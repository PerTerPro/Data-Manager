namespace QT.Moduls.CrawlerProduct
{
    partial class FrmResetCompanyCacheCrawler
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPushReloadCacheCheckDuplicateAllCompany = new DevExpress.XtraEditors.SimpleButton();
            this.btnPushReloadCacheProductInfoAllCompany = new DevExpress.XtraEditors.SimpleButton();
            this.btnResetCompanyCacheCrawler = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.report = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnPushReloadCacheCheckDuplicateAllCompany);
            this.panelControl1.Controls.Add(this.btnPushReloadCacheProductInfoAllCompany);
            this.panelControl1.Controls.Add(this.btnResetCompanyCacheCrawler);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 391);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(878, 97);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(299, 37);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(280, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "ResetAllCompany-Product";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnPushReloadCacheCheckDuplicateAllCompany
            // 
            this.btnPushReloadCacheCheckDuplicateAllCompany.Location = new System.Drawing.Point(5, 64);
            this.btnPushReloadCacheCheckDuplicateAllCompany.Name = "btnPushReloadCacheCheckDuplicateAllCompany";
            this.btnPushReloadCacheCheckDuplicateAllCompany.Size = new System.Drawing.Size(280, 23);
            this.btnPushReloadCacheCheckDuplicateAllCompany.TabIndex = 2;
            this.btnPushReloadCacheCheckDuplicateAllCompany.Text = "Push Reload Cache CheckDuplicate All Company";
            this.btnPushReloadCacheCheckDuplicateAllCompany.Click += new System.EventHandler(this.btnPushReloadCacheCheckDuplicateAllCompany_Click);
            // 
            // btnPushReloadCacheProductInfoAllCompany
            // 
            this.btnPushReloadCacheProductInfoAllCompany.Location = new System.Drawing.Point(5, 35);
            this.btnPushReloadCacheProductInfoAllCompany.Name = "btnPushReloadCacheProductInfoAllCompany";
            this.btnPushReloadCacheProductInfoAllCompany.Size = new System.Drawing.Size(280, 23);
            this.btnPushReloadCacheProductInfoAllCompany.TabIndex = 1;
            this.btnPushReloadCacheProductInfoAllCompany.Text = "Push Reload Cache Product Info All Company";
            this.btnPushReloadCacheProductInfoAllCompany.Click += new System.EventHandler(this.btnPushReloadCacheProductInfoAllCompany_Click);
            // 
            // btnResetCompanyCacheCrawler
            // 
            this.btnResetCompanyCacheCrawler.Location = new System.Drawing.Point(5, 6);
            this.btnResetCompanyCacheCrawler.Name = "btnResetCompanyCacheCrawler";
            this.btnResetCompanyCacheCrawler.Size = new System.Drawing.Size(280, 23);
            this.btnResetCompanyCacheCrawler.TabIndex = 0;
            this.btnResetCompanyCacheCrawler.Text = "ResetCompanyCacheCrawler";
            this.btnResetCompanyCacheCrawler.Click += new System.EventHandler(this.btnResetCompanyCacheCrawler_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.report);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(878, 391);
            this.panelControl2.TabIndex = 1;
            // 
            // report
            // 
            this.report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report.Location = new System.Drawing.Point(2, 2);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(874, 387);
            this.report.TabIndex = 0;
            this.report.Text = "";
            // 
            // FrmResetCompanyCacheCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 488);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmResetCompanyCacheCrawler";
            this.Text = "FrmResetCompanyCacheCrawler";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnResetCompanyCacheCrawler;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.RichTextBox report;
        private DevExpress.XtraEditors.SimpleButton btnPushReloadCacheProductInfoAllCompany;
        private DevExpress.XtraEditors.SimpleButton btnPushReloadCacheCheckDuplicateAllCompany;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}