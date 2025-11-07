using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RMS_Project.Business_Layer
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public string ItemDescription { get; set; }
        public byte[] itemImage { get; set; }
        public string ItemCategory { get; set; }
        public Image image { get; set; }
    }
}