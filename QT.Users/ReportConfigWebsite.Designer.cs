namespace QT.Users
{
    partial class ReportConfigWebsite
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB = new QT.Users.DB();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.viewConfigWebBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameTypeNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btView = new DevExpress.XtraEditors.SimpleButton();
            this.btExport = new DevExpress.XtraEditors.SimpleButton();
            this.btViewAll = new DevExpress.XtraEditors.SimpleButton();
            this.ctrDateRanger1 = new QT.Entities.ctrDateRanger();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.tblUserTableAdapter = new QT.Users.DBTableAdapters.tblUserTableAdapter();
            this.viewConfigWebTableAdapter = new QT.Users.DBTableAdapters.ViewConfigWebTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConfigWebBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "UserName", true));
            this.userNameTextBox.Enabled = false;
            this.userNameTextBox.Location = new System.Drawing.Point(185, 9);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.userNameTextBox.TabIndex = 16;
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
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.viewConfigWebBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(922, 544);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // viewConfigWebBindingSource
            // 
            this.viewConfigWebBindingSource.DataMember = "ViewConfigWeb";
            this.viewConfigWebBindingSource.DataSource = this.dB;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colDomain,
            this.colNameType,
            this.colNameTypeNew,
            this.colStatus,
            this.colLastUpdate,
            this.colLastUpdate1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 3;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "IDStatus", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUserName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDomain, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLastUpdate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.FixedWidth = true;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.OptionsColumn.FixedWidth = true;
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 0;
            // 
            // colNameType
            // 
            this.colNameType.FieldName = "NameType";
            this.colNameType.Name = "colNameType";
            this.colNameType.Visible = true;
            this.colNameType.VisibleIndex = 0;
            this.colNameType.Width = 83;
            // 
            // colNameTypeNew
            // 
            this.colNameTypeNew.FieldName = "NameTypeNew";
            this.colNameTypeNew.Name = "colNameTypeNew";
            this.colNameTypeNew.Visible = true;
            this.colNameTypeNew.VisibleIndex = 1;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.FixedWidth = true;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.Caption = "Ngày";
            this.colLastUpdate.DisplayFormat.FormatString = "dd/MM/yy";
            this.colLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.OptionsColumn.FixedWidth = true;
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 3;
            // 
            // colLastUpdate1
            // 
            this.colLastUpdate1.Caption = "Giờ";
            this.colLastUpdate1.DisplayFormat.FormatString = "hh:mm";
            this.colLastUpdate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUpdate1.FieldName = "LastUpdate";
            this.colLastUpdate1.Name = "colLastUpdate1";
            this.colLastUpdate1.OptionsColumn.FixedWidth = true;
            this.colLastUpdate1.Visible = true;
            this.colLastUpdate1.VisibleIndex = 3;
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(6, 35);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(102, 23);
            this.btView.TabIndex = 13;
            this.btView.Text = "Xem theo user";
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(222, 35);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(102, 23);
            this.btExport.TabIndex = 14;
            this.btExport.Text = "Export";
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btViewAll
            // 
            this.btViewAll.Location = new System.Drawing.Point(114, 35);
            this.btViewAll.Name = "btViewAll";
            this.btViewAll.Size = new System.Drawing.Size(102, 23);
            this.btViewAll.TabIndex = 12;
            this.btViewAll.Text = "Xem toàn bộ";
            this.btViewAll.Click += new System.EventHandler(this.btViewAll_Click);
            // 
            // ctrDateRanger1
            // 
            this.ctrDateRanger1.FromDate = new System.DateTime(2014, 7, 20, 0, 0, 1, 0);
            this.ctrDateRanger1.Location = new System.Drawing.Point(312, 5);
            this.ctrDateRanger1.Name = "ctrDateRanger1";
            this.ctrDateRanger1.Size = new System.Drawing.Size(442, 27);
            this.ctrDateRanger1.TabIndex = 11;
            this.ctrDateRanger1.ToDate = new System.DateTime(2014, 7, 20, 23, 59, 59, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chọn User";
            // 
            // cboUser
            // 
            this.cboUser.DataSource = this.tblUserBindingSource;
            this.cboUser.DisplayMember = "UserName";
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(74, 8);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(105, 21);
            this.cboUser.TabIndex = 9;
            this.cboUser.ValueMember = "ID";
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // viewConfigWebTableAdapter
            // 
            this.viewConfigWebTableAdapter.ClearBeforeFill = true;
            // 
            // ReportConfigWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(924, 606);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btViewAll);
            this.Controls.Add(this.ctrDateRanger1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboUser);
            this.Name = "ReportConfigWebsite";
            this.Load += new System.EventHandler(this.ReportConfigWebsite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewConfigWebBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btView;
        private DevExpress.XtraEditors.SimpleButton btExport;
        private DevExpress.XtraEditors.SimpleButton btViewAll;
        private Entities.ctrDateRanger ctrDateRanger1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUser;
        private DB dB;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private DBTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private System.Windows.Forms.BindingSource viewConfigWebBindingSource;
        private DBTableAdapters.ViewConfigWebTableAdapter viewConfigWebTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colNameType;
        private DevExpress.XtraGrid.Columns.GridColumn colNameTypeNew;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
