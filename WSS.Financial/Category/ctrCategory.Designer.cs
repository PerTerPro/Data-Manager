namespace WSS.Financial.Backend.Category
{
    partial class ctrCategory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label parentIdLabel;
            System.Windows.Forms.Label categoryLevelLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFinancial = new WSS.Financial.Backend.DBFinancial();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.parentIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categoryTableAdapter = new WSS.Financial.Backend.DBFinancialTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new WSS.Financial.Backend.DBFinancialTableAdapters.TableAdapterManager();
            this.treeListCategory = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCategoryLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.categoryLevelTextEdit = new DevExpress.XtraEditors.TextEdit();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            parentIdLabel = new System.Windows.Forms.Label();
            categoryLevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLevelTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(7, 17);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(101, 17);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // parentIdLabel
            // 
            parentIdLabel.AutoSize = true;
            parentIdLabel.Location = new System.Drawing.Point(9, 55);
            parentIdLabel.Name = "parentIdLabel";
            parentIdLabel.Size = new System.Drawing.Size(53, 13);
            parentIdLabel.TabIndex = 5;
            parentIdLabel.Text = "Parent Id:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(categoryLevelLabel);
            this.panelControl1.Controls.Add(this.categoryLevelTextEdit);
            this.panelControl1.Controls.Add(idLabel);
            this.panelControl1.Controls.Add(this.idTextEdit);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.nameTextEdit);
            this.panelControl1.Controls.Add(parentIdLabel);
            this.panelControl1.Controls.Add(this.parentIdTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(410, 49);
            this.panelControl1.TabIndex = 0;
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoryBindingSource, "Id", true));
            this.idTextEdit.Location = new System.Drawing.Point(32, 14);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Size = new System.Drawing.Size(57, 20);
            this.idTextEdit.TabIndex = 2;
            this.idTextEdit.EditValueChanged += new System.EventHandler(this.idTextEdit_EditValueChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dBFinancial;
            // 
            // dBFinancial
            // 
            this.dBFinancial.DataSetName = "DBFinancial";
            this.dBFinancial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoryBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(160, 14);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(205, 20);
            this.nameTextEdit.TabIndex = 4;
            // 
            // parentIdTextEdit
            // 
            this.parentIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoryBindingSource, "ParentId", true));
            this.parentIdTextEdit.Location = new System.Drawing.Point(68, 52);
            this.parentIdTextEdit.Name = "parentIdTextEdit";
            this.parentIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.parentIdTextEdit.TabIndex = 6;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.ItemPropertiesTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.PropertyGroupTableAdapter = null;
            this.tableAdapterManager.PropertyStatusTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.Financial.Backend.DBFinancialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // treeListCategory
            // 
            this.treeListCategory.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colCategoryLevel,
            this.treeListColumnId});
            this.treeListCategory.DataSource = this.categoryBindingSource;
            this.treeListCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListCategory.KeyFieldName = "Id";
            this.treeListCategory.Location = new System.Drawing.Point(0, 49);
            this.treeListCategory.Name = "treeListCategory";
            this.treeListCategory.ParentFieldName = "ParentId";
            this.treeListCategory.PreviewFieldName = "Name";
            this.treeListCategory.Size = new System.Drawing.Size(410, 524);
            this.treeListCategory.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 177;
            // 
            // colCategoryLevel
            // 
            this.colCategoryLevel.FieldName = "CategoryLevel";
            this.colCategoryLevel.Name = "colCategoryLevel";
            this.colCategoryLevel.Visible = true;
            this.colCategoryLevel.VisibleIndex = 2;
            this.colCategoryLevel.Width = 80;
            // 
            // treeListColumnId
            // 
            this.treeListColumnId.Caption = "Id";
            this.treeListColumnId.FieldName = "Id";
            this.treeListColumnId.Name = "treeListColumnId";
            this.treeListColumnId.Visible = true;
            this.treeListColumnId.VisibleIndex = 0;
            this.treeListColumnId.Width = 81;
            // 
            // categoryLevelLabel
            // 
            categoryLevelLabel.AutoSize = true;
            categoryLevelLabel.Location = new System.Drawing.Point(176, 55);
            categoryLevelLabel.Name = "categoryLevelLabel";
            categoryLevelLabel.Size = new System.Drawing.Size(81, 13);
            categoryLevelLabel.TabIndex = 6;
            categoryLevelLabel.Text = "Category Level:";
            // 
            // categoryLevelTextEdit
            // 
            this.categoryLevelTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoryBindingSource, "CategoryLevel", true));
            this.categoryLevelTextEdit.Location = new System.Drawing.Point(263, 52);
            this.categoryLevelTextEdit.Name = "categoryLevelTextEdit";
            this.categoryLevelTextEdit.Size = new System.Drawing.Size(100, 20);
            this.categoryLevelTextEdit.TabIndex = 7;
            // 
            // ctrCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeListCategory);
            this.Controls.Add(this.panelControl1);
            this.Name = "ctrCategory";
            this.Size = new System.Drawing.Size(410, 573);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLevelTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DBFinancial dBFinancial;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit parentIdTextEdit;
        private DBFinancialTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraTreeList.TreeList treeListCategory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCategoryLevel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnId;
        private DevExpress.XtraEditors.TextEdit categoryLevelTextEdit;
    }
}
