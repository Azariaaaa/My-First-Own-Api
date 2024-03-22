using MySqlConnector;

namespace MyFirstOwnApi.Database
{
    public static class InitDatabase
    {
        public static void CreateDB()
        {
            Console.WriteLine("Creating DB..");
            string sql = "DROP DATABASE IF EXISTS MyFirstOwnApiDatabase; CREATE DATABASE MyFirstOwnApiDatabase";
            using (MySqlCommand command = new MySqlCommand(sql, Connection.GetInstance()))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Database created.");
            }
        }
    }
}
