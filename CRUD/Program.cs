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
            string sqlCreate;

            using (StreamReader streamReader = new StreamReader(".\\Scripts\\CreateDb.sql", Encoding.UTF8))
            {
                sqlCreate = streamReader.ReadToEnd();
            }

            DbConnection.OpenConnection(DbConnection.GetConnection());

            using (var command = new MySqlCommand(sqlCreate, DbConnection.GetConnection()))
            {
                command.ExecuteNonQuery();
            }

            using (var command = new MySqlCommand("INSERT INTO PFSwChO.dane(name, surname, age)VALUES(\"val1\", \"val2\", \"1\")", DbConnection.GetConnection()))
            {
                command.ExecuteNonQuery();
            }

            using (var command = new MySqlCommand("UPDATE PFSwChO.dane SET name=\"patyk\" WHERE age=\"1\"", DbConnection.GetConnection()))
            {
                command.ExecuteNonQuery();
            }

            using (var command = new MySqlCommand("SELECT name, surname, age FROM PFSwChO.dane", DbConnection.GetConnection()))
            {
                using (MySqlDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("Duap"); //TODO Reader jest jak komunista, trzeba to naprawić
                    }
                }
            }
        }
    }
}
