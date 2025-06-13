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
                this.Controls.Add(dgvListaAlunos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel visualizar!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvListaAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            String FiltroNome = tbxFiltroNome.Text;

            SqlConnection sql = new SqlConnection("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");
            String command = $"Select nome, cpf, dataNascimento from dbo.Alunos WHERE nome LIKE '%{FiltroNome}%'";

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
                this.Controls.Add(dgvListaAlunos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel visualizar!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            tbxNome.Text = dgvListaAlunos.CurrentRow.Cells[0].Value.ToString();
            tbxCpf.Text = dgvListaAlunos.CurrentRow.Cells[1].Value.ToString();
            dtpDataNascimento.Text = dgvListaAlunos.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            String cpf = dgvListaAlunos.CurrentRow.Cells[1].Value.ToString();
            SqlConnection conn = new SqlConnection("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");

            SqlCommand comand = new SqlCommand($"UPDATE dbo.Alunos SET nome = @nome, cpf = @cpf, dataNascimento = @dataNascimento WHERE cpf = '{cpf}'", conn);

            try
            {
                comand.Parameters.Add(new SqlParameter("@cpf", tbxCpf.Text));
                comand.Parameters.Add(new SqlParameter("@nome", tbxNome.Text));
                comand.Parameters.Add(new SqlParameter("@dataNascimento", dtpDataNascimento.Text));

                conn.Open();
                comand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Auteração feita com Sucesso!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel concluir a ação!\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
