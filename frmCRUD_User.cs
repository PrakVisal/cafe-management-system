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
    public partial class frmCRUD_User : Form
    {
        public frmCRUD_User()
        {
            InitializeComponent();
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
    }
}
