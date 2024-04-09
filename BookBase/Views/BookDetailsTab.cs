using BookBase.Controllers;
using BookBase.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookBase.Views
{
    public partial class BookDetailsTab : UserControl
    {
        private Book book;
        private LibraryController libraryController;
        public int bookId { get; set; }

        public BookDetailsTab()
        {
            InitializeComponent();
            libraryController = new LibraryController(); // Instantiate LibraryController
        }

        private void BookDetailsTab_EnabledChanged(object sender, EventArgs e)
        {
            book = libraryController.GetBookDetailsById(bookId);

            bookCard.Controls.Clear();
            PictureBox pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Top,
                Margin = new Padding(10),
                Height = 400
            };

            libraryController.ImageLoad(pictureBox, book);

            Label titleLabel = new Label
            {
                Text = book.title,
                AutoSize = false,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 18, FontStyle.Bold),
                Height = 30
            };

            MaterialLabel authorLabel = new MaterialLabel
            {
                Text = book.author,
                AutoSize = false,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 18, FontStyle.Bold),
                Height = 30
            };

            MaterialButton viewButton = new MaterialButton
            {
                Text = "View book",
                Dock = DockStyle.Bottom
            };

            bookCard.Controls.Add(viewButton);
            bookCard.Controls.Add(authorLabel);
            bookCard.Controls.Add(titleLabel);
            bookCard.Controls.Add(pictureBox);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.SendToBack();
        }
    }
}
