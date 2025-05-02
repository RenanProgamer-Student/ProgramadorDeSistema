namespace StringVetor
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
            tbxPlaca = new TextBox();
            tbxL1 = new TextBox();
            tbxL2 = new TextBox();
            tbxL3 = new TextBox();
            Confirmar = new Button();
            tbxMes = new TextBox();
            label3 = new Label();
            dtpRodizio = new DateTimePicker();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 15);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Placa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 15);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Letras";
            // 
            // tbxPlaca
            // 
            tbxPlaca.Location = new Point(104, 12);
            tbxPlaca.MaxLength = 7;
            tbxPlaca.Name = "tbxPlaca";
            tbxPlaca.Size = new Size(100, 23);
            tbxPlaca.TabIndex = 2;
            // 
            // tbxL1
            // 
            tbxL1.Location = new Point(274, 12);
            tbxL1.Name = "tbxL1";
            tbxL1.Size = new Size(29, 23);
            tbxL1.TabIndex = 3;
            tbxL1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxL2
            // 
            tbxL2.Location = new Point(309, 12);
            tbxL2.Name = "tbxL2";
            tbxL2.Size = new Size(29, 23);
            tbxL2.TabIndex = 4;
            tbxL2.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxL3
            // 
            tbxL3.Location = new Point(344, 12);
            tbxL3.Name = "tbxL3";
            tbxL3.Size = new Size(29, 23);
            tbxL3.TabIndex = 5;
            tbxL3.TextAlign = HorizontalAlignment.Center;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(169, 171);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(99, 28);
            Confirmar.TabIndex = 6;
            Confirmar.Text = "Verificar";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += Confirmar_Click;
            // 
            // tbxMes
            // 
            tbxMes.Location = new Point(180, 57);
            tbxMes.Name = "tbxMes";
            tbxMes.ReadOnly = true;
            tbxMes.Size = new Size(100, 23);
            tbxMes.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 60);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 7;
            label3.Text = "Mês";
            // 
            // dtpRodizio
            // 
            dtpRodizio.Location = new Point(124, 100);
            dtpRodizio.Name = "dtpRodizio";
            dtpRodizio.Size = new Size(249, 23);
            dtpRodizio.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 106);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 10;
            label4.Text = "Rodízio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 245);
            Controls.Add(label4);
            Controls.Add(dtpRodizio);
            Controls.Add(tbxMes);
            Controls.Add(label3);
            Controls.Add(Confirmar);
            Controls.Add(tbxL3);
            Controls.Add(tbxL2);
            Controls.Add(tbxL1);
            Controls.Add(tbxPlaca);
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
        private TextBox tbxPlaca;
        private TextBox tbxL1;
        private TextBox tbxL2;
        private TextBox tbxL3;
        private Button Confirmar;
        private TextBox tbxMes;
        private Label label3;
        private DateTimePicker dtpRodizio;
        private Label label4;
    }
}
