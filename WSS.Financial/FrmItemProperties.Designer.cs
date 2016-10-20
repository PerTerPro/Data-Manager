namespace WSS.Financial
{
    partial class FrmItemProperties
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
            System.Windows.Forms.Label itemIdLabel;
            System.Windows.Forms.Label propertyValueIdLabel;
            System.Windows.Forms.Label propertyIdLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemProperties));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.itemIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.itemPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFinancial = new WSS.Financial.DBFinancial();
            this.propertyIdLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValueTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.propertyValueIdLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.propertyValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPropertiesTableAdapter = new WSS.Financial.DBFinancialTableAdapters.ItemPropertiesTableAdapter();
            this.tableAdapterManager = new WSS.Financial.DBFinancialTableAdapters.TableAdapterManager();
            this.propertyTableAdapter = new WSS.Financial.DBFinancialTableAdapters.PropertyTableAdapter();
            this.propertyValueTableAdapter = new WSS.Financial.DBFinancialTableAdapters.PropertyValueTableAdapter();
            this.itemPropertiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.itemPropertiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.itemPropertiesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPropertyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEditProperty = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPropertyValueId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEditPropertyValue = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.itemTableAdapter = new WSS.Financial.DBFinancialTableAdapters.ItemTableAdapter();
            this.colId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValueTypeId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewOrder1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue1 = new DevExpress.XtraGrid.Columns.GridColumn();
            itemIdLabel = new System.Windows.Forms.Label();
            propertyValueIdLabel = new System.Windows.Forms.Label();
            propertyIdLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPropertiesBindingNavigator)).BeginInit();
            this.itemPropertiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPropertiesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEditProperty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEditPropertyValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // itemIdLabel
            // 
            itemIdLabel.AutoSize = true;
            itemIdLabel.Location = new System.Drawing.Point(14, 19);
            itemIdLabel.Name = "itemIdLabel";
            itemIdLabel.Size = new System.Drawing.Size(42, 13);
            itemIdLabel.TabIndex = 0;
            itemIdLabel.Text = "Item Id:";
            // 
            // propertyValueIdLabel
            // 
            propertyValueIdLabel.AutoSize = true;
            propertyValueIdLabel.Location = new System.Drawing.Point(645, 19);
            propertyValueIdLabel.Name = "propertyValueIdLabel";
            propertyValueIdLabel.Size = new System.Drawing.Size(91, 13);
            propertyValueIdLabel.TabIndex = 4;
            propertyValueIdLabel.Text = "Property Value Id:";
            // 
            // propertyIdLabel1
            // 
            propertyIdLabel1.AutoSize = true;
            propertyIdLabel1.Location = new System.Drawing.Point(189, 19);
            propertyIdLabel1.Name = "propertyIdLabel1";
            propertyIdLabel1.Size = new System.Drawing.Size(61, 13);
            propertyIdLabel1.TabIndex = 5;
            propertyIdLabel1.Text = "Property Id:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(propertyIdLabel1);
            this.panelControl1.Controls.Add(itemIdLabel);
            this.panelControl1.Controls.Add(this.itemIdTextEdit);
            this.panelControl1.Controls.Add(propertyValueIdLabel);
            this.panelControl1.Controls.Add(this.propertyIdLookUpEdit);
            this.panelControl1.Controls.Add(this.propertyValueIdLookUpEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1251, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // itemIdTextEdit
            // 
            this.itemIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemPropertiesBindingSource, "ItemId", true));
            this.itemIdTextEdit.Location = new System.Drawing.Point(62, 16);
            this.itemIdTextEdit.Name = "itemIdTextEdit";
            this.itemIdTextEdit.Properties.ShowNullValuePromptWhenFocused = true;
            this.itemIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.itemIdTextEdit.TabIndex = 1;
            // 
            // itemPropertiesBindingSource
            // 
            this.itemPropertiesBindingSource.DataMember = "ItemProperties";
            this.itemPropertiesBindingSource.DataSource = this.dBFinancial;
            // 
            // dBFinancial
            // 
            this.dBFinancial.DataSetName = "DBFinancial";
            this.dBFinancial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyIdLookUpEdit
            // 
            this.propertyIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemPropertiesBindingSource, "PropertyId", true));
            this.propertyIdLookUpEdit.Location = new System.Drawing.Point(256, 16);
            this.propertyIdLookUpEdit.Name = "propertyIdLookUpEdit";
            this.propertyIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.propertyIdLookUpEdit.Properties.DataSource = this.propertyBindingSource;
            this.propertyIdLookUpEdit.Properties.DisplayMember = "Name";
            this.propertyIdLookUpEdit.Properties.ValueMember = "Id";
            this.propertyIdLookUpEdit.Properties.View = this.searchLookUpEdit1View;
            this.propertyIdLookUpEdit.Size = new System.Drawing.Size(364, 20);
            this.propertyIdLookUpEdit.TabIndex = 6;
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataMember = "Property";
            this.propertyBindingSource.DataSource = this.dBFinancial;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colGroupId,
            this.colValueTypeId,
            this.colUnit,
            this.colViewOrder,
            this.colIsActive,
            this.colCategoryId});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 200;
            // 
            // colGroupId
            // 
            this.colGroupId.FieldName = "GroupId";
            this.colGroupId.Name = "colGroupId";
            // 
            // colValueTypeId
            // 
            this.colValueTypeId.FieldName = "ValueTypeId";
            this.colValueTypeId.Name = "colValueTypeId";
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            // 
            // colViewOrder
            // 
            this.colViewOrder.FieldName = "ViewOrder";
            this.colViewOrder.Name = "colViewOrder";
            this.colViewOrder.Visible = true;
            this.colViewOrder.VisibleIndex = 1;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            // 
            // colCategoryId
            // 
            this.colCategoryId.FieldName = "CategoryId";
            this.colCategoryId.Name = "colCategoryId";
            // 
            // propertyValueIdLookUpEdit
            // 
            this.propertyValueIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemPropertiesBindingSource, "PropertyValueId", true));
            this.propertyValueIdLookUpEdit.Location = new System.Drawing.Point(742, 16);
            this.propertyValueIdLookUpEdit.Name = "propertyValueIdLookUpEdit";
            this.propertyValueIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.propertyValueIdLookUpEdit.Properties.DataSource = this.propertyValueBindingSource;
            this.propertyValueIdLookUpEdit.Properties.DisplayMember = "Value";
            this.propertyValueIdLookUpEdit.Properties.ValueMember = "Id";
            this.propertyValueIdLookUpEdit.Properties.View = this.gridView2;
            this.propertyValueIdLookUpEdit.Size = new System.Drawing.Size(351, 20);
            this.propertyValueIdLookUpEdit.TabIndex = 5;
            // 
            // propertyValueBindingSource
            // 
            this.propertyValueBindingSource.DataMember = "PropertyValue";
            this.propertyValueBindingSource.DataSource = this.dBFinancial;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colValue});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 1;
            // 
            // colValue
            // 
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 0;
            this.colValue.Width = 200;
            // 
            // itemPropertiesTableAdapter
            // 
            this.itemPropertiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ItemPropertiesTableAdapter = this.itemPropertiesTableAdapter;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.PropertyGroupTableAdapter = null;
            this.tableAdapterManager.PropertyStatusTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = this.propertyTableAdapter;
            this.tableAdapterManager.PropertyValueTableAdapter = this.propertyValueTableAdapter;
            this.tableAdapterManager.PropertyValueTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.Financial.DBFinancialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // propertyTableAdapter
            // 
            this.propertyTableAdapter.ClearBeforeFill = true;
            // 
            // propertyValueTableAdapter
            // 
            this.propertyValueTableAdapter.ClearBeforeFill = true;
            // 
            // itemPropertiesBindingNavigator
            // 
            this.itemPropertiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemPropertiesBindingNavigator.BindingSource = this.itemPropertiesBindingSource;
            this.itemPropertiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemPropertiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemPropertiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itemPropertiesBindingNavigatorSaveItem});
            this.itemPropertiesBindingNavigator.Location = new System.Drawing.Point(0, 52);
            this.itemPropertiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemPropertiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemPropertiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemPropertiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemPropertiesBindingNavigator.Name = "itemPropertiesBindingNavigator";
            this.itemPropertiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemPropertiesBindingNavigator.Size = new System.Drawing.Size(1251, 25);
            this.itemPropertiesBindingNavigator.TabIndex = 1;
            this.itemPropertiesBindingNavigator.Text = "bindingNavigator1";
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
            // itemPropertiesBindingNavigatorSaveItem
            // 
            this.itemPropertiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemPropertiesBindingNavigatorSaveItem.Image")));
            this.itemPropertiesBindingNavigatorSaveItem.Name = "itemPropertiesBindingNavigatorSaveItem";
            this.itemPropertiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.itemPropertiesBindingNavigatorSaveItem.Text = "Save Data";
            this.itemPropertiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemPropertiesBindingNavigatorSaveItem_Click);
            // 
            // itemPropertiesGridControl
            // 
            this.itemPropertiesGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.itemPropertiesGridControl.DataSource = this.itemPropertiesBindingSource;
            this.itemPropertiesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPropertiesGridControl.Location = new System.Drawing.Point(0, 77);
            this.itemPropertiesGridControl.MainView = this.gridView1;
            this.itemPropertiesGridControl.Name = "itemPropertiesGridControl";
            this.itemPropertiesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEditPropertyValue,
            this.repositoryItemLookUpEditItem,
            this.repositoryItemSearchLookUpEditProperty});
            this.itemPropertiesGridControl.Size = new System.Drawing.Size(1251, 690);
            this.itemPropertiesGridControl.TabIndex = 2;
            this.itemPropertiesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemId,
            this.colPropertyId,
            this.colPropertyValueId});
            this.gridView1.GridControl = this.itemPropertiesGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colItemId
            // 
            this.colItemId.ColumnEdit = this.repositoryItemLookUpEditItem;
            this.colItemId.FieldName = "ItemId";
            this.colItemId.Name = "colItemId";
            this.colItemId.Visible = true;
            this.colItemId.VisibleIndex = 0;
            this.colItemId.Width = 224;
            // 
            // repositoryItemLookUpEditItem
            // 
            this.repositoryItemLookUpEditItem.AutoHeight = false;
            this.repositoryItemLookUpEditItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditItem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Item")});
            this.repositoryItemLookUpEditItem.DataSource = this.itemBindingSource;
            this.repositoryItemLookUpEditItem.DisplayMember = "Name";
            this.repositoryItemLookUpEditItem.Name = "repositoryItemLookUpEditItem";
            this.repositoryItemLookUpEditItem.ValueMember = "Id";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.dBFinancial;
            // 
            // colPropertyId
            // 
            this.colPropertyId.ColumnEdit = this.repositoryItemSearchLookUpEditProperty;
            this.colPropertyId.FieldName = "PropertyId";
            this.colPropertyId.Name = "colPropertyId";
            this.colPropertyId.Visible = true;
            this.colPropertyId.VisibleIndex = 1;
            this.colPropertyId.Width = 490;
            // 
            // repositoryItemSearchLookUpEditProperty
            // 
            this.repositoryItemSearchLookUpEditProperty.AutoHeight = false;
            this.repositoryItemSearchLookUpEditProperty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEditProperty.DataSource = this.propertyBindingSource;
            this.repositoryItemSearchLookUpEditProperty.DisplayMember = "Name";
            this.repositoryItemSearchLookUpEditProperty.Name = "repositoryItemSearchLookUpEditProperty";
            this.repositoryItemSearchLookUpEditProperty.ValueMember = "Id";
            this.repositoryItemSearchLookUpEditProperty.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId2,
            this.colName1,
            this.colGroupId1,
            this.colValueTypeId1,
            this.colUnit1,
            this.colViewOrder1,
            this.colIsActive1,
            this.colCategoryId1});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colPropertyValueId
            // 
            this.colPropertyValueId.ColumnEdit = this.repositoryItemSearchLookUpEditPropertyValue;
            this.colPropertyValueId.FieldName = "PropertyValueId";
            this.colPropertyValueId.Name = "colPropertyValueId";
            this.colPropertyValueId.Visible = true;
            this.colPropertyValueId.VisibleIndex = 2;
            this.colPropertyValueId.Width = 519;
            // 
            // repositoryItemSearchLookUpEditPropertyValue
            // 
            this.repositoryItemSearchLookUpEditPropertyValue.AutoHeight = false;
            this.repositoryItemSearchLookUpEditPropertyValue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEditPropertyValue.DataSource = this.propertyValueBindingSource;
            this.repositoryItemSearchLookUpEditPropertyValue.DisplayMember = "Value";
            this.repositoryItemSearchLookUpEditPropertyValue.Name = "repositoryItemSearchLookUpEditPropertyValue";
            this.repositoryItemSearchLookUpEditPropertyValue.ValueMember = "Id";
            this.repositoryItemSearchLookUpEditPropertyValue.View = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colValue1,
            this.colId3});
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // colId2
            // 
            this.colId2.FieldName = "Id";
            this.colId2.Name = "colId2";
            this.colId2.OptionsColumn.ReadOnly = true;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 200;
            // 
            // colGroupId1
            // 
            this.colGroupId1.FieldName = "GroupId";
            this.colGroupId1.Name = "colGroupId1";
            // 
            // colValueTypeId1
            // 
            this.colValueTypeId1.FieldName = "ValueTypeId";
            this.colValueTypeId1.Name = "colValueTypeId1";
            // 
            // colUnit1
            // 
            this.colUnit1.FieldName = "Unit";
            this.colUnit1.Name = "colUnit1";
            // 
            // colViewOrder1
            // 
            this.colViewOrder1.FieldName = "ViewOrder";
            this.colViewOrder1.Name = "colViewOrder1";
            this.colViewOrder1.Visible = true;
            this.colViewOrder1.VisibleIndex = 1;
            this.colViewOrder1.Width = 184;
            // 
            // colIsActive1
            // 
            this.colIsActive1.FieldName = "IsActive";
            this.colIsActive1.Name = "colIsActive1";
            // 
            // colCategoryId1
            // 
            this.colCategoryId1.FieldName = "CategoryId";
            this.colCategoryId1.Name = "colCategoryId1";
            // 
            // colId3
            // 
            this.colId3.FieldName = "Id";
            this.colId3.Name = "colId3";
            // 
            // colValue1
            // 
            this.colValue1.FieldName = "Value";
            this.colValue1.Name = "colValue1";
            this.colValue1.Visible = true;
            this.colValue1.VisibleIndex = 0;
            // 
            // FrmItemProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 767);
            this.Controls.Add(this.itemPropertiesGridControl);
            this.Controls.Add(this.itemPropertiesBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmItemProperties";
            this.Text = "FrmItemProperties";
            this.Load += new System.EventHandler(this.FrmItemProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPropertiesBindingNavigator)).EndInit();
            this.itemPropertiesBindingNavigator.ResumeLayout(false);
            this.itemPropertiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPropertiesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEditProperty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEditPropertyValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource itemPropertiesBindingSource;
        private DBFinancialTableAdapters.ItemPropertiesTableAdapter itemPropertiesTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator itemPropertiesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton itemPropertiesBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl itemPropertiesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit itemIdTextEdit;
        private DBFinancialTableAdapters.PropertyTableAdapter propertyTableAdapter;
        private System.Windows.Forms.BindingSource propertyBindingSource;
        private DBFinancialTableAdapters.PropertyValueTableAdapter propertyValueTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colPropertyId;
        private DevExpress.XtraGrid.Columns.GridColumn colPropertyValueId;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEditPropertyValue;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private System.Windows.Forms.BindingSource propertyValueBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit propertyIdLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit propertyValueIdLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditItem;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DBFinancialTableAdapters.ItemTableAdapter itemTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEditProperty;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupId;
        private DevExpress.XtraGrid.Columns.GridColumn colValueTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colViewOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colId2;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupId1;
        private DevExpress.XtraGrid.Columns.GridColumn colValueTypeId1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit1;
        private DevExpress.XtraGrid.Columns.GridColumn colViewOrder1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryId1;
        private DevExpress.XtraGrid.Columns.GridColumn colValue1;
        private DevExpress.XtraGrid.Columns.GridColumn colId3;
    }
}