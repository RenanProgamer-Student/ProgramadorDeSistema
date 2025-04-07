namespace CinemaInterfaceAula3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl1.BackColor = Color.Transparent;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(tbxPreco.Text);
            double qtd = Convert.ToDouble(tbxQuantidade.Text);

            lblFaturamento.Visible = true;
            tbxFaturamento.Visible = true;
            double total = preco * qtd;

            //pegando o total converte para o texto e inserir no tbxFaturamento
            tbxFaturamento.Text = total.ToString();

            if (total >= 500)
            {
                tbxFaturamento.ForeColor = Color.Green;
            }
            else
            {
                 tbxFaturamento.ForeColor= Color.Red;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
