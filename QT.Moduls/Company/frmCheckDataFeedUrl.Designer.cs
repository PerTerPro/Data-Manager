namespace QT.Moduls.Company
{
    partial class frmCheckDataFeedUrl
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonExport = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.companyGridControl = new DevExpress.XtraGrid.GridControl();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCom = new QT.Moduls.Company.DBCom();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.companyTableAdapter = new QT.Moduls.Company.DBComTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Company.DBComTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonExport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1075, 39);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButtonExport
            // 
            this.simpleButtonExport.Location = new System.Drawing.Point(965, 5);
            this.simpleButtonExport.Name = "simpleButtonExport";
            this.simpleButtonExport.Size = new System.Drawing.Size(98, 29);
            this.simpleButtonExport.TabIndex = 0;
            this.simpleButtonExport.Text = "Export";
            this.simpleButtonExport.Click += new System.EventHandler(this.simpleButtonExport_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.companyGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 39);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1075, 497);
            this.panelControl2.TabIndex = 1;
            // 
            // companyGridControl
            // 
            this.companyGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.companyGridControl.DataSource = this.companyBindingSource;
            this.companyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.companyGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.companyGridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.companyGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.companyGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.companyGridControl.Location = new System.Drawing.Point(0, 0);
            this.companyGridControl.MainView = this.gridView1;
            this.companyGridControl.Name = "companyGridControl";
            this.companyGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.companyGridControl.Size = new System.Drawing.Size(1075, 497);
            this.companyGridControl.TabIndex = 0;
            this.companyGridControl.UseEmbeddedNavigator = true;
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
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn4,
            this.gridColumn6});
            this.gridView1.GridControl = this.companyGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 176;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Domain";
            this.gridColumn2.FieldName = "Domain";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 206;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "DataFeedUrl";
            this.gridColumn3.FieldName = "DataFeedUrl";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 168;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "DataFeedType";
            this.gridColumn5.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gridColumn5.FieldName = "DataFeedType";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 168;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Value";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "LastUpdateDataFeed";
            this.gridColumn4.DisplayFormat.FormatString = "HH:mm:ss dd-MM-yyyy";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "LastUpdateDataFeed";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 168;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "LastUpdateSolr";
            this.gridColumn6.DisplayFormat.FormatString = "HH:mm:ss dd-MM-yyyy";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn6.FieldName = "LastUpdateSolr";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 170;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_AddressTableAdapter = null;
            this.tableAdapterManager.Company_ImageTableAdapter = null;
            this.tableAdapterManager.Company1TableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.DatafeedConfigTableAdapter = null;
            this.tableAdapterManager.HistoryDatafeedTableAdapter = null;
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
            // frmCheckDataFeedUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 536);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCheckDataFeedUrl";
            this.Text = "frmCheckDataFeedUrl";
            this.Load += new System.EventHandler(this.frmCheckDataFeedUrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DBCom dBCom;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBComTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DBComTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl companyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExport;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}