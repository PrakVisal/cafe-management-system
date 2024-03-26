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
    public class StockManager
    {
        public static DataTable GetStockItems()
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string query = "SELECT StockName, Photo FROM tbStockCount";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Print the retrieved column names
                Console.WriteLine("Retrieved Column Names:");
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.WriteLine(column.ColumnName);
                }

                return dataTable;
            }
        }

        public static DataTable FilterStockItemsByCategory(string category)
        {
            DataTable filteredItems = new DataTable();

            // Query to filter stock items by category
            string query = "SELECT StockName, Photo, StockCount FROM tbStockCount " +
                "WHERE FoodCategory = @Category AND FoodCategory IS NOT NULL AND FoodCategory <> ''";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Category", category);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(filteredItems);
                    }
                }
            }

            return filteredItems;
        }

        public static DataTable SearchStockItemsByName(string searchText)
        {
            DataTable filteredItems = new DataTable();

            // Query to search for stock items by name
            string query = "SELECT StockName, Photo FROM tbStockCount WHERE StockName LIKE @SearchText";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(filteredItems);
                    }
                }
            }

            return filteredItems;
        }

    }
}
