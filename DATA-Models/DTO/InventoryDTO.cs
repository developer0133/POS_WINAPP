using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.DTO
{
    public class InventoryDTO
    {
        public int INV_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public string PRODUCT_CODE { get; set; }

        public DateTime? ORDER_DATE { get; set; }
        public decimal? QTY { get; set; }
        public decimal? BALANCE { get; set; }
        public string UNIT { get; set; }
        public string REMARK { get; set; }
        public string C_BY { get; set; }
        public DateTime? C_DATE { get; set; }
        public string E_BY { get; set; }
        public DateTime? E_DATE { get; set; }
        public decimal? AMOUNT { get; set; }
        public decimal? TOTAL_AMOUNT { get; set; }
        public string PRODUCT_NAME { get; set; }

        public string STR_AMOUNT { get; set; }
        public string STR_TOTAL_AMOUNT { get; set; }
        public string STR_ORDERDATE { get; set; }
        public string CONDITION1 { get; set; }
        public string CONDITION2 { get; set; }


        public decimal? AVGCOST { get; set; }
        public decimal? WHOLESALEPRICE { get; set; }
        public decimal? RETAILPRICE { get; set; }
        public decimal? WHOLESALEPROFIT { get; set; }
        public decimal? RETAILPROFIT { get; set; }
        public decimal? AVG_PACK { get; set; }
        public decimal? AVG_ITEM { get; set; }
        public string STR_UNIT { get; set; }
        public decimal? WHOLESALEPRICE_ITEM { get; set; }
        public string UNIT_BALANCE_TEXT { get; set; }

        public int? PACK_BALANCE { get; set; }
        public int? ITEM_BALANCE { get; set; }
        public int? BOX_BALANCE { get; set; }

        public string CATE_CODE { get; set; }
        public decimal? BOXPRICE { get; set; }
        public string STATUS { get; set; }

        
    }
}
