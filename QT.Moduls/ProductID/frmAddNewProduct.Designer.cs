namespace QT.Moduls.ProductID
{
    partial class frmAddNewProduct
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
            System.Windows.Forms.Label summaryLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label nameFTLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label validLabel;
            System.Windows.Forms.Label keySearchLabel;
            System.Windows.Forms.Label contentFTLabel;
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProperties = new QT.Moduls.ProductID.DBProperties();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.nameFTTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.validCheckBox = new System.Windows.Forms.CheckBox();
            this.productTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new QT.Moduls.ProductID.DBPropertiesTableAdapters.TableAdapterManager();
            this.listClassificationTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.ListClassificationTableAdapter();
            this.keySearchTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.contentFTTextEdit = new DevExpress.XtraEditors.TextEdit();
            iDLabel = new System.Windows.Forms.Label();
            summaryLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            nameFTLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            validLabel = new System.Windows.Forms.Label();
            keySearchLabel = new System.Windows.Forms.Label();
            contentFTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySearchTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentFTTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(51, 226);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Location = new System.Drawing.Point(19, 200);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new System.Drawing.Size(53, 13);
            summaryLabel.TabIndex = 3;
            summaryLabel.Text = "Summary:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(33, 42);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(5, 15);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(66, 13);
            categoryIDLabel.TabIndex = 7;
            categoryIDLabel.Text = "Category ID:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(18, 174);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 10;
            companyLabel.Text = "Company:";
            // 
            // nameFTLabel
            // 
            nameFTLabel.AutoSize = true;
            nameFTLabel.Location = new System.Drawing.Point(17, 252);
            nameFTLabel.Name = "nameFTLabel";
            nameFTLabel.Size = new System.Drawing.Size(54, 13);
            nameFTLabel.TabIndex = 12;
            nameFTLabel.Text = "Name FT:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(31, 278);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 14;
            statusLabel.Text = "Status:";
            // 
            // validLabel
            // 
            validLabel.AutoSize = true;
            validLabel.Location = new System.Drawing.Point(188, 228);
            validLabel.Name = "validLabel";
            validLabel.Size = new System.Drawing.Size(33, 13);
            validLabel.TabIndex = 16;
            validLabel.Text = "Valid:";
            // 
            // keySearchLabel
            // 
            keySearchLabel.AutoSize = true;
            keySearchLabel.Location = new System.Drawing.Point(201, 275);
            keySearchLabel.Name = "keySearchLabel";
            keySearchLabel.Size = new System.Drawing.Size(65, 13);
            keySearchLabel.TabIndex = 18;
            keySearchLabel.Text = "Key Search:";
            // 
            // contentFTLabel
            // 
            contentFTLabel.AutoSize = true;
            contentFTLabel.Location = new System.Drawing.Point(208, 174);
            contentFTLabel.Name = "contentFTLabel";
            contentFTLabel.Size = new System.Drawing.Size(63, 13);
            contentFTLabel.TabIndex = 20;
            contentFTLabel.Text = "Content FT:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(78, 223);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBProperties;
            // 
            // dBProperties
            // 
            this.dBProperties.DataSetName = "DBProperties";
            this.dBProperties.EnforceConstraints = false;
            this.dBProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Summary", true));
            this.summaryTextBox.Location = new System.Drawing.Point(78, 197);
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.ReadOnly = true;
            this.summaryTextBox.Size = new System.Drawing.Size(318, 20);
            this.summaryTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(77, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(318, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryID", true));
            this.categoryIDComboBox.DataSource = this.listClassificationBindingSource;
            this.categoryIDComboBox.DisplayMember = "Name";
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(77, 12);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryIDComboBox.TabIndex = 8;
            this.categoryIDComboBox.ValueMember = "ID";
            this.categoryIDComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryIDComboBox_SelectedIndexChanged);
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dBProperties;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(130, 65);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(211, 65);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(78, 171);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.ReadOnly = true;
            this.companyTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyTextBox.TabIndex = 11;
            // 
            // nameFTTextBox
            // 
            this.nameFTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "NameFT", true));
            this.nameFTTextBox.Location = new System.Drawing.Point(77, 249);
            this.nameFTTextBox.Name = "nameFTTextBox";
            this.nameFTTextBox.ReadOnly = true;
            this.nameFTTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameFTTextBox.TabIndex = 13;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(77, 275);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 15;
            // 
            // validCheckBox
            // 
            this.validCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "Valid", true));
            this.validCheckBox.Location = new System.Drawing.Point(227, 223);
            this.validCheckBox.Name = "validCheckBox";
            this.validCheckBox.Size = new System.Drawing.Size(104, 24);
            this.validCheckBox.TabIndex = 17;
            this.validCheckBox.TabStop = false;
            this.validCheckBox.Text = "checkBox1";
            this.validCheckBox.UseVisualStyleBackColor = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.ListClassification_PropertiesTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.Product_PropertiesTableAdapter = null;
            this.tableAdapterManager.ProductDetailTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.PropertiesConfig_PropertiesTableAdapter = null;
            this.tableAdapterManager.PropertiesConfigTableAdapter = null;
            this.tableAdapterManager.PropertiesGroupTableAdapter = null;
            this.tableAdapterManager.PropertiesTableAdapter = null;
            this.tableAdapterManager.PropertiesValueTableAdapter = null;
            this.tableAdapterManager.PropertiesViewTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.ProductID.DBPropertiesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // keySearchTextEdit
            // 
            this.keySearchTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.listClassificationBindingSource, "KeySearch", true));
            this.keySearchTextEdit.Location = new System.Drawing.Point(272, 272);
            this.keySearchTextEdit.Name = "keySearchTextEdit";
            this.keySearchTextEdit.Properties.ReadOnly = true;
            this.keySearchTextEdit.Size = new System.Drawing.Size(100, 20);
            this.keySearchTextEdit.TabIndex = 19;
            this.keySearchTextEdit.EditValueChanged += new System.EventHandler(this.keySearchTextEdit_EditValueChanged);
            this.keySearchTextEdit.TextChanged += new System.EventHandler(this.keySearchTextEdit_TextChanged);
            // 
            // contentFTTextEdit
            // 
            this.contentFTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "ContentFT", true));
            this.contentFTTextEdit.Location = new System.Drawing.Point(277, 171);
            this.contentFTTextEdit.Name = "contentFTTextEdit";
            this.contentFTTextEdit.Properties.ReadOnly = true;
            this.contentFTTextEdit.Size = new System.Drawing.Size(100, 20);
            this.contentFTTextEdit.TabIndex = 21;
            // 
            // frmAddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 307);
            this.Controls.Add(contentFTLabel);
            this.Controls.Add(this.contentFTTextEdit);
            this.Controls.Add(keySearchLabel);
            this.Controls.Add(this.keySearchTextEdit);
            this.Controls.Add(validLabel);
            this.Controls.Add(this.validCheckBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(nameFTLabel);
            this.Controls.Add(this.nameFTTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(summaryLabel);
            this.Controls.Add(this.summaryTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Name = "frmAddNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewProduct";
            this.Load += new System.EventHandler(this.frmAddNewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keySearchTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentFTTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBProperties dBProperties;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBPropertiesTableAdapters.ProductTableAdapter productTableAdapter;
        private DBPropertiesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox summaryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox categoryIDComboBox;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DBPropertiesTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.SimpleButton btClose;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox nameFTTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.CheckBox validCheckBox;
        private DevExpress.XtraEditors.TextEdit keySearchTextEdit;
        private DevExpress.XtraEditors.TextEdit contentFTTextEdit;
    }
}