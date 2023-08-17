using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.DTO
{
    public class DashboardDTO
    {
        public int PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }    
        public string PRODUCT_CODE { get; set; }
        public decimal? AMOUNT { get; set; }   
        public string STR_TOTAL_AMOUNT { get; set; }
        public string STR_TOTAL_INCOME { get; set; }
        public DateTime? C_DATE { get; set; }

    }
}
