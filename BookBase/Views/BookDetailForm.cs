using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBase.Controllers;
using BookBase.Models;
using BookBase.Views.Components;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BookBase.Views
{
    public partial class BookDetailForm : MaterialForm
    {
        private Book book;
        private LibraryController libraryController;
        public int bookId { get; set; }

        public BookDetailForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            libraryController = new LibraryController();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            DisplayBookDetails();
        }

        private void DisplayBookDetails()
        {
            try
            {
                book = libraryController.GetBookDetailsById(bookId);

                bookCard.Controls.Clear();
                PictureBox pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Top,
                    Margin = new Padding(10),
                    Height = 375
                };

                libraryController.ImageLoad(pictureBox, book.image_url);

                Label titleLabel = new Label
                {
                    Text = book.title,
                    AutoSize = false,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold),
                    Height = 35
                };
                MaterialLabel authorLabel = new MaterialLabel
                {
                    Text = "By: " + book.author,
                    AutoSize = false,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 30
                };
                MaterialLabel publishLabel = new MaterialLabel
                {
                    Text = "Publisher: " + book.year_published + ", " + book.publisher,
                    AutoSize = false,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 30
                };
                MaterialLabel locationLabel = new MaterialLabel
                {
                    Text = "Where: " + book.shelf_location,
                    AutoSize = false,
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Height = 30
                };
                Button updateBtn = new Button
                {
                    Text = "Update details",
                    Font = new Font("Monaco", 12, FontStyle.Bold),
                    BackColor = Color.CornflowerBlue,
                    Size = new Size(20, 40),
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Bottom
                };
                updateBtn.FlatAppearance.BorderColor = Color.White;
                updateBtn.Click += (sender, e) => OpenUpdateBookForm(book.id);

                Button delBtn = new Button
                {
                    Text = "Dispose Book",
                    // Font = new Font(FontFamily.Families[55], 12, FontStyle.Regular),
                    Font = new Font("Monaco", 12, FontStyle.Regular),
                    BackColor = Color.IndianRed,
                    Size = new Size(20, 40),
                    FlatStyle = FlatStyle.Flat,
                    Dock = DockStyle.Bottom
                };
                delBtn.FlatAppearance.BorderColor = Color.White;
                delBtn.Click += (sender, e) => DeleteSelectedBook(book.id);

                bookCard.Controls.Add(pictureBox);
                bookCard.Controls.Add(titleLabel);
                bookCard.Controls.Add(authorLabel);
                bookCard.Controls.Add(publishLabel);
                bookCard.Controls.Add(locationLabel);
                bookCard.Controls.Add(updateBtn);
                bookCard.Controls.Add(delBtn);
            } catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.materialTabControl1.SelectedTab = form1.materialTabControl1.TabPages["tabPage2"];
            form1.Show();
        }

        private void OpenUpdateBookForm(int id)
        {
            this.Hide();
            UpdateBookForm updateBook = new UpdateBookForm(id);
            updateBook.ShowDialog();
        }

        private async void DeleteSelectedBook(int id)
        {
            try
            {
                this.Hide();
                AlertBox alert = new AlertBox(id);
                alert.ShowDialog();

                if (alert.result == false)
                {
                    return;
                }

                bool isSuccess = await Task.Run(() => libraryController.DeleteBook(id));
                if (isSuccess)
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.materialTabControl1.SelectedTab = form1.materialTabControl1.TabPages["tabPage2"];
                    form1.Show();
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}
