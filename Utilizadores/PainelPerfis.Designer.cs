namespace Painel_Admin
{
    partial class PainelPerfis
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelPerfis));
            this.dgvPerfis = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panelBotoes = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfis)).BeginInit();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPerfis
            // 
            this.dgvPerfis.AllowUserToAddRows = false;
            this.dgvPerfis.AllowUserToDeleteRows = false;
            this.dgvPerfis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPerfis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerfis.BackgroundColor = System.Drawing.Color.White;
            this.dgvPerfis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerfis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPerfis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerfis.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPerfis.EnableHeadersVisualStyles = false;
            this.dgvPerfis.Location = new System.Drawing.Point(0, 0);
            this.dgvPerfis.MultiSelect = false;
            this.dgvPerfis.Name = "dgvPerfis";
            this.dgvPerfis.ReadOnly = true;
            this.dgvPerfis.RowHeadersVisible = false;
            this.dgvPerfis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerfis.Size = new System.Drawing.Size(900, 429);
            this.dgvPerfis.TabIndex = 0;
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
            this.btnAdicionar.Location = new System.Drawing.Point(11, 8);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(90, 27);
            this.btnAdicionar.TabIndex = 4;
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
            this.btnEditar.Location = new System.Drawing.Point(111, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 27);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "✏️ &Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnRemover.Location = new System.Drawing.Point(211, 8);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(90, 27);
            this.btnRemover.TabIndex = 2;
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
            this.btnAtualizar.Location = new System.Drawing.Point(311, 8);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(90, 27);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "🔄 &Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // panelBotoes
            // 
            this.panelBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotoes.BackColor = System.Drawing.Color.Orange;
            this.panelBotoes.Controls.Add(this.btnAdicionar);
            this.panelBotoes.Controls.Add(this.btnEditar);
            this.panelBotoes.Controls.Add(this.btnRemover);
            this.panelBotoes.Controls.Add(this.btnAtualizar);
            this.panelBotoes.Location = new System.Drawing.Point(0, 427);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(900, 45);
            this.panelBotoes.TabIndex = 1;
            // 
            // PainelPerfis
            // 
            this.ClientSize = new System.Drawing.Size(900, 465);
            this.Controls.Add(this.dgvPerfis);
            this.Controls.Add(this.panelBotoes);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PainelPerfis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Perfis de Administradores";
            this.Load += new System.EventHandler(this.PainelPerfis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfis)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerfis;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panelBotoes;
    }
}
