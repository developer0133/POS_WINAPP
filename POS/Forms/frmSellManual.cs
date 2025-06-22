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
    public partial class frmSellManual : Form
    {
        public frmSellManual()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvSell.Rows[0].Clone();
            row.Cells[0].Value = txtProductName.Text;
            row.Cells[1].Value = txtQty.Text;
            row.Cells[2].Value = txtUnit.Text; // obj.SELLPRICE;//obj.STRSELLPRICE;
            row.Cells[3].Value = txtPrice.Text;
            row.Cells[4].Value = txtDis.Text;

            txtDis.Text = string.IsNullOrEmpty(txtDis.Text) ? "0" : txtDis.Text;    
            var total = Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtPrice.Text)- Convert.ToDecimal(txtDis.Text);
            row.Cells[5].Value = total.ToString();

            dgvSell.Rows.Add(row);
            foreach (DataGridViewRow rw in dgvSell.Rows)
            {
                rw.HeaderCell.Value = (rw.Index + 1).ToString();
                rw.Cells[0].Style.BackColor = Color.DarkGray;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
    }
}
