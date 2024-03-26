
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
        }

        private void LoadData()
        {
            // Retrieve and display Total Order
            DisplayTotalOrder();

            // Retrieve and display Total Sale
            DisplayTotalSale();

            // Retrieve and display Total Expense
            DisplayTotalExpense();
        }

        private void LoadCharts()
        {
            // Load chart for total order in months
            LoadTotalOrderChart();

            // Load chart for total sale in months
            LoadTotalSaleChart();

            // Load pie chart to compare total sale and expense in percentage
            LoadPieChart();
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

        private void LoadPieChart()
        {
            try
            {
                // Retrieve total sale value from UC_Total2
                decimal totalSale = decimal.Parse(uC_Total2.lblValue.Text, System.Globalization.NumberStyles.Currency);

                // Retrieve total expense value from UC_Total3
                decimal totalExpense = decimal.Parse(uC_Total3.lblValue.Text, System.Globalization.NumberStyles.Currency);

                decimal total = totalSale + totalExpense;

                chart3.Series.Clear(); // Clear existing series
                chart3.Series.Add("Comparison"); // Add new series

                // Add data points for total sale and total expense
                DataPoint salePoint = new DataPoint();
                salePoint.SetValueXY("Total Sale", totalSale);
                salePoint.Label = "Total Sale: " + ((totalSale / total) * 100).ToString("0.##") + "%";
                chart3.Series["Comparison"].Points.Add(salePoint);

                DataPoint expensePoint = new DataPoint();
                expensePoint.SetValueXY("Total Expense", totalExpense);
                expensePoint.Label = "Total Expense: " + ((totalExpense / total) * 100).ToString("0.##") + "%";
                chart3.Series["Comparison"].Points.Add(expensePoint);

                chart3.Series["Comparison"].ChartType = SeriesChartType.Pie;
                chart3.Series["Comparison"].Label = "#PERCENT{P0}";
                chart3.Titles.Add("Total Sale vs Total Expense");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Pie Chart: " + ex.Message);
            }
        }

        private void DisplayTotalOrder()
        {
            try
            {
                int totalOrders = DashboardManager.GetTotalOrders();
                uC_Total1.lblTitle.Text = "Total Order";
                uC_Total1.lblValue.Text = totalOrders.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Display Total Order: " + ex.Message);
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

        private void DisplayTotalExpense()
        {
            try
            {
                decimal totalExpense = DashboardManager.GetTotalExpense();
                uC_Total3.lblTitle.Text = "Total Expense";
                uC_Total3.lblValue.Text = totalExpense.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Display Total Expense: " + ex.Message);
            }
        }

    }
}