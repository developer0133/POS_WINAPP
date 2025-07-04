using BL;
using DATA_Models.Models;
using Microsoft.Reporting.WinForms;
using POS.Utils;
using POS_Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Reports
{
    public class clsRpt
    {
        public static bool PrintReport(GenReportModel OReport, ref string FileName)
        {
            bool isSuccess = false;
            string saveFile = string.Empty;

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            string genRpt = System.IO.Directory.GetCurrentDirectory();
            genRpt = string.Format("{0}/{1}", genRpt, POS_PATH.GEN_REPORT);
            DAL.Utils.clsFunction.MakePath(genRpt);

            var rptPath = String.Empty;

            var savePath = string.Format("{0}/{1}{2}", POS_PATH.GEN_REPORT, OReport.code, ".pdf");
            string path1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\POS" + "\\";
            string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\POS" + "\\" + rptPath;
            saveFile = path1 + savePath;//Path.Combine(Directory.GetCurrentDirectory(), savePath);

            ReportParameterCollection parameters = new ReportParameterCollection();

            ReportViewer viewer = new ReportViewer();
           

            try
            {
                if (OReport.reportFlag == "SellItem")
                {
                    rptPath = string.Format("{0}/{1}{2}", POS_PATH.REPORTS, REPORT_NAME.SELL_REPORT3, ".rdlc");

                    var rptData = ReportService.SellItemReport(OReport.code);
                    decimal? sumAmount = rptData.Sum(s => decimal.Parse( s.AMOUNT));
                    string strsSumAmount = "";
                    strsSumAmount = sumAmount.HasValue ? string.Format("{0} {1}", Utils.clsFunction.setFormatCurrency(sumAmount), "บาท") : string.Empty;

                    parameters.Add(new ReportParameter("printby", OReport.printby));
                    parameters.Add(new ReportParameter("total", strsSumAmount.ToString()));
                    parameters.Add(new ReportParameter("cdate", Utils.clsFunction.setFormatDateWithTime(rptData.First().CDATE, true).ToString()));
                    parameters.Add(new ReportParameter("date", Utils.clsFunction.setFormatDateWithTime(Utils.clsFunction.GetDate(), true).ToString()));
                    parameters.Add(new ReportParameter("no", OReport.code.ToString()));

                    viewer.ProcessingMode = ProcessingMode.Local;
                    viewer.LocalReport.ReportPath = path;//"D:/Workspace/DotNet/Inventory/POS_WINAPP3/POS_WINAPP/POS/Reports/SellReport.rdlc";
                    viewer.LocalReport.SetParameters(parameters);
                    viewer.LocalReport.DataSources.Add(new ReportDataSource("sell_DS", rptData));


                }
                else if (OReport.reportFlag == "Daily")
                {
                    rptPath = string.Format("{0}/{1}{2}", POS_PATH.REPORTS, REPORT_NAME.DailyRpt, ".rdlc");
                }

                byte[] bytes = viewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

                using (FileStream fs = new FileStream(saveFile, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                if (bytes.Length > 0)
                {
                    ////download
                    //string FileName = @"D:\Workspace\DotNet\Inventory\POS_WINAPP3\POS_WINAPP\POS\GenReports\SE12700253.pdf";
                    //string PDFUrl = @"C:\Users\CUBE\Desktop\test\testtest.pdf";
                    //System.Net.WebClient client = new System.Net.WebClient();
                    //client.DownloadFile(FileName, PDFUrl);
                    //FileInfo PDFFile = new FileInfo(FileName);

                    isSuccess = true;
                    FileName = saveFile;
                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
                clsLog.Info("PrintReport SellItem failed:" + ex.Message);
            }
            return isSuccess;
        }
    }
}
