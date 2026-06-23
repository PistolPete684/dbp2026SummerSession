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

                    Console.WriteLine($"Connection was established!\n\n");

                    // Business logic starts here
                    // after connection is established

                    string sqlQuery = "SELECT * FROM Customers ;";

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = sqlQuery;
                    sqlCommand.Connection = connection;

                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    int? recordCounter = 0;
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            Console.WriteLine($"Read Row #{++recordCounter} - {dataReader[0]}: {dataReader[1]}");
                            
                        }
                    }


                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
