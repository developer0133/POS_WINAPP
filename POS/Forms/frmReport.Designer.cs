
namespace POS.Forms
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.label2 = new System.Windows.Forms.Label();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tbDaily = new System.Windows.Forms.TabPage();
            this.rptDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELL_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELLPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.tabcontrol1.SuspendLayout();
            this.tbDaily.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "รายงาน";
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tbDaily);
            this.tabcontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabcontrol1.Location = new System.Drawing.Point(17, 83);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(975, 198);
            this.tabcontrol1.TabIndex = 23;
            // 
            // tbDaily
            // 
            this.tbDaily.Controls.Add(this.btnOK);
            this.tbDaily.Controls.Add(this.rptDate);
            this.tbDaily.Location = new System.Drawing.Point(4, 29);
            this.tbDaily.Name = "tbDaily";
            this.tbDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tbDaily.Size = new System.Drawing.Size(967, 165);
            this.tbDaily.TabIndex = 0;
            this.tbDaily.Text = "ประจำวัน";
            this.tbDaily.UseVisualStyleBackColor = true;
            // 
            // rptDate
            // 
            this.rptDate.Location = new System.Drawing.Point(20, 22);
            this.rptDate.Name = "rptDate";
            this.rptDate.Size = new System.Drawing.Size(200, 27);
            this.rptDate.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSum);
            this.groupBox1.Controls.Add(this.dgvReport);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(21, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1339, 321);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายการ";
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.SELL_NO,
            this.PRODUCT_CODE,
            this.PRODUCT_NAME,
            this.Qty,
            this.UNIT,
            this.SELLPRICE,
            this.DISCOUNT,
            this.AMOUNT});
            this.dgvReport.Location = new System.Drawing.Point(20, 26);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1297, 252);
            this.dgvReport.TabIndex = 0;
            // 
            // NO
            // 
            this.NO.DataPropertyName = "NO";
            this.NO.HeaderText = "NO";
            this.NO.MinimumWidth = 6;
            this.NO.Name = "NO";
            this.NO.Width = 125;
            // 
            // SELL_NO
            // 
            this.SELL_NO.DataPropertyName = "SELL_NO";
            this.SELL_NO.HeaderText = "เลขที่การขาย";
            this.SELL_NO.MinimumWidth = 6;
            this.SELL_NO.Name = "SELL_NO";
            this.SELL_NO.Width = 125;
            // 
            // PRODUCT_CODE
            // 
            this.PRODUCT_CODE.DataPropertyName = "PRODUCT_CODE";
            this.PRODUCT_CODE.HeaderText = "รหัสสินค้า";
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
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "จำนวน";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 125;
            // 
            // UNIT
            // 
            this.UNIT.DataPropertyName = "UNIT";
            this.UNIT.HeaderText = "หน่วย";
            this.UNIT.MinimumWidth = 6;
            this.UNIT.Name = "UNIT";
            this.UNIT.Width = 125;
            // 
            // SELLPRICE
            // 
            this.SELLPRICE.DataPropertyName = "SELLPRICE";
            this.SELLPRICE.HeaderText = "ราคา(บาท)";
            this.SELLPRICE.MinimumWidth = 6;
            this.SELLPRICE.Name = "SELLPRICE";
            this.SELLPRICE.Width = 125;
            // 
            // DISCOUNT
            // 
            this.DISCOUNT.DataPropertyName = "DISCOUNT";
            this.DISCOUNT.HeaderText = "ส่วนลด(บาท)";
            this.DISCOUNT.MinimumWidth = 6;
            this.DISCOUNT.Name = "DISCOUNT";
            this.DISCOUNT.Width = 125;
            // 
            // AMOUNT
            // 
            this.AMOUNT.DataPropertyName = "AMOUNT";
            this.AMOUNT.HeaderText = "รวม(บาท)";
            this.AMOUNT.MinimumWidth = 6;
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Width = 125;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::POS.Properties.Resources.print1;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOK.Location = new System.Drawing.Point(270, 22);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(159, 81);
            this.btnOK.TabIndex = 46;
            this.btnOK.Text = "ตกลง";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSum.Location = new System.Drawing.Point(1106, 298);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(66, 24);
            this.lblSum.TabIndex = 25;
            this.lblSum.Text = "label1";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 638);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabcontrol1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.Text = "Product Service System";
            this.tabcontrol1.ResumeLayout(false);
            this.tbDaily.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tbDaily;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker rptDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SELL_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SELLPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private System.Windows.Forms.Label lblSum;
    }
}