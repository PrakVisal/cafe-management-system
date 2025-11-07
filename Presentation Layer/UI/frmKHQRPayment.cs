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
using Guna.UI2.WinForms;

namespace RMS_Project.Presentation_Layer.UI
{
    public partial class frmKHQRPayment : Form
    {
        private Guna2Button currentButton;       
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
        private void ActiveButton(object btnsender)
        {
            if (btnsender != null)
            {
                // Call DisableButton before updating currentButton
                DisableButton();
                currentButton = (Guna2Button)btnsender;
                currentButton.Checked = true;
                currentButton.ForeColor = Color.Black;
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.Checked = false;
                currentButton.FillColor = Color.WhiteSmoke;
                currentButton.ForeColor = Color.Black;
            }
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
            ActiveButton(sender);

            frmInvoice invoiceForm = GetForm<frmInvoice>();
            if (invoiceForm != null)
            {
                invoiceForm.ptrQRCode.Image = Properties.Resources.QR_USD;
            }
            else
            {
                ShowErrorMessage("Unable to find the required form.");
            }
        }

        private void btnKHR_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);

            frmInvoice invoiceForm = GetForm<frmInvoice>();
            if (invoiceForm != null)
            {
                invoiceForm.ptrQRCode.Image = Properties.Resources.KHR_QR;
            }
            else
            {
                ShowErrorMessage("Unable to find the required form.");
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private T GetForm<T>() where T : Form
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
