namespace QT.Moduls.LogJob
{
    partial class FrmLogJobData
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonExpandGroup = new DevExpress.XtraEditors.SimpleButton();
            this.checkEditLoadAll = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButtonViewLog = new DevExpress.XtraEditors.SimpleButton();
            this.textEditIDData = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrDateRanger1 = new QT.Entities.ctrDateRanger();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.logJobGridControl = new DevExpress.XtraGrid.GridControl();
            this.logJobBindingSource = new System.Windows.Forms.BindingSource();
            this.dBLogJob = new QT.Moduls.LogJob.DBLogJob();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource();
            this.colIDJob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditJobName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.jobBindingSource = new System.Windows.Forms.BindingSource();
            this.colContentJob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditTypeData = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.logJobTableAdapter = new QT.Moduls.LogJob.DBLogJobTableAdapters.LogJobTableAdapter();
            this.tblUserTableAdapter = new QT.Moduls.LogJob.DBLogJobTableAdapters.tblUserTableAdapter();
            this.jobTableAdapter = new QT.Moduls.LogJob.DBLogJobTableAdapters.JobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditLoadAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIDData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logJobGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLogJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditJobName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTypeData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonExpandGroup);
            this.panelControl1.Controls.Add(this.checkEditLoadAll);
            this.panelControl1.Controls.Add(this.simpleButtonViewLog);
            this.panelControl1.Controls.Add(this.textEditIDData);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.ctrDateRanger1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1008, 55);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButtonExpandGroup
            // 
            this.simpleButtonExpandGroup.Location = new System.Drawing.Point(793, 19);
            this.simpleButtonExpandGroup.Name = "simpleButtonExpandGroup";
            this.simpleButtonExpandGroup.Size = new System.Drawing.Size(63, 23);
            this.simpleButtonExpandGroup.TabIndex = 5;
            this.simpleButtonExpandGroup.Text = "Expand";
            this.simpleButtonExpandGroup.Click += new System.EventHandler(this.simpleButtonExpandGroup_Click);
            // 
            // checkEditLoadAll
            // 
            this.checkEditLoadAll.EditValue = true;
            this.checkEditLoadAll.Location = new System.Drawing.Point(252, 21);
            this.checkEditLoadAll.Name = "checkEditLoadAll";
            this.checkEditLoadAll.Properties.Caption = "Load All";
            this.checkEditLoadAll.Size = new System.Drawing.Size(63, 19);
            this.checkEditLoadAll.TabIndex = 4;
            // 
            // simpleButtonViewLog
            // 
            this.simpleButtonViewLog.Location = new System.Drawing.Point(900, 19);
            this.simpleButtonViewLog.Name = "simpleButtonViewLog";
            this.simpleButtonViewLog.Size = new System.Drawing.Size(96, 23);
            this.simpleButtonViewLog.TabIndex = 3;
            this.simpleButtonViewLog.Text = "ViewLog";
            this.simpleButtonViewLog.Click += new System.EventHandler(this.simpleButtonViewLog_Click);
            // 
            // textEditIDData
            // 
            this.textEditIDData.Location = new System.Drawing.Point(54, 21);
            this.textEditIDData.Name = "textEditIDData";
            this.textEditIDData.Size = new System.Drawing.Size(189, 20);
            this.textEditIDData.TabIndex = 2;
            this.textEditIDData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditIDData_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "IDData";
            // 
            // ctrDateRanger1
            // 
            this.ctrDateRanger1.FromDate = new System.DateTime(2015, 12, 1, 0, 0, 1, 0);
            this.ctrDateRanger1.Location = new System.Drawing.Point(348, 19);
            this.ctrDateRanger1.Name = "ctrDateRanger1";
            this.ctrDateRanger1.Size = new System.Drawing.Size(470, 30);
            this.ctrDateRanger1.TabIndex = 0;
            this.ctrDateRanger1.ToDate = new System.DateTime(2015, 12, 1, 23, 59, 59, 0);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.logJobGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 55);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1008, 546);
            this.panelControl2.TabIndex = 1;
            // 
            // logJobGridControl
            // 
            this.logJobGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.logJobGridControl.DataSource = this.logJobBindingSource;
            this.logJobGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logJobGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.logJobGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.logJobGridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.logJobGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.logJobGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.logJobGridControl.Location = new System.Drawing.Point(2, 2);
            this.logJobGridControl.MainView = this.gridView1;
            this.logJobGridControl.Name = "logJobGridControl";
            this.logJobGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditUser,
            this.repositoryItemLookUpEditJobName,
            this.repositoryItemLookUpEditTypeData});
            this.logJobGridControl.Size = new System.Drawing.Size(1004, 542);
            this.logJobGridControl.TabIndex = 1;
            this.logJobGridControl.UseEmbeddedNavigator = true;
            this.logJobGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // logJobBindingSource
            // 
            this.logJobBindingSource.DataMember = "LogJob";
            this.logJobBindingSource.DataSource = this.dBLogJob;
            // 
            // dBLogJob
            // 
            this.dBLogJob.DataSetName = "DBLogJob";
            this.dBLogJob.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colIDUser,
            this.colIDJob,
            this.colContentJob,
            this.colLastUpdate,
            this.colIDData,
            this.colTypeData,
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.logJobGridControl;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIDUser, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawGroupRow);
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            // 
            // colIDUser
            // 
            this.colIDUser.ColumnEdit = this.repositoryItemLookUpEditUser;
            this.colIDUser.FieldName = "IDUser";
            this.colIDUser.Name = "colIDUser";
            this.colIDUser.Visible = true;
            this.colIDUser.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEditUser
            // 
            this.repositoryItemLookUpEditUser.AutoHeight = false;
            this.repositoryItemLookUpEditUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditUser.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "UserName")});
            this.repositoryItemLookUpEditUser.DataSource = this.tblUserBindingSource;
            this.repositoryItemLookUpEditUser.DisplayMember = "UserName";
            this.repositoryItemLookUpEditUser.Name = "repositoryItemLookUpEditUser";
            this.repositoryItemLookUpEditUser.ValueMember = "ID";
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.dBLogJob;
            // 
            // colIDJob
            // 
            this.colIDJob.ColumnEdit = this.repositoryItemLookUpEditJobName;
            this.colIDJob.FieldName = "IDJob";
            this.colIDJob.Name = "colIDJob";
            this.colIDJob.Visible = true;
            this.colIDJob.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEditJobName
            // 
            this.repositoryItemLookUpEditJobName.AutoHeight = false;
            this.repositoryItemLookUpEditJobName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditJobName.DataSource = this.jobBindingSource;
            this.repositoryItemLookUpEditJobName.DisplayMember = "JobName";
            this.repositoryItemLookUpEditJobName.Name = "repositoryItemLookUpEditJobName";
            this.repositoryItemLookUpEditJobName.ValueMember = "ID";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.dBLogJob;
            // 
            // colContentJob
            // 
            this.colContentJob.FieldName = "ContentJob";
            this.colContentJob.Name = "colContentJob";
            this.colContentJob.Visible = true;
            this.colContentJob.VisibleIndex = 6;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.DisplayFormat.FormatString = "HH:mm:ss dd-MM-yyyy";
            this.colLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 3;
            // 
            // colIDData
            // 
            this.colIDData.FieldName = "IDData";
            this.colIDData.Name = "colIDData";
            this.colIDData.Visible = true;
            this.colIDData.VisibleIndex = 4;
            // 
            // colTypeData
            // 
            this.colTypeData.ColumnEdit = this.repositoryItemLookUpEditTypeData;
            this.colTypeData.FieldName = "TypeData";
            this.colTypeData.Name = "colTypeData";
            this.colTypeData.Visible = true;
            this.colTypeData.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEditTypeData
            // 
            this.repositoryItemLookUpEditTypeData.AutoHeight = false;
            this.repositoryItemLookUpEditTypeData.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditTypeData.DisplayMember = "TypeData";
            this.repositoryItemLookUpEditTypeData.Name = "repositoryItemLookUpEditTypeData";
            this.repositoryItemLookUpEditTypeData.ValueMember = "IDTypeData";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Domain";
            this.gridColumn1.FieldName = "DomainCompany";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên sản phẩm";
            this.gridColumn2.FieldName = "NameProduct";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // logJobTableAdapter
            // 
            this.logJobTableAdapter.ClearBeforeFill = true;
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLogJobData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmLogJobData";
            this.Text = "FrmLogJobData";
            this.Load += new System.EventHandler(this.FrmLogJobData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditLoadAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIDData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logJobGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLogJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditJobName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditTypeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonViewLog;
        private DevExpress.XtraEditors.TextEdit textEditIDData;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Entities.ctrDateRanger ctrDateRanger1;
        private DevExpress.XtraGrid.GridControl logJobGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditUser;
        private DevExpress.XtraGrid.Columns.GridColumn colIDJob;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditJobName;
        private DevExpress.XtraGrid.Columns.GridColumn colContentJob;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colIDData;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeData;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditTypeData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DBLogJob dBLogJob;
        private System.Windows.Forms.BindingSource logJobBindingSource;
        private DBLogJobTableAdapters.LogJobTableAdapter logJobTableAdapter;
        private DevExpress.XtraEditors.CheckEdit checkEditLoadAll;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private DBLogJobTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private DBLogJobTableAdapters.JobTableAdapter jobTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExpandGroup;
    }
}