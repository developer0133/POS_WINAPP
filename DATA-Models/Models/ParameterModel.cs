using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_Models.Models
{
    public class ParameterModel
    {
        public int PARAMETER_ID { get; set; }
        public string MAJOR_CODE { get; set; }
        public string MINOR_CODE { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string C_BY { get; set; }
        public DateTime? C_DATE { get; set; }
        public string E_BY { get; set; }
        public DateTime? E_DATE { get; set; }
        public string STATUS { get; set; }
        public string CONDITION1 { get; set; }
        public string CONDITION2 { get; set; }
    }
}
