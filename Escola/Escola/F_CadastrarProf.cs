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
    public partial class F_CadastrarProf : Form
    {
        public F_CadastrarProf()
        {
            InitializeComponent();
        }

        private void F_CadastrarProf_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            //Conexão com o Banco de dados
            string strconn = ("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");
            SqlConnection conn = new SqlConnection(strconn);

            //Comando sql
            String sql = "INSERT INTO Professores (nome, cpf, usuario, senha, dataAdmissao, segmento) VALUES(@nome, @cpf, @usuario, @senha, @dataAdmissao, @segmento)";


            try
            {
                //Adicionar parametros
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@cpf", tbxCpf.Text));
                comando.Parameters.Add(new SqlParameter("@nome", tbxNome.Text));
                comando.Parameters.Add(new SqlParameter("@usuario", tbxUser.Text));
                comando.Parameters.Add(new SqlParameter("@senha", tbxSenha.Text));
                comando.Parameters.Add(new SqlParameter("@dataAdmissao", dtpData.Text));
                comando.Parameters.Add(new SqlParameter("@segmento", cbxSegmento.Text));

                //abrindo a conezão com o banco de dados
                conn.Open();
                //Executando o comando sql
                comando.ExecuteNonQuery();
                //conn.Close();
                MessageBox.Show("Professro Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
