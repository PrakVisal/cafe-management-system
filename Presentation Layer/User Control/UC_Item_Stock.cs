using System;
using System.Drawing;
using System.Windows.Forms;
using RMS_Project.Class;

namespace RMS_Project
{
    public partial class UC_Item_Stock : UserControl
    {
        public event EventHandler QtyUpdated;
        public UC_Item_Stock()
        {
            InitializeComponent();
        }
        public Label QtyLabel { get; set; }
        public event EventHandler ItemClicked;

        public string ItemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }

        public Image ItemImage
        {
            get { return ptrImage.Image; }
            set { ptrImage.Image = value; }
        }

        public string ItemQty
        {
            get { return lblQty.Text; }
            set { lblQty.Text = value; }
        }

        public string FoodCategory { get; set; }

        public int StockCount { get; set; }

        public double UnitPrice { get; set; }

        private void btnUCItems_Click_1(object sender, EventArgs e)
        {
            // Trigger the ItemClicked event when the button is clicked
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetInitialStockCount(int initialStockCount)
        {
            lblQty.Text = initialStockCount.ToString();
        }

        public void UpdateQtyLabel(string newQty)
        {
            lblQty.Text = newQty;
        }
    }
}
