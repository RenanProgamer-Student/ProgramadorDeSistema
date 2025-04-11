namespace jogoRPG
{
    public partial class Form1 : Form
    {
        int defesaJ1 = 0;
        int defesaJ2 = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAttJ1_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //diminuir os pontos de vida do jogador 2
            //dano = ataquej1 - desegaj2
            int dano = 15 - defesaJ2;
            //vidaJ2 = VidaJ2 - dano
            int vidaJ2 = Convert.ToInt32(tbxVidaJ2.Text);
            int vidaJ1 = Convert.ToInt32(tbxVidaJ1.Text);



            tbxVidaJ2.Text = (vidaJ2 - dano).ToString();
            if (vidaJ2 < 0)
            {
                MessageBox.Show("Joagdor 1 ganhou", "Vitória", MessageBoxButtons.OK);
                btnAttJ1.Enabled = false;
                btnDfsJ1.Enabled = false;
                btnAttJ2.Enabled = false;
                btnDfsJ2.Enabled = false;
                this.Close();
                return;
            }
            else if (vidaJ1 < 0)
            {
                MessageBox.Show("Joagdor 1 Perdeu", "Derrota", MessageBoxButtons.OK);
                btnAttJ1.Enabled = false;
                btnDfsJ1.Enabled = false;
                btnAttJ2.Enabled = false;
                btnDfsJ2.Enabled = false;
                this.Close();
                return;
            }

            //bloquear os botões do jogador 1
            btnAttJ1.Enabled = false;
            btnDfsJ1.Enabled = false;
            //desbloquear os botões do jogador 2
            btnAttJ2.Enabled = true;
            btnDfsJ2.Enabled = true;

            defesaJ2 = 0;


        }

        private void btnAttJ2_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            int dano = 12 - defesaJ1;
            int vidaJ2 = Convert.ToInt32(tbxVidaJ2.Text);
            int vidaJ1 = Convert.ToInt32(tbxVidaJ1.Text);
            tbxVidaJ1.Text = (vidaJ1 - dano).ToString();


            if (vidaJ1 < 0)
            {
                MessageBox.Show("Joagdor 2 ganhou", "Vitória", MessageBoxButtons.OK);
                btnAttJ1.Enabled = false;
                btnDfsJ1.Enabled = false;
                btnAttJ2.Enabled = false;
                btnDfsJ2.Enabled = false;
                this.Close();
                return;
            }
            else if (vidaJ2 < 0)
            {
                MessageBox.Show("Joagdor 2 Perdeu", "Derrota", MessageBoxButtons.OK);
                btnAttJ1.Enabled = false;
                btnDfsJ1.Enabled = false;
                btnAttJ2.Enabled = false;
                btnDfsJ2.Enabled = false;
                this.Close();
                return;
            }


            btnAttJ2.Enabled = false;
            btnDfsJ2.Enabled = false;
            btnAttJ1.Enabled = true;
            btnDfsJ1.Enabled = true;

            //defesa do jogador 1 volte ao padrão
            defesaJ1 = 0;
        }

        private void btnDfsJ1_Click(object sender, EventArgs e)
        {
            //mudar a defesa do jogador 1
            defesaJ1 = 5;
            //bloquear os botões do jogador 1
            btnAttJ1.Enabled = false;
            btnDfsJ1.Enabled = false;
            //desbloquear os botões do jogador 2
            btnAttJ2.Enabled = true;
            btnDfsJ2.Enabled = true;

        }

        private void btnDfsJ2_Click(object sender, EventArgs e)
        {
            //mudar a defesa do jogador 2
            defesaJ2 = 20;
            //bloquear os botões do jogador 2
            btnAttJ2.Enabled = false;
            btnDfsJ2.Enabled = false;
            //desbloquear os botões do jogador 1
            btnAttJ1.Enabled = true;
            btnDfsJ1.Enabled = true;
        }
    }


}
