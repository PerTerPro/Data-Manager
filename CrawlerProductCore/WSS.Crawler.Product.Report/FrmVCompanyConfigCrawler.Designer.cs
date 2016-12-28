namespace WSS.Crawler.Product.Report
{
    partial class FrmVCompanyConfigCrawler
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.v_Company_ConfigCrawlerGridControl = new DevExpress.XtraGrid.GridControl();
            this.v_Company_ConfigCrawlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsQT2 = new WSS.Crawler.Product.Report.DS.DsQT2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinHourReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinHourFindNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCrawlerFindNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastEndCrawlerFindNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCrawlerReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastEndCrawlerReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowFindNew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowReload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colh_reload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colh_findnew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colm_run_reload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colm_run_findnew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.v_Company_CrawlerFailGridControl = new DevExpress.XtraGrid.GridControl();
            this.v_Company_CrawlerFailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinHourReload1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinHourFindNew1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCrawlerFindNew1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastEndCrawlerFindNew1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastCrawlerReload1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastEndCrawlerReload1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowFindNew1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowReload1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colh_reload1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colh_findnew1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colm_run_reload1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colm_run_findnew1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_Company_ConfigCrawlerTableAdapter = new WSS.Crawler.Product.Report.DS.DsQT2TableAdapters.V_Company_ConfigCrawlerTableAdapter();
            this.tableAdapterManager = new WSS.Crawler.Product.Report.DS.DsQT2TableAdapters.TableAdapterManager();
            this.v_Company_CrawlerFailTableAdapter = new WSS.Crawler.Product.Report.DS.DsQT2TableAdapters.V_Company_CrawlerFailTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_ConfigCrawlerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_ConfigCrawlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_CrawlerFailGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_CrawlerFailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1276, 734);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.v_Company_ConfigCrawlerGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1270, 706);
            this.xtraTabPage1.Text = "ReportRun";
            // 
            // v_Company_ConfigCrawlerGridControl
            // 
            this.v_Company_ConfigCrawlerGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.v_Company_ConfigCrawlerGridControl.DataSource = this.v_Company_ConfigCrawlerBindingSource;
            this.v_Company_ConfigCrawlerGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_Company_ConfigCrawlerGridControl.Location = new System.Drawing.Point(0, 0);
            this.v_Company_ConfigCrawlerGridControl.MainView = this.gridView1;
            this.v_Company_ConfigCrawlerGridControl.Name = "v_Company_ConfigCrawlerGridControl";
            this.v_Company_ConfigCrawlerGridControl.Size = new System.Drawing.Size(1270, 706);
            this.v_Company_ConfigCrawlerGridControl.TabIndex = 0;
            this.v_Company_ConfigCrawlerGridControl.UseEmbeddedNavigator = true;
            this.v_Company_ConfigCrawlerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // v_Company_ConfigCrawlerBindingSource
            // 
            this.v_Company_ConfigCrawlerBindingSource.DataMember = "V_Company_ConfigCrawler";
            this.v_Company_ConfigCrawlerBindingSource.DataSource = this.dsQT2;
            // 
            // dsQT2
            // 
            this.dsQT2.DataSetName = "DsQT2";
            this.dsQT2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDomain,
            this.colMinHourReload,
            this.colMinHourFindNew,
            this.colLastCrawlerFindNew,
            this.colLastEndCrawlerFindNew,
            this.colLastCrawlerReload,
            this.colLastEndCrawlerReload,
            this.colAllowFindNew,
            this.colAllowReload,
            this.colTotalProduct,
            this.colh_reload,
            this.colh_findnew,
            this.colm_run_reload,
            this.colm_run_findnew});
            this.gridView1.GridControl = this.v_Company_ConfigCrawlerGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 1;
            // 
            // colMinHourReload
            // 
            this.colMinHourReload.FieldName = "MinHourReload";
            this.colMinHourReload.Name = "colMinHourReload";
            this.colMinHourReload.Visible = true;
            this.colMinHourReload.VisibleIndex = 2;
            // 
            // colMinHourFindNew
            // 
            this.colMinHourFindNew.FieldName = "MinHourFindNew";
            this.colMinHourFindNew.Name = "colMinHourFindNew";
            this.colMinHourFindNew.Visible = true;
            this.colMinHourFindNew.VisibleIndex = 3;
            // 
            // colLastCrawlerFindNew
            // 
            this.colLastCrawlerFindNew.FieldName = "LastCrawlerFindNew";
            this.colLastCrawlerFindNew.Name = "colLastCrawlerFindNew";
            this.colLastCrawlerFindNew.Visible = true;
            this.colLastCrawlerFindNew.VisibleIndex = 4;
            // 
            // colLastEndCrawlerFindNew
            // 
            this.colLastEndCrawlerFindNew.FieldName = "LastEndCrawlerFindNew";
            this.colLastEndCrawlerFindNew.Name = "colLastEndCrawlerFindNew";
            this.colLastEndCrawlerFindNew.Visible = true;
            this.colLastEndCrawlerFindNew.VisibleIndex = 5;
            // 
            // colLastCrawlerReload
            // 
            this.colLastCrawlerReload.FieldName = "LastCrawlerReload";
            this.colLastCrawlerReload.Name = "colLastCrawlerReload";
            this.colLastCrawlerReload.Visible = true;
            this.colLastCrawlerReload.VisibleIndex = 6;
            // 
            // colLastEndCrawlerReload
            // 
            this.colLastEndCrawlerReload.FieldName = "LastEndCrawlerReload";
            this.colLastEndCrawlerReload.Name = "colLastEndCrawlerReload";
            this.colLastEndCrawlerReload.Visible = true;
            this.colLastEndCrawlerReload.VisibleIndex = 7;
            // 
            // colAllowFindNew
            // 
            this.colAllowFindNew.FieldName = "AllowFindNew";
            this.colAllowFindNew.Name = "colAllowFindNew";
            this.colAllowFindNew.Visible = true;
            this.colAllowFindNew.VisibleIndex = 8;
            // 
            // colAllowReload
            // 
            this.colAllowReload.FieldName = "AllowReload";
            this.colAllowReload.Name = "colAllowReload";
            this.colAllowReload.Visible = true;
            this.colAllowReload.VisibleIndex = 9;
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 10;
            // 
            // colh_reload
            // 
            this.colh_reload.FieldName = "h_reload";
            this.colh_reload.Name = "colh_reload";
            this.colh_reload.OptionsColumn.ReadOnly = true;
            this.colh_reload.Visible = true;
            this.colh_reload.VisibleIndex = 11;
            // 
            // colh_findnew
            // 
            this.colh_findnew.FieldName = "h_findnew";
            this.colh_findnew.Name = "colh_findnew";
            this.colh_findnew.OptionsColumn.ReadOnly = true;
            this.colh_findnew.Visible = true;
            this.colh_findnew.VisibleIndex = 12;
            // 
            // colm_run_reload
            // 
            this.colm_run_reload.FieldName = "m_run_reload";
            this.colm_run_reload.Name = "colm_run_reload";
            this.colm_run_reload.OptionsColumn.ReadOnly = true;
            this.colm_run_reload.Visible = true;
            this.colm_run_reload.VisibleIndex = 13;
            // 
            // colm_run_findnew
            // 
            this.colm_run_findnew.FieldName = "m_run_findnew";
            this.colm_run_findnew.Name = "colm_run_findnew";
            this.colm_run_findnew.OptionsColumn.ReadOnly = true;
            this.colm_run_findnew.Visible = true;
            this.colm_run_findnew.VisibleIndex = 14;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.v_Company_CrawlerFailGridControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1316, 706);
            this.xtraTabPage2.Text = "WaitCrawler";
            // 
            // v_Company_CrawlerFailGridControl
            // 
            this.v_Company_CrawlerFailGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.v_Company_CrawlerFailGridControl.DataSource = this.v_Company_CrawlerFailBindingSource;
            this.v_Company_CrawlerFailGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_Company_CrawlerFailGridControl.Location = new System.Drawing.Point(0, 0);
            this.v_Company_CrawlerFailGridControl.MainView = this.gridView2;
            this.v_Company_CrawlerFailGridControl.Name = "v_Company_CrawlerFailGridControl";
            this.v_Company_CrawlerFailGridControl.Size = new System.Drawing.Size(1316, 706);
            this.v_Company_CrawlerFailGridControl.TabIndex = 0;
            this.v_Company_CrawlerFailGridControl.UseEmbeddedNavigator = true;
            this.v_Company_CrawlerFailGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // v_Company_CrawlerFailBindingSource
            // 
            this.v_Company_CrawlerFailBindingSource.DataMember = "V_Company_CrawlerFail";
            this.v_Company_CrawlerFailBindingSource.DataSource = this.dsQT2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colDomain1,
            this.colMinHourReload1,
            this.colMinHourFindNew1,
            this.colLastCrawlerFindNew1,
            this.colLastEndCrawlerFindNew1,
            this.colLastCrawlerReload1,
            this.colLastEndCrawlerReload1,
            this.colAllowFindNew1,
            this.colAllowReload1,
            this.colTotalProduct1,
            this.colh_reload1,
            this.colh_findnew1,
            this.colm_run_reload1,
            this.colm_run_findnew1});
            this.gridView2.GridControl = this.v_Company_CrawlerFailGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            // 
            // colDomain1
            // 
            this.colDomain1.FieldName = "Domain";
            this.colDomain1.Name = "colDomain1";
            this.colDomain1.Visible = true;
            this.colDomain1.VisibleIndex = 1;
            // 
            // colMinHourReload1
            // 
            this.colMinHourReload1.FieldName = "MinHourReload";
            this.colMinHourReload1.Name = "colMinHourReload1";
            this.colMinHourReload1.Visible = true;
            this.colMinHourReload1.VisibleIndex = 2;
            // 
            // colMinHourFindNew1
            // 
            this.colMinHourFindNew1.FieldName = "MinHourFindNew";
            this.colMinHourFindNew1.Name = "colMinHourFindNew1";
            this.colMinHourFindNew1.Visible = true;
            this.colMinHourFindNew1.VisibleIndex = 3;
            // 
            // colLastCrawlerFindNew1
            // 
            this.colLastCrawlerFindNew1.FieldName = "LastCrawlerFindNew";
            this.colLastCrawlerFindNew1.Name = "colLastCrawlerFindNew1";
            this.colLastCrawlerFindNew1.Visible = true;
            this.colLastCrawlerFindNew1.VisibleIndex = 4;
            // 
            // colLastEndCrawlerFindNew1
            // 
            this.colLastEndCrawlerFindNew1.FieldName = "LastEndCrawlerFindNew";
            this.colLastEndCrawlerFindNew1.Name = "colLastEndCrawlerFindNew1";
            this.colLastEndCrawlerFindNew1.Visible = true;
            this.colLastEndCrawlerFindNew1.VisibleIndex = 5;
            // 
            // colLastCrawlerReload1
            // 
            this.colLastCrawlerReload1.FieldName = "LastCrawlerReload";
            this.colLastCrawlerReload1.Name = "colLastCrawlerReload1";
            this.colLastCrawlerReload1.Visible = true;
            this.colLastCrawlerReload1.VisibleIndex = 6;
            // 
            // colLastEndCrawlerReload1
            // 
            this.colLastEndCrawlerReload1.FieldName = "LastEndCrawlerReload";
            this.colLastEndCrawlerReload1.Name = "colLastEndCrawlerReload1";
            this.colLastEndCrawlerReload1.Visible = true;
            this.colLastEndCrawlerReload1.VisibleIndex = 7;
            // 
            // colAllowFindNew1
            // 
            this.colAllowFindNew1.FieldName = "AllowFindNew";
            this.colAllowFindNew1.Name = "colAllowFindNew1";
            this.colAllowFindNew1.Visible = true;
            this.colAllowFindNew1.VisibleIndex = 8;
            // 
            // colAllowReload1
            // 
            this.colAllowReload1.FieldName = "AllowReload";
            this.colAllowReload1.Name = "colAllowReload1";
            this.colAllowReload1.Visible = true;
            this.colAllowReload1.VisibleIndex = 9;
            // 
            // colTotalProduct1
            // 
            this.colTotalProduct1.FieldName = "TotalProduct";
            this.colTotalProduct1.Name = "colTotalProduct1";
            this.colTotalProduct1.Visible = true;
            this.colTotalProduct1.VisibleIndex = 10;
            // 
            // colh_reload1
            // 
            this.colh_reload1.FieldName = "h_reload";
            this.colh_reload1.Name = "colh_reload1";
            this.colh_reload1.OptionsColumn.ReadOnly = true;
            this.colh_reload1.Visible = true;
            this.colh_reload1.VisibleIndex = 11;
            // 
            // colh_findnew1
            // 
            this.colh_findnew1.FieldName = "h_findnew";
            this.colh_findnew1.Name = "colh_findnew1";
            this.colh_findnew1.OptionsColumn.ReadOnly = true;
            this.colh_findnew1.Visible = true;
            this.colh_findnew1.VisibleIndex = 12;
            // 
            // colm_run_reload1
            // 
            this.colm_run_reload1.FieldName = "m_run_reload";
            this.colm_run_reload1.Name = "colm_run_reload1";
            this.colm_run_reload1.OptionsColumn.ReadOnly = true;
            this.colm_run_reload1.Visible = true;
            this.colm_run_reload1.VisibleIndex = 13;
            // 
            // colm_run_findnew1
            // 
            this.colm_run_findnew1.FieldName = "m_run_findnew";
            this.colm_run_findnew1.Name = "colm_run_findnew1";
            this.colm_run_findnew1.OptionsColumn.ReadOnly = true;
            this.colm_run_findnew1.Visible = true;
            this.colm_run_findnew1.VisibleIndex = 14;
            // 
            // v_Company_ConfigCrawlerTableAdapter
            // 
            this.v_Company_ConfigCrawlerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WSS.Crawler.Product.Report.DS.DsQT2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_Company_CrawlerFailTableAdapter
            // 
            this.v_Company_CrawlerFailTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(8, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "RefreshData";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 39);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xtraTabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 734);
            this.panel2.TabIndex = 3;
            // 
            // FrmVCompanyConfigCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 773);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVCompanyConfigCrawler";
            this.Text = "FrmVCompanyConfigCrawler";
            this.Load += new System.EventHandler(this.FrmVCompanyConfigCrawler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_ConfigCrawlerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_ConfigCrawlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_CrawlerFailGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_CrawlerFailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DS.DsQT2 dsQT2;
        private System.Windows.Forms.BindingSource v_Company_ConfigCrawlerBindingSource;
        private DS.DsQT2TableAdapters.V_Company_ConfigCrawlerTableAdapter v_Company_ConfigCrawlerTableAdapter;
        private DS.DsQT2TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl v_Company_ConfigCrawlerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colMinHourReload;
        private DevExpress.XtraGrid.Columns.GridColumn colMinHourFindNew;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCrawlerFindNew;
        private DevExpress.XtraGrid.Columns.GridColumn colLastEndCrawlerFindNew;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCrawlerReload;
        private DevExpress.XtraGrid.Columns.GridColumn colLastEndCrawlerReload;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowFindNew;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowReload;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colh_reload;
        private DevExpress.XtraGrid.Columns.GridColumn colh_findnew;
        private DevExpress.XtraGrid.Columns.GridColumn colm_run_reload;
        private DevExpress.XtraGrid.Columns.GridColumn colm_run_findnew;
        private System.Windows.Forms.BindingSource v_Company_CrawlerFailBindingSource;
        private DS.DsQT2TableAdapters.V_Company_CrawlerFailTableAdapter v_Company_CrawlerFailTableAdapter;
        private DevExpress.XtraGrid.GridControl v_Company_CrawlerFailGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain1;
        private DevExpress.XtraGrid.Columns.GridColumn colMinHourReload1;
        private DevExpress.XtraGrid.Columns.GridColumn colMinHourFindNew1;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCrawlerFindNew1;
        private DevExpress.XtraGrid.Columns.GridColumn colLastEndCrawlerFindNew1;
        private DevExpress.XtraGrid.Columns.GridColumn colLastCrawlerReload1;
        private DevExpress.XtraGrid.Columns.GridColumn colLastEndCrawlerReload1;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowFindNew1;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowReload1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct1;
        private DevExpress.XtraGrid.Columns.GridColumn colh_reload1;
        private DevExpress.XtraGrid.Columns.GridColumn colh_findnew1;
        private DevExpress.XtraGrid.Columns.GridColumn colm_run_reload1;
        private DevExpress.XtraGrid.Columns.GridColumn colm_run_findnew1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}