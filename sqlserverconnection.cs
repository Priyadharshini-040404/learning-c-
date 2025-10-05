using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = @"Server=PSILENL068;Database=Pubs;Integrated Security=True;";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                Console.WriteLine(" Connection Opened Successfully!");

                string query = "INSERT INTO authors (au_id, au_lname, au_fname, phone, address, city, state, zip, contract) " +
                               "VALUES (@au_id, @au_lname, @au_fname, @phone, @address, @city, @state, @zip, @contract)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@au_id", "999-99-9999"); 
                cmd.Parameters.AddWithValue("@au_lname", "Devaraj");
                cmd.Parameters.AddWithValue("@au_fname", "Nivi");
                cmd.Parameters.AddWithValue("@phone", "123-456-7890");
                cmd.Parameters.AddWithValue("@address", "Test Street 1");
                cmd.Parameters.AddWithValue("@city", "Coimbatore");
                cmd.Parameters.AddWithValue("@state", "TN");
                cmd.Parameters.AddWithValue("@zip", "64100"); 
                cmd.Parameters.AddWithValue("@contract", 1);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? " Author Inserted Successfully!" : " Insert Failed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error: " + ex.Message);
            }
        }
    }
}