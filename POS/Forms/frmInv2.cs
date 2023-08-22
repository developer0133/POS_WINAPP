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
using System.Net.NetworkInformation;

namespace POS.Forms
{
    public partial class frmInv2 : Form
    {
        List<InventoryDTO> dt = null;
        InventoryDTO pModel = null;
        List<PARAMETER> dtUnit = null;
        public frmInv2()
        {
            InitializeComponent();
            this.InitPage();
        }

        void InitPage()
        {
            invdate.CustomFormat = "MMMM dd, yyyy - dddd";
            invdate.Format = DateTimePickerFormat.Short;

            LoadTexboxComplete();
            GetUnit();
            BindDGV(string.Empty);
        }

        void LoadTexboxComplete()
        {
            List<ProductAutoCompleteDTO> data = new List<ProductAutoCompleteDTO>();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            data = ProductService.GetProductAutoComplete();

            coll.AddRange(data.Select(s => s.PRODUCT_NAME).ToArray());

            txtProductName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProductName.AutoCompleteCustomSource = coll;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void GetUnit()
        {
            var parm = ParameterService.GetParameter(PARAMETERCODE.UNIT);

            cboUnit.DisplayMember = "NAME";
            cboUnit.ValueMember = "MINOR_CODE";
            cboUnit.DataSource = parm;

            dtUnit = parm;
        }

        private void txtRetailprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtWholesaleprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PriceCaculate()
        {
            object objUnit = cboUnit.SelectedItem;

            if (objUnit != null)
            {
                decimal con1 = string.IsNullOrEmpty(((PARAMETER)objUnit).CONDITION1) ? 0 : decimal.Parse(((PARAMETER)objUnit).CONDITION1);
                decimal con2 = string.IsNullOrEmpty(((PARAMETER)objUnit).CONDITION2) ? 0 : decimal.Parse(((PARAMETER)objUnit).CONDITION2);
                decimal amount = 0;
                amount = string.IsNullOrEmpty(txtAmount.Text) ? 0 : decimal.Parse(txtAmount.Text);

                decimal qtyTotal = 0;
                int tmpQty = string.IsNullOrEmpty(txtQty.Text) ? 0 : int.Parse(txtQty.Text);
                decimal packPrice = 0;
                decimal itemPrice = 0;


                if (con1 > 0 && con2 > 0)
                {
                    qtyTotal = con1 * con2;

                    if (amount > 0 && tmpQty > 0)
                    {
                        var calPack = (amount / con2) / (tmpQty);
                        packPrice = calPack;

                        var calItem = (amount / qtyTotal) / (tmpQty);
                        itemPrice = calItem;
                    }
                }
                else
                {
                    if (con1 == 0 && con2 > 0)
                    {
                        if (amount > 0 && tmpQty > 0)
                        {
                            var calPack = (amount / tmpQty);
                            packPrice = calPack;

                            var calItem = (amount) / (tmpQty * con2);
                            itemPrice = calItem;

                            string strName = txtProductName.Text;

                            if (strName.Contains("ท่อ"))
                            {
                                itemPrice = packPrice;
                            }
                        }

                    }
                    else
                    {
                        if (con1 > 0)
                        {
                            var qtyPack = tmpQty * con1;
                            decimal calitem = 0; //(amount / qtyPack);
                            decimal calpack = 0; //(amount / tmpQty);

                            if (amount > 0 && qtyPack > 0)
                            {
                                calitem = (amount / qtyPack);
                            }

                            if (amount > 0 && qtyPack > 0)
                            {
                                calpack = (amount / tmpQty);
                            }

                            packPrice = calitem;
                            itemPrice = calpack;
                        }
                        else
                        {
                            if (con1 == 0 && con2 == 0)
                            {
                                packPrice = 0;
                                itemPrice = 0;
                            }
                            try
                            {
                                var cal = (amount / tmpQty);
                                packPrice = cal;
                                itemPrice = cal;
                            }
                            catch
                            {
                                packPrice = 0;
                                itemPrice = 0;
                            }
                           
                        }
                    }
                }

                txtCostAvgItem.Text = itemPrice.ToString("#,###.00");
                txtCostAvgBox.Text = packPrice.ToString("#,###.00");

                this.QtyBalance();
            }
        }

        private void ProfitCalculate(string flag, decimal price, decimal cost)
        {
            decimal _cost = cost;
            decimal _price = price;
            decimal _avgPack = 0;
            decimal _wholeSale = 0;
            decimal _retailPrice = 0;
            decimal _avgItem = 0;
            string objName = string.Empty;
            int con1 = 0;
            int con2 = 0;
            decimal amount = 0;

            object objUnit = cboUnit.SelectedItem;
            if (objUnit != null)
            {
                objName = string.IsNullOrEmpty(((PARAMETER)objUnit).NAME) ? string.Empty : ((PARAMETER)objUnit).NAME;
                con1 = string.IsNullOrEmpty(((PARAMETER)objUnit).CONDITION1) ? 0 : int.Parse(((PARAMETER)objUnit).CONDITION1);
                con2 = string.IsNullOrEmpty(((PARAMETER)objUnit).CONDITION2) ? 0 : int.Parse(((PARAMETER)objUnit).CONDITION2);
                amount = string.IsNullOrEmpty(txtAmount.Text) ? 0 : decimal.Parse(txtAmount.Text);
            }

            //if (con1 != 0 && con2 != 0)
            //{

                /*if (flag == "w")
                {
                    
                    _wholeSale = decimal.Parse(txtWholesaleprice.Text);
                    var cal = (_wholeSale - _avgPack);
                    txtWholesaleprofit.Text = cal.ToString("#,###.00");

                    if (con1 == 0)
                    {
                        var cal2 = (_wholeSale / con2);
                        txtWholesalePriceItem.Text = cal2.ToString("#,###.00");

                        if (objName.Contains("ลัง"))
                        {
                            var calB = Math.Ceiling((cal2 * con2));
                           
                        }
                    }
                    else
                    {
                        var cal2 = (_wholeSale / con1);
                        txtWholesalePriceItem.Text = cal2.ToString("#,###.00");

                        if (objName.Contains("ลัง"))
                        {
                            var calB = Math.Ceiling((cal2 * con2));
                            
                        }
                    }

                    if (con1 > 0 && con2 > 0)
                    {
                        var w = decimal.Parse(txtWholesalePriceItem.Text);

                        if (objName.Contains("ลัง"))
                        {
                            var calB = Math.Ceiling((w * con1 * con2));
                            
                        }
                    }
                }*/
                
                
                    _retailPrice = decimal.Parse(txtRetailprice.Text);
                    _avgItem = decimal.Parse(txtCostAvgItem.Text);
                    var cal = _retailPrice - _avgItem;
                txtProfitRetail.Text = cal.ToString("#,###.00");
                
            //}
            //else
            //{


            //    txtBoxprice.Text = "0";
            //    txtProfitRetail.Text = "0";
            //}
        }
        private void QtyBalance()
        {
            var box = txtBoxBalance.Text;
            var pack = txtPackBalance.Text;
            var item = txtItemBalance.Text;

            object objUnit = cboUnit.SelectedItem;
            string objName = string.IsNullOrEmpty(((PARAMETER)objUnit).NAME) ? string.Empty : ((PARAMETER)objUnit).NAME;
            decimal con1 = string.IsNullOrEmpty(((PARAMETER)objUnit).CONDITION1) ? 0 : decimal.Parse(((PARAMETER)objUnit).CONDITION1);
            decimal con2 = string.IsNullOrEmpty(((PARAMETER)objUnit).CONDITION2) ? 0 : decimal.Parse(((PARAMETER)objUnit).CONDITION2);

            var qtyTotal = 0;
            var flagPack = false;
            int qty = 0;
            qty = string.IsNullOrEmpty(txtQty.Text) ? 0 : int.Parse(txtQty.Text);

            if (con1 == 0 && con2 == 0)
            {
                txtPackBalance.Text = "0";
                txtItemBalance.Text = "0";
                txtBoxBalance.Text = "0";

                return;
            }

            if (con1 > 0)
            {
                flagPack = true;
            }

            var calpack = (qty * con2);
            if (con2 == 0)
            {
                calpack = (qty * con1);
            }
            if (con1 == 0)
            {
                calpack = 0;//(qty*con2);
            }

            var calitem = (qty * con1 * con2);
            if (con2 == 0)
            {
                calitem = (qty * con1);
            }
            if (con1 == 0)
            {
                calitem = (qty * con2);
            }

            if (objName.Contains("ลัง") || objName.Contains("โหล"))
            {
                txtBoxBalance.Text = qty.ToString();
                txtPackBalance.Text = calpack.ToString();

                if (objName.Contains("โหล"))
                {
                    txtPackBalance.Text = "0";
                }
                txtItemBalance.Text = calitem.ToString();
            }
            else if (objName.Contains("แพ็ค") || objName.Contains("ถาด") || objName.Contains("กล่อง") || objName.Contains("ห่อ"))
            {
                txtPackBalance.Text = qty.ToString();
                txtItemBalance.Text = calitem.ToString();

            }
            else
            {

                if (((PARAMETER)objUnit).MAJOR_CODE == "UNIT" && ((PARAMETER)objUnit).MINOR_CODE == "1016")
                {
                    txtItemBalance.Text = qty.ToString();
                }
                else
                {
                    txtItemBalance.Text = calitem.ToString();
                }
            }
        }

        //private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        MessageBox.Show("You pressed enter! Good job!");
        //    }
        //}

        private void txtWholesaleprice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRetailprice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRetailprice.Text))
            {
                this.ProfitCalculate("r", 0, decimal.Parse(txtRetailprice.Text));
            }
        }

        //private void txtAmount_TextChanged(object sender, EventArgs e)
        //{
        //    this.PriceCaculate();
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            INV_PRODUCTS obj = new INV_PRODUCTS();

            bool isSuccess = false;
            string unit = string.Empty;
            string msg = string.Empty;

            if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtQty.Text) || string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show(MESSAGEALERT.FULLFILL, "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                unit = cboUnit.SelectedValue == null ? "" : cboUnit.SelectedValue.ToString();

                obj.QTY = string.IsNullOrEmpty(txtQty.Text) ? 0 : int.Parse(txtQty.Text);
                obj.UNIT = unit;
                obj.AMOUNT = string.IsNullOrEmpty(txtAmount.Text) ? 0 : decimal.Parse(txtAmount.Text);
                obj.AVG_ITEM = string.IsNullOrEmpty(txtCostAvgItem.Text) ? 0 : decimal.Parse(txtCostAvgItem.Text);
                //obj.AVG_PACK = string.IsNullOrEmpty(txtCostAvgPack.Text) ? 0 : decimal.Parse(txtCostAvgPack.Text);
                obj.RETAILPRICE = string.IsNullOrEmpty(txtRetailprice.Text) ? 0 : decimal.Parse(txtRetailprice.Text);
                obj.WHOLESALEPRICE = 0; //string.IsNullOrEmpty(txtWholesaleprice.Text) ? 0 : decimal.Parse(txtWholesaleprice.Text);


                obj.RETAILPROFIT = string.IsNullOrEmpty(txtProfitRetail.Text) ? 0 : decimal.Parse(txtProfitRetail.Text);
                obj.WHOLESALEPROFIT = string.IsNullOrEmpty(txtWholesaleprofit.Text) ? 0 : decimal.Parse(txtWholesaleprofit.Text);
                obj.WHOLESALEPROFIT = string.IsNullOrEmpty(txtWholesaleprofit.Text) ? 0 : decimal.Parse(txtWholesaleprofit.Text);
                obj.WHOLESALEPRICE_ITEM = string.IsNullOrEmpty(txtWholesalePriceItem.Text) ? 0 : decimal.Parse(txtWholesalePriceItem.Text);

                obj.BOX_BALANCE = string.IsNullOrEmpty(txtBoxBalance.Text) ? 0 : decimal.Parse(txtBoxBalance.Text);
                obj.PACK_BALANCE = string.IsNullOrEmpty(txtPackBalance.Text) ? 0 : decimal.Parse(txtPackBalance.Text);
                obj.ITEM_BALANCE = string.IsNullOrEmpty(txtItemBalance.Text) ? 0 : decimal.Parse(txtItemBalance.Text);
                obj.REMARK = txtRemark.Text;
                obj.TOTAL_AMOUNT = string.IsNullOrEmpty(txtAmount.Text) ? 0 : decimal.Parse(txtAmount.Text);
                obj.AVGCOST = string.IsNullOrEmpty(txtCostAvgBox.Text) ? 0 : decimal.Parse(txtCostAvgBox.Text);

                obj.ORDER_DATE = invdate.Value;
                obj.C_BY = UserModel.USERNAME;
                obj.E_BY = UserModel.USERNAME;


                if (pModel != null && pModel.PRODUCT_ID > 0 && pModel.INV_ID > 0)
                {
                    ////update 
                    obj.PRODUCT_ID = pModel.PRODUCT_ID;
                    obj.INV_ID = pModel.INV_ID;
                    isSuccess = InvService.UpdateInventory2(obj);
                }
                else
                {
                    var name = txtProductName.Text;
                    var sp = name.Split('-');
                    var pid = ProductService.GetProduct(sp[1], string.Empty).Select(s => s.PRODUCT_ID).FirstOrDefault();

                    if (pid == 0)
                    {
                        pid = ProductService.GetProductByCODE(sp[1]).PRODUCT_ID;
                        obj.PRODUCT_ID = pid;
                    }

                    obj.PRODUCT_ID = pid;
                    obj.PRODUCT_ID2 = pid;

                   
                    isSuccess = InvService.UpdateINV2(obj, ref msg); // InvService.InsertInventory2(obj);
                }

                if (isSuccess)
                {
                    MessageBox.Show(MESSAGEALERT.COMPLETED, "POS");
                    BindDGV(string.Empty);
                    Clear();
                }
                else
                {
                    MessageBox.Show(msg, "POS");
                }
            }
        }

        private void BindDGV(string code)
        {
            dt = new List<InventoryDTO>();

            dgvInv.Columns.Clear();
            dgvInv.DataSource = null;
            var invData = InvService.GetAllInventory(code);
          

            var tmp = (from a in invData
                       select new 
                       {
                           INV_ID=a.INV_ID,
                           PRODUCT_CODE=a.PRODUCT_CODE,
                           PRODUCT_NAME = a.PRODUCT_NAME,
                           STR_ORDERDATE = a.STR_ORDERDATE,
                           QTY = a.QTY,
                           STR_UNIT = a.STR_UNIT,
                           STR_TOTAL_AMOUNT = a.STR_TOTAL_AMOUNT,
                           REMARK = a.REMARK,
                       }).ToList();

            dgvInv.DataSource = tmp;

            dgvInv.Columns[0].HeaderText = "ID";
            dgvInv.Columns[1].HeaderText = "รหัสสินค้า";
            dgvInv.Columns[2].HeaderText = "ชื่อสินค้า";
            dgvInv.Columns[3].HeaderText = "วันที่สั่ง";
            dgvInv.Columns[4].HeaderText = "จำนวน";
            dgvInv.Columns[5].HeaderText = "หน่วย";
            dgvInv.Columns[6].HeaderText = "รวมสุทธิ(บาท)";
            dgvInv.Columns[7].HeaderText = "หมายเหตุ";

            dgvInv.Columns[0].Width = 130;
            dgvInv.Columns[1].Width = 130;
            dgvInv.Columns[2].Width = 100;
            dgvInv.Columns[3].Width = 100;
            dgvInv.Columns[4].Width = 100;
            dgvInv.Columns[5].Width = 130;
            dgvInv.Columns[6].Width = 130;
            dgvInv.Columns[7].Width = 130;

            dgvInv.Columns[0].Name = "INV_ID";
            dgvInv.Columns[1].Name = "PRODUCT_CODE";
            dgvInv.Columns[2].Name = "PRODUCT_NAME";
            dgvInv.Columns[3].Name = "STR_ORDERDATE";
            dgvInv.Columns[4].Name = "QTY";
            dgvInv.Columns[5].Name = "STR_UNIT";
            dgvInv.Columns[6].Name = "STR_TOTAL_AMOUNT";
            dgvInv.Columns[7].Name = "REMARK";

            dgvInv.Columns[0].DataPropertyName = "INV_ID";
            dgvInv.Columns[1].DataPropertyName = "PRODUCT_CODE";
            dgvInv.Columns[2].DataPropertyName = "PRODUCT_NAME";
            dgvInv.Columns[3].DataPropertyName = "STR_ORDERDATE";
            dgvInv.Columns[4].DataPropertyName = "QTY";
            dgvInv.Columns[5].DataPropertyName = "STR_UNIT";
            dgvInv.Columns[6].DataPropertyName = "STR_TOTAL_AMOUNT";
            dgvInv.Columns[7].DataPropertyName = "REMARK";

            clsFunction.FormatHeaderDatagrid(dgvInv);
        }

        private void dgvInv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInv.CurrentRow.Index != -1)
            {
                pModel = new InventoryDTO();
                string code = dgvInv.CurrentRow.Cells["PRODUCT_CODE"].Value.ToString();
                int invid = int.Parse(dgvInv.CurrentRow.Cells["INV_ID"].Value.ToString());

                pModel = InvService.GetAllInventory(code).SingleOrDefault();

                if (pModel != null)
                {
                    txtQty.Text = pModel.QTY.ToString();
                    cboUnit.SelectedValue = pModel.UNIT;
                    txtAmount.Text = pModel.TOTAL_AMOUNT.HasValue ? pModel.TOTAL_AMOUNT.Value.ToString() : string.Empty;
                    txtCostAvgItem.Text = pModel.AVG_ITEM.HasValue ? pModel.AVG_ITEM.Value.ToString() : string.Empty;
                    txtCostAvgBox.Text = pModel.AVGCOST.HasValue ? pModel.AVGCOST.Value.ToString() : string.Empty;
                    //txtCostAvgPack.Text = pModel.AVG_PACK.HasValue ? pModel.AVG_PACK.Value.ToString() : string.Empty;
                    txtRetailprice.Text = pModel.RETAILPRICE.HasValue ? pModel.RETAILPRICE.Value.ToString() : string.Empty;
                    //txtWholesaleprice.Text = pModel.WHOLESALEPRICE.HasValue ? pModel.WHOLESALEPRICE.Value.ToString() : string.Empty;
                   
                    txtProfitRetail.Text=pModel.RETAILPROFIT.HasValue ? pModel.RETAILPROFIT.Value.ToString() : string.Empty;
                    txtWholesaleprofit.Text = pModel.WHOLESALEPROFIT.HasValue ? pModel.WHOLESALEPROFIT.Value.ToString() : string.Empty;
                    txtWholesalePriceItem.Text = pModel.WHOLESALEPRICE_ITEM.HasValue ? pModel.WHOLESALEPRICE_ITEM.Value.ToString() : string.Empty;

                    txtBoxBalance.Text=pModel.BOX_BALANCE.HasValue ? pModel.BOX_BALANCE.Value.ToString() : string.Empty;
                    txtPackBalance.Text = pModel.PACK_BALANCE.HasValue ? pModel.PACK_BALANCE.Value.ToString() : string.Empty;
                    txtItemBalance.Text = pModel.ITEM_BALANCE.HasValue ? pModel.ITEM_BALANCE.Value.ToString() : string.Empty;
                    invdate.Value = pModel.ORDER_DATE.Value;
                    txtProductName.Text = pModel.PRODUCT_NAME;
                    txtRemark.Text = pModel.REMARK;
                }
            }
        }

        private void frmInv_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtQty.Clear();
            txtAmount.Clear();
            txtCostAvgItem.Clear();
           
            txtRetailprice.Clear();
            //txtWholesaleprice.Clear();
          
            txtProfitRetail.Clear();
            txtWholesaleprofit.Clear();
            txtWholesalePriceItem.Clear();
            txtBoxBalance.Clear();
            txtPackBalance.Clear();
            txtItemBalance.Clear();
            txtProductName.Clear();
            txtRemark.Clear();

            pModel = new InventoryDTO();//test

        }

        private void cboUnit_DropDownClosed(object sender, EventArgs e)
        {
            this.PriceCaculate();
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            this.PriceCaculate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDGV(txtSearch.Text);
        }

        private void cboUnit_TextChanged(object sender, EventArgs e)
        {

            //DataTable dt = (DataTable)cboUnit.DataSource;
            //var qry = from DataRow dr in dt.Rows
            //          where dr["Name"].ToString().ToLower().Contains(cboUnit.Text)
            //          select dr;
            //dt = qry.CopyToDataTable();
            //this.cboUnit.DataSource = dt;


            //if (cboUnit.Text.Length > 1)
            //{
            //    if (dtUnit !=null)
            //    {
            //        var parm = dtUnit.Where(w => w.NAME.Contains(cboUnit.Text));

            //        //cboUnit.DisplayMember = "NAME";
            //        //cboUnit.ValueMember = "MINOR_CODE";
            //        cboUnit.DroppedDown = true ;
            //    }

            //}

        }

        private void UpdateData()
        {
            if (cboUnit.Text.Length > 1)
            {
                //List<string> searchData = ParameterService.GetParameter(PARAMETERCODE.UNIT, cboUnit.Text.ToLower());
                HandleTextChanged();
            }
        }


        private void HandleTextChanged()
        {
            var text = cboUnit.Text;

            var dataSource = ParameterService.GetParameter(PARAMETERCODE.UNIT, cboUnit.Text.ToLower());
            if (dataSource.Count() > 0)
            {
                cboUnit.DataSource = dataSource;

                var sText = cboUnit.Items[0].ToString();
                cboUnit.SelectionStart = text.Length;
                cboUnit.SelectionLength = sText.Length - text.Length;
                cboUnit.DroppedDown = true;


                return;
            }
            else
            {
                cboUnit.DroppedDown = false;
                cboUnit.SelectionStart = text.Length;
            }
        }
    }
}
