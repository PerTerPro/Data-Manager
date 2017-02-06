namespace WSS.Crl.ProducProperties.Manager
{
    partial class FrmMapProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMapProperties));
            this.panel1 = new System.Windows.Forms.Panel();
            this.productQT = new WSS.Crl.ProducProperties.Manager.ProductQT();
            this.product_PropertyCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_PropertyCategoryTableAdapter = new WSS.Crl.ProducProperties.Manager.ProductQTTableAdapters.Product_PropertyCategoryTableAdapter();
            this.tableAdapterManager = new WSS.Crl.ProducProperties.Manager.ProductQTTableAdapters.TableAdapterManager();
            this.product_PropertyCategoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.product_PropertyCategoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.product_PropertyCategoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.propertiesWssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProperty_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.propertiesWssTableAdapter = new WSS.Crl.ProducProperties.Manager.ProductQTTableAdapters.PropertiesWssTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productQT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_PropertyCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_PropertyCategoryBindingNavigator)).BeginInit();
            this.product_PropertyCategoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_PropertyCategoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesWssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 44);
            this.panel1.TabIndex = 2;
            // 
            // productQT
            // 
            this.productQT.DataSetName = "ProductQT";
            this.productQT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_PropertyCategoryBindingSource
            // 
            this.product_PropertyCategoryBindingSource.DataMember = "Product_PropertyCategory";
            this.product_PropertyCategoryBindingSource.DataSource = this.productQT;
            // 
            // product_PropertyCategoryTableAdapter
            // 
            this.product_PropertyCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.Configuration_PropertyTableAdapter = null;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.Product_PropertyCategoryTableAdapter = this.product_PropertyCategoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = WSS.Crl.ProducProperties.Manager.ProductQTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // product_PropertyCategoryBindingNavigator
            // 
            this.product_PropertyCategoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.product_PropertyCategoryBindingNavigator.BindingSource = this.product_PropertyCategoryBindingSource;
            this.product_PropertyCategoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.product_PropertyCategoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.product_PropertyCategoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.product_PropertyCategoryBindingNavigatorSaveItem});
            this.product_PropertyCategoryBindingNavigator.Location = new System.Drawing.Point(0, 44);
            this.product_PropertyCategoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.product_PropertyCategoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.product_PropertyCategoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.product_PropertyCategoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.product_PropertyCategoryBindingNavigator.Name = "product_PropertyCategoryBindingNavigator";
            this.product_PropertyCategoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.product_PropertyCategoryBindingNavigator.Size = new System.Drawing.Size(1023, 25);
            this.product_PropertyCategoryBindingNavigator.TabIndex = 3;
            this.product_PropertyCategoryBindingNavigator.Text = "bindingNavigator1";
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
            // product_PropertyCategoryBindingNavigatorSaveItem
            // 
            this.product_PropertyCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.product_PropertyCategoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("product_PropertyCategoryBindingNavigatorSaveItem.Image")));
            this.product_PropertyCategoryBindingNavigatorSaveItem.Name = "product_PropertyCategoryBindingNavigatorSaveItem";
            this.product_PropertyCategoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.product_PropertyCategoryBindingNavigatorSaveItem.Text = "Save Data";
            this.product_PropertyCategoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.product_PropertyCategoryBindingNavigatorSaveItem_Click);
            // 
            // product_PropertyCategoryGridControl
            // 
            this.product_PropertyCategoryGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.product_PropertyCategoryGridControl.DataSource = this.product_PropertyCategoryBindingSource;
            this.product_PropertyCategoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_PropertyCategoryGridControl.Location = new System.Drawing.Point(0, 69);
            this.product_PropertyCategoryGridControl.MainView = this.gridView1;
            this.product_PropertyCategoryGridControl.Name = "product_PropertyCategoryGridControl";
            this.product_PropertyCategoryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1});
            this.product_PropertyCategoryGridControl.Size = new System.Drawing.Size(1023, 523);
            this.product_PropertyCategoryGridControl.TabIndex = 3;
            this.product_PropertyCategoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCompanyId,
            this.colName,
            this.colProperty_Id});
            this.gridView1.GridControl = this.product_PropertyCategoryGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.DataSource = this.propertiesWssBindingSource;
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.ValueMember = "ID";
            this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // propertiesWssBindingSource
            // 
            this.propertiesWssBindingSource.DataMember = "PropertiesWss";
            this.propertiesWssBindingSource.DataSource = this.productQT;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCompanyId
            // 
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.Visible = true;
            this.colCompanyId.VisibleIndex = 0;
            this.colCompanyId.Width = 167;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 171;
            // 
            // colProperty_Id
            // 
            this.colProperty_Id.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.colProperty_Id.FieldName = "Property_Id";
            this.colProperty_Id.Name = "colProperty_Id";
            this.colProperty_Id.Visible = true;
            this.colProperty_Id.VisibleIndex = 2;
            this.colProperty_Id.Width = 667;
            // 
            // propertiesWssTableAdapter
            // 
            this.propertiesWssTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMapProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 592);
            this.Controls.Add(this.product_PropertyCategoryGridControl);
            this.Controls.Add(this.product_PropertyCategoryBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMapProperties";
            this.Text = "Map properties vs properties root product";
            this.Load += new System.EventHandler(this.FrmMapProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productQT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_PropertyCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_PropertyCategoryBindingNavigator)).EndInit();
            this.product_PropertyCategoryBindingNavigator.ResumeLayout(false);
            this.product_PropertyCategoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_PropertyCategoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesWssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ProductQT productQT;
        private System.Windows.Forms.BindingSource product_PropertyCategoryBindingSource;
        private ProductQTTableAdapters.Product_PropertyCategoryTableAdapter product_PropertyCategoryTableAdapter;
        private ProductQTTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator product_PropertyCategoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton product_PropertyCategoryBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl product_PropertyCategoryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colProperty_Id;
        private System.Windows.Forms.BindingSource propertiesWssBindingSource;
        private ProductQTTableAdapters.PropertiesWssTableAdapter propertiesWssTableAdapter;
    }
}