using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using RMS_Project.Business_Layer;
using ImageConverter = RMS_Project.Business_Layer.ImageConverter;

namespace RMS_Project
{
    public partial class UC_Item : UserControl
    {
        private readonly Item item;
        private frmOrders frmOrder;
        public string Category { get; private set; }
        public string ItemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }

        public UC_Item(Item item)
        {
            InitializeComponent();
            this.item = item;
            InitializeUI();
        }

        public UC_Item(frmOrders frmOrder, Item item) : this(item)
        {
            this.frmOrder = frmOrder;
        }

        private void InitializeUI()
        {
            lblItemName.Text = item.ItemName;
            lblPrice.Text = item.ItemPrice.ToString();
            lblDescription.Text = item.ItemDescription;
            Category = item.ItemCategory;

            ptrImage.Image = item.itemImage != null
                ? ImageConverter.ConvertByteArrayToImage(item.itemImage)
                : Properties.Resources.no_image;
        }
        private void btnUC_Item_Click(object sender, EventArgs e)
        {
            frmInvoice invoiceForm = GetForm<frmInvoice>();
            frmOrder = GetForm<frmOrders>();

            if (invoiceForm != null && frmOrder != null)
            {
                IncrementCartItem(invoiceForm);
                IncrementBillingItem(invoiceForm);

                foreach (UC_CartItem cartItem in frmOrder.pnlCartItem.Controls.OfType<UC_CartItem>())
                {
                    cartItem.DeleteButtonClick += frmOrder.HandleCartItemDeleteButtonClick;
                }

            }
            else
            {
                ShowErrorMessage("Unable to find the required forms.");
            }

        }

        
        private void IncrementCartItem(frmInvoice invoiceForm)
        {
            UC_CartItem existingCartItem = frmOrder.pnlCartItem.Controls
                .OfType<UC_CartItem>()
                .FirstOrDefault(ci => ci.ItemId == item.ItemID);

            if (existingCartItem != null)
            {
                existingCartItem.ItemAmount += 1;
                frmOrder.RecalculateSubTotal();
            }
            else
            {
                UC_CartItem cartItem = new UC_CartItem(invoiceForm, item);

                if (invoiceForm.pnlnvoiceItem.InvokeRequired)
                {
                    frmOrder.pnlCartItem.Invoke(new Action(() => frmOrder.pnlCartItem.Controls.Add(cartItem)));
                    frmOrder.RecalculateSubTotal();
                }
                else
                {
                    frmOrder.pnlCartItem.Controls.Add(cartItem);
                    frmOrder.RecalculateSubTotal();
                }
                
            }
        }

        private void IncrementBillingItem(frmInvoice invoiceForm)
        {
            UC_BillingItem existingBillingItem = invoiceForm.pnlnvoiceItem.Controls
                .OfType<UC_BillingItem>()
                .FirstOrDefault(bi => bi.ItemId == item.ItemID);

            if (existingBillingItem != null)
            {
                existingBillingItem.ItemAmount += 1;
                existingBillingItem.TotalPrice = existingBillingItem.ItemAmount * item.ItemPrice;
                invoiceForm.CalculateSubTotal();
            }
            else
            {
                UC_BillingItem billingItem = new UC_BillingItem(frmOrder, item);

                if (invoiceForm.pnlnvoiceItem.InvokeRequired)
                {
                    invoiceForm.pnlnvoiceItem.Invoke(new Action(() => invoiceForm.pnlnvoiceItem.Controls.Add(billingItem)));
                    invoiceForm.CalculateSubTotal();
                }
                else
                {
                    invoiceForm.pnlnvoiceItem.Controls.Add(billingItem);
                    invoiceForm.CalculateSubTotal();
                }
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public T GetForm<T>() where T : Form
        {
            try
            {
                return Application.OpenForms.OfType<T>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Error while retrieving form: {ex.Message}");
                return default;
            }
        }      
    }
}

