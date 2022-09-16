using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DATA_Models.Models;
using DATA_Models.DTO;
using DATA_EF;


namespace BL
{
    public class ReportService
    {
        static IReport _report;

        static ReportService()
        {
            _report = new Report();
        }

        public static List<SellReportModel> SellItemReport(string code)
        {
            return _report.SellItemReport(code);
        }

        public static List<ReportModel2> SellSummaryReport(string sdate, string flag)
        {
            return _report.SellSummaryReport(sdate, flag);
        }
    }
}
