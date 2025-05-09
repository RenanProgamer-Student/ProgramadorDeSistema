namespace NumeroSequencial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //TI = Termo inicial
            int TI = Convert.ToInt32(tbxTI.Text);
            //IC = incremento
            int IC = Convert.ToInt32(tbxIC.Text);
            //qtd = quantidade
            int qtd = Convert.ToInt32(tbxQtd.Text);
            int total = TI;
            String frase = "";
            //int i;

            for (int i = 0; i < qtd; i++)
            {
                //total = TI + (IC * i);
                frase += $" {total}";
                total += IC;

            }
            lblResultado.Visible = true;
            lblResultado.Text = frase;
            
        }
    }
}
