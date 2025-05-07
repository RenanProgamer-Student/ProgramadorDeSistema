namespace SomaPrecos
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
            tbxQuantidade = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 57);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Preços";
            // 
            // tbxQuantidade
            // 
            tbxQuantidade.Location = new Point(239, 54);
            tbxQuantidade.Name = "tbxQuantidade";
            tbxQuantidade.Size = new Size(111, 23);
            tbxQuantidade.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(206, 111);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 32);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.Anchor = AnchorStyles.Bottom;
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label2";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            lblResultado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 231);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(tbxQuantidade);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxQuantidade;
        private Button btnCalcular;
        private Label lblResultado;
    }
}
