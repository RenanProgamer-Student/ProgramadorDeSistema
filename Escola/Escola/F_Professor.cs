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
            C_Aluno c_Aluno = new C_Aluno();

            try
            {
                SqlDataAdapter da = c_Aluno.selecionarTodos();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvListaAlunos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void CarregarTurmas()
        {
            C_Turma c_turma = new C_Turma();

            try
            {
                SqlDataAdapter da = c_turma.selecionarTodos();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTurmas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
        private void F_Professor_Load(object sender, EventArgs e)
        {
            CarregarAlunos();
            CarregarTurmas();
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarAlunos();
            CarregarTurmas();
        }

        private void CadastrarTSMI_Click(object sender, EventArgs e)
        {
            F_CadastrarTurma janelaCadastrarTurma = new F_CadastrarTurma();
            janelaCadastrarTurma.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dgvListaAlunos.Visible)
            {
                dgvListaAlunos.Visible = true;
                btnFechar.Visible = true;
                CarregarAlunos();
            }
            
        }
        private void listaTSMI_Click(object sender, EventArgs e)
        {
            if (!dgvTurmas.Visible)
            {
                dgvTurmas.Visible = true;
                btnFechar.Visible = true;
                CarregarTurmas();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (dgvListaAlunos.Visible)
            {
                dgvListaAlunos.Visible = false;
                btnFechar.Visible = false;
            }
            if (dgvTurmas.Visible)
            {
                dgvTurmas.Visible = false;
                btnFechar.Visible = false;
            }
        }

    }
}
