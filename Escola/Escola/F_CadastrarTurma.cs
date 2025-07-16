using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class F_CadastrarTurma : Form
    {
        public F_CadastrarTurma()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            C_Turma c_turma = new C_Turma();
            c_turma.CadastrarTurma(tbxDiciplina.Text, dtpHi, dtpHf, tbxSala.Text);
            Close();
        }
    }
}
