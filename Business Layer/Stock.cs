using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project.Business_Layer
{
    public class Stock
    {
        public int StockID { get; set; }
        public string StockName { get; set; }
        public byte[] Photo { get; set; }
        public int StockCount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public byte[] StockImage { get; set; }
        public int FoodCategoryID { get; set; }
        public string FoodCategoryName { get; set; }
    }
}
