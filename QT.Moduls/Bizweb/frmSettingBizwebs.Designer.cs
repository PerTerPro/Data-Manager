namespace QT.Moduls.Bizweb
{
    partial class frmSettingBizwebs
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
            System.Windows.Forms.Label companyIdBizwebLabel;
            System.Windows.Forms.Label shopNameLabel;
            System.Windows.Forms.Label domainChinhXacLabel;
            System.Windows.Forms.Label accessTokenLabel;
            System.Windows.Forms.Label companyIdWSSLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label domainLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label domainLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingBizwebs));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.company_BizwebGridControl = new DevExpress.XtraGrid.GridControl();
            this.company_BizwebBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBBizweb = new QT.Moduls.Bizweb.DBBizweb();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyIdBizweb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyIdWSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomainChinhXac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccessToken = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPublic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefreshData = new System.Windows.Forms.ToolStripButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.companyIdWSSTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.accessTokenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.domainChinhXacTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.shopNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.companyIdBizwebTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageProduct = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
            this.gridViewProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonUpdateProduct = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonTestProduct = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPageProductInSQL = new DevExpress.XtraTab.XtraTabPage();
            this.productGridControl = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassificationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarranty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPromotion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageUrls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastPriceChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNews = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHashName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImagePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContentFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDownloadError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageWidth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageHeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategorySTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceChangeWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVATInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPromotionInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonLoadProductInSql = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPageUpdateDomain = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlCompany = new DevExpress.XtraGrid.GridControl();
            this.companySearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.domainCompanySearchTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.iDCompanySearchTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControlCheckDomain = new DevExpress.XtraEditors.LabelControl();
            this.ButtonCheckCompanyByDomain = new DevExpress.XtraEditors.SimpleButton();
            this.textEditDomainCheck = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonSaveCompany = new DevExpress.XtraEditors.SimpleButton();
            this.statusCompanyLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domainCompanyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.websiteCompanyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameCompanyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.iDCompanyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.company_BizwebTableAdapter = new QT.Moduls.Bizweb.DBBizwebTableAdapters.Company_BizwebTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Bizweb.DBBizwebTableAdapters.TableAdapterManager();
            this.companyTableAdapter = new QT.Moduls.Bizweb.DBBizwebTableAdapters.CompanyTableAdapter();
            this.company_StatusTableAdapter = new QT.Moduls.Bizweb.DBBizwebTableAdapters.Company_StatusTableAdapter();
            this.companySearchTableAdapter = new QT.Moduls.Bizweb.DBBizwebTableAdapters.CompanySearchTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemUpdateDomain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUnPublicStore = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemUpdateByCurrentDomain = new System.Windows.Forms.ToolStripMenuItem();
            this.productTableAdapter = new QT.Moduls.Bizweb.DBBizwebTableAdapters.ProductTableAdapter();
            companyIdBizwebLabel = new System.Windows.Forms.Label();
            shopNameLabel = new System.Windows.Forms.Label();
            domainChinhXacLabel = new System.Windows.Forms.Label();
            accessTokenLabel = new System.Windows.Forms.Label();
            companyIdWSSLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            domainLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_BizwebGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_BizwebBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBizweb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyIdWSSTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessTokenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainChinhXacTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyIdBizwebTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.xtraTabPageProductInSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            this.xtraTabPageUpdateDomain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainCompanySearchTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDCompanySearchTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDomainCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCompanyLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainCompanyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteCompanyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameCompanyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDCompanyTextEdit.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyIdBizwebLabel
            // 
            companyIdBizwebLabel.AutoSize = true;
            companyIdBizwebLabel.Location = new System.Drawing.Point(7, 19);
            companyIdBizwebLabel.Name = "companyIdBizwebLabel";
            companyIdBizwebLabel.Size = new System.Drawing.Size(103, 13);
            companyIdBizwebLabel.TabIndex = 0;
            companyIdBizwebLabel.Text = "Company Id Bizweb:";
            // 
            // shopNameLabel
            // 
            shopNameLabel.AutoSize = true;
            shopNameLabel.Location = new System.Drawing.Point(7, 45);
            shopNameLabel.Name = "shopNameLabel";
            shopNameLabel.Size = new System.Drawing.Size(66, 13);
            shopNameLabel.TabIndex = 2;
            shopNameLabel.Text = "Shop Name:";
            // 
            // domainChinhXacLabel
            // 
            domainChinhXacLabel.AutoSize = true;
            domainChinhXacLabel.Location = new System.Drawing.Point(286, 45);
            domainChinhXacLabel.Name = "domainChinhXacLabel";
            domainChinhXacLabel.Size = new System.Drawing.Size(98, 13);
            domainChinhXacLabel.TabIndex = 4;
            domainChinhXacLabel.Text = "Domain Chinh Xac:";
            // 
            // accessTokenLabel
            // 
            accessTokenLabel.AutoSize = true;
            accessTokenLabel.Location = new System.Drawing.Point(71, 119);
            accessTokenLabel.Name = "accessTokenLabel";
            accessTokenLabel.Size = new System.Drawing.Size(79, 13);
            accessTokenLabel.TabIndex = 6;
            accessTokenLabel.Text = "Access Token:";
            // 
            // companyIdWSSLabel
            // 
            companyIdWSSLabel.AutoSize = true;
            companyIdWSSLabel.Location = new System.Drawing.Point(286, 19);
            companyIdWSSLabel.Name = "companyIdWSSLabel";
            companyIdWSSLabel.Size = new System.Drawing.Size(94, 13);
            companyIdWSSLabel.TabIndex = 8;
            companyIdWSSLabel.Text = "Company Id WSS:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(24, 36);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(337, 36);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(337, 83);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(49, 13);
            websiteLabel.TabIndex = 4;
            websiteLabel.Text = "Website:";
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(24, 83);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 6;
            domainLabel.Text = "Domain:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(24, 126);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "Status:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(74, 87);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 11;
            iDLabel1.Text = "ID:";
            // 
            // domainLabel1
            // 
            domainLabel1.AutoSize = true;
            domainLabel1.Location = new System.Drawing.Point(243, 90);
            domainLabel1.Name = "domainLabel1";
            domainLabel1.Size = new System.Drawing.Size(46, 13);
            domainLabel1.TabIndex = 12;
            domainLabel1.Text = "Domain:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1362, 741);
            this.splitContainerControl1.SplitterPosition = 556;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.bindingNavigator1);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(556, 741);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.company_BizwebGridControl);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(0, 76);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(556, 640);
            this.panelControl4.TabIndex = 2;
            // 
            // company_BizwebGridControl
            // 
            this.company_BizwebGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.company_BizwebGridControl.DataSource = this.company_BizwebBindingSource;
            this.company_BizwebGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.company_BizwebGridControl.Location = new System.Drawing.Point(0, 0);
            this.company_BizwebGridControl.MainView = this.gridView1;
            this.company_BizwebGridControl.Name = "company_BizwebGridControl";
            this.company_BizwebGridControl.Size = new System.Drawing.Size(556, 640);
            this.company_BizwebGridControl.TabIndex = 0;
            this.company_BizwebGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.company_BizwebGridControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.company_BizwebGridControl_MouseDown);
            // 
            // company_BizwebBindingSource
            // 
            this.company_BizwebBindingSource.DataMember = "Company_Bizweb";
            this.company_BizwebBindingSource.DataSource = this.dBBizweb;
            // 
            // dBBizweb
            // 
            this.dBBizweb.DataSetName = "DBBizweb";
            this.dBBizweb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyIdBizweb,
            this.colShopName,
            this.colCompanyIdWSS,
            this.colDomainChinhXac,
            this.colAccessToken,
            this.colIsActive,
            this.colUpdatedDate,
            this.colCreatedDate,
            this.colIsPublic});
            this.gridView1.GridControl = this.company_BizwebGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colCompanyIdBizweb
            // 
            this.colCompanyIdBizweb.FieldName = "CompanyIdBizweb";
            this.colCompanyIdBizweb.Name = "colCompanyIdBizweb";
            // 
            // colShopName
            // 
            this.colShopName.FieldName = "ShopName";
            this.colShopName.Name = "colShopName";
            this.colShopName.Visible = true;
            this.colShopName.VisibleIndex = 0;
            this.colShopName.Width = 143;
            // 
            // colCompanyIdWSS
            // 
            this.colCompanyIdWSS.FieldName = "CompanyIdWSS";
            this.colCompanyIdWSS.Name = "colCompanyIdWSS";
            // 
            // colDomainChinhXac
            // 
            this.colDomainChinhXac.FieldName = "DomainChinhXac";
            this.colDomainChinhXac.Name = "colDomainChinhXac";
            this.colDomainChinhXac.Visible = true;
            this.colDomainChinhXac.VisibleIndex = 1;
            this.colDomainChinhXac.Width = 147;
            // 
            // colAccessToken
            // 
            this.colAccessToken.FieldName = "AccessToken";
            this.colAccessToken.Name = "colAccessToken";
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 2;
            this.colIsActive.Width = 52;
            // 
            // colUpdatedDate
            // 
            this.colUpdatedDate.FieldName = "UpdatedDate";
            this.colUpdatedDate.Name = "colUpdatedDate";
            this.colUpdatedDate.Visible = true;
            this.colUpdatedDate.VisibleIndex = 5;
            this.colUpdatedDate.Width = 96;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 4;
            this.colCreatedDate.Width = 85;
            // 
            // colIsPublic
            // 
            this.colIsPublic.FieldName = "IsPublic";
            this.colIsPublic.Name = "colIsPublic";
            this.colIsPublic.Visible = true;
            this.colIsPublic.VisibleIndex = 3;
            this.colIsPublic.Width = 48;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonRefreshData});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 716);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(556, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripButtonRefreshData
            // 
            this.toolStripButtonRefreshData.Image = global::QT.Moduls.Properties.Resources.Refresh;
            this.toolStripButtonRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefreshData.Name = "toolStripButtonRefreshData";
            this.toolStripButtonRefreshData.Size = new System.Drawing.Size(68, 22);
            this.toolStripButtonRefreshData.Text = "Load lại";
            this.toolStripButtonRefreshData.Click += new System.EventHandler(this.toolStripButtonRefreshData_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(companyIdWSSLabel);
            this.panelControl3.Controls.Add(this.companyIdWSSTextEdit);
            this.panelControl3.Controls.Add(accessTokenLabel);
            this.panelControl3.Controls.Add(this.accessTokenTextEdit);
            this.panelControl3.Controls.Add(domainChinhXacLabel);
            this.panelControl3.Controls.Add(this.domainChinhXacTextEdit);
            this.panelControl3.Controls.Add(shopNameLabel);
            this.panelControl3.Controls.Add(this.shopNameTextEdit);
            this.panelControl3.Controls.Add(companyIdBizwebLabel);
            this.panelControl3.Controls.Add(this.companyIdBizwebTextEdit);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(556, 76);
            this.panelControl3.TabIndex = 0;
            // 
            // companyIdWSSTextEdit
            // 
            this.companyIdWSSTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.company_BizwebBindingSource, "CompanyIdWSS", true));
            this.companyIdWSSTextEdit.Location = new System.Drawing.Point(389, 16);
            this.companyIdWSSTextEdit.Name = "companyIdWSSTextEdit";
            this.companyIdWSSTextEdit.Size = new System.Drawing.Size(160, 20);
            this.companyIdWSSTextEdit.TabIndex = 9;
            // 
            // accessTokenTextEdit
            // 
            this.accessTokenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.company_BizwebBindingSource, "AccessToken", true));
            this.accessTokenTextEdit.Location = new System.Drawing.Point(156, 116);
            this.accessTokenTextEdit.Name = "accessTokenTextEdit";
            this.accessTokenTextEdit.Size = new System.Drawing.Size(281, 20);
            this.accessTokenTextEdit.TabIndex = 7;
            // 
            // domainChinhXacTextEdit
            // 
            this.domainChinhXacTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.company_BizwebBindingSource, "DomainChinhXac", true));
            this.domainChinhXacTextEdit.Location = new System.Drawing.Point(389, 42);
            this.domainChinhXacTextEdit.Name = "domainChinhXacTextEdit";
            this.domainChinhXacTextEdit.Size = new System.Drawing.Size(160, 20);
            this.domainChinhXacTextEdit.TabIndex = 5;
            // 
            // shopNameTextEdit
            // 
            this.shopNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.company_BizwebBindingSource, "ShopName", true));
            this.shopNameTextEdit.Location = new System.Drawing.Point(116, 42);
            this.shopNameTextEdit.Name = "shopNameTextEdit";
            this.shopNameTextEdit.Size = new System.Drawing.Size(160, 20);
            this.shopNameTextEdit.TabIndex = 3;
            // 
            // companyIdBizwebTextEdit
            // 
            this.companyIdBizwebTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.company_BizwebBindingSource, "CompanyIdBizweb", true));
            this.companyIdBizwebTextEdit.Location = new System.Drawing.Point(116, 16);
            this.companyIdBizwebTextEdit.Name = "companyIdBizwebTextEdit";
            this.companyIdBizwebTextEdit.Size = new System.Drawing.Size(160, 20);
            this.companyIdBizwebTextEdit.TabIndex = 1;
            this.companyIdBizwebTextEdit.EditValueChanged += new System.EventHandler(this.companyIdBizwebTextEdit_EditValueChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.xtraTabControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(798, 741);
            this.panelControl2.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageProduct;
            this.xtraTabControl1.Size = new System.Drawing.Size(798, 741);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageProduct,
            this.xtraTabPageProductInSQL,
            this.xtraTabPageUpdateDomain});
            // 
            // xtraTabPageProduct
            // 
            this.xtraTabPageProduct.Controls.Add(this.gridControlProduct);
            this.xtraTabPageProduct.Controls.Add(this.panelControl5);
            this.xtraTabPageProduct.Name = "xtraTabPageProduct";
            this.xtraTabPageProduct.Size = new System.Drawing.Size(790, 712);
            this.xtraTabPageProduct.Text = "Product";
            // 
            // gridControlProduct
            // 
            this.gridControlProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProduct.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridControlProduct.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlProduct.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridControlProduct.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlProduct.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControlProduct.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlProduct.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControlProduct.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlProduct.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gridControlProduct.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlProduct.Location = new System.Drawing.Point(0, 53);
            this.gridControlProduct.MainView = this.gridViewProduct;
            this.gridControlProduct.Name = "gridControlProduct";
            this.gridControlProduct.Size = new System.Drawing.Size(790, 659);
            this.gridControlProduct.TabIndex = 2;
            this.gridControlProduct.UseEmbeddedNavigator = true;
            this.gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProduct});
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewProduct.GridControl = this.gridControlProduct;
            this.gridViewProduct.Name = "gridViewProduct";
            this.gridViewProduct.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProduct.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên sản phẩm";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giá";
            this.gridColumn3.FieldName = "Price";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Status";
            this.gridColumn4.FieldName = "Status";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "URL";
            this.gridColumn5.FieldName = "DetailUrl";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 251;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.simpleButtonUpdateProduct);
            this.panelControl5.Controls.Add(this.simpleButtonTestProduct);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(0, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(790, 53);
            this.panelControl5.TabIndex = 0;
            // 
            // simpleButtonUpdateProduct
            // 
            this.simpleButtonUpdateProduct.Location = new System.Drawing.Point(681, 12);
            this.simpleButtonUpdateProduct.Name = "simpleButtonUpdateProduct";
            this.simpleButtonUpdateProduct.Size = new System.Drawing.Size(90, 30);
            this.simpleButtonUpdateProduct.TabIndex = 1;
            this.simpleButtonUpdateProduct.Text = "UpdateProduct";
            this.simpleButtonUpdateProduct.Click += new System.EventHandler(this.simpleButtonUpdateProduct_Click);
            // 
            // simpleButtonTestProduct
            // 
            this.simpleButtonTestProduct.Location = new System.Drawing.Point(15, 12);
            this.simpleButtonTestProduct.Name = "simpleButtonTestProduct";
            this.simpleButtonTestProduct.Size = new System.Drawing.Size(90, 30);
            this.simpleButtonTestProduct.TabIndex = 0;
            this.simpleButtonTestProduct.Text = "Test Product";
            this.simpleButtonTestProduct.Click += new System.EventHandler(this.simpleButtonTestProduct_Click);
            // 
            // xtraTabPageProductInSQL
            // 
            this.xtraTabPageProductInSQL.Controls.Add(this.productGridControl);
            this.xtraTabPageProductInSQL.Controls.Add(this.panelControl6);
            this.xtraTabPageProductInSQL.Name = "xtraTabPageProductInSQL";
            this.xtraTabPageProductInSQL.Size = new System.Drawing.Size(795, 713);
            this.xtraTabPageProductInSQL.Text = "Product In Database";
            // 
            // productGridControl
            // 
            this.productGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.productGridControl.DataSource = this.productBindingSource;
            this.productGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.productGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.productGridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.productGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.productGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.productGridControl.Location = new System.Drawing.Point(0, 53);
            this.productGridControl.MainView = this.gridView2;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.Size = new System.Drawing.Size(795, 660);
            this.productGridControl.TabIndex = 3;
            this.productGridControl.UseEmbeddedNavigator = true;
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBBizweb;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colClassificationID,
            this.colPrice,
            this.colWarranty,
            this.colStatus,
            this.colCompany,
            this.colLastUpdate,
            this.colProductID,
            this.colPromotion,
            this.colSummary,
            this.colProductContent,
            this.colName,
            this.colDetailUrl,
            this.colImageUrls,
            this.colNameFT,
            this.colValid,
            this.colLastPriceChange,
            this.colPriceChange,
            this.colIsNews,
            this.colHashName,
            this.colImagePath,
            this.colCategoryID,
            this.colContentFT,
            this.colDownloadError,
            this.colImageWidth,
            this.colImageHeight,
            this.colCategorySTT,
            this.colViewCount,
            this.colPriceChangeWeek,
            this.colAddPosition,
            this.colVATInfo,
            this.colPromotionInfo});
            this.gridView2.GridControl = this.productGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colClassificationID
            // 
            this.colClassificationID.FieldName = "ClassificationID";
            this.colClassificationID.Name = "colClassificationID";
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 57;
            // 
            // colWarranty
            // 
            this.colWarranty.FieldName = "Warranty";
            this.colWarranty.Name = "colWarranty";
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            this.colStatus.Width = 39;
            // 
            // colCompany
            // 
            this.colCompany.FieldName = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 0;
            this.colCompany.Width = 80;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            // 
            // colProductID
            // 
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            // 
            // colPromotion
            // 
            this.colPromotion.FieldName = "Promotion";
            this.colPromotion.Name = "colPromotion";
            // 
            // colSummary
            // 
            this.colSummary.FieldName = "Summary";
            this.colSummary.Name = "colSummary";
            // 
            // colProductContent
            // 
            this.colProductContent.FieldName = "ProductContent";
            this.colProductContent.Name = "colProductContent";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 162;
            // 
            // colDetailUrl
            // 
            this.colDetailUrl.FieldName = "DetailUrl";
            this.colDetailUrl.Name = "colDetailUrl";
            this.colDetailUrl.Visible = true;
            this.colDetailUrl.VisibleIndex = 3;
            this.colDetailUrl.Width = 181;
            // 
            // colImageUrls
            // 
            this.colImageUrls.FieldName = "ImageUrls";
            this.colImageUrls.Name = "colImageUrls";
            // 
            // colNameFT
            // 
            this.colNameFT.FieldName = "NameFT";
            this.colNameFT.Name = "colNameFT";
            // 
            // colValid
            // 
            this.colValid.FieldName = "Valid";
            this.colValid.Name = "colValid";
            this.colValid.Visible = true;
            this.colValid.VisibleIndex = 4;
            this.colValid.Width = 30;
            // 
            // colLastPriceChange
            // 
            this.colLastPriceChange.FieldName = "LastPriceChange";
            this.colLastPriceChange.Name = "colLastPriceChange";
            // 
            // colPriceChange
            // 
            this.colPriceChange.FieldName = "PriceChange";
            this.colPriceChange.Name = "colPriceChange";
            // 
            // colIsNews
            // 
            this.colIsNews.FieldName = "IsNews";
            this.colIsNews.Name = "colIsNews";
            // 
            // colHashName
            // 
            this.colHashName.FieldName = "HashName";
            this.colHashName.Name = "colHashName";
            // 
            // colImagePath
            // 
            this.colImagePath.FieldName = "ImagePath";
            this.colImagePath.Name = "colImagePath";
            this.colImagePath.Visible = true;
            this.colImagePath.VisibleIndex = 6;
            this.colImagePath.Width = 171;
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            // 
            // colContentFT
            // 
            this.colContentFT.FieldName = "ContentFT";
            this.colContentFT.Name = "colContentFT";
            // 
            // colDownloadError
            // 
            this.colDownloadError.FieldName = "DownloadError";
            this.colDownloadError.Name = "colDownloadError";
            // 
            // colImageWidth
            // 
            this.colImageWidth.FieldName = "ImageWidth";
            this.colImageWidth.Name = "colImageWidth";
            // 
            // colImageHeight
            // 
            this.colImageHeight.FieldName = "ImageHeight";
            this.colImageHeight.Name = "colImageHeight";
            // 
            // colCategorySTT
            // 
            this.colCategorySTT.FieldName = "CategorySTT";
            this.colCategorySTT.Name = "colCategorySTT";
            // 
            // colViewCount
            // 
            this.colViewCount.FieldName = "ViewCount";
            this.colViewCount.Name = "colViewCount";
            // 
            // colPriceChangeWeek
            // 
            this.colPriceChangeWeek.FieldName = "PriceChangeWeek";
            this.colPriceChangeWeek.Name = "colPriceChangeWeek";
            // 
            // colAddPosition
            // 
            this.colAddPosition.FieldName = "AddPosition";
            this.colAddPosition.Name = "colAddPosition";
            // 
            // colVATInfo
            // 
            this.colVATInfo.FieldName = "VATInfo";
            this.colVATInfo.Name = "colVATInfo";
            // 
            // colPromotionInfo
            // 
            this.colPromotionInfo.FieldName = "PromotionInfo";
            this.colPromotionInfo.Name = "colPromotionInfo";
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.simpleButtonLoadProductInSql);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl6.Location = new System.Drawing.Point(0, 0);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(795, 53);
            this.panelControl6.TabIndex = 0;
            // 
            // simpleButtonLoadProductInSql
            // 
            this.simpleButtonLoadProductInSql.Location = new System.Drawing.Point(14, 14);
            this.simpleButtonLoadProductInSql.Name = "simpleButtonLoadProductInSql";
            this.simpleButtonLoadProductInSql.Size = new System.Drawing.Size(154, 30);
            this.simpleButtonLoadProductInSql.TabIndex = 1;
            this.simpleButtonLoadProductInSql.Text = "Load Product in Database";
            this.simpleButtonLoadProductInSql.Click += new System.EventHandler(this.simpleButtonLoadProductInSql_Click);
            // 
            // xtraTabPageUpdateDomain
            // 
            this.xtraTabPageUpdateDomain.Controls.Add(this.panelControl7);
            this.xtraTabPageUpdateDomain.Controls.Add(this.groupControl2);
            this.xtraTabPageUpdateDomain.Controls.Add(this.groupControl1);
            this.xtraTabPageUpdateDomain.Name = "xtraTabPageUpdateDomain";
            this.xtraTabPageUpdateDomain.Size = new System.Drawing.Size(795, 713);
            this.xtraTabPageUpdateDomain.Text = "Update Domain";
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.gridControlCompany);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl7.Location = new System.Drawing.Point(0, 229);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(795, 484);
            this.panelControl7.TabIndex = 2;
            // 
            // gridControlCompany
            // 
            this.gridControlCompany.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlCompany.DataSource = this.companySearchBindingSource;
            this.gridControlCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCompany.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlCompany.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlCompany.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlCompany.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlCompany.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlCompany.Location = new System.Drawing.Point(2, 2);
            this.gridControlCompany.MainView = this.gridViewCompany;
            this.gridControlCompany.Name = "gridControlCompany";
            this.gridControlCompany.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlCompany.Size = new System.Drawing.Size(791, 480);
            this.gridControlCompany.TabIndex = 2;
            this.gridControlCompany.UseEmbeddedNavigator = true;
            this.gridControlCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCompany});
            this.gridControlCompany.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControlCompany_MouseDown);
            // 
            // companySearchBindingSource
            // 
            this.companySearchBindingSource.DataMember = "CompanySearch";
            this.companySearchBindingSource.DataSource = this.dBBizweb;
            // 
            // gridViewCompany
            // 
            this.gridViewCompany.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colName1,
            this.colWebsite,
            this.colDomain,
            this.colAddDate,
            this.colStatus1,
            this.colTotalProduct});
            this.gridViewCompany.GridControl = this.gridControlCompany;
            this.gridViewCompany.Name = "gridViewCompany";
            this.gridViewCompany.OptionsBehavior.Editable = false;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            this.colID1.Width = 96;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            this.colName1.Width = 107;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 2;
            this.colWebsite.Width = 146;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 3;
            this.colDomain.Width = 178;
            // 
            // colAddDate
            // 
            this.colAddDate.FieldName = "AddDate";
            this.colAddDate.Name = "colAddDate";
            this.colAddDate.Visible = true;
            this.colAddDate.VisibleIndex = 4;
            this.colAddDate.Width = 81;
            // 
            // colStatus1
            // 
            this.colStatus1.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colStatus1.FieldName = "Status";
            this.colStatus1.Name = "colStatus1";
            this.colStatus1.Visible = true;
            this.colStatus1.VisibleIndex = 5;
            this.colStatus1.Width = 49;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Description";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 6;
            this.colTotalProduct.Width = 79;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(domainLabel1);
            this.groupControl2.Controls.Add(this.domainCompanySearchTextEdit);
            this.groupControl2.Controls.Add(iDLabel1);
            this.groupControl2.Controls.Add(this.iDCompanySearchTextEdit);
            this.groupControl2.Controls.Add(this.labelControlCheckDomain);
            this.groupControl2.Controls.Add(this.ButtonCheckCompanyByDomain);
            this.groupControl2.Controls.Add(this.textEditDomainCheck);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 166);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(795, 63);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Check Domain";
            // 
            // domainCompanySearchTextEdit
            // 
            this.domainCompanySearchTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companySearchBindingSource, "Domain", true));
            this.domainCompanySearchTextEdit.Location = new System.Drawing.Point(295, 87);
            this.domainCompanySearchTextEdit.Name = "domainCompanySearchTextEdit";
            this.domainCompanySearchTextEdit.Size = new System.Drawing.Size(100, 20);
            this.domainCompanySearchTextEdit.TabIndex = 13;
            // 
            // iDCompanySearchTextEdit
            // 
            this.iDCompanySearchTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companySearchBindingSource, "ID", true));
            this.iDCompanySearchTextEdit.Location = new System.Drawing.Point(101, 84);
            this.iDCompanySearchTextEdit.Name = "iDCompanySearchTextEdit";
            this.iDCompanySearchTextEdit.Size = new System.Drawing.Size(100, 20);
            this.iDCompanySearchTextEdit.TabIndex = 12;
            // 
            // labelControlCheckDomain
            // 
            this.labelControlCheckDomain.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlCheckDomain.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControlCheckDomain.Location = new System.Drawing.Point(416, 34);
            this.labelControlCheckDomain.Name = "labelControlCheckDomain";
            this.labelControlCheckDomain.Size = new System.Drawing.Size(12, 16);
            this.labelControlCheckDomain.TabIndex = 11;
            this.labelControlCheckDomain.Text = "...";
            // 
            // ButtonCheckCompanyByDomain
            // 
            this.ButtonCheckCompanyByDomain.Location = new System.Drawing.Point(273, 31);
            this.ButtonCheckCompanyByDomain.Name = "ButtonCheckCompanyByDomain";
            this.ButtonCheckCompanyByDomain.Size = new System.Drawing.Size(88, 23);
            this.ButtonCheckCompanyByDomain.TabIndex = 10;
            this.ButtonCheckCompanyByDomain.Text = "Check thông tin";
            this.ButtonCheckCompanyByDomain.Click += new System.EventHandler(this.ButtonCheckCompanyByDomain_Click);
            // 
            // textEditDomainCheck
            // 
            this.textEditDomainCheck.Location = new System.Drawing.Point(72, 33);
            this.textEditDomainCheck.Name = "textEditDomainCheck";
            this.textEditDomainCheck.Size = new System.Drawing.Size(192, 20);
            this.textEditDomainCheck.TabIndex = 9;
            this.textEditDomainCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditDomainCheck_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Domain";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButtonSaveCompany);
            this.groupControl1.Controls.Add(statusLabel);
            this.groupControl1.Controls.Add(this.statusCompanyLookUpEdit);
            this.groupControl1.Controls.Add(domainLabel);
            this.groupControl1.Controls.Add(this.domainCompanyTextEdit);
            this.groupControl1.Controls.Add(websiteLabel);
            this.groupControl1.Controls.Add(this.websiteCompanyTextEdit);
            this.groupControl1.Controls.Add(nameLabel);
            this.groupControl1.Controls.Add(this.nameCompanyTextEdit);
            this.groupControl1.Controls.Add(iDLabel);
            this.groupControl1.Controls.Add(this.iDCompanyTextEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(795, 166);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin công ty trong Database";
            // 
            // simpleButtonSaveCompany
            // 
            this.simpleButtonSaveCompany.Location = new System.Drawing.Point(340, 111);
            this.simpleButtonSaveCompany.Name = "simpleButtonSaveCompany";
            this.simpleButtonSaveCompany.Size = new System.Drawing.Size(122, 43);
            this.simpleButtonSaveCompany.TabIndex = 10;
            this.simpleButtonSaveCompany.Text = "Lưu lại";
            this.simpleButtonSaveCompany.Click += new System.EventHandler(this.simpleButtonSaveCompany_Click);
            // 
            // statusCompanyLookUpEdit
            // 
            this.statusCompanyLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Status", true));
            this.statusCompanyLookUpEdit.Location = new System.Drawing.Point(80, 123);
            this.statusCompanyLookUpEdit.Name = "statusCompanyLookUpEdit";
            this.statusCompanyLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusCompanyLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Name")});
            this.statusCompanyLookUpEdit.Properties.DataSource = this.companyStatusBindingSource;
            this.statusCompanyLookUpEdit.Properties.DisplayMember = "Description";
            this.statusCompanyLookUpEdit.Properties.ValueMember = "ID";
            this.statusCompanyLookUpEdit.Size = new System.Drawing.Size(131, 20);
            this.statusCompanyLookUpEdit.TabIndex = 9;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBBizweb;
            // 
            // companyStatusBindingSource
            // 
            this.companyStatusBindingSource.DataMember = "Company_Status";
            this.companyStatusBindingSource.DataSource = this.dBBizweb;
            // 
            // domainCompanyTextEdit
            // 
            this.domainCompanyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Domain", true));
            this.domainCompanyTextEdit.Location = new System.Drawing.Point(80, 80);
            this.domainCompanyTextEdit.Name = "domainCompanyTextEdit";
            this.domainCompanyTextEdit.Size = new System.Drawing.Size(206, 20);
            this.domainCompanyTextEdit.TabIndex = 7;
            this.domainCompanyTextEdit.EditValueChanged += new System.EventHandler(this.domainCompanyTextEdit_EditValueChanged);
            // 
            // websiteCompanyTextEdit
            // 
            this.websiteCompanyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Website", true));
            this.websiteCompanyTextEdit.Location = new System.Drawing.Point(392, 80);
            this.websiteCompanyTextEdit.Name = "websiteCompanyTextEdit";
            this.websiteCompanyTextEdit.Size = new System.Drawing.Size(244, 20);
            this.websiteCompanyTextEdit.TabIndex = 5;
            // 
            // nameCompanyTextEdit
            // 
            this.nameCompanyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Name", true));
            this.nameCompanyTextEdit.Location = new System.Drawing.Point(392, 33);
            this.nameCompanyTextEdit.Name = "nameCompanyTextEdit";
            this.nameCompanyTextEdit.Size = new System.Drawing.Size(244, 20);
            this.nameCompanyTextEdit.TabIndex = 3;
            // 
            // iDCompanyTextEdit
            // 
            this.iDCompanyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "ID", true));
            this.iDCompanyTextEdit.Location = new System.Drawing.Point(80, 33);
            this.iDCompanyTextEdit.Name = "iDCompanyTextEdit";
            this.iDCompanyTextEdit.Size = new System.Drawing.Size(206, 20);
            this.iDCompanyTextEdit.TabIndex = 1;
            // 
            // company_BizwebTableAdapter
            // 
            this.company_BizwebTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Company_BizwebTableAdapter = this.company_BizwebTableAdapter;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanySearchTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Bizweb.DBBizwebTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // company_StatusTableAdapter
            // 
            this.company_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // companySearchTableAdapter
            // 
            this.companySearchTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUpdateDomain,
            this.toolStripMenuItemUnPublicStore});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 48);
            // 
            // toolStripMenuItemUpdateDomain
            // 
            this.toolStripMenuItemUpdateDomain.Name = "toolStripMenuItemUpdateDomain";
            this.toolStripMenuItemUpdateDomain.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemUpdateDomain.Text = "Cập nhật Domain";
            this.toolStripMenuItemUpdateDomain.Click += new System.EventHandler(this.toolStripMenuItemUpdateDomain_Click);
            // 
            // toolStripMenuItemUnPublicStore
            // 
            this.toolStripMenuItemUnPublicStore.Name = "toolStripMenuItemUnPublicStore";
            this.toolStripMenuItemUnPublicStore.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemUnPublicStore.Text = "Ngừng Puclic cửa hàng";
            this.toolStripMenuItemUnPublicStore.Click += new System.EventHandler(this.toolStripMenuItemUnPublicStore_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUpdateByCurrentDomain});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(259, 26);
            // 
            // toolStripMenuItemUpdateByCurrentDomain
            // 
            this.toolStripMenuItemUpdateByCurrentDomain.Name = "toolStripMenuItemUpdateByCurrentDomain";
            this.toolStripMenuItemUpdateByCurrentDomain.Size = new System.Drawing.Size(258, 22);
            this.toolStripMenuItemUpdateByCurrentDomain.Text = "Cập nhật dữ liệu theo Domain này!";
            this.toolStripMenuItemUpdateByCurrentDomain.Click += new System.EventHandler(this.toolStripMenuItemUpdateByCurrentDomain_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // frmSettingBizwebs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmSettingBizwebs";
            this.Text = "frmSettingBizwebs";
            this.Load += new System.EventHandler(this.frmSettingBizwebs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.company_BizwebGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_BizwebBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBizweb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyIdWSSTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessTokenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainChinhXacTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyIdBizwebTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.xtraTabPageProductInSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.xtraTabPageUpdateDomain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainCompanySearchTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDCompanySearchTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDomainCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCompanyLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainCompanyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteCompanyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameCompanyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDCompanyTextEdit.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DBBizweb dBBizweb;
        private System.Windows.Forms.BindingSource company_BizwebBindingSource;
        private DBBizwebTableAdapters.Company_BizwebTableAdapter company_BizwebTableAdapter;
        private DBBizwebTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl company_BizwebGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyIdBizweb;
        private DevExpress.XtraGrid.Columns.GridColumn colShopName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyIdWSS;
        private DevExpress.XtraGrid.Columns.GridColumn colDomainChinhXac;
        private DevExpress.XtraGrid.Columns.GridColumn colAccessToken;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPublic;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefreshData;
        private DevExpress.XtraEditors.TextEdit companyIdWSSTextEdit;
        private DevExpress.XtraEditors.TextEdit accessTokenTextEdit;
        private DevExpress.XtraEditors.TextEdit domainChinhXacTextEdit;
        private DevExpress.XtraEditors.TextEdit shopNameTextEdit;
        private DevExpress.XtraEditors.TextEdit companyIdBizwebTextEdit;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageProduct;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageProductInSQL;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraGrid.GridControl gridControlProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProduct;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdateProduct;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTestProduct;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageUpdateDomain;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLoadProductInSql;
        private DevExpress.XtraGrid.GridControl productGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colClassificationID;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colWarranty;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colPromotion;
        private DevExpress.XtraGrid.Columns.GridColumn colSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colProductContent;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colImageUrls;
        private DevExpress.XtraGrid.Columns.GridColumn colNameFT;
        private DevExpress.XtraGrid.Columns.GridColumn colValid;
        private DevExpress.XtraGrid.Columns.GridColumn colLastPriceChange;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceChange;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNews;
        private DevExpress.XtraGrid.Columns.GridColumn colHashName;
        private DevExpress.XtraGrid.Columns.GridColumn colImagePath;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colContentFT;
        private DevExpress.XtraGrid.Columns.GridColumn colDownloadError;
        private DevExpress.XtraGrid.Columns.GridColumn colImageWidth;
        private DevExpress.XtraGrid.Columns.GridColumn colImageHeight;
        private DevExpress.XtraGrid.Columns.GridColumn colCategorySTT;
        private DevExpress.XtraGrid.Columns.GridColumn colViewCount;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceChangeWeek;
        private DevExpress.XtraGrid.Columns.GridColumn colAddPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colVATInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colPromotionInfo;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.LabelControl labelControlCheckDomain;
        private DevExpress.XtraEditors.SimpleButton ButtonCheckCompanyByDomain;
        private DevExpress.XtraEditors.TextEdit textEditDomainCheck;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBBizwebTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSaveCompany;
        private DevExpress.XtraEditors.LookUpEdit statusCompanyLookUpEdit;
        private DevExpress.XtraEditors.TextEdit domainCompanyTextEdit;
        private DevExpress.XtraEditors.TextEdit websiteCompanyTextEdit;
        private DevExpress.XtraEditors.TextEdit nameCompanyTextEdit;
        private DevExpress.XtraEditors.TextEdit iDCompanyTextEdit;
        private System.Windows.Forms.BindingSource companyStatusBindingSource;
        private DBBizwebTableAdapters.Company_StatusTableAdapter company_StatusTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colAddDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
        private System.Windows.Forms.BindingSource companySearchBindingSource;
        private DBBizwebTableAdapters.CompanySearchTableAdapter companySearchTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdateDomain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUnPublicStore;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdateByCurrentDomain;
        private DevExpress.XtraEditors.TextEdit domainCompanySearchTextEdit;
        private DevExpress.XtraEditors.TextEdit iDCompanySearchTextEdit;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBBizwebTableAdapters.ProductTableAdapter productTableAdapter;
    }
}