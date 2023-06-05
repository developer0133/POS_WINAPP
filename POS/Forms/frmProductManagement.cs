using BL;
using DAL.Utils;
using DATA_EF;
using DATA_Models.DTO;
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
using ZXing.QrCode.Internal;

namespace POS.Forms
{
    public partial class frmProductManagement : Form
    {
        InventoryDTO pModel = new InventoryDTO();
        private int PID = 0;
        public frmProductManagement()
        {
            InitializeComponent();
            InitPage();
        }

        void InitPage()
        {
            LoadTexboxComplete();
            GetUnit();
        }

        private void GetUnit()
        {
            var unitSellData = ParameterService.GetParameter(PARAMETERCODE.UNITSELL);

            cboUnit.DisplayMember = "NAME";
            cboUnit.ValueMember = "MINOR_CODE";
            cboUnit.DataSource = unitSellData;
        }
        void LoadTexboxComplete()
        { 
            List<ProductAutoCompleteDTO> data = new List<ProductAutoCompleteDTO>();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            data = ProductService.GetProductAutoComplete();

            coll.AddRange(data.Select(s => s.PRODUCT_NAME).ToArray());
            coll.AddRange(data.Select(s => s.PRODUCT_ID.ToString()).ToArray());

            txtProductName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductName.AutoCompleteCustomSource = coll;
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            INV_PRODUCTS obj = new INV_PRODUCTS();
            var productName = ((TextBox)txtProductName).Text;

            var sp = productName.Split('-');
            var pid = ProductService.GetProduct(sp[1], string.Empty).Select(s => s.PRODUCT_ID).FirstOrDefault();
            PID = pid;

            var objInv = InvService.GetAllInventory2(pid).SingleOrDefault();
            txtCostAvgItem.Text = objInv.AVG_ITEM.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            INV_PRODUCTS obj = new INV_PRODUCTS();

            bool isSuccess = false;
            string unit = string.Empty;
            unit = cboUnit.SelectedValue == null ? string.Empty : cboUnit.SelectedValue.ToString();

            obj.RETAILPRICE = string.IsNullOrEmpty(txtRetailprice.Text) ? 0 : decimal.Parse(txtRetailprice.Text);

            obj.PRODUCT_ID = PID; //master
            obj.PRODUCT_ID2 = pModel.PRODUCT_ID;
            obj.UNIT = unit;
            
            obj.REMARK = txtRemark.Text;
            obj.C_BY = UserModel.USERNAME;
            obj.E_BY = UserModel.USERNAME;

            isSuccess = InvService.InsertInventory2(obj);
        }

        private void dgvInv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pModel = new InventoryDTO();
            string code = dgvInv.CurrentRow.Cells["PRODUCT_CODE"].Value.ToString();
        }
    }
}
