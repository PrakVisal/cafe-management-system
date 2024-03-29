using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using RMS_Project.Business_Layer;
using System.IO;

namespace RMS_Project.Presentation_Layer.UI
{
    public partial class frmKHQRPayment : Form
    {
        private frmInvoice invoiceForm;
        public string SelectedImagePath { get; private set; }
        public frmKHQRPayment(frmInvoice invoiceForm, string subTotal, string tax, string totalDollar, string totalRiel)
        {
            InitializeComponent();
            txtSubTotal.Text = subTotal;
            txtTax.Text = tax;
            txtTotalDollar.Text = totalDollar;
            txtTotalRiel.Text = totalRiel;
            this.invoiceForm = invoiceForm;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            DateTime orderDate = DateTime.Now;
            decimal totalRiel = decimal.Parse(txtTotalRiel.Text.Split(' ')[0]);
            decimal totalDollar = decimal.Parse(txtTotalDollar.Text.Split('$')[1]);
            decimal chargeRiel = 0.00m;
            decimal chargeDollar = 0.00m;
            int payment = 2;

            OrderManager.GetOrder(orderDate, totalRiel, totalDollar, chargeRiel, chargeDollar, payment);
            this.Close();
        }

        private void btnUSD_Click(object sender, EventArgs e)
        {
            SelectedImagePath = @"C:\Users\siv naysim\source\repos\SeangMengKheang\RMS-Project\Resources\usd1.png";
            invoiceForm.SetQRCodeImage(SelectedImagePath);
        }

        private void btnKHR_Click(object sender, EventArgs e)
        {
            SelectedImagePath = @"C:\Users\siv naysim\source\repos\SeangMengKheang\RMS-Project\Resources\riel1.png";
            invoiceForm.SetQRCodeImage(SelectedImagePath);
        }
        
        
    }
}
