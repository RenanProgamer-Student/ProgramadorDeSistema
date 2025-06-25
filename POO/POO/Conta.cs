using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    internal class Conta
    {
        private int ID;
        private string nome_cliente;
        private Double saldo = 0;

        //Construtor

        public Conta(int id, string nome)
        {
            this.ID = id;
            this.nome_cliente = nome;
            MessageBox.Show($"Conta em nome de '{nome}' criada com sucesso", "Sucesso");
        }

        public void SetNome(String nomeEditado)
        {
            this.nome_cliente = nomeEditado;
            MessageBox.Show("Nome Atualizado.");
        }
        
        public void Extrato()
        {
          MessageBox.Show($"ID: {this.ID}\n Nome do cliente: {this.nome_cliente}\n Saldo: {this.saldo}", "Sucesso");
        }

        public void Depositar(Double valor)
        {

            DialogResult resultado = MessageBox.Show("Deseja continuar o Depósito?", "Confirmação", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                this.saldo += valor;
                // Ação ao clicar em OK
                MessageBox.Show($"Depósito de {valor}R$ foi realizdo com sucesso!", "Depósito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                // Ação se clicar em Cancelar (opcional)
                MessageBox.Show("Você cancelou a operação.");
            }

        }

        public void Sacar(Double valor)
        {
            DialogResult resultado = MessageBox.Show("Deseja continuar o Saque?", "Confirmação", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {

                if (saldo >= valor)
                {
                    this.saldo -= valor;
                    // Ação de sacar dinheiro
                    MessageBox.Show($"Saque de {valor}R$ foi realizdo com sucesso!", "Depósito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"O valor {valor}R$ é mais do que seu saldo de {saldo}R$ \n Não posso seguir com essa operação.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (resultado == DialogResult.OK)
                    {
                        MessageBox.Show($"Saldo insuficiente? Faça um esprestimio agora e ganhe uma bonificação de 2% sem juros ao mês", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                // Ação se clicar em Cancelar (opcional)
                MessageBox.Show("Você cancelou a operação.");
            }
        }

    }

}
