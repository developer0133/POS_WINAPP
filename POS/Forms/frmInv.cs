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

namespace POS.Forms
{
    public partial class frmInv : Form
    {
        public frmInv()
        {
            InitializeComponent();
            this.InitPage();
        }

        void InitPage()
        {
            invdate.CustomFormat = "MMMM dd, yyyy - dddd";
            invdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            

            LoadTexboxComplete();
            GetUnit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var test = invdate.Value;
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

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PriceCaculate();
        }

        private void PriceCaculate()
        {
            object objUnit = cboUnit.SelectedItem;
            int con1 = string.IsNullOrEmpty(((PARAMETER)objUnit).CONDITION1) ? 0 : int.Parse(((PARAMETER)objUnit).CONDITION1);
            int con2 = string.IsNullOrEmpty(((PARAMETER)objUnit).CONDITION2) ? 0 : int.Parse(((PARAMETER)objUnit).CONDITION2);
            decimal amount = 0;
            amount = string.IsNullOrEmpty(txtAmount.Text) ? 0 : decimal.Parse(txtAmount.Text);

            int qtyTotal = 0;
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
                    }
                       
                }
                else
                {
                    if (con1 > 0)
                    {
                        var qtyPack = tmpQty * con1;
                        var calitem = (amount / qtyPack);
                        var calpack = (amount / tmpQty);

                        packPrice = calitem;
                        itemPrice = calpack;
                    }
                    else
                    {
                        var cal = (amount / tmpQty);
                        packPrice = cal;
                        itemPrice = cal;
                    }
                }
            }

            txtCostAvgItem.Text = itemPrice.ToString("#,###.00");
            txtCostAvgPack.Text = packPrice.ToString("#,###.00");
        }


        private void ProfitCalculate(string flag, decimal price, decimal cost)
        {
            decimal _cost = cost;
            decimal _price = price;
            decimal _avgPack = 0;
            decimal _wholeSale = 0;
            decimal _retailPrice = 0;
            decimal _avgItem = 0;

            object objUnit = cboUnit.SelectedItem;
            string objName = string.IsNullOrEmpty(((PARAMETER)objUnit).NAME) ? string.Empty : ((PARAMETER)objUnit).NAME;
            int con1 = string.IsNullOrEmpty(((PARAMETER)objUnit).CONDITION1) ? 0 : int.Parse(((PARAMETER)objUnit).CONDITION1);
            int con2 = string.IsNullOrEmpty(((PARAMETER)objUnit).CONDITION2) ? 0 : int.Parse(((PARAMETER)objUnit).CONDITION2);
            decimal amount = string.IsNullOrEmpty(txtAmount.Text) ? 0 : decimal.Parse(txtAmount.Text);

            if (flag == "w")
            {
                _avgPack = decimal.Parse(txtCostAvgPack.Text);
                _wholeSale = decimal.Parse(txtWholesaleprice.Text);
                var cal = (_wholeSale - _avgPack);
                txtWholesaleprofit.Text = cal.ToString("#,###.00");

                if (con1 == 0)
                {
                    var cal2 = (_wholeSale / con2);
                    txtWholesalePriceItem.Text = cal2.ToString("#,###.00");

                    if (objName.Contains("ลัง"))
                    {
                        txtBoxprice.Text = (cal2 * con2).ToString("#,###.00");
                    }
                }
                else
                {
                    var cal2 = (_wholeSale / con1);
                    txtWholesalePriceItem.Text = cal2.ToString("#,###.00");

                    if (objName.Contains("ลัง"))
                    {
                        txtBoxprice.Text = (cal2 * con2).ToString("#,###.00");
                    }
                }

                if (con1 > 0 && con2 > 0)
                {
                    var w = decimal.Parse(txtWholesalePriceItem.Text);

                    if (objName.Contains("ลัง"))
                    {
                        txtBoxprice.Text = (w * con1 * con2).ToString("#,###.00");
                    }

                }
            }
            else
            {
                _retailPrice = decimal.Parse(txtRetailprice.Text);
                _avgItem = decimal.Parse(txtCostAvgItem.Text);
                var cal = _retailPrice - _avgItem;
                txtProfitRetail.Text = cal.ToString("#,###.00");
            }
        }
        private void QtyBalance()
        {

        }

        ////private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        ////{
        ////    //
        ////    if (e.KeyCode == Keys.Enter)
        ////    {
        ////        MessageBox.Show("You pressed enter! Good job!");
        ////    }
        ////}

        private void txtWholesaleprice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWholesaleprice.Text))
            {
                this.ProfitCalculate("w", 0, decimal.Parse(txtWholesaleprice.Text));
            }
        }

        private void txtRetailprice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRetailprice.Text))
            {
                this.ProfitCalculate("r", 0, decimal.Parse(txtRetailprice.Text));
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            this.PriceCaculate();
        }
    }
}
