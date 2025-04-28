namespace Adivinhe
{
    partial class F_Recarregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Recarregar));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            tbxRecarga = new TextBox();
            btnRecarregar = new Button();
            gbxFdPg = new GroupBox();
            rbCredito = new RadioButton();
            rbDebito = new RadioButton();
            rbPix = new RadioButton();
            rbBoleto = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            gbxFdPg.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cb4h59rq;
            pictureBox1.Location = new Point(256, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.mc;
            pictureBox2.Location = new Point(23, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(118, -10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(23, 59);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(88, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 349);
            label1.Name = "label1";
            label1.Size = new Size(308, 20);
            label1.TabIndex = 4;
            label1.Text = "Informe a quantidades de creditos desejados";
            // 
            // tbxRecarga
            // 
            tbxRecarga.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxRecarga.Location = new Point(171, 372);
            tbxRecarga.Name = "tbxRecarga";
            tbxRecarga.Size = new Size(201, 29);
            tbxRecarga.TabIndex = 5;
            // 
            // btnRecarregar
            // 
            btnRecarregar.Location = new Point(225, 464);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(106, 39);
            btnRecarregar.TabIndex = 6;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = true;
            btnRecarregar.Click += btnRecarregar_Click;
            // 
            // gbxFdPg
            // 
            gbxFdPg.Controls.Add(rbBoleto);
            gbxFdPg.Controls.Add(rbPix);
            gbxFdPg.Controls.Add(rbDebito);
            gbxFdPg.Controls.Add(rbCredito);
            gbxFdPg.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxFdPg.Location = new Point(23, 121);
            gbxFdPg.Name = "gbxFdPg";
            gbxFdPg.Size = new Size(167, 225);
            gbxFdPg.TabIndex = 8;
            gbxFdPg.TabStop = false;
            gbxFdPg.Text = "Forma de pagamento";
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.Location = new Point(15, 24);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(131, 21);
            rbCredito.TabIndex = 0;
            rbCredito.TabStop = true;
            rbCredito.Text = "Cartão de Crédito";
            rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbDebito
            // 
            rbDebito.AutoSize = true;
            rbDebito.Location = new Point(15, 80);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(127, 21);
            rbDebito.TabIndex = 1;
            rbDebito.TabStop = true;
            rbDebito.Text = "Cartão de Débito";
            rbDebito.TextAlign = ContentAlignment.MiddleCenter;
            rbDebito.UseVisualStyleBackColor = true;
            // 
            // rbPix
            // 
            rbPix.AutoSize = true;
            rbPix.Location = new Point(15, 138);
            rbPix.Name = "rbPix";
            rbPix.Size = new Size(42, 21);
            rbPix.TabIndex = 2;
            rbPix.TabStop = true;
            rbPix.Text = "Pix";
            rbPix.UseVisualStyleBackColor = true;
            // 
            // rbBoleto
            // 
            rbBoleto.AutoSize = true;
            rbBoleto.Location = new Point(15, 186);
            rbBoleto.Name = "rbBoleto";
            rbBoleto.Size = new Size(63, 21);
            rbBoleto.TabIndex = 3;
            rbBoleto.TabStop = true;
            rbBoleto.Text = "Boleto";
            rbBoleto.UseVisualStyleBackColor = true;
            // 
            // F_Recarregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 551);
            Controls.Add(gbxFdPg);
            Controls.Add(btnRecarregar);
            Controls.Add(tbxRecarga);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "F_Recarregar";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            gbxFdPg.ResumeLayout(false);
            gbxFdPg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private TextBox tbxRecarga;
        private Button btnRecarregar;
        private GroupBox gbxFdPg;
        private RadioButton rbBoleto;
        private RadioButton rbPix;
        private RadioButton rbDebito;
        private RadioButton rbCredito;
    }
}