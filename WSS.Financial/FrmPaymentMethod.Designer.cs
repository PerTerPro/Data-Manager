namespace WSS.Financial
{
    partial class FrmPaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaymentMethod));
            System.Windows.Forms.Label paymentMethodIdLabel;
            System.Windows.Forms.Label paymentMethodNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dBFinancial = new WSS.Financial.DBFinancial();
            this.paymentMethodBindingSource = new System.Windows.Forms.BindingSource();
            this.paymentMethodTableAdapter = new WSS.Financial.DBFinancialTableAdapters.PaymentMethodTableAdapter();
            this.tableAdapterManager = new WSS.Financial.DBFinancialTableAdapters.TableAdapterManager();
            this.paymentMethodBindingNavigator = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.paymentMethodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.paymentMethodGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPaymentMethodId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMethodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paymentMethodIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.paymentMethodNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            paymentMethodIdLabel = new System.Windows.Forms.Label();
            paymentMethodNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingNavigator)).BeginInit();
            this.paymentMethodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(paymentMethodIdLabel);
            this.panelControl1.Controls.Add(this.paymentMethodIdTextEdit);
            this.panelControl1.Controls.Add(paymentMethodNameLabel);
            this.panelControl1.Controls.Add(this.paymentMethodNameTextEdit);
            this.panelControl1.Controls.Add(descriptionLabel);
            this.panelControl1.Controls.Add(this.descriptionTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(802, 80);
            this.panelControl1.TabIndex = 0;
            // 
            // dBFinancial
            // 
            this.dBFinancial.DataSetName = "DBFinancial";
            this.dBFinancial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentMethodBindingSource
            // 
            this.paymentMethodBindingSource.DataMember = "PaymentMethod";
            this.paymentMethodBindingSource.DataSource = this.dBFinancial;
            // 
            // paymentMethodTableAdapter
            // 
            this.paymentMethodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankLendingTableAdapter = null;
            this.tableAdapterManager.BankTableAdapter = null;
            this.tableAdapterManager.PaymentMethodTableAdapter = this.paymentMethodTableAdapter;
            this.tableAdapterManager.UpdateOrder = WSS.Financial.DBFinancialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paymentMethodBindingNavigator
            // 
            this.paymentMethodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paymentMethodBindingNavigator.BindingSource = this.paymentMethodBindingSource;
            this.paymentMethodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paymentMethodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paymentMethodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paymentMethodBindingNavigatorSaveItem});
            this.paymentMethodBindingNavigator.Location = new System.Drawing.Point(0, 80);
            this.paymentMethodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paymentMethodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paymentMethodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paymentMethodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paymentMethodBindingNavigator.Name = "paymentMethodBindingNavigator";
            this.paymentMethodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paymentMethodBindingNavigator.Size = new System.Drawing.Size(802, 25);
            this.paymentMethodBindingNavigator.TabIndex = 1;
            this.paymentMethodBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // paymentMethodBindingNavigatorSaveItem
            // 
            this.paymentMethodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentMethodBindingNavigatorSaveItem.Image")));
            this.paymentMethodBindingNavigatorSaveItem.Name = "paymentMethodBindingNavigatorSaveItem";
            this.paymentMethodBindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.paymentMethodBindingNavigatorSaveItem.Text = "Save";
            this.paymentMethodBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentMethodBindingNavigatorSaveItem_Click);
            // 
            // paymentMethodGridControl
            // 
            this.paymentMethodGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.paymentMethodGridControl.DataSource = this.paymentMethodBindingSource;
            this.paymentMethodGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentMethodGridControl.Location = new System.Drawing.Point(0, 105);
            this.paymentMethodGridControl.MainView = this.gridView1;
            this.paymentMethodGridControl.Name = "paymentMethodGridControl";
            this.paymentMethodGridControl.Size = new System.Drawing.Size(802, 419);
            this.paymentMethodGridControl.TabIndex = 2;
            this.paymentMethodGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPaymentMethodId,
            this.colPaymentMethodName,
            this.colDescription});
            this.gridView1.GridControl = this.paymentMethodGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colPaymentMethodId
            // 
            this.colPaymentMethodId.Caption = "ID";
            this.colPaymentMethodId.FieldName = "PaymentMethodId";
            this.colPaymentMethodId.Name = "colPaymentMethodId";
            this.colPaymentMethodId.Visible = true;
            this.colPaymentMethodId.VisibleIndex = 0;
            this.colPaymentMethodId.Width = 54;
            // 
            // colPaymentMethodName
            // 
            this.colPaymentMethodName.Caption = "Hình thức thanh toán";
            this.colPaymentMethodName.FieldName = "PaymentMethodName";
            this.colPaymentMethodName.Name = "colPaymentMethodName";
            this.colPaymentMethodName.Visible = true;
            this.colPaymentMethodName.VisibleIndex = 1;
            this.colPaymentMethodName.Width = 503;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Mô tả";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 227;
            // 
            // paymentMethodIdLabel
            // 
            paymentMethodIdLabel.AutoSize = true;
            paymentMethodIdLabel.Location = new System.Drawing.Point(11, 13);
            paymentMethodIdLabel.Name = "paymentMethodIdLabel";
            paymentMethodIdLabel.Size = new System.Drawing.Size(102, 13);
            paymentMethodIdLabel.TabIndex = 0;
            paymentMethodIdLabel.Text = "Payment Method Id:";
            // 
            // paymentMethodIdTextEdit
            // 
            this.paymentMethodIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentMethodBindingSource, "PaymentMethodId", true));
            this.paymentMethodIdTextEdit.Location = new System.Drawing.Point(138, 10);
            this.paymentMethodIdTextEdit.Name = "paymentMethodIdTextEdit";
            this.paymentMethodIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.paymentMethodIdTextEdit.TabIndex = 1;
            // 
            // paymentMethodNameLabel
            // 
            paymentMethodNameLabel.AutoSize = true;
            paymentMethodNameLabel.Location = new System.Drawing.Point(248, 13);
            paymentMethodNameLabel.Name = "paymentMethodNameLabel";
            paymentMethodNameLabel.Size = new System.Drawing.Size(121, 13);
            paymentMethodNameLabel.TabIndex = 2;
            paymentMethodNameLabel.Text = "Payment Method Name:";
            // 
            // paymentMethodNameTextEdit
            // 
            this.paymentMethodNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentMethodBindingSource, "PaymentMethodName", true));
            this.paymentMethodNameTextEdit.Location = new System.Drawing.Point(375, 10);
            this.paymentMethodNameTextEdit.Name = "paymentMethodNameTextEdit";
            this.paymentMethodNameTextEdit.Size = new System.Drawing.Size(415, 20);
            this.paymentMethodNameTextEdit.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(11, 48);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.paymentMethodBindingSource, "Description", true));
            this.descriptionTextEdit.Location = new System.Drawing.Point(138, 45);
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Size = new System.Drawing.Size(652, 20);
            this.descriptionTextEdit.TabIndex = 5;
            // 
            // FrmPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 524);
            this.Controls.Add(this.paymentMethodGridControl);
            this.Controls.Add(this.paymentMethodBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPaymentMethod";
            this.Text = "FrmPaymentMethod";
            this.Load += new System.EventHandler(this.FrmPaymentMethod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingNavigator)).EndInit();
            this.paymentMethodBindingNavigator.ResumeLayout(false);
            this.paymentMethodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource paymentMethodBindingSource;
        private DBFinancialTableAdapters.PaymentMethodTableAdapter paymentMethodTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paymentMethodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton paymentMethodBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl paymentMethodGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit paymentMethodIdTextEdit;
        private DevExpress.XtraEditors.TextEdit paymentMethodNameTextEdit;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethodId;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethodName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}