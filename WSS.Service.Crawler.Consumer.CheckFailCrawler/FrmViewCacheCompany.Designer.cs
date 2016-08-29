namespace WSS.Crawler.Product.Report
{
    partial class FrmViewCacheCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewCacheCompany));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnManager = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdateRedisCrawler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRunning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastJobCrawler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckInQueue_FindNew = new System.Windows.Forms.CheckBox();
            this.ckInQueue_Reload = new System.Windows.Forms.CheckBox();
            this.ckRunning = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnHistoryCrawler = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshCacheProductInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCacheDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewProductInCache = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewProductInDb = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSycCacheCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveHashChange = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompanyPlus1 = new WSS.Crawler.Product.Report.MenuCompanyPlus();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1354, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripButton1.Text = "Refresh";
            this.toolStripButton1.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnManager
            // 
            this.btnManager.Image = ((System.Drawing.Image)(resources.GetObject("btnManager.Image")));
            this.btnManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(74, 22);
            this.btnManager.Text = "Manager";
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1354, 689);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn12,
            this.gridColumn1,
            this.colLastUpdateRedisCrawler,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn7,
            this.gridColumn10,
            this.gridColumn9,
            this.colRunning,
            this.colLastJobCrawler});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "LastUpdateCache";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colLastUpdateRedisCrawler
            // 
            this.colLastUpdateRedisCrawler.Caption = "LastUpdateRedisCrawler";
            this.colLastUpdateRedisCrawler.FieldName = "LastUpdateRedisCrawler";
            this.colLastUpdateRedisCrawler.Name = "colLastUpdateRedisCrawler";
            this.colLastUpdateRedisCrawler.Visible = true;
            this.colLastUpdateRedisCrawler.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Domain";
            this.gridColumn2.FieldName = "Domain";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "MinHourReload";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "MinHourFindNew";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "InQueue_FindNew";
            this.gridColumn5.FieldName = "InQueue_FindNew";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "InQueue_Reload";
            this.gridColumn6.FieldName = "InQueue_Reload";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Time_NextReload";
            this.gridColumn8.FieldName = "Time_NextReload";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Time_NextFindNew";
            this.gridColumn7.FieldName = "Time_NextFindNew";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 9;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Time_LastFindNew";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Time_LastReload";
            this.gridColumn9.DisplayFormat.FormatString = "d";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 11;
            // 
            // colRunning
            // 
            this.colRunning.Caption = "Running";
            this.colRunning.FieldName = "Running";
            this.colRunning.Name = "colRunning";
            this.colRunning.Visible = true;
            this.colRunning.VisibleIndex = 12;
            // 
            // colLastJobCrawler
            // 
            this.colLastJobCrawler.Caption = "LastJobCrawler";
            this.colLastJobCrawler.FieldName = "LastJobCrawler";
            this.colLastJobCrawler.Name = "colLastJobCrawler";
            this.colLastJobCrawler.Visible = true;
            this.colLastJobCrawler.VisibleIndex = 13;
            // 
            // ckInQueue_FindNew
            // 
            this.ckInQueue_FindNew.AutoSize = true;
            this.ckInQueue_FindNew.Location = new System.Drawing.Point(296, 6);
            this.ckInQueue_FindNew.Name = "ckInQueue_FindNew";
            this.ckInQueue_FindNew.Size = new System.Drawing.Size(115, 17);
            this.ckInQueue_FindNew.TabIndex = 2;
            this.ckInQueue_FindNew.Text = "InQueue_FindNew";
            this.ckInQueue_FindNew.UseVisualStyleBackColor = true;
            this.ckInQueue_FindNew.CheckedChanged += new System.EventHandler(this.ckInQueue_FindNew_CheckedChanged);
            // 
            // ckInQueue_Reload
            // 
            this.ckInQueue_Reload.AutoSize = true;
            this.ckInQueue_Reload.Location = new System.Drawing.Point(417, 6);
            this.ckInQueue_Reload.Name = "ckInQueue_Reload";
            this.ckInQueue_Reload.Size = new System.Drawing.Size(107, 17);
            this.ckInQueue_Reload.TabIndex = 3;
            this.ckInQueue_Reload.Text = "InQueue_Reload";
            this.ckInQueue_Reload.UseVisualStyleBackColor = true;
            this.ckInQueue_Reload.CheckedChanged += new System.EventHandler(this.ckInQueue_Reload_CheckedChanged);
            // 
            // ckRunning
            // 
            this.ckRunning.AutoSize = true;
            this.ckRunning.Location = new System.Drawing.Point(530, 6);
            this.ckRunning.Name = "ckRunning";
            this.ckRunning.Size = new System.Drawing.Size(66, 17);
            this.ckRunning.TabIndex = 6;
            this.ckRunning.Text = "Running";
            this.ckRunning.UseVisualStyleBackColor = true;
            this.ckRunning.CheckedChanged += new System.EventHandler(this.ckRunning_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHistoryCrawler,
            this.toolStripMenuItem2,
            this.btnRefreshCacheProductInfo,
            this.btnCacheDuplicate,
            this.toolStripMenuItem5,
            this.btnViewProductInCache,
            this.btnViewProductInDb,
            this.btnSycCacheCompany,
            this.btnRemoveHashChange});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(224, 202);
            // 
            // btnHistoryCrawler
            // 
            this.btnHistoryCrawler.Name = "btnHistoryCrawler";
            this.btnHistoryCrawler.Size = new System.Drawing.Size(223, 22);
            this.btnHistoryCrawler.Text = "HistoryCrawler";
            this.btnHistoryCrawler.Click += new System.EventHandler(this.btnHistoryCrawler_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem2.Text = "Push->RefeshCacheProduct";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // btnRefreshCacheProductInfo
            // 
            this.btnRefreshCacheProductInfo.Name = "btnRefreshCacheProductInfo";
            this.btnRefreshCacheProductInfo.Size = new System.Drawing.Size(223, 22);
            this.btnRefreshCacheProductInfo.Text = "RefreshCacheProductInfo";
            this.btnRefreshCacheProductInfo.Click += new System.EventHandler(this.btnRefreshCacheProductInfo_Click);
            // 
            // btnCacheDuplicate
            // 
            this.btnCacheDuplicate.Name = "btnCacheDuplicate";
            this.btnCacheDuplicate.Size = new System.Drawing.Size(223, 22);
            this.btnCacheDuplicate.Text = "RefreshCacheDuplicate";
            this.btnCacheDuplicate.Click += new System.EventHandler(this.btnCacheDuplicate_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
            // 
            // btnViewProductInCache
            // 
            this.btnViewProductInCache.Name = "btnViewProductInCache";
            this.btnViewProductInCache.Size = new System.Drawing.Size(223, 22);
            this.btnViewProductInCache.Text = "ViewProduct-InCache";
            this.btnViewProductInCache.Click += new System.EventHandler(this.btnViewProductInCache_Click);
            // 
            // btnViewProductInDb
            // 
            this.btnViewProductInDb.Name = "btnViewProductInDb";
            this.btnViewProductInDb.Size = new System.Drawing.Size(223, 22);
            this.btnViewProductInDb.Text = "ViewProduct-InDb";
            this.btnViewProductInDb.Click += new System.EventHandler(this.btnViewProductInDb_Click);
            // 
            // btnSycCacheCompany
            // 
            this.btnSycCacheCompany.Name = "btnSycCacheCompany";
            this.btnSycCacheCompany.Size = new System.Drawing.Size(223, 22);
            this.btnSycCacheCompany.Text = "SycCacheCompany";
            this.btnSycCacheCompany.Click += new System.EventHandler(this.btnSycCacheCompany_Click);
            // 
            // btnRemoveHashChange
            // 
            this.btnRemoveHashChange.Name = "btnRemoveHashChange";
            this.btnRemoveHashChange.Size = new System.Drawing.Size(223, 22);
            this.btnRemoveHashChange.Text = "RemoveHashChange";
            this.btnRemoveHashChange.Click += new System.EventHandler(this.btnRemoveHashChange_Click);
            // 
            // menuCompanyPlus1
            // 
            this.menuCompanyPlus1.Name = "menuCompanyPlus1";
            this.menuCompanyPlus1.Size = new System.Drawing.Size(153, 26);
            // 
            // FrmViewCacheCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 714);
            this.Controls.Add(this.ckRunning);
            this.Controls.Add(this.ckInQueue_Reload);
            this.Controls.Add(this.ckInQueue_FindNew);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmViewCacheCompany";
            this.Text = "FrmViewCacheCompany";
            this.Load += new System.EventHandler(this.FrmViewCacheCompany_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmViewCacheCompany_MouseDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn colRunning;
        private System.Windows.Forms.CheckBox ckInQueue_FindNew;
        private System.Windows.Forms.CheckBox ckInQueue_Reload;
        private System.Windows.Forms.CheckBox ckRunning;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdateRedisCrawler;
        private DevExpress.XtraGrid.Columns.GridColumn colLastJobCrawler;
        private System.Windows.Forms.ToolStripButton btnManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnHistoryCrawler;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnRefreshCacheProductInfo;
        private System.Windows.Forms.ToolStripMenuItem btnCacheDuplicate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem btnViewProductInCache;
        private System.Windows.Forms.ToolStripMenuItem btnViewProductInDb;
        private System.Windows.Forms.ToolStripMenuItem btnSycCacheCompany;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveHashChange;
        private MenuCompanyPlus menuCompanyPlus1;
    }
}