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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void CloseAllChildForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();

            frmProduct f = new frmProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();

            frmParameter f = new frmParameter();
            f.MdiParent = this;
            f.Show();
        }
    }
}
