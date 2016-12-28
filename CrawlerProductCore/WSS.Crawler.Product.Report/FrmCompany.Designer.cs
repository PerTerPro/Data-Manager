namespace WSS.Crawler.Product.Report
{
    partial class FrmCompany
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPushNextFN = new System.Windows.Forms.Button();
            this.btnPushNextRl = new System.Windows.Forms.Button();
            this.dtpTimeRun = new System.Windows.Forms.DateTimePicker();
            this.ckSelectGroup = new System.Windows.Forms.CheckBox();
            this.btnLoadNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconfiguration_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinHourReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinHourFindNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberThreadCrawler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTTType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCrawlerReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCrawlerFindNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNextReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNextFindNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowFindNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSourceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_SourceWebsiteType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMaxLinksFindNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxHourFindNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeDelay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowAutoCheckPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidMinProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidMaxProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxProductToWarning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinProductToWarning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxDeep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLimitFailToDelProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLimitProductValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuCompanyPlus1 = new WSS.Crawler.Product.Report.MenuCompanyPlus();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_SourceWebsiteType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnPushNextFN);
            this.panel1.Controls.Add(this.btnPushNextRl);
            this.panel1.Controls.Add(this.dtpTimeRun);
            this.panel1.Controls.Add(this.ckSelectGroup);
            this.panel1.Controls.Add(this.btnLoadNext);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 28);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "UpdateCountProduct";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnPushNextFN
            // 
            this.btnPushNextFN.Location = new System.Drawing.Point(927, 2);
            this.btnPushNextFN.Name = "btnPushNextFN";
            this.btnPushNextFN.Size = new System.Drawing.Size(75, 23);
            this.btnPushNextFN.TabIndex = 5;
            this.btnPushNextFN.Text = "PushNextFN";
            this.btnPushNextFN.UseVisualStyleBackColor = true;
            this.btnPushNextFN.Click += new System.EventHandler(this.btnPushNextFN_Click);
            // 
            // btnPushNextRl
            // 
            this.btnPushNextRl.Location = new System.Drawing.Point(846, 1);
            this.btnPushNextRl.Name = "btnPushNextRl";
            this.btnPushNextRl.Size = new System.Drawing.Size(75, 23);
            this.btnPushNextRl.TabIndex = 3;
            this.btnPushNextRl.Text = "PushNextRL";
            this.btnPushNextRl.UseVisualStyleBackColor = true;
            this.btnPushNextRl.Click += new System.EventHandler(this.btnPushNextRl_Click);
            // 
            // dtpTimeRun
            // 
            this.dtpTimeRun.CustomFormat = "dd-MM-yyyy";
            this.dtpTimeRun.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeRun.Location = new System.Drawing.Point(746, 4);
            this.dtpTimeRun.Name = "dtpTimeRun";
            this.dtpTimeRun.Size = new System.Drawing.Size(94, 20);
            this.dtpTimeRun.TabIndex = 4;
            // 
            // ckSelectGroup
            // 
            this.ckSelectGroup.AutoSize = true;
            this.ckSelectGroup.Location = new System.Drawing.Point(655, 8);
            this.ckSelectGroup.Name = "ckSelectGroup";
            this.ckSelectGroup.Size = new System.Drawing.Size(85, 17);
            this.ckSelectGroup.TabIndex = 3;
            this.ckSelectGroup.Text = "SelectGroup";
            this.ckSelectGroup.UseVisualStyleBackColor = true;
            // 
            // btnLoadNext
            // 
            this.btnLoadNext.Location = new System.Drawing.Point(169, 2);
            this.btnLoadNext.Name = "btnLoadNext";
            this.btnLoadNext.Size = new System.Drawing.Size(75, 23);
            this.btnLoadNext.TabIndex = 2;
            this.btnLoadNext.Text = "LoadNext";
            this.btnLoadNext.UseVisualStyleBackColor = true;
            this.btnLoadNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(7, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit_SourceWebsiteType});
            this.gridControl1.Size = new System.Drawing.Size(1276, 713);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colconfiguration_id,
            this.coldomain,
            this.colMinHourReload,
            this.colMinHourFindNew,
            this.colNumberThreadCrawler,
            this.colNameType,
            this.colSTTType,
            this.colLastCrawlerReload,
            this.colLastCrawlerFindNew,
            this.colNextReload,
            this.colNextFindNew,
            this.colAllowReload,
            this.colAllowFindNew,
            this.colTotalProduct,
            this.colSourceType,
            this.colMaxLinksFindNew,
            this.colMaxHourFindNew,
            this.colTimeDelay,
            this.colAllowAutoCheckPrice,
            this.colValidMinProduct,
            this.colValidMaxProduct,
            this.colMaxProductToWarning,
            this.colMinProductToWarning,
            this.colMaxDeep,
            this.colLimitFailToDelProduct,
            this.colLimitProductValid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.Caption = "id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 55;
            // 
            // colconfiguration_id
            // 
            this.colconfiguration_id.Caption = "configuration_id";
            this.colconfiguration_id.FieldName = "configuration_id";
            this.colconfiguration_id.Name = "colconfiguration_id";
            this.colconfiguration_id.OptionsColumn.AllowEdit = false;
            this.colconfiguration_id.Visible = true;
            this.colconfiguration_id.VisibleIndex = 1;
            this.colconfiguration_id.Width = 55;
            // 
            // coldomain
            // 
            this.coldomain.Caption = "domain";
            this.coldomain.FieldName = "domain";
            this.coldomain.Name = "coldomain";
            this.coldomain.OptionsColumn.ReadOnly = true;
            this.coldomain.Visible = true;
            this.coldomain.VisibleIndex = 2;
            this.coldomain.Width = 55;
            // 
            // colMinHourReload
            // 
            this.colMinHourReload.Caption = "MinHourReload";
            this.colMinHourReload.FieldName = "MinHourReload";
            this.colMinHourReload.Name = "colMinHourReload";
            this.colMinHourReload.Visible = true;
            this.colMinHourReload.VisibleIndex = 3;
            this.colMinHourReload.Width = 55;
            // 
            // colMinHourFindNew
            // 
            this.colMinHourFindNew.Caption = "MinHourFindNew";
            this.colMinHourFindNew.FieldName = "MinHourFindNew";
            this.colMinHourFindNew.Name = "colMinHourFindNew";
            this.colMinHourFindNew.Visible = true;
            this.colMinHourFindNew.VisibleIndex = 4;
            this.colMinHourFindNew.Width = 55;
            // 
            // colNumberThreadCrawler
            // 
            this.colNumberThreadCrawler.Caption = "NumberThreadCrawler";
            this.colNumberThreadCrawler.FieldName = "NumberThreadCrawler";
            this.colNumberThreadCrawler.Name = "colNumberThreadCrawler";
            this.colNumberThreadCrawler.Visible = true;
            this.colNumberThreadCrawler.VisibleIndex = 5;
            this.colNumberThreadCrawler.Width = 55;
            // 
            // colNameType
            // 
            this.colNameType.Caption = "NameType";
            this.colNameType.FieldName = "NameType";
            this.colNameType.Name = "colNameType";
            this.colNameType.OptionsColumn.AllowEdit = false;
            this.colNameType.Visible = true;
            this.colNameType.VisibleIndex = 6;
            this.colNameType.Width = 55;
            // 
            // colSTTType
            // 
            this.colSTTType.Caption = "STTType";
            this.colSTTType.FieldName = "STTType";
            this.colSTTType.Name = "colSTTType";
            this.colSTTType.OptionsColumn.AllowEdit = false;
            this.colSTTType.Visible = true;
            this.colSTTType.VisibleIndex = 7;
            this.colSTTType.Width = 55;
            // 
            // colLastCrawlerReload
            // 
            this.colLastCrawlerReload.Caption = "LastCrawlerReload";
            this.colLastCrawlerReload.FieldName = "LastCrawlerReload";
            this.colLastCrawlerReload.Name = "colLastCrawlerReload";
            this.colLastCrawlerReload.Visible = true;
            this.colLastCrawlerReload.VisibleIndex = 8;
            this.colLastCrawlerReload.Width = 55;
            // 
            // colLastCrawlerFindNew
            // 
            this.colLastCrawlerFindNew.Caption = "LastCrawlerFindNew";
            this.colLastCrawlerFindNew.FieldName = "LastCrawlerFindNew";
            this.colLastCrawlerFindNew.Name = "colLastCrawlerFindNew";
            this.colLastCrawlerFindNew.Visible = true;
            this.colLastCrawlerFindNew.VisibleIndex = 9;
            this.colLastCrawlerFindNew.Width = 55;
            // 
            // colNextReload
            // 
            this.colNextReload.Caption = "NextReload";
            this.colNextReload.FieldName = "NextReload";
            this.colNextReload.Name = "colNextReload";
            this.colNextReload.Visible = true;
            this.colNextReload.VisibleIndex = 10;
            this.colNextReload.Width = 55;
            // 
            // colNextFindNew
            // 
            this.colNextFindNew.Caption = "NextFindNew";
            this.colNextFindNew.FieldName = "NextFindNew";
            this.colNextFindNew.Name = "colNextFindNew";
            this.colNextFindNew.Visible = true;
            this.colNextFindNew.VisibleIndex = 11;
            this.colNextFindNew.Width = 55;
            // 
            // colAllowReload
            // 
            this.colAllowReload.Caption = "AllowReload";
            this.colAllowReload.FieldName = "AllowReload";
            this.colAllowReload.Name = "colAllowReload";
            this.colAllowReload.Visible = true;
            this.colAllowReload.VisibleIndex = 12;
            this.colAllowReload.Width = 55;
            // 
            // colAllowFindNew
            // 
            this.colAllowFindNew.Caption = "AllowFindNew";
            this.colAllowFindNew.FieldName = "AllowFindNew";
            this.colAllowFindNew.Name = "colAllowFindNew";
            this.colAllowFindNew.Visible = true;
            this.colAllowFindNew.VisibleIndex = 13;
            this.colAllowFindNew.Width = 55;
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.Caption = "TotalProduct";
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 14;
            this.colTotalProduct.Width = 55;
            // 
            // colSourceType
            // 
            this.colSourceType.Caption = "Website_SourceType";
            this.colSourceType.ColumnEdit = this.repositoryItemLookUpEdit_SourceWebsiteType;
            this.colSourceType.FieldName = "Website_SourceType";
            this.colSourceType.Name = "colSourceType";
            this.colSourceType.Visible = true;
            this.colSourceType.VisibleIndex = 15;
            this.colSourceType.Width = 55;
            // 
            // repositoryItemLookUpEdit_SourceWebsiteType
            // 
            this.repositoryItemLookUpEdit_SourceWebsiteType.AutoHeight = false;
            this.repositoryItemLookUpEdit_SourceWebsiteType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_SourceWebsiteType.Name = "repositoryItemLookUpEdit_SourceWebsiteType";
            // 
            // colMaxLinksFindNew
            // 
            this.colMaxLinksFindNew.Caption = "MaxLinksFindNew";
            this.colMaxLinksFindNew.FieldName = "MaxLinksFindNew";
            this.colMaxLinksFindNew.Name = "colMaxLinksFindNew";
            this.colMaxLinksFindNew.Visible = true;
            this.colMaxLinksFindNew.VisibleIndex = 16;
            this.colMaxLinksFindNew.Width = 55;
            // 
            // colMaxHourFindNew
            // 
            this.colMaxHourFindNew.Caption = "MaxHourFindNew";
            this.colMaxHourFindNew.FieldName = "MaxHourFindNew";
            this.colMaxHourFindNew.Name = "colMaxHourFindNew";
            this.colMaxHourFindNew.Visible = true;
            this.colMaxHourFindNew.VisibleIndex = 17;
            this.colMaxHourFindNew.Width = 55;
            // 
            // colTimeDelay
            // 
            this.colTimeDelay.Caption = "TimeDelay";
            this.colTimeDelay.FieldName = "TimeDelay";
            this.colTimeDelay.Name = "colTimeDelay";
            this.colTimeDelay.Visible = true;
            this.colTimeDelay.VisibleIndex = 18;
            this.colTimeDelay.Width = 55;
            // 
            // colAllowAutoCheckPrice
            // 
            this.colAllowAutoCheckPrice.Caption = "AllowAutoCheckPrice";
            this.colAllowAutoCheckPrice.FieldName = "AllowAutoCheckPrice";
            this.colAllowAutoCheckPrice.Name = "colAllowAutoCheckPrice";
            this.colAllowAutoCheckPrice.Visible = true;
            this.colAllowAutoCheckPrice.VisibleIndex = 19;
            this.colAllowAutoCheckPrice.Width = 55;
            // 
            // colValidMinProduct
            // 
            this.colValidMinProduct.Caption = "ValidMinProduct";
            this.colValidMinProduct.FieldName = "ValidMinProduct";
            this.colValidMinProduct.Name = "colValidMinProduct";
            this.colValidMinProduct.Visible = true;
            this.colValidMinProduct.VisibleIndex = 20;
            this.colValidMinProduct.Width = 55;
            // 
            // colValidMaxProduct
            // 
            this.colValidMaxProduct.Caption = "ValidMaxProduct";
            this.colValidMaxProduct.FieldName = "ValidMaxProduct";
            this.colValidMaxProduct.Name = "colValidMaxProduct";
            this.colValidMaxProduct.Visible = true;
            this.colValidMaxProduct.VisibleIndex = 21;
            this.colValidMaxProduct.Width = 55;
            // 
            // colMaxProductToWarning
            // 
            this.colMaxProductToWarning.Caption = "MaxProductToWarning";
            this.colMaxProductToWarning.FieldName = "MaxProductToWarning";
            this.colMaxProductToWarning.Name = "colMaxProductToWarning";
            this.colMaxProductToWarning.Visible = true;
            this.colMaxProductToWarning.VisibleIndex = 22;
            this.colMaxProductToWarning.Width = 55;
            // 
            // colMinProductToWarning
            // 
            this.colMinProductToWarning.Caption = "MinProductToWarning";
            this.colMinProductToWarning.FieldName = "MinProductToWarning";
            this.colMinProductToWarning.Name = "colMinProductToWarning";
            this.colMinProductToWarning.Visible = true;
            this.colMinProductToWarning.VisibleIndex = 23;
            this.colMinProductToWarning.Width = 55;
            // 
            // colMaxDeep
            // 
            this.colMaxDeep.Caption = "MaxDeep";
            this.colMaxDeep.FieldName = "MaxDeep";
            this.colMaxDeep.Name = "colMaxDeep";
            this.colMaxDeep.Visible = true;
            this.colMaxDeep.VisibleIndex = 24;
            this.colMaxDeep.Width = 72;
            // 
            // colLimitFailToDelProduct
            // 
            this.colLimitFailToDelProduct.Caption = "LimitFailToDelProduct";
            this.colLimitFailToDelProduct.FieldName = "LimitFailToDelProduct";
            this.colLimitFailToDelProduct.Name = "colLimitFailToDelProduct";
            this.colLimitFailToDelProduct.Visible = true;
            this.colLimitFailToDelProduct.VisibleIndex = 25;
            this.colLimitFailToDelProduct.Width = 54;
            // 
            // colLimitProductValid
            // 
            this.colLimitProductValid.Caption = "LimitProductValid";
            this.colLimitProductValid.FieldName = "LimitProductValid";
            this.colLimitProductValid.Name = "colLimitProductValid";
            this.colLimitProductValid.Visible = true;
            this.colLimitProductValid.VisibleIndex = 26;
            // 
            // menuCompanyPlus1
            // 
            this.menuCompanyPlus1.Name = "menuCompanyPlus1";
            this.menuCompanyPlus1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 741);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmCompany";
            this.Text = "Cong ty";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCompany_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCompany_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_SourceWebsiteType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colconfiguration_id;
        private DevExpress.XtraGrid.Columns.GridColumn coldomain;
        private DevExpress.XtraGrid.Columns.GridColumn colMinHourReload;
        private DevExpress.XtraGrid.Columns.GridColumn colMinHourFindNew;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberThreadCrawler;
        private DevExpress.XtraGrid.Columns.GridColumn colNameType;
        private DevExpress.XtraGrid.Columns.GridColumn colSTTType;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCrawlerReload;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCrawlerFindNew;
        private DevExpress.XtraGrid.Columns.GridColumn colNextReload;
        private System.Windows.Forms.Button btnLoadNext;
        private DevExpress.XtraGrid.Columns.GridColumn colNextFindNew;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowReload;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowFindNew;
        private System.Windows.Forms.CheckBox ckSelectGroup;
        private System.Windows.Forms.Button btnPushNextFN;
        private System.Windows.Forms.Button btnPushNextRl;
        private System.Windows.Forms.DateTimePicker dtpTimeRun;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceType;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxLinksFindNew;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxHourFindNew;
        private MenuCompanyPlus menuCompanyPlus1;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeDelay;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_SourceWebsiteType;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowAutoCheckPrice;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.Columns.GridColumn colValidMinProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colValidMaxProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxProductToWarning;
        private DevExpress.XtraGrid.Columns.GridColumn colMinProductToWarning;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxDeep;
        private DevExpress.XtraGrid.Columns.GridColumn colLimitFailToDelProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colLimitProductValid;
    }
}