namespace  WSS.Crawler.Product.Report
{
    partial class FrmWaitNextCrawler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWaitNextCrawler));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnPushWait = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Index = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWaitMinute = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuCompanyPlus1 = new WSS.Crawler.Product.Report.MenuCompanyPlus();
            this.updateAllowReloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAllowFindNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ckOnlyWait = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.menuCompanyPlus1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.toolStripButton2,
            this.btnPushWait,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1210, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 22);
            this.btnRefresh.Text = "WatingReload";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(115, 22);
            this.toolStripButton2.Text = "WaitingFindNew";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnPushWait
            // 
            this.btnPushWait.Image = ((System.Drawing.Image)(resources.GetObject("btnPushWait.Image")));
            this.btnPushWait.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPushWait.Name = "btnPushWait";
            this.btnPushWait.Size = new System.Drawing.Size(111, 22);
            this.btnPushWait.Text = "SetWaitingTime";
            this.btnPushWait.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1210, 620);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Index,
            this.gridColumn1,
            this.colCompanyID,
            this.gridColumn3,
            this.colWaitMinute});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // Index
            // 
            this.Index.Caption = "Index";
            this.Index.Name = "Index";
            this.Index.Visible = true;
            this.Index.VisibleIndex = 0;
            this.Index.Width = 53;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "DateRun";
            this.gridColumn1.DisplayFormat.FormatString = "yy-MM-dd HH";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "DateRun";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 460;
            // 
            // colCompanyID
            // 
            this.colCompanyID.Caption = "CompanyID";
            this.colCompanyID.FieldName = "CompanyID";
            this.colCompanyID.Name = "colCompanyID";
            this.colCompanyID.Visible = true;
            this.colCompanyID.VisibleIndex = 4;
            this.colCompanyID.Width = 464;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Wait";
            this.gridColumn3.FieldName = "Wait";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // colWaitMinute
            // 
            this.colWaitMinute.Caption = "WaitMinute";
            this.colWaitMinute.FieldName = "WaitMinute";
            this.colWaitMinute.Name = "colWaitMinute";
            this.colWaitMinute.Visible = true;
            this.colWaitMinute.VisibleIndex = 2;
            // 
            // menuCompanyPlus1
            // 
            this.menuCompanyPlus1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateAllowReloadToolStripMenuItem,
            this.updateAllowFindNewToolStripMenuItem});
            this.menuCompanyPlus1.Name = "menuCompanyPlus1";
            this.menuCompanyPlus1.Size = new System.Drawing.Size(190, 48);
            // 
            // updateAllowReloadToolStripMenuItem
            // 
            this.updateAllowReloadToolStripMenuItem.Name = "updateAllowReloadToolStripMenuItem";
            this.updateAllowReloadToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.updateAllowReloadToolStripMenuItem.Text = "UpdateAllowReload";
            this.updateAllowReloadToolStripMenuItem.Click += new System.EventHandler(this.updateAllowReloadToolStripMenuItem_Click);
            // 
            // updateAllowFindNewToolStripMenuItem
            // 
            this.updateAllowFindNewToolStripMenuItem.Name = "updateAllowFindNewToolStripMenuItem";
            this.updateAllowFindNewToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.updateAllowFindNewToolStripMenuItem.Text = "UpdateAllowFindNew";
            this.updateAllowFindNewToolStripMenuItem.Click += new System.EventHandler(this.updateAllowFindNewToolStripMenuItem_Click);
            // 
            // ckOnlyWait
            // 
            this.ckOnlyWait.AutoSize = true;
            this.ckOnlyWait.Location = new System.Drawing.Point(350, 6);
            this.ckOnlyWait.Name = "ckOnlyWait";
            this.ckOnlyWait.Size = new System.Drawing.Size(69, 17);
            this.ckOnlyWait.TabIndex = 2;
            this.ckOnlyWait.Text = "OnlyWait";
            this.ckOnlyWait.UseVisualStyleBackColor = true;
            // 
            // FrmWaitNextCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 645);
            this.Controls.Add(this.ckOnlyWait);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmWaitNextCrawler";
            this.Text = "FrmWaitNextCrawler";
            this.Load += new System.EventHandler(this.FrmWaitNextCrawler_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.menuCompanyPlus1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn Index;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ToolStripButton btnPushWait;
        private MenuCompanyPlus menuCompanyPlus1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox ckOnlyWait;
        private DevExpress.XtraGrid.Columns.GridColumn colWaitMinute;
        private System.Windows.Forms.ToolStripMenuItem updateAllowReloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAllowFindNewToolStripMenuItem;
    }
}