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
using System.Globalization;
using System.Threading;

namespace POS.Forms
{
    public partial class frmProduct : Form
    {
        private const int pageSize = 10;
        private int pageNumber = 1;

        List<ProductDTO> dt = null;
        ProductDTO pModel = null;

        public static string sellNo = string.Empty;
        public static string flag = string.Empty;
        public frmProduct()
        {
            InitializeComponent();
            FormLoad();
        }

        void PopulateDataGridView()
        {
            dgvProduct.AutoGenerateColumns = false;

            dt = new List<ProductDTO>();
            dt = ProductService.GetProduct(string.Empty, string.Empty); //140000101
            dgvProduct.DataSource = dt;//.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();

            lblPage.Text = string.Format("Page {0}/{1}", (pageNumber), dt.Count() / pageSize);

            btnFirst.Enabled = false;

            if (dt.Count() / pageSize == 1)
            {
                btnNext.Enabled = false;
            }

            btnNext.Enabled = true;

            if (dt.Count() == 1)
            {
                lblPage.Text = string.Format("Page {0}/{1}", (pageNumber), 1);
                btnNext.Enabled = false;
            }
        }

        void BindCboCategory()
        {
            var cates = CategoryService.GetCategories();
            cboCategory.DisplayMember = "CATEGORY_NAME";
            cboCategory.ValueMember = "CATEGORY_ID";
            cboCategory.DataSource = cates;
        }

        void BindType()
        {
            var parm = ParameterService.GetParameter(PARAMETERCODE.PARAMETER_TYPE);
            cboType.DisplayMember = "NAME";
            cboType.ValueMember = "MINOR_CODE";
            cboType.DataSource = parm;
        }
        void BindSize()
        {
            var parm = ParameterService.GetParameter(PARAMETERCODE.PARAMETER_SIZE);
            cboSize.DisplayMember = "NAME";
            cboSize.ValueMember = "MINOR_CODE";
            cboSize.DataSource = parm;
        }

        void FormLoad()
        {
            PopulateDataGridView();
            BindCboCategory();
            BindType();
            BindSize();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtBarcode.Text = string.Empty;
            txtRemark.Text = string.Empty;
            txtLastCost.Text = string.Empty;
            chkStatus.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PRODUCTS obj = new PRODUCTS();
            bool isSuccess = false;

            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("กรุณาระบุข้อมูล", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                obj.PRODUCT_NAME = txtProductName.Text.Trim();
                obj.BARCODE = txtBarcode.Text.Trim();
                obj.CATEGORY_ID = Convert.ToInt32(cboCategory.SelectedValue);
                obj.PRODUCT_TYPE_ID = cboType.SelectedValue != null ? cboType.SelectedValue.ToString() : string.Empty;
                obj.PRODUCT_SIZE_ID = cboSize.SelectedValue != null ? cboSize.SelectedValue.ToString() : string.Empty;
                obj.REMARK = txtRemark.Text.Trim();

                if (chkStatus.Checked == true)
                {
                    obj.STATUS = STATUS.INACTIVE;
                }
                else
                {
                    obj.STATUS = STATUS.ACTIVE;
                }

                if (pModel != null && pModel.PRODUCT_ID > 0)
                {
                    obj.PRODUCT_ID = pModel.PRODUCT_ID;
                    obj.PRODUCT_CODE = pModel.PRODUCT_CODE;
                    obj.AVGCOST = pModel.AVGCOST;
                    obj.UNIT = pModel.UNIT;
                    //obj.STATUS = pModel.STATUS;

                    isSuccess = ProductService.UpdateProduct(obj);
                }
                else
                {
                    obj.RETAILPRICE = 0;
                    obj.WHOLESALEPRICE = 0;
                    obj.AVGCOST = 0;
                    obj.WHOLESALEPROFIT = 0;
                    obj.RETAILPROFIT = 0;
                    obj.QTY = 0;
                    obj.UNIT = "0";
                    obj.AVG_PACK = 0;
                    obj.AVG_ITEM = 0;
                    obj.WHOLESALEPRICE_ITEM = 0;
                    obj.BOXPRICE = 0; obj.RETAILPRICE = 0;
                    obj.WHOLESALEPRICE = 0;
                    obj.AVGCOST = 0;
                    obj.WHOLESALEPROFIT = 0;
                    obj.RETAILPROFIT = 0;
                    obj.QTY = 0;
                    obj.UNIT = "0";
                    obj.AVG_PACK = 0;
                    obj.AVG_ITEM = 0;
                    obj.WHOLESALEPRICE_ITEM = 0;
                    obj.BOXPRICE = 0;

                    isSuccess = ProductService.InsertProduct(obj);
                }

                if (isSuccess)
                {
                    MessageBox.Show("Completed", "POS");
                    Clear();
                    pageNumber = 1;
                    PopulateDataGridView();
                }
            }
        }

        void Clear()
        {
            txtBarcode.Clear();
            txtProductName.Clear();
            txtRemark.Clear();
            txtLastCost.Clear();
            txtCostAvg.Clear();
            pModel = null;
            dgvOrderHist.Columns.Clear();
            dgvSellHist.Columns.Clear();
            chkStatus.Checked = false;

            dgvSellHist.DataSource = null;
            dgvOrderHist.DataSource = null;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pageNumber--;
            dgvProduct.DataSource = dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();

            if (dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).Count() > 0)
            {
                btnFirst.Enabled = true;
            }
            else
            {
                btnFirst.Enabled = false;
            }

            btnNext.Enabled = true;
            btnFirst.Enabled = !(pageNumber == 1);
            lblPage.Text = string.Format("Page {0}/{1}", (pageNumber), dt.Count() / pageSize);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageNumber++;
            dgvProduct.DataSource = dt.Skip(pageSize * (pageNumber )).Take(pageSize).ToList();
            if (dt.Skip(pageSize * (pageNumber )).Take(pageSize).Count() > 0)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }

            btnFirst.Enabled = true;
            btnNext.Enabled = !(pageNumber == dt.Count() / pageSize);
            lblPage.Text = string.Format("Page {0}/{1}", (pageNumber), dt.Count() / pageSize);
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.CurrentRow.Index != -1)
            {
                pModel = new ProductDTO();
                string code = dgvProduct.CurrentRow.Cells["PRODUCT_CODE"].Value.ToString();
                pModel = ProductService.GetProduct(code, string.Empty).SingleOrDefault();

                txtProductID.Text = pModel.PRODUCT_CODE;
                txtProductName.Text = pModel.PRODUCT_NAME;
                txtRemark.Text = pModel.REMARK;
                txtBarcode.Text = pModel.BARCODE;
                txtLastCost.Text = pModel.AVGCOST.ToString();

                cboType.SelectedValue = pModel.PRODUCT_TYPE_ID;
                cboCategory.SelectedValue = pModel.CATEGORY_ID;
                cboSize.SelectedValue = pModel.PRODUCT_SIZE_ID;

                this.GetSellHistory(pModel.PRODUCT_ID);
                this.GetOrderHistory(pModel.PRODUCT_ID);
            }
        }

        void GetSellHistory(int ProductID)
        {
            dgvSellHist.Columns.Clear();
            dgvSellHist.DataSource = null;
            var sellData = SellItemService.GetSellItem(ProductID);
            dgvSellHist.DataSource = sellData;

            dgvSellHist.Columns[0].HeaderText = "เลขที่การขาย";
            dgvSellHist.Columns[1].HeaderText = "วันที่";
            dgvSellHist.Columns[2].HeaderText = "จำนวน";
            dgvSellHist.Columns[3].HeaderText = "รหัสสินค้า";
            dgvSellHist.Columns[4].HeaderText = "หน่วย";
            dgvSellHist.Columns[5].HeaderText = "ราคารวม(บาท)";
            dgvSellHist.Columns[6].HeaderText = "ส่วนลด(บาท)";

            dgvSellHist.Columns[0].Width = 130;
            dgvSellHist.Columns[1].Width = 130;
            dgvSellHist.Columns[2].Width = 100;
            dgvSellHist.Columns[3].Width = 100;
            dgvSellHist.Columns[4].Width = 100;
            dgvSellHist.Columns[5].Width = 130;
            dgvSellHist.Columns[6].Width = 130;

            dgvSellHist.Columns[0].Name = "SELLITEM_NO";
            dgvSellHist.Columns[1].Name = "STR_SELL_DATE";
            dgvSellHist.Columns[2].Name = "Qty";
            dgvSellHist.Columns[3].Name = "PRODUCT_CODE";
            dgvSellHist.Columns[4].Name = "STR_UNIT";
            dgvSellHist.Columns[5].Name = "AMOUNT";
            dgvSellHist.Columns[6].Name = "DISCOUNT";

            dgvSellHist.Columns[0].DataPropertyName = "SELLITEM_NO";
            dgvSellHist.Columns[1].DataPropertyName = "STR_SELL_DATE";
            dgvSellHist.Columns[2].DataPropertyName = "Qty";
            dgvSellHist.Columns[3].DataPropertyName = "PRODUCT_CODE";
            dgvSellHist.Columns[4].DataPropertyName = "STR_UNIT";
            dgvSellHist.Columns[5].DataPropertyName = "AMOUNT";
            dgvSellHist.Columns[6].DataPropertyName = "DISCOUNT";

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "";
            btnColumn.Width = 60;
            btnColumn.Name = "btnReport";
            btnColumn.Text = "รายงาน";
            btnColumn.UseColumnTextForButtonValue = true;
            dgvSellHist.Columns.Insert(7, btnColumn);
            dgvSellHist.Columns[7].Width = 130;
        }

        void GetOrderHistory(int ProductID)
        {
            dgvOrderHist.Columns.Clear();
            dgvOrderHist.DataSource = null;
            var orderData = OrderHistoryService.GetOrderHistory(ProductID, null);
            dgvOrderHist.DataSource = orderData;

            dgvOrderHist.Columns[0].HeaderText = "วันที่";
            dgvOrderHist.Columns[1].HeaderText = "จำนวน";
            dgvOrderHist.Columns[2].HeaderText = "หน่วย";
            dgvOrderHist.Columns[3].HeaderText = "ราคา";
            dgvOrderHist.Columns[4].HeaderText = "รวม(THB)";
            dgvOrderHist.Columns[5].HeaderText = "ราคา/ชิ้น(บาท)";
            dgvOrderHist.Columns[6].HeaderText = "ราคา/โหล/แพ็ค(บาท)";
            dgvOrderHist.Columns[7].HeaderText = "หมายเหตุ";

            dgvOrderHist.Columns[0].Width = 130;
            dgvOrderHist.Columns[1].Width = 130;
            dgvOrderHist.Columns[2].Width = 100;
            dgvOrderHist.Columns[3].Width = 100;
            dgvOrderHist.Columns[4].Width = 100;
            dgvOrderHist.Columns[5].Width = 130;
            dgvOrderHist.Columns[6].Width = 130;
            dgvOrderHist.Columns[7].Width = 130;

            dgvOrderHist.Columns[0].Name = "STR_ORDERDATE";
            dgvOrderHist.Columns[1].Name = "QTY";
            dgvOrderHist.Columns[2].Name = "STR_UNIT";
            dgvOrderHist.Columns[3].Name = "STR_AMOUNT";
            dgvOrderHist.Columns[4].Name = "STR_TOTAL_AMOUNT";
            dgvOrderHist.Columns[5].Name = "AVG_ITEM";
            dgvOrderHist.Columns[6].Name = "AVG_PACK";
            dgvOrderHist.Columns[7].Name = "REMARK";

            dgvOrderHist.Columns[0].DataPropertyName = "STR_ORDERDATE";
            dgvOrderHist.Columns[1].DataPropertyName = "QTY";
            dgvOrderHist.Columns[2].DataPropertyName = "STR_UNIT";
            dgvOrderHist.Columns[3].DataPropertyName = "STR_AMOUNT";
            dgvOrderHist.Columns[4].DataPropertyName = "STR_TOTAL_AMOUNT";
            dgvOrderHist.Columns[5].DataPropertyName = "AVG_ITEM";
            dgvOrderHist.Columns[6].DataPropertyName = "AVG_PACK";
            dgvOrderHist.Columns[7].DataPropertyName = "REMARK";

            dgvOrderHist.Columns[8].Visible = false;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSellHist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSellHist.Columns[e.ColumnIndex].Name == "btnReport")
            {
                DataGridViewRow row = dgvSellHist.Rows[e.RowIndex];
                sellNo = row.Cells["SELLITEM_NO"].Value.ToString(); //SELLITEM_NO
                PrintModel.SellNo = sellNo;

                if (MessageBox.Show(string.Format("ต้องการพิมพ์รายงาน" + sellNo + " หรือไม่ ?", ""), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PrintModel.Flag = "SellItem";
                    frmLoading frmload = new frmLoading();
                    frmload.Show();

                    //string fileName = string.Empty;
                    //GenReportModel objRp = new GenReportModel();
                    //objRp.code = sellNo;
                    //objRp.printby = "test";

                    //var isPrint = clsFunction.PrintReport(objRp, ref fileName);

                    //if (isPrint)
                    //{
                    //    System.Diagnostics.Process.Start(fileName);
                    //    frmload.Close();
                    //}
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            dgvProduct.AutoGenerateColumns = false;
            pageNumber = 1;
            dt = new List<ProductDTO>();
            dt = ProductService.GetProduct(txtSearch.Text, string.Empty); //140000101
            dgvProduct.DataSource = dt;//.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();

            lblPage.Text = string.Format("Page {0}/{1}", (pageNumber), dt.Count() / pageSize);
        }
    }
}
