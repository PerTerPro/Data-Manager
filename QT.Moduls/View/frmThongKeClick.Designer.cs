namespace QT.Moduls.View
{
    partial class frmThongKeClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeClick));
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCom = new QT.Moduls.Company.DBCom();
            this.laDomain = new DevExpress.XtraEditors.LabelControl();
            this.ctrBaseDateRange1 = new QT.Moduls.Base.ctrBaseDateRange();
            this.companyTableAdapter = new QT.Moduls.Company.DBComTableAdapters.CompanyTableAdapter();
            this.btView = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.viewProductLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBView = new QT.Moduls.View.DBView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDateLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCounts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_ProductAdd_Log = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productLogsAddProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colURL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_ProductLogAddURL = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btExport = new System.Windows.Forms.ToolStripButton();
            this.btExportPDF = new System.Windows.Forms.ToolStripButton();
            this.btExportHTM = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExportNew = new System.Windows.Forms.ToolStripButton();
            this.xtraTabPageReport = new DevExpress.XtraTab.XtraTabPage();
            this.prc_ProductLog_ThongKeClickGridControl = new DevExpress.XtraGrid.GridControl();
            this.prc_ProductLog_ThongKeClickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLog1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCounts1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonth1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHours1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ExportExcelButton = new DevExpress.XtraEditors.SimpleButton();
            this.tabChiNhanh = new DevExpress.XtraTab.XtraTabPage();
            this.viewProductLogTableAdapter = new QT.Moduls.View.DBViewTableAdapters.ViewProductLogTableAdapter();
            this.product_LogsAddProductTableAdapter = new QT.Moduls.View.DBViewTableAdapters.Product_LogsAddProductTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboDonVi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableAdapterManager = new QT.Moduls.View.DBViewTableAdapters.TableAdapterManager();
            this.prc_ProductLog_ThongKeClickTableAdapter = new QT.Moduls.View.DBViewTableAdapters.prc_ProductLog_ThongKeClickTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_ProductAdd_Log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLogsAddProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_ProductLogAddURL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.xtraTabPageReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prc_ProductLog_ThongKeClickGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prc_ProductLog_ThongKeClickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDonVi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBCom;
            // 
            // dBCom
            // 
            this.dBCom.DataSetName = "DBCom";
            this.dBCom.EnforceConstraints = false;
            this.dBCom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laDomain
            // 
            this.laDomain.Location = new System.Drawing.Point(12, 13);
            this.laDomain.Name = "laDomain";
            this.laDomain.Size = new System.Drawing.Size(62, 13);
            this.laDomain.TabIndex = 1;
            this.laDomain.Text = "Chọn domain";
            // 
            // ctrBaseDateRange1
            // 
            this.ctrBaseDateRange1.FromDate = new System.DateTime(2014, 2, 15, 0, 0, 0, 0);
            this.ctrBaseDateRange1.Location = new System.Drawing.Point(102, 3);
            this.ctrBaseDateRange1.Name = "ctrBaseDateRange1";
            this.ctrBaseDateRange1.Size = new System.Drawing.Size(553, 34);
            this.ctrBaseDateRange1.TabIndex = 2;
            this.ctrBaseDateRange1.ToDate = new System.DateTime(2014, 2, 15, 23, 59, 59, 0);
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(804, 6);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(53, 23);
            this.btView.TabIndex = 3;
            this.btView.Text = "Xem";
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 43);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageReport;
            this.xtraTabControl1.Size = new System.Drawing.Size(965, 479);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageReport,
            this.xtraTabPage1,
            this.tabChiNhanh});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Controls.Add(this.bindingNavigator1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(959, 451);
            this.xtraTabPage1.Text = "Report";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.viewProductLogBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit_ProductLogAddURL,
            this.repositoryItemLookUpEdit_ProductAdd_Log});
            this.gridControl1.Size = new System.Drawing.Size(959, 426);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // viewProductLogBindingSource
            // 
            this.viewProductLogBindingSource.DataMember = "ViewProductLog";
            this.viewProductLogBindingSource.DataSource = this.dBView;
            // 
            // dBView
            // 
            this.dBView.DataSetName = "DBView";
            this.dBView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDateLog,
            this.colYear,
            this.colMonth,
            this.colDay,
            this.colHours,
            this.colCounts,
            this.colName,
            this.colURL,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colDateLog
            // 
            this.colDateLog.Caption = "Thời gian click";
            this.colDateLog.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateLog.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateLog.FieldName = "DateLog";
            this.colDateLog.Name = "colDateLog";
            this.colDateLog.OptionsColumn.FixedWidth = true;
            this.colDateLog.OptionsColumn.ReadOnly = true;
            this.colDateLog.Visible = true;
            this.colDateLog.VisibleIndex = 0;
            this.colDateLog.Width = 164;
            // 
            // colYear
            // 
            this.colYear.Caption = "Năm";
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.OptionsColumn.FixedWidth = true;
            this.colYear.OptionsColumn.ReadOnly = true;
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 1;
            this.colYear.Width = 45;
            // 
            // colMonth
            // 
            this.colMonth.Caption = "Tháng";
            this.colMonth.FieldName = "Month";
            this.colMonth.Name = "colMonth";
            this.colMonth.OptionsColumn.FixedWidth = true;
            this.colMonth.OptionsColumn.ReadOnly = true;
            this.colMonth.Visible = true;
            this.colMonth.VisibleIndex = 2;
            this.colMonth.Width = 50;
            // 
            // colDay
            // 
            this.colDay.Caption = "Ngày";
            this.colDay.FieldName = "Day";
            this.colDay.Name = "colDay";
            this.colDay.OptionsColumn.FixedWidth = true;
            this.colDay.OptionsColumn.ReadOnly = true;
            this.colDay.Visible = true;
            this.colDay.VisibleIndex = 3;
            this.colDay.Width = 45;
            // 
            // colHours
            // 
            this.colHours.Caption = "Giờ";
            this.colHours.FieldName = "Hours";
            this.colHours.Name = "colHours";
            this.colHours.OptionsColumn.FixedWidth = true;
            this.colHours.OptionsColumn.ReadOnly = true;
            this.colHours.Visible = true;
            this.colHours.VisibleIndex = 4;
            this.colHours.Width = 40;
            // 
            // colCounts
            // 
            this.colCounts.Caption = "Click";
            this.colCounts.FieldName = "Counts";
            this.colCounts.Name = "colCounts";
            this.colCounts.OptionsColumn.FixedWidth = true;
            this.colCounts.OptionsColumn.ReadOnly = true;
            this.colCounts.Visible = true;
            this.colCounts.VisibleIndex = 5;
            this.colCounts.Width = 50;
            // 
            // colName
            // 
            this.colName.Caption = "Tên sản phẩm";
            this.colName.ColumnEdit = this.repositoryItemLookUpEdit_ProductAdd_Log;
            this.colName.FieldName = "IDProduct";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Width = 213;
            // 
            // repositoryItemLookUpEdit_ProductAdd_Log
            // 
            this.repositoryItemLookUpEdit_ProductAdd_Log.AutoHeight = false;
            this.repositoryItemLookUpEdit_ProductAdd_Log.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_ProductAdd_Log.DataSource = this.productLogsAddProductBindingSource;
            this.repositoryItemLookUpEdit_ProductAdd_Log.DisplayMember = "Name";
            this.repositoryItemLookUpEdit_ProductAdd_Log.Name = "repositoryItemLookUpEdit_ProductAdd_Log";
            this.repositoryItemLookUpEdit_ProductAdd_Log.ValueMember = "IDProduct";
            // 
            // productLogsAddProductBindingSource
            // 
            this.productLogsAddProductBindingSource.DataMember = "Product_LogsAddProduct";
            this.productLogsAddProductBindingSource.DataSource = this.dBView;
            // 
            // colURL
            // 
            this.colURL.Caption = "Link đến";
            this.colURL.ColumnEdit = this.repositoryItemLookUpEdit_ProductLogAddURL;
            this.colURL.FieldName = "IDProduct";
            this.colURL.Name = "colURL";
            this.colURL.OptionsColumn.ReadOnly = true;
            this.colURL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colURL.Width = 329;
            // 
            // repositoryItemLookUpEdit_ProductLogAddURL
            // 
            this.repositoryItemLookUpEdit_ProductLogAddURL.AutoHeight = false;
            this.repositoryItemLookUpEdit_ProductLogAddURL.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_ProductLogAddURL.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit_ProductLogAddURL.DataSource = this.productLogsAddProductBindingSource;
            this.repositoryItemLookUpEdit_ProductLogAddURL.DisplayMember = "URL";
            this.repositoryItemLookUpEdit_ProductLogAddURL.Name = "repositoryItemLookUpEdit_ProductLogAddURL";
            this.repositoryItemLookUpEdit_ProductLogAddURL.ValueMember = "IDProduct";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên sản phẩm";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "URL";
            this.gridColumn2.FieldName = "URL";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.viewProductLogBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
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
            this.btExport,
            this.btExportPDF,
            this.btExportHTM,
            this.toolStripSeparator1,
            this.toolStripButtonExportNew});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(959, 25);
            this.bindingNavigator1.TabIndex = 28;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // btExport
            // 
            this.btExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btExport.Image = ((System.Drawing.Image)(resources.GetObject("btExport.Image")));
            this.btExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(70, 22);
            this.btExport.Text = "ExportExcel";
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btExportPDF
            // 
            this.btExportPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btExportPDF.Image = ((System.Drawing.Image)(resources.GetObject("btExportPDF.Image")));
            this.btExportPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExportPDF.Name = "btExportPDF";
            this.btExportPDF.Size = new System.Drawing.Size(65, 22);
            this.btExportPDF.Text = "ExportPDF";
            this.btExportPDF.Click += new System.EventHandler(this.btExportPDF_Click);
            // 
            // btExportHTM
            // 
            this.btExportHTM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btExportHTM.Image = ((System.Drawing.Image)(resources.GetObject("btExportHTM.Image")));
            this.btExportHTM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExportHTM.Name = "btExportHTM";
            this.btExportHTM.Size = new System.Drawing.Size(71, 22);
            this.btExportHTM.Text = "ExportHTM";
            this.btExportHTM.Click += new System.EventHandler(this.btExportHTM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonExportNew
            // 
            this.toolStripButtonExportNew.Image = global::QT.Moduls.Properties.Resources.microsoft_excel;
            this.toolStripButtonExportNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExportNew.Name = "toolStripButtonExportNew";
            this.toolStripButtonExportNew.Size = new System.Drawing.Size(84, 22);
            this.toolStripButtonExportNew.Text = "ExportNew";
            this.toolStripButtonExportNew.Click += new System.EventHandler(this.toolStripButtonExportNew_Click);
            // 
            // xtraTabPageReport
            // 
            this.xtraTabPageReport.Controls.Add(this.prc_ProductLog_ThongKeClickGridControl);
            this.xtraTabPageReport.Controls.Add(this.panelControl1);
            this.xtraTabPageReport.Name = "xtraTabPageReport";
            this.xtraTabPageReport.Size = new System.Drawing.Size(959, 451);
            this.xtraTabPageReport.Text = "Report New";
            // 
            // prc_ProductLog_ThongKeClickGridControl
            // 
            this.prc_ProductLog_ThongKeClickGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.prc_ProductLog_ThongKeClickGridControl.DataSource = this.prc_ProductLog_ThongKeClickBindingSource;
            this.prc_ProductLog_ThongKeClickGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prc_ProductLog_ThongKeClickGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.prc_ProductLog_ThongKeClickGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.prc_ProductLog_ThongKeClickGridControl.Location = new System.Drawing.Point(0, 52);
            this.prc_ProductLog_ThongKeClickGridControl.MainView = this.gridView2;
            this.prc_ProductLog_ThongKeClickGridControl.Name = "prc_ProductLog_ThongKeClickGridControl";
            this.prc_ProductLog_ThongKeClickGridControl.Size = new System.Drawing.Size(959, 399);
            this.prc_ProductLog_ThongKeClickGridControl.TabIndex = 1;
            this.prc_ProductLog_ThongKeClickGridControl.UseEmbeddedNavigator = true;
            this.prc_ProductLog_ThongKeClickGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // prc_ProductLog_ThongKeClickBindingSource
            // 
            this.prc_ProductLog_ThongKeClickBindingSource.DataMember = "prc_ProductLog_ThongKeClick";
            this.prc_ProductLog_ThongKeClickBindingSource.DataSource = this.dBView;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDateLog1,
            this.colIDCompany,
            this.colIDProduct,
            this.colCounts1,
            this.colName1,
            this.colURL1,
            this.colYear1,
            this.colMonth1,
            this.colDay1,
            this.colHours1});
            this.gridView2.GridControl = this.prc_ProductLog_ThongKeClickGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 91;
            // 
            // colDateLog1
            // 
            this.colDateLog1.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colDateLog1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateLog1.FieldName = "DateLog";
            this.colDateLog1.Name = "colDateLog1";
            this.colDateLog1.Visible = true;
            this.colDateLog1.VisibleIndex = 2;
            this.colDateLog1.Width = 129;
            // 
            // colIDCompany
            // 
            this.colIDCompany.FieldName = "IDCompany";
            this.colIDCompany.Name = "colIDCompany";
            // 
            // colIDProduct
            // 
            this.colIDProduct.FieldName = "IDProduct";
            this.colIDProduct.Name = "colIDProduct";
            // 
            // colCounts1
            // 
            this.colCounts1.FieldName = "Counts";
            this.colCounts1.Name = "colCounts1";
            this.colCounts1.Width = 215;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.ReadOnly = true;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 309;
            // 
            // colURL1
            // 
            this.colURL1.FieldName = "URL";
            this.colURL1.Name = "colURL1";
            this.colURL1.OptionsColumn.ReadOnly = true;
            this.colURL1.Visible = true;
            this.colURL1.VisibleIndex = 1;
            this.colURL1.Width = 503;
            // 
            // colYear1
            // 
            this.colYear1.FieldName = "Year";
            this.colYear1.Name = "colYear1";
            this.colYear1.OptionsColumn.ReadOnly = true;
            // 
            // colMonth1
            // 
            this.colMonth1.FieldName = "Month";
            this.colMonth1.Name = "colMonth1";
            this.colMonth1.OptionsColumn.ReadOnly = true;
            // 
            // colDay1
            // 
            this.colDay1.FieldName = "Day";
            this.colDay1.Name = "colDay1";
            this.colDay1.OptionsColumn.ReadOnly = true;
            // 
            // colHours1
            // 
            this.colHours1.FieldName = "Hours";
            this.colHours1.Name = "colHours1";
            this.colHours1.OptionsColumn.ReadOnly = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ExportExcelButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(959, 52);
            this.panelControl1.TabIndex = 1;
            // 
            // ExportExcelButton
            // 
            this.ExportExcelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportExcelButton.Image = global::QT.Moduls.Properties.Resources.microsoft_excel;
            this.ExportExcelButton.Location = new System.Drawing.Point(816, 5);
            this.ExportExcelButton.Name = "ExportExcelButton";
            this.ExportExcelButton.Size = new System.Drawing.Size(137, 41);
            this.ExportExcelButton.TabIndex = 2;
            this.ExportExcelButton.Text = "Export Excel";
            this.ExportExcelButton.Click += new System.EventHandler(this.ExportExcelButton_Click);
            // 
            // tabChiNhanh
            // 
            this.tabChiNhanh.Name = "tabChiNhanh";
            this.tabChiNhanh.Size = new System.Drawing.Size(959, 451);
            this.tabChiNhanh.Text = "Địa chỉ chi nhánh";
            // 
            // viewProductLogTableAdapter
            // 
            this.viewProductLogTableAdapter.ClearBeforeFill = true;
            // 
            // product_LogsAddProductTableAdapter
            // 
            this.product_LogsAddProductTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(661, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Đơn vị";
            // 
            // cboDonVi
            // 
            this.cboDonVi.Location = new System.Drawing.Point(698, 9);
            this.cboDonVi.Name = "cboDonVi";
            this.cboDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDonVi.Properties.Items.AddRange(new object[] {
            "Giây",
            "Giờ",
            "Ngày",
            "Tháng",
            "Năm"});
            this.cboDonVi.Size = new System.Drawing.Size(100, 20);
            this.cboDonVi.TabIndex = 5;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.View.DBViewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prc_ProductLog_ThongKeClickTableAdapter
            // 
            this.prc_ProductLog_ThongKeClickTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKeClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(969, 521);
            this.Controls.Add(this.cboDonVi);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.ctrBaseDateRange1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.laDomain);
            this.Name = "frmThongKeClick";
            this.Load += new System.EventHandler(this.frmThongKeClick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_ProductAdd_Log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLogsAddProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_ProductLogAddURL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.xtraTabPageReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prc_ProductLog_ThongKeClickGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prc_ProductLog_ThongKeClickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboDonVi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl laDomain;
        private Base.ctrBaseDateRange ctrBaseDateRange1;
        private Company.DBCom dBCom;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private Company.DBComTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btView;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage tabChiNhanh;
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_ProductLogAddURL;
        private DBView dBView;
        private System.Windows.Forms.BindingSource viewProductLogBindingSource;
        private DBViewTableAdapters.ViewProductLogTableAdapter viewProductLogTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLog;
        private DevExpress.XtraGrid.Columns.GridColumn colCounts;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colURL;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_ProductAdd_Log;
        private System.Windows.Forms.BindingSource productLogsAddProductBindingSource;
        private DBViewTableAdapters.Product_LogsAddProductTableAdapter product_LogsAddProductTableAdapter;
        private System.Windows.Forms.ToolStripButton btExport;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colDay;
        private DevExpress.XtraGrid.Columns.GridColumn colHours;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton btExportPDF;
        private System.Windows.Forms.ToolStripButton btExportHTM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportNew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageReport;
        private DBViewTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton ExportExcelButton;
        private System.Windows.Forms.BindingSource prc_ProductLog_ThongKeClickBindingSource;
        private DBViewTableAdapters.prc_ProductLog_ThongKeClickTableAdapter prc_ProductLog_ThongKeClickTableAdapter;
        private DevExpress.XtraGrid.GridControl prc_ProductLog_ThongKeClickGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLog1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colCounts1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colURL1;
        private DevExpress.XtraGrid.Columns.GridColumn colYear1;
        private DevExpress.XtraGrid.Columns.GridColumn colMonth1;
        private DevExpress.XtraGrid.Columns.GridColumn colDay1;
        private DevExpress.XtraGrid.Columns.GridColumn colHours1;
    }
}
