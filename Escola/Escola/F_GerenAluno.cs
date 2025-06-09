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
    public partial class F_GerenAluno : Form
    {
        public F_GerenAluno()
        {
            InitializeComponent();
        }
        private void F_GerenAluno_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");

            String command = "Select nome, cpf, dataNascimento from dbo.Alunos";
            try
            {
                //executa um comando SQL e recebendo dados
                SqlDataAdapter da = new SqlDataAdapter(command, sql);
                //instancia um DataTable - que servirá de intermediáro
                DataTable dt = new DataTable();
                //preencher o dt com os dados presente no da
                da.Fill(dt);
                //preencher o dataGridView com os dados do dt
                dgvListaAlunos.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel visualizar!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvListaAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
