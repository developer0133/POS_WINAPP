using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DATA_Models.Models;
using DATA_Models.DTO;
using DATA_EF;

namespace BL
{
    public class ProductService
    {
        static IProduct _product;

        static ProductService()
        {
            _product = new Product();
        }

        public static List<ProductDTO> GetProduct(string code, string flag)
        {
            return _product.GetProduct(code, flag);
        }
        public static bool UpdateProduct(PRODUCTS product)
        {
            return _product.UpdateProduct(product);
        }
        public static bool InsertProduct(PRODUCTS product)
        {
            return _product.InsertProduct(product);
        }
        public static List<ProductAutoCompleteDTO> GetProductAutoComplete()
        {
            return _product.GetProductAutoComplete();
        }

        public static List<ProductOutOfStockDTO> GetOutOfStock()
        {
            return _product.GetOutOfStock();
        }

        public static PRODUCTS GetProductByCODE(string code)
        {
            return _product.GetProductByCODE(code);
        }
    }
}
