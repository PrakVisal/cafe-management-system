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
using RMS_Project.Business_Layer;
using ImageConverter = RMS_Project.Business_Layer.ImageConverter;
using System.Runtime.CompilerServices;


namespace RMS_Project
{
    public partial class UC_CartItem : UserControl
    {
        private frmInvoice invoiceForm = null;
        private readonly Item item;

        public int ItemId { get; }
        public int ItemAmount
        {
            get => Convert.ToInt32(txtAmount.Text);
            set => txtAmount.Text = value.ToString();
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
            set
            {
                txtAmount.Text = value.ToString();
                UpdateSubTotal();
                UpdateBillingItemQuantity(value);

            }

        }
        public string LabelName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public UC_CartItem(frmInvoice frmInvoice, Item item)
        {
            InitializeComponent();
            this.item = item;
            this.invoiceForm = frmInvoice;

            ItemId = item.ItemID;
            InitializeUI();
        }

        private void InitializeUI()
        {
            lblName.Text = item.ItemName;
            lblPrice.Text = item.ItemPrice.ToString();
            txtAmount.Text = "1";

            if (item.itemImage != null)
            {
                ptrImage.Image = ImageConverter.ConvertByteArrayToImage(item.itemImage);
            }
            else
            {
                ptrImage.Image = Properties.Resources.no_image;
            }
        }
        
        private void btnDecreease_Click(object sender, EventArgs e)
        {
            if (TxtAmount > 1)
                TxtAmount--;          

        }
            
        private void btnIncrease_Click_1(object sender, EventArgs e)
        {
            TxtAmount++;
        }
        public void btnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteButtonClick?.Invoke(this, e);
        }

        public event EventHandler DeleteButtonClick;

        private void UpdateBillingItemQuantity(int quantity)
        {
            try
            {
                if (invoiceForm != null)
                {
                    UC_BillingItem billingItem = invoiceForm.pnlnvoiceItem.Controls
                    .OfType<UC_BillingItem>()
                    .FirstOrDefault(bi => bi.ItemId == item.ItemID);

                    if (billingItem != null)
                    {
                        billingItem.ItemAmount = quantity;
                        billingItem.TotalPrice = quantity * decimal.Parse(lblPrice.Text);
                        invoiceForm.CalculateSubTotal();
                    }
                    else
                    {
                        MessageBox.Show("billing item is null");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
        
        private void UpdateSubTotal()
        {
            frmOrders parentForm = this.ParentForm as frmOrders;
            parentForm?.CalculateSubTotal();
           
        }      
    }
}