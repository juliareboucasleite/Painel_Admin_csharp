using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Painel_Admin
{
    public class UtilizadorRepository
    {
        public DataTable GetAll()
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = @"SELECT Id, Nome, Email, Telefone, PerfilId, Ativo, Data_Registo 
                                 FROM utilizadores";

                using (var cmd = new MySqlCommand(query, con))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public void Add(string nome, string email, string senhaHash, string telefone, bool ativo, int perfilId)
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = @"INSERT INTO utilizadores 
                        (Nome, Email, SenhaHash, Telefone, Ativo, PerfilId, Data_Registo, EmailVerificado, CodigoEmail)
                        VALUES (@nome, @mail, @senhaHash, @tel, @ativo, @perfil, NOW(), 1, 0)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@senhaHash", senhaHash);
                    cmd.Parameters.AddWithValue("@tel", string.IsNullOrEmpty(telefone) ? (object)DBNull.Value : telefone);
                    cmd.Parameters.AddWithValue("@ativo", ativo ? 1 : 0);
                    cmd.Parameters.AddWithValue("@perfil", perfilId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(int id, string nome, string email, string telefone, bool ativo, int perfilId)
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = @"UPDATE utilizadores 
                         SET Nome=@nome, Email=@mail, Telefone=@tel, Ativo=@ativo, PerfilId=@perfil
                         WHERE Id=@id";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@mail", email);
                    cmd.Parameters.AddWithValue("@tel", string.IsNullOrEmpty(telefone) ? (object)DBNull.Value : telefone);
                    cmd.Parameters.AddWithValue("@ativo", ativo ? 1 : 0);
                    cmd.Parameters.AddWithValue("@perfil", perfilId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Delete(int id)
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = "DELETE FROM utilizadores WHERE Id=@id";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
