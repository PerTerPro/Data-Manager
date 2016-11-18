namespace  WSS.Crawler.Product.Report
{
    partial class FrmHistoryCrawlerByCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoryCrawlerByCompany));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTypeCrawler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coCountVisited = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSession = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuCompanyPlus1 = new WSS.Crawler.Product.Report.MenuCompanyPlus();
            this.RunTime = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(921, 25);
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
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(921, 574);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTypeCrawler,
            this.colStartAt,
            this.colEndAt,
            this.colTotalProduct,
            this.coCountVisited,
            this.colCountProduct,
            this.colIP,
            this.colSession,
            this.RunTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colTypeCrawler
            // 
            this.colTypeCrawler.Caption = "TypeCrawler";
            this.colTypeCrawler.FieldName = "TypeCrawler";
            this.colTypeCrawler.Name = "colTypeCrawler";
            this.colTypeCrawler.Visible = true;
            this.colTypeCrawler.VisibleIndex = 0;
            // 
            // colStartAt
            // 
            this.colStartAt.Caption = "colStartAt";
            this.colStartAt.DisplayFormat.FormatString = "yy-MM-dd HH:mm";
            this.colStartAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartAt.FieldName = "StartAt";
            this.colStartAt.Name = "colStartAt";
            this.colStartAt.Visible = true;
            this.colStartAt.VisibleIndex = 1;
            // 
            // colEndAt
            // 
            this.colEndAt.Caption = "colEndAt";
            this.colEndAt.DisplayFormat.FormatString = "yy-MM-dd HH:mm";
            this.colEndAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndAt.FieldName = "EndAt";
            this.colEndAt.Name = "colEndAt";
            this.colEndAt.Visible = true;
            this.colEndAt.VisibleIndex = 2;
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.Caption = "TotalProduct";
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 3;
            // 
            // coCountVisited
            // 
            this.coCountVisited.Caption = "CountVisited";
            this.coCountVisited.FieldName = "CountVisited";
            this.coCountVisited.Name = "coCountVisited";
            this.coCountVisited.Visible = true;
            this.coCountVisited.VisibleIndex = 4;
            // 
            // colCountProduct
            // 
            this.colCountProduct.Caption = "CountProduct";
            this.colCountProduct.FieldName = "CountProduct";
            this.colCountProduct.Name = "colCountProduct";
            this.colCountProduct.Visible = true;
            this.colCountProduct.VisibleIndex = 5;
            // 
            // colIP
            // 
            this.colIP.Caption = "IP";
            this.colIP.FieldName = "IP";
            this.colIP.Name = "colIP";
            this.colIP.Visible = true;
            this.colIP.VisibleIndex = 6;
            // 
            // colSession
            // 
            this.colSession.Caption = "Session";
            this.colSession.FieldName = "Session";
            this.colSession.Name = "colSession";
            this.colSession.Visible = true;
            this.colSession.VisibleIndex = 7;
            // 
            // menuCompanyPlus1
            // 
            this.menuCompanyPlus1.Name = "menuCompanyPlus1";
            this.menuCompanyPlus1.Size = new System.Drawing.Size(61, 4);
            // 
            // RunTime
            // 
            this.RunTime.Caption = "RunTime";
            this.RunTime.FieldName = "RunTime";
            this.RunTime.Name = "RunTime";
            this.RunTime.Visible = true;
            this.RunTime.VisibleIndex = 8;
            // 
            // FrmHistoryCrawlerByCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 599);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmHistoryCrawlerByCompany";
            this.Text = "Lịch sử crawler";
            this.Load += new System.EventHandler(this.FrmHistoryCrawler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeCrawler;
        private DevExpress.XtraGrid.Columns.GridColumn colStartAt;
        private DevExpress.XtraGrid.Columns.GridColumn colEndAt;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
        private DevExpress.XtraGrid.Columns.GridColumn coCountVisited;
        private DevExpress.XtraGrid.Columns.GridColumn colCountProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colIP;
        private DevExpress.XtraGrid.Columns.GridColumn colSession;
        private MenuCompanyPlus menuCompanyPlus1;
        private DevExpress.XtraGrid.Columns.GridColumn RunTime;

    }
}