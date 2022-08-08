using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.Models
{
    public class ProductsModel
    {
        public int PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }

        public decimal COSTPRICE { get; set; }

        public decimal SELLPRICE { get; set; }
        public string PICTURE { get; set; }
        public string REMARK { get; set; }
        public DateTime? ORDER_DATE { get; set; }
        public int CATEGORY_ID { get; set; }
        public string C_BY { get; set; }
        public DateTime? C_DATE { get; set; }
        public string E_BY { get; set; }
        public DateTime? E_DATE { get; set; }
        public string PRODUCT_TYPE_ID { get; set; }
        public string PRODUCT_SIZE_ID { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string STATUS { get; set; }
        public string BARCODE { get; set; }


        public decimal? AVGCOST { get; set; }
        public decimal? WHOLESALEPRICE { get; set; }
        public decimal? RETAILPRICE { get; set; }

        public decimal? WHOLESALEPROFIT { get; set; }
        public decimal? RETAILPROFIT { get; set; }

        public int? QTY { get; set; }
        public string UNIT { get; set; }

        public decimal? AVG_PACK { get; set; }
        public decimal? AVG_ITEM { get; set; }

        public decimal? WHOLESALEPRICE_ITEM { get; set; }

        public decimal? BOXPRICE { get; set; }

    }
}
