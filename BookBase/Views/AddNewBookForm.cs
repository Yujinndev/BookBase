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
    public partial class AddNewBookForm : MaterialForm
    {
        public AddNewBookForm()
        {
            InitializeComponent();
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

        public void inputOnEnter(MaterialTextBox2 input, string placeholder)
        {
            if (input.Text == placeholder)
            {
                input.Clear();
            }
        }

        public void inputOnLeave(MaterialTextBox2 input, string placeholder)
        {
            if (input.TextLength == 0)
            {
                input.Text = placeholder;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.materialTabControl1.SelectedTab = form1.materialTabControl1.TabPages["tabPage2"];
            form1.Show();
        }

        private void resetBtn_Click(object sender, EventArgs e)
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // TODO: send input to controller and save to database.
        }
    }
}
