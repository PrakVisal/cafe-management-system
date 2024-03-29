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

namespace RMS_Project
{
    public partial class frmOrders : Form
    {
        private Guna2Button currentButton;
        private decimal subTotal = 0.00m;
        public frmOrders()
        {
            InitializeComponent();
            btnAll.Click += btnAll_Click;
            btnAccount.Text = SharedData.CurrentUsername;
        
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

        private void LoadProducts()
        {
            DataTable productsTable = OrderManager.GetProducts();

            foreach (DataRow row in productsTable.Rows)
            {
                string productName = row["ProductName"].ToString();
                decimal price = Convert.ToDecimal(row["Price"]);
                string description = row["Description"].ToString();
                byte[] imageData = (byte[])row["Image"];
                Image image = Image.FromStream(new System.IO.MemoryStream(imageData));
                string category = row["FoodCategoryName"].ToString();

                UC_Item ucItem = new UC_Item(productName, price, description, image, category);
                ucItem.BtnUC_ItemClick += (sender, e) => AddToCart(ucItem);
                ucItem.ItemName = productName;
                ucItem.Label1Text = price.ToString();
                ucItem.PictureBoxImage = image;
                flowLayoutPanel2.Controls.Add(ucItem);
            }
        }

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
            decimal grandTotalRiel = grandTotalDollor * dollarToRiel;
            int grandToTalRielToInt = Convert.ToInt32(grandTotalRiel);
            lblGrandTotalRiel.Text = grandToTalRielToInt.ToString() + " Riel";
        }

        public void RecalculateSubTotal()
        {
            CalculateSubTotal();
        }

        private void AddToCart(UC_Item ucItem)
        {
            UC_CartItem existingCartItem = pnlCartItem.Controls.OfType<UC_CartItem>()
                                           .FirstOrDefault(c => c.LabelName == ucItem.ItemName);
            if (existingCartItem != null)
            {
                existingCartItem.IncreaseQuantity();
            }
            else
            {
                UC_CartItem cartItem = new UC_CartItem(ucItem.ItemName, ucItem.Label1Text, ucItem.PictureBoxImage);
                cartItem.TxtAmount = 1;
                cartItem.LblPriceText = decimal.Parse(ucItem.Label1Text);
                pnlCartItem.Controls.Add(cartItem);
                cartItem.DeleteButtonClick += (s, args) => RemoveCartItem(cartItem);
                RecalculateSubTotal();

            }

        }

        private void LoadCartItemProduct()
        {
            foreach (UC_CartItem existingCartItem in pnlCartItem.Controls.OfType<UC_CartItem>())
            {
                UC_CartItem cartItem = existingCartItem;
                cartItem.DeleteButtonClick += (s, args) => RemoveCartItem(cartItem);
            }
        }

        private void RemoveCartItem(UC_CartItem cartItem)
        {
            this.pnlCartItem.Controls.Remove(cartItem);
            cartItem.Dispose(); // Dispose the UC_CartItem instance
            RecalculateSubTotal();
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
                if (cartItem.LabelName == "BBQ spicy")
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


        


        private void btnBeverages_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Beverages");
        }

    

        private void btnFrappes_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Frappes");

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

        private void btnCash_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            frmCashPayment frmcash = new frmCashPayment(lblSubTotal.Text, lblTax.Text, 
                lblGrandTotalDollor.Text, lblGrandTotalRiel.Text);
            frmcash.ShowDialog();
        }
        frmInvoice invoiceForm = new frmInvoice();
        private void btnKHQR_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            using (var frmKHQR = new frmKHQRPayment(invoiceForm, lblSubTotal.Text, lblTax.Text, lblGrandTotalDollor.Text, lblGrandTotalRiel.Text))
            {
                frmKHQR.ShowDialog(); // Show frmKHQRPayment as a dialog


                // Retrieve the selected image path after frmKHQRPayment is closed
                string selectedImagePath = frmKHQR.SelectedImagePath;
                // Set the QR code image in frmInvoice.cs
                invoiceForm.SetQRCodeImage(selectedImagePath);
                
            }
        }

        private void btnMeat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Meats");

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowAllItems();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCartItemProduct();
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
            //InsertOrderIntoDatabase();
            PrintReceipt();

        }
    }
}
