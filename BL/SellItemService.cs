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
    public class SellItemService
    {
        static ISellItem _sellItem;

        static SellItemService()
        {
            _sellItem = new SellItem();
        }

        public static string InsertSellItem(List<SELLITEMS> sellitem)
        {
            return _sellItem.InsertSellItem(sellitem);
        }

        public static string InsertSellItem2(List<SELLITEMS> sellitem, ref string message)
        {
            return _sellItem.InsertSellItem2(sellitem, ref message);
        }

        public static List<SellHistDTO> GetSellItem(int productid, List<int> parentID)
        {
            return _sellItem.GetSellItem(productid, parentID);
        }

        public static string GetSellCode()
        {
            return _sellItem.GetSellCode();
        }

    }
}
