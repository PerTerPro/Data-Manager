namespace QT.Moduls.ProductID
{
    partial class frmMapClassificationProperties
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapClassificationProperties));
            this.dBProperties = new QT.Moduls.ProductID.DBProperties();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listClassificationTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ListClassificationTableAdapter();
            this.tableAdapterManager = new QT.Moduls.ProductID.DBPropertiesTableAdapters.TableAdapterManager();
            this.listClassification_PropertiesTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ListClassification_PropertiesTableAdapter();
            this.propertiesTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.PropertiesTableAdapter();
            this.listClassificationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.listClassificationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listClassification_PropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tlClassification = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLevels = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNameProperties = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDListClassification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProperties = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btRemove = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameShow1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameGroup1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btInsert = new DevExpress.XtraEditors.SimpleButton();
            this.iDClassRProTextBox1 = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingNavigator)).BeginInit();
            this.listClassificationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listClassification_PropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlClassification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(3, 13);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(82, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID Classification";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(95, 10);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(44, 13);
            iDLabel1.TabIndex = 6;
            iDLabel1.Text = "IDRefer";
            // 
            // dBProperties
            // 
            this.dBProperties.DataSetName = "DBProperties";
            this.dBProperties.EnforceConstraints = false;
            this.dBProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dBProperties;
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ListClassification_PropertiesTableAdapter = this.listClassification_PropertiesTableAdapter;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.Product_PropertiesTableAdapter = null;
            this.tableAdapterManager.ProductDetailTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PropertiesConfig_PropertiesTableAdapter = null;
            this.tableAdapterManager.PropertiesConfigTableAdapter = null;
            this.tableAdapterManager.PropertiesGroupTableAdapter = null;
            this.tableAdapterManager.PropertiesTableAdapter = this.propertiesTableAdapter;
            this.tableAdapterManager.PropertiesValueTableAdapter = null;
            this.tableAdapterManager.PropertiesViewTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.ProductID.DBPropertiesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listClassification_PropertiesTableAdapter
            // 
            this.listClassification_PropertiesTableAdapter.ClearBeforeFill = true;
            // 
            // propertiesTableAdapter
            // 
            this.propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // listClassificationBindingNavigator
            // 
            this.listClassificationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listClassificationBindingNavigator.BindingSource = this.listClassificationBindingSource;
            this.listClassificationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listClassificationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listClassificationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listClassificationBindingNavigatorSaveItem});
            this.listClassificationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listClassificationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listClassificationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listClassificationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listClassificationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listClassificationBindingNavigator.Name = "listClassificationBindingNavigator";
            this.listClassificationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listClassificationBindingNavigator.Size = new System.Drawing.Size(1020, 25);
            this.listClassificationBindingNavigator.TabIndex = 0;
            this.listClassificationBindingNavigator.Text = "bindingNavigator1";
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
            // listClassificationBindingNavigatorSaveItem
            // 
            this.listClassificationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listClassificationBindingNavigatorSaveItem.Enabled = false;
            this.listClassificationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listClassificationBindingNavigatorSaveItem.Image")));
            this.listClassificationBindingNavigatorSaveItem.Name = "listClassificationBindingNavigatorSaveItem";
            this.listClassificationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listClassificationBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // listClassification_PropertiesBindingSource
            // 
            this.listClassification_PropertiesBindingSource.DataMember = "ListClassification_Properties";
            this.listClassification_PropertiesBindingSource.DataSource = this.dBProperties;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 25);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tlClassification);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1020, 446);
            this.splitContainerControl1.SplitterPosition = 148;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tlClassification
            // 
            this.tlClassification.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.colLevels,
            this.colDescription});
            this.tlClassification.DataSource = this.listClassificationBindingSource;
            this.tlClassification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlClassification.Location = new System.Drawing.Point(0, 0);
            this.tlClassification.Name = "tlClassification";
            this.tlClassification.OptionsBehavior.AutoChangeParent = false;
            this.tlClassification.OptionsBehavior.CanCloneNodesOnDrop = true;
            this.tlClassification.OptionsBehavior.CloseEditorOnLostFocus = false;
            this.tlClassification.OptionsBehavior.DragNodes = true;
            this.tlClassification.Size = new System.Drawing.Size(148, 446);
            this.tlClassification.TabIndex = 7;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 127;
            // 
            // colLevels
            // 
            this.colLevels.FieldName = "Levels";
            this.colLevels.Name = "colLevels";
            this.colLevels.Visible = true;
            this.colLevels.VisibleIndex = 1;
            this.colLevels.Width = 126;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 126;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.iDTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl2.Panel1.Controls.Add(iDLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.btRemove);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl2.Panel2.Controls.Add(this.btInsert);
            this.splitContainerControl2.Panel2.Controls.Add(iDLabel1);
            this.splitContainerControl2.Panel2.Controls.Add(this.iDClassRProTextBox1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(864, 446);
            this.splitContainerControl2.SplitterPosition = 448;
            this.splitContainerControl2.TabIndex = 8;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(91, 10);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(130, 20);
            this.iDTextBox.TabIndex = 2;
            this.iDTextBox.TextChanged += new System.EventHandler(this.iDTextBox_TextChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.listClassification_PropertiesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(1, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(447, 415);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNameProperties,
            this.colID,
            this.colIDListClassification,
            this.colIDProperties,
            this.colSTT,
            this.colShow,
            this.colNameGroup});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNameGroup, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSTT, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colNameProperties
            // 
            this.colNameProperties.FieldName = "NameProperties";
            this.colNameProperties.Name = "colNameProperties";
            this.colNameProperties.Visible = true;
            this.colNameProperties.VisibleIndex = 1;
            this.colNameProperties.Width = 192;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colIDListClassification
            // 
            this.colIDListClassification.FieldName = "IDListClassification";
            this.colIDListClassification.Name = "colIDListClassification";
            // 
            // colIDProperties
            // 
            this.colIDProperties.FieldName = "IDProperties";
            this.colIDProperties.Name = "colIDProperties";
            this.colIDProperties.Visible = true;
            this.colIDProperties.VisibleIndex = 0;
            this.colIDProperties.Width = 39;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.FixedWidth = true;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 2;
            this.colSTT.Width = 60;
            // 
            // colShow
            // 
            this.colShow.FieldName = "Show";
            this.colShow.Name = "colShow";
            this.colShow.OptionsColumn.FixedWidth = true;
            this.colShow.Visible = true;
            this.colShow.VisibleIndex = 3;
            this.colShow.Width = 60;
            // 
            // colNameGroup
            // 
            this.colNameGroup.FieldName = "NameGroup";
            this.colNameGroup.Name = "colNameGroup";
            this.colNameGroup.Visible = true;
            this.colNameGroup.VisibleIndex = 4;
            // 
            // btRemove
            // 
            this.btRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemove.Location = new System.Drawing.Point(358, 4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "Remove>>";
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.propertiesBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(1, 31);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(392, 415);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "Properties";
            this.propertiesBindingSource.DataSource = this.dBProperties;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryID,
            this.colID1,
            this.colName1,
            this.colNameShow1,
            this.colFilter,
            this.colNameGroup1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCategoryID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.FixedWidth = true;
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            this.colID1.Width = 63;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 2;
            this.colName1.Width = 298;
            // 
            // colNameShow1
            // 
            this.colNameShow1.FieldName = "NameShow";
            this.colNameShow1.Name = "colNameShow1";
            this.colNameShow1.OptionsColumn.FixedWidth = true;
            this.colNameShow1.Width = 112;
            // 
            // colFilter
            // 
            this.colFilter.FieldName = "Filter";
            this.colFilter.Name = "colFilter";
            this.colFilter.OptionsColumn.FixedWidth = true;
            this.colFilter.Visible = true;
            this.colFilter.VisibleIndex = 3;
            this.colFilter.Width = 42;
            // 
            // colNameGroup1
            // 
            this.colNameGroup1.FieldName = "NameGroup";
            this.colNameGroup1.Name = "colNameGroup1";
            this.colNameGroup1.Visible = true;
            this.colNameGroup1.VisibleIndex = 1;
            this.colNameGroup1.Width = 127;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(14, 4);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 4;
            this.btInsert.Text = "<< Insert";
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // iDClassRProTextBox1
            // 
            this.iDClassRProTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "ID", true));
            this.iDClassRProTextBox1.Location = new System.Drawing.Point(145, 6);
            this.iDClassRProTextBox1.Name = "iDClassRProTextBox1";
            this.iDClassRProTextBox1.ReadOnly = true;
            this.iDClassRProTextBox1.Size = new System.Drawing.Size(100, 20);
            this.iDClassRProTextBox1.TabIndex = 7;
            // 
            // frmMapClassificationProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1020, 471);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.listClassificationBindingNavigator);
            this.Name = "frmMapClassificationProperties";
            this.Load += new System.EventHandler(this.frmMapClassificationProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingNavigator)).EndInit();
            this.listClassificationBindingNavigator.ResumeLayout(false);
            this.listClassificationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listClassification_PropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlClassification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBProperties dBProperties;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DBPropertiesTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private DBPropertiesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator listClassificationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listClassificationBindingNavigatorSaveItem;
        private DBPropertiesTableAdapters.ListClassification_PropertiesTableAdapter listClassification_PropertiesTableAdapter;
        private System.Windows.Forms.BindingSource listClassification_PropertiesBindingSource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList tlClassification;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLevels;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
        private DBPropertiesTableAdapters.PropertiesTableAdapter propertiesTableAdapter;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colNameShow1;
        private DevExpress.XtraGrid.Columns.GridColumn colFilter;
        private System.Windows.Forms.TextBox iDTextBox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDListClassification;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProperties;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colShow;
        private DevExpress.XtraGrid.Columns.GridColumn colNameProperties;
        private DevExpress.XtraEditors.SimpleButton btRemove;
        private DevExpress.XtraEditors.SimpleButton btInsert;
        private System.Windows.Forms.TextBox iDClassRProTextBox1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colNameGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colNameGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
    }
}
