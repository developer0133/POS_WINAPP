
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.t_outofstock = new System.Windows.Forms.ToolStripMenuItem();
            this.t_ds = new System.Windows.Forms.ToolStripMenuItem();
            this.t_rpt = new System.Windows.Forms.ToolStripMenuItem();
            this.t_home = new System.Windows.Forms.ToolStripMenuItem();
            this.t_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.t_product = new System.Windows.Forms.ToolStripMenuItem();
            this.t_cate = new System.Windows.Forms.ToolStripMenuItem();
            this.t_master = new System.Windows.Forms.ToolStripMenuItem();
            this.t_barcode = new System.Windows.Forms.ToolStripMenuItem();
            this.t_sell = new System.Windows.Forms.ToolStripMenuItem();
            this.t_inv = new System.Windows.Forms.ToolStripMenuItem();
            this.t_productmng = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.btnPManagement = new System.Windows.Forms.Button();
            this.btnProductOrder = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnCate = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnProductIn = new System.Windows.Forms.Button();
            this.btnOutOfStock = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 953);
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
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(300, 953);
            this.splitContainer1.SplitterDistance = 905;
            this.splitContainer1.SplitterWidth = 20;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t_outofstock,
            this.t_ds,
            this.t_rpt,
            this.t_home,
            this.t_logout});
            this.menuStrip2.Location = new System.Drawing.Point(116, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Size = new System.Drawing.Size(131, 905);
            this.menuStrip2.TabIndex = 52;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // t_outofstock
            // 
            this.t_outofstock.Image = global::POS.Properties.Resources.icons8_out_of_stock_48;
            this.t_outofstock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_outofstock.Name = "t_outofstock";
            this.t_outofstock.Size = new System.Drawing.Size(118, 72);
            this.t_outofstock.Text = "รายการสินค้าหมด";
            this.t_outofstock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.t_outofstock.ToolTipText = "รายการสินค้าหมด";
            // 
            // t_ds
            // 
            this.t_ds.AutoToolTip = true;
            this.t_ds.Image = global::POS.Properties.Resources.icons8_dashboard_64;
            this.t_ds.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_ds.Name = "t_ds";
            this.t_ds.Size = new System.Drawing.Size(118, 88);
            this.t_ds.Text = "Dashboard";
            this.t_ds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // t_rpt
            // 
            this.t_rpt.Image = global::POS.Properties.Resources.icons8_report_1001;
            this.t_rpt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.t_rpt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_rpt.Name = "t_rpt";
            this.t_rpt.Size = new System.Drawing.Size(118, 124);
            this.t_rpt.Text = "รายงาน";
            this.t_rpt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_rpt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.t_rpt.ToolTipText = "รายงาน";
            // 
            // t_home
            // 
            this.t_home.AutoToolTip = true;
            this.t_home.Image = global::POS.Properties.Resources.icons8_homepage_100;
            this.t_home.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_home.Name = "t_home";
            this.t_home.Size = new System.Drawing.Size(118, 124);
            this.t_home.Text = "หน้าหลัก";
            this.t_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // t_logout
            // 
            this.t_logout.AutoToolTip = true;
            this.t_logout.Image = global::POS.Properties.Resources.icons8_logout_582;
            this.t_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.t_logout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_logout.Name = "t_logout";
            this.t_logout.Size = new System.Drawing.Size(118, 82);
            this.t_logout.Text = "Logout";
            this.t_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.t_logout.ToolTipText = "Logout";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t_product,
            this.t_cate,
            this.t_master,
            this.t_barcode,
            this.t_sell,
            this.t_inv,
            this.t_productmng});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(116, 905);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // t_product
            // 
            this.t_product.Image = global::POS.Properties.Resources.icons8_sell_96;
            this.t_product.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.t_product.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_product.Name = "t_product";
            this.t_product.Size = new System.Drawing.Size(103, 120);
            this.t_product.Text = "สินค้า";
            this.t_product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.t_product.ToolTipText = "สินค้า";
            // 
            // t_cate
            // 
            this.t_cate.Image = global::POS.Properties.Resources.cate;
            this.t_cate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.t_cate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_cate.Name = "t_cate";
            this.t_cate.Size = new System.Drawing.Size(103, 88);
            this.t_cate.Text = "หมวดหมู่สินค้า";
            this.t_cate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_cate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.t_cate.ToolTipText = "หมวดหมู่สินค้า";
            // 
            // t_master
            // 
            this.t_master.Image = global::POS.Properties.Resources.config;
            this.t_master.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.t_master.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_master.Name = "t_master";
            this.t_master.Size = new System.Drawing.Size(103, 84);
            this.t_master.Text = "Master";
            this.t_master.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.t_master.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.t_master.ToolTipText = "Master";
            // 
            // t_barcode
            // 
            this.t_barcode.Image = global::POS.Properties.Resources.icons8_barcode_64;
            this.t_barcode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_barcode.Name = "t_barcode";
            this.t_barcode.Size = new System.Drawing.Size(103, 88);
            this.t_barcode.Text = "บาร์โค้ด";
            this.t_barcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.t_barcode.ToolTipText = "บาร์โค้ด";
            // 
            // t_sell
            // 
            this.t_sell.Image = global::POS.Properties.Resources.icons8_sell_48;
            this.t_sell.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_sell.Name = "t_sell";
            this.t_sell.Size = new System.Drawing.Size(103, 72);
            this.t_sell.Text = "ขาย";
            this.t_sell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.t_sell.ToolTipText = "รายการขาย";
            // 
            // t_inv
            // 
            this.t_inv.Image = global::POS.Properties.Resources.icons8_sell_stock_94;
            this.t_inv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_inv.Name = "t_inv";
            this.t_inv.Size = new System.Drawing.Size(103, 118);
            this.t_inv.Text = "ร้บสินค้าเข้า";
            this.t_inv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.t_inv.ToolTipText = "รับสินค้าเข้า";
            // 
            // t_productmng
            // 
            this.t_productmng.Image = global::POS.Properties.Resources.icons8_setting_64;
            this.t_productmng.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.t_productmng.Name = "t_productmng";
            this.t_productmng.Size = new System.Drawing.Size(103, 88);
            this.t_productmng.Text = "จัดการสินค้า";
            this.t_productmng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.t_productmng.ToolTipText = "จัดการสินค้า";
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
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblName.Location = new System.Drawing.Point(300, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 24);
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
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbldate.ForeColor = System.Drawing.Color.Black;
            this.lbldate.Location = new System.Drawing.Point(1089, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(160, 20);
            this.lbldate.TabIndex = 10;
            this.lbldate.Text = "label2";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.Location = new System.Drawing.Point(1248, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(120, 20);
            this.lbltime.TabIndex = 11;
            this.lbltime.Text = "label2";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPManagement
            // 
            this.btnPManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnPManagement.Image")));
            this.btnPManagement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPManagement.Location = new System.Drawing.Point(692, 450);
            this.btnPManagement.Name = "btnPManagement";
            this.btnPManagement.Size = new System.Drawing.Size(236, 89);
            this.btnPManagement.TabIndex = 10;
            this.btnPManagement.Text = "จัดการสินค้า";
            this.btnPManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPManagement.UseVisualStyleBackColor = true;
            this.btnPManagement.Visible = false;
            this.btnPManagement.Click += new System.EventHandler(this.btnPManagement_Click);
            // 
            // btnProductOrder
            // 
            this.btnProductOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnProductOrder.Image = global::POS.Properties.Resources.Order;
            this.btnProductOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductOrder.Location = new System.Drawing.Point(942, 531);
            this.btnProductOrder.Name = "btnProductOrder";
            this.btnProductOrder.Size = new System.Drawing.Size(233, 82);
            this.btnProductOrder.TabIndex = 9;
            this.btnProductOrder.Text = "รายการสั่งสินค้า";
            this.btnProductOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductOrder.UseVisualStyleBackColor = true;
            this.btnProductOrder.Visible = false;
            this.btnProductOrder.Click += new System.EventHandler(this.btnProductOrder_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLogout.Image = global::POS.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(694, 997);
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
            this.btnReport.Location = new System.Drawing.Point(692, 545);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(233, 82);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "รายงาน";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnProduct.Image = global::POS.Properties.Resources.product1;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduct.Location = new System.Drawing.Point(691, 177);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(233, 82);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "สินค้า";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Visible = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnMaster
            // 
            this.btnMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnMaster.Image = global::POS.Properties.Resources.Finance_Order;
            this.btnMaster.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaster.Location = new System.Drawing.Point(930, 177);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(233, 82);
            this.btnMaster.TabIndex = 1;
            this.btnMaster.Text = "Master";
            this.btnMaster.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Visible = false;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnCate
            // 
            this.btnCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCate.Image = global::POS.Properties.Resources.Category;
            this.btnCate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCate.Location = new System.Drawing.Point(691, 274);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(233, 82);
            this.btnCate.TabIndex = 2;
            this.btnCate.Text = "หมวดหมู่สินค้า";
            this.btnCate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCate.UseVisualStyleBackColor = true;
            this.btnCate.Visible = false;
            this.btnCate.Click += new System.EventHandler(this.btnCate_Click);
            // 
            // btnSell
            // 
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSell.Image = global::POS.Properties.Resources.sale;
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSell.Location = new System.Drawing.Point(694, 362);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(233, 82);
            this.btnSell.TabIndex = 8;
            this.btnSell.Text = "ขาย";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Visible = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnProductIn
            // 
            this.btnProductIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnProductIn.Image = global::POS.Properties.Resources.Order_history;
            this.btnProductIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductIn.Location = new System.Drawing.Point(942, 362);
            this.btnProductIn.Name = "btnProductIn";
            this.btnProductIn.Size = new System.Drawing.Size(233, 82);
            this.btnProductIn.TabIndex = 4;
            this.btnProductIn.Text = "รับสินค้าเข้า";
            this.btnProductIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductIn.UseVisualStyleBackColor = true;
            this.btnProductIn.Visible = false;
            this.btnProductIn.Click += new System.EventHandler(this.btnProductIn_Click);
            // 
            // btnOutOfStock
            // 
            this.btnOutOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOutOfStock.Image = global::POS.Properties.Resources.Zoom_out;
            this.btnOutOfStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOutOfStock.Location = new System.Drawing.Point(942, 450);
            this.btnOutOfStock.Name = "btnOutOfStock";
            this.btnOutOfStock.Size = new System.Drawing.Size(233, 82);
            this.btnOutOfStock.TabIndex = 5;
            this.btnOutOfStock.Text = "รายการสินค้าหมด";
            this.btnOutOfStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOutOfStock.UseVisualStyleBackColor = true;
            this.btnOutOfStock.Visible = false;
            this.btnOutOfStock.Click += new System.EventHandler(this.btnOutOfStock_Click);
            // 
            // btnBarcode
            // 
            this.btnBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBarcode.Image = global::POS.Properties.Resources.Barcodes;
            this.btnBarcode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBarcode.Location = new System.Drawing.Point(930, 274);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(233, 82);
            this.btnBarcode.TabIndex = 3;
            this.btnBarcode.Text = "บาร์โค้ด";
            this.btnBarcode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBarcode.UseVisualStyleBackColor = true;
            this.btnBarcode.Visible = false;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1371, 953);
            this.Controls.Add(this.btnPManagement);
            this.Controls.Add(this.btnProductOrder);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnMaster);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCate);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnProductIn);
            this.Controls.Add(this.btnOutOfStock);
            this.Controls.Add(this.btnBarcode);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Product Service System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem t_product;
        private System.Windows.Forms.ToolStripMenuItem t_cate;
        private System.Windows.Forms.ToolStripMenuItem t_master;
        private System.Windows.Forms.ToolStripMenuItem t_barcode;
        private System.Windows.Forms.ToolStripMenuItem t_sell;
        private System.Windows.Forms.ToolStripMenuItem t_inv;
        private System.Windows.Forms.ToolStripMenuItem t_productmng;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem t_rpt;
        private System.Windows.Forms.ToolStripMenuItem t_logout;
        private System.Windows.Forms.ToolStripMenuItem t_outofstock;
        private System.Windows.Forms.ToolStripMenuItem t_ds;
        private System.Windows.Forms.ToolStripMenuItem t_home;
    }
}