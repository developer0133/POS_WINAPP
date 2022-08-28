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
        public static bool UpdateInventory(INV_PRODUCTS InvData)
        {
            return _inv.UpdateInventory(InvData);
        }
    }
}
