namespace QT.Moduls.Tag
{
    partial class frmCategorySearchPriority
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorySearchPriority));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label searchPriorityLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dBTag = new QT.Moduls.Tag.DBTag();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listClassificationTableAdapter = new QT.Moduls.Tag.DBTagTableAdapters.ListClassificationTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Tag.DBTagTableAdapters.TableAdapterManager();
            this.listClassificationGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSearchPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.searchPriorityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            searchPriorityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPriorityTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(searchPriorityLabel);
            this.panelControl1.Controls.Add(this.searchPriorityTextEdit);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.nameTextEdit);
            this.panelControl1.Controls.Add(iDLabel);
            this.panelControl1.Controls.Add(this.iDTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(630, 36);
            this.panelControl1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.listClassificationBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonSave});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 636);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(630, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.listClassificationGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 36);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(630, 600);
            this.panelControl2.TabIndex = 2;
            // 
            // dBTag
            // 
            this.dBTag.DataSetName = "DBTag";
            this.dBTag.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dBTag;
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = this.listClassificationTableAdapter;
            this.tableAdapterManager.ProductStatusTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.Tag_CategoryTableAdapter = null;
            this.tableAdapterManager.Tag_ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Tag.DBTagTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listClassificationGridControl
            // 
            this.listClassificationGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.listClassificationGridControl.DataSource = this.listClassificationBindingSource;
            this.listClassificationGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listClassificationGridControl.Location = new System.Drawing.Point(2, 2);
            this.listClassificationGridControl.MainView = this.gridView1;
            this.listClassificationGridControl.Name = "listClassificationGridControl";
            this.listClassificationGridControl.Size = new System.Drawing.Size(626, 596);
            this.listClassificationGridControl.TabIndex = 0;
            this.listClassificationGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colParentID,
            this.colDescription,
            this.colValid,
            this.colSearchPriority});
            this.gridView1.GridControl = this.listClassificationGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 54;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 409;
            // 
            // colParentID
            // 
            this.colParentID.FieldName = "ParentID";
            this.colParentID.Name = "colParentID";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colValid
            // 
            this.colValid.FieldName = "Valid";
            this.colValid.Name = "colValid";
            this.colValid.OptionsColumn.ReadOnly = true;
            this.colValid.Visible = true;
            this.colValid.VisibleIndex = 2;
            this.colValid.Width = 56;
            // 
            // colSearchPriority
            // 
            this.colSearchPriority.FieldName = "SearchPriority";
            this.colSearchPriority.Name = "colSearchPriority";
            this.colSearchPriority.Visible = true;
            this.colSearchPriority.VisibleIndex = 3;
            this.colSearchPriority.Width = 250;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(16, 12);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // iDTextEdit
            // 
            this.iDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.listClassificationBindingSource, "ID", true));
            this.iDTextEdit.Location = new System.Drawing.Point(43, 9);
            this.iDTextEdit.Name = "iDTextEdit";
            this.iDTextEdit.Properties.ReadOnly = true;
            this.iDTextEdit.Size = new System.Drawing.Size(100, 20);
            this.iDTextEdit.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(162, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.listClassificationBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(206, 9);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.ReadOnly = true;
            this.nameTextEdit.Size = new System.Drawing.Size(180, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // searchPriorityLabel
            // 
            searchPriorityLabel.AutoSize = true;
            searchPriorityLabel.Location = new System.Drawing.Point(420, 12);
            searchPriorityLabel.Name = "searchPriorityLabel";
            searchPriorityLabel.Size = new System.Drawing.Size(78, 13);
            searchPriorityLabel.TabIndex = 4;
            searchPriorityLabel.Text = "Search Priority:";
            // 
            // searchPriorityTextEdit
            // 
            this.searchPriorityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.listClassificationBindingSource, "SearchPriority", true));
            this.searchPriorityTextEdit.Location = new System.Drawing.Point(504, 9);
            this.searchPriorityTextEdit.Name = "searchPriorityTextEdit";
            this.searchPriorityTextEdit.Size = new System.Drawing.Size(100, 20);
            this.searchPriorityTextEdit.TabIndex = 5;
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(76, 22);
            this.toolStripButtonSave.Text = "Save(Ctrl+S)";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // frmCategorySearchPriority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 661);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCategorySearchPriority";
            this.Text = "frmCategorySearchPriority";
            this.Load += new System.EventHandler(this.frmCategorySearchPriority_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPriorityTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DBTag dBTag;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DBTagTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private DBTagTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl listClassificationGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colParentID;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colValid;
        private DevExpress.XtraGrid.Columns.GridColumn colSearchPriority;
        private DevExpress.XtraEditors.TextEdit searchPriorityTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit iDTextEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
    }
}