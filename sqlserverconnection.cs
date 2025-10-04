using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Server=PSILENL068;Database=Chinook;Integrated Security=True;";
        string query = "SELECT TOP 10 * FROM Artist";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                Console.WriteLine(" Connection successful!");

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("Columns in result:");
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetName(i) + "\t");
                    }
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetValue(i) + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
