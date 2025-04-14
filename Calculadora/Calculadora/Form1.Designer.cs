namespace Calculadora
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
            tbxResultado = new TextBox();
            label1 = new Label();
            tbxN1 = new TextBox();
            label2 = new Label();
            tbxN2 = new TextBox();
            btnSoma = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // tbxResultado
            // 
            tbxResultado.Enabled = false;
            tbxResultado.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxResultado.Location = new Point(12, 12);
            tbxResultado.Name = "tbxResultado";
            tbxResultado.Size = new Size(363, 50);
            tbxResultado.TabIndex = 0;
            tbxResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "Numero 1";
            // 
            // tbxN1
            // 
            tbxN1.Location = new Point(114, 125);
            tbxN1.Name = "tbxN1";
            tbxN1.Size = new Size(156, 23);
            tbxN1.TabIndex = 2;
            tbxN1.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 209);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = "Numero 2";
            // 
            // tbxN2
            // 
            tbxN2.Location = new Point(114, 214);
            tbxN2.Name = "tbxN2";
            tbxN2.Size = new Size(156, 23);
            tbxN2.TabIndex = 4;
            tbxN2.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("News706 BT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoma.Location = new Point(27, 278);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(57, 57);
            btnSoma.TabIndex = 5;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("News706 BT", 20.25F, FontStyle.Bold);
            btnSub.Location = new Point(123, 278);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(57, 57);
            btnSub.TabIndex = 6;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("News706 BT", 20.25F, FontStyle.Bold);
            btnMult.Location = new Point(227, 278);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(57, 57);
            btnMult.TabIndex = 7;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("News706 BT", 20.25F, FontStyle.Bold);
            btnDiv.Location = new Point(318, 278);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(57, 57);
            btnDiv.TabIndex = 8;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 407);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Controls.Add(tbxN2);
            Controls.Add(label2);
            Controls.Add(tbxN1);
            Controls.Add(label1);
            Controls.Add(tbxResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxResultado;
        private Label label1;
        private TextBox tbxN1;
        private Label label2;
        private TextBox tbxN2;
        private Button btnSoma;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
    }
}
