using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_EF;
using DATA_Models.DTO;
using DATA_Models.Models;

namespace DAL
{
    public interface IOrderHistory
    {
        List<ORDER_HISTORY> GetOrderHistory();
        List<OrderHistoryDTO2> GetOrderHistory(int PRODUCT_ID, string orderDate);
        bool InsertOrderHistory(ORDER_HISTORY orderhist);
    }
}
