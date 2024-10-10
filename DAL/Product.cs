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
using ZXing.QrCode.Internal;
using System.Data.Odbc;
using System.Data.Entity.Validation;
using System.Xml.Linq;

namespace DAL
{
    public class Product : IProduct
    {
        public List<ProductDTO> GetProduct(string code, string flag)
        {
            clsLog.Info("GetProduct");

            List<ProductDTO> oList = null;
            try
            {
                using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
                {
                    var qrydata = (from t in _db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE && w.PARENT_ID.HasValue == false)
                                   join t1 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.POSPARAMETER_TYPE && w.STATUS == STATUS.ACTIVE) on t.PRODUCT_TYPE_ID equals t1.MINOR_CODE
                                   join t2 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.POSPARAMETER_SIZE && w.STATUS == STATUS.ACTIVE) on t.PRODUCT_SIZE_ID equals t2.MINOR_CODE
                                   //join t6 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.STATUS == STATUS.ACTIVE) on t.UNIT equals t6.MINOR_CODE
                                   join t3 in _db.CATEGORY on t.CATEGORY_ID equals t3.CATEGORY_ID
                                   //join t4 in _db.INV_PRODUCTS on t.PRODUCT_ID equals t4.PRODUCT_ID into ct
                                   //from t5 in ct.DefaultIfEmpty()

                                   where (string.IsNullOrEmpty(code) || t.PRODUCT_CODE == code) || t.PRODUCT_NAME.Trim().Contains(code.Trim())
                                   select new ProductDTO //ProductsModel
                                   {
                                       PRODUCT_ID = t.PRODUCT_ID,
                                       PRODUCT_CODE = t.PRODUCT_CODE,
                                       PRODUCT_NAME = t.PRODUCT_NAME,
                                       REMARK = t.REMARK,
                                       PRODUCT_TYPE = t1.NAME,
                                       PRODUCT_SIZE = t2.NAME,
                                       SELLPRICE = t.SELLPRICE,
                                       CATEGORYNAME = t3.CATEGORY_NAME,
                                       STATUS = t.STATUS,
                                       CATEGORY_ID = t.CATEGORY_ID,
                                       PRODUCT_SIZE_ID = t.PRODUCT_SIZE_ID,
                                       PRODUCT_TYPE_ID = t.PRODUCT_TYPE_ID,
                                       //UNIT = t5.UNIT,
                                       QTY = t.QTY,//t5.QTY,
                                       //BALANCE = t5.UNIT_BALANCE_TEXT,
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
                                       //UNIT_BALANCE_TEXT = t5.UNIT_BALANCE_TEXT,
                                       //STRUNIT = t6.NAME,
                                       BOXPRICE = t.BOXPRICE,
                                       PARENT_ID = t.PARENT_ID
                                   }).AsQueryable();
                               
                    if (flag == "sell")
                    {
                        qrydata = (from t in _db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE && w.PARENT_ID.HasValue == true)
                                   join t2 in _db.INV_PRODUCTS on t.PRODUCT_ID equals t2.PRODUCT_ID
                                   //join t3 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.POSPARAMETER_TYPE && w.STATUS == STATUS.ACTIVE) on t.PRODUCT_TYPE_ID equals t1.MINOR_CODE
                                   //join t2 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.POSPARAMETER_SIZE && w.STATUS == STATUS.ACTIVE) on t.PRODUCT_SIZE_ID equals t2.MINOR_CODE
                                   join t5 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.STATUS == STATUS.ACTIVE) on t2.UNIT equals t5.MINOR_CODE
                                   //join t3 in _db.CATEGORY on t.CATEGORY_ID equals t3.CATEGORY_ID
                                   //join t4 in _db.INV_PRODUCTS on t.PRODUCT_ID equals t4.PRODUCT_ID into ct
                                   //from t5 in ct.DefaultIfEmpty()

                                   where (string.IsNullOrEmpty(code) || t.PRODUCT_CODE == code) || t.PRODUCT_NAME.Trim().Contains(code.Trim())
                                   select new ProductDTO //ProductsModel
                                   {
                                       PRODUCT_ID = t.PRODUCT_ID,
                                       PRODUCT_CODE = t.PRODUCT_CODE,
                                       PRODUCT_NAME = t.PRODUCT_NAME,
                                       REMARK = t.REMARK,
                                       //PRODUCT_TYPE = t1.NAME,
                                       //PRODUCT_SIZE = t2.NAME,
                                       SELLPRICE = t.SELLPRICE,
                                       //CATEGORYNAME = t3.CATEGORY_NAME,
                                       STATUS = t.STATUS,
                                       CATEGORY_ID = t.CATEGORY_ID,
                                       PRODUCT_SIZE_ID = t.PRODUCT_SIZE_ID,
                                       PRODUCT_TYPE_ID = t.PRODUCT_TYPE_ID,
                                       UNIT = t2.UNIT,
                                       QTY = t.QTY,//t5.QTY,
                                       BALANCE = t2.UNIT_BALANCE_TEXT,
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
                                       UNIT_BALANCE_TEXT = t2.UNIT_BALANCE_TEXT,
                                       //STRUNIT = t6.NAME,
                                       BOXPRICE = t.BOXPRICE,
                                       PARENT_ID = t2.PRODUCT_ID2
                                   }).AsQueryable();
                    }

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
                        //STRUNIT = s.STRUNIT,
                        BOXPRICE = s.BOXPRICE,
                        PARENT_ID = s.PARENT_ID
                    }).ToList();
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //oData.MessageError += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLog.Error("GetProduct:" + ex.Message);
            }
            if (oList == null)
            {
                oList = new List<ProductDTO>();
            }

            return oList;
        }

        public List<ProductDTO> GetProductForSell(string code)
        {
            clsLog.Info("GetProduct");

            List<ProductDTO> oList = null;
            try
            {
                using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
                {
                    var qrydata = (from t in _db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE && w.PARENT_ID.HasValue == false)
                                   join t4 in _db.INV_PRODUCTS on t.PRODUCT_ID equals t4.PRODUCT_ID 
                                   where (t.PRODUCT_CODE == code)
                                   select new ProductDTO //ProductsModel
                                   {
                                       PRODUCT_ID = t.PRODUCT_ID,
                                       PRODUCT_CODE = t.PRODUCT_CODE,
                                       PRODUCT_NAME = t.PRODUCT_NAME,
                                       REMARK = t.REMARK,
                                     
                                       SELLPRICE = t.SELLPRICE,
                                       STATUS = t.STATUS,
                                       CATEGORY_ID = t.CATEGORY_ID,
                                       PRODUCT_SIZE_ID = t.PRODUCT_SIZE_ID,
                                       PRODUCT_TYPE_ID = t.PRODUCT_TYPE_ID,
                                       
                                       QTY = t.QTY,//t5.QTY,
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
                                       UNIT_BALANCE_TEXT = t4.UNIT_BALANCE_TEXT,
                                       BOXPRICE = t.BOXPRICE,
                                       PARENT_ID = t.PARENT_ID
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
                        //STRUNIT = s.STRUNIT,
                        BOXPRICE = s.BOXPRICE,
                        PARENT_ID = s.PARENT_ID
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
               // MasterRunningModel mstRunning = new MasterRunningModel();
                MASTER_RUNNING mstRunning = new MASTER_RUNNING();

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

                    if(!string.IsNullOrEmpty(product.BARCODE))
                    {
                        product.PRODUCT_CODE = product.BARCODE;
                    }
                    else
                    {
                        pcode = clsFunction.GenFormatCode(mstRunning.RUNNING_NO.Value, catecode, "P"); // string.Format("{0}{1}{2}{3}{4}", category.CATE_CODE, d, m, y, mstRunning.RUNNING_NO);
                        product.PRODUCT_CODE = pcode;
                    }
                    
                    product.STATUS = STATUS.ACTIVE;
                    product.C_DATE = clsFunction.GetDate();
                    product.E_DATE = clsFunction.GetDate();
                    product.C_BY = UserModel.USERNAME;
                    product.E_BY = UserModel.USERNAME;

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
                    clsLog.Error("InsertProduct Error:" + ex.Message);
                    throw new Exception(ex.Message);
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

        public bool UpdateProduct(PRODUCTS product)
        {
            bool isSuccess = false;

            try
            {
                POSSYSTEMEntities _db2 = new POSSYSTEMEntities();

                using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
                {
                    product.E_DATE = clsFunction.GetDate();
                    var obj = _db2.PRODUCTS.Where(w => w.PRODUCT_ID == product.PRODUCT_ID).SingleOrDefault();
                    product.COSTPRICE = obj.COSTPRICE;
                    product.SELLPRICE = obj.SELLPRICE;
                    product.C_BY = obj.C_BY;
                    product.C_DATE = obj.C_DATE;
                    product.E_BY = UserModel.USER_CODE;
                    product.E_DATE = clsFunction.GetDate();

                    product.RETAILPRICE = obj.RETAILPRICE;
                    product.WHOLESALEPRICE = obj.WHOLESALEPRICE;
                    product.WHOLESALEPROFIT = obj.WHOLESALEPROFIT;
                    product.RETAILPROFIT = obj.RETAILPROFIT;
                    product.QTY = obj.QTY;
                    product.UNIT = obj.UNIT;
                    product.AVG_PACK = obj.AVG_PACK;

                    product.AVG_ITEM = obj.AVG_ITEM;
                    product.WHOLESALEPRICE_ITEM = obj.WHOLESALEPRICE_ITEM;
                    product.BOXPRICE = obj.BOXPRICE;

                    _db.Entry(product).State = EntityState.Modified;

                    if (!string.IsNullOrEmpty(product.BARCODE))
                    {
                        product.PRODUCT_CODE = product.BARCODE;
                        product.PRODUCT_CODE = product.BARCODE;
                    }

                    _db.SaveChanges();
                    isSuccess = true;

                    _db.Dispose();
                    _db2.Dispose();
                }
                    
            }
            catch (Exception ex)
            {
                clsLog.Error("UpdateProduct Error:" + ex.Message);
                isSuccess = false;
            }

            return isSuccess;
        }

        public List<ProductAutoCompleteDTO> GetProductAutoComplete()
        {
            List<ProductAutoCompleteDTO> list = new List<ProductAutoCompleteDTO>();

            using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
            {
                list = (from t in _db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE && !w.PRODUCT_CODE.Contains(".") && w.PARENT_ID == null).AsNoTracking()
                        select new ProductAutoCompleteDTO
                        {
                            PRODUCT_ID = t.PRODUCT_ID,
                            PRODUCT_NAME = t.PRODUCT_NAME + "-" + t.PRODUCT_CODE,
                            PRODUCT_CODE = t.PRODUCT_CODE,
                        }).ToList();
            }

            return  list;
        }

        public List<ProductAutoCompleteDTO> GetProductAutoComplete2()
        {
            List<ProductAutoCompleteDTO> list = new List<ProductAutoCompleteDTO>();

            using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
            {
                list = (from t in _db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE && !w.PRODUCT_CODE.Contains(".") && w.PARENT_ID > 0).AsNoTracking()
                        select new ProductAutoCompleteDTO
                        {
                            PRODUCT_ID = t.PRODUCT_ID,
                            PRODUCT_NAME = t.PRODUCT_NAME + "-" + t.PRODUCT_CODE,
                            PRODUCT_CODE = t.PRODUCT_CODE,
                        }).ToList();
            }

            return list;
        }

        public List<ProductOutOfStockDTO> GetOutOfStock()
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            List<ProductOutOfStockDTO> oList = null;

            var qrydata = (from t in _db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE)
                           join t1 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.POSPARAMETER_TYPE && w.STATUS == STATUS.ACTIVE) on t.PRODUCT_TYPE_ID equals t1.MINOR_CODE
                           join t2 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.POSPARAMETER_SIZE && w.STATUS == STATUS.ACTIVE) on t.PRODUCT_SIZE_ID equals t2.MINOR_CODE
                           join t3 in _db.CATEGORY on t.CATEGORY_ID equals t3.CATEGORY_ID
                           join t4 in _db.INV_PRODUCTS on t.PRODUCT_ID equals t4.PRODUCT_ID into ct
                           from t5 in ct.DefaultIfEmpty()
                           where t5.BOX_BALANCE == 0 && t5.ITEM_BALANCE == 0 && t5.PACK_BALANCE == 0
                           select new ProductOutOfStockDTO
                           {
                               //PRODUCT_ID = t.PRODUCT_ID,
                               PRODUCT_CODE = t.PRODUCT_CODE,
                               PRODUCT_NAME = t.PRODUCT_NAME,
                               REMARK = t.REMARK,
                               BALANCE = t5.UNIT_BALANCE_TEXT,
                               CATEGORYNAME = t3.CATEGORY_NAME,
                               PRODUCT_TYPE = t1.NAME,
                           }).AsQueryable();

            oList = (List<ProductOutOfStockDTO>)qrydata.AsEnumerable().Select(s => new ProductOutOfStockDTO
            {
                //PRODUCT_ID = s.PRODUCT_ID,
                PRODUCT_CODE = s.PRODUCT_CODE,
                PRODUCT_NAME = s.PRODUCT_NAME,
                REMARK = s.REMARK,
                BALANCE = s.BALANCE,
                CATEGORYNAME = s.CATEGORYNAME,
                PRODUCT_TYPE = s.PRODUCT_TYPE,
            }).ToList();


            if (oList == null)
            {
                oList = new List<ProductOutOfStockDTO>();
            }

            _db.Dispose();
            return oList;
        }

        public PRODUCTS GetProductByCODE(string code)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();

            var obj = _db.PRODUCTS.Where(w => w.PRODUCT_CODE == code).SingleOrDefault();

            _db.Dispose();
            return obj;
        }

        public List<PRODUCTS> GetProductParent(string code)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            int parentId = 0;

            var obj = _db.PRODUCTS.Where(w => w.PRODUCT_CODE == code).SingleOrDefault();

            var obj2 = _db.PRODUCTS.Where(w => w.PARENT_ID == obj.PRODUCT_ID).OrderBy(o => o.PRODUCT_ID).ToList();

            return obj2;
        }

    }
}
