namespace VetorFut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbxVT.Enabled = false;
            tbxEM.Enabled = false;
            tbxDE.Enabled = false;
            tbxVT2.Enabled = false;
            tbxEM2.Enabled = false;
            tbxDE2.Enabled = false;
        }
        private void tbxNomeTM_TextChanged(object sender, EventArgs e)
        {
            bool habilitar = !string.IsNullOrWhiteSpace(tbxNomeTM.Text);

            tbxVT.Enabled = true;
            tbxEM.Enabled = true;
            tbxDE.Enabled = true;

        }
        private void tbxTimeNM2_TextChanged(object sender, EventArgs e)
        {
            tbxVT2.Enabled = true;
            tbxEM2.Enabled = true;
            tbxDE2.Enabled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String nome = tbxNomeTM.Text;
            String nome2 = tbxTimeNM2.Text;

            if (String.IsNullOrEmpty(nome) && String.IsNullOrEmpty(nome2))
            {
                MessageBox.Show("Por favor digite o Nome do time!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                if (string.IsNullOrWhiteSpace(tbxVT.Text) || string.IsNullOrWhiteSpace(tbxEM.Text) || string.IsNullOrWhiteSpace(tbxDE.Text) || string.IsNullOrWhiteSpace(tbxVT2.Text) || string.IsNullOrWhiteSpace(tbxEM2.Text) || string.IsNullOrWhiteSpace(tbxDE2.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos de pontos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int[] pontos = new int[6];
                pontos[0] = Convert.ToInt32(tbxVT.Text);
                pontos[1] = Convert.ToInt32(tbxEM.Text);
                pontos[2] = Convert.ToInt32(tbxDE.Text);
                pontos[3] = Convert.ToInt32(tbxVT2.Text);
                pontos[4] = Convert.ToInt32(tbxEM2.Text);
                pontos[5] = Convert.ToInt32(tbxDE2.Text);

                int total = (pontos[0] * 3) + (pontos[1] * 1);
                int total2 = (pontos[3] * 3) + (pontos[4] * 1);

                if (total > total2)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = $"O total de pontos do Time: {nome} é maior que do Time: {nome2}\n {nome} fez um total de {total} e {nome2} fez o total de {total2}";

                }
                else
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = $"O total de pontos do Time: {nome2} é maior que do Time: {nome}\n {nome} fez um total de {total} e {nome2} fez o total de {total2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Digite apenas números nos campos de pontos (Vitórias, Empates, Derrotas).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
