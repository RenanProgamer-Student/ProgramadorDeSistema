using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public class C_Professor
    {
        C_Conexao c_Conexao = new C_Conexao();

        public SqlDataReader selecionarTodos()
        {
            SqlConnection conn = c_Conexao.abrirConxexao();
            string command = "SELECT id, (RTRIM(nome)) as nome from dbo.Professores";
            SqlDataReader reader = c_Conexao.selecionarDadosReader(command, conn);
            
            return reader;
        }
    }
}
