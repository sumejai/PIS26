using MySql.Data.MySqlClient;

namespace PISVezba.Data
{
    public static class Konekcija
    {
        private static string connectionString = "Server=localhost;Database=hotel;Uid=root;Pwd=;";

        // Metoda koja vraća novu MySQL konekciju
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}