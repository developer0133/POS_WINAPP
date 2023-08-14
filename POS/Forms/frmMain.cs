
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
using DAL.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

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

            timer1.Start();
            this.lblName.Text = string.Format("เข้าสู่ระบบโดย: {0} {1}", UserModel.FIRST_NAME, UserModel.LAST_NAME);
           // txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", formatThai);
            //strDate = Date.Value.ToString("dd/MM/yyyy HH:mm:ss", clsFunctions.formatThai);
        }

        private static System.IFormatProvider formatThai = new System.Globalization.CultureInfo("th-TH");
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

            //frmInv f = new frmInv();
            frmInv2 f = new frmInv2();
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();

            frmReport f = new frmReport();
            f.MdiParent = this;
            f.Show();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnProductOrder_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();

            frmOrder f = new frmOrder();
            f.MdiParent = this;
            f.Show();
        }

        private void btnPManagement_Click(object sender, EventArgs e)
        {
            CloseAllChildForm();

            frmProductManagement f = new frmProductManagement();
            f.MdiParent = this;
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string itemText = e.ClickedItem.Name;
            CloseAllChildForm();
            switch (itemText)
            {
                case "t_product":
                    frmProduct f = new frmProduct();
                    f.MdiParent = this;
                    f.Show();
                    break;

                case "t_cate":
                    frmCategory f2 = new frmCategory();
                    f2.MdiParent = this;
                    f2.Show();
                    break;

                case "t_master":
                    frmParameter f3 = new frmParameter();
                    f3.MdiParent = this;
                    f3.Show();
                    break;

                case "t_barcode":
                    frmBarcode f4 = new frmBarcode();
                    f4.MdiParent = this;
                    f4.Show();
                    break;

                case "t_sell":
                    frmSell f5 = new frmSell();
                    f5.MdiParent = this;
                    f5.Show();
                    break;

                case "t_inv":
                    frmInv2 f6 = new frmInv2();
                    f6.MdiParent = this;
                    f6.Show();
                    break;

                case "t_productmng":
                    frmProductManagement f7 = new frmProductManagement();
                    f7.MdiParent = this;
                    f7.Show();
                    break;
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string itemText = e.ClickedItem.Name;
            CloseAllChildForm();
            switch (itemText)
            {
                case "t_outofstock":
                    frmOutOfStock f = new frmOutOfStock();
                    f.MdiParent = this;
                    f.Show();
                    break;

                case "t_ds":
                    frmCategory f2 = new frmCategory();
                    f2.MdiParent = this;
                    f2.Show();
                    break;

                case "t_rpt":
                    frmReport f3 = new frmReport();
                    f3.MdiParent = this;
                    f3.Show();
                    break;

                case "t_logout":
                    Application.Exit();
                    break;

            }
        }
    }
}
