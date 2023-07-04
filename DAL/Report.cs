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
                               join t3 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNITSELL && w.STATUS == STATUS.ACTIVE) on t1.UNIT equals t3.MINOR_CODE

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

        public List<ReportModel2> SellSummaryReport(string sdate, string flag)
        {
            List<ReportModel2> reprotData = null;
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.Required,
                          new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                {

                    DateTime? dt = clsFunction.strDateToDateTime(sdate);

                    //var sellItem = _db.SELLITEMS.AsNoTracking().Where(w => System.Data.Entity.DbFunctions.TruncateTime(w.C_DATE) == dt);
                    var sellItem = _db.SELLITEMS.Where(w => System.Data.Entity.DbFunctions.TruncateTime(w.C_DATE) == dt);

                    if (flag == "M")//month
                    {
                        sellItem = _db.SELLITEMS.Where(w => w.C_DATE.Value.Month == dt.Value.Month && w.C_DATE.Value.Year == dt.Value.Year);
                    }
                    if (flag == "Y")//year
                    {
                        sellItem = _db.SELLITEMS.Where(w => w.C_DATE.Value.Year == dt.Value.Year);
                    }

                    if (sellItem.Count() > 0)
                    {
                        var qry = (from t1 in sellItem
                                   join t2 in _db.PRODUCTS on t1.PRODUCT_ID equals t2.PRODUCT_ID
                                   join t3 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNITSELL && w.STATUS == STATUS.ACTIVE) on t1.UNIT equals t3.MINOR_CODE

                                   select new ReportModel2
                                   {
                                       PRODUCT_CODE = t2.PRODUCT_CODE,
                                       PRODUCT_NAME = t2.PRODUCT_NAME,
                                       Qty = t1.QTY,
                                       UNIT = t3.NAME,
                                       AMOUNT = t1.AMOUNT,
                                       DISCOUNT = t1.DISCOUNT,
                                       SELLPRICE = t1.SELL_PRICE,
                                       //SELL_DATE = t1.C_DATE.ToString(),
                                       SELL_NO = t1.SELLITEM_NO
                                   }).AsQueryable();

                        reprotData = (List<ReportModel2>)qry.AsEnumerable().Select((s, index) => new ReportModel2
                        {
                            PRODUCT_CODE = s.PRODUCT_CODE,
                            PRODUCT_NAME = s.PRODUCT_NAME,
                            Qty = s.Qty,
                            AMOUNT = s.AMOUNT,
                            UNIT = s.UNIT,
                            //NO = (index + 1),
                            DISCOUNT = s.DISCOUNT,
                            SELLPRICE = s.SELLPRICE,
                            //SELL_DATE = s.SELL_DATE,
                            SELL_NO = s.SELL_NO
                        }).ToList();

                        reprotData = reprotData.GroupBy(r => new { r.SELL_NO, r.PRODUCT_CODE })//.GroupBy(p => p.SELL_NO)
                        .Select((s, index) => new ReportModel2
                        {
                            NO = (index + 1),
                            PRODUCT_CODE = s.First().PRODUCT_CODE,
                            PRODUCT_NAME = s.First().PRODUCT_NAME,
                            Qty = s.Sum(a => a.Qty),
                            AMOUNT = s.Sum(a => a.AMOUNT),
                            SELLPRICE = s.First().SELLPRICE,
                            DISCOUNT = s.Sum(a => a.DISCOUNT),
                            //SELL_DATE = s.First().SELL_DATE,
                            SELL_NO = s.First().SELL_NO,
                            UNIT = s.First().UNIT
                        }).OrderBy(a => a.NO).ToList();

                        //reprotData = reprotData
                        //.Select((s, index) => new ReportModel2
                        //{
                        //    NO = (index + 1),
                        //    PRODUCT_CODE = s.PRODUCT_CODE,
                        //    PRODUCT_NAME = s.PRODUCT_NAME,
                        //    Qty = s.Qty,
                        //    AMOUNT = s.AMOUNT,
                        //    SELLPRICE = s.SELLPRICE,
                        //    DISCOUNT = s.DISCOUNT,
                        //    //SELL_DATE = s.First().SELL_DATE,
                        //    SELL_NO = s.SELL_NO,
                        //    UNIT = s.UNIT
                        //}).OrderBy(a => a.NO).ToList();


                        var sumAmount = reprotData.Sum(s => s.AMOUNT);
                        reprotData.First().SUM_TOTAL_AMOUNT = clsFunction.setFormatCurrency(sumAmount);
                        //reprotData

                        scope.Complete();
                    }
                    else
                    {
                        reprotData = new List<ReportModel2>();
                    }

                }

            }
            catch (Exception ex)
            {
                reprotData = new List<ReportModel2>();
                throw new Exception(ex.Message);
            }
            finally
            {
                _db.Dispose();
            }

            return reprotData;
        }
    }
}
