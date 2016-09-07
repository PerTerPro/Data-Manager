namespace QT.Moduls.WebPartner
{
    partial class frmSettingHaravan
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
            System.Windows.Forms.Label shopNameLabel;
            System.Windows.Forms.Label companyIdHaravanLabel;
            System.Windows.Forms.Label domainChinhXacLabel;
            System.Windows.Forms.Label companyIdWSSLabel;
            System.Windows.Forms.Label isPublicLabel;
            System.Windows.Forms.Label accessTokenLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label domainLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label websiteLabel1;
            System.Windows.Forms.Label domainLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingHaravan));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.company_HaravanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBWebPartner = new QT.Moduls.WebPartner.DBWebPartner();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccessToken = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyIdHaravan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomainChinhXac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyIdWSS = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.CheckCompanyButton = new DevExpress.XtraEditors.SimpleButton();
            this.accessTokenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isPublicCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.companyIdWSSSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.shopNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.domainChinhXacTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.companyIdHaravanSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
            this.gridViewProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControlMessage = new DevExpress.XtraEditors.LabelControl();
            this.UpdateProductButton = new DevExpress.XtraEditors.SimpleButton();
            this.TestProductButton = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControlMessageImage = new DevExpress.XtraEditors.LabelControl();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.DownloadImageThieuButton = new DevExpress.XtraEditors.SimpleButton();
            this.DownloadAllImageButton = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
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
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.LoadProductDatabaseButton = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
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
            this.companyStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.domainTextEditSearch = new DevExpress.XtraEditors.TextEdit();
            this.websiteTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.iDTextEditCompanySearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControlCheckDomain = new DevExpress.XtraEditors.LabelControl();
            this.ButtonCheckCompanyByDomain = new DevExpress.XtraEditors.SimpleButton();
            this.textEditDomain = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.UnPublicShopButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.statusLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domainTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.websiteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.iDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.company_HaravanTableAdapter = new QT.Moduls.WebPartner.DBWebPartnerTableAdapters.Company_HaravanTableAdapter();
            this.tableAdapterManager = new QT.Moduls.WebPartner.DBWebPartnerTableAdapters.TableAdapterManager();
            this.productTableAdapter = new QT.Moduls.WebPartner.DBWebPartnerTableAdapters.ProductTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemUpdateDomain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUnPublic = new System.Windows.Forms.ToolStripMenuItem();
            this.companyTableAdapter = new QT.Moduls.WebPartner.DBWebPartnerTableAdapters.CompanyTableAdapter();
            this.company_StatusTableAdapter = new QT.Moduls.WebPartner.DBWebPartnerTableAdapters.Company_StatusTableAdapter();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateByDomainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySearchTableAdapter = new QT.Moduls.WebPartner.DBWebPartnerTableAdapters.CompanySearchTableAdapter();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            shopNameLabel = new System.Windows.Forms.Label();
            companyIdHaravanLabel = new System.Windows.Forms.Label();
            domainChinhXacLabel = new System.Windows.Forms.Label();
            companyIdWSSLabel = new System.Windows.Forms.Label();
            isPublicLabel = new System.Windows.Forms.Label();
            accessTokenLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            websiteLabel1 = new System.Windows.Forms.Label();
            domainLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_HaravanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBWebPartner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessTokenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isPublicCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyIdWSSSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainChinhXacTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyIdHaravanSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEditSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEditCompanySearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDomain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopNameLabel
            // 
            shopNameLabel.AutoSize = true;
            shopNameLabel.Location = new System.Drawing.Point(278, 18);
            shopNameLabel.Name = "shopNameLabel";
            shopNameLabel.Size = new System.Drawing.Size(66, 13);
            shopNameLabel.TabIndex = 0;
            shopNameLabel.Text = "Shop Name:";
            // 
            // companyIdHaravanLabel
            // 
            companyIdHaravanLabel.AutoSize = true;
            companyIdHaravanLabel.Location = new System.Drawing.Point(2, 18);
            companyIdHaravanLabel.Name = "companyIdHaravanLabel";
            companyIdHaravanLabel.Size = new System.Drawing.Size(63, 13);
            companyIdHaravanLabel.TabIndex = 2;
            companyIdHaravanLabel.Text = "Id Haravan:";
            // 
            // domainChinhXacLabel
            // 
            domainChinhXacLabel.AutoSize = true;
            domainChinhXacLabel.Location = new System.Drawing.Point(32, 117);
            domainChinhXacLabel.Name = "domainChinhXacLabel";
            domainChinhXacLabel.Size = new System.Drawing.Size(94, 13);
            domainChinhXacLabel.TabIndex = 0;
            domainChinhXacLabel.Text = "Domain chính xác";
            // 
            // companyIdWSSLabel
            // 
            companyIdWSSLabel.AutoSize = true;
            companyIdWSSLabel.Location = new System.Drawing.Point(12, 174);
            companyIdWSSLabel.Name = "companyIdWSSLabel";
            companyIdWSSLabel.Size = new System.Drawing.Size(47, 13);
            companyIdWSSLabel.TabIndex = 2;
            companyIdWSSLabel.Text = "Id WSS:";
            // 
            // isPublicLabel
            // 
            isPublicLabel.AutoSize = true;
            isPublicLabel.Location = new System.Drawing.Point(271, 176);
            isPublicLabel.Name = "isPublicLabel";
            isPublicLabel.Size = new System.Drawing.Size(85, 13);
            isPublicLabel.TabIndex = 5;
            isPublicLabel.Text = "Public Cửa hàng";
            // 
            // accessTokenLabel
            // 
            accessTokenLabel.AutoSize = true;
            accessTokenLabel.Location = new System.Drawing.Point(3, 87);
            accessTokenLabel.Name = "accessTokenLabel";
            accessTokenLabel.Size = new System.Drawing.Size(79, 13);
            accessTokenLabel.TabIndex = 4;
            accessTokenLabel.Text = "Access Token:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(355, 44);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(13, 44);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(355, 86);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(49, 13);
            websiteLabel.TabIndex = 4;
            websiteLabel.Text = "Website:";
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(13, 86);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 6;
            domainLabel.Text = "Domain:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(13, 127);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "Status:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(39, 89);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 4;
            iDLabel1.Text = "ID:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(216, 91);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 6;
            nameLabel1.Text = "Name:";
            // 
            // websiteLabel1
            // 
            websiteLabel1.AutoSize = true;
            websiteLabel1.Location = new System.Drawing.Point(393, 89);
            websiteLabel1.Name = "websiteLabel1";
            websiteLabel1.Size = new System.Drawing.Size(49, 13);
            websiteLabel1.TabIndex = 8;
            websiteLabel1.Text = "Website:";
            // 
            // domainLabel1
            // 
            domainLabel1.AutoSize = true;
            domainLabel1.Location = new System.Drawing.Point(574, 87);
            domainLabel1.Name = "domainLabel1";
            domainLabel1.Size = new System.Drawing.Size(46, 13);
            domainLabel1.TabIndex = 10;
            domainLabel1.Text = "Domain:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1309, 661);
            this.splitContainerControl1.SplitterPosition = 527;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Controls.Add(this.bindingNavigator1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 46);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(527, 615);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.company_HaravanBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(523, 586);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // company_HaravanBindingSource
            // 
            this.company_HaravanBindingSource.DataMember = "Company_Haravan";
            this.company_HaravanBindingSource.DataSource = this.dBWebPartner;
            // 
            // dBWebPartner
            // 
            this.dBWebPartner.DataSetName = "DBWebPartner";
            this.dBWebPartner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShopName,
            this.colAccessToken,
            this.colIsActive,
            this.colUpdatedDate,
            this.colCompanyIdHaravan,
            this.colDomainChinhXac,
            this.colCompanyIdWSS,
            this.colCreatedDate,
            this.colIsPublic});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            // 
            // colShopName
            // 
            this.colShopName.FieldName = "ShopName";
            this.colShopName.Name = "colShopName";
            this.colShopName.Visible = true;
            this.colShopName.VisibleIndex = 0;
            this.colShopName.Width = 118;
            // 
            // colAccessToken
            // 
            this.colAccessToken.FieldName = "AccessToken";
            this.colAccessToken.Name = "colAccessToken";
            this.colAccessToken.Width = 199;
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
            this.colUpdatedDate.VisibleIndex = 4;
            // 
            // colCompanyIdHaravan
            // 
            this.colCompanyIdHaravan.FieldName = "CompanyIdHaravan";
            this.colCompanyIdHaravan.Name = "colCompanyIdHaravan";
            // 
            // colDomainChinhXac
            // 
            this.colDomainChinhXac.FieldName = "DomainChinhXac";
            this.colDomainChinhXac.Name = "colDomainChinhXac";
            this.colDomainChinhXac.Visible = true;
            this.colDomainChinhXac.VisibleIndex = 1;
            this.colDomainChinhXac.Width = 173;
            // 
            // colCompanyIdWSS
            // 
            this.colCompanyIdWSS.FieldName = "CompanyIdWSS";
            this.colCompanyIdWSS.Name = "colCompanyIdWSS";
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            // 
            // colIsPublic
            // 
            this.colIsPublic.FieldName = "IsPublic";
            this.colIsPublic.Name = "colIsPublic";
            this.colIsPublic.Visible = true;
            this.colIsPublic.VisibleIndex = 3;
            this.colIsPublic.Width = 51;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.company_HaravanBindingSource;
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
            this.toolStripButtonReload});
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 588);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(523, 25);
            this.bindingNavigator1.TabIndex = 0;
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
            // toolStripButtonReload
            // 
            this.toolStripButtonReload.Image = global::QT.Moduls.Properties.Resources.Refresh;
            this.toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReload.Name = "toolStripButtonReload";
            this.toolStripButtonReload.Size = new System.Drawing.Size(68, 22);
            this.toolStripButtonReload.Text = "Load lại";
            this.toolStripButtonReload.Click += new System.EventHandler(this.ReloadCompanyHaravanButton_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.CheckCompanyButton);
            this.panelControl1.Controls.Add(accessTokenLabel);
            this.panelControl1.Controls.Add(isPublicLabel);
            this.panelControl1.Controls.Add(companyIdWSSLabel);
            this.panelControl1.Controls.Add(this.accessTokenTextEdit);
            this.panelControl1.Controls.Add(this.isPublicCheckEdit);
            this.panelControl1.Controls.Add(companyIdHaravanLabel);
            this.panelControl1.Controls.Add(shopNameLabel);
            this.panelControl1.Controls.Add(this.companyIdWSSSpinEdit);
            this.panelControl1.Controls.Add(this.shopNameTextEdit);
            this.panelControl1.Controls.Add(domainChinhXacLabel);
            this.panelControl1.Controls.Add(this.domainChinhXacTextEdit);
            this.panelControl1.Controls.Add(this.companyIdHaravanSpinEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(527, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // CheckCompanyButton
            // 
            this.CheckCompanyButton.Location = new System.Drawing.Point(367, 230);
            this.CheckCompanyButton.Name = "CheckCompanyButton";
            this.CheckCompanyButton.Size = new System.Drawing.Size(93, 23);
            this.CheckCompanyButton.TabIndex = 8;
            this.CheckCompanyButton.Text = "CheckCompany";
            this.CheckCompanyButton.ToolTip = "Check xem cửa hàng này có tồn tại trong bảng Company hay không?";
            this.CheckCompanyButton.Click += new System.EventHandler(this.CheckCompanyButton_Click);
            // 
            // accessTokenTextEdit
            // 
            this.accessTokenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.company_HaravanBindingSource, "AccessToken", true));
            this.accessTokenTextEdit.Location = new System.Drawing.Point(88, 84);
            this.accessTokenTextEdit.Name = "accessTokenTextEdit";
            this.accessTokenTextEdit.Properties.ReadOnly = true;
            this.accessTokenTextEdit.Size = new System.Drawing.Size(316, 20);
            this.accessTokenTextEdit.TabIndex = 5;
            // 
            // isPublicCheckEdit
            // 
            this.isPublicCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.company_HaravanBindingSource, "IsPublic", true));
            this.isPublicCheckEdit.Location = new System.Drawing.Point(247, 173);
            this.isPublicCheckEdit.Name = "isPublicCheckEdit";
            this.isPublicCheckEdit.Properties.Caption = "";
            this.isPublicCheckEdit.Size = new System.Drawing.Size(18, 19);
            this.isPublicCheckEdit.TabIndex = 6;
            // 
            // companyIdWSSSpinEdit
            // 
            this.companyIdWSSSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.company_HaravanBindingSource, "CompanyIdWSS", true));
            this.companyIdWSSSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.companyIdWSSSpinEdit.Location = new System.Drawing.Point(84, 173);
            this.companyIdWSSSpinEdit.Name = "companyIdWSSSpinEdit";
            this.companyIdWSSSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.companyIdWSSSpinEdit.Properties.ReadOnly = true;
            this.companyIdWSSSpinEdit.Size = new System.Drawing.Size(147, 20);
            this.companyIdWSSSpinEdit.TabIndex = 3;
            // 
            // shopNameTextEdit
            // 
            this.shopNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.company_HaravanBindingSource, "ShopName", true));
            this.shopNameTextEdit.Location = new System.Drawing.Point(350, 15);
            this.shopNameTextEdit.Name = "shopNameTextEdit";
            this.shopNameTextEdit.Properties.ReadOnly = true;
            this.shopNameTextEdit.Size = new System.Drawing.Size(153, 20);
            this.shopNameTextEdit.TabIndex = 1;
            // 
            // domainChinhXacTextEdit
            // 
            this.domainChinhXacTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.company_HaravanBindingSource, "DomainChinhXac", true));
            this.domainChinhXacTextEdit.Location = new System.Drawing.Point(131, 114);
            this.domainChinhXacTextEdit.Name = "domainChinhXacTextEdit";
            this.domainChinhXacTextEdit.Properties.ReadOnly = true;
            this.domainChinhXacTextEdit.Size = new System.Drawing.Size(192, 20);
            this.domainChinhXacTextEdit.TabIndex = 1;
            // 
            // companyIdHaravanSpinEdit
            // 
            this.companyIdHaravanSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.company_HaravanBindingSource, "CompanyIdHaravan", true));
            this.companyIdHaravanSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.companyIdHaravanSpinEdit.Location = new System.Drawing.Point(65, 15);
            this.companyIdHaravanSpinEdit.Name = "companyIdHaravanSpinEdit";
            this.companyIdHaravanSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.companyIdHaravanSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.companyIdHaravanSpinEdit.Properties.ReadOnly = true;
            this.companyIdHaravanSpinEdit.Size = new System.Drawing.Size(139, 20);
            this.companyIdHaravanSpinEdit.TabIndex = 3;
            this.companyIdHaravanSpinEdit.EditValueChanged += new System.EventHandler(this.companyIdHaravanSpinEdit_EditValueChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(777, 661);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControlProduct);
            this.xtraTabPage1.Controls.Add(this.panelControl4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(771, 633);
            this.xtraTabPage1.Text = "Sản phẩm Haravan";
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
            this.gridControlProduct.Location = new System.Drawing.Point(0, 48);
            this.gridControlProduct.MainView = this.gridViewProduct;
            this.gridControlProduct.Name = "gridControlProduct";
            this.gridControlProduct.Size = new System.Drawing.Size(771, 585);
            this.gridControlProduct.TabIndex = 1;
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
            this.gridColumn5,
            this.gridColumn6});
            this.gridViewProduct.GridControl = this.gridControlProduct;
            this.gridViewProduct.Name = "gridViewProduct";
            this.gridViewProduct.OptionsView.ShowAutoFilterRow = true;
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
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControlMessage);
            this.panelControl4.Controls.Add(this.UpdateProductButton);
            this.panelControl4.Controls.Add(this.TestProductButton);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(771, 48);
            this.panelControl4.TabIndex = 0;
            // 
            // labelControlMessage
            // 
            this.labelControlMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControlMessage.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControlMessage.Location = new System.Drawing.Point(87, 17);
            this.labelControlMessage.Name = "labelControlMessage";
            this.labelControlMessage.Size = new System.Drawing.Size(46, 14);
            this.labelControlMessage.TabIndex = 2;
            this.labelControlMessage.Text = "Message";
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateProductButton.Location = new System.Drawing.Point(645, 5);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(104, 38);
            this.UpdateProductButton.TabIndex = 1;
            this.UpdateProductButton.Text = "Update Product";
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // TestProductButton
            // 
            this.TestProductButton.Location = new System.Drawing.Point(6, 5);
            this.TestProductButton.Name = "TestProductButton";
            this.TestProductButton.Size = new System.Drawing.Size(75, 38);
            this.TestProductButton.TabIndex = 0;
            this.TestProductButton.Text = "TestProduct";
            this.TestProductButton.Click += new System.EventHandler(this.TestProductButton_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.labelControlMessageImage);
            this.xtraTabPage2.Controls.Add(this.richTextBoxMessage);
            this.xtraTabPage2.Controls.Add(this.DownloadImageThieuButton);
            this.xtraTabPage2.Controls.Add(this.DownloadAllImageButton);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.PageVisible = false;
            this.xtraTabPage2.Size = new System.Drawing.Size(771, 633);
            this.xtraTabPage2.Text = "Ảnh sản phẩm";
            // 
            // labelControlMessageImage
            // 
            this.labelControlMessageImage.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelControlMessageImage.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControlMessageImage.Location = new System.Drawing.Point(185, 43);
            this.labelControlMessageImage.Name = "labelControlMessageImage";
            this.labelControlMessageImage.Size = new System.Drawing.Size(46, 14);
            this.labelControlMessageImage.TabIndex = 3;
            this.labelControlMessageImage.Text = "Message";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(10, 126);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(693, 204);
            this.richTextBoxMessage.TabIndex = 2;
            this.richTextBoxMessage.Text = "";
            // 
            // DownloadImageThieuButton
            // 
            this.DownloadImageThieuButton.Location = new System.Drawing.Point(554, 20);
            this.DownloadImageThieuButton.Name = "DownloadImageThieuButton";
            this.DownloadImageThieuButton.Size = new System.Drawing.Size(149, 65);
            this.DownloadImageThieuButton.TabIndex = 1;
            this.DownloadImageThieuButton.Text = "Download Ảnh thiếu";
            this.DownloadImageThieuButton.Click += new System.EventHandler(this.DownloadImageThieuButton_Click);
            // 
            // DownloadAllImageButton
            // 
            this.DownloadAllImageButton.Location = new System.Drawing.Point(21, 20);
            this.DownloadAllImageButton.Name = "DownloadAllImageButton";
            this.DownloadAllImageButton.Size = new System.Drawing.Size(149, 65);
            this.DownloadAllImageButton.TabIndex = 0;
            this.DownloadAllImageButton.Text = "Download lại toàn bộ ảnh";
            this.DownloadAllImageButton.Click += new System.EventHandler(this.DownloadAllImageButton_Click);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.productGridControl);
            this.xtraTabPage3.Controls.Add(this.panelControl5);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(771, 633);
            this.xtraTabPage3.Text = "SP trong Database";
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
            this.productGridControl.Location = new System.Drawing.Point(0, 48);
            this.productGridControl.MainView = this.gridView2;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.Size = new System.Drawing.Size(771, 585);
            this.productGridControl.TabIndex = 1;
            this.productGridControl.UseEmbeddedNavigator = true;
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBWebPartner;
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
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.LoadProductDatabaseButton);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(0, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(771, 48);
            this.panelControl5.TabIndex = 0;
            // 
            // LoadProductDatabaseButton
            // 
            this.LoadProductDatabaseButton.Location = new System.Drawing.Point(6, 14);
            this.LoadProductDatabaseButton.Name = "LoadProductDatabaseButton";
            this.LoadProductDatabaseButton.Size = new System.Drawing.Size(75, 23);
            this.LoadProductDatabaseButton.TabIndex = 0;
            this.LoadProductDatabaseButton.Text = "LoadAll";
            this.LoadProductDatabaseButton.Click += new System.EventHandler(this.LoadProductDatabaseButton_Click);
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.panelControl6);
            this.xtraTabPage4.Controls.Add(this.panelControl3);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(771, 633);
            this.xtraTabPage4.Text = "Cập nhật Domain";
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.groupControl3);
            this.panelControl6.Controls.Add(this.groupControl2);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl6.Location = new System.Drawing.Point(0, 180);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(771, 453);
            this.panelControl6.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControlCompany);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 67);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(767, 384);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Công ty đã check";
            // 
            // gridControlCompany
            // 
            this.gridControlCompany.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlCompany.DataSource = this.companySearchBindingSource;
            this.gridControlCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCompany.Location = new System.Drawing.Point(2, 21);
            this.gridControlCompany.MainView = this.gridViewCompany;
            this.gridControlCompany.Name = "gridControlCompany";
            this.gridControlCompany.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControlCompany.Size = new System.Drawing.Size(763, 361);
            this.gridControlCompany.TabIndex = 0;
            this.gridControlCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCompany});
            // 
            // companySearchBindingSource
            // 
            this.companySearchBindingSource.DataMember = "CompanySearch";
            this.companySearchBindingSource.DataSource = this.dBWebPartner;
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
            this.gridViewCompany.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewCompany_MouseDown);
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
            this.repositoryItemLookUpEdit1.DataSource = this.companyStatusBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Description";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // companyStatusBindingSource
            // 
            this.companyStatusBindingSource.DataMember = "Company_Status";
            this.companyStatusBindingSource.DataSource = this.dBWebPartner;
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
            this.groupControl2.Controls.Add(this.domainTextEditSearch);
            this.groupControl2.Controls.Add(websiteLabel1);
            this.groupControl2.Controls.Add(this.websiteTextEdit1);
            this.groupControl2.Controls.Add(nameLabel1);
            this.groupControl2.Controls.Add(this.nameTextEdit1);
            this.groupControl2.Controls.Add(iDLabel1);
            this.groupControl2.Controls.Add(this.iDTextEditCompanySearch);
            this.groupControl2.Controls.Add(this.labelControlCheckDomain);
            this.groupControl2.Controls.Add(this.ButtonCheckCompanyByDomain);
            this.groupControl2.Controls.Add(this.textEditDomain);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(767, 65);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Domain muốn thay đổi";
            // 
            // domainTextEditSearch
            // 
            this.domainTextEditSearch.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companySearchBindingSource, "Domain", true));
            this.domainTextEditSearch.Location = new System.Drawing.Point(626, 84);
            this.domainTextEditSearch.Name = "domainTextEditSearch";
            this.domainTextEditSearch.Size = new System.Drawing.Size(100, 20);
            this.domainTextEditSearch.TabIndex = 11;
            // 
            // websiteTextEdit1
            // 
            this.websiteTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companySearchBindingSource, "Website", true));
            this.websiteTextEdit1.Location = new System.Drawing.Point(448, 86);
            this.websiteTextEdit1.Name = "websiteTextEdit1";
            this.websiteTextEdit1.Size = new System.Drawing.Size(100, 20);
            this.websiteTextEdit1.TabIndex = 9;
            // 
            // nameTextEdit1
            // 
            this.nameTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companySearchBindingSource, "Name", true));
            this.nameTextEdit1.Location = new System.Drawing.Point(260, 88);
            this.nameTextEdit1.Name = "nameTextEdit1";
            this.nameTextEdit1.Size = new System.Drawing.Size(100, 20);
            this.nameTextEdit1.TabIndex = 7;
            // 
            // iDTextEditCompanySearch
            // 
            this.iDTextEditCompanySearch.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companySearchBindingSource, "ID", true));
            this.iDTextEditCompanySearch.Location = new System.Drawing.Point(66, 86);
            this.iDTextEditCompanySearch.Name = "iDTextEditCompanySearch";
            this.iDTextEditCompanySearch.Size = new System.Drawing.Size(100, 20);
            this.iDTextEditCompanySearch.TabIndex = 5;
            // 
            // labelControlCheckDomain
            // 
            this.labelControlCheckDomain.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlCheckDomain.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControlCheckDomain.Location = new System.Drawing.Point(410, 34);
            this.labelControlCheckDomain.Name = "labelControlCheckDomain";
            this.labelControlCheckDomain.Size = new System.Drawing.Size(12, 16);
            this.labelControlCheckDomain.TabIndex = 3;
            this.labelControlCheckDomain.Text = "...";
            // 
            // ButtonCheckCompanyByDomain
            // 
            this.ButtonCheckCompanyByDomain.Location = new System.Drawing.Point(267, 31);
            this.ButtonCheckCompanyByDomain.Name = "ButtonCheckCompanyByDomain";
            this.ButtonCheckCompanyByDomain.Size = new System.Drawing.Size(88, 23);
            this.ButtonCheckCompanyByDomain.TabIndex = 2;
            this.ButtonCheckCompanyByDomain.Text = "Check thông tin";
            this.ButtonCheckCompanyByDomain.Click += new System.EventHandler(this.ButtonCheckCompanyByDomain_Click);
            // 
            // textEditDomain
            // 
            this.textEditDomain.Location = new System.Drawing.Point(66, 33);
            this.textEditDomain.Name = "textEditDomain";
            this.textEditDomain.Size = new System.Drawing.Size(192, 20);
            this.textEditDomain.TabIndex = 1;
            this.textEditDomain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditDomain_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Domain";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(771, 180);
            this.panelControl3.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.UnPublicShopButton);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.simpleButtonSave);
            this.groupControl1.Controls.Add(statusLabel);
            this.groupControl1.Controls.Add(this.statusLookUpEdit);
            this.groupControl1.Controls.Add(domainLabel);
            this.groupControl1.Controls.Add(this.domainTextEdit);
            this.groupControl1.Controls.Add(websiteLabel);
            this.groupControl1.Controls.Add(this.websiteTextEdit);
            this.groupControl1.Controls.Add(iDLabel);
            this.groupControl1.Controls.Add(this.iDTextEdit);
            this.groupControl1.Controls.Add(nameLabel);
            this.groupControl1.Controls.Add(this.nameTextEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(767, 176);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin công ty trong Database";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(658, 86);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(7, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "*";
            // 
            // UnPublicShopButton
            // 
            this.UnPublicShopButton.Location = new System.Drawing.Point(517, 120);
            this.UnPublicShopButton.Name = "UnPublicShopButton";
            this.UnPublicShopButton.Size = new System.Drawing.Size(159, 47);
            this.UnPublicShopButton.TabIndex = 7;
            this.UnPublicShopButton.Text = "Ngừng Public Cửa hàng";
            this.UnPublicShopButton.Visible = false;
            this.UnPublicShopButton.Click += new System.EventHandler(this.UnPublicShopButton_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(285, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(7, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "*";
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(358, 120);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(136, 48);
            this.simpleButtonSave.TabIndex = 10;
            this.simpleButtonSave.Text = "Cập nhật dữ liệu mới";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // statusLookUpEdit
            // 
            this.statusLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Status", true));
            this.statusLookUpEdit.Location = new System.Drawing.Point(66, 124);
            this.statusLookUpEdit.Name = "statusLookUpEdit";
            this.statusLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Name")});
            this.statusLookUpEdit.Properties.DataSource = this.companyStatusBindingSource;
            this.statusLookUpEdit.Properties.DisplayMember = "Description";
            this.statusLookUpEdit.Properties.ValueMember = "ID";
            this.statusLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.statusLookUpEdit.TabIndex = 9;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBWebPartner;
            // 
            // domainTextEdit
            // 
            this.domainTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Domain", true));
            this.domainTextEdit.Location = new System.Drawing.Point(66, 83);
            this.domainTextEdit.Name = "domainTextEdit";
            this.domainTextEdit.Size = new System.Drawing.Size(213, 20);
            this.domainTextEdit.TabIndex = 7;
            this.domainTextEdit.EditValueChanged += new System.EventHandler(this.domainTextEdit_EditValueChanged);
            // 
            // websiteTextEdit
            // 
            this.websiteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Website", true));
            this.websiteTextEdit.Location = new System.Drawing.Point(410, 83);
            this.websiteTextEdit.Name = "websiteTextEdit";
            this.websiteTextEdit.Size = new System.Drawing.Size(242, 20);
            this.websiteTextEdit.TabIndex = 5;
            // 
            // iDTextEdit
            // 
            this.iDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "ID", true));
            this.iDTextEdit.Location = new System.Drawing.Point(66, 41);
            this.iDTextEdit.Name = "iDTextEdit";
            this.iDTextEdit.Size = new System.Drawing.Size(213, 20);
            this.iDTextEdit.TabIndex = 3;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(410, 41);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(242, 20);
            this.nameTextEdit.TabIndex = 1;
            // 
            // company_HaravanTableAdapter
            // 
            this.company_HaravanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Company_HaravanTableAdapter = null;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyOldTableAdapter = null;
            this.tableAdapterManager.CompanySearchTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Product_MappingHaravanTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.WebPartner.DBWebPartnerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUpdateDomain,
            this.toolStripMenuItemUnPublic});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 48);
            // 
            // toolStripMenuItemUpdateDomain
            // 
            this.toolStripMenuItemUpdateDomain.Name = "toolStripMenuItemUpdateDomain";
            this.toolStripMenuItemUpdateDomain.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItemUpdateDomain.Text = "Cập nhật Domain";
            this.toolStripMenuItemUpdateDomain.Click += new System.EventHandler(this.toolStripMenuItemUpdateDomain_Click);
            // 
            // toolStripMenuItemUnPublic
            // 
            this.toolStripMenuItemUnPublic.Name = "toolStripMenuItemUnPublic";
            this.toolStripMenuItemUnPublic.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItemUnPublic.Text = "Ngừng Public cửa hàng";
            this.toolStripMenuItemUnPublic.Click += new System.EventHandler(this.toolStripMenuItemUnPublic_Click);
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // company_StatusTableAdapter
            // 
            this.company_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateByDomainToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(259, 26);
            // 
            // UpdateByDomainToolStripMenuItem
            // 
            this.UpdateByDomainToolStripMenuItem.Name = "UpdateByDomainToolStripMenuItem";
            this.UpdateByDomainToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.UpdateByDomainToolStripMenuItem.Text = "Cập nhật dữ liệu sang domain này!";
            this.UpdateByDomainToolStripMenuItem.ToolTipText = "Trường hợp website đã có trong hệ thống nhưng bây giờ cài app thì sử dụng chức nă" +
    "ng này để cập nhật vào domain đã có. VD: chuyển từ demo.myharavan.com -> demo.co" +
    "m";
            this.UpdateByDomainToolStripMenuItem.Click += new System.EventHandler(this.UpdateByDomainToolStripMenuItem_Click);
            // 
            // companySearchTableAdapter
            // 
            this.companySearchTableAdapter.ClearBeforeFill = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "VATStatus";
            this.gridColumn6.FieldName = "VATStatus";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // frmSettingHaravan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 661);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmSettingHaravan";
            this.Text = "frmSettingHaravan";
            this.Load += new System.EventHandler(this.frmSettingHaravan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_HaravanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBWebPartner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accessTokenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isPublicCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyIdWSSSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainChinhXacTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyIdHaravanSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companySearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEditSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEditCompanySearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDomain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBWebPartner dBWebPartner;
        private System.Windows.Forms.BindingSource company_HaravanBindingSource;
        private DBWebPartnerTableAdapters.Company_HaravanTableAdapter company_HaravanTableAdapter;
        private DBWebPartnerTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colShopName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccessToken;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyIdHaravan;
        private DevExpress.XtraGrid.Columns.GridColumn colDomainChinhXac;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyIdWSS;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPublic;
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
        private DevExpress.XtraEditors.TextEdit shopNameTextEdit;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.CheckEdit isPublicCheckEdit;
        private DevExpress.XtraEditors.SpinEdit companyIdWSSSpinEdit;
        private DevExpress.XtraEditors.TextEdit domainChinhXacTextEdit;
        private DevExpress.XtraGrid.GridControl gridControlProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProduct;
        private DevExpress.XtraEditors.SimpleButton UpdateProductButton;
        private DevExpress.XtraEditors.SimpleButton TestProductButton;
        private DevExpress.XtraEditors.SimpleButton UnPublicShopButton;
        private DevExpress.XtraEditors.TextEdit accessTokenTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControlMessage;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton CheckCompanyButton;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private DevExpress.XtraEditors.SimpleButton DownloadImageThieuButton;
        private DevExpress.XtraEditors.SimpleButton DownloadAllImageButton;
        private DevExpress.XtraEditors.LabelControl labelControlMessageImage;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton LoadProductDatabaseButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBWebPartnerTableAdapters.ProductTableAdapter productTableAdapter;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdateDomain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUnPublic;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBWebPartnerTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit statusLookUpEdit;
        private DevExpress.XtraEditors.TextEdit domainTextEdit;
        private DevExpress.XtraEditors.TextEdit websiteTextEdit;
        private DevExpress.XtraEditors.TextEdit iDTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private System.Windows.Forms.BindingSource companyStatusBindingSource;
        private DBWebPartnerTableAdapters.Company_StatusTableAdapter company_StatusTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton ButtonCheckCompanyByDomain;
        private DevExpress.XtraEditors.TextEdit textEditDomain;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.TextEdit companyIdHaravanSpinEdit;
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
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem UpdateByDomainToolStripMenuItem;
        private System.Windows.Forms.BindingSource companySearchBindingSource;
        private DBWebPartnerTableAdapters.CompanySearchTableAdapter companySearchTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControlCheckDomain;
        private DevExpress.XtraEditors.TextEdit domainTextEditSearch;
        private DevExpress.XtraEditors.TextEdit websiteTextEdit1;
        private DevExpress.XtraEditors.TextEdit nameTextEdit1;
        private DevExpress.XtraEditors.TextEdit iDTextEditCompanySearch;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}