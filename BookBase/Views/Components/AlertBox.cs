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
        private Timer disableButtonTimer;
        private static DateTime disabledUntilTime;
        private static bool enableButtonAfterTimer;

        private int bookId;
        public bool result { get; set; }

        public int tryCount { get; set; }

        public AlertBox(int id)
        {
            InitializeComponent();
            this.bookId = id;

            tryCount = 3;
            result = false;

            // Initialize and start the updateTimer
            disableButtonTimer = new Timer();
            disableButtonTimer.Interval = 1000;
            disableButtonTimer.Tick += CheckTimer;
            disableButtonTimer.Start();
        }

        private void closeForm()
        {
            this.Hide();
            BookDetailForm bookDetailForm = new BookDetailForm
            {
                bookId = bookId,
            };
            bookDetailForm.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (tryCount != 3)
            {
                return;
            }

            closeForm();
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            if (passwordInput.TextLength == 0)
            {
                return;
            }

            if (tryCount == 1)
            {
                DialogResult dialog = MessageBox.Show("Please try again later", "Process Unsuccessful", MessageBoxButtons.OK);

                if (dialog == DialogResult.OK)
                {
                    DisableButtonForDelay(90000); // 1 minute in milliseconds
                    closeForm();
                }

                return;
            }

            if (passwordInput.Text != "proglan")
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

        private void DisableButtonForDelay(int delayMilliseconds)
        {
            disabledUntilTime = DateTime.Now.AddMilliseconds(delayMilliseconds);
            disableButtonTimer.Stop();
            disableButtonTimer.Interval = 1000;
            disableButtonTimer.Start();

            DisableButton();
            CheckTimer(null, EventArgs.Empty);
        }

        private void DisableButton()
        {
            proceedBtn.Enabled = false;
            passwordInput.Enabled = false;
            proceedBtn.BackColor = Color.Gray;
            enableButtonAfterTimer = true;
        }

        private void EnableButton()
        {
            disableButtonTimer.Stop();

            errorMsg.Text = "";
            tryCount = 3;
            proceedBtn.Enabled = true;
            passwordInput.Enabled = true;
            proceedBtn.BackColor = Color.CornflowerBlue;
            enableButtonAfterTimer = false;
        }

        private void CheckTimer(object sender, EventArgs e)
        {
            if (DateTime.Now >= disabledUntilTime)
            {
                EnableButton();
            } else
            {
                TimeSpan remaining = disabledUntilTime - DateTime.Now;
                errorMsg.Text = $"Try again in {remaining:mm\\:ss}";
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (DateTime.Now < disabledUntilTime)
            {
                DisableButton();
                DisableButtonForDelay((int)(disabledUntilTime - DateTime.Now).TotalMilliseconds);
            }
            else if (enableButtonAfterTimer)
            {
                EnableButton();
            }
        }
    }
}
