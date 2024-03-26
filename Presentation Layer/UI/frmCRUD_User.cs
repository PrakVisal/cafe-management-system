using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.VisualBasic.ApplicationServices;
using RMS_Project.Business_Layer;

namespace RMS_Project
{
    public partial class frmCRUD_User : Form
    {
        RMS_Project.Business_Layer.User user = null;
        public frmCRUD_User()
        {
            InitializeComponent();

            lblTitle.Text = "Edit User";

            this.user = user;
            txtFullname.Text = user.Fullname;
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password;
            cboRole.Text = user.Role;
            cboStatus.Text = user.Status ? "Active" : "Inactive";
            ptrImage.Image = Business_Layer.ImageConverter.ConvertByteArrayToImage(user.Image);
        }
        public frmCRUD_User(string title)
        {
            InitializeComponent();
            if (title == "Add New User")
                btnDelete.Visible = false;
                
            lblTitle.Text = title;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Delete User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    UserManager.DeleteUser(user.UserID);
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblTitle.Text == "Add New User")
                {
                    RMS_Project.Business_Layer.User user = CreateUser();
                    UserManager.AddUser(user);
                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RMS_Project.Business_Layer.User user = UpdateUser();
                    UserManager.UpdateUser(user);
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close(); return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUC_User_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\"; // Set initial directory
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            DialogResult result = await Task.Run(() => ofd.ShowDialog(this));
            if (result == DialogResult.OK)
            {
                try
                {
                    ptrImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    // Load the image using Image.FromFile to handle potential errors
                    using (Image img = Image.FromFile(ofd.FileName))
                    {
                        ptrImage.Image = new Bitmap(img);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private RMS_Project.Business_Layer.User CreateUser()
        {
            try
            {
                string fullname = txtFullname.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string role = cboRole.Text;
                bool status = (cboStatus.Text.Equals("Active", StringComparison.OrdinalIgnoreCase)) ? true : false;
                byte[] imageBytes = Business_Layer.ImageConverter.ConvertImageToBytes(ptrImage);

                // Check if a user with the same username already exists
                if (UserManager.UserExists(username))
                {
                    throw new Exception("A user with this username already exists.");
                }

                return new RMS_Project.Business_Layer.User
                {
                    Fullname = fullname,
                    Username = username,
                    Password = password,
                    Role = role,
                    Status = status,
                    Image = imageBytes
                };
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the user: " + ex.Message);
            }
        }

        private RMS_Project.Business_Layer.User UpdateUser()
        {
            try
            {
                string fullname = txtFullname.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string role = cboRole.Text;
                bool status = (cboStatus.Text.Equals("Active", StringComparison.OrdinalIgnoreCase)) ? true : false;
                byte[] imageBytes = Business_Layer.ImageConverter.ConvertImageToBytes(ptrImage);


                RMS_Project.Business_Layer.User user = new RMS_Project.Business_Layer.User
                {
                    UserID = this.user.UserID,
                    Fullname = fullname,
                    Username = username,
                    Password = password,
                    Role = role,
                    Status = status,
                    Image = imageBytes
                };

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the user: " + ex.Message);
            }
        }

    }
}
