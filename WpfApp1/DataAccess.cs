using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
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
                    string query = "DELETE FROM Users_Games WHERE user_id = (SELECT ID FROM User WHERE Username = @value); DELETE FROM User WHERE Username = @value;";


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
        public static async Task<List<GameInMainMenu>> GetUserGames(string username)
        {
            List<GameInMainMenu> games = new List<GameInMainMenu>();

            using (var connection = new SqliteConnection(path)) 
            {
                await connection.OpenAsync();
                string query = "SELECT game, path_icon, path_background FROM Games JOIN Users_Games ON Users_Games.game_id = Games.game_id JOIN User ON User.ID = Users_Games.user_id WHERE username = @value GROUP BY game";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@value", username);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string game = (string)reader.GetValue(0);
                                string path_icon = "..\\..\\.." + ((string)reader.GetValue(1));
                                string path_background = "..\\..\\.." + ((string)reader.GetValue(2));
                                GameInMainMenu gameIn = new GameInMainMenu(game, 0, path_background, path_icon);
                                games.Add(gameIn);
                            }
                        }
                    }
                }
            }
            return games;
        }
        public static async Task<List<Game>> GetGame()
        {
            List<Game> games = new List<Game>();
            
            using (var connection = new SqliteConnection(path))
            {
                await connection.OpenAsync();
                string query = "SELECT game, cost, path FROM Games";
                using (var command = new SqliteCommand(query, connection))
                {
                    
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string game = (string) reader.GetValue(0);
                                int cost = Convert.ToInt32(reader.GetValue(1));
                                string pathOfGame = "..\\..\\.."+ ((string) reader.GetValue(2));
                                Game MyGame = new Game(game, cost, pathOfGame);
                                games.Add(MyGame);
                                
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
        public async static Task<bool> IsGameAlreadyPurchased(string username, string game)
        {
            bool exist = false;
            using (var connection = new SqliteConnection(path))
            {
                await connection.OpenAsync();
                string query = "SELECT COUNT(*) FROM Users_Games JOIN User ON User.ID = Users_Games.user_id JOIN Games ON Games.game_id = Users_Games.game_id WHERE Username = @username AND game = @game";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@game", game);
                    var result = await command.ExecuteScalarAsync();
                    exist = Convert.ToInt32(result) > 0;
                }
            }
            return exist;
        } 
       

    }
}
