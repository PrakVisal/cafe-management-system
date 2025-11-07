using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace RMS_Project.Business_Layer
{
    public class FormHelper
    {
        public static void AccountButton_Click(object sender, EventArgs e)
        {
            // Show the login form
            frmLogin loginForm = new frmLogin();
            loginForm.FormClosed += (s, args) => Application.Exit(); // Close the application when login form is closed
            loginForm.Show();

            // Close the current form
            Form currentForm = (Form)((Guna2Button)sender).FindForm();
            currentForm.Close();


        }
    }
}
