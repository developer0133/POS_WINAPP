using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_EF;
using DAL.Utils;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DATA_Models.DTO;


namespace DAL
{
    public interface ISellItem
    {
        string InsertSellItem(List<SELLITEMS> sellitem);
        string InsertSellItem2(List<SELLITEMS> sellitem, ref string message);
        List<SellHistDTO> GetSellItem(int productid, List<int> parentID);
        string GetSellCode();
    }
}
