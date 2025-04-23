namespace calculadora_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(tbxN1.Text);
            double N2 = Convert.ToDouble(tbxN2.Text);
            String operador = cbxOperador.Text;
            if (operador == "Soma")
            {
                double resultado = N1 + N2;
                tbxResultado.Text = resultado.ToString();
            }
            else if (operador == "Subtração")
            {
                double resultado = N1 - N2;
                tbxResultado.Text = resultado.ToString();
            }
            else if (operador == "Multiplicação")
            {
                double resultado = N1 * N2;
                tbxResultado.Text = resultado.ToString();
            }
            else if (operador == "Divisão")
            {
                double resultado = N1 / N2;
                tbxResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Erro, Sem operador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
