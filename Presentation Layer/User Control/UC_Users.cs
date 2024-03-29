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
    public partial class UC_Users : UserControl
    {
        User user = null;
        public UC_Users(User user)
        {
            InitializeComponent();

            this.user = user;
            this.lblUsername.Text = user.Username;
            try
            {
                if (user.Image != null)
                {
                    this.ptrUserImage.Image = Business_Layer.ImageConverter.ConvertByteArrayToImage(user.Image);
                }
                else
                {
                    // Handle null image data
                }
            }
            catch (Exception ex)
            {
                // Log or display the exception details
                Console.WriteLine(ex.Message);
            }

            if (user.Status)
            {
                this.lblStatus.Text = "Active";
                this.lblStatus.ForeColor = Color.Green;
            }
            else
            {
                this.lblStatus.Text = "Inactive";
                this.lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnUC_User_Click(object sender, EventArgs e)
        {
            frmCRUD_User frmCRUD_User = new frmCRUD_User(user);
            frmCRUD_User.ShowDialog(); 
        }
    }
}
