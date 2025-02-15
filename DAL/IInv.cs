﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_EF;
using DATA_Models.DTO;
using DATA_Models.Models;

namespace DAL
{
    public interface IInv
    {
        bool InsertInventory(INV_PRODUCTS InvData);
        bool InsertInventory2(INV_PRODUCTS InvData);

        bool UpdateInventory(INV_PRODUCTS InvData);
        bool UpdateInventory2(INV_PRODUCTS InvData);

        List<INV_PRODUCTS> GetInventory(int id);
        List<InventoryDTO> GetAllInventory(string code);
        List<InventoryDTO> GetAllInventory2(int? id);

        List<InventoryDTO> GetProductParent(int? id);

        bool UpdateINV2(INV_PRODUCTS InvData, ref string msg);

        string SRTUNIT(int pid);
        List<DashboardDTO> GetTop5Products(string sdate);
        List<DashboardDTO> GetIncome(string sdate);
        List<DashboardDTO> GetIncomeLast30();
        List<DashboardDTO> GetTop5ProductsLast30();
    }
}
