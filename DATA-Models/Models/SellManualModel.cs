using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.Models
{
    public class SellManualModel
    {
        public string NO { get; set; }
        public string CUSTOMER_NAME { get; set; } = string.Empty;
        public string ADDRESS { get; set; }
        public string PRODUCT_NAME { get; set; }
        public decimal? QTY { get; set; }
        public string UNIT { get; set; }
        public decimal? PRICE { get; set; }
        public decimal? DISCOUNT { get; set; }
        public decimal? TOTAL { get; set; }
    }
}
