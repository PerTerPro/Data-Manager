namespace QT.Moduls.CrawlerProduct
{
    partial class FrmTrustedFollow
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
            this.btnPushCompanyInfo_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlCompanyTrusted = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrusted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEditTrusted = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colFolder = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompanyTrusted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditTrusted)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPushCompanyInfo_Reset);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(597, 47);
            this.panelControl1.TabIndex = 0;
            // 
            // btnPushCompanyInfo_Reset
            // 
            this.btnPushCompanyInfo_Reset.Location = new System.Drawing.Point(437, 12);
            this.btnPushCompanyInfo_Reset.Name = "btnPushCompanyInfo_Reset";
            this.btnPushCompanyInfo_Reset.Size = new System.Drawing.Size(148, 28);
            this.btnPushCompanyInfo_Reset.TabIndex = 0;
            this.btnPushCompanyInfo_Reset.Text = "Push Company Info ";
            this.btnPushCompanyInfo_Reset.Click += new System.EventHandler(this.btnPushCompanyInfo_Reset_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlCompanyTrusted);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 47);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(597, 478);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControlCompanyTrusted
            // 
            this.gridControlCompanyTrusted.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlCompanyTrusted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCompanyTrusted.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlCompanyTrusted.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlCompanyTrusted.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlCompanyTrusted.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlCompanyTrusted.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlCompanyTrusted.Location = new System.Drawing.Point(2, 2);
            this.gridControlCompanyTrusted.MainView = this.gridView1;
            this.gridControlCompanyTrusted.Name = "gridControlCompanyTrusted";
            this.gridControlCompanyTrusted.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEditTrusted});
            this.gridControlCompanyTrusted.Size = new System.Drawing.Size(593, 474);
            this.gridControlCompanyTrusted.TabIndex = 0;
            this.gridControlCompanyTrusted.UseEmbeddedNavigator = true;
            this.gridControlCompanyTrusted.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDomain,
            this.colTrusted,
            this.colFolder});
            this.gridView1.GridControl = this.gridControlCompanyTrusted;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.Caption = "CompanyId";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 140;
            // 
            // colDomain
            // 
            this.colDomain.Caption = "Domain";
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 1;
            this.colDomain.Width = 210;
            // 
            // colTrusted
            // 
            this.colTrusted.Caption = "Trusted";
            this.colTrusted.ColumnEdit = this.repositoryItemCheckEditTrusted;
            this.colTrusted.FieldName = "Trusted";
            this.colTrusted.Name = "colTrusted";
            this.colTrusted.Visible = true;
            this.colTrusted.VisibleIndex = 3;
            this.colTrusted.Width = 50;
            // 
            // repositoryItemCheckEditTrusted
            // 
            this.repositoryItemCheckEditTrusted.AutoHeight = false;
            this.repositoryItemCheckEditTrusted.Name = "repositoryItemCheckEditTrusted";
            // 
            // colFolder
            // 
            this.colFolder.Caption = "Folder";
            this.colFolder.FieldName = "Folder";
            this.colFolder.Name = "colFolder";
            this.colFolder.Visible = true;
            this.colFolder.VisibleIndex = 2;
            this.colFolder.Width = 174;
            // 
            // FrmTrustedFollow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 525);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmTrustedFollow";
            this.Text = "FrmTrustedFollow";
            this.Load += new System.EventHandler(this.FrmTrustedFollow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompanyTrusted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditTrusted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControlCompanyTrusted;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colTrusted;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditTrusted;
        private DevExpress.XtraEditors.SimpleButton btnPushCompanyInfo_Reset;
        private DevExpress.XtraGrid.Columns.GridColumn colFolder;
    }
}