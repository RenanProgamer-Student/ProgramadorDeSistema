namespace VetorMedia
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
            label4 = new Label();
            label5 = new Label();
            lblResultado = new Label();
            btnCalcular = new Button();
            tbxN1 = new TextBox();
            tbxN2 = new TextBox();
            tbxN3 = new TextBox();
            tbxN4 = new TextBox();
            lebel7 = new Label();
            tbxNome = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            tbxMedia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Subheading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(119, 2);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 0;
            label1.Text = "Notas de Aluno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 9F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 109);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 1;
            label2.Text = "Nota 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Small", 9F);
            label3.Location = new Point(52, 149);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 2;
            label3.Text = "Nota 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Small", 9F);
            label4.Location = new Point(52, 190);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 3;
            label4.Text = "Nota 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sitka Small", 9F);
            label5.Location = new Point(52, 232);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 4;
            label5.Text = "Nota 4";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.Black;
            lblResultado.Location = new Point(31, 250);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(48, 23);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "label6";
            lblResultado.TextAlign = ContentAlignment.BottomCenter;
            lblResultado.Visible = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(161, 304);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // tbxN1
            // 
            tbxN1.Location = new Point(124, 104);
            tbxN1.Name = "tbxN1";
            tbxN1.Size = new Size(153, 23);
            tbxN1.TabIndex = 7;
            tbxN1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxN2
            // 
            tbxN2.Location = new Point(124, 144);
            tbxN2.Name = "tbxN2";
            tbxN2.Size = new Size(153, 23);
            tbxN2.TabIndex = 8;
            tbxN2.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxN3
            // 
            tbxN3.Location = new Point(124, 185);
            tbxN3.Name = "tbxN3";
            tbxN3.Size = new Size(153, 23);
            tbxN3.TabIndex = 9;
            tbxN3.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxN4
            // 
            tbxN4.Location = new Point(124, 227);
            tbxN4.Name = "tbxN4";
            tbxN4.Size = new Size(153, 23);
            tbxN4.TabIndex = 10;
            tbxN4.TextAlign = HorizontalAlignment.Center;
            // 
            // lebel7
            // 
            lebel7.AutoSize = true;
            lebel7.BackColor = Color.Transparent;
            lebel7.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lebel7.ForeColor = Color.White;
            lebel7.Location = new Point(12, 34);
            lebel7.Name = "lebel7";
            lebel7.Size = new Size(101, 18);
            lebel7.TabIndex = 11;
            lebel7.Text = "Nome do Aluno";
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(12, 52);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(265, 23);
            tbxNome.TabIndex = 12;
            tbxNome.TextChanged += tbxNome_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(283, 55);
            label8.Name = "label8";
            label8.Size = new Size(48, 18);
            label8.TabIndex = 13;
            label8.Text = "Turma";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(333, 52);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(39, 23);
            textBox6.TabIndex = 14;
            // 
            // tbxMedia
            // 
            tbxMedia.Location = new Point(148, 275);
            tbxMedia.Name = "tbxMedia";
            tbxMedia.Size = new Size(100, 23);
            tbxMedia.TabIndex = 15;
            tbxMedia.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo;
            ClientSize = new Size(379, 355);
            Controls.Add(tbxMedia);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(tbxNome);
            Controls.Add(lebel7);
            Controls.Add(tbxN4);
            Controls.Add(tbxN3);
            Controls.Add(tbxN2);
            Controls.Add(tbxN1);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblResultado;
        private Button btnCalcular;
        private TextBox tbxN1;
        private TextBox tbxN2;
        private TextBox tbxN3;
        private TextBox tbxN4;
        private Label lebel7;
        private TextBox tbxNome;
        private Label label8;
        private TextBox textBox6;
        private TextBox tbxMedia;
    }
}
