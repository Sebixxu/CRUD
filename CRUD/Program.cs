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
            DbConnection.OpenConnection(DbConnection.GetConnection());

            //Konsola - UI
        }
    }
}
