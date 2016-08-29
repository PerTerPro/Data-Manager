namespace QT.Moduls.CrawlSale
{
    partial class FrmWebSites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWebSites));
            this.crawlerSaleNew = new QT.Moduls.RaoVat.CrawlerSaleNew();
            this.webSiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webSiteTableAdapter = new QT.Moduls.RaoVat.CrawlerSaleNewTableAdapters.WebSiteTableAdapter();
            this.tableAdapterManager = new QT.Moduls.RaoVat.CrawlerSaleNewTableAdapters.TableAdapterManager();
            this.webSiteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.webSiteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.webSiteGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.danhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapClassificationCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colWebSiteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsiteDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsiteBaseLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsiteTimedelay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsiteConfigID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerSaleNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSiteBindingNavigator)).BeginInit();
            this.webSiteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webSiteGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // crawlerSaleNew
            // 
            this.crawlerSaleNew.DataSetName = "CrawlerSaleNew";
            this.crawlerSaleNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // webSiteBindingSource
            // 
            this.webSiteBindingSource.DataMember = "WebSite";
            this.webSiteBindingSource.DataSource = this.crawlerSaleNew;
            // 
            // webSiteTableAdapter
            // 
            this.webSiteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.config_run_crawlerTableAdapter = null;
            this.tableAdapterManager.RegexFindKeyWordTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.RaoVat.CrawlerSaleNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WebSiteTableAdapter = this.webSiteTableAdapter;
            // 
            // webSiteBindingNavigator
            // 
            this.webSiteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.webSiteBindingNavigator.BindingSource = this.webSiteBindingSource;
            this.webSiteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.webSiteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.webSiteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.webSiteBindingNavigatorSaveItem});
            this.webSiteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.webSiteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.webSiteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.webSiteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.webSiteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.webSiteBindingNavigator.Name = "webSiteBindingNavigator";
            this.webSiteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.webSiteBindingNavigator.Size = new System.Drawing.Size(759, 25);
            this.webSiteBindingNavigator.TabIndex = 0;
            this.webSiteBindingNavigator.Text = "bindingNavigator1";
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
            // webSiteBindingNavigatorSaveItem
            // 
            this.webSiteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.webSiteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("webSiteBindingNavigatorSaveItem.Image")));
            this.webSiteBindingNavigatorSaveItem.Name = "webSiteBindingNavigatorSaveItem";
            this.webSiteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.webSiteBindingNavigatorSaveItem.Text = "Save Data";
            this.webSiteBindingNavigatorSaveItem.Click += new System.EventHandler(this.webSiteBindingNavigatorSaveItem_Click);
            // 
            // webSiteGridControl
            // 
            this.webSiteGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.webSiteGridControl.DataSource = this.webSiteBindingSource;
            this.webSiteGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webSiteGridControl.Location = new System.Drawing.Point(0, 25);
            this.webSiteGridControl.MainView = this.gridView1;
            this.webSiteGridControl.Name = "webSiteGridControl";
            this.webSiteGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.webSiteGridControl.Size = new System.Drawing.Size(759, 412);
            this.webSiteGridControl.TabIndex = 1;
            this.webSiteGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.webSiteGridControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.webSiteGridControl_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWebSiteId,
            this.colWebsite,
            this.colWebsiteDomain,
            this.colWebsiteBaseLink,
            this.colWebsiteTimedelay,
            this.colWebsiteConfigID});
            this.gridView1.GridControl = this.webSiteGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchToolStripMenuItem,
            this.mapClassificationCategoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(234, 48);
            // 
            // danhSáchToolStripMenuItem
            // 
            this.danhSáchToolStripMenuItem.Name = "danhSáchToolStripMenuItem";
            this.danhSáchToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.danhSáchToolStripMenuItem.Text = "Map Classification ~ City";
            this.danhSáchToolStripMenuItem.Click += new System.EventHandler(this.danhSáchToolStripMenuItem_Click);
            // 
            // mapClassificationCategoryToolStripMenuItem
            // 
            this.mapClassificationCategoryToolStripMenuItem.Name = "mapClassificationCategoryToolStripMenuItem";
            this.mapClassificationCategoryToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.mapClassificationCategoryToolStripMenuItem.Text = "Map Classification ~ Category";
            this.mapClassificationCategoryToolStripMenuItem.Click += new System.EventHandler(this.mapClassificationCategoryToolStripMenuItem_Click);
            // 
            // colWebSiteId
            // 
            this.colWebSiteId.Caption = "id";
            this.colWebSiteId.FieldName = "id";
            this.colWebSiteId.Name = "colWebSiteId";
            this.colWebSiteId.Visible = true;
            this.colWebSiteId.VisibleIndex = 0;
            // 
            // colWebsite
            // 
            this.colWebsite.Caption = "colWebsite";
            this.colWebsite.FieldName = "website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 1;
            // 
            // colWebsiteDomain
            // 
            this.colWebsiteDomain.Caption = "domain";
            this.colWebsiteDomain.FieldName = "domain";
            this.colWebsiteDomain.Name = "colWebsiteDomain";
            this.colWebsiteDomain.Visible = true;
            this.colWebsiteDomain.VisibleIndex = 2;
            // 
            // colWebsiteBaseLink
            // 
            this.colWebsiteBaseLink.Caption = "base_link";
            this.colWebsiteBaseLink.FieldName = "base_link";
            this.colWebsiteBaseLink.Name = "colWebsiteBaseLink";
            this.colWebsiteBaseLink.Visible = true;
            this.colWebsiteBaseLink.VisibleIndex = 3;
            // 
            // colWebsiteTimedelay
            // 
            this.colWebsiteTimedelay.Caption = "time_delay";
            this.colWebsiteTimedelay.FieldName = "time_delay";
            this.colWebsiteTimedelay.Name = "colWebsiteTimedelay";
            this.colWebsiteTimedelay.Visible = true;
            this.colWebsiteTimedelay.VisibleIndex = 4;
            // 
            // colWebsiteConfigID
            // 
            this.colWebsiteConfigID.Caption = "config_id";
            this.colWebsiteConfigID.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colWebsiteConfigID.FieldName = "config_id";
            this.colWebsiteConfigID.Name = "colWebsiteConfigID";
            this.colWebsiteConfigID.Visible = true;
            this.colWebsiteConfigID.VisibleIndex = 5;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "name";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "id";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // FrmWebSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 437);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webSiteGridControl);
            this.Controls.Add(this.webSiteBindingNavigator);
            this.Name = "FrmWebSites";
            this.Text = "Danh sách website";
            this.Load += new System.EventHandler(this.FrmWebSite_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmWebSites_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.crawlerSaleNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSiteBindingNavigator)).EndInit();
            this.webSiteBindingNavigator.ResumeLayout(false);
            this.webSiteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webSiteGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RaoVat.CrawlerSaleNew crawlerSaleNew;
        private System.Windows.Forms.BindingSource webSiteBindingSource;
        private RaoVat.CrawlerSaleNewTableAdapters.WebSiteTableAdapter webSiteTableAdapter;
        private RaoVat.CrawlerSaleNewTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator webSiteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton webSiteBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl webSiteGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapClassificationCategoryToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colWebSiteId;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsiteDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsiteBaseLink;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsiteTimedelay;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsiteConfigID;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;

    }
}