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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label domainLabel;
            System.Windows.Forms.Label facebookFanpageLabel;
            System.Windows.Forms.Label statusFanpageLabel;
            System.Windows.Forms.Label typeFanpageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.iDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFacebook = new WSS.FacebookMerchant.DBFacebook();
            this.domainTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.facebookFanpageTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.statusFanpageLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.typeFanpageLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.companyTableAdapter = new WSS.FacebookMerchant.DBFacebookTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager = new WSS.FacebookMerchant.DBFacebookTableAdapters.TableAdapterManager();
            this.companyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.companyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.companyGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacebookFanpage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusFanpage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeFanpage = new DevExpress.XtraGrid.Columns.GridColumn();
            iDLabel = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            facebookFanpageLabel = new System.Windows.Forms.Label();
            statusFanpageLabel = new System.Windows.Forms.Label();
            typeFanpageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookFanpageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusFanpageLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeFanpageLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingNavigator)).BeginInit();
            this.companyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 35);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 11;
            iDLabel.Text = "ID:";
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(12, 9);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 13;
            domainLabel.Text = "Domain:";
            // 
            // facebookFanpageLabel
            // 
            facebookFanpageLabel.AutoSize = true;
            facebookFanpageLabel.Location = new System.Drawing.Point(339, 9);
            facebookFanpageLabel.Name = "facebookFanpageLabel";
            facebookFanpageLabel.Size = new System.Drawing.Size(103, 13);
            facebookFanpageLabel.TabIndex = 15;
            facebookFanpageLabel.Text = "Facebook Fanpage:";
            // 
            // statusFanpageLabel
            // 
            statusFanpageLabel.AutoSize = true;
            statusFanpageLabel.Location = new System.Drawing.Point(978, 9);
            statusFanpageLabel.Name = "statusFanpageLabel";
            statusFanpageLabel.Size = new System.Drawing.Size(85, 13);
            statusFanpageLabel.TabIndex = 17;
            statusFanpageLabel.Text = "Status Fanpage:";
            // 
            // typeFanpageLabel
            // 
            typeFanpageLabel.AutoSize = true;
            typeFanpageLabel.Location = new System.Drawing.Point(978, 35);
            typeFanpageLabel.Name = "typeFanpageLabel";
            typeFanpageLabel.Size = new System.Drawing.Size(79, 13);
            typeFanpageLabel.TabIndex = 19;
            typeFanpageLabel.Text = "Type Fanpage:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(iDLabel);
            this.panelControl1.Controls.Add(this.iDTextEdit);
            this.panelControl1.Controls.Add(domainLabel);
            this.panelControl1.Controls.Add(this.domainTextEdit);
            this.panelControl1.Controls.Add(facebookFanpageLabel);
            this.panelControl1.Controls.Add(this.facebookFanpageTextEdit);
            this.panelControl1.Controls.Add(statusFanpageLabel);
            this.panelControl1.Controls.Add(this.statusFanpageLookUpEdit);
            this.panelControl1.Controls.Add(typeFanpageLabel);
            this.panelControl1.Controls.Add(this.typeFanpageLookUpEdit);
            this.panelControl1.Controls.Add(this.richTextBox1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1203, 68);
            this.panelControl1.TabIndex = 0;
            // 
            // iDTextEdit
            // 
            this.iDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "ID", true));
            this.iDTextEdit.Enabled = false;
            this.iDTextEdit.Location = new System.Drawing.Point(64, 32);
            this.iDTextEdit.Name = "iDTextEdit";
            this.iDTextEdit.Size = new System.Drawing.Size(243, 20);
            this.iDTextEdit.TabIndex = 12;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBFacebook;
            // 
            // dBFacebook
            // 
            this.dBFacebook.DataSetName = "DBFacebook";
            this.dBFacebook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // domainTextEdit
            // 
            this.domainTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Domain", true));
            this.domainTextEdit.Enabled = false;
            this.domainTextEdit.Location = new System.Drawing.Point(64, 6);
            this.domainTextEdit.Name = "domainTextEdit";
            this.domainTextEdit.Size = new System.Drawing.Size(243, 20);
            this.domainTextEdit.TabIndex = 14;
            this.domainTextEdit.EditValueChanged += new System.EventHandler(this.domainTextEdit_EditValueChanged_1);
            this.domainTextEdit.TextChanged += new System.EventHandler(this.domainTextEdit_TextChanged_1);
            // 
            // facebookFanpageTextEdit
            // 
            this.facebookFanpageTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "FacebookFanpage", true));
            this.facebookFanpageTextEdit.Location = new System.Drawing.Point(448, 6);
            this.facebookFanpageTextEdit.Name = "facebookFanpageTextEdit";
            this.facebookFanpageTextEdit.Size = new System.Drawing.Size(524, 20);
            this.facebookFanpageTextEdit.TabIndex = 16;
            // 
            // statusFanpageLookUpEdit
            // 
            this.statusFanpageLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "StatusFanpage", true));
            this.statusFanpageLookUpEdit.Location = new System.Drawing.Point(1087, 6);
            this.statusFanpageLookUpEdit.Name = "statusFanpageLookUpEdit";
            this.statusFanpageLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusFanpageLookUpEdit.Properties.DataSource = this.companyBindingSource;
            this.statusFanpageLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.statusFanpageLookUpEdit.TabIndex = 18;
            // 
            // typeFanpageLookUpEdit
            // 
            this.typeFanpageLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "TypeFanpage", true));
            this.typeFanpageLookUpEdit.Location = new System.Drawing.Point(1087, 32);
            this.typeFanpageLookUpEdit.Name = "typeFanpageLookUpEdit";
            this.typeFanpageLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeFanpageLookUpEdit.Properties.DataSource = this.companyBindingSource;
            this.typeFanpageLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.typeFanpageLookUpEdit.TabIndex = 20;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(613, 349);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(439, 351);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.Merchant_FacebookTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.FacebookMerchant.DBFacebookTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companyBindingNavigator
            // 
            this.companyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.companyBindingNavigator.BindingSource = this.companyBindingSource;
            this.companyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.companyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.companyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.companyBindingNavigatorSaveItem});
            this.companyBindingNavigator.Location = new System.Drawing.Point(0, 68);
            this.companyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.companyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.companyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.companyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.companyBindingNavigator.Name = "companyBindingNavigator";
            this.companyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.companyBindingNavigator.Size = new System.Drawing.Size(1203, 25);
            this.companyBindingNavigator.TabIndex = 1;
            this.companyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
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
            this.bindingNavigatorDeleteItem.Enabled = false;
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
            // companyBindingNavigatorSaveItem
            // 
            this.companyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.companyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("companyBindingNavigatorSaveItem.Image")));
            this.companyBindingNavigatorSaveItem.Name = "companyBindingNavigatorSaveItem";
            this.companyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.companyBindingNavigatorSaveItem.Text = "Save Data";
            this.companyBindingNavigatorSaveItem.Click += new System.EventHandler(this.companyBindingNavigatorSaveItem_Click);
            // 
            // companyGridControl
            // 
            this.companyGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.companyGridControl.DataSource = this.companyBindingSource;
            this.companyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyGridControl.Location = new System.Drawing.Point(0, 93);
            this.companyGridControl.MainView = this.gridView1;
            this.companyGridControl.Name = "companyGridControl";
            this.companyGridControl.Size = new System.Drawing.Size(1203, 512);
            this.companyGridControl.TabIndex = 2;
            this.companyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDomain,
            this.colFacebookFanpage,
            this.colStatusFanpage,
            this.colTypeFanpage});
            this.gridView1.GridControl = this.companyGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MaxWidth = 110;
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 110;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.MaxWidth = 230;
            this.colDomain.Name = "colDomain";
            this.colDomain.OptionsColumn.AllowEdit = false;
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 1;
            this.colDomain.Width = 215;
            // 
            // colFacebookFanpage
            // 
            this.colFacebookFanpage.FieldName = "FacebookFanpage";
            this.colFacebookFanpage.MaxWidth = 600;
            this.colFacebookFanpage.Name = "colFacebookFanpage";
            this.colFacebookFanpage.Visible = true;
            this.colFacebookFanpage.VisibleIndex = 2;
            this.colFacebookFanpage.Width = 600;
            // 
            // colStatusFanpage
            // 
            this.colStatusFanpage.FieldName = "StatusFanpage";
            this.colStatusFanpage.MaxWidth = 130;
            this.colStatusFanpage.Name = "colStatusFanpage";
            this.colStatusFanpage.Visible = true;
            this.colStatusFanpage.VisibleIndex = 3;
            this.colStatusFanpage.Width = 130;
            // 
            // colTypeFanpage
            // 
            this.colTypeFanpage.FieldName = "TypeFanpage";
            this.colTypeFanpage.MaxWidth = 130;
            this.colTypeFanpage.Name = "colTypeFanpage";
            this.colTypeFanpage.Visible = true;
            this.colTypeFanpage.VisibleIndex = 4;
            this.colTypeFanpage.Width = 130;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 605);
            this.Controls.Add(this.companyGridControl);
            this.Controls.Add(this.companyBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookFanpageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusFanpageLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeFanpageLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingNavigator)).EndInit();
            this.companyBindingNavigator.ResumeLayout(false);
            this.companyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DBFacebook dBFacebook;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBFacebookTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DBFacebookTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator companyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton companyBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.TextEdit iDTextEdit;
        private DevExpress.XtraEditors.TextEdit domainTextEdit;
        private DevExpress.XtraEditors.TextEdit facebookFanpageTextEdit;
        private DevExpress.XtraEditors.LookUpEdit statusFanpageLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit typeFanpageLookUpEdit;
        private DevExpress.XtraGrid.GridControl companyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colFacebookFanpage;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusFanpage;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeFanpage;

    }
}

