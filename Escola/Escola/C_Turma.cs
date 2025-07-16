using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public class C_Turma
    {
        private C_Conexao c_Conexao = new C_Conexao();


        public void CadastrarTurma(string d, DateTimePicker hi, DateTimePicker hf, string s)
        {
            SqlConnection conn = c_Conexao.abrirConxexao();

            String sql = "INSERT INTO T_Turmas (diciplina, horarioinicial, horariofinal, sala) VALUES(@diciplina, @horarioinicial, @horariofinal, @sala)";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@diciplina", d));
                comando.Parameters.Add(new SqlParameter("@horarioinicial", hi.Text));
                comando.Parameters.Add(new SqlParameter("@horariofinal", hf.Text));
                comando.Parameters.Add(new SqlParameter("@sala", s));

                string verificacao = c_Conexao.modficarDados(comando, conn);

                if (verificacao == "ok")
                {
                    MessageBox.Show("Aluno Cadastrado dentro de Tuma com Sucesso!", "Cadastro de Turma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possivel cadastrar!", "Cadastro de Turma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel cadastrar!\n" + ex.Message, "Cadastro de Turma", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string command = "SELECT (RTRIM(diciplina)) as Diciplina, horarioinicial as 'Horário Inicial', horariofinal as 'Horário Final', (RTRIM(sala)) as Sala FROM dbo.T_Turmas";

            SqlDataAdapter da = c_Conexao.selecionarDados(command, conn);
           
            return da;

        }
        public SqlDataReader selecionarIdDiciplina()
        {
            SqlConnection conn = c_Conexao.abrirConxexao();
            string command = "SELECT id, (RTRIM(diciplina)) as diciplina FROM dbo.T_Turmas";

            SqlDataReader reader = c_Conexao.selecionarDadosReader(command, conn);

            return reader;
        }

        
    }
}
