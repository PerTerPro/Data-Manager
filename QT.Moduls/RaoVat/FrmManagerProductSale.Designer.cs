namespace QT.Moduls.CrawlSale
{
    partial class FrmManagerProductSale
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
            this.btnUnCheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnCheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtNameItem = new System.Windows.Forms.TextBox();
            this.btnFindByName = new DevExpress.XtraEditors.SimpleButton();
            this.ckLoadImage = new System.Windows.Forms.CheckBox();
            this.btnRequest1000 = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.spinNumberItem = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spinEditPriceTo = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditPriceFrom = new DevExpress.XtraEditors.SpinEdit();
            this.btnHide = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.updated_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.source_updated_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.view_count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.url = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thumb_url = new DevExpress.XtraGrid.Columns.GridColumn();
            this.is_crawled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.is_selected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumberItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPriceTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPriceFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnUnCheckAll);
            this.panelControl1.Controls.Add(this.btnCheckAll);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.txtNameItem);
            this.panelControl1.Controls.Add(this.btnFindByName);
            this.panelControl1.Controls.Add(this.ckLoadImage);
            this.panelControl1.Controls.Add(this.btnRequest1000);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.txtQuery);
            this.panelControl1.Controls.Add(this.spinNumberItem);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.spinEditPriceTo);
            this.panelControl1.Controls.Add(this.spinEditPriceFrom);
            this.panelControl1.Controls.Add(this.btnHide);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(846, 115);
            this.panelControl1.TabIndex = 0;
            // 
            // btnUnCheckAll
            // 
            this.btnUnCheckAll.Location = new System.Drawing.Point(403, 77);
            this.btnUnCheckAll.Name = "btnUnCheckAll";
            this.btnUnCheckAll.Size = new System.Drawing.Size(50, 23);
            this.btnUnCheckAll.TabIndex = 23;
            this.btnUnCheckAll.Text = "UCk All";
            this.btnUnCheckAll.Click += new System.EventHandler(this.btnUnCheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(326, 77);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(71, 23);
            this.btnCheckAll.TabIndex = 22;
            this.btnCheckAll.Text = "Ck All";
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(721, 76);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(51, 23);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "...";
            // 
            // txtNameItem
            // 
            this.txtNameItem.Location = new System.Drawing.Point(101, 51);
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.Size = new System.Drawing.Size(271, 20);
            this.txtNameItem.TabIndex = 20;
            this.txtNameItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameItem_KeyDown);
            // 
            // btnFindByName
            // 
            this.btnFindByName.Location = new System.Drawing.Point(5, 51);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(90, 23);
            this.btnFindByName.TabIndex = 19;
            this.btnFindByName.Text = "Find by name";
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // ckLoadImage
            // 
            this.ckLoadImage.AutoSize = true;
            this.ckLoadImage.Location = new System.Drawing.Point(46, 28);
            this.ckLoadImage.Name = "ckLoadImage";
            this.ckLoadImage.Size = new System.Drawing.Size(82, 17);
            this.ckLoadImage.TabIndex = 18;
            this.ckLoadImage.Text = "Load Image";
            this.ckLoadImage.UseVisualStyleBackColor = true;
            // 
            // btnRequest1000
            // 
            this.btnRequest1000.Location = new System.Drawing.Point(101, 77);
            this.btnRequest1000.Name = "btnRequest1000";
            this.btnRequest1000.Size = new System.Drawing.Size(219, 23);
            this.btnRequest1000.TabIndex = 16;
            this.btnRequest1000.Text = "Top last request";
            this.btnRequest1000.Click += new System.EventHandler(this.btnRequest1000_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "QueryToSolr";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(506, 5);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(266, 54);
            this.txtQuery.TabIndex = 13;
            this.txtQuery.Text = "sort=updated_at desc&start=0&rows=100&indent=true";
            // 
            // spinNumberItem
            // 
            this.spinNumberItem.EditValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinNumberItem.Location = new System.Drawing.Point(334, 5);
            this.spinNumberItem.Name = "spinNumberItem";
            this.spinNumberItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNumberItem.Size = new System.Drawing.Size(94, 20);
            this.spinNumberItem.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "TopData";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giá từ";
            // 
            // spinEditPriceTo
            // 
            this.spinEditPriceTo.EditValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spinEditPriceTo.Location = new System.Drawing.Point(172, 5);
            this.spinEditPriceTo.Name = "spinEditPriceTo";
            this.spinEditPriceTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPriceTo.Size = new System.Drawing.Size(100, 20);
            this.spinEditPriceTo.TabIndex = 3;
            // 
            // spinEditPriceFrom
            // 
            this.spinEditPriceFrom.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditPriceFrom.Location = new System.Drawing.Point(46, 5);
            this.spinEditPriceFrom.Name = "spinEditPriceFrom";
            this.spinEditPriceFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditPriceFrom.Size = new System.Drawing.Size(100, 20);
            this.spinEditPriceFrom.TabIndex = 2;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(5, 76);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(90, 23);
            this.btnHide.TabIndex = 0;
            this.btnHide.Text = "Ẩn";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 115);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(846, 377);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemPictureEdit2,
            this.repositoryItemMemoEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemMemoEdit2,
            this.repositoryItemRichTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(842, 373);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._id,
            this.name,
            this.updated_at,
            this.source_updated_at,
            this.price,
            this.view_count,
            this.url,
            this.thumb_url,
            this.is_crawled,
            this.is_selected});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowHeight = 40;
            // 
            // _id
            // 
            this._id.Caption = "_id";
            this._id.FieldName = "_id";
            this._id.MinWidth = 30;
            this._id.Name = "_id";
            this._id.Visible = true;
            this._id.VisibleIndex = 1;
            this._id.Width = 30;
            // 
            // name
            // 
            this.name.Caption = "name";
            this.name.FieldName = "name";
            this.name.MinWidth = 50;
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 2;
            this.name.Width = 262;
            // 
            // updated_at
            // 
            this.updated_at.Caption = "updated_at";
            this.updated_at.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm";
            this.updated_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.updated_at.FieldName = "wss_last_update";
            this.updated_at.MinWidth = 30;
            this.updated_at.Name = "updated_at";
            this.updated_at.Visible = true;
            this.updated_at.VisibleIndex = 4;
            this.updated_at.Width = 83;
            // 
            // source_updated_at
            // 
            this.source_updated_at.Caption = "source_updated_at";
            this.source_updated_at.DisplayFormat.FormatString = "yyyy/MM/dd HH:mm";
            this.source_updated_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.source_updated_at.FieldName = "last_edit";
            this.source_updated_at.Name = "source_updated_at";
            this.source_updated_at.Visible = true;
            this.source_updated_at.VisibleIndex = 5;
            this.source_updated_at.Width = 83;
            // 
            // price
            // 
            this.price.Caption = "price";
            this.price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.price.FieldName = "price";
            this.price.Name = "price";
            this.price.Visible = true;
            this.price.VisibleIndex = 3;
            // 
            // view_count
            // 
            this.view_count.Caption = "view_count";
            this.view_count.FieldName = "wss_view_count";
            this.view_count.Name = "view_count";
            this.view_count.Visible = true;
            this.view_count.VisibleIndex = 6;
            this.view_count.Width = 50;
            // 
            // url
            // 
            this.url.Caption = "url";
            this.url.FieldName = "url";
            this.url.Name = "url";
            this.url.Visible = true;
            this.url.VisibleIndex = 7;
            this.url.Width = 94;
            // 
            // thumb_url
            // 
            this.thumb_url.Caption = "thumb_url";
            this.thumb_url.FieldName = "thumb_url";
            this.thumb_url.Name = "thumb_url";
            this.thumb_url.Visible = true;
            this.thumb_url.VisibleIndex = 8;
            this.thumb_url.Width = 94;
            // 
            // is_crawled
            // 
            this.is_crawled.Caption = "is_crawled";
            this.is_crawled.FieldName = "is_crawled";
            this.is_crawled.Name = "is_crawled";
            this.is_crawled.Visible = true;
            this.is_crawled.VisibleIndex = 9;
            this.is_crawled.Width = 93;
            // 
            // is_selected
            // 
            this.is_selected.Caption = "CK";
            this.is_selected.DisplayFormat.FormatString = "d";
            this.is_selected.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.is_selected.FieldName = "is_selected";
            this.is_selected.Name = "is_selected";
            this.is_selected.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.is_selected.Visible = true;
            this.is_selected.VisibleIndex = 0;
            this.is_selected.Width = 35;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.CustomHeight = 30;
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // FrmManagerProductSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 492);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "FrmManagerProductSale";
            this.Text = "Quản lí tin rao vặt";
            this.Load += new System.EventHandler(this.FrmManagerProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmManagerProductSale_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumberItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPriceTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditPriceFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit spinEditPriceTo;
        private DevExpress.XtraEditors.SpinEdit spinEditPriceFrom;
        private DevExpress.XtraEditors.SimpleButton btnHide;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn _id;
        private DevExpress.XtraGrid.Columns.GridColumn source_updated_at;
        private DevExpress.XtraGrid.Columns.GridColumn view_count;
        private DevExpress.XtraGrid.Columns.GridColumn url;
        private DevExpress.XtraGrid.Columns.GridColumn thumb_url;
        private DevExpress.XtraGrid.Columns.GridColumn is_crawled;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtQuery;
        private DevExpress.XtraEditors.SpinEdit spinNumberItem;
        private DevExpress.XtraEditors.SimpleButton btnRequest1000;
        private DevExpress.XtraGrid.Columns.GridColumn updated_at;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private System.Windows.Forms.CheckBox ckLoadImage;
        private DevExpress.XtraGrid.Columns.GridColumn is_selected;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private System.Windows.Forms.TextBox txtNameItem;
        private DevExpress.XtraEditors.SimpleButton btnFindByName;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.SimpleButton btnUnCheckAll;
        private DevExpress.XtraEditors.SimpleButton btnCheckAll;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
    }
}