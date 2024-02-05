using DAL;
using DATA_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductSellManagementService
    {
        static IProductSellManagement _product;

        static ProductSellManagementService()
        {
            _product = new ProductSellManagement();
        }

        public static bool ProductManagement(PRODUCTS_SELL PData, ref string msg)
        {
            return _product.ProductManagement(PData, ref msg);
        }

    }
}
