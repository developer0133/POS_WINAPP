using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_Models.Models;
using DAL;
using BL;
using POS.Utils;
using DATA_EF;
using DATA_Models.DTO;

namespace POS.Forms
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var tmpdate = rptDate.Value.ToShortDateString();
            var data = ReportService.SellSummaryReport(tmpdate, "");
            dgvReport.DataSource = data;

            if (data.Count() > 0)
                lblSum.Text = string.Format("{0} {1} บาท", "รวมทั้งสิน", data[0].SUM_TOTAL_AMOUNT.ToString());

            dgvReport.Columns[0].HeaderText = "NO.";
            dgvReport.Columns[1].HeaderText = "เลขที่การขาย";
            dgvReport.Columns[2].HeaderText = "รหัสสินค้า";
            dgvReport.Columns[3].HeaderText = "ชื่อสินค้า";
            dgvReport.Columns[4].HeaderText = "จำนวน";
            dgvReport.Columns[5].HeaderText = "หน่วย";
            dgvReport.Columns[6].HeaderText = "ราคา(บาท)";
            dgvReport.Columns[7].HeaderText = "ส่วนลด(บาท)";
            //dgvReport.Columns[8].HeaderText = "รวม(บาท)";

            dgvReport.Columns[0].Name = "NO";
            dgvReport.Columns[1].Name = "SELL_NO";
            dgvReport.Columns[2].Name = "PRODUCT_CODE";
            dgvReport.Columns[3].Name = "PRODUCT_NAME";
            dgvReport.Columns[4].Name = "Qty";
            dgvReport.Columns[5].Name = "UNIT";
            dgvReport.Columns[6].Name = "SELLPRICE";
            dgvReport.Columns[7].Name = "DISCOUNT";
            dgvReport.Columns[8].Name = "AMOUNT";

            dgvReport.Columns[0].DataPropertyName = "NO";
            dgvReport.Columns[1].DataPropertyName = "SELL_NO";
            dgvReport.Columns[2].DataPropertyName = "PRODUCT_CODE";
            dgvReport.Columns[3].DataPropertyName = "PRODUCT_NAME";
            dgvReport.Columns[4].DataPropertyName = "Qty";
            dgvReport.Columns[5].DataPropertyName = "UNIT";
            dgvReport.Columns[6].DataPropertyName = "SELLPRICE";
            dgvReport.Columns[7].DataPropertyName = "DISCOUNT";
            dgvReport.Columns[8].DataPropertyName = "AMOUNT";

            dgvReport.Columns[1].Width = 130;
            dgvReport.Columns[2].Width = 130;
            dgvReport.Columns[3].Width = 130;
            dgvReport.Columns[5].Width = 120;
            dgvReport.Columns[6].Width = 130;
            dgvReport.Columns[7].Width = 130;
            dgvReport.Columns[8].Width = 130;

            dgvReport.Columns[8].Visible = false;
            dgvReport.Columns[9].Visible = false;


        }
    }
}
