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
        List<PARAMETER> dt = new List<PARAMETER>();
        public frmParameter()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            dgvParameter.AutoGenerateColumns = false;

            dt = ParameterService.GetParameterAll();
            dgvParameter.DataSource = dt.Skip(pageSize * pageNumber).Take(pageSize).ToList();

            lblPage.Text = string.Format("Page {0}/{1}", pageNumber, dt.Count() / pageSize);

            btnFirst.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageNumber++;
            dgvParameter.DataSource = dt.Skip(pageSize * pageNumber).Take(pageSize).ToList();
            if(dt.Skip(pageSize * (pageNumber+1)).Take(pageSize).Count()>0)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }

            btnFirst.Enabled = true;
            btnNext.Enabled = !(pageNumber == dt.Count() / pageSize);
            lblPage.Text = string.Format("Page {0}/{1}", pageNumber, dt.Count() / pageSize);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pageNumber--;
            dgvParameter.DataSource = dt.Skip(pageSize * pageNumber).Take(pageSize).ToList();
            if (ParameterService.GetParameterAll().Skip(pageSize * (pageNumber - 1)).Take(pageSize).Count() > 0)
            {
                btnFirst.Enabled = true;
            }
            else
            {
                btnFirst.Enabled = false;
            }

            btnNext.Enabled = true;
            btnFirst.Enabled = !(pageNumber == 1);
            lblPage.Text = string.Format("Page {0}/{1}", pageNumber, dt.Count() / pageSize);
        }
    }
}
