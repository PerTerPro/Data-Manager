namespace QT.Moduls.Company
{
    partial class frmManagerCom
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
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label domainLabel;
            System.Windows.Forms.Label pageRankLabel;
            System.Windows.Forms.Label totalProductLabel;
            System.Windows.Forms.Label totalValidLabel;
            System.Windows.Forms.Label totalQueueLabel;
            System.Windows.Forms.Label totalVisitedLabel;
            System.Windows.Forms.Label iDLabel2;
            System.Windows.Forms.Label domainLabel1;
            System.Windows.Forms.Label totalValidLabel1;
            System.Windows.Forms.Label totalProductLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerCom));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.btLoad = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.managerTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.dBComBindingSource = new System.Windows.Forms.BindingSource();
            this.dBCom = new QT.Moduls.Company.DBCom();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinHourRecrawl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTheoDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.totalProductOfTypeTextBox = new System.Windows.Forms.TextBox();
            this.companyOfTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.totalValidOfTypeTextBox = new System.Windows.Forms.TextBox();
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.gridListCurrent = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolChuyenNhom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolXoaKhoiNhom = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDomain1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPageRank1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQueue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalVisited = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalViewMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btChamCongDayWeb = new DevExpress.XtraEditors.SimpleButton();
            this.btChamCongOK = new DevExpress.XtraEditors.SimpleButton();
            this.btChamCongErr = new DevExpress.XtraEditors.SimpleButton();
            this.btChamCongDuyet = new DevExpress.XtraEditors.SimpleButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator();
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.ctrLogMananger1 = new QT.Moduls.Company.ctrLogMananger();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.grvListAll = new DevExpress.XtraGrid.GridControl();
            this.companyViewBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPageRank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeDelay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManagerType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalQueue1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalVisited1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalViewMonth1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btAddCom = new DevExpress.XtraEditors.SimpleButton();
            this.btDeleteQueue = new DevExpress.XtraEditors.SimpleButton();
            this.btSaveTypeOf = new DevExpress.XtraEditors.SimpleButton();
            this.btRemove = new DevExpress.XtraEditors.SimpleButton();
            this.iDManagerTypeTextBox = new System.Windows.Forms.TextBox();
            this.btFillter = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.iDCompanyViewTextBox = new System.Windows.Forms.TextBox();
            this.totalVisitedTextBox = new System.Windows.Forms.TextBox();
            this.domainCompanyViewTextBox = new System.Windows.Forms.TextBox();
            this.totalQueueTextBox = new System.Windows.Forms.TextBox();
            this.pageRankTextBox = new System.Windows.Forms.TextBox();
            this.totalValidTextBox = new System.Windows.Forms.TextBox();
            this.totalProductTextBox = new System.Windows.Forms.TextBox();
            this.managerTypeTableAdapter = new QT.Moduls.Company.DBComTableAdapters.ManagerTypeTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Company.DBComTableAdapters.TableAdapterManager();
            this.companyViewTableAdapter = new QT.Moduls.Company.DBComTableAdapters.CompanyViewTableAdapter();
            this.companyOfTypeTableAdapter = new QT.Moduls.Company.DBComTableAdapters.CompanyOfTypeTableAdapter();
            this.managerTypeRCompanyBindingSource = new System.Windows.Forms.BindingSource();
            this.managerTypeRCompanyTableAdapter = new QT.Moduls.Company.DBComTableAdapters.ManagerTypeRCompanyTableAdapter();
            this.listComManBindingSource = new System.Windows.Forms.BindingSource();
            this.listComManTableAdapter = new QT.Moduls.Company.DBComTableAdapters.ListComManTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip();
            this.waitFindNewDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            iDLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            pageRankLabel = new System.Windows.Forms.Label();
            totalProductLabel = new System.Windows.Forms.Label();
            totalValidLabel = new System.Windows.Forms.Label();
            totalQueueLabel = new System.Windows.Forms.Label();
            totalVisitedLabel = new System.Windows.Forms.Label();
            iDLabel2 = new System.Windows.Forms.Label();
            domainLabel1 = new System.Windows.Forms.Label();
            totalValidLabel1 = new System.Windows.Forms.Label();
            totalProductLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBComBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyOfTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListCurrent)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeRCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listComManBindingSource)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(647, 17);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 6;
            iDLabel.Text = "ID:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(9, 28);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 8;
            iDLabel1.Text = "ID:";
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(-16, 51);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 11;
            domainLabel.Text = "Domain:";
            // 
            // pageRankLabel
            // 
            pageRankLabel.AutoSize = true;
            pageRankLabel.Location = new System.Drawing.Point(-34, 82);
            pageRankLabel.Name = "pageRankLabel";
            pageRankLabel.Size = new System.Drawing.Size(64, 13);
            pageRankLabel.TabIndex = 13;
            pageRankLabel.Text = "Page Rank:";
            // 
            // totalProductLabel
            // 
            totalProductLabel.AutoSize = true;
            totalProductLabel.Location = new System.Drawing.Point(-44, 108);
            totalProductLabel.Name = "totalProductLabel";
            totalProductLabel.Size = new System.Drawing.Size(74, 13);
            totalProductLabel.TabIndex = 14;
            totalProductLabel.Text = "Total Product:";
            // 
            // totalValidLabel
            // 
            totalValidLabel.AutoSize = true;
            totalValidLabel.Location = new System.Drawing.Point(-30, 134);
            totalValidLabel.Name = "totalValidLabel";
            totalValidLabel.Size = new System.Drawing.Size(60, 13);
            totalValidLabel.TabIndex = 15;
            totalValidLabel.Text = "Total Valid:";
            // 
            // totalQueueLabel
            // 
            totalQueueLabel.AutoSize = true;
            totalQueueLabel.Location = new System.Drawing.Point(-39, 160);
            totalQueueLabel.Name = "totalQueueLabel";
            totalQueueLabel.Size = new System.Drawing.Size(69, 13);
            totalQueueLabel.TabIndex = 16;
            totalQueueLabel.Text = "Total Queue:";
            // 
            // totalVisitedLabel
            // 
            totalVisitedLabel.AutoSize = true;
            totalVisitedLabel.Location = new System.Drawing.Point(104, 31);
            totalVisitedLabel.Name = "totalVisitedLabel";
            totalVisitedLabel.Size = new System.Drawing.Size(68, 13);
            totalVisitedLabel.TabIndex = 17;
            totalVisitedLabel.Text = "Total Visited:";
            // 
            // iDLabel2
            // 
            iDLabel2.AutoSize = true;
            iDLabel2.Location = new System.Drawing.Point(7, 31);
            iDLabel2.Name = "iDLabel2";
            iDLabel2.Size = new System.Drawing.Size(21, 13);
            iDLabel2.TabIndex = 2;
            iDLabel2.Text = "ID:";
            // 
            // domainLabel1
            // 
            domainLabel1.AutoSize = true;
            domainLabel1.Location = new System.Drawing.Point(69, 31);
            domainLabel1.Name = "domainLabel1";
            domainLabel1.Size = new System.Drawing.Size(46, 13);
            domainLabel1.TabIndex = 7;
            domainLabel1.Text = "Domain:";
            // 
            // totalValidLabel1
            // 
            totalValidLabel1.AutoSize = true;
            totalValidLabel1.Location = new System.Drawing.Point(160, 31);
            totalValidLabel1.Name = "totalValidLabel1";
            totalValidLabel1.Size = new System.Drawing.Size(60, 13);
            totalValidLabel1.TabIndex = 9;
            totalValidLabel1.Text = "Total Valid:";
            // 
            // totalProductLabel1
            // 
            totalProductLabel1.AutoSize = true;
            totalProductLabel1.Location = new System.Drawing.Point(265, 31);
            totalProductLabel1.Name = "totalProductLabel1";
            totalProductLabel1.Size = new System.Drawing.Size(74, 13);
            totalProductLabel1.TabIndex = 11;
            totalProductLabel1.Text = "Total Product:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btDelete);
            this.splitContainerControl1.Panel1.Controls.Add(this.btSave);
            this.splitContainerControl1.Panel1.Controls.Add(this.btLoad);
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.txtResult);
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.btAddCom);
            this.splitContainerControl1.Panel2.Controls.Add(iDLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.btDeleteQueue);
            this.splitContainerControl1.Panel2.Controls.Add(this.btSaveTypeOf);
            this.splitContainerControl1.Panel2.Controls.Add(this.btRemove);
            this.splitContainerControl1.Panel2.Controls.Add(this.iDManagerTypeTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(this.btFillter);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1354, 649);
            this.splitContainerControl1.SplitterPosition = 295;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(67, 6);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(52, 23);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Delete";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(125, 6);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(52, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(9, 6);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(52, 23);
            this.btLoad.TabIndex = 1;
            this.btLoad.Text = "Load";
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.managerTypeBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 32);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(289, 614);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // managerTypeBindingSource
            // 
            this.managerTypeBindingSource.DataMember = "ManagerType";
            this.managerTypeBindingSource.DataSource = this.dBComBindingSource;
            // 
            // dBComBindingSource
            // 
            this.dBComBindingSource.DataSource = this.dBCom;
            this.dBComBindingSource.Position = 0;
            // 
            // dBCom
            // 
            this.dBCom.DataSetName = "DBCom";
            this.dBCom.EnforceConstraints = false;
            this.dBCom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colSTT,
            this.colDes,
            this.colMinHourRecrawl,
            this.colTheoDoi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 2;
            // 
            // colDes
            // 
            this.colDes.FieldName = "Des";
            this.colDes.Name = "colDes";
            this.colDes.Visible = true;
            this.colDes.VisibleIndex = 3;
            // 
            // colMinHourRecrawl
            // 
            this.colMinHourRecrawl.FieldName = "MinHourRecrawl";
            this.colMinHourRecrawl.Name = "colMinHourRecrawl";
            this.colMinHourRecrawl.Visible = true;
            this.colMinHourRecrawl.VisibleIndex = 4;
            // 
            // colTheoDoi
            // 
            this.colTheoDoi.FieldName = "TheoDoi";
            this.colTheoDoi.Name = "colTheoDoi";
            this.colTheoDoi.Visible = true;
            this.colTheoDoi.VisibleIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(467, 9);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(437, 20);
            this.txtResult.TabIndex = 20;
            this.txtResult.WordWrap = false;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl2.Location = new System.Drawing.Point(-1, 36);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(totalProductLabel1);
            this.splitContainerControl2.Panel1.Controls.Add(this.totalProductOfTypeTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(totalValidLabel1);
            this.splitContainerControl2.Panel1.Controls.Add(this.totalValidOfTypeTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(domainLabel1);
            this.splitContainerControl2.Panel1.Controls.Add(this.domainTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(this.gridListCurrent);
            this.splitContainerControl2.Panel1.Controls.Add(this.btPrint);
            this.splitContainerControl2.Panel1.Controls.Add(this.btChamCongDayWeb);
            this.splitContainerControl2.Panel1.Controls.Add(this.btChamCongOK);
            this.splitContainerControl2.Panel1.Controls.Add(this.btChamCongErr);
            this.splitContainerControl2.Panel1.Controls.Add(this.btChamCongDuyet);
            this.splitContainerControl2.Panel1.Controls.Add(iDLabel2);
            this.splitContainerControl2.Panel1.Controls.Add(this.iDTextBox);
            this.splitContainerControl2.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1044, 613);
            this.splitContainerControl2.SplitterPosition = 574;
            this.splitContainerControl2.TabIndex = 13;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // totalProductOfTypeTextBox
            // 
            this.totalProductOfTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyOfTypeBindingSource, "TotalProduct", true));
            this.totalProductOfTypeTextBox.Location = new System.Drawing.Point(345, 28);
            this.totalProductOfTypeTextBox.Name = "totalProductOfTypeTextBox";
            this.totalProductOfTypeTextBox.Size = new System.Drawing.Size(47, 20);
            this.totalProductOfTypeTextBox.TabIndex = 12;
            // 
            // companyOfTypeBindingSource
            // 
            this.companyOfTypeBindingSource.DataMember = "CompanyOfType";
            this.companyOfTypeBindingSource.DataSource = this.dBCom;
            // 
            // totalValidOfTypeTextBox
            // 
            this.totalValidOfTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyOfTypeBindingSource, "TotalValid", true));
            this.totalValidOfTypeTextBox.Location = new System.Drawing.Point(226, 28);
            this.totalValidOfTypeTextBox.Name = "totalValidOfTypeTextBox";
            this.totalValidOfTypeTextBox.Size = new System.Drawing.Size(36, 20);
            this.totalValidOfTypeTextBox.TabIndex = 10;
            // 
            // domainTextBox
            // 
            this.domainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyOfTypeBindingSource, "Domain", true));
            this.domainTextBox.Location = new System.Drawing.Point(121, 28);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(35, 20);
            this.domainTextBox.TabIndex = 8;
            // 
            // gridListCurrent
            // 
            this.gridListCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListCurrent.ContextMenuStrip = this.contextMenuStrip1;
            this.gridListCurrent.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridListCurrent.DataSource = this.companyOfTypeBindingSource;
            this.gridListCurrent.Location = new System.Drawing.Point(3, 54);
            this.gridListCurrent.MainView = this.gridView2;
            this.gridListCurrent.Name = "gridListCurrent";
            this.gridListCurrent.Size = new System.Drawing.Size(568, 526);
            this.gridListCurrent.TabIndex = 0;
            this.gridListCurrent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridListCurrent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridListCurrent_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.toolChuyenNhom,
            this.toolXoaKhoiNhom});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 54);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(152, 6);
            // 
            // toolChuyenNhom
            // 
            this.toolChuyenNhom.Name = "toolChuyenNhom";
            this.toolChuyenNhom.Size = new System.Drawing.Size(155, 22);
            this.toolChuyenNhom.Text = "Chuyển nhóm";
            this.toolChuyenNhom.Click += new System.EventHandler(this.toolChuyenNhom_Click);
            // 
            // toolXoaKhoiNhom
            // 
            this.toolXoaKhoiNhom.Name = "toolXoaKhoiNhom";
            this.toolXoaKhoiNhom.Size = new System.Drawing.Size(155, 22);
            this.toolXoaKhoiNhom.Text = "Xóa khỏi nhóm";
            this.toolXoaKhoiNhom.Click += new System.EventHandler(this.toolXoaKhoiNhom_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDomain1,
            this.colMaxValid,
            this.colPageRank1,
            this.colTotalProduct1,
            this.colTotalValid1,
            this.colTotalQueue,
            this.colTotalVisited,
            this.colTotalViewMonth});
            this.gridView2.GridControl = this.gridListCurrent;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colDomain1
            // 
            this.colDomain1.FieldName = "Domain";
            this.colDomain1.Name = "colDomain1";
            this.colDomain1.OptionsColumn.AllowEdit = false;
            this.colDomain1.OptionsColumn.FixedWidth = true;
            this.colDomain1.Visible = true;
            this.colDomain1.VisibleIndex = 0;
            this.colDomain1.Width = 138;
            // 
            // colMaxValid
            // 
            this.colMaxValid.DisplayFormat.FormatString = "n0";
            this.colMaxValid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMaxValid.FieldName = "MaxValid";
            this.colMaxValid.Name = "colMaxValid";
            this.colMaxValid.OptionsColumn.FixedWidth = true;
            this.colMaxValid.Visible = true;
            this.colMaxValid.VisibleIndex = 1;
            this.colMaxValid.Width = 65;
            // 
            // colPageRank1
            // 
            this.colPageRank1.Caption = "Rank";
            this.colPageRank1.DisplayFormat.FormatString = "n0";
            this.colPageRank1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPageRank1.FieldName = "PageRank";
            this.colPageRank1.Name = "colPageRank1";
            this.colPageRank1.OptionsColumn.AllowEdit = false;
            this.colPageRank1.OptionsColumn.FixedWidth = true;
            this.colPageRank1.Visible = true;
            this.colPageRank1.VisibleIndex = 6;
            this.colPageRank1.Width = 40;
            // 
            // colTotalProduct1
            // 
            this.colTotalProduct1.Caption = "Total";
            this.colTotalProduct1.DisplayFormat.FormatString = "n0";
            this.colTotalProduct1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalProduct1.FieldName = "TotalProduct";
            this.colTotalProduct1.Name = "colTotalProduct1";
            this.colTotalProduct1.OptionsColumn.AllowEdit = false;
            this.colTotalProduct1.OptionsColumn.FixedWidth = true;
            this.colTotalProduct1.Visible = true;
            this.colTotalProduct1.VisibleIndex = 2;
            this.colTotalProduct1.Width = 55;
            // 
            // colTotalValid1
            // 
            this.colTotalValid1.Caption = "Valid";
            this.colTotalValid1.DisplayFormat.FormatString = "n0";
            this.colTotalValid1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalValid1.FieldName = "TotalValid";
            this.colTotalValid1.Name = "colTotalValid1";
            this.colTotalValid1.OptionsColumn.AllowEdit = false;
            this.colTotalValid1.OptionsColumn.FixedWidth = true;
            this.colTotalValid1.Visible = true;
            this.colTotalValid1.VisibleIndex = 3;
            this.colTotalValid1.Width = 55;
            // 
            // colTotalQueue
            // 
            this.colTotalQueue.Caption = "Queue";
            this.colTotalQueue.DisplayFormat.FormatString = "n0";
            this.colTotalQueue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalQueue.FieldName = "TotalQueue";
            this.colTotalQueue.Name = "colTotalQueue";
            this.colTotalQueue.OptionsColumn.AllowEdit = false;
            this.colTotalQueue.OptionsColumn.FixedWidth = true;
            this.colTotalQueue.Visible = true;
            this.colTotalQueue.VisibleIndex = 4;
            this.colTotalQueue.Width = 55;
            // 
            // colTotalVisited
            // 
            this.colTotalVisited.Caption = "Visited";
            this.colTotalVisited.DisplayFormat.FormatString = "n0";
            this.colTotalVisited.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalVisited.FieldName = "TotalVisited";
            this.colTotalVisited.Name = "colTotalVisited";
            this.colTotalVisited.OptionsColumn.AllowEdit = false;
            this.colTotalVisited.OptionsColumn.FixedWidth = true;
            this.colTotalVisited.Visible = true;
            this.colTotalVisited.VisibleIndex = 5;
            this.colTotalVisited.Width = 55;
            // 
            // colTotalViewMonth
            // 
            this.colTotalViewMonth.DisplayFormat.FormatString = "n0";
            this.colTotalViewMonth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalViewMonth.FieldName = "TotalViewMonth";
            this.colTotalViewMonth.Name = "colTotalViewMonth";
            this.colTotalViewMonth.OptionsColumn.FixedWidth = true;
            this.colTotalViewMonth.OptionsColumn.ReadOnly = true;
            this.colTotalViewMonth.Visible = true;
            this.colTotalViewMonth.VisibleIndex = 7;
            this.colTotalViewMonth.Width = 50;
            // 
            // btPrint
            // 
            this.btPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPrint.Location = new System.Drawing.Point(449, 586);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(75, 24);
            this.btPrint.TabIndex = 1;
            this.btPrint.Text = "Export";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btChamCongDayWeb
            // 
            this.btChamCongDayWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btChamCongDayWeb.Location = new System.Drawing.Point(324, 586);
            this.btChamCongDayWeb.Name = "btChamCongDayWeb";
            this.btChamCongDayWeb.Size = new System.Drawing.Size(122, 24);
            this.btChamCongDayWeb.TabIndex = 1;
            this.btChamCongDayWeb.Text = "Chấm công đẩy web";
            this.btChamCongDayWeb.Click += new System.EventHandler(this.btChamCongDayWeb_Click);
            // 
            // btChamCongOK
            // 
            this.btChamCongOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btChamCongOK.Location = new System.Drawing.Point(217, 586);
            this.btChamCongOK.Name = "btChamCongOK";
            this.btChamCongOK.Size = new System.Drawing.Size(101, 24);
            this.btChamCongOK.TabIndex = 1;
            this.btChamCongOK.Text = "Chấm công OK";
            this.btChamCongOK.Click += new System.EventHandler(this.btChamCongOK_Click);
            // 
            // btChamCongErr
            // 
            this.btChamCongErr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btChamCongErr.Location = new System.Drawing.Point(110, 586);
            this.btChamCongErr.Name = "btChamCongErr";
            this.btChamCongErr.Size = new System.Drawing.Size(101, 24);
            this.btChamCongErr.TabIndex = 1;
            this.btChamCongErr.Text = "Chấm công Error";
            this.btChamCongErr.Click += new System.EventHandler(this.btChamCongErr_Click);
            // 
            // btChamCongDuyet
            // 
            this.btChamCongDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btChamCongDuyet.Location = new System.Drawing.Point(3, 586);
            this.btChamCongDuyet.Name = "btChamCongDuyet";
            this.btChamCongDuyet.Size = new System.Drawing.Size(101, 24);
            this.btChamCongDuyet.TabIndex = 1;
            this.btChamCongDuyet.Text = "Chấm công duyệt";
            this.btChamCongDuyet.Click += new System.EventHandler(this.btChamCongDuyet_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyOfTypeBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Location = new System.Drawing.Point(34, 28);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(29, 20);
            this.iDTextBox.TabIndex = 3;
            this.iDTextBox.TextChanged += new System.EventHandler(this.iDTextBox_TextChanged);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.companyOfTypeBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(574, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(462, 613);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.ctrLogMananger1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(454, 584);
            this.xtraTabPage2.Text = "Error";
            // 
            // ctrLogMananger1
            // 
            this.ctrLogMananger1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrLogMananger1.Location = new System.Drawing.Point(0, 0);
            this.ctrLogMananger1.Name = "ctrLogMananger1";
            this.ctrLogMananger1.Size = new System.Drawing.Size(454, 584);
            this.ctrLogMananger1.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grvListAll);
            this.xtraTabPage1.Controls.Add(this.bindingNavigator2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(454, 584);
            this.xtraTabPage1.Text = "List";
            // 
            // grvListAll
            // 
            this.grvListAll.DataSource = this.companyViewBindingSource;
            this.grvListAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvListAll.Location = new System.Drawing.Point(0, 25);
            this.grvListAll.MainView = this.gridView3;
            this.grvListAll.Name = "grvListAll";
            this.grvListAll.Size = new System.Drawing.Size(454, 559);
            this.grvListAll.TabIndex = 0;
            this.grvListAll.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.grvListAll.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grvListAll_MouseDoubleClick);
            // 
            // companyViewBindingSource
            // 
            this.companyViewBindingSource.DataMember = "CompanyView";
            this.companyViewBindingSource.DataSource = this.dBCom;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDomain,
            this.colPageRank,
            this.colTimeDelay,
            this.colTotalProduct,
            this.colTotalValid,
            this.colManagerType,
            this.colTotalQueue1,
            this.colTotalVisited1,
            this.colTotalViewMonth1});
            this.gridView3.GridControl = this.grvListAll;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.OptionsColumn.AllowEdit = false;
            this.colDomain.OptionsColumn.FixedWidth = true;
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 0;
            this.colDomain.Width = 160;
            // 
            // colPageRank
            // 
            this.colPageRank.Caption = "Rank";
            this.colPageRank.FieldName = "PageRank";
            this.colPageRank.Name = "colPageRank";
            this.colPageRank.OptionsColumn.AllowEdit = false;
            this.colPageRank.Visible = true;
            this.colPageRank.VisibleIndex = 6;
            this.colPageRank.Width = 45;
            // 
            // colTimeDelay
            // 
            this.colTimeDelay.Caption = "MaxValid";
            this.colTimeDelay.FieldName = "TimeDelay";
            this.colTimeDelay.Name = "colTimeDelay";
            this.colTimeDelay.Visible = true;
            this.colTimeDelay.VisibleIndex = 2;
            this.colTimeDelay.Width = 45;
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.Caption = "Total";
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.OptionsColumn.AllowEdit = false;
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 3;
            this.colTotalProduct.Width = 45;
            // 
            // colTotalValid
            // 
            this.colTotalValid.Caption = "Valid";
            this.colTotalValid.FieldName = "TotalValid";
            this.colTotalValid.Name = "colTotalValid";
            this.colTotalValid.OptionsColumn.AllowEdit = false;
            this.colTotalValid.Visible = true;
            this.colTotalValid.VisibleIndex = 4;
            this.colTotalValid.Width = 45;
            // 
            // colManagerType
            // 
            this.colManagerType.Caption = "Type";
            this.colManagerType.FieldName = "ManagerType";
            this.colManagerType.Name = "colManagerType";
            this.colManagerType.OptionsColumn.AllowEdit = false;
            this.colManagerType.Visible = true;
            this.colManagerType.VisibleIndex = 7;
            this.colManagerType.Width = 46;
            // 
            // colTotalQueue1
            // 
            this.colTotalQueue1.Caption = "Queue";
            this.colTotalQueue1.FieldName = "TotalQueue";
            this.colTotalQueue1.Name = "colTotalQueue1";
            this.colTotalQueue1.OptionsColumn.AllowEdit = false;
            this.colTotalQueue1.Visible = true;
            this.colTotalQueue1.VisibleIndex = 1;
            this.colTotalQueue1.Width = 45;
            // 
            // colTotalVisited1
            // 
            this.colTotalVisited1.Caption = "Visited";
            this.colTotalVisited1.FieldName = "TotalVisited";
            this.colTotalVisited1.Name = "colTotalVisited1";
            this.colTotalVisited1.OptionsColumn.AllowEdit = false;
            this.colTotalVisited1.Visible = true;
            this.colTotalVisited1.VisibleIndex = 5;
            this.colTotalVisited1.Width = 45;
            // 
            // colTotalViewMonth1
            // 
            this.colTotalViewMonth1.FieldName = "TotalViewMonth";
            this.colTotalViewMonth1.Name = "colTotalViewMonth1";
            this.colTotalViewMonth1.OptionsColumn.FixedWidth = true;
            this.colTotalViewMonth1.OptionsColumn.ReadOnly = true;
            this.colTotalViewMonth1.Visible = true;
            this.colTotalViewMonth1.VisibleIndex = 8;
            this.colTotalViewMonth1.Width = 50;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.companyViewBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(454, 25);
            this.bindingNavigator2.TabIndex = 1;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
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
            // btAddCom
            // 
            this.btAddCom.Location = new System.Drawing.Point(133, 6);
            this.btAddCom.Name = "btAddCom";
            this.btAddCom.Size = new System.Drawing.Size(77, 24);
            this.btAddCom.TabIndex = 1;
            this.btAddCom.Text = "Thêm vào";
            this.btAddCom.Click += new System.EventHandler(this.btAddCom_Click);
            // 
            // btDeleteQueue
            // 
            this.btDeleteQueue.Location = new System.Drawing.Point(384, 6);
            this.btDeleteQueue.Name = "btDeleteQueue";
            this.btDeleteQueue.Size = new System.Drawing.Size(77, 24);
            this.btDeleteQueue.TabIndex = 1;
            this.btDeleteQueue.Text = "Xóa Queue";
            this.btDeleteQueue.Click += new System.EventHandler(this.btDeleteQueue_Click);
            // 
            // btSaveTypeOf
            // 
            this.btSaveTypeOf.Location = new System.Drawing.Point(301, 6);
            this.btSaveTypeOf.Name = "btSaveTypeOf";
            this.btSaveTypeOf.Size = new System.Drawing.Size(77, 24);
            this.btSaveTypeOf.TabIndex = 1;
            this.btSaveTypeOf.Text = "Save";
            this.btSaveTypeOf.Click += new System.EventHandler(this.btSaveTypeOf_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(218, 6);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(77, 24);
            this.btRemove.TabIndex = 1;
            this.btRemove.Text = "Xóa đi";
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // iDManagerTypeTextBox
            // 
            this.iDManagerTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeBindingSource, "ID", true));
            this.iDManagerTypeTextBox.Enabled = false;
            this.iDManagerTypeTextBox.Location = new System.Drawing.Point(674, 14);
            this.iDManagerTypeTextBox.Name = "iDManagerTypeTextBox";
            this.iDManagerTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDManagerTypeTextBox.TabIndex = 7;
            this.iDManagerTypeTextBox.TextChanged += new System.EventHandler(this.iDManagerTypeTextBox_TextChanged);
            // 
            // btFillter
            // 
            this.btFillter.Location = new System.Drawing.Point(2, 6);
            this.btFillter.Name = "btFillter";
            this.btFillter.Size = new System.Drawing.Size(118, 24);
            this.btFillter.TabIndex = 1;
            this.btFillter.Text = "FillterCompany";
            this.btFillter.Click += new System.EventHandler(this.btFillter_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.iDCompanyViewTextBox);
            this.groupControl1.Controls.Add(totalVisitedLabel);
            this.groupControl1.Controls.Add(iDLabel1);
            this.groupControl1.Controls.Add(this.totalVisitedTextBox);
            this.groupControl1.Controls.Add(this.domainCompanyViewTextBox);
            this.groupControl1.Controls.Add(totalQueueLabel);
            this.groupControl1.Controls.Add(domainLabel);
            this.groupControl1.Controls.Add(this.totalQueueTextBox);
            this.groupControl1.Controls.Add(this.pageRankTextBox);
            this.groupControl1.Controls.Add(totalValidLabel);
            this.groupControl1.Controls.Add(pageRankLabel);
            this.groupControl1.Controls.Add(this.totalValidTextBox);
            this.groupControl1.Controls.Add(this.totalProductTextBox);
            this.groupControl1.Controls.Add(totalProductLabel);
            this.groupControl1.Enabled = false;
            this.groupControl1.Location = new System.Drawing.Point(415, 140);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(147, 89);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "groupControl1";
            // 
            // iDCompanyViewTextBox
            // 
            this.iDCompanyViewTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyViewBindingSource, "ID", true));
            this.iDCompanyViewTextBox.Location = new System.Drawing.Point(36, 25);
            this.iDCompanyViewTextBox.Name = "iDCompanyViewTextBox";
            this.iDCompanyViewTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDCompanyViewTextBox.TabIndex = 9;
            // 
            // totalVisitedTextBox
            // 
            this.totalVisitedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyViewBindingSource, "TotalVisited", true));
            this.totalVisitedTextBox.Location = new System.Drawing.Point(178, 28);
            this.totalVisitedTextBox.Name = "totalVisitedTextBox";
            this.totalVisitedTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalVisitedTextBox.TabIndex = 18;
            // 
            // domainCompanyViewTextBox
            // 
            this.domainCompanyViewTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyViewBindingSource, "Domain", true));
            this.domainCompanyViewTextBox.Location = new System.Drawing.Point(36, 48);
            this.domainCompanyViewTextBox.Name = "domainCompanyViewTextBox";
            this.domainCompanyViewTextBox.Size = new System.Drawing.Size(100, 20);
            this.domainCompanyViewTextBox.TabIndex = 12;
            // 
            // totalQueueTextBox
            // 
            this.totalQueueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyViewBindingSource, "TotalQueue", true));
            this.totalQueueTextBox.Location = new System.Drawing.Point(36, 157);
            this.totalQueueTextBox.Name = "totalQueueTextBox";
            this.totalQueueTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalQueueTextBox.TabIndex = 17;
            // 
            // pageRankTextBox
            // 
            this.pageRankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyViewBindingSource, "PageRank", true));
            this.pageRankTextBox.Location = new System.Drawing.Point(36, 79);
            this.pageRankTextBox.Name = "pageRankTextBox";
            this.pageRankTextBox.Size = new System.Drawing.Size(100, 20);
            this.pageRankTextBox.TabIndex = 14;
            // 
            // totalValidTextBox
            // 
            this.totalValidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyViewBindingSource, "TotalValid", true));
            this.totalValidTextBox.Location = new System.Drawing.Point(36, 131);
            this.totalValidTextBox.Name = "totalValidTextBox";
            this.totalValidTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalValidTextBox.TabIndex = 16;
            // 
            // totalProductTextBox
            // 
            this.totalProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyViewBindingSource, "TotalProduct", true));
            this.totalProductTextBox.Location = new System.Drawing.Point(36, 105);
            this.totalProductTextBox.Name = "totalProductTextBox";
            this.totalProductTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalProductTextBox.TabIndex = 15;
            // 
            // managerTypeTableAdapter
            // 
            this.managerTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_AddressTableAdapter = null;
            this.tableAdapterManager.Company_ImageTableAdapter = null;
            this.tableAdapterManager.Company1TableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.DatafeedConfigTableAdapter = null;
            this.tableAdapterManager.HistoryDatafeedTableAdapter = null;
            this.tableAdapterManager.Job_WebsiteConfigLogTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.ManagerCompanyLogTableAdapter = null;
            this.tableAdapterManager.ManagerCompanyLogTypeTableAdapter = null;
            this.tableAdapterManager.ManagerCrawlerTableAdapter = null;
            this.tableAdapterManager.ManagerTypeRCompanyTableAdapter = null;
            this.tableAdapterManager.ManagerTypeTableAdapter = this.managerTypeTableAdapter;
            this.tableAdapterManager.ProductQuangCaoTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Company.DBComTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companyViewTableAdapter
            // 
            this.companyViewTableAdapter.ClearBeforeFill = true;
            // 
            // companyOfTypeTableAdapter
            // 
            this.companyOfTypeTableAdapter.ClearBeforeFill = true;
            // 
            // managerTypeRCompanyBindingSource
            // 
            this.managerTypeRCompanyBindingSource.DataMember = "ManagerTypeRCompany";
            this.managerTypeRCompanyBindingSource.DataSource = this.dBCom;
            // 
            // managerTypeRCompanyTableAdapter
            // 
            this.managerTypeRCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // listComManBindingSource
            // 
            this.listComManBindingSource.DataMember = "ListComMan";
            this.listComManBindingSource.DataSource = this.dBCom;
            // 
            // listComManTableAdapter
            // 
            this.listComManTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waitFindNewDataToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(170, 26);
            // 
            // waitFindNewDataToolStripMenuItem
            // 
            this.waitFindNewDataToolStripMenuItem.Name = "waitFindNewDataToolStripMenuItem";
            this.waitFindNewDataToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.waitFindNewDataToolStripMenuItem.Text = "WaitFindNewData";
            this.waitFindNewDataToolStripMenuItem.Click += new System.EventHandler(this.waitFindNewDataToolStripMenuItem_Click);
            // 
            // frmManagerCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1354, 649);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmManagerCom";
            this.Load += new System.EventHandler(this.frmManagerCom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBComBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyOfTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListCurrent)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvListAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeRCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listComManBindingSource)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dBComBindingSource;
        private DBCom dBCom;
        private System.Windows.Forms.BindingSource managerTypeBindingSource;
        private DBComTableAdapters.ManagerTypeTableAdapter managerTypeTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btDelete;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.SimpleButton btLoad;
        private DevExpress.XtraGrid.GridControl gridListCurrent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btAddCom;
        private DevExpress.XtraEditors.SimpleButton btRemove;
        private DBComTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDManagerTypeTextBox;
        private DevExpress.XtraGrid.GridControl grvListAll;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource companyViewBindingSource;
        private DBComTableAdapters.CompanyViewTableAdapter companyViewTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colPageRank;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValid;
        private DevExpress.XtraGrid.Columns.GridColumn colManagerType;
        private System.Windows.Forms.BindingSource companyOfTypeBindingSource;
        private DBComTableAdapters.CompanyOfTypeTableAdapter companyOfTypeTableAdapter;
        private System.Windows.Forms.TextBox iDCompanyViewTextBox;
        private DevExpress.XtraEditors.SimpleButton btFillter;
        private System.Windows.Forms.TextBox domainCompanyViewTextBox;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain1;
        private DevExpress.XtraGrid.Columns.GridColumn colPageRank1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValid1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQueue;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalVisited;
        private System.Windows.Forms.TextBox totalVisitedTextBox;
        private System.Windows.Forms.TextBox totalQueueTextBox;
        private System.Windows.Forms.TextBox totalValidTextBox;
        private System.Windows.Forms.TextBox totalProductTextBox;
        private System.Windows.Forms.TextBox pageRankTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalVisited1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btSaveTypeOf;
        private System.Windows.Forms.BindingSource managerTypeRCompanyBindingSource;
        private DBComTableAdapters.ManagerTypeRCompanyTableAdapter managerTypeRCompanyTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalQueue1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource listComManBindingSource;
        private DBComTableAdapters.ListComManTableAdapter listComManTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolChuyenNhom;
        private System.Windows.Forms.ToolStripMenuItem toolXoaKhoiNhom;
        private System.Windows.Forms.TextBox iDTextBox;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ctrLogMananger ctrLogMananger1;
        private DevExpress.XtraEditors.SimpleButton btChamCongDuyet;
        private DevExpress.XtraEditors.SimpleButton btChamCongErr;
        private DevExpress.XtraEditors.SimpleButton btChamCongOK;
        private System.Windows.Forms.TextBox domainTextBox;
        private System.Windows.Forms.TextBox totalProductOfTypeTextBox;
        private System.Windows.Forms.TextBox totalValidOfTypeTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxValid;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeDelay;
        private DevExpress.XtraEditors.SimpleButton btChamCongDayWeb;
        private DevExpress.XtraEditors.SimpleButton btDeleteQueue;
        private System.Windows.Forms.TextBox txtResult;
        private DevExpress.XtraEditors.SimpleButton btPrint;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalViewMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalViewMonth1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colDes;
        private DevExpress.XtraGrid.Columns.GridColumn colMinHourRecrawl;
        private DevExpress.XtraGrid.Columns.GridColumn colTheoDoi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem waitFindNewDataToolStripMenuItem;
    }
}
