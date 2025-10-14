using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Painel_Admin
{
    public class ProdutoRepository
    {
        public DataTable GetAll()
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = @"
                    SELECT 
                        p.Id,
                        u.Nome AS UsuarioNome,
                        p.Nome,
                        p.Link,
                        p.PrecoAlvo,
                        p.DataLimite,
                        p.Loja
                    FROM produtos p
                    INNER JOIN utilizadores u ON u.Id = p.UserId
                    ORDER BY p.Id ASC;";

                using (var cmd = new MySqlCommand(query, con))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public void Add(int userId, string nome, string link, decimal precoAlvo, DateTime? dataLimite, string loja)
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = @"INSERT INTO produtos 
                                (UserId, Nome, Link, PrecoAlvo, DataLimite, Loja)
                                 VALUES (@userId, @nome, @link, @precoAlvo, @dataLimite, @loja)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@link", link);
                    cmd.Parameters.AddWithValue("@precoAlvo", precoAlvo);
                    cmd.Parameters.AddWithValue("@dataLimite", (object)dataLimite ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@loja", loja);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(int id, string nome, string link, decimal precoAlvo, DateTime? dataLimite, string loja)
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = @"UPDATE produtos 
                                 SET Nome=@nome, Link=@link, PrecoAlvo=@precoAlvo, 
                                     DataLimite=@dataLimite, Loja=@loja
                                 WHERE Id=@id";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@link", link);
                    cmd.Parameters.AddWithValue("@precoAlvo", precoAlvo);
                    cmd.Parameters.AddWithValue("@dataLimite", (object)dataLimite ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@loja", loja);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetUserIdsComProdutos()
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = @"
                    SELECT DISTINCT u.Id, CONCAT(u.Id, ' - ', u.Nome) AS Nome
                    FROM produtos p
                    INNER JOIN utilizadores u ON u.Id = p.UserId
                    ORDER BY u.Id ASC;";

                using (var cmd = new MySqlCommand(query, con))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public void Delete(int id)
        {
            using (var con = new MySqlConnection(DbConfig.ConnectionString))
            {
                con.Open();

                string query = "DELETE FROM produtos WHERE Id=@id";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
