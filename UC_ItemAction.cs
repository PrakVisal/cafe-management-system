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
    public partial class UC_ItemAction : UserControl
    {
        public UC_ItemAction()
        {
            InitializeComponent();
        }

        private void btnUC_Item_Click(object sender, EventArgs e)
        {
            frmCRUD_Item frmCRUD_Item = new frmCRUD_Item();
            frmCRUD_Item.ShowDialog();
        }
    }
}
