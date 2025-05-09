namespace Fatorial
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
            tbxNum = new TextBox();
            btnFator = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 39);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Número Inicial";
            // 
            // tbxNum
            // 
            tbxNum.Location = new Point(126, 36);
            tbxNum.Name = "tbxNum";
            tbxNum.Size = new Size(100, 23);
            tbxNum.TabIndex = 1;
            // 
            // btnFator
            // 
            btnFator.Location = new Point(126, 112);
            btnFator.Name = "btnFator";
            btnFator.Size = new Size(75, 23);
            btnFator.TabIndex = 2;
            btnFator.Text = "Fatorar";
            btnFator.UseVisualStyleBackColor = true;
            btnFator.Click += btnFator_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(43, 150);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 455);
            Controls.Add(lblResultado);
            Controls.Add(btnFator);
            Controls.Add(tbxNum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxNum;
        private Button btnFator;
        private Label lblResultado;
    }
}
