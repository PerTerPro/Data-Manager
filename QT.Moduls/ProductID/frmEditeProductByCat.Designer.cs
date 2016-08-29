namespace QT.Moduls.ProductID
{
    partial class frmEditeProductByCat
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label imagePathLabel;
            System.Windows.Forms.Label propertiesIDLabel;
            System.Windows.Forms.Label propertiesGroupIDLabel;
            System.Windows.Forms.Label propertiesValueIDLabel;
            System.Windows.Forms.Label sTTLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label valueNameLabel;
            System.Windows.Forms.Label hasNameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label detailUrlLabel;
            System.Windows.Forms.Label imageUrlsLabel;
            System.Windows.Forms.Label lastUpdateLabel;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label validLabel;
            System.Windows.Forms.Label iDLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditeProductByCat));
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productStatusBindingSource = new System.Windows.Forms.BindingSource();
            this.dBProperties = new QT.Moduls.ProductID.DBProperties();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btLoadJobSP = new System.Windows.Forms.Button();
            this.btLoadCatMyJob = new System.Windows.Forms.Button();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colValid1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource();
            this.iDCategoryTextBox = new System.Windows.Forms.TextBox();
            this.btExpan = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.rdbMotTuan = new System.Windows.Forms.RadioButton();
            this.rdbHomNay = new System.Windows.Forms.RadioButton();
            this.btnGetNumberAddNewProduct = new DevExpress.XtraEditors.SimpleButton();
            this.propertiesBindingNavigator = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.btSaveDanhSach = new System.Windows.Forms.ToolStripButton();
            this.btAutoSave = new System.Windows.Forms.ToolStripButton();
            this.toolXoa = new System.Windows.Forms.ToolStripButton();
            this.toolNews = new System.Windows.Forms.ToolStripButton();
            this.validCheckBox = new System.Windows.Forms.CheckBox();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.iDJobTextBox = new System.Windows.Forms.TextBox();
            this.jobSPGocNhapLieuBindingSource = new System.Windows.Forms.BindingSource();
            this.dBJob = new QT.Moduls.ProductID.DBJob();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.productDetailBindingSource = new System.Windows.Forms.BindingSource();
            this.chkDeleteFirst = new System.Windows.Forms.CheckBox();
            this.dateLastUpdate = new DevExpress.XtraEditors.DateEdit();
            this.cboJobStatus = new System.Windows.Forms.ComboBox();
            this.jobNhapLieuStatusBindingSource = new System.Windows.Forms.BindingSource();
            this.btCheck = new DevExpress.XtraEditors.SimpleButton();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.btBiLoi = new DevExpress.XtraEditors.SimpleButton();
            this.btBiThieu = new DevExpress.XtraEditors.SimpleButton();
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.btOpenWeb = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.productPropertiesBindingSource = new System.Windows.Forms.BindingSource();
            this.detailUrlTextBox = new System.Windows.Forms.TextBox();
            this.imageUrlsTextBox = new System.Windows.Forms.TextBox();
            this.gridControlProductProperties = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductProperties = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPropertiesName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValueName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPropertiesValueID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHasName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPropertiesID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeleteAllthuocTinh = new System.Windows.Forms.ToolStripButton();
            this.toolbtSaveValue = new System.Windows.Forms.ToolStripButton();
            this.iDProductTextBox = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.hasNameTextBox = new System.Windows.Forms.TextBox();
            this.valueNameTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.sTTTextBox = new System.Windows.Forms.TextBox();
            this.propertiesValueIDTextBox = new System.Windows.Forms.TextBox();
            this.propertiesGroupIDTextBox = new System.Windows.Forms.TextBox();
            this.propertiesIDTextBox = new System.Windows.Forms.TextBox();
            this.jobNhapLieuStatusConstBindingSource = new System.Windows.Forms.BindingSource();
            this.productTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ProductTableAdapter();
            this.listClassificationTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ListClassificationTableAdapter();
            this.tableAdapterManager = new QT.Moduls.ProductID.DBPropertiesTableAdapters.TableAdapterManager();
            this.product_PropertiesTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.Product_PropertiesTableAdapter();
            this.listClassification_PropertiesBindingSource = new System.Windows.Forms.BindingSource();
            this.listClassification_PropertiesTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ListClassification_PropertiesTableAdapter();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource();
            this.propertiesTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.PropertiesTableAdapter();
            this.propertiesValueBindingSource = new System.Windows.Forms.BindingSource();
            this.propertiesValueTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.PropertiesValueTableAdapter();
            this.productStatusTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ProductStatusTableAdapter();
            this.propertiesConfig_PropertiesBindingSource = new System.Windows.Forms.BindingSource();
            this.propertiesConfig_PropertiesTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.PropertiesConfig_PropertiesTableAdapter();
            this.job_NhapLieuStatusTableAdapter = new QT.Moduls.ProductID.DBJobTableAdapters.Job_NhapLieuStatusTableAdapter();
            this.job_SPGocNhapLieuTableAdapter = new QT.Moduls.ProductID.DBJobTableAdapters.Job_SPGocNhapLieuTableAdapter();
            this.job_NhapLieuStatusConstTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.Job_NhapLieuStatusConstTableAdapter();
            this.tableAdapterManager1 = new QT.Moduls.ProductID.DBJobTableAdapters.TableAdapterManager();
            this.job_SPGocNhapLieuLogBindingSource = new System.Windows.Forms.BindingSource();
            this.job_SPGocNhapLieuLogTableAdapter = new QT.Moduls.ProductID.DBJobTableAdapters.Job_SPGocNhapLieuLogTableAdapter();
            this.productDetailTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ProductDetailTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            imagePathLabel = new System.Windows.Forms.Label();
            propertiesIDLabel = new System.Windows.Forms.Label();
            propertiesGroupIDLabel = new System.Windows.Forms.Label();
            propertiesValueIDLabel = new System.Windows.Forms.Label();
            sTTLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            valueNameLabel = new System.Windows.Forms.Label();
            hasNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            detailUrlLabel = new System.Windows.Forms.Label();
            imageUrlsLabel = new System.Windows.Forms.Label();
            lastUpdateLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            validLabel = new System.Windows.Forms.Label();
            iDLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingNavigator)).BeginInit();
            this.propertiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobSPGocNhapLieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLastUpdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLastUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobNhapLieuStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobNhapLieuStatusConstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassification_PropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesValueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesConfig_PropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_SPGocNhapLieuLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(4, 8);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(53, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // imagePathLabel
            // 
            imagePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            imagePathLabel.AutoSize = true;
            imagePathLabel.Location = new System.Drawing.Point(433, 62);
            imagePathLabel.Name = "imagePathLabel";
            imagePathLabel.Size = new System.Drawing.Size(64, 13);
            imagePathLabel.TabIndex = 4;
            imagePathLabel.Text = "Image Path:";
            // 
            // propertiesIDLabel
            // 
            propertiesIDLabel.AutoSize = true;
            propertiesIDLabel.Location = new System.Drawing.Point(38, 8);
            propertiesIDLabel.Name = "propertiesIDLabel";
            propertiesIDLabel.Size = new System.Drawing.Size(71, 13);
            propertiesIDLabel.TabIndex = 0;
            propertiesIDLabel.Text = "Properties ID:";
            // 
            // propertiesGroupIDLabel
            // 
            propertiesGroupIDLabel.AutoSize = true;
            propertiesGroupIDLabel.Location = new System.Drawing.Point(6, 60);
            propertiesGroupIDLabel.Name = "propertiesGroupIDLabel";
            propertiesGroupIDLabel.Size = new System.Drawing.Size(103, 13);
            propertiesGroupIDLabel.TabIndex = 0;
            propertiesGroupIDLabel.Text = "Properties Group ID:";
            // 
            // propertiesValueIDLabel
            // 
            propertiesValueIDLabel.AutoSize = true;
            propertiesValueIDLabel.Location = new System.Drawing.Point(205, 63);
            propertiesValueIDLabel.Name = "propertiesValueIDLabel";
            propertiesValueIDLabel.Size = new System.Drawing.Size(101, 13);
            propertiesValueIDLabel.TabIndex = 4;
            propertiesValueIDLabel.Text = "Properties Value ID:";
            // 
            // sTTLabel
            // 
            sTTLabel.AutoSize = true;
            sTTLabel.Location = new System.Drawing.Point(78, 86);
            sTTLabel.Name = "sTTLabel";
            sTTLabel.Size = new System.Drawing.Size(31, 13);
            sTTLabel.TabIndex = 6;
            sTTLabel.Text = "STT:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(48, 34);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 8;
            productIDLabel.Text = "Product ID:";
            // 
            // valueNameLabel
            // 
            valueNameLabel.AutoSize = true;
            valueNameLabel.Location = new System.Drawing.Point(238, 11);
            valueNameLabel.Name = "valueNameLabel";
            valueNameLabel.Size = new System.Drawing.Size(68, 13);
            valueNameLabel.TabIndex = 10;
            valueNameLabel.Text = "Value Name:";
            // 
            // hasNameLabel
            // 
            hasNameLabel.AutoSize = true;
            hasNameLabel.Location = new System.Drawing.Point(246, 37);
            hasNameLabel.Name = "hasNameLabel";
            hasNameLabel.Size = new System.Drawing.Size(60, 13);
            hasNameLabel.TabIndex = 12;
            hasNameLabel.Text = "Has Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 13);
            label1.TabIndex = 4;
            label1.Text = "Giá trị nhập vào:";
            // 
            // detailUrlLabel
            // 
            detailUrlLabel.AutoSize = true;
            detailUrlLabel.Location = new System.Drawing.Point(361, 38);
            detailUrlLabel.Name = "detailUrlLabel";
            detailUrlLabel.Size = new System.Drawing.Size(80, 13);
            detailUrlLabel.TabIndex = 15;
            detailUrlLabel.Text = "Link tham khảo";
            // 
            // imageUrlsLabel
            // 
            imageUrlsLabel.AutoSize = true;
            imageUrlsLabel.Location = new System.Drawing.Point(31, 62);
            imageUrlsLabel.Name = "imageUrlsLabel";
            imageUrlsLabel.Size = new System.Drawing.Size(60, 13);
            imageUrlsLabel.TabIndex = 16;
            imageUrlsLabel.Text = "Image Urls:";
            // 
            // lastUpdateLabel
            // 
            lastUpdateLabel.AutoSize = true;
            lastUpdateLabel.Location = new System.Drawing.Point(24, 38);
            lastUpdateLabel.Name = "lastUpdateLabel";
            lastUpdateLabel.Size = new System.Drawing.Size(67, 13);
            lastUpdateLabel.TabIndex = 16;
            lastUpdateLabel.Text = "Cập nhật lúc";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(247, 8);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(40, 13);
            iDLabel1.TabIndex = 7;
            iDLabel1.Text = "IDCate";
            // 
            // validLabel
            // 
            validLabel.AutoSize = true;
            validLabel.Location = new System.Drawing.Point(93, 398);
            validLabel.Name = "validLabel";
            validLabel.Size = new System.Drawing.Size(33, 13);
            validLabel.TabIndex = 9;
            validLabel.Text = "Valid:";
            // 
            // iDLabel2
            // 
            iDLabel2.AutoSize = true;
            iDLabel2.Location = new System.Drawing.Point(544, 159);
            iDLabel2.Name = "iDLabel2";
            iDLabel2.Size = new System.Drawing.Size(35, 13);
            iDLabel2.TabIndex = 23;
            iDLabel2.Text = "IDJob";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit3.DataSource = this.productStatusBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "Name";
            this.repositoryItemLookUpEdit3.LookAndFeel.SkinName = "iMaginary";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "ID";
            // 
            // productStatusBindingSource
            // 
            this.productStatusBindingSource.DataMember = "ProductStatus";
            this.productStatusBindingSource.DataSource = this.dBProperties;
            // 
            // dBProperties
            // 
            this.dBProperties.DataSetName = "DBProperties";
            this.dBProperties.EnforceConstraints = false;
            this.dBProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit4.DisplayMember = "Name";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.ValueMember = "ID";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.propertiesBindingNavigator);
            this.splitContainerControl1.Panel1.Controls.Add(validLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.validCheckBox);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl1.Panel2.Controls.Add(iDLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.iDProductTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1222, 487);
            this.splitContainerControl1.SplitterPosition = 559;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(556, 456);
            this.xtraTabControl1.TabIndex = 11;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(iDLabel1);
            this.xtraTabPage1.Controls.Add(this.btLoadJobSP);
            this.xtraTabPage1.Controls.Add(this.btLoadCatMyJob);
            this.xtraTabPage1.Controls.Add(this.treeList1);
            this.xtraTabPage1.Controls.Add(this.iDCategoryTextBox);
            this.xtraTabPage1.Controls.Add(this.btExpan);
            this.xtraTabPage1.Controls.Add(this.btAddNew);
            this.xtraTabPage1.Controls.Add(this.btLoad);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(550, 428);
            this.xtraTabPage1.Text = "Chọn chuyên mục";
            // 
            // btLoadJobSP
            // 
            this.btLoadJobSP.Location = new System.Drawing.Point(231, 29);
            this.btLoadJobSP.Name = "btLoadJobSP";
            this.btLoadJobSP.Size = new System.Drawing.Size(224, 23);
            this.btLoadJobSP.TabIndex = 7;
            this.btLoadJobSP.Text = "Load Sản phẩm của: ";
            this.btLoadJobSP.UseVisualStyleBackColor = true;
            this.btLoadJobSP.Click += new System.EventHandler(this.btLoadJobSP_Click);
            // 
            // btLoadCatMyJob
            // 
            this.btLoadCatMyJob.Location = new System.Drawing.Point(1, 29);
            this.btLoadCatMyJob.Name = "btLoadCatMyJob";
            this.btLoadCatMyJob.Size = new System.Drawing.Size(224, 23);
            this.btLoadCatMyJob.TabIndex = 8;
            this.btLoadCatMyJob.Text = "Load Chuyên mục của: ";
            this.btLoadCatMyJob.UseVisualStyleBackColor = true;
            this.btLoadCatMyJob.Click += new System.EventHandler(this.btLoadCatMyJob_Click);
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName1,
            this.colValid1});
            this.treeList1.CustomizationFormBounds = new System.Drawing.Rectangle(306, 478, 216, 178);
            this.treeList1.DataSource = this.listClassificationBindingSource;
            this.treeList1.Location = new System.Drawing.Point(1, 58);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(532, 367);
            this.treeList1.TabIndex = 7;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.ReadOnly = true;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 313;
            // 
            // colValid1
            // 
            this.colValid1.FieldName = "Valid";
            this.colValid1.Name = "colValid1";
            this.colValid1.OptionsColumn.FixedWidth = true;
            this.colValid1.OptionsColumn.ReadOnly = true;
            this.colValid1.Visible = true;
            this.colValid1.VisibleIndex = 1;
            this.colValid1.Width = 66;
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dBProperties;
            // 
            // iDCategoryTextBox
            // 
            this.iDCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "ID", true));
            this.iDCategoryTextBox.Location = new System.Drawing.Point(293, 5);
            this.iDCategoryTextBox.Name = "iDCategoryTextBox";
            this.iDCategoryTextBox.ReadOnly = true;
            this.iDCategoryTextBox.Size = new System.Drawing.Size(26, 20);
            this.iDCategoryTextBox.TabIndex = 8;
            // 
            // btExpan
            // 
            this.btExpan.Location = new System.Drawing.Point(163, 4);
            this.btExpan.Name = "btExpan";
            this.btExpan.Size = new System.Drawing.Size(75, 23);
            this.btExpan.TabIndex = 6;
            this.btExpan.Text = "Expan";
            this.btExpan.UseVisualStyleBackColor = true;
            this.btExpan.Click += new System.EventHandler(this.btExpan_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(82, 4);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(75, 23);
            this.btAddNew.TabIndex = 6;
            this.btAddNew.Text = "AddNew";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(1, 4);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 6;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.nameLabel2);
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(550, 428);
            this.xtraTabPage2.Text = "Danh sách sản phẩm";
            // 
            // nameLabel2
            // 
            this.nameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "Name", true));
            this.nameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(84, 6);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(461, 23);
            this.nameLabel2.TabIndex = 9;
            this.nameLabel2.Text = "label2";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.productBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(0, 32);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(548, 392);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBProperties;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colPrice,
            this.colLastUpdate,
            this.colStatus,
            this.colValid,
            this.colCategoryID,
            this.colViewCount,
            this.colJobStatus});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "JobStatus", null, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 184;
            // 
            // colPrice
            // 
            this.colPrice.DisplayFormat.FormatString = "n0";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.FixedWidth = true;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 65;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.Caption = "Cập nhật";
            this.colLastUpdate.DisplayFormat.FormatString = "hh:mm-dd/MM/yy";
            this.colLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.OptionsColumn.FixedWidth = true;
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 3;
            this.colLastUpdate.Width = 70;
            // 
            // colStatus
            // 
            this.colStatus.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.FixedWidth = true;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            this.colStatus.Width = 60;
            // 
            // colValid
            // 
            this.colValid.Caption = "Public";
            this.colValid.FieldName = "Valid";
            this.colValid.Name = "colValid";
            this.colValid.OptionsColumn.FixedWidth = true;
            this.colValid.Visible = true;
            this.colValid.VisibleIndex = 4;
            this.colValid.Width = 50;
            // 
            // colCategoryID
            // 
            this.colCategoryID.Caption = "Category";
            this.colCategoryID.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.OptionsColumn.FixedWidth = true;
            this.colCategoryID.Width = 83;
            // 
            // colViewCount
            // 
            this.colViewCount.DisplayFormat.FormatString = "n0";
            this.colViewCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colViewCount.FieldName = "ViewCount";
            this.colViewCount.Name = "colViewCount";
            this.colViewCount.OptionsColumn.FixedWidth = true;
            this.colViewCount.OptionsColumn.ReadOnly = true;
            this.colViewCount.Visible = true;
            this.colViewCount.VisibleIndex = 0;
            this.colViewCount.Width = 50;
            // 
            // colJobStatus
            // 
            this.colJobStatus.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colJobStatus.FieldName = "JobStatus";
            this.colJobStatus.Name = "colJobStatus";
            this.colJobStatus.OptionsColumn.AllowEdit = false;
            this.colJobStatus.OptionsColumn.FixedWidth = true;
            this.colJobStatus.Visible = true;
            this.colJobStatus.VisibleIndex = 6;
            this.colJobStatus.Width = 55;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl1);
            this.xtraTabPage3.Controls.Add(this.panelControl2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(550, 428);
            this.xtraTabPage3.Text = "DS Thêm mới";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(0, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(550, 381);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.rdbMotTuan);
            this.panelControl2.Controls.Add(this.rdbHomNay);
            this.panelControl2.Controls.Add(this.btnGetNumberAddNewProduct);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(550, 47);
            this.panelControl2.TabIndex = 0;
            // 
            // rdbMotTuan
            // 
            this.rdbMotTuan.AutoSize = true;
            this.rdbMotTuan.Location = new System.Drawing.Point(128, 18);
            this.rdbMotTuan.Name = "rdbMotTuan";
            this.rdbMotTuan.Size = new System.Drawing.Size(55, 17);
            this.rdbMotTuan.TabIndex = 2;
            this.rdbMotTuan.Text = "1 tuần";
            this.rdbMotTuan.UseVisualStyleBackColor = true;
            // 
            // rdbHomNay
            // 
            this.rdbHomNay.AutoSize = true;
            this.rdbHomNay.Checked = true;
            this.rdbHomNay.Location = new System.Drawing.Point(22, 18);
            this.rdbHomNay.Name = "rdbHomNay";
            this.rdbHomNay.Size = new System.Drawing.Size(67, 17);
            this.rdbHomNay.TabIndex = 1;
            this.rdbHomNay.TabStop = true;
            this.rdbHomNay.Text = "Hôm nay";
            this.rdbHomNay.UseVisualStyleBackColor = true;
            // 
            // btnGetNumberAddNewProduct
            // 
            this.btnGetNumberAddNewProduct.Location = new System.Drawing.Point(473, 12);
            this.btnGetNumberAddNewProduct.Name = "btnGetNumberAddNewProduct";
            this.btnGetNumberAddNewProduct.Size = new System.Drawing.Size(56, 23);
            this.btnGetNumberAddNewProduct.TabIndex = 0;
            this.btnGetNumberAddNewProduct.Text = "Get";
            this.btnGetNumberAddNewProduct.Click += new System.EventHandler(this.btnGetNumberAddNewProduct_Click);
            // 
            // propertiesBindingNavigator
            // 
            this.propertiesBindingNavigator.AddNewItem = null;
            this.propertiesBindingNavigator.BindingSource = this.productBindingSource;
            this.propertiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.propertiesBindingNavigator.DeleteItem = null;
            this.propertiesBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.btSaveDanhSach,
            this.btAutoSave,
            this.toolXoa,
            this.toolNews});
            this.propertiesBindingNavigator.Location = new System.Drawing.Point(0, 462);
            this.propertiesBindingNavigator.MoveFirstItem = null;
            this.propertiesBindingNavigator.MoveLastItem = null;
            this.propertiesBindingNavigator.MoveNextItem = null;
            this.propertiesBindingNavigator.MovePreviousItem = null;
            this.propertiesBindingNavigator.Name = "propertiesBindingNavigator";
            this.propertiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propertiesBindingNavigator.Size = new System.Drawing.Size(559, 25);
            this.propertiesBindingNavigator.TabIndex = 4;
            this.propertiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(25, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // btSaveDanhSach
            // 
            this.btSaveDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btSaveDanhSach.Image")));
            this.btSaveDanhSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSaveDanhSach.Name = "btSaveDanhSach";
            this.btSaveDanhSach.Size = new System.Drawing.Size(104, 22);
            this.btSaveDanhSach.Text = "Lưu danh sách";
            this.btSaveDanhSach.Click += new System.EventHandler(this.btSaveDanhSach_Click);
            // 
            // btAutoSave
            // 
            this.btAutoSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btAutoSave.Image = ((System.Drawing.Image)(resources.GetObject("btAutoSave.Image")));
            this.btAutoSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAutoSave.Name = "btAutoSave";
            this.btAutoSave.Size = new System.Drawing.Size(61, 22);
            this.btAutoSave.Text = "AutoSave";
            this.btAutoSave.Click += new System.EventHandler(this.btAutoSave_Click);
            // 
            // toolXoa
            // 
            this.toolXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolXoa.Image = ((System.Drawing.Image)(resources.GetObject("toolXoa.Image")));
            this.toolXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolXoa.Name = "toolXoa";
            this.toolXoa.Size = new System.Drawing.Size(71, 22);
            this.toolXoa.Text = "Xóa SP Gốc";
            this.toolXoa.Click += new System.EventHandler(this.toolXoa_Click);
            // 
            // toolNews
            // 
            this.toolNews.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolNews.Image = ((System.Drawing.Image)(resources.GetObject("toolNews.Image")));
            this.toolNews.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNews.Name = "toolNews";
            this.toolNews.Size = new System.Drawing.Size(106, 22);
            this.toolNews.Text = "Thêm mới SP Gốc";
            this.toolNews.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // validCheckBox
            // 
            this.validCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "Valid", true));
            this.validCheckBox.Enabled = false;
            this.validCheckBox.Location = new System.Drawing.Point(132, 393);
            this.validCheckBox.Name = "validCheckBox";
            this.validCheckBox.Size = new System.Drawing.Size(104, 24);
            this.validCheckBox.TabIndex = 10;
            this.validCheckBox.Text = "checkBox1";
            this.validCheckBox.UseVisualStyleBackColor = true;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(iDLabel2);
            this.splitContainerControl2.Panel1.Controls.Add(this.iDJobTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(this.nameTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(this.chkDeleteFirst);
            this.splitContainerControl2.Panel1.Controls.Add(this.dateLastUpdate);
            this.splitContainerControl2.Panel1.Controls.Add(this.cboJobStatus);
            this.splitContainerControl2.Panel1.Controls.Add(lastUpdateLabel);
            this.splitContainerControl2.Panel1.Controls.Add(nameLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.btCheck);
            this.splitContainerControl2.Panel1.Controls.Add(this.imagePathTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(this.btBiLoi);
            this.splitContainerControl2.Panel1.Controls.Add(imagePathLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.btBiThieu);
            this.splitContainerControl2.Panel1.Controls.Add(label1);
            this.splitContainerControl2.Panel1.Controls.Add(this.btOk);
            this.splitContainerControl2.Panel1.Controls.Add(this.btOpenWeb);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl2.Panel1.Controls.Add(this.memoEdit1);
            this.splitContainerControl2.Panel1.Controls.Add(this.detailUrlTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(detailUrlLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.imageUrlsTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(imageUrlsLabel);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControlProductProperties);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(643, 459);
            this.splitContainerControl2.SplitterPosition = 188;
            this.splitContainerControl2.TabIndex = 24;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // iDJobTextBox
            // 
            this.iDJobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobSPGocNhapLieuBindingSource, "ID", true));
            this.iDJobTextBox.Location = new System.Drawing.Point(585, 156);
            this.iDJobTextBox.Name = "iDJobTextBox";
            this.iDJobTextBox.ReadOnly = true;
            this.iDJobTextBox.Size = new System.Drawing.Size(42, 20);
            this.iDJobTextBox.TabIndex = 24;
            // 
            // jobSPGocNhapLieuBindingSource
            // 
            this.jobSPGocNhapLieuBindingSource.DataMember = "Job_SPGocNhapLieu";
            this.jobSPGocNhapLieuBindingSource.DataSource = this.dBJob;
            // 
            // dBJob
            // 
            this.dBJob.DataSetName = "DBJob";
            this.dBJob.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(97, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(529, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // productDetailBindingSource
            // 
            this.productDetailBindingSource.DataMember = "ProductDetail";
            this.productDetailBindingSource.DataSource = this.dBProperties;
            // 
            // chkDeleteFirst
            // 
            this.chkDeleteFirst.AutoSize = true;
            this.chkDeleteFirst.Checked = true;
            this.chkDeleteFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeleteFirst.Location = new System.Drawing.Point(237, 36);
            this.chkDeleteFirst.Name = "chkDeleteFirst";
            this.chkDeleteFirst.Size = new System.Drawing.Size(118, 17);
            this.chkDeleteFirst.TabIndex = 19;
            this.chkDeleteFirst.Text = "Delete trước khi lưu";
            this.chkDeleteFirst.UseVisualStyleBackColor = true;
            // 
            // dateLastUpdate
            // 
            this.dateLastUpdate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "LastUpdate", true));
            this.dateLastUpdate.EditValue = null;
            this.dateLastUpdate.Enabled = false;
            this.dateLastUpdate.Location = new System.Drawing.Point(97, 34);
            this.dateLastUpdate.Name = "dateLastUpdate";
            this.dateLastUpdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateLastUpdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateLastUpdate.Properties.Mask.EditMask = "hh:mm - dd/MM/yyyy";
            this.dateLastUpdate.Size = new System.Drawing.Size(134, 20);
            this.dateLastUpdate.TabIndex = 17;
            // 
            // cboJobStatus
            // 
            this.cboJobStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jobSPGocNhapLieuBindingSource, "JobStatus", true));
            this.cboJobStatus.DataSource = this.jobNhapLieuStatusBindingSource;
            this.cboJobStatus.DisplayMember = "Name";
            this.cboJobStatus.FormattingEnabled = true;
            this.cboJobStatus.Location = new System.Drawing.Point(97, 155);
            this.cboJobStatus.Name = "cboJobStatus";
            this.cboJobStatus.Size = new System.Drawing.Size(101, 21);
            this.cboJobStatus.TabIndex = 23;
            this.cboJobStatus.ValueMember = "ID";
            // 
            // jobNhapLieuStatusBindingSource
            // 
            this.jobNhapLieuStatusBindingSource.DataMember = "Job_NhapLieuStatus";
            this.jobNhapLieuStatusBindingSource.DataSource = this.dBJob;
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(447, 154);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 23);
            this.btCheck.TabIndex = 22;
            this.btCheck.Text = "Đã &Duyệt";
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailBindingSource, "ImagePath", true));
            this.imagePathTextBox.Location = new System.Drawing.Point(502, 59);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.ReadOnly = true;
            this.imagePathTextBox.Size = new System.Drawing.Size(124, 20);
            this.imagePathTextBox.TabIndex = 5;
            // 
            // btBiLoi
            // 
            this.btBiLoi.Location = new System.Drawing.Point(366, 154);
            this.btBiLoi.Name = "btBiLoi";
            this.btBiLoi.Size = new System.Drawing.Size(75, 23);
            this.btBiLoi.TabIndex = 22;
            this.btBiLoi.Text = "&Bị lỗi";
            this.btBiLoi.Click += new System.EventHandler(this.btBiLoi_Click);
            // 
            // btBiThieu
            // 
            this.btBiThieu.Location = new System.Drawing.Point(285, 154);
            this.btBiThieu.Name = "btBiThieu";
            this.btBiThieu.Size = new System.Drawing.Size(75, 23);
            this.btBiThieu.TabIndex = 22;
            this.btBiThieu.Text = "Còn &thiếu";
            this.btBiThieu.Click += new System.EventHandler(this.btBiThieu_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(204, 154);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 22;
            this.btOk.Text = "Nhập &xong";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btOpenWeb
            // 
            this.btOpenWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpenWeb.Location = new System.Drawing.Point(581, 33);
            this.btOpenWeb.Name = "btOpenWeb";
            this.btOpenWeb.Size = new System.Drawing.Size(45, 23);
            this.btOpenWeb.TabIndex = 14;
            this.btOpenWeb.Text = "Open";
            this.btOpenWeb.Click += new System.EventHandler(this.btSaveValue_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 156);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Trạng thái job:";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productPropertiesBindingSource, "ValueName", true));
            this.memoEdit1.Location = new System.Drawing.Point(97, 85);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(529, 64);
            this.memoEdit1.TabIndex = 2;
            this.memoEdit1.EditValueChanged += new System.EventHandler(this.memoEdit1_EditValueChanged);
            // 
            // productPropertiesBindingSource
            // 
            this.productPropertiesBindingSource.DataMember = "Product_Properties";
            this.productPropertiesBindingSource.DataSource = this.dBProperties;
            // 
            // detailUrlTextBox
            // 
            this.detailUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailUrlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailBindingSource, "DetailUrl", true));
            this.detailUrlTextBox.Location = new System.Drawing.Point(447, 35);
            this.detailUrlTextBox.Name = "detailUrlTextBox";
            this.detailUrlTextBox.Size = new System.Drawing.Size(128, 20);
            this.detailUrlTextBox.TabIndex = 0;
            // 
            // imageUrlsTextBox
            // 
            this.imageUrlsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageUrlsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailBindingSource, "ImageUrls", true));
            this.imageUrlsTextBox.Location = new System.Drawing.Point(97, 59);
            this.imageUrlsTextBox.Name = "imageUrlsTextBox";
            this.imageUrlsTextBox.Size = new System.Drawing.Size(336, 20);
            this.imageUrlsTextBox.TabIndex = 1;
            // 
            // gridControlProductProperties
            // 
            this.gridControlProductProperties.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProductProperties.DataSource = this.productPropertiesBindingSource;
            this.gridControlProductProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductProperties.Location = new System.Drawing.Point(0, 0);
            this.gridControlProductProperties.MainView = this.gridViewProductProperties;
            this.gridControlProductProperties.Name = "gridControlProductProperties";
            this.gridControlProductProperties.Size = new System.Drawing.Size(643, 266);
            this.gridControlProductProperties.TabIndex = 6;
            this.gridControlProductProperties.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductProperties});
            // 
            // gridViewProductProperties
            // 
            this.gridViewProductProperties.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroupName,
            this.colPropertiesName,
            this.colValueName,
            this.colPropertiesValueID,
            this.colSTT,
            this.colHasName,
            this.colUnit,
            this.colPropertiesID});
            this.gridViewProductProperties.GridControl = this.gridControlProductProperties;
            this.gridViewProductProperties.GroupCount = 1;
            this.gridViewProductProperties.Name = "gridViewProductProperties";
            this.gridViewProductProperties.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProductProperties.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGroupName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colGroupName
            // 
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Width = 115;
            // 
            // colPropertiesName
            // 
            this.colPropertiesName.FieldName = "PropertiesName";
            this.colPropertiesName.Name = "colPropertiesName";
            this.colPropertiesName.OptionsColumn.FixedWidth = true;
            this.colPropertiesName.Visible = true;
            this.colPropertiesName.VisibleIndex = 1;
            this.colPropertiesName.Width = 280;
            // 
            // colValueName
            // 
            this.colValueName.FieldName = "ValueName";
            this.colValueName.Name = "colValueName";
            this.colValueName.Visible = true;
            this.colValueName.VisibleIndex = 2;
            this.colValueName.Width = 96;
            // 
            // colPropertiesValueID
            // 
            this.colPropertiesValueID.FieldName = "PropertiesValueID";
            this.colPropertiesValueID.Name = "colPropertiesValueID";
            this.colPropertiesValueID.Visible = true;
            this.colPropertiesValueID.VisibleIndex = 6;
            this.colPropertiesValueID.Width = 167;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.FixedWidth = true;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 4;
            this.colSTT.Width = 40;
            // 
            // colHasName
            // 
            this.colHasName.FieldName = "HasName";
            this.colHasName.Name = "colHasName";
            this.colHasName.Visible = true;
            this.colHasName.VisibleIndex = 5;
            this.colHasName.Width = 65;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Đơn vị";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.FixedWidth = true;
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 3;
            this.colUnit.Width = 60;
            // 
            // colPropertiesID
            // 
            this.colPropertiesID.FieldName = "PropertiesID";
            this.colPropertiesID.Name = "colPropertiesID";
            this.colPropertiesID.Visible = true;
            this.colPropertiesID.VisibleIndex = 0;
            this.colPropertiesID.Width = 76;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.productPropertiesBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.toolStripButtonDeleteAllthuocTinh,
            this.bindingNavigatorDeleteItem,
            this.toolbtSaveValue});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 462);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(658, 25);
            this.bindingNavigator1.TabIndex = 18;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(138, 22);
            this.bindingNavigatorDeleteItem.Text = "Xóa giá trị thuộc tính";
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
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
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
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
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
            // toolStripButtonDeleteAllthuocTinh
            // 
            this.toolStripButtonDeleteAllthuocTinh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeleteAllthuocTinh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteAllthuocTinh.Image")));
            this.toolStripButtonDeleteAllthuocTinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteAllthuocTinh.Name = "toolStripButtonDeleteAllthuocTinh";
            this.toolStripButtonDeleteAllthuocTinh.Size = new System.Drawing.Size(142, 22);
            this.toolStripButtonDeleteAllthuocTinh.Text = "Xóa hết giá trị thuộc tính";
            this.toolStripButtonDeleteAllthuocTinh.Click += new System.EventHandler(this.toolStripButtonDeleteAllthuocTinh_Click);
            // 
            // toolbtSaveValue
            // 
            this.toolbtSaveValue.Image = ((System.Drawing.Image)(resources.GetObject("toolbtSaveValue.Image")));
            this.toolbtSaveValue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtSaveValue.Name = "toolbtSaveValue";
            this.toolbtSaveValue.Size = new System.Drawing.Size(142, 22);
            this.toolbtSaveValue.Text = "Save giá trị thuộc tính";
            this.toolbtSaveValue.Click += new System.EventHandler(this.toolbtSaveValue_Click);
            // 
            // iDProductTextBox
            // 
            this.iDProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDProductTextBox.Location = new System.Drawing.Point(31, 5);
            this.iDProductTextBox.Name = "iDProductTextBox";
            this.iDProductTextBox.ReadOnly = true;
            this.iDProductTextBox.Size = new System.Drawing.Size(122, 20);
            this.iDProductTextBox.TabIndex = 1;
            this.iDProductTextBox.TextChanged += new System.EventHandler(this.iDProductTextBox_TextChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(hasNameLabel);
            this.panelControl1.Controls.Add(this.hasNameTextBox);
            this.panelControl1.Controls.Add(valueNameLabel);
            this.panelControl1.Controls.Add(this.valueNameTextBox);
            this.panelControl1.Controls.Add(productIDLabel);
            this.panelControl1.Controls.Add(this.productIDTextBox);
            this.panelControl1.Controls.Add(sTTLabel);
            this.panelControl1.Controls.Add(this.sTTTextBox);
            this.panelControl1.Controls.Add(propertiesValueIDLabel);
            this.panelControl1.Controls.Add(this.propertiesValueIDTextBox);
            this.panelControl1.Controls.Add(propertiesGroupIDLabel);
            this.panelControl1.Controls.Add(this.propertiesGroupIDTextBox);
            this.panelControl1.Controls.Add(propertiesIDLabel);
            this.panelControl1.Controls.Add(this.propertiesIDTextBox);
            this.panelControl1.Location = new System.Drawing.Point(46, 233);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(449, 30);
            this.panelControl1.TabIndex = 7;
            // 
            // hasNameTextBox
            // 
            this.hasNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productPropertiesBindingSource, "HasName", true));
            this.hasNameTextBox.Location = new System.Drawing.Point(312, 34);
            this.hasNameTextBox.Name = "hasNameTextBox";
            this.hasNameTextBox.ReadOnly = true;
            this.hasNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.hasNameTextBox.TabIndex = 13;
            // 
            // valueNameTextBox
            // 
            this.valueNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productPropertiesBindingSource, "ValueName", true));
            this.valueNameTextBox.Location = new System.Drawing.Point(312, 8);
            this.valueNameTextBox.Name = "valueNameTextBox";
            this.valueNameTextBox.ReadOnly = true;
            this.valueNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueNameTextBox.TabIndex = 11;
            this.valueNameTextBox.TextChanged += new System.EventHandler(this.valueNameTextBox_TextChanged);
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productPropertiesBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(115, 31);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.ReadOnly = true;
            this.productIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.productIDTextBox.TabIndex = 9;
            // 
            // sTTTextBox
            // 
            this.sTTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productPropertiesBindingSource, "STT", true));
            this.sTTTextBox.Location = new System.Drawing.Point(115, 83);
            this.sTTTextBox.Name = "sTTTextBox";
            this.sTTTextBox.ReadOnly = true;
            this.sTTTextBox.Size = new System.Drawing.Size(100, 20);
            this.sTTTextBox.TabIndex = 7;
            // 
            // propertiesValueIDTextBox
            // 
            this.propertiesValueIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productPropertiesBindingSource, "PropertiesValueID", true));
            this.propertiesValueIDTextBox.Location = new System.Drawing.Point(312, 60);
            this.propertiesValueIDTextBox.Name = "propertiesValueIDTextBox";
            this.propertiesValueIDTextBox.ReadOnly = true;
            this.propertiesValueIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.propertiesValueIDTextBox.TabIndex = 5;
            // 
            // propertiesGroupIDTextBox
            // 
            this.propertiesGroupIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productPropertiesBindingSource, "PropertiesGroupID", true));
            this.propertiesGroupIDTextBox.Location = new System.Drawing.Point(115, 57);
            this.propertiesGroupIDTextBox.Name = "propertiesGroupIDTextBox";
            this.propertiesGroupIDTextBox.ReadOnly = true;
            this.propertiesGroupIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.propertiesGroupIDTextBox.TabIndex = 3;
            // 
            // propertiesIDTextBox
            // 
            this.propertiesIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productPropertiesBindingSource, "PropertiesID", true));
            this.propertiesIDTextBox.Location = new System.Drawing.Point(115, 5);
            this.propertiesIDTextBox.Name = "propertiesIDTextBox";
            this.propertiesIDTextBox.ReadOnly = true;
            this.propertiesIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.propertiesIDTextBox.TabIndex = 1;
            // 
            // jobNhapLieuStatusConstBindingSource
            // 
            this.jobNhapLieuStatusConstBindingSource.DataMember = "Job_NhapLieuStatusConst";
            this.jobNhapLieuStatusConstBindingSource.DataSource = this.dBProperties;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.ListClassification_PropertiesTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.Product_PropertiesTableAdapter = null;
            this.tableAdapterManager.ProductDetailTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.PropertiesConfig_PropertiesTableAdapter = null;
            this.tableAdapterManager.PropertiesConfigTableAdapter = null;
            this.tableAdapterManager.PropertiesGroupTableAdapter = null;
            this.tableAdapterManager.PropertiesTableAdapter = null;
            this.tableAdapterManager.PropertiesValueTableAdapter = null;
            this.tableAdapterManager.PropertiesViewTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.ProductID.DBPropertiesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // product_PropertiesTableAdapter
            // 
            this.product_PropertiesTableAdapter.ClearBeforeFill = true;
            // 
            // listClassification_PropertiesBindingSource
            // 
            this.listClassification_PropertiesBindingSource.DataMember = "ListClassification_Properties";
            this.listClassification_PropertiesBindingSource.DataSource = this.dBProperties;
            // 
            // listClassification_PropertiesTableAdapter
            // 
            this.listClassification_PropertiesTableAdapter.ClearBeforeFill = true;
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "Properties";
            this.propertiesBindingSource.DataSource = this.dBProperties;
            // 
            // propertiesTableAdapter
            // 
            this.propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // propertiesValueBindingSource
            // 
            this.propertiesValueBindingSource.DataMember = "PropertiesValue";
            this.propertiesValueBindingSource.DataSource = this.dBProperties;
            // 
            // propertiesValueTableAdapter
            // 
            this.propertiesValueTableAdapter.ClearBeforeFill = true;
            // 
            // productStatusTableAdapter
            // 
            this.productStatusTableAdapter.ClearBeforeFill = true;
            // 
            // propertiesConfig_PropertiesBindingSource
            // 
            this.propertiesConfig_PropertiesBindingSource.DataMember = "PropertiesConfig_Properties";
            this.propertiesConfig_PropertiesBindingSource.DataSource = this.dBProperties;
            // 
            // propertiesConfig_PropertiesTableAdapter
            // 
            this.propertiesConfig_PropertiesTableAdapter.ClearBeforeFill = true;
            // 
            // job_NhapLieuStatusTableAdapter
            // 
            this.job_NhapLieuStatusTableAdapter.ClearBeforeFill = true;
            // 
            // job_SPGocNhapLieuTableAdapter
            // 
            this.job_SPGocNhapLieuTableAdapter.ClearBeforeFill = true;
            // 
            // job_NhapLieuStatusConstTableAdapter
            // 
            this.job_NhapLieuStatusConstTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Job_SPGocNhapLieuLogTableAdapter = null;
            this.tableAdapterManager1.Job_SPGocNhapLieuTableAdapter = this.job_SPGocNhapLieuTableAdapter;
            this.tableAdapterManager1.UpdateOrder = QT.Moduls.ProductID.DBJobTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // job_SPGocNhapLieuLogBindingSource
            // 
            this.job_SPGocNhapLieuLogBindingSource.DataMember = "Job_SPGocNhapLieuLog";
            this.job_SPGocNhapLieuLogBindingSource.DataSource = this.dBJob;
            // 
            // job_SPGocNhapLieuLogTableAdapter
            // 
            this.job_SPGocNhapLieuLogTableAdapter.ClearBeforeFill = true;
            // 
            // productDetailTableAdapter
            // 
            this.productDetailTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditeProductByCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1222, 487);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmEditeProductByCat";
            this.Load += new System.EventHandler(this.frmEditeProductByCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingNavigator)).EndInit();
            this.propertiesBindingNavigator.ResumeLayout(false);
            this.propertiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jobSPGocNhapLieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLastUpdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLastUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobNhapLieuStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobNhapLieuStatusConstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassification_PropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesValueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesConfig_PropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_SPGocNhapLieuLogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingNavigator propertiesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private DBProperties dBProperties;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBPropertiesTableAdapters.ProductTableAdapter productTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colValid;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DBPropertiesTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.TextBox imagePathTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox iDProductTextBox;
        private DBPropertiesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridControlProductProperties;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductProperties;
        private System.Windows.Forms.BindingSource productPropertiesBindingSource;
        private DBPropertiesTableAdapters.Product_PropertiesTableAdapter product_PropertiesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPropertiesValueID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private System.Windows.Forms.BindingSource listClassification_PropertiesBindingSource;
        private DBPropertiesTableAdapters.ListClassification_PropertiesTableAdapter listClassification_PropertiesTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox sTTTextBox;
        private System.Windows.Forms.TextBox propertiesValueIDTextBox;
        private System.Windows.Forms.TextBox propertiesGroupIDTextBox;
        private System.Windows.Forms.TextBox propertiesIDTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private DBPropertiesTableAdapters.PropertiesTableAdapter propertiesTableAdapter;
        private System.Windows.Forms.TextBox hasNameTextBox;
        private System.Windows.Forms.TextBox valueNameTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colPropertiesName;
        private DevExpress.XtraGrid.Columns.GridColumn colValueName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private System.Windows.Forms.BindingSource propertiesValueBindingSource;
        private DBPropertiesTableAdapters.PropertiesValueTableAdapter propertiesValueTableAdapter;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.TextBox detailUrlTextBox;
        private System.Windows.Forms.TextBox imageUrlsTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraEditors.DateEdit dateLastUpdate;
        private System.Windows.Forms.ToolStripButton btSaveDanhSach;
        private System.Windows.Forms.BindingSource productStatusBindingSource;
        private DBPropertiesTableAdapters.ProductStatusTableAdapter productStatusTableAdapter;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colValid1;
        private System.Windows.Forms.TextBox iDCategoryTextBox;
        private System.Windows.Forms.Label nameLabel2;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraEditors.SimpleButton btOpenWeb;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton toolbtSaveValue;
        private System.Windows.Forms.CheckBox chkDeleteFirst;
        private DevExpress.XtraGrid.Columns.GridColumn colHasName;
        private System.Windows.Forms.ToolStripButton btAutoSave;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private System.Windows.Forms.ToolStripButton toolXoa;
        private System.Windows.Forms.CheckBox validCheckBox;
        private System.Windows.Forms.ToolStripButton toolNews;
        private DevExpress.XtraGrid.Columns.GridColumn colPropertiesID;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Button btExpan;
        private System.Windows.Forms.BindingSource propertiesConfig_PropertiesBindingSource;
        private DBPropertiesTableAdapters.PropertiesConfig_PropertiesTableAdapter propertiesConfig_PropertiesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colViewCount;
        private System.Windows.Forms.Button btLoadJobSP;
        private System.Windows.Forms.Button btLoadCatMyJob;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btCheck;
        private DevExpress.XtraEditors.SimpleButton btOk;
        private System.Windows.Forms.ComboBox cboJobStatus;
        private DBJob dBJob;
        private System.Windows.Forms.BindingSource jobNhapLieuStatusBindingSource;
        private DBJobTableAdapters.Job_NhapLieuStatusTableAdapter job_NhapLieuStatusTableAdapter;
        private System.Windows.Forms.BindingSource jobSPGocNhapLieuBindingSource;
        private DBJobTableAdapters.Job_SPGocNhapLieuTableAdapter job_SPGocNhapLieuTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btBiThieu;
        private DevExpress.XtraEditors.SimpleButton btBiLoi;
        private DevExpress.XtraGrid.Columns.GridColumn colJobStatus;
        private System.Windows.Forms.BindingSource jobNhapLieuStatusConstBindingSource;
        private DBPropertiesTableAdapters.Job_NhapLieuStatusConstTableAdapter job_NhapLieuStatusConstTableAdapter;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.TextBox iDJobTextBox;
        private DBJobTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource job_SPGocNhapLieuLogBindingSource;
        private DBJobTableAdapters.Job_SPGocNhapLieuLogTableAdapter job_SPGocNhapLieuLogTableAdapter;
        private System.Windows.Forms.BindingSource productDetailBindingSource;
        private DBPropertiesTableAdapters.ProductDetailTableAdapter productDetailTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteAllthuocTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.RadioButton rdbMotTuan;
        private System.Windows.Forms.RadioButton rdbHomNay;
        private DevExpress.XtraEditors.SimpleButton btnGetNumberAddNewProduct;
    }
}
