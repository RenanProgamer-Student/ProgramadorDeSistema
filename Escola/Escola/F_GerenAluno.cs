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

        // Método para carregar os dados no DataGridView
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

        // Carregar os dados ao abrir o formulário
        private void F_GerenAluno_Load(object sender, EventArgs e)
        {
            CarregarAlunos();
        }

        // Filtro por nome
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            string filtroNome = tbxFiltroNome.Text;
            SqlConnection sql = new SqlConnection("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");
            string command = $"SELECT nome, cpf, dataNascimento FROM dbo.Alunos WHERE nome LIKE '%{filtroNome}%'";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(command, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvListaAlunos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aplicar filtro: " + ex.Message);
            }
        }

        // Preencher campos quando selecionar no DataGridView
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            tbxNome.Text = dgvListaAlunos.CurrentRow.Cells[0].Value.ToString();
            tbxCpf.Text = dgvListaAlunos.CurrentRow.Cells[1].Value.ToString();
            dtpDataNascimento.Text = dgvListaAlunos.CurrentRow.Cells[2].Value.ToString();
        }

        // Editar registro
        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            string cpfAntigo = dgvListaAlunos.CurrentRow.Cells[1].Value.ToString();
            SqlConnection conn = new SqlConnection("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");

            SqlCommand comand = new SqlCommand(
                "UPDATE dbo.Alunos SET nome = @nome, cpf = @cpf, dataNascimento = @dataNascimento WHERE cpf = @cpfAntigo", conn);

            try
            {
                comand.Parameters.AddWithValue("@nome", tbxNome.Text);
                comand.Parameters.AddWithValue("@cpf", tbxCpf.Text);
                comand.Parameters.AddWithValue("@dataNascimento", dtpDataNascimento.Text);
                comand.Parameters.AddWithValue("@cpfAntigo", cpfAntigo);

                conn.Open();
                comand.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Alteração feita com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualiza o DataGridView
                CarregarAlunos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar!\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Deletar registro
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string cpf = dgvListaAlunos.CurrentRow.Cells[1].Value.ToString();
                SqlConnection conn = new SqlConnection("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");

                SqlCommand comand = new SqlCommand("DELETE FROM dbo.Alunos WHERE cpf = @cpf", conn);

                try
                {
                    comand.Parameters.AddWithValue("@cpf", cpf);

                    conn.Open();
                    comand.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Deletado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza o DataGridView
                    CarregarAlunos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar!\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Você pode deixar o CellContentClick vazio ou usar para alguma ação futura
        private void dgvListaAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
