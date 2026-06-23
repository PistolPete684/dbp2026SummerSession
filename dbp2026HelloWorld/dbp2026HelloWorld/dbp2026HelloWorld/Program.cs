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

                    //"SELECT * FROM Customers ;";

                    // Select the columns individually in order to reference them individualy when calling them below
                    string sqlQuery = "SELECT ContactName, CompanyName, CustomerID FROM Customers ORDER BY CustomerID ASC;";

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = sqlQuery;
                    sqlCommand.Connection = connection;

                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    int? recordCounter = 0;
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            // Reference the column name, so when the table is altered in the future, the display isn't broken
                            Console.WriteLine($"Read Row #{++recordCounter} - {dataReader["CustomerID"]}: {dataReader["CustomerName"]}");
                            
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
