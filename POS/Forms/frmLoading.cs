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

namespace POS.Forms
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
            progressbar.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressbar.Value += 5; //we will increment the value of the progressbar by +2
            progressbar.Text = progressbar.Value.ToString() + "%";
            if (progressbar.Value == 100)
            {
                timer1.Enabled = false;

                var sellNO = frmProduct.sellNo;

                string fileName = string.Empty;
                GenReportModel objRp = new GenReportModel();
                objRp.code = sellNO;
                objRp.printby = "test";

                bool isSuccess = false;

                if (frmProduct.flag == "SellItem")
                {
                    isSuccess = clsFunction.PrintReport(objRp, ref fileName);
                }

                if (isSuccess)
                {
                    System.Diagnostics.Process.Start(fileName);
                    this.Close();
                }
            }
        }
    }
}
