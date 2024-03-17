using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class UC_Item : UserControl
    {
        frmOrders frmOrders;
        frmInvoice frmInvoice;
        UC_CartItem cartItem;
        UC_BillingItem billingItem;

        public UC_Item()
        {
            InitializeComponent();
        }

        private void btnUC_Item_Click(object sender, EventArgs e)
        {
            // Check if frmOrders is already open
            frmOrders = Application.OpenForms.OfType<frmOrders>().FirstOrDefault();

            if (frmOrders == null)
            {
                // Create the frmOrders form on the main UI thread
                Thread uiThread = new Thread(() =>
                {
                    frmOrders = new frmOrders();
                    Application.Run(frmOrders);
                });

                uiThread.SetApartmentState(ApartmentState.STA);
                uiThread.Start();
            }

            // Check if frmInvoice is already open
            if (frmInvoice == null)
            {
                frmInvoice = Application.OpenForms.OfType<frmInvoice>().FirstOrDefault();
            }

            if (frmInvoice != null)
            {
                if (billingItem == null)
                {
                    // Create the billingItem control on the main UI thread
                    frmInvoice.Invoke(new Action(() =>
                    {
                        billingItem = new UC_BillingItem();
                        frmInvoice.pnlnvoiceItem.Controls.Add(billingItem);
                    }));
                }
            }

            // Create the cartItem control on the main UI thread
            frmOrders.Invoke(new Action(() =>
            {
                cartItem = new UC_CartItem();
                frmOrders.pnlCartItem.Controls.Add(cartItem);
            }));
        }
    }
}