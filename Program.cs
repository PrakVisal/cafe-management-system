using System;
using System.Linq;
using System.Threading;
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

            // Create instances of the forms
            frmLogin loginForm = new frmLogin();
            frmInvoice invoiceForm = new frmInvoice();

            // Determine which screen is primary
            var primaryScreen = Screen.AllScreens.FirstOrDefault(s => s.Primary);
            var secondaryScreen = Screen.AllScreens.FirstOrDefault(s => !s.Primary);

            if (primaryScreen != null)
            {
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.Location = primaryScreen.WorkingArea.Location;
            }

            if (secondaryScreen != null)
            {
                invoiceForm.StartPosition = FormStartPosition.Manual;
                invoiceForm.Location = secondaryScreen.WorkingArea.Location;
            }

            // Run the loginForm on a separate thread
            Thread loginThread = new Thread(() =>
            {
                Application.Run(loginForm);
            });
            loginThread.Start();

            // Run the invoiceForm on the main thread
            Application.Run(invoiceForm);
        }
    }
}