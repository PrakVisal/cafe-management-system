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
    public partial class frmCRUD_Stock : Form
    {
        public frmCRUD_Stock()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUnitPrice.Text = "";
            txtPrice.Text = "";
            cboCategory.Text = "";
            txtSafetyAlert.Text = "";
            txtQty.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
