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

        public static Task InputParams(string username, string password, string email)
        {
            return Task.Run(() =>
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
        public async static Task<string> GetEmail(string username)
        {
            
            using (var connection = new SqliteConnection(path))
            {
                await connection.OpenAsync();
                string query = $"SELECT Email FROM User WHERE Username = @value";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@value", username);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if(await reader.ReadAsync())
                        {
                            string email = reader.GetString(0);
                            return email;
                        }
                    }
                }
            }
            return "";
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
                    exist = Convert.ToInt32(result) > 0;
                    
                }
            }
            return exist;
        }
        public static Task DeleteUser(string username)
        {
            return Task.Run(() => 
            {
                using (var connection = new SqliteConnection(path))
                {
                    connection.OpenAsync();
                    string query = "DELETE FROM User WHERE Username = @value";
                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@value", username);
                        command.ExecuteNonQuery();

                    }
                }
            }
            );

        } 
        public async static Task<bool> IsValidPassword(string Username, string password)
        {
            bool flag = false;
            using(var connection = new SqliteConnection(path))
            {
                await connection.OpenAsync();
                string query = $"SELECT Password FROM User WHERE Username = @value";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@value", Username);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if(await reader.ReadAsync())
                        {
                            string correctPassword = reader.GetString(0);
                            return correctPassword == password; 
                        }
                    }
                    
                }
            }
            return flag;
        }
        public static async Task<Game[]> GetGame(int count)
        {
            Game[] games = new Game[count];
            int ind = 0;
            using (var connection = new SqliteConnection(path))
            {
                await connection.OpenAsync();
                string query = "SELECT game, cost, path FROM Games LIMIT @value";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@value", count);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string game = (string) reader.GetValue(0);
                                int cost = Convert.ToInt32(reader.GetValue(1));
                                string pathOfGame = (string) reader.GetValue(2);
                                Game MyGame = new Game(game, cost, pathOfGame);
                                games[ind] = MyGame;
                                ind++;
                            }
                        }
                        
                    }
                }
            }
            return games;
        }
        public static async Task BuyGame(string username, string nameOfGame)
        {
            using (var connection = new SqliteConnection(path))
            {
                await connection.OpenAsync(); // Асинхронное открытие соединения
                string query = "INSERT INTO Users_Games SELECT (SELECT ID FROM User WHERE Username = @username), (SELECT game_id FROM Games WHERE game = @game), null";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@game", nameOfGame);
                    await command.ExecuteNonQueryAsync(); // Асинхронное выполнение запроса
                }
            }
        }

    }
}
