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
using RMS_Project;

namespace RMS_Project.Presentation_Layer.UI
{
    public partial class frmCashPayment : Form
    {
        frmInvoice invoiceForm = new frmInvoice();
        
        // Properties to store payment information
        public bool IsPaymentValid { get; private set; } = false;
        public decimal ReceivedUSD { get; private set; }
        public decimal ReceivedRiel { get; private set; }
        public decimal ChangeRiel { get; private set; }
        public decimal ChangeDollar { get; private set; }
        public decimal TotalDollar { get; private set; }
        public decimal TotalRiel { get; private set; }
        
        public frmCashPayment(string subTotal, string tax, string totalDollar, string totalRiel)
        {
            InitializeComponent();

            txtSubTotal.Text = subTotal;
            txtTax.Text = tax;
            txtTotalDollar.Text = totalDollar;
            txtTotalRiel.Text = totalRiel;
            
            // Parse and store totals
            TotalDollar = decimal.Parse(totalDollar.Split('$')[1]);
            TotalRiel = decimal.Parse(totalRiel.Split(' ')[0]);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ValidateAndCalculatePayment()
        {
            // Parse received amounts
            decimal.TryParse(txtUSDAmount.Text, out decimal receivedUSD);
            decimal.TryParse(txtRielAmount.Text, out decimal receivedRiel);
            
            // Calculate total received in Riel
            decimal totalReceivedRiel;
            if (receivedRiel == 0)
            {
                // If no Riel received, convert USD at 4000 rate
                totalReceivedRiel = receivedUSD * 4000;
            }
            else
            {
                // If Riel received, convert USD at 4000 rate and add Riel
                totalReceivedRiel = (receivedUSD * 4000) + receivedRiel;
            }
            
            // Calculate total required in Riel (using 4100 rate)
            decimal totalRequiredRiel = TotalDollar * 4100;
            
            // Check if payment is sufficient
            if (totalReceivedRiel < totalRequiredRiel)
            {
                decimal shortage = totalRequiredRiel - totalReceivedRiel;
                MessageBox.Show($"Insufficient payment!\n\nRequired: {totalRequiredRiel:N0} Riel\nReceived: {totalReceivedRiel:N0} Riel\nShortage: {shortage:N0} Riel", 
                    "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsPaymentValid = false;
                return;
            }
            
            // Calculate change in Riel
            ChangeRiel = totalReceivedRiel - totalRequiredRiel;
            
            // Calculate change in Dollar (convert Riel to Dollar using 4100 rate)
            ChangeDollar = ChangeRiel / 4100;
            
            // Store payment info
            ReceivedUSD = receivedUSD;
            ReceivedRiel = receivedRiel;
            
            // Display change
            txtChangeRiel.Text = ChangeRiel.ToString("N0");
            txtChangeDollar.Text = ChangeDollar.ToString("F2");
            
            // Update invoice form
            if (invoiceForm != null)
            {
                invoiceForm = GetForm<frmInvoice>();
                if (invoiceForm != null)
                {
                    invoiceForm.lblRecievedRiel.Text = "Riel " + receivedRiel.ToString("N0");
                    invoiceForm.lblRecievedDollar.Text = "$" + receivedUSD.ToString("0.00");
                    invoiceForm.lblChange.Text = $"Riel {ChangeRiel:N0} / ${ChangeDollar:F2}";
                }
            }
            
            IsPaymentValid = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate payment and calculate change
            ValidateAndCalculatePayment();
            
            if (IsPaymentValid)
            {
                // Close the form - order will be placed when user clicks "Place Order" button
                this.DialogResult = DialogResult.OK;
                this.Close();
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
                return default;
            }
        }

        private void txtUSDAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void txtRielAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void CalculateChange()
        {
            // Parse received amounts (default to 0 if empty or invalid)
            decimal usd = 0;
            decimal riel = 0;
            
            if (!string.IsNullOrWhiteSpace(txtUSDAmount.Text))
            {
                decimal.TryParse(txtUSDAmount.Text, out usd);
            }
            
            if (!string.IsNullOrWhiteSpace(txtRielAmount.Text))
            {
                decimal.TryParse(txtRielAmount.Text, out riel);
            }
            
            // If both fields are empty, clear change
            if (string.IsNullOrWhiteSpace(txtUSDAmount.Text) && string.IsNullOrWhiteSpace(txtRielAmount.Text))
            {
                txtChangeRiel.Text = "";
                txtChangeDollar.Text = "0.00";
                return;
            }
            
            // Calculate total received in Riel
            decimal totalReceivedRiel;
            if (riel == 0)
            {
                // If no Riel received, convert USD at 4000 rate
                totalReceivedRiel = usd * 4000;
            }
            else
            {
                // If Riel received, convert USD at 4000 rate and add Riel
                totalReceivedRiel = (usd * 4000) + riel;
            }
            
            // Calculate total required in Riel (using 4100 rate)
            decimal totalRequiredRiel = TotalDollar * 4100;
            
            // Calculate change in Riel (can be negative if insufficient)
            decimal changeRiel = totalReceivedRiel - totalRequiredRiel;
            
            // Calculate change in Dollar (convert Riel to Dollar using 4100 rate)
            decimal changeDollar = changeRiel / 4100;
            
            // Display change
            if (changeRiel >= 0)
            {
                txtChangeRiel.Text = changeRiel.ToString("N0");
                txtChangeDollar.Text = changeDollar.ToString("F2");
            }
            else
            {
                // Show negative change (shortage) - user will see error when confirming
                txtChangeRiel.Text = changeRiel.ToString("N0");
                txtChangeDollar.Text = changeDollar.ToString("F2");
            }
        }
    }

}
