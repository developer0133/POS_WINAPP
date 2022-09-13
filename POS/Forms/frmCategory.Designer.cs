
namespace POS.Forms
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvCate = new System.Windows.Forms.DataGridView();
            this.CATEGORY_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATE_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCateCode = new System.Windows.Forms.TextBox();
            this.lblCateCode = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(1142, 386);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 34);
            this.btnFirst.TabIndex = 37;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(1264, 403);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(40, 17);
            this.lblPage.TabIndex = 36;
            this.lblPage.Text = "????";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1352, 386);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 34);
            this.btnNext.TabIndex = 35;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvCate
            // 
            this.dgvCate.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CATEGORY_ID,
            this.CATEGORY_NAME,
            this.CATE_CODE,
            this.REMARK});
            this.dgvCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCate.Location = new System.Drawing.Point(459, 139);
            this.dgvCate.Name = "dgvCate";
            this.dgvCate.ReadOnly = true;
            this.dgvCate.RowHeadersWidth = 51;
            this.dgvCate.RowTemplate.Height = 24;
            this.dgvCate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCate.Size = new System.Drawing.Size(957, 231);
            this.dgvCate.StandardTab = true;
            this.dgvCate.TabIndex = 34;
            this.dgvCate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCate_CellClick);
            this.dgvCate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCate_CellContentClick);
            // 
            // CATEGORY_ID
            // 
            this.CATEGORY_ID.DataPropertyName = "CATEGORY_ID";
            this.CATEGORY_ID.HeaderText = "รหัส";
            this.CATEGORY_ID.MinimumWidth = 6;
            this.CATEGORY_ID.Name = "CATEGORY_ID";
            this.CATEGORY_ID.ReadOnly = true;
            this.CATEGORY_ID.Width = 90;
            // 
            // CATEGORY_NAME
            // 
            this.CATEGORY_NAME.DataPropertyName = "CATEGORY_NAME";
            this.CATEGORY_NAME.HeaderText = "ชื่อ";
            this.CATEGORY_NAME.MinimumWidth = 6;
            this.CATEGORY_NAME.Name = "CATEGORY_NAME";
            this.CATEGORY_NAME.ReadOnly = true;
            this.CATEGORY_NAME.Width = 230;
            // 
            // CATE_CODE
            // 
            this.CATE_CODE.DataPropertyName = "CATE_CODE";
            this.CATE_CODE.HeaderText = "CATE_CODE";
            this.CATE_CODE.MinimumWidth = 6;
            this.CATE_CODE.Name = "CATE_CODE";
            this.CATE_CODE.ReadOnly = true;
            this.CATE_CODE.Width = 125;
            // 
            // REMARK
            // 
            this.REMARK.DataPropertyName = "REMARK";
            this.REMARK.HeaderText = "หมายเหตุ";
            this.REMARK.MinimumWidth = 6;
            this.REMARK.Name = "REMARK";
            this.REMARK.ReadOnly = true;
            this.REMARK.Width = 125;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::POS.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(250, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 66);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::POS.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(87, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 66);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "บันทึก";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(87, 205);
            this.txtRemark.MaxLength = 500;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(302, 128);
            this.txtRemark.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "หมายเหตุ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 22);
            this.txtName.TabIndex = 25;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 115);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 17);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "ชื่อหมวดหมู่";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(87, 76);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(302, 22);
            this.txtCode.TabIndex = 21;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 76);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(31, 17);
            this.lblCode.TabIndex = 20;
            this.lblCode.Text = "รหัส";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "หมวดหมู่สินค้า";
            // 
            // txtCateCode
            // 
            this.txtCateCode.Location = new System.Drawing.Point(87, 163);
            this.txtCateCode.Name = "txtCateCode";
            this.txtCateCode.Size = new System.Drawing.Size(302, 22);
            this.txtCateCode.TabIndex = 40;
            // 
            // lblCateCode
            // 
            this.lblCateCode.AutoSize = true;
            this.lblCateCode.Location = new System.Drawing.Point(6, 163);
            this.lblCateCode.Name = "lblCateCode";
            this.lblCateCode.Size = new System.Drawing.Size(70, 17);
            this.lblCateCode.TabIndex = 39;
            this.lblCateCode.Text = "CateCode";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(742, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 35);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(459, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(254, 22);
            this.txtSearch.TabIndex = 42;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1601, 865);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCateCode);
            this.Controls.Add(this.lblCateCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvCate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategory";
            this.Text = "Product Service System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnNext;
        protected System.Windows.Forms.DataGridView dgvCate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCateCode;
        private System.Windows.Forms.Label lblCateCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATE_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMARK;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}