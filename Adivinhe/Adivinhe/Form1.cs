namespace Adivinhe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNumero.Text))
            {
                MessageBox.Show("Por favor, digite um número válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbxNumero.Text, out int numero))
            {
                MessageBox.Show("Digite apenas números.", "Erro de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxNumero.Clear();
                return;
            }
            int creditos = Convert.ToInt32(tbxCreditos.Text);
            if (creditos > 0)
            {
                Random random = new Random();
                int NmAdv = random.Next(1, 11);

                if (NmAdv == numero)
                {
                    lblResultado.Visible = true;
                    lblResultado.ForeColor = Color.Green;
                    creditos += 5;
                    lblResultado.Text = "Você acertou o numero, Parabéns, você ganhou + 5 Credtios";

                }
                else
                {
                    lblResultado.Visible = true;
                    lblResultado.ForeColor = Color.Red;
                    creditos -= -1;
                    lblResultado.Text = "Você Errou o numero, que pena, tente mais uma vez";
                }
                tbxNumero.Clear();
                tbxCreditos.Text = creditos.ToString();
            }
            else
            {
                tbxNumero.Enabled = false;
                lblResultado.Text = "Você ficou sem Creditos, Recarregue agora para ter mais 5 creditos extras\n" +
                    "usando o pix, agora!!";

            }
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            F_Recarregar janelaRecarregar = new F_Recarregar();
            if (janelaRecarregar.ShowDialog() == DialogResult.OK)
            {
                int creditoAtual = Convert.ToInt32(tbxCreditos.Text);
                creditoAtual = creditoAtual +  janelaRecarregar.creditos;
                tbxCreditos.Text = creditoAtual.ToString();
            }
        }
    }
}
