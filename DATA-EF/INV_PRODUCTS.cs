//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class INV_PRODUCTS
    {
        public int INV_ID { get; set; }
        public Nullable<int> PRODUCT_ID { get; set; }
        public Nullable<System.DateTime> ORDER_DATE { get; set; }
        public Nullable<int> QTY { get; set; }
        public Nullable<decimal> BALANCE { get; set; }
        public string UNIT { get; set; }
        public string REMARK { get; set; }
        public string C_BY { get; set; }
        public Nullable<System.DateTime> C_DATE { get; set; }
        public string E_BY { get; set; }
        public Nullable<System.DateTime> E_DATE { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<decimal> TOTAL_AMOUNT { get; set; }
        public Nullable<decimal> RETAILPRICE { get; set; }
        public Nullable<decimal> WHOLESALEPRICE { get; set; }
        public Nullable<decimal> AVGCOST { get; set; }
        public Nullable<decimal> WHOLESALEPROFIT { get; set; }
        public Nullable<decimal> RETAILPROFIT { get; set; }
        public Nullable<decimal> AVG_PACK { get; set; }
        public Nullable<decimal> AVG_ITEM { get; set; }
        public Nullable<decimal> WHOLESALEPRICE_ITEM { get; set; }
        public string UNIT_BALANCE_TEXT { get; set; }
        public Nullable<decimal> PACK_BALANCE { get; set; }
        public Nullable<decimal> ITEM_BALANCE { get; set; }
        public Nullable<decimal> BOX_BALANCE { get; set; }
        public Nullable<decimal> BOXPRICE { get; set; }
        public Nullable<int> PRODUCT_ID2 { get; set; }
    }
}
