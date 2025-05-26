<<<<<<< HEAD
namespace Escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            String user = tbxUser.Text;
            String senha = tbxPass.Text;
            String perfil = cbxPerfil.Text;

            if (perfil == "Diretor")
            {
                F_Diretor f_Diretor = new F_Diretor(this);
                f_Diretor.ShowDialog();
                this.Close();
                
                
            }
        }
    }
}
=======
namespace Escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            String user = tbxUser.Text;
            String senha = tbxPass.Text;
            String perfil = cbxPerfil.Text;

            if (perfil == "Diretor")
            {
                F_Diretor f_Diretor = new F_Diretor(this);
                f_Diretor.ShowDialog();
                this.Close();
                
                
            }
        }
    }
}
>>>>>>> 4e2b252a2f0cfab5879d560deaf77c53b142be93
