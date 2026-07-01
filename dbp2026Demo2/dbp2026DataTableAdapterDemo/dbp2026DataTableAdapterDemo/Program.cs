using System.Data.SqlClient;

namespace dbp2026DataTableAdapterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string connectionString = "Database=Northwind; Integrated Security=SSPI; Server=LITTLE-JOHN;";

            try
            {
                Console.WriteLine("Hello, World! Let's  interact with the DB using Data Tables, Sets and Adapters");


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    Console.WriteLine("Connection successfully Established!");

                    connection.Close();
                }

                
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine($"Argument Error Encountered : {ex.Message}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error Encountered : {ex.Message}");
            }
        }
    }
}
