using DATA_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DATA_EF;
using DAL.Utils;

namespace DAL
{
    public class Report:IReport
    {
        public List<SellReportModel> SellItemReport(string code)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            List<SellReportModel> reprotData = null;

            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.Required,
                          new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                {
                    var qry = (from t1 in _db.SELLITEMS.Where(w => w.SELLITEM_NO.ToLower() == code.ToLower())
                               join t2 in _db.PRODUCTS on t1.PRODUCT_ID equals t2.PRODUCT_ID
                               join t3 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.STATUS == STATUS.ACTIVE) on t1.UNIT equals t3.MINOR_CODE

                               select new SellReportModel
                               {
                                   Item = t2.PRODUCT_NAME,
                                   Qty = t1.QTY,
                                   UNIT = t3.NAME,
                                   AMOUNT = t1.AMOUNT,
                                   DISCOUNT = t1.DISCOUNT,
                                   CDATE = t1.C_DATE
                                   //Product_ID=t2.PRODUCT_ID,
                                   //Product_Code=t1.PRODUCT_CODE
                               }).AsQueryable();

                    reprotData = (List<SellReportModel>)qry.AsEnumerable().Select((s, index) => new SellReportModel
                    {
                        Item = s.Item,
                        Qty = s.Qty,
                        AMOUNT = s.AMOUNT,
                        UNIT = s.UNIT,
                        No = (index + 1),
                        DISCOUNT = s.DISCOUNT,
                        CDATE = s.CDATE
                    }).ToList();

                    scope.Complete();
                }

                if (reprotData == null)
                {
                    reprotData = new List<SellReportModel>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return reprotData;
        }
    }
}
