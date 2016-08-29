namespace QT.Users
{
    partial class frmUserManager
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
            System.Windows.Forms.Label iDUserLabel;
            System.Windows.Forms.Label iDTypeLabel;
            System.Windows.Forms.Label nameTypeLabel;
            System.Windows.Forms.Label sTTLabel;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label sTTLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label iDLabel2;
            System.Windows.Forms.Label iDLabel3;
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource();
            this.dB = new QT.Users.DB();
            this.iDUserTextBox = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.btReset = new DevExpress.XtraEditors.SimpleButton();
            this.btReload = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.managerTypeRUserBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNameType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btSavePermitsion = new DevExpress.XtraEditors.SimpleButton();
            this.btDeletePermision = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.managerTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sTTAddTextBox = new System.Windows.Forms.TextBox();
            this.nameTypeAddTextBox = new System.Windows.Forms.TextBox();
            this.iDTypeAddTextBox = new System.Windows.Forms.TextBox();
            this.sTTRTextBox = new System.Windows.Forms.TextBox();
            this.nameTypeRTextBox = new System.Windows.Forms.TextBox();
            this.iDTypeRTextBox = new System.Windows.Forms.TextBox();
            this.iDUserRTextBox = new System.Windows.Forms.TextBox();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btAddPermision = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.ctrUserCategory1 = new QT.Users.ctrUserCategory();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.userPermisionBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iDUser_PermistionTextBox = new System.Windows.Forms.TextBox();
            this.btXoaQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.btTaiLaiPhanQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.permissionBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iDPermitsionTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btGanQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.tblUserTableAdapter = new QT.Users.DBTableAdapters.tblUserTableAdapter();
            this.tableAdapterManager = new QT.Users.DBTableAdapters.TableAdapterManager();
            this.managerTypeRUserTableAdapter = new QT.Users.DBTableAdapters.ManagerTypeRUserTableAdapter();
            this.managerTypeTableAdapter = new QT.Users.DBTableAdapters.ManagerTypeTableAdapter();
            this.user_PermisionTableAdapter = new QT.Users.DBTableAdapters.User_PermisionTableAdapter();
            this.permissionTableAdapter = new QT.Users.DBTableAdapters.PermissionTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            iDUserLabel = new System.Windows.Forms.Label();
            iDTypeLabel = new System.Windows.Forms.Label();
            nameTypeLabel = new System.Windows.Forms.Label();
            sTTLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            sTTLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            iDLabel2 = new System.Windows.Forms.Label();
            iDLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeRUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPermisionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(164, 36);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDUserLabel
            // 
            iDUserLabel.AutoSize = true;
            iDUserLabel.Location = new System.Drawing.Point(21, 88);
            iDUserLabel.Name = "iDUserLabel";
            iDUserLabel.Size = new System.Drawing.Size(43, 13);
            iDUserLabel.TabIndex = 4;
            iDUserLabel.Text = "IDUser:";
            // 
            // iDTypeLabel
            // 
            iDTypeLabel.AutoSize = true;
            iDTypeLabel.Location = new System.Drawing.Point(19, 65);
            iDTypeLabel.Name = "iDTypeLabel";
            iDTypeLabel.Size = new System.Drawing.Size(45, 13);
            iDTypeLabel.TabIndex = 6;
            iDTypeLabel.Text = "IDType:";
            // 
            // nameTypeLabel
            // 
            nameTypeLabel.AutoSize = true;
            nameTypeLabel.Location = new System.Drawing.Point(-1, 114);
            nameTypeLabel.Name = "nameTypeLabel";
            nameTypeLabel.Size = new System.Drawing.Size(65, 13);
            nameTypeLabel.TabIndex = 8;
            nameTypeLabel.Text = "Name Type:";
            // 
            // sTTLabel
            // 
            sTTLabel.AutoSize = true;
            sTTLabel.Location = new System.Drawing.Point(33, 140);
            sTTLabel.Name = "sTTLabel";
            sTTLabel.Size = new System.Drawing.Size(31, 13);
            sTTLabel.TabIndex = 10;
            sTTLabel.Text = "STT:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(151, 68);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 12;
            iDLabel1.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(134, 94);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Name:";
            // 
            // sTTLabel1
            // 
            sTTLabel1.AutoSize = true;
            sTTLabel1.Location = new System.Drawing.Point(141, 120);
            sTTLabel1.Name = "sTTLabel1";
            sTTLabel1.Size = new System.Drawing.Size(31, 13);
            sTTLabel1.TabIndex = 16;
            sTTLabel1.Text = "STT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(141, 120);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 13);
            label1.TabIndex = 16;
            label1.Text = "STT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(134, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 14;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(151, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(21, 13);
            label3.TabIndex = 12;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(33, 140);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(31, 13);
            label4.TabIndex = 10;
            label4.Text = "STT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(-1, 114);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 13);
            label5.TabIndex = 8;
            label5.Text = "Name Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(19, 65);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(45, 13);
            label6.TabIndex = 6;
            label6.Text = "IDType:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(21, 88);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(43, 13);
            label7.TabIndex = 4;
            label7.Text = "IDUser:";
            // 
            // iDLabel2
            // 
            iDLabel2.AutoSize = true;
            iDLabel2.Location = new System.Drawing.Point(110, 10);
            iDLabel2.Name = "iDLabel2";
            iDLabel2.Size = new System.Drawing.Size(21, 13);
            iDLabel2.TabIndex = 17;
            iDLabel2.Text = "ID:";
            // 
            // iDLabel3
            // 
            iDLabel3.AutoSize = true;
            iDLabel3.Location = new System.Drawing.Point(24, 64);
            iDLabel3.Name = "iDLabel3";
            iDLabel3.Size = new System.Drawing.Size(21, 13);
            iDLabel3.TabIndex = 3;
            iDLabel3.Text = "ID:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(iDLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.passwordTextBox);
            this.splitContainerControl1.Panel1.Controls.Add(this.iDUserTextBox);
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.btSave);
            this.splitContainerControl1.Panel1.Controls.Add(this.btReset);
            this.splitContainerControl1.Panel1.Controls.Add(this.btReload);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(933, 433);
            this.splitContainerControl1.SplitterPosition = 405;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(3, 33);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(156, 20);
            this.passwordTextBox.TabIndex = 4;
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
            // iDUserTextBox
            // 
            this.iDUserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "ID", true));
            this.iDUserTextBox.Location = new System.Drawing.Point(191, 33);
            this.iDUserTextBox.Name = "iDUserTextBox";
            this.iDUserTextBox.ReadOnly = true;
            this.iDUserTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDUserTextBox.TabIndex = 2;
            this.iDUserTextBox.TextChanged += new System.EventHandler(this.iDUserTextBox_TextChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.tblUserBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 59);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(405, 374);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colEmail,
            this.colMobile,
            this.colActive});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 1;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 3;
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.FixedWidth = true;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 2;
            this.colActive.Width = 57;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(165, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(3, 4);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "ResetPass";
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btReload
            // 
            this.btReload.Location = new System.Drawing.Point(84, 4);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(75, 23);
            this.btReload.TabIndex = 0;
            this.btReload.Text = "Reload";
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(520, 433);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.splitContainerControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(512, 404);
            this.xtraTabPage1.Text = "Crawler";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl2);
            this.splitContainerControl2.Panel1.Controls.Add(this.btSavePermitsion);
            this.splitContainerControl2.Panel1.Controls.Add(this.btDeletePermision);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl3);
            this.splitContainerControl2.Panel2.Controls.Add(sTTLabel1);
            this.splitContainerControl2.Panel2.Controls.Add(this.sTTAddTextBox);
            this.splitContainerControl2.Panel2.Controls.Add(nameLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.nameTypeAddTextBox);
            this.splitContainerControl2.Panel2.Controls.Add(iDLabel1);
            this.splitContainerControl2.Panel2.Controls.Add(this.iDTypeAddTextBox);
            this.splitContainerControl2.Panel2.Controls.Add(sTTLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.sTTRTextBox);
            this.splitContainerControl2.Panel2.Controls.Add(nameTypeLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.nameTypeRTextBox);
            this.splitContainerControl2.Panel2.Controls.Add(iDTypeLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.iDTypeRTextBox);
            this.splitContainerControl2.Panel2.Controls.Add(iDUserLabel);
            this.splitContainerControl2.Panel2.Controls.Add(this.iDUserRTextBox);
            this.splitContainerControl2.Panel2.Controls.Add(this.btRefresh);
            this.splitContainerControl2.Panel2.Controls.Add(this.btAddPermision);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(512, 404);
            this.splitContainerControl2.SplitterPosition = 222;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.managerTypeRUserBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(0, 33);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(222, 371);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // managerTypeRUserBindingSource
            // 
            this.managerTypeRUserBindingSource.DataMember = "ManagerTypeRUser";
            this.managerTypeRUserBindingSource.DataSource = this.dB;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNameType,
            this.colSTT1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colNameType
            // 
            this.colNameType.FieldName = "NameType";
            this.colNameType.Name = "colNameType";
            this.colNameType.Visible = true;
            this.colNameType.VisibleIndex = 1;
            this.colNameType.Width = 156;
            // 
            // colSTT1
            // 
            this.colSTT1.FieldName = "STT";
            this.colSTT1.Name = "colSTT1";
            this.colSTT1.Visible = true;
            this.colSTT1.VisibleIndex = 0;
            this.colSTT1.Width = 45;
            // 
            // btSavePermitsion
            // 
            this.btSavePermitsion.Location = new System.Drawing.Point(3, 4);
            this.btSavePermitsion.Name = "btSavePermitsion";
            this.btSavePermitsion.Size = new System.Drawing.Size(75, 23);
            this.btSavePermitsion.TabIndex = 3;
            this.btSavePermitsion.Text = "Save";
            this.btSavePermitsion.Click += new System.EventHandler(this.btSavePermitsion_Click);
            // 
            // btDeletePermision
            // 
            this.btDeletePermision.Location = new System.Drawing.Point(84, 4);
            this.btDeletePermision.Name = "btDeletePermision";
            this.btDeletePermision.Size = new System.Drawing.Size(75, 23);
            this.btDeletePermision.TabIndex = 3;
            this.btDeletePermision.Text = ">>";
            this.btDeletePermision.Click += new System.EventHandler(this.btDeletePermision_Click);
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.DataSource = this.managerTypeBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(3, 33);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(274, 368);
            this.gridControl3.TabIndex = 2;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // managerTypeBindingSource
            // 
            this.managerTypeBindingSource.DataMember = "ManagerType";
            this.managerTypeBindingSource.DataSource = this.dB;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDes,
            this.colSTT});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 110;
            // 
            // colDes
            // 
            this.colDes.FieldName = "Des";
            this.colDes.Name = "colDes";
            this.colDes.Visible = true;
            this.colDes.VisibleIndex = 2;
            this.colDes.Width = 107;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 46;
            // 
            // sTTAddTextBox
            // 
            this.sTTAddTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeBindingSource, "STT", true));
            this.sTTAddTextBox.Location = new System.Drawing.Point(178, 117);
            this.sTTAddTextBox.Name = "sTTAddTextBox";
            this.sTTAddTextBox.ReadOnly = true;
            this.sTTAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.sTTAddTextBox.TabIndex = 17;
            // 
            // nameTypeAddTextBox
            // 
            this.nameTypeAddTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeBindingSource, "Name", true));
            this.nameTypeAddTextBox.Location = new System.Drawing.Point(178, 91);
            this.nameTypeAddTextBox.Name = "nameTypeAddTextBox";
            this.nameTypeAddTextBox.ReadOnly = true;
            this.nameTypeAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTypeAddTextBox.TabIndex = 15;
            // 
            // iDTypeAddTextBox
            // 
            this.iDTypeAddTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeBindingSource, "ID", true));
            this.iDTypeAddTextBox.Location = new System.Drawing.Point(178, 65);
            this.iDTypeAddTextBox.Name = "iDTypeAddTextBox";
            this.iDTypeAddTextBox.ReadOnly = true;
            this.iDTypeAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTypeAddTextBox.TabIndex = 13;
            // 
            // sTTRTextBox
            // 
            this.sTTRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeRUserBindingSource, "STT", true));
            this.sTTRTextBox.Location = new System.Drawing.Point(70, 137);
            this.sTTRTextBox.Name = "sTTRTextBox";
            this.sTTRTextBox.ReadOnly = true;
            this.sTTRTextBox.Size = new System.Drawing.Size(57, 20);
            this.sTTRTextBox.TabIndex = 11;
            // 
            // nameTypeRTextBox
            // 
            this.nameTypeRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeRUserBindingSource, "NameType", true));
            this.nameTypeRTextBox.Location = new System.Drawing.Point(70, 111);
            this.nameTypeRTextBox.Name = "nameTypeRTextBox";
            this.nameTypeRTextBox.ReadOnly = true;
            this.nameTypeRTextBox.Size = new System.Drawing.Size(57, 20);
            this.nameTypeRTextBox.TabIndex = 9;
            // 
            // iDTypeRTextBox
            // 
            this.iDTypeRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeRUserBindingSource, "IDType", true));
            this.iDTypeRTextBox.Location = new System.Drawing.Point(70, 62);
            this.iDTypeRTextBox.Name = "iDTypeRTextBox";
            this.iDTypeRTextBox.ReadOnly = true;
            this.iDTypeRTextBox.Size = new System.Drawing.Size(57, 20);
            this.iDTypeRTextBox.TabIndex = 7;
            // 
            // iDUserRTextBox
            // 
            this.iDUserRTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeRUserBindingSource, "IDUser", true));
            this.iDUserRTextBox.Location = new System.Drawing.Point(70, 85);
            this.iDUserRTextBox.Name = "iDUserRTextBox";
            this.iDUserRTextBox.ReadOnly = true;
            this.iDUserRTextBox.Size = new System.Drawing.Size(57, 20);
            this.iDUserRTextBox.TabIndex = 5;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(83, 3);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.Text = "Tải lại";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btAddPermision
            // 
            this.btAddPermision.Location = new System.Drawing.Point(2, 4);
            this.btAddPermision.Name = "btAddPermision";
            this.btAddPermision.Size = new System.Drawing.Size(75, 23);
            this.btAddPermision.TabIndex = 3;
            this.btAddPermision.Text = "<<";
            this.btAddPermision.Click += new System.EventHandler(this.btAddPermision_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.ctrUserCategory1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(512, 404);
            this.xtraTabPage2.Text = "Category";
            // 
            // ctrUserCategory1
            // 
            this.ctrUserCategory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrUserCategory1.Location = new System.Drawing.Point(0, 0);
            this.ctrUserCategory1.Name = "ctrUserCategory1";
            this.ctrUserCategory1.Size = new System.Drawing.Size(512, 404);
            this.ctrUserCategory1.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.splitContainerControl3);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(512, 404);
            this.xtraTabPage3.Text = "Phân quyền";
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.gridControl4);
            this.splitContainerControl3.Panel1.Controls.Add(iDLabel3);
            this.splitContainerControl3.Panel1.Controls.Add(this.iDUser_PermistionTextBox);
            this.splitContainerControl3.Panel1.Controls.Add(this.btXoaQuyen);
            this.splitContainerControl3.Panel1.Controls.Add(this.btTaiLaiPhanQuyen);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.gridControl5);
            this.splitContainerControl3.Panel2.Controls.Add(iDLabel2);
            this.splitContainerControl3.Panel2.Controls.Add(this.iDPermitsionTextBox);
            this.splitContainerControl3.Panel2.Controls.Add(label1);
            this.splitContainerControl3.Panel2.Controls.Add(this.textBox1);
            this.splitContainerControl3.Panel2.Controls.Add(label2);
            this.splitContainerControl3.Panel2.Controls.Add(this.textBox2);
            this.splitContainerControl3.Panel2.Controls.Add(label3);
            this.splitContainerControl3.Panel2.Controls.Add(this.textBox3);
            this.splitContainerControl3.Panel2.Controls.Add(label4);
            this.splitContainerControl3.Panel2.Controls.Add(this.textBox4);
            this.splitContainerControl3.Panel2.Controls.Add(label5);
            this.splitContainerControl3.Panel2.Controls.Add(this.textBox5);
            this.splitContainerControl3.Panel2.Controls.Add(label6);
            this.splitContainerControl3.Panel2.Controls.Add(this.textBox6);
            this.splitContainerControl3.Panel2.Controls.Add(label7);
            this.splitContainerControl3.Panel2.Controls.Add(this.textBox7);
            this.splitContainerControl3.Panel2.Controls.Add(this.btGanQuyen);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(512, 404);
            this.splitContainerControl3.SplitterPosition = 222;
            this.splitContainerControl3.TabIndex = 1;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // gridControl4
            // 
            this.gridControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl4.DataSource = this.userPermisionBindingSource;
            this.gridControl4.Location = new System.Drawing.Point(0, 36);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(222, 368);
            this.gridControl4.TabIndex = 1;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // userPermisionBindingSource
            // 
            this.userPermisionBindingSource.DataMember = "User_Permision";
            this.userPermisionBindingSource.DataSource = this.dB;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            // 
            // iDUser_PermistionTextBox
            // 
            this.iDUser_PermistionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userPermisionBindingSource, "ID", true));
            this.iDUser_PermistionTextBox.Location = new System.Drawing.Point(51, 61);
            this.iDUser_PermistionTextBox.Name = "iDUser_PermistionTextBox";
            this.iDUser_PermistionTextBox.ReadOnly = true;
            this.iDUser_PermistionTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDUser_PermistionTextBox.TabIndex = 4;
            // 
            // btXoaQuyen
            // 
            this.btXoaQuyen.Location = new System.Drawing.Point(138, 4);
            this.btXoaQuyen.Name = "btXoaQuyen";
            this.btXoaQuyen.Size = new System.Drawing.Size(75, 23);
            this.btXoaQuyen.TabIndex = 3;
            this.btXoaQuyen.Text = ">>";
            this.btXoaQuyen.Click += new System.EventHandler(this.btXoaQuyen_Click);
            // 
            // btTaiLaiPhanQuyen
            // 
            this.btTaiLaiPhanQuyen.Location = new System.Drawing.Point(3, 4);
            this.btTaiLaiPhanQuyen.Name = "btTaiLaiPhanQuyen";
            this.btTaiLaiPhanQuyen.Size = new System.Drawing.Size(75, 23);
            this.btTaiLaiPhanQuyen.TabIndex = 3;
            this.btTaiLaiPhanQuyen.Text = "Tải lại";
            this.btTaiLaiPhanQuyen.Click += new System.EventHandler(this.btTaiLaiPhanQuyen_Click);
            // 
            // gridControl5
            // 
            this.gridControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl5.DataSource = this.permissionBindingSource;
            this.gridControl5.Location = new System.Drawing.Point(3, 33);
            this.gridControl5.MainView = this.gridView5;
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.Size = new System.Drawing.Size(274, 368);
            this.gridControl5.TabIndex = 2;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // permissionBindingSource
            // 
            this.permissionBindingSource.DataMember = "Permission";
            this.permissionBindingSource.DataSource = this.dB;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName2});
            this.gridView5.GridControl = this.gridControl5;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colName2
            // 
            this.colName2.FieldName = "Name";
            this.colName2.Name = "colName2";
            this.colName2.Visible = true;
            this.colName2.VisibleIndex = 0;
            // 
            // iDPermitsionTextBox
            // 
            this.iDPermitsionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissionBindingSource, "ID", true));
            this.iDPermitsionTextBox.Location = new System.Drawing.Point(137, 7);
            this.iDPermitsionTextBox.Name = "iDPermitsionTextBox";
            this.iDPermitsionTextBox.ReadOnly = true;
            this.iDPermitsionTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDPermitsionTextBox.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeBindingSource, "STT", true));
            this.textBox1.Location = new System.Drawing.Point(178, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeBindingSource, "Name", true));
            this.textBox2.Location = new System.Drawing.Point(178, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeBindingSource, "ID", true));
            this.textBox3.Location = new System.Drawing.Point(178, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeRUserBindingSource, "STT", true));
            this.textBox4.Location = new System.Drawing.Point(70, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(57, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeRUserBindingSource, "NameType", true));
            this.textBox5.Location = new System.Drawing.Point(70, 111);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(57, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeRUserBindingSource, "IDType", true));
            this.textBox6.Location = new System.Drawing.Point(70, 62);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(57, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeRUserBindingSource, "IDUser", true));
            this.textBox7.Location = new System.Drawing.Point(70, 85);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(57, 20);
            this.textBox7.TabIndex = 5;
            // 
            // btGanQuyen
            // 
            this.btGanQuyen.Location = new System.Drawing.Point(2, 4);
            this.btGanQuyen.Name = "btGanQuyen";
            this.btGanQuyen.Size = new System.Drawing.Size(75, 23);
            this.btGanQuyen.TabIndex = 3;
            this.btGanQuyen.Text = "<<";
            this.btGanQuyen.Click += new System.EventHandler(this.btGanQuyen_Click);
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManagerTypeRUserTableAdapter = null;
            this.tableAdapterManager.ManagerTypeTableAdapter = null;
            this.tableAdapterManager.PermissionTableAdapter = null;
            this.tableAdapterManager.tblUserTableAdapter = this.tblUserTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Users.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_CategoryTableAdapter = null;
            this.tableAdapterManager.User_PermisionTableAdapter = null;
            this.tableAdapterManager.UserJobTableAdapter = null;
            this.tableAdapterManager.UserJobTypeTableAdapter = null;
            // 
            // managerTypeRUserTableAdapter
            // 
            this.managerTypeRUserTableAdapter.ClearBeforeFill = true;
            // 
            // managerTypeTableAdapter
            // 
            this.managerTypeTableAdapter.ClearBeforeFill = true;
            // 
            // user_PermisionTableAdapter
            // 
            this.user_PermisionTableAdapter.ClearBeforeFill = true;
            // 
            // permissionTableAdapter
            // 
            this.permissionTableAdapter.ClearBeforeFill = true;
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(933, 433);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmUserManager";
            this.Load += new System.EventHandler(this.frmUserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeRUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPermisionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DB dB;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private DBTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.SimpleButton btReset;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.SimpleButton btReload;
        private System.Windows.Forms.TextBox passwordTextBox;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource managerTypeRUserBindingSource;
        private DBTableAdapters.ManagerTypeRUserTableAdapter managerTypeRUserTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colNameType;
        private System.Windows.Forms.TextBox iDUserTextBox;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource managerTypeBindingSource;
        private DBTableAdapters.ManagerTypeTableAdapter managerTypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDes;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT1;
        private DevExpress.XtraEditors.SimpleButton btSavePermitsion;
        private DevExpress.XtraEditors.SimpleButton btDeletePermision;
        private DevExpress.XtraEditors.SimpleButton btAddPermision;
        private System.Windows.Forms.TextBox sTTRTextBox;
        private System.Windows.Forms.TextBox nameTypeRTextBox;
        private System.Windows.Forms.TextBox iDTypeRTextBox;
        private System.Windows.Forms.TextBox iDUserRTextBox;
        private System.Windows.Forms.TextBox sTTAddTextBox;
        private System.Windows.Forms.TextBox nameTypeAddTextBox;
        private System.Windows.Forms.TextBox iDTypeAddTextBox;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ctrUserCategory ctrUserCategory1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SimpleButton btXoaQuyen;
        private DevExpress.XtraGrid.GridControl gridControl5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private DevExpress.XtraEditors.SimpleButton btTaiLaiPhanQuyen;
        private DevExpress.XtraEditors.SimpleButton btGanQuyen;
        private System.Windows.Forms.BindingSource userPermisionBindingSource;
        private DBTableAdapters.User_PermisionTableAdapter user_PermisionTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private System.Windows.Forms.BindingSource permissionBindingSource;
        private DBTableAdapters.PermissionTableAdapter permissionTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colName2;
        private System.Windows.Forms.TextBox iDPermitsionTextBox;
        private System.Windows.Forms.TextBox iDUser_PermistionTextBox;
    }
}
