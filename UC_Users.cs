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
    public partial class UC_Users : UserControl
    {
        public UC_Users()
        {
            InitializeComponent();
        }

        private void btnUC_User_Click(object sender, EventArgs e)
        {
            frmCRUD_User frmCRUD_User = new frmCRUD_User();
            frmCRUD_User.ShowDialog(); 
        }
    }
}
