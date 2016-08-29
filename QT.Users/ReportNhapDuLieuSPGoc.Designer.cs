namespace QT.Users
{
    partial class ReportNhapDuLieuSPGoc
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
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource();
            this.dB = new QT.Users.DB();
            this.label1 = new System.Windows.Forms.Label();
            this.tblUserTableAdapter = new QT.Users.DBTableAdapters.tblUserTableAdapter();
            this.ctrDateRanger1 = new QT.Entities.ctrDateRanger();
            this.btViewAll = new DevExpress.XtraEditors.SimpleButton();
            this.btView = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.viewNhapLieuSPGocBindingSource = new System.Windows.Forms.BindingSource();
            this.dBPhanSP = new QT.Users.DBPhanSP();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuyenMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewNhapLieuSPGocTableAdapter = new QT.Users.DBPhanSPTableAdapters.ViewNhapLieuSPGocTableAdapter();
            this.btExport = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableAdapterManager = new QT.Users.DBTableAdapters.TableAdapterManager();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNhapLieuSPGocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPhanSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboUser
            // 
            this.cboUser.DataSource = this.tblUserBindingSource;
            this.cboUser.DisplayMember = "UserName";
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(76, 10);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(105, 21);
            this.cboUser.TabIndex = 0;
            this.cboUser.ValueMember = "ID";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn User";
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // ctrDateRanger1
            // 
            this.ctrDateRanger1.FromDate = new System.DateTime(2014, 7, 20, 0, 0, 1, 0);
            this.ctrDateRanger1.Location = new System.Drawing.Point(314, 7);
            this.ctrDateRanger1.Name = "ctrDateRanger1";
            this.ctrDateRanger1.Size = new System.Drawing.Size(442, 27);
            this.ctrDateRanger1.TabIndex = 2;
            this.ctrDateRanger1.ToDate = new System.DateTime(2014, 7, 20, 23, 59, 59, 0);
            // 
            // btViewAll
            // 
            this.btViewAll.Location = new System.Drawing.Point(116, 37);
            this.btViewAll.Name = "btViewAll";
            this.btViewAll.Size = new System.Drawing.Size(102, 23);
            this.btViewAll.TabIndex = 3;
            this.btViewAll.Text = "Xem toàn bộ";
            this.btViewAll.Click += new System.EventHandler(this.btViewAll_Click);
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(8, 37);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(102, 23);
            this.btView.TabIndex = 3;
            this.btView.Text = "Xem theo user";
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.viewNhapLieuSPGocBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(2, 66);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(921, 437);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // viewNhapLieuSPGocBindingSource
            // 
            this.viewNhapLieuSPGocBindingSource.DataMember = "ViewNhapLieuSPGoc";
            this.viewNhapLieuSPGocBindingSource.DataSource = this.dBPhanSP;
            // 
            // dBPhanSP
            // 
            this.dBPhanSP.DataSetName = "DBPhanSP";
            this.dBPhanSP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDStatus,
            this.colNameStatus,
            this.colChuyenMuc,
            this.colIDProduct,
            this.colNameProduct,
            this.colLastUpdate,
            this.colUserName,
            this.colLastUpdate1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "IDStatus", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUserName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNameStatus, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIDStatus
            // 
            this.colIDStatus.FieldName = "IDStatus";
            this.colIDStatus.Name = "colIDStatus";
            // 
            // colNameStatus
            // 
            this.colNameStatus.FieldName = "NameStatus";
            this.colNameStatus.Name = "colNameStatus";
            // 
            // colChuyenMuc
            // 
            this.colChuyenMuc.FieldName = "ChuyenMuc";
            this.colChuyenMuc.Name = "colChuyenMuc";
            this.colChuyenMuc.OptionsColumn.FixedWidth = true;
            this.colChuyenMuc.Visible = true;
            this.colChuyenMuc.VisibleIndex = 0;
            this.colChuyenMuc.Width = 163;
            // 
            // colIDProduct
            // 
            this.colIDProduct.FieldName = "IDProduct";
            this.colIDProduct.Name = "colIDProduct";
            this.colIDProduct.OptionsColumn.FixedWidth = true;
            this.colIDProduct.Visible = true;
            this.colIDProduct.VisibleIndex = 1;
            this.colIDProduct.Width = 100;
            // 
            // colNameProduct
            // 
            this.colNameProduct.FieldName = "NameProduct";
            this.colNameProduct.Name = "colNameProduct";
            this.colNameProduct.Visible = true;
            this.colNameProduct.VisibleIndex = 2;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.OptionsColumn.FixedWidth = true;
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 3;
            this.colLastUpdate.Width = 150;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            // 
            // colLastUpdate1
            // 
            this.colLastUpdate1.Caption = "Times";
            this.colLastUpdate1.DisplayFormat.FormatString = "hh:mm";
            this.colLastUpdate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUpdate1.FieldName = "LastUpdate";
            this.colLastUpdate1.Name = "colLastUpdate1";
            this.colLastUpdate1.OptionsColumn.FixedWidth = true;
            this.colLastUpdate1.Visible = true;
            this.colLastUpdate1.VisibleIndex = 4;
            // 
            // viewNhapLieuSPGocTableAdapter
            // 
            this.viewNhapLieuSPGocTableAdapter.ClearBeforeFill = true;
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(224, 37);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(102, 23);
            this.btExport.TabIndex = 3;
            this.btExport.Text = "Export";
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
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
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "UserName", true));
            this.userNameTextBox.Enabled = false;
            this.userNameTextBox.Location = new System.Drawing.Point(187, 11);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.userNameTextBox.TabIndex = 8;
            // 
            // ReportNhapDuLieuSPGoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(925, 504);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btViewAll);
            this.Controls.Add(this.ctrDateRanger1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboUser);
            this.Name = "ReportNhapDuLieuSPGoc";
            this.Load += new System.EventHandler(this.ReportNhapDuLieuSPGoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewNhapLieuSPGocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPhanSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Label label1;
        private DB dB;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private DBTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private Entities.ctrDateRanger ctrDateRanger1;
        private DevExpress.XtraEditors.SimpleButton btViewAll;
        private DevExpress.XtraEditors.SimpleButton btView;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DBPhanSP dBPhanSP;
        private System.Windows.Forms.BindingSource viewNhapLieuSPGocBindingSource;
        private DBPhanSPTableAdapters.ViewNhapLieuSPGocTableAdapter viewNhapLieuSPGocTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colNameStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colChuyenMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colNameProduct;
        private DevExpress.XtraEditors.SimpleButton btExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userNameTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate1;
    }
}
