
namespace POS.Forms
{
    partial class frmLoading
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
            this.components = new System.ComponentModel.Container();
            this.progressbar = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressbar
            // 
            this.progressbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressbar.AnimationSpeed = 500;
            this.progressbar.BackColor = System.Drawing.Color.Black;
            this.progressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressbar.InnerColor = System.Drawing.Color.Black;
            this.progressbar.InnerMargin = 2;
            this.progressbar.InnerWidth = -1;
            this.progressbar.Location = new System.Drawing.Point(272, 106);
            this.progressbar.MarqueeAnimationSpeed = 2000;
            this.progressbar.Name = "progressbar";
            this.progressbar.OuterColor = System.Drawing.Color.Gray;
            this.progressbar.OuterMargin = -25;
            this.progressbar.OuterWidth = 26;
            this.progressbar.ProgressColor = System.Drawing.Color.Red;
            this.progressbar.ProgressWidth = 6;
            this.progressbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressbar.Size = new System.Drawing.Size(206, 200);
            this.progressbar.StartAngle = 270;
            this.progressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressbar.SubscriptText = "";
            this.progressbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressbar.SuperscriptText = "";
            this.progressbar.TabIndex = 0;
            this.progressbar.Text = "Loading";
            this.progressbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressbar.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(289, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Service System";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressbar);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "frmLoading";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoading";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar progressbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}