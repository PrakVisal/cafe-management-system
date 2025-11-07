using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace RMS_Project
{
    public partial class frmInvoice : Form
    {
        public frmInvoice InvoiceForm { get; set; }
        public frmInvoice()
        {
            InitializeComponent();
            LoadPaymentImage();
            
        }
        private void SetImageOnUIThread(Image image)
        {
            if (ptrQRCode.InvokeRequired)
            {
                // If we're not on the UI thread, invoke this method on the UI thread
                ptrQRCode.Invoke(new Action<Image>(SetImageOnUIThread), image);
            }
            else
            {
                // Set the image on the UI thread
                ptrQRCode.Image = image;
            }
        }
        
        private void LoadPaymentImage()
        {
            // Get your image from your resources
            Image yourImage = RMS_Project.Properties.Resources.usd1;

            // Set the image on the UI thread
            SetImageOnUIThread(yourImage);
        }
        private decimal subTotal = 0.00m;

        public void CalculateSubTotal()
        {
            subTotal = 0.00m;

            foreach (UC_BillingItem billingItem in pnlnvoiceItem.Controls.OfType<UC_BillingItem>())
            {
                subTotal += billingItem.TotalPrice;
            }
            lblSubTotal.Text = "$" + subTotal.ToString();
            decimal taxRate = 0.00m;
            lblTotalTax.Text = "$" + taxRate.ToString();
            decimal grandTotalDollor = subTotal + (taxRate * subTotal);
            lblGrandTotalDollar.Text = "$" + grandTotalDollor.ToString("F2");
            decimal dollarToRiel = 4100;
            decimal grandTotalRiel = grandTotalDollor * dollarToRiel;
            int grandToTalRielToInt = Convert.ToInt32(grandTotalRiel);
            lblGrandTotalRiel.Text = grandToTalRielToInt.ToString() + " Riel";
        }

        
        public void RemoveBillingItem(int itemId)
        {
            UC_BillingItem billingItemToRemove = pnlnvoiceItem.Controls
                .OfType<UC_BillingItem>()
                .FirstOrDefault(bi => bi.ItemId == itemId);

            if (billingItemToRemove != null)
            {
                pnlnvoiceItem.Controls.Remove(billingItemToRemove);
                // Recalculate subtotal after removing the item
                CalculateSubTotal();
            }
        }
    }
}
