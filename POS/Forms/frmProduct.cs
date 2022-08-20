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

namespace POS.Forms
{
    public partial class frmProduct : Form
    {
        private const int pageSize = 10;
        private int pageNumber = 1;

        List<ProductDTO> dt = null;
        ProductDTO pModel = null;

        public frmProduct()
        {
            InitializeComponent();
            FormLoad();
        }

        void PopulateDataGridView()
        {
            dgvProduct.AutoGenerateColumns = false;

            dt = new List<ProductDTO>();
            dt = ProductService.GetProduct(string.Empty); //140000101
            dgvProduct.DataSource = dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();

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

            obj.PRODUCT_NAME = txtProductName.Text.Trim();
            obj.BARCODE = txtBarcode.Text.Trim();
            obj.CATEGORY_ID = Convert.ToInt32(cboCategory.SelectedValue);
            obj.PRODUCT_TYPE_ID = cboType.SelectedValue.ToString();
            obj.PRODUCT_SIZE_ID = cboSize.SelectedValue.ToString();
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
                obj.STATUS = pModel.STATUS;

                isSuccess = ProductService.UpdateProduct(obj);
            }
            else
            {
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

        void Clear()
        {
            txtBarcode.Clear();
            txtProductName.Clear();
            txtRemark.Clear();
            txtLastCost.Clear();
            txtCostAvg.Clear();
            pModel = null;
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
                pModel = ProductService.GetProduct(code).SingleOrDefault();

                txtProductID.Text = pModel.PRODUCT_CODE;
                txtProductName.Text = pModel.PRODUCT_NAME;
                txtRemark.Text = pModel.REMARK;
                txtBarcode.Text = pModel.BARCODE;
                txtLastCost.Text = pModel.AVGCOST.ToString();

                cboType.SelectedValue = pModel.PRODUCT_TYPE_ID;
                cboCategory.SelectedValue = pModel.CATEGORY_ID;
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
