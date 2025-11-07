using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project.Business_Layer
{
    public interface IStrategyItem
    {
        bool FilterItems(UC_ItemAction item, string criterion);
    }
}

