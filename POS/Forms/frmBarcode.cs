using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace POS.Forms
{
    public partial class frmBarcode : Form
    {
        public frmBarcode()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBarcode.Text) || String.IsNullOrEmpty(txtBarcode.Text))
            {
                MessageBox.Show("Input data", "POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QrCodeEncodingOptions options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Width = 170,
                    Height = 170,
                };


                var qr = new ZXing.BarcodeWriter();
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.CODE_128;
                var result = new Bitmap(qr.Write(txtBarcode.Text.Trim()));
                pictureBox1.Image = result;
                txtBarcode.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = string.Empty;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }
    }
}
