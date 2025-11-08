using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_Project.Business_Layer;
using RMS_Project.Class;

namespace RMS_Project
{
    public partial class frmLogin : Form
    {
        private string enteredPassword = "";
        private bool isUserSelected = false;
        private string selectedUsername;

        public frmLogin()
        {
            InitializeComponent();
            LoadUserAccounts(); // Load user accounts into the flowLayoutPanel1
            DisablePasswordTextBoxes();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (isUserSelected)
            {
                if (!string.IsNullOrEmpty(enteredPassword))
                {
                    // Pass the selected username to the AuthenticateUser method
                    AuthenticateUser(selectedUsername, enteredPassword);
                }
                else
                {
                    MessageBox.Show("Please enter the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadUserAccounts()
        {
            // User feature removed - login form no longer loads user accounts
            // This method is kept for compatibility but does nothing
        }

        private void txtPasscode1_TextChanged(object sender, EventArgs e)
        {
            UpdatePassword();
            if (txtPasscode1.Text.Length >= 1)
            {
                guna2TextBox1.Focus(); // Move focus to the next textbox
                guna2TextBox1.SelectAll(); // Select all text in the next textbox
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdatePassword();

            if (guna2TextBox1.Text.Length >= 1)
            {
                guna2TextBox2.Focus(); // Move focus to the next textbox
                guna2TextBox2.SelectAll(); // Select all text in the next textbox
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

            UpdatePassword();

            if (guna2TextBox2.Text.Length >= 1)
            {
                guna2TextBox3.Focus(); // Move focus to the next textbox
                guna2TextBox3.SelectAll(); // Select all text in the next textbox
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            UpdatePassword();

            if (guna2TextBox3.Text.Length >= 1)
            {
                btnConfirm.Focus(); // Move focus to the Confirm button when all textboxes are filled
            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // UserAccountClicked event handler removed - user feature no longer exists
        private void ClearPassword()
        {
            // Clear the entered password
            enteredPassword = "";
            // Clear the text in all textboxes
            txtPasscode1.Clear();
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
        }
        private void EnablePasswordTextBoxes()
        {
            txtPasscode1.Enabled = true;
            guna2TextBox1.Enabled = true;
            guna2TextBox2.Enabled = true;
            guna2TextBox3.Enabled = true;
        }

        private void DisablePasswordTextBoxes()
        {
            txtPasscode1.Enabled = false;
            guna2TextBox1.Enabled = false;
            guna2TextBox2.Enabled = false;
            guna2TextBox3.Enabled = false;
        }


        private void UpdatePassword()
        {
            // Concatenate the text from all four textboxes to form the entered password
            enteredPassword = txtPasscode1.Text + guna2TextBox1.Text + guna2TextBox2.Text + guna2TextBox3.Text;
        }

        private void AuthenticateUser(string username, string password)
        {
            // Retrieve the stored password for the given username
            string storedPassword = GetStoredPassword(username);

            // Check if the stored password matches the entered password
            if (storedPassword != null && storedPassword == password)
            {
                // Set the current username after successful authentication
                SharedData.CurrentUsername = username;


                // Show main menu
                frmMainMenu mainMenu = new frmMainMenu();
                mainMenu.FormClosed += (s, args) => this.Close();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                // Password is incorrect, display error message
                MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear entered password and reset focus to the first textbox
                ClearPassword();
                txtPasscode1.Focus();
            }
        }
        private string GetStoredPassword(string username)
        {
            // User feature removed - tbUser table no longer exists
            // This method is kept for compatibility but returns null
            return null;
        }

    }
}
