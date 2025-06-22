using POS.Utils;
using DATA_Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_Utility;
using BL;
using POS.Reports;

namespace POS.Forms
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
            progressbar.Value = 0;
        }

        [Obsolete]
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressbar.Value += 5; //we will increment the value of the progressbar by +2
            progressbar.Text = progressbar.Value.ToString() + "%";
            if (progressbar.Value == 100)
            {
                timer1.Enabled = false;

                var sellNO = PrintModel.SellNo;

                string fileName = string.Empty;
                GenReportModel objRp = new GenReportModel();
                objRp.code = sellNO;
                objRp.printby = UserModel.USERNAME;
                objRp.cusname = PrintModel.Cusname;
                objRp.address = PrintModel.Address;

                bool isSuccess = false;

                if (PrintModel.Flag == "SellItem")
                {
                    objRp.reportFlag = "SellItem";
                    objRp.param = objRp.code;
                    clsLog.Info("PrintReport SellItem:"+ objRp.code);
                    isSuccess = clsFunction.PrintReport(objRp, ref fileName);
                }
                else if (PrintModel.Flag == "Daily")
                {
                    var sp = PrintModel.DateRpt.Split('/');
                    string sp2= sp[0].ToString()+sp[1].ToString() + sp[2].ToString();

                    objRp.reportFlag = "Daily";
                    objRp.code = PrintModel.DateRpt;
                    objRp.param = sp2;
                    clsLog.Info("PrintReport DailyReport:" + PrintModel.DateRpt); 
                    isSuccess = clsFunction.PrintDailyReport(objRp, ref fileName);

                    //var test = ReportService.SellSummaryReport(PrintModel.DateRpt.ToString(), "");
                }
                

                if (isSuccess)
                {
                    System.Diagnostics.Process.Start(fileName);
                }
                this.Close();
            }
        }
    }
}
