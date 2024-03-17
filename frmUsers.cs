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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnNewUsers_Click(object sender, EventArgs e)
        {
            frmCRUD_User frm = new frmCRUD_User("Add New User");
            frm.ShowDialog();
        }

    }
}
