namespace WSS.Crawler.Product.Report
{
    partial class FrmHistoryProduct
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPromotionInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProductId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSession);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1452, 37);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1083, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ProductId";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(410, 6);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(249, 20);
            this.txtProductId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(724, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Session";
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(62, 6);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(265, 20);
            this.txtSession.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1452, 758);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPrice,
            this.colName,
            this.colImageUrl,
            this.colOldPrice,
            this.colLastUpdate,
            this.colPromotionInfo,
            this.colVatInfo,
            this.colShortDescription,
            this.colDetailUrl,
            this.colId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colImageUrl
            // 
            this.colImageUrl.Caption = "ImageUrl";
            this.colImageUrl.FieldName = "ImageUrl";
            this.colImageUrl.Name = "colImageUrl";
            this.colImageUrl.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colImageUrl.Visible = true;
            this.colImageUrl.VisibleIndex = 2;
            // 
            // colOldPrice
            // 
            this.colOldPrice.Caption = "OldPrice";
            this.colOldPrice.FieldName = "OldPrice";
            this.colOldPrice.Name = "colOldPrice";
            this.colOldPrice.Visible = true;
            this.colOldPrice.VisibleIndex = 3;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.Caption = "LastUpdate";
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 4;
            // 
            // colPromotionInfo
            // 
            this.colPromotionInfo.Caption = "PromotionInfo";
            this.colPromotionInfo.Name = "colPromotionInfo";
            this.colPromotionInfo.Visible = true;
            this.colPromotionInfo.VisibleIndex = 5;
            // 
            // colVatInfo
            // 
            this.colVatInfo.Caption = "colVatInfo";
            this.colVatInfo.Name = "colVatInfo";
            this.colVatInfo.Visible = true;
            this.colVatInfo.VisibleIndex = 6;
            // 
            // colShortDescription
            // 
            this.colShortDescription.Caption = "ShortDescription";
            this.colShortDescription.FieldName = "ShortDescription";
            this.colShortDescription.Name = "colShortDescription";
            this.colShortDescription.Visible = true;
            this.colShortDescription.VisibleIndex = 7;
            // 
            // colDetailUrl
            // 
            this.colDetailUrl.Caption = "DetailUrl";
            this.colDetailUrl.FieldName = "DetailUrl";
            this.colDetailUrl.Name = "colDetailUrl";
            this.colDetailUrl.Visible = true;
            this.colDetailUrl.VisibleIndex = 8;
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "ID";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 9;
            // 
            // FrmHistoryProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 795);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHistoryProduct";
            this.Text = "FrmHistoryProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSession;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnLoad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colImageUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colOldPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colPromotionInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colVatInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colShortDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}