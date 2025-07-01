using System.Data.SqlClient;

namespace BaseDeDatos;

public class DB
{
    private string _connectionString;
    protected SqlConnection _connection; //Se debe instalar System.Data.SqlClient

    public DB(string server, string db, string user, string password)
    {
        _connectionString = $"Data Source={server}; Initial Catalog={db}; " +
                            $"Integrated Security=True"; //localhost
        
        // _connectionString = $"Data Source={server}; Initial Catalog={db}; " +
        //                     $"User={user}; Password={password}";   //para trabajo
    }

    public void Connect()
    {
        _connection = new SqlConnection(_connectionString);
        _connection.Open();
    }

    public void Close()
    {
        if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
        {
            _connection.Close();
        }
    }
}