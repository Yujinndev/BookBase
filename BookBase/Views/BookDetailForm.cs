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
            book = libraryController.GetBookDetailsById(bookId);

            bookCard.Controls.Clear();
            PictureBox pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Top,
                Margin = new Padding(10),
                Height = 375
            };

            libraryController.ImageLoad(pictureBox, book);

            Label titleLabel = new Label
            {
                Text = book.title,
                AutoSize = false,
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 18, FontStyle.Bold),
                Height = 40
            };
            MaterialLabel authorLabel = new MaterialLabel
            {
                Text = book.author,
                AutoSize = false,
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 18, FontStyle.Bold),
                Height = 40
            };
            Button updateBtn = new Button
            {
                Text = "Update Book",
                Font = new Font("Arial", 14, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                BackColor = Color.DodgerBlue,
                Size = new Size(20, 40)
            };
            Button delBtn = new Button
            {
                Text = "Dispose Book",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                BackColor = Color.IndianRed,
                Size = new Size(20, 40)
            };

            bookCard.Controls.Add(pictureBox);
            bookCard.Controls.Add(titleLabel);
            bookCard.Controls.Add(authorLabel);
            bookCard.Controls.Add(updateBtn);
            bookCard.Controls.Add(delBtn);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
