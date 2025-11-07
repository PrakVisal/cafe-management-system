using DocumentFormat.OpenXml.VariantTypes;
using Guna.UI2.WinForms;
using RMS_Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_Project.Business_Layer;
using RMS_Project.Presentation_Layer.UI;
using System.Drawing.Printing;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using Item = RMS_Project.Business_Layer.Item;

namespace RMS_Project
{
    public partial class frmOrders : Form
    {
        public frmInvoice InvoiceForm { get; set; }       
        private UC_CartItem uC_CartItem = null;
        private Guna2Button currentButton;
        public frmOrders()
        {
            InitializeComponent();

            LoadData();
            btnAccount.Visible = false; // Hide account button (login feature removed)

        }

        private void ActiveButton(object btnsender)
        {
            if (btnsender != null)
            {
                // Call DisableButton before updating currentButton
                DisableButton();
                currentButton = (Guna2Button)btnsender;
                currentButton.Checked = true;
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.Checked = false;
                currentButton.FillColor = Color.WhiteSmoke;
            }
        }

        private void LoadData()
        {
            // Clear the flow panel first
            flowLayoutPanel2.Controls.Clear();

            // Get the list of orders from the database
            List<Item> items = ItemManager.ReadItemToOrder();

            // Check if orders list is not null or empty
            if (items != null && items.Any())
            {
                // Loop through each order
                foreach (Item item in items)
                {
                    UC_Item uc = new UC_Item(this, item);

                    flowLayoutPanel2.Controls.Add(uc);
                    RecalculateSubTotal();
                }               
            }
            else
            {
                // Handle no data in table
                MessageBox.Show("No items found in the database.");
            }

            if (pnlCartItem.Controls.Count == 0)
            { 
               
                if (invoiceForm != null)
                {
                    invoiceForm = GetForm<frmInvoice>();
                    invoiceForm.pnlnvoiceItem.Controls.Clear();
                    invoiceForm.CalculateSubTotal();
                }
            }
        }
        public T GetForm<T>() where T : Form
        {
            try
            {
                return Application.OpenForms.OfType<T>().FirstOrDefault();
    }
            catch (Exception)
            {
                MessageBox.Show("Open form error");
                return default;
            }
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Beverages");
        }

        private void btnFrappes_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Beverages");
        }

        private void btnJuices_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Juices");
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Snacks");
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Breakfast");
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Lunch");
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Others");
        }

        private void btnPromotionSet_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Promotion Set");
        }
        
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchProduct.Text.Trim().ToLower(); // Convert the search text to lowercase for case-insensitive comparison

            foreach (Control control in flowLayoutPanel2.Controls)
            {
                UC_Item ucItem = control as UC_Item;
                if (ucItem != null)
                {
                    
                    string itemName = ucItem.ItemName.ToLower();
                    if (itemName.Contains(searchText))
                    {
                        ucItem.Visible = true;
                    }
                    else
                    {
                        ucItem.Visible = false;
                    }                   
                }
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FormHelper.AccountButton_Click(sender, e);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PrintReceipt();

        }
        private decimal subTotal = 0.00m;
        public void CalculateSubTotal()
        {
            subTotal = 0.00m;

            foreach (UC_CartItem cartItem in pnlCartItem.Controls.OfType<UC_CartItem>())
            {
                subTotal += cartItem.TxtAmount * cartItem.LblPriceText;
            }
            lblSubTotal.Text = "$" + subTotal.ToString();
            decimal taxRate = 0.00m;
            lblTax.Text = "$" + taxRate.ToString();
            decimal grandTotalDollor = subTotal + (taxRate * subTotal);
            lblGrandTotalDollor.Text = "$" + grandTotalDollor.ToString("F2");
            decimal dollarToRiel = 4100;
           // decimal dollarToRiel = 4000;
            decimal grandTotalRiel = grandTotalDollor * dollarToRiel;
            int grandToTalRielToInt = Convert.ToInt32(grandTotalRiel);
            lblGrandTotalRiel.Text = grandToTalRielToInt.ToString() + " Riel";
        }

        public void RecalculateSubTotal()
        {
            CalculateSubTotal();
        }
        private void FilterItemsByCategory(string category)
        {
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                UC_Item ucItem = control as UC_Item;
                if (ucItem != null)
                {
                    if (string.Equals(ucItem.Category, category, StringComparison.OrdinalIgnoreCase))
                    {
                        ucItem.Visible = true;
                    }
                    else
                    {
                        ucItem.Visible = false;
                    }
                }
            }
        }
        private void PrintReceipt()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string header = Receipt.HeaderReceipt();
            string body = "";
            foreach (UC_CartItem cartItem in pnlCartItem.Controls)
            {
                if (cartItem.LabelName == "BBQ Spicy")
                    body += $"{cartItem.LabelName}\t{cartItem.LblPriceText}\t\t{cartItem.TxtAmount}\t{cartItem.LblPriceText * cartItem.TxtAmount}\n";
                else

                    body += $"{cartItem.LabelName}\t\t{cartItem.LblPriceText}\t\t{cartItem.TxtAmount}\t{cartItem.LblPriceText * cartItem.TxtAmount}\n";
            }
            string footer = Receipt.FooterReceipt(subTotal);
            string receiptText = header + "DESCRIPTION\tUNIT PRICE\tQTY\tAMOUNT\n\n" + body + "\n" + footer;
            // Define font and brush
            Font font = new Font("Arial", 20, FontStyle.Bold);
            Brush brush = Brushes.Black;
            // Draw receipt text on the PrintPageEventArgs
            e.Graphics.DrawString(receiptText, font, brush, 50, 50);
        }
       

        private void btnCash_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
            frmCashPayment frmcash = new frmCashPayment(lblSubTotal.Text, lblTax.Text,
                lblGrandTotalDollor.Text, lblGrandTotalRiel.Text);
            frmcash.ShowDialog();

        }
        frmInvoice invoiceForm = new frmInvoice();

        private void btnKHQR_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
            using (var frmKHQR = new frmKHQRPayment(invoiceForm, lblSubTotal.Text, lblTax.Text, lblGrandTotalDollor.Text, lblGrandTotalRiel.Text))
            {
                frmKHQR.ShowDialog(); 

            }
        }

        private void btnAll_Click_1(object sender, EventArgs e)
        {
            ShowAllItems();
        }
        private void ShowAllItems()
        {
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                UC_Item ucItem = control as UC_Item;
                if (ucItem != null)
                {
                    ucItem.Visible = true;
                }
            }
        }

        public void HandleCartItemDeleteButtonClick(object sender, EventArgs e)
        {
            UC_CartItem_DeleteButtonClick(sender, e);
            RecalculateSubTotal();
        }

        private void UC_CartItem_DeleteButtonClick(object sender, EventArgs e)
        {
            // Remove the corresponding UC_CartItem when delete button is clicked
            UC_CartItem ucCartItem = sender as UC_CartItem;
            if (ucCartItem != null)
            {
                pnlCartItem.Controls.Remove(ucCartItem);

                // Communicate the delete action to frmInvoice
                invoiceForm?.RemoveBillingItem(ucCartItem.ItemId);
                
            }
            
        }   
    }
}
