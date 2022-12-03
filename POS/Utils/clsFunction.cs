using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using POS.Utils;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using DATA_Models.Models;
using Microsoft.Reporting.WebForms;
using BL;
using POS_Utility;
using System.Configuration;

namespace POS.Utils
{
    public class clsFunction
    {
        public static DateTime GetDate()
        {
            var dateTime = DateTime.UtcNow;
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone); // convert from utc to local
            return localTime; //DateTime.Now;
        }

        public static string DecryptText(string input)
        {
            var key = KEY.KEY_STRING;

            //var encryptedString = EncryptString(key, "test");
            //var decryptedString = DecryptString(key, encryptedString);


            string result = DecryptString(key, input);

            return result;
        }

        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        public static Exception getInnerException(Exception ex)
        {
            while (ex.InnerException != null) ex = ex.InnerException;
            return ex;
        }

        public static void FormatHeaderDatagrid (DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
        }


        public static string setFormatCurrency(decimal? dDec)
        {
            string strDec = "0.00";
            if (dDec.HasValue)
            {
                strDec = dDec.Value.ToString("#,##0.00");
            }

            return strDec;
        }

        public static System.IFormatProvider formatThai = new System.Globalization.CultureInfo("th-TH");
        public static string setFormatDate(DateTime? Date)
        {
            string strDate = string.Empty;
            if (Date.HasValue)
            {
                strDate = Date.Value.ToString("dd/MM/yyyy");
            }

            return strDate;
        }
        public static string setFormatDateWithTime(DateTime? Date, bool IsThai)
        {
            string strDate = string.Empty;
            if (Date.HasValue)
            {
                if (IsThai)
                    strDate = Date.Value.ToString("dd/MM/yyyy HH:mm:ss", formatThai);
                else
                {
                    strDate = Date.Value.ToString("dd/MM/yyyy HH:mm:ss");

                }
            }

            return strDate;
        }

        public static bool PrintReport(GenReportModel OReport,ref string FileName)
        {
            bool isSuccess = false;
            string saveFile = string.Empty;

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            string genRpt = REPORT_PATH_CONFIG.RPT_PATH;//  ConfigurationSettings.AppSettings["RootPath"];//System.IO.Directory.GetCurrentDirectory();
            genRpt = string.Format("{0}/{1}", genRpt, POS_PATH.GEN_REPORT);
            DAL.Utils.clsFunction.MakePath(genRpt);
            clsLog.Info("make path:" + genRpt);

            var rptPath = REPORT_PATH_CONFIG.RPT_PATH + REPORT_NAME.SELL_REPORT + ".rdlc";// ConfigurationSettings.AppSettings["RptPath"] + REPORT_NAME.SELL_REPORT + ".rdlc";//string.Format("{0}/{1}{2}", POS_PATH.REPORTS, REPORT_NAME.DailyRpt, ".rdlc");
            var savePath = REPORT_PATH_CONFIG.GEN_REPORT + OReport.param.ToString() + ".pdf";//string.Format("{0}/{1}{2}", POS_PATH.GEN_REPORT, OReport.param.ToString(), ".pdf");
            clsLog.Info("genRpt :" + genRpt);
            clsLog.Info("savePath :" + savePath);

            //var rptPath = string.Format("{0}/{1}{2}", POS_PATH.REPORTS, REPORT_NAME.SELL_REPORT, ".rdlc");
            //var savePath = string.Format("{0}/{1}{2}", POS_PATH.GEN_REPORT, OReport.code, ".pdf");
            //clsLog.Info("savePath :" + savePath);

            string path1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\POS" + "\\";
            //string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\POS" + "\\" + rptPath;
           
            saveFile = savePath;//Path.Combine(Directory.GetCurrentDirectory(), savePath);

            var rptData = ReportService.SellItemReport(OReport.code);

            if (rptData.Count > 0)
            {
                decimal? sumAmount = rptData.Sum(s => s.AMOUNT);
                string strsSumAmount = "";
                strsSumAmount = sumAmount.HasValue ? string.Format("{0} {1}", Utils.clsFunction.setFormatCurrency(sumAmount), "บาท") : string.Empty;


                ReportParameterCollection parameters = new ReportParameterCollection();
                parameters.Add(new ReportParameter("printby", OReport.printby));
                parameters.Add(new ReportParameter("total", strsSumAmount.ToString()));
                parameters.Add(new ReportParameter("cdate", Utils.clsFunction.setFormatDateWithTime(rptData.First().CDATE, true).ToString()));
                parameters.Add(new ReportParameter("date", Utils.clsFunction.setFormatDateWithTime(Utils.clsFunction.GetDate(), true).ToString()));
                parameters.Add(new ReportParameter("no", OReport.code.ToString()));

                try
                {

                    ReportViewer viewer = new ReportViewer();
                    viewer.ProcessingMode = ProcessingMode.Local;
                    viewer.LocalReport.ReportPath = rptPath;//"D:/Workspace/DotNet/Inventory/POS_WINAPP3/POS_WINAPP/POS/Reports/SellReport.rdlc";
                    viewer.LocalReport.SetParameters(parameters);
                    viewer.LocalReport.DataSources.Add(new ReportDataSource("sell_DS", rptData));

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
                }
            }
            else
            {
                MessageBox.Show("Report not found", "POS");
            }

            return isSuccess;
        }

        [Obsolete]
        public static bool PrintDailyReport(GenReportModel OReport, ref string FileName)
        {
            bool isSuccess = false;
            string saveFile = string.Empty;

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            string genRpt = REPORT_PATH_CONFIG.ROOT_PATH;// ConfigurationSettings.AppSettings["RootPath"];//System.IO.Directory.GetCurrentDirectory();
            genRpt = string.Format("{0}/{1}", genRpt, POS_PATH.GEN_REPORT);
            DAL.Utils.clsFunction.MakePath(genRpt);
            clsLog.Info("make path:" + genRpt);

            var rptPath = REPORT_PATH_CONFIG.RPT_PATH + REPORT_NAME.DailyRpt + ".rdlc";// ConfigurationSettings.AppSettings["RptPath"] + REPORT_NAME.DailyRpt + ".rdlc";//string.Format("{0}/{1}{2}", POS_PATH.REPORTS, REPORT_NAME.DailyRpt, ".rdlc");
            var savePath = REPORT_PATH_CONFIG.GEN_REPORT + OReport.param.ToString() + ".pdf";//ConfigurationSettings.AppSettings["GenReport"] + OReport.param.ToString()+".pdf";//string.Format("{0}/{1}{2}", POS_PATH.GEN_REPORT, OReport.param.ToString(), ".pdf");
            clsLog.Info("genRpt :" + genRpt);
            clsLog.Info("savePath :" + savePath);

            saveFile = savePath;//path1 + savePath;//Path.Combine(Directory.GetCurrentDirectory(), savePath);

            var rptData = ReportService.SellSummaryReport(OReport.code, "D");
            decimal? sumAmount = rptData.Sum(s => s.AMOUNT);
            string strsSumAmount = "";
            strsSumAmount = sumAmount.HasValue ? string.Format("{0} {1}", Utils.clsFunction.setFormatCurrency(sumAmount), "บาท") : string.Empty;


            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("printby", OReport.printby));
            parameters.Add(new ReportParameter("cdate", OReport.code));
            parameters.Add(new ReportParameter("date", Utils.clsFunction.setFormatDateWithTime(Utils.clsFunction.GetDate(), true).ToString()));
            parameters.Add(new ReportParameter("total", strsSumAmount.ToString()));


            try
            {

                ReportViewer viewer = new ReportViewer();
                viewer.ProcessingMode = ProcessingMode.Local;
                viewer.LocalReport.ReportPath = rptPath;//path;//"D:/Workspace/DotNet/Inventory/POS_WINAPP3/POS_WINAPP/POS/Reports/SellReport.rdlc";
                viewer.LocalReport.SetParameters(parameters);
                viewer.LocalReport.DataSources.Add(new ReportDataSource("Daily_DS", rptData));

                byte[] bytes = viewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

                using (FileStream fs = new FileStream(saveFile, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                if (bytes.Length > 0)
                {
                    isSuccess = true;
                    FileName = saveFile;
                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }

            return isSuccess;
        }

    }
}
