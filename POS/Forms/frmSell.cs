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

namespace POS.Forms
{
    public partial class frmSell : Form
    {
        ProductDTO obj = new ProductDTO();

        public frmSell()
        {
            InitializeComponent();


            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "";
            btnColumn.Width = 60;
            btnColumn.Name = "btndelete";
            btnColumn.Text = "ลบ";
            btnColumn.HeaderText = "ลบ";
            btnColumn.UseColumnTextForButtonValue = true;
            dgvSell.Columns.Insert(7, btnColumn);

           // dgvSell.CellValueChanged += new DataGridViewCellEventHandler(dgvSell_CellValueChanged);
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.PushDataGV();
            }
        }

        void PushDataGV()
        {
            string code = txtBarcode.Text;
          
            obj = ProductService.GetProduct(code).SingleOrDefault();

            if (obj != null)
            {
                DataGridViewRow row = (DataGridViewRow)dgvSell.Rows[0].Clone();
                row.Cells[0].Value = obj.PRODUCT_NAME;
                row.Cells[2].Value = obj.STRUNIT;
                row.Cells[3].Value = obj.RETAILPRICE;//obj.STRSELLPRICE;

                dgvSell.Rows.Add(row);
            }

            foreach (DataGridViewRow rw in dgvSell.Rows)
            {
                rw.HeaderCell.Value = (rw.Index + 1).ToString();
                rw.Cells[3].Style.BackColor = Color.DarkGray;
            }


           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var test211 = dgvSell.CurrentRow.Cells["Qty"].Value;

            //DataGridViewRow row = (DataGridViewRow)dgvSell.Rows[0].Clone();
            ////row.Cells[0].Value =+1;
            //row.Cells[1].Value = 50.2;
            //dgvSell.Rows.Add(row);

            ////DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            ////btnColumn.HeaderText = "";
            ////btnColumn.Width = 60;
            ////btnColumn.Name = "btndelete";
            ////btnColumn.Text = "ลบ";
            ////btnColumn.HeaderText = "ลบ";
            ////btnColumn.UseColumnTextForButtonValue = true;
            ////dgvSell.Columns.Insert(8, btnColumn);

            //foreach (DataGridViewRow rw in dgvSell.Rows)
            //    rw.HeaderCell.Value = (rw.Index + 1).ToString();
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


        void CalFn(int rowIndex)
        {
            if (obj != null)
            {
                if (dgvSell.CurrentRow.Index != -1)
                {
                    var _disc = Convert.ToInt32(dgvSell.CurrentRow.Cells["Discount"].Value);
                    var test2 = dgvSell.CurrentRow.Cells["Qty"].Value;
                }
                 
                //var _sellprice = value.current_Sellprice;
                //var _amt = value.sellprice;////value.amount; 
                //var currSalePrice = value.current_Sellprice;

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



            disc = dgvSell.CurrentRow.Cells["Discount"].Value == null ? 0 : decimal.Parse(dgvSell.CurrentRow.Cells["Discount"].Value.ToString());
            qty = decimal.Parse(dgvSell.CurrentRow.Cells["Qty"].Value.ToString());
            price = decimal.Parse(dgvSell.CurrentRow.Cells["SellPrice"].Value.ToString());

            sum = (price * qty) - (disc);

            dgvSell.CurrentRow.Cells[5].Value = sum.ToString();
        }
    }
}
