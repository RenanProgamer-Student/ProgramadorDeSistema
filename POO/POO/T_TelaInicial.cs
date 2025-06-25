using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class T_TelaInicial : Form
    {
        Conta c1;
        public T_TelaInicial()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxId.Text);
            string nome = tbxNome.Text;

            c1 = new Conta(id,nome);
            

        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            try
            {
                c1.Extrato();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Identificado: {ex.Message}", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Double valor = Convert.ToDouble(tbxValor.Text);
            try
            {
                c1.Depositar(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Identificado: {ex.Message}", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Double valor = Convert.ToDouble(tbxValor.Text);
            try
            {
                c1.Sacar(valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Identificado: {ex.Message}", "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String nomeEditado = tbxNomeAtt.Text;
            c1.SetNome(nomeEditado);
        }
    }
}
