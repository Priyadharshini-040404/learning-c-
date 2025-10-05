using System;
using System.Data;
using System.Data.SqlClient;

namespace PubsRepoDemo
{
    // 1️⃣ Author entity
    public class Author
    {
        public string AuId { get; set; }
        public string AuLName { get; set; }
        public string AuFName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool Contract { get; set; }
    }

    // 2️⃣ Repository
    public class AuthorRepository
    {
        private readonly SqlConnection _connection;

        public AuthorRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public int Add(Author author)
        {
            // ✅ Verbatim string literal for multi-line SQL
            string query = @"INSERT INTO authors 
(au_id, au_lname, au_fname, phone, address, city, state, zip, contract) 
VALUES (@au_id, @au_lname, @au_fname, @phone, @address, @city, @state, @zip, @contract)";

            using (SqlCommand cmd = new SqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@au_id", author.AuId);
                cmd.Parameters.AddWithValue("@au_lname", author.AuLName);
                cmd.Parameters.AddWithValue("@au_fname", author.AuFName);
                cmd.Parameters.AddWithValue("@phone", author.Phone);
                cmd.Parameters.AddWithValue("@address", author.Address);
                cmd.Parameters.AddWithValue("@city", author.City);
                cmd.Parameters.AddWithValue("@state", author.State);
                cmd.Parameters.AddWithValue("@zip", author.Zip);
                cmd.Parameters.AddWithValue("@contract", author.Contract);

                return cmd.ExecuteNonQuery();
            }
        }
    }

    // 3️⃣ Unit of Work
    public class UnitOfWork : IDisposable
    {
        private readonly SqlConnection _connection;
        public AuthorRepository Authors { get; }

        public UnitOfWork(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            Authors = new AuthorRepository(_connection);
        }

        public void Dispose()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
            _connection.Dispose();
        }
    }

    // 4️⃣ Main Program
    class Program
    {
        static void Main()
        {
            string connString = @"Server=PSILENL068;Database=Pubs;Integrated Security=True;";

            using (var uow = new UnitOfWork(connString))
            {
                // Auto-generate a unique au_id to avoid primary key violation
                string uniqueId = "999-99-" + new Random().Next(1000, 9999);

                var newAuthor = new Author
                {
                    AuId = uniqueId,
                    AuLName = "Devaraj",
                    AuFName = "Nivi",
                    Phone = "123-456-7890",
                    Address = "Test Street 1",
                    City = "Coimbatore",
                    State = "TN",
                    Zip = "64100",
                    Contract = true
                };

                int inserted = uow.Authors.Add(newAuthor);

                Console.WriteLine(inserted > 0
                    ? $"Author Inserted Successfully! au_id = {newAuthor.AuId}"
                    : "Insert Failed.");
            }
        }
    }
}
