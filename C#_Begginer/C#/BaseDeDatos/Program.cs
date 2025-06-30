
using System.Data.SqlClient;
using BaseDeDatos;

try
{
    DB db = new DB(@"localhost\SQLEXPRESS", "CsharpDB", "sa", "123456");
    db.Connect();

    db.Close();
}
catch (SqlException ex)
{
    Console.WriteLine("No pudimos conectarnos");
}