using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS_Project.Business_Layer;

namespace RMS_Project.Business_Layer
{
    public class CategoryFilterStrategy: IStrategyItem
    {
        public bool FilterItems(UC_ItemAction item, string criterion)
        {
            return string.Equals(item.ItemCategory, criterion, StringComparison.OrdinalIgnoreCase);
        }

    }
}
