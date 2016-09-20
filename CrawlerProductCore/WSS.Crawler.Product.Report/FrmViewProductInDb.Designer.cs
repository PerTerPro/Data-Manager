namespace WSS.Crawler.Product.Report
{
    partial class FrmViewProductInDb
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
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ImageUrls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Valid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IsNews = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ImagePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_OriginPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_HashName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuCompanyPlus1 = new WSS.Crawler.Product.Report.MenuCompanyPlus();
            this.col_VAT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1075, 549);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_Name,
            this.col_Price,
            this.col_ImageUrls,
            this.col_Valid,
            this.col_IsNews,
            this.col_ImagePath,
            this.colLastUpdate,
            this.colDetailUrl,
            this.col_OriginPrice,
            this.col_HashName,
            this.col_VAT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // col_id
            // 
            this.col_id.Caption = "id";
            this.col_id.FieldName = "ID";
            this.col_id.Name = "col_id";
            this.col_id.Visible = true;
            this.col_id.VisibleIndex = 0;
            // 
            // col_Name
            // 
            this.col_Name.Caption = "Name";
            this.col_Name.FieldName = "Name";
            this.col_Name.Name = "col_Name";
            this.col_Name.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.col_Name.Visible = true;
            this.col_Name.VisibleIndex = 1;
            // 
            // col_Price
            // 
            this.col_Price.Caption = "Price";
            this.col_Price.FieldName = "Price";
            this.col_Price.Name = "col_Price";
            this.col_Price.Visible = true;
            this.col_Price.VisibleIndex = 2;
            // 
            // col_ImageUrls
            // 
            this.col_ImageUrls.Caption = "ImageUrls";
            this.col_ImageUrls.FieldName = "ImageUrls";
            this.col_ImageUrls.Name = "col_ImageUrls";
            this.col_ImageUrls.Visible = true;
            this.col_ImageUrls.VisibleIndex = 3;
            // 
            // col_Valid
            // 
            this.col_Valid.Caption = "Valid";
            this.col_Valid.FieldName = "Valid";
            this.col_Valid.Name = "col_Valid";
            this.col_Valid.Visible = true;
            this.col_Valid.VisibleIndex = 4;
            // 
            // col_IsNews
            // 
            this.col_IsNews.Caption = "IsNews";
            this.col_IsNews.FieldName = "IsNews";
            this.col_IsNews.Name = "col_IsNews";
            this.col_IsNews.Visible = true;
            this.col_IsNews.VisibleIndex = 5;
            // 
            // col_ImagePath
            // 
            this.col_ImagePath.Caption = "ImagePath";
            this.col_ImagePath.FieldName = "ImagePath";
            this.col_ImagePath.Name = "col_ImagePath";
            this.col_ImagePath.Visible = true;
            this.col_ImagePath.VisibleIndex = 6;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.Caption = "LastUpdate";
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 7;
            // 
            // colDetailUrl
            // 
            this.colDetailUrl.Caption = "DetailUrl";
            this.colDetailUrl.FieldName = "DetailUrl";
            this.colDetailUrl.Name = "colDetailUrl";
            this.colDetailUrl.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDetailUrl.Visible = true;
            this.colDetailUrl.VisibleIndex = 8;
            // 
            // col_OriginPrice
            // 
            this.col_OriginPrice.Caption = "OriginPrice";
            this.col_OriginPrice.FieldName = "OriginPrice";
            this.col_OriginPrice.Name = "col_OriginPrice";
            this.col_OriginPrice.Visible = true;
            this.col_OriginPrice.VisibleIndex = 9;
            // 
            // col_HashName
            // 
            this.col_HashName.Caption = "HashHashName";
            this.col_HashName.FieldName = "HashName";
            this.col_HashName.Name = "col_HashName";
            this.col_HashName.Visible = true;
            this.col_HashName.VisibleIndex = 10;
            // 
            // menuCompanyPlus1
            // 
            this.menuCompanyPlus1.Name = "menuCompanyPlus1";
            this.menuCompanyPlus1.Size = new System.Drawing.Size(61, 4);
            // 
            // col_VAT
            // 
            this.col_VAT.Caption = "VATStatus";
            this.col_VAT.FieldName = "VATStatus";
            this.col_VAT.Name = "col_VAT";
            this.col_VAT.Visible = true;
            this.col_VAT.VisibleIndex = 11;
            // 
            // FrmViewProductInDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 549);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmViewProductInDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm trong database";
            this.Load += new System.EventHandler(this.FrmViewProductInDb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_Name;
        private DevExpress.XtraGrid.Columns.GridColumn col_Price;
        private DevExpress.XtraGrid.Columns.GridColumn col_ImageUrls;
        private DevExpress.XtraGrid.Columns.GridColumn col_Valid;
        private DevExpress.XtraGrid.Columns.GridColumn col_IsNews;
        private DevExpress.XtraGrid.Columns.GridColumn col_ImagePath;
        private MenuCompanyPlus menuCompanyPlus1;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailUrl;
        private DevExpress.XtraGrid.Columns.GridColumn col_OriginPrice;
        private DevExpress.XtraGrid.Columns.GridColumn col_HashName;
        private DevExpress.XtraGrid.Columns.GridColumn col_VAT;
    }
}