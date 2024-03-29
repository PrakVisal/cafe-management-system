using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS_Project.Business_Layer;

namespace RMS_Project.Business_Layer
{
    public class ProductNameSearchStrategy: IStrategyItem
    {

        public bool FilterItems(UC_Item item, string criterion)
        {
            string itemName = item.ItemName.ToLower();
            return itemName.Contains(criterion);
        }


    }
}
