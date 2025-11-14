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
            // Hide Users and Logout buttons (login feature removed)
            btnUsers.Visible = false;
            btnLogout.Visible = false;
            // Hide Account label and separator (login feature removed)
            label1.Visible = false;
            guna2Separator1.Visible = false;
            // Hide Finances button (feature removed)
            btnFinances.Visible = false;
            // Hide Stocks button (feature removed)
            btnStocks.Visible = false;
            // Hide Reports button (feature removed)
            btnReports.Visible = false;
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
                // Activate Dashboard button on startup
                ActiveButton(btnDashboard);

                // Create and show dashboard
                dashboard = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                pnlSubForm.BringToFront();
                pnlSubForm.Controls.Add(dashboard);
                pnlSubForm.Tag = dashboard;
                dashboard.Show();
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
                    // If the form is not disposed, bring it to the front and refresh data
                    dashboard.BringToFront();
                    dashboard.RefreshData();
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

        // Finances feature removed
        private void btnFinances_Click(object sender, EventArgs e)
        {
            // Feature removed
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

        // Reports feature removed
        private void btnReport_Click(object sender, EventArgs e)
        {
            // Feature removed
        }

        // Stocks feature removed
        private void btnStocks_Click(object sender, EventArgs e)
        {
            // Feature removed
        }

        // Users and Logout features removed - buttons hidden
        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Feature removed
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Feature removed
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
