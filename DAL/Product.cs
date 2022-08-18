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

namespace DAL
{
    public class Product : IProduct
    {
        public List<ProductDTO> GetProduct(string code)
        {
            List<ProductDTO> oList = null;
            try
            {
                using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
                {
                    var qrydata = (from t in _db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE)
                                   join t1 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.POSPARAMETER_TYPE && w.STATUS == STATUS.ACTIVE) on t.PRODUCT_TYPE_ID equals t1.MINOR_CODE
                                   join t2 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.POSPARAMETER_SIZE && w.STATUS == STATUS.ACTIVE) on t.PRODUCT_SIZE_ID equals t2.MINOR_CODE
                                   //join t6 in _db.PARAMETER.Where(w => w.MAJOR_CODE == SOCKET.UNIT && w.STATUS == STATUS.ACTIVE) on t.UNIT equals t6.MINOR_CODE
                                   join t3 in _db.CATEGORY on t.CATEGORY_ID equals t3.CATEGORY_ID
                                   join t4 in _db.INV_PRODUCTS on t.PRODUCT_ID equals t4.PRODUCT_ID into ct
                                   from t5 in ct.DefaultIfEmpty()

                                   where (string.IsNullOrEmpty(code) || t.PRODUCT_CODE == code)
                                   select new ProductDTO //ProductsModel
                                   {
                                       PRODUCT_ID = t.PRODUCT_ID,
                                       PRODUCT_CODE = t.PRODUCT_CODE,
                                       PRODUCT_NAME = t.PRODUCT_NAME,
                                       REMARK = t.REMARK,
                                       PRODUCT_TYPE = t1.NAME,
                                       PRODUCT_SIZE = t2.NAME,
                                       //SELLPRICE = t.SELLPRICE,
                                       CATEGORYNAME = t3.CATEGORY_NAME,
                                       STATUS = t.STATUS,
                                       CATEGORY_ID = t.CATEGORY_ID,
                                       PRODUCT_SIZE_ID = t.PRODUCT_SIZE_ID,
                                       PRODUCT_TYPE_ID = t.PRODUCT_TYPE_ID,
                                       UNIT = "",//t5.UNIT,
                                       QTY = t.QTY,//t5.QTY,
                                       BALANCE = "",//t5.UNIT_BALANCE_TEXT,
                                       BARCODE = t.BARCODE,
                                       RETAILPRICE = t.RETAILPRICE,
                                       WHOLESALEPRICE = t.WHOLESALEPRICE,
                                       AVGCOST = t.AVGCOST,
                                       WHOLESALEPROFIT = t.WHOLESALEPROFIT,
                                       RETAILPROFIT = t.RETAILPROFIT,
                                       AVG_ITEM = t.AVG_ITEM,
                                       AVG_PACK = t.AVG_PACK,
                                       WHOLESALEPRICE_ITEM = t.WHOLESALEPRICE_ITEM,
                                       UNIT_ID = t.UNIT,
                                       UNIT_BALANCE_TEXT = "",//t5.UNIT_BALANCE_TEXT,
                                       STRUNIT = "",//t6.NAME
                                       BOXPRICE = t.BOXPRICE
                                   }).AsQueryable();

                    oList = (List<ProductDTO>)qrydata.AsEnumerable().Select(s => new ProductDTO
                    {
                        PRODUCT_ID = s.PRODUCT_ID,
                        PRODUCT_CODE = s.PRODUCT_CODE,
                        PRODUCT_NAME = s.PRODUCT_NAME,
                        REMARK = s.REMARK,
                        PRODUCT_TYPE = s.PRODUCT_TYPE,
                        PRODUCT_SIZE = s.PRODUCT_SIZE,
                        //STRCOSTPRICE = string.Format("{0} {1}", s.COSTPRICE, "บาท"),
                        STRSELLPRICE = string.Format("{0} {1}", s.RETAILPRICE, "บาท"),

                        STRSELLPRICE_WHOLESALE = string.Format("{0} {1}", s.WHOLESALEPRICE_ITEM, "บาท"),
                        SELLPRICE = s.SELLPRICE,
                        CATEGORYNAME = s.CATEGORYNAME,
                        //PROFIT = (s.SELLPRICE - s.COSTPRICE),
                        STATUS = s.STATUS,

                        CATEGORY_ID = s.CATEGORY_ID,
                        PRODUCT_SIZE_ID = s.PRODUCT_SIZE_ID,
                        PRODUCT_TYPE_ID = s.PRODUCT_TYPE_ID,
                        //COSTPRICE = s.COSTPRICE,
                        UNIT = s.UNIT,
                        STR_QTY = s.QTY.ToString(),
                        QTY = s.QTY,
                        BALANCE = s.BALANCE,
                        BARCODE = s.BARCODE,
                        RETAILPRICE = s.RETAILPRICE,
                        WHOLESALEPRICE = s.WHOLESALEPRICE,
                        AVGCOST = s.AVGCOST,
                        WHOLESALEPROFIT = s.WHOLESALEPROFIT,
                        RETAILPROFIT = s.RETAILPROFIT,
                        AVG_ITEM = s.AVG_ITEM,
                        AVG_PACK = s.AVG_PACK,
                        WHOLESALEPRICE_ITEM = s.WHOLESALEPRICE_ITEM,
                        UNIT_ID = s.UNIT_ID,
                        UNIT_BALANCE_TEXT = s.UNIT_BALANCE_TEXT,
                        STRUNIT = s.STRUNIT,
                        BOXPRICE = s.BOXPRICE
                    }).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            if (oList == null)
            {
                oList = new List<ProductDTO>();
            }

            return oList;

        }

        public bool InsertProduct(PRODUCTS product)
        {
            bool isSuccess = false;

            using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
            {
                MasterRunningModel mstRunning = new MasterRunningModel();
                try
                {
                    string pcode = string.Empty;
                    int running_id = _db.MASTER_RUNNING.Max(x => (int?)x.RUNNING_ID) ?? 0 + 1; //_db.MASTER_RUNNING.Max(s => s.RUNNING_NO);

                    var tmpRunning = _db.PRODUCTS.Where(w => w.PRODUCT_NAME.ToLower() == product.PRODUCT_NAME.ToLower() && w.STATUS == STATUS.ACTIVE).FirstOrDefault();
                    if (tmpRunning != null)
                    {
                        throw new Exception("Data exist");
                    }

                    var category =  _db.CATEGORY.Find(product.CATEGORY_ID);
                    string catecode = "1";
    
                    DateTime date = DateTime.UtcNow;
                    var d = date.Day;
                    var m = date.Month;
                    var y = date.Year;


                    if (running_id > 1)
                    {
                        running_id++;
                    }

                    mstRunning.RUNNING_NO = running_id;

                    UpdateMasterRunning(mstRunning); //var tm = mService.UpdateMasterRunning(mstRunning);

                    if (!string.IsNullOrEmpty(category.CATE_CODE))
                    {
                        catecode = category.CATE_CODE;
                    }

                    pcode = clsFunction.GenFormatCode(mstRunning.RUNNING_NO, catecode, "P"); // string.Format("{0}{1}{2}{3}{4}", category.CATE_CODE, d, m, y, mstRunning.RUNNING_NO);
                    product.PRODUCT_CODE = pcode;
                    product.STATUS = STATUS.ACTIVE;
                    product.C_DATE = clsFunction.GetDate();
                    product.E_DATE = clsFunction.GetDate();
                    product.C_BY = product.C_BY;
                    product.E_BY = product.C_BY;

                    _db.PRODUCTS.Add(product);
                     _db.SaveChanges();
                    isSuccess = true;

                    //create barcode
                    if (!string.IsNullOrEmpty(product.BARCODE))
                    {
                        pcode = string.Empty;
                        pcode = product.BARCODE;
                    }
                    string filemame = pcode;
                    clsFunction.GenBarcode(filemame);
                }
                catch (Exception ex)
                {
                    isSuccess = false;
                    throw new Exception(ex.Message);
                }
            }

            return isSuccess;
        }

        private void UpdateMasterRunning(MasterRunningModel masterrunning)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            try
            {
                _db.Entry(masterrunning).State = EntityState.Added;
                //_db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

            }
        }

        public bool UpdateProduct(PRODUCTS product)
        {
            bool isSuccess = false;

            try
            {
                using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
                {
                    product.E_DATE = clsFunction.GetDate();
                    _db.Entry(product).State = EntityState.Modified;

                    if (!string.IsNullOrEmpty(product.BARCODE))
                    {
                        product.PRODUCT_CODE = string.Empty;
                        product.PRODUCT_CODE = product.BARCODE;
                    }

                    _db.SaveChanges();
                    isSuccess = true;
                }
                    
            }
            catch (DbUpdateConcurrencyException ex)
            {
                isSuccess = false;
            }

            return isSuccess;
        }
    }
}
