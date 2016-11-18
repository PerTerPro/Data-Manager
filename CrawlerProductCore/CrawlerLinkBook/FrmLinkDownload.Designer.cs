namespace CrawlerLinkBook
{
    partial class FrmLinkDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLinkDownload));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsDownloadBook = new CrawlerLinkBook.DsDownloadBook();
            this.linkItbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkItbookTableAdapter = new CrawlerLinkBook.DsDownloadBookTableAdapters.LinkItbookTableAdapter();
            this.tableAdapterManager = new CrawlerLinkBook.DsDownloadBookTableAdapters.TableAdapterManager();
            this.linkItbookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.linkItbookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.linkItbookGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountPage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinkDownload = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDownloaded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDownloadBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkItbookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkItbookBindingNavigator)).BeginInit();
            this.linkItbookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkItbookGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 26);
            // 
            // downloadedToolStripMenuItem
            // 
            this.downloadedToolStripMenuItem.Name = "downloadedToolStripMenuItem";
            this.downloadedToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.downloadedToolStripMenuItem.Text = "Downloaded";
            this.downloadedToolStripMenuItem.Click += new System.EventHandler(this.downloadedToolStripMenuItem_Click);
            // 
            // dsDownloadBook
            // 
            this.dsDownloadBook.DataSetName = "DsDownloadBook";
            this.dsDownloadBook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linkItbookBindingSource
            // 
            this.linkItbookBindingSource.DataMember = "LinkItbook";
            this.linkItbookBindingSource.DataSource = this.dsDownloadBook;
            // 
            // linkItbookTableAdapter
            // 
            this.linkItbookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LinkItbookTableAdapter = this.linkItbookTableAdapter;
            this.tableAdapterManager.UpdateOrder = CrawlerLinkBook.DsDownloadBookTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // linkItbookBindingNavigator
            // 
            this.linkItbookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.linkItbookBindingNavigator.BindingSource = this.linkItbookBindingSource;
            this.linkItbookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.linkItbookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.linkItbookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.linkItbookBindingNavigatorSaveItem});
            this.linkItbookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.linkItbookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.linkItbookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.linkItbookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.linkItbookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.linkItbookBindingNavigator.Name = "linkItbookBindingNavigator";
            this.linkItbookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.linkItbookBindingNavigator.Size = new System.Drawing.Size(971, 25);
            this.linkItbookBindingNavigator.TabIndex = 1;
            this.linkItbookBindingNavigator.Text = "bindingNavigator1";
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
            // linkItbookBindingNavigatorSaveItem
            // 
            this.linkItbookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.linkItbookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("linkItbookBindingNavigatorSaveItem.Image")));
            this.linkItbookBindingNavigatorSaveItem.Name = "linkItbookBindingNavigatorSaveItem";
            this.linkItbookBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.linkItbookBindingNavigatorSaveItem.Text = "Save Data";
            this.linkItbookBindingNavigatorSaveItem.Click += new System.EventHandler(this.linkItbookBindingNavigatorSaveItem_Click);
            // 
            // linkItbookGridControl
            // 
            this.linkItbookGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkItbookGridControl.DataSource = this.linkItbookBindingSource;
            this.linkItbookGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkItbookGridControl.Location = new System.Drawing.Point(0, 25);
            this.linkItbookGridControl.MainView = this.gridView1;
            this.linkItbookGridControl.Name = "linkItbookGridControl";
            this.linkItbookGridControl.Size = new System.Drawing.Size(971, 514);
            this.linkItbookGridControl.TabIndex = 2;
            this.linkItbookGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.linkItbookGridControl.Click += new System.EventHandler(this.linkItbookGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colLink,
            this.colName,
            this.colCountPage,
            this.colLinkDownload,
            this.colDownloaded});
            this.gridView1.GridControl = this.linkItbookGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colLink
            // 
            this.colLink.FieldName = "Link";
            this.colLink.Name = "colLink";
            this.colLink.OptionsColumn.AllowEdit = false;
            this.colLink.OptionsColumn.ReadOnly = true;
            this.colLink.Visible = true;
            this.colLink.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colCountPage
            // 
            this.colCountPage.FieldName = "CountPage";
            this.colCountPage.Name = "colCountPage";
            this.colCountPage.Visible = true;
            this.colCountPage.VisibleIndex = 3;
            // 
            // colLinkDownload
            // 
            this.colLinkDownload.FieldName = "LinkDownload";
            this.colLinkDownload.Name = "colLinkDownload";
            this.colLinkDownload.OptionsColumn.AllowEdit = false;
            this.colLinkDownload.OptionsColumn.ReadOnly = true;
            this.colLinkDownload.Visible = true;
            this.colLinkDownload.VisibleIndex = 4;
            // 
            // colDownloaded
            // 
            this.colDownloaded.FieldName = "Downloaded";
            this.colDownloaded.Name = "colDownloaded";
            this.colDownloaded.Visible = true;
            this.colDownloaded.VisibleIndex = 5;
            // 
            // FrmLinkDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 539);
            this.Controls.Add(this.linkItbookGridControl);
            this.Controls.Add(this.linkItbookBindingNavigator);
            this.Name = "FrmLinkDownload";
            this.Text = "FrmLinkDownload";
            this.Load += new System.EventHandler(this.FrmLinkDownload_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsDownloadBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkItbookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkItbookBindingNavigator)).EndInit();
            this.linkItbookBindingNavigator.ResumeLayout(false);
            this.linkItbookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkItbookGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem downloadedToolStripMenuItem;
        private DsDownloadBook dsDownloadBook;
        private System.Windows.Forms.BindingSource linkItbookBindingSource;
        private DsDownloadBookTableAdapters.LinkItbookTableAdapter linkItbookTableAdapter;
        private DsDownloadBookTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator linkItbookBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton linkItbookBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl linkItbookGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colLink;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountPage;
        private DevExpress.XtraGrid.Columns.GridColumn colLinkDownload;
        private DevExpress.XtraGrid.Columns.GridColumn colDownloaded;

    }
}