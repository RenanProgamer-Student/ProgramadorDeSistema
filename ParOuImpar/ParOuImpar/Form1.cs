namespace ParOuImpar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = string.Empty;
            int qtd = Convert.ToInt32(tbxQtd.Text);
            int[] num = new int[qtd];
            Random r = new Random();
            String frase = "";
            int j;
            int contP = 0;
            int contI = 0;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = r.Next(1, 11);
                j = num[i] % 2 == 0 ? contP++ : contI++;

                frase += num[i] % 2 == 0 ? $"{num[i]} é par.\n" : $"{num[i]} é impar.\n";
                /*
                //O simbolo % ira pegar o resto da divisão e é possivel fazer uma verificação dentro do if como mostra nesse caso.
                if (num[i] % 2 == 0)
                {
                    lblResultado.Text += $"{num[i]} é par.\n";
                }
                else
                {
                    lblResultado.Text += $"{num[i]} é impar.\n";
                }
                */

            }
            lblResultado.Text = $"Par: {contP}, Impar: {contI}\n{frase}";

        }
    }
}
