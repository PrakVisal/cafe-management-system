using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS_Project;
using RMS_Project.Class;

namespace RMS_Project.Business_Layer
{
    public class DashboardManager
    {
        public static int GetTotalOrders()
        {
            string query = "SELECT ISNULL(COUNT(*), 0) FROM tbOrder";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving total orders: " + ex.Message);
                }
            }
        }

        public static decimal GetTotalSale()
        {
            string query = "SELECT ISNULL(SUM(TotalDollar), 0) + ISNULL(SUM(TotalRiel) / 4100, 0) FROM tbOrder";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        return Convert.ToDecimal(command.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving total sale: " + ex.Message);
                }
            }
        }

        public static decimal GetTotalExpense()
        {
            // Expense feature removed - stock feature no longer exists
            return 0;
        }

        public static DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}
