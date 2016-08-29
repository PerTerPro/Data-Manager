namespace QT.Moduls.LogJob
{
    partial class frmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartment));
            this.dBLogJob = new QT.Moduls.LogJob.DBLogJob();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserTableAdapter = new QT.Moduls.LogJob.DBLogJobTableAdapters.tblUserTableAdapter();
            this.tableAdapterManager = new QT.Moduls.LogJob.DBLogJobTableAdapters.TableAdapterManager();
            this.tblUserBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblUserBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblUserGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSkype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYahoo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateofBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvatar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLogJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingNavigator)).BeginInit();
            this.tblUserBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // dBLogJob
            // 
            this.dBLogJob.DataSetName = "DBLogJob";
            this.dBLogJob.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.dBLogJob;
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.CompanyVATStatusTableAdapter = null;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.LogJobTableAdapter = null;
            this.tableAdapterManager.tblUserTableAdapter = this.tblUserTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.LogJob.DBLogJobTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblUserBindingNavigator
            // 
            this.tblUserBindingNavigator.AddNewItem = null;
            this.tblUserBindingNavigator.BindingSource = this.tblUserBindingSource;
            this.tblUserBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblUserBindingNavigator.DeleteItem = null;
            this.tblUserBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tblUserBindingNavigatorSaveItem});
            this.tblUserBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblUserBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblUserBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblUserBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblUserBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblUserBindingNavigator.Name = "tblUserBindingNavigator";
            this.tblUserBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblUserBindingNavigator.Size = new System.Drawing.Size(656, 25);
            this.tblUserBindingNavigator.TabIndex = 0;
            this.tblUserBindingNavigator.Text = "bindingNavigator1";
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
            // tblUserBindingNavigatorSaveItem
            // 
            this.tblUserBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblUserBindingNavigatorSaveItem.Image")));
            this.tblUserBindingNavigatorSaveItem.Name = "tblUserBindingNavigatorSaveItem";
            this.tblUserBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.tblUserBindingNavigatorSaveItem.Text = "Save Data";
            this.tblUserBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblUserBindingNavigatorSaveItem_Click);
            // 
            // tblUserGridControl
            // 
            this.tblUserGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tblUserGridControl.DataSource = this.tblUserBindingSource;
            this.tblUserGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUserGridControl.Location = new System.Drawing.Point(0, 25);
            this.tblUserGridControl.MainView = this.gridView1;
            this.tblUserGridControl.Name = "tblUserGridControl";
            this.tblUserGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.tblUserGridControl.Size = new System.Drawing.Size(656, 398);
            this.tblUserGridControl.TabIndex = 1;
            this.tblUserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colUserName,
            this.colPassword,
            this.colEmail,
            this.colMobile,
            this.colActive,
            this.colAddress,
            this.colSkype,
            this.colYahoo,
            this.colDateofBirth,
            this.colAvatar,
            this.colFullName,
            this.colDepartment});
            this.gridView1.GridControl = this.tblUserGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 83;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            this.colUserName.Width = 289;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            // 
            // colActive
            // 
            this.colActive.FieldName = "Active";
            this.colActive.Name = "colActive";
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            // 
            // colSkype
            // 
            this.colSkype.FieldName = "Skype";
            this.colSkype.Name = "colSkype";
            // 
            // colYahoo
            // 
            this.colYahoo.FieldName = "Yahoo";
            this.colYahoo.Name = "colYahoo";
            // 
            // colDateofBirth
            // 
            this.colDateofBirth.FieldName = "DateofBirth";
            this.colDateofBirth.Name = "colDateofBirth";
            // 
            // colAvatar
            // 
            this.colAvatar.FieldName = "Avatar";
            this.colAvatar.Name = "colAvatar";
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Width = 289;
            // 
            // colDepartment
            // 
            this.colDepartment.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 2;
            this.colDepartment.Width = 291;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Department")});
            this.repositoryItemLookUpEdit1.DisplayMember = "Text";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Department";
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 423);
            this.Controls.Add(this.tblUserGridControl);
            this.Controls.Add(this.tblUserBindingNavigator);
            this.Name = "frmDepartment";
            this.Text = "frmDepartment";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBLogJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingNavigator)).EndInit();
            this.tblUserBindingNavigator.ResumeLayout(false);
            this.tblUserBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBLogJob dBLogJob;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private DBLogJobTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private DBLogJobTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblUserBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblUserBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl tblUserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colSkype;
        private DevExpress.XtraGrid.Columns.GridColumn colYahoo;
        private DevExpress.XtraGrid.Columns.GridColumn colDateofBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colAvatar;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}