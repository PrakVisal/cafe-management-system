using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project.Business_Layer
{
    public class DeleteStocManager
    {
        private const string connectionString = "Data Source=LAPTOP-ALHRF6DV\\SQLEXPRESS;Initial Catalog=ManagementSystem;Trusted_Connection=True;";

        public static bool  DeleteStockEntry(string StockCountName, decimal price)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM tbStockCount WHERE StockName = @StockCountName AND UnitPrice = @StockCountPrice";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@StockCountName", StockCountName);
                    command.Parameters.AddWithValue("@StockCountPrice", price);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }
    }
}
