using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_Project.Class;
using RMS_Project.Business_Layer;

namespace RMS_Project
{
    public partial class frmStocks : Form
    {
        private UC_Item_Stock ucItemStock;
        public frmStocks()
        {
            InitializeComponent();
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            
        }

        private void LoadStockItems()
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable stockItems = StockManager.GetStockItems();

            if (stockItems != null && stockItems.Rows.Count > 0)
            {
                foreach (DataRow row in stockItems.Rows)
                {
                    try
                    {
                        UC_Item_Stock itemStock = new UC_Item_Stock();

                        if (stockItems.Columns.Contains("StockName") && row["StockName"] != DBNull.Value)
                        {
                            itemStock.ItemName = row["StockName"].ToString();
                        }

                        if (stockItems.Columns.Contains("Photo") && row["Photo"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])row["Photo"];
                            MemoryStream ms = new MemoryStream(imageData);
                            itemStock.ItemImage = Image.FromStream(ms);
                        }

                        string itemName = itemStock.ItemName;
                        int initialStockCount = CRUDStockManager.GetStockCount(itemName);
                        itemStock.SetInitialStockCount(initialStockCount);

                        // Subscribe to the ItemClicked event
                        itemStock.ItemClicked += ItemStock_ItemClicked;

                        flowLayoutPanel1.Controls.Add(itemStock);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error loading stock item: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No stock items found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenCRUDStockForm(string itemName, Image itemImage, int stockCount, double unitPrice, string foodCategory)
        {
            // Pass the selected item information to the CRUD Stock form
            frmCRUD_Stock cruidStockForm = new frmCRUD_Stock(itemName, itemImage, stockCount, unitPrice, foodCategory);
            cruidStockForm.ShowDialog();
        }

        private void ItemStock_ItemClicked(object sender, EventArgs e)
        {
            // Open frmCRUD_Stock form
            UC_Item_Stock clickedItem = (UC_Item_Stock)sender;
            string itemName = clickedItem.ItemName;
            Image itemImage = clickedItem.ItemImage; // Assuming UC_Item_Stock has a property called ItemImage
            int stockCount = 0; // Assuming you have the stock count available here
            double unitPrice = 0.0; // Assuming you have the unit price available here
            string foodCategory = ""; // Assuming you have the food category available here
            OpenCRUDStockForm(itemName, itemImage, stockCount, unitPrice, foodCategory);
        }


        private void frmStocks_Load(object sender, EventArgs e)
        {
            LoadStockItems();
            
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cboRole.SelectedItem.ToString();

            if (selectedCategory == "All")
            {
                LoadStockItems(); // Load all stock items
            }
            else
            {
                // Filter stock items based on selected category
                DataTable filteredStockItems = StockManager.FilterStockItemsByCategory(selectedCategory);
                DisplayFilteredStockItems(filteredStockItems);
            }
        }


        private void DisplayFilteredStockItems(DataTable filteredStockItems)
        {
            flowLayoutPanel1.Controls.Clear();

            if (filteredStockItems != null && filteredStockItems.Rows.Count > 0)
            {
                foreach (DataRow row in filteredStockItems.Rows)
                {
                    try
                    {
                        UC_Item_Stock itemStock = new UC_Item_Stock();

                        if (filteredStockItems.Columns.Contains("StockName") && row["StockName"] != DBNull.Value)
                        {
                            itemStock.ItemName = row["StockName"].ToString();
                        }
                        if (filteredStockItems.Columns.Contains("StockCount") && row["StockCount"] != DBNull.Value)
                        {
                            itemStock.ItemQty = row["StockCount"].ToString();
                        }

                        if (filteredStockItems.Columns.Contains("Photo") && row["Photo"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])row["Photo"];
                            MemoryStream ms = new MemoryStream(imageData);
                            itemStock.ItemImage = Image.FromStream(ms);
                        }

                        itemStock.ItemClicked += (s, e) =>
                        {
                            OpenCRUDStockForm(itemStock.ItemName, itemStock.ItemImage, itemStock.StockCount, itemStock.UnitPrice, itemStock.FoodCategory);
                        };


                        flowLayoutPanel1.Controls.Add(itemStock);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error loading filtered stock item: " + ex.Message);
                    }
                }
            }

        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchProduct.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                // Filter stock items based on search text
                DataTable filteredStockItems = StockManager.SearchStockItemsByName(searchText);
                DisplayFilteredStockItems(filteredStockItems);
            }
            else
            {
                // If search text is empty, load all stock items
                LoadStockItems();
            }
        }

        


    }

}