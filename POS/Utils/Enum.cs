using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace POS.Utils
{
    public class Enum
    {
    }

    public sealed class STATUS
    {
        public STATUS() { }
        public const string ACTIVE = "ACTIVE";
        public const string INACTIVE = "INACTIVE";
    }
    public sealed class KEY
    {
        public KEY() { }
        public const string KEY_STRING = "b14ca5898a4e4133bbce2ea2315a1916";//test
    }

    public sealed class POSPARAMETER
    {
        public POSPARAMETER() { }
        public const string POSPARAMETER_SIZE = "SIZE";
        public const string POSPARAMETER_TYPE = "TYPE";
        public const string UNIT = "UNIT";
    }

    public sealed class PARAMETERCODE
    {
        public PARAMETERCODE() { }
        public const string PARAMETER_SIZE = "SIZE";
        public const string PARAMETER_TYPE = "TYPE";
        public const string UNIT = "UNIT";

    }

    public sealed class POS_PATH
    {
        public POS_PATH() { }
        public const string REPORTS = "Reports";
        public const string GEN_REPORT = "GenReports";
    }

    public sealed class REPORT_NAME
    {
        public REPORT_NAME() { }
        public const string SELL_REPORT = "SellReport";
        public const string SELL_REPORT2 = "SellReport2";
        public const string Report1 = "Report1";
        public const string DailyRpt = "Daily_rpt";
    }

 
}
