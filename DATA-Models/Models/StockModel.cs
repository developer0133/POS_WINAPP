using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.Models
{
    public class StockModel
    {
        public int STOCK_ID { get; set; }
        public int PRODUCT_ID { get; set;}
        public string UNIT_BALANCE_TEXT { get; set; }
        public string C_BY { get; set; } 
        public DateTime? C_DATE { get; set; }
        public string E_BY { get; set; }
        public DateTime? E_DATE { get; set; }
        public string REMARK { get; set;}
        public string QTY_BALANCE { get; set; }
    }
}
