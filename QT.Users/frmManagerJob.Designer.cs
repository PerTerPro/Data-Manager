namespace QT.Users
{
    partial class frmManagerJob
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.userJobBindingSource = new System.Windows.Forms.BindingSource();
            this.dB = new QT.Users.DB();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateJob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userJobTableAdapter = new QT.Users.DBTableAdapters.UserJobTableAdapter();
            this.btLoad = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.btPrinter = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.userJobBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 29);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(809, 435);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // userJobBindingSource
            // 
            this.userJobBindingSource.DataMember = "UserJob";
            this.userJobBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colUserID,
            this.colJobType,
            this.colComment,
            this.colDateJob,
            this.colVote,
            this.colIDCompany,
            this.colJob,
            this.colUserName,
            this.colDomain,
            this.colMoney});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "JobType", null, "  - Tổng={0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Money", null, "Tổng tiền={0:n0}đ")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUserName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colJob, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colUserID
            // 
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            // 
            // colJobType
            // 
            this.colJobType.FieldName = "JobType";
            this.colJobType.Name = "colJobType";
            // 
            // colComment
            // 
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Visible = true;
            this.colComment.VisibleIndex = 1;
            this.colComment.Width = 191;
            // 
            // colDateJob
            // 
            this.colDateJob.FieldName = "DateJob";
            this.colDateJob.Name = "colDateJob";
            this.colDateJob.OptionsColumn.FixedWidth = true;
            this.colDateJob.Visible = true;
            this.colDateJob.VisibleIndex = 2;
            this.colDateJob.Width = 80;
            // 
            // colVote
            // 
            this.colVote.FieldName = "Vote";
            this.colVote.Name = "colVote";
            this.colVote.OptionsColumn.FixedWidth = true;
            this.colVote.Visible = true;
            this.colVote.VisibleIndex = 3;
            this.colVote.Width = 50;
            // 
            // colIDCompany
            // 
            this.colIDCompany.FieldName = "IDCompany";
            this.colIDCompany.Name = "colIDCompany";
            // 
            // colJob
            // 
            this.colJob.FieldName = "Job";
            this.colJob.Name = "colJob";
            this.colJob.OptionsColumn.FixedWidth = true;
            this.colJob.Width = 146;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.FixedWidth = true;
            this.colUserName.Width = 124;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.OptionsColumn.FixedWidth = true;
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 0;
            this.colDomain.Width = 197;
            // 
            // colMoney
            // 
            this.colMoney.DisplayFormat.FormatString = "n0";
            this.colMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMoney.FieldName = "Money";
            this.colMoney.Name = "colMoney";
            this.colMoney.OptionsColumn.AllowEdit = false;
            this.colMoney.SummaryItem.DisplayFormat = "SUM={0:n0}";
            this.colMoney.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colMoney.Visible = true;
            this.colMoney.VisibleIndex = 4;
            // 
            // userJobTableAdapter
            // 
            this.userJobTableAdapter.ClearBeforeFill = true;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(112, 2);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 4;
            this.btLoad.Text = "Load";
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(6, 3);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.EditMask = "y";
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 5;
            // 
            // btPrinter
            // 
            this.btPrinter.Location = new System.Drawing.Point(193, 2);
            this.btPrinter.Name = "btPrinter";
            this.btPrinter.Size = new System.Drawing.Size(75, 23);
            this.btPrinter.TabIndex = 4;
            this.btPrinter.Text = "Printer";
            this.btPrinter.Click += new System.EventHandler(this.btPrinter_Click);
            // 
            // frmManagerJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(809, 464);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.btPrinter);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmManagerJob";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManagerJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DB dB;
        private System.Windows.Forms.BindingSource userJobBindingSource;
        private DBTableAdapters.UserJobTableAdapter userJobTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colJobType;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;
        private DevExpress.XtraGrid.Columns.GridColumn colDateJob;
        private DevExpress.XtraGrid.Columns.GridColumn colVote;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colJob;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraEditors.SimpleButton btLoad;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.SimpleButton btPrinter;
        private DevExpress.XtraGrid.Columns.GridColumn colMoney;
    }
}
