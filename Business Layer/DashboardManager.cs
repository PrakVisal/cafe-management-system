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

        public static int GetTotalOrdersThisMonth()
        {
            string query = @"SELECT ISNULL(COUNT(*), 0) FROM tbOrder 
                            WHERE MONTH(OrderDate) = MONTH(GETDATE()) 
                            AND YEAR(OrderDate) = YEAR(GETDATE())";
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
                    throw new Exception("Error retrieving total orders this month: " + ex.Message);
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

        public static decimal GetTotalSaleThisMonth()
        {
            string query = @"SELECT ISNULL(SUM(TotalDollar), 0) + ISNULL(SUM(TotalRiel) / 4100.0, 0) FROM tbOrder 
                            WHERE MONTH(OrderDate) = MONTH(GETDATE()) 
                            AND YEAR(OrderDate) = YEAR(GETDATE())";
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
                    throw new Exception("Error retrieving total sale this month: " + ex.Message);
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

        /// <summary>
        /// Gets total orders by month across all years, including all 12 months
        /// </summary>
        public static DataTable GetTotalOrdersByMonth()
        {
            string query = @"
                WITH Months AS (
                    SELECT 1 AS MonthNumber UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 
                    UNION ALL SELECT 5 UNION ALL SELECT 6 UNION ALL SELECT 7 UNION ALL SELECT 8 
                    UNION ALL SELECT 9 UNION ALL SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12
                )
                SELECT 
                    m.MonthNumber AS Month,
                    ISNULL(COUNT(o.OrderID), 0) AS TotalOrders
                FROM Months m
                LEFT JOIN tbOrder o ON MONTH(o.OrderDate) = m.MonthNumber
                GROUP BY m.MonthNumber
                ORDER BY m.MonthNumber";

            return ExecuteQuery(query);
        }

        /// <summary>
        /// Gets total sales by month across all years, including all 12 months
        /// </summary>
        public static DataTable GetTotalSalesByMonth()
        {
            string query = @"
                WITH Months AS (
                    SELECT 1 AS MonthNumber UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 
                    UNION ALL SELECT 5 UNION ALL SELECT 6 UNION ALL SELECT 7 UNION ALL SELECT 8 
                    UNION ALL SELECT 9 UNION ALL SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12
                )
                SELECT 
                    m.MonthNumber AS Month,
                    ISNULL(SUM(o.TotalDollar), 0) + ISNULL(SUM(o.TotalRiel) / 4100.0, 0) AS TotalSales
                FROM Months m
                LEFT JOIN tbOrder o ON MONTH(o.OrderDate) = m.MonthNumber
                GROUP BY m.MonthNumber
                ORDER BY m.MonthNumber";

            return ExecuteQuery(query);
        }
    }
}
