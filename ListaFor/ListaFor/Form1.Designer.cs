namespace ListaFor
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
            tbxNome = new TextBox();
            btnRepetir = new Button();
            lblResultado = new Label();
            tbxVezes = new TextBox();
            label2 = new Label();
            btnSN = new Button();
            btnMaior = new Button();
            btnMenor = new Button();
            btnNum = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 15);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 0;
            label1.Text = "Digite um nome";
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(324, 24);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(123, 23);
            tbxNome.TabIndex = 1;
            // 
            // btnRepetir
            // 
            btnRepetir.Location = new Point(487, 19);
            btnRepetir.Name = "btnRepetir";
            btnRepetir.Size = new Size(118, 31);
            btnRepetir.TabIndex = 2;
            btnRepetir.Text = "Repetir Nome";
            btnRepetir.UseVisualStyleBackColor = true;
            btnRepetir.Click += btnRepetir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(87, 169);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 21);
            lblResultado.TabIndex = 3;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxVezes
            // 
            tbxVezes.Location = new Point(324, 72);
            tbxVezes.Name = "tbxVezes";
            tbxVezes.Size = new Size(123, 23);
            tbxVezes.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 63);
            label2.Name = "label2";
            label2.Size = new Size(225, 32);
            label2.TabIndex = 4;
            label2.Text = "Digite a quantidade";
            // 
            // btnSN
            // 
            btnSN.Location = new Point(487, 56);
            btnSN.Name = "btnSN";
            btnSN.Size = new Size(118, 31);
            btnSN.TabIndex = 6;
            btnSN.Text = "Somar números";
            btnSN.UseVisualStyleBackColor = true;
            btnSN.Click += btnSN_Click;
            // 
            // btnMaior
            // 
            btnMaior.Location = new Point(487, 93);
            btnMaior.Name = "btnMaior";
            btnMaior.Size = new Size(118, 31);
            btnMaior.TabIndex = 7;
            btnMaior.Text = "Maiores de idade";
            btnMaior.UseVisualStyleBackColor = true;
            btnMaior.Click += btnMaior_Click;
            // 
            // btnMenor
            // 
            btnMenor.Location = new Point(487, 130);
            btnMenor.Name = "btnMenor";
            btnMenor.Size = new Size(118, 31);
            btnMenor.TabIndex = 8;
            btnMenor.Text = "Menores de idade";
            btnMenor.UseVisualStyleBackColor = true;
            btnMenor.Click += btnMenor_Click;
            // 
            // btnNum
            // 
            btnNum.Location = new Point(487, 166);
            btnNum.Name = "btnNum";
            btnNum.Size = new Size(118, 31);
            btnNum.TabIndex = 9;
            btnNum.Text = "Entre 0 e 100";
            btnNum.UseVisualStyleBackColor = true;
            btnNum.Click += btnNum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 450);
            Controls.Add(btnNum);
            Controls.Add(btnMenor);
            Controls.Add(btnMaior);
            Controls.Add(btnSN);
            Controls.Add(tbxVezes);
            Controls.Add(label2);
            Controls.Add(lblResultado);
            Controls.Add(btnRepetir);
            Controls.Add(tbxNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxNome;
        private Button btnRepetir;
        private Label lblResultado;
        private TextBox tbxVezes;
        private Label label2;
        private Button btnSN;
        private Button btnMaior;
        private Button btnMenor;
        private Button btnNum;
    }
}
