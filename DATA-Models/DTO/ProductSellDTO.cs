using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.DTO
{
    public class ProductSellDTO
    {
        public int PRODUCT_SELL_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string PRODUCT_NAME { get; set; }    

        public Nullable<int> INV_ID { get; set; }
        public string UNIT { get; set; }
        public Nullable<decimal> PRICE { get; set; }
        public string C_BY { get; set; }
        public Nullable<System.DateTime> C_DATE { get; set; }
        public string E_BY { get; set; }
        public Nullable<System.DateTime> E_DATE { get; set; }
        public Nullable<decimal> COST { get; set; }
        public Nullable<decimal> PROFIT { get; set; }
        public string REMARK { get; set; }
        public string BARCODE { get; set; }
        public string STATUS { get; set; }
    }
}
