using System.Data.SqlClient;

namespace AdoNet;

internal class Program
{
    private static void Main(string[] args)
    {
        var connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=testdb; Integrated Security=True";

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var cmd = new SqlCommand("INSERT INTO Customers VALUES(@FirstName, @LastName)", connection);

            cmd.Parameters.AddWithValue("@FirstName", "Hannes");
            cmd.Parameters.AddWithValue("@LastName", "Kurz");

            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}