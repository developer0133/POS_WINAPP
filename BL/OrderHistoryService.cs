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
    public class OrderHistoryService
    {
        static IOrderHistory _orderHist;

        static OrderHistoryService()
        {
            _orderHist = new OrderHistory();
        }

        public static List<ORDER_HISTORY> GetOrderHistory()
        {
            return _orderHist.GetOrderHistory();
        }

        public static List<OrderHistoryDTO2> GetOrderHistory(int id, string orderDate)
        {
            return _orderHist.GetOrderHistory(id, orderDate);
        }

        public static bool InsertOrderHistory(ORDER_HISTORY orderhist)
        {
            return _orderHist.InsertOrderHistory(orderhist);
        }
    }
}
