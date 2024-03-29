using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_Project.Business_Layer;
using RMS_Project.Class;
using ItemManager = RMS_Project.Business_Layer.ItemManager;
using CategoryFilterStrategy = RMS_Project.Business_Layer.CategoryFilterStrategy;
using ProductNameSearchStrategy = RMS_Project.Business_Layer.ProductNameSearchStrategy;



namespace RMS_Project
{
    public partial class frmItems : Form
    {

        private IStrategyItem filterStrategy;
        private ItemManager itemManager;

        public frmItems()
        {
            InitializeComponent();
            cboFilterCategory.SelectedIndex = 0;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            filterStrategy = new CategoryFilterStrategy();
            itemManager = new ItemManager(DBConnection.path);
            btnAccount.Text = SharedData.CurrentUsername;
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            frmCRUD_Item frm = new frmCRUD_Item("New Item");
            frm.ShowDialog();
        }

        private void LoadProducts()
        {
            flowLayoutPanel1.Controls.Clear();

            // Load all items from the database
            List<ItemManager.ItemData> items = itemManager.GetItems();

            // Display all items
            DisplayItems(items);
        }

        private void DisplayItems(List<ItemManager.ItemData> items)
        {
            foreach (var item in items)
            {
                UC_Item ucItem = new UC_Item(item.ProductId, item.ProductName, item.Price, item.Description, item.Image, item.Category);
                flowLayoutPanel1.Controls.Add(ucItem);
                ucItem.BtnUC_ItemClick += UC_Item_Click;
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
                filterStrategy = null; // No filtering needed
            }
            else
            {
                filterStrategy = new CategoryFilterStrategy();
            }
            FilterItems(selectedCategory);
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            filterStrategy = new ProductNameSearchStrategy();
            FilterItems(txtSearchProduct.Text.Trim().ToLower());
        }

        private void FilterItems(string criterion)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is UC_Item ucItem)
                {
                    // Determine whether the item meets the filtering criterion
                    bool meetsCriterion = filterStrategy == null || filterStrategy.FilterItems(ucItem, criterion);
                    ucItem.Visible = meetsCriterion; // Set visibility based on the result
                }
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            FormHelper.AccountButton_Click(sender, e);
        }
    }
}


   