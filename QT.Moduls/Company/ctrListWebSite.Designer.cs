namespace QT.Moduls
{
    partial class ctrListWebSite
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label checkLabel;
            System.Windows.Forms.Label domainLabel;
            System.Windows.Forms.Label statusLabel;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrListWebSite));
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyDomainToClipboadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pushIsNewToQueueImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crawlerReloadNoValidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pushCompanyDownloadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHistoryCrawlerData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAllImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageĐãValidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAllImageValidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewQuangCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewThongKeLuotClick = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setStatusNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.checkedAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unCheckedAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewProductMerchanttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrawlerByQueue = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrawlerInRedis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMapCategoryAndClassification = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPushQueueFindData = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMapCatAndClassAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewProduct1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoveFailRegexProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPushCompanyInfoReset = new System.Windows.Forms.ToolStripMenuItem();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCom = new QT.Moduls.Company.DBCom();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNewProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotVisibleProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeDelay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQueue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalVisited = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCheckTotalValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalViewMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCrawlerReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dB = new QT.Moduls.DB();
            this.companyStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barPage = new DevExpress.XtraBars.Bar();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.cboCount = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btFirst = new DevExpress.XtraBars.BarButtonItem();
            this.btPrevious = new DevExpress.XtraBars.BarButtonItem();
            this.txtPageCurrent = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btNext = new DevExpress.XtraBars.BarButtonItem();
            this.btEnd = new DevExpress.XtraBars.BarButtonItem();
            this.btRunAllQueue = new DevExpress.XtraBars.BarButtonItem();
            this.barLoadT = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.tableAdapterManager = new QT.Moduls.DBTableAdapters.TableAdapterManager();
            this.websiteLabel1 = new System.Windows.Forms.Label();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.company_StatusTableAdapter = new QT.Moduls.DBTableAdapters.Company_StatusTableAdapter();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.checkCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btDelete = new System.Windows.Forms.ToolStripButton();
            this.domainLabel1 = new System.Windows.Forms.Label();
            this.companyTableAdapter1 = new QT.Moduls.Company.DBComTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager1 = new QT.Moduls.Company.DBComTableAdapters.TableAdapterManager();
            this.statusLabel1 = new System.Windows.Forms.Label();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.managerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTypeTableAdapter = new QT.Moduls.Company.DBComTableAdapters.ManagerTypeTableAdapter();
            this.btRunQueue = new DevExpress.XtraEditors.SimpleButton();
            this.btAllHistory = new DevExpress.XtraEditors.SimpleButton();
            this.luCompanyStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.tabCrawler = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.viewManagerCrawlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNameType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameCommand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnline = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.company1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.company1GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTheoDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ListError = new DevExpress.XtraTab.XtraTabPage();
            this.grvListNeedRepair = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Fixed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkFixed = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Domain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaxValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastCheckConfig = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastRepairConfig = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPageRpMinLastRL = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlRpMinLastRL = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRpDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRpMinLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRpTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRpTotalValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRpMaxValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRpMinHourRecrawl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRpTimeDelay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRpLastCrawlerReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRpTotalNewProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRpLastEndCrawlerReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRpLastJobCrawlerReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CkVipCom = new System.Windows.Forms.RadioButton();
            this.CkAllCom = new System.Windows.Forms.RadioButton();
            this.btnViewCount = new DevExpress.XtraEditors.SimpleButton();
            this.lblCountSelected = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.viewManagerCrawlerTableAdapter = new QT.Moduls.Company.DBComTableAdapters.ViewManagerCrawlerTableAdapter();
            this.btLoadManagerCrawler = new DevExpress.XtraEditors.SimpleButton();
            this.btLoadDistinct = new DevExpress.XtraEditors.SimpleButton();
            this.btnNotShowProduct = new DevExpress.XtraEditors.SimpleButton();
            this.company1TableAdapter = new QT.Moduls.Company.DBComTableAdapters.Company1TableAdapter();
            this.btnLoadErrorConfig = new DevExpress.XtraEditors.SimpleButton();
            this.btnNeedRepair = new DevExpress.XtraEditors.SimpleButton();
            this.btnRpMinLastRL = new DevExpress.XtraEditors.SimpleButton();
            websiteLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            checkLabel = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luCompanyStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.tabCrawler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewManagerCrawlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.company1GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.ListError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListNeedRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkFixed)).BeginInit();
            this.xtraTabPageRpMinLastRL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRpMinLastRL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(205, 207);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(49, 13);
            websiteLabel.TabIndex = 6;
            websiteLabel.Text = "Website:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(233, 240);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 11;
            iDLabel.Text = "ID:";
            // 
            // checkLabel
            // 
            checkLabel.AutoSize = true;
            checkLabel.Enabled = false;
            checkLabel.Location = new System.Drawing.Point(88, 309);
            checkLabel.Name = "checkLabel";
            checkLabel.Size = new System.Drawing.Size(41, 13);
            checkLabel.TabIndex = 21;
            checkLabel.Text = "Check:";
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(428, 270);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 31;
            domainLabel.Text = "Domain:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(409, 181);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 36;
            statusLabel.Text = "Status:";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.DisplayFormat.FormatString = "n0";
            this.repositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.companyBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(3, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(841, 284);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyDomainToClipboadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.btnHistoryCrawlerData,
            this.toolStripSeparator4,
            this.loadImageToolStripMenuItem,
            this.loadAllImageToolStripMenuItem,
            this.loadImageĐãValidToolStripMenuItem,
            this.loadAllImageValidToolStripMenuItem,
            this.toolStripSeparator3,
            this.viewProfileToolStripMenuItem,
            this.viewProductToolStripMenuItem,
            this.exportProductToolStripMenuItem,
            this.viewWebToolStripMenuItem,
            this.viewQuangCaoToolStripMenuItem,
            this.viewThongKeLuotClick,
            this.menuItemExportExcel,
            this.toolStripSeparator1,
            this.addNewWebToolStripMenuItem,
            this.notAvailableToolStripMenuItem,
            this.NewsToolStripMenuItem,
            this.NotProductToolStripMenuItem,
            this.setStatusNormalToolStripMenuItem,
            this.toolStripSeparator2,
            this.checkedAllToolStripMenuItem,
            this.unCheckedAllToolStripMenuItem,
            this.AddNewProductMerchanttoolStripMenuItem,
            this.btnCrawlerByQueue,
            this.btnCrawlerInRedis,
            this.btnMapCategoryAndClassification,
            this.btnPushQueueFindData,
            this.btnMapCatAndClassAuto,
            this.btnViewProduct1,
            this.btnRemoveFailRegexProduct,
            this.updateCategoryToolStripMenuItem,
            this.btnPushCompanyInfoReset});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 732);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // copyDomainToClipboadToolStripMenuItem
            // 
            this.copyDomainToClipboadToolStripMenuItem.Name = "copyDomainToClipboadToolStripMenuItem";
            this.copyDomainToClipboadToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.copyDomainToClipboadToolStripMenuItem.Text = "CopyIDToClipboad";
            this.copyDomainToClipboadToolStripMenuItem.Click += new System.EventHandler(this.copyDomainToClipboadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pushIsNewToQueueImageToolStripMenuItem,
            this.crawlerReloadNoValidToolStripMenuItem,
            this.pushCompanyDownloadImageToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.toolStripMenuItem1.Text = "FixData";
            // 
            // pushIsNewToQueueImageToolStripMenuItem
            // 
            this.pushIsNewToQueueImageToolStripMenuItem.Name = "pushIsNewToQueueImageToolStripMenuItem";
            this.pushIsNewToQueueImageToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.pushIsNewToQueueImageToolStripMenuItem.Text = "PushIsNewToQueueImage";
            this.pushIsNewToQueueImageToolStripMenuItem.Click += new System.EventHandler(this.pushIsNewToQueueImageToolStripMenuItem_Click);
            // 
            // crawlerReloadNoValidToolStripMenuItem
            // 
            this.crawlerReloadNoValidToolStripMenuItem.Name = "crawlerReloadNoValidToolStripMenuItem";
            this.crawlerReloadNoValidToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.crawlerReloadNoValidToolStripMenuItem.Text = "Crawler_ReloadNoValid";
            this.crawlerReloadNoValidToolStripMenuItem.Click += new System.EventHandler(this.crawlerReloadNoValidToolStripMenuItem_Click);
            // 
            // pushCompanyDownloadImageToolStripMenuItem
            // 
            this.pushCompanyDownloadImageToolStripMenuItem.Name = "pushCompanyDownloadImageToolStripMenuItem";
            this.pushCompanyDownloadImageToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.pushCompanyDownloadImageToolStripMenuItem.Text = "PushCompanyDownloadImage";
            this.pushCompanyDownloadImageToolStripMenuItem.Click += new System.EventHandler(this.pushCompanyDownloadImageToolStripMenuItem_Click);
            // 
            // btnHistoryCrawlerData
            // 
            this.btnHistoryCrawlerData.Name = "btnHistoryCrawlerData";
            this.btnHistoryCrawlerData.Size = new System.Drawing.Size(235, 22);
            this.btnHistoryCrawlerData.Text = "HistoryCrawler";
            this.btnHistoryCrawlerData.Click += new System.EventHandler(this.btnHistoryCrawlerData_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(232, 6);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // loadAllImageToolStripMenuItem
            // 
            this.loadAllImageToolStripMenuItem.Name = "loadAllImageToolStripMenuItem";
            this.loadAllImageToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.loadAllImageToolStripMenuItem.Text = "Load All Image";
            this.loadAllImageToolStripMenuItem.Click += new System.EventHandler(this.loadAllImageToolStripMenuItem_Click);
            // 
            // loadImageĐãValidToolStripMenuItem
            // 
            this.loadImageĐãValidToolStripMenuItem.Name = "loadImageĐãValidToolStripMenuItem";
            this.loadImageĐãValidToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.loadImageĐãValidToolStripMenuItem.Text = "Download Image";
            this.loadImageĐãValidToolStripMenuItem.Click += new System.EventHandler(this.loadImageĐãValidToolStripMenuItem_Click);
            // 
            // loadAllImageValidToolStripMenuItem
            // 
            this.loadAllImageValidToolStripMenuItem.Name = "loadAllImageValidToolStripMenuItem";
            this.loadAllImageValidToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.loadAllImageValidToolStripMenuItem.Text = "Download All Image";
            this.loadAllImageValidToolStripMenuItem.Click += new System.EventHandler(this.loadAllImageValidToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(232, 6);
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Checked = true;
            this.viewProfileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.viewProfileToolStripMenuItem.Text = "View Profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // viewProductToolStripMenuItem
            // 
            this.viewProductToolStripMenuItem.Name = "viewProductToolStripMenuItem";
            this.viewProductToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.viewProductToolStripMenuItem.Text = "ViewProduct";
            this.viewProductToolStripMenuItem.Click += new System.EventHandler(this.viewProductToolStripMenuItem_Click);
            // 
            // exportProductToolStripMenuItem
            // 
            this.exportProductToolStripMenuItem.Name = "exportProductToolStripMenuItem";
            this.exportProductToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.exportProductToolStripMenuItem.Text = "Export Product";
            this.exportProductToolStripMenuItem.Click += new System.EventHandler(this.exportProductToolStripMenuItem_Click);
            // 
            // viewWebToolStripMenuItem
            // 
            this.viewWebToolStripMenuItem.Name = "viewWebToolStripMenuItem";
            this.viewWebToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.viewWebToolStripMenuItem.Text = "ViewWeb";
            this.viewWebToolStripMenuItem.Click += new System.EventHandler(this.viewWebToolStripMenuItem_Click);
            // 
            // viewQuangCaoToolStripMenuItem
            // 
            this.viewQuangCaoToolStripMenuItem.Name = "viewQuangCaoToolStripMenuItem";
            this.viewQuangCaoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.viewQuangCaoToolStripMenuItem.Text = "Quảng Cáo";
            this.viewQuangCaoToolStripMenuItem.Click += new System.EventHandler(this.viewQuangCaoToolStripMenuItem_Click);
            // 
            // viewThongKeLuotClick
            // 
            this.viewThongKeLuotClick.Name = "viewThongKeLuotClick";
            this.viewThongKeLuotClick.Size = new System.Drawing.Size(235, 22);
            this.viewThongKeLuotClick.Text = "Thống kê lượt click";
            this.viewThongKeLuotClick.Click += new System.EventHandler(this.viewThongKeLuotClick_Click);
            // 
            // menuItemExportExcel
            // 
            this.menuItemExportExcel.Name = "menuItemExportExcel";
            this.menuItemExportExcel.Size = new System.Drawing.Size(235, 22);
            this.menuItemExportExcel.Text = "Export To Excel";
            this.menuItemExportExcel.Click += new System.EventHandler(this.menuItemExportExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // addNewWebToolStripMenuItem
            // 
            this.addNewWebToolStripMenuItem.Name = "addNewWebToolStripMenuItem";
            this.addNewWebToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.addNewWebToolStripMenuItem.Text = "Add New Web";
            this.addNewWebToolStripMenuItem.Click += new System.EventHandler(this.addNewWebToolStripMenuItem_Click);
            // 
            // notAvailableToolStripMenuItem
            // 
            this.notAvailableToolStripMenuItem.Name = "notAvailableToolStripMenuItem";
            this.notAvailableToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.notAvailableToolStripMenuItem.Text = "Change to Not Available";
            this.notAvailableToolStripMenuItem.Click += new System.EventHandler(this.notAvailableToolStripMenuItem_Click);
            // 
            // NewsToolStripMenuItem
            // 
            this.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem";
            this.NewsToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.NewsToolStripMenuItem.Text = "Change to Web News";
            this.NewsToolStripMenuItem.Click += new System.EventHandler(this.NewsToolStripMenuItem_Click);
            // 
            // NotProductToolStripMenuItem
            // 
            this.NotProductToolStripMenuItem.Name = "NotProductToolStripMenuItem";
            this.NotProductToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.NotProductToolStripMenuItem.Text = "Change  to not product";
            this.NotProductToolStripMenuItem.Click += new System.EventHandler(this.NotProductToolStripMenuItem_Click);
            // 
            // setStatusNormalToolStripMenuItem
            // 
            this.setStatusNormalToolStripMenuItem.Enabled = false;
            this.setStatusNormalToolStripMenuItem.Name = "setStatusNormalToolStripMenuItem";
            this.setStatusNormalToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.setStatusNormalToolStripMenuItem.Text = "Set Status normal";
            this.setStatusNormalToolStripMenuItem.Click += new System.EventHandler(this.setStatusNormalToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // checkedAllToolStripMenuItem
            // 
            this.checkedAllToolStripMenuItem.Name = "checkedAllToolStripMenuItem";
            this.checkedAllToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.checkedAllToolStripMenuItem.Text = "Checked All";
            this.checkedAllToolStripMenuItem.Click += new System.EventHandler(this.checkedAllToolStripMenuItem_Click);
            // 
            // unCheckedAllToolStripMenuItem
            // 
            this.unCheckedAllToolStripMenuItem.Name = "unCheckedAllToolStripMenuItem";
            this.unCheckedAllToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.unCheckedAllToolStripMenuItem.Text = "UnCheckAll";
            this.unCheckedAllToolStripMenuItem.Click += new System.EventHandler(this.unCheckedAllToolStripMenuItem_Click);
            // 
            // AddNewProductMerchanttoolStripMenuItem
            // 
            this.AddNewProductMerchanttoolStripMenuItem.Name = "AddNewProductMerchanttoolStripMenuItem";
            this.AddNewProductMerchanttoolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.AddNewProductMerchanttoolStripMenuItem.Text = "Nhập SP Merchant";
            this.AddNewProductMerchanttoolStripMenuItem.Click += new System.EventHandler(this.AddNewProductMerchanttoolStripMenuItem_Click);
            // 
            // btnCrawlerByQueue
            // 
            this.btnCrawlerByQueue.Name = "btnCrawlerByQueue";
            this.btnCrawlerByQueue.Size = new System.Drawing.Size(235, 22);
            this.btnCrawlerByQueue.Text = "CrawlerByQueue";
            this.btnCrawlerByQueue.Click += new System.EventHandler(this.btnCrawlerByQueue_Click);
            // 
            // btnCrawlerInRedis
            // 
            this.btnCrawlerInRedis.Name = "btnCrawlerInRedis";
            this.btnCrawlerInRedis.Size = new System.Drawing.Size(235, 22);
            this.btnCrawlerInRedis.Text = "btnCrawlerInRedis";
            this.btnCrawlerInRedis.Click += new System.EventHandler(this.btnCrawlerInRedis_Click);
            // 
            // btnMapCategoryAndClassification
            // 
            this.btnMapCategoryAndClassification.Name = "btnMapCategoryAndClassification";
            this.btnMapCategoryAndClassification.Size = new System.Drawing.Size(235, 22);
            this.btnMapCategoryAndClassification.Text = "Map Category ~ Classification";
            this.btnMapCategoryAndClassification.Click += new System.EventHandler(this.btnMapCategoryAndClassification_Click);
            // 
            // btnPushQueueFindData
            // 
            this.btnPushQueueFindData.Name = "btnPushQueueFindData";
            this.btnPushQueueFindData.Size = new System.Drawing.Size(235, 22);
            this.btnPushQueueFindData.Text = "btnPushQueueFindData";
            this.btnPushQueueFindData.Click += new System.EventHandler(this.btnPushQueueFindData_Click);
            // 
            // btnMapCatAndClassAuto
            // 
            this.btnMapCatAndClassAuto.Name = "btnMapCatAndClassAuto";
            this.btnMapCatAndClassAuto.Size = new System.Drawing.Size(235, 22);
            this.btnMapCatAndClassAuto.Text = "MapCatAndClassAuto";
            this.btnMapCatAndClassAuto.Click += new System.EventHandler(this.btnMapCatAndClassAuto_Click);
            // 
            // btnViewProduct1
            // 
            this.btnViewProduct1.Name = "btnViewProduct1";
            this.btnViewProduct1.Size = new System.Drawing.Size(235, 22);
            this.btnViewProduct1.Text = "View Product 1";
            this.btnViewProduct1.Click += new System.EventHandler(this.btnViewProduct1_Click);
            // 
            // btnRemoveFailRegexProduct
            // 
            this.btnRemoveFailRegexProduct.Name = "btnRemoveFailRegexProduct";
            this.btnRemoveFailRegexProduct.Size = new System.Drawing.Size(235, 22);
            this.btnRemoveFailRegexProduct.Text = "RemoveFailRegexProduct";
            this.btnRemoveFailRegexProduct.Click += new System.EventHandler(this.btnRemoveFailRegexProduct_Click);
            // 
            // updateCategoryToolStripMenuItem
            // 
            this.updateCategoryToolStripMenuItem.Name = "updateCategoryToolStripMenuItem";
            this.updateCategoryToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.updateCategoryToolStripMenuItem.Text = "Update Category";
            this.updateCategoryToolStripMenuItem.Click += new System.EventHandler(this.updateCategoryToolStripMenuItem_Click);
            // 
            // btnPushCompanyInfoReset
            // 
            this.btnPushCompanyInfoReset.Name = "btnPushCompanyInfoReset";
            this.btnPushCompanyInfoReset.Size = new System.Drawing.Size(235, 22);
            this.btnPushCompanyInfoReset.Text = "Push_Company_ResetInfoWeb";
            this.btnPushCompanyInfoReset.Click += new System.EventHandler(this.btnPushCompanyInfoReset_Click);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBCom;
            // 
            // dBCom
            // 
            this.dBCom.DataSetName = "DBCom";
            this.dBCom.EnforceConstraints = false;
            this.dBCom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colDomain,
            this.colTotalProduct,
            this.colTotalNewProduct,
            this.colTotalValid,
            this.colNotVisibleProduct,
            this.colTimeDelay,
            this.colTotalQueue,
            this.colTotalVisited,
            this.colLastCheckTotalValid,
            this.colTotalViewMonth,
            this.gridColumn1,
            this.gridColumn2,
            this.colID1,
            this.colMaxValid,
            this.colLastCrawlerReload});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCheck
            // 
            this.colCheck.Caption = " ";
            this.colCheck.FieldName = "Check";
            this.colCheck.Name = "colCheck";
            this.colCheck.OptionsColumn.FixedWidth = true;
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            this.colCheck.Width = 24;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.OptionsColumn.FixedWidth = true;
            this.colDomain.OptionsColumn.ReadOnly = true;
            this.colDomain.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 2;
            this.colDomain.Width = 83;
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.Caption = "TotalProduct";
            this.colTotalProduct.ColumnEdit = this.repositoryItemTextEdit3;
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.OptionsColumn.AllowEdit = false;
            this.colTotalProduct.OptionsColumn.FixedWidth = true;
            this.colTotalProduct.OptionsColumn.ReadOnly = true;
            this.colTotalProduct.ToolTip = "Tổng sản phẩm web";
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 6;
            this.colTotalProduct.Width = 70;
            // 
            // colTotalNewProduct
            // 
            this.colTotalNewProduct.Caption = "TotalNewProduct";
            this.colTotalNewProduct.FieldName = "TotalNewProduct";
            this.colTotalNewProduct.MaxWidth = 70;
            this.colTotalNewProduct.MinWidth = 30;
            this.colTotalNewProduct.Name = "colTotalNewProduct";
            this.colTotalNewProduct.OptionsColumn.FixedWidth = true;
            this.colTotalNewProduct.ToolTip = "Tổng sản phẩm mới chờ duyệt";
            this.colTotalNewProduct.Visible = true;
            this.colTotalNewProduct.VisibleIndex = 3;
            this.colTotalNewProduct.Width = 40;
            // 
            // colTotalValid
            // 
            this.colTotalValid.Caption = "TotalValid";
            this.colTotalValid.ColumnEdit = this.repositoryItemTextEdit3;
            this.colTotalValid.FieldName = "TotalValid";
            this.colTotalValid.MinWidth = 50;
            this.colTotalValid.Name = "colTotalValid";
            this.colTotalValid.OptionsColumn.AllowEdit = false;
            this.colTotalValid.OptionsColumn.FixedWidth = true;
            this.colTotalValid.OptionsColumn.ReadOnly = true;
            this.colTotalValid.ToolTip = "Tổng sản phẩm dữ liệu ok";
            this.colTotalValid.Visible = true;
            this.colTotalValid.VisibleIndex = 4;
            this.colTotalValid.Width = 55;
            // 
            // colNotVisibleProduct
            // 
            this.colNotVisibleProduct.Caption = "NotVisibleProduct";
            this.colNotVisibleProduct.FieldName = "NotVisibleProduct";
            this.colNotVisibleProduct.Name = "colNotVisibleProduct";
            this.colNotVisibleProduct.Width = 20;
            // 
            // colTimeDelay
            // 
            this.colTimeDelay.Caption = "MaxValid";
            this.colTimeDelay.DisplayFormat.FormatString = "n0";
            this.colTimeDelay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTimeDelay.FieldName = "TimeDelay";
            this.colTimeDelay.Name = "colTimeDelay";
            this.colTimeDelay.OptionsColumn.FixedWidth = true;
            this.colTimeDelay.ToolTip = "Tổng sản phẩm lớn nhất đã được duyệt";
            this.colTimeDelay.Width = 66;
            // 
            // colTotalQueue
            // 
            this.colTotalQueue.Caption = "Queue";
            this.colTotalQueue.DisplayFormat.FormatString = "N0";
            this.colTotalQueue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalQueue.FieldName = "TotalQueue";
            this.colTotalQueue.Name = "colTotalQueue";
            this.colTotalQueue.OptionsColumn.AllowEdit = false;
            this.colTotalQueue.Visible = true;
            this.colTotalQueue.VisibleIndex = 12;
            this.colTotalQueue.Width = 20;
            // 
            // colTotalVisited
            // 
            this.colTotalVisited.Caption = "Visit";
            this.colTotalVisited.DisplayFormat.FormatString = "n0";
            this.colTotalVisited.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalVisited.FieldName = "TotalVisited";
            this.colTotalVisited.Name = "colTotalVisited";
            this.colTotalVisited.OptionsColumn.AllowEdit = false;
            this.colTotalVisited.OptionsColumn.FixedWidth = true;
            this.colTotalVisited.Visible = true;
            this.colTotalVisited.VisibleIndex = 13;
            this.colTotalVisited.Width = 44;
            // 
            // colLastCheckTotalValid
            // 
            this.colLastCheckTotalValid.Caption = "LastValid";
            this.colLastCheckTotalValid.DisplayFormat.FormatString = "n0";
            this.colLastCheckTotalValid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLastCheckTotalValid.FieldName = "LastCheckTotalValid";
            this.colLastCheckTotalValid.MinWidth = 50;
            this.colLastCheckTotalValid.Name = "colLastCheckTotalValid";
            this.colLastCheckTotalValid.OptionsColumn.AllowEdit = false;
            this.colLastCheckTotalValid.OptionsColumn.FixedWidth = true;
            this.colLastCheckTotalValid.OptionsColumn.ReadOnly = true;
            this.colLastCheckTotalValid.ToolTip = "Tổng sản phẩm lần cuối không duyệt được";
            this.colLastCheckTotalValid.Visible = true;
            this.colLastCheckTotalValid.VisibleIndex = 11;
            this.colLastCheckTotalValid.Width = 52;
            // 
            // colTotalViewMonth
            // 
            this.colTotalViewMonth.Caption = "Click/tháng";
            this.colTotalViewMonth.DisplayFormat.FormatString = "n0";
            this.colTotalViewMonth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalViewMonth.FieldName = "TotalViewMonth";
            this.colTotalViewMonth.Name = "colTotalViewMonth";
            this.colTotalViewMonth.OptionsColumn.FixedWidth = true;
            this.colTotalViewMonth.OptionsColumn.ReadOnly = true;
            this.colTotalViewMonth.Visible = true;
            this.colTotalViewMonth.VisibleIndex = 10;
            this.colTotalViewMonth.Width = 66;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "LastUpdateDatafeed";
            this.gridColumn1.DisplayFormat.FormatString = "HH:mm dd/MM/yyyy";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "LastUpdateDataFeed";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 109;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "LastUpdateSolr";
            this.gridColumn2.DisplayFormat.FormatString = "HH:mm dd/MM/yyyy";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "LastUpdateSolr";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 8;
            this.gridColumn2.Width = 100;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.MinWidth = 30;
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 1;
            this.colID1.Width = 30;
            // 
            // colMaxValid
            // 
            this.colMaxValid.FieldName = "MaxValid";
            this.colMaxValid.MinWidth = 50;
            this.colMaxValid.Name = "colMaxValid";
            this.colMaxValid.Visible = true;
            this.colMaxValid.VisibleIndex = 5;
            this.colMaxValid.Width = 77;
            // 
            // colLastCrawlerReload
            // 
            this.colLastCrawlerReload.Caption = "LastCrawlerReload";
            this.colLastCrawlerReload.DisplayFormat.FormatString = "dd/MM/yyy HH:mm:ss:ff";
            this.colLastCrawlerReload.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastCrawlerReload.FieldName = "LastCrawlerReload";
            this.colLastCrawlerReload.MinWidth = 70;
            this.colLastCrawlerReload.Name = "colLastCrawlerReload";
            this.colLastCrawlerReload.Visible = true;
            this.colLastCrawlerReload.VisibleIndex = 9;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.EnforceConstraints = false;
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyStatusBindingSource
            // 
            this.companyStatusBindingSource.DataMember = "Company_Status";
            this.companyStatusBindingSource.DataSource = this.dB;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barPage});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageList1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btFirst,
            this.btPrevious,
            this.txtPageCurrent,
            this.btNext,
            this.btEnd,
            this.cboCount,
            this.barEditItem1,
            this.barStaticItem1,
            this.btRunAllQueue,
            this.barStaticItem2,
            this.barLoadT});
            this.barManager1.MaxItemId = 18;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemGridLookUpEdit2});
            // 
            // barPage
            // 
            this.barPage.BarName = "Tools";
            this.barPage.DockCol = 0;
            this.barPage.DockRow = 0;
            this.barPage.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barPage.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.cboCount, "", false, true, true, 50),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btFirst),
            new DevExpress.XtraBars.LinkPersistInfo(this.btPrevious),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtPageCurrent),
            new DevExpress.XtraBars.LinkPersistInfo(this.btNext),
            new DevExpress.XtraBars.LinkPersistInfo(this.btEnd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btRunAllQueue),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLoadT)});
            this.barPage.OptionsBar.AllowQuickCustomization = false;
            this.barPage.OptionsBar.DisableClose = true;
            this.barPage.OptionsBar.DisableCustomization = true;
            this.barPage.OptionsBar.DrawDragBorder = false;
            this.barPage.Text = "Tools";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "__________________";
            this.barStaticItem2.Id = 16;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cboCount
            // 
            this.cboCount.Caption = "barEditItem3";
            this.cboCount.Edit = this.repositoryItemComboBox1;
            this.cboCount.EditValue = "20";
            this.cboCount.Id = 8;
            this.cboCount.Name = "cboCount";
            superToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipItem1.Text = "Chọn số lượng hiển thị";
            superToolTip1.Items.Add(toolTipItem1);
            this.cboCount.SuperTip = superToolTip1;
            this.cboCount.EditValueChanged += new System.EventHandler(this.cboCount_EditValueChanged);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.DropDownRows = 10;
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "25",
            "50",
            "100",
            "200",
            "400",
            "900000"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem1.Caption = "Page";
            this.barStaticItem1.Id = 14;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btFirst
            // 
            this.btFirst.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btFirst.Caption = "<<";
            this.btFirst.Id = 2;
            this.btFirst.Name = "btFirst";
            this.btFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btFirst_ItemClick);
            // 
            // btPrevious
            // 
            this.btPrevious.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btPrevious.Caption = "<";
            this.btPrevious.Id = 3;
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btPrevious_ItemClick);
            // 
            // txtPageCurrent
            // 
            this.txtPageCurrent.Caption = "barEditItem2";
            this.txtPageCurrent.Edit = this.repositoryItemTextEdit2;
            this.txtPageCurrent.EditValue = ((short)(1));
            this.txtPageCurrent.Id = 4;
            this.txtPageCurrent.Name = "txtPageCurrent";
            this.txtPageCurrent.Width = 30;
            this.txtPageCurrent.EditValueChanged += new System.EventHandler(this.txtPageCurrent_EditValueChanged);
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTextEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // btNext
            // 
            this.btNext.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btNext.Caption = ">";
            this.btNext.Id = 5;
            this.btNext.Name = "btNext";
            this.btNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btNext_ItemClick);
            // 
            // btEnd
            // 
            this.btEnd.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btEnd.Caption = ">>";
            this.btEnd.Id = 6;
            this.btEnd.Name = "btEnd";
            this.btEnd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btEnd_ItemClick);
            // 
            // btRunAllQueue
            // 
            this.btRunAllQueue.Caption = "RunAllQueue";
            this.btRunAllQueue.Id = 15;
            this.btRunAllQueue.Name = "btRunAllQueue";
            this.btRunAllQueue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btRunAllQueue_ItemClick);
            // 
            // barLoadT
            // 
            this.barLoadT.Caption = "Load-T";
            this.barLoadT.Id = 17;
            this.barLoadT.Name = "barLoadT";
            this.barLoadT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLoadT_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(871, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 462);
            this.barDockControlBottom.Size = new System.Drawing.Size(871, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 432);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(871, 30);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 432);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Delete.png");
            this.imageList1.Images.SetKeyName(1, "Refresh.png");
            this.imageList1.Images.SetKeyName(2, "Save.png");
            this.imageList1.Images.SetKeyName(3, "add.png");
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemGridLookUpEdit2;
            this.barEditItem1.Id = 11;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.companyStatusBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "Description";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "ID";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "<Nhập nội dung cần tìm>";
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "Đã config",
            "Chờ sử lý",
            "Không xác định",
            "Not product",
            "SP Gốc",
            "Tin",
            "Not Queue"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_RattingTableAdapter = null;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.Config_HaravanBizwebTableAdapter = null;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.MapClassificationTableAdapter = null;
            this.tableAdapterManager.ProductID_PropertyTableAdapter = null;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PropertyGroupTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // websiteLabel1
            // 
            this.websiteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Website", true));
            this.websiteLabel1.Location = new System.Drawing.Point(260, 207);
            this.websiteLabel1.Name = "websiteLabel1";
            this.websiteLabel1.Size = new System.Drawing.Size(100, 23);
            this.websiteLabel1.TabIndex = 7;
            this.websiteLabel1.Text = "label1";
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(260, 240);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 12;
            this.iDLabel1.Text = "label1";
            // 
            // company_StatusTableAdapter
            // 
            this.company_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.companyStatusBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "Description";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "ID";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // txtSearch
            // 
            this.txtSearch.EditValue = "Nhập tên domain/mô tả để tìm (ấn F1)";
            this.txtSearch.Location = new System.Drawing.Point(0, 27);
            this.txtSearch.MenuManager = this.barManager1;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(704, 20);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // checkCheckBox
            // 
            this.checkCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.companyBindingSource, "Check", true));
            this.checkCheckBox.Enabled = false;
            this.checkCheckBox.Location = new System.Drawing.Point(135, 304);
            this.checkCheckBox.Name = "checkCheckBox";
            this.checkCheckBox.Size = new System.Drawing.Size(104, 24);
            this.checkCheckBox.TabIndex = 22;
            this.checkCheckBox.Text = "checkBox1";
            this.checkCheckBox.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.companyBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btAdd,
            this.btDelete});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 304);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(862, 25);
            this.bindingNavigator1.TabIndex = 27;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Position";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(30, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btAdd
            // 
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(35, 22);
            this.btAdd.Text = "New";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(44, 22);
            this.btDelete.Text = "Delete";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // domainLabel1
            // 
            this.domainLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Domain", true));
            this.domainLabel1.Location = new System.Drawing.Point(480, 270);
            this.domainLabel1.Name = "domainLabel1";
            this.domainLabel1.Size = new System.Drawing.Size(100, 23);
            this.domainLabel1.TabIndex = 32;
            this.domainLabel1.Text = "label1";
            // 
            // companyTableAdapter1
            // 
            this.companyTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClassificationTableAdapter = null;
            this.tableAdapterManager1.Company_AddressTableAdapter = null;
            this.tableAdapterManager1.Company_ImageTableAdapter = null;
            this.tableAdapterManager1.Company1TableAdapter = null;
            this.tableAdapterManager1.CompanyTableAdapter = this.companyTableAdapter1;
            this.tableAdapterManager1.DatafeedConfigTableAdapter = null;
            this.tableAdapterManager1.HistoryDatafeedTableAdapter = null;
            this.tableAdapterManager1.Job_WebsiteConfigLogTableAdapter = null;
            this.tableAdapterManager1.ListClassificationTableAdapter = null;
            this.tableAdapterManager1.ManagerCompanyLogTableAdapter = null;
            this.tableAdapterManager1.ManagerCompanyLogTypeTableAdapter = null;
            this.tableAdapterManager1.ManagerCrawlerTableAdapter = null;
            this.tableAdapterManager1.ManagerTypeRCompanyTableAdapter = null;
            this.tableAdapterManager1.ManagerTypeTableAdapter = null;
            this.tableAdapterManager1.ProductQuangCaoTableAdapter = null;
            this.tableAdapterManager1.ProductTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QT.Moduls.Company.DBComTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statusLabel1
            // 
            this.statusLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Status", true));
            this.statusLabel1.Location = new System.Drawing.Point(455, 181);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(100, 23);
            this.statusLabel1.TabIndex = 37;
            this.statusLabel1.Text = "label1";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(3, 53);
            this.lookUpEdit1.MenuManager = this.barManager1;
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Des", "Des", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STT", "STT", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.lookUpEdit1.Properties.DataSource = this.managerTypeBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "Name";
            this.lookUpEdit1.Properties.DropDownRows = 40;
            this.lookUpEdit1.Properties.PopupFormMinSize = new System.Drawing.Size(250, 0);
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(114, 20);
            this.lookUpEdit1.TabIndex = 42;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // managerTypeBindingSource
            // 
            this.managerTypeBindingSource.DataMember = "ManagerType";
            this.managerTypeBindingSource.DataSource = this.dBCom;
            // 
            // managerTypeTableAdapter
            // 
            this.managerTypeTableAdapter.ClearBeforeFill = true;
            // 
            // btRunQueue
            // 
            this.btRunQueue.Location = new System.Drawing.Point(27, 197);
            this.btRunQueue.Name = "btRunQueue";
            this.btRunQueue.Size = new System.Drawing.Size(70, 23);
            this.btRunQueue.TabIndex = 47;
            this.btRunQueue.Text = "RunAllQueue";
            this.btRunQueue.Click += new System.EventHandler(this.btRunQueue_Click);
            // 
            // btAllHistory
            // 
            this.btAllHistory.Location = new System.Drawing.Point(103, 197);
            this.btAllHistory.Name = "btAllHistory";
            this.btAllHistory.Size = new System.Drawing.Size(72, 23);
            this.btAllHistory.TabIndex = 47;
            this.btAllHistory.Text = "RunAllHistory";
            this.btAllHistory.Click += new System.EventHandler(this.btAllHistory_Click);
            // 
            // luCompanyStatus
            // 
            this.luCompanyStatus.Location = new System.Drawing.Point(3, 3);
            this.luCompanyStatus.Name = "luCompanyStatus";
            this.luCompanyStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luCompanyStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STT", "STT", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luCompanyStatus.Properties.DataSource = this.companyStatusBindingSource;
            this.luCompanyStatus.Properties.DisplayMember = "Description";
            this.luCompanyStatus.Properties.DropDownRows = 15;
            this.luCompanyStatus.Properties.ValueMember = "ID";
            this.luCompanyStatus.Size = new System.Drawing.Size(99, 20);
            this.luCompanyStatus.TabIndex = 42;
            this.luCompanyStatus.EditValueChanged += new System.EventHandler(this.luCompanyStatus_EditValueChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(1, 103);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(870, 358);
            this.xtraTabControl1.TabIndex = 52;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.tabCrawler,
            this.xtraTabPage2,
            this.ListError,
            this.xtraTabPageRpMinLastRL});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Controls.Add(this.bindingNavigator1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(862, 329);
            this.xtraTabPage1.Text = "ListWebsite";
            // 
            // tabCrawler
            // 
            this.tabCrawler.Controls.Add(this.gridControl2);
            this.tabCrawler.Name = "tabCrawler";
            this.tabCrawler.Size = new System.Drawing.Size(862, 329);
            this.tabCrawler.Text = "ListCrawler";
            // 
            // gridControl2
            // 
            this.gridControl2.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl2.DataSource = this.viewManagerCrawlerBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(862, 329);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // viewManagerCrawlerBindingSource
            // 
            this.viewManagerCrawlerBindingSource.DataMember = "ViewManagerCrawler";
            this.viewManagerCrawlerBindingSource.DataSource = this.dBCom;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNameType,
            this.colNameCommand,
            this.colOnline,
            this.colLastUpdate,
            this.colComment});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNameCommand, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colNameType
            // 
            this.colNameType.FieldName = "NameType";
            this.colNameType.Name = "colNameType";
            this.colNameType.OptionsColumn.FixedWidth = true;
            this.colNameType.Visible = true;
            this.colNameType.VisibleIndex = 0;
            this.colNameType.Width = 114;
            // 
            // colNameCommand
            // 
            this.colNameCommand.FieldName = "NameCommand";
            this.colNameCommand.Name = "colNameCommand";
            this.colNameCommand.Visible = true;
            this.colNameCommand.VisibleIndex = 2;
            this.colNameCommand.Width = 191;
            // 
            // colOnline
            // 
            this.colOnline.FieldName = "Online";
            this.colOnline.Name = "colOnline";
            this.colOnline.OptionsColumn.FixedWidth = true;
            this.colOnline.Visible = true;
            this.colOnline.VisibleIndex = 2;
            this.colOnline.Width = 69;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.DisplayFormat.FormatString = "hh:mm:ss - dd/MM";
            this.colLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.OptionsColumn.FixedWidth = true;
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 3;
            this.colLastUpdate.Width = 70;
            // 
            // colComment
            // 
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Visible = true;
            this.colComment.VisibleIndex = 1;
            this.colComment.Width = 297;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.AutoScroll = true;
            this.xtraTabPage2.Controls.Add(this.bindingNavigator2);
            this.xtraTabPage2.Controls.Add(this.company1GridControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(862, 329);
            this.xtraTabPage2.Text = "ListErrorConfig";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.company1BindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 304);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(862, 25);
            this.bindingNavigator2.TabIndex = 1;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // company1BindingSource
            // 
            this.company1BindingSource.DataMember = "Company1";
            this.company1BindingSource.DataSource = this.dBCom;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // company1GridControl
            // 
            this.company1GridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.company1GridControl.DataSource = this.company1BindingSource;
            this.company1GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.company1GridControl.Location = new System.Drawing.Point(0, 0);
            this.company1GridControl.MainView = this.gridView3;
            this.company1GridControl.MenuManager = this.barManager1;
            this.company1GridControl.Name = "company1GridControl";
            this.company1GridControl.Size = new System.Drawing.Size(862, 329);
            this.company1GridControl.TabIndex = 0;
            this.company1GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDanhMuc,
            this.colName1,
            this.colDomain1,
            this.colTotalValid1,
            this.colTheoDoi});
            this.gridView3.GridControl = this.company1GridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colDanhMuc
            // 
            this.colDanhMuc.FieldName = "DanhMuc";
            this.colDanhMuc.Name = "colDanhMuc";
            this.colDanhMuc.Visible = true;
            this.colDanhMuc.VisibleIndex = 1;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 2;
            // 
            // colDomain1
            // 
            this.colDomain1.FieldName = "Domain";
            this.colDomain1.Name = "colDomain1";
            this.colDomain1.Visible = true;
            this.colDomain1.VisibleIndex = 3;
            // 
            // colTotalValid1
            // 
            this.colTotalValid1.FieldName = "TotalValid";
            this.colTotalValid1.Name = "colTotalValid1";
            this.colTotalValid1.Visible = true;
            this.colTotalValid1.VisibleIndex = 4;
            // 
            // colTheoDoi
            // 
            this.colTheoDoi.FieldName = "TheoDoi";
            this.colTheoDoi.Name = "colTheoDoi";
            this.colTheoDoi.Visible = true;
            this.colTheoDoi.VisibleIndex = 5;
            // 
            // ListError
            // 
            this.ListError.Controls.Add(this.grvListNeedRepair);
            this.ListError.Name = "ListError";
            this.ListError.Size = new System.Drawing.Size(862, 329);
            this.ListError.Text = "ListNeedRepairConfig";
            // 
            // grvListNeedRepair
            // 
            this.grvListNeedRepair.Cursor = System.Windows.Forms.Cursors.Default;
            this.grvListNeedRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvListNeedRepair.Location = new System.Drawing.Point(0, 0);
            this.grvListNeedRepair.MainView = this.gridView4;
            this.grvListNeedRepair.MenuManager = this.barManager1;
            this.grvListNeedRepair.Name = "grvListNeedRepair";
            this.grvListNeedRepair.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkFixed});
            this.grvListNeedRepair.Size = new System.Drawing.Size(862, 329);
            this.grvListNeedRepair.TabIndex = 0;
            this.grvListNeedRepair.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.grvListNeedRepair.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grvListNeedRepair_MouseDoubleClick);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Fixed,
            this.colCompanyID,
            this.Domain,
            this.colWebsite,
            this.TotalValid,
            this.MaxValid,
            this.LastCheckConfig,
            this.LastRepairConfig});
            this.gridView4.GridControl = this.grvListNeedRepair;
            this.gridView4.IndicatorWidth = 30;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView4_CustomDrawRowIndicator);
            // 
            // Fixed
            // 
            this.Fixed.Caption = "Fixed";
            this.Fixed.ColumnEdit = this.repositoryItemHyperLinkFixed;
            this.Fixed.MaxWidth = 30;
            this.Fixed.Name = "Fixed";
            this.Fixed.Visible = true;
            this.Fixed.VisibleIndex = 0;
            this.Fixed.Width = 30;
            // 
            // repositoryItemHyperLinkFixed
            // 
            this.repositoryItemHyperLinkFixed.AutoHeight = false;
            this.repositoryItemHyperLinkFixed.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemHyperLinkFixed.Image")));
            this.repositoryItemHyperLinkFixed.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemHyperLinkFixed.Name = "repositoryItemHyperLinkFixed";
            // 
            // colCompanyID
            // 
            this.colCompanyID.Caption = "CompanyID";
            this.colCompanyID.FieldName = "ID";
            this.colCompanyID.MaxWidth = 50;
            this.colCompanyID.Name = "colCompanyID";
            this.colCompanyID.OptionsColumn.ReadOnly = true;
            this.colCompanyID.Visible = true;
            this.colCompanyID.VisibleIndex = 1;
            this.colCompanyID.Width = 50;
            // 
            // Domain
            // 
            this.Domain.Caption = "Domain";
            this.Domain.FieldName = "Domain";
            this.Domain.MaxWidth = 70;
            this.Domain.Name = "Domain";
            this.Domain.OptionsColumn.ReadOnly = true;
            this.Domain.Visible = true;
            this.Domain.VisibleIndex = 2;
            this.Domain.Width = 50;
            // 
            // colWebsite
            // 
            this.colWebsite.Caption = "Website";
            this.colWebsite.FieldName = "Website";
            this.colWebsite.MaxWidth = 70;
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.OptionsColumn.ReadOnly = true;
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 3;
            this.colWebsite.Width = 50;
            // 
            // TotalValid
            // 
            this.TotalValid.Caption = "TotalValid";
            this.TotalValid.FieldName = "TotalValid";
            this.TotalValid.MaxWidth = 50;
            this.TotalValid.Name = "TotalValid";
            this.TotalValid.OptionsColumn.ReadOnly = true;
            this.TotalValid.Visible = true;
            this.TotalValid.VisibleIndex = 4;
            this.TotalValid.Width = 30;
            // 
            // MaxValid
            // 
            this.MaxValid.Caption = "MaxValid";
            this.MaxValid.FieldName = "MaxValid";
            this.MaxValid.MaxWidth = 50;
            this.MaxValid.Name = "MaxValid";
            this.MaxValid.OptionsColumn.ReadOnly = true;
            this.MaxValid.Visible = true;
            this.MaxValid.VisibleIndex = 5;
            this.MaxValid.Width = 30;
            // 
            // LastCheckConfig
            // 
            this.LastCheckConfig.Caption = "LastCheckConfig";
            this.LastCheckConfig.DisplayFormat.FormatString = "dd/MM/yyy HH:mm:ss:ff";
            this.LastCheckConfig.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.LastCheckConfig.FieldName = "LastCheckConfig";
            this.LastCheckConfig.Name = "LastCheckConfig";
            this.LastCheckConfig.OptionsColumn.ReadOnly = true;
            this.LastCheckConfig.Visible = true;
            this.LastCheckConfig.VisibleIndex = 6;
            // 
            // LastRepairConfig
            // 
            this.LastRepairConfig.Caption = "LastRepairConfig";
            this.LastRepairConfig.DisplayFormat.FormatString = "dd/MM/yyy HH:mm:ss:ff";
            this.LastRepairConfig.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.LastRepairConfig.FieldName = "LastRepairConfig";
            this.LastRepairConfig.Name = "LastRepairConfig";
            this.LastRepairConfig.OptionsColumn.ReadOnly = true;
            this.LastRepairConfig.Visible = true;
            this.LastRepairConfig.VisibleIndex = 7;
            // 
            // xtraTabPageRpMinLastRL
            // 
            this.xtraTabPageRpMinLastRL.Controls.Add(this.panelControl2);
            this.xtraTabPageRpMinLastRL.Controls.Add(this.panelControl1);
            this.xtraTabPageRpMinLastRL.Name = "xtraTabPageRpMinLastRL";
            this.xtraTabPageRpMinLastRL.Size = new System.Drawing.Size(862, 329);
            this.xtraTabPageRpMinLastRL.Text = "RpMinLastRL";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlRpMinLastRL);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 61);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(862, 268);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControlRpMinLastRL
            // 
            this.gridControlRpMinLastRL.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlRpMinLastRL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRpMinLastRL.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlRpMinLastRL.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlRpMinLastRL.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlRpMinLastRL.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlRpMinLastRL.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlRpMinLastRL.Location = new System.Drawing.Point(2, 2);
            this.gridControlRpMinLastRL.MainView = this.gridView5;
            this.gridControlRpMinLastRL.MenuManager = this.barManager1;
            this.gridControlRpMinLastRL.Name = "gridControlRpMinLastRL";
            this.gridControlRpMinLastRL.Size = new System.Drawing.Size(858, 264);
            this.gridControlRpMinLastRL.TabIndex = 0;
            this.gridControlRpMinLastRL.UseEmbeddedNavigator = true;
            this.gridControlRpMinLastRL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRpID,
            this.colRpDomain,
            this.colRpMinLastUpdate,
            this.colRpTotalProduct,
            this.colRpTotalValid,
            this.colRpMaxValid,
            this.colRpMinHourRecrawl,
            this.colRpTimeDelay,
            this.colRpLastCrawlerReload,
            this.colRpTotalNewProduct,
            this.colRpLastEndCrawlerReload,
            this.colRpLastJobCrawlerReload});
            this.gridView5.GridControl = this.gridControlRpMinLastRL;
            this.gridView5.IndicatorWidth = 30;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsSelection.MultiSelect = true;
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView5_CustomDrawRowIndicator);
            // 
            // colRpID
            // 
            this.colRpID.Caption = "ID";
            this.colRpID.FieldName = "ID";
            this.colRpID.Name = "colRpID";
            this.colRpID.Visible = true;
            this.colRpID.VisibleIndex = 0;
            // 
            // colRpDomain
            // 
            this.colRpDomain.Caption = "Domain";
            this.colRpDomain.FieldName = "Domain";
            this.colRpDomain.Name = "colRpDomain";
            this.colRpDomain.Visible = true;
            this.colRpDomain.VisibleIndex = 1;
            // 
            // colRpMinLastUpdate
            // 
            this.colRpMinLastUpdate.Caption = "MinLastUpdate";
            this.colRpMinLastUpdate.DisplayFormat.FormatString = "dd/MM/yyy HH:mm:ss:ff";
            this.colRpMinLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRpMinLastUpdate.FieldName = "MinLastUpdate";
            this.colRpMinLastUpdate.Name = "colRpMinLastUpdate";
            this.colRpMinLastUpdate.Visible = true;
            this.colRpMinLastUpdate.VisibleIndex = 8;
            // 
            // colRpTotalProduct
            // 
            this.colRpTotalProduct.Caption = "TotalProduct";
            this.colRpTotalProduct.FieldName = "TotalProduct";
            this.colRpTotalProduct.Name = "colRpTotalProduct";
            this.colRpTotalProduct.Visible = true;
            this.colRpTotalProduct.VisibleIndex = 2;
            // 
            // colRpTotalValid
            // 
            this.colRpTotalValid.Caption = "TotalValid";
            this.colRpTotalValid.FieldName = "TotalValid";
            this.colRpTotalValid.Name = "colRpTotalValid";
            this.colRpTotalValid.Visible = true;
            this.colRpTotalValid.VisibleIndex = 3;
            // 
            // colRpMaxValid
            // 
            this.colRpMaxValid.Caption = "MaxValid";
            this.colRpMaxValid.FieldName = "MaxValid";
            this.colRpMaxValid.Name = "colRpMaxValid";
            this.colRpMaxValid.Visible = true;
            this.colRpMaxValid.VisibleIndex = 5;
            // 
            // colRpMinHourRecrawl
            // 
            this.colRpMinHourRecrawl.Caption = "MinHourRecrawl";
            this.colRpMinHourRecrawl.FieldName = "MinHourRecrawl";
            this.colRpMinHourRecrawl.Name = "colRpMinHourRecrawl";
            this.colRpMinHourRecrawl.Visible = true;
            this.colRpMinHourRecrawl.VisibleIndex = 6;
            // 
            // colRpTimeDelay
            // 
            this.colRpTimeDelay.Caption = "TimeDelay";
            this.colRpTimeDelay.FieldName = "TimeDelay";
            this.colRpTimeDelay.Name = "colRpTimeDelay";
            this.colRpTimeDelay.Visible = true;
            this.colRpTimeDelay.VisibleIndex = 7;
            // 
            // colRpLastCrawlerReload
            // 
            this.colRpLastCrawlerReload.Caption = "LastCrawlerReload";
            this.colRpLastCrawlerReload.DisplayFormat.FormatString = "dd/MM/yyy HH:mm:ss:ff";
            this.colRpLastCrawlerReload.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRpLastCrawlerReload.FieldName = "LastCrawlerReload";
            this.colRpLastCrawlerReload.Name = "colRpLastCrawlerReload";
            this.colRpLastCrawlerReload.Visible = true;
            this.colRpLastCrawlerReload.VisibleIndex = 9;
            // 
            // colRpTotalNewProduct
            // 
            this.colRpTotalNewProduct.Caption = "TotalNewProduct";
            this.colRpTotalNewProduct.FieldName = "TotalNewProduct";
            this.colRpTotalNewProduct.Name = "colRpTotalNewProduct";
            this.colRpTotalNewProduct.Visible = true;
            this.colRpTotalNewProduct.VisibleIndex = 4;
            // 
            // colRpLastEndCrawlerReload
            // 
            this.colRpLastEndCrawlerReload.Caption = "LastEndCrawlerReload";
            this.colRpLastEndCrawlerReload.DisplayFormat.FormatString = "dd/MM/yyy HH:mm:ss:ff";
            this.colRpLastEndCrawlerReload.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRpLastEndCrawlerReload.FieldName = "LastEndCrawlerReload";
            this.colRpLastEndCrawlerReload.Name = "colRpLastEndCrawlerReload";
            this.colRpLastEndCrawlerReload.Visible = true;
            this.colRpLastEndCrawlerReload.VisibleIndex = 10;
            // 
            // colRpLastJobCrawlerReload
            // 
            this.colRpLastJobCrawlerReload.Caption = "LastJobCrawlerReload";
            this.colRpLastJobCrawlerReload.DisplayFormat.FormatString = "dd/MM/yyy HH:mm:ss:ff";
            this.colRpLastJobCrawlerReload.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colRpLastJobCrawlerReload.FieldName = "LastJobCrawlerReload";
            this.colRpLastJobCrawlerReload.Name = "colRpLastJobCrawlerReload";
            this.colRpLastJobCrawlerReload.Visible = true;
            this.colRpLastJobCrawlerReload.VisibleIndex = 11;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLoadData);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(862, 61);
            this.panelControl1.TabIndex = 0;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(221, 18);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CkVipCom);
            this.groupBox1.Controls.Add(this.CkAllCom);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CkVipCom
            // 
            this.CkVipCom.AutoSize = true;
            this.CkVipCom.Checked = true;
            this.CkVipCom.Location = new System.Drawing.Point(115, 16);
            this.CkVipCom.Name = "CkVipCom";
            this.CkVipCom.Size = new System.Drawing.Size(87, 17);
            this.CkVipCom.TabIndex = 2;
            this.CkVipCom.TabStop = true;
            this.CkVipCom.Text = "Vip Company";
            this.CkVipCom.UseVisualStyleBackColor = true;
            // 
            // CkAllCom
            // 
            this.CkAllCom.AutoSize = true;
            this.CkAllCom.Location = new System.Drawing.Point(7, 16);
            this.CkAllCom.Name = "CkAllCom";
            this.CkAllCom.Size = new System.Drawing.Size(83, 17);
            this.CkAllCom.TabIndex = 1;
            this.CkAllCom.Text = "All Company";
            this.CkAllCom.UseVisualStyleBackColor = true;
            // 
            // btnViewCount
            // 
            this.btnViewCount.Location = new System.Drawing.Point(123, 77);
            this.btnViewCount.Name = "btnViewCount";
            this.btnViewCount.Size = new System.Drawing.Size(85, 23);
            this.btnViewCount.TabIndex = 30;
            this.btnViewCount.Text = "View Count";
            this.btnViewCount.Click += new System.EventHandler(this.btnViewCount_Click);
            // 
            // lblCountSelected
            // 
            this.lblCountSelected.Location = new System.Drawing.Point(255, 82);
            this.lblCountSelected.Name = "lblCountSelected";
            this.lblCountSelected.Size = new System.Drawing.Size(20, 13);
            this.lblCountSelected.TabIndex = 29;
            this.lblCountSelected.Text = "-----";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(216, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Count:";
            // 
            // viewManagerCrawlerTableAdapter
            // 
            this.viewManagerCrawlerTableAdapter.ClearBeforeFill = true;
            // 
            // btLoadManagerCrawler
            // 
            this.btLoadManagerCrawler.Location = new System.Drawing.Point(368, 51);
            this.btLoadManagerCrawler.Name = "btLoadManagerCrawler";
            this.btLoadManagerCrawler.Size = new System.Drawing.Size(52, 23);
            this.btLoadManagerCrawler.TabIndex = 47;
            this.btLoadManagerCrawler.Text = "LoadRun";
            this.btLoadManagerCrawler.Click += new System.EventHandler(this.btLoadManagerCrawler_Click);
            // 
            // btLoadDistinct
            // 
            this.btLoadDistinct.Location = new System.Drawing.Point(295, 51);
            this.btLoadDistinct.Name = "btLoadDistinct";
            this.btLoadDistinct.Size = new System.Drawing.Size(67, 23);
            this.btLoadDistinct.TabIndex = 47;
            this.btLoadDistinct.Text = "LoadDistinct";
            this.btLoadDistinct.Click += new System.EventHandler(this.btLoadDistinct_Click);
            // 
            // btnNotShowProduct
            // 
            this.btnNotShowProduct.Location = new System.Drawing.Point(507, 51);
            this.btnNotShowProduct.Name = "btnNotShowProduct";
            this.btnNotShowProduct.Size = new System.Drawing.Size(90, 23);
            this.btnNotShowProduct.TabIndex = 57;
            this.btnNotShowProduct.Text = "NotShowProduct";
            this.btnNotShowProduct.Click += new System.EventHandler(this.btnNotShowProduct_Click);
            // 
            // company1TableAdapter
            // 
            this.company1TableAdapter.ClearBeforeFill = true;
            // 
            // btnLoadErrorConfig
            // 
            this.btnLoadErrorConfig.Location = new System.Drawing.Point(123, 51);
            this.btnLoadErrorConfig.Name = "btnLoadErrorConfig";
            this.btnLoadErrorConfig.Size = new System.Drawing.Size(85, 23);
            this.btnLoadErrorConfig.TabIndex = 62;
            this.btnLoadErrorConfig.Text = "LoadErrorConfig";
            this.btnLoadErrorConfig.Click += new System.EventHandler(this.btnLoadErrorConfig_Click);
            // 
            // btnNeedRepair
            // 
            this.btnNeedRepair.Location = new System.Drawing.Point(214, 51);
            this.btnNeedRepair.Name = "btnNeedRepair";
            this.btnNeedRepair.Size = new System.Drawing.Size(75, 23);
            this.btnNeedRepair.TabIndex = 67;
            this.btnNeedRepair.Text = "NeedRepair";
            this.btnNeedRepair.Click += new System.EventHandler(this.btnNeedRepair_Click);
            // 
            // btnRpMinLastRL
            // 
            this.btnRpMinLastRL.Location = new System.Drawing.Point(426, 51);
            this.btnRpMinLastRL.Name = "btnRpMinLastRL";
            this.btnRpMinLastRL.Size = new System.Drawing.Size(75, 23);
            this.btnRpMinLastRL.TabIndex = 2;
            this.btnRpMinLastRL.Text = "RpMinLastRL";
            this.btnRpMinLastRL.Click += new System.EventHandler(this.btnRpMinLastRL_Click);
            // 
            // ctrListWebSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewCount);
            this.Controls.Add(this.lblCountSelected);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnRpMinLastRL);
            this.Controls.Add(this.btnNeedRepair);
            this.Controls.Add(this.btnLoadErrorConfig);
            this.Controls.Add(this.btnNotShowProduct);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btAllHistory);
            this.Controls.Add(this.btRunQueue);
            this.Controls.Add(this.btLoadManagerCrawler);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.btLoadDistinct);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.luCompanyStatus);
            this.Controls.Add(this.statusLabel1);
            this.Controls.Add(domainLabel);
            this.Controls.Add(this.domainLabel1);
            this.Controls.Add(checkLabel);
            this.Controls.Add(this.checkCheckBox);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDLabel1);
            this.Controls.Add(websiteLabel);
            this.Controls.Add(this.websiteLabel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ctrListWebSite";
            this.Size = new System.Drawing.Size(871, 462);
            this.Load += new System.EventHandler(this.ctrListWebSite_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.ctrListWebSite_ControlRemoved);
            this.Resize += new System.EventHandler(this.ctrListWebSite_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luCompanyStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.tabCrawler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewManagerCrawlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.company1GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ListError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvListNeedRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkFixed)).EndInit();
            this.xtraTabPageRpMinLastRL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRpMinLastRL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DB dB;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barPage;
        //private DevExpress.XtraBars.BarEditItem txtSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btFirst;
        private DevExpress.XtraBars.BarButtonItem btPrevious;
        private DevExpress.XtraBars.BarEditItem txtPageCurrent;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarButtonItem btNext;
        private DevExpress.XtraBars.BarButtonItem btEnd;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraBars.BarEditItem cboCount;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setStatusNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem unCheckedAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NotProductToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private System.Windows.Forms.ToolStripMenuItem viewWebToolStripMenuItem;
        private System.Windows.Forms.Label websiteLabel1;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem notAvailableToolStripMenuItem;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.BindingSource companyStatusBindingSource;
        private DBTableAdapters.Company_StatusTableAdapter company_StatusTableAdapter;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private System.Windows.Forms.ToolStripMenuItem addNewWebToolStripMenuItem;
        public System.Windows.Forms.CheckBox checkCheckBox;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.ToolStripMenuItem viewProductToolStripMenuItem;
        private System.Windows.Forms.Label domainLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAllImageToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValid;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQueue;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalVisited;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarButtonItem btRunAllQueue;
        private System.Windows.Forms.ToolStripMenuItem loadImageĐãValidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAllImageValidToolStripMenuItem;
        private Company.DBCom dBCom;
        private Company.DBComTableAdapters.CompanyTableAdapter companyTableAdapter1;
        public System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.ToolStripButton btDelete;
        private System.Windows.Forms.Label statusLabel1;
        private Company.DBComTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.BindingSource managerTypeBindingSource;
        private Company.DBComTableAdapters.ManagerTypeTableAdapter managerTypeTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btRunQueue;
        private DevExpress.XtraEditors.SimpleButton btAllHistory;
        private DevExpress.XtraEditors.LookUpEdit luCompanyStatus;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCheckTotalValid;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeDelay;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage tabCrawler;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource viewManagerCrawlerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNameType;
        private DevExpress.XtraGrid.Columns.GridColumn colNameCommand;
        private DevExpress.XtraGrid.Columns.GridColumn colOnline;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private Company.DBComTableAdapters.ViewManagerCrawlerTableAdapter viewManagerCrawlerTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btLoadManagerCrawler;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;
        private DevExpress.XtraEditors.SimpleButton btLoadDistinct;
        private System.Windows.Forms.ToolStripMenuItem viewQuangCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewThongKeLuotClick;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalViewMonth;
        private System.Windows.Forms.ToolStripMenuItem menuItemExportExcel;
        private DevExpress.XtraBars.BarButtonItem barLoadT;
        private System.Windows.Forms.ToolStripMenuItem AddNewProductMerchanttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCrawlerByQueue;
        private System.Windows.Forms.ToolStripMenuItem btnCrawlerInRedis;
        private System.Windows.Forms.ToolStripMenuItem btnMapCategoryAndClassification;
        private System.Windows.Forms.ToolStripMenuItem btnPushQueueFindData;
        private DevExpress.XtraEditors.SimpleButton btnNotShowProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNewProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colNotVisibleProduct;
        private System.Windows.Forms.ToolStripMenuItem btnMapCatAndClassAuto;
        private DevExpress.XtraEditors.SimpleButton btnLoadErrorConfig;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl company1GridControl;
        private System.Windows.Forms.BindingSource company1BindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private Company.DBComTableAdapters.Company1TableAdapter company1TableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValid1;
        private DevExpress.XtraGrid.Columns.GridColumn colTheoDoi;
        private System.Windows.Forms.ToolStripMenuItem btnViewProduct1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnNeedRepair;
        private DevExpress.XtraTab.XtraTabPage ListError;
        private DevExpress.XtraGrid.GridControl grvListNeedRepair;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn Domain;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn TotalValid;
        private DevExpress.XtraGrid.Columns.GridColumn MaxValid;
        private DevExpress.XtraGrid.Columns.GridColumn LastCheckConfig;
        private DevExpress.XtraGrid.Columns.GridColumn LastRepairConfig;
        private DevExpress.XtraGrid.Columns.GridColumn Fixed;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkFixed;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private System.Windows.Forms.ToolStripMenuItem btnHistoryCrawlerData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pushIsNewToQueueImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crawlerReloadNoValidToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btnRpMinLastRL;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageRpMinLastRL;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CkVipCom;
        private System.Windows.Forms.RadioButton CkAllCom;
        private DevExpress.XtraGrid.GridControl gridControlRpMinLastRL;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colRpID;
        private DevExpress.XtraGrid.Columns.GridColumn colRpDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colRpMinLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colRpTotalProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colRpTotalValid;
        private DevExpress.XtraGrid.Columns.GridColumn colRpMaxValid;
        private DevExpress.XtraGrid.Columns.GridColumn colRpMinHourRecrawl;
        private DevExpress.XtraGrid.Columns.GridColumn colRpTimeDelay;
        private DevExpress.XtraGrid.Columns.GridColumn colRpLastCrawlerReload;
        private DevExpress.XtraGrid.Columns.GridColumn colRpTotalNewProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colRpLastEndCrawlerReload;
        private DevExpress.XtraGrid.Columns.GridColumn colRpLastJobCrawlerReload;
        private System.Windows.Forms.ToolStripMenuItem pushCompanyDownloadImageToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxValid;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCrawlerReload;
        private System.Windows.Forms.ToolStripMenuItem btnRemoveFailRegexProduct;
        private DevExpress.XtraEditors.SimpleButton btnViewCount;
        private DevExpress.XtraEditors.LabelControl lblCountSelected;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStripMenuItem copyDomainToClipboadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnPushCompanyInfoReset;
    }
}
