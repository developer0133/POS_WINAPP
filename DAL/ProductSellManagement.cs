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
using DATA_Models.Models;
using System.Transactions;

namespace DAL
{
    public class ProductSellManagement : IProductSellManagement
    {
        public bool ProductManagement(PRODUCTS_SELL PData, ref string msg)
        {
            bool isSuccess = false;

            using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
            {

                decimal balance = 0;
                decimal? old_packBalance = 0;
                decimal? old_itemBalance = 0;
                decimal? old_boxBalance = 0;

                PRODUCTS_SELL pd = new PRODUCTS_SELL();
                INV_PRODUCTS inv = new INV_PRODUCTS();
                ORDER_HISTORY objHist = null;

                using (DbContextTransaction trn = _db.Database.BeginTransaction())
                {
                    try
                    {
                        var pSell = _db.PRODUCTS_SELL.Where(w => w.PRODUCT_SELL_ID == PData.PRODUCT_SELL_ID && w.UNIT == PData.UNIT).SingleOrDefault();
                        var objProdduct = _db.PRODUCTS.Where(w => w.PRODUCT_ID == PData.PRODUCT_ID && w.STATUS == STATUS.ACTIVE).SingleOrDefault();

                        if (pSell != null)
                        {
                            pSell.UNIT = PData.UNIT;
                            pSell.PRICE = PData.PRICE;
                            pSell.COST = PData.COST;
                            pSell.REMARK = PData.REMARK;
                            pSell.PROFIT = PData.PROFIT;
                            pSell.BARCODE = PData.BARCODE;
                            pSell.PRODUCT_ID = PData.PRODUCT_ID;

                            pSell.C_BY = PData.C_BY;
                            pSell.E_BY = PData.E_BY;
                            pSell.C_DATE = PData.C_DATE;
                            pSell.E_DATE = PData.E_DATE;

                            _db.Entry(pSell).State = EntityState.Modified;
                            _db.SaveChanges();

                            isSuccess = true;
                        }
                        else
                        {
                            int running_id = _db.MASTER_RUNNING.Max(x => (int?)x.RUNNING_ID) ?? 0 + 1; //_db.MASTER_RUNNING.Max(s => s.RUNNING_NO);
                            MASTER_RUNNING mstRunning = new MASTER_RUNNING();

                            if (running_id > 1)
                            {
                                running_id++;
                            }
                             
                            mstRunning.RUNNING_NO = running_id;

                            UpdateMasterRunning(mstRunning);
                            pd.PRODUCT_CODE = clsFunction.GenFormatCode(mstRunning.RUNNING_NO.Value, "1", "P");
                            pd.UNIT = PData.UNIT;
                            pd.PRICE = PData.PRICE;
                            pd.COST = PData.COST;
                            pd.PROFIT = PData.PROFIT;
                            pd.C_DATE = clsFunction.GetDate();
                            pd.E_DATE = clsFunction.GetDate();
                            pd.E_BY = PData.E_BY;
                            pd.C_BY = PData.C_BY;
                            pd.REMARK = PData.REMARK;
                            pd.BARCODE = pd.PRODUCT_CODE;
                            pd.PRODUCT_ID = PData.PRODUCT_ID;

                            isSuccess = true;

                            _db.PRODUCTS_SELL.Add(pd);
                            _db.SaveChanges();
                        }

                        trn.Commit();
                        _db.Dispose();

                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        trn.Rollback();
                        msg = ex.Message;
                    }
                    catch (Exception ex)
                    {
                        trn.Rollback();
                        msg = ex.Message;
                    }
                }
            }
            return isSuccess;
        }

        private void UpdateMasterRunning(MASTER_RUNNING masterrunning)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            try
            {
                _db.Entry(masterrunning).State = EntityState.Added;
                _db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {

            }
        }


        public List<ProductSellDTO> GetProductSell(int? id)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            List<ProductSellDTO> oList = new List<ProductSellDTO>();

            try
            {
                var qrydata = (from t in _db.PRODUCTS_SELL
                               join t1 in _db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE) on t.PRODUCT_ID equals t1.PRODUCT_ID//.Where(w => w.STATUS == STATUS.ACTIVE && (string.IsNullOrEmpty(code) || w.PRODUCT_CODE == code)) on t.PRODUCT_ID equals t1.PRODUCT_ID
                               //join t5 in _db.CATEGORY on t1.CATEGORY_ID equals t5.CATEGORY_ID
                               //join t2 in _db.PARAMETER.Where(w => w.MAJOR_CODE == PARAMETERCODE.PARAMETER_TYPE && w.STATUS == STATUS.ACTIVE) on t1.PRODUCT_TYPE_ID equals t2.MINOR_CODE //into ct
                               join t4 in _db.PARAMETER.Where(w => w.MAJOR_CODE == PARAMETERCODE.UNIT && w.STATUS == STATUS.ACTIVE) on t.UNIT equals t4.MINOR_CODE into c1
                               from t3 in c1.DefaultIfEmpty()
                               where (id.HasValue == false || t1.PRODUCT_ID == id)

                               select new ProductSellDTO
                               {
                                   PRODUCT_ID = t.PRODUCT_ID,
                                   PRODUCT_NAME = t1.PRODUCT_NAME,
                                   PRODUCT_CODE = t1.PRODUCT_CODE,
                                   REMARK = t.REMARK,
                                   PRICE = t.PRICE,
                                   UNIT = t.UNIT,
                                   C_BY = t.C_BY,
                                   C_DATE = t.C_DATE,
                                   
                              

                               }).AsQueryable();
                oList = (List<ProductSellDTO>)qrydata.AsEnumerable().Select(s => new ProductSellDTO
                {
                    PRODUCT_ID = s.PRODUCT_ID,
                    PRODUCT_CODE = s.PRODUCT_CODE,
                    PRODUCT_NAME = s.PRODUCT_NAME,
                    REMARK = s.REMARK,
                    UNIT = s.UNIT,
                    C_BY = s.C_BY,
                    C_DATE = s.C_DATE,
                    PRICE = s.PRICE,
                    STATUS = s.STATUS

                }).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return oList;
        }


    }
}
