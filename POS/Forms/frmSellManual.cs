using BL;
using DATA_EF;
using DATA_Models.DTO;
using DATA_Models.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS.Utils;
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
    public partial class frmSellManual : Form
    {

        private string strSellNo = string.Empty;
        private string saveFile = string.Empty;
        public frmSellManual()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvSell.Rows[0].Clone();
            row.Cells[0].Value = txtProductName.Text;
            row.Cells[1].Value = txtQty.Text;
            row.Cells[2].Value = txtUnit.Text; // obj.SELLPRICE;//obj.STRSELLPRICE;
            row.Cells[3].Value = txtPrice.Text;
            row.Cells[4].Value = txtDis.Text;

            txtDis.Text = string.IsNullOrEmpty(txtDis.Text) ? "0" : txtDis.Text;    
            var total = Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtPrice.Text)- Convert.ToDecimal(txtDis.Text);
            row.Cells[5].Value = total.ToString();

            dgvSell.Rows.Add(row);
            foreach (DataGridViewRow rw in dgvSell.Rows)
            {
                rw.HeaderCell.Value = (rw.Index + 1).ToString();
                rw.Cells[0].Style.BackColor = Color.DarkGray;
            }

            AmountCalculate();
            CLEAR();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string fileName = string.Empty;

            GenReportModel objRp = new GenReportModel();
            objRp.code = "";
            objRp.printby = UserModel.USERNAME;
            objRp.cusname = string.IsNullOrEmpty(txtCusName.Text) ? string.Empty : txtCusName.Text;
            objRp.address = string.IsNullOrEmpty(txtAddr.Text) ? string.Empty : txtAddr.Text;

            if (MessageBox.Show(string.Format("ต้องการพิมพ์รายงานหรือไม่ ? ", ""), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                List<SELLITEMS> sellData = new List<SELLITEMS>();
                List<SellReportModel> SellItemReport = new List<SellReportModel>();

                strSellNo = SellItemService.GetSellCode();
                objRp.code = strSellNo;

                PrintModel.Flag = "Manual";
                PrintModel.SellNo = objRp.code;
                PrintModel.DateRpt = "";
                PrintModel.Cusname = objRp.cusname;
                PrintModel.Address = objRp.address;
                objRp.param = objRp.code;


                for (int i = 0; i < dgvSell.Rows.Count - 1; i++)
                {

                    SellItemReport.Add(new SellReportModel()
                    {
                        No = (i + 1),
                        Item = dgvSell.Rows[i].Cells["PName"].Value.ToString(),
                        Qty = dgvSell.Rows[i].Cells["Qty"].Value == null ? 0 : int.Parse(dgvSell.Rows[i].Cells["Qty"].Value.ToString()),
                        AMOUNT = dgvSell.Rows[i].Cells["Amount"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["Amount"].Value.ToString()),
                        UNIT = dgvSell.Rows[i].Cells["Unit"].Value.ToString(),
                        DISCOUNT = dgvSell.Rows[i].Cells["Discount"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["Discount"].Value.ToString()),
                        RETAILPRICE = dgvSell.Rows[i].Cells["SellPrice"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["SellPrice"].Value.ToString()),  
                        CDATE = clsFunction.GetDate()
                    });
                }

                var isSuccess = clsFunction.PrintReportManual(objRp, SellItemReport, ref fileName);

                if (isSuccess)
                {
                    System.Diagnostics.Process.Start(fileName);
                }
                this.Close();
            }
        }

        private void dgvSell_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
      
        }

        private void dgvSell_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSell.CurrentRow != null)
            {
                if (dgvSell.CurrentRow.Cells["SellPrice"].Value != null && dgvSell.CurrentRow.Cells["Qty"].Value != null)
                {
                    if (!string.IsNullOrWhiteSpace(dgvSell.CurrentRow.Cells["SellPrice"].FormattedValue.ToString()) &&
                        !string.IsNullOrWhiteSpace(dgvSell.CurrentRow.Cells["Qty"].FormattedValue.ToString()))
                    {
                        this.AmountCalculate();
                    }
                }
            }
        }

        private void AmountCalculate()
        {
            decimal qty = 0;
            decimal price = 0;
            decimal sum = 0;
            decimal disc = 0;

            decimal total = 0;
            for (int j = 0; j < dgvSell.Rows.Count - 1; j++)
            {

                disc = dgvSell.Rows[j].Cells["Discount"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[j].Cells["Discount"].Value.ToString());
                qty = dgvSell.Rows[j].Cells["Qty"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[j].Cells["Qty"].Value.ToString());
                price = dgvSell.Rows[j].Cells["SellPrice"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[j].Cells["SellPrice"].Value.ToString());


                sum = (price * qty) - (disc);

                dgvSell.Rows[j].Cells[5].Value = sum.ToString();

                if (dgvSell.Rows[j].Cells[5].Value != null)
                {
                    total += decimal.Parse(dgvSell.Rows[j].Cells[5].Value.ToString());
                }
            }

            lblSum.Text = string.Format("{0} {1} บาท", "รวมสุทธิ", total.ToString("#,###.00"));
        }

        private void dgvSell_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                
                DataGridViewRow row = dgvSell.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("ต้องการลบหรือไม่ ?", ""), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dgvSell.Rows[e.RowIndex].Cells["PName"].Value != null)
                    {
                        dgvSell.Rows.RemoveAt(row.Index);

                        AmountCalculate();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.dgvSell.Rows.Clear();
            lblSum.Text = string.Empty;
            lblSum.Text = string.Format("{0} {1} บาท", "รวมสุทธิ", "0.00");

            CLEAR();
        }

        private void CLEAR()
        {
            
            txtDis.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtUnit.Text = string.Empty;
        }
    }
}
