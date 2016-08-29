namespace QT.Moduls.CrawlerProduct
{
    partial class FrmReportMinLastUpdateProductCrawler
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPushIsNew = new System.Windows.Forms.Button();
            this.btnReloadData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckVip = new System.Windows.Forms.RadioButton();
            this.ckAllCom = new System.Windows.Forms.RadioButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNewProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinHourRecrawl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCrawlerReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastEndCrawlerReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastJobCrawlerReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btncheckErrorDownloadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1051, 55);
            this.panelControl1.TabIndex = 0;
            // 
            // btnPushIsNew
            // 
            this.btnPushIsNew.Location = new System.Drawing.Point(120, 5);
            this.btnPushIsNew.Name = "btnPushIsNew";
            this.btnPushIsNew.Size = new System.Drawing.Size(75, 23);
            this.btnPushIsNew.TabIndex = 2;
            this.btnPushIsNew.Text = "PushIsNew";
            this.btnPushIsNew.UseVisualStyleBackColor = true;
            this.btnPushIsNew.Click += new System.EventHandler(this.btnPushIsNew_Click);
            // 
            // btnReloadData
            // 
            this.btnReloadData.Location = new System.Drawing.Point(39, 5);
            this.btnReloadData.Name = "btnReloadData";
            this.btnReloadData.Size = new System.Drawing.Size(75, 23);
            this.btnReloadData.TabIndex = 1;
            this.btnReloadData.Text = "ReloadData";
            this.btnReloadData.UseVisualStyleBackColor = true;
            this.btnReloadData.Click += new System.EventHandler(this.btnReloadData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelControl3);
            this.groupBox1.Controls.Add(this.ckVip);
            this.groupBox1.Controls.Add(this.ckAllCom);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ckVip
            // 
            this.ckVip.AutoSize = true;
            this.ckVip.Location = new System.Drawing.Point(131, 11);
            this.ckVip.Name = "ckVip";
            this.ckVip.Size = new System.Drawing.Size(76, 17);
            this.ckVip.TabIndex = 1;
            this.ckVip.Text = "Khách VIP";
            this.ckVip.UseVisualStyleBackColor = true;
            // 
            // ckAllCom
            // 
            this.ckAllCom.AutoSize = true;
            this.ckAllCom.Checked = true;
            this.ckAllCom.Location = new System.Drawing.Point(10, 11);
            this.ckAllCom.Name = "ckAllCom";
            this.ckAllCom.Size = new System.Drawing.Size(115, 17);
            this.ckAllCom.TabIndex = 0;
            this.ckAllCom.TabStop = true;
            this.ckAllCom.Text = "AllCompanyCrawler";
            this.ckAllCom.UseVisualStyleBackColor = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 55);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1051, 334);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1047, 330);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDomain,
            this.colMinLastUpdate,
            this.colTotalProduct,
            this.colTotalValid,
            this.colTotalNewProduct,
            this.colMinHourRecrawl,
            this.colMaxValid,
            this.colLastCrawlerReload,
            this.colLastEndCrawlerReload,
            this.colLastJobCrawlerReload});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colDomain
            // 
            this.colDomain.Caption = "Domain";
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 1;
            // 
            // colMinLastUpdate
            // 
            this.colMinLastUpdate.Caption = "MinLastUpdate";
            this.colMinLastUpdate.DisplayFormat.FormatString = "dd/MM HH:mm:ss:ff";
            this.colMinLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colMinLastUpdate.FieldName = "MinLastUpdate";
            this.colMinLastUpdate.Name = "colMinLastUpdate";
            this.colMinLastUpdate.Visible = true;
            this.colMinLastUpdate.VisibleIndex = 2;
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.Caption = "TotalProduct";
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 4;
            // 
            // colTotalValid
            // 
            this.colTotalValid.Caption = "TotalValid";
            this.colTotalValid.FieldName = "TotalValid";
            this.colTotalValid.Name = "colTotalValid";
            this.colTotalValid.Visible = true;
            this.colTotalValid.VisibleIndex = 6;
            // 
            // colTotalNewProduct
            // 
            this.colTotalNewProduct.Caption = "TotalNewProduct";
            this.colTotalNewProduct.FieldName = "TotalNewProduct";
            this.colTotalNewProduct.Name = "colTotalNewProduct";
            this.colTotalNewProduct.Visible = true;
            this.colTotalNewProduct.VisibleIndex = 5;
            // 
            // colMinHourRecrawl
            // 
            this.colMinHourRecrawl.Caption = "MinHourRecrawl";
            this.colMinHourRecrawl.FieldName = "MinHourRecrawl";
            this.colMinHourRecrawl.Name = "colMinHourRecrawl";
            this.colMinHourRecrawl.Visible = true;
            this.colMinHourRecrawl.VisibleIndex = 3;
            // 
            // colMaxValid
            // 
            this.colMaxValid.Caption = "MaxValid";
            this.colMaxValid.FieldName = "MaxValid";
            this.colMaxValid.Name = "colMaxValid";
            this.colMaxValid.Visible = true;
            this.colMaxValid.VisibleIndex = 7;
            // 
            // colLastCrawlerReload
            // 
            this.colLastCrawlerReload.Caption = "LastCrawlerReload";
            this.colLastCrawlerReload.DisplayFormat.FormatString = "dd/MM HH:mm:ss:ff";
            this.colLastCrawlerReload.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastCrawlerReload.FieldName = "LastCrawlerReload";
            this.colLastCrawlerReload.Name = "colLastCrawlerReload";
            this.colLastCrawlerReload.Visible = true;
            this.colLastCrawlerReload.VisibleIndex = 8;
            // 
            // colLastEndCrawlerReload
            // 
            this.colLastEndCrawlerReload.Caption = "LastEndCrawlerReload";
            this.colLastEndCrawlerReload.DisplayFormat.FormatString = "dd/MM HH:mm:ss:ff";
            this.colLastEndCrawlerReload.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastEndCrawlerReload.FieldName = "LastEndCrawlerReload";
            this.colLastEndCrawlerReload.Name = "colLastEndCrawlerReload";
            this.colLastEndCrawlerReload.Visible = true;
            this.colLastEndCrawlerReload.VisibleIndex = 9;
            // 
            // colLastJobCrawlerReload
            // 
            this.colLastJobCrawlerReload.Caption = "LastJobCrawlerReload";
            this.colLastJobCrawlerReload.DisplayFormat.FormatString = "dd/MM HH:mm:ss:ff";
            this.colLastJobCrawlerReload.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastJobCrawlerReload.FieldName = "LastJobCrawlerReload";
            this.colLastJobCrawlerReload.Name = "colLastJobCrawlerReload";
            this.colLastJobCrawlerReload.Visible = true;
            this.colLastJobCrawlerReload.VisibleIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btncheckErrorDownloadImageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 26);
            // 
            // btncheckErrorDownloadImageToolStripMenuItem
            // 
            this.btncheckErrorDownloadImageToolStripMenuItem.Name = "btncheckErrorDownloadImageToolStripMenuItem";
            this.btncheckErrorDownloadImageToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.btncheckErrorDownloadImageToolStripMenuItem.Text = "CheckErrorDownloadImage";
            this.btncheckErrorDownloadImageToolStripMenuItem.Click += new System.EventHandler(this.btncheckErrorDownloadImageToolStripMenuItem_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnReloadData);
            this.panelControl3.Controls.Add(this.btnPushIsNew);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(844, 16);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(200, 32);
            this.panelControl3.TabIndex = 3;
            // 
            // FrmReportMinLastUpdateProductCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 389);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmReportMinLastUpdateProductCrawler";
            this.Text = "FrmReportMinLastUpdateProductCrawler";
            this.Load += new System.EventHandler(this.FrmReportMinLastUpdateProductCrawler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colMinLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValid;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNewProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colMinHourRecrawl;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxValid;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCrawlerReload;
        private DevExpress.XtraGrid.Columns.GridColumn colLastEndCrawlerReload;
        private DevExpress.XtraGrid.Columns.GridColumn colLastJobCrawlerReload;
        private System.Windows.Forms.Button btnReloadData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ckVip;
        private System.Windows.Forms.RadioButton ckAllCom;
        private System.Windows.Forms.Button btnPushIsNew;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btncheckErrorDownloadImageToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}