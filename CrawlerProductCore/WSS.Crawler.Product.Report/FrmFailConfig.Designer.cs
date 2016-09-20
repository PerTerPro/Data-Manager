namespace WSS.Crawler.Product.Report
{
    partial class FrmFailConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFailConfig));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dsQT2 = new WSS.Crawler.Product.Report.DS.DsQT2();
            this.v_Company_FailConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_Company_FailConfigTableAdapter = new WSS.Crawler.Product.Report.DS.DsQT2TableAdapters.V_Company_FailConfigTableAdapter();
            this.tableAdapterManager = new WSS.Crawler.Product.Report.DS.DsQT2TableAdapters.TableAdapterManager();
            this.v_Company_FailConfigBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.v_Company_FailConfigBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.v_Company_FailConfigGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsQT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_FailConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_FailConfigBindingNavigator)).BeginInit();
            this.v_Company_FailConfigBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_FailConfigGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 33);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dsQT2
            // 
            this.dsQT2.DataSetName = "DsQT2";
            this.dsQT2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_Company_FailConfigBindingSource
            // 
            this.v_Company_FailConfigBindingSource.DataMember = "V_Company_FailConfig";
            this.v_Company_FailConfigBindingSource.DataSource = this.dsQT2;
            // 
            // v_Company_FailConfigTableAdapter
            // 
            this.v_Company_FailConfigTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WSS.Crawler.Product.Report.DS.DsQT2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_Company_FailConfigBindingNavigator
            // 
            this.v_Company_FailConfigBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.v_Company_FailConfigBindingNavigator.BindingSource = this.v_Company_FailConfigBindingSource;
            this.v_Company_FailConfigBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.v_Company_FailConfigBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.v_Company_FailConfigBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.v_Company_FailConfigBindingNavigatorSaveItem});
            this.v_Company_FailConfigBindingNavigator.Location = new System.Drawing.Point(0, 33);
            this.v_Company_FailConfigBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.v_Company_FailConfigBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.v_Company_FailConfigBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.v_Company_FailConfigBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.v_Company_FailConfigBindingNavigator.Name = "v_Company_FailConfigBindingNavigator";
            this.v_Company_FailConfigBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.v_Company_FailConfigBindingNavigator.Size = new System.Drawing.Size(1207, 25);
            this.v_Company_FailConfigBindingNavigator.TabIndex = 1;
            this.v_Company_FailConfigBindingNavigator.Text = "bindingNavigator1";
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
            // v_Company_FailConfigBindingNavigatorSaveItem
            // 
            this.v_Company_FailConfigBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.v_Company_FailConfigBindingNavigatorSaveItem.Enabled = false;
            this.v_Company_FailConfigBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("v_Company_FailConfigBindingNavigatorSaveItem.Image")));
            this.v_Company_FailConfigBindingNavigatorSaveItem.Name = "v_Company_FailConfigBindingNavigatorSaveItem";
            this.v_Company_FailConfigBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.v_Company_FailConfigBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // v_Company_FailConfigGridControl
            // 
            this.v_Company_FailConfigGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.v_Company_FailConfigGridControl.DataSource = this.v_Company_FailConfigBindingSource;
            this.v_Company_FailConfigGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v_Company_FailConfigGridControl.Location = new System.Drawing.Point(0, 58);
            this.v_Company_FailConfigGridControl.MainView = this.gridView1;
            this.v_Company_FailConfigGridControl.Name = "v_Company_FailConfigGridControl";
            this.v_Company_FailConfigGridControl.Size = new System.Drawing.Size(1207, 698);
            this.v_Company_FailConfigGridControl.TabIndex = 2;
            this.v_Company_FailConfigGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colCompanyId,
            this.colDomain,
            this.colTypeName});
            this.gridView1.GridControl = this.v_Company_FailConfigGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colCompanyId
            // 
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.Visible = true;
            this.colCompanyId.VisibleIndex = 1;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 2;
            // 
            // colTypeName
            // 
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 3;
            // 
            // FrmFailConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 756);
            this.Controls.Add(this.v_Company_FailConfigGridControl);
            this.Controls.Add(this.v_Company_FailConfigBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFailConfig";
            this.Text = "FrmFailConfig";
            this.Load += new System.EventHandler(this.FrmFailConfig_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsQT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_FailConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_FailConfigBindingNavigator)).EndInit();
            this.v_Company_FailConfigBindingNavigator.ResumeLayout(false);
            this.v_Company_FailConfigBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_Company_FailConfigGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private DS.DsQT2 dsQT2;
        private System.Windows.Forms.BindingSource v_Company_FailConfigBindingSource;
        private DS.DsQT2TableAdapters.V_Company_FailConfigTableAdapter v_Company_FailConfigTableAdapter;
        private DS.DsQT2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator v_Company_FailConfigBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton v_Company_FailConfigBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl v_Company_FailConfigGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
    }
}