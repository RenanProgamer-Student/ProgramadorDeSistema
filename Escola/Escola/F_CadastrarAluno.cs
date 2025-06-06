using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class F_CadastrarAluno : Form
    {
        public F_CadastrarAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            //Conexão com o Banco de dados
            string strconn = ("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");
            SqlConnection conn = new SqlConnection(strconn);

            //Comando sql
            String sql = "INSERT INTO Alunos (nome, cpf, usuario, senha, salt, dataNascimento) VALUES(@nome, @cpf, @usuario, @senha, @salt, @dataNascimento)";


            try
            {

                String salt = PasswordHelper.GenerateSalt();
                String senhaHash = PasswordHelper.HashPassword(tbxSenhaAluno.Text, salt);
                //Adicionar parametros
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@cpf", tbxCpfAluno.Text));
                comando.Parameters.Add(new SqlParameter("@nome", tbxNomeAluno.Text));
                comando.Parameters.Add(new SqlParameter("@usuario", tbxUserAluno.Text));
                comando.Parameters.Add(new SqlParameter("@senha", senhaHash));
                comando.Parameters.Add(new SqlParameter("@salt", salt));
                comando.Parameters.Add(new SqlParameter("@dataNascimento", dtpDataNascimento.Text));
                
                //abrindo a conezão com o banco de dados
                conn.Open();
                //Executando o comando sql
                comando.ExecuteNonQuery();
                //conn.Close();
                MessageBox.Show("Aluno Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel cadastrar!\n" + ex.Message, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fehcando a conexão
                conn.Close();
            }
        }
    }
}
