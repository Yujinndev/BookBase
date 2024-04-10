using BookBase.Models;
using BookBase.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Book GetBookDetailsById(int book_id)
        {
            Book book = new Book();

            try
            {
                connection.Open();

                string query = "SELECT * FROM books WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", book_id);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    book.id = Convert.ToInt32(reader["id"]);
                    book.title = reader["title"].ToString();
                    book.author = reader["author"].ToString();
                    book.publisher = reader["publisher"].ToString();
                    book.year_published = Convert.ToInt32(reader["year_published"]);
                    book.image_url = reader["image_url"].ToString();
                    book.added_at = reader["added_at"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving book: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return book;
        }

        public async void ImageLoad(PictureBox pictureBox, Book book)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
                try
                {
                    byte[] imageData = await client.DownloadDataTaskAsync(book.image_url);
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        pictureBox.Image = Image.FromStream(stream);
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show($"Error loading image for {book.title}: {ex.Message}");
                }
            }
        }
    }
}
