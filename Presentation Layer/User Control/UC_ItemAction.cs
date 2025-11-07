using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS_Project.Business_Layer;
using ImageConverter = RMS_Project.Business_Layer.ImageConverter;

namespace RMS_Project
{
    public partial class UC_ItemAction : UserControl
    {
        readonly Item item;
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public UC_ItemAction(Item item)
        {
            InitializeComponent();

            this.item = item;
            ItemID = item.ItemID;
            ItemCategory = item.ItemCategory;
            ItemName = item.ItemName;
            lblItemName.Text = item.ItemName;
            lblPrice.Text = item.ItemPrice.ToString();
            lblDescription.Text = item.ItemDescription;
            

            try
            {
                if (item.itemImage != null)
                {
                    ptrImage.Image = ImageConverter.ConvertByteArrayToImage(item.itemImage);
                }
                else
                {
                    ptrImage.Image = Properties.Resources.no_image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUC_Item_Click(object sender, EventArgs e)
        {
            frmCRUD_Item frmCRUD_Item = new frmCRUD_Item(item);
            frmCRUD_Item.ShowDialog();
        }
    }
}
