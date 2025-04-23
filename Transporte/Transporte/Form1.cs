namespace Transporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tipo = cbbTipo.Text;
            double distancia = Convert.ToDouble(tbxDistancia.Text);
            double preco;
            if (tipo == "Moto")
            {
                preco = distancia * 1;
                
            }
            else if (tipo == "Carro")
            {
                preco = distancia * 1.5;
            }
            else
            {
                preco = distancia * 2;
            }
            MessageBox.Show($"Foi confimado seu tipo {tipo} para viaem com o valor total de {preco}", "Confimação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
