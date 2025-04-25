namespace viagem
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
            cbxDestino = new ComboBox();
            tbxDiarias = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 150);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 0;
            label1.Text = "Destino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bernard MT Condensed", 12F);
            label2.Location = new Point(28, 258);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 1;
            label2.Text = "Diarias";
            // 
            // cbxDestino
            // 
            cbxDestino.FormattingEnabled = true;
            cbxDestino.Items.AddRange(new object[] { "São Paulo", "Londres", "Dallas" });
            cbxDestino.Location = new Point(117, 147);
            cbxDestino.Name = "cbxDestino";
            cbxDestino.Size = new Size(160, 23);
            cbxDestino.TabIndex = 2;
            cbxDestino.Text = "São Paulo";
            // 
            // tbxDiarias
            // 
            tbxDiarias.Location = new Point(117, 255);
            tbxDiarias.Name = "tbxDiarias";
            tbxDiarias.Size = new Size(160, 23);
            tbxDiarias.TabIndex = 3;
            tbxDiarias.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.WhiteSmoke;
            btnCalcular.FlatStyle = FlatStyle.Popup;
            btnCalcular.Font = new Font("Swis721 BlkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(135, 335);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(117, 31);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_airplanes;
            ClientSize = new Size(587, 455);
            Controls.Add(btnCalcular);
            Controls.Add(tbxDiarias);
            Controls.Add(cbxDestino);
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
        private ComboBox cbxDestino;
        private TextBox tbxDiarias;
        private Button btnCalcular;
    }
}
