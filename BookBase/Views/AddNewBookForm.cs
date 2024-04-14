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
using static System.Net.Mime.MediaTypeNames;

namespace BookBase.Views
{
    public partial class AddNewBookForm : MaterialForm
    {
        private LibraryController libraryController;

        public AddNewBookForm()
        {
            InitializeComponent();
            libraryController = new LibraryController();
        }

        private void AddNewBookForm_Load(object sender, EventArgs e)
        {
            try
            {
                string[] textFields = { "titleInput,Title", "authorInput,Author", "publisherInput,Publisher", "yearInput,Year Published", "shelfInput,Shelf Location", "imageInput,Image URI" };

                foreach (string inputNameAndPlaceholder in textFields)
                {
                    string[] parts = inputNameAndPlaceholder.Split(',');
                    string inputName = parts[0];
                    string placeholder = parts[1];

                    MaterialTextBox2 input = this.Controls.Find(inputName, true).FirstOrDefault() as MaterialTextBox2;

                    if (input != null)
                    {
                        input.Enter += (sndr, evnt) => inputOnEnter(input, placeholder);
                        input.Leave += (sndr, evnt) => inputOnLeave(input, placeholder);
                    }
                    else
                    {
                        Console.WriteLine($"Control '{inputName}' not found.");
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }

        private void inputOnEnter(MaterialTextBox2 input, string placeholder)
        {
            if (input.Text == placeholder)
            {
                input.Clear();
            }
        }

        private void inputOnLeave(MaterialTextBox2 input, string placeholder)
        {
            if (input.TextLength == 0)
            {
                input.Text = placeholder;
            }

            if (input == imageInput && input.Text == placeholder)
            {
                pictureBox1.Image = Properties.Resources.NewBook;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                return;
            }

            if (input == imageInput)
            {
                libraryController.ImageLoad(pictureBox1, input.Text.Trim());
            }
        }

        private void closeForm()
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.materialTabControl1.SelectedTab = form1.materialTabControl1.TabPages["tabPage2"];
            form1.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] textFields = { "titleInput,Title", "authorInput,Author", "publisherInput,Publisher", "yearInput,Year Published", "shelfInput,Shelf Location", "imageInput,Image URI" };

                bool isChanged = false;

                foreach (string inputNameAndPlaceholder in textFields)
                {
                    string[] parts = inputNameAndPlaceholder.Split(',');
                    string inputName = parts[0];
                    string placeholder = parts[1];

                    MaterialTextBox2 input = this.Controls.Find(inputName, true).FirstOrDefault() as MaterialTextBox2;

                    if (input.Text != placeholder)
                    {
                        isChanged = true;
                    }
                }

                if (isChanged)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to go back?", "Progress will be canceled", MessageBoxButtons.OKCancel);

                    if (dialogResult == DialogResult.OK)
                    {
                        closeForm();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    closeForm();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Properties.Resources.NewBook;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                string[] textFields = { "titleInput,Title", "authorInput,Author", "publisherInput,Publisher", "yearInput,Year Published", "shelfInput,Shelf Location", "imageInput,Image URI" };

                foreach (string inputNameAndPlaceholder in textFields)
                {
                    string[] parts = inputNameAndPlaceholder.Split(',');
                    string inputName = parts[0];
                    string placeholder = parts[1];

                    MaterialTextBox2 input = this.Controls.Find(inputName, true).FirstOrDefault() as MaterialTextBox2;

                    if (input != null)
                    {
                        input.Clear();
                        input.Text = placeholder;
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
            int year = int.TryParse(yearInput.Text, out year) ? year : 0;
            string[] placeholders = { "Title", "Author", "Publisher", "Year Published", "Shelf Location", "Image URI" };
            string[] currentValues = { titleInput.Text, authorInput.Text, publisherInput.Text, year.ToString(), shelfInput.Text, imageInput.Text };

            for (int i = 0; i < placeholders.Length; i++)
            {
                string placeholder = placeholders[i];
                string value = currentValues[i];

                if (placeholder == value)
                {
                    MessageBox.Show($"Kindly fill out all inputs!", "Try Again!", MessageBoxButtons.OK);
                    return;
                }
            }

            try
            {
                bool isSuccess = await Task.Run(() => libraryController.CreateNewBook(currentValues[0], currentValues[1], currentValues[2], year, currentValues[4], currentValues[5]));
                if (isSuccess)
                {
                    closeForm();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}
