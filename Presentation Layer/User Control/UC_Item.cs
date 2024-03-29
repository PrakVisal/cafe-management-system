using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static RMS_Project.UC_CartItem;

namespace RMS_Project
{
    public partial class UC_Item : UserControl
    {
       
        public int ProductId { get; set; }
        public string Category { get; private set; }
        public string Label1Text
        {
            get { return lblPrice.Text; }
            set
            {
                // Remove the dollar sign from the price before setting the text
                lblPrice.Text = value;
            }
        }


        public string LabelDescription
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }

        public Image PictureBoxImage
        {
            get { return guna2PictureBox1.Image; }
            set { guna2PictureBox1.Image = value; }
        }

        public string ItemName
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }

        public event EventHandler<ItemAddedEventArgs> ItemAddedToCart;

        public UC_Item()
        {
            InitializeComponent();
        }
    
        public UC_Item(int productId, string productName, decimal price, string description, Image image, string category)
        {
            InitializeComponent();
            ProductId = productId;
            lblItemName.Text = productName;
            lblDescription.Text = description;
            lblPrice.Text = price.ToString();
            guna2PictureBox1.Image = image;
            Category = category;

        }

        public UC_Item(string productName, decimal price, string description, Image image, string category)
        {
            InitializeComponent();
            lblItemName.Text = productName;
            lblDescription.Text = description;
            lblPrice.Text = price.ToString();
            guna2PictureBox1.Image = image;
            Category = category;

        }
        public event EventHandler BtnUC_ItemClick;
        private void btnUC_Item_Click(object sender, EventArgs e)
        {

            BtnUC_ItemClick?.Invoke(this, EventArgs.Empty);
        }
        
    }

}


    

