using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS_Project.Business_Layer;
using RMS_Project.Class;

namespace RMS_Project.Business_Layer
{
    public class ItemCategoryManager
    {
        public static List<ItemCategory> ReadItemCategory()
        {
            List<ItemCategory> itemCategories = new List<ItemCategory>();
            using (SqlConnection connection = DBConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("SELECT * FROM tbFoodCategory", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ItemCategory itemCategory = new ItemCategory
                    {
                        CategoryID = Convert.ToInt32(reader["FoodCategoryID"]),
                        CategoryName = reader["FoodCategoryName"].ToString()
                    };
                    itemCategories.Add(itemCategory);
                }
            }
            return itemCategories;
        }
    }
}
