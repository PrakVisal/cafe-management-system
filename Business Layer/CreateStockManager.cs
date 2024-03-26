using System;
using System.Data.SqlClient;

namespace RMS_Project
{
    public static class CreateStockManager
    {
        private const string connectionString = "Data Source=LAPTOP-ALHRF6DV\\SQLEXPRESS;Initial Catalog=ManagementSystem;Trusted_Connection=True;";

        public static bool CreateStockEntry(string productName, decimal unitPrice, byte[] photo, string foodCategory)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the FoodCategoryID based on the given FoodCategory
                    string categoryIdQuery = "SELECT TOP 1 FoodCategoryID FROM tbFoodCategory WHERE FoodCategoryName = @FoodCategory";
                    SqlCommand categoryIdCommand = new SqlCommand(categoryIdQuery, connection);
                    categoryIdCommand.Parameters.AddWithValue("@FoodCategory", foodCategory);
                    int foodCategoryId = 0;

                    using (SqlDataReader reader = categoryIdCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foodCategoryId = Convert.ToInt32(reader["FoodCategoryID"]);
                        }
                    }

                    // Insert the stock entry using the retrieved FoodCategoryID
                    string insertQuery = "INSERT INTO tbStockCount (StockName, StockCount, UnitPrice, Amount, Photo, FoodCategoryID, FoodCategory) " +
                                         "VALUES (@StockName, @StockCount, @UnitPrice, @Amount, @Photo, @FoodCategoryID, @FoodCategory)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@StockName", productName);
                    command.Parameters.AddWithValue("@StockCount", 0);
                    command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    command.Parameters.AddWithValue("@Amount", 0); // Assuming the initial amount is 0
                    command.Parameters.AddWithValue("@Photo", photo);
                    command.Parameters.AddWithValue("@FoodCategoryID", foodCategoryId);
                    command.Parameters.AddWithValue("@FoodCategory", foodCategory);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating a stock entry: " + ex.Message);
                return false;
            }
        }

    }
}
