namespace WSS.IndividualCategoryWebsites
{
    partial class CtrlWebsite
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
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label domainLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.domainTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.websitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBIndi = new WSS.IndividualCategoryWebsites.DBIndi();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getRootProductToWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerRootProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTagInWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websitesTableAdapter = new WSS.IndividualCategoryWebsites.DBIndiTableAdapters.WebsitesTableAdapter();
            this.tableAdapterManager = new WSS.IndividualCategoryWebsites.DBIndiTableAdapters.TableAdapterManager();
            this.websitesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewWebsites = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            idLabel1 = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIndi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.websitesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWebsites)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(5, 21);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 2;
            idLabel1.Text = "Id:";
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(148, 21);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 3;
            domainLabel.Text = "Domain:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(domainLabel);
            this.panelControl1.Controls.Add(this.domainTextEdit);
            this.panelControl1.Controls.Add(idLabel1);
            this.panelControl1.Controls.Add(this.idTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(380, 62);
            this.panelControl1.TabIndex = 0;
            // 
            // domainTextEdit
            // 
            this.domainTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.websitesBindingSource, "Domain", true));
            this.domainTextEdit.Location = new System.Drawing.Point(200, 18);
            this.domainTextEdit.Name = "domainTextEdit";
            this.domainTextEdit.Size = new System.Drawing.Size(157, 20);
            this.domainTextEdit.TabIndex = 4;
            // 
            // websitesBindingSource
            // 
            this.websitesBindingSource.DataMember = "Websites";
            this.websitesBindingSource.DataSource = this.dBIndi;
            // 
            // dBIndi
            // 
            this.dBIndi.DataSetName = "DBIndi";
            this.dBIndi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.websitesBindingSource, "Id", true));
            this.idTextEdit.Location = new System.Drawing.Point(30, 18);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Size = new System.Drawing.Size(87, 20);
            this.idTextEdit.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getRootProductToWebsiteToolStripMenuItem,
            this.managerRootProductToolStripMenuItem,
            this.viewTagInWebsiteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(260, 92);
            // 
            // getRootProductToWebsiteToolStripMenuItem
            // 
            this.getRootProductToWebsiteToolStripMenuItem.Name = "getRootProductToWebsiteToolStripMenuItem";
            this.getRootProductToWebsiteToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.getRootProductToWebsiteToolStripMenuItem.Text = "Tạo sản phẩm gốc cho website";
            this.getRootProductToWebsiteToolStripMenuItem.Click += new System.EventHandler(this.getRootProductToWebsiteToolStripMenuItem_Click);
            // 
            // managerRootProductToolStripMenuItem
            // 
            this.managerRootProductToolStripMenuItem.Name = "managerRootProductToolStripMenuItem";
            this.managerRootProductToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.managerRootProductToolStripMenuItem.Text = "Quản lý sản phẩm gốc cho website";
            this.managerRootProductToolStripMenuItem.Click += new System.EventHandler(this.managerRootProductToolStripMenuItem_Click);
            // 
            // viewTagInWebsiteToolStripMenuItem
            // 
            this.viewTagInWebsiteToolStripMenuItem.Name = "viewTagInWebsiteToolStripMenuItem";
            this.viewTagInWebsiteToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.viewTagInWebsiteToolStripMenuItem.Text = "Quản lý Tag cho website";
            this.viewTagInWebsiteToolStripMenuItem.Click += new System.EventHandler(this.viewTagInWebsiteToolStripMenuItem_Click);
            // 
            // websitesTableAdapter
            // 
            this.websitesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.RootProductsTableAdapter = null;
            this.tableAdapterManager.TagsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.IndividualCategoryWebsites.DBIndiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WebsitesTableAdapter = this.websitesTableAdapter;
            // 
            // websitesGridControl
            // 
            this.websitesGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.websitesGridControl.DataSource = this.websitesBindingSource;
            this.websitesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.websitesGridControl.Location = new System.Drawing.Point(0, 62);
            this.websitesGridControl.MainView = this.gridViewWebsites;
            this.websitesGridControl.Name = "websitesGridControl";
            this.websitesGridControl.Size = new System.Drawing.Size(380, 469);
            this.websitesGridControl.TabIndex = 3;
            this.websitesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWebsites});
            // 
            // gridViewWebsites
            // 
            this.gridViewWebsites.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDomain,
            this.colDescription});
            this.gridViewWebsites.GridControl = this.websitesGridControl;
            this.gridViewWebsites.Name = "gridViewWebsites";
            this.gridViewWebsites.OptionsBehavior.Editable = false;
            this.gridViewWebsites.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewWebsites_MouseDown);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 59;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 1;
            this.colDomain.Width = 196;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 137;
            // 
            // CtrlWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.websitesGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "CtrlWebsite";
            this.Size = new System.Drawing.Size(380, 531);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIndi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.websitesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWebsites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem getRootProductToWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerRootProductToolStripMenuItem;
        private DBIndi dBIndi;
        private System.Windows.Forms.BindingSource websitesBindingSource;
        private DBIndiTableAdapters.WebsitesTableAdapter websitesTableAdapter;
        private DBIndiTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl websitesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWebsites;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.TextEdit domainTextEdit;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private System.Windows.Forms.ToolStripMenuItem viewTagInWebsiteToolStripMenuItem;
    }
}
