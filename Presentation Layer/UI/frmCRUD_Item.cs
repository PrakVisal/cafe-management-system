using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using RMS_Project.Business_Layer;
using RMS_Project.Class;

namespace RMS_Project
{
    
    public partial class frmCRUD_Item : Form
    {
        private ItemManager itemManager;

        //private const string connectionString = "Data Source=LAPTOP-ALHRF6DV\\SQLEXPRESS;Initial Catalog=ManagementSystem;Trusted_Connection=True;";
        private byte[] imageData;
        private FlowLayoutPanel flowLayoutPanel1;
        private bool isUpdateMode = false;
        private int productIdToUpdate = -1;

        public frmCRUD_Item(string itemName, string price, string description, Image image, int productId)
        {
            InitializeComponent();

            itemManager = new ItemManager(DBConnection.path);

            //Console.WriteLine($"Item Name: {itemName}, Price: {price}, Description: {description}, Product ID: {productId}");
            txtName.Text = itemName;
            txtPrice.Text = price.ToString();
            txtDescription.Text = description;
            txtProductID.Text = productId.ToString(); // Display ProductID in TextBox
            ptrImage.Image = image;
            productIdToUpdate = productId;
            isUpdateMode = true;
            PopulateCategoryComboBox();
            FillCategoryComboBox(productId);

        }

        public frmCRUD_Item(string title)
        {
            InitializeComponent();

            itemManager = new ItemManager(DBConnection.path);
  
            if (title.Equals("New Item"))
            {
                btnDelete.Visible = false;
                lblProductID.Visible = false;
                txtProductID.Visible = false;
            }
        }

        private void FillCategoryComboBox(int productId)
        {
            try
            {
                // Fetch and set the category for the existing product
                string category = itemManager.GetProductCategory(productId);
                if (!string.IsNullOrEmpty(category))
                {
                    cboCategory.SelectedItem = category;
                    cboCategory.Enabled = false; // Optionally disable the ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the category: " + ex.Message);
            }
        }


        private bool ValidateInput()
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) || cboCategory.SelectedIndex == 0 || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtDescription.Text) || ptrImage.Image == null)
            {
                MessageBox.Show("Please fill all fields and select a category.");
                return false;
            }

            // Remove any non-numeric characters except for '.' (decimal separator)
            string cleanedPriceText = new string(txtPrice.Text.Where(c => char.IsDigit(c) || c == '.').ToArray());

            if (!decimal.TryParse(cleanedPriceText, out decimal price))
            {
                MessageBox.Show("Price must be a valid number.");
                return false;
            }

            return true;

        }

        private void PopulateCategoryComboBox()
        {
            cboCategory.Items.Add("Choose Category");
            cboCategory.Items.Add("Beverages");
            cboCategory.Items.Add("Frappes");
            cboCategory.Items.Add("Juices");
            cboCategory.Items.Add("Meats");
            cboCategory.Items.Add("Snacks");
            cboCategory.Items.Add("Others");
            cboCategory.Items.Add("Promotion Set");
            cboCategory.SelectedIndex = 0;
        }

       
        private byte[] ConvertImageToByteArray(Image image)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Save the image to the memory stream in JPEG format
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    // Return the byte array representation of the image
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                // If an error occurs during image conversion, return null
                MessageBox.Show("Error converting image to byte array: " + ex.Message);
                return null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        
        public class ProductDeletedEventArgs : EventArgs
        {
            public int ProductId { get; }

            public ProductDeletedEventArgs(int productId)
            {
                ProductId = productId;
            }
        }

        public event EventHandler<ProductDeletedEventArgs> ProductDeleted;

        // Call this event when the product is deleted
        protected virtual void OnProductDeleted(ProductDeletedEventArgs e)
        {
            ProductDeleted?.Invoke(this, e);
        }

        
        public event EventHandler ProductUpdated;

        // Call this event when the product is updated
        protected virtual void OnProductUpdated(EventArgs e)
        {
            ProductUpdated?.Invoke(this, e);
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (!ValidateInput())
            {
                return;
            }

            // Retrieve updated product details
            string itemName = txtName.Text.Trim();
            string cleanedPriceText = new string(txtPrice.Text.Where(c => char.IsDigit(c) || c == '.').ToArray());
            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }
            string description = txtDescription.Text.Trim();
            string category = cboCategory.SelectedItem.ToString();
            byte[] imageData = ConvertImageToByteArray(ptrImage.Image);

            // Update the product in the database
            if (isUpdateMode)
            {
                if (itemManager.UpdateProduct(itemName, category, price, description, imageData, productIdToUpdate))
                {
                    MessageBox.Show("Product updated successfully!");
                    OnProductUpdated(EventArgs.Empty); // Notify frmItems.cs that the product is updated
                    this.Close(); // Close the form after updating
                }
                else
                {
                    MessageBox.Show("Failed to update product.");
                }
            }
            else
            {
                // Insert new product into the database
                if (itemManager.InsertProduct(itemName, category, price, description, imageData))
                {
                    MessageBox.Show("Product added successfully!");
                    OnProductUpdated(EventArgs.Empty); // Notify frmItems.cs that a new product is added
                    this.Close(); // Close the form after adding
                    if (category == "Others")
                    {
                        // Create stock entry if category is "Others"
                        if (CreateStockManager.CreateStockEntry(itemName, price, imageData, category))
                        {
                            MessageBox.Show("Stock entry created successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to create stock entry.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Failed to add product.");
                }
            }
            frmItems parentForm = Application.OpenForms["frmItems"] as frmItems;
            parentForm?.ReloadUserControls();
            this.Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            int productIdToDelete = int.Parse(txtProductID.Text);

            // Delete the product from the database
            if (itemManager.DeleteProduct(productIdToDelete))
            {
                MessageBox.Show("Product deleted successfully!");
                // Notify the parent form (frmItems) that a product has been deleted
                OnProductDeleted(new ProductDeletedEventArgs(productIdToDelete));
                this.Close(); // Close the form after deleting
            }
            else
            {
                MessageBox.Show("Failed to delete product.");
            }
            frmItems parentForm = Application.OpenForms["frmItems"] as frmItems;
            parentForm?.ReloadUserControls();
            this.Close();
        }

        private async void btnImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\year4\OOAD\RMS-Project\RMS Photo"; // Set initial directory
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            DialogResult result = await Task.Run(() => ofd.ShowDialog(this));
            if (result == DialogResult.OK)
            {
                //ptrImage.SizeMode = PictureBoxSizeMode.StretchImage;
                //ptrImage.ImageLocation = ofd.FileName;
                try
                {
                    ptrImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    // Load the image using Image.FromFile to handle potential errors
                    using (Image img = Image.FromFile(ofd.FileName))
                    {
                        ptrImage.Image = new Bitmap(img);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void frmCRUD_Item_Load_1(object sender, EventArgs e)
        {
            txtProductID.Enabled = false;
        }
    }
}
