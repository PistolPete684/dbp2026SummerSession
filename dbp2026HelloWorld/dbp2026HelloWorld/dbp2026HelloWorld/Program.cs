using System.Data.SqlClient;

namespace dbp2026HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Let's find our database!\n\n");

            try
            {
                string connectionString = "Server=(local); Database=Northwind; Integrated Security=SSPI";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    Console.WriteLine($"Connection was established!");

                    // Business logic starts here
                    // after connection is established

                    string sqlQuery = "SELECT * FROM Customers ;";

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = sqlQuery;
                    sqlCommand.Connection = connection;

                    sqlCommand.ExecuteReader();


                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
