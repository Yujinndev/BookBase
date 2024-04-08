using BookBase.Models;
using BookBase.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBase.Controllers
{
    public class LibraryController
    {
        private readonly DbConnector dbConnector;
        private readonly MySqlConnection connection;

        public LibraryController()
        {
            dbConnector = new DbConnector();
            connection = dbConnector.DbConnect();
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            try
            {
                connection.Open();
                string query = "SELECT * FROM books";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Book book = new Book
                    {
                        id = Convert.ToInt32(reader["id"]),
                        title = reader["title"].ToString(),
                        author = reader["author"].ToString(),
                        publisher = reader["publisher"].ToString(),
                        year_published = Convert.ToInt32(reader["year_published"]),
                        image_url = reader["image_url"].ToString(),
                        added_at = reader["added_at"].ToString(),
                    };
                    books.Add(book);
                }

                reader.Close();
                return books;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving books: " + ex.Message);
                return new List<Book>();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
