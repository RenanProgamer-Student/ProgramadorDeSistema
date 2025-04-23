namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxUser = new TextBox();
            tbxSenha = new TextBox();
            btnEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbxUser
            // 
            tbxUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUser.Location = new Point(272, 167);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(159, 29);
            tbxUser.TabIndex = 0;
            // 
            // tbxSenha
            // 
            tbxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSenha.Location = new Point(272, 240);
            tbxSenha.Name = "tbxSenha";
            tbxSenha.Size = new Size(159, 29);
            tbxSenha.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.LimeGreen;
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(272, 290);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(159, 37);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Square721 Cn BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(289, 135);
            label1.Name = "label1";
            label1.Size = new Size(139, 19);
            label1.TabIndex = 3;
            label1.Text = "PAINEL DE CONTROLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Square721 Cn BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(233, 340);
            label2.Name = "label2";
            label2.Size = new Size(245, 19);
            label2.TabIndex = 4;
            label2.Text = "Esqueci minha senha / Primeiro acesso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_senac;
            ClientSize = new Size(743, 500);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(tbxSenha);
            Controls.Add(tbxUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUser;
        private TextBox tbxSenha;
        private Button btnEntrar;
        private Label label1;
        private Label label2;
    }
}
