namespace QT.Moduls.Maps
{
    partial class ctrEditeKeyword
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
            System.Windows.Forms.Label keyHashLabel;
            System.Windows.Forms.Label keyNameLabel;
            System.Windows.Forms.Label keyHashLabel1;
            System.Windows.Forms.Label keyNameLabel1;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrEditeKeyword));
            this.gridKe = new DevExpress.XtraGrid.GridControl();
            this.keywordsBindingSource = new System.Windows.Forms.BindingSource();
            this.kW = new QT.Moduls.Data.KW();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKeyHash1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyFreq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.keywordsTempBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKeyHash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.keywordsTableAdapter = new QT.Moduls.Data.KWTableAdapters.KeywordsTableAdapter();
            this.keywordsTempTableAdapter = new QT.Moduls.Data.KWTableAdapters.KeywordsTempTableAdapter();
            this.btLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.tableAdapterManager = new QT.Moduls.Data.KWTableAdapters.TableAdapterManager();
            this.keyHashTextBox = new System.Windows.Forms.TextBox();
            this.keyNameTextBox = new System.Windows.Forms.TextBox();
            this.keyHashTextBox1 = new System.Windows.Forms.TextBox();
            this.keyNameTextBox1 = new System.Windows.Forms.TextBox();
            this.btAuto = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoLanXuatHien = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator();
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
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btCRC64 = new DevExpress.XtraEditors.SimpleButton();
            this.lames = new DevExpress.XtraEditors.LabelControl();
            keyHashLabel = new System.Windows.Forms.Label();
            keyNameLabel = new System.Windows.Forms.Label();
            keyHashLabel1 = new System.Windows.Forms.Label();
            keyNameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsTempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyHashLabel
            // 
            keyHashLabel.AutoSize = true;
            keyHashLabel.Enabled = false;
            keyHashLabel.Location = new System.Drawing.Point(44, 373);
            keyHashLabel.Name = "keyHashLabel";
            keyHashLabel.Size = new System.Drawing.Size(56, 13);
            keyHashLabel.TabIndex = 5;
            keyHashLabel.Text = "Key Hash:";
            // 
            // keyNameLabel
            // 
            keyNameLabel.AutoSize = true;
            keyNameLabel.Enabled = false;
            keyNameLabel.Location = new System.Drawing.Point(41, 399);
            keyNameLabel.Name = "keyNameLabel";
            keyNameLabel.Size = new System.Drawing.Size(59, 13);
            keyNameLabel.TabIndex = 6;
            keyNameLabel.Text = "Key Name:";
            // 
            // keyHashLabel1
            // 
            keyHashLabel1.AutoSize = true;
            keyHashLabel1.Enabled = false;
            keyHashLabel1.Location = new System.Drawing.Point(503, 373);
            keyHashLabel1.Name = "keyHashLabel1";
            keyHashLabel1.Size = new System.Drawing.Size(56, 13);
            keyHashLabel1.TabIndex = 8;
            keyHashLabel1.Text = "Key Hash:";
            // 
            // keyNameLabel1
            // 
            keyNameLabel1.AutoSize = true;
            keyNameLabel1.Enabled = false;
            keyNameLabel1.Location = new System.Drawing.Point(500, 399);
            keyNameLabel1.Name = "keyNameLabel1";
            keyNameLabel1.Size = new System.Drawing.Size(59, 13);
            keyNameLabel1.TabIndex = 10;
            keyNameLabel1.Text = "Key Name:";
            // 
            // gridKe
            // 
            this.gridKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKe.DataSource = this.keywordsBindingSource;
            this.gridKe.Location = new System.Drawing.Point(3, 61);
            this.gridKe.MainView = this.gridView2;
            this.gridKe.Name = "gridKe";
            this.gridKe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridKe.Size = new System.Drawing.Size(436, 360);
            this.gridKe.TabIndex = 4;
            this.gridKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridKe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridKe_MouseDoubleClick);
            // 
            // keywordsBindingSource
            // 
            this.keywordsBindingSource.DataMember = "Keywords";
            this.keywordsBindingSource.DataSource = this.kW;
            // 
            // kW
            // 
            this.kW.DataSetName = "KW";
            this.kW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKeyHash1,
            this.colKeyName1,
            this.colKeyFreq,
            this.colLastUpdate});
            this.gridView2.GridControl = this.gridKe;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colKeyHash1
            // 
            this.colKeyHash1.FieldName = "KeyHash";
            this.colKeyHash1.Name = "colKeyHash1";
            this.colKeyHash1.OptionsColumn.AllowEdit = false;
            this.colKeyHash1.Visible = true;
            this.colKeyHash1.VisibleIndex = 0;
            // 
            // colKeyName1
            // 
            this.colKeyName1.FieldName = "KeyName";
            this.colKeyName1.Name = "colKeyName1";
            this.colKeyName1.OptionsColumn.AllowEdit = false;
            this.colKeyName1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colKeyName1.Visible = true;
            this.colKeyName1.VisibleIndex = 1;
            // 
            // colKeyFreq
            // 
            this.colKeyFreq.FieldName = "KeyFreq";
            this.colKeyFreq.Name = "colKeyFreq";
            this.colKeyFreq.Visible = true;
            this.colKeyFreq.VisibleIndex = 2;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.ColumnEdit = this.repositoryItemDateEdit1;
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.OptionsColumn.AllowEdit = false;
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 3;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.keywordsTempBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(445, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(296, 360);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDoubleClick);
            // 
            // keywordsTempBindingSource
            // 
            this.keywordsTempBindingSource.DataMember = "KeywordsTemp";
            this.keywordsTempBindingSource.DataSource = this.kW;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKeyHash,
            this.colKeyName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colKeyHash
            // 
            this.colKeyHash.FieldName = "KeyHash";
            this.colKeyHash.Name = "colKeyHash";
            this.colKeyHash.OptionsColumn.AllowEdit = false;
            this.colKeyHash.Visible = true;
            this.colKeyHash.VisibleIndex = 0;
            // 
            // colKeyName
            // 
            this.colKeyName.FieldName = "KeyName";
            this.colKeyName.Name = "colKeyName";
            this.colKeyName.OptionsColumn.AllowEdit = false;
            this.colKeyName.Visible = true;
            this.colKeyName.VisibleIndex = 1;
            // 
            // keywordsTableAdapter
            // 
            this.keywordsTableAdapter.ClearBeforeFill = true;
            // 
            // keywordsTempTableAdapter
            // 
            this.keywordsTempTableAdapter.ClearBeforeFill = true;
            // 
            // btLoadData
            // 
            this.btLoadData.Location = new System.Drawing.Point(0, 0);
            this.btLoadData.Name = "btLoadData";
            this.btLoadData.Size = new System.Drawing.Size(100, 23);
            this.btLoadData.TabIndex = 5;
            this.btLoadData.Text = "Tải dữ liệu";
            this.btLoadData.Click += new System.EventHandler(this.btLoadData_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(363, 0);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(100, 23);
            this.btUpdate.TabIndex = 5;
            this.btUpdate.Text = "Update";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Keywords_SeoTableAdapter = null;
            this.tableAdapterManager.KeywordsExportTableAdapter = null;
            this.tableAdapterManager.KeywordsSeoTableAdapter = null;
            this.tableAdapterManager.KeywordsTableAdapter = this.keywordsTableAdapter;
            this.tableAdapterManager.KeywordsTempTableAdapter = this.keywordsTempTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Data.KWTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // keyHashTextBox
            // 
            this.keyHashTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsBindingSource, "KeyHash", true));
            this.keyHashTextBox.Enabled = false;
            this.keyHashTextBox.Location = new System.Drawing.Point(106, 370);
            this.keyHashTextBox.Name = "keyHashTextBox";
            this.keyHashTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyHashTextBox.TabIndex = 6;
            // 
            // keyNameTextBox
            // 
            this.keyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsBindingSource, "KeyName", true));
            this.keyNameTextBox.Enabled = false;
            this.keyNameTextBox.Location = new System.Drawing.Point(106, 396);
            this.keyNameTextBox.Name = "keyNameTextBox";
            this.keyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyNameTextBox.TabIndex = 7;
            // 
            // keyHashTextBox1
            // 
            this.keyHashTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsTempBindingSource, "KeyHash", true));
            this.keyHashTextBox1.Enabled = false;
            this.keyHashTextBox1.Location = new System.Drawing.Point(565, 370);
            this.keyHashTextBox1.Name = "keyHashTextBox1";
            this.keyHashTextBox1.Size = new System.Drawing.Size(100, 20);
            this.keyHashTextBox1.TabIndex = 9;
            // 
            // keyNameTextBox1
            // 
            this.keyNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsTempBindingSource, "KeyName", true));
            this.keyNameTextBox1.Enabled = false;
            this.keyNameTextBox1.Location = new System.Drawing.Point(565, 396);
            this.keyNameTextBox1.Name = "keyNameTextBox1";
            this.keyNameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.keyNameTextBox1.TabIndex = 11;
            // 
            // btAuto
            // 
            this.btAuto.Location = new System.Drawing.Point(257, 0);
            this.btAuto.Name = "btAuto";
            this.btAuto.Size = new System.Drawing.Size(100, 23);
            this.btAuto.TabIndex = 5;
            this.btAuto.Text = "Auto chuyển";
            this.btAuto.Click += new System.EventHandler(this.btAuto_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(106, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Số lần xuất hiện";
            // 
            // txtSoLanXuatHien
            // 
            this.txtSoLanXuatHien.Location = new System.Drawing.Point(189, 3);
            this.txtSoLanXuatHien.Name = "txtSoLanXuatHien";
            this.txtSoLanXuatHien.Size = new System.Drawing.Size(62, 20);
            this.txtSoLanXuatHien.TabIndex = 13;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.keywordsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 33);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 14;
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
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton1;
            this.bindingNavigator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigator2.BindingSource = this.keywordsTempBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = this.toolStripButton2;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2});
            this.bindingNavigator2.Location = new System.Drawing.Point(476, 33);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator2.TabIndex = 14;
            this.bindingNavigator2.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
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
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btCRC64
            // 
            this.btCRC64.Location = new System.Drawing.Point(469, 0);
            this.btCRC64.Name = "btCRC64";
            this.btCRC64.Size = new System.Drawing.Size(121, 23);
            this.btCRC64.TabIndex = 5;
            this.btCRC64.Text = "UpdateCountSearch";
            this.btCRC64.Click += new System.EventHandler(this.btCRC64_Click);
            // 
            // lames
            // 
            this.lames.Location = new System.Drawing.Point(596, 6);
            this.lames.Name = "lames";
            this.lames.Size = new System.Drawing.Size(19, 13);
            this.lames.TabIndex = 12;
            this.lames.Text = "mes";
            // 
            // ctrEditeKeyword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.txtSoLanXuatHien);
            this.Controls.Add(this.lames);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btAuto);
            this.Controls.Add(this.btCRC64);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btLoadData);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridKe);
            this.Controls.Add(keyNameLabel1);
            this.Controls.Add(this.keyNameTextBox1);
            this.Controls.Add(keyHashLabel1);
            this.Controls.Add(this.keyHashTextBox1);
            this.Controls.Add(keyNameLabel);
            this.Controls.Add(this.keyNameTextBox);
            this.Controls.Add(keyHashLabel);
            this.Controls.Add(this.keyHashTextBox);
            this.Name = "ctrEditeKeyword";
            this.Size = new System.Drawing.Size(744, 424);
            ((System.ComponentModel.ISupportInitialize)(this.gridKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsTempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridKe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource keywordsBindingSource;
        private Data.KW kW;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyHash1;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyName1;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyFreq;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private System.Windows.Forms.BindingSource keywordsTempBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyHash;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyName;
        private Data.KWTableAdapters.KeywordsTableAdapter keywordsTableAdapter;
        private Data.KWTableAdapters.KeywordsTempTableAdapter keywordsTempTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btLoadData;
        private DevExpress.XtraEditors.SimpleButton btUpdate;
        private Data.KWTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox keyHashTextBox;
        private System.Windows.Forms.TextBox keyNameTextBox;
        private System.Windows.Forms.TextBox keyHashTextBox1;
        private System.Windows.Forms.TextBox keyNameTextBox1;
        private DevExpress.XtraEditors.SimpleButton btAuto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtSoLanXuatHien;
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
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private DevExpress.XtraEditors.SimpleButton btCRC64;
        private DevExpress.XtraEditors.LabelControl lames;
    }
}
