namespace funcao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tbxNumero.Text);

            if (num < 10)
            {
                somar(num);
            }
            else
            {
                multiplicar(num);
            }
        }
        private void somar(int num)
        {
            lblResultado.Text = (num + 2).ToString();
        }

        private void multiplicar(int num)
        {
            lblResultado.Text = (num * 2).ToString();
        }
    }
}
