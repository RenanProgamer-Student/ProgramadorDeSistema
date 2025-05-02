namespace StringVetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            String placa = tbxPlaca.Text;

            tbxL1.Text = placa[0].ToString();
            tbxL2.Text = placa[1].ToString();
            tbxL3.Text = placa[2].ToString();

            //Licenciamento
            string numero = placa[6].ToString();
            switch (numero)
            {
                case "1":
                    tbxMes.Text = "Março";
                    break;
                case "2":
                    tbxMes.Text = "Abril";
                    break;
                case "3":
                    tbxMes.Text = "Maio";
                    break;
                case "4":
                    tbxMes.Text = "Junho";
                    break;
                case "5":
                    tbxMes.Text = "Julho";
                    break;
                case "6":
                    tbxMes.Text = "Agosto";
                    break;
                case "7":
                    tbxMes.Text = "Setembro";
                    break;
                case "8":
                    tbxMes.Text = "Outubro";
                    break;
                case "9":
                    tbxMes.Text = "Novembro";
                    break;
                case "0":
                    tbxMes.Text = "Dezembro";
                    break;

            }

            String dia = dtpRodizio.Value.ToString("dddd", new System.Globalization.CultureInfo("pt-BR"));
            String frase = "Liberado";

            if (dia == "segunda-feira" && (placa[6] == '1' || placa[6] == '2'))
            { 
                frase = "Não liberado";
            }
            else if (dia == "terça-feira" && (placa[6] == '3' || placa[6] == '4'))
            {
                frase = "Não liberado";
            }
            else if (dia == "quarta-feira" && (placa[6] == '5' || placa[6] == '6'))
            {
                frase = "Não liberado";
            }
            else if (dia == "quinta-feira" && (placa[6] == '7' || placa[6] == '8'))
            {
                frase = "Não liberado";
            }
            else if (dia == "sexta-feira" && (placa[6] == '9' || placa[6] == '0'))
            {
                frase = "Não liberado";
            }
            MessageBox.Show($"{frase}");



            /*
            if (numero == "1")
            {
                tbxMes.Text = "Março";
            }
            if (numero == "2")
            {
                tbxMes.Text = "Abril";
            }
            if (numero == "3")
            {
                tbxMes.Text = "Maio";
            }
            if (numero == "4")
            {
                tbxMes.Text = "Junho";
            }
            if (numero == "5")
            {
                tbxMes.Text = "Julho";
            }
            if (numero == "6")
            {
                tbxMes.Text = "Agosto";
            }
            if (numero == "7")
            {
                tbxMes.Text = "Setembro";
            }
            if (numero == "8")
            {
                tbxMes.Text = "Outubro";
            }
            if (numero == "9")
            {
                tbxMes.Text = "Novembro";
            }
            if (numero == "0")
            {
                tbxMes.Text = "Dezembro";
            }
            */
        }
    }
}
