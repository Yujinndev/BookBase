using BookBase.Controllers;
using BookBase.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace BookBase
{
    public partial class Form1 : MaterialForm
    {
        private List<Book> books;
        private LibraryController libraryController;

        public Form1()
        {
            InitializeComponent();
            libraryController = new LibraryController(); // Instantiate LibraryController
            books = libraryController.GetAllBooks(); // Call GetAllBooks to get the list of books
            DisplayProducts(flowLayoutPanel1);
        }

        public void DisplayProducts(FlowLayoutPanel container)
        {
            foreach (Book book in books)
            {
                MaterialCard cardPanel = new MaterialCard
                {
                    Size = new Size(225, 300),
                    Margin = new Padding(10),
                };

                PictureBox pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Top,
                    Height = 175
                };

                ImageLoad(pictureBox, book);

                Label titleLabel = new Label
                {
                    Text = book.title,
                    AutoSize = false,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Height = 25
                };

                MaterialLabel authorLabel = new MaterialLabel
                {
                    Text = book.author,
                    AutoSize = false,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 25
                };

                MaterialButton addToCartButton = new MaterialButton
                {
                    Text = "Borrow",
                    Dock = DockStyle.Bottom
                };

                cardPanel.Controls.Add(addToCartButton);
                cardPanel.Controls.Add(authorLabel);
                cardPanel.Controls.Add(titleLabel);
                cardPanel.Controls.Add(pictureBox);

                container.Controls.Add(cardPanel);
            }
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
