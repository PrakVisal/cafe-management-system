using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project.Class
{
    public class DBConnection
    {
        public static string path = ConfigurationManager.ConnectionStrings["ManagementSystemConnection"]?.ConnectionString
            ?? "Data Source=DESKTOP-UHPED7U;Initial Catalog=ManagementSystem;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(path);
            try
            {
                connection.Open();
                
                // Verify connection is actually open
                if (connection.State != ConnectionState.Open)
                {
                    throw new Exception("Connection opened but state is not Open");
                }
            }
            catch (SqlException sqlEx)
            {
                connection?.Dispose();
                string errorMessage = $"SQL Server Error: {sqlEx.Message}\n\n" +
                    $"Connection String: {path}\n\n" +
                    $"Error Number: {sqlEx.Number}\n" +
                    $"Please check:\n" +
                    $"1. SQL Server is running on DESKTOP-UHPED7U\n" +
                    $"2. Database 'ManagementSystem' exists\n" +
                    $"3. Windows Authentication is enabled\n" +
                    $"4. Your user has access to the database";

                MessageBox.Show(errorMessage, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Re-throw to prevent using closed connection
            }
            catch (Exception ex)
            {
                connection?.Dispose();
                string errorMessage = $"Failed to connect to Database.\n\n" +
                    $"Error: {ex.Message}\n\n" +
                    $"Connection String: {path}\n\n" +
                    $"Please check:\n" +
                    $"1. SQL Server is running\n" +
                    $"2. Database 'ManagementSystem' exists\n" +
                    $"3. Connection string in App.config is correct";

                MessageBox.Show(errorMessage, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Re-throw to prevent using closed connection
            }
            return connection;
        }
    }
}
