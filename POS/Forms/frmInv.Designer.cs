
namespace POS.Forms
{
    partial class frmInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInv));
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.invdate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCostAvg1 = new System.Windows.Forms.Label();
            this.txtCostAvgItem = new System.Windows.Forms.TextBox();
            this.txtCostAvgPack = new System.Windows.Forms.TextBox();
            this.lblCostAvgPack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRetailprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfitRetail = new System.Windows.Forms.TextBox();
            this.txtWholesaleprice = new System.Windows.Forms.TextBox();
            this.txtWholesaleprofit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWholesalePriceItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxprice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtItemBalance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPackBalance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVGCOST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETAILPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "รับสินค้าเข้า";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 17);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "สินค้า";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(188, 68);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(282, 22);
            this.txtProductName.TabIndex = 42;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 116);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(32, 17);
            this.lblDate.TabIndex = 43;
            this.lblDate.Text = "วันที่";
            // 
            // invdate
            // 
            this.invdate.Location = new System.Drawing.Point(188, 111);
            this.invdate.Name = "invdate";
            this.invdate.Size = new System.Drawing.Size(200, 22);
            this.invdate.TabIndex = 44;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(106, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 50);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(17, 161);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 17);
            this.lblQty.TabIndex = 46;
            this.lblQty.Text = "จำนวน";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(188, 161);
            this.txtQty.MaxLength = 5;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 22);
            this.txtQty.TabIndex = 47;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(17, 204);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(40, 17);
            this.lblUnit.TabIndex = 48;
            this.lblUnit.Text = "หน่วย";
            // 
            // cboUnit
            // 
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(188, 204);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(200, 24);
            this.cboUnit.TabIndex = 49;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(17, 248);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 17);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "ราคารวม(บาท)";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(188, 248);
            this.txtAmount.MaxLength = 5;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 51;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblCostAvg1
            // 
            this.lblCostAvg1.AutoSize = true;
            this.lblCostAvg1.Location = new System.Drawing.Point(17, 298);
            this.lblCostAvg1.Name = "lblCostAvg1";
            this.lblCostAvg1.Size = new System.Drawing.Size(132, 17);
            this.lblCostAvg1.TabIndex = 52;
            this.lblCostAvg1.Text = "ราคาทุนเฉลี่ย/ชิ้น(บาท)";
            // 
            // txtCostAvgItem
            // 
            this.txtCostAvgItem.Location = new System.Drawing.Point(188, 298);
            this.txtCostAvgItem.MaxLength = 5;
            this.txtCostAvgItem.Name = "txtCostAvgItem";
            this.txtCostAvgItem.Size = new System.Drawing.Size(200, 22);
            this.txtCostAvgItem.TabIndex = 53;
            // 
            // txtCostAvgPack
            // 
            this.txtCostAvgPack.Location = new System.Drawing.Point(188, 348);
            this.txtCostAvgPack.MaxLength = 5;
            this.txtCostAvgPack.Name = "txtCostAvgPack";
            this.txtCostAvgPack.Size = new System.Drawing.Size(200, 22);
            this.txtCostAvgPack.TabIndex = 55;
            // 
            // lblCostAvgPack
            // 
            this.lblCostAvgPack.AutoSize = true;
            this.lblCostAvgPack.Location = new System.Drawing.Point(17, 348);
            this.lblCostAvgPack.Name = "lblCostAvgPack";
            this.lblCostAvgPack.Size = new System.Drawing.Size(140, 17);
            this.lblCostAvgPack.TabIndex = 54;
            this.lblCostAvgPack.Text = "ราคาทุนเฉลี่ย/แพ็ค(บาท)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "ราคาขายปลีก/ชิ้น(บาท)";
            // 
            // txtRetailprice
            // 
            this.txtRetailprice.Location = new System.Drawing.Point(697, 116);
            this.txtRetailprice.MaxLength = 9;
            this.txtRetailprice.Name = "txtRetailprice";
            this.txtRetailprice.Size = new System.Drawing.Size(102, 22);
            this.txtRetailprice.TabIndex = 57;
            this.txtRetailprice.TextChanged += new System.EventHandler(this.txtRetailprice_TextChanged);
            this.txtRetailprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetailprice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "ราคาขายส่ง/แพ็ค/โหล(บาท)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(830, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "กำไร(ปลีก)";
            // 
            // txtProfitRetail
            // 
            this.txtProfitRetail.BackColor = System.Drawing.SystemColors.Control;
            this.txtProfitRetail.Enabled = false;
            this.txtProfitRetail.Location = new System.Drawing.Point(905, 114);
            this.txtProfitRetail.MaxLength = 5;
            this.txtProfitRetail.Name = "txtProfitRetail";
            this.txtProfitRetail.Size = new System.Drawing.Size(84, 22);
            this.txtProfitRetail.TabIndex = 60;
            // 
            // txtWholesaleprice
            // 
            this.txtWholesaleprice.Location = new System.Drawing.Point(697, 161);
            this.txtWholesaleprice.MaxLength = 9;
            this.txtWholesaleprice.Name = "txtWholesaleprice";
            this.txtWholesaleprice.Size = new System.Drawing.Size(102, 22);
            this.txtWholesaleprice.TabIndex = 61;
            this.txtWholesaleprice.TextChanged += new System.EventHandler(this.txtWholesaleprice_TextChanged);
            this.txtWholesaleprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWholesaleprice_KeyPress);
            // 
            // txtWholesaleprofit
            // 
            this.txtWholesaleprofit.BackColor = System.Drawing.SystemColors.Control;
            this.txtWholesaleprofit.Enabled = false;
            this.txtWholesaleprofit.Location = new System.Drawing.Point(905, 159);
            this.txtWholesaleprofit.MaxLength = 5;
            this.txtWholesaleprofit.Name = "txtWholesaleprofit";
            this.txtWholesaleprofit.Size = new System.Drawing.Size(84, 22);
            this.txtWholesaleprofit.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(830, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "กำไร(ส่ง)";
            // 
            // txtWholesalePriceItem
            // 
            this.txtWholesalePriceItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtWholesalePriceItem.Enabled = false;
            this.txtWholesalePriceItem.Location = new System.Drawing.Point(905, 199);
            this.txtWholesalePriceItem.MaxLength = 5;
            this.txtWholesalePriceItem.Name = "txtWholesalePriceItem";
            this.txtWholesalePriceItem.Size = new System.Drawing.Size(84, 22);
            this.txtWholesalePriceItem.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(830, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "เฉลี่ย/ชิ้น";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "ราคาขาย/ลัง(บาท)";
            // 
            // txtBoxprice
            // 
            this.txtBoxprice.Location = new System.Drawing.Point(697, 254);
            this.txtBoxprice.MaxLength = 9;
            this.txtBoxprice.Name = "txtBoxprice";
            this.txtBoxprice.Size = new System.Drawing.Size(102, 22);
            this.txtBoxprice.TabIndex = 67;
            this.txtBoxprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxprice_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtItemBalance);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtPackBalance);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtBoxBalance);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(500, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 158);
            this.panel1.TabIndex = 68;
            this.panel1.Tag = "";
            // 
            // txtItemBalance
            // 
            this.txtItemBalance.BackColor = System.Drawing.SystemColors.Control;
            this.txtItemBalance.Enabled = false;
            this.txtItemBalance.Location = new System.Drawing.Point(112, 108);
            this.txtItemBalance.Name = "txtItemBalance";
            this.txtItemBalance.Size = new System.Drawing.Size(133, 22);
            this.txtItemBalance.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 71;
            this.label10.Text = "คงเหลือ/ชิ้น";
            // 
            // txtPackBalance
            // 
            this.txtPackBalance.BackColor = System.Drawing.SystemColors.Control;
            this.txtPackBalance.Enabled = false;
            this.txtPackBalance.Location = new System.Drawing.Point(112, 67);
            this.txtPackBalance.Name = "txtPackBalance";
            this.txtPackBalance.Size = new System.Drawing.Size(133, 22);
            this.txtPackBalance.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 69;
            this.label9.Text = "คงเหลือ/แพ็ค";
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxBalance.Enabled = false;
            this.txtBoxBalance.Location = new System.Drawing.Point(112, 21);
            this.txtBoxBalance.Name = "txtBoxBalance";
            this.txtBoxBalance.Size = new System.Drawing.Size(133, 22);
            this.txtBoxBalance.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "คงเหลือ/ลัง";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 50);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvInv
            // 
            this.dgvInv.BackgroundColor = System.Drawing.Color.White;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCT_ID,
            this.inv_id,
            this.PRODUCT_CODE,
            this.PRODUCT_NAME,
            this.QTY,
            this.PRODUCT_TYPE,
            this.AVGCOST,
            this.RETAILPRICE});
            this.dgvInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvInv.Location = new System.Drawing.Point(12, 576);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.RowHeadersWidth = 51;
            this.dgvInv.RowTemplate.Height = 24;
            this.dgvInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInv.Size = new System.Drawing.Size(1013, 202);
            this.dgvInv.TabIndex = 70;
            this.dgvInv.TabStop = false;
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.DataPropertyName = "PRODUCT_ID";
            this.PRODUCT_ID.HeaderText = "รหัส";
            this.PRODUCT_ID.MinimumWidth = 6;
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            this.PRODUCT_ID.Visible = false;
            this.PRODUCT_ID.Width = 125;
            // 
            // inv_id
            // 
            this.inv_id.DataPropertyName = "INV_ID";
            this.inv_id.HeaderText = "inv_id";
            this.inv_id.MinimumWidth = 6;
            this.inv_id.Name = "inv_id";
            this.inv_id.Visible = false;
            this.inv_id.Width = 125;
            // 
            // PRODUCT_CODE
            // 
            this.PRODUCT_CODE.DataPropertyName = "PRODUCT_CODE";
            this.PRODUCT_CODE.HeaderText = "รหัส";
            this.PRODUCT_CODE.MinimumWidth = 6;
            this.PRODUCT_CODE.Name = "PRODUCT_CODE";
            this.PRODUCT_CODE.Width = 125;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.DataPropertyName = "PRODUCT_NAME";
            this.PRODUCT_NAME.HeaderText = "ชื่อสินค้า";
            this.PRODUCT_NAME.MinimumWidth = 6;
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            this.PRODUCT_NAME.Width = 125;
            // 
            // QTY
            // 
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "จำนวน";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.Width = 125;
            // 
            // PRODUCT_TYPE
            // 
            this.PRODUCT_TYPE.DataPropertyName = "PRODUCT_TYPE";
            this.PRODUCT_TYPE.HeaderText = "ชนิดสินค้า";
            this.PRODUCT_TYPE.MinimumWidth = 6;
            this.PRODUCT_TYPE.Name = "PRODUCT_TYPE";
            this.PRODUCT_TYPE.Width = 125;
            // 
            // AVGCOST
            // 
            this.AVGCOST.DataPropertyName = "AVGCOST";
            this.AVGCOST.HeaderText = "ทุน(บาท)";
            this.AVGCOST.MinimumWidth = 6;
            this.AVGCOST.Name = "AVGCOST";
            this.AVGCOST.Width = 125;
            // 
            // RETAILPRICE
            // 
            this.RETAILPRICE.DataPropertyName = "RETAILPRICE";
            this.RETAILPRICE.HeaderText = "ราคาขาย(บาท)";
            this.RETAILPRICE.MinimumWidth = 6;
            this.RETAILPRICE.Name = "RETAILPRICE";
            this.RETAILPRICE.Width = 125;
            // 
            // frmInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1056, 791);
            this.Controls.Add(this.dgvInv);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWholesalePriceItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWholesaleprofit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWholesaleprice);
            this.Controls.Add(this.txtProfitRetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRetailprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCostAvgPack);
            this.Controls.Add(this.lblCostAvgPack);
            this.Controls.Add(this.txtCostAvgItem);
            this.Controls.Add(this.lblCostAvg1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.invdate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Product Service System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker invdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCostAvg1;
        private System.Windows.Forms.TextBox txtCostAvgItem;
        private System.Windows.Forms.TextBox txtCostAvgPack;
        private System.Windows.Forms.Label lblCostAvgPack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRetailprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProfitRetail;
        private System.Windows.Forms.TextBox txtWholesaleprice;
        private System.Windows.Forms.TextBox txtWholesaleprofit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWholesalePriceItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxprice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtItemBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPackBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn inv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVGCOST;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETAILPRICE;
    }
}