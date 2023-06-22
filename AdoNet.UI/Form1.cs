using AdoNet.Data.Models;
using Microsoft.Data.SqlClient;

namespace AdoNet.UI;

public partial class Form1 : Form
{
    public Form1()
    {   
        connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=testdb; Integrated Security=True";

        InitializeComponent();

        GetDataFormDb();
    }

    private string connectionString { get; }

    private void GetDataFormDb()
    {
        var allCustomers = new List<Customer>();

        using (var con = new SqlConnection(connectionString))
        {
            var cmd = new SqlCommand("Select * From Customers", con);

            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    allCustomers.Add(new Customer
                    {
                        Id = (int)reader["Id"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"]
                    });
            reader.Close();
        }

        if (allCustomers.Any())
        {
            cboxAllCustomer.DataSource = allCustomers;
            cboxAllCustomer.DisplayMember = "DisplayName";
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var cmd = new SqlCommand("INSERT INTO Customers VALUES(@FirstName, @LastName)", connection);

            cmd.Parameters.AddWithValue("@FirstName", txtbox_FirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtbox_LastName.Text);

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        EmptyBoxes();
        GetDataFormDb();
    }

    private void EmptyBoxes()
    {
        txtbox_FirstName.Text = string.Empty;
        txtbox_LastName.Text = string.Empty;
    }

    private void cboxAllCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        var ordersFromCustmer = new List<Order>();

        using (var con = new SqlConnection(connectionString))
        {
            var cmd = new SqlCommand("Select * from Orders Where CustomerId = @InputId", con);

            cmd.Parameters.AddWithValue("@InputId", ((Customer)cboxAllCustomer.SelectedItem).Id);

            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    ordersFromCustmer.Add(new Order
                    {
                        Id = (int)reader["Id"],
                        OrderNumber = (int)reader["OrderNumber"],
                        Orderdate = (DateTime)reader["Orderdate"],
                        Price = (decimal)reader["Price"]
                    });
            reader.Close();
        }

        if (ordersFromCustmer.Any())
        {
            dataGrid.DataSource = ordersFromCustmer;
        }
        else
        {
            dataGrid.DataSource = null;
        }
    }
}