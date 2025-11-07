using System;
using System.Linq;
using System.Windows.Forms;

namespace RMS_Project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Determine which screen is primary
            var primaryScreen = Screen.AllScreens.FirstOrDefault(s => s.Primary);
            var secondaryScreen = Screen.AllScreens.FirstOrDefault(s => !s.Primary);

            // Create and configure login form
            frmLogin loginForm = new frmLogin();
            if (primaryScreen != null)
            {
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.Location = primaryScreen.WorkingArea.Location;
            }

            // Create and configure invoice form
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

            // Show both forms on the main UI thread
            loginForm.Show();
            invoiceForm.Show();

            // Run the application message loop on the main thread
            Application.Run();
        }
    }
}