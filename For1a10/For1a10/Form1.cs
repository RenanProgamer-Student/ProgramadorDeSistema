namespace For1a10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //Meu exemplo de fato\\
            /*
                String frase = "";
                for (int i = 1; i <= 10; i++)
                {
                    //o uso de "?" e ":" é operador ternário, um if e else compacto
                    frase += i == 1 ? $"{i}" : $", {i}";
                }
                lblResultado.Text = $"{frase }";
            */

            //AUla + meu exemplo\\
            /*
            lblResultado.Text = "";
            int qtd = Convert.ToInt32(tbxQuantidade.Text);
            String[] numeros = new string[qtd];
            for (int i = 0; i < qtd; i++)
            {
                numeros[i] = $"{i + 1}";
            }
            for (int i = 0; i < qtd; i++)
            {
                int n = Convert.ToInt32(numeros[i]) * 2;
                
                lblResultado.Text += n == 2 ? $"{n}" : $", {n}";
            }
            */

            lblResultado.Text = "";
            int qtd = Convert.ToInt32(tbxQuantidade.Text);
            int[] numeros1 = new int[qtd];
            int[] numeros2 = new int[qtd];
            Random rand = new Random();
            for (int i = 0; i < qtd; i++)
            {
                int num = rand.Next(1, 11);
                numeros1[i] = num;
            }
            for (int i = 0; i < qtd; i++)
            {
                numeros2[i] = numeros1[i] * 2;
            }
            for (int i = 0; i < qtd; i++)
            {
                lblResultado.Text += i == qtd - 1 ? $"{numeros2[i]}" : $"{numeros2[i]}, ";
            }


            //Da explicação da aula\\
            /*
                String[] numeros = new string[10];
                for (int i = 0; i < 10; i++)
                {
                    numeros[i] = $"{i + 1}";
                }
                for (int i = 0; i < 10; i++)
                {
                    lblResultado.text += numeros[i];
                }
            */
        }
    }
}
