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

        public static List<ReportModel> SellItemReport(string code)
        {
            return _report.SellItemReport(code);
        }
    }
}
