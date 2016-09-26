namespace QT.Moduls.ProductID
{
    partial class frmEditeTenSanPham
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
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label contentFTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditeTenSanPham));
            DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.chkTimChinhXac = new System.Windows.Forms.CheckBox();
            this.nameCategoryTextBox = new System.Windows.Forms.TextBox();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource();
            this.dBPMan = new QT.Moduls.Maps.DBPMan();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTaiCat = new System.Windows.Forms.ToolStripButton();
            this.toolTaiLai = new System.Windows.Forms.ToolStripButton();
            this.btUpdateMapCat = new System.Windows.Forms.ToolStripButton();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.iDCategoryTextBox = new System.Windows.Forms.TextBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.contentFTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource();
            this.categoryIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btViewWeb = new DevExpress.XtraEditors.SimpleButton();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.btDienTen = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btDoiCategory = new DevExpress.XtraEditors.SimpleButton();
            this.txtCatDoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoiDungCat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btThayThe = new DevExpress.XtraEditors.SimpleButton();
            this.txtNoiDungThayBang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoiDungMuonThay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productStatusBindingSource = new System.Windows.Forms.BindingSource();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.listClassificationSelectBindingSource = new System.Windows.Forms.BindingSource();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.listClassificationTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.ListClassificationTableAdapter();
            this.productTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.ProductTableAdapter();
            this.productStatusTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.ProductStatusTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Maps.DBPManTableAdapters.TableAdapterManager();
            this.listClassificationSelectTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.ListClassificationSelectTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            contentFTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentFTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatDoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungCat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungThayBang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungMuonThay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationSelectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(69, 68);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 6;
            iDLabel.Text = "ID:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(413, 28);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 7;
            iDLabel1.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(664, 28);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Name:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(6, 31);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(38, 13);
            nameLabel1.TabIndex = 7;
            nameLabel1.Text = "Name:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(547, 28);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(66, 13);
            categoryIDLabel.TabIndex = 11;
            categoryIDLabel.Text = "Category ID:";
            // 
            // contentFTLabel
            // 
            contentFTLabel.AutoSize = true;
            contentFTLabel.Location = new System.Drawing.Point(713, 48);
            contentFTLabel.Name = "contentFTLabel";
            contentFTLabel.Size = new System.Drawing.Size(63, 13);
            contentFTLabel.TabIndex = 13;
            contentFTLabel.Text = "Content FT:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.chkTimChinhXac);
            this.splitContainerControl1.Panel1.Controls.Add(nameLabel1);
            this.splitContainerControl1.Panel1.Controls.Add(this.nameCategoryTextBox);
            this.splitContainerControl1.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl1.Panel1.Controls.Add(this.treeList1);
            this.splitContainerControl1.Panel1.Controls.Add(iDLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.iDCategoryTextBox);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit1);
            this.splitContainerControl1.Panel2.Controls.Add(contentFTLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.contentFTTextEdit);
            this.splitContainerControl1.Panel2.Controls.Add(categoryIDLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.categoryIDTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(nameLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.nameTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(iDLabel1);
            this.splitContainerControl1.Panel2.Controls.Add(this.iDTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(this.bindingNavigator2);
            this.splitContainerControl1.Panel2.Controls.Add(this.btViewWeb);
            this.splitContainerControl1.Panel2.Controls.Add(this.btSave);
            this.splitContainerControl1.Panel2.Controls.Add(this.btDienTen);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1262, 645);
            this.splitContainerControl1.SplitterPosition = 435;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // chkTimChinhXac
            // 
            this.chkTimChinhXac.AutoSize = true;
            this.chkTimChinhXac.Checked = true;
            this.chkTimChinhXac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimChinhXac.Location = new System.Drawing.Point(9, 51);
            this.chkTimChinhXac.Name = "chkTimChinhXac";
            this.chkTimChinhXac.Size = new System.Drawing.Size(190, 17);
            this.chkTimChinhXac.TabIndex = 9;
            this.chkTimChinhXac.Text = "Tìm chính xác theo id chuyên mục";
            this.chkTimChinhXac.UseVisualStyleBackColor = true;
            // 
            // nameCategoryTextBox
            // 
            this.nameCategoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "Name", true));
            this.nameCategoryTextBox.Location = new System.Drawing.Point(50, 28);
            this.nameCategoryTextBox.Name = "nameCategoryTextBox";
            this.nameCategoryTextBox.Size = new System.Drawing.Size(383, 20);
            this.nameCategoryTextBox.TabIndex = 8;
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dBPMan;
            // 
            // dBPMan
            // 
            this.dBPMan.DataSetName = "DBPMan";
            this.dBPMan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.listClassificationBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.toolTaiCat,
            this.toolTaiLai,
            this.btUpdateMapCat});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(435, 25);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolTaiCat
            // 
            this.toolTaiCat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolTaiCat.Image = ((System.Drawing.Image)(resources.GetObject("toolTaiCat.Image")));
            this.toolTaiCat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTaiCat.Name = "toolTaiCat";
            this.toolTaiCat.Size = new System.Drawing.Size(55, 22);
            this.toolTaiCat.Text = "LoadCat";
            this.toolTaiCat.Click += new System.EventHandler(this.toolTaiCat_Click);
            // 
            // toolTaiLai
            // 
            this.toolTaiLai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolTaiLai.Image = ((System.Drawing.Image)(resources.GetObject("toolTaiLai.Image")));
            this.toolTaiLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTaiLai.Name = "toolTaiLai";
            this.toolTaiLai.Size = new System.Drawing.Size(57, 22);
            this.toolTaiLai.Text = "LoadALL";
            this.toolTaiLai.Click += new System.EventHandler(this.toolTaiLai_Click);
            // 
            // btUpdateMapCat
            // 
            this.btUpdateMapCat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btUpdateMapCat.Image = ((System.Drawing.Image)(resources.GetObject("btUpdateMapCat.Image")));
            this.btUpdateMapCat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUpdateMapCat.Name = "btUpdateMapCat";
            this.btUpdateMapCat.Size = new System.Drawing.Size(97, 22);
            this.btUpdateMapCat.Text = "Update Map Cat";
            this.btUpdateMapCat.Click += new System.EventHandler(this.btUpdateMapCat_Click);
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName});
            this.treeList1.DataSource = this.listClassificationBindingSource;
            this.treeList1.Location = new System.Drawing.Point(2, 97);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(431, 548);
            this.treeList1.TabIndex = 5;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 61;
            // 
            // iDCategoryTextBox
            // 
            this.iDCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "ID", true));
            this.iDCategoryTextBox.Location = new System.Drawing.Point(96, 65);
            this.iDCategoryTextBox.Name = "iDCategoryTextBox";
            this.iDCategoryTextBox.ReadOnly = true;
            this.iDCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDCategoryTextBox.TabIndex = 7;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(703, 98);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 15;
            // 
            // contentFTTextEdit
            // 
            this.contentFTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "ContentFT", true));
            this.contentFTTextEdit.Location = new System.Drawing.Point(708, 65);
            this.contentFTTextEdit.Name = "contentFTTextEdit";
            this.contentFTTextEdit.Size = new System.Drawing.Size(100, 20);
            this.contentFTTextEdit.TabIndex = 14;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBPMan;
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "CategoryID", true));
            this.categoryIDTextBox.Location = new System.Drawing.Point(619, 25);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.Size = new System.Drawing.Size(37, 20);
            this.categoryIDTextBox.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(708, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(108, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(440, 25);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(103, 20);
            this.iDTextBox.TabIndex = 8;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.productBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator3});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton2;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(822, 25);
            this.bindingNavigator2.TabIndex = 6;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move next";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btViewWeb
            // 
            this.btViewWeb.Appearance.Options.UseTextOptions = true;
            this.btViewWeb.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btViewWeb.Location = new System.Drawing.Point(608, 51);
            this.btViewWeb.Name = "btViewWeb";
            this.btViewWeb.Size = new System.Drawing.Size(89, 67);
            this.btViewWeb.TabIndex = 2;
            this.btViewWeb.Text = "Xem trên website";
            this.btViewWeb.Click += new System.EventHandler(this.btViewWeb_Click);
            // 
            // btSave
            // 
            this.btSave.Appearance.Options.UseTextOptions = true;
            this.btSave.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btSave.Location = new System.Drawing.Point(513, 51);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(89, 67);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Lưu dữ liệu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDienTen
            // 
            this.btDienTen.Appearance.Options.UseTextOptions = true;
            this.btDienTen.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btDienTen.Location = new System.Drawing.Point(418, 51);
            this.btDienTen.Name = "btDienTen";
            this.btDienTen.Size = new System.Drawing.Size(89, 67);
            this.btDienTen.TabIndex = 2;
            this.btDienTen.Text = "Tự động điền tên category vào trước";
            this.btDienTen.Click += new System.EventHandler(this.btDienTen_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btDoiCategory);
            this.groupControl2.Controls.Add(this.txtCatDoi);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtNoiDungCat);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Location = new System.Drawing.Point(207, 25);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 100);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Đổi Category";
            // 
            // btDoiCategory
            // 
            this.btDoiCategory.Location = new System.Drawing.Point(6, 72);
            this.btDoiCategory.Name = "btDoiCategory";
            this.btDoiCategory.Size = new System.Drawing.Size(189, 23);
            this.btDoiCategory.TabIndex = 2;
            this.btDoiCategory.Text = "Đổi Category";
            this.btDoiCategory.Click += new System.EventHandler(this.btDoiCategory_Click);
            // 
            // txtCatDoi
            // 
            this.txtCatDoi.Location = new System.Drawing.Point(61, 51);
            this.txtCatDoi.Name = "txtCatDoi";
            this.txtCatDoi.Size = new System.Drawing.Size(134, 20);
            this.txtCatDoi.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "thay CatID";
            // 
            // txtNoiDungCat
            // 
            this.txtNoiDungCat.Location = new System.Drawing.Point(61, 25);
            this.txtNoiDungCat.Name = "txtNoiDungCat";
            this.txtNoiDungCat.Size = new System.Drawing.Size(134, 20);
            this.txtNoiDungCat.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Nội dung";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btThayThe);
            this.groupControl1.Controls.Add(this.txtNoiDungThayBang);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtNoiDungMuonThay);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 25);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 100);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Nội dung thay thế";
            // 
            // btThayThe
            // 
            this.btThayThe.Location = new System.Drawing.Point(6, 72);
            this.btThayThe.Name = "btThayThe";
            this.btThayThe.Size = new System.Drawing.Size(189, 23);
            this.btThayThe.TabIndex = 2;
            this.btThayThe.Text = "Thay thế";
            this.btThayThe.Click += new System.EventHandler(this.btThayThe_Click);
            // 
            // txtNoiDungThayBang
            // 
            this.txtNoiDungThayBang.Location = new System.Drawing.Point(61, 51);
            this.txtNoiDungThayBang.Name = "txtNoiDungThayBang";
            this.txtNoiDungThayBang.Size = new System.Drawing.Size(134, 20);
            this.txtNoiDungThayBang.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "thay bằng";
            // 
            // txtNoiDungMuonThay
            // 
            this.txtNoiDungMuonThay.Location = new System.Drawing.Point(61, 25);
            this.txtNoiDungMuonThay.Name = "txtNoiDungMuonThay";
            this.txtNoiDungMuonThay.Size = new System.Drawing.Size(134, 20);
            this.txtNoiDungMuonThay.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nội dung";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.productBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 131);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(810, 514);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colValid,
            this.colLastUpdate,
            this.colStatus,
            this.colCategoryID,
            this.colPrice,
            this.colCategoryID1,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colName1
            // 
            this.colName1.Caption = "Tên sản phẩm";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 149;
            // 
            // colValid
            // 
            this.colValid.Caption = "Pulic";
            this.colValid.FieldName = "Valid";
            this.colValid.Name = "colValid";
            this.colValid.OptionsColumn.FixedWidth = true;
            this.colValid.Visible = true;
            this.colValid.VisibleIndex = 4;
            this.colValid.Width = 51;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.DisplayFormat.FormatString = "hh:mm - dd/MM/yy";
            this.colLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.OptionsColumn.AllowEdit = false;
            this.colLastUpdate.OptionsColumn.FixedWidth = true;
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 6;
            this.colLastUpdate.Width = 100;
            // 
            // colStatus
            // 
            repositoryItemLookUpEdit1.AutoHeight = false;
            repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            repositoryItemLookUpEdit1.DisplayMember = "Name";
            repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            repositoryItemLookUpEdit1.ValueMember = "ID";
            this.colStatus.ColumnEdit = repositoryItemLookUpEdit1;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.FixedWidth = true;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            // 
            // productStatusBindingSource
            // 
            this.productStatusBindingSource.DataMember = "ProductStatus";
            this.productStatusBindingSource.DataSource = this.dBPMan;
            // 
            // colCategoryID
            // 
            this.colCategoryID.Caption = "NameCate";
            repositoryItemLookUpEdit2.AutoHeight = false;
            repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NameFull", "Name Full", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            repositoryItemLookUpEdit2.DisplayMember = "NameFull";
            repositoryItemLookUpEdit2.DropDownRows = 30;
            repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEditCategory";
            repositoryItemLookUpEdit2.ValueMember = "ID";
            this.colCategoryID.ColumnEdit = repositoryItemLookUpEdit2;
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 1;
            this.colCategoryID.Width = 89;
            // 
            // listClassificationSelectBindingSource
            // 
            this.listClassificationSelectBindingSource.DataMember = "ListClassificationSelect";
            this.listClassificationSelectBindingSource.DataSource = this.dBPMan;
            // 
            // colPrice
            // 
            this.colPrice.DisplayFormat.FormatString = "n0";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.FixedWidth = true;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // colCategoryID1
            // 
            this.colCategoryID1.Caption = "CategoryID";
            this.colCategoryID1.FieldName = "CategoryID";
            this.colCategoryID1.Name = "colCategoryID1";
            this.colCategoryID1.OptionsColumn.FixedWidth = true;
            this.colCategoryID1.Visible = true;
            this.colCategoryID1.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ContentFT";
            this.gridColumn1.FieldName = "ContentFT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productStatusTableAdapter
            // 
            this.productStatusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ListClassificationTableAdapter = this.listClassificationTableAdapter;
            this.tableAdapterManager.NewsTableAdapter = null;
            this.tableAdapterManager.Product_KeyComparisonTableAdapter = null;
            this.tableAdapterManager.Product_PropertiesTableAdapter = null;
            this.tableAdapterManager.ProductAnanyticTableAdapter = null;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductStatusTableAdapter = this.productStatusTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.Tag_CategoryTableAdapter = null;
            this.tableAdapterManager.Tag_ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Maps.DBPManTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listClassificationSelectTableAdapter
            // 
            this.listClassificationSelectTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditeTenSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1262, 645);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmEditeTenSanPham";
            this.Load += new System.EventHandler(this.frmEditeTenSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentFTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatDoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungCat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungThayBang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDungMuonThay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationSelectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private Maps.DBPMan dBPMan;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private Maps.DBPManTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolTaiCat;
        private System.Windows.Forms.ToolStripButton toolTaiLai;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colValid;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Maps.DBPManTableAdapters.ProductTableAdapter productTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private System.Windows.Forms.BindingSource productStatusBindingSource;
        private Maps.DBPManTableAdapters.ProductStatusTableAdapter productStatusTableAdapter;
        private System.Windows.Forms.TextBox iDCategoryTextBox;
        private Maps.DBPManTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNoiDungThayBang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNoiDungMuonThay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btThayThe;
        private DevExpress.XtraEditors.SimpleButton btDienTen;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.BindingSource listClassificationSelectBindingSource;
        private Maps.DBPManTableAdapters.ListClassificationSelectTableAdapter listClassificationSelectTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btViewWeb;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameCategoryTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btDoiCategory;
        private DevExpress.XtraEditors.TextEdit txtCatDoi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNoiDungCat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox categoryIDTextBox;
        private System.Windows.Forms.ToolStripButton btUpdateMapCat;
        private System.Windows.Forms.CheckBox chkTimChinhXac;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit contentFTTextEdit;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}
