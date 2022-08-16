using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DATA_Models.Models;
using DATA_Models.DTO;


namespace BL
{
    public class ProductService
    {
        static IProduct _product;

        static ProductService()
        {
            _product = new Product();
        }

        public static List<ProductDTO> GetProduct(string code)
        {
            return _product.GetProduct(code);
        }
    }
}
