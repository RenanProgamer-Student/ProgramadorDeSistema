namespace CinemaInterfaceAula3
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
            lbl1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            lblFaturamento = new Label();
            tbxPreco = new TextBox();
            tbxQuantidade = new TextBox();
            tbxFaturamento = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(226, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(134, 40);
            lbl1.TabIndex = 0;
            lbl1.Text = "Cinema";
            lbl1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Agency FB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(162, 108);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 1;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Agency FB", 15.75F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(133, 179);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Quantidade";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(244, 249);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(116, 39);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblFaturamento
            // 
            lblFaturamento.AutoSize = true;
            lblFaturamento.BackColor = Color.Transparent;
            lblFaturamento.Font = new Font("Agency FB", 15.75F);
            lblFaturamento.Location = new Point(123, 328);
            lblFaturamento.Name = "lblFaturamento";
            lblFaturamento.Size = new Size(87, 25);
            lblFaturamento.TabIndex = 4;
            lblFaturamento.Text = "Faturamento";
            lblFaturamento.Visible = false;
            // 
            // tbxPreco
            // 
            tbxPreco.Location = new Point(233, 110);
            tbxPreco.Name = "tbxPreco";
            tbxPreco.Size = new Size(139, 23);
            tbxPreco.TabIndex = 5;
            // 
            // tbxQuantidade
            // 
            tbxQuantidade.Location = new Point(233, 181);
            tbxQuantidade.Name = "tbxQuantidade";
            tbxQuantidade.Size = new Size(139, 23);
            tbxQuantidade.TabIndex = 6;
            // 
            // tbxFaturamento
            // 
            tbxFaturamento.Location = new Point(233, 330);
            tbxFaturamento.Name = "tbxFaturamento";
            tbxFaturamento.Size = new Size(139, 23);
            tbxFaturamento.TabIndex = 7;
            tbxFaturamento.TextAlign = HorizontalAlignment.Center;
            tbxFaturamento.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fundo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(590, 418);
            Controls.Add(tbxFaturamento);
            Controls.Add(tbxQuantidade);
            Controls.Add(tbxPreco);
            Controls.Add(lblFaturamento);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private Label lblFaturamento;
        private TextBox tbxPreco;
        private TextBox tbxQuantidade;
        private TextBox tbxFaturamento;
    }
}
