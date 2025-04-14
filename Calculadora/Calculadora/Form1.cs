namespace Calculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //TryGetInputs é usado para validar a entrada caso for de "123" e nn para "abc" ná matematica
        private bool TryGetInputs(out double N1, out double N2)
        {
            //TryParse Tenta converter uma string em double.
            bool validN1 = double.TryParse(tbxN1.Text, out N1);
            bool validN2 = double.TryParse(tbxN2.Text, out N2);

            // || Ele avalia duas expressões booleanas (verdadeiras ou falsas) e retorna:
            if (!validN1 || !validN2)
            {
                MessageBox.Show("Por favor, insira números válidos.");
                return false;
            }

            return true;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double N1, out double N2))
            {
                tbxResultado.Text = (N1 + N2).ToString();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double N1, out double N2))
            {
                tbxResultado.Text = (N1 - N2).ToString();
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double N1, out double N2))
            {
                tbxResultado.Text = (N1 * N2).ToString();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double N1, out double N2))
            {
                if (N2 == 0)
                {
                    tbxResultado.Text = "Erro: Divisão por zero";
                }
                else
                {
                    tbxResultado.Text = (N1 / N2).ToString();
                }
            }
        }
    }
}
