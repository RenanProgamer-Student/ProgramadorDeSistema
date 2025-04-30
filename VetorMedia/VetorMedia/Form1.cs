namespace VetorMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Desabilita os campos de nota ao iniciar
            tbxN1.Enabled = false;
            tbxN2.Enabled = false;
            tbxN3.Enabled = false;
            tbxN4.Enabled = false;
            
        }
        
        private void tbxNome_TextChanged(object sender, EventArgs e)
        {
            
            // Habilita os campos de nota quando o nome for preenchido
            bool habilitar = !string.IsNullOrWhiteSpace(tbxNome.Text);

            tbxN1.Enabled = habilitar;
            tbxN2.Enabled = habilitar;
            tbxN3.Enabled = habilitar;
            tbxN4.Enabled = habilitar;
            
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            string nome = tbxNome.Text;
            double[] notas = new double[4];
            notas[0] = Convert.ToDouble(tbxN1.Text);
            notas[1] = Convert.ToDouble(tbxN2.Text);
            notas[2] = Convert.ToDouble(tbxN3.Text);
            notas[3] = Convert.ToDouble(tbxN4.Text);

            double media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;
            

            /*
            TextBox[] notas = new TextBox[5];
            notas[0] = tbxN1;
            notas[1] = tbxN2;
            notas[2] = tbxN3;
            notas[3] = tbxN4;
            notas[4] = tbxMedia;
            notas[4].Text = Math.Round(((Convert.ToDouble(notas[0].Text) +
                              Convert.ToDouble(notas[1].Text) +
                              Convert.ToDouble(notas[2].Text) +
                              Convert.ToDouble(notas[3].Text)) / 4), 1).ToString();
            */
            
            if (media >= 7)
            {
                lblResultado.Visible = true;
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = $"O aluno {nome} \nPassou de Ano com a média: {Math.Round(media, 1)} em seu boletim";
            }
            else if (media >= 6)
            {
                lblResultado.Visible = true;
                lblResultado.ForeColor = Color.DarkOrange;
                lblResultado.Text = $"O aluno {nome} \nFicou de recuperação com a média: {Math.Round(media, 1)} em seu boletim";
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = $"O aluno {nome} \nRepetiu de Ano com a média: {Math.Round(media, 1)} em seu boletim";
            }
            
        }

    }
}
