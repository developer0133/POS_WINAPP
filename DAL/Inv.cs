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
using ZXing.QrCode.Internal;
using System.Runtime.Remoting.Contexts;
using System.Runtime.InteropServices;
using System.Transactions;
using DATA_Models.Models;

namespace DAL
{
    public class Inv : IInv
    {
        public bool InsertInventory(INV_PRODUCTS InvData)
        {
            bool isSuccess = false;

            try
            {
                using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
                {
                    decimal balance = 0;
                    decimal? old_packBalance = 0;
                    decimal? old_itemBalance = 0;
                    decimal? old_boxBalance = 0;

                    var invObj = _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID == InvData.PRODUCT_ID).FirstOrDefault();
                    ORDER_HISTORY objHist = new ORDER_HISTORY();

                    if (invObj != null)
                    {
                        balance = invObj.BALANCE.HasValue ? invObj.BALANCE.Value : 0;
                        old_packBalance = invObj.PACK_BALANCE.HasValue ? invObj.PACK_BALANCE.Value : 0;
                        old_itemBalance = invObj.ITEM_BALANCE.HasValue ? invObj.ITEM_BALANCE.Value : 0;
                        old_boxBalance = invObj.BOX_BALANCE.HasValue ? invObj.BOX_BALANCE.Value : 0;

                        var delList = _db.PRODUCTS.Where(w => w.PRODUCT_CODE.Contains(".")).ToList();
                        if (delList.Count() > 0)
                        {
                            foreach (var itm in delList)
                            {
                                string[] sp = itm.PRODUCT_CODE.Split('.');
                                if (int.Parse(sp[1]) == invObj.PRODUCT_ID)
                                {
                                    _db.PRODUCTS.Remove(itm);
                                }
                            }
                        }

                        _db.INV_PRODUCTS.Remove(invObj);
                    }

                    var packBalance = InvData.PACK_BALANCE;
                    var itemBalance = InvData.ITEM_BALANCE;
                    var boxBalance = InvData.BOX_BALANCE;

                    //InvData.PACK_BALANCE = InvData.PACK_BALANCE + old_packBalance;
                    //InvData.ITEM_BALANCE = InvData.ITEM_BALANCE + old_itemBalance;
                    //InvData.BOX_BALANCE = InvData.BOX_BALANCE + old_boxBalance;

                    InvData.BALANCE = (InvData.BALANCE + balance);
                    InvData.ORDER_DATE = InvData.ORDER_DATE.Value;
                    InvData.E_BY = InvData.C_BY;
                    InvData.C_DATE = clsFunction.GetDate();
                    InvData.E_DATE = clsFunction.GetDate();
                    InvData.UNIT_BALANCE_TEXT = String.Format("{0}:ลัง {1}:แพ็ค {2}:ชิ้น", InvData.BOX_BALANCE, InvData.PACK_BALANCE, InvData.ITEM_BALANCE);
                    _db.INV_PRODUCTS.Add(InvData);
                    //_db.SaveChanges();

                    var objProdduct = _db.PRODUCTS.Where(w => w.PRODUCT_ID == InvData.PRODUCT_ID).SingleOrDefault();
                    var masterUnit = _db.PARAMETER.Where(w => w.MAJOR_CODE == PARAMETERCODE.UNIT && (w.MINOR_CODE != "1003" && w.MINOR_CODE != "1012")).ToList();
                    var typeProduct = masterUnit.Where(w => w.MINOR_CODE == InvData.UNIT).FirstOrDefault();
                    var cateCode = "x";



                    //////// Insert OrderHistory
                    ///// 
                    objHist = new ORDER_HISTORY();
                    objHist.PRODUCT_ID = InvData.PRODUCT_ID;
                    objHist.ORDER_DATE = InvData.ORDER_DATE;
                    objHist.QTY = InvData.QTY;
                    objHist.UNIT = InvData.UNIT;
                    objHist.AMOUNT = InvData.AMOUNT;
                    objHist.TOTAL_AMOUNT = InvData.TOTAL_AMOUNT;
                    objHist.REMARK = InvData.REMARK;
                    objHist.C_BY = InvData.C_BY;
                    objHist.E_BY = InvData.C_BY;
                    objHist.C_DATE = clsFunction.GetDate();
                    objHist.E_DATE = clsFunction.GetDate();
                    objHist.RETAILPRICE = InvData.RETAILPRICE;
                    objHist.WHOLESALEPRICE = InvData.WHOLESALEPRICE;
                    objHist.AVGCOST = objProdduct.AVGCOST;
                    objHist.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT;
                    objHist.RETAILPROFIT = InvData.RETAILPROFIT;
                    objHist.AVG_PACK = InvData.AVG_PACK;
                    objHist.AVG_ITEM = InvData.AVG_ITEM;

                    _db.ORDER_HISTORY.Add(objHist);


                    if (objProdduct != null)
                    {
                        cateCode = _db.CATEGORY.Where(w => w.CATEGORY_ID == objProdduct.CATEGORY_ID).Select(s => s.CATE_CODE).FirstOrDefault();

                        objProdduct.COSTPRICE = InvData.AMOUNT.Value;
                        objProdduct.QTY = InvData.QTY;
                        objProdduct.UNIT = InvData.UNIT;
                        objProdduct.AVG_ITEM = InvData.AVG_ITEM;
                        objProdduct.AVG_PACK = InvData.AVG_PACK;
                        //objProdduct.RETAILPRICE = inventoryData.RETAILPRICE;
                        objProdduct.WHOLESALEPRICE = InvData.WHOLESALEPRICE;
                        objProdduct.AVGCOST = InvData.AVGCOST;
                        objProdduct.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT.HasValue ? InvData.WHOLESALEPROFIT : 0;
                        objProdduct.RETAILPROFIT = InvData.RETAILPROFIT.HasValue ? InvData.RETAILPROFIT : 0;
                        objProdduct.WHOLESALEPRICE_ITEM = InvData.WHOLESALEPRICE_ITEM.HasValue ? InvData.WHOLESALEPRICE_ITEM : 0;
                        objProdduct.SELLPRICE = InvData.WHOLESALEPRICE.HasValue ? InvData.WHOLESALEPRICE.Value : 0;
                        objProdduct.BOXPRICE = InvData.BOXPRICE.HasValue ? InvData.BOXPRICE.Value : 0;

                        if (typeProduct != null)
                        {
                            if (typeProduct.NAME.Contains("ลัง"))
                            {
                                objProdduct.SELLPRICE = objProdduct.BOXPRICE.Value;
                            }

                            if (cateCode == "17")//rice
                            {
                                objProdduct.PRODUCT_NAME = objProdduct.PRODUCT_NAME + " *[" + typeProduct.NAME + "]";
                                objProdduct.RETAILPRICE = InvData.RETAILPRICE;
                                objProdduct.SELLPRICE = InvData.RETAILPRICE.Value;
                            }
                        }
                      

                        //if (cateCode == "17")//rice
                        //{
                        //    objProdduct.PRODUCT_NAME = objProdduct.PRODUCT_NAME + " *[" + typeProduct.NAME + "]";
                        //    objProdduct.RETAILPRICE = InvData.RETAILPRICE;
                        //    objProdduct.SELLPRICE = InvData.RETAILPRICE.Value;
                        //}

                        _db.Entry(objProdduct).State = EntityState.Modified;

                        if (masterUnit.Select(s => s.MINOR_CODE).Contains(InvData.UNIT))
                        {
                            var objUnit = masterUnit.Where(w => w.MINOR_CODE == InvData.UNIT).FirstOrDefault();
                            //if (objUnit.NAME.Contains("ลัง") || objUnit.NAME.Contains("โหล"))
                            //{
                            int con1Qty = string.IsNullOrEmpty(objUnit.CONDITION1) ? 0 : int.Parse(objUnit.CONDITION1);

                            var flagPCS = false;
                            if (con1Qty == 0)
                            {
                                flagPCS = true;
                            }

                            for (int i = 0; i < 2; i++)
                            {
                                PRODUCTS pd = new PRODUCTS();
                                INV_PRODUCTS inv = new INV_PRODUCTS();
                               

                                decimal? wholeSellPrice = 0;
                                decimal? sellPrice = 0;

                                if (cateCode == "17")//rice
                                {
                                    _db.SaveChanges();
                                    isSuccess = true;
                                    break;
                                }

                                if ((con1Qty > 0 && flagPCS == false) || flagPCS)
                                {
                                    if (flagPCS)
                                    {
                                        i = 1;
                                    }

                                    if (i == 0)
                                    {
                                        pd.PRODUCT_CODE = objProdduct.PRODUCT_CODE + "." + objProdduct.PRODUCT_ID;
                                        pd.PRODUCT_NAME = objProdduct.PRODUCT_NAME + " *แพ็ค [" + con1Qty + "]";
                                        pd.UNIT = "1010";
                                        //wholeSellPrice = (inventoryData.QTY * con1Qty * inventoryData.WHOLESALEPRICE_ITEM);
                                        sellPrice = InvData.WHOLESALEPRICE; //wholeSellPrice;
                                    }
                                    else
                                    {
                                        if (cateCode != "17")//rice
                                        {
                                            pd.PRODUCT_CODE = objProdduct.PRODUCT_CODE + "_pc" + "." + objProdduct.PRODUCT_ID;
                                            pd.PRODUCT_NAME = objProdduct.PRODUCT_NAME + " *PCS";
                                            pd.UNIT = "1003";
                                            sellPrice = InvData.RETAILPRICE.Value;
                                        }
                                    }

                                    pd.AVG_ITEM = objProdduct.AVG_ITEM;
                                    pd.AVG_PACK = objProdduct.AVG_PACK;
                                    pd.RETAILPRICE = InvData.RETAILPRICE;
                                    pd.SELLPRICE = sellPrice.Value;//inventoryData.RETAILPRICE.Value;
                                    pd.WHOLESALEPRICE = wholeSellPrice;
                                    pd.BOXPRICE = InvData.BOXPRICE.HasValue ? InvData.BOXPRICE.Value : 0;

                                    pd.AVGCOST = objProdduct.AVGCOST;
                                    pd.WHOLESALEPROFIT = objProdduct.WHOLESALEPROFIT;
                                    pd.RETAILPROFIT = objProdduct.RETAILPROFIT;
                                    pd.WHOLESALEPRICE_ITEM = objProdduct.WHOLESALEPRICE_ITEM;
                                    pd.CATEGORY_ID = objProdduct.CATEGORY_ID;
                                    pd.PRODUCT_TYPE_ID = objProdduct.PRODUCT_TYPE_ID;
                                    pd.PRODUCT_SIZE_ID = objProdduct.PRODUCT_SIZE_ID;
                                    pd.COSTPRICE = objProdduct.COSTPRICE;


                                    var unit1 = masterUnit.Where(w => w.MINOR_CODE == InvData.UNIT).SingleOrDefault();
                                    if (unit1 != null)
                                    {
                                        int con1 = string.IsNullOrEmpty(unit1.CONDITION1) ? 0 : Convert.ToInt32(unit1.CONDITION1);
                                        int con2 = string.IsNullOrEmpty(unit1.CONDITION2) ? 0 : Convert.ToInt32(unit1.CONDITION2);

                                        var tmpQty = 0;
                                        if (con1 > 0)
                                        {
                                            tmpQty = con1 * InvData.QTY.Value;
                                        }
                                        if (con2 > 0)
                                        {
                                            tmpQty = con2 * InvData.QTY.Value;
                                        }

                                        pd.QTY = tmpQty;
                                    }

                                    pd.STATUS = STATUS.ACTIVE;
                                    pd.C_DATE = clsFunction.GetDate();
                                    pd.E_DATE = clsFunction.GetDate();
                                    pd.C_BY = objProdduct.C_BY;
                                    pd.E_BY = objProdduct.C_BY;

                                    _db.PRODUCTS.Add(pd);
                                    _db.SaveChanges();

                                    inv.PRODUCT_ID = pd.PRODUCT_ID;
                                    inv.ORDER_DATE = InvData.ORDER_DATE;
                                    inv.QTY = InvData.QTY;
                                    inv.PACK_BALANCE = InvData.PACK_BALANCE;
                                    inv.ITEM_BALANCE = InvData.ITEM_BALANCE;
                                    inv.BOX_BALANCE = InvData.BOX_BALANCE;
                                    //inv.BALANCE = (inventoryData.BALANCE + balance);
                                    inv.ORDER_DATE = InvData.ORDER_DATE.Value;

                                    inv.UNIT = pd.UNIT;
                                    inv.E_BY = InvData.C_BY;
                                    inv.C_DATE = clsFunction.GetDate();
                                    inv.E_DATE = clsFunction.GetDate();
                                    inv.RETAILPROFIT = InvData.RETAILPROFIT;
                                    inv.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT;
                                    inv.AVG_PACK = InvData.AVG_PACK;
                                    inv.AVG_ITEM = InvData.AVG_ITEM;
                                    inv.WHOLESALEPRICE_ITEM = InvData.WHOLESALEPRICE_ITEM;
                                    inv.RETAILPRICE = InvData.RETAILPRICE;
                                    inv.WHOLESALEPRICE = InvData.WHOLESALEPRICE_ITEM;

                                    inv.UNIT_BALANCE_TEXT = String.Format("{0}:ลัง {1}:แพ็ค {2}:ชิ้น", InvData.BOX_BALANCE, InvData.PACK_BALANCE, InvData.ITEM_BALANCE);
                                    _db.INV_PRODUCTS.Add(inv);

                                    _db.SaveChanges();
                                    isSuccess = true;

                                    //////// Insert OrderHistory
                                    ///// 
                                    objHist = new ORDER_HISTORY();
                                    objHist.PRODUCT_ID = pd.PRODUCT_ID;
                                    objHist.ORDER_DATE = inv.ORDER_DATE;
                                    objHist.QTY = InvData.QTY;
                                    objHist.UNIT = InvData.UNIT;
                                    objHist.AMOUNT = InvData.AMOUNT;
                                    objHist.TOTAL_AMOUNT = InvData.TOTAL_AMOUNT;
                                    objHist.REMARK = InvData.REMARK;
                                    objHist.C_BY = InvData.C_BY;
                                    objHist.E_BY = InvData.C_BY;
                                    objHist.C_DATE = clsFunction.GetDate();
                                    objHist.E_DATE = clsFunction.GetDate();
                                    objHist.RETAILPRICE = InvData.RETAILPRICE;
                                    objHist.WHOLESALEPRICE = InvData.WHOLESALEPRICE;
                                    objHist.AVGCOST = objProdduct.AVGCOST;
                                    objHist.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT;
                                    objHist.RETAILPROFIT = InvData.RETAILPROFIT;
                                    objHist.AVG_PACK = InvData.AVG_PACK;
                                    objHist.AVG_ITEM = InvData.AVG_ITEM;

                                    _db.ORDER_HISTORY.Add(objHist);

                                    _db.SaveChanges();
                                    //isSuccess = true;

                                    if (flagPCS)
                                    {
                                        break;
                                    }

                                }
                            }
                        }
                    }
                    _db.Dispose();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool InsertInventory2(INV_PRODUCTS InvData)
        {
            bool isSuccess = false;

            try
            {
                using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
                {
                    decimal balance = 0;
                    decimal? old_packBalance = 0;
                    decimal? old_itemBalance = 0;
                    decimal? old_boxBalance = 0;

                    PRODUCTS pd = new PRODUCTS();
                    INV_PRODUCTS inv = new INV_PRODUCTS();
                    ORDER_HISTORY objHist = null;

                    var invObj = _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID2 == InvData.PRODUCT_ID).FirstOrDefault();

                    var invObj2 = _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID2 == InvData.PRODUCT_ID && w.UNIT == InvData.UNIT).ToList();
                    if (invObj2.Count>0)
                    {

                        foreach(var item in invObj2)
                        {
                            old_packBalance += item.PACK_BALANCE.HasValue ? item.PACK_BALANCE.Value : 0;
                            old_itemBalance += item.ITEM_BALANCE.HasValue ? item.ITEM_BALANCE.Value : 0;
                            old_boxBalance += item.BOX_BALANCE.HasValue ? item.BOX_BALANCE.Value : 0;

                            //_db.INV_PRODUCTS.Remove(item);
                        }

                        inv.PACK_BALANCE = InvData.PACK_BALANCE + old_packBalance;
                        inv.ITEM_BALANCE = InvData.ITEM_BALANCE + old_itemBalance;
                        inv.BOX_BALANCE = InvData.BOX_BALANCE + old_boxBalance;

                    }

                    //var objP = _db.PRODUCTS.Where(w => w.PARENT_ID == InvData.PRODUCT_ID && w.UNIT == InvData.UNIT).FirstOrDefault();
                    //if (objP != null)
                    //{
                    //    _db.PRODUCTS.Remove(objP);
                    //}

                    var objProdduct = _db.PRODUCTS.Where(w => w.PRODUCT_ID == InvData.PRODUCT_ID).SingleOrDefault();

                    int running_id = _db.MASTER_RUNNING.Max(x => (int?)x.RUNNING_ID) ?? 0 + 1; //_db.MASTER_RUNNING.Max(s => s.RUNNING_NO);
                    MASTER_RUNNING mstRunning = new MASTER_RUNNING();

                    if (running_id > 1)
                    {
                        running_id++;
                    }

                    mstRunning.RUNNING_NO = running_id;

                    UpdateMasterRunning(mstRunning);

                    string catecode = "1";

                    pd.PRODUCT_CODE = clsFunction.GenFormatCode(mstRunning.RUNNING_NO.Value, catecode, "P");
                    pd.AVG_ITEM = objProdduct.AVG_ITEM;
                    pd.AVG_PACK = objProdduct.AVG_PACK;
                    pd.RETAILPRICE = InvData.RETAILPRICE;
                    pd.SELLPRICE = InvData.RETAILPRICE;
                    pd.WHOLESALEPRICE = 0;
                    pd.BOXPRICE = InvData.BOXPRICE.HasValue ? InvData.BOXPRICE.Value : 0;

                    pd.AVGCOST = objProdduct.AVGCOST;
                    pd.WHOLESALEPROFIT = objProdduct.WHOLESALEPROFIT;
                    pd.RETAILPROFIT = InvData.RETAILPROFIT;//objProdduct.RETAILPROFIT;
                    pd.WHOLESALEPRICE_ITEM = objProdduct.WHOLESALEPRICE_ITEM;
                    pd.CATEGORY_ID = objProdduct.CATEGORY_ID;
                    pd.PRODUCT_TYPE_ID = objProdduct.PRODUCT_TYPE_ID;
                    pd.PRODUCT_SIZE_ID = objProdduct.PRODUCT_SIZE_ID;
                    pd.COSTPRICE = objProdduct.COSTPRICE;

                    pd.STATUS = STATUS.ACTIVE;
                    pd.C_DATE = clsFunction.GetDate();
                    pd.E_DATE = clsFunction.GetDate();
                    pd.C_BY = objProdduct.C_BY;
                    pd.E_BY = objProdduct.C_BY;
                    pd.UNIT = InvData.UNIT;
                    pd.PARENT_ID = InvData.PRODUCT_ID2;// objProdduct.PRODUCT_ID;
                    pd.PRODUCT_NAME = objProdduct.PRODUCT_NAME;

                    _db.PRODUCTS.Add(pd);
                    _db.SaveChanges();

                    inv.PRODUCT_ID = pd.PRODUCT_ID;

                    if (InvData.ORDER_DATE == null)
                    {
                        inv.ORDER_DATE = objProdduct.C_DATE;//invObj.ORDER_DATE;
                    }
                    else
                    {
                        inv.ORDER_DATE = InvData.ORDER_DATE;//invObj.ORDER_DATE;
                    }


                  

                    inv.QTY = InvData.QTY;
                    //inv.PACK_BALANCE = InvData.PACK_BALANCE;
                    //inv.ITEM_BALANCE = InvData.ITEM_BALANCE;
                    //inv.BOX_BALANCE = InvData.BOX_BALANCE;

                    inv.UNIT = InvData.UNIT;
                    inv.E_BY = InvData.C_BY;
                    inv.C_DATE = clsFunction.GetDate();
                    inv.E_DATE = clsFunction.GetDate();
                    inv.RETAILPROFIT = InvData.RETAILPROFIT;
                    inv.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT;//invObj.WHOLESALEPROFIT;
                    inv.AVG_PACK = InvData.AVG_PACK;//invObj.AVG_PACK;
                    inv.AVG_ITEM = InvData.AVG_ITEM;//invObj.AVG_ITEM;
                    inv.WHOLESALEPRICE_ITEM = InvData.WHOLESALEPRICE_ITEM;//invObj.WHOLESALEPRICE_ITEM;
                    inv.RETAILPRICE = InvData.RETAILPRICE;
                    inv.WHOLESALEPRICE = InvData.WHOLESALEPRICE_ITEM;//invObj.WHOLESALEPRICE_ITEM;
                    inv.TOTAL_AMOUNT = InvData.TOTAL_AMOUNT;

                    inv.UNIT_BALANCE_TEXT = String.Format("{0}:ลัง {1}:แพ็ค {2}:ชิ้น", inv.BOX_BALANCE, inv.PACK_BALANCE, inv.ITEM_BALANCE);

                    inv.C_BY = InvData.C_BY;
                    inv.PRODUCT_ID2 = InvData.PRODUCT_ID2;

                    //var invObjBl = _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID2 == InvData.PRODUCT_ID2).FirstOrDefault();
                    //if (invObjBl != null)
                    //{
                    //    inv.PACK_BALANCE = invObjBl.PACK_BALANCE;
                    //    inv.ITEM_BALANCE = invObjBl.ITEM_BALANCE;
                    //    inv.BOX_BALANCE = invObjBl.BOX_BALANCE;
                    //    inv.UNIT_BALANCE_TEXT = invObjBl.UNIT_BALANCE_TEXT;
                    //}

                    _db.INV_PRODUCTS.Add(inv);
                    _db.SaveChanges();

                    ////////// Insert OrderHistory
                    //if (InvData.QTY > 0)
                    //{
                    //    objHist = new ORDER_HISTORY();
                    //    objHist.PRODUCT_ID = InvData.PRODUCT_ID2; //pd.PRODUCT_ID;
                    //    objHist.ORDER_DATE = inv.ORDER_DATE;
                    //    objHist.QTY = InvData.QTY;
                    //    objHist.UNIT = InvData.UNIT;
                    //    objHist.AMOUNT = InvData.AMOUNT;
                    //    objHist.TOTAL_AMOUNT = InvData.TOTAL_AMOUNT;
                    //    objHist.REMARK = InvData.REMARK;
                    //    objHist.C_BY = InvData.C_BY;
                    //    objHist.E_BY = InvData.C_BY;
                    //    objHist.C_DATE = clsFunction.GetDate();
                    //    objHist.E_DATE = clsFunction.GetDate();
                    //    objHist.RETAILPRICE = InvData.RETAILPRICE;
                    //    objHist.WHOLESALEPRICE = InvData.WHOLESALEPRICE;
                    //    objHist.AVGCOST = objProdduct.AVGCOST;
                    //    objHist.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT;
                    //    objHist.RETAILPROFIT = InvData.RETAILPROFIT;
                    //    objHist.AVG_PACK = InvData.AVG_PACK;
                    //    objHist.AVG_ITEM = InvData.AVG_ITEM;

                    //    _db.ORDER_HISTORY.Add(objHist);

                    //    _db.SaveChanges();
                    //}
                   
                    isSuccess = true;

                    _db.Dispose();
                }
            }
            catch (DbUpdateConcurrencyException)
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool UpdateINV2(INV_PRODUCTS InvData, ref string msg)
        {
            bool isSuccess = false;

            using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
            {

                decimal balance = 0;
                decimal? old_packBalance = 0;
                decimal? old_itemBalance = 0;
                decimal? old_boxBalance = 0;

                PRODUCTS pd = new PRODUCTS();
                INV_PRODUCTS inv = new INV_PRODUCTS();
                ORDER_HISTORY objHist = null;

                using (DbContextTransaction transaction = _db.Database.BeginTransaction())
                {
                    try
                    {
                        var invObj2 = _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID2 == InvData.PRODUCT_ID && w.UNIT == InvData.UNIT).SingleOrDefault();

                        var objProdduct = _db.PRODUCTS.Where(w => w.PRODUCT_ID == InvData.PRODUCT_ID).SingleOrDefault();

                        if (invObj2 != null)
                        {
                            

                            if (InvData.ORDER_DATE == null)
                            {
                                invObj2.ORDER_DATE = objProdduct.C_DATE;//invObj.ORDER_DATE;
                            }
                            else
                            {
                                invObj2.ORDER_DATE = InvData.ORDER_DATE;//invObj.ORDER_DATE;
                            }

                            invObj2.QTY = InvData.QTY;

                            invObj2.UNIT = InvData.UNIT;
                            invObj2.E_BY = InvData.C_BY;
                            invObj2.C_DATE = clsFunction.GetDate();
                            invObj2.E_DATE = clsFunction.GetDate();
                            invObj2.RETAILPROFIT = InvData.RETAILPROFIT;
                            invObj2.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT;//invObj.WHOLESALEPROFIT;
                            invObj2.AVG_PACK = InvData.AVG_PACK;//invObj.AVG_PACK;
                            invObj2.AVG_ITEM = InvData.AVG_ITEM;//invObj.AVG_ITEM;
                            invObj2.WHOLESALEPRICE_ITEM = InvData.WHOLESALEPRICE_ITEM;//invObj.WHOLESALEPRICE_ITEM;
                            invObj2.RETAILPRICE = InvData.RETAILPRICE;
                            invObj2.WHOLESALEPRICE = InvData.WHOLESALEPRICE_ITEM;//invObj.WHOLESALEPRICE_ITEM;
                            invObj2.TOTAL_AMOUNT = InvData.TOTAL_AMOUNT;
                            invObj2.AVGCOST = InvData.AVGCOST;



                            invObj2.UNIT_BALANCE_TEXT = String.Format("{0}:ลัง {1}:แพ็ค {2}:ชิ้น", invObj2.BOX_BALANCE, invObj2.PACK_BALANCE, invObj2.ITEM_BALANCE);

                            invObj2.C_BY = InvData.C_BY;
                            invObj2.PRODUCT_ID2 = InvData.PRODUCT_ID2;

                            _db.Entry(invObj2).State = EntityState.Modified;
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

                            string catecode = "1";

                            pd.PRODUCT_CODE = clsFunction.GenFormatCode(mstRunning.RUNNING_NO.Value, catecode, "P");
                            pd.AVG_ITEM = objProdduct.AVG_ITEM;
                            pd.AVG_PACK = objProdduct.AVG_PACK;
                            pd.RETAILPRICE = InvData.RETAILPRICE;
                            pd.SELLPRICE = InvData.RETAILPRICE;
                            pd.WHOLESALEPRICE = 0;
                            pd.BOXPRICE = InvData.BOXPRICE.HasValue ? InvData.BOXPRICE.Value : 0;

                            pd.AVGCOST = objProdduct.AVGCOST;//objProdduct.AVGCOST;
                            pd.WHOLESALEPROFIT = objProdduct.WHOLESALEPROFIT;
                            pd.RETAILPROFIT = InvData.RETAILPROFIT;//objProdduct.RETAILPROFIT;
                            pd.WHOLESALEPRICE_ITEM = objProdduct.WHOLESALEPRICE_ITEM;
                            pd.CATEGORY_ID = objProdduct.CATEGORY_ID;
                            pd.PRODUCT_TYPE_ID = objProdduct.PRODUCT_TYPE_ID;
                            pd.PRODUCT_SIZE_ID = objProdduct.PRODUCT_SIZE_ID;
                            pd.COSTPRICE = InvData.AVGCOST;// objProdduct.COSTPRICE;

                            pd.STATUS = STATUS.ACTIVE;
                            pd.C_DATE = clsFunction.GetDate();
                            pd.E_DATE = clsFunction.GetDate();
                            pd.C_BY = objProdduct.C_BY;
                            pd.E_BY = objProdduct.C_BY;
                            pd.UNIT = InvData.UNIT;
                            pd.PARENT_ID = InvData.PRODUCT_ID2;// objProdduct.PRODUCT_ID;
                            pd.PRODUCT_NAME = objProdduct.PRODUCT_NAME;
                            pd.QTY = InvData.QTY;


                            _db.PRODUCTS.Add(pd);
                            _db.SaveChanges();

                            if (InvData.ORDER_DATE == null)
                            {
                                inv.ORDER_DATE = objProdduct.C_DATE;//invObj.ORDER_DATE;
                            }
                            else
                            {
                                inv.ORDER_DATE = InvData.ORDER_DATE;//invObj.ORDER_DATE;
                            }

                            inv.QTY = InvData.QTY;
                            inv.PACK_BALANCE = InvData.PACK_BALANCE;
                            inv.ITEM_BALANCE = InvData.ITEM_BALANCE;
                            inv.BOX_BALANCE = InvData.BOX_BALANCE;

                            inv.UNIT = InvData.UNIT;
                            inv.E_BY = InvData.C_BY;
                            inv.C_DATE = clsFunction.GetDate();
                            inv.E_DATE = clsFunction.GetDate();
                            inv.RETAILPROFIT = InvData.RETAILPROFIT;
                            inv.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT;//invObj.WHOLESALEPROFIT;
                            inv.AVG_PACK = InvData.AVG_PACK;//invObj.AVG_PACK;
                            inv.AVG_ITEM = InvData.AVG_ITEM;//invObj.AVG_ITEM;
                            inv.WHOLESALEPRICE_ITEM = InvData.WHOLESALEPRICE_ITEM;//invObj.WHOLESALEPRICE_ITEM;
                            inv.RETAILPRICE = InvData.RETAILPRICE;
                            inv.WHOLESALEPRICE = InvData.WHOLESALEPRICE_ITEM;//invObj.WHOLESALEPRICE_ITEM;
                            inv.TOTAL_AMOUNT = InvData.TOTAL_AMOUNT;

                            inv.UNIT_BALANCE_TEXT = String.Format("{0}:ลัง {1}:แพ็ค {2}:ชิ้น", inv.BOX_BALANCE, inv.PACK_BALANCE, inv.ITEM_BALANCE);
                            inv.AVGCOST = InvData.AVGCOST;
                            inv.C_BY = InvData.C_BY;
                            inv.PRODUCT_ID2 = objProdduct.PRODUCT_ID;
                            inv.PRODUCT_ID = pd.PRODUCT_ID;
                            //////// Insert OrderHistory
                            if (InvData.QTY > 0)
                            {
                                objHist = new ORDER_HISTORY();
                                objHist.PRODUCT_ID = InvData.PRODUCT_ID2; //pd.PRODUCT_ID;
                                objHist.ORDER_DATE = InvData.ORDER_DATE;
                                objHist.QTY = InvData.QTY;
                                objHist.UNIT = InvData.UNIT;
                                objHist.AMOUNT = InvData.AMOUNT;
                                objHist.TOTAL_AMOUNT = InvData.TOTAL_AMOUNT;
                                objHist.REMARK = InvData.REMARK;
                                objHist.C_BY = InvData.C_BY;
                                objHist.E_BY = InvData.C_BY;
                                objHist.C_DATE = clsFunction.GetDate();
                                objHist.E_DATE = clsFunction.GetDate();
                                objHist.RETAILPRICE = InvData.RETAILPRICE;
                                objHist.WHOLESALEPRICE = InvData.WHOLESALEPRICE;
                                objHist.AVGCOST = objProdduct.AVGCOST;
                                objHist.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT;
                                objHist.RETAILPROFIT = InvData.RETAILPROFIT;
                                objHist.AVG_PACK = InvData.AVG_PACK;
                                objHist.AVG_ITEM = InvData.AVG_ITEM;

                                _db.ORDER_HISTORY.Add(objHist);

                            }

                            isSuccess = true;

                            _db.INV_PRODUCTS.Add(inv);
                            _db.SaveChanges();
                        }

                        transaction.Commit();
                        _db.Dispose();

                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        transaction.Rollback();
                        msg = ex.Message;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        msg = ex.Message;
                    }
                }
            }
            return isSuccess;
        }

        public bool UpdateInventory(INV_PRODUCTS InvData)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            bool isSuccess = false;

            try
            {

                PRODUCTS objProdduct = new PRODUCTS();
                objProdduct =  _db.PRODUCTS.Where(w => w.PRODUCT_ID == InvData.PRODUCT_ID).SingleOrDefault();

                List<PRODUCTS> pds = new List<PRODUCTS>();

                if (objProdduct.PRODUCT_CODE.Contains(".") || objProdduct.PRODUCT_CODE.Contains("_"))
                {
                    string[] sp = objProdduct.PRODUCT_CODE.Split('.');
                    string id = "";//sp[1];

                    var a1 = objProdduct.PRODUCT_CODE.Contains("_");
                    var a2 = objProdduct.PRODUCT_CODE.Contains(".");

                    if (a1 && a2)
                    {
                        sp = objProdduct.PRODUCT_CODE.Split('_');
                        sp[0] = sp[0];
                        var a3 = objProdduct.PRODUCT_CODE.Split('.');

                    }
                    else
                    {
                        sp = objProdduct.PRODUCT_CODE.Split('.');

                    }

                    var sp1 = sp[0].Trim().ToString();
                    pds = _db.PRODUCTS.Where(w => w.PRODUCT_CODE.Contains(sp1)).ToList();

                }
                else
                {
                    pds = _db.PRODUCTS.Where(w => w.PRODUCT_CODE.Contains(objProdduct.PRODUCT_CODE)).ToList();
                }

                if (pds.Count() > 0)  //(objProdduct != null)
                {
                    foreach (var item in pds)
                    {
                        objProdduct = new PRODUCTS();
                        objProdduct = _db.PRODUCTS.Where(w => w.PRODUCT_ID == item.PRODUCT_ID).SingleOrDefault();

                        var invpd = _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID == item.PRODUCT_ID && w.INV_ID != InvData.INV_ID).SingleOrDefault();
                        var ordHist = _db.ORDER_HISTORY.Where(w => w.PRODUCT_ID == item.PRODUCT_ID).ToList();

                        objProdduct.COSTPRICE = InvData.AMOUNT.HasValue ? InvData.AMOUNT.Value : 0;
                        objProdduct.QTY = InvData.QTY;
                        objProdduct.UNIT = InvData.UNIT;
                        objProdduct.AVG_ITEM = InvData.AVG_ITEM;
                        objProdduct.AVG_PACK = InvData.AVG_PACK;
                        objProdduct.RETAILPRICE = InvData.RETAILPRICE.HasValue ? InvData.RETAILPRICE.Value : 0;
                        objProdduct.WHOLESALEPRICE = InvData.WHOLESALEPRICE.HasValue ? InvData.WHOLESALEPRICE.Value : 0;
                        objProdduct.AVGCOST = InvData.AVGCOST.HasValue ? InvData.AVGCOST.Value : 0;
                        objProdduct.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT.HasValue ? InvData.WHOLESALEPROFIT.Value : 0;
                        objProdduct.RETAILPROFIT = InvData.RETAILPROFIT.HasValue ? InvData.RETAILPROFIT.Value : 0;
                        objProdduct.WHOLESALEPRICE_ITEM = InvData.WHOLESALEPRICE_ITEM.HasValue ? InvData.WHOLESALEPRICE_ITEM.Value : 0;
                        objProdduct.BOXPRICE = InvData.BOXPRICE.HasValue ? InvData.BOXPRICE.Value : 0;

                        objProdduct.SELLPRICE = InvData.WHOLESALEPRICE.HasValue ? InvData.WHOLESALEPRICE.Value : 0;
                     
                        if (invpd != null)
                        {
                            invpd.BOXPRICE = InvData.BOXPRICE;
                            invpd.QTY = InvData.QTY;
                            invpd.AMOUNT = InvData.AMOUNT;
                            invpd.AVGCOST = InvData.AVGCOST;
                            invpd.AVG_ITEM = InvData.AVG_ITEM;
                            invpd.AVG_PACK = InvData.AVG_PACK;
                            invpd.RETAILPRICE = InvData.RETAILPRICE;
                            invpd.RETAILPROFIT = InvData.RETAILPROFIT;
                            invpd.WHOLESALEPRICE = InvData.WHOLESALEPRICE;
                            invpd.WHOLESALEPRICE_ITEM = InvData.WHOLESALEPRICE_ITEM;
                            invpd.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT;
                            invpd.BOX_BALANCE = InvData.BOX_BALANCE;
                            invpd.PACK_BALANCE = InvData.PACK_BALANCE;
                            invpd.ITEM_BALANCE = InvData.ITEM_BALANCE;
                            invpd.ORDER_DATE = InvData.ORDER_DATE;
                            invpd.UNIT = InvData.UNIT;

                            _db.Entry(invpd).State = EntityState.Modified;
                        }
                        _db.Entry(objProdduct).State = EntityState.Modified;

                        if(ordHist !=null)
                        {
                            foreach(var itm in ordHist)
                            {
                                itm.ORDER_DATE = InvData.ORDER_DATE;
                                _db.Entry(itm).State = EntityState.Modified;
                            }   
                        }
                    }
                }
                 _db.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return isSuccess;
        }

        public bool UpdateInventory2(INV_PRODUCTS InvData)
        {
            bool isSuccess = false;

            try
            {
                using (POSSYSTEMEntities _db = new POSSYSTEMEntities())
                {
                    var objProdduct = _db.PRODUCTS.Where(w => w.PRODUCT_ID == InvData.PRODUCT_ID).SingleOrDefault();

                    if (objProdduct != null)
                    {
                        var invpd = _db.INV_PRODUCTS.Where(w => w.INV_ID == InvData.INV_ID).SingleOrDefault();

                        //var ordHist = _db.ORDER_HISTORY.Where(w => w.PRODUCT_ID == item.PRODUCT_ID).ToList();

                        //objProdduct.COSTPRICE = InvData.AMOUNT.HasValue ? InvData.AMOUNT.Value : 0;
                        //objProdduct.QTY = InvData.QTY;
                        objProdduct.UNIT = InvData.UNIT;
                        //objProdduct.AVG_ITEM = InvData.AVG_ITEM;
                        //objProdduct.AVG_PACK = InvData.AVG_PACK;
                        objProdduct.RETAILPRICE = InvData.RETAILPRICE.HasValue ? InvData.RETAILPRICE.Value : 0;
                        //objProdduct.WHOLESALEPRICE = InvData.WHOLESALEPRICE.HasValue ? InvData.WHOLESALEPRICE.Value : 0;
                        //objProdduct.AVGCOST = InvData.AVGCOST.HasValue ? InvData.AVGCOST.Value : 0;
                        //objProdduct.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT.HasValue ? InvData.WHOLESALEPROFIT.Value : 0;
                        objProdduct.RETAILPROFIT = InvData.RETAILPROFIT.HasValue ? InvData.RETAILPROFIT.Value : 0;
                        //objProdduct.WHOLESALEPRICE_ITEM = InvData.WHOLESALEPRICE_ITEM.HasValue ? InvData.WHOLESALEPRICE_ITEM.Value : 0;
                        //objProdduct.BOXPRICE = InvData.BOXPRICE.HasValue ? InvData.BOXPRICE.Value : 0;

                        objProdduct.SELLPRICE = InvData.RETAILPRICE.HasValue ? InvData.RETAILPRICE.Value : 0;

                        objProdduct.REMARK = InvData.REMARK;
                  
                        if (invpd != null)
                        {
                            //invpd.BOXPRICE = InvData.BOXPRICE;
                            invpd.QTY = InvData.QTY;
                            //invpd.AMOUNT = InvData.AMOUNT;
                            invpd.AVGCOST = InvData.AVGCOST;
                            //invpd.AVG_ITEM = InvData.AVG_ITEM;
                            //invpd.AVG_PACK = InvData.AVG_PACK;
                            invpd.RETAILPRICE = InvData.RETAILPRICE;
                            invpd.RETAILPROFIT = InvData.RETAILPROFIT;
                            //invpd.WHOLESALEPRICE = InvData.WHOLESALEPRICE;
                            //invpd.WHOLESALEPRICE_ITEM = InvData.WHOLESALEPRICE_ITEM;
                            //invpd.WHOLESALEPROFIT = InvData.WHOLESALEPROFIT;
                            //invpd.BOX_BALANCE = InvData.BOX_BALANCE;
                            //invpd.PACK_BALANCE = InvData.PACK_BALANCE;
                            //invpd.ITEM_BALANCE = InvData.ITEM_BALANCE;
                            //invpd.ORDER_DATE = InvData.ORDER_DATE;
                            invpd.UNIT = InvData.UNIT;
                            invpd.REMARK = InvData.REMARK;
                            invpd.TOTAL_AMOUNT = InvData.TOTAL_AMOUNT;

                            _db.Entry(invpd).State = EntityState.Modified;
                        }

                        _db.Entry(objProdduct).State = EntityState.Modified;

                        //if (ordHist != null)
                        //{
                        //    foreach (var itm in ordHist)
                        //    {
                        //        itm.ORDER_DATE = InvData.ORDER_DATE;
                        //        _db.Entry(itm).State = EntityState.Modified;
                        //    }
                        //}

                        _db.SaveChanges();

                        _db.Dispose();

                        isSuccess = true;
                    }
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
            }

            return isSuccess;
        }

        public List<INV_PRODUCTS> GetInventory(int id)
        {
            try
            {
                POSSYSTEMEntities _db = new POSSYSTEMEntities();
                return  _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID == id).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string SRTUNIT(int pid)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            string strunit = string.Empty;

            var qry = (from t in _db.INV_PRODUCTS
                       join t2 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.STATUS == STATUS.ACTIVE) on t.UNIT equals t2.MINOR_CODE
                       where t.PRODUCT_ID == pid
                       select new
                       {
                           STRUNIT = t2.NAME
                       }).FirstOrDefault();

            if (qry != null)
            {
                strunit = qry.STRUNIT;
            }
            return strunit;
        }

        public List<InventoryDTO> GetAllInventory(string code)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            List<InventoryDTO> oList = new List<InventoryDTO>();

            try
            {
                var qrydata = (from t in _db.INV_PRODUCTS.Where(w => w.QTY > 0)
                               join t1 in _db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE) on t.PRODUCT_ID equals t1.PRODUCT_ID//.Where(w => w.STATUS == STATUS.ACTIVE && (string.IsNullOrEmpty(code) || w.PRODUCT_CODE == code)) on t.PRODUCT_ID equals t1.PRODUCT_ID
                               join t5 in _db.CATEGORY on t1.CATEGORY_ID equals t5.CATEGORY_ID
                               //join t2 in _db.PARAMETER.Where(w => w.MAJOR_CODE == PARAMETERCODE.PARAMETER_TYPE && w.STATUS == STATUS.ACTIVE) on t1.PRODUCT_TYPE_ID equals t2.MINOR_CODE //into ct
                               join t4 in _db.PARAMETER.Where(w => w.MAJOR_CODE == PARAMETERCODE.UNIT && w.STATUS == STATUS.ACTIVE) on t.UNIT equals t4.MINOR_CODE into c1
                               from t3 in c1.DefaultIfEmpty()
                               where (string.IsNullOrEmpty(code)
                               || t1.PRODUCT_CODE == code || t1.PRODUCT_NAME.Trim().Contains(code.Trim()))

                               select new InventoryDTO
                               {
                                   INV_ID = t.INV_ID,
                                   PRODUCT_ID = t.PRODUCT_ID.Value,
                                   PRODUCT_NAME = t1.PRODUCT_NAME,
                                   PRODUCT_CODE = t1.PRODUCT_CODE,
                                   REMARK = t.REMARK,
                                   QTY = t.QTY,
                                   AMOUNT = t.AMOUNT,
                                   TOTAL_AMOUNT = t.TOTAL_AMOUNT,
                                   ORDER_DATE = t.ORDER_DATE,
                                   UNIT = t.UNIT,
                                   BALANCE = t.BALANCE,
                                   C_BY = t.C_BY,
                                   C_DATE = t.C_DATE,
                                   CONDITION1 = t3.CONDITION1,
                                   CONDITION2 = t3.CONDITION2,

                                   RETAILPRICE = t.RETAILPRICE,
                                   WHOLESALEPRICE = t.WHOLESALEPRICE,
                                   AVGCOST = t.AVGCOST,
                                   WHOLESALEPROFIT = t.WHOLESALEPROFIT,
                                   RETAILPROFIT = t.RETAILPROFIT,
                                   AVG_ITEM = t.AVG_ITEM,
                                   AVG_PACK = t.AVG_PACK,
                                   STR_UNIT = t3.NAME,
                                   WHOLESALEPRICE_ITEM = t1.WHOLESALEPRICE_ITEM,
                                   UNIT_BALANCE_TEXT = t.UNIT_BALANCE_TEXT,
                                   PACK_BALANCE = t.PACK_BALANCE,
                                   ITEM_BALANCE = t.ITEM_BALANCE,
                                   BOX_BALANCE = t.BOX_BALANCE,
                                   CATE_CODE = t5.CATE_CODE,
                                   BOXPRICE = t1.BOXPRICE,
                                   STATUS = t1.STATUS

                               }).AsQueryable();
                oList = (List<InventoryDTO>)qrydata.AsEnumerable().Select(s => new InventoryDTO
                {
                    INV_ID = s.INV_ID,
                    PRODUCT_ID = s.PRODUCT_ID,
                    PRODUCT_CODE = s.PRODUCT_CODE,
                    PRODUCT_NAME = s.PRODUCT_NAME,
                    REMARK = s.REMARK,
                    QTY = s.QTY,
                    UNIT = s.UNIT,
                    BALANCE = s.BALANCE,
                    ORDER_DATE = s.ORDER_DATE,
                    C_BY = s.C_BY,
                    C_DATE = s.C_DATE,
                    AMOUNT = s.AMOUNT,
                    TOTAL_AMOUNT = s.TOTAL_AMOUNT,
                    STR_AMOUNT = string.Format("{0} {1}", s.AMOUNT, ""),
                    STR_TOTAL_AMOUNT = string.Format("{0} {1}", s.TOTAL_AMOUNT, ""),
                    STR_ORDERDATE = s.ORDER_DATE.Value.ToString("dd/MM/yyyy", clsFunction.formatThai),
                    CONDITION1 = s.CONDITION1,
                    CONDITION2 = s.CONDITION2,

                    RETAILPRICE = s.RETAILPRICE,
                    WHOLESALEPRICE = s.WHOLESALEPRICE,
                    AVGCOST = s.AVGCOST,
                    WHOLESALEPROFIT = s.WHOLESALEPROFIT,
                    RETAILPROFIT = s.RETAILPROFIT,
                    AVG_ITEM = s.AVG_ITEM,
                    AVG_PACK = s.AVG_PACK,
                    STR_UNIT = s.STR_UNIT,
                    WHOLESALEPRICE_ITEM = s.WHOLESALEPRICE_ITEM,
                    UNIT_BALANCE_TEXT = s.UNIT_BALANCE_TEXT,
                    PACK_BALANCE = s.PACK_BALANCE,
                    ITEM_BALANCE = s.ITEM_BALANCE,
                    BOX_BALANCE = s.BOX_BALANCE,
                    CATE_CODE = s.CATE_CODE,
                    BOXPRICE = s.BOXPRICE,
                    STATUS = s.STATUS

                }).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return oList;
        }


        public List<InventoryDTO> GetAllInventory2(int? id)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            List<InventoryDTO> oList = new List<InventoryDTO>();

            try
            {
                var qrydata = (from t in _db.INV_PRODUCTS
                               join t1 in _db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE) on t.PRODUCT_ID equals t1.PRODUCT_ID//.Where(w => w.STATUS == STATUS.ACTIVE && (string.IsNullOrEmpty(code) || w.PRODUCT_CODE == code)) on t.PRODUCT_ID equals t1.PRODUCT_ID
                               //join t5 in _db.CATEGORY on t1.CATEGORY_ID equals t5.CATEGORY_ID
                               //join t2 in _db.PARAMETER.Where(w => w.MAJOR_CODE == PARAMETERCODE.PARAMETER_TYPE && w.STATUS == STATUS.ACTIVE) on t1.PRODUCT_TYPE_ID equals t2.MINOR_CODE //into ct
                               join t4 in _db.PARAMETER.Where(w => w.MAJOR_CODE == PARAMETERCODE.UNIT && w.STATUS == STATUS.ACTIVE) on t.UNIT equals t4.MINOR_CODE into c1
                               from t3 in c1.DefaultIfEmpty()
                               where (id.HasValue == false || t1.PRODUCT_ID == id)

                               select new InventoryDTO
                               {
                                   INV_ID = t.INV_ID,
                                   PRODUCT_ID = t.PRODUCT_ID.Value,
                                   PRODUCT_NAME = t1.PRODUCT_NAME,
                                   PRODUCT_CODE = t1.PRODUCT_CODE,
                                   REMARK = t.REMARK,
                                   QTY = t.QTY,
                                   AMOUNT = t.AMOUNT,
                                   TOTAL_AMOUNT = t.TOTAL_AMOUNT,
                                   ORDER_DATE = t.ORDER_DATE,
                                   UNIT = t.UNIT,
                                   BALANCE = t.BALANCE,
                                   C_BY = t.C_BY,
                                   C_DATE = t.C_DATE,
                                   CONDITION1 = t3.CONDITION1,
                                   CONDITION2 = t3.CONDITION2,

                                   RETAILPRICE = t.RETAILPRICE,
                                   WHOLESALEPRICE = t.WHOLESALEPRICE,
                                   AVGCOST = t.AVGCOST,
                                   WHOLESALEPROFIT = t.WHOLESALEPROFIT,
                                   RETAILPROFIT = t.RETAILPROFIT,
                                   AVG_ITEM = t.AVG_ITEM,
                                   AVG_PACK = t.AVG_PACK,
                                   STR_UNIT = t3.NAME,
                                   WHOLESALEPRICE_ITEM = t1.WHOLESALEPRICE_ITEM,
                                   UNIT_BALANCE_TEXT = t.UNIT_BALANCE_TEXT,
                                   PACK_BALANCE = t.PACK_BALANCE,
                                   ITEM_BALANCE = t.ITEM_BALANCE,
                                   BOX_BALANCE = t.BOX_BALANCE,
                                  // CATE_CODE = t5.CATE_CODE,
                                   BOXPRICE = t1.BOXPRICE,
                                   STATUS = t1.STATUS

                               }).AsQueryable();
                oList = (List<InventoryDTO>)qrydata.AsEnumerable().Select(s => new InventoryDTO
                {
                    INV_ID = s.INV_ID,
                    PRODUCT_ID = s.PRODUCT_ID,
                    PRODUCT_CODE = s.PRODUCT_CODE,
                    PRODUCT_NAME = s.PRODUCT_NAME,
                    REMARK = s.REMARK,
                    QTY = s.QTY,
                    UNIT = s.UNIT,
                    BALANCE = s.BALANCE,
                    ORDER_DATE = s.ORDER_DATE,
                    C_BY = s.C_BY,
                    C_DATE = s.C_DATE,
                    AMOUNT = s.AMOUNT,
                    TOTAL_AMOUNT = s.TOTAL_AMOUNT,
                    STR_AMOUNT = string.Format("{0} {1}", s.AMOUNT, ""),
                    STR_TOTAL_AMOUNT = string.Format("{0} {1}", s.TOTAL_AMOUNT, ""),
                    STR_ORDERDATE = s.ORDER_DATE.Value.ToString("dd/MM/yyyy", clsFunction.formatThai),
                    CONDITION1 = s.CONDITION1,
                    CONDITION2 = s.CONDITION2,

                    RETAILPRICE = s.RETAILPRICE,
                    WHOLESALEPRICE = s.WHOLESALEPRICE,
                    AVGCOST = s.AVGCOST,
                    WHOLESALEPROFIT = s.WHOLESALEPROFIT,
                    RETAILPROFIT = s.RETAILPROFIT,
                    AVG_ITEM = s.AVG_ITEM,
                    AVG_PACK = s.AVG_PACK,
                    STR_UNIT = s.STR_UNIT,
                    WHOLESALEPRICE_ITEM = s.WHOLESALEPRICE_ITEM,
                    UNIT_BALANCE_TEXT = s.UNIT_BALANCE_TEXT,
                    PACK_BALANCE = s.PACK_BALANCE,
                    ITEM_BALANCE = s.ITEM_BALANCE,
                    BOX_BALANCE = s.BOX_BALANCE,
                    //CATE_CODE = s.CATE_CODE,
                    BOXPRICE = s.BOXPRICE,
                    STATUS = s.STATUS

                }).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return oList;
        }

        public List<InventoryDTO> GetProductParent(int? id)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            List<InventoryDTO> oList = new List<InventoryDTO>();

            try
            {
                var qrydata = (from t in _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID2 > 0 && w.TOTAL_AMOUNT.HasValue ==false)
                               join t1 in _db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE && w.PARENT_ID > 0) on t.PRODUCT_ID equals t1.PRODUCT_ID//.Where(w => w.STATUS == STATUS.ACTIVE && (string.IsNullOrEmpty(code) || w.PRODUCT_CODE == code)) on t.PRODUCT_ID equals t1.PRODUCT_ID
                               //join t5 in _db.CATEGORY on t1.CATEGORY_ID equals t5.CATEGORY_ID
                               //join t2 in _db.PARAMETER.Where(w => w.MAJOR_CODE == PARAMETERCODE.PARAMETER_TYPE && w.STATUS == STATUS.ACTIVE) on t1.PRODUCT_TYPE_ID equals t2.MINOR_CODE //into ct
                               join t4 in _db.PARAMETER.Where(w => w.MAJOR_CODE == PARAMETERCODE.UNIT && w.STATUS == STATUS.ACTIVE) on t.UNIT equals t4.MINOR_CODE into c1
                               from t3 in c1.DefaultIfEmpty()
                               where (id.HasValue == false || t1.PRODUCT_ID == id)

                               select new InventoryDTO
                               {
                                   INV_ID = t.INV_ID,
                                   PRODUCT_ID = t.PRODUCT_ID.Value,
                                   PRODUCT_NAME = t1.PRODUCT_NAME,
                                   PRODUCT_CODE = t1.PRODUCT_CODE,
                                   REMARK = t.REMARK,
                                   QTY = t.QTY, 
                                   AMOUNT = t.AMOUNT,
                                   TOTAL_AMOUNT = t.TOTAL_AMOUNT,
                                   ORDER_DATE = t.ORDER_DATE,
                                   UNIT = t.UNIT,
                                   BALANCE = t.BALANCE,
                                   C_BY = t.C_BY,
                                   C_DATE = t.C_DATE,
                                   CONDITION1 = t3.CONDITION1,
                                   CONDITION2 = t3.CONDITION2,

                                   RETAILPRICE = t.RETAILPRICE,
                                   WHOLESALEPRICE = t.WHOLESALEPRICE,
                                   AVGCOST = t.AVGCOST,
                                   WHOLESALEPROFIT = t.WHOLESALEPROFIT,
                                   RETAILPROFIT = t.RETAILPROFIT,
                                   AVG_ITEM = t.AVG_ITEM,
                                   AVG_PACK = t.AVG_PACK,
                                   STR_UNIT = t3.NAME,
                                   WHOLESALEPRICE_ITEM = t1.WHOLESALEPRICE_ITEM,
                                   UNIT_BALANCE_TEXT = t.UNIT_BALANCE_TEXT,
                                   PACK_BALANCE = t.PACK_BALANCE,
                                   ITEM_BALANCE = t.ITEM_BALANCE,
                                   BOX_BALANCE = t.BOX_BALANCE,
                                   //CATE_CODE = t5.CATE_CODE,
                                   BOXPRICE = t1.BOXPRICE,
                                   STATUS = t1.STATUS

                               }).AsQueryable();
                oList = (List<InventoryDTO>)qrydata.AsEnumerable().Select(s => new InventoryDTO
                {
                    INV_ID = s.INV_ID,
                    PRODUCT_ID = s.PRODUCT_ID,
                    PRODUCT_CODE = s.PRODUCT_CODE,
                    PRODUCT_NAME = s.PRODUCT_NAME,
                    REMARK = s.REMARK,
                    QTY = s.QTY,
                    UNIT = s.UNIT,
                    BALANCE = s.BALANCE,
                    ORDER_DATE = s.ORDER_DATE,
                    C_BY = s.C_BY,
                    C_DATE = s.C_DATE,
                    AMOUNT = s.AMOUNT,
                    TOTAL_AMOUNT = s.TOTAL_AMOUNT,
                    STR_AMOUNT = string.Format("{0} {1}", s.AMOUNT, ""),
                    STR_TOTAL_AMOUNT = string.Format("{0} {1}", s.TOTAL_AMOUNT, ""),
                    STR_ORDERDATE = s.ORDER_DATE.Value.ToString("dd/MM/yyyy", clsFunction.formatThai),
                    CONDITION1 = s.CONDITION1,
                    CONDITION2 = s.CONDITION2,

                    RETAILPRICE = s.RETAILPRICE,
                    WHOLESALEPRICE = s.WHOLESALEPRICE,
                    AVGCOST = s.AVGCOST,
                    WHOLESALEPROFIT = s.WHOLESALEPROFIT,
                    RETAILPROFIT = s.RETAILPROFIT,
                    AVG_ITEM = s.AVG_ITEM,
                    AVG_PACK = s.AVG_PACK,
                    STR_UNIT = s.STR_UNIT,
                    WHOLESALEPRICE_ITEM = s.WHOLESALEPRICE_ITEM,
                    UNIT_BALANCE_TEXT = s.UNIT_BALANCE_TEXT,
                    PACK_BALANCE = s.PACK_BALANCE,
                    ITEM_BALANCE = s.ITEM_BALANCE,
                    BOX_BALANCE = s.BOX_BALANCE,
                    //CATE_CODE = s.CATE_CODE,
                    BOXPRICE = s.BOXPRICE,
                    STATUS = s.STATUS

                }).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return oList;
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

        public List<DashboardDTO> GetTop5Products(string sdate)
        {
            POSSYSTEMEntities db = new POSSYSTEMEntities();
            List<DashboardDTO> oList = new List<DashboardDTO>();

            try
            {
                DateTime? dt = clsFunction.strDateToDateTime(sdate);


                //  var sellItem = db.SELLITEMS.Where(w => System.Data.Entity.DbFunctions.TruncateTime(w.C_DATE) == dt);

                var sumIncome = db.SELLITEMS.Where(w => w.C_DATE.Value.Month == dt.Value.Month && w.C_DATE.Value.Year == dt.Value.Year).Sum(s => s.AMOUNT);

                var qrydata = (from t in db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE)//&& w.PARENT_ID > 0
                               join t1 in db.SELLITEMS.Where(w => System.Data.Entity.DbFunctions.TruncateTime(w.C_DATE) == dt) on t.PRODUCT_ID equals t1.PRODUCT_ID

                               select new InventoryDTO
                               {
                                   PRODUCT_ID = t1.PRODUCT_ID.Value,
                                   PRODUCT_NAME = t.PRODUCT_NAME,
                                   PRODUCT_CODE = t1.PRODUCT_CODE,
                                   C_DATE = t1.C_DATE,
                                   AMOUNT = t1.AMOUNT,
       
                               }).ToList();

                //var result = qrydata.GroupBy(x => new { x.PRODUCT_ID})
                //        .Select((s, index) => new InventoryDTO
                //        {
                //            PRODUCT_ID = s.First().PRODUCT_ID,
                //            PRODUCT_NAME = s.First().PRODUCT_NAME,
                //        }).OrderByDescending(a => a.PRODUCT_ID).ToList();


                var productList = qrydata.GroupBy(g => new { g.PRODUCT_ID, g.PRODUCT_NAME }).OrderByDescending(a => a.Count()).Select(g => new DashboardDTO
                {
                    PRODUCT_ID = g.Key.PRODUCT_ID,
                    //Count = g.Count(),
                    PRODUCT_NAME = g.Key.PRODUCT_NAME,
                   
                    AMOUNT = g.Sum(a => a.AMOUNT),
                }).Take(5).ToList();

                var sumAmount = productList.Sum(s => s.AMOUNT);
                productList.First().STR_TOTAL_AMOUNT = clsFunction.setFormatCurrency(sumAmount);
                productList.First().STR_TOTAL_INCOME = clsFunction.setFormatCurrency(sumIncome);

                oList = productList;
            }
            catch
            {

            }


            return oList;
        }

        public List<DashboardDTO> GetTop5ProductsLast30()
        {
            POSSYSTEMEntities db = new POSSYSTEMEntities();
            List<DashboardDTO> oList = new List<DashboardDTO>();

            try
            {
                // DateTime? dt = clsFunction.strDateToDateTime();


                //  var sellItem = db.SELLITEMS.Where(w => System.Data.Entity.DbFunctions.TruncateTime(w.C_DATE) == dt);

                var sumIncome = db.SELLITEMS.AsNoTracking().Where(w => w.C_DATE >= DateTime.Now.AddDays(-30)).Sum(s => s.AMOUNT);

                var qrydata = (from t in db.PRODUCTS.Where(w => w.STATUS == STATUS.ACTIVE)//&& w.PARENT_ID > 0
                               join t1 in db.SELLITEMS.Where(w => w.C_DATE >= DateTime.Now.AddDays(-30)) on t.PRODUCT_ID equals t1.PRODUCT_ID

                               select new InventoryDTO
                               {
                                   PRODUCT_ID = t1.PRODUCT_ID.Value,
                                   PRODUCT_NAME = t.PRODUCT_NAME,
                                   PRODUCT_CODE = t1.PRODUCT_CODE,
                                   C_DATE = t1.C_DATE,
                                   AMOUNT = t1.AMOUNT,

                               }).ToList();

                //var result = qrydata.GroupBy(x => new { x.PRODUCT_ID})
                //        .Select((s, index) => new InventoryDTO
                //        {
                //            PRODUCT_ID = s.First().PRODUCT_ID,
                //            PRODUCT_NAME = s.First().PRODUCT_NAME,
                //        }).OrderByDescending(a => a.PRODUCT_ID).ToList();


                var productList = qrydata.GroupBy(g => new { g.PRODUCT_ID, g.PRODUCT_NAME }).OrderByDescending(a => a.Count()).Select(g => new DashboardDTO
                {
                    PRODUCT_ID = g.Key.PRODUCT_ID,
                    //Count = g.Count(),
                    PRODUCT_NAME = g.Key.PRODUCT_NAME,

                    AMOUNT = g.Sum(a => a.AMOUNT),
                }).Take(5).ToList();

                var sumAmount = productList.Sum(s => s.AMOUNT);
                productList.First().STR_TOTAL_AMOUNT = clsFunction.setFormatCurrency(sumAmount);
                productList.First().STR_TOTAL_INCOME = clsFunction.setFormatCurrency(sumIncome);

                oList = productList;
            }
            catch
            {

            }


            return oList;
        }

        public List<DashboardDTO> GetIncome(string sdate)
        {
            POSSYSTEMEntities db = new POSSYSTEMEntities();
            List<DashboardDTO> oList = new List<DashboardDTO>();

            try
            {
                DateTime? dt = clsFunction.strDateToDateTime(sdate);
                var sumIncome = db.SELLITEMS.AsNoTracking().Where(w => w.C_DATE.Value.Month == dt.Value.Month).Sum(s => s.AMOUNT);

                var qry = (from t in db.SELLITEMS
                           where t.C_DATE.Value.Month == dt.Value.Month && t.C_DATE.Value.Year == dt.Value.Year

                           select new DashboardDTO
                           {
                               C_DATE = t.C_DATE,
                               AMOUNT = t.AMOUNT,
                               STR_TOTAL_INCOME=""
                           }).ToList();//.GroupBy(a => DbFunctions.TruncateTime(a.C_DATE)).ToList();

                oList = qry.GroupBy(l => l.C_DATE.Value.Date)
                    .Select(cl => new DashboardDTO
                    {
                        C_DATE = cl.First().C_DATE,
                        AMOUNT = cl.Sum(c => c.AMOUNT),
                        STR_TOTAL_INCOME = clsFunction.setFormatCurrency(sumIncome)
                    }).ToList();


            }
            catch
            {

            }
            return oList;
        }

        public List<DashboardDTO> GetIncomeLast30()
        {
            POSSYSTEMEntities db = new POSSYSTEMEntities();
            List<DashboardDTO> oList = new List<DashboardDTO>();

            try
            {
                var sumIncome = db.SELLITEMS.AsNoTracking().Where(w => w.C_DATE >= DateTime.Now.AddDays(-30));//.Sum(s => s.AMOUNT);

                var qry = (from t in db.SELLITEMS
                           where t.C_DATE >= DateTime.Now.AddDays(-30)

                           select new DashboardDTO
                           {
                               C_DATE = t.C_DATE,
                               AMOUNT = t.AMOUNT,
                               STR_TOTAL_INCOME = ""
                           }).ToList();//.GroupBy(a => DbFunctions.TruncateTime(a.C_DATE)).ToList();

                oList = qry.GroupBy(l => l.C_DATE.Value.Date)
                    .Select(cl => new DashboardDTO
                    {
                        C_DATE = cl.First().C_DATE,
                        AMOUNT = cl.Sum(c => c.AMOUNT),
                        STR_TOTAL_INCOME = ""//clsFunction.setFormatCurrency(sumIncome)
                    }).ToList();


            }
            catch
            {

            }
            return oList;
        }
    }
}
