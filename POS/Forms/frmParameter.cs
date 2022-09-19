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

namespace POS.Forms
{
    public partial class frmParameter : Form
    {
        private const int pageSize = 10;
        private  int pageNumber = 1;
        List<ParameterModel> dt = null;
        PARAMETER pModel = null;
        public frmParameter()
        {
            InitializeComponent();
            PopulateDataGridView();
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "";
            btnColumn.Width = 60;
            btnColumn.Name = "btndelete";
            btnColumn.Text = "ลบ";
            btnColumn.HeaderText = "ลบ";
            btnColumn.UseColumnTextForButtonValue = true;
            dgvParameter.Columns.Insert(7, btnColumn);
        }

        void PopulateDataGridView()
        {
            dgvParameter.AutoGenerateColumns = false;

           
            dgvParameter.DataSource = ParameterService.GetParameterAll();

      
            clsFunction.FormatHeaderDatagrid(dgvParameter);

         
        }

        private void dgvParameter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParameter.CurrentRow.Index != -1)
            {
                pModel = new PARAMETER();
                int id = Convert.ToInt32(dgvParameter.CurrentRow.Cells["PARAMETER_ID"].Value);
                pModel = ParameterService.GetParameterByID(id);

                txtMajorCode.Text = pModel.MAJOR_CODE;
                txtMinorCode.Text = pModel.MINOR_CODE;
                txtName.Text = pModel.NAME;
                txtCon1.Text = pModel.CONDITION1;
                txtCon2.Text = pModel.CONDITION2;
                txtRemark.Text = pModel.DESCRIPTION;
            }
        }

        void Clear()
        {
            txtMajorCode.Text = string.Empty;
            txtMinorCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCon1.Text = string.Empty;
            txtCon2.Text = string.Empty;
            txtRemark.Text = string.Empty;
            pModel = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PARAMETER obj = new PARAMETER();

            if (string.IsNullOrEmpty(txtMajorCode.Text) || string.IsNullOrEmpty(txtMinorCode.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("กรุณาระบุข้อมูล", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                obj.MAJOR_CODE = txtMajorCode.Text.Trim();
                obj.MINOR_CODE = txtMinorCode.Text.Trim();
                obj.NAME = txtName.Text.Trim();
                obj.CONDITION1 = txtCon1.Text.Trim();
                obj.CONDITION2 = txtCon2.Text.Trim();
                obj.DESCRIPTION = txtRemark.Text.Trim();

                if (pModel != null && pModel.PARAMETER_ID > 0)
                {
                    obj.PARAMETER_ID = pModel.PARAMETER_ID;
                    obj.STATUS = pModel.STATUS;
                    obj.C_BY = pModel.C_BY;
                    obj.E_BY = pModel.E_BY;

                    bool isSuccess = ParameterService.UpdateParameter(obj);

                    if (isSuccess)
                    {
                        MessageBox.Show("บันทึกสำเร็จ", "POS");
                        Clear();
                        PopulateDataGridView();
                    }
                    else
                    {

                    }
                }
                else
                {
                    obj.STATUS = STATUS.ACTIVE;
                    obj.C_BY = "SYSTEM";
                    obj.E_BY = "SYSTEM";
                    obj.C_DATE = clsFunction.GetDate();
                    obj.E_DATE = clsFunction.GetDate();

                    bool isSuccess = ParameterService.InsertParameter(obj);
                    if (isSuccess)
                    {
                        MessageBox.Show("Completed", "POS");
                        Clear();
                        PopulateDataGridView();
                    }
                    else
                    {

                    }
                }
            }
        }

        private void dgvParameter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParameter.Columns[e.ColumnIndex].Name == "btndelete")
            {
                DataGridViewRow row = dgvParameter.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("ต้องการลบหรือไม่ ?", ""), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)row.Cells["PARAMETER_ID"].Value;
                    bool isSuccess = ParameterService.DeleteParameter(id);

                    if (isSuccess)
                    {
                        MessageBox.Show("Completed", "POS");
                        Clear();
                        PopulateDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Try again.", "POS");
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dt = new List<ParameterModel>();
            dt = ParameterService.ParameterSearch(txtSearch.Text);
            dgvParameter.DataSource = dt;

        }

        private void dgvParameter_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //dgvParameter.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            //dgvParameter.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }
    }
}
