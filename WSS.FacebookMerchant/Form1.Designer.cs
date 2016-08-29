namespace WSS.FacebookMerchant
{
    partial class Form1
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
            System.Windows.Forms.Label merchantIdLabel;
            System.Windows.Forms.Label facebookFanpageLabel;
            System.Windows.Forms.Label typeFanpageLabel;
            System.Windows.Forms.Label domainLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.statusLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.merchant_FacebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFacebook = new WSS.FacebookMerchant.DBFacebook();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.merchantIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.facebookFanpageTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.typeFanpageLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.domainTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.merchant_FacebookTableAdapter = new WSS.FacebookMerchant.DBFacebookTableAdapters.Merchant_FacebookTableAdapter();
            this.tableAdapterManager = new WSS.FacebookMerchant.DBFacebookTableAdapters.TableAdapterManager();
            this.merchant_FacebookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.merchant_FacebookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.merchant_FacebookGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMerchantId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacebookFanpage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeFanpage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            merchantIdLabel = new System.Windows.Forms.Label();
            facebookFanpageLabel = new System.Windows.Forms.Label();
            typeFanpageLabel = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchant_FacebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookFanpageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeFanpageLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchant_FacebookBindingNavigator)).BeginInit();
            this.merchant_FacebookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.merchant_FacebookGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // merchantIdLabel
            // 
            merchantIdLabel.AutoSize = true;
            merchantIdLabel.Location = new System.Drawing.Point(7, 62);
            merchantIdLabel.Name = "merchantIdLabel";
            merchantIdLabel.Size = new System.Drawing.Size(67, 13);
            merchantIdLabel.TabIndex = 0;
            merchantIdLabel.Text = "Merchant Id:";
            // 
            // facebookFanpageLabel
            // 
            facebookFanpageLabel.AutoSize = true;
            facebookFanpageLabel.Location = new System.Drawing.Point(316, 22);
            facebookFanpageLabel.Name = "facebookFanpageLabel";
            facebookFanpageLabel.Size = new System.Drawing.Size(103, 13);
            facebookFanpageLabel.TabIndex = 2;
            facebookFanpageLabel.Text = "Facebook Fanpage:";
            // 
            // typeFanpageLabel
            // 
            typeFanpageLabel.AutoSize = true;
            typeFanpageLabel.Location = new System.Drawing.Point(974, 22);
            typeFanpageLabel.Name = "typeFanpageLabel";
            typeFanpageLabel.Size = new System.Drawing.Size(79, 13);
            typeFanpageLabel.TabIndex = 6;
            typeFanpageLabel.Text = "Type Fanpage:";
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(8, 22);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 8;
            domainLabel.Text = "Domain:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(974, 58);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Status:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(statusLabel);
            this.panelControl1.Controls.Add(this.statusLookUpEdit);
            this.panelControl1.Controls.Add(this.richTextBox1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(merchantIdLabel);
            this.panelControl1.Controls.Add(this.merchantIdTextEdit);
            this.panelControl1.Controls.Add(facebookFanpageLabel);
            this.panelControl1.Controls.Add(this.facebookFanpageTextEdit);
            this.panelControl1.Controls.Add(typeFanpageLabel);
            this.panelControl1.Controls.Add(this.typeFanpageLookUpEdit);
            this.panelControl1.Controls.Add(domainLabel);
            this.panelControl1.Controls.Add(this.domainTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1203, 98);
            this.panelControl1.TabIndex = 0;
            // 
            // statusLookUpEdit
            // 
            this.statusLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.merchant_FacebookBindingSource, "Status", true));
            this.statusLookUpEdit.Location = new System.Drawing.Point(1059, 55);
            this.statusLookUpEdit.Name = "statusLookUpEdit";
            this.statusLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status", "Status")});
            this.statusLookUpEdit.Properties.DisplayMember = "Status";
            this.statusLookUpEdit.Properties.ValueMember = "Value";
            this.statusLookUpEdit.Size = new System.Drawing.Size(124, 20);
            this.statusLookUpEdit.TabIndex = 12;
            // 
            // merchant_FacebookBindingSource
            // 
            this.merchant_FacebookBindingSource.DataMember = "Merchant_Facebook";
            this.merchant_FacebookBindingSource.DataSource = this.dBFacebook;
            // 
            // dBFacebook
            // 
            this.dBFacebook.DataSetName = "DBFacebook";
            this.dBFacebook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(584, 145);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(410, 147);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // merchantIdTextEdit
            // 
            this.merchantIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.merchant_FacebookBindingSource, "MerchantId", true));
            this.merchantIdTextEdit.Location = new System.Drawing.Point(116, 59);
            this.merchantIdTextEdit.Name = "merchantIdTextEdit";
            this.merchantIdTextEdit.Size = new System.Drawing.Size(190, 20);
            this.merchantIdTextEdit.TabIndex = 1;
            // 
            // facebookFanpageTextEdit
            // 
            this.facebookFanpageTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.merchant_FacebookBindingSource, "FacebookFanpage", true));
            this.facebookFanpageTextEdit.Location = new System.Drawing.Point(425, 19);
            this.facebookFanpageTextEdit.Name = "facebookFanpageTextEdit";
            this.facebookFanpageTextEdit.Size = new System.Drawing.Size(450, 20);
            this.facebookFanpageTextEdit.TabIndex = 3;
            // 
            // typeFanpageLookUpEdit
            // 
            this.typeFanpageLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.merchant_FacebookBindingSource, "TypeFanpage", true));
            this.typeFanpageLookUpEdit.Location = new System.Drawing.Point(1059, 19);
            this.typeFanpageLookUpEdit.Name = "typeFanpageLookUpEdit";
            this.typeFanpageLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeFanpageLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type", "TypeFacebook")});
            this.typeFanpageLookUpEdit.Properties.DisplayMember = "Type";
            this.typeFanpageLookUpEdit.Properties.ValueMember = "Value";
            this.typeFanpageLookUpEdit.Size = new System.Drawing.Size(124, 20);
            this.typeFanpageLookUpEdit.TabIndex = 7;
            // 
            // domainTextEdit
            // 
            this.domainTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.merchant_FacebookBindingSource, "Domain", true));
            this.domainTextEdit.Location = new System.Drawing.Point(60, 19);
            this.domainTextEdit.Name = "domainTextEdit";
            this.domainTextEdit.Size = new System.Drawing.Size(246, 20);
            this.domainTextEdit.TabIndex = 9;
            this.domainTextEdit.EditValueChanged += new System.EventHandler(this.domainTextEdit_EditValueChanged);
            this.domainTextEdit.TextChanged += new System.EventHandler(this.domainTextEdit_TextChanged);
            // 
            // merchant_FacebookTableAdapter
            // 
            this.merchant_FacebookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Merchant_FacebookTableAdapter = this.merchant_FacebookTableAdapter;
            this.tableAdapterManager.UpdateOrder = WSS.FacebookMerchant.DBFacebookTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // merchant_FacebookBindingNavigator
            // 
            this.merchant_FacebookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.merchant_FacebookBindingNavigator.BindingSource = this.merchant_FacebookBindingSource;
            this.merchant_FacebookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.merchant_FacebookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.merchant_FacebookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.merchant_FacebookBindingNavigatorSaveItem});
            this.merchant_FacebookBindingNavigator.Location = new System.Drawing.Point(0, 98);
            this.merchant_FacebookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.merchant_FacebookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.merchant_FacebookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.merchant_FacebookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.merchant_FacebookBindingNavigator.Name = "merchant_FacebookBindingNavigator";
            this.merchant_FacebookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.merchant_FacebookBindingNavigator.Size = new System.Drawing.Size(1203, 25);
            this.merchant_FacebookBindingNavigator.TabIndex = 1;
            this.merchant_FacebookBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
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
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(44, 22);
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
            // merchant_FacebookBindingNavigatorSaveItem
            // 
            this.merchant_FacebookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("merchant_FacebookBindingNavigatorSaveItem.Image")));
            this.merchant_FacebookBindingNavigatorSaveItem.Name = "merchant_FacebookBindingNavigatorSaveItem";
            this.merchant_FacebookBindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.merchant_FacebookBindingNavigatorSaveItem.Text = "Save";
            this.merchant_FacebookBindingNavigatorSaveItem.Click += new System.EventHandler(this.merchant_FacebookBindingNavigatorSaveItem_Click);
            // 
            // merchant_FacebookGridControl
            // 
            this.merchant_FacebookGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.merchant_FacebookGridControl.DataSource = this.merchant_FacebookBindingSource;
            this.merchant_FacebookGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.merchant_FacebookGridControl.Location = new System.Drawing.Point(0, 123);
            this.merchant_FacebookGridControl.MainView = this.gridView1;
            this.merchant_FacebookGridControl.Name = "merchant_FacebookGridControl";
            this.merchant_FacebookGridControl.Size = new System.Drawing.Size(1203, 482);
            this.merchant_FacebookGridControl.TabIndex = 2;
            this.merchant_FacebookGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMerchantId,
            this.colFacebookFanpage,
            this.colStatus,
            this.colTypeFanpage,
            this.colDomain});
            this.gridView1.GridControl = this.merchant_FacebookGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colMerchantId
            // 
            this.colMerchantId.FieldName = "MerchantId";
            this.colMerchantId.Name = "colMerchantId";
            this.colMerchantId.Visible = true;
            this.colMerchantId.VisibleIndex = 2;
            this.colMerchantId.Width = 226;
            // 
            // colFacebookFanpage
            // 
            this.colFacebookFanpage.FieldName = "FacebookFanpage";
            this.colFacebookFanpage.Name = "colFacebookFanpage";
            this.colFacebookFanpage.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colFacebookFanpage.Visible = true;
            this.colFacebookFanpage.VisibleIndex = 1;
            this.colFacebookFanpage.Width = 455;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 139;
            // 
            // colTypeFanpage
            // 
            this.colTypeFanpage.FieldName = "TypeFanpage";
            this.colTypeFanpage.Name = "colTypeFanpage";
            this.colTypeFanpage.Visible = true;
            this.colTypeFanpage.VisibleIndex = 4;
            this.colTypeFanpage.Width = 143;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 0;
            this.colDomain.Width = 218;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 605);
            this.Controls.Add(this.merchant_FacebookGridControl);
            this.Controls.Add(this.merchant_FacebookBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchant_FacebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookFanpageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeFanpageLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchant_FacebookBindingNavigator)).EndInit();
            this.merchant_FacebookBindingNavigator.ResumeLayout(false);
            this.merchant_FacebookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.merchant_FacebookGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBFacebook dBFacebook;
        private System.Windows.Forms.BindingSource merchant_FacebookBindingSource;
        private DBFacebookTableAdapters.Merchant_FacebookTableAdapter merchant_FacebookTableAdapter;
        private DBFacebookTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator merchant_FacebookBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton merchant_FacebookBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.TextEdit merchantIdTextEdit;
        private DevExpress.XtraEditors.TextEdit facebookFanpageTextEdit;
        private DevExpress.XtraEditors.LookUpEdit typeFanpageLookUpEdit;
        private DevExpress.XtraEditors.TextEdit domainTextEdit;
        private DevExpress.XtraGrid.GridControl merchant_FacebookGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMerchantId;
        private DevExpress.XtraGrid.Columns.GridColumn colFacebookFanpage;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeFanpage;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.LookUpEdit statusLookUpEdit;

    }
}

