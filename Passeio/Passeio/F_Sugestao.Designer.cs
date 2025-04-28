namespace passeio
{
    partial class F_Sugestao
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
            pbxImagem = new PictureBox();
            lblSugestao = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxImagem).BeginInit();
            SuspendLayout();
            // 
            // pbxImagem
            // 
            pbxImagem.BackgroundImageLayout = ImageLayout.Center;
            pbxImagem.Image = Properties.Resources.Sobral_Shopping;
            pbxImagem.Location = new Point(68, 84);
            pbxImagem.Name = "pbxImagem";
            pbxImagem.Size = new Size(417, 304);
            pbxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagem.TabIndex = 0;
            pbxImagem.TabStop = false;
            // 
            // lblSugestao
            // 
            lblSugestao.AutoSize = true;
            lblSugestao.BackColor = Color.Transparent;
            lblSugestao.Font = new Font("Harlow Solid Italic", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSugestao.Location = new Point(68, 47);
            lblSugestao.Name = "lblSugestao";
            lblSugestao.Size = new Size(78, 34);
            lblSugestao.TabIndex = 1;
            lblSugestao.Text = "label1";
            // 
            // F_Sugestao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 504);
            Controls.Add(lblSugestao);
            Controls.Add(pbxImagem);
            Name = "F_Sugestao";
            Text = "F_Sugestao";
            Load += F_Sugestao_Load;
            ((System.ComponentModel.ISupportInitialize)pbxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxImagem;
        private Label lblSugestao;
    }
}