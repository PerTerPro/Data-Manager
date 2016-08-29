namespace QT.Moduls.Excel
{
    partial class frmProductToExcel
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dBRoot = new QT.Moduls.Excel.DBRoot();
            this.productNotMapRootBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNotMapRootTableAdapter = new QT.Moduls.Excel.DBRootTableAdapters.ProductNotMapRootTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Excel.DBRootTableAdapters.TableAdapterManager();
            this.productNotMapRootGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNotRoot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameFT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountFail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNotMapRootBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNotMapRootGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(886, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(116, 46);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Export";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1048, 64);
            this.panelControl1.TabIndex = 1;
            // 
            // dBRoot
            // 
            this.dBRoot.DataSetName = "DBRoot";
            this.dBRoot.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productNotMapRootBindingSource
            // 
            this.productNotMapRootBindingSource.DataMember = "ProductNotMapRoot";
            this.productNotMapRootBindingSource.DataSource = this.dBRoot;
            // 
            // productNotMapRootTableAdapter
            // 
            this.productNotMapRootTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductNotMapRootTableAdapter = this.productNotMapRootTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Excel.DBRootTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productNotMapRootGridControl
            // 
            this.productNotMapRootGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.productNotMapRootGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productNotMapRootGridControl.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.productNotMapRootGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.productNotMapRootGridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.productNotMapRootGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.productNotMapRootGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.productNotMapRootGridControl.Location = new System.Drawing.Point(0, 64);
            this.productNotMapRootGridControl.MainView = this.gridView1;
            this.productNotMapRootGridControl.Name = "productNotMapRootGridControl";
            this.productNotMapRootGridControl.Size = new System.Drawing.Size(1048, 479);
            this.productNotMapRootGridControl.TabIndex = 2;
            this.productNotMapRootGridControl.UseEmbeddedNavigator = true;
            this.productNotMapRootGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDNotRoot,
            this.colIDCompany,
            this.colDateAdd,
            this.colName,
            this.colNameFT,
            this.colLength,
            this.colCountFail});
            this.gridView1.GridControl = this.productNotMapRootGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colIDNotRoot
            // 
            this.colIDNotRoot.FieldName = "IDNotRoot";
            this.colIDNotRoot.Name = "colIDNotRoot";
            this.colIDNotRoot.Visible = true;
            this.colIDNotRoot.VisibleIndex = 0;
            // 
            // colIDCompany
            // 
            this.colIDCompany.FieldName = "IDCompany";
            this.colIDCompany.Name = "colIDCompany";
            this.colIDCompany.Visible = true;
            this.colIDCompany.VisibleIndex = 1;
            // 
            // colDateAdd
            // 
            this.colDateAdd.FieldName = "DateAdd";
            this.colDateAdd.Name = "colDateAdd";
            this.colDateAdd.Visible = true;
            this.colDateAdd.VisibleIndex = 2;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            // 
            // colNameFT
            // 
            this.colNameFT.FieldName = "NameFT";
            this.colNameFT.Name = "colNameFT";
            this.colNameFT.OptionsColumn.ReadOnly = true;
            this.colNameFT.Visible = true;
            this.colNameFT.VisibleIndex = 4;
            // 
            // colLength
            // 
            this.colLength.FieldName = "Length";
            this.colLength.Name = "colLength";
            this.colLength.Visible = true;
            this.colLength.VisibleIndex = 5;
            // 
            // colCountFail
            // 
            this.colCountFail.FieldName = "CountFail";
            this.colCountFail.Name = "colCountFail";
            this.colCountFail.Visible = true;
            this.colCountFail.VisibleIndex = 6;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(116, 46);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Load";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmProductToExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.Controls.Add(this.productNotMapRootGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmProductToExcel";
            this.Text = "frmProductToExcel";
            this.Load += new System.EventHandler(this.frmProductToExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNotMapRootBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNotMapRootGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBRoot dBRoot;
        private System.Windows.Forms.BindingSource productNotMapRootBindingSource;
        private DBRootTableAdapters.ProductNotMapRootTableAdapter productNotMapRootTableAdapter;
        private DBRootTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl productNotMapRootGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNotRoot;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colDateAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNameFT;
        private DevExpress.XtraGrid.Columns.GridColumn colLength;
        private DevExpress.XtraGrid.Columns.GridColumn colCountFail;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}