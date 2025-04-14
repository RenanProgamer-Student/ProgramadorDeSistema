using System.Text;

namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool TryGetInputs(out double N1)
        {
            bool validN1 = double.TryParse(tbxN1.Text, out N1);


            if (!validN1)
            {
                MessageBox.Show("Por favor, insira números válidos.");
                return false;
            }

            return true;
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {

            if (TryGetInputs(out double N1))
            {
                lblResultado.Visible = true;
                lblResultado.Text = (
                    $"{N1} + 1 = {N1 + 1}\n" +
                    $"{N1} + 2 = {N1 + 2}\n" +
                    $"{N1} + 3 = {N1 + 3}\n" +
                    $"{N1} + 4 = {N1 + 4}\n" +
                    $"{N1} + 5 = {N1 + 5}\n" +
                    $"{N1} + 6 = {N1 + 6}\n" +
                    $"{N1} + 7 = {N1 + 7}\n" +
                    $"{N1} + 8 = {N1 + 8}\n" +
                    $"{N1} + 9 = {N1 + 9}\n" +
                    $"{N1} + 10 = {N1 + 10}\n");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double N1))
            {
                lblResultado.Visible = true;
                lblResultado.Text = (
                    $"{N1} - 1 = {N1 - 1}\n" +
                    $"{N1} - 2 = {N1 - 2}\n" +
                    $"{N1} - 3 = {N1 - 3}\n" +
                    $"{N1} - 4 = {N1 - 4}\n" +
                    $"{N1} - 5 = {N1 - 5}\n" +
                    $"{N1} - 6 = {N1 - 6}\n" +
                    $"{N1} - 7 = {N1 - 7}\n" +
                    $"{N1} - 8 = {N1 - 8}\n" +
                    $"{N1} - 9 = {N1 - 9}\n" +
                    $"{N1} - 10 = {N1 - 10}\n");
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double N1))
            {
                lblResultado.Visible = true;
                lblResultado.Text = (
                    $"{N1} * 1 = {N1 * 1}\n" +
                    $"{N1} * 2 = {N1 * 2}\n" +
                    $"{N1} * 3 = {N1 * 3}\n" +
                    $"{N1} * 4 = {N1 * 4}\n" +
                    $"{N1} * 5 = {N1 * 5}\n" +
                    $"{N1} * 6 = {N1 * 6}\n" +
                    $"{N1} * 7 = {N1 * 7}\n" +
                    $"{N1} * 8 = {N1 * 8}\n" +
                    $"{N1} * 9 = {N1 * 9}\n" +
                    $"{N1} * 10 = {N1 * 10}\n");
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double N1))
            {
                lblResultado.Visible = true;
                lblResultado.Text = (
                    $"{N1} / 1 = {(N1 / 1).ToString("F1")}\n" +
                    $"{N1} / 2 = {(N1 / 2).ToString("F1")}\n" +
                    $"{N1} / 3 = {(N1 / 3).ToString("F1")}\n" +
                    $"{N1} / 4 = {(N1 / 4).ToString("F1")}\n" +
                    $"{N1} / 5 = {(N1 / 5).ToString("F1")}\n" +
                    $"{N1} / 6 = {(N1 / 6).ToString("F1")}\n" +
                    $"{N1} / 7 = {(N1 / 7).ToString("F1")}\n" +
                    $"{N1} / 8 = {(N1 / 8).ToString("F1")}\n" +
                    $"{N1} / 9 = {(N1 / 9).ToString("F1")}\n" +
                    $"{N1} / 10 = {(N1 / 10).ToString("F1")}\n");
            }
        }
    }
}
