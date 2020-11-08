using System;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public class DbConnection : IDisposable
    {
        private static string connectionString =
            "server=localhost;port=3306;userid=root;password=;database=world;";

        private static MySqlConnection SqlConnection;

        private DbConnection()
        {
        }

        public static MySqlConnection GetConnection()
        {
            return SqlConnection ??= new MySqlConnection(connectionString);
        }

        public static void OpenConnection(MySqlConnection sqlConnection)
        {
            sqlConnection.Open();
        }

        public void Dispose()
        {
        }
    }
}