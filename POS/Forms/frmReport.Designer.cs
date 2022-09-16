
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
            this.btnOK = new System.Windows.Forms.Button();
            this.rptDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.tbSellSearch = new System.Windows.Forms.TabPage();
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
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "รายงาน";
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tbSellSearch);
            this.tabcontrol1.Controls.Add(this.tbDaily);
            this.tabcontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabcontrol1.Location = new System.Drawing.Point(13, 67);
            this.tabcontrol1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(901, 161);
            this.tabcontrol1.TabIndex = 23;
            // 
            // tbDaily
            // 
            this.tbDaily.Controls.Add(this.btnOK);
            this.tbDaily.Controls.Add(this.rptDate);
            this.tbDaily.Location = new System.Drawing.Point(4, 26);
            this.tbDaily.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDaily.Name = "tbDaily";
            this.tbDaily.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDaily.Size = new System.Drawing.Size(893, 131);
            this.tbDaily.TabIndex = 0;
            this.tbDaily.Text = "ประจำวัน";
            this.tbDaily.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::POS.Properties.Resources.print1;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOK.Location = new System.Drawing.Point(294, 18);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 66);
            this.btnOK.TabIndex = 46;
            this.btnOK.Text = "ตกลง";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rptDate
            // 
            this.rptDate.Location = new System.Drawing.Point(15, 18);
            this.rptDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rptDate.Name = "rptDate";
            this.rptDate.Size = new System.Drawing.Size(205, 23);
            this.rptDate.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSum);
            this.groupBox1.Controls.Add(this.dgvReport);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(16, 248);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1004, 261);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายการ";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSum.Location = new System.Drawing.Point(830, 242);
            this.lblSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(52, 18);
            this.lblSum.TabIndex = 25;
            this.lblSum.Text = "label1";
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(15, 21);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(973, 205);
            this.dgvReport.TabIndex = 0;
            // 
            // tbSellSearch
            // 
            this.tbSellSearch.Location = new System.Drawing.Point(4, 26);
            this.tbSellSearch.Name = "tbSellSearch";
            this.tbSellSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbSellSearch.Size = new System.Drawing.Size(893, 131);
            this.tbSellSearch.TabIndex = 1;
            this.tbSellSearch.Text = "ค้นหารายการขาย";
            this.tbSellSearch.UseVisualStyleBackColor = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabcontrol1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TabPage tbSellSearch;
    }
}