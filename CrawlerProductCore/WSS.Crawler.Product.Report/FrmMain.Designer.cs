namespace  WSS.Crawler.Product.Report
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnHistoryCrawler = new System.Windows.Forms.ToolStripButton();
            this.btnShortRunning = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.cacheProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacheDuplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacheCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacheWaitCrawlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.exportTrackFieldCrawlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHistoryCrawler,
            this.btnShortRunning,
            this.toolStripButton2,
            this.toolStripButton7,
            this.toolStripButton1,
            this.toolStripDropDownButton1,
            this.toolStripButton3,
            this.toolStripDropDownButton2,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1276, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnHistoryCrawler
            // 
            this.btnHistoryCrawler.Image = ((System.Drawing.Image)(resources.GetObject("btnHistoryCrawler.Image")));
            this.btnHistoryCrawler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHistoryCrawler.Name = "btnHistoryCrawler";
            this.btnHistoryCrawler.Size = new System.Drawing.Size(108, 22);
            this.btnHistoryCrawler.Text = "&HistoryCrawler ";
            this.btnHistoryCrawler.Click += new System.EventHandler(this.btnHistoryCrawler_Click);
            // 
            // btnShortRunning
            // 
            this.btnShortRunning.Image = ((System.Drawing.Image)(resources.GetObject("btnShortRunning.Image")));
            this.btnShortRunning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShortRunning.Name = "btnShortRunning";
            this.btnShortRunning.Size = new System.Drawing.Size(101, 22);
            this.btnShortRunning.Text = "Show&Running";
            this.btnShortRunning.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(108, 22);
            this.toolStripButton2.Text = "&WaitingCrawler";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton7.Text = "&Company";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton1.Text = "PushToMQ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cacheProductToolStripMenuItem,
            this.cacheDuplicateToolStripMenuItem,
            this.cacheCompanyToolStripMenuItem,
            this.cacheWaitCrawlerToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(116, 22);
            this.toolStripDropDownButton1.Text = "ManagerCache";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // cacheProductToolStripMenuItem
            // 
            this.cacheProductToolStripMenuItem.Name = "cacheProductToolStripMenuItem";
            this.cacheProductToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cacheProductToolStripMenuItem.Text = "CacheProduct";
            // 
            // cacheDuplicateToolStripMenuItem
            // 
            this.cacheDuplicateToolStripMenuItem.Name = "cacheDuplicateToolStripMenuItem";
            this.cacheDuplicateToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cacheDuplicateToolStripMenuItem.Text = "CacheDuplicate";
            // 
            // cacheCompanyToolStripMenuItem
            // 
            this.cacheCompanyToolStripMenuItem.Name = "cacheCompanyToolStripMenuItem";
            this.cacheCompanyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cacheCompanyToolStripMenuItem.Text = "CacheCompany";
            this.cacheCompanyToolStripMenuItem.Click += new System.EventHandler(this.cacheCompanyToolStripMenuItem_Click);
            // 
            // cacheWaitCrawlerToolStripMenuItem
            // 
            this.cacheWaitCrawlerToolStripMenuItem.Name = "cacheWaitCrawlerToolStripMenuItem";
            this.cacheWaitCrawlerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cacheWaitCrawlerToolStripMenuItem.Text = "CacheWaitCrawler";
            this.cacheWaitCrawlerToolStripMenuItem.Click += new System.EventHandler(this.cacheWaitCrawlerToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(81, 22);
            this.toolStripButton3.Text = "FailConfig";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_2);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportTrackFieldCrawlerToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click_1);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // exportTrackFieldCrawlerToolStripMenuItem
            // 
            this.exportTrackFieldCrawlerToolStripMenuItem.Name = "exportTrackFieldCrawlerToolStripMenuItem";
            this.exportTrackFieldCrawlerToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exportTrackFieldCrawlerToolStripMenuItem.Text = "ExportTrackFieldCrawler";
            this.exportTrackFieldCrawlerToolStripMenuItem.Click += new System.EventHandler(this.exportTrackViewToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 741);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống theo dõi Crawler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTrack_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmTrack_MouseDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHistoryCrawler;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem cacheProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacheDuplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacheCompanyToolStripMenuItem;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.ToolStripMenuItem cacheWaitCrawlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton btnShortRunning;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem exportTrackFieldCrawlerToolStripMenuItem;
    }
}