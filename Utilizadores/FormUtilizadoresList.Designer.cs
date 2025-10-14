namespace Painel_Admin
{
    partial class FormUtilizadoresList
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtilizadoresList));
            this.dgvUtilizadores = new System.Windows.Forms.DataGridView();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizadores)).BeginInit();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUtilizadores
            // 
            this.dgvUtilizadores.AllowUserToAddRows = false;
            this.dgvUtilizadores.AllowUserToDeleteRows = false;
            this.dgvUtilizadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUtilizadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtilizadores.BackgroundColor = System.Drawing.Color.White;
            this.dgvUtilizadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUtilizadores.Location = new System.Drawing.Point(0, 0);
            this.dgvUtilizadores.MultiSelect = false;
            this.dgvUtilizadores.Name = "dgvUtilizadores";
            this.dgvUtilizadores.ReadOnly = true;
            this.dgvUtilizadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtilizadores.Size = new System.Drawing.Size(900, 420);
            this.dgvUtilizadores.TabIndex = 0;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotoes.BackColor = System.Drawing.Color.Orange;
            this.panelBotoes.Controls.Add(this.btnAdicionar);
            this.panelBotoes.Controls.Add(this.btnEditar);
            this.panelBotoes.Controls.Add(this.btnDetalhes);
            this.panelBotoes.Controls.Add(this.btnRemover);
            this.panelBotoes.Controls.Add(this.btnAtualizar);
            this.panelBotoes.ForeColor = System.Drawing.Color.Transparent;
            this.panelBotoes.Location = new System.Drawing.Point(0, 417);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(900, 51);
            this.panelBotoes.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(10, 10);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(90, 33);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "➕ &Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(110, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 33);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "✏️ &Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalhes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetalhes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDetalhes.ForeColor = System.Drawing.Color.White;
            this.btnDetalhes.Location = new System.Drawing.Point(208, 9);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(90, 33);
            this.btnDetalhes.TabIndex = 2;
            this.btnDetalhes.Text = "➕ &Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = false;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(308, 9);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(90, 33);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "🗑️ &Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.BackColor = System.Drawing.Color.DimGray;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(408, 9);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(90, 33);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "🔄 &Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FormUtilizadoresList
            // 
            this.ClientSize = new System.Drawing.Size(900, 465);
            this.Controls.Add(this.dgvUtilizadores);
            this.Controls.Add(this.panelBotoes);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUtilizadoresList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Utilizadores";
            this.Load += new System.EventHandler(this.FormUtilizadoresList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizadores)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUtilizadores;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
