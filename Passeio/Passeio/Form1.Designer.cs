namespace passeio
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
            tbxDinheiro = new TextBox();
            cbxClima = new ComboBox();
            btnSugerir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 70);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Clima";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 162);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Dinheiro";
            // 
            // tbxDinheiro
            // 
            tbxDinheiro.Location = new Point(177, 159);
            tbxDinheiro.Name = "tbxDinheiro";
            tbxDinheiro.Size = new Size(152, 23);
            tbxDinheiro.TabIndex = 3;
            // 
            // cbxClima
            // 
            cbxClima.FormattingEnabled = true;
            cbxClima.Items.AddRange(new object[] { "Sol", "Chuva" });
            cbxClima.Location = new Point(177, 67);
            cbxClima.Name = "cbxClima";
            cbxClima.Size = new Size(152, 23);
            cbxClima.TabIndex = 4;
            // 
            // btnSugerir
            // 
            btnSugerir.Location = new Point(203, 225);
            btnSugerir.Name = "btnSugerir";
            btnSugerir.Size = new Size(96, 37);
            btnSugerir.TabIndex = 5;
            btnSugerir.Text = "Sugerir";
            btnSugerir.UseVisualStyleBackColor = true;
            btnSugerir.Click += btnSugerir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 323);
            Controls.Add(btnSugerir);
            Controls.Add(cbxClima);
            Controls.Add(tbxDinheiro);
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
        private TextBox tbxDinheiro;
        private ComboBox cbxClima;
        private Button btnSugerir;
    }
}
