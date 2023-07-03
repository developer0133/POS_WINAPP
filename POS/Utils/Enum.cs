using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web.Configuration;

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
        public const string SELL_REPORT3 = "SellReport3";
        public const string Report1 = "Report1";
        public const string DailyRpt = "Daily_rpt";
    }
    public sealed class REPORT_PATH_CONFIG
    {
        public REPORT_PATH_CONFIG() { }

        public static readonly string ROOT_PATH = WebConfigurationManager.AppSettings["RootPath"];
        public static readonly string RPT_PATH = WebConfigurationManager.AppSettings["RptPath"];
        public static readonly string GEN_REPORT = WebConfigurationManager.AppSettings["GenReport"];

    }

    public sealed class MESSAGEALERT
    {
        public MESSAGEALERT() { }
        public const string COMPLETED = "บันทึกสำเร็จ";
        public const string DUPLICATE = "ข้อมูลซ้ำ";
        public const string TRYAGAIN = "ลองอีกครั้ง";
        public const string FULLFILL = "ระบุข้อมูล";
    }


}
