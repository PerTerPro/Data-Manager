namespace WSS.Financial.Backend
{
    partial class FrmPropertyValue
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label valueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPropertyValue));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.propertyValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFinancial = new WSS.Financial.Backend.DBFinancial();
            this.valueTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.propertyValueTableAdapter = new WSS.Financial.Backend.DBFinancialTableAdapters.PropertyValueTableAdapter();
            this.tableAdapterManager = new WSS.Financial.Backend.DBFinancialTableAdapters.TableAdapterManager();
            this.propertyValueBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.propertyValueBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.propertyValueGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            idLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueBindingNavigator)).BeginInit();
            this.propertyValueBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(22, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(277, 15);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(37, 13);
            valueLabel.TabIndex = 2;
            valueLabel.Text = "Value:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(idLabel);
            this.panelControl1.Controls.Add(this.idTextEdit);
            this.panelControl1.Controls.Add(valueLabel);
            this.panelControl1.Controls.Add(this.valueTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(962, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyValueBindingSource, "Id", true));
            this.idTextEdit.Location = new System.Drawing.Point(65, 12);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Properties.ReadOnly = true;
            this.idTextEdit.Size = new System.Drawing.Size(194, 20);
            this.idTextEdit.TabIndex = 1;
            // 
            // propertyValueBindingSource
            // 
            this.propertyValueBindingSource.DataMember = "PropertyValue";
            this.propertyValueBindingSource.DataSource = this.dBFinancial;
            // 
            // dBFinancial
            // 
            this.dBFinancial.DataSetName = "DBFinancial";
            this.dBFinancial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // valueTextEdit
            // 
            this.valueTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.propertyValueBindingSource, "Value", true));
            this.valueTextEdit.Location = new System.Drawing.Point(320, 12);
            this.valueTextEdit.Name = "valueTextEdit";
            this.valueTextEdit.Size = new System.Drawing.Size(582, 20);
            this.valueTextEdit.TabIndex = 3;
            this.valueTextEdit.EditValueChanged += new System.EventHandler(this.valueTextEdit_EditValueChanged);
            // 
            // propertyValueTableAdapter
            // 
            this.propertyValueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ItemPropertiesTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.PropertyGroupTableAdapter = null;
            this.tableAdapterManager.PropertyStatusTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropertyValueTableAdapter = this.propertyValueTableAdapter;
            this.tableAdapterManager.UpdateOrder = WSS.Financial.Backend.DBFinancialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // propertyValueBindingNavigator
            // 
            this.propertyValueBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.propertyValueBindingNavigator.BindingSource = this.propertyValueBindingSource;
            this.propertyValueBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.propertyValueBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.propertyValueBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.propertyValueBindingNavigatorSaveItem});
            this.propertyValueBindingNavigator.Location = new System.Drawing.Point(0, 50);
            this.propertyValueBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.propertyValueBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.propertyValueBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.propertyValueBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.propertyValueBindingNavigator.Name = "propertyValueBindingNavigator";
            this.propertyValueBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propertyValueBindingNavigator.Size = new System.Drawing.Size(962, 25);
            this.propertyValueBindingNavigator.TabIndex = 1;
            this.propertyValueBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // propertyValueBindingNavigatorSaveItem
            // 
            this.propertyValueBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("propertyValueBindingNavigatorSaveItem.Image")));
            this.propertyValueBindingNavigatorSaveItem.Name = "propertyValueBindingNavigatorSaveItem";
            this.propertyValueBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.propertyValueBindingNavigatorSaveItem.Text = "Save Data";
            this.propertyValueBindingNavigatorSaveItem.Click += new System.EventHandler(this.propertyValueBindingNavigatorSaveItem_Click);
            // 
            // propertyValueGridControl
            // 
            this.propertyValueGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyValueGridControl.DataSource = this.propertyValueBindingSource;
            this.propertyValueGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyValueGridControl.Location = new System.Drawing.Point(0, 75);
            this.propertyValueGridControl.MainView = this.gridView1;
            this.propertyValueGridControl.Name = "propertyValueGridControl";
            this.propertyValueGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.propertyValueGridControl.Size = new System.Drawing.Size(962, 562);
            this.propertyValueGridControl.TabIndex = 2;
            this.propertyValueGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colValue});
            this.gridView1.GridControl = this.propertyValueGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.RowHeight = 40;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 219;
            // 
            // colValue
            // 
            this.colValue.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 0;
            this.colValue.Width = 725;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // FrmPropertyValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 637);
            this.Controls.Add(this.propertyValueGridControl);
            this.Controls.Add(this.propertyValueBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPropertyValue";
            this.Text = "FrmPropertyValue";
            this.Load += new System.EventHandler(this.FrmPropertyValue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueBindingNavigator)).EndInit();
            this.propertyValueBindingNavigator.ResumeLayout(false);
            this.propertyValueBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyValueGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource propertyValueBindingSource;
        private DBFinancialTableAdapters.PropertyValueTableAdapter propertyValueTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator propertyValueBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton propertyValueBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl propertyValueGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit valueTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}