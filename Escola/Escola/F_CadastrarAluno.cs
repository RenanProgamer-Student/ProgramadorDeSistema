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
    public partial class F_CadastrarAluno : Form
    {
        public F_CadastrarAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            
            C_Aluno c_Aluno = new C_Aluno();
            c_Aluno.CadastrarAluno(tbxNomeAluno.Text, tbxCpfAluno.Text, tbxUserAluno.Text, tbxSenhaAluno.Text, dtpDataNascimento);
            
        }
    }
}
