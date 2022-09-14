
namespace POS.Forms
{
    partial class frmOutOfStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutOfStock));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOutOfStock = new System.Windows.Forms.DataGridView();
            this.PRODUCT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BALANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORYNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutOfStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "รายการสินค้าหมด";
            // 
            // dgvOutOfStock
            // 
            this.dgvOutOfStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutOfStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCT_CODE,
            this.PRODUCT_NAME,
            this.BALANCE,
            this.CATEGORYNAME,
            this.PRODUCT_TYPE,
            this.REMARK});
            this.dgvOutOfStock.Location = new System.Drawing.Point(16, 40);
            this.dgvOutOfStock.Name = "dgvOutOfStock";
            this.dgvOutOfStock.RowHeadersWidth = 51;
            this.dgvOutOfStock.RowTemplate.Height = 24;
            this.dgvOutOfStock.Size = new System.Drawing.Size(996, 264);
            this.dgvOutOfStock.TabIndex = 22;
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
            // BALANCE
            // 
            this.BALANCE.DataPropertyName = "BALANCE";
            this.BALANCE.HeaderText = "คงเหลือ";
            this.BALANCE.MinimumWidth = 6;
            this.BALANCE.Name = "BALANCE";
            this.BALANCE.Width = 125;
            // 
            // CATEGORYNAME
            // 
            this.CATEGORYNAME.DataPropertyName = "CATEGORYNAME";
            this.CATEGORYNAME.HeaderText = "หมวดหมู่";
            this.CATEGORYNAME.MinimumWidth = 6;
            this.CATEGORYNAME.Name = "CATEGORYNAME";
            this.CATEGORYNAME.Width = 125;
            // 
            // PRODUCT_TYPE
            // 
            this.PRODUCT_TYPE.DataPropertyName = "PRODUCT_TYPE";
            this.PRODUCT_TYPE.HeaderText = "ประเภทสินค้า";
            this.PRODUCT_TYPE.MinimumWidth = 6;
            this.PRODUCT_TYPE.Name = "PRODUCT_TYPE";
            this.PRODUCT_TYPE.Width = 125;
            // 
            // REMARK
            // 
            this.REMARK.DataPropertyName = "REMARK";
            this.REMARK.HeaderText = "หมายเหตุ";
            this.REMARK.MinimumWidth = 6;
            this.REMARK.Name = "REMARK";
            this.REMARK.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOutOfStock);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(26, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 407);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // frmOutOfStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 791);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOutOfStock";
            this.Text = "Product Service System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutOfStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvOutOfStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BALANCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORYNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMARK;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}