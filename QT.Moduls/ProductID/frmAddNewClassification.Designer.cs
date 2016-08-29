namespace QT.Moduls.ProductID
{
    partial class frmAddNewClassification
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label iDCategoryLabel;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label iDCompanyLabel1;
            this.dBProperties = new QT.Moduls.ProductID.DBProperties();
            this.classificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classificationTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ClassificationTableAdapter();
            this.tableAdapterManager = new QT.Moduls.ProductID.DBPropertiesTableAdapters.TableAdapterManager();
            this.iDCategoryTreeListLookUpEditTreeList = new DevExpress.XtraTreeList.TreeList();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.iDCategoryTreeListLookUpEdit = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.iDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.listClassificationTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ListClassificationTableAdapter();
            this.iDCompanyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.QuitButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLevels = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colValid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPropertiesConfigID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colKeySearch = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            nameLabel = new System.Windows.Forms.Label();
            iDCategoryLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            iDCompanyLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDCategoryTreeListLookUpEditTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDCategoryTreeListLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDCompanyTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(14, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // iDCategoryLabel
            // 
            iDCategoryLabel.AutoSize = true;
            iDCategoryLabel.Location = new System.Drawing.Point(14, 132);
            iDCategoryLabel.Name = "iDCategoryLabel";
            iDCategoryLabel.Size = new System.Drawing.Size(63, 13);
            iDCategoryLabel.TabIndex = 5;
            iDCategoryLabel.Text = "IDCategory:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(14, 14);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 8;
            iDLabel1.Text = "ID:";
            // 
            // iDCompanyLabel1
            // 
            iDCompanyLabel1.AutoSize = true;
            iDCompanyLabel1.Location = new System.Drawing.Point(14, 158);
            iDCompanyLabel1.Name = "iDCompanyLabel1";
            iDCompanyLabel1.Size = new System.Drawing.Size(65, 13);
            iDCompanyLabel1.TabIndex = 9;
            iDCompanyLabel1.Text = "IDCompany:";
            // 
            // dBProperties
            // 
            this.dBProperties.DataSetName = "DBProperties";
            this.dBProperties.EnforceConstraints = false;
            this.dBProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classificationBindingSource
            // 
            this.classificationBindingSource.DataMember = "Classification";
            this.classificationBindingSource.DataSource = this.dBProperties;
            // 
            // classificationTableAdapter
            // 
            this.classificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = this.classificationTableAdapter;
            this.tableAdapterManager.ListClassification_PropertiesTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.Product_PropertiesTableAdapter = null;
            this.tableAdapterManager.ProductDetailTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PropertiesConfig_PropertiesTableAdapter = null;
            this.tableAdapterManager.PropertiesConfigTableAdapter = null;
            this.tableAdapterManager.PropertiesGroupTableAdapter = null;
            this.tableAdapterManager.PropertiesTableAdapter = null;
            this.tableAdapterManager.PropertiesValueTableAdapter = null;
            this.tableAdapterManager.PropertiesViewTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.ProductID.DBPropertiesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDCategoryTreeListLookUpEditTreeList
            // 
            this.iDCategoryTreeListLookUpEditTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colLevels,
            this.colDescription,
            this.colValid,
            this.colPropertiesConfigID,
            this.colKeySearch});
            this.iDCategoryTreeListLookUpEditTreeList.DataSource = this.listClassificationBindingSource;
            this.iDCategoryTreeListLookUpEditTreeList.Location = new System.Drawing.Point(0, 0);
            this.iDCategoryTreeListLookUpEditTreeList.Name = "iDCategoryTreeListLookUpEditTreeList";
            this.iDCategoryTreeListLookUpEditTreeList.OptionsBehavior.EnableFiltering = true;
            this.iDCategoryTreeListLookUpEditTreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.iDCategoryTreeListLookUpEditTreeList.Size = new System.Drawing.Size(400, 200);
            this.iDCategoryTreeListLookUpEditTreeList.TabIndex = 0;
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dBProperties;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.classificationBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(85, 37);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(357, 20);
            this.nameTextEdit.TabIndex = 4;
            this.nameTextEdit.EditValueChanged += new System.EventHandler(this.nameTextEdit_EditValueChanged);
            // 
            // iDCategoryTreeListLookUpEdit
            // 
            this.iDCategoryTreeListLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.classificationBindingSource, "IDCategory", true));
            this.iDCategoryTreeListLookUpEdit.Location = new System.Drawing.Point(85, 129);
            this.iDCategoryTreeListLookUpEdit.Name = "iDCategoryTreeListLookUpEdit";
            this.iDCategoryTreeListLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iDCategoryTreeListLookUpEdit.Properties.DataSource = this.listClassificationBindingSource;
            this.iDCategoryTreeListLookUpEdit.Properties.DisplayMember = "Name";
            this.iDCategoryTreeListLookUpEdit.Properties.TreeList = this.iDCategoryTreeListLookUpEditTreeList;
            this.iDCategoryTreeListLookUpEdit.Properties.ValueMember = "ID";
            this.iDCategoryTreeListLookUpEdit.Size = new System.Drawing.Size(357, 20);
            this.iDCategoryTreeListLookUpEdit.TabIndex = 6;
            // 
            // iDTextEdit
            // 
            this.iDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.classificationBindingSource, "ID", true));
            this.iDTextEdit.Location = new System.Drawing.Point(85, 11);
            this.iDTextEdit.Name = "iDTextEdit";
            this.iDTextEdit.Properties.ReadOnly = true;
            this.iDTextEdit.Size = new System.Drawing.Size(178, 20);
            this.iDTextEdit.TabIndex = 9;
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // iDCompanyTextEdit
            // 
            this.iDCompanyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.classificationBindingSource, "IDCompany", true));
            this.iDCompanyTextEdit.Location = new System.Drawing.Point(85, 155);
            this.iDCompanyTextEdit.Name = "iDCompanyTextEdit";
            this.iDCompanyTextEdit.Size = new System.Drawing.Size(357, 20);
            this.iDCompanyTextEdit.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(254, 199);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(367, 199);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 12;
            this.QuitButton.Text = "Quit";
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(85, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(351, 16);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "VD: trananh.vn -> Điện lạnh -> Máy giặt lồng nghiêng";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 64;
            // 
            // colLevels
            // 
            this.colLevels.FieldName = "Levels";
            this.colLevels.Name = "colLevels";
            this.colLevels.Width = 64;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 64;
            // 
            // colValid
            // 
            this.colValid.FieldName = "Valid";
            this.colValid.Name = "colValid";
            this.colValid.Width = 64;
            // 
            // colPropertiesConfigID
            // 
            this.colPropertiesConfigID.FieldName = "PropertiesConfigID";
            this.colPropertiesConfigID.Name = "colPropertiesConfigID";
            this.colPropertiesConfigID.Width = 64;
            // 
            // colKeySearch
            // 
            this.colKeySearch.FieldName = "KeySearch";
            this.colKeySearch.Name = "colKeySearch";
            this.colKeySearch.Width = 64;
            // 
            // frmAddNewClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 241);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(iDCompanyLabel1);
            this.Controls.Add(this.iDCompanyTextEdit);
            this.Controls.Add(iDLabel1);
            this.Controls.Add(this.iDTextEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(iDCategoryLabel);
            this.Controls.Add(this.iDCategoryTreeListLookUpEdit);
            this.Name = "frmAddNewClassification";
            this.Text = "frmAddNewClassification";
            this.Load += new System.EventHandler(this.frmAddNewClassification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDCategoryTreeListLookUpEditTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDCategoryTreeListLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDCompanyTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBProperties dBProperties;
        private System.Windows.Forms.BindingSource classificationBindingSource;
        private DBPropertiesTableAdapters.ClassificationTableAdapter classificationTableAdapter;
        private DBPropertiesTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraTreeList.TreeList iDCategoryTreeListLookUpEditTreeList;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TreeListLookUpEdit iDCategoryTreeListLookUpEdit;
        private DevExpress.XtraEditors.TextEdit iDTextEdit;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DBPropertiesTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private DevExpress.XtraEditors.TextEdit iDCompanyTextEdit;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton QuitButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLevels;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colValid;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPropertiesConfigID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colKeySearch;
    }
}