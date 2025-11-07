using System;
using System.Drawing;
using System.Windows.Forms;
using RMS_Project.Class;
using System.Data;
using System.IO;
using static RMS_Project.Class.CRUDStockManager;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using ClosedXML.Parser;

namespace RMS_Project
{
    public partial class frmCRUD_Stock : Form
    {
        private int foodCategoryID;
        private string stockType;
        private string ItemName;
        private Image ItemImage;
        private int StockCount;
        private double UnitPrice;
        private string FoodCategory;
        private RadioButton rboStockIn;
        private UC_Item_Stock ucItemStock;

        public frmCRUD_Stock(string itemName, Image itemImage, int stockCount, double unitPrice, string foodCategory)
        {
            InitializeComponent();

            // Display item details
            ItemName = itemName;
            ItemImage = itemImage;
            StockCount = stockCount;
            UnitPrice = unitPrice;
            FoodCategory = foodCategory;
            if (cboCateggory.SelectedItem != null)
            {
                foodCategoryID = GetFoodCategoryID(cboCateggory.SelectedItem.ToString());
            }
            rboStockIn = new RadioButton();
            //this.rboStockIn.CheckedChanged += new System.EventHandler(this.rdoStockIN_CheckedChanged_1);

            ucItemStock = new UC_Item_Stock();
            ucItemStock.QtyLabel = lblQty;

        }

        // Convert image to byte array
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private int GetFoodCategoryID(string foodCategory)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string query = "SELECT FoodCategoryID FROM tbFoodCategory WHERE FoodCategoryName = @FoodCategory";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FoodCategory", foodCategory);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            // If the category is not found, you can handle it as needed
            throw new Exception("Category ID not found for " + foodCategory);
        }

        private void rdoStockIN_CheckedChanged_1(object sender, EventArgs e)
        {
            PopulateControlsBasedOnRadioButtons();
            UpdateNewQty();
        }

        private void rdoStockOUT_CheckedChanged_1(object sender, EventArgs e)
        {
            PopulateControlsBasedOnRadioButtons();
            UpdateNewQty();
        }

        private void PopulateControlsBasedOnRadioButtons()
        {
            if (rdoStockIN.Checked)
            {

                txtUnitPrice.Enabled = false;
                txtPrice.Enabled = false;
                cboCateggory.Enabled = false;
                dtpExpiration.Enabled = false;
                txtSafetyAlert.Enabled = false;

                // Populate controls with values from tbStockIn
                DataTable stockInData = CRUDStockManager.GetStockForItem(ItemName);
                if (stockInData.Rows.Count > 0)
                {
                    txtUnitPrice.Text = stockInData.Rows[0]["UnitPrice"].ToString();
                    txtPrice.Text = stockInData.Rows[0]["Amount"].ToString();
                    cboCateggory.Text = stockInData.Rows[0]["FoodCategory"].ToString();
                    if (cboCateggory.Items.Contains(cboCateggory.Text))
                    {
                        cboCateggory.SelectedItem = cboCateggory.Text;
                    }
                    else
                    {
                        MessageBox.Show($"The value '{cboCateggory.Text}' is not found in the combobox items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dtpExpiration.Value = DateTime.Now;
                    txtSafetyAlert.Text = "1";
                }
            }
            else if (rdoStockOUT.Checked)
            {

                txtUnitPrice.Enabled = false;
                txtPrice.Enabled = false;
                cboCateggory.Enabled = false;
                dtpExpiration.Enabled = false;
                txtSafetyAlert.Enabled = false;

                // Populate controls with values from tbStockOut
                DataTable stockOutData = CRUDStockManager.GetStockForItem(ItemName);
                if (stockOutData.Rows.Count > 0)
                {
                    txtUnitPrice.Text = stockOutData.Rows[0]["UnitPrice"].ToString();
                    txtPrice.Text = stockOutData.Rows[0]["Amount"].ToString();
                    cboCateggory.Text = stockOutData.Rows[0]["FoodCategory"].ToString();
                    dtpExpiration.Value = DateTime.Now;
                    txtSafetyAlert.Text = "1";
                }

            }
        }
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            UpdateNewQty();
        }

        private void UpdateNewQty()
        {
            try
            {
                int quantity;
                lblOldQty.Text = lblQty.Text;
                lblNewQty.Text = lblQty.Text;

                string input = txtQty.Text.Trim();

                if (!Regex.IsMatch(input, @"^\d+$"))
                {
                    lblNewQty.Text = lblOldQty.Text;
                    return;
                }

                // Validate if txtQty contains a valid integer value
                if (!int.TryParse(txtQty.Text, out quantity))
                {
                    lblNewQty.Text = lblOldQty.Text;
                    return;
                }

                // Get the current value from lblOldQty
                int oldQty = int.Parse(lblOldQty.Text);

                int newQty;

                if (rdoStockIN.Checked)
                {
                    newQty = oldQty + quantity;
                }
                else
                {
                    newQty = oldQty - quantity;
                }

                // Update lblNewQty with the new quantity
                lblNewQty.Text = newQty.ToString();
            }

            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error, display a message box)
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrement_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Please enter a quantity in the textbox.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = int.Parse(txtQty.Text);
            if (qty > 0)
            {
                txtQty.Text = (--qty).ToString();
            }
        }

        private void btnIncrement_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Please enter a quantity in the textbox.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = int.Parse(txtQty.Text);
            txtQty.Text = (++qty).ToString();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtUnitPrice.Text = "";
            txtPrice.Text = "";
            cboCateggory.Text = "";
            txtSafetyAlert.Text = "";
            txtQty.Text = "";
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string foodCategory = cboCateggory.SelectedItem?.ToString();
            int foodCategoryID = GetFoodCategoryID(foodCategory);
            int quantity = int.Parse(txtQty.Text);
            int initialStockCount = int.Parse(lblQty.Text);

            // Ensure foodCategoryID is valid
            if (foodCategoryID == -1)
            {
                MessageBox.Show("Food category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate if quantity is entered
            if (string.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Please enter a quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if a stock type (Stock In or Stock Out) is selected
            if (!rdoStockIN.Checked && !rdoStockOUT.Checked)
            {
                MessageBox.Show("Please select a stock type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] photoByteArray = ImageToByteArray(ptrImage.Image);
            decimal amount = int.Parse(txtQty.Text) * decimal.Parse(txtUnitPrice.Text);


            // Create an instance of StockDetails with the necessary data
            StockDetails stockDetails = new StockDetails(
                ItemName, // Assuming ItemName is accessible in this context
                int.Parse(txtQty.Text), // Assuming txtQty contains the quantity
                decimal.Parse(txtUnitPrice.Text), // Assuming txtUnitPrice contains the unit price
                cboCateggory.SelectedItem.ToString(), // Assuming cboCateggory contains the selected category
                dtpExpiration.Value, // Assuming dtpExpiration contains the selected expiration date
                photoByteArray,// Pass the photo byte array to the constructor
                amount,
                foodCategoryID
            );

            bool isStockIn = rdoStockIN.Checked;
            CRUDStockManager.SaveStock(stockDetails, isStockIn, initialStockCount);

            // Determine stock type and save data accordingly
            if (rdoStockIN.Checked)
            {
                // Save data to tbStockIn
                stockDetails.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                stockDetails.Amount = stockDetails.UnitPrice * quantity; // Calculate amount
                stockDetails.Photo = ImageToByteArray(ptrImage.Image);


                CRUDStockManager.UpdateStockCount(ItemName, initialStockCount, quantity, isStockIn);
            }
            else if (rdoStockOUT.Checked)
            {
                // Save data to tbStockOut
                stockDetails.UnitPrice = decimal.Parse(txtPrice.Text); // Assuming txtPrice is used for unit price in Stock Out
                stockDetails.Amount = stockDetails.UnitPrice * quantity; // Calculate amount
                stockDetails.Photo = ImageToByteArray(ptrImage.Image);

                if (initialStockCount < 0)
                {
                    MessageBox.Show("Insufficient stock quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CRUDStockManager.UpdateStockCount(ItemName, initialStockCount, quantity, isStockIn);
            }
            int newStockCount = CRUDStockManager.GetStockCount(ItemName);
            lblQty.Text = newStockCount.ToString();

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            ucItemStock.UpdateQtyLabel(lblQty.Text);
            frmStocks parentForm = Application.OpenForms["frmStocks"] as frmStocks;
            parentForm?.ReloadStockControls();
           
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCRUD_Stock_Load_1(object sender, EventArgs e)
        {
            lblItemName.Text = ItemName;
            ptrImage.Image = ItemImage;
            lblQty.Text = StockCount.ToString();

            StockCount = CRUDStockManager.GetStockCountForItem(ItemName);
            lblQty.Text = StockCount.ToString();
            PopulateControlsBasedOnRadioButtons();
        }
    }
}

