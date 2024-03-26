using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project.Class
{
    public class CRUDStockManager
    {
        

        public class StockDetails
        {
            public string StockName { get; set; }
            public byte[] Photo { get; set; }
            public int StockCount { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal Amount { get; set; }
            public string FoodCategory { get; set; }
            public int Quantity { get; set; }
            public DateTime ExpirationDate { get; set; }
            public int FoodCategoryID { get; set; }

            public StockDetails(string stockName, int quantity, decimal unitPrice, string foodCategory, DateTime expirationDate, byte[] photo, decimal amount, int foodCategoryID)
            {
                StockName = stockName;
                Quantity = quantity;
                UnitPrice = unitPrice;
                FoodCategory = foodCategory;
                ExpirationDate = expirationDate;
                Photo = photo; 
                Amount = amount;
                FoodCategoryID = foodCategoryID;
            }
        }

        public static DataTable GetStockInDataForItem(string itemName)
        {
            DataTable stockInData = new DataTable();

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string query = "SELECT UnitPrice, Amount, FoodCategory, Date " +
                               "FROM tbStockIn " +
                               "WHERE StockName = @ItemName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", itemName);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(stockInData);
                    }
                }
            }
            stockInData.Columns.Add("SafetyAlert", typeof(int)).DefaultValue = 1;
            return stockInData;
        }

        public static DataTable GetStockOutDataForItem(string itemName)
        {
            DataTable stockOutData = new DataTable();

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string query = "SELECT UnitPrice, Amount, FoodCategory, Date " +
                               "FROM tbStockOut " +
                               "WHERE StockName = @ItemName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", itemName);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(stockOutData);
                    }
                }
            }
            stockOutData.Columns.Add("SafetyAlert", typeof(int)).DefaultValue = 1;
            return stockOutData;
        }

        public static int GetStockCountForItem(string itemName)
        {
            int stockCount = 0;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string query = "SELECT StockCount FROM tbStockCount WHERE StockName = @ItemName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", itemName);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        stockCount = Convert.ToInt32(result);
                    }
                }
            }

            return stockCount;
        }

        public static void SaveStock(StockDetails stockDetails, bool isStockIn, int initialStockCount)
        {
           

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string tableName = isStockIn ? "tbStockIn" : "tbStockOut";
                string stockColumn = isStockIn ? "StockIn" : "StockOut";

                string insertQuery = $"INSERT INTO {tableName} (StockName, {stockColumn} ,UnitPrice, FoodCategory, Date, Photo, Amount, FoodCategoryID) " +
                    "VALUES (@StockName, @QTY, @UnitPrice, @FoodCategory, @ExpirationDate, @Photo, @Amount, @FoodCategoryID)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@StockName", stockDetails.StockName);
                    command.Parameters.AddWithValue("@UnitPrice", stockDetails.UnitPrice);
                    command.Parameters.AddWithValue("@FoodCategory", stockDetails.FoodCategory);
                    command.Parameters.AddWithValue("@ExpirationDate", stockDetails.ExpirationDate);
                    command.Parameters.AddWithValue("@Photo", stockDetails.Photo);
                    command.Parameters.AddWithValue("@Amount", stockDetails.Amount);
                    command.Parameters.AddWithValue("@QTY", stockDetails.Quantity);
                    command.Parameters.AddWithValue("@FoodCategoryID", stockDetails.FoodCategoryID);

                    command.ExecuteNonQuery();
                }
               


                // Update tbStockCount
                UpdateStockCount(stockDetails.StockName, initialStockCount, stockDetails.Quantity, isStockIn);
            }
        }

        public static void UpdateStockCount(string itemName, int initialStockCount, int quantity, bool isStockIn)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string tableName = "tbStockCount";
               
                int newStockCount = isStockIn ? initialStockCount + quantity : initialStockCount - quantity;

                string updateQuery = $"UPDATE {tableName} SET StockCount = @NewStockCount WHERE StockName = @StockName";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@NewStockCount", newStockCount);
                    command.Parameters.AddWithValue("@StockName", itemName);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static int GetStockCount(string itemName)
        {
            int stockCount = 0;

            // Query the database to retrieve the stock count for the specified item
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string query = "SELECT StockCount FROM tbStockCount WHERE StockName = @StockName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockName", itemName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        stockCount = Convert.ToInt32(result);
                    }
                }
            }

            return stockCount;
        }

    }
}
