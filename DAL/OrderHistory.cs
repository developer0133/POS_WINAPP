using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_Models.Models;
using DATA_Models.DTO;
using DATA_EF;
using DAL.Utils;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using POS_Utility;


namespace DAL
{
    public class OrderHistory : IOrderHistory
    {
        public List<ORDER_HISTORY> GetOrderHistory()
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            return _db.ORDER_HISTORY.ToList();
        }

        public List<OrderHistoryDTO2> GetOrderHistory(int id, string orderDate)
        {
            List<OrderHistoryDTO2> oList = new List<OrderHistoryDTO2>();
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            try
            {
                List<DATA_EF.ORDER_HISTORY> ORDER_HISTORY = new List<DATA_EF.ORDER_HISTORY>();
                List<DATA_EF.PRODUCTS> PRODUCTS = new List<DATA_EF.PRODUCTS>();

                DateTime? dt = null;

                var tmpProduct = _db.PRODUCTS.ToList().OrderBy(s => s.PRODUCT_ID);
                List<string> tmpCode = new List<string>();
                List<string> tmpCodeNew = new List<string>();

                tmpCode = tmpProduct.Select(s => s.PRODUCT_CODE).ToList();

                foreach (var item in tmpCode)
                {
                    string[] sp = item.Split('_');

                    if (!tmpCodeNew.Any(p => p == item))
                    {
                        tmpCodeNew.Add(sp[0]);
                    }

                }

                if (string.IsNullOrEmpty(orderDate) && id > 0)
                {
                    ORDER_HISTORY = _db.ORDER_HISTORY.Where(w => w.PRODUCT_ID == id).ToList();
                    PRODUCTS = _db.PRODUCTS.Where(w => w.PRODUCT_ID == id).ToList();
                }
                else
                {
                    dt = clsFunction.strDateToDateTime(orderDate);
                    ORDER_HISTORY = _db.ORDER_HISTORY.Where(w => System.Data.Entity.DbFunctions.TruncateTime(w.ORDER_DATE) == dt).ToList();
                    PRODUCTS = _db.PRODUCTS.Where(w => tmpCodeNew.Contains(w.PRODUCT_CODE)).ToList();
                }

               

                var qrydata = (from t in ORDER_HISTORY//_db.ORDER_HISTORY.Where(w => w.PRODUCT_ID == id)
                               join t2 in PRODUCTS on t.PRODUCT_ID equals t2.PRODUCT_ID //_db.PRODUCTS on t.PRODUCT_ID equals t2.PRODUCT_ID
                               join t3 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.STATUS == STATUS.ACTIVE) on t2.UNIT equals t3.MINOR_CODE into c1
                               from t4 in c1.DefaultIfEmpty()
                               select new
                               {
                                   HIST_ID = t.HIST_ID,
                                   PRODUCT_ID = t.PRODUCT_ID.Value,
                                   QTY = t.QTY,
                                   UNIT = t.UNIT,
                                   REMARK = t.REMARK,
                                   AMOUNT = t.AMOUNT,
                                   TOTAL_AMOUNT = t.TOTAL_AMOUNT,
                                   ORDER_DATE = t.ORDER_DATE,
                                   C_BY = t.C_BY,
                                   C_DATE = t.C_DATE,
                                   E_BY = t.E_BY,
                                   E_DATE = t.E_DATE,
                                   STR_UNIT = t4.NAME,

                                   RETAILPRICE = t2.RETAILPRICE,
                                   WHOLESALEPRICE = t2.WHOLESALEPRICE,
                                   AVGCOST = t2.AVGCOST,
                                   WHOLESALEPROFIT = t2.WHOLESALEPROFIT,
                                   RETAILPROFIT = t2.RETAILPROFIT,
                                   AVG_ITEM = t2.AVG_ITEM,
                                   AVG_PACK = t2.AVG_PACK,
                                   PRODUCT_NAME = t2.PRODUCT_NAME

                               }).AsQueryable();
                oList = (List<OrderHistoryDTO2>)qrydata.AsEnumerable().Select((s, index) => new OrderHistoryDTO2
                {
                    //No = (index + 1),
                    // HIST_ID = s.HIST_ID,
                    //PRODUCT_ID = s.PRODUCT_ID,
                    REMARK = s.REMARK,
                    QTY = s.QTY,
                    //UNIT = s.UNIT,
                    //ORDER_DATE = s.ORDER_DATE,
                    //C_BY = s.C_BY,
                    //C_DATE = s.C_DATE,
                    //AMOUNT = s.AMOUNT,
                    //TOTAL_AMOUNT = s.TOTAL_AMOUNT,
                    STR_AMOUNT = string.Format("{0} {1}", s.AMOUNT, ""),
                    STR_TOTAL_AMOUNT = string.Format("{0} {1}", s.TOTAL_AMOUNT, ""),
                    STR_ORDERDATE = s.ORDER_DATE.Value.ToString("dd/MM/yyyy", clsFunction.formatThai),
                    STR_UNIT = s.STR_UNIT,

                    //RETAILPRICE = s.RETAILPRICE,
                    //WHOLESALEPRICE = s.WHOLESALEPRICE,
                    //AVGCOST = s.AVGCOST,
                    //WHOLESALEPROFIT = s.WHOLESALEPROFIT,
                    //RETAILPROFIT = s.RETAILPROFIT,
                    AVG_ITEM = s.AVG_ITEM,
                    AVG_PACK = s.AVG_PACK,
                    PRODUCT_NAME = s.PRODUCT_NAME
                }).OrderBy(a => a.STR_ORDERDATE).ToList();

                return oList;
                //return await _db.ORDER_HISTORY.Where(w => w.PRODUCT_ID == id).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool InsertOrderHistory(ORDER_HISTORY orderhist)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            bool isSuccess = false;
            try
            {
                orderhist.ORDER_DATE = orderhist.ORDER_DATE.Value;
                orderhist.C_DATE = clsFunction.GetDate();
                orderhist.E_DATE = clsFunction.GetDate();

                _db.ORDER_HISTORY.Add(orderhist);
                _db.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }
    }
}
