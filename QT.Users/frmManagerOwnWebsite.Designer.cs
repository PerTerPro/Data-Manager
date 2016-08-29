namespace QT.Users
{
    partial class frmManagerOwnWebsite
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label iDWebLabel;
            System.Windows.Forms.Label createDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerOwnWebsite));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btViewDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.btViewAll = new DevExpress.XtraEditors.SimpleButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator();
            this.userPersonBindingSource = new System.Windows.Forms.BindingSource();
            this.dBCustomer = new QT.Users.DBCustomer();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdated_Time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVerified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.webUserBindingSource = new System.Windows.Forms.BindingSource();
            this.iDWebTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.iDUserTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDWeb1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.companyBindingSource = new System.Windows.Forms.BindingSource();
            this.dB = new QT.Users.DB();
            this.iDCompanyTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userPersonTableAdapter = new QT.Users.DBCustomerTableAdapters.UserPersonTableAdapter();
            this.webUserTableAdapter = new QT.Users.DBCustomerTableAdapters.WebUserTableAdapter();
            this.companyTableAdapter = new QT.Users.DBTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager = new QT.Users.DBCustomerTableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new QT.Users.DBTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            iDWebLabel = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(7, 28);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(34, 48);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(31, 71);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(6, 94);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 9;
            userNameLabel.Text = "User Name:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(14, 31);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 4;
            iDLabel1.Text = "ID:";
            // 
            // iDWebLabel
            // 
            iDWebLabel.AutoSize = true;
            iDWebLabel.Location = new System.Drawing.Point(28, 123);
            iDWebLabel.Name = "iDWebLabel";
            iDWebLabel.Size = new System.Drawing.Size(44, 13);
            iDWebLabel.TabIndex = 11;
            iDWebLabel.Text = "IDWeb:";
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Location = new System.Drawing.Point(5, 150);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(67, 13);
            createDateLabel.TabIndex = 13;
            createDateLabel.Text = "Create Date:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btViewDangKy);
            this.splitContainerControl1.Panel1.Controls.Add(this.btViewAll);
            this.splitContainerControl1.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1360, 586);
            this.splitContainerControl1.SplitterPosition = 534;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btViewDangKy
            // 
            this.btViewDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btViewDangKy.Location = new System.Drawing.Point(12, 535);
            this.btViewDangKy.Name = "btViewDangKy";
            this.btViewDangKy.Size = new System.Drawing.Size(75, 23);
            this.btViewDangKy.TabIndex = 0;
            this.btViewDangKy.Text = "Xem Đăng ký";
            this.btViewDangKy.Click += new System.EventHandler(this.btViewDangKy_Click);
            // 
            // btViewAll
            // 
            this.btViewAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btViewAll.Location = new System.Drawing.Point(93, 535);
            this.btViewAll.Name = "btViewAll";
            this.btViewAll.Size = new System.Drawing.Size(75, 23);
            this.btViewAll.TabIndex = 0;
            this.btViewAll.Text = "Xem Toàn bộ";
            this.btViewAll.Click += new System.EventHandler(this.btViewAll_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.userPersonBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 561);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(534, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // userPersonBindingSource
            // 
            this.userPersonBindingSource.DataMember = "UserPerson";
            this.userPersonBindingSource.DataSource = this.dBCustomer;
            // 
            // dBCustomer
            // 
            this.dBCustomer.DataSetName = "DBCustomer";
            this.dBCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.userPersonBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 16);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(534, 517);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmail,
            this.colName,
            this.colUpdated_Time,
            this.colUserName,
            this.colVerified});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 1;
            this.colEmail.Width = 94;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colUpdated_Time
            // 
            this.colUpdated_Time.FieldName = "Updated_Time";
            this.colUpdated_Time.Name = "colUpdated_Time";
            this.colUpdated_Time.OptionsColumn.AllowEdit = false;
            this.colUpdated_Time.OptionsColumn.FixedWidth = true;
            this.colUpdated_Time.OptionsColumn.ReadOnly = true;
            this.colUpdated_Time.Visible = true;
            this.colUpdated_Time.VisibleIndex = 3;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.OptionsColumn.ReadOnly = true;
            this.colUserName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 2;
            this.colUserName.Width = 95;
            // 
            // colVerified
            // 
            this.colVerified.FieldName = "Verified";
            this.colVerified.Name = "colVerified";
            this.colVerified.OptionsColumn.AllowEdit = false;
            this.colVerified.OptionsColumn.FixedWidth = true;
            this.colVerified.OptionsColumn.ReadOnly = true;
            this.colVerified.Visible = true;
            this.colVerified.VisibleIndex = 4;
            this.colVerified.Width = 50;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(createDateLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.createDateDateTimePicker);
            this.splitContainerControl2.Panel1.Controls.Add(iDWebLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.iDWebTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(userNameLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.userNameLabel1);
            this.splitContainerControl2.Panel1.Controls.Add(nameLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.nameLabel1);
            this.splitContainerControl2.Panel1.Controls.Add(emailLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.emailLabel1);
            this.splitContainerControl2.Panel1.Controls.Add(iDLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.iDUserTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(this.bindingNavigator2);
            this.splitContainerControl2.Panel1.Controls.Add(this.label2);
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl2);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(iDLabel1);
            this.splitContainerControl2.Panel2.Controls.Add(this.iDCompanyTextBox);
            this.splitContainerControl2.Panel2.Controls.Add(this.bindingNavigator3);
            this.splitContainerControl2.Panel2.Controls.Add(this.label3);
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(821, 586);
            this.splitContainerControl2.SplitterPosition = 459;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.webUserBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Location = new System.Drawing.Point(78, 146);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.createDateDateTimePicker.TabIndex = 14;
            // 
            // webUserBindingSource
            // 
            this.webUserBindingSource.DataMember = "WebUser";
            this.webUserBindingSource.DataSource = this.dBCustomer;
            // 
            // iDWebTextBox
            // 
            this.iDWebTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.webUserBindingSource, "IDWeb", true));
            this.iDWebTextBox.Location = new System.Drawing.Point(78, 120);
            this.iDWebTextBox.Name = "iDWebTextBox";
            this.iDWebTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDWebTextBox.TabIndex = 12;
            // 
            // userNameLabel1
            // 
            this.userNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPersonBindingSource, "UserName", true));
            this.userNameLabel1.Location = new System.Drawing.Point(75, 94);
            this.userNameLabel1.Name = "userNameLabel1";
            this.userNameLabel1.Size = new System.Drawing.Size(226, 23);
            this.userNameLabel1.TabIndex = 10;
            this.userNameLabel1.Text = "label4";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPersonBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(75, 71);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(226, 23);
            this.nameLabel1.TabIndex = 8;
            this.nameLabel1.Text = "label4";
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPersonBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(75, 48);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(226, 23);
            this.emailLabel1.TabIndex = 6;
            this.emailLabel1.Text = "label4";
            // 
            // iDUserTextBox
            // 
            this.iDUserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPersonBindingSource, "ID", true));
            this.iDUserTextBox.Location = new System.Drawing.Point(34, 25);
            this.iDUserTextBox.Name = "iDUserTextBox";
            this.iDUserTextBox.ReadOnly = true;
            this.iDUserTextBox.Size = new System.Drawing.Size(253, 20);
            this.iDUserTextBox.TabIndex = 4;
            this.iDUserTextBox.TextChanged += new System.EventHandler(this.iDUserTextBox_TextChanged);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.webUserBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButtonDelete});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 561);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(459, 25);
            this.bindingNavigator2.TabIndex = 3;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
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
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(31, 22);
            this.toolStripButtonDelete.Text = "Xóa";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách web sở hữu";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.webUserBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(0, 172);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl2.Size = new System.Drawing.Size(459, 386);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDWeb,
            this.colCreateDate,
            this.colIDWeb1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            // 
            // colIDWeb
            // 
            this.colIDWeb.FieldName = "IDWeb";
            this.colIDWeb.Name = "colIDWeb";
            this.colIDWeb.OptionsColumn.AllowEdit = false;
            this.colIDWeb.OptionsColumn.FixedWidth = true;
            this.colIDWeb.OptionsColumn.ReadOnly = true;
            this.colIDWeb.Visible = true;
            this.colIDWeb.VisibleIndex = 0;
            this.colIDWeb.Width = 175;
            // 
            // colCreateDate
            // 
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.OptionsColumn.AllowEdit = false;
            this.colCreateDate.OptionsColumn.ReadOnly = true;
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 2;
            this.colCreateDate.Width = 113;
            // 
            // colIDWeb1
            // 
            this.colIDWeb1.Caption = "domain";
            this.colIDWeb1.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIDWeb1.FieldName = "IDWeb";
            this.colIDWeb1.Name = "colIDWeb1";
            this.colIDWeb1.OptionsColumn.AllowEdit = false;
            this.colIDWeb1.OptionsColumn.FixedWidth = true;
            this.colIDWeb1.OptionsColumn.ReadOnly = true;
            this.colIDWeb1.Visible = true;
            this.colIDWeb1.VisibleIndex = 1;
            this.colIDWeb1.Width = 170;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.companyBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Domain";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDCompanyTextBox
            // 
            this.iDCompanyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "ID", true));
            this.iDCompanyTextBox.Location = new System.Drawing.Point(41, 28);
            this.iDCompanyTextBox.Name = "iDCompanyTextBox";
            this.iDCompanyTextBox.ReadOnly = true;
            this.iDCompanyTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDCompanyTextBox.TabIndex = 5;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = null;
            this.bindingNavigator3.BindingSource = this.companyBindingSource;
            this.bindingNavigator3.CountItem = this.toolStripLabel2;
            this.bindingNavigator3.DeleteItem = null;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator6});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 561);
            this.bindingNavigator3.MoveFirstItem = this.toolStripButton5;
            this.bindingNavigator3.MoveLastItem = this.toolStripButton8;
            this.bindingNavigator3.MoveNextItem = this.toolStripButton7;
            this.bindingNavigator3.MovePreviousItem = this.toolStripButton6;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator3.Size = new System.Drawing.Size(357, 25);
            this.bindingNavigator3.TabIndex = 4;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move first";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move next";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách web";
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.DataSource = this.companyBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(-2, 120);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(353, 438);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gridControl3.DoubleClick += new System.EventHandler(this.gridControl3_DoubleClick);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDomain});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
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
            this.colID.Width = 121;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.OptionsColumn.AllowEdit = false;
            this.colDomain.OptionsColumn.ReadOnly = true;
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 1;
            this.colDomain.Width = 218;
            // 
            // userPersonTableAdapter
            // 
            this.userPersonTableAdapter.ClearBeforeFill = true;
            // 
            // webUserTableAdapter
            // 
            this.webUserTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = QT.Users.DBCustomerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserPersonTableAdapter = this.userPersonTableAdapter;
            this.tableAdapterManager.UserPersonTypeTableAdapter = null;
            this.tableAdapterManager.WebUserTableAdapter = this.webUserTableAdapter;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager1.ManagerTypeRUserTableAdapter = null;
            this.tableAdapterManager1.ManagerTypeTableAdapter = null;
            this.tableAdapterManager1.PermissionTableAdapter = null;
            this.tableAdapterManager1.tblUserTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QT.Users.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.User_CategoryTableAdapter = null;
            this.tableAdapterManager1.User_PermisionTableAdapter = null;
            this.tableAdapterManager1.UserJobTableAdapter = null;
            this.tableAdapterManager1.UserJobTypeTableAdapter = null;
            // 
            // frmManagerOwnWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1360, 586);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManagerOwnWebsite";
            this.Load += new System.EventHandler(this.frmManagerOwnWebsite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btViewAll;
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
        private DBCustomer dBCustomer;
        private System.Windows.Forms.BindingSource userPersonBindingSource;
        private DBCustomerTableAdapters.UserPersonTableAdapter userPersonTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdated_Time;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colVerified;
        private DevExpress.XtraEditors.SimpleButton btViewDangKy;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource webUserBindingSource;
        private DBCustomerTableAdapters.WebUserTableAdapter webUserTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DB dB;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label userNameLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.TextBox iDUserTextBox;
        private DBCustomerTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colIDWeb1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.TextBox iDCompanyTextBox;
        private DBTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker;
        private System.Windows.Forms.TextBox iDWebTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
    }
}
