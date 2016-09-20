namespace WSS.Crawler.Product.Report
{
    partial class FrmTrackCrawlerAllCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrackCrawlerAllCompany));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckAll = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeCrawler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSession = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeRun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCrawler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberDuplicates = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuCompanyPlus1 = new WSS.Crawler.Product.Report.MenuCompanyPlus();
            this.btnLastCrawler = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckAll);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 30);
            this.panel1.TabIndex = 0;
            // 
            // ckAll
            // 
            this.ckAll.AutoSize = true;
            this.ckAll.Location = new System.Drawing.Point(249, 3);
            this.ckAll.Name = "ckAll";
            this.ckAll.Size = new System.Drawing.Size(37, 17);
            this.ckAll.TabIndex = 1;
            this.ckAll.Text = "All";
            this.ckAll.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnLastCrawler});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1364, 25);
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
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1364, 720);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCompanyID,
            this.colDomain,
            this.colTypeCrawler,
            this.colStartAt,
            this.colEndAt,
            this.colCountLink,
            this.gridColumn7,
            this.colCountProduct,
            this.colCountChange,
            this.colSession,
            this.colTotalProduct,
            this.colTimeRun,
            this.colDateCrawler,
            this.colIP,
            this.colTypeEnd,
            this.colNumberDuplicates});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 44;
            // 
            // colCompanyID
            // 
            this.colCompanyID.Caption = "CompanyID";
            this.colCompanyID.FieldName = "CompanyID";
            this.colCompanyID.Name = "colCompanyID";
            this.colCompanyID.Visible = true;
            this.colCompanyID.VisibleIndex = 0;
            this.colCompanyID.Width = 49;
            // 
            // colDomain
            // 
            this.colDomain.Caption = "Domain";
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 2;
            this.colDomain.Width = 77;
            // 
            // colTypeCrawler
            // 
            this.colTypeCrawler.Caption = "Type";
            this.colTypeCrawler.FieldName = "TypeCrawler";
            this.colTypeCrawler.Name = "colTypeCrawler";
            this.colTypeCrawler.Visible = true;
            this.colTypeCrawler.VisibleIndex = 1;
            this.colTypeCrawler.Width = 41;
            // 
            // colStartAt
            // 
            this.colStartAt.Caption = "StartAt";
            this.colStartAt.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.colStartAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartAt.FieldName = "StartAt";
            this.colStartAt.Name = "colStartAt";
            this.colStartAt.Visible = true;
            this.colStartAt.VisibleIndex = 3;
            this.colStartAt.Width = 70;
            // 
            // colEndAt
            // 
            this.colEndAt.Caption = "EndAt";
            this.colEndAt.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.colEndAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndAt.FieldName = "EndAt";
            this.colEndAt.Name = "colEndAt";
            this.colEndAt.Visible = true;
            this.colEndAt.VisibleIndex = 4;
            this.colEndAt.Width = 68;
            // 
            // colCountLink
            // 
            this.colCountLink.Caption = "CountLink";
            this.colCountLink.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCountLink.FieldName = "CountLink";
            this.colCountLink.Name = "colCountLink";
            this.colCountLink.Visible = true;
            this.colCountLink.VisibleIndex = 6;
            this.colCountLink.Width = 88;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "CountVisited";
            this.gridColumn7.FieldName = "CountVisited";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 88;
            // 
            // colCountProduct
            // 
            this.colCountProduct.Caption = "CountProduct";
            this.colCountProduct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCountProduct.FieldName = "CountProduct";
            this.colCountProduct.Name = "colCountProduct";
            this.colCountProduct.Visible = true;
            this.colCountProduct.VisibleIndex = 8;
            this.colCountProduct.Width = 88;
            // 
            // colCountChange
            // 
            this.colCountChange.Caption = "CountChange";
            this.colCountChange.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCountChange.FieldName = "CountChange";
            this.colCountChange.Name = "colCountChange";
            this.colCountChange.Visible = true;
            this.colCountChange.VisibleIndex = 9;
            this.colCountChange.Width = 88;
            // 
            // colSession
            // 
            this.colSession.Caption = "Session";
            this.colSession.FieldName = "Session";
            this.colSession.Name = "colSession";
            this.colSession.Visible = true;
            this.colSession.VisibleIndex = 10;
            this.colSession.Width = 88;
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.Caption = "TotalProduct";
            this.colTotalProduct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 11;
            this.colTotalProduct.Width = 105;
            // 
            // colTimeRun
            // 
            this.colTimeRun.Caption = "TimeRun";
            this.colTimeRun.FieldName = "TimeRun";
            this.colTimeRun.Name = "colTimeRun";
            this.colTimeRun.Visible = true;
            this.colTimeRun.VisibleIndex = 5;
            this.colTimeRun.Width = 88;
            // 
            // colDateCrawler
            // 
            this.colDateCrawler.Caption = "DateCrawler";
            this.colDateCrawler.FieldName = "DateCrawler";
            this.colDateCrawler.Name = "colDateCrawler";
            this.colDateCrawler.Visible = true;
            this.colDateCrawler.VisibleIndex = 12;
            this.colDateCrawler.Width = 70;
            // 
            // colIP
            // 
            this.colIP.Caption = "IP";
            this.colIP.FieldName = "IP";
            this.colIP.Name = "colIP";
            this.colIP.Visible = true;
            this.colIP.VisibleIndex = 13;
            this.colIP.Width = 70;
            // 
            // colTypeEnd
            // 
            this.colTypeEnd.Caption = "TypeEnd";
            this.colTypeEnd.FieldName = "TypeEnd";
            this.colTypeEnd.Name = "colTypeEnd";
            this.colTypeEnd.Visible = true;
            this.colTypeEnd.VisibleIndex = 14;
            this.colTypeEnd.Width = 70;
            // 
            // colNumberDuplicates
            // 
            this.colNumberDuplicates.Caption = "NumberDuplicates";
            this.colNumberDuplicates.FieldName = "NumberDuplicates";
            this.colNumberDuplicates.Name = "colNumberDuplicates";
            this.colNumberDuplicates.Visible = true;
            this.colNumberDuplicates.VisibleIndex = 15;
            this.colNumberDuplicates.Width = 110;
            // 
            // menuCompanyPlus1
            // 
            this.menuCompanyPlus1.Name = "menuCompanyPlus1";
            this.menuCompanyPlus1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnLastCrawler
            // 
            this.btnLastCrawler.Image = ((System.Drawing.Image)(resources.GetObject("btnLastCrawler.Image")));
            this.btnLastCrawler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLastCrawler.Name = "btnLastCrawler";
            this.btnLastCrawler.Size = new System.Drawing.Size(109, 22);
            this.btnLastCrawler.Text = "LastCrawlerInfo";
            this.btnLastCrawler.Click += new System.EventHandler(this.btnLastCrawler_Click);
            // 
            // FrmTrackCrawlerAllCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 750);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTrackCrawlerAllCompany";
            this.Text = "Lịch sử crawler";
            this.Load += new System.EventHandler(this.FrmTrackCrawlerAllCompany_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeCrawler;
        private DevExpress.XtraGrid.Columns.GridColumn colStartAt;
        private DevExpress.XtraGrid.Columns.GridColumn colEndAt;
        private DevExpress.XtraGrid.Columns.GridColumn colCountLink;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn colCountProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colCountChange;
        private DevExpress.XtraGrid.Columns.GridColumn colSession;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeRun;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCrawler;
        private DevExpress.XtraGrid.Columns.GridColumn colIP;
        private MenuCompanyPlus menuCompanyPlus1;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private System.Windows.Forms.CheckBox ckAll;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberDuplicates;
        private System.Windows.Forms.ToolStripButton btnLastCrawler;
    }
}