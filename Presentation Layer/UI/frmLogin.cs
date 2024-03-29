using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_Project.Business_Layer;
using RMS_Project.Class;
using System.Drawing;

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
            // Get the list of users from the database
            List<User> users = UserManager.ReadUser();

            // Check if users list is not null or empty
            if (users != null && users.Any())
            {
                foreach (User user in users)
                {
                    UC_UserAccount uc = new UC_UserAccount(user);
                    // Wire up the click event for each user account
                    uc.UserAccountClicked += UC_UserAccountClicked;
                    flowLayoutPanel1.Controls.Add(uc);
                }
            }
            else
            {
                MessageBox.Show("No users found in the database.");
            }
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
        private void UC_UserAccountClicked(object sender, UserAccountClickedEventArgs e)
        {
            selectedUsername = e.Username;

            // Clear entered password when a user account is clicked
            ClearPassword();
            // Enable textboxes to enter password
            EnablePasswordTextBoxes();            // Focus on the first textbox
            txtPasscode1.Focus();
            // Set user selected flag to true
            isUserSelected = true;

        }
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

            string query = "SELECT Password FROM tbUser WHERE UserName = @Username;";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    return (string)command.ExecuteScalar();
                }
            }
        }

    }
}
