using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passeio
{
    public partial class F_Sugestao : Form
    {
        String c;
        double v;
        public F_Sugestao(String clima, double valor)
        {
            c = clima;
            v = valor;
            InitializeComponent();
        }
        private void F_Sugestao_Load(object sender, EventArgs e)
        {
            if (c == "Sol" && v < 3000)
            {
                lblSugestao.Text = "Recomendo ir a Pria";
                pbxImagem.Image = Properties.Resources.praia;
            }
            else if (c == "Sol" && v >= 3000)
            {
                lblSugestao.Text = "Recomendo ir a Dubai";
                pbxImagem.Image = Properties.Resources.dubai;

            }
            else if (c == "Chuva" && v < 3000)
            {
                lblSugestao.Text = "Recomendo ir ao Shopping";
                pbxImagem.Image = Properties.Resources.Sobral_Shopping;

            }
            else if (c == "Chuva" && v >= 3000)
            {
                lblSugestao.Text = "Recomendo ir a Serra de Meruoca";
                pbxImagem.Image = Properties.Resources.Meruoca;

            }
        }
    }
}
