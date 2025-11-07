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
using ImageConverter = RMS_Project.Business_Layer.ImageConverter;
using RMS_Project.Class;
using Microsoft.VisualBasic.ApplicationServices;

namespace RMS_Project
{

    public partial class frmCRUD_Item : Form
    {
        Item item = null;
        private ItemManager itemManager;
        public frmCRUD_Item(Item item)
        {
            InitializeComponent();

            foreach (ItemCategory category in ItemCategoryManager.ReadItemCategory())
                cboCategory.Items.Add(category.CategoryName);

            this.item = item;
            txtProductID.Text = item.ItemID.ToString();
            txtName.Text = item.ItemName;
            txtPrice.Text = item.ItemPrice.ToString();
            txtDescription.Text = item.ItemDescription;
            cboCategory.SelectedIndex = cboCategory.FindStringExact(item.ItemCategory);
            ptrImage.Image = ImageConverter.ConvertByteArrayToImage(item.itemImage);

            txtProductID.Enabled = false;
            lblTitle.Text = "Edit Item";


        }
        public frmCRUD_Item(string title)
        {
            InitializeComponent();

            if (title.Equals("Add New Item"))
            {
                txtProductID.Enabled = false;
                btnDelete.Visible = false;
            }

            txtProductID.Text = Convert.ToString(ItemManager.ReadItemID() + 1);

            foreach (ItemCategory category in ItemCategoryManager.ReadItemCategory())
                cboCategory.Items.Add(category.CategoryName);

            lblTitle.Text = title;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                if (lblTitle.Text == "Add New Item")
                {
                    Item item = CreateItem();
                    ItemManager.AddItem(item);
                    MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    byte[] itemImage = ImageConverter.ConvertImageToBytes(ptrImage);
                    if (cboCategory.SelectedItem.ToString() == "Others")
                    {
                        // Create stock entry if category is "Others"
                        if (CreateStockManager.CreateStockEntry(txtName.Text, decimal.Parse(txtPrice.Text), itemImage))
                        {
                            MessageBox.Show("Stock entry created successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to create stock entry.");
                        }
                    }
                    this.Close(); 
                }
                else
                {
                    Item item = UpdateItem();
                    ItemManager.UpdateItem(item);
                    MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close(); return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            frmItems parentForm = Application.OpenForms["frmItems"] as frmItems;
            parentForm?.ReloadItemControls();
            this.Close();

        }
        private Item CreateItem()
        {
            try
            {
                string itemName = txtName.Text;
                decimal itemPrice = Convert.ToDecimal(txtPrice.Text);
                string itemDescription = txtDescription.Text;
                string itemCategory = cboCategory.SelectedItem.ToString();
                //byte[] itemImage = ConvertImageToByteArray(ptrImage.Image);
                byte[] itemImage = ImageConverter.ConvertImageToBytes(ptrImage);

                return new Item
                {
                    ItemName = itemName,
                    ItemPrice = itemPrice,
                    ItemDescription = itemDescription,
                    ItemCategory = itemCategory,
                    itemImage = itemImage
                };
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the item: " + ex.Message);
            }
        }

        private Item UpdateItem()
        {
            try
            {
                int itemID = Convert.ToInt32(txtProductID.Text);
                string itemName = txtName.Text;
                decimal itemPrice = Convert.ToDecimal(txtPrice.Text);
                string itemDescription = txtDescription.Text;
                string itemCategory = cboCategory.SelectedItem.ToString();
                //byte[] itemImage = ConvertImageToByteArray(ptrImage.Image);
                byte[] itemImage = ImageConverter.ConvertImageToBytes(ptrImage);

                return new Item
                {
                    ItemID = itemID,
                    ItemName = itemName,
                    ItemPrice = itemPrice,
                    ItemDescription = itemDescription,
                    ItemCategory = itemCategory,
                    itemImage = itemImage
                };
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the item: " + ex.Message);
            }
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Delete User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    ItemManager.DeleteItem(item.ItemID);
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        public static byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null)
            {
                throw new ArgumentException("Invalid image parameter");
            }

            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    // Save the image to the memory stream in PNG format
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    // Return the byte array representation of the image
                    return ms.ToArray();
                }
                catch (Exception ex)
                {
                    // Handle any specific exceptions or log the error as needed
                    throw new Exception("Error converting image to byte array", ex);
                }
            }
        }      

        private async void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\"; // Set initial directory
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            DialogResult result = await Task.Run(() => ofd.ShowDialog(this));
            if (result == DialogResult.OK)
            {
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
      
    }
}