
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RMS_Project.Class;
using RMS_Project.Business_Layer;

namespace RMS_Project
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            LoadData();
            LoadCharts();
            // Refresh dashboard when it becomes visible
            this.Activated += FrmDashboard_Activated;
        }

        private void FrmDashboard_Activated(object sender, EventArgs e)
        {
            // Refresh data when dashboard form is activated (becomes visible)
            RefreshData();
        }

        /// <summary>
        /// Public method to refresh dashboard data - can be called from other forms
        /// </summary>
        public void RefreshData()
        {
            LoadData();
            LoadCharts();
        }

        private void LoadData()
        {
            // Retrieve and display Total Order (All Time)
            DisplayTotalOrderAllTime();

            // Retrieve and display Total Order (This Month)
            DisplayTotalOrderThisMonth();

            // Retrieve and display Total Sale
            DisplayTotalSale();

            // Total Expense feature removed - no longer needed
        }

        private void LoadCharts()
        {
            // Load chart for total order in months
            LoadTotalOrderChart();

            // Load chart for total sale in months
            LoadTotalSaleChart();

            // Pie chart removed - expense feature no longer exists
        }

        private void LoadTotalOrderChart()
        {
            try
            {
                DataTable dataTable = DashboardManager.ExecuteQuery("SELECT MONTH(OrderDate) AS Month, COUNT(*) AS TotalOrders FROM tbOrder GROUP BY MONTH(OrderDate)");

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    chart1.Series.Clear(); // Clear existing series
                    chart1.Series.Add("TotalOrders"); // Add new series
                    chart1.Series["TotalOrders"].XValueMember = "Month";
                    chart1.Series["TotalOrders"].YValueMembers = "TotalOrders";
                    chart1.DataSource = dataTable;
                    chart1.DataBind();

                    // Add label for chart1
                    chart1.ChartAreas[0].AxisX.Title = "Month";
                    chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Poppins", 10);
                    chart1.ChartAreas[0].AxisY.Title = "Total Orders";
                    chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Poppins", 10);
                }
                else
                {
                    MessageBox.Show("No data found for Total Order chart.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Total Order chart: " + ex.Message);
            }
        }

        private void LoadTotalSaleChart()
        {
            try
            {
                DataTable dataTable = DashboardManager.ExecuteQuery("SELECT MONTH(OrderDate) AS Month, SUM(TotalDollar) + SUM(TotalRiel)/4100  AS TotalSales FROM tbOrder GROUP BY MONTH(OrderDate)");

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    chart2.Series.Clear(); // Clear existing series
                    chart2.Series.Add("TotalSales"); // Add new series
                    chart2.Series["TotalSales"].XValueMember = "Month";
                    chart2.Series["TotalSales"].YValueMembers = "TotalSales";
                    chart2.DataSource = dataTable;
                    chart2.DataBind();

                    // Add label for chart2
                    chart2.ChartAreas[0].AxisX.Title = "Month";
                    chart2.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Poppins", 10);
                    chart2.ChartAreas[0].AxisY.Title = "Total Sales($)";
                    chart2.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Poppins", 10);
                }
                else
                {
                    MessageBox.Show("No data found for Total Sale chart.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Total Sale chart: " + ex.Message);
            }
        }

        // Pie chart removed - expense feature no longer exists

        private void DisplayTotalOrderAllTime()
        {
            try
            {
                int totalOrders = DashboardManager.GetTotalOrders();
                uC_Total1.lblTitle.Text = "Total Order";
                uC_Total1.lblValue.Text = totalOrders.ToString();
                // Set the time period label
                uC_Total1.TimePeriodLabel.Text = "All Time";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Display Total Order All Time: " + ex.Message);
            }
        }

        private void DisplayTotalOrderThisMonth()
        {
            try
            {
                int totalOrdersThisMonth = DashboardManager.GetTotalOrdersThisMonth();
                uC_Total3.lblTitle.Text = "Total Order";
                uC_Total3.lblValue.Text = totalOrdersThisMonth.ToString();
                // Set the time period label
                uC_Total3.TimePeriodLabel.Text = "This Month";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Display Total Order This Month: " + ex.Message);
            }
        }

        private void DisplayTotalSale()
        {
            try
            {
                decimal totalSale = DashboardManager.GetTotalSale();
                uC_Total2.lblTitle.Text = "Total Sale";
                uC_Total2.lblValue.Text = totalSale.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Display Total Sale: " + ex.Message);
            }
        }

        // DisplayTotalExpense method removed - expense feature no longer exists

    }
}