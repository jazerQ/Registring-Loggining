using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    static class DataAccess
    {
        public static readonly string path = @"Data Source=C:\Users\user\Desktop\Reg.db";

        public static void InputParams(string username, string password, string email)
        {
            using (var connection = new SqliteConnection(path))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO User(ID, Username, Password, Email) VALUES(NULL, {username}, {password}, {email})";
                command.ExecuteNonQuery();
            }
        }
       
    }
}
