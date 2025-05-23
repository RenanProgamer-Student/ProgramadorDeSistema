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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            gereciarProfessoresToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            relatorioEEstatisticasToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            notifyIcon1 = new NotifyIcon(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gereciarProfessoresToolStripMenuItem, relatorioEEstatisticasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1030, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gereciarProfessoresToolStripMenuItem
            // 
            gereciarProfessoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, editarToolStripMenuItem, listarToolStripMenuItem, deletarToolStripMenuItem });
            gereciarProfessoresToolStripMenuItem.Name = "gereciarProfessoresToolStripMenuItem";
            gereciarProfessoresToolStripMenuItem.Size = new Size(125, 20);
            gereciarProfessoresToolStripMenuItem.Text = "Gereciar Professores";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(124, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(124, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(124, 22);
            listarToolStripMenuItem.Text = "Listar";
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.Size = new Size(124, 22);
            deletarToolStripMenuItem.Text = "Deletar";
            // 
            // relatorioEEstatisticasToolStripMenuItem
            // 
            relatorioEEstatisticasToolStripMenuItem.Name = "relatorioEEstatisticasToolStripMenuItem";
            relatorioEEstatisticasToolStripMenuItem.Size = new Size(135, 20);
            relatorioEEstatisticasToolStripMenuItem.Text = "Relatorio e Estatisticas";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // F_Diretor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 590);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "F_Diretor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela do Diretor";
            Load += F_Diretor_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gereciarProfessoresToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem deletarToolStripMenuItem;
        private ToolStripMenuItem relatorioEEstatisticasToolStripMenuItem;
        private ToolTip toolTip1;
        private NotifyIcon notifyIcon1;
    }
}