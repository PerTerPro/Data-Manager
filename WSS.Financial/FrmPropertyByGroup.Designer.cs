namespace WSS.Financial
{
    partial class FrmPropertyByGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPropertyByGroup));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFinancial = new WSS.Financial.DBFinancial();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.valueTypeIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.propertyValueTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categoryIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewOrderTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.groupIdTreeListLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.propertyGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyTableAdapter = new WSS.Financial.DBFinancialTableAdapters.PropertyTableAdapter();
            this.tableAdapterManager = new WSS.Financial.DBFinancialTableAdapters.TableAdapterManager();
            this.categoryTableAdapter = new WSS.Financial.DBFinancialTableAdapters.CategoryTableAdapter();
            this.propertyGroupTableAdapter = new WSS.Financial.DBFinancialTableAdapters.PropertyGroupTableAdapter();
            this.propertyValueTypeTableAdapter = new WSS.Financial.DBFinancialTableAdapters.PropertyValueTypeTableAdapter();
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
            this.propertyGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditGroup = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colValueTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditValueType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditCategory = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colViewOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            groupIdLabel = new System.Windows.Forms.Label();
            valueTypeIdLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            viewOrderLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTypeIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIdTreeListLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingNavigator)).BeginInit();
            this.propertyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditValueType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(11, 14);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(115, 14);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // groupIdLabel
            // 
            groupIdLabel.AutoSize = true;
            groupIdLabel.Location = new System.Drawing.Point(311, 47);
            groupIdLabel.Name = "groupIdLabel";
            groupIdLabel.Size = new System.Drawing.Size(51, 13);
            groupIdLabel.TabIndex = 4;
            groupIdLabel.Text = "Group Id:";
            // 
            // valueTypeIdLabel
            // 
            valueTypeIdLabel.AutoSize = true;
            valueTypeIdLabel.Location = new System.Drawing.Point(732, 15);
            valueTypeIdLabel.Name = "valueTypeIdLabel";
            valueTypeIdLabel.Size = new System.Drawing.Size(76, 13);
            valueTypeIdLabel.TabIndex = 6;
            valueTypeIdLabel.Text = "Value Type Id:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(11, 47);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(29, 13);
            unitLabel.TabIndex = 8;
            unitLabel.Text = "Unit:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(732, 47);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(64, 13);
            categoryIdLabel.TabIndex = 10;
            categoryIdLabel.Text = "Category Id:";
            // 
            // viewOrderLabel
            // 
            viewOrderLabel.AutoSize = true;
            viewOrderLabel.Location = new System.Drawing.Point(991, 15);
            viewOrderLabel.Name = "viewOrderLabel";
            viewOrderLabel.Size = new System.Drawing.Size(62, 13);
            viewOrderLabel.TabIndex = 12;
            viewOrderLabel.Text = "View Order:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(1056, 47);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 14;
            isActiveLabel.Text = "Is Active:";
            // 
            // panelControl1
            // 
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
            this.panelControl1.Controls.Add(this.categoryIdLookUpEdit);
            this.panelControl1.Controls.Add(viewOrderLabel);
            this.panelControl1.Controls.Add(this.viewOrderTextEdit);
            this.panelControl1.Controls.Add(isActiveLabel);
            this.panelControl1.Controls.Add(this.isActiveCheckEdit);
            this.panelControl1.Controls.Add(this.groupIdTreeListLookUpEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1190, 84);
            this.panelControl1.TabIndex = 0;
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "Id", true));
            this.idTextEdit.Location = new System.Drawing.Point(36, 11);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Properties.ReadOnly = true;
            this.idTextEdit.Size = new System.Drawing.Size(55, 20);
            this.idTextEdit.TabIndex = 1;
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
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(174, 11);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(546, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // valueTypeIdLookUpEdit
            // 
            this.valueTypeIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "ValueTypeId", true));
            this.valueTypeIdLookUpEdit.Location = new System.Drawing.Point(814, 12);
            this.valueTypeIdLookUpEdit.Name = "valueTypeIdLookUpEdit";
            this.valueTypeIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.valueTypeIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValueType", "Kiểu giá trị")});
            this.valueTypeIdLookUpEdit.Properties.DataSource = this.propertyValueTypeBindingSource;
            this.valueTypeIdLookUpEdit.Properties.DisplayMember = "ValueType";
            this.valueTypeIdLookUpEdit.Properties.ValueMember = "Id";
            this.valueTypeIdLookUpEdit.Size = new System.Drawing.Size(160, 20);
            this.valueTypeIdLookUpEdit.TabIndex = 7;
            // 
            // propertyValueTypeBindingSource
            // 
            this.propertyValueTypeBindingSource.DataMember = "PropertyValueType";
            this.propertyValueTypeBindingSource.DataSource = this.dBFinancial;
            // 
            // unitTextEdit
            // 
            this.unitTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "Unit", true));
            this.unitTextEdit.Location = new System.Drawing.Point(46, 44);
            this.unitTextEdit.Name = "unitTextEdit";
            this.unitTextEdit.Size = new System.Drawing.Size(230, 20);
            this.unitTextEdit.TabIndex = 9;
            // 
            // categoryIdLookUpEdit
            // 
            this.categoryIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "CategoryId", true));
            this.categoryIdLookUpEdit.Location = new System.Drawing.Point(814, 44);
            this.categoryIdLookUpEdit.Name = "categoryIdLookUpEdit";
            this.categoryIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Category")});
            this.categoryIdLookUpEdit.Properties.DataSource = this.categoryBindingSource;
            this.categoryIdLookUpEdit.Properties.DisplayMember = "Name";
            this.categoryIdLookUpEdit.Properties.ReadOnly = true;
            this.categoryIdLookUpEdit.Properties.ValueMember = "Id";
            this.categoryIdLookUpEdit.Size = new System.Drawing.Size(229, 20);
            this.categoryIdLookUpEdit.TabIndex = 11;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dBFinancial;
            // 
            // viewOrderTextEdit
            // 
            this.viewOrderTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "ViewOrder", true));
            this.viewOrderTextEdit.Location = new System.Drawing.Point(1073, 12);
            this.viewOrderTextEdit.Name = "viewOrderTextEdit";
            this.viewOrderTextEdit.Size = new System.Drawing.Size(100, 20);
            this.viewOrderTextEdit.TabIndex = 13;
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "IsActive", true));
            this.isActiveCheckEdit.Location = new System.Drawing.Point(1125, 44);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "";
            this.isActiveCheckEdit.Size = new System.Drawing.Size(48, 19);
            this.isActiveCheckEdit.TabIndex = 15;
            // 
            // groupIdTreeListLookUpEdit
            // 
            this.groupIdTreeListLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyBindingSource, "GroupId", true));
            this.groupIdTreeListLookUpEdit.Location = new System.Drawing.Point(393, 44);
            this.groupIdTreeListLookUpEdit.Name = "groupIdTreeListLookUpEdit";
            this.groupIdTreeListLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.groupIdTreeListLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Group")});
            this.groupIdTreeListLookUpEdit.Properties.DataSource = this.propertyGroupBindingSource;
            this.groupIdTreeListLookUpEdit.Properties.DisplayMember = "Name";
            this.groupIdTreeListLookUpEdit.Properties.ReadOnly = true;
            this.groupIdTreeListLookUpEdit.Properties.ValueMember = "Id";
            this.groupIdTreeListLookUpEdit.Size = new System.Drawing.Size(327, 20);
            this.groupIdTreeListLookUpEdit.TabIndex = 5;
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
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.ItemPropertiesTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.PropertyGroupTableAdapter = this.propertyGroupTableAdapter;
            this.tableAdapterManager.PropertyStatusTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = this.propertyTableAdapter;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.PropertyValueTypeTableAdapter = this.propertyValueTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = WSS.Financial.DBFinancialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // propertyGroupTableAdapter
            // 
            this.propertyGroupTableAdapter.ClearBeforeFill = true;
            // 
            // propertyValueTypeTableAdapter
            // 
            this.propertyValueTypeTableAdapter.ClearBeforeFill = true;
            // 
            // propertyBindingNavigator
            // 
            this.propertyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.propertyBindingNavigator.BindingSource = this.propertyBindingSource;
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
            this.propertyBindingNavigator.Location = new System.Drawing.Point(0, 84);
            this.propertyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.propertyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.propertyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.propertyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.propertyBindingNavigator.Name = "propertyBindingNavigator";
            this.propertyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propertyBindingNavigator.Size = new System.Drawing.Size(1190, 25);
            this.propertyBindingNavigator.TabIndex = 1;
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
            this.propertyBindingNavigatorSaveItem.Name = "propertyBindingNavigatorSaveItem";
            this.propertyBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.propertyBindingNavigatorSaveItem.Text = "Save Data";
            this.propertyBindingNavigatorSaveItem.Click += new System.EventHandler(this.propertyBindingNavigatorSaveItem_Click);
            // 
            // propertyGridControl
            // 
            this.propertyGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridControl.DataSource = this.propertyBindingSource;
            this.propertyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl.Location = new System.Drawing.Point(0, 109);
            this.propertyGridControl.MainView = this.gridView1;
            this.propertyGridControl.Name = "propertyGridControl";
            this.propertyGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditCategory,
            this.repositoryItemLookUpEditGroup,
            this.repositoryItemLookUpEditValueType});
            this.propertyGridControl.Size = new System.Drawing.Size(1190, 594);
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
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 133;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 538;
            // 
            // colGroupId
            // 
            this.colGroupId.ColumnEdit = this.repositoryItemLookUpEditGroup;
            this.colGroupId.FieldName = "GroupId";
            this.colGroupId.Name = "colGroupId";
            this.colGroupId.OptionsColumn.ReadOnly = true;
            this.colGroupId.Width = 263;
            // 
            // repositoryItemLookUpEditGroup
            // 
            this.repositoryItemLookUpEditGroup.AutoHeight = false;
            this.repositoryItemLookUpEditGroup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditGroup.Name = "repositoryItemLookUpEditGroup";
            // 
            // colValueTypeId
            // 
            this.colValueTypeId.ColumnEdit = this.repositoryItemLookUpEditValueType;
            this.colValueTypeId.FieldName = "ValueTypeId";
            this.colValueTypeId.Name = "colValueTypeId";
            this.colValueTypeId.Visible = true;
            this.colValueTypeId.VisibleIndex = 3;
            this.colValueTypeId.Width = 144;
            // 
            // repositoryItemLookUpEditValueType
            // 
            this.repositoryItemLookUpEditValueType.AutoHeight = false;
            this.repositoryItemLookUpEditValueType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditValueType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ValueType", "Value Type")});
            this.repositoryItemLookUpEditValueType.DataSource = this.propertyValueTypeBindingSource;
            this.repositoryItemLookUpEditValueType.DisplayMember = "ValueType";
            this.repositoryItemLookUpEditValueType.Name = "repositoryItemLookUpEditValueType";
            this.repositoryItemLookUpEditValueType.ValueMember = "Id";
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            this.colUnit.Width = 187;
            // 
            // colCategoryId
            // 
            this.colCategoryId.ColumnEdit = this.repositoryItemLookUpEditCategory;
            this.colCategoryId.FieldName = "CategoryId";
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.OptionsColumn.ReadOnly = true;
            this.colCategoryId.Width = 160;
            // 
            // repositoryItemLookUpEditCategory
            // 
            this.repositoryItemLookUpEditCategory.AutoHeight = false;
            this.repositoryItemLookUpEditCategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditCategory.Name = "repositoryItemLookUpEditCategory";
            // 
            // colViewOrder
            // 
            this.colViewOrder.FieldName = "ViewOrder";
            this.colViewOrder.Name = "colViewOrder";
            this.colViewOrder.Visible = true;
            this.colViewOrder.VisibleIndex = 4;
            this.colViewOrder.Width = 84;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 5;
            this.colIsActive.Width = 86;
            // 
            // FrmPropertyByGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 703);
            this.Controls.Add(this.propertyGridControl);
            this.Controls.Add(this.propertyBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPropertyByGroup";
            this.Text = "FrmPropertyByGroup";
            this.Load += new System.EventHandler(this.FrmPropertyByGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTypeIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIdTreeListLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingNavigator)).EndInit();
            this.propertyBindingNavigator.ResumeLayout(false);
            this.propertyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditValueType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource propertyBindingSource;
        private DBFinancialTableAdapters.PropertyTableAdapter propertyTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
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
        private DevExpress.XtraGrid.GridControl propertyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit valueTypeIdLookUpEdit;
        private DevExpress.XtraEditors.TextEdit unitTextEdit;
        private DevExpress.XtraEditors.LookUpEdit categoryIdLookUpEdit;
        private DevExpress.XtraEditors.TextEdit viewOrderTextEdit;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DBFinancialTableAdapters.PropertyValueTypeTableAdapter propertyValueTypeTableAdapter;
        private System.Windows.Forms.BindingSource propertyValueTypeBindingSource;
        private DBFinancialTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colValueTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colViewOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DBFinancialTableAdapters.PropertyGroupTableAdapter propertyGroupTableAdapter;
        private System.Windows.Forms.BindingSource propertyGroupBindingSource;
        private DevExpress.XtraEditors.LookUpEdit groupIdTreeListLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditGroup;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditValueType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditCategory;
    }
}