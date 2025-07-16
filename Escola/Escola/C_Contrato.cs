using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Escola
{
    public class C_Contrato
    {
        private C_Conexao c_Conexao = new C_Conexao();
        public void cadastrarContrato(string idP, string idT, string R)
        {

            int idProF = Convert.ToInt32(idP);
            int idTur = Convert.ToInt32(idT);
            double re = Convert.ToDouble(R);

            SqlConnection conn = c_Conexao.abrirConxexao();

            String sql = "INSERT INTO T_Contratos (id_professor, id_turma, remuneracao) VALUES (@id_professor, @id_turma, @remuneracao)";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@id_professor", idProF));
                comando.Parameters.Add(new SqlParameter("@id_turma", idTur));
                comando.Parameters.Add(new SqlParameter("@remuneracao", re));

                string verificacao = c_Conexao.modficarDados(comando, conn);

                if (verificacao == "ok")
                {
                    MessageBox.Show("Contrato feito com Sucesso!", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possivel realizar essa ação!", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel realizar essa ação!\n" + ex.Message, "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fehcando a conexão
                conn.Close();

            }
        }

    }
}
