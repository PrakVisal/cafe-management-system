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
        public frmItems()
        {
            InitializeComponent();
            LoadData();
            cboFilterCategory.SelectedIndex = 0;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged_1;
            filterStrategy = new CategoryFilterStrategy();
            btnAccount.Visible = false; // Hide account button (login feature removed)
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            frmCRUD_Item frm = new frmCRUD_Item("Add New Item");
            frm.FormClosed += frmItems_FormClosed;
            frm.ShowDialog();
        }
        private void frmItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {

            pnlItem.Controls.Clear();

            // Get the list of users from the database
            List<Item> items = ItemManager.ReadItem();

            // Check if users list is not null or empty
            if (items != null && items.Any())
            {
                foreach (Item item in items)
                {
                    UC_ItemAction uc = new UC_ItemAction(item);
                    pnlItem.Controls.Add(uc);
                }
            }
            else
            {
                MessageBox.Show("No items found in the database.");
            }
        }
        public void ReloadItemControls()
        {
            LoadData();
        }


        private void txtSearchProduct_TextChanged_1(object sender, EventArgs e)
        {
            filterStrategy = new ProductNameSearchStrategy();
            //  FilterItems(txtSearchProduct.Text.Trim().ToLower());
            string searchText = txtSearchProduct.Text.Trim().ToLower();
            FilterItems(searchText);

        }

        private void cboFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cboFilterCategory.SelectedItem.ToString();
            if (selectedCategory == "All")
            {
                filterStrategy = null;
            }
            else
            {
                filterStrategy = new CategoryFilterStrategy();
                // Normalize category name to match database values
                if (selectedCategory == "Promotion Set")
                {
                    selectedCategory = "PromotionSet";
                }
                else if (selectedCategory == "Frappe")
                {
                    selectedCategory = "Frappes";
                }
                else if (selectedCategory == "Juice")
                {
                    selectedCategory = "Juices";
                }
                else if (selectedCategory == "Snack")
                {
                    selectedCategory = "Snacks";
                }
            }

            FilterItems(selectedCategory);

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            // Login feature removed - button disabled
        }
        private void FilterItems(string criterion)
        {
            foreach (Control control in pnlItem.Controls)
            {
                if (control is UC_ItemAction ucActionItem)
                {
                    // Determine whether the item meets the filtering criterion
                    bool meetsCriterion = filterStrategy == null || filterStrategy.FilterItems(ucActionItem, criterion);
                    ucActionItem.Visible = meetsCriterion; // Set visibility based on the result
                }
            }
        }

    }
}


