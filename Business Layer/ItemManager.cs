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
        private string connectionString;

        public ItemManager(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }
        public List<ItemData> GetItems()
        {
            List<ItemData> items = new List<ItemData>();

            string query = "SELECT p.ProductID, p.ProductName, p.Price, p.Description, p.Image, c.FoodCategoryName " +
                   "FROM tbProduct p " +
                   "INNER JOIN tbFoodCategory c ON p.FoodCategoryID = c.FoodCategoryID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int productId = Convert.ToInt32(reader["ProductID"]);
                    string productName = reader["ProductName"].ToString();
                    decimal price = Convert.ToDecimal(reader["Price"]);
                    string description = reader["Description"].ToString();
                    byte[] imageData = (byte[])reader["Image"];
                    Image image = Image.FromStream(new MemoryStream(imageData));
                    string category = reader["FoodCategoryName"].ToString();

                    items.Add(new ItemData(productId, productName, price, description, image, category));
                }
            }

            return items;
        }
        public class ItemData
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
            public Image Image { get; set; }
            public string Category { get; set; }

            public ItemData(int productId, string productName, decimal price, string description, Image image, string category)
            {
                ProductId = productId;
                ProductName = productName;
                Price = price;
                Description = description;
                Image = image;
                Category = category;
            }
        }

        public string GetProductCategory(int productId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT c.FoodCategoryName " +
                                   "FROM tbProduct p " +
                                   "INNER JOIN tbFoodCategory c ON p.FoodCategoryID = c.FoodCategoryID " +
                                   "WHERE p.ProductID = @ProductId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductId", productId);
                    return command.ExecuteScalar()?.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }
        public bool InsertProduct(string itemName, string category, decimal price, string description, byte[] image)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO tbProduct " +
                        "(ProductName, Price, Description, FoodCategoryID, Image) VALUES (@ProductName, @Price, @Description," +
                        "(SELECT FoodCategoryID FROM tbFoodCategory WHERE FoodCategoryName = @Category), @Image)";

                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@ProductName", itemName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Image", image);
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

        public bool UpdateProduct(string itemName, string category, decimal price, string description, byte[] image, int productId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE tbProduct SET " +
                        "ProductName = @ProductName, Price = @Price, Description = @Description, " +
                        "FoodCategoryID = (SELECT FoodCategoryID FROM tbFoodCategory WHERE FoodCategoryName = @Category), " +
                        "Image = @Image WHERE ProductID = @ProductID";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@ProductName", itemName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Image", image);
                    command.Parameters.AddWithValue("@ProductID", productId);
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

        public bool DeleteProduct(int productId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM tbProduct WHERE ProductID = @ProductId";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@ProductId", productId);
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
