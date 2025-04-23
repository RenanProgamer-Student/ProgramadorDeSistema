namespace Transporte
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
            cbbTipo = new ComboBox();
            tbxDistancia = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cbbTipo
            // 
            cbbTipo.FormattingEnabled = true;
            cbbTipo.Items.AddRange(new object[] { "Moto", "Carro", "Black" });
            cbbTipo.Location = new Point(117, 174);
            cbbTipo.Name = "cbbTipo";
            cbbTipo.Size = new Size(150, 23);
            cbbTipo.TabIndex = 0;
            cbbTipo.Text = "Moto";
            // 
            // tbxDistancia
            // 
            tbxDistancia.Location = new Point(143, 242);
            tbxDistancia.Name = "tbxDistancia";
            tbxDistancia.Size = new Size(100, 23);
            tbxDistancia.TabIndex = 1;
            tbxDistancia.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Swis721 Hv BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(143, 314);
            button1.Name = "button1";
            button1.Size = new Size(100, 33);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(57, 171);
            label1.Name = "label1";
            label1.Size = new Size(54, 29);
            label1.TabIndex = 3;
            label1.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 18F);
            label2.Location = new Point(6, 242);
            label2.Name = "label2";
            label2.Size = new Size(105, 29);
            label2.TabIndex = 4;
            label2.Text = "Distancia";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(395, 569);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(tbxDistancia);
            Controls.Add(cbbTipo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbTipo;
        private TextBox tbxDistancia;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
