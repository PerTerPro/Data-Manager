namespace WSS.Crawler.Product.Report
{
    partial class FrmViewDetailSessionFN
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_log = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIs_ok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSession = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(752, 659);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(748, 655);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct_id,
            this.colCrc,
            this.colDate_log,
            this.colIs_ok,
            this.colSession,
            this.colUrl});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colProduct_id
            // 
            this.colProduct_id.Caption = "product_id";
            this.colProduct_id.FieldName = "Product_Id";
            this.colProduct_id.Name = "colProduct_id";
            // 
            // colCrc
            // 
            this.colCrc.Caption = "crc";
            this.colCrc.FieldName = "CRC";
            this.colCrc.Name = "colCrc";
            // 
            // colDate_log
            // 
            this.colDate_log.Caption = "date_log";
            this.colDate_log.FieldName = "Date_Log_long";
            this.colDate_log.Name = "colDate_log";
            // 
            // colIs_ok
            // 
            this.colIs_ok.Caption = "is_ok";
            this.colIs_ok.FieldName = "is_OK";
            this.colIs_ok.Name = "colIs_ok";
            // 
            // colSession
            // 
            this.colSession.Caption = "session";
            this.colSession.FieldName = "Session";
            this.colSession.Name = "colSession";
            // 
            // colUrl
            // 
            this.colUrl.Caption = "Detail_Url";
            this.colUrl.FieldName = "Detail_Url";
            this.colUrl.Name = "colUrl";
            this.colUrl.Visible = true;
            this.colUrl.VisibleIndex = 0;
            // 
            // FrmViewDetailSessionFN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 659);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmViewDetailSessionFN";
            this.Text = "FrmViewDetailSessionFN";
            this.Load += new System.EventHandler(this.FrmViewDetailSessionFN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct_id;
        private DevExpress.XtraGrid.Columns.GridColumn colCrc;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_log;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_ok;
        private DevExpress.XtraGrid.Columns.GridColumn colSession;
        private DevExpress.XtraGrid.Columns.GridColumn colUrl;
    }
}