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
        List<PARAMETER> dt = null;
        PARAMETER pModel = null;
        public frmParameter()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            dgvParameter.AutoGenerateColumns = false;

            dt = new List<PARAMETER>();
            dt = ParameterService.GetParameterAll();
            dgvParameter.DataSource = dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();

            lblPage.Text = string.Format("Page {0}/{1}", (pageNumber), dt.Count() / pageSize);

            btnFirst.Enabled = false;

            clsFunction.FormatHeaderDatagrid(dgvParameter);
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageNumber++;
            dgvParameter.DataSource = dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            if(dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).Count()>0)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }

            btnFirst.Enabled = true;
            btnNext.Enabled = !(pageNumber == dt.Count() / pageSize);
            lblPage.Text = string.Format("Page {0}/{1}", (pageNumber), dt.Count() / pageSize);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pageNumber--;
            dgvParameter.DataSource = dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();

            if (dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).Count() > 0)
            {
                btnFirst.Enabled = true;
            }
            else
            {
                btnFirst.Enabled = false;
            }

            btnNext.Enabled = true;
            btnFirst.Enabled = !(pageNumber == 1);
            lblPage.Text = string.Format("Page {0}/{1}", (pageNumber), dt.Count() / pageSize);
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
                    MessageBox.Show("Completed", "POS");
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
}
