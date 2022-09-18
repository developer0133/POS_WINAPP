using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.DTO
{
    public class OrderHistoryDTO
    {
        public int HIST_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public DateTime? ORDER_DATE { get; set; }
        public decimal? QTY { get; set; }
        public string UNIT { get; set; }
        public decimal? AMOUNT { get; set; }
        public decimal? TOTAL_AMOUNT { get; set; }
        public string REMARK { get; set; }
        public string C_BY { get; set; }
        public DateTime? C_DATE { get; set; }
        public string E_BY { get; set; }
        public DateTime? E_DATE { get; set; }
        public string STR_AMOUNT { get; set; }
        public string STR_TOTAL_AMOUNT { get; set; }
        public string STR_ORDERDATE { get; set; }
        public int No { get; set; }
        public string STR_UNIT { get; set; }

        public decimal? AVGCOST { get; set; }
        public decimal? WHOLESALEPRICE { get; set; }
        public decimal? RETAILPRICE { get; set; }
        public decimal? WHOLESALEPROFIT { get; set; }
        public decimal? RETAILPROFIT { get; set; }
        public decimal? AVG_PACK { get; set; }
        public decimal? AVG_ITEM { get; set; }
    }

    public class OrderHistoryDTO2
    {
        public decimal? QTY { get; set; }
        public string STR_UNIT { get; set; }

        public string STR_AMOUNT { get; set; }
        public string STR_TOTAL_AMOUNT { get; set; }
        public string STR_ORDERDATE { get; set; }
        public decimal? AVG_PACK { get; set; }
        public decimal? AVG_ITEM { get; set; }
        public string REMARK { get; set; }
    }
}
