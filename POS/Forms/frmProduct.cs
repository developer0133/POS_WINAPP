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

namespace POS.Forms
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            FormLoad();
        }

        void PopulateDataGridView()
        {
            dgvProduct.AutoGenerateColumns = false;
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
