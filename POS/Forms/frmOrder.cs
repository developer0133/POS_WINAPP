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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.GetOrderHistory();

            clsFunction.FormatHeaderDatagrid(this.dgvOrder);
        }

        void GetOrderHistory()
        {
            dgvOrder.Columns.Clear();
            dgvOrder.DataSource = null;
            var orderData = OrderHistoryService.GetOrderHistory(0, rptDate.Value.ToShortDateString());

            if (orderData.Count == 0)
            {
                MessageBox.Show("ไม่พบข้อมูล", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dgvOrder.DataSource = orderData;

            dgvOrder.Columns[0].HeaderText = "รายการ";
            dgvOrder.Columns[1].HeaderText = "จำนวน";
            dgvOrder.Columns[2].HeaderText = "หน่วย";
            dgvOrder.Columns[3].HeaderText = "ราคา";
            dgvOrder.Columns[4].HeaderText = "รวม(THB)";
            dgvOrder.Columns[5].HeaderText = "ราคา/ชิ้น(บาท)";
            dgvOrder.Columns[6].HeaderText = "ราคา/โหล/แพ็ค(บาท)";
            dgvOrder.Columns[7].HeaderText = "หมายเหตุ";

            dgvOrder.Columns[0].Width = 130;
            dgvOrder.Columns[1].Width = 130;
            dgvOrder.Columns[2].Width = 100;
            dgvOrder.Columns[3].Width = 100;
            dgvOrder.Columns[4].Width = 100;
            dgvOrder.Columns[5].Width = 130;
            dgvOrder.Columns[6].Width = 130;
            dgvOrder.Columns[7].Width = 130;

            dgvOrder.Columns[0].Name = "PRODUCT_NAME";
            dgvOrder.Columns[1].Name = "QTY";
            dgvOrder.Columns[2].Name = "STR_UNIT";
            dgvOrder.Columns[3].Name = "STR_AMOUNT";
            dgvOrder.Columns[4].Name = "STR_TOTAL_AMOUNT";
            dgvOrder.Columns[5].Name = "AVG_ITEM";
            dgvOrder.Columns[6].Name = "AVG_PACK";
            dgvOrder.Columns[7].Name = "REMARK";

            dgvOrder.Columns[0].DataPropertyName = "PRODUCT_NAME";
            dgvOrder.Columns[1].DataPropertyName = "QTY";
            dgvOrder.Columns[2].DataPropertyName = "STR_UNIT";
            dgvOrder.Columns[3].DataPropertyName = "STR_AMOUNT";
            dgvOrder.Columns[4].DataPropertyName = "STR_TOTAL_AMOUNT";
            dgvOrder.Columns[5].DataPropertyName = "AVG_ITEM";
            dgvOrder.Columns[6].DataPropertyName = "AVG_PACK";
            dgvOrder.Columns[7].DataPropertyName = "REMARK";

            dgvOrder.Columns[8].Visible = false;

            decimal total = 0;
            foreach (DataGridViewRow rw in dgvOrder.Rows)
            {
                rw.HeaderCell.Value = (rw.Index + 1).ToString();

                if (rw.Cells[5].Value != null)
                {
                    total += decimal.Parse(rw.Cells[3].Value.ToString());
                }
            }
            lblSum.Text = string.Format("{0} {1} บาท", "รวมสุทธิ", total.ToString("#,###.00"));
        }
    }
}
