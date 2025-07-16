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
    public partial class F_ContratoProfessor : Form
    {
        public F_ContratoProfessor()
        {
            InitializeComponent();
        }
        private void F_ContratoProfessor_Load(object sender, EventArgs e)
        {
            //preencher cbxprofessor
            try
            {
                C_Professor c_Professor = new C_Professor();
                SqlDataReader reader = c_Professor.selecionarTodos();

                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string nome = reader["nome"].ToString();
                    string idNome = $"{id} - {nome}";
                    cbxProfessor.Items.Add(idNome);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }

            try
            {
                //Listar Turmas
                C_Turma c_Turma = new C_Turma();
                SqlDataReader reader = c_Turma.selecionarIdDiciplina();

                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string diciplina = reader["diciplina"].ToString();
                    string idDiciplina = $"{id} - {diciplina}";
                    cbxTurma.Items.Add(idDiciplina);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string[] partes = cbxProfessor.Text.Split('-');
            //remove os espaços em branco
            string idProfessor = partes[0].Trim();
            partes = cbxTurma.Text.Split('-');
            string idTurmas = partes[0].Trim();

            string remuneracao = tbxRemuneracao.Text.Trim();

            C_Contrato contrato = new C_Contrato();
            contrato.cadastrarContrato(idProfessor, idTurmas, remuneracao);

            //MessageBox.Show($"{idProfessor} {idTurmas}");

        }

        private void cbxProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
