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
    public class InvService
    {
        static IInv _inv;

        static InvService()
        {
            _inv = new Inv();
        }

        public static  bool InsertInventory(INV_PRODUCTS InvData)
        {
            return _inv.InsertInventory(InvData);
        }

        public static bool InsertInventory2(INV_PRODUCTS InvData)
        {
            return _inv.InsertInventory2(InvData);
        }
        public static bool UpdateInventory(INV_PRODUCTS InvData)
        {
            return _inv.UpdateInventory(InvData);
        }
        public static bool UpdateInventory2(INV_PRODUCTS InvData)
        {
            return _inv.UpdateInventory2(InvData);
        }

        public static bool UpdateINV2(INV_PRODUCTS InvData)
        {
            return _inv.UpdateINV2(InvData);
        }

        public static List<InventoryDTO> GetAllInventory(string code)
        {
            return _inv.GetAllInventory(code);
        }

        public static List<InventoryDTO> GetAllInventory2(int? id)
        {
            return _inv.GetAllInventory2(id);
        }

        public static List<InventoryDTO> GetProductParent(int? id)
        {
            return _inv.GetProductParent(id);
        }

        public static List<INV_PRODUCTS> GetInventory(int id)
        {
            return _inv.GetInventory(id);
        }

        public static string SRTUNIT(int pid)
        {
            return _inv.SRTUNIT(pid);
        }
    }
}
