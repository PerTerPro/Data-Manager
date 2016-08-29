namespace QT.Moduls.Company
{
    partial class FrmPublicProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPublicProduct));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCom = new QT.Moduls.Company.DBCom();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtPageIndex = new DevExpress.XtraEditors.TextEdit();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.cboPageSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsBlackList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productTableAdapter = new QT.Moduls.Company.DBComTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Company.DBComTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPageSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(738, 48);
            this.panelControl1.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBCom;
            // 
            // dBCom
            // 
            this.dBCom.DataSetName = "DBCom";
            this.dBCom.EnforceConstraints = false;
            this.dBCom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 48);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.AutoScroll = true;
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(738, 455);
            this.splitContainerControl1.SplitterPosition = 470;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txtPageIndex);
            this.panelControl3.Controls.Add(this.btnLast);
            this.panelControl3.Controls.Add(this.btnNext);
            this.panelControl3.Controls.Add(this.btnPrevious);
            this.panelControl3.Controls.Add(this.btnFirst);
            this.panelControl3.Controls.Add(this.cboPageSize);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 420);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(470, 31);
            this.panelControl3.TabIndex = 2;
            // 
            // txtPageIndex
            // 
            this.txtPageIndex.EditValue = 1;
            this.txtPageIndex.Location = new System.Drawing.Point(131, 7);
            this.txtPageIndex.Name = "txtPageIndex";
            this.txtPageIndex.Size = new System.Drawing.Size(49, 20);
            this.txtPageIndex.TabIndex = 5;
            this.txtPageIndex.EditValueChanged += new System.EventHandler(this.txtPageIndex_EditValueChanged);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(215, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(23, 23);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">>";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(186, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(102, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 23);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(73, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(23, 23);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "<<";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // cboPageSize
            // 
            this.cboPageSize.EditValue = 20;
            this.cboPageSize.Location = new System.Drawing.Point(10, 7);
            this.cboPageSize.Name = "cboPageSize";
            this.cboPageSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPageSize.Size = new System.Drawing.Size(57, 20);
            this.cboPageSize.TabIndex = 0;
            this.cboPageSize.EditValueChanged += new System.EventHandler(this.cboPageSize_EditValueChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.productBindingNavigator);
            this.panelControl2.Controls.Add(this.productGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(470, 420);
            this.panelControl2.TabIndex = 1;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(2, 393);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(466, 25);
            this.productBindingNavigator.TabIndex = 2;
            this.productBindingNavigator.Text = "bindingNavigator1";
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
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // productGridControl
            // 
            this.productGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.productGridControl.DataSource = this.productBindingSource;
            this.productGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridControl.Location = new System.Drawing.Point(2, 2);
            this.productGridControl.MainView = this.gridView1;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.Size = new System.Drawing.Size(466, 416);
            this.productGridControl.TabIndex = 0;
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.Valid,
            this.IsBlackList});
            this.gridView1.GridControl = this.productGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // Valid
            // 
            this.Valid.Caption = "Valid";
            this.Valid.FieldName = "Valid";
            this.Valid.Name = "Valid";
            this.Valid.Visible = true;
            this.Valid.VisibleIndex = 2;
            // 
            // IsBlackList
            // 
            this.IsBlackList.Caption = "IsBlackList";
            this.IsBlackList.FieldName = "IsBlackList";
            this.IsBlackList.Name = "IsBlackList";
            this.IsBlackList.Visible = true;
            this.IsBlackList.VisibleIndex = 3;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_AddressTableAdapter = null;
            this.tableAdapterManager.Company_ImageTableAdapter = null;
            this.tableAdapterManager.Company1TableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.DatafeedConfigTableAdapter = null;
            this.tableAdapterManager.Job_WebsiteConfigLogTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.ManagerCompanyLogTableAdapter = null;
            this.tableAdapterManager.ManagerCompanyLogTypeTableAdapter = null;
            this.tableAdapterManager.ManagerCrawlerTableAdapter = null;
            this.tableAdapterManager.ManagerTypeRCompanyTableAdapter = null;
            this.tableAdapterManager.ManagerTypeTableAdapter = null;
            this.tableAdapterManager.ProductQuangCaoTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Company.DBComTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmPublicProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 503);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPublicProduct";
            this.Text = "FrmPublicProduct";
            this.Load += new System.EventHandler(this.FrmPublicProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPageIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPageSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DBCom dBCom;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBComTableAdapters.ProductTableAdapter productTableAdapter;
        private DBComTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit txtPageIndex;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnPrevious;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.ComboBoxEdit cboPageSize;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl productGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn IsBlackList;
        private DevExpress.XtraGrid.Columns.GridColumn Valid;

    }
}