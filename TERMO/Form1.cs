namespace TERMO
{
    public partial class Form1 : Form
    {
        // Vetor com 50 palavras
        String[] palavras = { "carta", "vento", "pluma", "festa", "nuvem", "tigre", "verde", "ramos", "folha", "bravo", "luzes", "mares", "solar", "chove", "flora", "pazao", "fogao", "noite", "diasa", "ceusa", "terro", "vidas", "amora", "risos", "sonho", "luaes", "estao", "venta", "cores", "tempo", "artes", "ponti", "linha", "formo", "vazio", "cheio", "altos", "baixo", "longe", "perto", "frios", "quente", "doces", "salga", "lento", "rapid", "claro", "escuro", "forte", "fraco" };

        String termo;
        int contLinhas = 0;
        TextBox[,] textBoxes = new TextBox[6, 5];

        public Form1()
        {
            InitializeComponent();
            textBoxes[0, 0] = tbx1_1;
            textBoxes[0, 1] = tbx1_2;
            textBoxes[0, 2] = tbx1_3;
            textBoxes[0, 3] = tbx1_4;
            textBoxes[0, 4] = tbx1_5;
            textBoxes[1, 0] = tbx2_1;
            textBoxes[1, 1] = tbx2_2;
            textBoxes[1, 2] = tbx2_3;
            textBoxes[1, 3] = tbx2_4;
            textBoxes[1, 4] = tbx2_5;
            textBoxes[2, 0] = tbx3_1;
            textBoxes[2, 1] = tbx3_2;
            textBoxes[2, 2] = tbx3_3;
            textBoxes[2, 3] = tbx3_4;
            textBoxes[2, 4] = tbx3_5;
            textBoxes[3, 0] = tbx4_1;
            textBoxes[3, 1] = tbx4_2;
            textBoxes[3, 2] = tbx4_3;
            textBoxes[3, 3] = tbx4_4;
            textBoxes[3, 4] = tbx4_5;
            textBoxes[4, 0] = tbx5_1;
            textBoxes[4, 1] = tbx5_2;
            textBoxes[4, 2] = tbx5_3;
            textBoxes[4, 3] = tbx5_4;
            textBoxes[4, 4] = tbx5_5;
            textBoxes[5, 0] = tbx6_1;
            textBoxes[5, 1] = tbx6_2;
            textBoxes[5, 2] = tbx6_3;
            textBoxes[5, 3] = tbx6_4;
            textBoxes[5, 4] = tbx6_5;

            // Bloqueia todas as linhas exceto a primeira
            for (int linha = 1; linha < 6; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    textBoxes[linha, coluna].Enabled = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ResetGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Char[] letras = new char[5];

            // Captura as letras digitadas na linha atual
            for (int coluna = 0; coluna < 5; coluna++)
            {
                if (textBoxes[contLinhas, coluna] != null)
                {
                    letras[coluna] = Convert.ToChar(textBoxes[contLinhas, coluna].Text);
                }
            }

            // Verificar se a letra está na palavra
            for (int coluna = 0; coluna < letras.Length; coluna++)
            {
                for (int j = 0; j < termo.Length; j++)
                {
                    if (letras[coluna] == termo[j])
                    {
                        textBoxes[contLinhas, coluna].BackColor = Color.Yellow;
                    }
                }
            }

            // Verificar se a letra está no local correto
            for (int coluna = 0; coluna < letras.Length; coluna++)
            {
                if (letras[coluna] == termo[coluna])
                {
                    textBoxes[contLinhas, coluna].BackColor = Color.Green;
                }
            }

            // Verificar se o usuário acertou a palavra
            int acertos = 0;
            for (int coluna = 0; coluna < letras.Length; coluna++)
            {
                if (letras[coluna] == termo[coluna])
                {
                    acertos++;
                }
            }

            if (acertos == 5)
            {
                MessageBox.Show("Você ganhou", "TERMO", MessageBoxButtons.OK);
            }
            else if (contLinhas < 5)
            {
                // Bloqueia a linha atual
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if (textBoxes[contLinhas, coluna] != null)
                    {
                        textBoxes[contLinhas, coluna].ReadOnly = true;
                    }
                }

                //avança para próxima linha
                contLinhas++;

                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if (textBoxes[contLinhas, coluna] != null)
                    {
                        textBoxes[contLinhas, coluna].Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Você perdeu", "Termo", MessageBoxButtons.OK);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            
            for (int linha = 0; linha < 6; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    textBoxes[linha, coluna].Text = "";
                    textBoxes[linha, coluna].BackColor = Color.FromArgb(97, 84, 88);
                    textBoxes[linha, coluna].ReadOnly = false;
                    textBoxes[linha, coluna].Enabled = (linha == 0);
                }
            }
            
            // Gerar número aletorio entre 0 e 49
            Random random = new Random();
            int indicePalavra = random.Next(0, 50);
            //Definir o termo
            termo = palavras[indicePalavra];
            //lblTeste.Text = termo;
            //lblTeste.Visible = true;

            contLinhas = 0;
        }
    }
}
