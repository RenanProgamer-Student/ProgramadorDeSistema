namespace Adivinhe
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
            tbxNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbxCreditos = new TextBox();
            btnVerificar = new Button();
            lblResultado = new Label();
            btnRecarregar = new Button();
            SuspendLayout();
            // 
            // tbxNumero
            // 
            tbxNumero.Location = new Point(208, 219);
            tbxNumero.Name = "tbxNumero";
            tbxNumero.Size = new Size(156, 23);
            tbxNumero.TabIndex = 0;
            tbxNumero.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Creditos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Forte", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(165, 184);
            label2.Name = "label2";
            label2.Size = new Size(233, 21);
            label2.TabIndex = 2;
            label2.Text = "Adivinhe o numero de 1 a 10";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxCreditos
            // 
            tbxCreditos.Location = new Point(69, 6);
            tbxCreditos.Name = "tbxCreditos";
            tbxCreditos.ReadOnly = true;
            tbxCreditos.Size = new Size(36, 23);
            tbxCreditos.TabIndex = 3;
            tbxCreditos.Text = "10";
            tbxCreditos.TextAlign = HorizontalAlignment.Center;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.Orange;
            btnVerificar.FlatStyle = FlatStyle.Popup;
            btnVerificar.Font = new Font("Matura MT Script Capitals", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificar.ForeColor = Color.White;
            btnVerificar.Location = new Point(241, 260);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(88, 28);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.FlatStyle = FlatStyle.System;
            lblResultado.Font = new Font("News706 BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(41, 393);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(52, 18);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "label3";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            lblResultado.Visible = false;
            // 
            // btnRecarregar
            // 
            btnRecarregar.BackColor = Color.Orange;
            btnRecarregar.FlatStyle = FlatStyle.Popup;
            btnRecarregar.Font = new Font("Matura MT Script Capitals", 12F);
            btnRecarregar.ForeColor = Color.White;
            btnRecarregar.Location = new Point(473, 5);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(101, 38);
            btnRecarregar.TabIndex = 6;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = false;
            btnRecarregar.Click += btnRecarregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.adivinhe_Tiger;
            ClientSize = new Size(586, 452);
            Controls.Add(btnRecarregar);
            Controls.Add(lblResultado);
            Controls.Add(btnVerificar);
            Controls.Add(tbxCreditos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNumero;
        private Label label1;
        private Label label2;
        private TextBox tbxCreditos;
        private Button btnVerificar;
        private Label lblResultado;
        private Button btnRecarregar;
    }
}
