using DocumentFormat.OpenXml.VariantTypes;
using Guna.UI2.WinForms;
using RMS_Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class frmOrders : Form
    {
        private Guna2Button currentButton;
        public frmOrders()
        {
            InitializeComponent();
            btnAll.Click += btnAll_Click;
        }
        
        private void ActiveButton(object btnsender)
        {
            if (btnsender != null)
            {
                // Call DisableButton before updating currentButton
                DisableButton();
                currentButton = (Guna2Button)btnsender;
                currentButton.Checked = true;
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.Checked = false;
                currentButton.FillColor = Color.WhiteSmoke;
            }
        }

        private void FilterItemsByCategory(string category)
        {
            foreach (Control control in flowLayoutPanel2.Controls)
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

        private void LoadProducts()
        {
            string query = "SELECT ProductName, Price, Description, Image, FoodCategoryName " +
                           "FROM tbProduct " +
                           "INNER JOIN tbFoodCategory ON tbProduct.FoodCategoryID = tbFoodCategory.FoodCategoryID";

            using (SqlConnection connection = new SqlConnection(DBConnection.path))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string productName = reader["ProductName"].ToString();
                    decimal price = Convert.ToDecimal(reader["Price"]);
                    string description = reader["Description"].ToString();
                    byte[] imageData = (byte[])reader["Image"];
                    Image image = Image.FromStream(new System.IO.MemoryStream(imageData));
                    string category = reader["FoodCategoryName"].ToString();


                    UC_Item ucItem = new UC_Item(productName, price, description, image, category);
                    ucItem.BtnUC_ItemClick += (sender, e) => AddToCart(ucItem);
                    ucItem.ItemName = productName;
                    ucItem.Label1Text = price.ToString();
                    ucItem.PictureBoxImage = image;
                    flowLayoutPanel2.Controls.Add(ucItem);
                }
            }
        }
        private void AddToCart(UC_Item ucItem)
        {
            UC_CartItem existingCartItem = pnlCartItem.Controls.OfType<UC_CartItem>()
                                           .FirstOrDefault(c => c.LabelName == ucItem.ItemName);
            if (existingCartItem != null)
            {
                existingCartItem.IncreaseQuantity();
            }
            else
            {
                UC_CartItem cartItem = new UC_CartItem(ucItem.ItemName, ucItem.Label1Text, ucItem.PictureBoxImage);
                cartItem.TxtAmount = 1;
                cartItem.LblPriceText = decimal.Parse(ucItem.Label1Text);
                pnlCartItem.Controls.Add(cartItem);

            }

            /*  CartItem newItem = new CartItem
              {
                  LabelName = ucItem.ItemName,
                  LblPriceText = decimal.Parse(ucItem.Label1Text),
                  TxtAmount = 1
              };

              UC_CartItem cartItem = new UC_CartItem();
              cartItem.Item = newItem;
              pnlCartItem.Controls.Add(cartItem); */

        }

        private void ShowAllItems()
        {
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                UC_Item ucItem = control as UC_Item;
                if (ucItem != null)
                {
                    ucItem.Visible = true;
                }
            }
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Beverages");
        }

    

        private void btnFrappes_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Frappes");

        }

        private void btnJuices_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Juices");
        }


        private void btnSnacks_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Snacks");
        }

      

        private void btnOthers_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Others");
        }

        private void btnPromotionSet_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Promotion Set");
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnKHQR_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnMeat_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            FilterItemsByCategory("Meats");

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ShowAllItems();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchProduct.Text.Trim().ToLower(); // Convert the search text to lowercase for case-insensitive comparison

            foreach (Control control in flowLayoutPanel2.Controls)
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
    }
}
