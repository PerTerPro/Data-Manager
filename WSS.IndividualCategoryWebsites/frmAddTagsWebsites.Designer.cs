namespace WSS.IndividualCategoryWebsites
{
    partial class frmAddTagsWebsites
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
            System.Windows.Forms.Label tagLabel;
            System.Windows.Forms.Label relateKeywordsLabel;
            System.Windows.Forms.Label rootProductIdListLabel;
            System.Windows.Forms.Label ordinalLabel;
            System.Windows.Forms.Label websiteIdLabel;
            System.Windows.Forms.Label isActiveLabel;
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tagsGridControl = new DevExpress.XtraGrid.GridControl();
            this.tagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBIndi = new WSS.IndividualCategoryWebsites.DBIndi();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tagTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.relateKeywordsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.rootProductIdListInSqlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ordinalTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.websiteIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isActiveTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.grdRootProduct = new DevExpress.XtraGrid.GridControl();
            this.gvRootProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtListRootIdNew = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.tagsTableAdapter = new WSS.IndividualCategoryWebsites.DBIndiTableAdapters.TagsTableAdapter();
            this.tableAdapterManager = new WSS.IndividualCategoryWebsites.DBIndiTableAdapters.TableAdapterManager();
            this.contextMenuStripProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectedRootProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTags = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewListProductByTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonNew = new System.Windows.Forms.RadioButton();
            tagLabel = new System.Windows.Forms.Label();
            relateKeywordsLabel = new System.Windows.Forms.Label();
            rootProductIdListLabel = new System.Windows.Forms.Label();
            ordinalLabel = new System.Windows.Forms.Label();
            websiteIdLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIndi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relateKeywordsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootProductIdListInSqlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordinalTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRootProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRootProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtListRootIdNew.Properties)).BeginInit();
            this.contextMenuStripProduct.SuspendLayout();
            this.contextMenuStripTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Location = new System.Drawing.Point(9, 17);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new System.Drawing.Size(29, 13);
            tagLabel.TabIndex = 0;
            tagLabel.Text = "Tag:";
            // 
            // relateKeywordsLabel
            // 
            relateKeywordsLabel.AutoSize = true;
            relateKeywordsLabel.Location = new System.Drawing.Point(9, 50);
            relateKeywordsLabel.Name = "relateKeywordsLabel";
            relateKeywordsLabel.Size = new System.Drawing.Size(90, 13);
            relateKeywordsLabel.TabIndex = 2;
            relateKeywordsLabel.Text = "Relate Keywords:";
            // 
            // rootProductIdListLabel
            // 
            rootProductIdListLabel.AutoSize = true;
            rootProductIdListLabel.Location = new System.Drawing.Point(9, 78);
            rootProductIdListLabel.Name = "rootProductIdListLabel";
            rootProductIdListLabel.Size = new System.Drawing.Size(104, 13);
            rootProductIdListLabel.TabIndex = 4;
            rootProductIdListLabel.Text = "Root Product Id List:";
            // 
            // ordinalLabel
            // 
            ordinalLabel.AutoSize = true;
            ordinalLabel.Location = new System.Drawing.Point(9, 104);
            ordinalLabel.Name = "ordinalLabel";
            ordinalLabel.Size = new System.Drawing.Size(43, 13);
            ordinalLabel.TabIndex = 6;
            ordinalLabel.Text = "Ordinal:";
            // 
            // websiteIdLabel
            // 
            websiteIdLabel.AutoSize = true;
            websiteIdLabel.Location = new System.Drawing.Point(9, 130);
            websiteIdLabel.Name = "websiteIdLabel";
            websiteIdLabel.Size = new System.Drawing.Size(61, 13);
            websiteIdLabel.TabIndex = 8;
            websiteIdLabel.Text = "Website Id:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(9, 156);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 10;
            isActiveLabel.Text = "Is Active:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tagsGridControl);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grdRootProduct);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1241, 508);
            this.splitContainerControl1.SplitterPosition = 515;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tagsGridControl
            // 
            this.tagsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tagsGridControl.DataSource = this.tagsBindingSource;
            this.tagsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagsGridControl.Location = new System.Drawing.Point(0, 193);
            this.tagsGridControl.MainView = this.gridView1;
            this.tagsGridControl.Name = "tagsGridControl";
            this.tagsGridControl.Size = new System.Drawing.Size(515, 315);
            this.tagsGridControl.TabIndex = 1;
            this.tagsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tagsBindingSource
            // 
            this.tagsBindingSource.DataMember = "Tags";
            this.tagsBindingSource.DataSource = this.dBIndi;
            // 
            // dBIndi
            // 
            this.dBIndi.DataSetName = "DBIndi";
            this.dBIndi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.tagsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvTags_MouseDown);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(tagLabel);
            this.panelControl1.Controls.Add(this.tagTextEdit);
            this.panelControl1.Controls.Add(relateKeywordsLabel);
            this.panelControl1.Controls.Add(this.relateKeywordsTextEdit);
            this.panelControl1.Controls.Add(rootProductIdListLabel);
            this.panelControl1.Controls.Add(this.rootProductIdListInSqlTextEdit);
            this.panelControl1.Controls.Add(ordinalLabel);
            this.panelControl1.Controls.Add(this.ordinalTextEdit);
            this.panelControl1.Controls.Add(websiteIdLabel);
            this.panelControl1.Controls.Add(this.websiteIdTextEdit);
            this.panelControl1.Controls.Add(isActiveLabel);
            this.panelControl1.Controls.Add(this.isActiveTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(515, 193);
            this.panelControl1.TabIndex = 0;
            // 
            // tagTextEdit
            // 
            this.tagTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tagsBindingSource, "Tag", true));
            this.tagTextEdit.Location = new System.Drawing.Point(119, 14);
            this.tagTextEdit.Name = "tagTextEdit";
            this.tagTextEdit.Size = new System.Drawing.Size(324, 20);
            this.tagTextEdit.TabIndex = 1;
            // 
            // relateKeywordsTextEdit
            // 
            this.relateKeywordsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tagsBindingSource, "RelateKeywords", true));
            this.relateKeywordsTextEdit.Location = new System.Drawing.Point(119, 47);
            this.relateKeywordsTextEdit.Name = "relateKeywordsTextEdit";
            this.relateKeywordsTextEdit.Size = new System.Drawing.Size(381, 20);
            this.relateKeywordsTextEdit.TabIndex = 3;
            // 
            // rootProductIdListInSqlTextEdit
            // 
            this.rootProductIdListInSqlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tagsBindingSource, "RootProductIdList", true));
            this.rootProductIdListInSqlTextEdit.Location = new System.Drawing.Point(119, 75);
            this.rootProductIdListInSqlTextEdit.Name = "rootProductIdListInSqlTextEdit";
            this.rootProductIdListInSqlTextEdit.Size = new System.Drawing.Size(381, 20);
            this.rootProductIdListInSqlTextEdit.TabIndex = 5;
            // 
            // ordinalTextEdit
            // 
            this.ordinalTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tagsBindingSource, "Ordinal", true));
            this.ordinalTextEdit.Location = new System.Drawing.Point(119, 101);
            this.ordinalTextEdit.Name = "ordinalTextEdit";
            this.ordinalTextEdit.Size = new System.Drawing.Size(100, 20);
            this.ordinalTextEdit.TabIndex = 7;
            // 
            // websiteIdTextEdit
            // 
            this.websiteIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tagsBindingSource, "WebsiteId", true));
            this.websiteIdTextEdit.Location = new System.Drawing.Point(119, 127);
            this.websiteIdTextEdit.Name = "websiteIdTextEdit";
            this.websiteIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.websiteIdTextEdit.TabIndex = 9;
            // 
            // isActiveTextEdit
            // 
            this.isActiveTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tagsBindingSource, "IsActive", true));
            this.isActiveTextEdit.Location = new System.Drawing.Point(119, 153);
            this.isActiveTextEdit.Name = "isActiveTextEdit";
            this.isActiveTextEdit.Size = new System.Drawing.Size(100, 20);
            this.isActiveTextEdit.TabIndex = 11;
            // 
            // grdRootProduct
            // 
            this.grdRootProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdRootProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRootProduct.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdRootProduct.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdRootProduct.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdRootProduct.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdRootProduct.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdRootProduct.Location = new System.Drawing.Point(0, 147);
            this.grdRootProduct.MainView = this.gvRootProduct;
            this.grdRootProduct.Name = "grdRootProduct";
            this.grdRootProduct.Size = new System.Drawing.Size(721, 361);
            this.grdRootProduct.TabIndex = 1;
            this.grdRootProduct.UseEmbeddedNavigator = true;
            this.grdRootProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRootProduct});
            // 
            // gvRootProduct
            // 
            this.gvRootProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvRootProduct.GridControl = this.grdRootProduct;
            this.gvRootProduct.Name = "gvRootProduct";
            this.gvRootProduct.OptionsBehavior.Editable = false;
            this.gvRootProduct.OptionsSelection.MultiSelect = true;
            this.gvRootProduct.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvRootProduct.OptionsView.ShowAutoFilterRow = true;
            this.gvRootProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvRootProduct_MouseDown);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Name";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.radioButtonNew);
            this.panelControl2.Controls.Add(this.radioButtonUpdate);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txtListRootIdNew);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(721, 147);
            this.panelControl2.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "ListRootId Chọn từ Grid";
            // 
            // txtListRootIdNew
            // 
            this.txtListRootIdNew.Location = new System.Drawing.Point(238, 14);
            this.txtListRootIdNew.Name = "txtListRootIdNew";
            this.txtListRootIdNew.Size = new System.Drawing.Size(334, 20);
            this.txtListRootIdNew.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(601, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 62);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tagsTableAdapter
            // 
            this.tagsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.RootProductsTableAdapter = null;
            this.tableAdapterManager.TagsTableAdapter = this.tagsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WSS.IndividualCategoryWebsites.DBIndiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WebsitesTableAdapter = null;
            // 
            // contextMenuStripProduct
            // 
            this.contextMenuStripProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectedRootProductToolStripMenuItem});
            this.contextMenuStripProduct.Name = "contextMenuStrip1";
            this.contextMenuStripProduct.Size = new System.Drawing.Size(224, 26);
            // 
            // SelectedRootProductToolStripMenuItem
            // 
            this.SelectedRootProductToolStripMenuItem.Name = "SelectedRootProductToolStripMenuItem";
            this.SelectedRootProductToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.SelectedRootProductToolStripMenuItem.Text = "Xác nhận chọn RootProduct";
            this.SelectedRootProductToolStripMenuItem.Click += new System.EventHandler(this.SelectedRootProductToolStripMenuItem_Click);
            // 
            // contextMenuStripTags
            // 
            this.contextMenuStripTags.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewListProductByTagToolStripMenuItem});
            this.contextMenuStripTags.Name = "contextMenuStrip2";
            this.contextMenuStripTags.Size = new System.Drawing.Size(204, 26);
            // 
            // viewListProductByTagToolStripMenuItem
            // 
            this.viewListProductByTagToolStripMenuItem.Name = "viewListProductByTagToolStripMenuItem";
            this.viewListProductByTagToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.viewListProductByTagToolStripMenuItem.Text = "Xem List Product by Tag";
            this.viewListProductByTagToolStripMenuItem.Click += new System.EventHandler(this.viewListProductByTagToolStripMenuItem_Click);
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Checked = true;
            this.radioButtonUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonUpdate.ForeColor = System.Drawing.Color.Red;
            this.radioButtonUpdate.Location = new System.Drawing.Point(22, 49);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(296, 23);
            this.radioButtonUpdate.TabIndex = 10;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Mặc định : Cập nhật thêm dữ liệu";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonNew
            // 
            this.radioButtonNew.AutoSize = true;
            this.radioButtonNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonNew.ForeColor = System.Drawing.Color.Red;
            this.radioButtonNew.Location = new System.Drawing.Point(22, 78);
            this.radioButtonNew.Name = "radioButtonNew";
            this.radioButtonNew.Size = new System.Drawing.Size(228, 23);
            this.radioButtonNew.TabIndex = 11;
            this.radioButtonNew.Text = "Cập nhật theo ListId mới";
            this.radioButtonNew.UseVisualStyleBackColor = true;
            // 
            // frmAddTagsWebsites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 508);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmAddTagsWebsites";
            this.Text = "frmAddTagsWebsites";
            this.Load += new System.EventHandler(this.frmAddTagsWebsites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tagsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIndi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relateKeywordsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootProductIdListInSqlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordinalTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRootProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRootProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtListRootIdNew.Properties)).EndInit();
            this.contextMenuStripProduct.ResumeLayout(false);
            this.contextMenuStripTags.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBIndi dBIndi;
        private System.Windows.Forms.BindingSource tagsBindingSource;
        private DBIndiTableAdapters.TagsTableAdapter tagsTableAdapter;
        private DBIndiTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl grdRootProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRootProduct;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtListRootIdNew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProduct;
        private System.Windows.Forms.ToolStripMenuItem SelectedRootProductToolStripMenuItem;
        private DevExpress.XtraEditors.TextEdit tagTextEdit;
        private DevExpress.XtraEditors.TextEdit relateKeywordsTextEdit;
        private DevExpress.XtraEditors.TextEdit rootProductIdListInSqlTextEdit;
        private DevExpress.XtraEditors.TextEdit ordinalTextEdit;
        private DevExpress.XtraEditors.TextEdit websiteIdTextEdit;
        private DevExpress.XtraEditors.TextEdit isActiveTextEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTags;
        private System.Windows.Forms.ToolStripMenuItem viewListProductByTagToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl tagsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.RadioButton radioButtonNew;
        private System.Windows.Forms.RadioButton radioButtonUpdate;

    }
}