namespace NumeroSequencial
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
            tbxTI = new TextBox();
            tbxIC = new TextBox();
            tbxQtd = new TextBox();
            btnGerar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 53);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Termo inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 91);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Incremento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 136);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // tbxTI
            // 
            tbxTI.Location = new Point(199, 50);
            tbxTI.Name = "tbxTI";
            tbxTI.Size = new Size(100, 23);
            tbxTI.TabIndex = 3;
            // 
            // tbxIC
            // 
            tbxIC.Location = new Point(199, 88);
            tbxIC.Name = "tbxIC";
            tbxIC.Size = new Size(100, 23);
            tbxIC.TabIndex = 4;
            // 
            // tbxQtd
            // 
            tbxQtd.Location = new Point(199, 133);
            tbxQtd.Name = "tbxQtd";
            tbxQtd.Size = new Size(100, 23);
            tbxQtd.TabIndex = 5;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(169, 198);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(108, 33);
            btnGerar.TabIndex = 6;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(63, 276);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "label4";
            lblResultado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 395);
            Controls.Add(lblResultado);
            Controls.Add(btnGerar);
            Controls.Add(tbxQtd);
            Controls.Add(tbxIC);
            Controls.Add(tbxTI);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox tbxTI;
        private TextBox tbxIC;
        private TextBox tbxQtd;
        private Button btnGerar;
        private Label lblResultado;
    }
}
