namespace WSS.IndividualCategoryWebsites.DataTeam
{
    partial class FrmSuggestRootProduct
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grdCategory = new DevExpress.XtraGrid.GridControl();
            this.gvCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCategoryIdSelected = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtKeyword = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.memoIdCompany = new DevExpress.XtraEditors.MemoEdit();
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.ctrPage1 = new QT.Entities.ctrPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddToBlackList = new DevExpress.XtraEditors.SimpleButton();
            this.lbCategoryNameSelected = new DevExpress.XtraEditors.LabelControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryIdSelected.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoIdCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.grdCategory);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grdProduct);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl3);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1362, 709);
            this.splitContainerControl1.SplitterPosition = 390;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // grdCategory
            // 
            this.grdCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCategory.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdCategory.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdCategory.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdCategory.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdCategory.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdCategory.Location = new System.Drawing.Point(0, 262);
            this.grdCategory.MainView = this.gvCategory;
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.Size = new System.Drawing.Size(390, 447);
            this.grdCategory.TabIndex = 1;
            this.grdCategory.UseEmbeddedNavigator = true;
            this.grdCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategory});
            // 
            // gvCategory
            // 
            this.gvCategory.GridControl = this.grdCategory;
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.OptionsBehavior.Editable = false;
            this.gvCategory.OptionsView.ShowAutoFilterRow = true;
            this.gvCategory.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCategory_RowClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtCategoryIdSelected);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtKeyword);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.memoIdCompany);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(390, 262);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(205, 234);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "ID Category Selected";
            // 
            // txtCategoryIdSelected
            // 
            this.txtCategoryIdSelected.Location = new System.Drawing.Point(327, 232);
            this.txtCategoryIdSelected.Name = "txtCategoryIdSelected";
            this.txtCategoryIdSelected.Size = new System.Drawing.Size(55, 20);
            this.txtCategoryIdSelected.TabIndex = 1;
            this.txtCategoryIdSelected.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl7.Location = new System.Drawing.Point(13, 11);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(262, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Nhập IdCompany - Từ khóa có thể nhập hoặc không...";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Location = new System.Drawing.Point(344, 84);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(7, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "*";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 192);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Từ khóa";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(75, 189);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(200, 20);
            this.txtKeyword.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(75, 215);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 32);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "IDCompany";
            // 
            // memoIdCompany
            // 
            this.memoIdCompany.Location = new System.Drawing.Point(75, 44);
            this.memoIdCompany.Name = "memoIdCompany";
            this.memoIdCompany.Size = new System.Drawing.Size(263, 139);
            this.memoIdCompany.TabIndex = 5;
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
            this.grdProduct.Location = new System.Drawing.Point(0, 44);
            this.grdProduct.MainView = this.gvProduct;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.Size = new System.Drawing.Size(967, 630);
            this.grdProduct.TabIndex = 2;
            this.grdProduct.UseEmbeddedNavigator = true;
            this.grdProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            // 
            // gvProduct
            // 
            this.gvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvProduct.GridControl = this.grdProduct;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsSelection.MultiSelect = true;
            this.gvProduct.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvProduct.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 182;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên sản phẩm";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 420;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giá";
            this.gridColumn3.FieldName = "Price";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 113;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ViewCount";
            this.gridColumn4.FieldName = "ViewCount";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 140;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ID Công ty";
            this.gridColumn5.FieldName = "WebsiteId";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 170;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Id Category";
            this.gridColumn6.FieldName = "CategoryId";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 67;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.ctrPage1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 674);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(967, 35);
            this.panelControl3.TabIndex = 1;
            // 
            // ctrPage1
            // 
            this.ctrPage1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctrPage1.Location = new System.Drawing.Point(2, 2);
            this.ctrPage1.Name = "ctrPage1";
            this.ctrPage1.Size = new System.Drawing.Size(463, 31);
            this.ctrPage1.TabIndex = 0;
            this.ctrPage1.PageChanged += new QT.Entities.ctrPage.ChangedEventHandler(this.ctrPage1_PageChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnExcel);
            this.panelControl2.Controls.Add(this.btnAddToBlackList);
            this.panelControl2.Controls.Add(this.lbCategoryNameSelected);
            this.panelControl2.Controls.Add(this.btnRefresh);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(967, 44);
            this.panelControl2.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Location = new System.Drawing.Point(880, 6);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnAddToBlackList
            // 
            this.btnAddToBlackList.Location = new System.Drawing.Point(14, 6);
            this.btnAddToBlackList.Name = "btnAddToBlackList";
            this.btnAddToBlackList.Size = new System.Drawing.Size(98, 33);
            this.btnAddToBlackList.TabIndex = 2;
            this.btnAddToBlackList.Text = "Cho vào BlackList";
            this.btnAddToBlackList.Click += new System.EventHandler(this.btnAddToBlackList_Click);
            // 
            // lbCategoryNameSelected
            // 
            this.lbCategoryNameSelected.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbCategoryNameSelected.Location = new System.Drawing.Point(278, 22);
            this.lbCategoryNameSelected.Name = "lbCategoryNameSelected";
            this.lbCategoryNameSelected.Size = new System.Drawing.Size(12, 13);
            this.lbCategoryNameSelected.TabIndex = 1;
            this.lbCategoryNameSelected.Text = "...";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(788, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmSuggestRootProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 709);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmSuggestRootProduct";
            this.Text = "FrmSuggestRootProduct";
            this.Load += new System.EventHandler(this.FrmSuggestRootProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryIdSelected.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoIdCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl grdCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategory;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grdProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCategoryIdSelected;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtKeyword;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lbCategoryNameSelected;
        private QT.Entities.ctrPage ctrPage1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.MemoEdit memoIdCompany;
        private DevExpress.XtraEditors.SimpleButton btnAddToBlackList;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
    }
}