namespace VetorLetra
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
            tbxPalavra = new TextBox();
            tbxLetra = new TextBox();
            btnVerificar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 87);
            label1.Name = "label1";
            label1.Size = new Size(81, 22);
            label1.TabIndex = 0;
            label1.Text = "Palavra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 14.25F, FontStyle.Bold);
            label2.Location = new Point(87, 126);
            label2.Name = "label2";
            label2.Size = new Size(59, 22);
            label2.TabIndex = 1;
            label2.Text = "Letra";
            // 
            // tbxPalavra
            // 
            tbxPalavra.Font = new Font("Lucida Bright", 11.25F);
            tbxPalavra.Location = new Point(152, 86);
            tbxPalavra.Name = "tbxPalavra";
            tbxPalavra.Size = new Size(100, 25);
            tbxPalavra.TabIndex = 2;
            // 
            // tbxLetra
            // 
            tbxLetra.Font = new Font("Lucida Bright", 11.25F);
            tbxLetra.Location = new Point(152, 125);
            tbxLetra.MaxLength = 1;
            tbxLetra.Name = "tbxLetra";
            tbxLetra.Size = new Size(32, 25);
            tbxLetra.TabIndex = 3;
            tbxLetra.TextAlign = HorizontalAlignment.Center;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(152, 184);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(83, 236);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(53, 17);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "label3";
            lblResultado.TextAlign = ContentAlignment.BottomCenter;
            lblResultado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 356);
            Controls.Add(lblResultado);
            Controls.Add(btnVerificar);
            Controls.Add(tbxLetra);
            Controls.Add(tbxPalavra);
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
        private TextBox tbxPalavra;
        private TextBox tbxLetra;
        private Button btnVerificar;
        private Label lblResultado;
    }
}
