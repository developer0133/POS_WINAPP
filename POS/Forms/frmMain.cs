
using POS.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_Models.Models;

namespace POS.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            //var path = Path.Combine(Directory.GetCurrentDirectory());
            //string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            //string solutionFileLocation = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\POS";

            //var rptPath = string.Format("{0}/{1}{2}", POS_PATH.REPORTS, REPORT_NAME.SELL_REPORT2, ".rdlc");
            //string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\POS" + "\\" + rptPath;
            //LocalReport localReport = new LocalReport(path);

            this.lblName.Text = string.Format("เข้าสู่ระบบโดย: {0} {1}", UserModel.FIRST_NAME, UserModel.LAST_NAME);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnCate_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();

            frmCategory f = new frmCategory();
            f.MdiParent = this;
            f.Show();
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();

            frmBarcode f = new frmBarcode();
            f.MdiParent = this;
            f.Show();
        }

        private void btnProductIn_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();

            frmInv f = new frmInv();
            f.MdiParent = this;
            f.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();

            frmSell f = new frmSell();
            f.MdiParent = this;
            f.Show();
        }

        private void btnOutOfStock_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();

            frmOutOfStock f = new frmOutOfStock();
            f.MdiParent = this;
            f.Show();
        }
    }
}
