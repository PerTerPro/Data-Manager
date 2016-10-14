namespace WSS.Financial.Bank
{
    partial class FrmBankManager
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
            System.Windows.Forms.Label bankIdLabel;
            System.Windows.Forms.Label bankNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label bankWebsiteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankManager));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bankWebsiteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bankBindingSource = new System.Windows.Forms.BindingSource();
            this.dBFinancial = new WSS.Financial.DBFinancial();
            this.bankIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bankNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.bankTableAdapter = new WSS.Financial.DBFinancialTableAdapters.BankTableAdapter();
            this.tableAdapterManager = new WSS.Financial.DBFinancialTableAdapters.TableAdapterManager();
            this.bankBindingNavigator = new System.Windows.Forms.BindingNavigator();
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
            this.bankBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bankGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewBank = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBankId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            bankIdLabel = new System.Windows.Forms.Label();
            bankNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            bankWebsiteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankWebsiteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingNavigator)).BeginInit();
            this.bankBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBank)).BeginInit();
            this.SuspendLayout();
            // 
            // bankIdLabel
            // 
            bankIdLabel.AutoSize = true;
            bankIdLabel.Location = new System.Drawing.Point(9, 17);
            bankIdLabel.Name = "bankIdLabel";
            bankIdLabel.Size = new System.Drawing.Size(47, 13);
            bankIdLabel.TabIndex = 0;
            bankIdLabel.Text = "Bank Id:";
            // 
            // bankNameLabel
            // 
            bankNameLabel.AutoSize = true;
            bankNameLabel.Location = new System.Drawing.Point(168, 18);
            bankNameLabel.Name = "bankNameLabel";
            bankNameLabel.Size = new System.Drawing.Size(80, 13);
            bankNameLabel.TabIndex = 2;
            bankNameLabel.Text = "Tên ngân hàng";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(9, 54);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(882, 18);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 6;
            isActiveLabel.Text = "Is Active:";
            // 
            // bankWebsiteLabel
            // 
            bankWebsiteLabel.AutoSize = true;
            bankWebsiteLabel.Location = new System.Drawing.Point(578, 18);
            bankWebsiteLabel.Name = "bankWebsiteLabel";
            bankWebsiteLabel.Size = new System.Drawing.Size(77, 13);
            bankWebsiteLabel.TabIndex = 8;
            bankWebsiteLabel.Text = "Bank Website:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(bankWebsiteLabel);
            this.panelControl1.Controls.Add(this.bankWebsiteTextEdit);
            this.panelControl1.Controls.Add(bankIdLabel);
            this.panelControl1.Controls.Add(this.bankIdTextEdit);
            this.panelControl1.Controls.Add(bankNameLabel);
            this.panelControl1.Controls.Add(this.bankNameTextEdit);
            this.panelControl1.Controls.Add(descriptionLabel);
            this.panelControl1.Controls.Add(this.descriptionTextEdit);
            this.panelControl1.Controls.Add(isActiveLabel);
            this.panelControl1.Controls.Add(this.isActiveCheckEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1181, 85);
            this.panelControl1.TabIndex = 0;
            // 
            // bankWebsiteTextEdit
            // 
            this.bankWebsiteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "BankWebsite", true));
            this.bankWebsiteTextEdit.Location = new System.Drawing.Point(661, 15);
            this.bankWebsiteTextEdit.Name = "bankWebsiteTextEdit";
            this.bankWebsiteTextEdit.Size = new System.Drawing.Size(205, 20);
            this.bankWebsiteTextEdit.TabIndex = 9;
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataMember = "Bank";
            this.bankBindingSource.DataSource = this.dBFinancial;
            // 
            // dBFinancial
            // 
            this.dBFinancial.DataSetName = "DBFinancial";
            this.dBFinancial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankIdTextEdit
            // 
            this.bankIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "BankId", true));
            this.bankIdTextEdit.Location = new System.Drawing.Point(62, 14);
            this.bankIdTextEdit.Name = "bankIdTextEdit";
            this.bankIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.bankIdTextEdit.TabIndex = 1;
            // 
            // bankNameTextEdit
            // 
            this.bankNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "BankName", true));
            this.bankNameTextEdit.Location = new System.Drawing.Point(265, 15);
            this.bankNameTextEdit.Name = "bankNameTextEdit";
            this.bankNameTextEdit.Size = new System.Drawing.Size(297, 20);
            this.bankNameTextEdit.TabIndex = 3;
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "Description", true));
            this.descriptionTextEdit.Location = new System.Drawing.Point(79, 51);
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Size = new System.Drawing.Size(787, 20);
            this.descriptionTextEdit.TabIndex = 5;
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "IsActive", true));
            this.isActiveCheckEdit.Location = new System.Drawing.Point(939, 15);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "Active";
            this.isActiveCheckEdit.Size = new System.Drawing.Size(67, 19);
            this.isActiveCheckEdit.TabIndex = 7;
            // 
            // bankTableAdapter
            // 
            this.bankTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankLendingTableAdapter = null;
            this.tableAdapterManager.BankTableAdapter = this.bankTableAdapter;
            this.tableAdapterManager.PaymentMethodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.Financial.DBFinancialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bankBindingNavigator
            // 
            this.bankBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bankBindingNavigator.BindingSource = this.bankBindingSource;
            this.bankBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bankBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bankBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bankBindingNavigatorSaveItem});
            this.bankBindingNavigator.Location = new System.Drawing.Point(0, 85);
            this.bankBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bankBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bankBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bankBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bankBindingNavigator.Name = "bankBindingNavigator";
            this.bankBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bankBindingNavigator.Size = new System.Drawing.Size(1181, 25);
            this.bankBindingNavigator.TabIndex = 1;
            this.bankBindingNavigator.Text = "bindingNavigator1";
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
            // bankBindingNavigatorSaveItem
            // 
            this.bankBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bankBindingNavigatorSaveItem.Image")));
            this.bankBindingNavigatorSaveItem.Name = "bankBindingNavigatorSaveItem";
            this.bankBindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.bankBindingNavigatorSaveItem.Text = "Save";
            this.bankBindingNavigatorSaveItem.Click += new System.EventHandler(this.bankBindingNavigatorSaveItem_Click);
            // 
            // bankGridControl
            // 
            this.bankGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.bankGridControl.DataSource = this.bankBindingSource;
            this.bankGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankGridControl.Location = new System.Drawing.Point(0, 110);
            this.bankGridControl.MainView = this.gridViewBank;
            this.bankGridControl.Name = "bankGridControl";
            this.bankGridControl.Size = new System.Drawing.Size(1181, 461);
            this.bankGridControl.TabIndex = 2;
            this.bankGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBank});
            // 
            // gridViewBank
            // 
            this.gridViewBank.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBankId,
            this.colBankName,
            this.colBankWebsite,
            this.colDescription,
            this.colIsActive});
            this.gridViewBank.GridControl = this.bankGridControl;
            this.gridViewBank.Name = "gridViewBank";
            this.gridViewBank.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colBankId
            // 
            this.colBankId.FieldName = "BankId";
            this.colBankId.Name = "colBankId";
            this.colBankId.OptionsColumn.ReadOnly = true;
            this.colBankId.Visible = true;
            this.colBankId.VisibleIndex = 0;
            this.colBankId.Width = 61;
            // 
            // colBankName
            // 
            this.colBankName.Caption = "Ngân hàng";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 1;
            this.colBankName.Width = 251;
            // 
            // colBankWebsite
            // 
            this.colBankWebsite.Caption = "Webiste Ngân hàng";
            this.colBankWebsite.FieldName = "BankWebsite";
            this.colBankWebsite.Name = "colBankWebsite";
            this.colBankWebsite.Visible = true;
            this.colBankWebsite.VisibleIndex = 2;
            this.colBankWebsite.Width = 387;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Mô tả";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 380;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 4;
            this.colIsActive.Width = 84;
            // 
            // FrmBankManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 571);
            this.Controls.Add(this.bankGridControl);
            this.Controls.Add(this.bankBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmBankManager";
            this.Text = "FrmBankManager";
            this.Load += new System.EventHandler(this.FrmBankManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankWebsiteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingNavigator)).EndInit();
            this.bankBindingNavigator.ResumeLayout(false);
            this.bankBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private DBFinancialTableAdapters.BankTableAdapter bankTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bankBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bankBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl bankGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBank;
        private DevExpress.XtraEditors.TextEdit bankIdTextEdit;
        private DevExpress.XtraEditors.TextEdit bankNameTextEdit;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DevExpress.XtraEditors.TextEdit bankWebsiteTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colBankId;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
    }
}