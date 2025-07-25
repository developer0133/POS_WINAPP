﻿namespace POS.Forms
{
    partial class frmSellManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellManual));
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.dgvSell = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchNo = new System.Windows.Forms.TextBox();
            this.btnSaveDraft = new System.Windows.Forms.Button();
            this.btnReportInv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(33, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "ADDR";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(172, 174);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(287, 22);
            this.txtAddr.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(33, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "CUSTOMER NAME";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(172, 143);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(287, 22);
            this.txtCusName.TabIndex = 62;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSum.Location = new System.Drawing.Point(912, 739);
            this.lblSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(232, 25);
            this.lblSum.TabIndex = 61;
            this.lblSum.Text = "GRAND TOTAL 0 THB";
            // 
            // dgvSell
            // 
            this.dgvSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.Qty,
            this.Unit,
            this.SellPrice,
            this.Discount,
            this.Amount});
            this.dgvSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSell.Location = new System.Drawing.Point(38, 495);
            this.dgvSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSell.Name = "dgvSell";
            this.dgvSell.RowHeadersWidth = 51;
            this.dgvSell.RowTemplate.Height = 24;
            this.dgvSell.Size = new System.Drawing.Size(1142, 199);
            this.dgvSell.TabIndex = 57;
            this.dgvSell.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSell_CellDoubleClick);
            this.dgvSell.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSell_CellValueChanged);
            this.dgvSell.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSell_EditingControlShowing);
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PRODUCT_NAME";
            this.PName.HeaderText = "PRODUCT NAME";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.Width = 140;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "QTY";
            this.Qty.HeaderText = "QTY";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 125;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "UNIT";
            this.Unit.HeaderText = "UNIT";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.Width = 125;
            // 
            // SellPrice
            // 
            this.SellPrice.DataPropertyName = "PRICE";
            this.SellPrice.HeaderText = "PRICE";
            this.SellPrice.MinimumWidth = 6;
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.Width = 125;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "DISCOUNT";
            this.Discount.HeaderText = "DIS(THB)";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 125;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "TOTAL";
            this.Amount.HeaderText = "TOTAL(THB)";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = global::POS.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(812, 84);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 82);
            this.btnSave.TabIndex = 59;
            this.btnSave.Tag = "";
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Image = global::POS.Properties.Resources.cancel;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(1001, 85);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 82);
            this.btnClear.TabIndex = 58;
            this.btnClear.Text = "CLEAR";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Image = global::POS.Properties.Resources.print;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReport.Location = new System.Drawing.Point(812, 206);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(171, 82);
            this.btnReport.TabIndex = 60;
            this.btnReport.Text = "PRINT ORDER";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(172, 218);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(287, 22);
            this.txtProductName.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(33, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "PRODUCT NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(33, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "QTY";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(172, 251);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(287, 22);
            this.txtQty.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(33, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "UNIT";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(172, 280);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(287, 22);
            this.txtUnit.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(35, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "PRICE";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(174, 310);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(285, 22);
            this.txtPrice.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(33, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 75;
            this.label7.Text = "DIS";
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(172, 338);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(69, 22);
            this.txtDis.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(35, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 77;
            this.label9.Text = "DATE";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(172, 111);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 22);
            this.txtDate.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSearchNo);
            this.groupBox1.Location = new System.Drawing.Point(36, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 100);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(398, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 34);
            this.btnSearch.TabIndex = 81;
            this.btnSearch.Text = "    OK";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Invoice/Del No";
            // 
            // txtSearchNo
            // 
            this.txtSearchNo.Location = new System.Drawing.Point(118, 30);
            this.txtSearchNo.Name = "txtSearchNo";
            this.txtSearchNo.Size = new System.Drawing.Size(263, 22);
            this.txtSearchNo.TabIndex = 0;
            // 
            // btnSaveDraft
            // 
            this.btnSaveDraft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveDraft.Image = global::POS.Properties.Resources.save;
            this.btnSaveDraft.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveDraft.Location = new System.Drawing.Point(625, 84);
            this.btnSaveDraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveDraft.Name = "btnSaveDraft";
            this.btnSaveDraft.Size = new System.Drawing.Size(171, 82);
            this.btnSaveDraft.TabIndex = 80;
            this.btnSaveDraft.Tag = "";
            this.btnSaveDraft.Text = "SAVE_DRAFT";
            this.btnSaveDraft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveDraft.UseVisualStyleBackColor = true;
            this.btnSaveDraft.Click += new System.EventHandler(this.btnSaveDraft_Click);
            // 
            // btnReportInv
            // 
            this.btnReportInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportInv.Image = global::POS.Properties.Resources.print;
            this.btnReportInv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportInv.Location = new System.Drawing.Point(625, 206);
            this.btnReportInv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportInv.Name = "btnReportInv";
            this.btnReportInv.Size = new System.Drawing.Size(171, 82);
            this.btnReportInv.TabIndex = 81;
            this.btnReportInv.Text = "PRINT INVOICE";
            this.btnReportInv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportInv.UseVisualStyleBackColor = true;
            this.btnReportInv.Click += new System.EventHandler(this.btnReportInv_Click);
            // 
            // frmSellManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 933);
            this.Controls.Add(this.btnReportInv);
            this.Controls.Add(this.btnSaveDraft);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvSell);
            this.Controls.Add(this.btnReport);
            this.Name = "frmSellManual";
            this.Text = "MANUAL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSell;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSaveDraft;
        private System.Windows.Forms.Button btnReportInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}