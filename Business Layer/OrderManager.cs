using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RMS_Project.Business_Layer;
using RMS_Project.Class;
using System.Windows.Forms;

namespace RMS_Project.Business_Layer
{
    public class OrderManager
    {
        public static DataTable GetProducts()
        {
            DataTable productsTable = new DataTable();

            string query = "SELECT ProductName, Price, Description, Image, FoodCategoryName " +
                           "FROM tbProduct " +
                           "INNER JOIN tbFoodCategory ON tbProduct.FoodCategoryID = tbFoodCategory.FoodCategoryID where FoodCategoryName <> 'Others'";

            using (SqlConnection connection = new SqlConnection(DBConnection.path))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(productsTable);
            }

            return productsTable;
        }

        public static int GetOrder(DateTime orderDate, decimal totalRiel, decimal totalDollar, decimal chargeRiel, decimal chargeDollar)
        {
            string insertQuery = @"INSERT INTO tbOrder (OrderDate, TotalRiel, TotalDollar, ChargeRiel, ChargeDollar, Tax) 
                           VALUES (@OrderDate, @TotalRiel, @TotalDollar, @ChargeRiel, @ChargeDollar, 0.00);
                           SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(DBConnection.path))
            {
                // Create and configure SqlCommand
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@OrderDate", orderDate);
                command.Parameters.AddWithValue("@TotalRiel", totalRiel);
                command.Parameters.AddWithValue("@TotalDollar", totalDollar);
                command.Parameters.AddWithValue("@ChargeRiel", chargeRiel);
                command.Parameters.AddWithValue("@ChargeDollar", chargeDollar);
                try
                {
                    // Open the connection
                    connection.Open();
                    // Execute the INSERT command and get the OrderID
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        int orderId = Convert.ToInt32(result);
                        return orderId;
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert into the database.");
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while insert: " + ex.Message);
                    return -1;
                }
            }
        }

        public static void InsertOrderDetail(int orderId, int productId, int orderQty, decimal unitPrice, decimal amount, string size = null)
        {
            string insertQuery = @"INSERT INTO tbOrderDetail (OrderID, ProductID, Size, OrderQty, UnitPrice, Amount) 
                           VALUES (@OrderID, @ProductID, @Size, @OrderQty, @UnitPrice, @Amount)";

            using (SqlConnection connection = new SqlConnection(DBConnection.path))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@OrderID", orderId);
                command.Parameters.AddWithValue("@ProductID", productId);
                command.Parameters.AddWithValue("@Size", (object)size ?? DBNull.Value);
                command.Parameters.AddWithValue("@OrderQty", orderQty);
                command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                command.Parameters.AddWithValue("@Amount", amount);
                
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting order detail: " + ex.Message);
                }
            }
        }
    }
}
