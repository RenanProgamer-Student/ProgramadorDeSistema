using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Escola
{
    public class C_Conexao
    {
                                        //MÉTODOS
        public SqlConnection abrirConxexao()
        {
            string strconn = ("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");
            SqlConnection conn = new SqlConnection(strconn);
            return conn;

        }

        public string modficarDados(SqlCommand c, SqlConnection conn) 
        {
            try
            {
                                        //abrindo a conezão com o banco de dados
                conn.Open();
                                        //Executando o comando sql
                c.ExecuteNonQuery();
                conn.Close();
                return "ok";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão inesperada!\n" + ex.Message, "Erro de modFicarDados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "erro";
            }
        }
    }
}
