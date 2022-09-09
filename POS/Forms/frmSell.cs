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
        List<string> pcode = new List<string>();
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
                this.txtBarcode.Clear();
            }
        }

        void PushDataGV()
        {
            string code = txtBarcode.Text;

            obj = ProductService.GetProduct(code).SingleOrDefault();

            if (obj != null)
            {
                var strUnit = InvService.SRTUNIT(obj.PRODUCT_ID);

                DataGridViewRow row = (DataGridViewRow)dgvSell.Rows[0].Clone();
                row.Cells[0].Value = obj.PRODUCT_NAME;
                row.Cells[8].Value = obj.PRODUCT_CODE;//obj.STRSELLPRICE;
                //row.Cells[1].Value = 1;
                row.Cells[2].Value = strUnit;
                row.Cells[3].Value = obj.SELLPRICE;//obj.STRSELLPRICE;

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
  
            //dgvSell.Rows[dgvSell.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
            //dgvSell.Rows[dgvSell.Rows.Count - 1].DefaultCellStyle.SelectionBackColor = Color.Red;
            dgvSell.Rows[dgvSell.Rows.Count - 1].Cells[4].Style.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            dgvSell.Rows[dgvSell.Rows.Count - 1].Cells[4].Value = "รวมทั้งสิ้น";

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

            disc = dgvSell.CurrentRow.Cells["Discount"].Value == null ? 0 : decimal.Parse(dgvSell.CurrentRow.Cells["Discount"].Value.ToString());
            qty = dgvSell.CurrentRow.Cells["Qty"].Value == null ? 0 : decimal.Parse(dgvSell.CurrentRow.Cells["Qty"].Value.ToString());
            price = dgvSell.CurrentRow.Cells["SellPrice"].Value == null ? 0 : decimal.Parse(dgvSell.CurrentRow.Cells["SellPrice"].Value.ToString());

            sum = (price * qty) - (disc);

            dgvSell.CurrentRow.Cells[5].Value = sum.ToString();

            decimal total = 0;
            for (int j = 0; j < dgvSell.Rows.Count - 1; j++)
            {
                if (dgvSell.Rows[j].Cells[5].Value != null)
                {
                    total += decimal.Parse(dgvSell.Rows[j].Cells[5].Value.ToString());
                }
            }

            dgvSell.Rows[dgvSell.Rows.Count - 1].Cells[5].Value = total.ToString("#,###.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtBarcode.Clear();
            this.dgvSell.Rows.Clear();
            pcode = new List<string>();
            obj = new ProductDTO();
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
    }
}
