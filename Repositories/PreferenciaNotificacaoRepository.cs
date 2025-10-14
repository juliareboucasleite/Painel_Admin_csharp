using MySql.Data.MySqlClient;
using System.Data;

namespace Painel_Admin
{
    public class PreferenciaNotificacaoRepository
    {
        public DataTable GetAll()
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = @"
                    SELECT 
                        n.Id,
                        u.Nome AS UsuarioNome,
                        n.Tipo,
                        n.Ativo
                    FROM preferenciasnotificacao n
                    INNER JOIN utilizadores u ON u.Id = n.UserId
                    ORDER BY n.Id ASC;";

                using (var cmd = new MySqlCommand(query, con))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public void Add(int userId, string tipo, bool ativo)
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = @"INSERT INTO preferenciasnotificacao (UserId, Tipo, Ativo)
                                 VALUES (@userId, @tipo, @ativo)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@ativo", ativo ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(int id, int userId, string tipo, bool ativo)
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = @"UPDATE preferenciasnotificacao 
                                 SET UserId=@userId, Tipo=@tipo, Ativo=@ativo 
                                 WHERE Id=@id";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@ativo", ativo ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = "DELETE FROM preferenciasnotificacao WHERE Id=@id";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
