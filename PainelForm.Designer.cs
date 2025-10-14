namespace Painel_Admin
{
    partial class PainelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PainelPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.painelPerfisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelPerfisUtilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificaçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.cardUsers = new System.Windows.Forms.Panel();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.picUsers = new System.Windows.Forms.PictureBox();
            this.cardProdutos = new System.Windows.Forms.Panel();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.picProdutos = new System.Windows.Forms.PictureBox();
            this.cardNotificacoes = new System.Windows.Forms.Panel();
            this.lblTotalNotificacoes = new System.Windows.Forms.Label();
            this.picNotificacoes = new System.Windows.Forms.PictureBox();
            this.cardPoupado = new System.Windows.Forms.Panel();
            this.lblTotalPoupado = new System.Windows.Forms.Label();
            this.picPoupado = new System.Windows.Forms.PictureBox();
            this.btnAtualizarDashboard = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.cardUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).BeginInit();
            this.cardProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).BeginInit();
            this.cardNotificacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNotificacoes)).BeginInit();
            this.cardPoupado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoupado)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.PainelPrincipal,
            this.notificaçõesToolStripMenuItem,
            this.suporteToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarProdutosToolStripMenuItem});
            this.produtosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            resources.ApplyResources(this.produtosToolStripMenuItem, "produtosToolStripMenuItem");
            // 
            // editarProdutosToolStripMenuItem
            // 
            resources.ApplyResources(this.editarProdutosToolStripMenuItem, "editarProdutosToolStripMenuItem");
            this.editarProdutosToolStripMenuItem.Name = "editarProdutosToolStripMenuItem";
            this.editarProdutosToolStripMenuItem.Click += new System.EventHandler(this.editarProdutosToolStripMenuItem_Click);
            // 
            // PainelPrincipal
            // 
            this.PainelPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.painelPerfisToolStripMenuItem,
            this.painelPerfisUtilizadoresToolStripMenuItem});
            this.PainelPrincipal.ForeColor = System.Drawing.Color.White;
            this.PainelPrincipal.Name = "PainelPrincipal";
            resources.ApplyResources(this.PainelPrincipal, "PainelPrincipal");
            // 
            // painelPerfisToolStripMenuItem
            // 
            resources.ApplyResources(this.painelPerfisToolStripMenuItem, "painelPerfisToolStripMenuItem");
            this.painelPerfisToolStripMenuItem.Name = "painelPerfisToolStripMenuItem";
            this.painelPerfisToolStripMenuItem.Click += new System.EventHandler(this.painelPerfisToolStripMenuItem_Click);
            // 
            // painelPerfisUtilizadoresToolStripMenuItem
            // 
            this.painelPerfisUtilizadoresToolStripMenuItem.Image = global::Painel_Admin.Properties.Resources.Usuario;
            this.painelPerfisUtilizadoresToolStripMenuItem.Name = "painelPerfisUtilizadoresToolStripMenuItem";
            resources.ApplyResources(this.painelPerfisUtilizadoresToolStripMenuItem, "painelPerfisUtilizadoresToolStripMenuItem");
            this.painelPerfisUtilizadoresToolStripMenuItem.Click += new System.EventHandler(this.painelPerfisUtilizadoresToolStripMenuItem_Click);
            // 
            // notificaçõesToolStripMenuItem
            // 
            this.notificaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificaçõesToolStripMenuItem1});
            this.notificaçõesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.notificaçõesToolStripMenuItem.Name = "notificaçõesToolStripMenuItem";
            resources.ApplyResources(this.notificaçõesToolStripMenuItem, "notificaçõesToolStripMenuItem");
            // 
            // notificaçõesToolStripMenuItem1
            // 
            this.notificaçõesToolStripMenuItem1.Image = global::Painel_Admin.Properties.Resources.Notificacoes;
            this.notificaçõesToolStripMenuItem1.Name = "notificaçõesToolStripMenuItem1";
            resources.ApplyResources(this.notificaçõesToolStripMenuItem1, "notificaçõesToolStripMenuItem1");
            this.notificaçõesToolStripMenuItem1.Click += new System.EventHandler(this.notificacoesToolStripMenuItem1_Click);
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            resources.ApplyResources(this.suporteToolStripMenuItem, "suporteToolStripMenuItem");
            this.suporteToolStripMenuItem.Click += new System.EventHandler(this.suporteToolStripMenuItem_Click);
            // 
            // panelDashboard
            // 
            resources.ApplyResources(this.panelDashboard, "panelDashboard");
            this.panelDashboard.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDashboard.Controls.Add(this.cardUsers);
            this.panelDashboard.Controls.Add(this.cardProdutos);
            this.panelDashboard.Controls.Add(this.cardNotificacoes);
            this.panelDashboard.Controls.Add(this.cardPoupado);
            this.panelDashboard.Name = "panelDashboard";
            // 
            // cardUsers
            // 
            this.cardUsers.BackColor = System.Drawing.Color.White;
            this.cardUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardUsers.Controls.Add(this.lblTotalUsers);
            this.cardUsers.Controls.Add(this.picUsers);
            resources.ApplyResources(this.cardUsers, "cardUsers");
            this.cardUsers.Name = "cardUsers";
            // 
            // lblTotalUsers
            // 
            resources.ApplyResources(this.lblTotalUsers, "lblTotalUsers");
            this.lblTotalUsers.ForeColor = System.Drawing.Color.Black;
            this.lblTotalUsers.Name = "lblTotalUsers";
            // 
            // picUsers
            // 
            resources.ApplyResources(this.picUsers, "picUsers");
            this.picUsers.Name = "picUsers";
            this.picUsers.TabStop = false;
            // 
            // cardProdutos
            // 
            this.cardProdutos.BackColor = System.Drawing.Color.White;
            this.cardProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardProdutos.Controls.Add(this.lblTotalProdutos);
            this.cardProdutos.Controls.Add(this.picProdutos);
            resources.ApplyResources(this.cardProdutos, "cardProdutos");
            this.cardProdutos.Name = "cardProdutos";
            // 
            // lblTotalProdutos
            // 
            resources.ApplyResources(this.lblTotalProdutos, "lblTotalProdutos");
            this.lblTotalProdutos.ForeColor = System.Drawing.Color.Black;
            this.lblTotalProdutos.Name = "lblTotalProdutos";
            // 
            // picProdutos
            // 
            resources.ApplyResources(this.picProdutos, "picProdutos");
            this.picProdutos.Name = "picProdutos";
            this.picProdutos.TabStop = false;
            // 
            // cardNotificacoes
            // 
            this.cardNotificacoes.BackColor = System.Drawing.Color.White;
            this.cardNotificacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardNotificacoes.Controls.Add(this.lblTotalNotificacoes);
            this.cardNotificacoes.Controls.Add(this.picNotificacoes);
            resources.ApplyResources(this.cardNotificacoes, "cardNotificacoes");
            this.cardNotificacoes.Name = "cardNotificacoes";
            // 
            // lblTotalNotificacoes
            // 
            resources.ApplyResources(this.lblTotalNotificacoes, "lblTotalNotificacoes");
            this.lblTotalNotificacoes.ForeColor = System.Drawing.Color.Black;
            this.lblTotalNotificacoes.Name = "lblTotalNotificacoes";
            // 
            // picNotificacoes
            // 
            resources.ApplyResources(this.picNotificacoes, "picNotificacoes");
            this.picNotificacoes.Name = "picNotificacoes";
            this.picNotificacoes.TabStop = false;
            // 
            // cardPoupado
            // 
            this.cardPoupado.BackColor = System.Drawing.Color.White;
            this.cardPoupado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardPoupado.Controls.Add(this.lblTotalPoupado);
            this.cardPoupado.Controls.Add(this.picPoupado);
            resources.ApplyResources(this.cardPoupado, "cardPoupado");
            this.cardPoupado.Name = "cardPoupado";
            // 
            // lblTotalPoupado
            // 
            resources.ApplyResources(this.lblTotalPoupado, "lblTotalPoupado");
            this.lblTotalPoupado.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalPoupado.Name = "lblTotalPoupado";
            // 
            // picPoupado
            // 
            this.picPoupado.Image = global::Painel_Admin.Properties.Resources.Dinheiro;
            resources.ApplyResources(this.picPoupado, "picPoupado");
            this.picPoupado.Name = "picPoupado";
            this.picPoupado.TabStop = false;
            // 
            // btnAtualizarDashboard
            // 
            resources.ApplyResources(this.btnAtualizarDashboard, "btnAtualizarDashboard");
            this.btnAtualizarDashboard.BackColor = System.Drawing.Color.Orange;
            this.btnAtualizarDashboard.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarDashboard.Name = "btnAtualizarDashboard";
            this.btnAtualizarDashboard.UseVisualStyleBackColor = false;
            this.btnAtualizarDashboard.Click += new System.EventHandler(this.btnAtualizarDashboard_Click);
            // 
            // PainelForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnAtualizarDashboard);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PainelForm";
            this.Load += new System.EventHandler(this.PainelForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDashboard.ResumeLayout(false);
            this.cardUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUsers)).EndInit();
            this.cardProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProdutos)).EndInit();
            this.cardNotificacoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNotificacoes)).EndInit();
            this.cardPoupado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPoupado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PainelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem painelPerfisToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel panelDashboard;
        private System.Windows.Forms.Panel cardUsers;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.PictureBox picUsers;
        private System.Windows.Forms.Panel cardProdutos;
        private System.Windows.Forms.Label lblTotalProdutos;
        private System.Windows.Forms.PictureBox picProdutos;
        private System.Windows.Forms.Panel cardNotificacoes;
        private System.Windows.Forms.Label lblTotalNotificacoes;
        private System.Windows.Forms.PictureBox picNotificacoes;
        private System.Windows.Forms.Panel cardPoupado;
        private System.Windows.Forms.Label lblTotalPoupado;
        private System.Windows.Forms.PictureBox picPoupado;
        private System.Windows.Forms.Button btnAtualizarDashboard;
        private System.Windows.Forms.ToolStripMenuItem notificaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificaçõesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem painelPerfisUtilizadoresToolStripMenuItem;
    }
}
