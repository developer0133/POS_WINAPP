using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.Models
{
    public class ReportModel
    {
        public int Index { get; set; }
        public string Item { get; set; }
        public int? Qty { get; set; }
        public decimal? Amount { get; set; }
        public int No { get; set; }
        public decimal? Total { get; set; }
        public string Unit { get; set; }
        public int? Discount { get; set; }
        public DateTime? cdate { get; set; }
        public string SellNo { get; set; }
        public string PRODUCT_CODE { get; set; }
        public decimal? SellPrice { get; set; }
    }

    public class ReportResultModel
    {
        public DateTime? cdate { get; set; }
        public string str_cdate { get; set; }
        public string SellNo { get; set; }
        public decimal? Total { get; set; }
        public string SUM_TOTAL_AMOUNT { get; set; }
    }

    public class ReportModel2
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
        public string SELL_DATE { get; set; }
        public string SELL_NO { get; set; }
    }

    public class ReportResult
    {
        public List<ReportModel2> Detail { get; set; }
        public string SUM_TOTAL_AMOUNT { get; set; }
    }

    public class SellsItemSearchResult
    {
        public List<ReportModel> Details { get; set; }
        public List<ReportResultModel> Result { get; set; }
    }
    public class GenReportModel
    {
        public string filename { get; set; }
        public string code { get; set; }
        public string printby { get; set; }
    }
}
