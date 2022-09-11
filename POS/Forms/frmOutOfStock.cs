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
    public partial class frmOutOfStock : Form
    {
        public frmOutOfStock()
        {
            InitializeComponent();

            this.LoadData();
        }

        void LoadData()
        {
            dgvOutOfStock.DataSource = ProductService.GetOutOfStock();

            foreach (DataGridViewRow rw in dgvOutOfStock.Rows)
            {
                rw.HeaderCell.Value = (rw.Index + 1).ToString();
            }
        }
    }
}
