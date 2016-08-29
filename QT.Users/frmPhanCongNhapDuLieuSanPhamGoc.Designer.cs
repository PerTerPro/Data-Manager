namespace QT.Users
{
    partial class frmPhanCongNhapDuLieuSanPhamGoc
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label iDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCongNhapDuLieuSanPhamGoc));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colValid1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPhanSP = new QT.Users.DBPhanSP();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btLoadCat = new DevExpress.XtraEditors.SimpleButton();
            this.btExpanCat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.iDClassificationTextBox = new System.Windows.Forms.TextBox();
            this.ViewInfoAssignButton = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Select1000Button = new DevExpress.XtraEditors.SimpleButton();
            this.Select500Button = new DevExpress.XtraEditors.SimpleButton();
            this.txtViewCount = new DevExpress.XtraEditors.TextEdit();
            this.txtNameSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategorySTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.btSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btReLoadAllProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btPhanTichLai = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.userNameSelectTextBox = new System.Windows.Forms.TextBox();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB = new QT.Users.DB();
            this.cboListUser = new System.Windows.Forms.ComboBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.productJobUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewCount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.job_NhapLieuStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colLastUpdateJob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iDUserSelectTextBox = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btXoaCongViecUser = new DevExpress.XtraEditors.SimpleButton();
            this.btTaiJobUser = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btDay = new DevExpress.XtraEditors.SimpleButton();
            this.listClassificationTableAdapter = new QT.Users.DBPhanSPTableAdapters.ListClassificationTableAdapter();
            this.tblUserTableAdapter = new QT.Users.DBTableAdapters.tblUserTableAdapter();
            this.tableAdapterManager = new QT.Users.DBPhanSPTableAdapters.TableAdapterManager();
            this.job_NhapLieuStatusTableAdapter = new QT.Users.DBPhanSPTableAdapters.Job_NhapLieuStatusTableAdapter();
            this.job_SPGocNhapLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.job_SPGocNhapLieuTableAdapter = new QT.Users.DBPhanSPTableAdapters.Job_SPGocNhapLieuTableAdapter();
            this.job_SPGocNhapLieuLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.job_SPGocNhapLieuLogTableAdapter = new QT.Users.DBPhanSPTableAdapters.Job_SPGocNhapLieuLogTableAdapter();
            this.job_SPGocNhapLieuTempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.job_SPGocNhapLieuTempTableAdapter = new QT.Users.DBPhanSPTableAdapters.Job_SPGocNhapLieuTempTableAdapter();
            this.productTableAdapter = new QT.Users.DBPhanSPTableAdapters.ProductTableAdapter();
            this.tableAdapterManager1 = new QT.Users.DBTableAdapters.TableAdapterManager();
            this.productJobUserTableAdapter = new QT.Users.DBPhanSPTableAdapters.ProductJobUserTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPhanSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtViewCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productJobUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_NhapLieuStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_SPGocNhapLieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_SPGocNhapLieuLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_SPGocNhapLieuTempBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(138, 11);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 9;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 27);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(69, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Chuyên mục:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(101, 53);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 3;
            iDLabel1.Text = "ID:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1252, 635);
            this.splitContainerControl1.SplitterPosition = 377;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(378, 632);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.treeList1);
            this.xtraTabPage1.Controls.Add(this.panelControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(372, 604);
            this.xtraTabPage1.Text = "Chọn chuyên mục";
            // 
            // treeList1
            // 
            this.treeList1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.treeList1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName1,
            this.colValid1,
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeList1.CustomizationFormBounds = new System.Drawing.Rectangle(306, 478, 216, 178);
            this.treeList1.DataSource = this.listClassificationBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 44);
            this.treeList1.Name = "treeList1";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.treeList1.Size = new System.Drawing.Size(372, 560);
            this.treeList1.TabIndex = 8;
            // 
            // colName1
            // 
            this.colName1.Caption = "Tên chuyên mục";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.ReadOnly = true;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 177;
            // 
            // colValid1
            // 
            this.colValid1.FieldName = "Valid";
            this.colValid1.Name = "colValid1";
            this.colValid1.OptionsColumn.FixedWidth = true;
            this.colValid1.OptionsColumn.ReadOnly = true;
            this.colValid1.Width = 66;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.treeListColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.treeListColumn1.Caption = "Info";
            this.treeListColumn1.FieldName = "InfoAssignment";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 1;
            this.treeListColumn1.Width = 83;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Xem DS";
            this.treeListColumn2.ColumnEdit = this.repositoryItemButtonEdit1;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.ToolTip = "Xem tất cả sản phẩm thuộc CHUYÊN MỤC chưa được giao";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 2;
            this.treeListColumn2.Width = 52;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.repositoryItemButtonEdit1.Appearance.Options.UseForeColor = true;
            serializableAppearanceObject2.ForeColor = System.Drawing.Color.DarkTurquoise;
            serializableAppearanceObject2.Options.UseForeColor = true;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "XemDS", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dBPhanSP;
            // 
            // dBPhanSP
            // 
            this.dBPhanSP.DataSetName = "DBPhanSP";
            this.dBPhanSP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btLoadCat);
            this.panelControl2.Controls.Add(this.btExpanCat);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.iDClassificationTextBox);
            this.panelControl2.Controls.Add(this.ViewInfoAssignButton);
            this.panelControl2.Controls.Add(iDLabel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(372, 44);
            this.panelControl2.TabIndex = 14;
            // 
            // btLoadCat
            // 
            this.btLoadCat.Location = new System.Drawing.Point(2, 5);
            this.btLoadCat.Name = "btLoadCat";
            this.btLoadCat.Size = new System.Drawing.Size(60, 23);
            this.btLoadCat.TabIndex = 9;
            this.btLoadCat.Text = "Load Cat";
            this.btLoadCat.Click += new System.EventHandler(this.btLoadCat_Click);
            // 
            // btExpanCat
            // 
            this.btExpanCat.Location = new System.Drawing.Point(68, 5);
            this.btExpanCat.Name = "btExpanCat";
            this.btExpanCat.Size = new System.Drawing.Size(60, 23);
            this.btExpanCat.TabIndex = 9;
            this.btExpanCat.Text = "Expan";
            this.btExpanCat.Click += new System.EventHandler(this.btExpanCat_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(295, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Cập nhật Info";
            this.simpleButton1.ToolTip = "Cập nhật lại Số SP chưa phân công/ Tổng số sản phẩm";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // iDClassificationTextBox
            // 
            this.iDClassificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "ID", true));
            this.iDClassificationTextBox.Location = new System.Drawing.Point(165, 8);
            this.iDClassificationTextBox.Name = "iDClassificationTextBox";
            this.iDClassificationTextBox.ReadOnly = true;
            this.iDClassificationTextBox.Size = new System.Drawing.Size(34, 20);
            this.iDClassificationTextBox.TabIndex = 10;
            // 
            // ViewInfoAssignButton
            // 
            this.ViewInfoAssignButton.Location = new System.Drawing.Point(205, 5);
            this.ViewInfoAssignButton.Name = "ViewInfoAssignButton";
            this.ViewInfoAssignButton.Size = new System.Drawing.Size(84, 23);
            this.ViewInfoAssignButton.TabIndex = 11;
            this.ViewInfoAssignButton.Text = "Xem Công việc";
            this.ViewInfoAssignButton.ToolTip = "Cập nhật lại Số SP chưa phân công/ Tổng số sản phẩm";
            this.ViewInfoAssignButton.Click += new System.EventHandler(this.ViewInfoAssignButton_Click);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl2.Panel1.Controls.Add(this.Select1000Button);
            this.splitContainerControl2.Panel1.Controls.Add(this.Select500Button);
            this.splitContainerControl2.Panel1.Controls.Add(this.txtViewCount);
            this.splitContainerControl2.Panel1.Controls.Add(this.txtNameSearch);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl2.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl2.Panel1.Controls.Add(nameLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.nameLabel1);
            this.splitContainerControl2.Panel1.Controls.Add(this.btSearch);
            this.splitContainerControl2.Panel1.Controls.Add(this.btReLoadAllProduct);
            this.splitContainerControl2.Panel1.Controls.Add(this.btPhanTichLai);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.userNameSelectTextBox);
            this.splitContainerControl2.Panel2.Controls.Add(this.cboListUser);
            this.splitContainerControl2.Panel2.Controls.Add(this.bindingNavigator2);
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl2.Panel2.Controls.Add(iDLabel1);
            this.splitContainerControl2.Panel2.Controls.Add(this.iDUserSelectTextBox);
            this.splitContainerControl2.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl2.Panel2.Controls.Add(this.btXoaCongViecUser);
            this.splitContainerControl2.Panel2.Controls.Add(this.btTaiJobUser);
            this.splitContainerControl2.Panel2.Controls.Add(this.labelControl4);
            this.splitContainerControl2.Panel2.Controls.Add(this.btDay);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(870, 635);
            this.splitContainerControl2.SplitterPosition = 470;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(166, 79);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(60, 23);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Expan";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Select1000Button
            // 
            this.Select1000Button.Location = new System.Drawing.Point(85, 79);
            this.Select1000Button.Name = "Select1000Button";
            this.Select1000Button.Size = new System.Drawing.Size(75, 23);
            this.Select1000Button.TabIndex = 10;
            this.Select1000Button.Text = "Chọn 1000SP";
            this.Select1000Button.Click += new System.EventHandler(this.Select1000Button_Click);
            // 
            // Select500Button
            // 
            this.Select500Button.Location = new System.Drawing.Point(4, 79);
            this.Select500Button.Name = "Select500Button";
            this.Select500Button.Size = new System.Drawing.Size(75, 23);
            this.Select500Button.TabIndex = 9;
            this.Select500Button.Text = "Chọn 500SP";
            this.Select500Button.Click += new System.EventHandler(this.Select500Button_Click);
            // 
            // txtViewCount
            // 
            this.txtViewCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtViewCount.EditValue = "0";
            this.txtViewCount.Location = new System.Drawing.Point(314, 50);
            this.txtViewCount.Name = "txtViewCount";
            this.txtViewCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtViewCount.Size = new System.Drawing.Size(53, 20);
            this.txtViewCount.TabIndex = 8;
            this.txtViewCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameSearch_KeyDown);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSearch.Location = new System.Drawing.Point(26, 51);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(248, 20);
            this.txtNameSearch.TabIndex = 7;
            this.txtNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameSearch_KeyDown);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(280, 54);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "View>";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(16, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tìm";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.productBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
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
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 610);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(470, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBPhanSP;
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
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.productBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 112);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(466, 495);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colPrice,
            this.colCategorySTT,
            this.colViewCount,
            this.colLastUpdate,
            this.colStatus,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "Tổng SP thuộc chuyên mục = {0}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 138;
            // 
            // colPrice
            // 
            this.colPrice.DisplayFormat.FormatString = "n0";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.FixedWidth = true;
            this.colPrice.OptionsColumn.ReadOnly = true;
            // 
            // colCategorySTT
            // 
            this.colCategorySTT.DisplayFormat.FormatString = "n0";
            this.colCategorySTT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCategorySTT.FieldName = "CategorySTT";
            this.colCategorySTT.Name = "colCategorySTT";
            this.colCategorySTT.Visible = true;
            this.colCategorySTT.VisibleIndex = 2;
            // 
            // colViewCount
            // 
            this.colViewCount.DisplayFormat.FormatString = "n0";
            this.colViewCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colViewCount.FieldName = "ViewCount";
            this.colViewCount.Name = "colViewCount";
            this.colViewCount.Visible = true;
            this.colViewCount.VisibleIndex = 3;
            this.colViewCount.Width = 67;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 4;
            this.colLastUpdate.Width = 62;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            this.colStatus.Width = 65;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "CategoryID";
            this.gridColumn1.FieldName = "CategoryID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // nameLabel1
            // 
            this.nameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(78, 27);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(388, 17);
            this.nameLabel1.TabIndex = 3;
            this.nameLabel1.Text = "label1";
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.Location = new System.Drawing.Point(379, 49);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(87, 23);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "Tìm";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btReLoadAllProduct
            // 
            this.btReLoadAllProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReLoadAllProduct.Location = new System.Drawing.Point(331, 79);
            this.btReLoadAllProduct.Name = "btReLoadAllProduct";
            this.btReLoadAllProduct.Size = new System.Drawing.Size(135, 23);
            this.btReLoadAllProduct.TabIndex = 1;
            this.btReLoadAllProduct.Text = "Lấy lại toàn bộ sản phẩm";
            this.btReLoadAllProduct.Visible = false;
            this.btReLoadAllProduct.Click += new System.EventHandler(this.btReLoadAllProduct_Click);
            // 
            // btPhanTichLai
            // 
            this.btPhanTichLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPhanTichLai.Location = new System.Drawing.Point(390, 5);
            this.btPhanTichLai.Name = "btPhanTichLai";
            this.btPhanTichLai.Size = new System.Drawing.Size(76, 23);
            this.btPhanTichLai.TabIndex = 1;
            this.btPhanTichLai.Text = "Phân tích lại";
            this.btPhanTichLai.Visible = false;
            this.btPhanTichLai.Click += new System.EventHandler(this.btPhanTichLai_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(3, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(263, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Danh sách sản phẩm chưa được phân";
            // 
            // userNameSelectTextBox
            // 
            this.userNameSelectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "UserName", true));
            this.userNameSelectTextBox.Location = new System.Drawing.Point(173, 50);
            this.userNameSelectTextBox.Name = "userNameSelectTextBox";
            this.userNameSelectTextBox.ReadOnly = true;
            this.userNameSelectTextBox.Size = new System.Drawing.Size(92, 20);
            this.userNameSelectTextBox.TabIndex = 11;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboListUser
            // 
            this.cboListUser.DataSource = this.tblUserBindingSource;
            this.cboListUser.DisplayMember = "UserName";
            this.cboListUser.FormattingEnabled = true;
            this.cboListUser.Location = new System.Drawing.Point(81, 23);
            this.cboListUser.Name = "cboListUser";
            this.cboListUser.Size = new System.Drawing.Size(176, 21);
            this.cboListUser.TabIndex = 7;
            this.cboListUser.ValueMember = "ID";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.productJobUserBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 610);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(395, 25);
            this.bindingNavigator2.TabIndex = 6;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // productJobUserBindingSource
            // 
            this.productJobUserBindingSource.DataMember = "ProductJobUser";
            this.productJobUserBindingSource.DataSource = this.dBPhanSP;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
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
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.productJobUserBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(0, 82);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl2.Size = new System.Drawing.Size(390, 525);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryID,
            this.colName2,
            this.colPrice1,
            this.colViewCount1,
            this.colJobStatus,
            this.colLastUpdateJob});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupCount = 1;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", null, "Tổng SP = {0}")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCategoryID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 0;
            // 
            // colName2
            // 
            this.colName2.FieldName = "Name";
            this.colName2.Name = "colName2";
            this.colName2.Visible = true;
            this.colName2.VisibleIndex = 1;
            this.colName2.Width = 163;
            // 
            // colPrice1
            // 
            this.colPrice1.DisplayFormat.FormatString = "n0";
            this.colPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice1.FieldName = "Price";
            this.colPrice1.Name = "colPrice1";
            this.colPrice1.OptionsColumn.AllowEdit = false;
            this.colPrice1.OptionsColumn.FixedWidth = true;
            this.colPrice1.OptionsColumn.ReadOnly = true;
            this.colPrice1.Width = 60;
            // 
            // colViewCount1
            // 
            this.colViewCount1.DisplayFormat.FormatString = "n0";
            this.colViewCount1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colViewCount1.FieldName = "ViewCount";
            this.colViewCount1.Name = "colViewCount1";
            this.colViewCount1.Visible = true;
            this.colViewCount1.VisibleIndex = 2;
            this.colViewCount1.Width = 70;
            // 
            // colJobStatus
            // 
            this.colJobStatus.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colJobStatus.FieldName = "JobStatus";
            this.colJobStatus.Name = "colJobStatus";
            this.colJobStatus.Visible = true;
            this.colJobStatus.VisibleIndex = 3;
            this.colJobStatus.Width = 66;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.job_NhapLieuStatusBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // job_NhapLieuStatusBindingSource
            // 
            this.job_NhapLieuStatusBindingSource.DataMember = "Job_NhapLieuStatus";
            this.job_NhapLieuStatusBindingSource.DataSource = this.dBPhanSP;
            // 
            // colLastUpdateJob
            // 
            this.colLastUpdateJob.DisplayFormat.FormatString = "dd/MM/yy-hh:mm";
            this.colLastUpdateJob.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUpdateJob.FieldName = "LastUpdateJob";
            this.colLastUpdateJob.Name = "colLastUpdateJob";
            this.colLastUpdateJob.Visible = true;
            this.colLastUpdateJob.VisibleIndex = 4;
            this.colLastUpdateJob.Width = 86;
            // 
            // iDUserSelectTextBox
            // 
            this.iDUserSelectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "ID", true));
            this.iDUserSelectTextBox.Location = new System.Drawing.Point(126, 50);
            this.iDUserSelectTextBox.Name = "iDUserSelectTextBox";
            this.iDUserSelectTextBox.ReadOnly = true;
            this.iDUserSelectTextBox.Size = new System.Drawing.Size(44, 20);
            this.iDUserSelectTextBox.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Chọn tài khoản";
            // 
            // btXoaCongViecUser
            // 
            this.btXoaCongViecUser.Location = new System.Drawing.Point(308, 49);
            this.btXoaCongViecUser.Name = "btXoaCongViecUser";
            this.btXoaCongViecUser.Size = new System.Drawing.Size(82, 23);
            this.btXoaCongViecUser.TabIndex = 1;
            this.btXoaCongViecUser.Text = "Xóa";
            this.btXoaCongViecUser.Click += new System.EventHandler(this.btXoaCongViecUser_Click);
            // 
            // btTaiJobUser
            // 
            this.btTaiJobUser.Location = new System.Drawing.Point(258, 22);
            this.btTaiJobUser.Name = "btTaiJobUser";
            this.btTaiJobUser.Size = new System.Drawing.Size(132, 23);
            this.btTaiJobUser.TabIndex = 1;
            this.btTaiJobUser.Text = "Xem công việc của user";
            this.btTaiJobUser.Click += new System.EventHandler(this.btTaiJobUser_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(3, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(205, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Danh sách sản phẩm Đã phân";
            // 
            // btDay
            // 
            this.btDay.Location = new System.Drawing.Point(2, 49);
            this.btDay.Name = "btDay";
            this.btDay.Size = new System.Drawing.Size(94, 23);
            this.btDay.TabIndex = 1;
            this.btDay.Text = "Chuyển việc >>";
            this.btDay.Click += new System.EventHandler(this.btDay_Click);
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Job_SPGocNhapLieuLogTableAdapter = null;
            this.tableAdapterManager.Job_SPGocNhapLieuTableAdapter = null;
            this.tableAdapterManager.Job_SPGocNhapLieuTempTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Users.DBPhanSPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // job_NhapLieuStatusTableAdapter
            // 
            this.job_NhapLieuStatusTableAdapter.ClearBeforeFill = true;
            // 
            // job_SPGocNhapLieuBindingSource
            // 
            this.job_SPGocNhapLieuBindingSource.DataMember = "Job_SPGocNhapLieu";
            this.job_SPGocNhapLieuBindingSource.DataSource = this.dBPhanSP;
            // 
            // job_SPGocNhapLieuTableAdapter
            // 
            this.job_SPGocNhapLieuTableAdapter.ClearBeforeFill = true;
            // 
            // job_SPGocNhapLieuLogBindingSource
            // 
            this.job_SPGocNhapLieuLogBindingSource.DataMember = "Job_SPGocNhapLieuLog";
            this.job_SPGocNhapLieuLogBindingSource.DataSource = this.dBPhanSP;
            // 
            // job_SPGocNhapLieuLogTableAdapter
            // 
            this.job_SPGocNhapLieuLogTableAdapter.ClearBeforeFill = true;
            // 
            // job_SPGocNhapLieuTempBindingSource
            // 
            this.job_SPGocNhapLieuTempBindingSource.DataMember = "Job_SPGocNhapLieuTemp";
            this.job_SPGocNhapLieuTempBindingSource.DataSource = this.dBPhanSP;
            // 
            // job_SPGocNhapLieuTempTableAdapter
            // 
            this.job_SPGocNhapLieuTempTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CompanyTableAdapter = null;
            this.tableAdapterManager1.ManagerTypeRUserTableAdapter = null;
            this.tableAdapterManager1.ManagerTypeTableAdapter = null;
            this.tableAdapterManager1.PermissionTableAdapter = null;
            this.tableAdapterManager1.tblUserTableAdapter = this.tblUserTableAdapter;
            this.tableAdapterManager1.UpdateOrder = QT.Users.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.User_CategoryTableAdapter = null;
            this.tableAdapterManager1.User_PermisionTableAdapter = null;
            this.tableAdapterManager1.UserJobTableAdapter = null;
            this.tableAdapterManager1.UserJobTypeTableAdapter = null;
            // 
            // productJobUserTableAdapter
            // 
            this.productJobUserTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhanCongNhapDuLieuSanPhamGoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1252, 635);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmPhanCongNhapDuLieuSanPhamGoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanCongNhapDuLieuSanPhamGoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPhanSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtViewCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productJobUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_NhapLieuStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_SPGocNhapLieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_SPGocNhapLieuLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.job_SPGocNhapLieuTempBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colValid1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btLoadCat;
        private DevExpress.XtraEditors.SimpleButton btExpanCat;
        private DBPhanSP dBPhanSP;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DBPhanSPTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private DB dB;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private DBTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btPhanTichLai;
        private System.Windows.Forms.TextBox iDClassificationTextBox;
        private DBPhanSPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.BindingSource job_NhapLieuStatusBindingSource;
        private DBPhanSPTableAdapters.Job_NhapLieuStatusTableAdapter job_NhapLieuStatusTableAdapter;
        private System.Windows.Forms.BindingSource job_SPGocNhapLieuBindingSource;
        private DBPhanSPTableAdapters.Job_SPGocNhapLieuTableAdapter job_SPGocNhapLieuTableAdapter;
        private System.Windows.Forms.BindingSource job_SPGocNhapLieuLogBindingSource;
        private DBPhanSPTableAdapters.Job_SPGocNhapLieuLogTableAdapter job_SPGocNhapLieuLogTableAdapter;
        private System.Windows.Forms.BindingSource job_SPGocNhapLieuTempBindingSource;
        private DBPhanSPTableAdapters.Job_SPGocNhapLieuTempTableAdapter job_SPGocNhapLieuTempTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBPhanSPTableAdapters.ProductTableAdapter productTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colCategorySTT;
        private DevExpress.XtraGrid.Columns.GridColumn colViewCount;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNameSearch;
        private DevExpress.XtraEditors.SimpleButton btSearch;
        private DevExpress.XtraEditors.SimpleButton btDay;
        private System.Windows.Forms.TextBox iDUserSelectTextBox;
        private DBTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource productJobUserBindingSource;
        private DBPhanSPTableAdapters.ProductJobUserTableAdapter productJobUserTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colName2;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colViewCount1;
        private DevExpress.XtraGrid.Columns.GridColumn colJobStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdateJob;
        private DevExpress.XtraEditors.SimpleButton btTaiJobUser;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.ComboBox cboListUser;
        private DevExpress.XtraEditors.SimpleButton btXoaCongViecUser;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox userNameSelectTextBox;
        private DevExpress.XtraEditors.TextEdit txtViewCount;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btReLoadAllProduct;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.SimpleButton ViewInfoAssignButton;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton Select1000Button;
        private DevExpress.XtraEditors.SimpleButton Select500Button;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
