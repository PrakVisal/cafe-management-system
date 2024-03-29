using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;

namespace RMS_Project
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
            LoadPaymentImage();
        }
        public void SetQRCodeImage(string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    SetImageOnUIThread(image);
                }
                else
                {
                    MessageBox.Show($"Image file not found: {imagePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void SetImageOnUIThread(Image image)
        {
            if (ptrQRCode.InvokeRequired)
            {
                // If we're not on the UI thread, invoke this method on the UI thread
                ptrQRCode.Invoke(new Action<Image>(SetImageOnUIThread), image);
            }
            else
            {
                // Set the image on the UI thread
                ptrQRCode.Image = image;
            }
        }

        
        private void LoadPaymentImage()
        {
            // Get your image from your resources
            Image yourImage = RMS_Project.Properties.Resources.usd1;

            // Set the image on the UI thread
            SetImageOnUIThread(yourImage);
        }
    }
   
    
}
