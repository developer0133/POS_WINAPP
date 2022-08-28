using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_EF;
using DATA_Models.Models;

namespace DAL
{
    public interface IInv
    {
        bool InsertInventory(INV_PRODUCTS InvData);

        bool UpdateInventory(INV_PRODUCTS InvData);

        List<INV_PRODUCTS> GetInventory(int id);
    }
}
