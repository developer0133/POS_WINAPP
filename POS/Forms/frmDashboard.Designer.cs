namespace POS.Forms
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.productchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLast30 = new System.Windows.Forms.Button();
            this.btnLast7 = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productchart)).BeginInit();
            this.grp2.SuspendLayout();
            this.grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productchart
            // 
            chartArea1.Name = "ChartArea1";
            this.productchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.productchart.Legends.Add(legend1);
            this.productchart.Location = new System.Drawing.Point(936, 218);
            this.productchart.Name = "productchart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.productchart.Series.Add(series1);
            this.productchart.Size = new System.Drawing.Size(385, 387);
            this.productchart.TabIndex = 0;
            this.productchart.Text = "productchart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Top 5 Products";
            this.productchart.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dashboard";
            // 
            // grp2
            // 
            this.grp2.BackColor = System.Drawing.SystemColors.Window;
            this.grp2.Controls.Add(this.pictureBox2);
            this.grp2.Controls.Add(this.lblProfit);
            this.grp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.grp2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.grp2.Location = new System.Drawing.Point(391, 232);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(313, 111);
            this.grp2.TabIndex = 7;
            this.grp2.TabStop = false;
            this.grp2.Text = "กำไร";
            // 
            // grp1
            // 
            this.grp1.BackColor = System.Drawing.SystemColors.Window;
            this.grp1.Controls.Add(this.pictureBox1);
            this.grp1.Controls.Add(this.lblIncome);
            this.grp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.grp1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.grp1.Location = new System.Drawing.Point(42, 232);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(302, 111);
            this.grp1.TabIndex = 6;
            this.grp1.TabStop = false;
            this.grp1.Text = "รายได้";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblIncome.Location = new System.Drawing.Point(179, 53);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(70, 25);
            this.lblIncome.TabIndex = 0;
            this.lblIncome.Text = "label2";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblProfit.Location = new System.Drawing.Point(169, 53);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(70, 25);
            this.lblProfit.TabIndex = 0;
            this.lblProfit.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::POS.Properties.Resources.icons8_profit_642;
            this.pictureBox2.Location = new System.Drawing.Point(8, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 79);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::POS.Properties.Resources.icons8_revenue_641;
            this.pictureBox1.Location = new System.Drawing.Point(6, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 79);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLast30
            // 
            this.btnLast30.Image = global::POS.Properties.Resources.icons8_30_161;
            this.btnLast30.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLast30.Location = new System.Drawing.Point(671, 108);
            this.btnLast30.Name = "btnLast30";
            this.btnLast30.Size = new System.Drawing.Size(180, 79);
            this.btnLast30.TabIndex = 4;
            this.btnLast30.Text = "30 วันล่าสุด";
            this.btnLast30.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLast30.UseVisualStyleBackColor = true;
            // 
            // btnLast7
            // 
            this.btnLast7.Image = global::POS.Properties.Resources.icons8_calendar_7_48;
            this.btnLast7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLast7.Location = new System.Drawing.Point(463, 108);
            this.btnLast7.Name = "btnLast7";
            this.btnLast7.Size = new System.Drawing.Size(180, 79);
            this.btnLast7.TabIndex = 3;
            this.btnLast7.Text = "7 วันล่าสุด";
            this.btnLast7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLast7.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            this.btnToday.Image = global::POS.Properties.Resources.icons8_today_40;
            this.btnToday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToday.Location = new System.Drawing.Point(250, 108);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(180, 79);
            this.btnToday.TabIndex = 2;
            this.btnToday.Text = "วันนี้";
            this.btnToday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnToday.UseVisualStyleBackColor = true;
            // 
            // btnYesterday
            // 
            this.btnYesterday.Image = global::POS.Properties.Resources.icons8_history_48;
            this.btnYesterday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYesterday.Location = new System.Drawing.Point(42, 108);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(180, 79);
            this.btnYesterday.TabIndex = 1;
            this.btnYesterday.Text = "เมื่อวาน";
            this.btnYesterday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYesterday.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 826);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLast30);
            this.Controls.Add(this.btnLast7);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnYesterday);
            this.Controls.Add(this.productchart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.productchart)).EndInit();
            this.grp2.ResumeLayout(false);
            this.grp2.PerformLayout();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart productchart;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7;
        private System.Windows.Forms.Button btnLast30;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}