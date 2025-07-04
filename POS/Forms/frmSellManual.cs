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
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class frmSellManual : Form
    {

        private string strIVNO = string.Empty;
        private string strSENO = string.Empty;
        private string saveFile = string.Empty;

        private List<SellManualModel> sellmanualDS = new List<SellManualModel>();
        public frmSellManual()
        {
            InitializeComponent();
            dgvSell.AutoGenerateColumns = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            List<SELL_MANUAL> sellData = new List<SELL_MANUAL>();

            try
            {
                strIVNO = SellItemService.GetSellCode("IV");
                strSENO = SellItemService.GetSellCode("SE");//strIVNO.Replace("IV", "SE");

                for (int i = 0; i < dgvSell.Rows.Count - 1; i++)
                {
                    sellData.Add(new SELL_MANUAL()
                    {
                        IV_NO = strIVNO,
                        SE_NO = strSENO,
                        CUSTOMER_NAME = txtCusName.Text,
                        ADDRESS = txtAddr.Text,
                        DISCOUNT = dgvSell.Rows[i].Cells["Discount"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["Discount"].Value.ToString()),
                        PRODUCT_NAME = dgvSell.Rows[i].Cells["PName"].Value.ToString(),
                        QTY = dgvSell.Rows[i].Cells["Qty"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["Qty"].Value.ToString()),
                        PRICE = dgvSell.Rows[i].Cells["SellPrice"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["SellPrice"].Value.ToString()),
                        UNIT = dgvSell.Rows[i].Cells["Unit"].Value.ToString(),
                        TOTAL = dgvSell.Rows[i].Cells["Amount"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["Amount"].Value.ToString()),
                        C_BY = UserModel.USER_CODE,
                        C_DATE = txtDate.Value,
                        E_BY = UserModel.USER_CODE,
                        E_DATE = clsFunction.GetDate()
                    });
                }

                var isSuccess = SellItemService.InsertSellItemManual(sellData, ref msg);

                if (isSuccess == true)
                {
                    MessageBox.Show(MESSAGEALERT.COMPLETED, "POS", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strSENO))
            {
                PrepareReportData("SE", strSENO);
            } //order delivery
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
            if (sellmanualDS.Count > 0)
            {
                sellmanualDS = new List<SellManualModel>();
                // dgvSell.DataSource = null;
                dgvSell.Columns[0].Name = "PRODUCT_NAME";
            }
            else
            {
                dgvSell.Rows.Clear();
            }

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
            //txtAddr.Text = string.Empty;
            //txtCusName.Text = string.Empty;
            txtSearchNo.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sellmanualDS = SellItemService.GetSellManual(txtSearchNo.Text);
            dgvSell.DataSource = sellmanualDS;

            if (sellmanualDS.Count > 0)
            {
                txtCusName.Text = sellmanualDS.Select(s => s.CUSTOMER_NAME).First();
                txtAddr.Text = sellmanualDS.Select(s => s.ADDRESS).First();
                strIVNO = sellmanualDS.Select(s => s.IV_NO).First();
                strSENO = sellmanualDS.Select(s => s.SE_NO).First();

                decimal total = 0;
                total = sellmanualDS.Sum(s => s.TOTAL.Value);
                lblSum.Text = string.Format("{0} {1} บาท", "รวมสุทธิ", total.ToString("#,###.00"));
            }
        }

        private void btnSaveDraft_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvSell.Rows[0].Clone();
            row.Cells[0].Value = txtProductName.Text;
            row.Cells[1].Value = txtQty.Text;
            row.Cells[2].Value = txtUnit.Text;
            row.Cells[3].Value = txtPrice.Text;
            row.Cells[4].Value = string.IsNullOrEmpty(txtDis.Text) ? "0" : txtDis.Text;

            txtDis.Text = string.IsNullOrEmpty(txtDis.Text) ? "0" : txtDis.Text;
            var total = (Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtPrice.Text)) - Convert.ToDecimal(txtDis.Text);
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

        private void btnReportInv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strIVNO))
                PrepareReportData("IV", strIVNO);//invoice
        }

        private void PrepareReportData(string flag, string No)
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

                if (string.IsNullOrEmpty(No))
                {
                    objRp.code = SellItemService.GetSellCode(flag);
                }
                else
                {
                    objRp.code = No;
                }

                PrintModel.Flag = "Manual";
                PrintModel.SellNo = objRp.code;
                PrintModel.DateRpt = "";
                PrintModel.Cusname = objRp.cusname;
                PrintModel.Address = objRp.address;
                objRp.param = objRp.code;

                if (sellmanualDS.Count == 0 || sellmanualDS == null)
                {
                    for (int i = 0; i < dgvSell.Rows.Count - 1; i++)
                    {
                       
                        SellItemReport.Add(new SellReportModel()
                        {
                            No = (i + 1),
                            Item = dgvSell.Rows[i].Cells["PName"].Value.ToString(),
                            Qty = dgvSell.Rows[i].Cells["Qty"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["Qty"].Value.ToString()),
                            AMOUNT = dgvSell.Rows[i].Cells["Amount"].Value == null ? "" : clsFunction.setFormatCurrency(decimal.Parse(dgvSell.Rows[i].Cells["Amount"].Value.ToString())),  // decimal.Parse(dgvSell.Rows[i].Cells["Amount"].Value.ToString()),
                            UNIT = dgvSell.Rows[i].Cells["Unit"].Value.ToString(),
                            DISCOUNT = dgvSell.Rows[i].Cells["Discount"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["Discount"].Value.ToString()),
                            RETAILPRICE = dgvSell.Rows[i].Cells["SellPrice"].Value == null ? "" : clsFunction.setFormatCurrency(decimal.Parse(dgvSell.Rows[i].Cells["SellPrice"].Value.ToString())),//decimal.Parse(dgvSell.Rows[i].Cells["SellPrice"].Value.ToString()),
                            CDATE = txtDate.Value //clsFunction.GetDate()
                        });
                    }
                }
                else
                {
                    if (sellmanualDS.Count > 0)
                    {
                        for (int i = 0; i < sellmanualDS.Count; i++)
                        {

                            SellItemReport.Add(new SellReportModel()
                            {
                                No = (i + 1),
                                Item = dgvSell.Rows[i].Cells["PName"].Value.ToString(),
                                Qty = dgvSell.Rows[i].Cells["Qty"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["Qty"].Value.ToString()),
                                AMOUNT = dgvSell.Rows[i].Cells["Amount"].Value == null ? "" : clsFunction.setFormatCurrency(decimal.Parse(dgvSell.Rows[i].Cells["Amount"].Value.ToString())),//AMOUNT = dgvSell.Rows[i].Cells["Amount"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["Amount"].Value.ToString()),
                                UNIT = dgvSell.Rows[i].Cells["Unit"].Value.ToString(),
                                DISCOUNT = dgvSell.Rows[i].Cells["Discount"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["Discount"].Value.ToString()),
                                RETAILPRICE = dgvSell.Rows[i].Cells["SellPrice"].Value == null ? "" : clsFunction.setFormatCurrency(decimal.Parse(dgvSell.Rows[i].Cells["SellPrice"].Value.ToString())),//RETAILPRICE = dgvSell.Rows[i].Cells["SellPrice"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["SellPrice"].Value.ToString()),
                                CDATE = txtDate.Value //clsFunction.GetDate()
                            });
                        }
                    }
                }

                var isSuccess = clsFunction.PrintReportManual(objRp, SellItemReport, flag, ref fileName);

                if (isSuccess)
                {
                    System.Diagnostics.Process.Start(fileName);
                }
            }
        }
    }
}
