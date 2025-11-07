using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_Project.Business_Layer;

namespace RMS_Project
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
            LoadData();
            btnAccount.Visible = false; // Hide account button (login feature removed)
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
        }

        private void btnNewUsers_Click(object sender, EventArgs e)
        {
            frmCRUD_User frm = new frmCRUD_User("Add New User");
            //frm.FormClosed += FrmCRUD_User_FormClosed; // Subscribe to the FormClosed event
            frm.FormClosed += frmUsers_FormClosed; // Subscribe to the FormClosed event
            frm.ShowDialog();
        }

        private void frmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Clear the flow panel first
            pnlUser.Controls.Clear();

            // Get the list of users from the database
            List<User> users = UserManager.ReadUser();

            // Check if users list is not null or empty
            if (users != null && users.Any())
            {

                // Loop through each user
                foreach (User user in users)
                {
                    UC_Users uc = new UC_Users(user);

                    // Add the user control to the panel
                    pnlUser.Controls.Add(uc);
                }
            }
            else
            {
                // Handle no data in table
                MessageBox.Show("No users found in the database.");
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            // Login feature removed - button disabled
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {


            string searchText = txtSearchProduct.Text.Trim();

            
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
