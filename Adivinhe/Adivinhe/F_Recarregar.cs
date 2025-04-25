using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adivinhe
{
    public partial class F_Recarregar : Form
    {
        public F_Recarregar()
        {
            InitializeComponent();
        }

        public int creditos {get ;set;} 
        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            creditos = Convert.ToInt32(tbxRecarga.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
