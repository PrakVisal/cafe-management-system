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
    public partial class frmCRUD_Item : Form
    {
        public frmCRUD_Item()
        {
            InitializeComponent();
        }   
        public frmCRUD_Item(string title)
        {
            InitializeComponent();
            
            if (title.Equals("New Item"))
                btnDelete.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
