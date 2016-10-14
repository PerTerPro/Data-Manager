namespace WSS.Financial.Bank
{
    partial class ctrBank
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
            System.Windows.Forms.Label bankIdLabel;
            System.Windows.Forms.Label bankNameLabel;
            this.dBFinancial = new WSS.Financial.DBFinancial();
            this.bankBindingSource = new System.Windows.Forms.BindingSource();
            this.bankTableAdapter = new WSS.Financial.DBFinancialTableAdapters.BankTableAdapter();
            this.tableAdapterManager = new WSS.Financial.DBFinancialTableAdapters.TableAdapterManager();
            this.bankIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.viewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankLendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bankNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bankGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewBank = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBankId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            bankIdLabel = new System.Windows.Forms.Label();
            bankNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankIdTextEdit.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBank)).BeginInit();
            this.SuspendLayout();
            // 
            // bankIdLabel
            // 
            bankIdLabel.AutoSize = true;
            bankIdLabel.Location = new System.Drawing.Point(6, 23);
            bankIdLabel.Name = "bankIdLabel";
            bankIdLabel.Size = new System.Drawing.Size(47, 13);
            bankIdLabel.TabIndex = 1;
            bankIdLabel.Text = "Bank Id:";
            // 
            // bankNameLabel
            // 
            bankNameLabel.AutoSize = true;
            bankNameLabel.Location = new System.Drawing.Point(142, 23);
            bankNameLabel.Name = "bankNameLabel";
            bankNameLabel.Size = new System.Drawing.Size(80, 13);
            bankNameLabel.TabIndex = 2;
            bankNameLabel.Text = "Tên ngân hàng";
            // 
            // dBFinancial
            // 
            this.dBFinancial.DataSetName = "DBFinancial";
            this.dBFinancial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataMember = "Bank";
            this.bankBindingSource.DataSource = this.dBFinancial;
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
            // bankIdTextEdit
            // 
            this.bankIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "BankId", true));
            this.bankIdTextEdit.Location = new System.Drawing.Point(59, 20);
            this.bankIdTextEdit.Name = "bankIdTextEdit";
            this.bankIdTextEdit.Size = new System.Drawing.Size(75, 20);
            this.bankIdTextEdit.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoToolStripMenuItem,
            this.bankLendingToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 48);
            // 
            // viewInfoToolStripMenuItem
            // 
            this.viewInfoToolStripMenuItem.Name = "viewInfoToolStripMenuItem";
            this.viewInfoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewInfoToolStripMenuItem.Text = "View Info";
            this.viewInfoToolStripMenuItem.Click += new System.EventHandler(this.viewInfoToolStripMenuItem_Click);
            // 
            // bankLendingToolStripMenuItem
            // 
            this.bankLendingToolStripMenuItem.Name = "bankLendingToolStripMenuItem";
            this.bankLendingToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.bankLendingToolStripMenuItem.Text = "Các gói vay tín dụng";
            this.bankLendingToolStripMenuItem.Click += new System.EventHandler(this.bankLendingToolStripMenuItem_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(bankNameLabel);
            this.panelControl1.Controls.Add(this.bankNameTextEdit);
            this.panelControl1.Controls.Add(this.bankIdTextEdit);
            this.panelControl1.Controls.Add(bankIdLabel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(430, 54);
            this.panelControl1.TabIndex = 3;
            // 
            // bankNameTextEdit
            // 
            this.bankNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "BankName", true));
            this.bankNameTextEdit.Location = new System.Drawing.Point(228, 20);
            this.bankNameTextEdit.Name = "bankNameTextEdit";
            this.bankNameTextEdit.Size = new System.Drawing.Size(183, 20);
            this.bankNameTextEdit.TabIndex = 3;
            // 
            // bankGridControl
            // 
            this.bankGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.bankGridControl.DataSource = this.bankBindingSource;
            this.bankGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankGridControl.Location = new System.Drawing.Point(0, 54);
            this.bankGridControl.MainView = this.gridViewBank;
            this.bankGridControl.Name = "bankGridControl";
            this.bankGridControl.Size = new System.Drawing.Size(430, 607);
            this.bankGridControl.TabIndex = 4;
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
            this.gridViewBank.OptionsBehavior.Editable = false;
            this.gridViewBank.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBank.OptionsView.ShowGroupPanel = false;
            this.gridViewBank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridViewBank_MouseDown);
            // 
            // colBankId
            // 
            this.colBankId.FieldName = "BankId";
            this.colBankId.Name = "colBankId";
            this.colBankId.OptionsColumn.ReadOnly = true;
            this.colBankId.Visible = true;
            this.colBankId.VisibleIndex = 0;
            this.colBankId.Width = 47;
            // 
            // colBankName
            // 
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 1;
            this.colBankName.Width = 111;
            // 
            // colBankWebsite
            // 
            this.colBankWebsite.FieldName = "BankWebsite";
            this.colBankWebsite.Name = "colBankWebsite";
            this.colBankWebsite.Visible = true;
            this.colBankWebsite.VisibleIndex = 2;
            this.colBankWebsite.Width = 82;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 113;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 4;
            this.colIsActive.Width = 59;
            // 
            // ctrBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bankGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "ctrBank";
            this.Size = new System.Drawing.Size(430, 661);
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankIdTextEdit.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private DBFinancialTableAdapters.BankTableAdapter bankTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit bankIdTextEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankLendingToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit bankNameTextEdit;
        private DevExpress.XtraGrid.GridControl bankGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBank;
        private DevExpress.XtraGrid.Columns.GridColumn colBankId;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
    }
}
