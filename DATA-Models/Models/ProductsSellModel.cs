using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.Models
{
    public class ProductsSellModel
    {
        public int PRODUCT_SELL_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public int INV_ID { get; set; }
        public string UNIT { get; set; }
        public decimal? PRICE { get; set; }
        public string C_BY { get; set; }
        public DateTime? C_DATE { get; set; }
        public string E_BY { get; set; }
        public DateTime? E_DATE { get; set; }
        public decimal? COST { get; set; }
        public decimal? PROFIT { get; set; }
        public string REMARK { get; set; }
    }
}
