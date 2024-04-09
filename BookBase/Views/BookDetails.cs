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

namespace BookBase.Views
{
    public partial class BookDetails : MaterialForm
    {
        private Book book;
        private LibraryController libraryController;

        public BookDetails(int book_id)
        {
            InitializeComponent();
            libraryController = new LibraryController(); // Instantiate LibraryController
            book = libraryController.GetBookDetailsById(book_id); // Call GetAllBooks to get the list of books
        }

        
    }
}
