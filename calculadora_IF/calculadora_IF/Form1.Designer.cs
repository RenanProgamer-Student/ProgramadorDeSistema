namespace calculadora_IF
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
            cbxOperador = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxN1 = new TextBox();
            tbxN2 = new TextBox();
            label4 = new Label();
            tbxResultado = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // cbxOperador
            // 
            cbxOperador.FormattingEnabled = true;
            cbxOperador.Items.AddRange(new object[] { "Soma", "Subtração", "Multiplicação", "Divisão" });
            cbxOperador.Location = new Point(189, 161);
            cbxOperador.Name = "cbxOperador";
            cbxOperador.Size = new Size(121, 23);
            cbxOperador.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 1;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(23, 90);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 2;
            label2.Text = "Número 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(23, 150);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 3;
            label3.Text = "Operador";
            // 
            // tbxN1
            // 
            tbxN1.Location = new Point(189, 39);
            tbxN1.Name = "tbxN1";
            tbxN1.Size = new Size(121, 23);
            tbxN1.TabIndex = 4;
            // 
            // tbxN2
            // 
            tbxN2.Location = new Point(189, 101);
            tbxN2.Name = "tbxN2";
            tbxN2.Size = new Size(121, 23);
            tbxN2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(23, 242);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 6;
            label4.Text = "Resultado";
            // 
            // tbxResultado
            // 
            tbxResultado.Location = new Point(189, 251);
            tbxResultado.Name = "tbxResultado";
            tbxResultado.ReadOnly = true;
            tbxResultado.Size = new Size(121, 23);
            tbxResultado.TabIndex = 7;
            tbxResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(130, 343);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(99, 35);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 508);
            Controls.Add(btnCalcular);
            Controls.Add(tbxResultado);
            Controls.Add(label4);
            Controls.Add(tbxN2);
            Controls.Add(tbxN1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxOperador);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxOperador;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbxN1;
        private TextBox tbxN2;
        private Label label4;
        private TextBox tbxResultado;
        private Button btnCalcular;
    }
}
