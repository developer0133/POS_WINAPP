using BL;
using POS.Utils;
using DATA_EF;
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
    public partial class frmCategory : Form
    {
        private const int pageSize = 10;
        private int pageNumber = 1;
        List<CATEGORY> dt = null;
        CATEGORY pModel = null;
        public frmCategory()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            dgvCate.AutoGenerateColumns = false;

            dt = new List<CATEGORY>();
            dt = CategoryService.GetCategories();
            dgvCate.DataSource = dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();

            lblPage.Text = string.Format("Page {0}/{1}", (pageNumber), dt.Count() / pageSize);

            btnFirst.Enabled = false;

            if(dt.Count() / pageSize == 1)
            {
                btnNext.Enabled = false;
            }

            clsFunction.FormatHeaderDatagrid(dgvCate);

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "";
            btnColumn.Width = 60;
            btnColumn.Name = "btndelete";
            btnColumn.Text = "ลบ";
            btnColumn.HeaderText = "ลบ";
            btnColumn.UseColumnTextForButtonValue = true;
            dgvCate.Columns.Insert(4, btnColumn);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CATEGORY obj = new CATEGORY();

            obj.CATEGORY_NAME = txtName.Text.Trim();
            obj.CATE_CODE = txtCateCode.Text.Trim();
            obj.REMARK = txtRemark.Text.Trim();

            if (pModel != null && pModel.CATEGORY_ID > 0)
            {
                obj.CATEGORY_ID = pModel.CATEGORY_ID;
                obj.CATE_CODE = pModel.CATE_CODE;
                obj.CATEGORY_NAME = pModel.CATEGORY_NAME;
                obj.REMARK = pModel.REMARK;
                obj.STATUS = pModel.STATUS;

                bool isSuccess = CategoryService.UpdateCategory(obj);

                if (isSuccess)
                {
                    MessageBox.Show("Completed", "POS");
                    Clear();
                    PopulateDataGridView();
                }
                else
                {
                    MessageBox.Show("Try again", "POS");
                }
            }
            else
            {
                obj.STATUS = STATUS.ACTIVE;

                bool isSuccess = CategoryService.InsertCategory(obj);
                if (isSuccess)
                {
                    MessageBox.Show("Completed", "POS");
                    Clear();
                    PopulateDataGridView();
                }
                else
                {
                    MessageBox.Show("Try again", "POS");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCateCode.Text = string.Empty;
            txtRemark.Text = string.Empty;
            pModel = null;
        }

        private void dgvCate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCate.Columns[e.ColumnIndex].Name == "btndelete")
            {
                DataGridViewRow row = dgvCate.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("ต้องการลบหรือไม่ ?", ""), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)row.Cells["CATEGORY_ID"].Value;
                    bool isSuccess = CategoryService.DeleteCategory(id);

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

        private void dgvCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCate.CurrentRow.Index != -1)
            {
                pModel = new CATEGORY();
                int id = Convert.ToInt32(dgvCate.CurrentRow.Cells["CATEGORY_ID"].Value);
                pModel = CategoryService.GetCategoryByID(id);

                txtName.Text = pModel.CATEGORY_NAME;
                txtCateCode.Text = pModel.CATE_CODE;
                txtRemark.Text = pModel.REMARK;
                txtCode.Text = pModel.CATEGORY_ID.ToString();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pageNumber--;
            dgvCate.DataSource = dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageNumber++;
            dgvCate.DataSource = dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            if (dt.Skip(pageSize * (pageNumber - 1)).Take(pageSize).Count() > 0)
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
    }
}
