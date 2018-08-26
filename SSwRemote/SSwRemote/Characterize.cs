using Microsoft.Data.Sqlite;

namespace SSwRemote
{
    class Characterize
    {
        void Start(string dbPath)
        {
            var connection = new SqliteConnection("Data Source=" + dbPath);
            connection.Open();
// do stuff
            connection.Close();
        }
    }
}
