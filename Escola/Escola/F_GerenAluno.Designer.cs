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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GerenAluno));
            this.dgvListaAlunos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFiltroNome = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.tbxCpf = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaAlunos
            // 
            this.dgvListaAlunos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAlunos.Location = new System.Drawing.Point(12, 93);
            this.dgvListaAlunos.Name = "dgvListaAlunos";
            this.dgvListaAlunos.ReadOnly = true;
            this.dgvListaAlunos.RowHeadersVisible = false;
            this.dgvListaAlunos.Size = new System.Drawing.Size(562, 430);
            this.dgvListaAlunos.TabIndex = 0;
            this.dgvListaAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAlunos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar por nome:";
            // 
            // tbxFiltroNome
            // 
            this.tbxFiltroNome.Location = new System.Drawing.Point(143, 42);
            this.tbxFiltroNome.Name = "tbxFiltroNome";
            this.tbxFiltroNome.Size = new System.Drawing.Size(262, 20);
            this.tbxFiltroNome.TabIndex = 2;
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.White;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltro.Location = new System.Drawing.Point(411, 40);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Pesquisar";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.BackColor = System.Drawing.Color.White;
            this.btnEditarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAluno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditarAluno.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEditarAluno.Location = new System.Drawing.Point(675, 228);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(87, 30);
            this.btnEditarAluno.TabIndex = 40;
            this.btnEditarAluno.Text = "Editar";
            this.btnEditarAluno.UseVisualStyleBackColor = false;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(637, 178);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDataNascimento.Size = new System.Drawing.Size(175, 20);
            this.dtpDataNascimento.TabIndex = 39;
            // 
            // tbxCpf
            // 
            this.tbxCpf.Location = new System.Drawing.Point(637, 118);
            this.tbxCpf.MaxLength = 14;
            this.tbxCpf.Name = "tbxCpf";
            this.tbxCpf.Size = new System.Drawing.Size(175, 20);
            this.tbxCpf.TabIndex = 35;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(637, 80);
            this.tbxNome.MaxLength = 250;
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(175, 20);
            this.tbxNome.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bell MT", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(660, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Data de Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bell MT", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(600, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cpf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(586, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(628, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Editar ALUNO";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.White;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSelecionar.Location = new System.Drawing.Point(487, 538);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(87, 30);
            this.btnSelecionar.TabIndex = 41;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.White;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDeletar.Location = new System.Drawing.Point(394, 538);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(87, 30);
            this.btnDeletar.TabIndex = 42;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // F_GerenAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 580);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.tbxCpf);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.tbxFiltroNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaAlunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_GerenAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel Gerenciar Alunos";
            this.Load += new System.EventHandler(this.F_GerenAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFiltroNome;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox tbxCpf;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnDeletar;
    }
}