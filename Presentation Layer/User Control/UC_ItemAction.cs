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
            lblPrice.Text = "$" + item.ItemPrice.ToString("F2");
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

            // Adjust price badge size dynamically
            AdjustPriceBadgeSize();

            // Setup cool hover animations
            SetupHoverAnimations();
        }

        private void AdjustPriceBadgeSize()
        {
            // Measure the text width
            using (Graphics g = this.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(lblPrice.Text, lblPrice.Font);
                int badgeWidth = (int)textSize.Width + 16; // Add padding
                if (badgeWidth < 80) badgeWidth = 80; // Minimum width
                if (badgeWidth > 120) badgeWidth = 120; // Maximum width
                priceBadge.Size = new Size(badgeWidth, 32);
            }
        }

        private void SetupHoverAnimations()
        {
            // Attach hover events to button (since it covers the entire card)
            btnUC_Item.MouseEnter += (s, e) =>
            {
                AnimateCardHover(true);
            };

            btnUC_Item.MouseLeave += (s, e) =>
            {
                AnimateCardHover(false);
            };

            // Also attach to UserControl for edge cases
            this.MouseEnter += (s, e) =>
            {
                AnimateCardHover(true);
            };

            this.MouseLeave += (s, e) =>
            {
                AnimateCardHover(false);
            };
        }

        private void AnimateCardHover(bool isHover)
        {
            if (isHover)
            {
                // Cool hover effect - lift and glow
                guna2ContainerControl1.ShadowDecoration.Depth = 25;
                guna2ContainerControl1.ShadowDecoration.Shadow = new Padding(0, -3, 0, 12);
                guna2ContainerControl1.BorderColor = Color.FromArgb(75, 103, 89);
                guna2ContainerControl1.BorderThickness = 2;
                guna2ContainerControl1.FillColor = Color.White;
            }
            else
            {
                // Reset to normal state
                guna2ContainerControl1.ShadowDecoration.Depth = 12;
                guna2ContainerControl1.ShadowDecoration.Shadow = new Padding(0, 0, 0, 6);
                guna2ContainerControl1.BorderColor = Color.FromArgb(240, 240, 240);
                guna2ContainerControl1.BorderThickness = 1;
                guna2ContainerControl1.FillColor = Color.White;
            }
            guna2ContainerControl1.Invalidate();
        }

        private void btnUC_Item_Click(object sender, EventArgs e)
        {
            frmCRUD_Item frmCRUD_Item = new frmCRUD_Item(item);
            frmCRUD_Item.ShowDialog();
        }
    }
}
