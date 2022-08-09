
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
            this.ขอมลหลกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.สนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.จดการผใชToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnOutOfStock = new System.Windows.Forms.Button();
            this.btnProductIn = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnCate = new System.Windows.Forms.Button();
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขอมลหลกToolStripMenuItem,
            this.สนคาToolStripMenuItem,
            this.จดการผใชToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1371, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ขอมลหลกToolStripMenuItem
            // 
            this.ขอมลหลกToolStripMenuItem.Name = "ขอมลหลกToolStripMenuItem";
            this.ขอมลหลกToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.ขอมลหลกToolStripMenuItem.Text = "ข้อมูลหลัก";
            // 
            // สนคาToolStripMenuItem
            // 
            this.สนคาToolStripMenuItem.Name = "สนคาToolStripMenuItem";
            this.สนคาToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.สนคาToolStripMenuItem.Text = "สินค้า";
            // 
            // จดการผใชToolStripMenuItem
            // 
            this.จดการผใชToolStripMenuItem.Name = "จดการผใชToolStripMenuItem";
            this.จดการผใชToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.จดการผใชToolStripMenuItem.Text = "จัดการผู้ใช้";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 704);
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
            this.splitContainer1.Panel1.Controls.Add(this.btnReport);
            this.splitContainer1.Panel1.Controls.Add(this.btnOutOfStock);
            this.splitContainer1.Panel1.Controls.Add(this.btnProductIn);
            this.splitContainer1.Panel1.Controls.Add(this.btnBarcode);
            this.splitContainer1.Panel1.Controls.Add(this.btnCate);
            this.splitContainer1.Panel1.Controls.Add(this.btnMaster);
            this.splitContainer1.Panel1.Controls.Add(this.btnProduct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(233, 704);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.SplitterWidth = 20;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.Location = new System.Drawing.Point(0, 385);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(233, 55);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "ออกจากระบบ";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.Location = new System.Drawing.Point(0, 330);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(233, 55);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "รายงาน";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnOutOfStock
            // 
            this.btnOutOfStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOutOfStock.Location = new System.Drawing.Point(0, 275);
            this.btnOutOfStock.Name = "btnOutOfStock";
            this.btnOutOfStock.Size = new System.Drawing.Size(233, 55);
            this.btnOutOfStock.TabIndex = 5;
            this.btnOutOfStock.Text = "รายการสินค้าหมด";
            this.btnOutOfStock.UseVisualStyleBackColor = true;
            // 
            // btnProductIn
            // 
            this.btnProductIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductIn.Location = new System.Drawing.Point(0, 220);
            this.btnProductIn.Name = "btnProductIn";
            this.btnProductIn.Size = new System.Drawing.Size(233, 55);
            this.btnProductIn.TabIndex = 4;
            this.btnProductIn.Text = "รับสินค้าเข้า";
            this.btnProductIn.UseVisualStyleBackColor = true;
            // 
            // btnBarcode
            // 
            this.btnBarcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarcode.Location = new System.Drawing.Point(0, 165);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(233, 55);
            this.btnBarcode.TabIndex = 3;
            this.btnBarcode.Text = "บาร์โค้ด";
            this.btnBarcode.UseVisualStyleBackColor = true;
            // 
            // btnCate
            // 
            this.btnCate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCate.Location = new System.Drawing.Point(0, 110);
            this.btnCate.Name = "btnCate";
            this.btnCate.Size = new System.Drawing.Size(233, 55);
            this.btnCate.TabIndex = 2;
            this.btnCate.Text = "หมวดหมู่สินค้า";
            this.btnCate.UseVisualStyleBackColor = true;
            // 
            // btnMaster
            // 
            this.btnMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaster.Location = new System.Drawing.Point(0, 55);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(233, 55);
            this.btnMaster.TabIndex = 1;
            this.btnMaster.Text = "Master";
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(233, 55);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "สินค้า";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "© Copy right 2022 KNN";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Product Service System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem ขอมลหลกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem สนคาToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem จดการผใชToolStripMenuItem;
        private System.Windows.Forms.Button btnOutOfStock;
        private System.Windows.Forms.Button btnProductIn;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Button btnCate;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}