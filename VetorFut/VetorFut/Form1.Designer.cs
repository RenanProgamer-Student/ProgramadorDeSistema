namespace VetorFut
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
            tbxNomeTM = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxVT = new TextBox();
            tbxEM = new TextBox();
            tbxDE = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            tbxTimeNM2 = new TextBox();
            label5 = new Label();
            tbxDE2 = new TextBox();
            tbxEM2 = new TextBox();
            tbxVT2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(348, 76);
            label1.Name = "label1";
            label1.Size = new Size(229, 23);
            label1.TabIndex = 0;
            label1.Text = "DIGITE O NOME DO TIME";
            // 
            // tbxNomeTM
            // 
            tbxNomeTM.Font = new Font("Berlin Sans FB", 9F);
            tbxNomeTM.Location = new Point(271, 102);
            tbxNomeTM.Name = "tbxNomeTM";
            tbxNomeTM.Size = new Size(175, 21);
            tbxNomeTM.TabIndex = 1;
            tbxNomeTM.TextChanged += tbxNomeTM_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(279, 159);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 2;
            label2.Text = "Vitorias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(269, 207);
            label3.Name = "label3";
            label3.Size = new Size(66, 18);
            label3.TabIndex = 3;
            label3.Text = "Empates";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(271, 258);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 4;
            label4.Text = "Derrotas";
            // 
            // tbxVT
            // 
            tbxVT.Font = new Font("Berlin Sans FB", 9F);
            tbxVT.Location = new Point(348, 154);
            tbxVT.Name = "tbxVT";
            tbxVT.Size = new Size(60, 21);
            tbxVT.TabIndex = 5;
            tbxVT.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxEM
            // 
            tbxEM.Font = new Font("Berlin Sans FB", 9F);
            tbxEM.Location = new Point(348, 207);
            tbxEM.Name = "tbxEM";
            tbxEM.Size = new Size(60, 21);
            tbxEM.TabIndex = 6;
            tbxEM.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxDE
            // 
            tbxDE.Font = new Font("Berlin Sans FB", 9F);
            tbxDE.Location = new Point(348, 258);
            tbxDE.Name = "tbxDE";
            tbxDE.Size = new Size(60, 21);
            tbxDE.TabIndex = 7;
            tbxDE.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.White;
            btnCalcular.FlatStyle = FlatStyle.Popup;
            btnCalcular.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(393, 348);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(139, 35);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Berlin Sans FB", 16F);
            lblResultado.ForeColor = Color.White;
            lblResultado.Location = new Point(98, 398);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(67, 24);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "label5";
            lblResultado.TextAlign = ContentAlignment.BottomCenter;
            lblResultado.Visible = false;
            // 
            // tbxTimeNM2
            // 
            tbxTimeNM2.Font = new Font("Berlin Sans FB", 9F);
            tbxTimeNM2.Location = new Point(500, 102);
            tbxTimeNM2.Name = "tbxTimeNM2";
            tbxTimeNM2.Size = new Size(180, 21);
            tbxTimeNM2.TabIndex = 10;
            tbxTimeNM2.TextChanged += tbxTimeNM2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Berlin Sans FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(463, 101);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 11;
            label5.Text = "X";
            // 
            // tbxDE2
            // 
            tbxDE2.Font = new Font("Berlin Sans FB", 9F);
            tbxDE2.Location = new Point(535, 258);
            tbxDE2.Name = "tbxDE2";
            tbxDE2.Size = new Size(60, 21);
            tbxDE2.TabIndex = 17;
            tbxDE2.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxEM2
            // 
            tbxEM2.Font = new Font("Berlin Sans FB", 9F);
            tbxEM2.Location = new Point(535, 207);
            tbxEM2.Name = "tbxEM2";
            tbxEM2.Size = new Size(60, 21);
            tbxEM2.TabIndex = 16;
            tbxEM2.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxVT2
            // 
            tbxVT2.Font = new Font("Berlin Sans FB", 9F);
            tbxVT2.Location = new Point(535, 154);
            tbxVT2.Name = "tbxVT2";
            tbxVT2.Size = new Size(60, 21);
            tbxVT2.TabIndex = 15;
            tbxVT2.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(616, 258);
            label6.Name = "label6";
            label6.Size = new Size(64, 18);
            label6.TabIndex = 14;
            label6.Text = "Derrotas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(614, 207);
            label7.Name = "label7";
            label7.Size = new Size(66, 18);
            label7.TabIndex = 13;
            label7.Text = "Empates";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(624, 159);
            label8.Name = "label8";
            label8.Size = new Size(56, 18);
            label8.TabIndex = 12;
            label8.Text = "Vitorias";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(753, 595);
            Controls.Add(tbxDE2);
            Controls.Add(tbxEM2);
            Controls.Add(tbxVT2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(tbxTimeNM2);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(tbxDE);
            Controls.Add(tbxEM);
            Controls.Add(tbxVT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxNomeTM);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxNomeTM;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbxVT;
        private TextBox tbxEM;
        private TextBox tbxDE;
        private Button btnCalcular;
        private Label lblResultado;
        private TextBox tbxTimeNM2;
        private Label label5;
        private TextBox tbxDE2;
        private TextBox tbxEM2;
        private TextBox tbxVT2;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
