namespace QT.Moduls.ProductID
{
    partial class frmGhepChuyenMucVoiDinhNghia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGhepChuyenMucVoiDinhNghia));
            this.tlClassification = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colValid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPropertiesConfigID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.propertiesConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProperties = new QT.Moduls.ProductID.DBProperties();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listClassificationTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ListClassificationTableAdapter();
            this.propertiesConfigTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.PropertiesConfigTableAdapter();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.btExpan = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.tlClassification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlClassification
            // 
            this.tlClassification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tlClassification.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colValid,
            this.colPropertiesConfigID,
            this.treeListColumn1});
            this.tlClassification.DataSource = this.listClassificationBindingSource;
            this.tlClassification.Location = new System.Drawing.Point(0, 1);
            this.tlClassification.Name = "tlClassification";
            this.tlClassification.OptionsBehavior.AutoChangeParent = false;
            this.tlClassification.OptionsBehavior.CanCloneNodesOnDrop = true;
            this.tlClassification.OptionsBehavior.CloseEditorOnLostFocus = false;
            this.tlClassification.OptionsBehavior.DragNodes = true;
            this.tlClassification.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.tlClassification.Size = new System.Drawing.Size(360, 512);
            this.tlClassification.TabIndex = 8;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 159;
            // 
            // colValid
            // 
            this.colValid.FieldName = "Valid";
            this.colValid.Name = "colValid";
            this.colValid.OptionsColumn.FixedWidth = true;
            this.colValid.Visible = true;
            this.colValid.VisibleIndex = 3;
            this.colValid.Width = 50;
            // 
            // colPropertiesConfigID
            // 
            this.colPropertiesConfigID.Caption = "Định nghĩa ID";
            this.colPropertiesConfigID.FieldName = "PropertiesConfigID";
            this.colPropertiesConfigID.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPropertiesConfigID.Name = "colPropertiesConfigID";
            this.colPropertiesConfigID.OptionsColumn.FixedWidth = true;
            this.colPropertiesConfigID.Visible = true;
            this.colPropertiesConfigID.VisibleIndex = 1;
            this.colPropertiesConfigID.Width = 100;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Định nghĩa thông số";
            this.treeListColumn1.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.treeListColumn1.FieldName = "PropertiesConfigID";
            this.treeListColumn1.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.FixedWidth = true;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 2;
            this.treeListColumn1.Width = 130;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.propertiesConfigBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.DropDownRows = 12;
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // propertiesConfigBindingSource
            // 
            this.propertiesConfigBindingSource.DataMember = "PropertiesConfig";
            this.propertiesConfigBindingSource.DataSource = this.dBProperties;
            // 
            // dBProperties
            // 
            this.dBProperties.DataSetName = "DBProperties";
            this.dBProperties.EnforceConstraints = false;
            this.dBProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dBProperties;
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // propertiesConfigTableAdapter
            // 
            this.propertiesConfigTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.listClassificationBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel2;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator6,
            this.toolStripButton11,
            this.btExpan});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 516);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton7;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton10;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton9;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton8;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(362, 25);
            this.bindingNavigator2.TabIndex = 9;
            this.bindingNavigator2.Text = "bindingNavigator1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move first";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(30, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Move next";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Save Data";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // btExpan
            // 
            this.btExpan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btExpan.Image = ((System.Drawing.Image)(resources.GetObject("btExpan.Image")));
            this.btExpan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExpan.Name = "btExpan";
            this.btExpan.Size = new System.Drawing.Size(56, 22);
            this.btExpan.Text = "ExpanAll";
            this.btExpan.Click += new System.EventHandler(this.btExpan_Click);
            // 
            // frmGhepChuyenMucVoiDinhNghia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(362, 541);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.tlClassification);
            this.Name = "frmGhepChuyenMucVoiDinhNghia";
            this.Load += new System.EventHandler(this.frmGhepChuyenMucVoiDinhNghia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlClassification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlClassification;
        private DBProperties dBProperties;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DBPropertiesTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colValid;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPropertiesConfigID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource propertiesConfigBindingSource;
        private DBPropertiesTableAdapters.PropertiesConfigTableAdapter propertiesConfigTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton btExpan;
    }
}
