using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_Models.Models;
using DATA_Models.DTO;
using DATA_EF;


namespace DAL
{
    public interface IProduct
    {
        List<ProductDTO> GetProduct(string code);

        bool InsertProduct(PRODUCTS product);
        bool UpdateProduct(PRODUCTS product);

        List<ProductAutoCompleteDTO> GetProductAutoComplete();
    }
}
