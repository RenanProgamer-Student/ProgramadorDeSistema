namespace soma1a15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int total = 0;
            String frase = "";

            for (int i = 1; i <= 15; i++)
            {
                total += i;
                if (i == 10)
                {
                    frase += $"{i} + \n";
                }
                else if (i == 15)
                {
                    frase += $"{i}";
                }
                else
                {
                    frase += $"{i} +";
                }

            }
            lblResultado.Text = $"{frase} = {total}";
        }
    }
}
