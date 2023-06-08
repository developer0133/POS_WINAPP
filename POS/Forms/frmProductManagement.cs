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
        List<InventoryDTO> dt = null;
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
            BindDGV();
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

            if (!string.IsNullOrEmpty(sp[1]))
            {
                var pid = ProductService.GetProduct(sp[1], string.Empty).Select(s => s.PRODUCT_ID).FirstOrDefault();
                PID = pid;

                var objInv = InvService.GetAllInventory2(pid).SingleOrDefault();
                txtCostAvgItem.Text = objInv.AVG_ITEM.ToString();
            }
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

        private void ProfitCalculate()
        {
            decimal _avgPack = 0;
            decimal _wholeSale = 0;
            decimal _retailPrice = 0;
            decimal _avgItem = 0;
            string objName = string.Empty;
            int con1 = 0;
            int con2 = 0;
            decimal amount = 0;

            _retailPrice = decimal.Parse(txtRetailprice.Text);
            _avgItem = decimal.Parse(txtCostAvgItem.Text);
            var cal = _retailPrice - _avgItem;
            txtProfitRetail.Text = cal.ToString("#,###.00");
        }

        private void txtRetailprice_TextChanged(object sender, EventArgs e)
        {
            ProfitCalculate();
        }

        private void BindDGV()
        {
            dt = new List<InventoryDTO>();

            dgvInv.Columns.Clear();
            dgvInv.DataSource = null;
            var invData = InvService.GetAllInventory2(null);
         

            var tmp = (from a in invData
                       select new
                       {
                           INV_ID = a.INV_ID,
                           PRODUCT_CODE = a.PRODUCT_CODE,
                           PRODUCT_NAME = a.PRODUCT_NAME,
                           //STR_ORDERDATE = a.STR_ORDERDATE,
                           //QTY = a.QTY,
                           STR_UNIT = a.STR_UNIT,
                           RETAILPRICE = a.RETAILPRICE,
                           REMARK = a.REMARK,
                       }).ToList();

            dgvInv.DataSource = tmp;

            dgvInv.Columns[0].HeaderText = "ID";
            dgvInv.Columns[1].HeaderText = "รหัสสินค้า";
            dgvInv.Columns[2].HeaderText = "ชื่อสินค้า";
            dgvInv.Columns[3].HeaderText = "หน่วย";
            dgvInv.Columns[4].HeaderText = "ราคาขาย";
            dgvInv.Columns[5].HeaderText = "หมายเหตุ";

            dgvInv.Columns[0].Width = 130;
            dgvInv.Columns[1].Width = 130;
            dgvInv.Columns[2].Width = 100;
            dgvInv.Columns[3].Width = 100;
            dgvInv.Columns[4].Width = 100;
            dgvInv.Columns[5].Width = 130;
  
            dgvInv.Columns[0].Name = "INV_ID";
            dgvInv.Columns[1].Name = "PRODUCT_CODE";
            dgvInv.Columns[2].Name = "PRODUCT_NAME";
            dgvInv.Columns[3].Name = "STR_UNIT";
            dgvInv.Columns[4].Name = "RETAILPRICE";
            dgvInv.Columns[5].Name = "REMARK";


            dgvInv.Columns[0].DataPropertyName = "INV_ID";
            dgvInv.Columns[1].DataPropertyName = "PRODUCT_CODE";
            dgvInv.Columns[2].DataPropertyName = "PRODUCT_NAME";
            dgvInv.Columns[3].DataPropertyName = "STR_UNIT";
            dgvInv.Columns[4].DataPropertyName = "RETAILPRICE";
            dgvInv.Columns[5].DataPropertyName = "REMARK";


           // dgvInv.Columns[6].Visible = false;
           // dgvInv.Columns[7].Visible = false;
  
        }
    }
}
