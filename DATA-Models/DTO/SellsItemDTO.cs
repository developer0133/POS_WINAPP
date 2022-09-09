using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.DTO
{
    public class SellsItemDTO
    {
        public string PRODUCT_CODE { get; set; }
        public string PRODUCT_NAME { get; set; }
        public int? Qty { get; set; }
        public decimal? AMOUNT { get; set; }
        public int NO { get; set; }
        public decimal? TOTAL { get; set; }
        public string UNIT { get; set; }
        public decimal? DISCOUNT { get; set; }
        public decimal? SELLPRICE { get; set; }
        public string SUM_TOTAL_AMOUNT { get; set; }
        public string STR_SELL_DATE { get; set; }
        public DateTime? SELL_DATE { get; set; }

        public string SELLITEM_NO { get; set; }
        public string STR_UNIT { get; set; }

        public string UNIT_ID { get; set; }

        public int SELLITEM_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        //public int QTY { get; set; }
        public DateTime? C_DATE { get; set; }
        public string C_BY { get; set; }
        public string E_BY { get; set; }
        public DateTime? E_DATE { get; set; }

        public decimal? SELL_PRICE { get; set; }
    }
}
