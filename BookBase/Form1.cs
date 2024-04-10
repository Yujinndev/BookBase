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
using BookBase.Views;
using MaterialSkin;

namespace BookBase
{
    public partial class Form1 : MaterialForm
    {
        private List<Book> books;
        private LibraryController libraryController;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            libraryController = new LibraryController(); // Instantiate LibraryController
            books = libraryController.GetAllBooks(); // Call GetAllBooks to get the list of books
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                    Margin = new Padding(10),
                    Height = 175
                };

                libraryController.ImageLoad(pictureBox, book);

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

                MaterialButton viewButton = new MaterialButton
                {
                    Text = "View book",
                    Dock = DockStyle.Bottom
                };
                viewButton.Click += (sender, e) => OpenDetailsForm(book.id);

                cardPanel.Controls.Add(viewButton);
                cardPanel.Controls.Add(authorLabel);
                cardPanel.Controls.Add(titleLabel);
                cardPanel.Controls.Add(pictureBox);

                container.Controls.Add(cardPanel);
            }
        }

        private void OpenDetailsForm(int id)
        {
            this.Hide();

            BookDetailForm bookDetailForm = new BookDetailForm();
            bookDetailForm.bookId = id;
            bookDetailForm.Show();
        }
    }
}
