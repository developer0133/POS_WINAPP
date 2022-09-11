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
        public List<ReportModel> SellItemReport(string code)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            List<ReportModel> reprotData = null;

            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.Required,
                          new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                {
                    var qry = (from t1 in _db.SELLITEMS.Where(w => w.SELLITEM_NO.ToLower() == code.ToLower())
                               join t2 in _db.PRODUCTS on t1.PRODUCT_ID equals t2.PRODUCT_ID
                               join t3 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.STATUS == STATUS.ACTIVE) on t1.UNIT equals t3.MINOR_CODE

                               select new ReportModel
                               {
                                   Item = t2.PRODUCT_NAME,
                                   Qty = t1.QTY,
                                   Unit = t3.NAME,
                                   Amount = t1.AMOUNT,
                                   Discount = t1.DISCOUNT,
                                   cdate = t1.C_DATE
                                   //Product_ID=t2.PRODUCT_ID,
                                   //Product_Code=t1.PRODUCT_CODE
                               }).AsQueryable();

                    reprotData = (List<ReportModel>)qry.AsEnumerable().Select((s, index) => new ReportModel
                    {
                        Item = s.Item,
                        Qty = s.Qty,
                        Amount = s.Amount,
                        Unit = s.Unit,
                        No = (index + 1),
                        Discount = s.Discount,
                        cdate = s.cdate
                    }).ToList();

                    scope.Complete();
                }

                if (reprotData == null)
                {
                    reprotData = new List<ReportModel>();
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
