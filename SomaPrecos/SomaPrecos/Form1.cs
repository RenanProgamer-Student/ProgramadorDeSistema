using System.Text;

namespace SomaPrecos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            int qtd = Convert.ToInt32(tbxQuantidade.Text);

            double[] preco = new double[qtd];
            Random r = new Random();
            String frase = "";
            double total = 0;
            int i;
            for ( i = 0; i < qtd; i++)
            {
                preco[i] = r.NextDouble() * (100 - 1) + 1;
                frase += $" {Math.Round(preco[i], 2)} \n";
                total += preco[i];
            }
                lblResultado.Visible = true;
                lblResultado.Text = $"{frase} = {Math.Round(total, 2)}";
            
            //-----------------CHAT GPT-------------------\\
            /*
            int qtd = Convert.ToInt32(tbxQuantidade.Text);
            Random r = new Random();
            double total = 0;
            var sb = new StringBuilder();

            for (int i = 0; i < qtd; i++)
            {
                double preco = Math.Round(r.NextDouble() * 99 + 1, 2); // entre 1 e 100
                sb.Append(preco.ToString("F2")).Append(" ");
                total += preco;
            }

            lblResultado.Visible = true;
            lblResultado.Text = $"{sb}= {total.ToString("F2")}";
            */
        }
    }
}
