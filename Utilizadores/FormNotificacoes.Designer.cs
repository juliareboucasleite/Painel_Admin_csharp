namespace Painel_Admin
{
    partial class FormNotificacoes
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotificacoes));
            this.dgvNotificacoes = new System.Windows.Forms.DataGridView();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificacoes)).BeginInit();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNotificacoes
            // 
            this.dgvNotificacoes.AllowUserToAddRows = false;
            this.dgvNotificacoes.AllowUserToDeleteRows = false;
            this.dgvNotificacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotificacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotificacoes.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotificacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotificacoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvNotificacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificacoes.EnableHeadersVisualStyles = false;
            this.dgvNotificacoes.GridColor = System.Drawing.Color.LightGray;
            this.dgvNotificacoes.Location = new System.Drawing.Point(0, 0);
            this.dgvNotificacoes.MultiSelect = false;
            this.dgvNotificacoes.Name = "dgvNotificacoes";
            this.dgvNotificacoes.ReadOnly = true;
            this.dgvNotificacoes.RowHeadersVisible = false;
            this.dgvNotificacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotificacoes.Size = new System.Drawing.Size(900, 420);
            this.dgvNotificacoes.TabIndex = 0;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBotoes.BackColor = System.Drawing.Color.Orange;
            this.panelBotoes.Controls.Add(this.btnEditar);
            this.panelBotoes.Controls.Add(this.btnRemover);
            this.panelBotoes.Controls.Add(this.btnAtualizar);
            this.panelBotoes.Location = new System.Drawing.Point(0, 420);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(900, 45);
            this.panelBotoes.TabIndex = 1;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(12, 10);
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
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(112, 10);
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
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(212, 10);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 27);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "🔄 &Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FormNotificacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(900, 465);
            this.Controls.Add(this.dgvNotificacoes);
            this.Controls.Add(this.panelBotoes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotificacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Notificações";
            this.Load += new System.EventHandler(this.FormNotificacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificacoes)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotificacoes;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
