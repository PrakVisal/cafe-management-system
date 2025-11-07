using RMS_Project.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project.Business_Layer
{
    public class ItemManager
    {
        public static void AddItem(Item item)
        {
            string query = "INSERT INTO tbProduct " +
                "(ProductName, Price, Description, FoodCategoryID, Image) " +
                "VALUES (@ProductName, @Price, @Description, " +
                "(SELECT FoodCategoryID FROM tbFoodCategory WHERE FoodCategoryName = @FoodCategoryName), " +
                "@Image)";

            /*  string insertStock = "INSERT INTO tbStockCount " +
                  "(StockName, StockCount, UnitPrice, Amount, Photo, FoodCategoryID, FoodCategory) " +
                  "VALUES (@ProductName, 0, @Price, 0, @Image, " +
                  "(SELECT FoodCategoryID FROM tbFoodCategory WHERE FoodCategoryName = @FoodCategory), " +
                  "@FoodCategory)"; */

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", item.ItemName);
                    command.Parameters.AddWithValue("@Price", item.ItemPrice);
                    command.Parameters.AddWithValue("@Description", item.ItemDescription);
                    command.Parameters.AddWithValue("@FoodCategoryName", item.ItemCategory);
                    command.Parameters.AddWithValue("@Image", item.itemImage);

                    command.ExecuteNonQuery();
                }

                /*
                using (SqlCommand command = new SqlCommand(insertStock, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", item.ItemName);
                    command.Parameters.AddWithValue("@Price", item.ItemPrice);
                    command.Parameters.AddWithValue("@Image", item.itemImage);
                    command.Parameters.AddWithValue("@FoodCategory", item.ItemCategory);

                    command.ExecuteNonQuery();
                } */
            }
        }

        public static List<Item> ReadItem()
        {
            List<Item> items = new List<Item>();
            string query = "SELECT p.ProductID, p.ProductName, p.Price, p.Description, p.Image, c.FoodCategoryName " +
                       "FROM tbProduct p " +
                       "INNER JOIN tbFoodCategory c ON p.FoodCategoryID = c.FoodCategoryID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Item item = new Item
                        {
                            ItemID = Convert.ToInt32(reader["ProductID"]),
                            ItemName = reader["ProductName"].ToString(),
                            ItemPrice = Convert.ToDecimal(reader["Price"]),
                            ItemDescription = reader["Description"].ToString(),
                            ItemCategory = reader["FoodCategoryName"].ToString(),
                            itemImage = (byte[])reader["Image"]
                        };
                        items.Add(item);
                    }
                }
            }
            return items;
        }
        public static List<Item> ReadItemToOrder()
        {
            List<Item> items = new List<Item>();
            string query = "SELECT p.ProductID, p.ProductName, p.Price, p.Description, p.Image, c.FoodCategoryName " +
                       "FROM tbProduct p " +
                       "INNER JOIN tbFoodCategory c ON p.FoodCategoryID = c.FoodCategoryID where p.FoodCategoryID != 7";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Item item = new Item
                        {
                            ItemID = Convert.ToInt32(reader["ProductID"]),
                            ItemName = reader["ProductName"].ToString(),
                            ItemPrice = Convert.ToDecimal(reader["Price"]),
                            ItemDescription = reader["Description"].ToString(),
                            ItemCategory = reader["FoodCategoryName"].ToString(),
                            itemImage = (byte[])reader["Image"]
                        };
                        items.Add(item);
                    }
                }
            }
            return items;
        }
        public static int ReadItemID()
        {
            int itemId = 0;
            string query = "SELECT IDENT_CURRENT('tbProduct') AS CurrentProductID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        itemId = Convert.ToInt32(result);
                    }
                }
            }

            return itemId;
        }

        public static void UpdateItem(Item item)
        {
            string productQuery = "UPDATE tbProduct SET " +
                "ProductName = @ProductName, Price = @Price, Description = @Description,  " +
                "FoodCategoryID = (SELECT FoodCategoryID FROM tbFoodCategory WHERE FoodCategoryName = @FoodCategoryName), " +
                "Image = @Image WHERE ProductID = @ProductID";


            string stockCountQuery = "UPDATE tbStockCount " +
                "SET StockName = @ProductName, UnitPrice = @Price, Photo = @Image," +
                " FoodCategoryID = (SELECT FoodCategoryID FROM tbFoodCategory WHERE FoodCategoryName = @FoodCategoryName)," +
                " FoodCategory = @FoodCategoryName " +
                "WHERE FoodCategoryID = 7";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand productCommand = new SqlCommand(productQuery, connection))
                {
                    productCommand.Parameters.AddWithValue("@ProductID", item.ItemID);
                    productCommand.Parameters.AddWithValue("@ProductName", item.ItemName);
                    productCommand.Parameters.AddWithValue("@Price", item.ItemPrice);
                    productCommand.Parameters.AddWithValue("@Description", item.ItemDescription);
                    productCommand.Parameters.AddWithValue("@FoodCategoryName", item.ItemCategory);
                    productCommand.Parameters.AddWithValue("@Image", item.itemImage);

                    productCommand.ExecuteNonQuery();
                }


                using (SqlCommand stockCountCommand = new SqlCommand(stockCountQuery, connection))
                {

                    stockCountCommand.Parameters.AddWithValue("@ProductName", item.ItemName);
                    stockCountCommand.Parameters.AddWithValue("@Price", item.ItemPrice);
                    stockCountCommand.Parameters.AddWithValue("@FoodCategoryName", item.ItemCategory);
                    stockCountCommand.Parameters.AddWithValue("@Image", item.itemImage);

                    stockCountCommand.ExecuteNonQuery();
                }



            }
        }
        public static void DeleteItem(int itemID)
        {
            string query = "DELETE FROM tbProduct WHERE ProductID = @ProductID";
            string deleteStockQuery = "DELETE FROM tbStockCount WHERE StockName = " +
                "(SELECT ProductName FROM tbProduct WHERE ProductID = @ProductID)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand deleteStockCommand = new SqlCommand(deleteStockQuery, connection))
                {
                    MessageBox.Show("Reach Command delete tbStockCount");
                    deleteStockCommand.Parameters.AddWithValue("@ProductID", itemID);
                    deleteStockCommand.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    MessageBox.Show("Reach Command delete tbProduct");
                    command.Parameters.AddWithValue("@ProductID", itemID);
                    command.ExecuteNonQuery();
                }


            }
        }


    }
}