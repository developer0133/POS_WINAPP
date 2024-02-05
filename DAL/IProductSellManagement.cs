using DATA_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IProductSellManagement
    {
        bool ProductManagement(PRODUCTS_SELL PData, ref string msg);
    }
}
