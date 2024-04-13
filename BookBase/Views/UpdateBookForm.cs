using BookBase.Controllers;
using BookBase.Models;
using BookBase.Views.Components;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBase.Views
{
    public partial class UpdateBookForm : MaterialForm
    {
        private int bookId;
        private Book book;
        private LibraryController libraryController;

        public UpdateBookForm(int id)
        {
            InitializeComponent();
            this.bookId = id;

            libraryController = new LibraryController();
        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
        {
            book = libraryController.GetBookDetailsById(bookId);

            try
            {
                string[] textFields = { "titleInput", "authorInput", "publisherInput", "yearInput", "shelfInput", "imageInput" };
                string[] oldValues = { book.title, book.author, book.publisher, book.year_published.ToString(), book.shelf_location, book.image_url };

                for (int i = 0; i < textFields.Length; i++)
                {
                    string inputName = textFields[i];
                    string value = oldValues[i];

                    MaterialTextBox2 input = this.Controls.Find(inputName, true).FirstOrDefault() as MaterialTextBox2;

                    if (input != null)
                    {
                        input.Text = value;
                        input.Leave += (sndr, evnt) => inputOnLeave(input, value);
                    }
                    else
                    {
                        Console.WriteLine($"Control '{inputName}' not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }

        private void inputOnLeave(MaterialTextBox2 input, string placeholder)
        {
            if (input.TextLength == 0)
            {
                input.Text = placeholder;
            }
        }

        private void closeForm()
        {
            this.Hide();
            BookDetailForm bookDetailForm = new BookDetailForm
            {
                bookId = bookId,
            };
            bookDetailForm.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] textFields = { "titleInput", "authorInput", "publisherInput", "yearInput", "shelfInput", "imageInput" };
                string[] oldValues = { book.title, book.author, book.publisher, book.year_published.ToString(), book.shelf_location, book.image_url };

                for (int i = 0; i < textFields.Length; i++)
                {
                    string inputName = textFields[i];
                    string value = oldValues[i];

                    MaterialTextBox2 input = this.Controls.Find(inputName, true).FirstOrDefault() as MaterialTextBox2;

                    if (input != null)
                    {
                        input.Clear();
                        input.Text = value;
                    }
                    else
                    {
                        Console.WriteLine($"Control '{inputName}' not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                string title = titleInput.Text;
                string author = authorInput.Text;
                string publisher = publisherInput.Text;
                int year = int.TryParse(yearInput.Text, out year) ? year : 0;
                string shelf = shelfInput.Text;
                string image = imageInput.Text;

                bool isSuccess = await Task.Run(() => libraryController.UpdateBook(bookId, title, author, publisher, year, shelf, image));
                if (isSuccess)
                {
                    closeForm();
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}
