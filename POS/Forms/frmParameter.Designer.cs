
namespace POS.Forms
{
    partial class frmParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParameter));
            this.lblMajorCode = new System.Windows.Forms.Label();
            this.txtMajorCode = new System.Windows.Forms.TextBox();
            this.txtMinorCode = new System.Windows.Forms.TextBox();
            this.lblMinorCode = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCon1 = new System.Windows.Forms.TextBox();
            this.lblCondition1 = new System.Windows.Forms.Label();
            this.txtCon2 = new System.Windows.Forms.TextBox();
            this.lblCondition2 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvParameter = new System.Windows.Forms.DataGridView();
            this.PARAMETER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAJOR_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MINOR_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONDITION1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONDITION2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMajorCode
            // 
            this.lblMajorCode.AutoSize = true;
            this.lblMajorCode.Location = new System.Drawing.Point(13, 24);
            this.lblMajorCode.Name = "lblMajorCode";
            this.lblMajorCode.Size = new System.Drawing.Size(55, 17);
            this.lblMajorCode.TabIndex = 0;
            this.lblMajorCode.Text = "รหัสหลัก";
            // 
            // txtMajorCode
            // 
            this.txtMajorCode.Location = new System.Drawing.Point(94, 24);
            this.txtMajorCode.Name = "txtMajorCode";
            this.txtMajorCode.Size = new System.Drawing.Size(197, 22);
            this.txtMajorCode.TabIndex = 1;
            // 
            // txtMinorCode
            // 
            this.txtMinorCode.Location = new System.Drawing.Point(94, 61);
            this.txtMinorCode.Name = "txtMinorCode";
            this.txtMinorCode.Size = new System.Drawing.Size(197, 22);
            this.txtMinorCode.TabIndex = 3;
            // 
            // lblMinorCode
            // 
            this.lblMinorCode.AutoSize = true;
            this.lblMinorCode.Location = new System.Drawing.Point(13, 61);
            this.lblMinorCode.Name = "lblMinorCode";
            this.lblMinorCode.Size = new System.Drawing.Size(51, 17);
            this.lblMinorCode.TabIndex = 2;
            this.lblMinorCode.Text = "รหัสรอง";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 22);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(23, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "ชื่อ";
            // 
            // txtCon1
            // 
            this.txtCon1.Location = new System.Drawing.Point(94, 136);
            this.txtCon1.Name = "txtCon1";
            this.txtCon1.Size = new System.Drawing.Size(197, 22);
            this.txtCon1.TabIndex = 7;
            // 
            // lblCondition1
            // 
            this.lblCondition1.AutoSize = true;
            this.lblCondition1.Location = new System.Drawing.Point(13, 136);
            this.lblCondition1.Name = "lblCondition1";
            this.lblCondition1.Size = new System.Drawing.Size(75, 17);
            this.lblCondition1.TabIndex = 6;
            this.lblCondition1.Text = "Condition1";
            // 
            // txtCon2
            // 
            this.txtCon2.Location = new System.Drawing.Point(94, 175);
            this.txtCon2.Name = "txtCon2";
            this.txtCon2.Size = new System.Drawing.Size(197, 22);
            this.txtCon2.TabIndex = 9;
            // 
            // lblCondition2
            // 
            this.lblCondition2.AutoSize = true;
            this.lblCondition2.Location = new System.Drawing.Point(13, 175);
            this.lblCondition2.Name = "lblCondition2";
            this.lblCondition2.Size = new System.Drawing.Size(75, 17);
            this.lblCondition2.TabIndex = 8;
            this.lblCondition2.Text = "Condition2";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(94, 211);
            this.txtRemark.MaxLength = 500;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(302, 128);
            this.txtRemark.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "หมายเหตุ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(94, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 66);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 66);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvParameter
            // 
            this.dgvParameter.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParameter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARAMETER_ID,
            this.MAJOR_CODE,
            this.MINOR_CODE,
            this.NAME,
            this.CONDITION1,
            this.CONDITION2});
            this.dgvParameter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvParameter.Location = new System.Drawing.Point(94, 527);
            this.dgvParameter.Name = "dgvParameter";
            this.dgvParameter.ReadOnly = true;
            this.dgvParameter.RowHeadersWidth = 51;
            this.dgvParameter.RowTemplate.Height = 24;
            this.dgvParameter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParameter.Size = new System.Drawing.Size(908, 182);
            this.dgvParameter.StandardTab = true;
            this.dgvParameter.TabIndex = 14;
            // 
            // PARAMETER_ID
            // 
            this.PARAMETER_ID.DataPropertyName = "PARAMETER_ID";
            this.PARAMETER_ID.HeaderText = "PARAMETER_ID";
            this.PARAMETER_ID.MinimumWidth = 6;
            this.PARAMETER_ID.Name = "PARAMETER_ID";
            this.PARAMETER_ID.ReadOnly = true;
            this.PARAMETER_ID.Width = 125;
            // 
            // MAJOR_CODE
            // 
            this.MAJOR_CODE.DataPropertyName = "MAJOR_CODE";
            this.MAJOR_CODE.HeaderText = "MAJOR_CODE";
            this.MAJOR_CODE.MinimumWidth = 6;
            this.MAJOR_CODE.Name = "MAJOR_CODE";
            this.MAJOR_CODE.ReadOnly = true;
            this.MAJOR_CODE.Width = 125;
            // 
            // MINOR_CODE
            // 
            this.MINOR_CODE.DataPropertyName = "MINOR_CODE";
            this.MINOR_CODE.HeaderText = "MINOR_CODE";
            this.MINOR_CODE.MinimumWidth = 6;
            this.MINOR_CODE.Name = "MINOR_CODE";
            this.MINOR_CODE.ReadOnly = true;
            this.MINOR_CODE.Width = 125;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "NAME";
            this.NAME.MinimumWidth = 6;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 230;
            // 
            // CONDITION1
            // 
            this.CONDITION1.DataPropertyName = "CONDITION1";
            this.CONDITION1.HeaderText = "CONDITION1";
            this.CONDITION1.MinimumWidth = 6;
            this.CONDITION1.Name = "CONDITION1";
            this.CONDITION1.ReadOnly = true;
            this.CONDITION1.Width = 125;
            // 
            // CONDITION2
            // 
            this.CONDITION2.DataPropertyName = "CONDITION2";
            this.CONDITION2.HeaderText = "CONDITION2";
            this.CONDITION2.MinimumWidth = 6;
            this.CONDITION2.Name = "CONDITION2";
            this.CONDITION2.ReadOnly = true;
            this.CONDITION2.Width = 125;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(927, 719);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(853, 722);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(40, 17);
            this.lblPage.TabIndex = 18;
            this.lblPage.Text = "????";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(766, 719);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 19;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // frmParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1056, 791);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvParameter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCon2);
            this.Controls.Add(this.lblCondition2);
            this.Controls.Add(this.txtCon1);
            this.Controls.Add(this.lblCondition1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtMinorCode);
            this.Controls.Add(this.lblMinorCode);
            this.Controls.Add(this.txtMajorCode);
            this.Controls.Add(this.lblMajorCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmParameter";
            this.Text = "Product Service System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMajorCode;
        private System.Windows.Forms.TextBox txtMajorCode;
        private System.Windows.Forms.TextBox txtMinorCode;
        private System.Windows.Forms.Label lblMinorCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCon1;
        private System.Windows.Forms.Label lblCondition1;
        private System.Windows.Forms.TextBox txtCon2;
        private System.Windows.Forms.Label lblCondition2;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARAMETER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAJOR_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MINOR_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONDITION1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONDITION2;
        protected System.Windows.Forms.DataGridView dgvParameter;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnFirst;
    }
}