using System.Data.SqlClient;

namespace dbp2026DataTableAdapterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Let's  interact with the DB using Data Tables, Sets and Adapters");

            string connectionString = "Database=Northwind; Integrated Security=SSPI; Server=LITTLE-JOHN;" ;

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            Console.WriteLine("Connection successfully Established!");

            connection.Close();
        }
    }
}
