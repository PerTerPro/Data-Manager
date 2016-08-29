namespace QT.Moduls.CrawlSale
{
    partial class FrmConfigGetKeywordTerm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigGetKeywordTerm));
            this.saleNewsDataSet = new QT.Moduls.SaleNewsDataSet();
            this.configGetKeywordTermBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configGetKeywordTermTableAdapter = new QT.Moduls.SaleNewsDataSetTableAdapters.ConfigGetKeywordTermTableAdapter();
            this.tableAdapterManager = new QT.Moduls.SaleNewsDataSetTableAdapters.TableAdapterManager();
            this.configGetKeywordTermBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.configGetKeywordTermBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.configGetKeywordTermGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.saleNewsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configGetKeywordTermBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configGetKeywordTermBindingNavigator)).BeginInit();
            this.configGetKeywordTermBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configGetKeywordTermGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // saleNewsDataSet
            // 
            this.saleNewsDataSet.DataSetName = "SaleNewsDataSet";
            this.saleNewsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configGetKeywordTermBindingSource
            // 
            this.configGetKeywordTermBindingSource.DataMember = "ConfigGetKeywordTerm";
            this.configGetKeywordTermBindingSource.DataSource = this.saleNewsDataSet;
            // 
            // configGetKeywordTermTableAdapter
            // 
            this.configGetKeywordTermTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.ConfigGetKeywordTermTableAdapter = this.configGetKeywordTermTableAdapter;
            this.tableAdapterManager.ConfigTableAdapter = null;
            this.tableAdapterManager.KeyWordProductTableAdapter = null;
            this.tableAdapterManager.KeyWords1TableAdapter = null;
            this.tableAdapterManager.KeywordsTableAdapter = null;
            this.tableAdapterManager.LogErrorCrawlTableAdapter = null;
            this.tableAdapterManager.SanPhamMauOToTableAdapter = null;
            this.tableAdapterManager.SessionRunTableAdapter = null;
            this.tableAdapterManager.Sheet1_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.SaleNewsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WebCategoryTableAdapter = null;
            this.tableAdapterManager.WebSiteTableAdapter = null;
            // 
            // configGetKeywordTermBindingNavigator
            // 
            this.configGetKeywordTermBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.configGetKeywordTermBindingNavigator.BindingSource = this.configGetKeywordTermBindingSource;
            this.configGetKeywordTermBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.configGetKeywordTermBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.configGetKeywordTermBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.configGetKeywordTermBindingNavigatorSaveItem});
            this.configGetKeywordTermBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.configGetKeywordTermBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.configGetKeywordTermBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.configGetKeywordTermBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.configGetKeywordTermBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.configGetKeywordTermBindingNavigator.Name = "configGetKeywordTermBindingNavigator";
            this.configGetKeywordTermBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.configGetKeywordTermBindingNavigator.Size = new System.Drawing.Size(791, 25);
            this.configGetKeywordTermBindingNavigator.TabIndex = 0;
            this.configGetKeywordTermBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // configGetKeywordTermBindingNavigatorSaveItem
            // 
            this.configGetKeywordTermBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.configGetKeywordTermBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("configGetKeywordTermBindingNavigatorSaveItem.Image")));
            this.configGetKeywordTermBindingNavigatorSaveItem.Name = "configGetKeywordTermBindingNavigatorSaveItem";
            this.configGetKeywordTermBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.configGetKeywordTermBindingNavigatorSaveItem.Text = "Save Data";
            this.configGetKeywordTermBindingNavigatorSaveItem.Click += new System.EventHandler(this.configGetKeywordTermBindingNavigatorSaveItem_Click);
            // 
            // configGetKeywordTermGridControl
            // 
            this.configGetKeywordTermGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.configGetKeywordTermGridControl.DataSource = this.configGetKeywordTermBindingSource;
            this.configGetKeywordTermGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configGetKeywordTermGridControl.Location = new System.Drawing.Point(0, 25);
            this.configGetKeywordTermGridControl.MainView = this.gridView1;
            this.configGetKeywordTermGridControl.Name = "configGetKeywordTermGridControl";
            this.configGetKeywordTermGridControl.Size = new System.Drawing.Size(791, 442);
            this.configGetKeywordTermGridControl.TabIndex = 1;
            this.configGetKeywordTermGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.configGetKeywordTermGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // FrmConfigGetKeywordTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 467);
            this.Controls.Add(this.configGetKeywordTermGridControl);
            this.Controls.Add(this.configGetKeywordTermBindingNavigator);
            this.Name = "FrmConfigGetKeywordTerm";
            this.Text = "FrmConfigGetKeywordTerm";
            this.Load += new System.EventHandler(this.FrmConfigGetKeywordTerm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleNewsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configGetKeywordTermBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configGetKeywordTermBindingNavigator)).EndInit();
            this.configGetKeywordTermBindingNavigator.ResumeLayout(false);
            this.configGetKeywordTermBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configGetKeywordTermGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaleNewsDataSet saleNewsDataSet;
        private System.Windows.Forms.BindingSource configGetKeywordTermBindingSource;
        private SaleNewsDataSetTableAdapters.ConfigGetKeywordTermTableAdapter configGetKeywordTermTableAdapter;
        private SaleNewsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator configGetKeywordTermBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton configGetKeywordTermBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl configGetKeywordTermGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}