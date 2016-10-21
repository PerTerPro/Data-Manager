namespace WSS.Financial
{
    partial class FrmAddNewItem
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label brandIdLabel;
            System.Windows.Forms.Label isActiveLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFinancial = new WSS.Financial.DBFinancial();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categoryIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.itemTableAdapter = new WSS.Financial.DBFinancialTableAdapters.ItemTableAdapter();
            this.tableAdapterManager = new WSS.Financial.DBFinancialTableAdapters.TableAdapterManager();
            this.categoryTableAdapter = new WSS.Financial.DBFinancialTableAdapters.CategoryTableAdapter();
            this.brandTableAdapter = new WSS.Financial.DBFinancialTableAdapters.BrandTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            brandIdLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(18, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(135, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(138, 47);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(64, 13);
            categoryIdLabel.TabIndex = 4;
            categoryIdLabel.Text = "Category Id:";
            // 
            // brandIdLabel
            // 
            brandIdLabel.AutoSize = true;
            brandIdLabel.Location = new System.Drawing.Point(469, 47);
            brandIdLabel.Name = "brandIdLabel";
            brandIdLabel.Size = new System.Drawing.Size(50, 13);
            brandIdLabel.TabIndex = 6;
            brandIdLabel.Text = "Brand Id:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(707, 15);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 8;
            isActiveLabel.Text = "Is Active:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(idLabel);
            this.panelControl1.Controls.Add(this.idTextEdit);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.nameTextEdit);
            this.panelControl1.Controls.Add(categoryIdLabel);
            this.panelControl1.Controls.Add(this.categoryIdLookUpEdit);
            this.panelControl1.Controls.Add(brandIdLabel);
            this.panelControl1.Controls.Add(this.brandIdLookUpEdit);
            this.panelControl1.Controls.Add(isActiveLabel);
            this.panelControl1.Controls.Add(this.isActiveCheckEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1256, 86);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1126, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 55);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu lại";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "Id", true));
            this.idTextEdit.Location = new System.Drawing.Point(43, 12);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Size = new System.Drawing.Size(73, 20);
            this.idTextEdit.TabIndex = 1;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.dBFinancial;
            // 
            // dBFinancial
            // 
            this.dBFinancial.DataSetName = "DBFinancial";
            this.dBFinancial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(179, 12);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(445, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // categoryIdLookUpEdit
            // 
            this.categoryIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "CategoryId", true));
            this.categoryIdLookUpEdit.Location = new System.Drawing.Point(208, 44);
            this.categoryIdLookUpEdit.Name = "categoryIdLookUpEdit";
            this.categoryIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Category")});
            this.categoryIdLookUpEdit.Properties.DataSource = this.categoryBindingSource;
            this.categoryIdLookUpEdit.Properties.DisplayMember = "Name";
            this.categoryIdLookUpEdit.Properties.ValueMember = "Id";
            this.categoryIdLookUpEdit.Size = new System.Drawing.Size(244, 20);
            this.categoryIdLookUpEdit.TabIndex = 5;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.dBFinancial;
            // 
            // brandIdLookUpEdit
            // 
            this.brandIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "BrandId", true));
            this.brandIdLookUpEdit.Location = new System.Drawing.Point(539, 44);
            this.brandIdLookUpEdit.Name = "brandIdLookUpEdit";
            this.brandIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.brandIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Brand")});
            this.brandIdLookUpEdit.Properties.DataSource = this.brandBindingSource;
            this.brandIdLookUpEdit.Properties.DisplayMember = "Name";
            this.brandIdLookUpEdit.Properties.ValueMember = "Id";
            this.brandIdLookUpEdit.Size = new System.Drawing.Size(256, 20);
            this.brandIdLookUpEdit.TabIndex = 7;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.dBFinancial;
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "IsActive", true));
            this.isActiveCheckEdit.Location = new System.Drawing.Point(764, 12);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "";
            this.isActiveCheckEdit.Size = new System.Drawing.Size(33, 19);
            this.isActiveCheckEdit.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 86);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1256, 658);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.RowHeight = 40;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ItemPropertiesTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.PropertyGroupTableAdapter = null;
            this.tableAdapterManager.PropertyStatusTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.PropertyValueTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.Financial.DBFinancialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(869, 39);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmAddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 744);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmAddNewItem";
            this.Text = "FrmAddNewItem";
            this.Load += new System.EventHandler(this.FrmAddNewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DBFinancialTableAdapters.ItemTableAdapter itemTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit categoryIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit brandIdLookUpEdit;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private DBFinancialTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private DBFinancialTableAdapters.BrandTableAdapter brandTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}