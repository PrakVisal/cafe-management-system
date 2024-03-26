using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project.Class
{
    public class DBConnection
    {
        
            public const string path = "Data Source=LAPTOP-ALHRF6DV\\SQLEXPRESS;Initial Catalog=ManagementSystem;Integrated Security=True";
            public static SqlConnection GetConnection()
            {
                var connection = new SqlConnection(path);
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "Failed to connect the Database", "Database Connection"
                        );
                }
                return connection;
            }
        
    }
}
