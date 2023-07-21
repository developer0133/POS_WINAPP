
namespace POS.Forms
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.grbGeneral = new System.Windows.Forms.GroupBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastCost = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.txtCostAvg = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORYNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVGCOST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETAILPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSellHist = new System.Windows.Forms.DataGridView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOrderHist = new System.Windows.Forms.DataGridView();
            this.grbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellHist)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHist)).BeginInit();
            this.SuspendLayout();
            // 
            // grbGeneral
            // 
            this.grbGeneral.Controls.Add(this.txtRemark);
            this.grbGeneral.Controls.Add(this.label7);
            this.grbGeneral.Controls.Add(this.cboSize);
            this.grbGeneral.Controls.Add(this.label4);
            this.grbGeneral.Controls.Add(this.cboType);
            this.grbGeneral.Controls.Add(this.label5);
            this.grbGeneral.Controls.Add(this.txtBarcode);
            this.grbGeneral.Controls.Add(this.label1);
            this.grbGeneral.Controls.Add(this.txtLastCost);
            this.grbGeneral.Controls.Add(this.Label18);
            this.grbGeneral.Controls.Add(this.chkStatus);
            this.grbGeneral.Controls.Add(this.txtCostAvg);
            this.grbGeneral.Controls.Add(this.Label6);
            this.grbGeneral.Controls.Add(this.cboCategory);
            this.grbGeneral.Controls.Add(this.lblCate);
            this.grbGeneral.Controls.Add(this.txtProductName);
            this.grbGeneral.Controls.Add(this.Label3);
            this.grbGeneral.Controls.Add(this.txtProductID);
            this.grbGeneral.Controls.Add(this.Label2);
            this.grbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.grbGeneral.Location = new System.Drawing.Point(32, 43);
            this.grbGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.grbGeneral.Name = "grbGeneral";
            this.grbGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.grbGeneral.Size = new System.Drawing.Size(556, 395);
            this.grbGeneral.TabIndex = 1;
            this.grbGeneral.TabStop = false;
            this.grbGeneral.Text = "ข้อมูลสินค้า";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(163, 210);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemark.MaxLength = 500;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(363, 52);
            this.txtRemark.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Remark :";
            // 
            // cboSize
            // 
            this.cboSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(163, 175);
            this.cboSize.Margin = new System.Windows.Forms.Padding(4);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(237, 28);
            this.cboSize.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "ขนาด :";
            // 
            // cboType
            // 
            this.cboType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(163, 144);
            this.cboType.Margin = new System.Windows.Forms.Padding(4);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(237, 28);
            this.cboType.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "ชนิดสินค้า :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(163, 85);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.MaxLength = 100;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(363, 27);
            this.txtBarcode.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "บาร์โค้ด:";
            // 
            // txtLastCost
            // 
            this.txtLastCost.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastCost.Enabled = false;
            this.txtLastCost.Location = new System.Drawing.Point(163, 270);
            this.txtLastCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastCost.MaxLength = 5;
            this.txtLastCost.Name = "txtLastCost";
            this.txtLastCost.Size = new System.Drawing.Size(91, 27);
            this.txtLastCost.TabIndex = 5;
            this.txtLastCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(33, 269);
            this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(60, 20);
            this.Label18.TabIndex = 11;
            this.Label18.Text = "ต้นทุน :";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStatus.ForeColor = System.Drawing.Color.Red;
            this.chkStatus.Location = new System.Drawing.Point(163, 352);
            this.chkStatus.Margin = new System.Windows.Forms.Padding(4);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(129, 24);
            this.chkStatus.TabIndex = 6;
            this.chkStatus.Text = "ยกเลิกจำหน่าย";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtCostAvg
            // 
            this.txtCostAvg.Location = new System.Drawing.Point(163, 302);
            this.txtCostAvg.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostAvg.MaxLength = 5;
            this.txtCostAvg.Name = "txtCostAvg";
            this.txtCostAvg.ReadOnly = true;
            this.txtCostAvg.Size = new System.Drawing.Size(91, 27);
            this.txtCostAvg.TabIndex = 5;
            this.txtCostAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(33, 302);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(95, 20);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "ต้นทุนเฉลี่ย :";
            // 
            // cboCategory
            // 
            this.cboCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(163, 112);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(237, 28);
            this.cboCategory.TabIndex = 3;
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(33, 114);
            this.lblCate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(79, 20);
            this.lblCate.TabIndex = 6;
            this.lblCate.Text = "หมวดหมู่ :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(163, 57);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.MaxLength = 100;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(363, 27);
            this.txtProductName.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(33, 57);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(81, 20);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "ชื่อสินค้า* :";
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(163, 25);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductID.MaxLength = 13;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(363, 27);
            this.txtProductID.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(33, 25);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 20);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "รหัสสินค้า :";
            // 
            // dgvProduct
            // 
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCT_ID,
            this.PRODUCT_CODE,
            this.PRODUCT_NAME,
            this.CATEGORYNAME,
            this.PRODUCT_TYPE,
            this.AVGCOST,
            this.RETAILPRICE});
            this.dgvProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProduct.Location = new System.Drawing.Point(19, 94);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1012, 202);
            this.dgvProduct.TabIndex = 2;
            this.dgvProduct.TabStop = false;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.DataPropertyName = "PRODUCT_ID";
            this.PRODUCT_ID.HeaderText = "รหัส";
            this.PRODUCT_ID.MinimumWidth = 6;
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            this.PRODUCT_ID.ReadOnly = true;
            this.PRODUCT_ID.Visible = false;
            this.PRODUCT_ID.Width = 125;
            // 
            // PRODUCT_CODE
            // 
            this.PRODUCT_CODE.DataPropertyName = "PRODUCT_CODE";
            this.PRODUCT_CODE.HeaderText = "รหัส";
            this.PRODUCT_CODE.MinimumWidth = 6;
            this.PRODUCT_CODE.Name = "PRODUCT_CODE";
            this.PRODUCT_CODE.ReadOnly = true;
            this.PRODUCT_CODE.Width = 125;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.DataPropertyName = "PRODUCT_NAME";
            this.PRODUCT_NAME.HeaderText = "ชื่อสินค้า";
            this.PRODUCT_NAME.MinimumWidth = 6;
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.ReadOnly = true;
            this.PRODUCT_NAME.Width = 125;
            // 
            // CATEGORYNAME
            // 
            this.CATEGORYNAME.DataPropertyName = "CATEGORYNAME";
            this.CATEGORYNAME.HeaderText = "หมวดหมู่";
            this.CATEGORYNAME.MinimumWidth = 6;
            this.CATEGORYNAME.Name = "CATEGORYNAME";
            this.CATEGORYNAME.ReadOnly = true;
            this.CATEGORYNAME.Width = 125;
            // 
            // PRODUCT_TYPE
            // 
            this.PRODUCT_TYPE.DataPropertyName = "PRODUCT_TYPE";
            this.PRODUCT_TYPE.HeaderText = "ชนิดสินค้า";
            this.PRODUCT_TYPE.MinimumWidth = 6;
            this.PRODUCT_TYPE.Name = "PRODUCT_TYPE";
            this.PRODUCT_TYPE.ReadOnly = true;
            this.PRODUCT_TYPE.Width = 125;
            // 
            // AVGCOST
            // 
            this.AVGCOST.DataPropertyName = "AVGCOST";
            this.AVGCOST.HeaderText = "ทุน(บาท)";
            this.AVGCOST.MinimumWidth = 6;
            this.AVGCOST.Name = "AVGCOST";
            this.AVGCOST.ReadOnly = true;
            this.AVGCOST.Width = 125;
            // 
            // RETAILPRICE
            // 
            this.RETAILPRICE.DataPropertyName = "RETAILPRICE";
            this.RETAILPRICE.HeaderText = "ราคาขาย(บาท)";
            this.RETAILPRICE.MinimumWidth = 6;
            this.RETAILPRICE.Name = "RETAILPRICE";
            this.RETAILPRICE.ReadOnly = true;
            this.RETAILPRICE.Width = 130;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(27, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "ข้อมูลสินค้า";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(837, 322);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(45, 20);
            this.lblPage.TabIndex = 41;
            this.lblPage.Text = "????";
            this.lblPage.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSellHist);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(507, 464);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1303, 388);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ประวัติการขาย";
            // 
            // dgvSellHist
            // 
            this.dgvSellHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellHist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSellHist.Location = new System.Drawing.Point(19, 42);
            this.dgvSellHist.Name = "dgvSellHist";
            this.dgvSellHist.RowHeadersWidth = 51;
            this.dgvSellHist.RowTemplate.Height = 24;
            this.dgvSellHist.Size = new System.Drawing.Size(1266, 340);
            this.dgvSellHist.TabIndex = 0;
            this.dgvSellHist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellHist_CellContentClick);
            // 
            // btnFirst
            // 
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.Location = new System.Drawing.Point(735, 313);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 34);
            this.btnFirst.TabIndex = 42;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Visible = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(949, 313);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 34);
            this.btnNext.TabIndex = 40;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::POS.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(255, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(162, 90);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::POS.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(58, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 90);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "บันทึก";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.dgvProduct);
            this.groupBox2.Controls.Add(this.btnFirst);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.lblPage);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(622, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1140, 365);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลสินค้า";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(5, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(254, 27);
            this.txtSearch.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(288, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 35);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvOrderHist);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox3.Location = new System.Drawing.Point(507, 882);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1303, 388);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ประวัติการสั่ง";
            // 
            // dgvOrderHist
            // 
            this.dgvOrderHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderHist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvOrderHist.Location = new System.Drawing.Point(19, 26);
            this.dgvOrderHist.Name = "dgvOrderHist";
            this.dgvOrderHist.RowHeadersWidth = 51;
            this.dgvOrderHist.RowTemplate.Height = 24;
            this.dgvOrderHist.Size = new System.Drawing.Size(1266, 340);
            this.dgvOrderHist.TabIndex = 0;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1872, 1055);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduct";
            this.Text = "Product Service System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbGeneral.ResumeLayout(false);
            this.grbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellHist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox grbGeneral;
        internal System.Windows.Forms.TextBox txtLastCost;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.CheckBox chkStatus;
        internal System.Windows.Forms.TextBox txtCostAvg;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cboCategory;
        internal System.Windows.Forms.Label lblCate;
        internal System.Windows.Forms.TextBox txtProductName;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtProductID;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtBarcode;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cboType;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtRemark;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cboSize;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSellHist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORYNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVGCOST;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETAILPRICE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvOrderHist;
    }
}