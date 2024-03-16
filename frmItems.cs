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
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            frmCRUD_Item frm = new frmCRUD_Item("New Item");
            frm.ShowDialog();
        }
    }
}
