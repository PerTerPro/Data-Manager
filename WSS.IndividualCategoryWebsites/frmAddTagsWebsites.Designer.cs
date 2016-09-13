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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tagsGridControl = new DevExpress.XtraGrid.GridControl();
            this.tagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBIndi = new WSS.IndividualCategoryWebsites.DBIndi();
            this.gvTags = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnViewTag = new DevExpress.XtraEditors.SimpleButton();
            this.txtTag = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tagsTableAdapter = new WSS.IndividualCategoryWebsites.DBIndiTableAdapters.TagsTableAdapter();
            this.tableAdapterManager = new WSS.IndividualCategoryWebsites.DBIndiTableAdapters.TableAdapterManager();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grdRootProduct = new DevExpress.XtraGrid.GridControl();
            this.gvRootProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lbRelatedKeyword = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtListRootIdNew = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtListIdRootProductSQL = new DevExpress.XtraEditors.TextEdit();
            this.checkEditNew = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditUpdate = new DevExpress.XtraEditors.CheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectedRootProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIndi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRootProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRootProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtListRootIdNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtListIdRootProductSQL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditUpdate.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1121, 508);
            this.splitContainerControl1.SplitterPosition = 345;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tagsGridControl
            // 
            this.tagsGridControl.DataSource = this.tagsBindingSource;
            this.tagsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagsGridControl.Location = new System.Drawing.Point(0, 104);
            this.tagsGridControl.MainView = this.gvTags;
            this.tagsGridControl.Name = "tagsGridControl";
            this.tagsGridControl.Size = new System.Drawing.Size(345, 404);
            this.tagsGridControl.TabIndex = 1;
            this.tagsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTags});
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
            // gvTags
            // 
            this.gvTags.GridControl = this.tagsGridControl;
            this.gvTags.Name = "gvTags";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnViewTag);
            this.panelControl1.Controls.Add(this.txtTag);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(345, 104);
            this.panelControl1.TabIndex = 0;
            // 
            // btnViewTag
            // 
            this.btnViewTag.Location = new System.Drawing.Point(57, 54);
            this.btnViewTag.Name = "btnViewTag";
            this.btnViewTag.Size = new System.Drawing.Size(192, 30);
            this.btnViewTag.TabIndex = 2;
            this.btnViewTag.Text = "View";
            this.btnViewTag.Click += new System.EventHandler(this.btnViewTag_Click);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(57, 19);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(192, 20);
            this.txtTag.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tag";
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.checkEditUpdate);
            this.panelControl2.Controls.Add(this.checkEditNew);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.txtListIdRootProductSQL);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txtListRootIdNew);
            this.panelControl2.Controls.Add(this.lbRelatedKeyword);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.textEdit1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(771, 159);
            this.panelControl2.TabIndex = 0;
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
            this.grdRootProduct.Location = new System.Drawing.Point(0, 159);
            this.grdRootProduct.MainView = this.gvRootProduct;
            this.grdRootProduct.Name = "grdRootProduct";
            this.grdRootProduct.Size = new System.Drawing.Size(771, 349);
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
            this.gvRootProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvRootProduct_MouseDown);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagsBindingSource, "RelateKeywords", true));
            this.textEdit1.Location = new System.Drawing.Point(103, 19);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(548, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(671, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            // 
            // lbRelatedKeyword
            // 
            this.lbRelatedKeyword.Location = new System.Drawing.Point(5, 22);
            this.lbRelatedKeyword.Name = "lbRelatedKeyword";
            this.lbRelatedKeyword.Size = new System.Drawing.Size(82, 13);
            this.lbRelatedKeyword.TabIndex = 3;
            this.lbRelatedKeyword.Text = "Related Keyword";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "ListRootId New";
            // 
            // txtListRootIdNew
            // 
            this.txtListRootIdNew.Location = new System.Drawing.Point(103, 84);
            this.txtListRootIdNew.Name = "txtListRootIdNew";
            this.txtListRootIdNew.Size = new System.Drawing.Size(548, 20);
            this.txtListRootIdNew.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "ListRootId in SQL";
            // 
            // txtListIdRootProductSQL
            // 
            this.txtListIdRootProductSQL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tagsBindingSource, "RootProductIdList", true));
            this.txtListIdRootProductSQL.Location = new System.Drawing.Point(103, 51);
            this.txtListIdRootProductSQL.Name = "txtListIdRootProductSQL";
            this.txtListIdRootProductSQL.Size = new System.Drawing.Size(548, 20);
            this.txtListIdRootProductSQL.TabIndex = 6;
            // 
            // checkEditNew
            // 
            this.checkEditNew.EditValue = true;
            this.checkEditNew.Location = new System.Drawing.Point(103, 115);
            this.checkEditNew.Name = "checkEditNew";
            this.checkEditNew.Properties.Caption = "Cập nhật theo ListId mới";
            this.checkEditNew.Size = new System.Drawing.Size(141, 19);
            this.checkEditNew.TabIndex = 8;
            // 
            // checkEditUpdate
            // 
            this.checkEditUpdate.Location = new System.Drawing.Point(270, 115);
            this.checkEditUpdate.Name = "checkEditUpdate";
            this.checkEditUpdate.Properties.Caption = "Cập nhật thêm dữ liệu";
            this.checkEditUpdate.Size = new System.Drawing.Size(137, 19);
            this.checkEditUpdate.TabIndex = 9;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectedRootProductToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(224, 26);
            // 
            // SelectedRootProductToolStripMenuItem
            // 
            this.SelectedRootProductToolStripMenuItem.Name = "SelectedRootProductToolStripMenuItem";
            this.SelectedRootProductToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.SelectedRootProductToolStripMenuItem.Text = "Xác nhận chọn RootProduct";
            this.SelectedRootProductToolStripMenuItem.Click += new System.EventHandler(this.SelectedRootProductToolStripMenuItem_Click);
            // 
            // frmAddTagsWebsites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 508);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmAddTagsWebsites";
            this.Text = "frmAddTagsWebsites";
            this.Load += new System.EventHandler(this.frmAddTagsWebsites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tagsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIndi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRootProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRootProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtListRootIdNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtListIdRootProductSQL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditUpdate.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBIndi dBIndi;
        private System.Windows.Forms.BindingSource tagsBindingSource;
        private DBIndiTableAdapters.TagsTableAdapter tagsTableAdapter;
        private DBIndiTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl tagsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTags;
        private DevExpress.XtraEditors.SimpleButton btnViewTag;
        private DevExpress.XtraEditors.TextEdit txtTag;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdRootProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRootProduct;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lbRelatedKeyword;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtListRootIdNew;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtListIdRootProductSQL;
        private DevExpress.XtraEditors.CheckEdit checkEditUpdate;
        private DevExpress.XtraEditors.CheckEdit checkEditNew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SelectedRootProductToolStripMenuItem;

    }
}