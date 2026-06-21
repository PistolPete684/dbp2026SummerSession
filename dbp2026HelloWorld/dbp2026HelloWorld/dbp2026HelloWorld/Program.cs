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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
