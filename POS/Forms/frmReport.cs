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
            btnPrint.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = null;
            dgvReport.Columns.Clear();

            var tmpdate = rptDate.Value.ToShortDateString();
            var data = ReportService.SellSummaryReport(tmpdate, "");
            dgvReport.DataSource = data;

            if (data.Count() > 0)
            {
                lblSum.Text = string.Format("{0} {1} บาท", "รวมทั้งสิน", data[0].SUM_TOTAL_AMOUNT.ToString());
                btnPrint.Enabled = true;
            }
            else
            {
                btnPrint.Enabled = false;
                MessageBox.Show("ไม่พบข้อมูล", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgvReport.Columns[0].HeaderText = "NO.";
            dgvReport.Columns[1].HeaderText = "เลขที่การขาย";
            dgvReport.Columns[2].HeaderText = "รหัสสินค้า";
            dgvReport.Columns[3].HeaderText = "ชื่อสินค้า";
            dgvReport.Columns[4].HeaderText = "จำนวน";
            dgvReport.Columns[5].HeaderText = "หน่วย";
            dgvReport.Columns[6].HeaderText = "ราคา(บาท)";
            dgvReport.Columns[7].HeaderText = "ส่วนลด(บาท)";
            dgvReport.Columns[8].HeaderText = "รวม(บาท)";

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

            //dgvReport.Columns[8].Visible = false;
            dgvReport.Columns[9].Visible = false;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = null;
            dgvReport.Columns.Clear();

            string sellNo = txtSellNo.Text;

            var rptData = ReportService.SellItemReport(sellNo);

            dgvReport.DataSource = rptData;

            dgvReport.Columns[0].HeaderText = "รายการสินค้า";
            dgvReport.Columns[1].HeaderText = "จำนวน";
            dgvReport.Columns[2].HeaderText = "หน่วย";
            dgvReport.Columns[3].HeaderText = "ส่วนลด(บาท)";
            dgvReport.Columns[4].HeaderText = "ราคารวม(บาท)";
 
            dgvReport.Columns[0].Width = 130;
            dgvReport.Columns[1].Width = 130;
            dgvReport.Columns[2].Width = 130;
            dgvReport.Columns[3].Width = 130;
            dgvReport.Columns[4].Width = 130;

            dgvReport.Columns[0].Name = "Item";
            dgvReport.Columns[1].Name = "Qty";
            dgvReport.Columns[2].Name = "UNIT";
            dgvReport.Columns[3].Name = "DISCOUNT";
            dgvReport.Columns[4].Name = "AMOUNT";

            dgvReport.Columns[0].DataPropertyName = "Item";
            dgvReport.Columns[1].DataPropertyName = "Qty";
            dgvReport.Columns[2].DataPropertyName = "UNIT";
            dgvReport.Columns[3].DataPropertyName = "DISCOUNT";
            dgvReport.Columns[4].DataPropertyName = "AMOUNT";

            dgvReport.Columns[5].Visible = false;
            dgvReport.Columns[6].Visible = false;

            decimal sum = 0;
            lblSum.Text = string.Empty;

            foreach (DataGridViewRow rw in dgvReport.Rows)
            {
                rw.HeaderCell.Value = (rw.Index + 1).ToString();
                sum += decimal.Parse(rw.Cells["AMOUNT"].Value.ToString());
            }
            lblSum.Text = string.Format("{0} {1} บาท", "รวมทั้งสิน", sum.ToString("#,###.00"));

            if (rptData.Count() > 0)
            {
                btnPrint.Enabled = true;
            }
            else
            {
                btnPrint.Enabled = false;
                MessageBox.Show("ไม่พบข้อมูล", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string tabName = tabcontrol1.SelectedTab.Name;

            if (tabName == "tbSellSearch")
            {
                if (MessageBox.Show(string.Format("ต้องการพิมพ์รายงานหรือไม่ ?", ""), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PrintModel.Flag = "SellItem";
                    PrintModel.SellNo = txtSellNo.Text;
                    frmLoading frmload = new frmLoading();
                    frmload.Show();
                }
            }
            else if(tabName == "tbDaily")
            {
                if (MessageBox.Show(string.Format("ต้องการพิมพ์รายงานหรือไม่ ?", ""), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var tmpdate = rptDate.Value.ToShortDateString();
                    //var data = ReportService.SellSummaryReport(tmpdate, "");
                    PrintModel.Flag = "Daily";
                    PrintModel.SellNo = string.Empty;
                    PrintModel.DateRpt = tmpdate;
                    frmLoading frmload = new frmLoading();
                    frmload.Show();
                }
            }


            
        }
    }
}
