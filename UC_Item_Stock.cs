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
    public partial class UC_Item_Stock : UserControl
    {
        frmCRUD_Stock frmCrudStock;
        public UC_Item_Stock()
        {
            InitializeComponent();
        }

        private void btnUCItems_Click(object sender, EventArgs e)
        {
            frmCrudStock = new frmCRUD_Stock();
            frmCrudStock.ShowDialog();
        }
    }
}
