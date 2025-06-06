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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String usuario = tbxUsuario.Text;
            String senha   = tbxSenha.Text;
            String perfil  = cbxPerfil.Text;



            if(perfil == "Diretor")
            {
                F_Diretor janelaDiretor = new F_Diretor(this);
                janelaDiretor.ShowDialog();
                this.Close();
            }
            else if (perfil == "Professor")
            {
                string strconn = ("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");
                SqlConnection conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    //Comando sql
                    String sql = "SELECT senha, salt FROM Professores WHERE usuario = @usuario";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Adiciona o valor do parâmetro "@usuario" ao comando SQL, substituindo por 'usuario' (valor fornecido pelo usuário)
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    // Executa o comando SQL e cria um SqlDataReader para ler os dados retornados pela consulta
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lê a senha hash armazenada no banco de dados (primeira coluna do reader)
                            String senhaHashBranco = reader.GetString(0);
                            // Lê o salt armazenado no banco de dados (segunda coluna do reader)
                            String saltBranco = reader.GetString(1);

                            // Remove todos os espaços do salt, caso existam
                            saltBranco = saltBranco.Replace(" ", "");

                            // Gera a senha hash a partir da senha digitada e do salt recuperado
                            String senhaHashDigitada = PasswordHelper.HashPassword(senha, saltBranco);
                            // Remove todos os espaços em branco da senha hash recuperada do banco (caso existam)
                            senhaHashBranco = senhaHashBranco.Replace(" ", "");
                            // Remove todos os espaços em branco da senha hash digitada (caso existam)
                            senhaHashDigitada = senhaHashDigitada.Replace(" ", "");

                            if (senhaHashDigitada == senhaHashBranco)
                            {

                            F_Professor janelaProfessor = new F_Professor(this);
                            janelaProfessor.ShowDialog();
                            this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta, Erro", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario incorreto, Erro", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro Inesperado, Erro: " + ex.Message, "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (perfil == "Aluno")
            {
                string strconn = ("Data source=SOB041991L4B1PC\\SQLEXPRESS;Initial Catalog=Senac;Integrated Security=True;");
                SqlConnection conn = new SqlConnection(strconn);
                try
                {
                    conn.Open();
                    //Comando sql
                    String sql = "SELECT senha, salt FROM Alunos WHERE usuario = @usuario";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Adiciona o valor do parâmetro "@usuario" ao comando SQL, substituindo por 'usuario' (valor fornecido pelo usuário)
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    // Executa o comando SQL e cria um SqlDataReader para ler os dados retornados pela consulta
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lê a senha hash armazenada no banco de dados (primeira coluna do reader)
                            String senhaHashBranco = reader.GetString(0);
                            // Lê o salt armazenado no banco de dados (segunda coluna do reader)
                            String saltBranco = reader.GetString(1);

                            // Remove todos os espaços do salt, caso existam
                            saltBranco = saltBranco.Replace(" ", "");

                            // Gera a senha hash a partir da senha digitada e do salt recuperado
                            String senhaHashDigitada = PasswordHelper.HashPassword(senha, saltBranco);
                            // Remove todos os espaços em branco da senha hash recuperada do banco (caso existam)
                            senhaHashBranco = senhaHashBranco.Replace(" ", "");
                            // Remove todos os espaços em branco da senha hash digitada (caso existam)
                            senhaHashDigitada = senhaHashDigitada.Replace(" ", "");

                            if (senhaHashDigitada == senhaHashBranco)
                            {
                                F_Aluno janelaAluno = new F_Aluno(this);
                                janelaAluno.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta, Erro", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario incorreto, Erro", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro Inesperado, Erro: " + ex.Message, "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
