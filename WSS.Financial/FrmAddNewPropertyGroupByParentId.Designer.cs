namespace WSS.Financial
{
    partial class FrmAddNewPropertyGroupByParentId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewPropertyGroupByParentId));
            System.Windows.Forms.Label viewOrderLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.parentIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.propertyGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFinancial = new WSS.Financial.DBFinancial();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categoryIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupLevelTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.propertyGroupTableAdapter = new WSS.Financial.DBFinancialTableAdapters.PropertyGroupTableAdapter();
            this.tableAdapterManager = new WSS.Financial.DBFinancialTableAdapters.TableAdapterManager();
            this.propertyGroupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.propertyGroupGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryTableAdapter = new WSS.Financial.DBFinancialTableAdapters.CategoryTableAdapter();
            this.viewOrderTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            parentIdLabel = new System.Windows.Forms.Label();
            groupLevelLabel = new System.Windows.Forms.Label();
            viewOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLevelTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupBindingNavigator)).BeginInit();
            this.propertyGroupBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(10, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(113, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(528, 15);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(64, 13);
            categoryIdLabel.TabIndex = 4;
            categoryIdLabel.Text = "Category Id:";
            // 
            // parentIdLabel
            // 
            parentIdLabel.AutoSize = true;
            parentIdLabel.Location = new System.Drawing.Point(10, 41);
            parentIdLabel.Name = "parentIdLabel";
            parentIdLabel.Size = new System.Drawing.Size(53, 13);
            parentIdLabel.TabIndex = 6;
            parentIdLabel.Text = "Parent Id:";
            // 
            // groupLevelLabel
            // 
            groupLevelLabel.AutoSize = true;
            groupLevelLabel.Location = new System.Drawing.Point(182, 41);
            groupLevelLabel.Name = "groupLevelLabel";
            groupLevelLabel.Size = new System.Drawing.Size(68, 13);
            groupLevelLabel.TabIndex = 8;
            groupLevelLabel.Text = "Group Level:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(viewOrderLabel);
            this.panelControl1.Controls.Add(this.viewOrderTextEdit);
            this.panelControl1.Controls.Add(this.parentIdTextEdit);
            this.panelControl1.Controls.Add(idLabel);
            this.panelControl1.Controls.Add(this.idTextEdit);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.nameTextEdit);
            this.panelControl1.Controls.Add(categoryIdLabel);
            this.panelControl1.Controls.Add(this.categoryIdLookUpEdit);
            this.panelControl1.Controls.Add(parentIdLabel);
            this.panelControl1.Controls.Add(groupLevelLabel);
            this.panelControl1.Controls.Add(this.groupLevelTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(969, 81);
            this.panelControl1.TabIndex = 0;
            // 
            // parentIdTextEdit
            // 
            this.parentIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "ParentId", true));
            this.parentIdTextEdit.Location = new System.Drawing.Point(69, 38);
            this.parentIdTextEdit.Name = "parentIdTextEdit";
            this.parentIdTextEdit.Properties.ReadOnly = true;
            this.parentIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.parentIdTextEdit.TabIndex = 11;
            // 
            // propertyGroupBindingSource
            // 
            this.propertyGroupBindingSource.DataMember = "PropertyGroup";
            this.propertyGroupBindingSource.DataSource = this.dBFinancial;
            // 
            // dBFinancial
            // 
            this.dBFinancial.DataSetName = "DBFinancial";
            this.dBFinancial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "Id", true));
            this.idTextEdit.Location = new System.Drawing.Point(35, 12);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Size = new System.Drawing.Size(66, 20);
            this.idTextEdit.TabIndex = 1;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(157, 12);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(342, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // categoryIdLookUpEdit
            // 
            this.categoryIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "CategoryId", true));
            this.categoryIdLookUpEdit.Location = new System.Drawing.Point(602, 12);
            this.categoryIdLookUpEdit.Name = "categoryIdLookUpEdit";
            this.categoryIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Category")});
            this.categoryIdLookUpEdit.Properties.DataSource = this.categoryBindingSource;
            this.categoryIdLookUpEdit.Properties.DisplayMember = "Name";
            this.categoryIdLookUpEdit.Properties.ReadOnly = true;
            this.categoryIdLookUpEdit.Properties.ValueMember = "Id";
            this.categoryIdLookUpEdit.Size = new System.Drawing.Size(175, 20);
            this.categoryIdLookUpEdit.TabIndex = 5;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dBFinancial;
            // 
            // groupLevelTextEdit
            // 
            this.groupLevelTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "GroupLevel", true));
            this.groupLevelTextEdit.Location = new System.Drawing.Point(256, 38);
            this.groupLevelTextEdit.Name = "groupLevelTextEdit";
            this.groupLevelTextEdit.Properties.ReadOnly = true;
            this.groupLevelTextEdit.Size = new System.Drawing.Size(70, 20);
            this.groupLevelTextEdit.TabIndex = 9;
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
            this.tableAdapterManager.UpdateOrder = WSS.Financial.DBFinancialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // propertyGroupBindingNavigator
            // 
            this.propertyGroupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.propertyGroupBindingNavigator.BindingSource = this.propertyGroupBindingSource;
            this.propertyGroupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.propertyGroupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.propertyGroupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.propertyGroupBindingNavigator.Location = new System.Drawing.Point(0, 81);
            this.propertyGroupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.propertyGroupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.propertyGroupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.propertyGroupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.propertyGroupBindingNavigator.Name = "propertyGroupBindingNavigator";
            this.propertyGroupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propertyGroupBindingNavigator.Size = new System.Drawing.Size(969, 25);
            this.propertyGroupBindingNavigator.TabIndex = 1;
            this.propertyGroupBindingNavigator.Text = "bindingNavigator1";
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
            this.propertyGroupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("propertyGroupBindingNavigatorSaveItem.Image")));
            this.propertyGroupBindingNavigatorSaveItem.Name = "propertyGroupBindingNavigatorSaveItem";
            this.propertyGroupBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.propertyGroupBindingNavigatorSaveItem.Text = "Save Data";
            this.propertyGroupBindingNavigatorSaveItem.Click += new System.EventHandler(this.propertyGroupBindingNavigatorSaveItem_Click);
            // 
            // propertyGroupGridControl
            // 
            this.propertyGroupGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGroupGridControl.DataSource = this.propertyGroupBindingSource;
            this.propertyGroupGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGroupGridControl.Location = new System.Drawing.Point(0, 106);
            this.propertyGroupGridControl.MainView = this.gridView1;
            this.propertyGroupGridControl.Name = "propertyGroupGridControl";
            this.propertyGroupGridControl.Size = new System.Drawing.Size(969, 440);
            this.propertyGroupGridControl.TabIndex = 2;
            this.propertyGroupGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colCategoryId,
            this.colParentId,
            this.colGroupLevel,
            this.gridColumn1});
            this.gridView1.GridControl = this.propertyGroupGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 72;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 399;
            // 
            // colCategoryId
            // 
            this.colCategoryId.FieldName = "CategoryId";
            this.colCategoryId.Name = "colCategoryId";
            this.colCategoryId.OptionsColumn.ReadOnly = true;
            this.colCategoryId.Visible = true;
            this.colCategoryId.VisibleIndex = 2;
            this.colCategoryId.Width = 161;
            // 
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.OptionsColumn.ReadOnly = true;
            this.colParentId.Visible = true;
            this.colParentId.VisibleIndex = 3;
            this.colParentId.Width = 99;
            // 
            // colGroupLevel
            // 
            this.colGroupLevel.FieldName = "GroupLevel";
            this.colGroupLevel.Name = "colGroupLevel";
            this.colGroupLevel.OptionsColumn.ReadOnly = true;
            this.colGroupLevel.Visible = true;
            this.colGroupLevel.VisibleIndex = 4;
            this.colGroupLevel.Width = 104;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // viewOrderLabel
            // 
            viewOrderLabel.AutoSize = true;
            viewOrderLabel.Location = new System.Drawing.Point(337, 41);
            viewOrderLabel.Name = "viewOrderLabel";
            viewOrderLabel.Size = new System.Drawing.Size(62, 13);
            viewOrderLabel.TabIndex = 11;
            viewOrderLabel.Text = "View Order:";
            // 
            // viewOrderTextEdit
            // 
            this.viewOrderTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyGroupBindingSource, "ViewOrder", true));
            this.viewOrderTextEdit.Location = new System.Drawing.Point(405, 38);
            this.viewOrderTextEdit.Name = "viewOrderTextEdit";
            this.viewOrderTextEdit.Size = new System.Drawing.Size(94, 20);
            this.viewOrderTextEdit.TabIndex = 12;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Thứ tự hiển thị";
            this.gridColumn1.FieldName = "ViewOrder";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // FrmAddNewPropertyGroupByParentId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 546);
            this.Controls.Add(this.propertyGroupGridControl);
            this.Controls.Add(this.propertyGroupBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmAddNewPropertyGroupByParentId";
            this.Text = "FrmAddNewPropertyGroupByParentId";
            this.Load += new System.EventHandler(this.FrmAddNewPropertyGroupByParentId_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLevelTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupBindingNavigator)).EndInit();
            this.propertyGroupBindingNavigator.ResumeLayout(false);
            this.propertyGroupBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGroupGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource propertyGroupBindingSource;
        private DBFinancialTableAdapters.PropertyGroupTableAdapter propertyGroupTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator propertyGroupBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton propertyGroupBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit categoryIdLookUpEdit;
        private DevExpress.XtraEditors.TextEdit groupLevelTextEdit;
        private DevExpress.XtraGrid.GridControl propertyGroupGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colParentId;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupLevel;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DBFinancialTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private DevExpress.XtraEditors.TextEdit parentIdTextEdit;
        private DevExpress.XtraEditors.TextEdit viewOrderTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}