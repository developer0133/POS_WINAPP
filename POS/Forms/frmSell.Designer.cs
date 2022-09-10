
namespace POS.Forms
{
    partial class frmSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSell));
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.dgvSell = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PRODUCT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "ขาย";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 17);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(95, 75);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(186, 22);
            this.txtBarcode.TabIndex = 43;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
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
            this.Amount,
            this.Retail,
            this.PRODUCT_CODE,
            this.PRODUCT_ID,
            this.UNIT_ID});
            this.dgvSell.Location = new System.Drawing.Point(20, 168);
            this.dgvSell.Name = "dgvSell";
            this.dgvSell.RowHeadersWidth = 51;
            this.dgvSell.RowTemplate.Height = 24;
            this.dgvSell.Size = new System.Drawing.Size(1038, 315);
            this.dgvSell.TabIndex = 44;
            this.dgvSell.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSell_CellDoubleClick);
            this.dgvSell.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSell_CellValueChanged);
            this.dgvSell.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSell_EditingControlShowing);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(888, 46);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 83);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "ยกเลิก";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(681, 46);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 83);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PName
            // 
            this.PName.HeaderText = "ชื่อสินค้า";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Width = 125;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "จำนวน";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 125;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "หน่วย";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 125;
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "ราคา";
            this.SellPrice.MinimumWidth = 6;
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            this.SellPrice.Width = 125;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "ส่วนลด(THB)";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "รวม(THB)";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 125;
            // 
            // Retail
            // 
            this.Retail.HeaderText = "ขายส่ง";
            this.Retail.MinimumWidth = 6;
            this.Retail.Name = "Retail";
            this.Retail.Width = 125;
            // 
            // PRODUCT_CODE
            // 
            this.PRODUCT_CODE.DataPropertyName = "PRODUCT_CODE";
            this.PRODUCT_CODE.HeaderText = "รหัส";
            this.PRODUCT_CODE.MinimumWidth = 6;
            this.PRODUCT_CODE.Name = "PRODUCT_CODE";
            this.PRODUCT_CODE.Visible = false;
            this.PRODUCT_CODE.Width = 125;
            // 
            // PRODUCT_ID
            // 
            this.PRODUCT_ID.DataPropertyName = "PRODUCT_ID";
            this.PRODUCT_ID.HeaderText = "PRODUCT_ID";
            this.PRODUCT_ID.MinimumWidth = 6;
            this.PRODUCT_ID.Name = "PRODUCT_ID";
            this.PRODUCT_ID.Visible = false;
            this.PRODUCT_ID.Width = 125;
            // 
            // UNIT_ID
            // 
            this.UNIT_ID.DataPropertyName = "UNIT_ID";
            this.UNIT_ID.HeaderText = "UNIT_ID";
            this.UNIT_ID.MinimumWidth = 6;
            this.UNIT_ID.Name = "UNIT_ID";
            this.UNIT_ID.Width = 125;
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1056, 875);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvSell);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSell";
            this.Text = "Product System Service";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DataGridView dgvSell;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Retail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_ID;
    }
}