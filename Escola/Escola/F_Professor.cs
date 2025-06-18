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
    public partial class F_Professor : Form
    {
        public F_Professor(Form1 f)
        {
            f.Visible = false;
            InitializeComponent();
        }
        private void CarregarAlunos()
        {
            SqlConnection sql = new SqlConnection("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");
            string command = "SELECT nome, cpf, dataNascimento FROM dbo.Alunos";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(command, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvListaAlunos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
        private void F_Professor_Load(object sender, EventArgs e)
        {
            CarregarAlunos();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CadastrarAluno janelaCDAluno = new F_CadastrarAluno();
            janelaCDAluno.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenAluno janelaGerenAluno = new F_GerenAluno();
            janelaGerenAluno.ShowDialog();

            
        }
    }
}
