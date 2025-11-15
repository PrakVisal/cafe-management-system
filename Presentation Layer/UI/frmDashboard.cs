
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

            // Retrieve and display Total Sale (All Time)
            DisplayTotalSale();

            // Retrieve and display Total Order (This Month)
            DisplayTotalOrderThisMonth();

            // Retrieve and display Total Sale (This Month)
            DisplayTotalSaleThisMonth();
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
                DataTable dataTable = DashboardManager.GetTotalOrdersByMonth();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    chart1.Series.Clear(); // Clear existing series
                    chart1.Series.Add("TotalOrders"); // Add new series
                    chart1.Series["TotalOrders"].ChartType = SeriesChartType.Column;

                    // Clear existing data points
                    chart1.Series["TotalOrders"].Points.Clear();

                    // Manually add data points to ensure all months are shown
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int month = Convert.ToInt32(row["Month"]);
                        int totalOrders = Convert.ToInt32(row["TotalOrders"]);
                        chart1.Series["TotalOrders"].Points.AddXY(month, totalOrders);
                    }

                    // Configure chart appearance - Modern Gen Z Style
                    chart1.ChartAreas[0].BackColor = System.Drawing.Color.White;
                    chart1.ChartAreas[0].BorderColor = System.Drawing.Color.FromArgb(240, 240, 240);
                    chart1.ChartAreas[0].BorderWidth = 1;
                    chart1.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;

                    // Modern axis styling
                    chart1.ChartAreas[0].AxisX.Title = "Month";
                    chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                    chart1.ChartAreas[0].AxisX.TitleForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
                    chart1.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.FromArgb(220, 220, 220);
                    chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(245, 245, 245);
                    chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
                    chart1.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
                    chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);

                    chart1.ChartAreas[0].AxisY.Title = "Total Orders";
                    chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                    chart1.ChartAreas[0].AxisY.TitleForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
                    chart1.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.FromArgb(220, 220, 220);
                    chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(245, 245, 245);
                    chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
                    chart1.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
                    chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);

                    // Modern bar styling with gradient
                    chart1.Series["TotalOrders"].Color = System.Drawing.Color.FromArgb(75, 103, 89);
                    chart1.Series["TotalOrders"].BorderColor = System.Drawing.Color.FromArgb(75, 103, 89);
                    chart1.Series["TotalOrders"].BorderWidth = 0;
                    chart1.Series["TotalOrders"]["PointWidth"] = "0.6";
                    chart1.Series["TotalOrders"].IsValueShownAsLabel = false;

                    // Set X-axis to show all 12 months
                    chart1.ChartAreas[0].AxisX.Minimum = 1;
                    chart1.ChartAreas[0].AxisX.Maximum = 12;
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;

                    // Remove legend or style it
                    chart1.Legends.Clear();
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
                DataTable dataTable = DashboardManager.GetTotalSalesByMonth();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    chart2.Series.Clear(); // Clear existing series
                    chart2.Series.Add("TotalSales"); // Add new series
                    chart2.Series["TotalSales"].ChartType = SeriesChartType.Column;

                    // Clear existing data points
                    chart2.Series["TotalSales"].Points.Clear();

                    // Manually add data points to ensure all months are shown
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int month = Convert.ToInt32(row["Month"]);
                        decimal totalSales = Convert.ToDecimal(row["TotalSales"]);
                        chart2.Series["TotalSales"].Points.AddXY(month, totalSales);
                    }

                    // Configure chart appearance - Modern Gen Z Style
                    chart2.ChartAreas[0].BackColor = System.Drawing.Color.White;
                    chart2.ChartAreas[0].BorderColor = System.Drawing.Color.FromArgb(240, 240, 240);
                    chart2.ChartAreas[0].BorderWidth = 1;
                    chart2.ChartAreas[0].BorderDashStyle = ChartDashStyle.Solid;

                    // Modern axis styling
                    chart2.ChartAreas[0].AxisX.Title = "Month";
                    chart2.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                    chart2.ChartAreas[0].AxisX.TitleForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
                    chart2.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.FromArgb(220, 220, 220);
                    chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(245, 245, 245);
                    chart2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
                    chart2.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
                    chart2.ChartAreas[0].AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);

                    chart2.ChartAreas[0].AxisY.Title = "Total Sales($)";
                    chart2.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                    chart2.ChartAreas[0].AxisY.TitleForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
                    chart2.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.FromArgb(220, 220, 220);
                    chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(245, 245, 245);
                    chart2.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
                    chart2.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
                    chart2.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);

                    // Modern bar styling with gradient
                    chart2.Series["TotalSales"].Color = System.Drawing.Color.FromArgb(75, 103, 89);
                    chart2.Series["TotalSales"].BorderColor = System.Drawing.Color.FromArgb(75, 103, 89);
                    chart2.Series["TotalSales"].BorderWidth = 0;
                    chart2.Series["TotalSales"]["PointWidth"] = "0.6";
                    chart2.Series["TotalSales"].IsValueShownAsLabel = false;

                    // Set X-axis to show all 12 months
                    chart2.ChartAreas[0].AxisX.Minimum = 1;
                    chart2.ChartAreas[0].AxisX.Maximum = 12;
                    chart2.ChartAreas[0].AxisX.Interval = 1;
                    chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;

                    // Remove legend or style it
                    chart2.Legends.Clear();
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
                uC_Total2.TimePeriodLabel.Text = "All Time";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Display Total Sale: " + ex.Message);
            }
        }

        private void DisplayTotalSaleThisMonth()
        {
            try
            {
                decimal totalSaleThisMonth = DashboardManager.GetTotalSaleThisMonth();
                uC_Total4.lblTitle.Text = "Total Sale";
                uC_Total4.lblValue.Text = totalSaleThisMonth.ToString("C");
                uC_Total4.TimePeriodLabel.Text = "This Month";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Display Total Sale This Month: " + ex.Message);
            }
        }

        // DisplayTotalExpense method removed - expense feature no longer exists

    }
}