namespace QT.Moduls.CrawlerProduct
{
    partial class FrmTrackFieldCrawler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPushAllCompany = new System.Windows.Forms.Button();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProperty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountCompanyConfiged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountProductCrawlerd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPushAllCompany);
            this.panel1.Controls.Add(this.btnRefreshData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnPushAllCompany
            // 
            this.btnPushAllCompany.Location = new System.Drawing.Point(93, 12);
            this.btnPushAllCompany.Name = "btnPushAllCompany";
            this.btnPushAllCompany.Size = new System.Drawing.Size(100, 23);
            this.btnPushAllCompany.TabIndex = 1;
            this.btnPushAllCompany.Text = "PushAllCompany";
            this.btnPushAllCompany.UseVisualStyleBackColor = true;
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Location = new System.Drawing.Point(12, 12);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshData.TabIndex = 0;
            this.btnRefreshData.Text = "RefreshData";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 44);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1068, 755);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProperty,
            this.colCountCompanyConfiged,
            this.colCountProductCrawlerd});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colProperty
            // 
            this.colProperty.Caption = "Property";
            this.colProperty.FieldName = "Property";
            this.colProperty.Name = "colProperty";
            this.colProperty.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colProperty.Visible = true;
            this.colProperty.VisibleIndex = 0;
            // 
            // colCountCompanyConfiged
            // 
            this.colCountCompanyConfiged.Caption = "CountCompanyConfiged";
            this.colCountCompanyConfiged.FieldName = "CountCompanyConfiged";
            this.colCountCompanyConfiged.Name = "colCountCompanyConfiged";
            this.colCountCompanyConfiged.Visible = true;
            this.colCountCompanyConfiged.VisibleIndex = 1;
            // 
            // colCountProductCrawlerd
            // 
            this.colCountProductCrawlerd.Caption = "CountProductCrawlerd";
            this.colCountProductCrawlerd.FieldName = "CountProductCrawlerd";
            this.colCountProductCrawlerd.Name = "colCountProductCrawlerd";
            this.colCountProductCrawlerd.Visible = true;
            this.colCountProductCrawlerd.VisibleIndex = 2;
            // 
            // FrmTrackFieldCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 799);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTrackFieldCrawler";
            this.Text = "FrmTrackFieldCrawler";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPushAllCompany;
        private System.Windows.Forms.Button btnRefreshData;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProperty;
        private DevExpress.XtraGrid.Columns.GridColumn colCountCompanyConfiged;
        private DevExpress.XtraGrid.Columns.GridColumn colCountProductCrawlerd;
    }
}