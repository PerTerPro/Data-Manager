namespace QT.Moduls.CrawlerProduct
{
    partial class FrmCheckConfigError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckConfigError));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grcListError = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEditFix = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcListError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEditFix)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(688, 53);
            this.panelControl1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(5, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grcListError);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 53);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(688, 263);
            this.panelControl2.TabIndex = 1;
            // 
            // grcListError
            // 
            this.grcListError.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcListError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcListError.Location = new System.Drawing.Point(2, 2);
            this.grcListError.MainView = this.gridView1;
            this.grcListError.Name = "grcListError";
            this.grcListError.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEditFix});
            this.grcListError.Size = new System.Drawing.Size(684, 259);
            this.grcListError.TabIndex = 0;
            this.grcListError.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grcListError.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grcListError_MouseDoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDomain,
            this.colWebsite,
            this.colTotalValid,
            this.colMaxValid,
            this.colFix});
            this.gridView1.GridControl = this.grcListError;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colDomain
            // 
            this.colDomain.Caption = "Domain";
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 1;
            // 
            // colWebsite
            // 
            this.colWebsite.Caption = "Website";
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 2;
            // 
            // colTotalValid
            // 
            this.colTotalValid.Caption = "TotalValid";
            this.colTotalValid.FieldName = "TotalValid";
            this.colTotalValid.Name = "colTotalValid";
            this.colTotalValid.Visible = true;
            this.colTotalValid.VisibleIndex = 3;
            // 
            // colMaxValid
            // 
            this.colMaxValid.Caption = "MaxValid";
            this.colMaxValid.FieldName = "MaxValid";
            this.colMaxValid.Name = "colMaxValid";
            this.colMaxValid.Visible = true;
            this.colMaxValid.VisibleIndex = 4;
            // 
            // colFix
            // 
            this.colFix.Caption = "Fix";
            this.colFix.ColumnEdit = this.repositoryItemHyperLinkEditFix;
            this.colFix.Name = "colFix";
            this.colFix.Visible = true;
            this.colFix.VisibleIndex = 5;
            // 
            // repositoryItemHyperLinkEditFix
            // 
            this.repositoryItemHyperLinkEditFix.AutoHeight = false;
            this.repositoryItemHyperLinkEditFix.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemHyperLinkEditFix.Image")));
            this.repositoryItemHyperLinkEditFix.Name = "repositoryItemHyperLinkEditFix";
            // 
            // FrmCheckConfigError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 316);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCheckConfigError";
            this.Text = "FrmCheckConfigError";
            this.Load += new System.EventHandler(this.FrmCheckConfigError_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcListError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEditFix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grcListError;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValid;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxValid;
        private DevExpress.XtraGrid.Columns.GridColumn colFix;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEditFix;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}