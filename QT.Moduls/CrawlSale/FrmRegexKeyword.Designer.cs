namespace QT.Moduls.CrawlSale
{
    partial class FrmRegexKeyword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegexKeyword));
            this.crawlerSaleNew = new QT.Moduls.CrawlSale.CrawlerSaleNew();
            this.regexFindKeyWordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regexFindKeyWordTableAdapter = new QT.Moduls.CrawlSale.CrawlerSaleNewTableAdapters.RegexFindKeyWordTableAdapter();
            this.tableAdapterManager = new QT.Moduls.CrawlSale.CrawlerSaleNewTableAdapters.TableAdapterManager();
            this.regexFindKeyWordBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.regexFindKeyWordBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.regexFindKeyWordGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerSaleNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexFindKeyWordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexFindKeyWordBindingNavigator)).BeginInit();
            this.regexFindKeyWordBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regexFindKeyWordGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // crawlerSaleNew
            // 
            this.crawlerSaleNew.DataSetName = "CrawlerSaleNew";
            this.crawlerSaleNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regexFindKeyWordBindingSource
            // 
            this.regexFindKeyWordBindingSource.DataMember = "RegexFindKeyWord";
            this.regexFindKeyWordBindingSource.DataSource = this.crawlerSaleNew;
            // 
            // regexFindKeyWordTableAdapter
            // 
            this.regexFindKeyWordTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RegexFindKeyWordTableAdapter = this.regexFindKeyWordTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.CrawlSale.CrawlerSaleNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // regexFindKeyWordBindingNavigator
            // 
            this.regexFindKeyWordBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.regexFindKeyWordBindingNavigator.BindingSource = this.regexFindKeyWordBindingSource;
            this.regexFindKeyWordBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.regexFindKeyWordBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.regexFindKeyWordBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.regexFindKeyWordBindingNavigatorSaveItem});
            this.regexFindKeyWordBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.regexFindKeyWordBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.regexFindKeyWordBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.regexFindKeyWordBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.regexFindKeyWordBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.regexFindKeyWordBindingNavigator.Name = "regexFindKeyWordBindingNavigator";
            this.regexFindKeyWordBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.regexFindKeyWordBindingNavigator.Size = new System.Drawing.Size(576, 25);
            this.regexFindKeyWordBindingNavigator.TabIndex = 0;
            this.regexFindKeyWordBindingNavigator.Text = "bindingNavigator1";
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
            // regexFindKeyWordBindingNavigatorSaveItem
            // 
            this.regexFindKeyWordBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.regexFindKeyWordBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("regexFindKeyWordBindingNavigatorSaveItem.Image")));
            this.regexFindKeyWordBindingNavigatorSaveItem.Name = "regexFindKeyWordBindingNavigatorSaveItem";
            this.regexFindKeyWordBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.regexFindKeyWordBindingNavigatorSaveItem.Text = "Save Data";
            this.regexFindKeyWordBindingNavigatorSaveItem.Click += new System.EventHandler(this.regexFindKeyWordBindingNavigatorSaveItem_Click);
            // 
            // regexFindKeyWordGridControl
            // 
            this.regexFindKeyWordGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.regexFindKeyWordGridControl.DataSource = this.regexFindKeyWordBindingSource;
            this.regexFindKeyWordGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regexFindKeyWordGridControl.Location = new System.Drawing.Point(0, 25);
            this.regexFindKeyWordGridControl.MainView = this.gridView1;
            this.regexFindKeyWordGridControl.Name = "regexFindKeyWordGridControl";
            this.regexFindKeyWordGridControl.Size = new System.Drawing.Size(576, 431);
            this.regexFindKeyWordGridControl.TabIndex = 1;
            this.regexFindKeyWordGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.regexFindKeyWordGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // FrmRegexKeyword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 456);
            this.Controls.Add(this.regexFindKeyWordGridControl);
            this.Controls.Add(this.regexFindKeyWordBindingNavigator);
            this.KeyPreview = true;
            this.Name = "FrmRegexKeyword";
            this.Text = "Regex lọc keyword";
            this.Load += new System.EventHandler(this.FrmRegexKeyword_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRegexKeyword_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.crawlerSaleNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexFindKeyWordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexFindKeyWordBindingNavigator)).EndInit();
            this.regexFindKeyWordBindingNavigator.ResumeLayout(false);
            this.regexFindKeyWordBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regexFindKeyWordGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrawlerSaleNew crawlerSaleNew;
        private System.Windows.Forms.BindingSource regexFindKeyWordBindingSource;
        private CrawlerSaleNewTableAdapters.RegexFindKeyWordTableAdapter regexFindKeyWordTableAdapter;
        private CrawlerSaleNewTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator regexFindKeyWordBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton regexFindKeyWordBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl regexFindKeyWordGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}