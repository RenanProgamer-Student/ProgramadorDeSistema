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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cb4h59rq;
            pictureBox1.Location = new Point(181, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.mc;
            pictureBox2.Location = new Point(23, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(163, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(23, 151);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(137, 86);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 325);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 4;
            label1.Text = "Digite o valor Desejado: ";
            // 
            // tbxRecarga
            // 
            tbxRecarga.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxRecarga.Location = new Point(235, 322);
            tbxRecarga.Name = "tbxRecarga";
            tbxRecarga.Size = new Size(201, 33);
            tbxRecarga.TabIndex = 5;
            // 
            // btnRecarregar
            // 
            btnRecarregar.Location = new Point(181, 390);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(106, 39);
            btnRecarregar.TabIndex = 6;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = true;
            btnRecarregar.Click += btnRecarregar_Click;
            // 
            // F_Recarregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 462);
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
    }
}