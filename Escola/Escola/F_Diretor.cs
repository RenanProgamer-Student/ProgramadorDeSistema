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
    public partial class F_Diretor : Form
    {
        public F_Diretor(Form1 f)
        {
            InitializeComponent();
            f.Visible = false;
        }
        private void CarregarContratos()
        {
            C_Contrato c_contrato = new C_Contrato();
            try
            {
                SqlDataAdapter da = c_contrato.selecionarTodos();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvListaContratos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void F_Diretor_Load(object sender, EventArgs e)
        {

        }
        /*
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           F_CadastrarProf janelaCadastrarProf = new F_CadastrarProf();
            janelaCadastrarProf.ShowDialog();
        }
        */
        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            F_CadastrarProf janelaCadastrarProf = new F_CadastrarProf();
            janelaCadastrarProf.ShowDialog();
        }

        private void professorTSMI_Click(object sender, EventArgs e)
        {
            F_ContratoProfessor f_ContratoProfessor = new F_ContratoProfessor();
            f_ContratoProfessor.ShowDialog();
        }

        private void gerenciarToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            if (!dgvListaContratos.Visible)
            {
                dgvListaContratos.Visible = true;
                btnFechar.Visible = true;
                CarregarContratos();
            }
        }
        
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            dgvListaContratos.Visible = false;
            btnFechar.Visible = false;
        }
    }
}
