using System.Text;

namespace Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFator_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tbxNum.Text);

            int total = 1;
            String frase = "";

            for (int i = num; i > 0; i--)
            {
                total *= i;
                frase += (i == 1) ? $"{i}" : $"{i} x";
            }
                lblResultado.Text = $"{frase} = {total}";
            
        }
    }
}
