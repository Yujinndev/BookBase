using BookBase.Models;
using BookBase.Utils;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                string query = "SELECT * FROM books ORDER BY id desc";
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
                        shelf_location = reader["shelf_location"].ToString(),
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
                    book.shelf_location = reader["shelf_location"].ToString();
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

        public bool UpdateBook(int bookId, string title, string author, string publisher, int yearPublished, string shelfLocation, string image)
        {
            try
            {
                connection.Open();
                string query = "UPDATE books SET title = @title, author = @author, publisher = @publisher, year_published = @yearPublished, shelf_location = @shelfLocation, image_url = @image WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@publisher", publisher);
                command.Parameters.AddWithValue("@yearPublished", yearPublished);
                command.Parameters.AddWithValue("@shelfLocation", shelfLocation);
                command.Parameters.AddWithValue("@image", image);
                command.Parameters.AddWithValue("@id", bookId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Done updating book #{bookId}", "Process done!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating book: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool CreateNewBook(string title, string author, string publisher, int yearPublished, string shelfLocation, string image)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO books (title, author, publisher, year_published, shelf_location, image_url) VALUES (@title, @author, @publisher, @yearPublished, @shelfLocation, @image)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@publisher", publisher);
                command.Parameters.AddWithValue("@yearPublished", yearPublished);
                command.Parameters.AddWithValue("@shelfLocation", shelfLocation);
                command.Parameters.AddWithValue("@image", image);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"New book was created successfully", "Process done!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating book: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool DeleteBook(int bookId)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM books WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", bookId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Done deleting book #{bookId}", "Process done!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting book: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public async void ImageLoad(PictureBox pictureBox, string url)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
                try
                {
                    byte[] imageData = await client.DownloadDataTaskAsync(url);
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        pictureBox.Image = Image.FromStream(stream);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    pictureBox.Image = Properties.Resources.PlaceholderImageee;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
