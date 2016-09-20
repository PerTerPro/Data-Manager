namespace WSS.Crawler.Product.Report
{
    partial class FrmViewProductInCache
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHashChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHashImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHashDuplicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewHistoryChangeProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompanyPlus1 = new WSS.Crawler.Product.Report.MenuCompanyPlus();
            this.viewScoreLastUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1136, 683);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHashChange,
            this.colHashImage,
            this.colHashDuplicate,
            this.colPrice,
            this.colurl,
            this.colId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colHashChange
            // 
            this.colHashChange.Caption = "HashChange";
            this.colHashChange.FieldName = "HashChange";
            this.colHashChange.Name = "colHashChange";
            this.colHashChange.Visible = true;
            this.colHashChange.VisibleIndex = 0;
            // 
            // colHashImage
            // 
            this.colHashImage.Caption = "HashImage";
            this.colHashImage.FieldName = "HashImage";
            this.colHashImage.Name = "colHashImage";
            this.colHashImage.Visible = true;
            this.colHashImage.VisibleIndex = 1;
            // 
            // colHashDuplicate
            // 
            this.colHashDuplicate.Caption = "HashDuplicate";
            this.colHashDuplicate.FieldName = "HashDuplicate";
            this.colHashDuplicate.Name = "colHashDuplicate";
            this.colHashDuplicate.Visible = true;
            this.colHashDuplicate.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // colurl
            // 
            this.colurl.Caption = "url";
            this.colurl.FieldName = "url";
            this.colurl.Name = "colurl";
            this.colurl.Visible = true;
            this.colurl.VisibleIndex = 4;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHistoryChangeProductToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewHistoryChangeProductToolStripMenuItem
            // 
            this.viewHistoryChangeProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewScoreLastUpdateToolStripMenuItem});
            this.viewHistoryChangeProductToolStripMenuItem.Name = "viewHistoryChangeProductToolStripMenuItem";
            this.viewHistoryChangeProductToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.viewHistoryChangeProductToolStripMenuItem.Text = "ViewHistoryChangeProduct";
            this.viewHistoryChangeProductToolStripMenuItem.Click += new System.EventHandler(this.viewHistoryChangeProductToolStripMenuItem_Click);
            // 
            // menuCompanyPlus1
            // 
            this.menuCompanyPlus1.Name = "menuCompanyPlus1";
            this.menuCompanyPlus1.Size = new System.Drawing.Size(61, 4);
            // 
            // viewScoreLastUpdateToolStripMenuItem
            // 
            this.viewScoreLastUpdateToolStripMenuItem.Name = "viewScoreLastUpdateToolStripMenuItem";
            this.viewScoreLastUpdateToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewScoreLastUpdateToolStripMenuItem.Text = "ViewScoreLastUpdate";
            this.viewScoreLastUpdateToolStripMenuItem.Click += new System.EventHandler(this.viewScoreLastUpdateToolStripMenuItem_Click);
            // 
            // FrmViewProductInCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 707);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmViewProductInCache";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm lưu trên cache";
            this.Load += new System.EventHandler(this.FrmViewProductInCache_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryChangeProductToolStripMenuItem;
        private MenuCompanyPlus menuCompanyPlus1;
        private DevExpress.XtraGrid.Columns.GridColumn colHashChange;
        private DevExpress.XtraGrid.Columns.GridColumn colHashImage;
        private DevExpress.XtraGrid.Columns.GridColumn colHashDuplicate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colurl;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private System.Windows.Forms.ToolStripMenuItem viewScoreLastUpdateToolStripMenuItem;
    }
}