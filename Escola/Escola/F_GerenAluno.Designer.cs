namespace Escola
{
    partial class F_GerenAluno
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
            this.dgvListaAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaAlunos
            // 
            this.dgvListaAlunos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAlunos.Location = new System.Drawing.Point(12, 93);
            this.dgvListaAlunos.Name = "dgvListaAlunos";
            this.dgvListaAlunos.Size = new System.Drawing.Size(717, 475);
            this.dgvListaAlunos.TabIndex = 0;
            this.dgvListaAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAlunos_CellContentClick);
            // 
            // F_GerenAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 580);
            this.Controls.Add(this.dgvListaAlunos);
            this.Name = "F_GerenAluno";
            this.Text = "F_GerenAluno";
            this.Load += new System.EventHandler(this.F_GerenAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaAlunos;
    }
}