using System.Data.SQLite;

class Program
{
    public static readonly string path = @"Data Source=C:\Users\user\Desktop\Reg.db";
    static void Main(string[] args)
    {
        using (var connection = new SQLiteConnection(path))
        {
            connection.Open();
        }
    }
}