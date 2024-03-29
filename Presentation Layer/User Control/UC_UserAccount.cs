using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using RMS_Project.Business_Layer;
using User = RMS_Project.Business_Layer.User;
using ImageConverter = RMS_Project.Business_Layer.ImageConverter;

namespace RMS_Project
{
   
    public partial class UC_UserAccount : UserControl
    {
        private User user;
        public string selectedUsername { get; set; }
        public UC_UserAccount(User user)
        {
            InitializeComponent();
            this.user = user;
            label1.Text = user.Username;

            if (user.Image != null)
            {
                ptrImage.Image = ImageConverter.ConvertByteArrayToImage(user.Image);
            }
            else
            {
                // Handle null image data
            }

            // Set the SizeMode property of the PictureBox to StretchImage
            ptrImage.SizeMode = PictureBoxSizeMode.StretchImage;

            // Wire up click event to handle user account click
            guna2Button1.CheckedChanged += RadioButton_CheckedChanged;
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If this radio button is checked, set its value to 1 and reset the value of all other radio buttons to 0
            if (guna2Button1.Checked)
            {
                selectedUsername = user.Username;
                SetOtherRadioButtonsToZero();
                OnUserAccountClicked(new UserAccountClickedEventArgs(user.Username));
            }
        }
        private void SetOtherRadioButtonsToZero()
        {
            // Iterate through all controls in the parent container (flowLayoutPanel1)
            foreach (Control control in Parent.Controls)
            {
                // Check if the control is a UC_UserAccount instance
                if (control is UC_UserAccount uc)
                {
                    // If the current UC_UserAccount instance is not this instance and its radio button is checked,
                    // uncheck its radio button
                    if (uc != this && uc.guna2Button1.Checked)
                    {
                        uc.guna2Button1.Checked = false;
                        uc.selectedUsername = null;
                    }
                }
            }
        }
        public event EventHandler<UserAccountClickedEventArgs> UserAccountClicked;

        protected virtual void OnUserAccountClicked(UserAccountClickedEventArgs e)
        {
            UserAccountClicked?.Invoke(this, e);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OnUserAccountClicked(new UserAccountClickedEventArgs(user.Username, user.Password));
        }
    }
}
