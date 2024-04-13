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

            libraryController = new LibraryController();
            books = libraryController.GetAllBooks();
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
                    Size = new Size(225, 325),
                    Margin = new Padding(10),
                };

                PictureBox pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Top,
                    Margin = new Padding(10),
                    Height = 175
                };

                libraryController.ImageLoad(pictureBox, book.image_url);

                Label titleLabel = new Label
                {
                    Text = book.title,
                    AutoSize = false,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
                    Height = 50
                };

                MaterialLabel authorLabel = new MaterialLabel
                {
                    Text = book.author,
                    AutoSize = false,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 25
                };

                Button viewButton = new Button
                {
                    Text = "More details",
                    Font = new Font("Monaco", 11, FontStyle.Regular),
                    BackColor = Color.CornflowerBlue,
                    Size = new Size(20, 40),
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Bottom
                };
                viewButton.FlatAppearance.BorderColor = Color.White;
                viewButton.Click += (sender, e) => OpenDetailsForm(book.id);

                cardPanel.Controls.Add(viewButton);
                cardPanel.Controls.Add(authorLabel);
                cardPanel.Controls.Add(titleLabel);
                cardPanel.Controls.Add(pictureBox);

                container.Controls.Add(cardPanel);
            }

            Button actionBtn = new Button
            {
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = Properties.Resources.Add1,
                BackgroundImageLayout = ImageLayout.Zoom,
                Size = new Size(225, 325),
                Anchor = AnchorStyles.Right,
                Margin = new Padding(8),
                BackColor = Color.White,
            };
            actionBtn.FlatAppearance.BorderColor = Color.White;
            actionBtn.Click += (sender, e) => OpenAddBookForm();

            container.Controls.Add(actionBtn);
        }

        private void OpenDetailsForm(int id)
        {
            this.Hide();
            BookDetailForm bookDetailForm = new BookDetailForm();
            bookDetailForm.bookId = id;
            bookDetailForm.Show();
        }

        private void OpenAddBookForm()
        {
            this.Hide();
            AddNewBookForm newBookFrom = new AddNewBookForm();
            newBookFrom.Show();
        }
    }
}
