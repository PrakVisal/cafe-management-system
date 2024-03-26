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
    public partial class UC_CartItem : UserControl
    {

        public string LabelName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public decimal LblPriceText
        {
            get { return decimal.Parse(lblPrice.Text); }
            set
            {
                lblPrice.Text = value.ToString();
            }
        }

        public int TxtAmount
        {
            get { return int.Parse(txtAmount.Text); }
            set { txtAmount.Text = value.ToString(); }
        }
     

        public class ItemAddedEventArgs : EventArgs
        {
            public string ItemName { get; }
            public int Quantity { get; }
            public decimal Price { get; }

            public ItemAddedEventArgs(string itemName, int quantity, decimal price)
            {
                ItemName = itemName;
                Quantity = quantity;
                Price = price;
            }
        }
        public UC_CartItem()
        {
            InitializeComponent();
        }
        public UC_CartItem(string name, string price, Image img)
        {
            InitializeComponent();
            lblName.Text = name;
            lblPrice.Text = price;
            ptrImage.Image = img;
        }

        public void IncreaseQuantity()
        {
            int currentQuantity = int.Parse(txtAmount.Text);
            currentQuantity++;
            txtAmount.Text = currentQuantity.ToString();
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDecreease_Click_1(object sender, EventArgs e)
        {
            if (TxtAmount > 1)
                TxtAmount--;
        }

        private void btnIncrease_Click_1(object sender, EventArgs e)
        {
            TxtAmount++;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
    }
}

