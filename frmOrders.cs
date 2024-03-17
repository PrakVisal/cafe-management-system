using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class frmOrders : Form
    {
        private Guna2Button currentButton;
        public frmOrders()
        {
            InitializeComponent();
        }
        
        private void ActiveButton(object btnsender)
        {
            if (btnsender != null)
            {
                // Call DisableButton before updating currentButton
                DisableButton();
                currentButton = (Guna2Button)btnsender;
                currentButton.Checked = true;
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.Checked = false;
                currentButton.FillColor = Color.WhiteSmoke;
            }
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnFrappes_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnJuices_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnPromotionSet_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnKHQR_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
    }
}
