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
        decimal usdAmount, rielAmount;
        decimal chargeRiel = 0, chargeDollar = 0;
        private void InsertOrderIntoDatabase()
        {
            DateTime orderDate = DateTime.Now;
            decimal totalRiel = decimal.Parse(txtTotalRiel.Text.Split(' ')[0]);
            decimal totalDollar = decimal.Parse(txtTotalDollar.Text.Split('$')[1]);

            
            // Parse USD amount, default to 0 if parsing fails
            decimal.TryParse(txtUSDAmount.Text, out usdAmount);
            // Parse Riel amount, default to 0 if parsing fails
            decimal.TryParse(txtRielAmount.Text, out rielAmount);

            
           
            if (decimal.TryParse(txtUSDAmount.Text, out decimal usd) && decimal.TryParse(txtRielAmount.Text, out decimal riel))
            {
                chargeRiel = (riel + (usd * 4000)) - (totalDollar * 4000);
                chargeDollar = 0.00m;
                txtChangeDollar.Text = "0.00";
                txtChangeRiel.Text = chargeRiel.ToString();
            }

            int payment = 1;
            // Save the order using OrderManager
            OrderManager.GetOrder(orderDate, totalRiel, totalDollar, chargeRiel, chargeDollar , payment );
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertOrderIntoDatabase();
            this.Close();
        }

        private void txtUSDAmount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUSDAmount.Text, out decimal usd) && decimal.TryParse(txtRielAmount.Text, out decimal riel))
            {
                // Calculate the chargeRiel and assign it to txtChangeRiel.Text
                chargeRiel = (riel + (usd * 4000)) - (decimal.Parse(txtTotalDollar.Text) * 4000) ;
                txtChangeRiel.Text = chargeRiel.ToString();

                txtChangeDollar.Text = "0.00";
            }
            else
            {
                // Handle invalid input, for example, you can set the text to empty or display a message to the user
                txtChangeRiel.Text = "";
            }

           
        }
    }
    
}
