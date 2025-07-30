namespace Escola
{
    partial class F_Diretor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Diretor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciarProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosEEstatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvListaContratos = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarProfessoresToolStripMenuItem,
            this.relatóriosEEstatísticasToolStripMenuItem,
            this.contratoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciarProfessoresToolStripMenuItem
            // 
            this.gerenciarProfessoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.deletarToolStripMenuItem});
            this.gerenciarProfessoresToolStripMenuItem.Name = "gerenciarProfessoresToolStripMenuItem";
            this.gerenciarProfessoresToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.gerenciarProfessoresToolStripMenuItem.Text = "Gerenciar Professores";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            // 
            // relatóriosEEstatísticasToolStripMenuItem
            // 
            this.relatóriosEEstatísticasToolStripMenuItem.Name = "relatóriosEEstatísticasToolStripMenuItem";
            this.relatóriosEEstatísticasToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.relatóriosEEstatísticasToolStripMenuItem.Text = "Relatórios e Estatísticas";
            // 
            // contratoToolStripMenuItem
            // 
            this.contratoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professorTSMI,
            this.gerenciarToolStripMenuItem});
            this.contratoToolStripMenuItem.Name = "contratoToolStripMenuItem";
            this.contratoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.contratoToolStripMenuItem.Text = "Contrato";
            // 
            // professorTSMI
            // 
            this.professorTSMI.Name = "professorTSMI";
            this.professorTSMI.Size = new System.Drawing.Size(180, 22);
            this.professorTSMI.Text = "professor";
            this.professorTSMI.Click += new System.EventHandler(this.professorTSMI_Click);
            // 
            // dgvListaContratos
            // 
            this.dgvListaContratos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaContratos.Location = new System.Drawing.Point(22, 56);
            this.dgvListaContratos.Name = "dgvListaContratos";
            this.dgvListaContratos.ReadOnly = true;
            this.dgvListaContratos.RowHeadersVisible = false;
            this.dgvListaContratos.Size = new System.Drawing.Size(742, 365);
            this.dgvListaContratos.TabIndex = 2;
            this.dgvListaContratos.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Location = new System.Drawing.Point(664, 27);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Visible = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            this.gerenciarToolStripMenuItem.Click += new System.EventHandler(this.gerenciarToolStripMenuItem_Click_2);
            // 
            // F_Diretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escola.Properties.Resources.FundoDrt;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvListaContratos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Diretor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina do Diretor";
            this.Load += new System.EventHandler(this.F_Diretor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosEEstatísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorTSMI;
        private System.Windows.Forms.DataGridView dgvListaContratos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
    }
}