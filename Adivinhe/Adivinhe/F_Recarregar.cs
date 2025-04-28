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

        public int creditos { get; set; }
        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            creditos = Convert.ToInt32(tbxRecarga.Text);
            double total;
            String FormaPagamento;
            if (creditos >= 1 && creditos <= 10)
            {
                if (rbCredito.Checked)
                {
                    total = 1.50 * creditos * 1.02;
                    FormaPagamento = rbCredito.Text;
                }
                else if (rbDebito.Checked) 
                {
                    total = 1.50 * creditos * 1.02;
                    FormaPagamento = rbDebito.Text;
                }
                else if (rbPix.Checked)
                {
                    total = 1.50 * creditos;
                    FormaPagamento = rbPix.Text;
                }
                else
                {
                    total = 1.50 * creditos;
                    FormaPagamento = rbBoleto.Text;
                }
                    MessageBox.Show($"Total: {total}, forma de pagamento Via {FormaPagamento}", "Confimação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Recarga deve ser de pelo menos entre 1 até 10 Cereditos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
