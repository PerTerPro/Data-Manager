namespace QT.Moduls.Maps
{
    partial class ctrProductInCategory
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
            System.Windows.Forms.Label productContentLabel;
            System.Windows.Forms.Label detailUrlLabel;
            System.Windows.Forms.Label promotionLabel;
            System.Windows.Forms.Label imageUrlsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrProductInCategory));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelControlListIDSearch = new DevExpress.XtraEditors.LabelControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator();
            this.productBindingSource = new System.Windows.Forms.BindingSource();
            this.dBMap = new QT.Moduls.Maps.DBMap();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lamssconvert = new DevExpress.XtraEditors.LabelControl();
            this.laIDCateMap = new DevExpress.XtraEditors.LabelControl();
            this.btConvertSPGoc = new DevExpress.XtraEditors.SimpleButton();
            this.btLoadAll = new DevExpress.XtraEditors.SimpleButton();
            this.btLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btMap = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemRichTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.imageUrlsTextBox = new System.Windows.Forms.TextBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.webContent = new System.Windows.Forms.WebBrowser();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.webImage = new System.Windows.Forms.WebBrowser();
            this.bt_Analytic = new DevExpress.XtraEditors.SimpleButton();
            this.promotionTextBox = new System.Windows.Forms.TextBox();
            this.detailUrlTextBox = new System.Windows.Forms.TextBox();
            this.productContentTextBox = new System.Windows.Forms.TextBox();
            this.productTableAdapter = new QT.Moduls.Maps.DBMapTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Maps.DBMapTableAdapters.TableAdapterManager();
            productContentLabel = new System.Windows.Forms.Label();
            detailUrlLabel = new System.Windows.Forms.Label();
            promotionLabel = new System.Windows.Forms.Label();
            imageUrlsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productContentLabel
            // 
            productContentLabel.AutoSize = true;
            productContentLabel.Location = new System.Drawing.Point(8, 6);
            productContentLabel.Name = "productContentLabel";
            productContentLabel.Size = new System.Drawing.Size(87, 13);
            productContentLabel.TabIndex = 0;
            productContentLabel.Text = "Product Content:";
            // 
            // detailUrlLabel
            // 
            detailUrlLabel.AutoSize = true;
            detailUrlLabel.Location = new System.Drawing.Point(42, 32);
            detailUrlLabel.Name = "detailUrlLabel";
            detailUrlLabel.Size = new System.Drawing.Size(53, 13);
            detailUrlLabel.TabIndex = 2;
            detailUrlLabel.Text = "Detail Url:";
            // 
            // promotionLabel
            // 
            promotionLabel.AutoSize = true;
            promotionLabel.Location = new System.Drawing.Point(38, 58);
            promotionLabel.Name = "promotionLabel";
            promotionLabel.Size = new System.Drawing.Size(57, 13);
            promotionLabel.TabIndex = 4;
            promotionLabel.Text = "Promotion:";
            // 
            // imageUrlsLabel
            // 
            imageUrlsLabel.AutoSize = true;
            imageUrlsLabel.Location = new System.Drawing.Point(35, 84);
            imageUrlsLabel.Name = "imageUrlsLabel";
            imageUrlsLabel.Size = new System.Drawing.Size(60, 13);
            imageUrlsLabel.TabIndex = 7;
            imageUrlsLabel.Text = "Image Urls:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControlListIDSearch);
            this.splitContainerControl1.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl1.Panel1.Controls.Add(this.lamssconvert);
            this.splitContainerControl1.Panel1.Controls.Add(this.laIDCateMap);
            this.splitContainerControl1.Panel1.Controls.Add(this.btConvertSPGoc);
            this.splitContainerControl1.Panel1.Controls.Add(this.btLoadAll);
            this.splitContainerControl1.Panel1.Controls.Add(this.btLoad);
            this.splitContainerControl1.Panel1.Controls.Add(this.btMap);
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(imageUrlsLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.imageUrlsTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.bt_Analytic);
            this.splitContainerControl1.Panel2.Controls.Add(promotionLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.promotionTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(detailUrlLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.detailUrlTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(productContentLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.productContentTextBox);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(779, 549);
            this.splitContainerControl1.SplitterPosition = 359;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // labelControlListIDSearch
            // 
            this.labelControlListIDSearch.Location = new System.Drawing.Point(159, 69);
            this.labelControlListIDSearch.Name = "labelControlListIDSearch";
            this.labelControlListIDSearch.Size = new System.Drawing.Size(60, 13);
            this.labelControlListIDSearch.TabIndex = 5;
            this.labelControlListIDSearch.Text = "ListIDSearch";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.productBindingSource;
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
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 524);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(359, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBMap;
            // 
            // dBMap
            // 
            this.dBMap.DataSetName = "DBMap";
            this.dBMap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lamssconvert
            // 
            this.lamssconvert.Location = new System.Drawing.Point(159, 41);
            this.lamssconvert.Name = "lamssconvert";
            this.lamssconvert.Size = new System.Drawing.Size(63, 13);
            this.lamssconvert.TabIndex = 3;
            this.lamssconvert.Text = "labelControl1";
            // 
            // laIDCateMap
            // 
            this.laIDCateMap.Location = new System.Drawing.Point(122, 14);
            this.laIDCateMap.Name = "laIDCateMap";
            this.laIDCateMap.Size = new System.Drawing.Size(63, 13);
            this.laIDCateMap.TabIndex = 3;
            this.laIDCateMap.Text = "labelControl1";
            // 
            // btConvertSPGoc
            // 
            this.btConvertSPGoc.Location = new System.Drawing.Point(62, 35);
            this.btConvertSPGoc.Name = "btConvertSPGoc";
            this.btConvertSPGoc.Size = new System.Drawing.Size(91, 23);
            this.btConvertSPGoc.TabIndex = 2;
            this.btConvertSPGoc.Text = "Chuyển sp gốc";
            this.btConvertSPGoc.Click += new System.EventHandler(this.btConvertSPGoc_Click);
            // 
            // btLoadAll
            // 
            this.btLoadAll.Location = new System.Drawing.Point(4, 64);
            this.btLoadAll.Name = "btLoadAll";
            this.btLoadAll.Size = new System.Drawing.Size(53, 23);
            this.btLoadAll.TabIndex = 2;
            this.btLoadAll.Text = "Load All";
            this.btLoadAll.Click += new System.EventHandler(this.btLoadAll_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(3, 35);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(53, 23);
            this.btLoad.TabIndex = 2;
            this.btLoad.Text = "Load";
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btMap
            // 
            this.btMap.Location = new System.Drawing.Point(4, 6);
            this.btMap.Name = "btMap";
            this.btMap.Size = new System.Drawing.Size(111, 23);
            this.btMap.TabIndex = 2;
            this.btMap.Text = "Map chuyên mục gốc";
            this.btMap.Click += new System.EventHandler(this.btMap_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.productBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 107);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRichTextEdit1,
            this.repositoryItemRichTextEdit2});
            this.gridControl1.Size = new System.Drawing.Size(359, 414);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colProductID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 20;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 178;
            // 
            // colProductID
            // 
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.OptionsColumn.FixedWidth = true;
            this.colProductID.OptionsColumn.ReadOnly = true;
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 1;
            this.colProductID.Width = 50;
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.repositoryItemRichTextEdit1.EncodingWebName = "utf-8";
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // repositoryItemRichTextEdit2
            // 
            this.repositoryItemRichTextEdit2.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.repositoryItemRichTextEdit2.EncodingWebName = "utf-8";
            this.repositoryItemRichTextEdit2.Name = "repositoryItemRichTextEdit2";
            this.repositoryItemRichTextEdit2.ShowCaretInReadOnly = false;
            // 
            // imageUrlsTextBox
            // 
            this.imageUrlsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageUrlsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ImageUrls", true));
            this.imageUrlsTextBox.Location = new System.Drawing.Point(101, 81);
            this.imageUrlsTextBox.Name = "imageUrlsTextBox";
            this.imageUrlsTextBox.Size = new System.Drawing.Size(273, 20);
            this.imageUrlsTextBox.TabIndex = 8;
            this.imageUrlsTextBox.TextChanged += new System.EventHandler(this.imageUrlsTextBox_TextChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 140);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(374, 406);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.webContent);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(368, 378);
            this.xtraTabPage1.Text = "Content";
            // 
            // webContent
            // 
            this.webContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webContent.Location = new System.Drawing.Point(0, 0);
            this.webContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.webContent.Name = "webContent";
            this.webContent.Size = new System.Drawing.Size(368, 378);
            this.webContent.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.webImage);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(368, 378);
            this.xtraTabPage2.Text = "Image";
            // 
            // webImage
            // 
            this.webImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webImage.Location = new System.Drawing.Point(0, 0);
            this.webImage.MinimumSize = new System.Drawing.Size(20, 20);
            this.webImage.Name = "webImage";
            this.webImage.Size = new System.Drawing.Size(368, 378);
            this.webImage.TabIndex = 1;
            // 
            // bt_Analytic
            // 
            this.bt_Analytic.Location = new System.Drawing.Point(4, 111);
            this.bt_Analytic.Name = "bt_Analytic";
            this.bt_Analytic.Size = new System.Drawing.Size(91, 23);
            this.bt_Analytic.TabIndex = 2;
            this.bt_Analytic.Text = "Test Phân tích";
            this.bt_Analytic.Click += new System.EventHandler(this.bt_Analytic_Click);
            // 
            // promotionTextBox
            // 
            this.promotionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promotionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Promotion", true));
            this.promotionTextBox.Location = new System.Drawing.Point(101, 55);
            this.promotionTextBox.Name = "promotionTextBox";
            this.promotionTextBox.Size = new System.Drawing.Size(273, 20);
            this.promotionTextBox.TabIndex = 5;
            this.promotionTextBox.TextChanged += new System.EventHandler(this.promotionTextBox_TextChanged);
            // 
            // detailUrlTextBox
            // 
            this.detailUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailUrlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "DetailUrl", true));
            this.detailUrlTextBox.Location = new System.Drawing.Point(101, 29);
            this.detailUrlTextBox.Name = "detailUrlTextBox";
            this.detailUrlTextBox.Size = new System.Drawing.Size(273, 20);
            this.detailUrlTextBox.TabIndex = 3;
            // 
            // productContentTextBox
            // 
            this.productContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productContentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductContent", true));
            this.productContentTextBox.Location = new System.Drawing.Point(101, 3);
            this.productContentTextBox.Name = "productContentTextBox";
            this.productContentTextBox.Size = new System.Drawing.Size(273, 20);
            this.productContentTextBox.TabIndex = 1;
            this.productContentTextBox.TextChanged += new System.EventHandler(this.productContentTextBox_TextChanged);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_AddressTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.Product_ImageTableAdapter = null;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Maps.DBMapTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ctrProductInCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ctrProductInCategory";
            this.Size = new System.Drawing.Size(779, 549);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBMap dBMap;
        private DBMapTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.TextBox promotionTextBox;
        private System.Windows.Forms.TextBox detailUrlTextBox;
        private System.Windows.Forms.TextBox productContentTextBox;
        private DBMapTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.WebBrowser webContent;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.WebBrowser webImage;
        private DevExpress.XtraEditors.SimpleButton btMap;
        private DevExpress.XtraEditors.LabelControl laIDCateMap;
        private DevExpress.XtraEditors.SimpleButton btLoad;
        private System.Windows.Forms.TextBox imageUrlsTextBox;
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
        private DevExpress.XtraEditors.SimpleButton btConvertSPGoc;
        private DevExpress.XtraEditors.LabelControl lamssconvert;
        private DevExpress.XtraEditors.SimpleButton btLoadAll;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraEditors.SimpleButton bt_Analytic;
        private DevExpress.XtraEditors.LabelControl labelControlListIDSearch;
    }
}
