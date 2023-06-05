
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
            this.STR_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STR_AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STR_TOTAL_AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CHKType = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblName.Location = new System.Drawing.Point(17, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 18);
            this.lblName.TabIndex = 41;
            this.lblName.Text = "สินค้า";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtProductName.Location = new System.Drawing.Point(188, 68);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(281, 24);
            this.txtProductName.TabIndex = 42;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDate.Location = new System.Drawing.Point(17, 116);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 18);
            this.lblDate.TabIndex = 43;
            this.lblDate.Text = "วันที่";
            // 
            // invdate
            // 
            this.invdate.Location = new System.Drawing.Point(188, 111);
            this.invdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invdate.Name = "invdate";
            this.invdate.Size = new System.Drawing.Size(200, 22);
            this.invdate.TabIndex = 44;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::POS.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(107, 406);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 82);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "บันทึก";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblQty.Location = new System.Drawing.Point(17, 161);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 18);
            this.lblQty.TabIndex = 46;
            this.lblQty.Text = "จำนวน";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQty.Location = new System.Drawing.Point(188, 161);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQty.MaxLength = 5;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 24);
            this.txtQty.TabIndex = 47;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblUnit.Location = new System.Drawing.Point(17, 204);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(41, 18);
            this.lblUnit.TabIndex = 48;
            this.lblUnit.Text = "หน่วย";
            // 
            // cboUnit
            // 
            this.cboUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(188, 204);
            this.cboUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(200, 26);
            this.cboUnit.TabIndex = 49;
            this.cboUnit.DropDownClosed += new System.EventHandler(this.cboUnit_DropDownClosed);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotal.Location = new System.Drawing.Point(17, 249);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 18);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "ราคารวม(บาท)";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtAmount.Location = new System.Drawing.Point(188, 249);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 24);
            this.txtAmount.TabIndex = 51;
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // lblCostAvg1
            // 
            this.lblCostAvg1.AutoSize = true;
            this.lblCostAvg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCostAvg1.Location = new System.Drawing.Point(17, 298);
            this.lblCostAvg1.Name = "lblCostAvg1";
            this.lblCostAvg1.Size = new System.Drawing.Size(137, 18);
            this.lblCostAvg1.TabIndex = 52;
            this.lblCostAvg1.Text = "ราคาทุนเฉลี่ย/ชิ้น(บาท)";
            // 
            // txtCostAvgItem
            // 
            this.txtCostAvgItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtCostAvgItem.Enabled = false;
            this.txtCostAvgItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCostAvgItem.Location = new System.Drawing.Point(188, 298);
            this.txtCostAvgItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostAvgItem.MaxLength = 5;
            this.txtCostAvgItem.Name = "txtCostAvgItem";
            this.txtCostAvgItem.Size = new System.Drawing.Size(200, 24);
            this.txtCostAvgItem.TabIndex = 53;
            // 
            // txtCostAvgPack
            // 
            this.txtCostAvgPack.BackColor = System.Drawing.SystemColors.Control;
            this.txtCostAvgPack.Enabled = false;
            this.txtCostAvgPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCostAvgPack.Location = new System.Drawing.Point(188, 348);
            this.txtCostAvgPack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostAvgPack.MaxLength = 5;
            this.txtCostAvgPack.Name = "txtCostAvgPack";
            this.txtCostAvgPack.Size = new System.Drawing.Size(200, 24);
            this.txtCostAvgPack.TabIndex = 55;
            // 
            // lblCostAvgPack
            // 
            this.lblCostAvgPack.AutoSize = true;
            this.lblCostAvgPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCostAvgPack.Location = new System.Drawing.Point(17, 348);
            this.lblCostAvgPack.Name = "lblCostAvgPack";
            this.lblCostAvgPack.Size = new System.Drawing.Size(147, 18);
            this.lblCostAvgPack.TabIndex = 54;
            this.lblCostAvgPack.Text = "ราคาทุนเฉลี่ย/แพ็ค(บาท)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(509, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "ราคาขายปลีก/ชิ้น(บาท)";
            // 
            // txtRetailprice
            // 
            this.txtRetailprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRetailprice.Location = new System.Drawing.Point(697, 116);
            this.txtRetailprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRetailprice.MaxLength = 9;
            this.txtRetailprice.Name = "txtRetailprice";
            this.txtRetailprice.Size = new System.Drawing.Size(103, 24);
            this.txtRetailprice.TabIndex = 57;
            this.txtRetailprice.TextChanged += new System.EventHandler(this.txtRetailprice_TextChanged);
            this.txtRetailprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRetailprice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(509, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "ราคาขายส่ง/แพ็ค/โหล(บาท)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(829, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "กำไร(ปลีก)";
            // 
            // txtProfitRetail
            // 
            this.txtProfitRetail.BackColor = System.Drawing.SystemColors.Control;
            this.txtProfitRetail.Enabled = false;
            this.txtProfitRetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtProfitRetail.Location = new System.Drawing.Point(905, 114);
            this.txtProfitRetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfitRetail.MaxLength = 5;
            this.txtProfitRetail.Name = "txtProfitRetail";
            this.txtProfitRetail.Size = new System.Drawing.Size(106, 24);
            this.txtProfitRetail.TabIndex = 60;
            // 
            // txtWholesaleprice
            // 
            this.txtWholesaleprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtWholesaleprice.Location = new System.Drawing.Point(697, 161);
            this.txtWholesaleprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWholesaleprice.MaxLength = 9;
            this.txtWholesaleprice.Name = "txtWholesaleprice";
            this.txtWholesaleprice.Size = new System.Drawing.Size(103, 24);
            this.txtWholesaleprice.TabIndex = 61;
            this.txtWholesaleprice.TextChanged += new System.EventHandler(this.txtWholesaleprice_TextChanged);
            this.txtWholesaleprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWholesaleprice_KeyPress);
            // 
            // txtWholesaleprofit
            // 
            this.txtWholesaleprofit.BackColor = System.Drawing.SystemColors.Control;
            this.txtWholesaleprofit.Enabled = false;
            this.txtWholesaleprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtWholesaleprofit.Location = new System.Drawing.Point(905, 159);
            this.txtWholesaleprofit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWholesaleprofit.MaxLength = 5;
            this.txtWholesaleprofit.Name = "txtWholesaleprofit";
            this.txtWholesaleprofit.Size = new System.Drawing.Size(106, 24);
            this.txtWholesaleprofit.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(829, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "กำไร(ส่ง)";
            // 
            // txtWholesalePriceItem
            // 
            this.txtWholesalePriceItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtWholesalePriceItem.Enabled = false;
            this.txtWholesalePriceItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtWholesalePriceItem.Location = new System.Drawing.Point(905, 199);
            this.txtWholesalePriceItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWholesalePriceItem.MaxLength = 5;
            this.txtWholesalePriceItem.Name = "txtWholesalePriceItem";
            this.txtWholesalePriceItem.Size = new System.Drawing.Size(106, 24);
            this.txtWholesalePriceItem.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(829, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 64;
            this.label5.Text = "เฉลี่ย/ชิ้น";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(509, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 66;
            this.label6.Text = "ราคาขาย/ลัง(บาท)";
            // 
            // txtBoxprice
            // 
            this.txtBoxprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtBoxprice.Location = new System.Drawing.Point(697, 254);
            this.txtBoxprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxprice.MaxLength = 9;
            this.txtBoxprice.Name = "txtBoxprice";
            this.txtBoxprice.Size = new System.Drawing.Size(103, 24);
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
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.panel1.Location = new System.Drawing.Point(500, 298);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtItemBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemBalance.Name = "txtItemBalance";
            this.txtItemBalance.Size = new System.Drawing.Size(133, 24);
            this.txtItemBalance.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 71;
            this.label10.Text = "คงเหลือ/ชิ้น";
            // 
            // txtPackBalance
            // 
            this.txtPackBalance.BackColor = System.Drawing.SystemColors.Control;
            this.txtPackBalance.Enabled = false;
            this.txtPackBalance.Location = new System.Drawing.Point(112, 66);
            this.txtPackBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPackBalance.Name = "txtPackBalance";
            this.txtPackBalance.Size = new System.Drawing.Size(133, 24);
            this.txtPackBalance.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 69;
            this.label9.Text = "คงเหลือ/แพ็ค";
            // 
            // txtBoxBalance
            // 
            this.txtBoxBalance.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxBalance.Enabled = false;
            this.txtBoxBalance.Location = new System.Drawing.Point(112, 21);
            this.txtBoxBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBalance.Name = "txtBoxBalance";
            this.txtBoxBalance.Size = new System.Drawing.Size(133, 24);
            this.txtBoxBalance.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 67;
            this.label7.Text = "คงเหลือ/ลัง";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::POS.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(289, 406);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 82);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.STR_UNIT,
            this.STR_AMOUNT,
            this.STR_TOTAL_AMOUNT,
            this.REMARK});
            this.dgvInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvInv.Location = new System.Drawing.Point(7, 64);
            this.dgvInv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.ReadOnly = true;
            this.dgvInv.RowHeadersWidth = 51;
            this.dgvInv.RowTemplate.Height = 24;
            this.dgvInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInv.Size = new System.Drawing.Size(1284, 219);
            this.dgvInv.TabIndex = 70;
            this.dgvInv.TabStop = false;
            this.dgvInv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInv_CellClick);
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
            // inv_id
            // 
            this.inv_id.DataPropertyName = "INV_ID";
            this.inv_id.HeaderText = "inv_id";
            this.inv_id.MinimumWidth = 6;
            this.inv_id.Name = "inv_id";
            this.inv_id.ReadOnly = true;
            this.inv_id.Visible = false;
            this.inv_id.Width = 125;
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
            this.PRODUCT_NAME.Width = 140;
            // 
            // QTY
            // 
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "จำนวน";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 125;
            // 
            // STR_UNIT
            // 
            this.STR_UNIT.DataPropertyName = "STR_UNIT";
            this.STR_UNIT.HeaderText = "หน่วย";
            this.STR_UNIT.MinimumWidth = 6;
            this.STR_UNIT.Name = "STR_UNIT";
            this.STR_UNIT.ReadOnly = true;
            this.STR_UNIT.Width = 125;
            // 
            // STR_AMOUNT
            // 
            this.STR_AMOUNT.DataPropertyName = "STR_AMOUNT";
            this.STR_AMOUNT.HeaderText = "Amount";
            this.STR_AMOUNT.MinimumWidth = 6;
            this.STR_AMOUNT.Name = "STR_AMOUNT";
            this.STR_AMOUNT.ReadOnly = true;
            this.STR_AMOUNT.Width = 125;
            // 
            // STR_TOTAL_AMOUNT
            // 
            this.STR_TOTAL_AMOUNT.DataPropertyName = "STR_TOTAL_AMOUNT";
            this.STR_TOTAL_AMOUNT.HeaderText = "TotalAmount(THB)";
            this.STR_TOTAL_AMOUNT.MinimumWidth = 6;
            this.STR_TOTAL_AMOUNT.Name = "STR_TOTAL_AMOUNT";
            this.STR_TOTAL_AMOUNT.ReadOnly = true;
            this.STR_TOTAL_AMOUNT.Width = 135;
            // 
            // REMARK
            // 
            this.REMARK.DataPropertyName = "REMARK";
            this.REMARK.HeaderText = "หมายเหตุ";
            this.REMARK.MinimumWidth = 6;
            this.REMARK.Name = "REMARK";
            this.REMARK.ReadOnly = true;
            this.REMARK.Width = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dgvInv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(67, 508);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1325, 303);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายการ";
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRemark.Location = new System.Drawing.Point(1007, 298);
            this.txtRemark.MaxLength = 300;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(351, 158);
            this.txtRemark.TabIndex = 72;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRemark.Location = new System.Drawing.Point(1004, 259);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(61, 18);
            this.lblRemark.TabIndex = 73;
            this.lblRemark.Text = "หมายเหตุ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(509, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 74;
            this.label11.Text = "ถาด/กล่อง(บาท)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(1017, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 18);
            this.label12.TabIndex = 75;
            this.label12.Text = "บาท";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(1017, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 18);
            this.label13.TabIndex = 76;
            this.label13.Text = "บาท";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.Location = new System.Drawing.Point(1017, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 18);
            this.label14.TabIndex = 77;
            this.label14.Text = "บาท";
            // 
            // CHKType
            // 
            this.CHKType.AutoSize = true;
            this.CHKType.Location = new System.Drawing.Point(512, 68);
            this.CHKType.Name = "CHKType";
            this.CHKType.Size = new System.Drawing.Size(48, 20);
            this.CHKType.TabIndex = 78;
            this.CHKType.Text = "ปลีก";
            this.CHKType.UseVisualStyleBackColor = true;
            this.CHKType.CheckedChanged += new System.EventHandler(this.CHKType_CheckedChanged);
            // 
            // frmInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1421, 826);
            this.Controls.Add(this.CHKType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.groupBox1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Product Service System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STR_TOTAL_AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMARK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CHKType;
    }
}