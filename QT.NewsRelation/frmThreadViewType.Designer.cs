namespace QT.NewsRelation
{
    partial class frmThreadViewType
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
            System.Windows.Forms.Label iDThreatLabel;
            System.Windows.Forms.Label sTTLabel;
            System.Windows.Forms.Label viewTypeLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label titleLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThreadViewType));
            this.threatViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB = new QT.NewsRelation.DB();
            this.label1 = new System.Windows.Forms.Label();
            this.cboViewType = new System.Windows.Forms.ComboBox();
            this.threatViewTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.threatViewTypeTableAdapter = new QT.NewsRelation.DBTableAdapters.ThreatViewTypeTableAdapter();
            this.threatViewTableAdapter = new QT.NewsRelation.DBTableAdapters.ThreatViewTableAdapter();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.titleTextBox = new System.Windows.Forms.TextBox();
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
            this.btUpdateThreadView = new System.Windows.Forms.ToolStripButton();
            this.viewTypeTextBox = new System.Windows.Forms.TextBox();
            this.sTTViewTypeTextBox = new System.Windows.Forms.TextBox();
            this.iDThreatViewTypeTextBox = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDThreat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.titleThreadSourceTextBox = new System.Windows.Forms.TextBox();
            this.threatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDThreadSourceTextBox = new System.Windows.Forms.TextBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.threatTableAdapter = new QT.NewsRelation.DBTableAdapters.ThreatTableAdapter();
            this.categoryTableAdapter = new QT.NewsRelation.DBTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new QT.NewsRelation.DBTableAdapters.TableAdapterManager();
            iDThreatLabel = new System.Windows.Forms.Label();
            sTTLabel = new System.Windows.Forms.Label();
            viewTypeLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.threatViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threatViewTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDThreatLabel
            // 
            iDThreatLabel.AutoSize = true;
            iDThreatLabel.Location = new System.Drawing.Point(20, 455);
            iDThreatLabel.Name = "iDThreatLabel";
            iDThreatLabel.Size = new System.Drawing.Size(52, 13);
            iDThreatLabel.TabIndex = 4;
            iDThreatLabel.Text = "IDThreat:";
            // 
            // sTTLabel
            // 
            sTTLabel.AutoSize = true;
            sTTLabel.Location = new System.Drawing.Point(41, 481);
            sTTLabel.Name = "sTTLabel";
            sTTLabel.Size = new System.Drawing.Size(31, 13);
            sTTLabel.TabIndex = 6;
            sTTLabel.Text = "STT:";
            // 
            // viewTypeLabel
            // 
            viewTypeLabel.AutoSize = true;
            viewTypeLabel.Location = new System.Drawing.Point(12, 507);
            viewTypeLabel.Name = "viewTypeLabel";
            viewTypeLabel.Size = new System.Drawing.Size(60, 13);
            viewTypeLabel.TabIndex = 8;
            viewTypeLabel.Text = "View Type:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(33, 458);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(24, 484);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Location = new System.Drawing.Point(199, 455);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(30, 13);
            titleLabel1.TabIndex = 10;
            titleLabel1.Text = "Title:";
            // 
            // threatViewBindingSource
            // 
            this.threatViewBindingSource.DataMember = "ThreatView";
            this.threatViewBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại view";
            // 
            // cboViewType
            // 
            this.cboViewType.DataSource = this.threatViewTypeBindingSource;
            this.cboViewType.DisplayMember = "NoiDung";
            this.cboViewType.FormattingEnabled = true;
            this.cboViewType.Location = new System.Drawing.Point(64, 3);
            this.cboViewType.Name = "cboViewType";
            this.cboViewType.Size = new System.Drawing.Size(285, 21);
            this.cboViewType.TabIndex = 0;
            this.cboViewType.ValueMember = "ID";
            this.cboViewType.SelectedIndexChanged += new System.EventHandler(this.cboViewType_SelectedIndexChanged);
            // 
            // threatViewTypeBindingSource
            // 
            this.threatViewTypeBindingSource.DataMember = "ThreatViewType";
            this.threatViewTypeBindingSource.DataSource = this.dB;
            // 
            // threatViewTypeTableAdapter
            // 
            this.threatViewTypeTableAdapter.ClearBeforeFill = true;
            // 
            // threatViewTableAdapter
            // 
            this.threatViewTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(titleLabel1);
            this.splitContainerControl1.Panel1.Controls.Add(this.titleTextBox);
            this.splitContainerControl1.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl1.Panel1.Controls.Add(viewTypeLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.viewTypeTextBox);
            this.splitContainerControl1.Panel1.Controls.Add(sTTLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.sTTViewTypeTextBox);
            this.splitContainerControl1.Panel1.Controls.Add(iDThreatLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.iDThreatViewTypeTextBox);
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.cboViewType);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(titleLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.titleThreadSourceTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(iDLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.iDThreadSourceTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1276, 569);
            this.splitContainerControl1.SplitterPosition = 603;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatViewBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(235, 452);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(348, 20);
            this.titleTextBox.TabIndex = 11;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.threatViewBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.btUpdateThreadView});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 544);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(603, 25);
            this.bindingNavigator1.TabIndex = 10;
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // btUpdateThreadView
            // 
            this.btUpdateThreadView.Image = ((System.Drawing.Image)(resources.GetObject("btUpdateThreadView.Image")));
            this.btUpdateThreadView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUpdateThreadView.Name = "btUpdateThreadView";
            this.btUpdateThreadView.Size = new System.Drawing.Size(65, 22);
            this.btUpdateThreadView.Text = "Update";
            this.btUpdateThreadView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUpdateThreadView.Click += new System.EventHandler(this.btUpdateThreadView_Click);
            // 
            // viewTypeTextBox
            // 
            this.viewTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatViewBindingSource, "ViewType", true));
            this.viewTypeTextBox.Location = new System.Drawing.Point(78, 504);
            this.viewTypeTextBox.Name = "viewTypeTextBox";
            this.viewTypeTextBox.ReadOnly = true;
            this.viewTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.viewTypeTextBox.TabIndex = 9;
            // 
            // sTTViewTypeTextBox
            // 
            this.sTTViewTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatViewBindingSource, "STT", true));
            this.sTTViewTypeTextBox.Location = new System.Drawing.Point(78, 478);
            this.sTTViewTypeTextBox.Name = "sTTViewTypeTextBox";
            this.sTTViewTypeTextBox.ReadOnly = true;
            this.sTTViewTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sTTViewTypeTextBox.TabIndex = 7;
            // 
            // iDThreatViewTypeTextBox
            // 
            this.iDThreatViewTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatViewBindingSource, "IDThreat", true));
            this.iDThreatViewTypeTextBox.Location = new System.Drawing.Point(78, 452);
            this.iDThreatViewTypeTextBox.Name = "iDThreatViewTypeTextBox";
            this.iDThreatViewTypeTextBox.ReadOnly = true;
            this.iDThreatViewTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDThreatViewTypeTextBox.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.threatViewBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(602, 416);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDThreat,
            this.colSTT,
            this.colViewType,
            this.colTitle});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.FixedWidth = true;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 45;
            // 
            // colIDThreat
            // 
            this.colIDThreat.FieldName = "IDThreat";
            this.colIDThreat.Name = "colIDThreat";
            this.colIDThreat.OptionsColumn.AllowEdit = false;
            this.colIDThreat.OptionsColumn.FixedWidth = true;
            this.colIDThreat.Visible = true;
            this.colIDThreat.VisibleIndex = 1;
            this.colIDThreat.Width = 89;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.FixedWidth = true;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 2;
            this.colSTT.Width = 40;
            // 
            // colViewType
            // 
            this.colViewType.FieldName = "ViewType";
            this.colViewType.Name = "colViewType";
            this.colViewType.Width = 137;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.OptionsColumn.AllowEdit = false;
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 3;
            this.colTitle.Width = 411;
            // 
            // titleThreadSourceTextBox
            // 
            this.titleThreadSourceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "Title", true));
            this.titleThreadSourceTextBox.Location = new System.Drawing.Point(60, 481);
            this.titleThreadSourceTextBox.Name = "titleThreadSourceTextBox";
            this.titleThreadSourceTextBox.ReadOnly = true;
            this.titleThreadSourceTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleThreadSourceTextBox.TabIndex = 4;
            // 
            // threatBindingSource
            // 
            this.threatBindingSource.DataMember = "Threat";
            this.threatBindingSource.DataSource = this.dB;
            // 
            // iDThreadSourceTextBox
            // 
            this.iDThreadSourceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "ID", true));
            this.iDThreadSourceTextBox.Location = new System.Drawing.Point(60, 455);
            this.iDThreadSourceTextBox.Name = "iDThreadSourceTextBox";
            this.iDThreadSourceTextBox.ReadOnly = true;
            this.iDThreadSourceTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDThreadSourceTextBox.TabIndex = 3;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.threatBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(60, 30);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl2.Size = new System.Drawing.Size(598, 416);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colTitle1,
            this.colViewMonth,
            this.colCategoryID});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCategoryID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.AllowEdit = false;
            this.colID1.OptionsColumn.FixedWidth = true;
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            this.colID1.Width = 98;
            // 
            // colTitle1
            // 
            this.colTitle1.FieldName = "Title";
            this.colTitle1.Name = "colTitle1";
            this.colTitle1.OptionsColumn.AllowEdit = false;
            this.colTitle1.Visible = true;
            this.colTitle1.VisibleIndex = 1;
            this.colTitle1.Width = 411;
            // 
            // colViewMonth
            // 
            this.colViewMonth.FieldName = "ViewMonth";
            this.colViewMonth.Name = "colViewMonth";
            this.colViewMonth.OptionsColumn.AllowEdit = false;
            this.colViewMonth.OptionsColumn.FixedWidth = true;
            this.colViewMonth.Visible = true;
            this.colViewMonth.VisibleIndex = 2;
            this.colViewMonth.Width = 72;
            // 
            // colCategoryID
            // 
            this.colCategoryID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 3;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.categoryBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dB;
            // 
            // threatTableAdapter
            // 
            this.threatTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.Threat_ContentTableAdapter = null;
            this.tableAdapterManager.ThreatConfig_ContainTableAdapter = null;
            this.tableAdapterManager.ThreatConfig_NotContainTableAdapter = null;
            this.tableAdapterManager.ThreatConfig_OrContainTableAdapter = null;
            this.tableAdapterManager.ThreatConfig_OrNotContainTableAdapter = null;
            this.tableAdapterManager.ThreatConfig_WebTableAdapter = null;
            this.tableAdapterManager.ThreatConfigTableAdapter = null;
            this.tableAdapterManager.ThreatTableAdapter = this.threatTableAdapter;
            this.tableAdapterManager.ThreatViewTableAdapter = this.threatViewTableAdapter;
            this.tableAdapterManager.ThreatViewTypeTableAdapter = this.threatViewTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.NewsRelation.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserPersonTableAdapter = null;
            this.tableAdapterManager.UserPersonTypeTableAdapter = null;
            // 
            // frmThreadViewType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1276, 569);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmThreadViewType";
            this.Load += new System.EventHandler(this.frmViewType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.threatViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threatViewTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboViewType;
        private DB dB;
        private System.Windows.Forms.BindingSource threatViewTypeBindingSource;
        private DBTableAdapters.ThreatViewTypeTableAdapter threatViewTypeTableAdapter;
        private System.Windows.Forms.BindingSource threatViewBindingSource;
        private DBTableAdapters.ThreatViewTableAdapter threatViewTableAdapter;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDThreat;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colViewType;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource threatBindingSource;
        private DBTableAdapters.ThreatTableAdapter threatTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle1;
        private DevExpress.XtraGrid.Columns.GridColumn colViewMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DBTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.TextBox viewTypeTextBox;
        private System.Windows.Forms.TextBox sTTViewTypeTextBox;
        private System.Windows.Forms.TextBox iDThreatViewTypeTextBox;
        private System.Windows.Forms.TextBox titleThreadSourceTextBox;
        private System.Windows.Forms.TextBox iDThreadSourceTextBox;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ToolStripButton btUpdateThreadView;
    }
}
