
namespace POS.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnOutOfStock = new System.Windows.Forms.Button();
            this.btnProductIn = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnCate = new System.Windows.Forms.Button();
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1371, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 708);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLogout);
            this.splitContainer1.Panel1.Controls.Add(this.btnProductIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnReport);
            this.splitContainer1.Panel1.Controls.Add(this.btnSell);
            this.splitContainer1.Panel1.Controls.Add(this.btnBarcode);
            this.splitContainer1.Panel1.Controls.Add(this.btnOutOfStock);
            this.splitContainer1.Panel1.Controls.Add(this.btnCate);
            this.splitContainer1.Panel1.Controls.Add(this.btnMaster);
            this.splitContainer1.Panel1.Controls.Add(this.btnProduct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(233, 708);
            this.splitContainer1.SplitterDistance = 662;
            this.splitContainer1.SplitterWidth = 20;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "© Copy right 2022 KNN";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblName.Location = new System.Drawing.Point(233, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "lblName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSell
            // 
            this.btnSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSell.Image = global::POS.Properties.Resources.sale;
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSell.Location = new System.Drawing.Point(0, 410);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(233, 82);
            this.btnSell.TabIndex = 8;
            this.btnSell.Text = "ขาย";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.Image = global::POS.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(0, 656);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(233, 82);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "ออกจากระบบ";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.Image = global::POS.Properties.Resources.Chart;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReport.Location = new System.Drawing.Point(0, 492);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(233, 82);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "รายงาน";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnOutOfStock
            // 
            this.btnOutOfStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOutOfStock.Image = global::POS.Properties.Resources.Zoom_out;
            this.btnOutOfStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOutOfStock.Location = new System.Drawing.Point(0, 246);
            this.btnOutOfStock.Name = "btnOutOfStock";
            this.btnOutOfStock.Size = new System.Drawing.Size(233, 82);
            this.btnOutOfStock.TabIndex = 5;
            this.btnOutOfStock.Text = "รายการสินค้าหมด";
            this.btnOutOfStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOutOfStock.UseVisualStyleBackColor = true;
            this.btnOutOfStock.Click += new System.EventHandler(this.btnOutOfStock_Click);
            // 
            // btnProductIn
            // 
            this.btnProductIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductIn.Image = global::POS.Properties.Resources.Order_history;
            this.btnProductIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductIn.Location = new System.Drawing.Point(0, 574);
            this.btnProductIn.Name = "btnProductIn";
            this.btnProductIn.Size = new System.Drawing.Size(233, 82);
            this.btnProductIn.TabIndex = 4;
            this.btnProductIn.Text = "รับสินค้าเข้า";
            this.btnProductIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductIn.UseVisualStyleBackColor = true;
            this.btnProductIn.Click += new System.EventHandler(this.btnProductIn_Click);
            // 
            // btnBarcode
            // 
            this.btnBarcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarcode.Image = global::POS.Properties.Resources.Barcodes;
            this.btnBarcode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBarcode.Location = new System.Drawing.Point(0, 328);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(233, 82);
            this.btnBarcode.TabIndex = 3;
            this.btnBarcode.Text = "บาร์โค้ด";
            this.btnBarcode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBarcode.UseVisualStyleBackColor = true;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // btnCate
            // 
            this.btnCate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCate.Image = global::POS.Properties.Resources.Category;
            this.btnCate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCate.Location = new System.Drawing.Point(0, 164);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(233, 82);
            this.btnCate.TabIndex = 2;
            this.btnCate.Text = "หมวดหมู่สินค้า";
            this.btnCate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCate.UseVisualStyleBackColor = true;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // btnMaster
            // 
            this.btnMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaster.Image = global::POS.Properties.Resources.Finance_Order;
            this.btnMaster.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaster.Location = new System.Drawing.Point(0, 82);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(233, 82);
            this.btnMaster.TabIndex = 1;
            this.btnMaster.Text = "Master";
            this.btnMaster.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.Image = global::POS.Properties.Resources.product1;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(233, 82);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "สินค้า";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 732);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Product Service System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOutOfStock;
        private System.Windows.Forms.Button btnProductIn;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button btnCate;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblName;
    }
}