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

        public static void GetOrder(DateTime orderDate, decimal totalRiel, decimal totalDollar, decimal chargeRiel, decimal chargeDollar, int payment)
        {
            string insertQuery = @"INSERT INTO tbOrder (OrderDate, TotalRiel, TotalDollar, ChargeRiel, ChargeDollar, PaymentMethodID, Tax) 
                           VALUES (@OrderDate, @TotalRiel, @TotalDollar,@ChargeRiel, @ChargeDollar, @PaymentMethod , 0.00 )";

            using (SqlConnection connection = new SqlConnection(DBConnection.path))
            {
                // Create and configure SqlCommand
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@OrderDate", orderDate);
                command.Parameters.AddWithValue("@TotalRiel", totalRiel);
                command.Parameters.AddWithValue("@TotalDollar", totalDollar);
                command.Parameters.AddWithValue("@ChargeRiel", chargeRiel);
                command.Parameters.AddWithValue("@ChargeDollar",chargeDollar);
                command.Parameters.AddWithValue("@PaymentMethod", payment);
                try
                {
                    // Open the connection
                    connection.Open();
                    // Execute the INSERT command
                    int rowsAffected = command.ExecuteNonQuery();
                    // Check if the data was inserted successfully
                    if (rowsAffected > 0)
                    {
                        //MessageBox.Show("inserted into the database successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert into the database.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while insert: " + ex.Message);
                }
            }
        }
    }
}
