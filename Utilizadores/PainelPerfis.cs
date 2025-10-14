using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Painel_Admin.Utilizadores;

namespace Painel_Admin
{
    public partial class PainelPerfis : Form
    {
        public PainelPerfis()
        {
            InitializeComponent();
        }

        private void PainelPerfis_Load(object sender, EventArgs e)
        {
            CarregarPerfis();
        }

        private void CarregarPerfis()
        {
            try
            {
                using (var con = new MySqlConnection(DbConfig.ConnectionString))
                {
                    con.Open();
                    var query = @"
                        SELECT 
                            u.Id, 
                            u.Nome, 
                            u.Email, 
                            u.Telefone, 
                            u.Ativo, 
                            p.Nome AS Perfil
                        FROM utilizadores u
                        INNER JOIN perfis p ON u.PerfilId = p.Id
                        WHERE u.PerfilId = 1
                        ORDER BY u.Nome ASC;";
                    using (var da = new MySqlDataAdapter(query, con))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvPerfis.DataSource = dt;
                    }
                    if (dgvPerfis.Columns.Count > 0)
                    {
                        dgvPerfis.Columns["Id"].HeaderText = "ID";
                        dgvPerfis.Columns["Nome"].HeaderText = "Nome";
                        dgvPerfis.Columns["Email"].HeaderText = "Email";
                        dgvPerfis.Columns["Telefone"].HeaderText = "Telefone";
                        dgvPerfis.Columns["Perfil"].HeaderText = "Perfil";
                        dgvPerfis.Columns["Ativo"].HeaderText = "Ativo";

                        dgvPerfis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvPerfis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvPerfis.MultiSelect = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar perfis: " + ex.Message);
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var frm = new FormAdicionar();
            if (frm.ShowDialog() == DialogResult.OK)
                CarregarPerfis();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPerfis.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPerfis.CurrentRow.Cells["Id"].Value);
                string nome = dgvPerfis.CurrentRow.Cells["Nome"].Value.ToString();
                string email = dgvPerfis.CurrentRow.Cells["Email"].Value.ToString();
                string telefone = dgvPerfis.CurrentRow.Cells["Telefone"].Value.ToString();
                string perfil = dgvPerfis.CurrentRow.Cells["Perfil"].Value.ToString();
                bool ativo = Convert.ToInt32(dgvPerfis.CurrentRow.Cells["Ativo"].Value) == 1;

                string canal = "email";
                var frm = new FormPerfilEditar(id, nome, email, telefone, "free", canal, ativo);

                if (frm.ShowDialog() == DialogResult.OK)
                    CarregarPerfis();
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvPerfis.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPerfis.CurrentRow.Cells["Id"].Value);
                if (MessageBox.Show("Remover este utilizador administrador?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (var con = new MySqlConnection(DbConfig.ConnectionString))
                        {
                            con.Open();
                            var cmd = new MySqlCommand("DELETE FROM utilizadores WHERE Id=@id", con);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                        CarregarPerfis();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao remover: " + ex.Message);
                    }
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarPerfis();
        }
    }
}
