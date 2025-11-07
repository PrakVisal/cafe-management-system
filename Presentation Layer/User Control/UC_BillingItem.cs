using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_Project.Business_Layer;

namespace RMS_Project
{
    public partial class UC_BillingItem : UserControl
    {
        private readonly Item item;
        private frmOrders frmOrder;

        public int ItemId { get; }
        public int ItemAmount
        {
            get => Convert.ToInt32(lblQty.Text);
            set
            {
                lblQty.Text = value.ToString();                              
            }
        }
        public decimal TotalPrice
        {
            get => Convert.ToDecimal(lblTotalPrice.Text);
            set => lblTotalPrice.Text = value.ToString();
        }
        
        public UC_BillingItem(frmOrders frmOrder, Item item)
        {
            InitializeComponent();

            this.frmOrder = frmOrder;
            this.item = item;
            this.ItemId = item.ItemID;

            lblNo.Text = frmOrder.pnlCartItem.Controls.Count.ToString();
            lblItemName.Text = item.ItemName;
            lblQty.Text = "1";
            lblUnitPrice.Text = item.ItemPrice.ToString();
            lblTotalPrice.Text = Convert.ToString(item.ItemPrice * Convert.ToInt32(lblQty.Text));
        }
    }
}