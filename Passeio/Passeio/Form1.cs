namespace passeio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSugerir_Click(object sender, EventArgs e)
        {
            String clima = cbxClima.Text;
            double valor = Convert.ToDouble(tbxDinheiro.Text);

            F_Sugestao f_sugestao = new F_Sugestao(clima, valor);
            f_sugestao.ShowDialog();
        }
    }
}
