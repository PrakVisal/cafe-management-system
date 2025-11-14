using System;
using System.Linq;
using System.Windows.Forms;
using RMS_Project.Business_Layer;

namespace RMS_Project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set default username (no login required)
            SharedData.CurrentUsername = "User";

            // Determine which screen is primary
            var primaryScreen = Screen.AllScreens.FirstOrDefault(s => s.Primary);
            var secondaryScreen = Screen.AllScreens.FirstOrDefault(s => !s.Primary);

            // Create and configure main menu form (replaces login)
            frmMainMenu mainMenu = new frmMainMenu();
            if (primaryScreen != null)
            {
                mainMenu.StartPosition = FormStartPosition.CenterScreen;
            }

            // Create and configure invoice form (hidden initially, shown when needed)
            frmInvoice invoiceForm = new frmInvoice();
            if (secondaryScreen != null)
            {
                invoiceForm.StartPosition = FormStartPosition.Manual;
                invoiceForm.Location = secondaryScreen.WorkingArea.Location;
            }
            else
            {
                // If no secondary screen, position it offset from primary
                invoiceForm.StartPosition = FormStartPosition.Manual;
                if (primaryScreen != null)
                {
                    invoiceForm.Location = new System.Drawing.Point(
                        primaryScreen.WorkingArea.Right - invoiceForm.Width - 20,
                        primaryScreen.WorkingArea.Top + 20);
                }
            }

            // Show main menu (Dashboard) first and bring to front
            mainMenu.Show();
            mainMenu.BringToFront();
            mainMenu.Activate();

            // Initialize invoice form but keep it hidden (will be shown when orders are placed)
            invoiceForm.Show();
            invoiceForm.Hide();

            // Run the application message loop on the main thread
            Application.Run();
        }
    }
}