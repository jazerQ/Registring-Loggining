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

        public async static void InputParams(string username, string password, string email)
        {
            await Task.Run(() =>
            {
                using (var connection = new SqliteConnection(path))
                {
                    connection.Open();
                    SqliteCommand command = new SqliteCommand();
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO User(ID, Username, Password, Email) VALUES(NULL, @username, @password, @email)";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.ExecuteNonQuery();
                }
            }
        );
        }
        public async static Task<bool> CheckValueExists(string column, string valueToCheck) 
        {
            bool exist = false;
            using (var connection = new SqliteConnection(path))
            {
                await connection.OpenAsync();
                string query = $"SELECT COUNT(*) FROM User WHERE {column} = @value";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@value", valueToCheck);
                    var result = await command.ExecuteScalarAsync();
                    exist = Convert.ToInt32(result) == 0;
                    
                }
            }
            return exist;
        }

    }
}
