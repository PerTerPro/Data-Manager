namespace QT.Moduls.CrawlerProduct
{
    partial class FrmCrawlerTest
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
            this.job_SPGocNhapLieuLogTableAdapter1 = new QT.Users.DBPhanSPTableAdapters.Job_SPGocNhapLieuLogTableAdapter();
            this.SuspendLayout();
            // 
            // job_SPGocNhapLieuLogTableAdapter1
            // 
            this.job_SPGocNhapLieuLogTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmCrawlerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 620);
            this.Name = "FrmCrawlerTest";
            this.Text = "FrmCrawlerTest";
            this.ResumeLayout(false);

        }

        #endregion

        private Users.DBPhanSPTableAdapters.Job_SPGocNhapLieuLogTableAdapter job_SPGocNhapLieuLogTableAdapter1;
    }
}