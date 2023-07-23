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
    public class SellItem : ISellItem
    {
        public string InsertSellItem(List<SELLITEMS> sellitem)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            string retsellNo = string.Empty;

            try
            {
                MASTER_RUNNING mstRunning = new MASTER_RUNNING();

                if (sellitem.Count > 0)
                {
                    string sellno = string.Empty;
                    int? mstrunning = _db.MASTER_RUNNING.Max(s => s.RUNNING_NO);

                    DateTime date = DateTime.UtcNow;
                    var d = date.Day;
                    var m = date.Month;
                    var y = date.Year;

                    if (mstrunning > 0)
                    {
                        mstrunning++;

                        mstRunning.RUNNING_NO = mstrunning.Value;// mstRunning.RUNNING_NO;
                        var bl = _db.Entry(mstRunning).State = EntityState.Added;

                        sellno = clsFunction.GenFormatCode(mstRunning.RUNNING_NO.Value, string.Empty, "SE");//string.Format("{0}{1}{2}{3}{4}", "SE", m, y, d, mstrunning);

                        foreach (var item in sellitem)
                        {
                            var pcs = false;
                            bool nonPackflag = false;

                            string unit1 = string.Empty;
                            string unit2 = string.Empty;
                            int qty = 0;
                            decimal? totalitem = 0;
                            int currId = 0;
                            int totalQty = 0;

                            currId = item.PRODUCT_ID.Value;
                            item.SELLITEM_NO = sellno;
                            item.C_DATE = clsFunction.GetDate();
                            item.E_DATE = clsFunction.GetDate();

                            qty = item.QTY.Value;

                            //product
                            var p = _db.PRODUCTS.Where(w => w.PRODUCT_ID == item.PRODUCT_ID).AsNoTracking().SingleOrDefault();
                            //var cateCode = _db.CATEGORY.Where(w => w.CATEGORY_ID == p.CATEGORY_ID).Select(s => s.CATE_CODE).FirstOrDefault();

                            var currentUnit = _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.MINOR_CODE == item.UNIT).AsNoTracking().SingleOrDefault();

                            if (currentUnit != null)
                            {
                                unit1 = string.IsNullOrEmpty(currentUnit.CONDITION1) ? "0" : currentUnit.CONDITION1;
                                unit2 = string.IsNullOrEmpty(currentUnit.CONDITION2) ? "0" : currentUnit.CONDITION2;

                                totalitem = Decimal.Parse(unit1) * Decimal.Parse(unit2);

                                if (int.Parse(unit1) == 0)
                                {
                                    nonPackflag = true;
                                }

                                if (int.Parse(unit1) > 0 && int.Parse(unit2) > 0)
                                {
                                    totalQty = int.Parse(unit1) * int.Parse(unit2) * qty;
                                }
                                else if (int.Parse(unit1) == 0 && int.Parse(unit2) > 0)
                                {
                                    totalQty = int.Parse(unit2) * qty;
                                }
                            }

                            _db.SELLITEMS.Add(item);

                            //////update inventory
                            ///case 1pc.
                            string[] sp = p.PRODUCT_CODE.Split('.');
                            string id = "";//sp[1];
                            int tmpId = 0;
                            var flagsplitdot = false;

                            var a1 = p.PRODUCT_CODE.Contains("_");
                            var a2 = p.PRODUCT_CODE.Contains(".");

                            ProductsModel fistObj = new ProductsModel();
                            int mstID = 0;

                            if (a1 && a2)
                            {
                                sp = p.PRODUCT_CODE.Split('_');
                                sp[0] = sp[0];
                                var a3 = p.PRODUCT_CODE.Split('.');
                                mstID = int.Parse(a3[1]);
                            }
                            else
                            {
                                sp = p.PRODUCT_CODE.Split('.');
                                flagsplitdot = true;
                            }

                            List<int> ids = new List<int>();

                            string pcode = sp[0];
                            string tmpUnit = string.Empty;

                            var tmpPro = _db.PRODUCTS.Where(w => w.PRODUCT_CODE.Contains(pcode)).AsNoTracking().ToList().OrderBy(x => x.PRODUCT_ID);
                            tmpUnit = tmpPro.Select(s => s.UNIT).FirstOrDefault();

                             var obj = _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID == item.PRODUCT_ID).SingleOrDefault();
                            var packBalance = obj.PACK_BALANCE.HasValue ? obj.PACK_BALANCE.Value : 0;
                            var itemBalance = obj.ITEM_BALANCE.HasValue ? obj.ITEM_BALANCE.Value : 0;
                            var boxBalance = obj.BOX_BALANCE.HasValue ? obj.BOX_BALANCE.Value : 0;

                            var prdUnit = _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.MINOR_CODE == tmpUnit).AsNoTracking().SingleOrDefault();

                            string u1 = "";
                            string u2 = "";
                            u1 = string.IsNullOrEmpty(prdUnit.CONDITION1) ? "0" : prdUnit.CONDITION1;
                            u2 = string.IsNullOrEmpty(prdUnit.CONDITION2) ? "0" : prdUnit.CONDITION2;

                            int calqty = totalQty; //Decimal.Parse(tmp1) * qty;
                            var calsellItem = (itemBalance - calqty);
                            //calpack

                            int qtyPack = 0;
                            int qtyu2 = 0;

                            if (int.Parse(u1) > 0)
                            {
                                qtyPack = int.Parse(u1);

                            }
                            else
                            {
                                qtyPack = int.Parse(u2);
                            }
                            //qtyPack = (qtyPack);
                            qtyu2 = int.Parse(u2);

                            if (currentUnit.MINOR_CODE == "1016" || currentUnit.MINOR_CODE == "1017" || currentUnit.MINOR_CODE == "1018")//rice
                            {
                                calsellItem = (itemBalance - qty);
                                if (calsellItem > itemBalance)
                                {
                                    throw new Exception("จำนวนสินค้าคงเหลือไม่พอ");
                                }
                            }
                            else
                            {
                                //if (calqty > itemBalance)
                                //{
                                //    throw new Exception("จำนวนสินค้าคงเหลือไม่พอ");
                                //}
                            }

                            if (currentUnit.MINOR_CODE == "1016" || currentUnit.MINOR_CODE == "1017" || currentUnit.MINOR_CODE == "1018")//rice
                            {
                                //calsellItem = (itemBalance - qty);
                                obj.ITEM_BALANCE = calsellItem;
                            }
                            else
                            {
                                //itemBalance = (int)calsellItem;
                                obj.ITEM_BALANCE = (int)calsellItem;
                            }

                            if (packBalance > 0)
                            {
                                decimal? calpack_balance = 0;
                                calpack_balance = (calsellItem / qtyPack);//calqty
                                packBalance = (int)calpack_balance;
                                obj.PACK_BALANCE = packBalance;
                            }
                            if (boxBalance > 0)
                            {
                                decimal? box = 0;

                                if (currentUnit.NAME.Contains("ลัง"))
                                {
                                    decimal totalQty1 = 0;
                                    decimal totalQty2 = 0;

                                    if (int.Parse(u1) > 0)
                                    {
                                        totalQty1 = (int.Parse(u1) * qtyu2 * qty);
                                        totalQty2 = itemBalance - totalQty1;
                                        box = (totalQty2 / int.Parse(u1) / qtyu2);
                                        var boxbalance = (int)box;
                                        obj.BOX_BALANCE = boxbalance;
                                    }
                                    else
                                    {
                                        totalQty1 = (qtyu2 * qty);
                                        totalQty2 = itemBalance - totalQty1;
                                        box = (totalQty2 / qtyu2);
                                        var boxbalance = (int)box;
                                        obj.BOX_BALANCE = boxbalance;
                                    }
                                }
                            }

                            foreach (var itmId in tmpPro)//ids
                            {
                                var obj2 = _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID == itmId.PRODUCT_ID).SingleOrDefault();
                                if (obj2 != null)
                                {
                                    //item
                                    itemBalance = (int)calsellItem;
                                    obj2.ITEM_BALANCE = obj.ITEM_BALANCE;
                                    obj2.PACK_BALANCE = obj.PACK_BALANCE;
                                    obj2.BOX_BALANCE = obj.BOX_BALANCE;

                                    obj2.E_BY = sellitem.First().E_BY;
                                    obj2.E_DATE = clsFunction.GetDate();

                                    obj2.UNIT_BALANCE_TEXT = String.Format("{0}:ลัง {1}:แพ็ค {2}:ชิ้น", obj.BOX_BALANCE, packBalance, itemBalance);

                                    _db.SaveChanges();
                                }
                            }

                            obj.E_BY = sellitem.First().E_BY;
                            obj.E_DATE = clsFunction.GetDate();

                            obj.UNIT_BALANCE_TEXT = String.Format("{0}:ลัง {1}:แพ็ค {2}:ชิ้น", obj.BOX_BALANCE, packBalance, itemBalance);
                        }

                        retsellNo = sellno;
                    }

                    //////notification send
                    //var optionBuilder = new DbContextOptionsBuilder<DBContext>();
                    //var conf = config.GetConnectionString(CONNECTIONSTRING_NAME.POS_CONN);
                    //optionBuilder.UseSqlServer(conf);
                    //var context2 = new DBContext(optionBuilder.Options);
                    //notiService = new NotificationService(context2);

                    //var t = Task.Run(() => notiService.CheckInventory(sellitem.Select(s => s.PRODUCT_ID).ToList()));
                    ////t.Wait();

                    //new Thread(() =>
                    //{
                    //    notiService.CheckInventory(sellitem.Select(s => s.PRODUCT_ID).ToList());
                    //}).Start();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _db.Dispose();
            }

            return retsellNo;
        }

        public string InsertSellItem2(List<SELLITEMS> sellitem)
        {
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            string retsellNo = string.Empty;

            try
            {
                MASTER_RUNNING mstRunning = new MASTER_RUNNING();

                if (sellitem.Count > 0)
                {
                    string sellno = string.Empty;
                    int? mstrunning = _db.MASTER_RUNNING.Max(s => s.RUNNING_NO);

                    DateTime date = DateTime.UtcNow;
                    var d = date.Day;
                    var m = date.Month;
                    var y = date.Year;

                    if (mstrunning > 0)
                    {
                        mstrunning++;

                        mstRunning.RUNNING_NO = mstrunning.Value;// mstRunning.RUNNING_NO;
                        var bl = _db.Entry(mstRunning).State = EntityState.Added;

                        sellno = clsFunction.GenFormatCode(mstRunning.RUNNING_NO.Value, string.Empty, "SE");//string.Format("{0}{1}{2}{3}{4}", "SE", m, y, d, mstrunning);

                        foreach (var item in sellitem)
                        {
                            var pcs = false;
                            bool nonPackflag = false;

                            string unit1 = string.Empty;
                            string unit2 = string.Empty;
                            decimal qty = 0;
                            decimal? totalitem = 0;
                            int currId = 0;
                            decimal totalQty = 0;

                            currId = item.PRODUCT_ID.Value;
                            item.SELLITEM_NO = sellno;
                            item.C_DATE = clsFunction.GetDate();
                            item.E_DATE = clsFunction.GetDate();

                            qty = item.QTY.Value;

                            //product
                            var p = _db.PRODUCTS.Where(w => w.PRODUCT_ID == item.PRODUCT_ID).AsNoTracking().SingleOrDefault();
                            //var cateCode = _db.CATEGORY.Where(w => w.CATEGORY_ID == p.CATEGORY_ID).Select(s => s.CATE_CODE).FirstOrDefault();

                            var currentUnit = _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.MINOR_CODE == item.UNIT).AsNoTracking().SingleOrDefault();
                            var obj = _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID == item.PRODUCT_ID).SingleOrDefault();
                            var objBalance = _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID2 == obj.PRODUCT_ID2 && w.QTY > 0).FirstOrDefault();
                            var currentUnit2 = _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.MINOR_CODE == objBalance.UNIT).AsNoTracking().SingleOrDefault();


                            if (currentUnit != null)
                            {
                                unit1 = string.IsNullOrEmpty(currentUnit.CONDITION1) ? "0" : currentUnit.CONDITION1;
                                unit2 = string.IsNullOrEmpty(currentUnit.CONDITION2) ? "0" : currentUnit.CONDITION2;

                                totalitem = Decimal.Parse(unit1) * Decimal.Parse(unit2);

                                if (int.Parse(unit1) == 0)
                                {
                                    nonPackflag = true;
                                }

                                if (int.Parse(unit1) > 0 && int.Parse(unit2) > 0)
                                {
                                    totalQty = int.Parse(unit1) * int.Parse(unit2) * qty;
                                }
                                else if (decimal.Parse(unit1) == 0 && decimal.Parse(unit2) > 0)
                                {
                                    totalQty = decimal.Parse(unit2) * qty;
                                }
                            }

                            _db.SELLITEMS.Add(item);

                            //////update inventory
                            ///case 1pc.
                            //string[] sp = p.PRODUCT_CODE.Split('.');
                            string id = "";//sp[1];
                            int tmpId = 0;
                            var flagsplitdot = false;

                            //var a1 = p.PRODUCT_CODE.Contains("_");
                            //var a2 = p.PRODUCT_CODE.Contains(".");

                            ProductsModel fistObj = new ProductsModel();
                            int mstID = 0;

                            //if (a1 && a2)
                            //{
                            //    sp = p.PRODUCT_CODE.Split('_');
                            //    sp[0] = sp[0];
                            //    var a3 = p.PRODUCT_CODE.Split('.');
                            //    mstID = int.Parse(a3[1]);
                            //}
                            //else
                            //{
                            //    sp = p.PRODUCT_CODE.Split('.');
                            //    flagsplitdot = true;
                            //}

                            List<int> ids = new List<int>();

                            string pcode = p.PRODUCT_CODE; //sp[0];
                            string tmpUnit = string.Empty;

                            //var tmpPro = _db.PRODUCTS.Where(w => w.PRODUCT_CODE.Contains(pcode)).AsNoTracking().ToList().OrderBy(x => x.PRODUCT_ID);
                            // tmpUnit = tmpPro.Select(s => s.UNIT).FirstOrDefault();

                           

                            var packBalance = objBalance.PACK_BALANCE.HasValue ? objBalance.PACK_BALANCE.Value : 0;
                            var itemBalance = objBalance.ITEM_BALANCE.HasValue ? objBalance.ITEM_BALANCE.Value : 0;
                            var boxBalance = objBalance.BOX_BALANCE.HasValue ? objBalance.BOX_BALANCE.Value : 0;

                            //var prdUnit = _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.MINOR_CODE == tmpUnit).AsNoTracking().SingleOrDefault();

                            string u1 = "";
                            string u2 = "";
                            u1 = string.IsNullOrEmpty(currentUnit.CONDITION1) ? "0" : currentUnit.CONDITION1;
                            u2 = string.IsNullOrEmpty(currentUnit.CONDITION2) ? "0" : currentUnit.CONDITION2;

                            decimal calqty = totalQty; //Decimal.Parse(tmp1) * qty;
                            var calsellItem = (itemBalance - calqty);
                            //calpack

                            decimal qtyPack = 0;
                            int qtyu2 = 0;

                            if (int.Parse(u1) > 0)
                            {
                                qtyPack = int.Parse(u1);

                            }
                            else
                            {
                                qtyPack = decimal.Parse(u2);
                            }
                            //qtyPack = (qtyPack);
                            qtyu2 = int.Parse(u2);

                            if (currentUnit.MINOR_CODE == "1016" || currentUnit.MINOR_CODE == "1017" || currentUnit.MINOR_CODE == "1018")//rice
                            {
                                calsellItem = (itemBalance - qty);
                                if (calsellItem > itemBalance)
                                {
                                    throw new Exception("จำนวนสินค้าคงเหลือไม่พอ");
                                }
                            }
                            else
                            {
                                if (calqty > itemBalance)
                                {
                                    throw new Exception("จำนวนสินค้าคงเหลือไม่พอ");
                                }
                            }

                            if (currentUnit.MINOR_CODE == "1016" || currentUnit.MINOR_CODE == "1017" || currentUnit.MINOR_CODE == "1018")//rice
                            {
                                //calsellItem = (itemBalance - qty);
                                objBalance.ITEM_BALANCE = Convert.ToInt32(calsellItem);
                            }
                            else
                            {
                                //itemBalance = (int)calsellItem;
                                objBalance.ITEM_BALANCE = (int)calsellItem;
                            }

                            if (packBalance > 0)
                            {
                                decimal? calpack_balance = 0;
                                calpack_balance = (calsellItem / qtyPack);//calqty
                                packBalance = (int)calpack_balance;
                                objBalance.PACK_BALANCE = packBalance;
                            }
                            if (boxBalance > 0)
                            {
                                decimal? box = 0;

                                if (currentUnit.NAME.Contains("ลัง")|| currentUnit2.NAME.Contains("ลัง"))
                                {
                                    decimal totalQty1 = 0;
                                    decimal totalQty2 = 0;

                                    if (int.Parse(u1) > 0)
                                    {
                                        totalQty1 = (int.Parse(u1) * qtyu2 * qty);
                                        totalQty2 = itemBalance - totalQty1;
                                        box = (totalQty2 / int.Parse(u1) / qtyu2);
                                        var boxbalance = (int)box;
                                        objBalance.BOX_BALANCE = boxbalance;
                                    }
                                    else
                                    {
                                        //totalQty1 = (qtyu2 * qty);
                                        totalQty2 = itemBalance - item.QTY.Value;

                                        u2 = string.IsNullOrEmpty(currentUnit2.CONDITION2) ? "0" : currentUnit2.CONDITION2;
                                        qtyu2 = int.Parse(u2);

                                        box = ((int)calsellItem / qtyu2);
                                        var boxbalance = (int)box;
                                        objBalance.BOX_BALANCE = boxbalance;
                                    }
                                }
                            }

                            //foreach (var itmId in tmpPro)//ids
                            //{
                            //    var obj2 = _db.INV_PRODUCTS.Where(w => w.PRODUCT_ID == itmId.PRODUCT_ID).SingleOrDefault();
                            //    if (obj2 != null)
                            //    {
                            //        //item
                            //        itemBalance = (int)calsellItem;
                            //        obj2.ITEM_BALANCE = obj.ITEM_BALANCE;
                            //        obj2.PACK_BALANCE = obj.PACK_BALANCE;
                            //        obj2.BOX_BALANCE = obj.BOX_BALANCE;

                            //        obj2.E_BY = sellitem.First().E_BY;
                            //        obj2.E_DATE = clsFunction.GetDate();

                            //        obj2.UNIT_BALANCE_TEXT = String.Format("{0}:ลัง {1}:แพ็ค {2}:ชิ้น", obj.BOX_BALANCE, packBalance, itemBalance);

                            //        _db.SaveChanges();
                            //    }
                            //}

                            objBalance.E_BY = sellitem.First().E_BY;
                            objBalance.E_DATE = clsFunction.GetDate();

                            objBalance.UNIT_BALANCE_TEXT = String.Format("{0}:ลัง {1}:แพ็ค {2}:ชิ้น", objBalance.BOX_BALANCE, packBalance, objBalance.ITEM_BALANCE);

                            _db.SaveChanges();
                        }

                        retsellNo = sellno;
                    }

                    //////notification send
                    //var optionBuilder = new DbContextOptionsBuilder<DBContext>();
                    //var conf = config.GetConnectionString(CONNECTIONSTRING_NAME.POS_CONN);
                    //optionBuilder.UseSqlServer(conf);
                    //var context2 = new DBContext(optionBuilder.Options);
                    //notiService = new NotificationService(context2);

                    //var t = Task.Run(() => notiService.CheckInventory(sellitem.Select(s => s.PRODUCT_ID).ToList()));
                    ////t.Wait();

                    //new Thread(() =>
                    //{
                    //    notiService.CheckInventory(sellitem.Select(s => s.PRODUCT_ID).ToList());
                    //}).Start();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _db.Dispose();
            }

            return retsellNo;
        }

        public List<SellHistDTO> GetSellItem(int productid,List<int> parentID)
        {
            List<SellHistDTO> reprotData = null;
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.Required,
                          new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                {

                    var qry = (from t1 in _db.SELLITEMS.Where(w => parentID.Contains(w.PRODUCT_ID.Value))
                                 join t2 in _db.PRODUCTS on t1.PRODUCT_ID equals t2.PRODUCT_ID //.Where(w => w.PARENT_ID == productid) on t1.PRODUCT_ID equals t2.PRODUCT_ID
                                 join t3 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.STATUS == STATUS.ACTIVE) on t2.UNIT equals t3.MINOR_CODE into c1
                                 from t4 in c1.DefaultIfEmpty()
                                 where productid.ToString().Contains(t2.PARENT_ID.ToString())//.ToString().Contains(productid.ToString())
                                 select new //SellsItemDTO
                                 {
                                     PRODUCT_CODE = t1.PRODUCT_CODE,
                                     //PRODUCT_NAME = t2.PRODUCT_NAME,
                                     Qty = t1.QTY,
                                     //UNIT = t1.UNIT,
                                     AMOUNT = t1.AMOUNT,
                                     DISCOUNT = t1.DISCOUNT,
                                     SELL_DATE = t1.C_DATE,
                                     SELLITEM_NO = t1.SELLITEM_NO,
                                     STR_UNIT = t4.NAME
                                 }).AsQueryable();

                    var test = qry.AsEnumerable().Select((s, index) => new
                    {
                        PRODUCT_CODE = s.PRODUCT_CODE,
                        //PRODUCT_NAME = s.PRODUCT_NAME,
                        Qty = s.Qty,
                        AMOUNT = s.AMOUNT,
                        //UNIT = s.UNIT,
                        //SELL_DATE = s.SELL_DATE,
                        DISCOUNT = s.DISCOUNT,
                        SUM_TOTAL_AMOUNT = string.Format("{0} {1}", s.AMOUNT, ""),
                        STR_SELL_DATE = s.SELL_DATE.Value.ToString("dd/MM/yyyy", clsFunction.formatThai),
                        SELLITEM_NO = s.SELLITEM_NO,
                        STR_UNIT = s.STR_UNIT
                    }).ToList();


                    reprotData = test.GroupBy(x => new {x.SELLITEM_NO, x.STR_SELL_DATE, x.PRODUCT_CODE })
                        .Select((s, index) => new SellHistDTO
                        {
                            PRODUCT_CODE = s.First().PRODUCT_CODE,
                            //PRODUCT_NAME = s.First().PRODUCT_NAME,
                            Qty = s.Sum(a => a.Qty),
                            AMOUNT = s.Sum(a => a.AMOUNT),
                            //SELLPRICE = s.First().SELLPRICE,
                            DISCOUNT = s.Sum(a => a.DISCOUNT),
                            STR_SELL_DATE = s.First().STR_SELL_DATE,
                            //UNIT = s.First().UNIT,
                            //SUM_TOTAL_AMOUNT = string.Format("{0} {1}", s.Sum(a => a.AMOUNT), ""),
                            SELLITEM_NO = s.First().SELLITEM_NO,
                            STR_UNIT = s.First().STR_UNIT
                        }).OrderBy(a => a.STR_SELL_DATE).ToList();

                    scope.Complete();
                    _db.Dispose();
                }

                if (reprotData == null)
                {
                    reprotData = new List<SellHistDTO>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return reprotData;
        }


        public List<SellsItemDTO> GetSellItemRpt(int productid)
        {
            List<SellsItemDTO> reprotData = null;
            POSSYSTEMEntities _db = new POSSYSTEMEntities();
            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.Required,
                          new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                {
                    var qry = (from t1 in _db.SELLITEMS.Where(w => w.PRODUCT_ID == productid)
                               join t2 in _db.PRODUCTS on t1.PRODUCT_ID equals t2.PRODUCT_ID
                               join t3 in _db.PARAMETER.Where(w => w.MAJOR_CODE == POSPARAMETER.UNIT && w.STATUS == STATUS.ACTIVE) on t2.UNIT equals t3.MINOR_CODE into c1
                               from t4 in c1.DefaultIfEmpty()
                               select new SellsItemDTO
                               {
                                   PRODUCT_CODE = t1.PRODUCT_CODE,
                                   //PRODUCT_NAME = t2.PRODUCT_NAME,
                                   Qty = t1.QTY,
                                   //UNIT = t1.UNIT,
                                   AMOUNT = t1.AMOUNT,
                                   DISCOUNT = t1.DISCOUNT,
                                   SELL_DATE = t1.C_DATE,
                                   SELLITEM_NO = t1.SELLITEM_NO,
                                   STR_UNIT = t4.NAME
                               }).AsQueryable();

                    reprotData = (List<SellsItemDTO>)qry.AsEnumerable().Select((s, index) => new SellsItemDTO
                    {
                        PRODUCT_CODE = s.PRODUCT_CODE,
                       //PRODUCT_NAME = s.PRODUCT_NAME,
                        Qty = s.Qty,
                        AMOUNT = s.AMOUNT,
                        //UNIT = s.UNIT,
                        SELL_DATE = s.SELL_DATE,
                        DISCOUNT = s.DISCOUNT,
                        //SUM_TOTAL_AMOUNT = string.Format("{0} {1}", s.AMOUNT, ""),
                        STR_SELL_DATE = s.SELL_DATE.Value.ToString("dd/MM/yyyy", clsFunction.formatThai),
                        SELLITEM_NO = s.SELLITEM_NO,
                        STR_UNIT = s.STR_UNIT
                    }).ToList();


                    reprotData = reprotData.GroupBy(x => new { x.STR_SELL_DATE, x.PRODUCT_CODE })
                        .Select((s, index) => new SellsItemDTO
                        {
                            PRODUCT_CODE = s.First().PRODUCT_CODE,
                            PRODUCT_NAME = s.First().PRODUCT_NAME,
                            Qty = s.Sum(a => a.Qty),
                            AMOUNT = s.Sum(a => a.AMOUNT),
                            SELLPRICE = s.First().SELLPRICE,
                            DISCOUNT = s.Sum(a => a.DISCOUNT),
                            STR_SELL_DATE = s.First().STR_SELL_DATE,
                            UNIT = s.First().UNIT,
                            //SUM_TOTAL_AMOUNT = string.Format("{0} {1}", s.Sum(a => a.AMOUNT), ""),
                            SELLITEM_NO = s.First().SELLITEM_NO,
                            STR_UNIT = s.First().STR_UNIT
                        }).OrderBy(a => a.STR_SELL_DATE).ToList();

                    scope.Complete();
                    _db.Dispose();
                }

                if (reprotData == null)
                {
                    reprotData = new List<SellsItemDTO>();
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
