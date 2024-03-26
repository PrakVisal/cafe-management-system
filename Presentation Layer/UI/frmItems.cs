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

namespace RMS_Project
{
    public partial class frmItems : Form
    {
        string connectionString = DBConnection.path;
        public frmItems()
        {
            InitializeComponent();
            cboFilterCategory.SelectedIndex = 0;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;

        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            frmCRUD_Item frm = new frmCRUD_Item("New Item");
            frm.ShowDialog();
        }
        private void LoadProducts()
        {

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
                    Image image = Image.FromStream(new System.IO.MemoryStream(imageData));
                    string category = reader["FoodCategoryName"].ToString();

                    UC_Item ucItem = new UC_Item(productId, productName, price, description, image, category);
                    flowLayoutPanel1.Controls.Add(ucItem);

                    ucItem.BtnUC_ItemClick += UC_Item_Click;
                }
            }
        }

        public class ProductUpdatedEventArgs : EventArgs
        {
            public string ItemName { get; }
            public decimal Price { get; }
            public string Description { get; }
            public byte[] ImageData { get; }
            public int ProductId { get; }

            public ProductUpdatedEventArgs(string itemName, decimal price, string description, byte[] imageData, int productId)
            {
                ItemName = itemName;
                Price = price;
                Description = description;
                ImageData = imageData;
                ProductId = productId;
            }

        }

        private void Frm_ProductUpdated(object sender, EventArgs e)
        {
            if (e is ProductUpdatedEventArgs productEventArgs)
            {
                UC_Item ucItemToUpdate = flowLayoutPanel1.Controls.OfType<UC_Item>().FirstOrDefault(item => item.ProductId == productEventArgs.ProductId);

                if (ucItemToUpdate != null)
                {
                    // Update the UC_Item control with the new details
                    ucItemToUpdate.ItemName = productEventArgs.ItemName;
                    ucItemToUpdate.Label1Text = $"{productEventArgs.Price:C}";
                    ucItemToUpdate.LabelDescription = productEventArgs.Description;
                    ucItemToUpdate.PictureBoxImage = Image.FromStream(new MemoryStream(productEventArgs.ImageData));
                }
            }
        }

       
        private void ShowAllItems()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Visible = true;
            }
        }

        private void FilterItemsByCategory(string category)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                UC_Item ucItem = control as UC_Item;
                if (ucItem != null)
                {
                    if (string.Equals(ucItem.Category, category, StringComparison.OrdinalIgnoreCase))
                    {
                        ucItem.Visible = true;
                    }
                    else
                    {
                        ucItem.Visible = false;
                    }
                }
            }
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchProduct.Text.Trim().ToLower(); // Convert the search text to lowercase for case-insensitive comparison

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                UC_Item ucItem = control as UC_Item;
                if (ucItem != null)
                {
                    string itemName = ucItem.ItemName.ToLower();
                    if (itemName.Contains(searchText))
                    {
                        ucItem.Visible = true;
                    }
                    else
                    {
                        ucItem.Visible = false;
                    }
                }
            }
        }

        private void UC_Item_Click(object sender, EventArgs e)
        {
            UC_Item clickedItem = (UC_Item)sender;
            int productId = clickedItem.ProductId;
            frmCRUD_Item frm = new frmCRUD_Item(clickedItem.ItemName, clickedItem.Label1Text, clickedItem.LabelDescription, clickedItem.PictureBoxImage, productId);
            frm.ProductUpdated += Frm_ProductUpdated; // Subscribe to the event
            frm.ShowDialog();
           
        }

        public void ReloadUserControls()
        {
            flowLayoutPanel1.Controls.Clear(); // Clear existing user controls
            LoadProducts(); 
        }

        private void frmItems_Load_1(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void cboFilterCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedCategory = cboFilterCategory.SelectedItem.ToString();
            if (selectedCategory == "All")
            {
                ShowAllItems();
            }
            else
            {
                FilterItemsByCategory(selectedCategory);
            }
        }
    }
}


   