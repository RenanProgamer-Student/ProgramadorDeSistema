using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public class C_Aluno
    {
        //ATRIBUTOS SERÃO PRIVADOS
        private int id;
        private string nome;
        private string cpf;
        private string usuario;
        private string senha;
        private string salt;
        private DateTimePicker dataNascimento;
        private C_Conexao c_Conexao = new C_Conexao();

        //MÉTODOS
        public void CadastrarAluno(string n, string c, string u, string se, DateTimePicker dn)
        {
                                                //Conexão com o Banco de dados
                
            SqlConnection conn = c_Conexao.abrirConxexao();

                                                //Comando sql
            String sql = "INSERT INTO Alunos (nome, cpf, usuario, senha, salt, dataNascimento) VALUES(@nome, @cpf, @usuario, @senha, @salt, @dataNascimento)";


            try
            {

                String salt = PasswordHelper.GenerateSalt();
                String senhaHash = PasswordHelper.HashPassword(se, salt);
                //Adicionar parametros
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@nome", n));
                comando.Parameters.Add(new SqlParameter("@cpf", c));
                comando.Parameters.Add(new SqlParameter("@usuario", u));
                comando.Parameters.Add(new SqlParameter("@senha", senhaHash));
                comando.Parameters.Add(new SqlParameter("@salt", salt));
                comando.Parameters.Add(new SqlParameter("@dataNascimento", dn.Text));

                string verificacao = c_Conexao.modficarDados(comando, conn);

                if (verificacao == "ok")
                {
                    MessageBox.Show("Aluno Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possivel cadastrar!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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

        public SqlDataAdapter selecionarTodos()
        {
                SqlConnection conn = c_Conexao.abrirConxexao();
                string command = "SELECT (RTRIM(nome)) as nome, cpf, dataNascimento as 'Data de Nascimento' FROM dbo.Alunos";

                SqlDataAdapter da = c_Conexao.selecionarDados(command, conn);
                conn.Close();
                return da;
            
        }

        public SqlDataReader selecionarNome()
        {
            SqlConnection conn = c_Conexao.abrirConxexao();
            string command = "SELECT (RTRIM(nome)) as nome FROM dbo.Alunos";
            SqlDataReader reader = c_Conexao.selecionarDadosReader(command, conn);
            return reader;
        }


        public SqlDataAdapter FiltrarNomes(string filtroNome)
        {
            SqlConnection conn = c_Conexao.abrirConxexao();
            string command = $"SELECT (RTRIM(nome)), cpf, dataNascimento FROM dbo.Alunos WHERE nome LIKE '%{filtroNome}%'";
            SqlDataAdapter da = c_Conexao.selecionarDados(command, conn);
            conn.Close();
            return da;
        }
    }
}
