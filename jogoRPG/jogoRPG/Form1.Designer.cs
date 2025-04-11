namespace jogoRPG
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
            tbxVidaJ1 = new TextBox();
            tbxVidaJ2 = new TextBox();
            btnAttJ1 = new Button();
            btnAttJ2 = new Button();
            btnDfsJ1 = new Button();
            btnDfsJ2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Swis721 Hv BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 214);
            label1.Name = "label1";
            label1.Size = new Size(41, 18);
            label1.TabIndex = 0;
            label1.Text = "Vida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Hv BT", 11.25F);
            label2.Location = new Point(532, 214);
            label2.Name = "label2";
            label2.Size = new Size(41, 18);
            label2.TabIndex = 1;
            label2.Text = "Vida";
            // 
            // tbxVidaJ1
            // 
            tbxVidaJ1.Enabled = false;
            tbxVidaJ1.Location = new Point(190, 213);
            tbxVidaJ1.Name = "tbxVidaJ1";
            tbxVidaJ1.ReadOnly = true;
            tbxVidaJ1.Size = new Size(30, 23);
            tbxVidaJ1.TabIndex = 2;
            tbxVidaJ1.Text = "100";
            tbxVidaJ1.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxVidaJ2
            // 
            tbxVidaJ2.Enabled = false;
            tbxVidaJ2.Location = new Point(478, 213);
            tbxVidaJ2.Name = "tbxVidaJ2";
            tbxVidaJ2.ReadOnly = true;
            tbxVidaJ2.Size = new Size(30, 23);
            tbxVidaJ2.TabIndex = 3;
            tbxVidaJ2.Text = "100";
            tbxVidaJ2.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAttJ1
            // 
            btnAttJ1.BackColor = SystemColors.Control;
            btnAttJ1.Font = new Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttJ1.ForeColor = Color.Red;
            btnAttJ1.Location = new Point(49, 268);
            btnAttJ1.Name = "btnAttJ1";
            btnAttJ1.Size = new Size(86, 35);
            btnAttJ1.TabIndex = 4;
            btnAttJ1.Text = "Ataque";
            btnAttJ1.UseVisualStyleBackColor = false;
            btnAttJ1.Click += btnAttJ1_Click;
            // 
            // btnAttJ2
            // 
            btnAttJ2.Enabled = false;
            btnAttJ2.Font = new Font("Bernard MT Condensed", 14.25F);
            btnAttJ2.ForeColor = Color.Red;
            btnAttJ2.Location = new Point(579, 268);
            btnAttJ2.Name = "btnAttJ2";
            btnAttJ2.Size = new Size(86, 35);
            btnAttJ2.TabIndex = 5;
            btnAttJ2.Text = "Ataque";
            btnAttJ2.UseVisualStyleBackColor = true;
            btnAttJ2.Click += btnAttJ2_Click;
            // 
            // btnDfsJ1
            // 
            btnDfsJ1.Font = new Font("Bernard MT Condensed", 14.25F);
            btnDfsJ1.ForeColor = Color.Blue;
            btnDfsJ1.Location = new Point(49, 369);
            btnDfsJ1.Name = "btnDfsJ1";
            btnDfsJ1.Size = new Size(86, 33);
            btnDfsJ1.TabIndex = 6;
            btnDfsJ1.Text = "Defesa";
            btnDfsJ1.UseVisualStyleBackColor = true;
            btnDfsJ1.Click += btnDfsJ1_Click;
            // 
            // btnDfsJ2
            // 
            btnDfsJ2.Enabled = false;
            btnDfsJ2.Font = new Font("Bernard MT Condensed", 14.25F);
            btnDfsJ2.ForeColor = Color.Blue;
            btnDfsJ2.Location = new Point(579, 369);
            btnDfsJ2.Name = "btnDfsJ2";
            btnDfsJ2.Size = new Size(86, 33);
            btnDfsJ2.TabIndex = 7;
            btnDfsJ2.Text = "Defesa";
            btnDfsJ2.UseVisualStyleBackColor = true;
            btnDfsJ2.Click += btnDfsJ2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.sung;
            pictureBox1.Location = new Point(141, 245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.beru;
            pictureBox2.Location = new Point(417, 239);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cave_doungeon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(718, 429);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnDfsJ2);
            Controls.Add(btnDfsJ1);
            Controls.Add(btnAttJ2);
            Controls.Add(btnAttJ1);
            Controls.Add(tbxVidaJ2);
            Controls.Add(tbxVidaJ1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxVidaJ1;
        private TextBox tbxVidaJ2;
        private Button btnAttJ1;
        private Button btnAttJ2;
        private Button btnDfsJ1;
        private Button btnDfsJ2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
