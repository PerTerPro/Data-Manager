namespace WSS.Financial
{
    partial class FrmPropertyByCategory
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
            System.Windows.Forms.Label groupIdLabel;
            System.Windows.Forms.Label valueTypeIdLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label viewOrderLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPropertyByCategory));
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFinancial = new WSS.Financial.DBFinancial();
            this.propertyGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyTableAdapter = new WSS.Financial.DBFinancialTableAdapters.PropertyTableAdapter();
            this.tableAdapterManager = new WSS.Financial.DBFinancialTableAdapters.TableAdapterManager();
            this.propertyGroupTableAdapter = new WSS.Financial.DBFinancialTableAdapters.PropertyGroupTableAdapter();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ctrCategory1 = new WSS.Financial.Category.ctrCategory();
            this.propertyGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditGroup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colValueTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditValueType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.propertyValueTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditCategory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colViewOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.propertyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.propertyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.treeListLookUpEditGroup = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListLookUpEditCategory = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.valueTypeIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.unitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.viewOrderTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.categoryTableAdapter = new WSS.Financial.DBFinancialTableAdapters.CategoryTableAdapter();
            this.propertyValueTypeTableAdapter = new WSS.Financial.DBFinancialTableAdapters.PropertyValueTypeTableAdapter();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            groupIdLabel = new System.Windows.Forms.Label();
            valueTypeIdLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            viewOrderLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditValueType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingNavigator)).BeginInit();
            this.propertyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTypeIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(15, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(115, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // groupIdLabel
            // 
            groupIdLabel.AutoSize = true;
            groupIdLabel.Location = new System.Drawing.Point(19, 41);
            groupIdLabel.Name = "groupIdLabel";
            groupIdLabel.Size = new System.Drawing.Size(51, 13);
            groupIdLabel.TabIndex = 4;
            groupIdLabel.Text = "Group Id:";
            // 
            // valueTypeIdLabel
            // 
            valueTypeIdLabel.AutoSize = true;
            valueTypeIdLabel.Location = new System.Drawing.Point(460, 41);
            valueTypeIdLabel.Name = "valueTypeIdLabel";
            valueTypeIdLabel.Size = new System.Drawing.Size(76, 13);
            valueTypeIdLabel.TabIndex = 6;
            valueTypeIdLabel.Text = "Value Type Id:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(19, 67);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(29, 13);
            unitLabel.TabIndex = 8;
            unitLabel.Text = "Unit:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(309, 67);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(64, 13);
            categoryIdLabel.TabIndex = 10;
            categoryIdLabel.Text = "Category Id:";
            // 
            // viewOrderLabel
            // 
            viewOrderLabel.AutoSize = true;
            viewOrderLabel.Location = new System.Drawing.Point(778, 15);
            viewOrderLabel.Name = "viewOrderLabel";
            viewOrderLabel.Size = new System.Drawing.Size(62, 13);
            viewOrderLabel.TabIndex = 12;
            viewOrderLabel.Text = "View Order:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(778, 42);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 14;
            isActiveLabel.Text = "Is Active:";
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataMember = "Property";
            this.propertyBindingSource.DataSource = this.dBFinancial;
            // 
            // dBFinancial
            // 
            this.dBFinancial.DataSetName = "DBFinancial";
            this.dBFinancial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyGroupBindingSource
            // 
            this.propertyGroupBindingSource.DataMember = "PropertyGroup";
            this.propertyGroupBindingSource.DataSource = this.dBFinancial;
            // 
            // propertyTableAdapter
            // 
            this.propertyTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PropertyTableAdapter = this.propertyTableAdapter;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.PropertyValueTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.Financial.DBFinancialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // propertyGroupTableAdapter
            // 
            this.propertyGroupTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ctrCategory1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.propertyGridControl);
            this.splitContainerControl1.Panel2.Controls.Add(this.propertyBindingNavigator);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1622, 713);
            this.splitContainerControl1.SplitterPosition = 404;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ctrCategory1
            // 
            this.ctrCategory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrCategory1.Location = new System.Drawing.Point(0, 0);
            this.ctrCategory1.Name = "ctrCategory1";
            this.ctrCategory1.Size = new System.Drawing.Size(404, 713);
            this.ctrCategory1.TabIndex = 0;
            this.ctrCategory1.IdCategoryChanged += new WSS.Financial.Category.ctrCategory.ChangedEventHandler(this.ctrCategory1_IdCategoryChanged);
            // 
            // propertyGridControl
            // 
            this.propertyGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridControl.DataSource = this.propertyBindingSource;
            this.propertyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl.Location = new System.Drawing.Point(0, 126);
            this.propertyGridControl.MainView = this.gridView1;
            this.propertyGridControl.Name = "propertyGridControl";
            this.propertyGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditGroup,
            this.repositoryItemLookUpEditValueType,
            this.repositoryItemLookUpEditCategory});
            this.propertyGridControl.Size = new System.Drawing.Size(1213, 587);
            this.propertyGridControl.TabIndex = 2;
            this.propertyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colGroupId,
            this.colValueTypeId,
            this.colUnit,
            this.colCategoryId,
            this.colViewOrder,
            this.colIsActive});
            this.gridView1.GridControl = this.propertyGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowHeight = 30;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 55;
            // 
            // colName
            // 
            this.colName.Caption = "Tên thuộc tính";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 409;
            // 
            // colGroupId
            // 
            this.colGroupId.Caption = "Group";
            this.colGroupId.ColumnEdit = this.repositoryItemLookUpEditGroup;
            this.colGroupId.FieldName = "GroupId";
            this.colGroupId.Name = "colGroupId";
            this.colGroupId.OptionsColumn.ReadOnly = true;
            this.colGroupId.Visible = true;
            this.colGroupId.VisibleIndex = 2;
            this.colGroupId.Width = 217;
            // 
            // repositoryItemLookUpEditGroup
            // 
            this.repositoryItemLookUpEditGroup.AutoHeight = false;
            this.repositoryItemLookUpEditGroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditGroup.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Group")});
            this.repositoryItemLookUpEditGroup.DataSource = this.propertyGroupBindingSource;
            this.repositoryItemLookUpEditGroup.DisplayMember = "Name";
            this.repositoryItemLookUpEditGroup.Name = "repositoryItemLookUpEditGroup";
            this.repositoryItemLookUpEditGroup.ValueMember = "Id";
            // 
            // colValueTypeId
            // 
            this.colValueTypeId.Caption = "Kiểu giá trị";
            this.colValueTypeId.ColumnEdit = this.repositoryItemLookUpEditValueType;
            this.colValueTypeId.FieldName = "ValueTypeId";
            this.colValueTypeId.Name = "colValueTypeId";
            this.colValueTypeId.Visible = true;
            this.colValueTypeId.VisibleIndex = 3;
            this.colValueTypeId.Width = 121;
            // 
            // repositoryItemLookUpEditValueType
            // 
            this.repositoryItemLookUpEditValueType.AutoHeight = false;
            this.repositoryItemLookUpEditValueType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditValueType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValueType", "Kiểu giá trị")});
            this.repositoryItemLookUpEditValueType.DataSource = this.propertyValueTypeBindingSource;
            this.repositoryItemLookUpEditValueType.DisplayMember = "ValueType";
            this.repositoryItemLookUpEditValueType.Name = "repositoryItemLookUpEditValueType";
            this.repositoryItemLookUpEditValueType.ValueMember = "Id";
            // 
            // propertyValueTypeBindingSource
            // 
            this.propertyValueTypeBindingSource.DataMember = "PropertyValueType";
            this.propertyValueTypeBindingSource.DataSource = this.dBFinancial;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 4;
            this.colUnit.Width = 101;
            // 
            // colCategoryId
            // 
            this.colCategoryId.Caption = "Category";
            this.colCategoryId.ColumnEdit = this.repositoryItemLookUpEditCategory;
            this.colCategoryId.FieldName = "CategoryId";
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.OptionsColumn.ReadOnly = true;
            this.colCategoryId.Visible = true;
            this.colCategoryId.VisibleIndex = 5;
            this.colCategoryId.Width = 131;
            // 
            // repositoryItemLookUpEditCategory
            // 
            this.repositoryItemLookUpEditCategory.AutoHeight = false;
            this.repositoryItemLookUpEditCategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditCategory.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Category")});
            this.repositoryItemLookUpEditCategory.DataSource = this.categoryBindingSource;
            this.repositoryItemLookUpEditCategory.DisplayMember = "Name";
            this.repositoryItemLookUpEditCategory.Name = "repositoryItemLookUpEditCategory";
            this.repositoryItemLookUpEditCategory.ValueMember = "Id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dBFinancial;
            // 
            // colViewOrder
            // 
            this.colViewOrder.Caption = "Thứ tự hiển thị";
            this.colViewOrder.FieldName = "ViewOrder";
            this.colViewOrder.Name = "colViewOrder";
            this.colViewOrder.Visible = true;
            this.colViewOrder.VisibleIndex = 6;
            this.colViewOrder.Width = 78;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 7;
            this.colIsActive.Width = 62;
            // 
            // propertyBindingNavigator
            // 
            this.propertyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.propertyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.propertyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.propertyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.propertyBindingNavigatorSaveItem});
            this.propertyBindingNavigator.Location = new System.Drawing.Point(0, 101);
            this.propertyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.propertyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.propertyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.propertyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.propertyBindingNavigator.Name = "propertyBindingNavigator";
            this.propertyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propertyBindingNavigator.Size = new System.Drawing.Size(1213, 25);
            this.propertyBindingNavigator.TabIndex = 2;
            this.propertyBindingNavigator.Text = "bindingNavigator1";
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
            // propertyBindingNavigatorSaveItem
            // 
            this.propertyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("propertyBindingNavigatorSaveItem.Image")));
            this.propertyBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.propertyBindingNavigatorSaveItem.Name = "propertyBindingNavigatorSaveItem";
            this.propertyBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.propertyBindingNavigatorSaveItem.Text = "Save Data";
            this.propertyBindingNavigatorSaveItem.Click += new System.EventHandler(this.propertyBindingNavigatorSaveItem_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Controls.Add(this.treeListLookUpEditGroup);
            this.panelControl1.Controls.Add(this.treeListLookUpEditCategory);
            this.panelControl1.Controls.Add(idLabel);
            this.panelControl1.Controls.Add(this.idTextEdit);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.nameTextEdit);
            this.panelControl1.Controls.Add(groupIdLabel);
            this.panelControl1.Controls.Add(valueTypeIdLabel);
            this.panelControl1.Controls.Add(this.valueTypeIdLookUpEdit);
            this.panelControl1.Controls.Add(unitLabel);
            this.panelControl1.Controls.Add(this.unitTextEdit);
            this.panelControl1.Controls.Add(categoryIdLabel);
            this.panelControl1.Controls.Add(viewOrderLabel);
            this.panelControl1.Controls.Add(this.viewOrderTextEdit);
            this.panelControl1.Controls.Add(isActiveLabel);
            this.panelControl1.Controls.Add(this.isActiveCheckEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1213, 101);
            this.panelControl1.TabIndex = 0;
            // 
            // treeListLookUpEditGroup
            // 
            this.treeListLookUpEditGroup.Location = new System.Drawing.Point(101, 38);
            this.treeListLookUpEditGroup.Name = "treeListLookUpEditGroup";
            this.treeListLookUpEditGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.treeListLookUpEditGroup.Properties.DataSource = this.categoryBindingSource;
            this.treeListLookUpEditGroup.Properties.DisplayMember = "Name";
            this.treeListLookUpEditGroup.Properties.ReadOnly = true;
            this.treeListLookUpEditGroup.Properties.TreeList = this.treeList1;
            this.treeListLookUpEditGroup.Properties.ValueMember = "Id";
            this.treeListLookUpEditGroup.Size = new System.Drawing.Size(339, 20);
            this.treeListLookUpEditGroup.TabIndex = 17;
            // 
            // treeList1
            // 
            this.treeList1.DataSource = this.categoryBindingSource;
            this.treeList1.KeyFieldName = "Id";
            this.treeList1.Location = new System.Drawing.Point(96, -50);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.EnableFiltering = true;
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.ParentFieldName = "ParentId";
            this.treeList1.Size = new System.Drawing.Size(400, 200);
            this.treeList1.TabIndex = 0;
            // 
            // treeListLookUpEditCategory
            // 
            this.treeListLookUpEditCategory.Location = new System.Drawing.Point(399, 64);
            this.treeListLookUpEditCategory.Name = "treeListLookUpEditCategory";
            this.treeListLookUpEditCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.treeListLookUpEditCategory.Properties.DataSource = this.categoryBindingSource;
            this.treeListLookUpEditCategory.Properties.DisplayMember = "Name";
            this.treeListLookUpEditCategory.Properties.ReadOnly = true;
            this.treeListLookUpEditCategory.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.treeListLookUpEditCategory.Properties.ValueMember = "Id";
            this.treeListLookUpEditCategory.Size = new System.Drawing.Size(339, 20);
            this.treeListLookUpEditCategory.TabIndex = 16;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.DataSource = this.categoryBindingSource;
            this.treeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "Id", true));
            this.idTextEdit.Location = new System.Drawing.Point(40, 12);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Properties.ReadOnly = true;
            this.idTextEdit.Size = new System.Drawing.Size(56, 20);
            this.idTextEdit.TabIndex = 1;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(159, 12);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(579, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // valueTypeIdLookUpEdit
            // 
            this.valueTypeIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "ValueTypeId", true));
            this.valueTypeIdLookUpEdit.Location = new System.Drawing.Point(542, 38);
            this.valueTypeIdLookUpEdit.Name = "valueTypeIdLookUpEdit";
            this.valueTypeIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.valueTypeIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValueType", "ProValueType")});
            this.valueTypeIdLookUpEdit.Properties.DataSource = this.propertyValueTypeBindingSource;
            this.valueTypeIdLookUpEdit.Properties.DisplayMember = "ValueType";
            this.valueTypeIdLookUpEdit.Properties.ValueMember = "Id";
            this.valueTypeIdLookUpEdit.Size = new System.Drawing.Size(196, 20);
            this.valueTypeIdLookUpEdit.TabIndex = 7;
            // 
            // unitTextEdit
            // 
            this.unitTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "Unit", true));
            this.unitTextEdit.Location = new System.Drawing.Point(101, 64);
            this.unitTextEdit.Name = "unitTextEdit";
            this.unitTextEdit.Size = new System.Drawing.Size(181, 20);
            this.unitTextEdit.TabIndex = 9;
            // 
            // viewOrderTextEdit
            // 
            this.viewOrderTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "ViewOrder", true));
            this.viewOrderTextEdit.Location = new System.Drawing.Point(860, 12);
            this.viewOrderTextEdit.Name = "viewOrderTextEdit";
            this.viewOrderTextEdit.Size = new System.Drawing.Size(58, 20);
            this.viewOrderTextEdit.TabIndex = 13;
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "IsActive", true));
            this.isActiveCheckEdit.Location = new System.Drawing.Point(860, 39);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "";
            this.isActiveCheckEdit.Size = new System.Drawing.Size(30, 19);
            this.isActiveCheckEdit.TabIndex = 15;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // propertyValueTypeTableAdapter
            // 
            this.propertyValueTypeTableAdapter.ClearBeforeFill = true;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(981, 35);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Chỉ Load những thuộc tính không thuộc Group";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 18;
            // 
            // FrmPropertyByCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 713);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmPropertyByCategory";
            this.Text = "Nhập thuộc tính từ Category";
            this.Load += new System.EventHandler(this.FrmProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditValueType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingNavigator)).EndInit();
            this.propertyBindingNavigator.ResumeLayout(false);
            this.propertyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTypeIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource propertyBindingSource;
        private DBFinancialTableAdapters.PropertyTableAdapter propertyTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private DBFinancialTableAdapters.PropertyGroupTableAdapter propertyGroupTableAdapter;
        private System.Windows.Forms.BindingSource propertyGroupBindingSource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Category.ctrCategory ctrCategory1;
        private System.Windows.Forms.BindingNavigator propertyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton propertyBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DBFinancialTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private DevExpress.XtraGrid.GridControl propertyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colValueTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colViewOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraEditors.TreeListLookUpEdit treeListLookUpEditCategory;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit valueTypeIdLookUpEdit;
        private DevExpress.XtraEditors.TextEdit unitTextEdit;
        private DevExpress.XtraEditors.TextEdit viewOrderTextEdit;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private System.Windows.Forms.BindingSource propertyValueTypeBindingSource;
        private DBFinancialTableAdapters.PropertyValueTypeTableAdapter propertyValueTypeTableAdapter;
        private DevExpress.XtraEditors.TreeListLookUpEdit treeListLookUpEditGroup;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditGroup;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditValueType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditCategory;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}