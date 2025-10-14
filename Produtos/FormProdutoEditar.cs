using System;
using System.Windows.Forms;
using Painel_Admin.Auth;

namespace Painel_Admin
{
    public partial class FormProdutoEditar : Form
    {
        private readonly ProdutoRepository _produtoRepo;
        private int _id;

        public FormProdutoEditar()
        {
            InitializeComponent();
            _produtoRepo = new ProdutoRepository();
            _id = 0;

            chkSemData.Checked = true;
            dtpDataLimite.Enabled = false;
        }

        public FormProdutoEditar(int id, int userId, string nome, string link, decimal precoAlvo, DateTime? dataLimite, string loja)
        {
            InitializeComponent();
            _produtoRepo = new ProdutoRepository();
            _id = id;

            txtNome.Text = nome;
            txtLink.Text = link;
            txtPrecoAlvo.Text = precoAlvo.ToString("0.00");

            if (dataLimite.HasValue)
            {
                dtpDataLimite.Value = dataLimite.Value;
                chkSemData.Checked = false;
                dtpDataLimite.Enabled = true;
            }
            else
            {
                chkSemData.Checked = true;
                dtpDataLimite.Enabled = false;
            }

            txtLoja.Text = loja;
        }

        private void FormProdutoEditar_Load(object sender, EventArgs e)
        {
            try
            {
                var users = _produtoRepo.GetUserIdsComProdutos(); 
                ComboBoxID.DataSource = users;
                ComboBoxID.DisplayMember = "Nome"; 
                ComboBoxID.ValueMember = "Id";   
                ComboBoxID.SelectedIndex = -1;    

                chkSemData.CheckedChanged += (s, ev) =>
                {
                    dtpDataLimite.Enabled = !chkSemData.Checked;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista de utilizadores: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxID.SelectedValue == null)
                {
                    MessageBox.Show("Selecione um ID de utilizador válido!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId = Convert.ToInt32(ComboBoxID.SelectedValue);
                string nome = txtNome.Text.Trim();
                string link = txtLink.Text.Trim();
                decimal precoAlvo = decimal.TryParse(txtPrecoAlvo.Text, out decimal preco) ? preco : 0;
                DateTime? dataLimite = chkSemData.Checked ? (DateTime?)null : dtpDataLimite.Value;
                string loja = txtLoja.Text.Trim();

                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(link))
                {
                    MessageBox.Show("Nome e Link são obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_id == 0)
                {
                    _produtoRepo.Add(userId, nome, link, precoAlvo, dataLimite, loja);
                }
                else
                {
                    _produtoRepo.Update(_id, nome, link, precoAlvo, dataLimite, loja);
                }

                MessageBox.Show("✅ Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Erro ao salvar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ComboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxID.SelectedItem is System.Data.DataRowView row)
            {
                int id = Convert.ToInt32(row["Id"]);
                string nome = row["Nome"].ToString();
                Console.WriteLine($"Selecionado: ID = {id}, Nome = {nome}");
            }
        }
        private void txtNome_TextChanged(object sender, EventArgs e){ }

        private void txtLink_TextChanged(object sender, EventArgs e) {}

        private void txtPrecoAlvo_TextChanged(object sender, EventArgs e) { }

        private void txtLoja_TextChanged(object sender, EventArgs e){}
    }
}
