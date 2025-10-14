using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Painel_Admin
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                var conn = DbConfig.ConnectionString;
                var b = new MySqlConnectionStringBuilder(conn);
                MessageBox.Show($"A conectar no MySQL com usuário: {b.UserID}",
                    "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (var con = new MySqlConnection(conn))
                {
                    con.Open();
                    Console.WriteLine("Conexão bem-sucedida!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar na base de dados: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}