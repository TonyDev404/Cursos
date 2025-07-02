using System.Data.SqlClient;
using BaseDeDatos;

public class BeerDB : DB
{
    public BeerDB(string server, string db, string user, string password) : base(server, db, user, password)
    {
        
    }

    public List<Beer> GetAll()
    {
        Connect();
        
        var beers = new List<Beer>();
        string query = "SELECT Id, Name, BrandId FROM BEER";
        SqlCommand command = new SqlCommand(query, _connection); //La conexión la podemos usar porque al estar como protected los hijos si tienen acceso
        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read()) //Lee los datos de la tabla fila por fila
        {
            int id = reader.GetInt32(0);
            string name = reader.GetString(1);
            int brandId = reader.GetInt32(2);
            beers.Add(new Beer(id, name, brandId));
        }
        
        Close();
        
        return beers;
    }

    public Beer GetById(int id)
    {
        Connect();
        
        Beer beer = null;
        string query = "SELECT Id, Name, BrandId FROM BEER WHERE ID=@Id";
        SqlCommand command = new SqlCommand(query, _connection);
        command.Parameters.AddWithValue("@Id", id);
        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            string name = reader.GetString(1);
            int brandId = reader.GetInt32(2);
            beer = new Beer(id, name, brandId);
        }
        
        Close();

        return beer;
    }

    public void Add(Beer beer)
    {
        Connect();
        
        string query = "INSERT INTO Beer(Name, BrandID) VALUES (@name, @brandId)";
        SqlCommand command = new SqlCommand(query,  _connection);
        command.Parameters.AddWithValue("@name", beer.Name);
        command.Parameters.AddWithValue("@brandId", beer.BrandId);
        command.ExecuteNonQuery();
        
        Close();
    }
    
    public void Edit(Beer beer)
    {
        Connect();

        string query = "UPDATE beer SET name=@name, brandId=@brandId WHERE ID=@Id";
        SqlCommand command = new SqlCommand(query, _connection);
        command.Parameters.AddWithValue("@name", beer.Name);
        command.Parameters.AddWithValue("@brandId", beer.BrandId);
        command.Parameters.AddWithValue("@id", beer.Id);
        command.ExecuteNonQuery();
        
        Close();
    }

    public void Delete(int id)
    {
        Connect();

        string query = "DELETE FROM beer WHERE ID=@Id";
        SqlCommand command = new SqlCommand(query, _connection);
        command.Parameters.AddWithValue("@Id", id);
        command.ExecuteNonQuery();
        
        Close();
    }
}