using BL;
using DATA_Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_EF;
using DAL.Utils;
using POS.Utils;
using System.IO;
using DATA_Models.Models;
using Microsoft.Reporting.WinForms;
using GreatFriends.ThaiBahtText;

namespace POS.Forms
{
    public partial class frmSell : Form
    {
        ProductDTO obj = new ProductDTO();
        List<string> pcode = new List<string>();
        private string strSellNo = string.Empty;
        private string saveFile = string.Empty;
        public frmSell()
        {
            InitializeComponent();

            btnReport.Enabled = false;

            POS.Utils.clsFunction.FormatHeaderDatagrid(dgvSell);

            // dgvSell.CellValueChanged += new DataGridViewCellEventHandler(dgvSell_CellValueChanged);
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.PushDataGV();
                this.txtBarcode.Clear();
            }
        }

        void PushDataGV()
        {
            string code = txtBarcode.Text;

            obj = ProductService.GetProduct(code, "sell").SingleOrDefault(); 

            if (obj != null)
            {
                var invChk = InvService.GetInventory(obj.PRODUCT_ID).Count();
                if (invChk == 0)
                {
                    MessageBox.Show("ไม่พบข้อมูล", "POS" );
                }
                else
                {
                    var strUnit = InvService.SRTUNIT(obj.PRODUCT_ID);

                    
                    DataGridViewRow row = (DataGridViewRow)dgvSell.Rows[0].Clone();
                    row.Cells[0].Value = obj.PRODUCT_NAME;
                    row.Cells[7].Value = obj.PRODUCT_CODE;//obj.STRSELLPRICE;
                                                          //row.Cells[1].Value = 1;
                    row.Cells[2].Value = strUnit;
                    row.Cells[3].Value = obj.RETAILPRICE; // obj.SELLPRICE;//obj.STRSELLPRICE;
                    row.Cells[8].Value = obj.PRODUCT_ID;
                    row.Cells[9].Value = obj.UNIT_ID;
                    row.Cells[10].Value = obj.PARENT_ID;
                    row.Cells[11].Value = obj.UNIT_BALANCE_TEXT;

                    pcode.Add(obj.PRODUCT_CODE);

                    if (pcode.Where(w => w == code).Count() > 1)
                    {
                        MessageBox.Show("ข้อมูลซ้ำ", "POS");
                    }
                    else
                    {
                        dgvSell.Rows.Add(row);
                        foreach (DataGridViewRow rw in dgvSell.Rows)
                        {
                            rw.HeaderCell.Value = (rw.Index + 1).ToString();
                            rw.Cells[3].Style.BackColor = Color.DarkGray;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูล", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
  
            //dgvSell.Rows[dgvSell.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
            //dgvSell.Rows[dgvSell.Rows.Count - 1].DefaultCellStyle.SelectionBackColor = Color.Red;
            //dgvSell.Rows[dgvSell.Rows.Count - 1].Cells[4].Style.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            //dgvSell.Rows[dgvSell.Rows.Count - 1].Cells[4].Value = "รวมทั้งสิ้น";

        }

        //private void dgvSell_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        //{
        //   //dgvSell.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        //}

        private void dgvSell_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(txtQty_Leave);
            if (dgvSell.CurrentCell.ColumnIndex == 1)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(txtQty_Leave);
                }
            }

            if (dgvSell.CurrentCell.ColumnIndex == 4)
            {

                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(txtQty_Leave);
                }
            }

        }

        void txtQty_Leave(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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

            //disc = dgvSell.CurrentRow.Cells["Discount"].Value == null ? 0 : decimal.Parse(dgvSell.CurrentRow.Cells["Discount"].Value.ToString());
            //qty = dgvSell.CurrentRow.Cells["Qty"].Value == null ? 0 : decimal.Parse(dgvSell.CurrentRow.Cells["Qty"].Value.ToString());
            //price = dgvSell.CurrentRow.Cells["SellPrice"].Value == null ? 0 : decimal.Parse(dgvSell.CurrentRow.Cells["SellPrice"].Value.ToString());

            //sum = (price * qty) - (disc);

            //dgvSell.CurrentRow.Cells[5].Value = sum.ToString();

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
            //dgvSell.Rows[dgvSell.Rows.Count - 1].Cells[5].Value = total.ToString("#,###.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtBarcode.Clear();
            this.dgvSell.Rows.Clear();
            pcode = new List<string>();
            obj = new ProductDTO();
            lblSum.Text = string.Empty;
            lblSum.Text = string.Format("{0} {1} บาท", "รวมสุทธิ", "0.00");
        }
        private void dgvSell_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                var dd = pcode;
                DataGridViewRow row = dgvSell.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("ต้องการลบหรือไม่ ?", ""), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (dgvSell.Rows[e.RowIndex].Cells["PRODUCT_CODE"].Value != null)
                    {
                        var code = dgvSell.Rows[e.RowIndex].Cells["PRODUCT_CODE"].Value.ToString();

                        pcode.Remove(code);
                        dgvSell.Rows.RemoveAt(row.Index);

                        AmountCalculate();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<SELLITEMS> sellData = new List<SELLITEMS>();
            string msg = string.Empty;

            for (int i = 0; i < dgvSell.Rows.Count - 1; i++)
            {
                sellData.Add(new SELLITEMS()
                {
                    PRODUCT_CODE = dgvSell.Rows[i].Cells["PRODUCT_CODE"].Value.ToString(),
                    QTY = dgvSell.Rows[i].Cells["Qty"].Value == null ? 0 : int.Parse(dgvSell.Rows[i].Cells["Qty"].Value.ToString()),
                    AMOUNT = dgvSell.Rows[i].Cells["Amount"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["Amount"].Value.ToString()),
                    DISCOUNT = dgvSell.Rows[i].Cells["Discount"].Value == null ? 0 : int.Parse(dgvSell.Rows[i].Cells["Discount"].Value.ToString()),
                    PRODUCT_ID = dgvSell.Rows[i].Cells["PRODUCT_ID"].Value == null ? 0 : int.Parse(dgvSell.Rows[i].Cells["PRODUCT_ID"].Value.ToString()),
                    SELL_PRICE = dgvSell.Rows[i].Cells["SellPrice"].Value == null ? 0 : decimal.Parse(dgvSell.Rows[i].Cells["SellPrice"].Value.ToString()),
                    UNIT = dgvSell.Rows[i].Cells["UNIT_ID"].Value.ToString(),
                    
                });
            }

            if (sellData.Count() > 0)
            {
                var isSuccess = SellItemService.InsertSellItem2(sellData, ref msg);

                if (!string.IsNullOrEmpty(isSuccess) && string.IsNullOrEmpty(msg))
                {
                    MessageBox.Show(MESSAGEALERT.COMPLETED, "POS", MessageBoxButtons.OK);
                    btnReport.Enabled = true;
                    strSellNo = isSuccess;
                }
                if (!string.IsNullOrEmpty(msg))
                {
                    MessageBox.Show(msg, "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                btnReport.Enabled = false;
                MessageBox.Show("ไม่มีรายการสินค้า", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            GenReportModel objRp = new GenReportModel();
            objRp.code = strSellNo;// "SE12700253";
            objRp.printby = UserModel.USERNAME;
            objRp.cusname = string.IsNullOrEmpty(txtCusName.Text) ? string.Empty : txtCusName.Text;
            objRp.address = string.IsNullOrEmpty(txtAddr.Text) ? string.Empty : txtAddr.Text; 

            if (MessageBox.Show(string.Format("ต้องการพิมพ์รายงาน" + strSellNo + "หรือไม่ ? ", ""), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PrintModel.Flag = "SellItem";
                PrintModel.SellNo = objRp.code;
                PrintModel.DateRpt = "";
                PrintModel.Cusname = objRp.cusname;
                PrintModel.Address = objRp.address;

                frmLoading frmload = new frmLoading();
                frmload.Show();
            }

            //var printRp = this.PrintReport(objRp);
            //if(printRp)
            //{
            //    MessageBox.Show("สำเร็จ", "POS");
            //    System.Diagnostics.Process.Start(saveFile);
            //}
        }

        private bool PrintReport(GenReportModel OReport)
        {
            bool isSuccess = false;

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            string genRpt = System.IO.Directory.GetCurrentDirectory();
            genRpt = string.Format("{0}/{1}", genRpt, POS_PATH.GEN_REPORT);
            DAL.Utils.clsFunction.MakePath(genRpt);

            var rptPath = string.Format("{0}/{1}{2}", POS_PATH.REPORTS, REPORT_NAME.SELL_REPORT3, ".rdlc");
            var savePath = string.Format("{0}/{1}{2}", POS_PATH.GEN_REPORT, OReport.code, ".pdf");

            string path1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\POS" + "\\";
            string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\POS"+"\\"+ rptPath;
            saveFile = path1 + savePath;//Path.Combine(Directory.GetCurrentDirectory(), savePath);

            var rptData = ReportService.SellItemReport(OReport.code);
            decimal? sumAmount = rptData.Sum(s => s.AMOUNT);
            string strsSumAmount = "";
            strsSumAmount = sumAmount.HasValue ? string.Format("{0} {1}", Utils.clsFunction.setFormatCurrency(sumAmount), "บาท") : string.Empty;

     
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("printby", UserModel.USERNAME));
            parameters.Add(new ReportParameter("total", strsSumAmount.ToString()));
            parameters.Add(new ReportParameter("cdate", Utils.clsFunction.setFormatDateWithTime(rptData.First().CDATE, true).ToString()));
            parameters.Add(new ReportParameter("date", Utils.clsFunction.setFormatDateWithTime(Utils.clsFunction.GetDate(), true).ToString()));
            parameters.Add(new ReportParameter("no", OReport.code.ToString()));

            try
            {

                ReportViewer viewer = new ReportViewer();
                viewer.ProcessingMode = ProcessingMode.Local;
                viewer.LocalReport.ReportPath = path;//"D:/Workspace/DotNet/Inventory/POS_WINAPP3/POS_WINAPP/POS/Reports/SellReport.rdlc";
                viewer.LocalReport.SetParameters(parameters);
                viewer.LocalReport.DataSources.Add(new ReportDataSource("sell_DS", rptData));

                byte[] bytes = viewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);

                using (FileStream fs = new FileStream(saveFile, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                if(bytes.Length > 0)
                {
                    ////download
                    //string FileName = @"D:\Workspace\DotNet\Inventory\POS_WINAPP3\POS_WINAPP\POS\GenReports\SE12700253.pdf";
                    //string PDFUrl = @"C:\Users\CUBE\Desktop\test\testtest.pdf";
                    //System.Net.WebClient client = new System.Net.WebClient();
                    //client.DownloadFile(FileName, PDFUrl);
                    //FileInfo PDFFile = new FileInfo(FileName);

                    isSuccess = true;
                }
            }
            catch(Exception ex)
            {
                isSuccess = false;
            }

            return isSuccess;
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            frmSellManual f = new frmSellManual();
            f.Show();
        }
    }
}
