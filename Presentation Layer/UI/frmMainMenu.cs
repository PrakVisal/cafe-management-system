using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class frmMainMenu : Form
    {
        private static frmMainMenu instance;   //add new
        private Guna2Button currentButton;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        public static frmMainMenu Instance //add new
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmMainMenu();
                }
                return instance;
            }
        }

        private void ActiveButton(object btnsender)
        {
            if (btnsender != null)
            {
                // Call DisableButton before updating currentButton
                DisableButton();
                currentButton = (Guna2Button)btnsender;
                currentButton.Checked = true;
                currentButton.ForeColor = Color.WhiteSmoke;
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

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                frmDashboard dashboard = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                pnlSubForm.Controls.Add(dashboard);
                //dashboard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private frmDashboard dashboard;
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            try
            {
                if (dashboard == null || dashboard.IsDisposed)
                {
                    // Dispose of the previous form
                    var oldForm = this.pnlSubForm.Controls[0] as Form;
                    if (oldForm != null)
                    {
                        oldForm.Dispose();
                    }

                    // Check if the control still exists before trying to remove it
                    if (this.pnlSubForm.Controls.Count > 0)
                    {
                        this.pnlSubForm.Controls.RemoveAt(0);
                    }

                    dashboard = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    pnlSubForm.BringToFront();
                    this.pnlSubForm.Controls.Add(dashboard);
                    this.pnlSubForm.Tag = dashboard;
                    dashboard.Show();
                }
                else
                {
                    // If the form is not disposed, bring it to the front
                    dashboard.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private frmOrders orders;
        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            try
            {
                if (orders == null || orders.IsDisposed)
                {
                    // Dispose of the previous form
                    var oldForm1 = this.pnlSubForm.Controls[0] as Form;
                    if (oldForm1 != null)
                    {
                        oldForm1.Dispose();
                    }

                    // Check if the control still exists before trying to remove it
                    if (this.pnlSubForm.Controls.Count > 0)
                    {
                        this.pnlSubForm.Controls.RemoveAt(0);
                    }

                    orders = new frmOrders() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    pnlSubForm.BringToFront();
                    this.pnlSubForm.Controls.Add(orders);
                    this.pnlSubForm.Tag = orders;
                    orders.Show();
                    if (orders == null || orders.IsDisposed)
                    {
                        // Dispose of the previous form
                        var oldForm2 = this.pnlSubForm.Controls[0] as Form;
                        if (oldForm2 != null)
                        {
                            oldForm2.Dispose();
                        }

                        // Check if the control still exists before trying to remove it
                        if (this.pnlSubForm.Controls.Count > 0)
                        {
                            this.pnlSubForm.Controls.RemoveAt(0);
                        }

                        orders = new frmOrders() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        pnlSubForm.BringToFront();
                        this.pnlSubForm.Controls.Add(orders);
                        this.pnlSubForm.Tag = orders;
                        orders.Show();
                    }
                }
                else
                {
                    // If the form is not disposed, bring it to the front
                    orders.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private frmFinance finance;
        private void btnFinances_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            try
            {
                if (finance == null || finance.IsDisposed)
                {
                    // Dispose of the previous form
                    var oldForm = this.pnlSubForm.Controls[0] as Form;
                    if (oldForm != null)
                    {
                        oldForm.Dispose();
                    }

                    // Check if the control still exists before trying to remove it
                    if (this.pnlSubForm.Controls.Count > 0)
                    {
                        this.pnlSubForm.Controls.RemoveAt(0);
                    }

                    finance = new frmFinance() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    pnlSubForm.BringToFront();
                    this.pnlSubForm.Controls.Add(finance);
                    this.pnlSubForm.Tag = finance;
                    finance.Show();
                }
                else
                {
                    // If the form is not disposed, bring it to the front
                    finance.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private frmItems items;
        private void btnItems_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            try
            {
                if (items == null || items.IsDisposed)
                {
                    // Dispose of the previous form
                    var oldForm = this.pnlSubForm.Controls[0] as Form;
                    if (oldForm != null)
                    {
                        oldForm.Dispose();
                    }

                    // Check if the control still exists before trying to remove it
                    if (this.pnlSubForm.Controls.Count > 0)
                    {
                        this.pnlSubForm.Controls.RemoveAt(0);
                    }

                    items = new frmItems() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    pnlSubForm.BringToFront();
                    this.pnlSubForm.Controls.Add(items);
                    this.pnlSubForm.Tag = items;
                    items.Show();
                }
                else
                {
                    // If the form is not disposed, bring it to the front
                    items.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private frmReport report;
        private void btnReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            try
            {
                if (report == null || report.IsDisposed)
                {
                    // Dispose of the previous form
                    var oldForm = this.pnlSubForm.Controls[0] as Form;
                    if (oldForm != null)
                    {
                        oldForm.Dispose();
                    }

                    // Check if the control still exists before trying to remove it
                    if (this.pnlSubForm.Controls.Count > 0)
                    {
                        this.pnlSubForm.Controls.RemoveAt(0);
                    }

                    report = new frmReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    pnlSubForm.BringToFront();
                    this.pnlSubForm.Controls.Add(report);
                    this.pnlSubForm.Tag = report;
                    report.Show();
                }
                else
                {
                    // If the form is not disposed, bring it to the front
                    report.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private frmStocks stocks;
        private void btnStocks_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            try
            {
                if (stocks == null || stocks.IsDisposed)
                {
                    // Dispose of the previous form
                    var oldForm = this.pnlSubForm.Controls[0] as Form;
                    if (oldForm != null)
                    {
                        oldForm.Dispose();
                    }

                    // Check if the control still exists before trying to remove it
                    if (this.pnlSubForm.Controls.Count > 0)
                    {
                        this.pnlSubForm.Controls.RemoveAt(0);
                    }

                    stocks = new frmStocks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    pnlSubForm.BringToFront();
                    this.pnlSubForm.Controls.Add(stocks);
                    this.pnlSubForm.Tag = stocks;
                    stocks.Show();
                }
                else
                {
                    // If the form is not disposed, bring it to the front
                    stocks.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private frmUsers users;
        private void btnUsers_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            try
            {
                if (users == null || users.IsDisposed)
                {
                    // Dispose of the previous form
                    var oldForm = this.pnlSubForm.Controls[0] as Form;
                    if (oldForm != null)
                    {
                        oldForm.Dispose();
                    }

                    // Check if the control still exists before trying to remove it
                    if (this.pnlSubForm.Controls.Count > 0)
                    {
                        this.pnlSubForm.Controls.RemoveAt(0);
                    }

                    users = new frmUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    pnlSubForm.BringToFront();
                    this.pnlSubForm.Controls.Add(users);
                    this.pnlSubForm.Tag = users;
                    users.Show();
                }
                else
                {
                    // If the form is not disposed, bring it to the front
                    users.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            this.Close();
        }
    }
}
