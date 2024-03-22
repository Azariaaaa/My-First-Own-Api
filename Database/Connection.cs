using MySqlConnector;

namespace MyFirstOwnApi.Database
{
    public class Connection
    {
        private static MySqlConnection? _connection;

        private Connection() { }

        public static MySqlConnection GetInstance()
        {
            if (_connection == null)
            {
                _connection = Connect();
            }

            return _connection;
        }
        public static MySqlConnection Connect()
        {
            try
            {
                string connectionString = "server=localhost;Database=MyFirstOwnApiDatabase;user=root;password=root";
                ;
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connecté.");

                return connection;
            }
            catch (MySqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);

                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    } 
}
