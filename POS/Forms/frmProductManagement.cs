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
        private int MasterID = 0;
        string CON1 = string.Empty;
        string CON2 = string.Empty;
        string UNITNAME = string.Empty;
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
            var unitSellData = ParameterService.GetParameter(PARAMETERCODE.UNIT);

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

            if (!string.IsNullOrEmpty(productName))
            {
                var sp = productName.Split('-');

                if (sp.Count() > 0 && sp.Count() >= 2)
                {
                    if (!string.IsNullOrEmpty(sp[1]))
                    {
                        var pid = ProductService.GetProduct(sp[1], string.Empty).Select(s => s.PRODUCT_ID).FirstOrDefault();
                        var productObj = ProductService.GetProductParent(sp[1]).FirstOrDefault();

                        if (productObj != null)
                        {
                            PID = productObj.PRODUCT_ID;
                            MasterID = pid;

                            var objInv = InvService.GetAllInventory2(PID).SingleOrDefault();

                            if (objInv != null)
                            {
                                txtCostAvgItem.Text = objInv.AVGCOST.HasValue ? objInv.AVGCOST.Value.ToString() : string.Empty;
                                txtWholesalePriceItem.Text = objInv.AVG_ITEM.HasValue ? objInv.AVG_ITEM.Value.ToString() : string.Empty;
                            }
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            INV_PRODUCTS obj = new INV_PRODUCTS();

            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtRetailprice.Text))
            {
                MessageBox.Show("กรุณาระบุข้อมูล", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool isSuccess = false;
                string unit = string.Empty;
                string msg = string.Empty;
                unit = cboUnit.SelectedValue == null ? string.Empty : cboUnit.SelectedValue.ToString();

                obj.RETAILPRICE = string.IsNullOrEmpty(txtRetailprice.Text) ? 0 : decimal.Parse(txtRetailprice.Text);

                obj.PRODUCT_ID = PID; //master
                obj.PRODUCT_ID2 = MasterID; // pModel.PRODUCT_ID;
                obj.UNIT = unit;

                if (!string.IsNullOrEmpty(txtProfitRetail.Text))
                {
                    obj.RETAILPROFIT = decimal.Parse(txtProfitRetail.Text);
                }
               
                obj.REMARK = txtRemark.Text;
                obj.C_BY = UserModel.USERNAME;
                obj.E_BY = UserModel.USERNAME;

                if (pModel != null)
                {
                    if (pModel.INV_ID > 0)
                    {
                        obj.PRODUCT_ID = pModel.PRODUCT_ID;
                        obj.INV_ID = pModel.INV_ID;
                        isSuccess = InvService.UpdateInventory2(obj);
                    }
                    else
                    {
                        isSuccess = InvService.UpdateINV2(obj, ref msg);//InvService.InsertInventory2(obj);
                    }
                }

                if (isSuccess)
                {
                    MessageBox.Show("Completed", "POS", MessageBoxButtons.OK);
                    BindDGV();
                    Clear();
                }
            }
        }

        private void Clear()
        {
            txtCostAvgItem.Clear();

            txtRetailprice.Clear();
            txtProfitRetail.Clear();
            txtWholesaleprofit.Clear();
            txtWholesalePriceItem.Clear();
            txtProductName.Clear();
            txtRemark.Clear();

            pModel = new InventoryDTO();
        }

        private void dgvInv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pModel = new InventoryDTO();
            string code = dgvInv.CurrentRow.Cells["PRODUCT_CODE"].Value.ToString();
            int id = Convert.ToInt32(dgvInv.CurrentRow.Cells["PRODUCT_ID"].Value.ToString());

            if (dgvInv.CurrentRow.Index != -1)
            {
                pModel = InvService.GetAllInventory2(id).SingleOrDefault();

                if (pModel != null)
                {
                    cboUnit.SelectedValue = pModel.UNIT;
                    txtProductName.Text = pModel.PRODUCT_NAME;
                    txtRetailprice.Text = pModel.RETAILPRICE.HasValue ? pModel.RETAILPRICE.Value.ToString() : string.Empty;
                    txtCostAvgItem.Text = pModel.AVG_ITEM.HasValue ? pModel.AVG_ITEM.Value.ToString() : string.Empty;
                    txtRemark.Text = pModel.REMARK;

                    txtProfitRetail.Text = pModel.RETAILPROFIT.HasValue ? pModel.RETAILPROFIT.Value.ToString() : string.Empty;
                    txtWholesaleprofit.Text = pModel.WHOLESALEPROFIT.HasValue ? pModel.WHOLESALEPROFIT.Value.ToString() : string.Empty;
                    txtWholesalePriceItem.Text = pModel.WHOLESALEPRICE_ITEM.HasValue ? pModel.WHOLESALEPRICE_ITEM.Value.ToString() : string.Empty;
                }
            }
        }

        private void ProfitCalculate()
        {
            if (!string.IsNullOrEmpty(txtCostAvgItem.Text))
            {
                decimal _avgPack = 0;
                decimal _wholeSaleCost = 0;
                decimal _retailPrice = 0;
                decimal _avgItem = 0;
                string objName = string.Empty;
                int con1 = 0;
                int con2 = 0;
                decimal amount = 0;

                if (!string.IsNullOrEmpty(UNITNAME))
                {
                    _retailPrice = !string.IsNullOrEmpty(txtRetailprice.Text) ? decimal.Parse(txtRetailprice.Text) : 0;
                    _avgItem = !string.IsNullOrEmpty(txtCostAvgItem.Text) ? decimal.Parse(txtCostAvgItem.Text) : 0;

                    //var cal = _retailPrice - _avgItem;
                    //txtProfitRetail.Text = cal.ToString("#,###.00");


                    if (UNITNAME.Contains("ขีด"))
                    {
                        if (!string.IsNullOrEmpty(txtWholesalePriceItem.Text))
                        {
                            _wholeSaleCost = decimal.Parse(txtWholesalePriceItem.Text);
                            decimal cal1 = 0;
                            decimal cal2 = 0;

                            cal1 = _wholeSaleCost / 10;
                            cal2 = _retailPrice - cal1;

                            txtProfitRetail.Text = cal2.ToString("#,###.00");
                        }
                    }
                    if (UNITNAME.Contains("กิโล") || UNITNAME.Contains("ก.ก.") || UNITNAME.Contains("กก."))
                    {
                        if (UNITNAME.Contains("ลัง"))
                        {
                            var cal = _retailPrice - _avgItem;
                            txtProfitRetail.Text = cal.ToString("#,###.00");
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(txtWholesalePriceItem.Text))
                            {
                                _wholeSaleCost = decimal.Parse(txtWholesalePriceItem.Text);
                                decimal cal1 = 0;
                                decimal cal2 = 0;

                                cal1 = _wholeSaleCost;
                                cal2 = _retailPrice - cal1;

                                txtProfitRetail.Text = cal2.ToString("#,###.00");
                            }
                        }
                        
                    }
                    else
                    {
                        var cal = _retailPrice - _avgItem;
                        txtProfitRetail.Text = cal.ToString("#,###.00");
                    }
                }
            }
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
            var invData = InvService.GetProductParent(null);

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
                           PRODUCT_ID = a.PRODUCT_ID
                       }).ToList();

            dgvInv.DataSource = tmp;
            SetColumnDGV();
        }

        private void SetColumnDGV()
        {
            dgvInv.Columns[0].HeaderText = "ID";
            dgvInv.Columns[1].HeaderText = "รหัสสินค้า";
            dgvInv.Columns[2].HeaderText = "ชื่อสินค้า";
            dgvInv.Columns[3].HeaderText = "หน่วย";
            dgvInv.Columns[4].HeaderText = "ราคาขาย";
            dgvInv.Columns[5].HeaderText = "หมายเหตุ";
            dgvInv.Columns[6].HeaderText = "PRODUCT_ID";

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
            dgvInv.Columns[6].Name = "PRODUCT_ID";

            dgvInv.Columns[0].DataPropertyName = "INV_ID";
            dgvInv.Columns[1].DataPropertyName = "PRODUCT_CODE";
            dgvInv.Columns[2].DataPropertyName = "PRODUCT_NAME";
            dgvInv.Columns[3].DataPropertyName = "STR_UNIT";
            dgvInv.Columns[4].DataPropertyName = "RETAILPRICE";
            dgvInv.Columns[5].DataPropertyName = "REMARK";
            dgvInv.Columns[6].DataPropertyName = "PRODUCT_ID";

            dgvInv.Columns[6].Visible = false;

            POS.Utils.clsFunction.FormatHeaderDatagrid(dgvInv);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var tmp = InvService.GetAllInventory(txtSearch.Text);


            var tmp2 = (from a in tmp
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
                           PRODUCT_ID = a.PRODUCT_ID
                       }).ToList();


            dgvInv.DataSource = tmp2;
            SetColumnDGV();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUnit.Text.Length > 1)
            {
                var item = (PARAMETER)cboUnit.SelectedItem;
                int selectedIndex = cboUnit.SelectedIndex;
                CON1 = item.CONDITION1;
                CON2 = item.CONDITION2;
                UNITNAME = item.NAME;

                this.ProfitCalculate();
            }
               

        }
    }
}
