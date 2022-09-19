
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
            this.tbSellSearch = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSellNo = new System.Windows.Forms.TextBox();
            this.tbDaily = new System.Windows.Forms.TabPage();
            this.btnOK = new System.Windows.Forms.Button();
            this.rptDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabcontrol1.SuspendLayout();
            this.tbSellSearch.SuspendLayout();
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
            this.tabcontrol1.Controls.Add(this.tbSellSearch);
            this.tabcontrol1.Controls.Add(this.tbDaily);
            this.tabcontrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabcontrol1.Location = new System.Drawing.Point(17, 82);
            this.tabcontrol1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(1201, 198);
            this.tabcontrol1.TabIndex = 23;
            // 
            // tbSellSearch
            // 
            this.tbSellSearch.Controls.Add(this.btnSearch);
            this.tbSellSearch.Controls.Add(this.label1);
            this.tbSellSearch.Controls.Add(this.txtSellNo);
            this.tbSellSearch.Location = new System.Drawing.Point(4, 29);
            this.tbSellSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSellSearch.Name = "tbSellSearch";
            this.tbSellSearch.Padding = new System.Windows.Forms.Padding(4);
            this.tbSellSearch.Size = new System.Drawing.Size(1193, 165);
            this.tbSellSearch.TabIndex = 1;
            this.tbSellSearch.Text = "ค้นหารายการขาย";
            this.tbSellSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::POS.Properties.Resources.search2;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(439, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 89);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "เลขที่การขาย";
            // 
            // txtSellNo
            // 
            this.txtSellNo.Location = new System.Drawing.Point(153, 27);
            this.txtSellNo.MaxLength = 15;
            this.txtSellNo.Name = "txtSellNo";
            this.txtSellNo.Size = new System.Drawing.Size(221, 27);
            this.txtSellNo.TabIndex = 0;
            // 
            // tbDaily
            // 
            this.tbDaily.Controls.Add(this.btnOK);
            this.tbDaily.Controls.Add(this.rptDate);
            this.tbDaily.Location = new System.Drawing.Point(4, 29);
            this.tbDaily.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDaily.Name = "tbDaily";
            this.tbDaily.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDaily.Size = new System.Drawing.Size(1193, 165);
            this.tbDaily.TabIndex = 0;
            this.tbDaily.Text = "ประจำวัน";
            this.tbDaily.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::POS.Properties.Resources.search2;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOK.Location = new System.Drawing.Point(392, 22);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(155, 89);
            this.btnOK.TabIndex = 46;
            this.btnOK.Text = "ค้นหา";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rptDate
            // 
            this.rptDate.Location = new System.Drawing.Point(20, 22);
            this.rptDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rptDate.Name = "rptDate";
            this.rptDate.Size = new System.Drawing.Size(272, 27);
            this.rptDate.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSum);
            this.groupBox1.Controls.Add(this.dgvReport);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(21, 305);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1339, 341);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายการ";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSum.Location = new System.Drawing.Point(1107, 298);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(66, 24);
            this.lblSum.TabIndex = 25;
            this.lblSum.Text = "label1";
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(20, 26);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1297, 252);
            this.dgvReport.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = global::POS.Properties.Resources.print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(1150, 665);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(155, 89);
            this.btnPrint.TabIndex = 47;
            this.btnPrint.Text = "พิมพ์";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 787);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabcontrol1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReport";
            this.Text = "Product Service System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabcontrol1.ResumeLayout(false);
            this.tbSellSearch.ResumeLayout(false);
            this.tbSellSearch.PerformLayout();
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSellNo;
    }
}