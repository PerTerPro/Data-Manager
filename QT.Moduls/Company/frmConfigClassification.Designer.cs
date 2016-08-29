namespace QT.Moduls.Company
{
    partial class frmConfigClassification
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
            System.Windows.Forms.Label iDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigClassification));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.companyGridControl = new DevExpress.XtraGrid.GridControl();
            this.companyBindingSource = new System.Windows.Forms.BindingSource();
            this.dBCom = new QT.Moduls.Company.DBCom();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.iDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonCheckCompany = new DevExpress.XtraEditors.SimpleButton();
            this.textEditDomain = new DevExpress.XtraEditors.TextEdit();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.companyTableAdapter = new QT.Moduls.Company.DBComTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Company.DBComTableAdapters.TableAdapterManager();
            this.classificationTableAdapter = new QT.Moduls.Company.DBComTableAdapters.ClassificationTableAdapter();
            this.classificationBindingSource = new System.Windows.Forms.BindingSource();
            this.classificationGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource();
            this.colIDCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsBlacklist = new DevExpress.XtraGrid.Columns.GridColumn();
            this.listClassificationTableAdapter = new QT.Moduls.Company.DBComTableAdapters.ListClassificationTableAdapter();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDomain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(32, 95);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(319, 644);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.companyGridControl);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 75);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(315, 567);
            this.panelControl3.TabIndex = 2;
            // 
            // companyGridControl
            // 
            this.companyGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.companyGridControl.DataSource = this.companyBindingSource;
            this.companyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyGridControl.Location = new System.Drawing.Point(2, 2);
            this.companyGridControl.MainView = this.gridView1;
            this.companyGridControl.Name = "companyGridControl";
            this.companyGridControl.Size = new System.Drawing.Size(311, 563);
            this.companyGridControl.TabIndex = 0;
            this.companyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBCom;
            // 
            // dBCom
            // 
            this.dBCom.DataSetName = "DBCom";
            this.dBCom.EnforceConstraints = false;
            this.dBCom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1});
            this.gridView1.GridControl = this.companyGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Domain";
            this.gridColumn1.FieldName = "Domain";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.iDTextEdit);
            this.panelControl2.Controls.Add(iDLabel);
            this.panelControl2.Controls.Add(this.simpleButtonCheckCompany);
            this.panelControl2.Controls.Add(this.textEditDomain);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(315, 73);
            this.panelControl2.TabIndex = 1;
            // 
            // iDTextEdit
            // 
            this.iDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "ID", true));
            this.iDTextEdit.Location = new System.Drawing.Point(74, 92);
            this.iDTextEdit.Name = "iDTextEdit";
            this.iDTextEdit.Size = new System.Drawing.Size(100, 20);
            this.iDTextEdit.TabIndex = 3;
            // 
            // simpleButtonCheckCompany
            // 
            this.simpleButtonCheckCompany.Location = new System.Drawing.Point(200, 9);
            this.simpleButtonCheckCompany.Name = "simpleButtonCheckCompany";
            this.simpleButtonCheckCompany.Size = new System.Drawing.Size(100, 54);
            this.simpleButtonCheckCompany.TabIndex = 1;
            this.simpleButtonCheckCompany.Text = "Company";
            this.simpleButtonCheckCompany.Click += new System.EventHandler(this.simpleButtonCheckCompany_Click);
            // 
            // textEditDomain
            // 
            this.textEditDomain.Location = new System.Drawing.Point(21, 26);
            this.textEditDomain.Name = "textEditDomain";
            this.textEditDomain.Size = new System.Drawing.Size(153, 20);
            this.textEditDomain.TabIndex = 0;
            this.textEditDomain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditDomain_KeyDown);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
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
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(319, 619);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(883, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton1.Text = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = this.classificationTableAdapter;
            this.tableAdapterManager.Company_AddressTableAdapter = null;
            this.tableAdapterManager.Company_ImageTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.DatafeedConfigTableAdapter = null;
            this.tableAdapterManager.Job_WebsiteConfigLogTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.ManagerCompanyLogTableAdapter = null;
            this.tableAdapterManager.ManagerCompanyLogTypeTableAdapter = null;
            this.tableAdapterManager.ManagerCrawlerTableAdapter = null;
            this.tableAdapterManager.ManagerTypeRCompanyTableAdapter = null;
            this.tableAdapterManager.ManagerTypeTableAdapter = null;
            this.tableAdapterManager.ProductQuangCaoTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Company.DBComTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // classificationTableAdapter
            // 
            this.classificationTableAdapter.ClearBeforeFill = true;
            // 
            // classificationBindingSource
            // 
            this.classificationBindingSource.DataMember = "Classification";
            this.classificationBindingSource.DataSource = this.dBCom;
            // 
            // classificationGridControl
            // 
            this.classificationGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.classificationGridControl.DataSource = this.classificationBindingSource;
            this.classificationGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classificationGridControl.Location = new System.Drawing.Point(319, 0);
            this.classificationGridControl.MainView = this.gridView2;
            this.classificationGridControl.Name = "classificationGridControl";
            this.classificationGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.classificationGridControl.Size = new System.Drawing.Size(883, 619);
            this.classificationGridControl.TabIndex = 2;
            this.classificationGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colIDCategory,
            this.colIDCompany,
            this.colIsBlacklist});
            this.gridView2.GridControl = this.classificationGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 88;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 264;
            // 
            // colIDCategory
            // 
            this.colIDCategory.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIDCategory.FieldName = "IDCategory";
            this.colIDCategory.Name = "colIDCategory";
            this.colIDCategory.Visible = true;
            this.colIDCategory.VisibleIndex = 3;
            this.colIDCategory.Width = 140;
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dBCom;
            // 
            // colIDCompany
            // 
            this.colIDCompany.FieldName = "IDCompany";
            this.colIDCompany.Name = "colIDCompany";
            this.colIDCompany.OptionsColumn.ReadOnly = true;
            this.colIDCompany.Visible = true;
            this.colIDCompany.VisibleIndex = 1;
            this.colIDCompany.Width = 120;
            // 
            // colIsBlacklist
            // 
            this.colIsBlacklist.FieldName = "IsBlacklist";
            this.colIsBlacklist.Name = "colIsBlacklist";
            this.colIsBlacklist.Visible = true;
            this.colIsBlacklist.VisibleIndex = 4;
            this.colIsBlacklist.Width = 252;
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repositoryItemLookUpEdit1.DataSource = this.listClassificationBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // frmConfigClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 644);
            this.Controls.Add(this.classificationGridControl);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmConfigClassification";
            this.Text = "frmConfigClassification";
            this.Load += new System.EventHandler(this.frmConfigClassification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDomain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCheckCompany;
        private DevExpress.XtraEditors.TextEdit textEditDomain;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DBCom dBCom;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBComTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DBComTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl companyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DBComTableAdapters.ClassificationTableAdapter classificationTableAdapter;
        private System.Windows.Forms.BindingSource classificationBindingSource;
        private DevExpress.XtraGrid.GridControl classificationGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit iDTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colIsBlacklist;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DBComTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;

    }
}