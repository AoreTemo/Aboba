using MySqlConnector;
namespace librarian
{
    internal class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=mydatabase");

    }
}
