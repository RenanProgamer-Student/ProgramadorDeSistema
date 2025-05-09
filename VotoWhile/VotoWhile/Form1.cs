namespace VotoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            String c1 = Convert.ToString(tbxCandidato1.Text);
            String c2 = Convert.ToString(tbxCandidato2.Text);
            
            int cont1 = 0;
            int cont2 = 0;
            
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                int num = r.Next(1, 3);
                if (num == 1)
                {
                    cont1++;
                }
                else if (num == 2)
                {
                    cont2++;
                }

            }
            
            if (cont1 > cont2)
            {
                lblResultado.Text = $"{c1}: {cont1} e {c2}: {cont2}, {c1} Venceu";
            }
            else if(cont1 < cont2)
            {
                lblResultado.Text = $"{c1}: {cont1} e {c2}: {cont2}, {c2} Venceu";
            }
            else
            {
                lblResultado.Text = $"{c1}: {cont1} e {c2}: {cont2}, ocorreu um empate";
            }
        }

    }
}
