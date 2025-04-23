namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String user = tbxUser.Text;
            String senha = tbxSenha.Text;
            // Operador && (E lógico condicional)
            // Retorna true somente se ambas as expressões forem verdadeiras.
            // Exemplo: condição1 && condição2
            // - Se condição1 for false, condição2 nem é avaliada (short-circuit).
            // - Usado para verificar múltiplas condições ao mesmo tempo.
            // Exemplo prático:
            if (user == "batata" && senha == "1234")
            {
                F_inicio janela = new F_inicio();
                janela.Show();    
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*
            if (user == "batata")
            {
                if (senha == "1234")
                {
                    F_inicio janela = new F_inicio();
                    janela.Show();
                }
                else 
                {
                    MessageBox.Show("Senha incorreta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User incorreto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

        }
    }
}
