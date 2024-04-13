using BookBase.Controllers;
using MaterialSkin.Controls;
using Mysqlx;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBase.Views.Components
{
    public partial class AlertBox : MaterialForm
    {
        private int id;
        private LibraryController libraryController;

        public bool result { get; set; }

        public int tryCount { get; set; }

        public AlertBox(int id)
        {
            InitializeComponent();
            this.id = id;

            libraryController = new LibraryController();

            tryCount = 3;
            result = false;
        }

        private void passwordInput_Enter(object sender, EventArgs e)
        {
            if (passwordInput.Text == "Password")
            {
                passwordInput.Clear();
            }
        }

        private void passwordInput_Leave(object sender, EventArgs e)
        {
            if (passwordInput.TextLength == 0)
            {
                passwordInput.Text = "Password";
            }
        }

        private void closeForm()
        {
            this.Hide();
            BookDetailForm bookDetailForm = new BookDetailForm
            {
                bookId = id,
            };
            bookDetailForm.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            if (tryCount == 1)
            {
                DialogResult dialog = MessageBox.Show("Please try again later", "Process Unsuccessful", MessageBoxButtons.OK);

                if (dialog == DialogResult.OK)
                {
                    closeForm();
                }

                return;
            }

            if (passwordInput.Text != "PROGLANEXAM")
            {
                tryCount--;

                passwordInput.Clear();
                passwordInput.Focus();

                errorMsg.Text = $"Password Incorrect! You have {tryCount} tries left";
                return;
            }

            this.Hide();
            result = true;
            return;
        }
    }
}
