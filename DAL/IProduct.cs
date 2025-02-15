﻿using System;
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
        List<ProductDTO> GetProduct(string code, string flag);

        bool InsertProduct(PRODUCTS product);
        bool UpdateProduct(PRODUCTS product);

        List<ProductAutoCompleteDTO> GetProductAutoComplete();

        List<ProductAutoCompleteDTO> GetProductAutoComplete2();
        List<ProductOutOfStockDTO> GetOutOfStock();
        PRODUCTS GetProductByCODE(string code);

        List<PRODUCTS> GetProductParent(string code);
        List<ProductDTO> GetProductForSell(string code);
    }
}
