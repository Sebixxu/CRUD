using System;
using System.IO;
using System.Text;
using MySql.Data.MySqlClient;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbManagement = new DbManagement();

            DbConnection.OpenConnection(DbConnection.GetConnection());
        }
    }
}
