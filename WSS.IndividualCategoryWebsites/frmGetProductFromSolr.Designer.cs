namespace WSS.IndividualCategoryWebsites
{
    partial class frmGetProductFromSolr
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.grdCategory = new DevExpress.XtraGrid.GridControl();
            this.gvCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtKeyword = new DevExpress.XtraEditors.TextEdit();
            this.txtDomain = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtWebsiteId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnGetListProductFromSolr = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumberFound = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtCategoryName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCategoryId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnPushAllProductToServiceRootProduct = new DevExpress.XtraEditors.SimpleButton();
            this.txtLimitPushMessage = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewDetailProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pushMessageToServiceRootProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SendListProductToServiceRootProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewAllProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsiteId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberFound.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimitPushMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.txtKeyword);
            this.panelControl1.Controls.Add(this.txtDomain);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.btnPushAllProductToServiceRootProduct);
            this.panelControl1.Controls.Add(this.txtWebsiteId);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.btnGetListProductFromSolr);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtNumberFound);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(270, 672);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.grdCategory);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 243);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(266, 427);
            this.panelControl3.TabIndex = 3;
            // 
            // grdCategory
            // 
            this.grdCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCategory.Location = new System.Drawing.Point(2, 2);
            this.grdCategory.MainView = this.gvCategory;
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.Size = new System.Drawing.Size(262, 423);
            this.grdCategory.TabIndex = 3;
            this.grdCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategory});
            // 
            // gvCategory
            // 
            this.gvCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvCategory.GridControl = this.grdCategory;
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.OptionsBehavior.Editable = false;
            this.gvCategory.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCategory_RowClick);
            this.gvCategory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvCategory_MouseDown);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(76, 97);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(182, 20);
            this.txtKeyword.TabIndex = 6;
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyDown);
            // 
            // txtDomain
            // 
            this.txtDomain.EditValue = "";
            this.txtDomain.Location = new System.Drawing.Point(76, 60);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDomain.Size = new System.Drawing.Size(182, 20);
            this.txtDomain.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 63);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Domain";
            // 
            // txtWebsiteId
            // 
            this.txtWebsiteId.EditValue = "";
            this.txtWebsiteId.Location = new System.Drawing.Point(76, 23);
            this.txtWebsiteId.Name = "txtWebsiteId";
            this.txtWebsiteId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWebsiteId.Size = new System.Drawing.Size(182, 20);
            this.txtWebsiteId.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "WebsiteId";
            // 
            // btnGetListProductFromSolr
            // 
            this.btnGetListProductFromSolr.Location = new System.Drawing.Point(28, 158);
            this.btnGetListProductFromSolr.Name = "btnGetListProductFromSolr";
            this.btnGetListProductFromSolr.Size = new System.Drawing.Size(189, 30);
            this.btnGetListProductFromSolr.TabIndex = 2;
            this.btnGetListProductFromSolr.Text = "Search";
            this.btnGetListProductFromSolr.Click += new System.EventHandler(this.btnGetListProductFromSolr_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(12, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Number Found";
            // 
            // txtNumberFound
            // 
            this.txtNumberFound.EditValue = "";
            this.txtNumberFound.Enabled = false;
            this.txtNumberFound.Location = new System.Drawing.Point(94, 132);
            this.txtNumberFound.Name = "txtNumberFound";
            this.txtNumberFound.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtNumberFound.Properties.Appearance.Options.UseForeColor = true;
            this.txtNumberFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumberFound.Size = new System.Drawing.Size(164, 20);
            this.txtNumberFound.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 100);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Từ khóa";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtCategoryName);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.txtCategoryId);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txtLimitPushMessage);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(270, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(987, 63);
            this.panelControl2.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.EditValue = "";
            this.txtCategoryName.Location = new System.Drawing.Point(267, 23);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCategoryName.Size = new System.Drawing.Size(181, 20);
            this.txtCategoryName.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(179, 24);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "CategoryName";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.EditValue = "";
            this.txtCategoryId.Location = new System.Drawing.Point(86, 23);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCategoryId.Size = new System.Drawing.Size(70, 20);
            this.txtCategoryId.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "CategoryId";
            // 
            // btnPushAllProductToServiceRootProduct
            // 
            this.btnPushAllProductToServiceRootProduct.Location = new System.Drawing.Point(28, 194);
            this.btnPushAllProductToServiceRootProduct.Name = "btnPushAllProductToServiceRootProduct";
            this.btnPushAllProductToServiceRootProduct.Size = new System.Drawing.Size(191, 43);
            this.btnPushAllProductToServiceRootProduct.TabIndex = 5;
            this.btnPushAllProductToServiceRootProduct.Text = "Push Message Tất cả sản phẩm";
            this.btnPushAllProductToServiceRootProduct.Click += new System.EventHandler(this.btnPushAllProductToServiceRootProduct_Click);
            // 
            // txtLimitPushMessage
            // 
            this.txtLimitPushMessage.EditValue = "100000";
            this.txtLimitPushMessage.Location = new System.Drawing.Point(682, 23);
            this.txtLimitPushMessage.Name = "txtLimitPushMessage";
            this.txtLimitPushMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLimitPushMessage.Size = new System.Drawing.Size(70, 20);
            this.txtLimitPushMessage.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(565, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Giới hạn số sản phẩm";
            // 
            // grdProduct
            // 
            this.grdProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdProduct.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdProduct.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdProduct.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdProduct.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdProduct.Location = new System.Drawing.Point(270, 63);
            this.grdProduct.MainView = this.gvProduct;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.Size = new System.Drawing.Size(987, 609);
            this.grdProduct.TabIndex = 2;
            this.grdProduct.UseEmbeddedNavigator = true;
            this.grdProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            // 
            // gvProduct
            // 
            this.gvProduct.GridControl = this.grdProduct;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsBehavior.Editable = false;
            this.gvProduct.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvProduct.OptionsSelection.MultiSelect = true;
            this.gvProduct.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvProduct_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewDetailProductToolStripMenuItem,
            this.pushMessageToServiceRootProductToolStripMenuItem,
            this.ViewAllProductToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(300, 92);
            // 
            // ViewDetailProductToolStripMenuItem
            // 
            this.ViewDetailProductToolStripMenuItem.Name = "ViewDetailProductToolStripMenuItem";
            this.ViewDetailProductToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.ViewDetailProductToolStripMenuItem.Text = "Xem chi tiết sản phẩm";
            this.ViewDetailProductToolStripMenuItem.Click += new System.EventHandler(this.ViewDetailProductToolStripMenuItem_Click);
            // 
            // pushMessageToServiceRootProductToolStripMenuItem
            // 
            this.pushMessageToServiceRootProductToolStripMenuItem.Name = "pushMessageToServiceRootProductToolStripMenuItem";
            this.pushMessageToServiceRootProductToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.pushMessageToServiceRootProductToolStripMenuItem.Text = "Chọn category này để chuyển sang SP gốc";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "CategoryId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 39;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cate";
            this.gridColumn2.FieldName = "CategoryName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 127;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Count";
            this.gridColumn3.FieldName = "CountProductInCat";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 78;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SendListProductToServiceRootProductToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(285, 26);
            // 
            // SendListProductToServiceRootProductToolStripMenuItem
            // 
            this.SendListProductToServiceRootProductToolStripMenuItem.Name = "SendListProductToServiceRootProductToolStripMenuItem";
            this.SendListProductToServiceRootProductToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.SendListProductToServiceRootProductToolStripMenuItem.Text = "Chuyển list Product sang sản phẩm gốc";
            this.SendListProductToServiceRootProductToolStripMenuItem.Click += new System.EventHandler(this.SendListProductToServiceRootProductToolStripMenuItem_Click);
            // 
            // ViewAllProductToolStripMenuItem
            // 
            this.ViewAllProductToolStripMenuItem.Name = "ViewAllProductToolStripMenuItem";
            this.ViewAllProductToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.ViewAllProductToolStripMenuItem.Text = "Xem tất cả sản phẩm";
            this.ViewAllProductToolStripMenuItem.Click += new System.EventHandler(this.ViewAllProductToolStripMenuItem_Click);
            // 
            // frmGetProductFromSolr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 672);
            this.Controls.Add(this.grdProduct);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmGetProductFromSolr";
            this.Text = "frmGetProductFromSolr";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsiteId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberFound.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimitPushMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGetListProductFromSolr;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNumberFound;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnPushAllProductToServiceRootProduct;
        private DevExpress.XtraEditors.TextEdit txtLimitPushMessage;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl grdProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
        private DevExpress.XtraEditors.TextEdit txtDomain;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtWebsiteId;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl grdCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategory;
        private DevExpress.XtraEditors.TextEdit txtKeyword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ViewDetailProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pushMessageToServiceRootProductToolStripMenuItem;
        private DevExpress.XtraEditors.TextEdit txtCategoryName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCategoryId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem SendListProductToServiceRootProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewAllProductToolStripMenuItem;
    }
}