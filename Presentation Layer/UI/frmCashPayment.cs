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

namespace RMS_Project.Presentation_Layer.UI
{
    public partial class frmCashPayment : Form
    {
        frmInvoice invoiceForm = new frmInvoice();
        public frmCashPayment(string subTotal, string tax, string totalDollar, string totalRiel)
        {

            InitializeComponent();

            txtSubTotal.Text = subTotal;
            txtTax.Text = tax;
            txtTotalDollar.Text = totalDollar;
            txtTotalRiel.Text = totalRiel;
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        decimal usdAmount;
        decimal  rielAmount;
        decimal chargeRiel = 0;
        decimal chargeDollar = 0;
        private void InsertOrderIntoDatabase()
        {
            DateTime orderDate = DateTime.Now;
            decimal totalRiel = decimal.Parse(txtTotalRiel.Text.Split(' ')[0]);
            decimal totalDollar = decimal.Parse(txtTotalDollar.Text.Split('$')[1]);

            //totalDollar is total in dollar
            //
            
            // Parse USD amount, default to 0 if parsing fails
            decimal.TryParse(txtUSDAmount.Text, out usdAmount);
            // Parse Riel amount, default to 0 if parsing fails
            decimal.TryParse(txtRielAmount.Text, out rielAmount);

            
           
            if (decimal.TryParse(txtUSDAmount.Text, out decimal usd) && decimal.TryParse(txtRielAmount.Text, out decimal riel))
            {

                if (txtRielAmount.Text == "0")
                {
                    chargeRiel = (riel + (usd * 4000)) - (totalDollar * 4000);
                }
                else
                {
                    chargeRiel = (riel + (usd * 4000)) - (totalDollar * 4100);
                }
                chargeDollar = 0.00m;
                txtChangeDollar.Text = "0.00";
                txtChangeRiel.Text = chargeRiel.ToString();
            }

            int payment = 1;
            OrderManager.GetOrder(orderDate, totalRiel, totalDollar, chargeRiel, chargeDollar , payment );
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertOrderIntoDatabase();
            //this.Close();

            if (invoiceForm != null)
            {
                invoiceForm = GetForm<frmInvoice>();
                invoiceForm.lblRecievedRiel.Text = "Riel " + txtRielAmount.Text;
                invoiceForm.lblRecievedDollar.Text = "$" + decimal.Parse(txtUSDAmount.Text).ToString("0.00");
                invoiceForm.lblChange.Text = "Riel " + chargeRiel.ToString("0");
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
            if (decimal.TryParse(txtUSDAmount.Text, out decimal usd) && decimal.TryParse(txtRielAmount.Text, out decimal riel))
            {
                // Calculate the chargeRiel and assign it to txtChangeRiel.Text
                if (txtRielAmount.Text == "0")
                {
                    chargeRiel = (riel + (usd * 4000)) - (decimal.Parse(txtTotalDollar.Text) * 4000);
                }
                else
                {
                    chargeRiel = (riel + (usd * 4000)) - (decimal.Parse(txtTotalDollar.Text) * 4100);
                }
                txtChangeRiel.Text = chargeRiel.ToString();

                txtChangeDollar.Text = "0.00";
            }
            else
            {             
                txtChangeRiel.Text = "";
            }

           
        }
    }
    
}
