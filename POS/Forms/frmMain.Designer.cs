
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnPManagement = new System.Windows.Forms.Button();
            this.btnProductOrder = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnCate = new System.Windows.Forms.Button();
            this.btnProductIn = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnOutOfStock = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 953);
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
            this.splitContainer1.Panel1.Controls.Add(this.btnPManagement);
            this.splitContainer1.Panel1.Controls.Add(this.btnProductOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnLogout);
            this.splitContainer1.Panel1.Controls.Add(this.btnReport);
            this.splitContainer1.Panel1.Controls.Add(this.btnProduct);
            this.splitContainer1.Panel1.Controls.Add(this.btnMaster);
            this.splitContainer1.Panel1.Controls.Add(this.btnCate);
            this.splitContainer1.Panel1.Controls.Add(this.btnProductIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnBarcode);
            this.splitContainer1.Panel1.Controls.Add(this.btnOutOfStock);
            this.splitContainer1.Panel1.Controls.Add(this.btnSell);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(233, 953);
            this.splitContainer1.SplitterDistance = 905;
            this.splitContainer1.SplitterWidth = 20;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btnPManagement
            // 
            this.btnPManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnPManagement.Image")));
            this.btnPManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPManagement.Location = new System.Drawing.Point(0, 491);
            this.btnPManagement.Name = "btnPManagement";
            this.btnPManagement.Size = new System.Drawing.Size(236, 89);
            this.btnPManagement.TabIndex = 10;
            this.btnPManagement.Text = "จัดการสินค้า";
            this.btnPManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPManagement.UseVisualStyleBackColor = true;
            this.btnPManagement.Click += new System.EventHandler(this.btnPManagement_Click);
            // 
            // btnProductOrder
            // 
            this.btnProductOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnProductOrder.Image = global::POS.Properties.Resources.Order;
            this.btnProductOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductOrder.Location = new System.Drawing.Point(0, 655);
            this.btnProductOrder.Name = "btnProductOrder";
            this.btnProductOrder.Size = new System.Drawing.Size(233, 82);
            this.btnProductOrder.TabIndex = 9;
            this.btnProductOrder.Text = "รายการสั่งสินค้า";
            this.btnProductOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductOrder.UseVisualStyleBackColor = true;
            this.btnProductOrder.Click += new System.EventHandler(this.btnProductOrder_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLogout.Image = global::POS.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(3, 820);
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
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnReport.Image = global::POS.Properties.Resources.Chart;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReport.Location = new System.Drawing.Point(1, 739);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(233, 82);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "รายงาน";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
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
            // btnMaster
            // 
            this.btnMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnMaster.Image = global::POS.Properties.Resources.Finance_Order;
            this.btnMaster.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaster.Location = new System.Drawing.Point(0, 81);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(233, 82);
            this.btnMaster.TabIndex = 1;
            this.btnMaster.Text = "Master";
            this.btnMaster.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnCate
            // 
            this.btnCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCate.Image = global::POS.Properties.Resources.Category;
            this.btnCate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCate.Location = new System.Drawing.Point(0, 162);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(233, 82);
            this.btnCate.TabIndex = 2;
            this.btnCate.Text = "หมวดหมู่สินค้า";
            this.btnCate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCate.UseVisualStyleBackColor = true;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // btnProductIn
            // 
            this.btnProductIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnProductIn.Image = global::POS.Properties.Resources.Order_history;
            this.btnProductIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductIn.Location = new System.Drawing.Point(0, 408);
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
            this.btnBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBarcode.Image = global::POS.Properties.Resources.Barcodes;
            this.btnBarcode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBarcode.Location = new System.Drawing.Point(0, 244);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(233, 82);
            this.btnBarcode.TabIndex = 3;
            this.btnBarcode.Text = "บาร์โค้ด";
            this.btnBarcode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBarcode.UseVisualStyleBackColor = true;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // btnOutOfStock
            // 
            this.btnOutOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOutOfStock.Image = global::POS.Properties.Resources.Zoom_out;
            this.btnOutOfStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOutOfStock.Location = new System.Drawing.Point(0, 574);
            this.btnOutOfStock.Name = "btnOutOfStock";
            this.btnOutOfStock.Size = new System.Drawing.Size(233, 82);
            this.btnOutOfStock.TabIndex = 5;
            this.btnOutOfStock.Text = "รายการสินค้าหมด";
            this.btnOutOfStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOutOfStock.UseVisualStyleBackColor = true;
            this.btnOutOfStock.Click += new System.EventHandler(this.btnOutOfStock_Click);
            // 
            // btnSell
            // 
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSell.Image = global::POS.Properties.Resources.sale;
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSell.Location = new System.Drawing.Point(0, 326);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(233, 82);
            this.btnSell.TabIndex = 8;
            this.btnSell.Text = "ขาย";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "© Copy right 2022 KNN";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblName.Location = new System.Drawing.Point(233, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "lblName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbldate
            // 
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbldate.Location = new System.Drawing.Point(1089, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(160, 20);
            this.lbldate.TabIndex = 10;
            this.lbldate.Text = "label2";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbltime
            // 
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbltime.Location = new System.Drawing.Point(1248, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(120, 20);
            this.lbltime.TabIndex = 11;
            this.lbltime.Text = "label2";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1371, 953);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Product Service System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.Button btnProductOrder;
        private System.Windows.Forms.Button btnPManagement;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbltime;
    }
}