namespace somaIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(tbxPessoas.Text);

            Random r = new Random();
            String frase = "";
            int total = 0;
            for (int i = 0; i < qtd; i++)
            {
                int idade = r.Next(1, 91);
                frase += idade + (i < qtd - 1 ? ", " : "");
                total += idade;
            }
                lblResultado.Text = $"Numero de pessoas selecionadas foram {frase}\n" +
                $"com a soma delas de: {total}";
        }
    }
}
