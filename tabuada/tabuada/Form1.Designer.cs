namespace tabuada
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
            tbxN1 = new TextBox();
            btnSoma = new Button();
            btnSub = new Button();
            btnMult = new Button();
            B = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // tbxN1
            // 
            tbxN1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxN1.Location = new Point(101, 9);
            tbxN1.Name = "tbxN1";
            tbxN1.Size = new Size(242, 39);
            tbxN1.TabIndex = 1;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSoma.Location = new Point(12, 68);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(63, 55);
            btnSoma.TabIndex = 2;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Showcard Gothic", 20.25F);
            btnSub.Location = new Point(101, 68);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(63, 55);
            btnSub.TabIndex = 3;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Showcard Gothic", 20.25F);
            btnMult.Location = new Point(191, 68);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(63, 55);
            btnMult.TabIndex = 4;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // B
            // 
            B.Font = new Font("Showcard Gothic", 20.25F);
            B.Location = new Point(280, 68);
            B.Name = "B";
            B.Size = new Size(63, 55);
            B.TabIndex = 5;
            B.Text = "/";
            B.UseVisualStyleBackColor = true;
            B.Click += B_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(114, 139);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 22);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "label2";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            lblResultado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 532);
            Controls.Add(lblResultado);
            Controls.Add(B);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Controls.Add(tbxN1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxN1;
        private Button btnSoma;
        private Button btnSub;
        private Button btnMult;
        private Button B;
        private Label lblResultado;
    }
}
