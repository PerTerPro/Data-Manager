namespace WSS.Financial.Backend
{
    partial class FrmPropertyGroup
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label parentIdLabel;
            System.Windows.Forms.Label groupLevelLabel;
            System.Windows.Forms.Label viewOrderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPropertyGroup));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ctrCategory1 = new WSS.Financial.Backend.Category.ctrCategory();
            this.treeListPropertyGroup = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCategoryId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemTreeListLookUpEditCategory = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFinancial = new WSS.Financial.Backend.DBFinancial();
            this.repositoryItemTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colGroupLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.propertyGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.propertyGroupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.viewOrderTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnAddPropertyInGroup = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpandGroup = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNodeCha = new DevExpress.XtraEditors.SimpleButton();
            this.AddNewPropertyGroupWithParentId = new DevExpress.XtraEditors.SimpleButton();
            this.deleteParentId = new DevExpress.XtraEditors.SimpleButton();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupLevelTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categoryIdLookUpEdit = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.parentIdLookUpEdit = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.propertyGroupTableAdapter = new WSS.Financial.Backend.DBFinancialTableAdapters.PropertyGroupTableAdapter();
            this.tableAdapterManager = new WSS.Financial.Backend.DBFinancialTableAdapters.TableAdapterManager();
            this.categoryTableAdapter = new WSS.Financial.Backend.DBFinancialTableAdapters.CategoryTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            parentIdLabel = new System.Windows.Forms.Label();
            groupLevelLabel = new System.Windows.Forms.Label();
            viewOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPropertyGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEditCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLevelTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(5, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(103, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(424, 8);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(64, 13);
            categoryIdLabel.TabIndex = 4;
            categoryIdLabel.Text = "Category Id:";
            // 
            // parentIdLabel
            // 
            parentIdLabel.AutoSize = true;
            parentIdLabel.Location = new System.Drawing.Point(424, 38);
            parentIdLabel.Name = "parentIdLabel";
            parentIdLabel.Size = new System.Drawing.Size(53, 13);
            parentIdLabel.TabIndex = 6;
            parentIdLabel.Text = "Parent Id:";
            // 
            // groupLevelLabel
            // 
            groupLevelLabel.AutoSize = true;
            groupLevelLabel.Location = new System.Drawing.Point(11, 38);
            groupLevelLabel.Name = "groupLevelLabel";
            groupLevelLabel.Size = new System.Drawing.Size(68, 13);
            groupLevelLabel.TabIndex = 8;
            groupLevelLabel.Text = "Group Level:";
            // 
            // viewOrderLabel
            // 
            viewOrderLabel.AutoSize = true;
            viewOrderLabel.Location = new System.Drawing.Point(137, 38);
            viewOrderLabel.Name = "viewOrderLabel";
            viewOrderLabel.Size = new System.Drawing.Size(62, 13);
            viewOrderLabel.TabIndex = 15;
            viewOrderLabel.Text = "View Order:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ctrCategory1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.treeListPropertyGroup);
            this.splitContainerControl1.Panel2.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1325, 710);
            this.splitContainerControl1.SplitterPosition = 376;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ctrCategory1
            // 
            this.ctrCategory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrCategory1.Location = new System.Drawing.Point(0, 0);
            this.ctrCategory1.Name = "ctrCategory1";
            this.ctrCategory1.Size = new System.Drawing.Size(376, 710);
            this.ctrCategory1.TabIndex = 0;
            this.ctrCategory1.IdCategoryChanged += new WSS.Financial.Backend.Category.ctrCategory.ChangedEventHandler(this.ctrCategory1_IdCategoryChanged);
            // 
            // treeListPropertyGroup
            // 
            this.treeListPropertyGroup.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colCategoryId,
            this.colGroupLevel,
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeListPropertyGroup.DataSource = this.propertyGroupBindingSource;
            this.treeListPropertyGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListPropertyGroup.KeyFieldName = "Id";
            this.treeListPropertyGroup.Location = new System.Drawing.Point(0, 121);
            this.treeListPropertyGroup.Name = "treeListPropertyGroup";
            this.treeListPropertyGroup.OptionsView.ShowAutoFilterRow = true;
            this.treeListPropertyGroup.ParentFieldName = "ParentId";
            this.treeListPropertyGroup.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTreeListLookUpEditCategory});
            this.treeListPropertyGroup.Size = new System.Drawing.Size(944, 589);
            this.treeListPropertyGroup.TabIndex = 2;
            // 
            // colName
            // 
            this.colName.Caption = "Tên của nhóm group (PropertyGroup)";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 512;
            // 
            // colCategoryId
            // 
            this.colCategoryId.Caption = "Category";
            this.colCategoryId.ColumnEdit = this.repositoryItemTreeListLookUpEditCategory;
            this.colCategoryId.FieldName = "CategoryId";
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.Visible = true;
            this.colCategoryId.VisibleIndex = 4;
            this.colCategoryId.Width = 131;
            // 
            // repositoryItemTreeListLookUpEditCategory
            // 
            this.repositoryItemTreeListLookUpEditCategory.AutoHeight = false;
            this.repositoryItemTreeListLookUpEditCategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTreeListLookUpEditCategory.DataSource = this.categoryBindingSource;
            this.repositoryItemTreeListLookUpEditCategory.DisplayMember = "Name";
            this.repositoryItemTreeListLookUpEditCategory.Name = "repositoryItemTreeListLookUpEditCategory";
            this.repositoryItemTreeListLookUpEditCategory.TreeList = this.repositoryItemTreeListLookUpEdit1TreeList;
            this.repositoryItemTreeListLookUpEditCategory.ValueMember = "Id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dBFinancial;
            // 
            // dBFinancial
            // 
            this.dBFinancial.DataSetName = "DBFinancial";
            this.dBFinancial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemTreeListLookUpEdit1TreeList
            // 
            this.repositoryItemTreeListLookUpEdit1TreeList.DataSource = this.categoryBindingSource;
            this.repositoryItemTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.repositoryItemTreeListLookUpEdit1TreeList.Name = "repositoryItemTreeListLookUpEdit1TreeList";
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colGroupLevel
            // 
            this.colGroupLevel.Caption = "Cấp bậc nhóm";
            this.colGroupLevel.FieldName = "GroupLevel";
            this.colGroupLevel.Name = "colGroupLevel";
            this.colGroupLevel.Visible = true;
            this.colGroupLevel.VisibleIndex = 3;
            this.colGroupLevel.Width = 83;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Id";
            this.treeListColumn1.FieldName = "Id";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 118;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Thứ tự hiển thị";
            this.treeListColumn2.FieldName = "ViewOrder";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 2;
            this.treeListColumn2.Width = 93;
            // 
            // propertyGroupBindingSource
            // 
            this.propertyGroupBindingSource.DataMember = "PropertyGroup";
            this.propertyGroupBindingSource.DataSource = this.dBFinancial;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.propertyGroupBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.propertyGroupBindingNavigatorSaveItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 96);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(944, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // propertyGroupBindingNavigatorSaveItem
            // 
            this.propertyGroupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.propertyGroupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("propertyGroupBindingNavigatorSaveItem.Image")));
            this.propertyGroupBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.propertyGroupBindingNavigatorSaveItem.Name = "propertyGroupBindingNavigatorSaveItem";
            this.propertyGroupBindingNavigatorSaveItem.Size = new System.Drawing.Size(62, 22);
            this.propertyGroupBindingNavigatorSaveItem.Text = "Save Data";
            this.propertyGroupBindingNavigatorSaveItem.Click += new System.EventHandler(this.propertyGroupBindingNavigatorSaveItem_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(viewOrderLabel);
            this.panelControl1.Controls.Add(this.viewOrderTextEdit);
            this.panelControl1.Controls.Add(this.btnAddPropertyInGroup);
            this.panelControl1.Controls.Add(this.btnExpandGroup);
            this.panelControl1.Controls.Add(this.btnAddNodeCha);
            this.panelControl1.Controls.Add(this.AddNewPropertyGroupWithParentId);
            this.panelControl1.Controls.Add(this.deleteParentId);
            this.panelControl1.Controls.Add(idLabel);
            this.panelControl1.Controls.Add(this.idTextEdit);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.nameTextEdit);
            this.panelControl1.Controls.Add(categoryIdLabel);
            this.panelControl1.Controls.Add(parentIdLabel);
            this.panelControl1.Controls.Add(groupLevelLabel);
            this.panelControl1.Controls.Add(this.groupLevelTextEdit);
            this.panelControl1.Controls.Add(this.categoryIdLookUpEdit);
            this.panelControl1.Controls.Add(this.parentIdLookUpEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(944, 96);
            this.panelControl1.TabIndex = 0;
            // 
            // viewOrderTextEdit
            // 
            this.viewOrderTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "ViewOrder", true));
            this.viewOrderTextEdit.Location = new System.Drawing.Point(205, 35);
            this.viewOrderTextEdit.Name = "viewOrderTextEdit";
            this.viewOrderTextEdit.Size = new System.Drawing.Size(100, 20);
            this.viewOrderTextEdit.TabIndex = 16;
            // 
            // btnAddPropertyInGroup
            // 
            this.btnAddPropertyInGroup.Location = new System.Drawing.Point(806, 5);
            this.btnAddPropertyInGroup.Name = "btnAddPropertyInGroup";
            this.btnAddPropertyInGroup.Size = new System.Drawing.Size(126, 51);
            this.btnAddPropertyInGroup.TabIndex = 14;
            this.btnAddPropertyInGroup.Text = "Nhập thuộc tinh \r\ntrong group (Property)";
            this.btnAddPropertyInGroup.Click += new System.EventHandler(this.btnAddPropertyInGroup_Click);
            // 
            // btnExpandGroup
            // 
            this.btnExpandGroup.Location = new System.Drawing.Point(272, 60);
            this.btnExpandGroup.Name = "btnExpandGroup";
            this.btnExpandGroup.Size = new System.Drawing.Size(142, 23);
            this.btnExpandGroup.TabIndex = 13;
            this.btnExpandGroup.Text = "Expand/UnExpand";
            this.btnExpandGroup.Click += new System.EventHandler(this.btnExpandGroup_Click);
            // 
            // btnAddNodeCha
            // 
            this.btnAddNodeCha.Location = new System.Drawing.Point(11, 60);
            this.btnAddNodeCha.Name = "btnAddNodeCha";
            this.btnAddNodeCha.Size = new System.Drawing.Size(107, 23);
            this.btnAddNodeCha.TabIndex = 12;
            this.btnAddNodeCha.Text = "Thêm Node cha";
            this.btnAddNodeCha.Click += new System.EventHandler(this.btnAddNodeCha_Click);
            // 
            // AddNewPropertyGroupWithParentId
            // 
            this.AddNewPropertyGroupWithParentId.Location = new System.Drawing.Point(124, 60);
            this.AddNewPropertyGroupWithParentId.Name = "AddNewPropertyGroupWithParentId";
            this.AddNewPropertyGroupWithParentId.Size = new System.Drawing.Size(142, 23);
            this.AddNewPropertyGroupWithParentId.TabIndex = 11;
            this.AddNewPropertyGroupWithParentId.Text = "Thêm Node con";
            this.AddNewPropertyGroupWithParentId.Click += new System.EventHandler(this.AddNewPropertyGroupWithParentId_Click);
            // 
            // deleteParentId
            // 
            this.deleteParentId.Location = new System.Drawing.Point(679, 32);
            this.deleteParentId.Name = "deleteParentId";
            this.deleteParentId.Size = new System.Drawing.Size(75, 23);
            this.deleteParentId.TabIndex = 10;
            this.deleteParentId.Text = "Bỏ ParentId";
            this.deleteParentId.Click += new System.EventHandler(this.deleteParentId_Click);
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "Id", true));
            this.idTextEdit.Location = new System.Drawing.Point(30, 5);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Size = new System.Drawing.Size(67, 20);
            this.idTextEdit.TabIndex = 1;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "Name", true));
            this.nameTextEdit.EditValue = "";
            this.nameTextEdit.Location = new System.Drawing.Point(147, 5);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.nameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.nameTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.nameTextEdit.Size = new System.Drawing.Size(267, 22);
            this.nameTextEdit.TabIndex = 3;
            // 
            // groupLevelTextEdit
            // 
            this.groupLevelTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "GroupLevel", true));
            this.groupLevelTextEdit.Location = new System.Drawing.Point(85, 35);
            this.groupLevelTextEdit.Name = "groupLevelTextEdit";
            this.groupLevelTextEdit.Size = new System.Drawing.Size(47, 20);
            this.groupLevelTextEdit.TabIndex = 9;
            // 
            // categoryIdLookUpEdit
            // 
            this.categoryIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "CategoryId", true));
            this.categoryIdLookUpEdit.Location = new System.Drawing.Point(498, 5);
            this.categoryIdLookUpEdit.Name = "categoryIdLookUpEdit";
            this.categoryIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryIdLookUpEdit.Properties.DataSource = this.categoryBindingSource;
            this.categoryIdLookUpEdit.Properties.DisplayMember = "Name";
            this.categoryIdLookUpEdit.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.categoryIdLookUpEdit.Properties.ValueMember = "Id";
            this.categoryIdLookUpEdit.Size = new System.Drawing.Size(256, 20);
            this.categoryIdLookUpEdit.TabIndex = 5;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName1});
            this.treeListLookUpEdit1TreeList.DataSource = this.categoryBindingSource;
            this.treeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 192;
            // 
            // parentIdLookUpEdit
            // 
            this.parentIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "ParentId", true));
            this.parentIdLookUpEdit.Location = new System.Drawing.Point(498, 34);
            this.parentIdLookUpEdit.Name = "parentIdLookUpEdit";
            this.parentIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.parentIdLookUpEdit.Properties.DataSource = this.propertyGroupBindingSource;
            this.parentIdLookUpEdit.Properties.DisplayMember = "Name";
            this.parentIdLookUpEdit.Properties.TreeList = this.treeList1;
            this.parentIdLookUpEdit.Properties.ValueMember = "Id";
            this.parentIdLookUpEdit.Size = new System.Drawing.Size(175, 20);
            this.parentIdLookUpEdit.TabIndex = 7;
            // 
            // treeList1
            // 
            this.treeList1.DataSource = this.propertyGroupBindingSource;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.EnableFiltering = true;
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.Size = new System.Drawing.Size(400, 200);
            this.treeList1.TabIndex = 0;
            // 
            // propertyGroupTableAdapter
            // 
            this.propertyGroupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ItemPropertiesTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.PropertyGroupTableAdapter = this.propertyGroupTableAdapter;
            this.tableAdapterManager.PropertyStatusTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.PropertyValueTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.Financial.Backend.DBFinancialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPropertyGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 710);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmPropertyGroup";
            this.Text = "FrmPropertyGroup";
            this.Load += new System.EventHandler(this.FrmPropertyGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListPropertyGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEditCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLevelTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Category.ctrCategory ctrCategory1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource propertyGroupBindingSource;
        private DBFinancialTableAdapters.PropertyGroupTableAdapter propertyGroupTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton propertyGroupBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SimpleButton btnAddNodeCha;
        private DevExpress.XtraEditors.SimpleButton AddNewPropertyGroupWithParentId;
        private DevExpress.XtraEditors.SimpleButton deleteParentId;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit groupLevelTextEdit;
        private DevExpress.XtraEditors.TreeListLookUpEdit categoryIdLookUpEdit;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.TreeListLookUpEdit parentIdLookUpEdit;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.TreeList treeListPropertyGroup;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCategoryId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colGroupLevel;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DBFinancialTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit repositoryItemTreeListLookUpEditCategory;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.SimpleButton btnExpandGroup;
        private DevExpress.XtraEditors.SimpleButton btnAddPropertyInGroup;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.TextEdit viewOrderTextEdit;

    }
}