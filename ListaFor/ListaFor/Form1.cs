namespace ListaFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = string.Empty;
            String nome = tbxNome.Text;
            int qtd = Convert.ToInt32(tbxVezes.Text);

            for (int i = 1; i <= qtd; i++)
            {

                lblResultado.Text += $"{i} - {nome}\n";
            }
        }

        private void btnSN_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            String frase = "";
            int total = 0;

            for (int i = 1; i <= 10; i++)
            {
                int num = r.Next(1, 101);
                total += num;
                frase += num;
                frase += (i < 10) ? $" ," : $" = {total}";
            }

            double media = total / 10;
            lblResultado.Text = $"{frase} Com a média é {media}";
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int cont = 0;
            for (int i = 1; i <= 20; i++)
            {
                int num = r.Next(1, 100);
                if (num >= 18)
                {
                    cont++;
                }
            }
            lblResultado.Text = cont.ToString();
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            int[] idades = { 34, 22, 67, 15, 81, 49, 19, 28, 73, 90 };
            int menor = idades[0];

            for (int i = 1; i < idades.Length; i++)
            {
                if (idades[i] < menor)
                {
                    menor = idades[i];
                }
            }
            lblResultado.Text = menor.ToString();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int cont = 0;
            for (int i = 0; i <= 20; i++)
            {
                int num = r.Next(0, 201);
                if (num >= 0 && num <= 100)
                {
                    cont++;
                }
            }
            lblResultado.Text = cont.ToString();
        }
    }
}
