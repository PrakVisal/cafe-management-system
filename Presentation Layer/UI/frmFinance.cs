using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using RMS_Project.Class;

namespace RMS_Project
{
    public partial class frmFinance : Form
    {
        public frmFinance()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Load data for guna2ContainerControl1
            LoadGuna2ContainerControl1Data();

            // Load data for guna2ContainerControl2
            LoadGuna2ContainerControl2Data();

            // Load data for guna2ContainerControl3
            LoadGuna2ContainerControl3Data();

            // Load data for guna2ContainerControl4
            LoadGuna2ContainerControl4Data();
        }

        private void LoadGuna2ContainerControl1Data()
        {
            try
            {
                decimal totalAmount = FinanceManager.GetTotalAmountForPaymentMethod("KHQR");
                lblProBankAmt.Text = totalAmount.ToString();
                int orderCount = FinanceManager.GetOrderCountForPaymentMethod("KHQR");
                lblProBankTransaction.Text = orderCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data for guna2ContainerControl1: " + ex.Message);
            }
        }

        private void LoadGuna2ContainerControl2Data()
        {
            try
            {
                decimal totalAmount = FinanceManager.GetTotalAmountForPaymentMethod("Cash");
                lblProCashAmt.Text = totalAmount.ToString();
                int orderCount = FinanceManager.GetOrderCountForPaymentMethod("Cash");
                lblProCashTransaction.Text = orderCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data for guna2ContainerControl2: " + ex.Message);
            }
        }

        private void LoadGuna2ContainerControl3Data()
        {
            try
            {
                decimal totalAmount = FinanceManager.GetTotalStockInAmount();
                lblExpCashAmt.Text = totalAmount.ToString();
                int stockInCount = FinanceManager.GetStockInCount();
                lblExpCashTransaction.Text = stockInCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data for guna2ContainerControl3: " + ex.Message);
            }
        }

        private void LoadGuna2ContainerControl4Data()
        {
            try
            {
                lblExpBankAmt.Text = "0"; // Since stockin is all pay by cash, set the amount to 0
                lblExpBankTransaction.Text = "0"; // Since there's no bank transaction, set the count to 0
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data for guna2ContainerControl4: " + ex.Message);
            }
        }

        private void btnProbank_Click(object sender, EventArgs e)
        {
            LoadTableForPaymentMethod("KHQR");
        }

        private void btnProCash_Click(object sender, EventArgs e)
        {
            LoadTableForPaymentMethod("Cash");
        }

        private void btnExpCash_Click(object sender, EventArgs e)
        {
            LoadStockInTable();
        }

        private void LoadTableForPaymentMethod(string paymentMethod)
        {
            string query = "SELECT OrderDate, TotalRiel, TotalDollar, CustomerID FROM tbOrder WHERE PaymentMethodID = (SELECT PaymentMethodID FROM tbPaymentMethod WHERE PaymentMethod = @PaymentMethodName)";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@PaymentMethodName", paymentMethod);
                    DataTable dataTable1 = new DataTable();
                    adapter.Fill(dataTable1);

                    ShowTableForm(dataTable1);
                }
            }
        }

        private void LoadStockInTable()
        {
            string query = "SELECT StockName, StockIn, Amount, Date FROM tbStockIn";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    ShowTableForm(dataTable);

                }
            }
        }

        private void ShowTableForm(DataTable table)
        {
            using (TableForm tableForm = new TableForm(table))
            {
                tableForm.ShowDialog();
            }
        }
    }
}
