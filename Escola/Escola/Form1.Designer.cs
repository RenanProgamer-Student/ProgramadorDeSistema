namespace Escola
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxUser = new TextBox();
            tbxPass = new TextBox();
            cbxPerfil = new ComboBox();
            btnAcessar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Geometr415 Blk BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 19);
            label1.Name = "label1";
            label1.Size = new Size(325, 22);
            label1.TabIndex = 0;
            label1.Text = "Login Escola - Dr. João ribeiro Ramos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("News706 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(79, 97);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("News706 BT", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(79, 143);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("News706 BT", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(79, 196);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 3;
            label4.Text = "Perfil";
            // 
            // tbxUser
            // 
            tbxUser.Location = new Point(165, 93);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(138, 23);
            tbxUser.TabIndex = 4;
            // 
            // tbxPass
            // 
            tbxPass.Location = new Point(165, 143);
            tbxPass.Name = "tbxPass";
            tbxPass.Size = new Size(138, 23);
            tbxPass.TabIndex = 5;
            // 
            // cbxPerfil
            // 
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Items.AddRange(new object[] { "Aluno", "Professor", "Diretor" });
            cbxPerfil.Location = new Point(165, 192);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(138, 23);
            cbxPerfil.TabIndex = 6;
            cbxPerfil.Text = "Selecione um Perfil";
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.White;
            btnAcessar.FlatStyle = FlatStyle.Popup;
            btnAcessar.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcessar.Location = new Point(165, 254);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 28);
            btnAcessar.TabIndex = 7;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_verde;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(395, 385);
            Controls.Add(btnAcessar);
            Controls.Add(cbxPerfil);
            Controls.Add(tbxPass);
            Controls.Add(tbxUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxUser;
        private TextBox tbxPass;
        private ComboBox cbxPerfil;
        private Button btnAcessar;
    }
}
