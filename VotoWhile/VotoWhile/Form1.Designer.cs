namespace VotoWhile
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
            tbxCandidato1 = new TextBox();
            tbxCandidato2 = new TextBox();
            btnVotar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 47);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Candidato 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 92);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Candidato 2";
            // 
            // tbxCandidato1
            // 
            tbxCandidato1.Location = new Point(274, 44);
            tbxCandidato1.Name = "tbxCandidato1";
            tbxCandidato1.Size = new Size(121, 23);
            tbxCandidato1.TabIndex = 4;
            // 
            // tbxCandidato2
            // 
            tbxCandidato2.Location = new Point(274, 84);
            tbxCandidato2.Name = "tbxCandidato2";
            tbxCandidato2.Size = new Size(121, 23);
            tbxCandidato2.TabIndex = 5;
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(237, 146);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(126, 31);
            btnVotar.TabIndex = 8;
            btnVotar.Text = "Votação";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(74, 221);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 368);
            Controls.Add(lblResultado);
            Controls.Add(btnVotar);
            Controls.Add(tbxCandidato2);
            Controls.Add(tbxCandidato1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxCandidato1;
        private TextBox tbxCandidato2;
        private Button btnVotar;
        private Label lblResultado;
    }
}
