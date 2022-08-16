using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_Models.Models;
using DATA_Models.DTO;
using DATA_EF;
using DAL.Utils;

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
                                       //CATEGORY_ID = t.CATEGORY_ID,
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
    }
}
