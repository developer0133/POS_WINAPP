using DATA_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IReport
    {
        List<SellReportModel> SellItemReport(string code);
    }
}
