namespace QT.Moduls.Tag
{
    partial class frmTagSPGoc
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label tagLabel;
            System.Windows.Forms.Label tagLabel1;
            System.Windows.Forms.Label lastUpdateLabel;
            System.Windows.Forms.Label lastUpdateLabel1;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label productIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTagSPGoc));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTag = new QT.Moduls.Tag.DBTag();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLoadCat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoadAllSPGoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.CategoryTab = new DevExpress.XtraTab.XtraTabPage();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colValid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.iDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ProductTab = new DevExpress.XtraTab.XtraTabPage();
            this.productGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassificationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarranty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPromotion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageUrls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastPriceChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNews = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHashName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImagePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContentFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.nameTextEditProduct = new DevExpress.XtraEditors.TextEdit();
            this.iDTextEditProduct = new DevExpress.XtraEditors.TextEdit();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.categoryIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tag_CategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastUpdateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.checkEditCategory = new DevExpress.XtraEditors.CheckEdit();
            this.tagRichTextBoxCategory = new System.Windows.Forms.RichTextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.productIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tag_ProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastUpdateDateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.checkEditProduct = new DevExpress.XtraEditors.CheckEdit();
            this.tagRichTextBoxProduct = new System.Windows.Forms.RichTextBox();
            this.listClassificationTableAdapter = new QT.Moduls.Tag.DBTagTableAdapters.ListClassificationTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Tag.DBTagTableAdapters.TableAdapterManager();
            this.productTableAdapter = new QT.Moduls.Tag.DBTagTableAdapters.ProductTableAdapter();
            this.productStatusTableAdapter = new QT.Moduls.Tag.DBTagTableAdapters.ProductStatusTableAdapter();
            this.tag_CategoryTableAdapter = new QT.Moduls.Tag.DBTagTableAdapters.Tag_CategoryTableAdapter();
            this.tag_ProductTableAdapter = new QT.Moduls.Tag.DBTagTableAdapters.Tag_ProductTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            tagLabel = new System.Windows.Forms.Label();
            tagLabel1 = new System.Windows.Forms.Label();
            lastUpdateLabel = new System.Windows.Forms.Label();
            lastUpdateLabel1 = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.CategoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            this.ProductTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEditProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEditProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tag_CategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastUpdateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastUpdateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tag_ProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastUpdateDateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastUpdateDateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditProduct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(225, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(8, 12);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(4, 12);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 0;
            iDLabel1.Text = "ID:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(176, 12);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 2;
            nameLabel1.Text = "Name:";
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Location = new System.Drawing.Point(12, 35);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new System.Drawing.Size(29, 13);
            tagLabel.TabIndex = 0;
            tagLabel.Text = "Tag:";
            // 
            // tagLabel1
            // 
            tagLabel1.AutoSize = true;
            tagLabel1.Location = new System.Drawing.Point(12, 36);
            tagLabel1.Name = "tagLabel1";
            tagLabel1.Size = new System.Drawing.Size(29, 13);
            tagLabel1.TabIndex = 0;
            tagLabel1.Text = "Tag:";
            // 
            // lastUpdateLabel
            // 
            lastUpdateLabel.AutoSize = true;
            lastUpdateLabel.Location = new System.Drawing.Point(438, 35);
            lastUpdateLabel.Name = "lastUpdateLabel";
            lastUpdateLabel.Size = new System.Drawing.Size(68, 13);
            lastUpdateLabel.TabIndex = 3;
            lastUpdateLabel.Text = "Last Update:";
            // 
            // lastUpdateLabel1
            // 
            lastUpdateLabel1.AutoSize = true;
            lastUpdateLabel1.Location = new System.Drawing.Point(438, 36);
            lastUpdateLabel1.Name = "lastUpdateLabel1";
            lastUpdateLabel1.Size = new System.Drawing.Size(68, 13);
            lastUpdateLabel1.TabIndex = 3;
            lastUpdateLabel1.Text = "Last Update:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(440, 102);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(66, 13);
            categoryIDLabel.TabIndex = 5;
            categoryIDLabel.Text = "Category ID:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(438, 100);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 5;
            productIDLabel.Text = "Product ID:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.productBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
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
            this.toolStripButtonLoadCat,
            this.toolStripButtonLoadAllSPGoc,
            this.toolStripButtonSave});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1184, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBTag;
            // 
            // dBTag
            // 
            this.dBTag.DataSetName = "DBTag";
            this.dBTag.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // toolStripButtonLoadCat
            // 
            this.toolStripButtonLoadCat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoadCat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadCat.Image")));
            this.toolStripButtonLoadCat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadCat.Name = "toolStripButtonLoadCat";
            this.toolStripButtonLoadCat.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonLoadCat.Text = "Load Cat";
            this.toolStripButtonLoadCat.Click += new System.EventHandler(this.toolStripButtonLoadCat_Click);
            // 
            // toolStripButtonLoadAllSPGoc
            // 
            this.toolStripButtonLoadAllSPGoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoadAllSPGoc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadAllSPGoc.Image")));
            this.toolStripButtonLoadAllSPGoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadAllSPGoc.Name = "toolStripButtonLoadAllSPGoc";
            this.toolStripButtonLoadAllSPGoc.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonLoadAllSPGoc.Text = "LoadAll";
            this.toolStripButtonLoadAllSPGoc.Click += new System.EventHandler(this.toolStripButtonLoadAllSPGoc_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(77, 22);
            this.toolStripButtonSave.Text = "Save (Strl+S)";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 25);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1184, 536);
            this.splitContainerControl1.SplitterPosition = 502;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.CategoryTab;
            this.xtraTabControl1.Size = new System.Drawing.Size(502, 536);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.CategoryTab,
            this.ProductTab});
            // 
            // CategoryTab
            // 
            this.CategoryTab.Controls.Add(this.treeList1);
            this.CategoryTab.Controls.Add(this.panelControl1);
            this.CategoryTab.Name = "CategoryTab";
            this.CategoryTab.Size = new System.Drawing.Size(494, 507);
            this.CategoryTab.Text = "Chuyên mục";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colDescription,
            this.colValid,
            this.treeListColumnID});
            this.treeList1.DataSource = this.listClassificationBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 36);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(494, 471);
            this.treeList1.TabIndex = 2;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 323;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 196;
            // 
            // colValid
            // 
            this.colValid.FieldName = "Valid";
            this.colValid.Name = "colValid";
            this.colValid.Visible = true;
            this.colValid.VisibleIndex = 2;
            this.colValid.Width = 42;
            // 
            // treeListColumnID
            // 
            this.treeListColumnID.Caption = "ID";
            this.treeListColumnID.FieldName = "ID";
            this.treeListColumnID.Name = "treeListColumnID";
            this.treeListColumnID.Visible = true;
            this.treeListColumnID.VisibleIndex = 0;
            this.treeListColumnID.Width = 68;
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dBTag;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(iDLabel);
            this.panelControl1.Controls.Add(this.iDTextEdit);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.nameTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(494, 36);
            this.panelControl1.TabIndex = 1;
            // 
            // iDTextEdit
            // 
            this.iDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.listClassificationBindingSource, "ID", true));
            this.iDTextEdit.Location = new System.Drawing.Point(35, 9);
            this.iDTextEdit.Name = "iDTextEdit";
            this.iDTextEdit.Size = new System.Drawing.Size(168, 20);
            this.iDTextEdit.TabIndex = 3;
            this.iDTextEdit.EditValueChanged += new System.EventHandler(this.iDTextEdit_EditValueChanged);
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.listClassificationBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(269, 9);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(180, 20);
            this.nameTextEdit.TabIndex = 1;
            // 
            // ProductTab
            // 
            this.ProductTab.Controls.Add(this.productGridControl);
            this.ProductTab.Controls.Add(this.panelControl4);
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Size = new System.Drawing.Size(494, 507);
            this.ProductTab.Text = "Sản phẩm gốc";
            // 
            // productGridControl
            // 
            this.productGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.productGridControl.DataSource = this.productBindingSource;
            this.productGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridControl.Location = new System.Drawing.Point(0, 34);
            this.productGridControl.MainView = this.gridViewProduct;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditStatus});
            this.productGridControl.Size = new System.Drawing.Size(494, 473);
            this.productGridControl.TabIndex = 1;
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProduct});
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colClassificationID,
            this.colPrice,
            this.colWarranty,
            this.colStatus,
            this.colCompany,
            this.colLastUpdate1,
            this.colProductID1,
            this.colPromotion,
            this.colSummary,
            this.colProductContent,
            this.colName1,
            this.colDetailUrl,
            this.colImageUrls,
            this.colNameFT,
            this.colValid1,
            this.colLastPriceChange,
            this.colPriceChange,
            this.colIsNews,
            this.colHashName,
            this.colImagePath,
            this.colCategoryID,
            this.colContentFT,
            this.colViewCount});
            this.gridViewProduct.GridControl = this.productGridControl;
            this.gridViewProduct.Name = "gridViewProduct";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 57;
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
            // 
            // colWarranty
            // 
            this.colWarranty.FieldName = "Warranty";
            this.colWarranty.Name = "colWarranty";
            // 
            // colStatus
            // 
            this.colStatus.ColumnEdit = this.repositoryItemLookUpEditStatus;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 67;
            // 
            // repositoryItemLookUpEditStatus
            // 
            this.repositoryItemLookUpEditStatus.AutoHeight = false;
            this.repositoryItemLookUpEditStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditStatus.DataSource = this.productStatusBindingSource;
            this.repositoryItemLookUpEditStatus.Name = "repositoryItemLookUpEditStatus";
            // 
            // productStatusBindingSource
            // 
            this.productStatusBindingSource.DataMember = "ProductStatus";
            this.productStatusBindingSource.DataSource = this.dBTag;
            // 
            // colCompany
            // 
            this.colCompany.FieldName = "Company";
            this.colCompany.Name = "colCompany";
            // 
            // colLastUpdate1
            // 
            this.colLastUpdate1.FieldName = "LastUpdate";
            this.colLastUpdate1.Name = "colLastUpdate1";
            // 
            // colProductID1
            // 
            this.colProductID1.FieldName = "ProductID";
            this.colProductID1.Name = "colProductID1";
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
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            this.colName1.Width = 136;
            // 
            // colDetailUrl
            // 
            this.colDetailUrl.FieldName = "DetailUrl";
            this.colDetailUrl.Name = "colDetailUrl";
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
            // colValid1
            // 
            this.colValid1.FieldName = "Valid";
            this.colValid1.Name = "colValid1";
            this.colValid1.Visible = true;
            this.colValid1.VisibleIndex = 2;
            this.colValid1.Width = 39;
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
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 4;
            this.colCategoryID.Width = 78;
            // 
            // colContentFT
            // 
            this.colContentFT.FieldName = "ContentFT";
            this.colContentFT.Name = "colContentFT";
            this.colContentFT.Visible = true;
            this.colContentFT.VisibleIndex = 5;
            this.colContentFT.Width = 86;
            // 
            // colViewCount
            // 
            this.colViewCount.FieldName = "ViewCount";
            this.colViewCount.Name = "colViewCount";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(nameLabel1);
            this.panelControl4.Controls.Add(this.nameTextEditProduct);
            this.panelControl4.Controls.Add(iDLabel1);
            this.panelControl4.Controls.Add(this.iDTextEditProduct);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(494, 34);
            this.panelControl4.TabIndex = 0;
            // 
            // nameTextEditProduct
            // 
            this.nameTextEditProduct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Name", true));
            this.nameTextEditProduct.Location = new System.Drawing.Point(220, 9);
            this.nameTextEditProduct.Name = "nameTextEditProduct";
            this.nameTextEditProduct.Size = new System.Drawing.Size(191, 20);
            this.nameTextEditProduct.TabIndex = 3;
            // 
            // iDTextEditProduct
            // 
            this.iDTextEditProduct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "ID", true));
            this.iDTextEditProduct.Location = new System.Drawing.Point(31, 9);
            this.iDTextEditProduct.Name = "iDTextEditProduct";
            this.iDTextEditProduct.Size = new System.Drawing.Size(139, 20);
            this.iDTextEditProduct.TabIndex = 1;
            this.iDTextEditProduct.EditValueChanged += new System.EventHandler(this.iDTextEditProduct_EditValueChanged);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(674, 536);
            this.splitContainerControl2.SplitterPosition = 243;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(categoryIDLabel);
            this.groupControl1.Controls.Add(this.categoryIDTextEdit);
            this.groupControl1.Controls.Add(lastUpdateLabel);
            this.groupControl1.Controls.Add(this.lastUpdateDateEdit);
            this.groupControl1.Controls.Add(this.checkEditCategory);
            this.groupControl1.Controls.Add(tagLabel);
            this.groupControl1.Controls.Add(this.tagRichTextBoxCategory);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(674, 243);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tag Chuyên mục";
            // 
            // categoryIDTextEdit
            // 
            this.categoryIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tag_CategoryBindingSource, "CategoryID", true));
            this.categoryIDTextEdit.Location = new System.Drawing.Point(512, 99);
            this.categoryIDTextEdit.Name = "categoryIDTextEdit";
            this.categoryIDTextEdit.Size = new System.Drawing.Size(100, 20);
            this.categoryIDTextEdit.TabIndex = 6;
            // 
            // tag_CategoryBindingSource
            // 
            this.tag_CategoryBindingSource.DataMember = "Tag_Category";
            this.tag_CategoryBindingSource.DataSource = this.dBTag;
            // 
            // lastUpdateDateEdit
            // 
            this.lastUpdateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tag_CategoryBindingSource, "LastUpdate", true));
            this.lastUpdateDateEdit.EditValue = null;
            this.lastUpdateDateEdit.Location = new System.Drawing.Point(512, 32);
            this.lastUpdateDateEdit.Name = "lastUpdateDateEdit";
            this.lastUpdateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lastUpdateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lastUpdateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.lastUpdateDateEdit.TabIndex = 4;
            // 
            // checkEditCategory
            // 
            this.checkEditCategory.Location = new System.Drawing.Point(648, 32);
            this.checkEditCategory.Name = "checkEditCategory";
            this.checkEditCategory.Properties.Caption = "";
            this.checkEditCategory.Properties.ReadOnly = true;
            this.checkEditCategory.Size = new System.Drawing.Size(17, 19);
            this.checkEditCategory.TabIndex = 2;
            // 
            // tagRichTextBoxCategory
            // 
            this.tagRichTextBoxCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tag_CategoryBindingSource, "Tag", true));
            this.tagRichTextBoxCategory.Location = new System.Drawing.Point(47, 32);
            this.tagRichTextBoxCategory.Name = "tagRichTextBoxCategory";
            this.tagRichTextBoxCategory.Size = new System.Drawing.Size(373, 179);
            this.tagRichTextBoxCategory.TabIndex = 1;
            this.tagRichTextBoxCategory.Text = "";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(productIDLabel);
            this.groupControl2.Controls.Add(this.productIDTextEdit);
            this.groupControl2.Controls.Add(lastUpdateLabel1);
            this.groupControl2.Controls.Add(this.lastUpdateDateEdit1);
            this.groupControl2.Controls.Add(this.checkEditProduct);
            this.groupControl2.Controls.Add(tagLabel1);
            this.groupControl2.Controls.Add(this.tagRichTextBoxProduct);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(674, 285);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Tag sản phẩm gốc";
            // 
            // productIDTextEdit
            // 
            this.productIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tag_ProductBindingSource, "ProductID", true));
            this.productIDTextEdit.Location = new System.Drawing.Point(512, 97);
            this.productIDTextEdit.Name = "productIDTextEdit";
            this.productIDTextEdit.Size = new System.Drawing.Size(153, 20);
            this.productIDTextEdit.TabIndex = 6;
            // 
            // tag_ProductBindingSource
            // 
            this.tag_ProductBindingSource.DataMember = "Tag_Product";
            this.tag_ProductBindingSource.DataSource = this.dBTag;
            // 
            // lastUpdateDateEdit1
            // 
            this.lastUpdateDateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tag_ProductBindingSource, "LastUpdate", true));
            this.lastUpdateDateEdit1.EditValue = null;
            this.lastUpdateDateEdit1.Location = new System.Drawing.Point(512, 33);
            this.lastUpdateDateEdit1.Name = "lastUpdateDateEdit1";
            this.lastUpdateDateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lastUpdateDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lastUpdateDateEdit1.Size = new System.Drawing.Size(100, 20);
            this.lastUpdateDateEdit1.TabIndex = 4;
            // 
            // checkEditProduct
            // 
            this.checkEditProduct.Location = new System.Drawing.Point(648, 30);
            this.checkEditProduct.Name = "checkEditProduct";
            this.checkEditProduct.Properties.Caption = "";
            this.checkEditProduct.Properties.ReadOnly = true;
            this.checkEditProduct.Size = new System.Drawing.Size(17, 19);
            this.checkEditProduct.TabIndex = 3;
            // 
            // tagRichTextBoxProduct
            // 
            this.tagRichTextBoxProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tag_ProductBindingSource, "Tag", true));
            this.tagRichTextBoxProduct.Location = new System.Drawing.Point(47, 33);
            this.tagRichTextBoxProduct.Name = "tagRichTextBoxProduct";
            this.tagRichTextBoxProduct.Size = new System.Drawing.Size(373, 225);
            this.tagRichTextBoxProduct.TabIndex = 1;
            this.tagRichTextBoxProduct.Text = "";
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = this.listClassificationTableAdapter;
            this.tableAdapterManager.ProductStatusTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Tag_CategoryTableAdapter = null;
            this.tableAdapterManager.Tag_ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Tag.DBTagTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productStatusTableAdapter
            // 
            this.productStatusTableAdapter.ClearBeforeFill = true;
            // 
            // tag_CategoryTableAdapter
            // 
            this.tag_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tag_ProductTableAdapter
            // 
            this.tag_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // frmTagSPGoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "frmTagSPGoc";
            this.Text = "frmTagSPGoc";
            this.Load += new System.EventHandler(this.frmTagSPGoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.CategoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            this.ProductTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEditProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEditProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tag_CategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastUpdateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastUpdateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tag_ProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastUpdateDateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastUpdateDateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditProduct.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage CategoryTab;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabPage ProductTab;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DBTag dBTag;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DBTagTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colValid;
        private DevExpress.XtraEditors.TextEdit iDTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DBTagTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadCat;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadAllSPGoc;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBTagTableAdapters.ProductTableAdapter productTableAdapter;
        private DevExpress.XtraGrid.GridControl productGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProduct;
        private DevExpress.XtraEditors.TextEdit nameTextEditProduct;
        private DevExpress.XtraEditors.TextEdit iDTextEditProduct;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colClassificationID;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colWarranty;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID1;
        private DevExpress.XtraGrid.Columns.GridColumn colPromotion;
        private DevExpress.XtraGrid.Columns.GridColumn colSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colProductContent;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colImageUrls;
        private DevExpress.XtraGrid.Columns.GridColumn colNameFT;
        private DevExpress.XtraGrid.Columns.GridColumn colValid1;
        private DevExpress.XtraGrid.Columns.GridColumn colLastPriceChange;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceChange;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNews;
        private DevExpress.XtraGrid.Columns.GridColumn colHashName;
        private DevExpress.XtraGrid.Columns.GridColumn colImagePath;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colContentFT;
        private DevExpress.XtraGrid.Columns.GridColumn colViewCount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditStatus;
        private System.Windows.Forms.BindingSource productStatusBindingSource;
        private DBTagTableAdapters.ProductStatusTableAdapter productStatusTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource tag_CategoryBindingSource;
        private DBTagTableAdapters.Tag_CategoryTableAdapter tag_CategoryTableAdapter;
        private System.Windows.Forms.RichTextBox tagRichTextBoxCategory;
        private System.Windows.Forms.BindingSource tag_ProductBindingSource;
        private DBTagTableAdapters.Tag_ProductTableAdapter tag_ProductTableAdapter;
        private System.Windows.Forms.RichTextBox tagRichTextBoxProduct;
        private DevExpress.XtraEditors.CheckEdit checkEditCategory;
        private DevExpress.XtraEditors.CheckEdit checkEditProduct;
        private DevExpress.XtraEditors.DateEdit lastUpdateDateEdit;
        private DevExpress.XtraEditors.DateEdit lastUpdateDateEdit1;
        private DevExpress.XtraEditors.TextEdit categoryIDTextEdit;
        private DevExpress.XtraEditors.TextEdit productIDTextEdit;

    }
}