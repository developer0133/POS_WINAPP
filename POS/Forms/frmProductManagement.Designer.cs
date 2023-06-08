namespace POS.Forms
{
    partial class frmProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductManagement));
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCostAvgItem = new System.Windows.Forms.TextBox();
            this.lblCostAvg1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWholesalePriceItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWholesaleprofit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfitRetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRetailprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(12, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "จัดการสินค้า";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtProductName.Location = new System.Drawing.Point(177, 29);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(281, 24);
            this.txtProductName.TabIndex = 44;
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblName.Location = new System.Drawing.Point(6, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 18);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "สินค้า";
            // 
            // cboUnit
            // 
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(177, 78);
            this.cboUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(200, 26);
            this.cboUnit.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCostAvgItem);
            this.groupBox1.Controls.Add(this.lblCostAvg1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblRemark);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtWholesalePriceItem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWholesaleprofit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProfitRetail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRetailprice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.cboUnit);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(17, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1291, 402);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // txtCostAvgItem
            // 
            this.txtCostAvgItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtCostAvgItem.Enabled = false;
            this.txtCostAvgItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCostAvgItem.Location = new System.Drawing.Point(177, 187);
            this.txtCostAvgItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostAvgItem.MaxLength = 5;
            this.txtCostAvgItem.Name = "txtCostAvgItem";
            this.txtCostAvgItem.Size = new System.Drawing.Size(200, 24);
            this.txtCostAvgItem.TabIndex = 95;
            // 
            // lblCostAvg1
            // 
            this.lblCostAvg1.AutoSize = true;
            this.lblCostAvg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCostAvg1.Location = new System.Drawing.Point(6, 187);
            this.lblCostAvg1.Name = "lblCostAvg1";
            this.lblCostAvg1.Size = new System.Drawing.Size(120, 18);
            this.lblCostAvg1.TabIndex = 94;
            this.lblCostAvg1.Text = "ราคาทุนเฉลี่ย (บาท)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 91;
            this.label2.Text = "ลักษณะหน่วยการขาย";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRemark.Location = new System.Drawing.Point(551, 199);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(61, 18);
            this.lblRemark.TabIndex = 90;
            this.lblRemark.Text = "หมายเหตุ";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRemark.Location = new System.Drawing.Point(554, 238);
            this.txtRemark.MaxLength = 300;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(351, 158);
            this.txtRemark.TabIndex = 89;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.Location = new System.Drawing.Point(739, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 18);
            this.label14.TabIndex = 88;
            this.label14.Text = "บาท";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(739, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 18);
            this.label13.TabIndex = 87;
            this.label13.Text = "บาท";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(739, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 18);
            this.label12.TabIndex = 86;
            this.label12.Text = "บาท";
            // 
            // txtWholesalePriceItem
            // 
            this.txtWholesalePriceItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtWholesalePriceItem.Enabled = false;
            this.txtWholesalePriceItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtWholesalePriceItem.Location = new System.Drawing.Point(627, 117);
            this.txtWholesalePriceItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWholesalePriceItem.MaxLength = 5;
            this.txtWholesalePriceItem.Name = "txtWholesalePriceItem";
            this.txtWholesalePriceItem.Size = new System.Drawing.Size(106, 24);
            this.txtWholesalePriceItem.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(551, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 84;
            this.label5.Text = "เฉลี่ย/ชิ้น";
            // 
            // txtWholesaleprofit
            // 
            this.txtWholesaleprofit.BackColor = System.Drawing.SystemColors.Control;
            this.txtWholesaleprofit.Enabled = false;
            this.txtWholesaleprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtWholesaleprofit.Location = new System.Drawing.Point(627, 77);
            this.txtWholesaleprofit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWholesaleprofit.MaxLength = 5;
            this.txtWholesaleprofit.Name = "txtWholesaleprofit";
            this.txtWholesaleprofit.Size = new System.Drawing.Size(106, 24);
            this.txtWholesaleprofit.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(551, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "กำไร(ส่ง)";
            // 
            // txtProfitRetail
            // 
            this.txtProfitRetail.BackColor = System.Drawing.SystemColors.Control;
            this.txtProfitRetail.Enabled = false;
            this.txtProfitRetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtProfitRetail.Location = new System.Drawing.Point(627, 32);
            this.txtProfitRetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfitRetail.MaxLength = 5;
            this.txtProfitRetail.Name = "txtProfitRetail";
            this.txtProfitRetail.Size = new System.Drawing.Size(106, 24);
            this.txtProfitRetail.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(551, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 80;
            this.label3.Text = "กำไร(ปลีก)";
            // 
            // txtRetailprice
            // 
            this.txtRetailprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRetailprice.Location = new System.Drawing.Point(177, 135);
            this.txtRetailprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRetailprice.MaxLength = 9;
            this.txtRetailprice.Name = "txtRetailprice";
            this.txtRetailprice.Size = new System.Drawing.Size(200, 24);
            this.txtRetailprice.TabIndex = 79;
            this.txtRetailprice.TextChanged += new System.EventHandler(this.txtRetailprice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(8, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 78;
            this.label1.Text = "ราคาขาย(บาท)";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(177, 297);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 82);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(-5, 297);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 82);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "บันทึก";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.dgvInv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(17, 510);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1325, 303);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลรายการ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(255, 24);
            this.txtSearch.TabIndex = 72;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(291, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 34);
            this.btnSearch.TabIndex = 71;
            this.btnSearch.Text = "    ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvInv
            // 
            this.dgvInv.BackgroundColor = System.Drawing.Color.White;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvInv.Location = new System.Drawing.Point(7, 64);
            this.dgvInv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.ReadOnly = true;
            this.dgvInv.RowHeadersWidth = 51;
            this.dgvInv.RowTemplate.Height = 24;
            this.dgvInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInv.Size = new System.Drawing.Size(1284, 219);
            this.dgvInv.TabIndex = 70;
            this.dgvInv.TabStop = false;
            this.dgvInv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInv_CellClick);
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 826);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "ProductManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWholesalePriceItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWholesaleprofit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfitRetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRetailprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCostAvgItem;
        private System.Windows.Forms.Label lblCostAvg1;
    }
}