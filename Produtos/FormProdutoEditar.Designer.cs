namespace Painel_Admin
{
    partial class FormProdutoEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutoEditar));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblPrecoAlvo = new System.Windows.Forms.Label();
            this.txtPrecoAlvo = new System.Windows.Forms.TextBox();
            this.lblDataLimite = new System.Windows.Forms.Label();
            this.dtpDataLimite = new System.Windows.Forms.DateTimePicker();
            this.chkSemData = new System.Windows.Forms.CheckBox();
            this.lblLoja = new System.Windows.Forms.Label();
            this.txtLoja = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxID = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNome.Location = new System.Drawing.Point(15, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "&Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome.Location = new System.Drawing.Point(89, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblLink
            // 
            this.lblLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLink.Location = new System.Drawing.Point(15, 58);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(32, 15);
            this.lblLink.TabIndex = 2;
            this.lblLink.Text = "&Link:";
            // 
            // txtLink
            // 
            this.txtLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLink.Location = new System.Drawing.Point(89, 56);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(281, 23);
            this.txtLink.TabIndex = 3;
            this.txtLink.TextChanged += new System.EventHandler(this.txtLink_TextChanged);
            // 
            // lblPrecoAlvo
            // 
            this.lblPrecoAlvo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecoAlvo.AutoSize = true;
            this.lblPrecoAlvo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrecoAlvo.Location = new System.Drawing.Point(15, 95);
            this.lblPrecoAlvo.Name = "lblPrecoAlvo";
            this.lblPrecoAlvo.Size = new System.Drawing.Size(67, 15);
            this.lblPrecoAlvo.TabIndex = 4;
            this.lblPrecoAlvo.Text = "&Preço Alvo:";
            // 
            // txtPrecoAlvo
            // 
            this.txtPrecoAlvo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoAlvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoAlvo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecoAlvo.Location = new System.Drawing.Point(89, 91);
            this.txtPrecoAlvo.Name = "txtPrecoAlvo";
            this.txtPrecoAlvo.Size = new System.Drawing.Size(86, 23);
            this.txtPrecoAlvo.TabIndex = 5;
            this.txtPrecoAlvo.TextChanged += new System.EventHandler(this.txtPrecoAlvo_TextChanged);
            // 
            // lblDataLimite
            // 
            this.lblDataLimite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataLimite.AutoSize = true;
            this.lblDataLimite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDataLimite.Location = new System.Drawing.Point(15, 160);
            this.lblDataLimite.Name = "lblDataLimite";
            this.lblDataLimite.Size = new System.Drawing.Size(70, 15);
            this.lblDataLimite.TabIndex = 8;
            this.lblDataLimite.Text = "&Data Limite:";
            // 
            // dtpDataLimite
            // 
            this.dtpDataLimite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataLimite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDataLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLimite.Location = new System.Drawing.Point(89, 157);
            this.dtpDataLimite.Name = "dtpDataLimite";
            this.dtpDataLimite.Size = new System.Drawing.Size(103, 23);
            this.dtpDataLimite.TabIndex = 9;
            // 
            // chkSemData
            // 
            this.chkSemData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSemData.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSemData.AutoSize = true;
            this.chkSemData.BackColor = System.Drawing.Color.Orange;
            this.chkSemData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkSemData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSemData.Location = new System.Drawing.Point(200, 158);
            this.chkSemData.Name = "chkSemData";
            this.chkSemData.Size = new System.Drawing.Size(71, 23);
            this.chkSemData.TabIndex = 10;
            this.chkSemData.Text = "Sem limite";
            this.chkSemData.UseVisualStyleBackColor = false;
            // 
            // lblLoja
            // 
            this.lblLoja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoja.AutoSize = true;
            this.lblLoja.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoja.Location = new System.Drawing.Point(15, 195);
            this.lblLoja.Name = "lblLoja";
            this.lblLoja.Size = new System.Drawing.Size(32, 15);
            this.lblLoja.TabIndex = 11;
            this.lblLoja.Text = "&Loja:";
            // 
            // txtLoja
            // 
            this.txtLoja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoja.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoja.Location = new System.Drawing.Point(89, 191);
            this.txtLoja.Name = "txtLoja";
            this.txtLoja.Size = new System.Drawing.Size(214, 23);
            this.txtLoja.TabIndex = 12;
            this.txtLoja.TextChanged += new System.EventHandler(this.txtLoja_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(89, 229);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(86, 26);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "💾 Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(217, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 26);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "❌ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "&ID Utilizador:";
            // 
            // ComboBoxID
            // 
            this.ComboBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxID.FormattingEnabled = true;
            this.ComboBoxID.Location = new System.Drawing.Point(89, 125);
            this.ComboBoxID.Name = "ComboBoxID";
            this.ComboBoxID.Size = new System.Drawing.Size(61, 21);
            this.ComboBoxID.TabIndex = 7;
            this.ComboBoxID.SelectedIndexChanged += new System.EventHandler(this.ComboBoxID_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Painel_Admin.Properties.Resources.android_chrome_192x1921;
            this.pictureBox2.Location = new System.Drawing.Point(450, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // FormProdutoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(627, 274);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ComboBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblPrecoAlvo);
            this.Controls.Add(this.txtPrecoAlvo);
            this.Controls.Add(this.lblDataLimite);
            this.Controls.Add(this.dtpDataLimite);
            this.Controls.Add(this.chkSemData);
            this.Controls.Add(this.lblLoja);
            this.Controls.Add(this.txtLoja);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProdutoEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Produto";
            this.Load += new System.EventHandler(this.FormProdutoEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblPrecoAlvo;
        private System.Windows.Forms.TextBox txtPrecoAlvo;
        private System.Windows.Forms.Label lblDataLimite;
        private System.Windows.Forms.DateTimePicker dtpDataLimite;
        private System.Windows.Forms.CheckBox chkSemData;
        private System.Windows.Forms.Label lblLoja;
        private System.Windows.Forms.TextBox txtLoja;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxID;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
