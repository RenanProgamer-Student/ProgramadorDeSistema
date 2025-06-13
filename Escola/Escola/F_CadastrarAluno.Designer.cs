namespace Escola
{
    partial class F_CadastrarAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CadastrarAluno));
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.tbxSenhaAluno = new System.Windows.Forms.TextBox();
            this.tbxUserAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxCpfAluno = new System.Windows.Forms.TextBox();
            this.tbxNomeAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.BackColor = System.Drawing.Color.White;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrarAluno.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(162, 333);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(87, 30);
            this.btnCadastrarAluno.TabIndex = 28;
            this.btnCadastrarAluno.Text = " Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(135, 194);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDataNascimento.Size = new System.Drawing.Size(175, 20);
            this.dtpDataNascimento.TabIndex = 27;
            // 
            // tbxSenhaAluno
            // 
            this.tbxSenhaAluno.Location = new System.Drawing.Point(135, 269);
            this.tbxSenhaAluno.MaxLength = 20;
            this.tbxSenhaAluno.Name = "tbxSenhaAluno";
            this.tbxSenhaAluno.Size = new System.Drawing.Size(175, 20);
            this.tbxSenhaAluno.TabIndex = 26;
            // 
            // tbxUserAluno
            // 
            this.tbxUserAluno.Location = new System.Drawing.Point(135, 230);
            this.tbxUserAluno.MaxLength = 50;
            this.tbxUserAluno.Name = "tbxUserAluno";
            this.tbxUserAluno.Size = new System.Drawing.Size(175, 20);
            this.tbxUserAluno.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bell MT", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(74, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Senha";
            // 
            // tbxCpfAluno
            // 
            this.tbxCpfAluno.Location = new System.Drawing.Point(135, 157);
            this.tbxCpfAluno.MaxLength = 14;
            this.tbxCpfAluno.Name = "tbxCpfAluno";
            this.tbxCpfAluno.Size = new System.Drawing.Size(175, 20);
            this.tbxCpfAluno.TabIndex = 23;
            // 
            // tbxNomeAluno
            // 
            this.tbxNomeAluno.Location = new System.Drawing.Point(135, 119);
            this.tbxNomeAluno.MaxLength = 250;
            this.tbxNomeAluno.Name = "tbxNomeAluno";
            this.tbxNomeAluno.Size = new System.Drawing.Size(175, 20);
            this.tbxNomeAluno.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bell MT", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bell MT", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bell MT", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cpf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "CADASTRAR ALUNO";
            // 
            // F_CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escola.Properties.Resources.bg_CdProf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 442);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.tbxSenhaAluno);
            this.Controls.Add(this.tbxUserAluno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxCpfAluno);
            this.Controls.Add(this.tbxNomeAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_CadastrarAluno";
            this.Text = "Cadastro Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox tbxSenhaAluno;
        private System.Windows.Forms.TextBox tbxUserAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxCpfAluno;
        private System.Windows.Forms.TextBox tbxNomeAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}