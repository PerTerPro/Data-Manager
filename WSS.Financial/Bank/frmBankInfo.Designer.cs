namespace WSS.Financial.Bank
{
    partial class FrmBankInfo
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
            System.Windows.Forms.Label bankWebsiteLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label isActiveLabel;
            this.dBFinancial = new WSS.Financial.DBFinancial();
            this.bankBindingSource = new System.Windows.Forms.BindingSource();
            this.bankTableAdapter = new WSS.Financial.DBFinancialTableAdapters.BankTableAdapter();
            this.tableAdapterManager = new WSS.Financial.DBFinancialTableAdapters.TableAdapterManager();
            this.bankIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bankNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bankWebsiteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            bankIdLabel = new System.Windows.Forms.Label();
            bankNameLabel = new System.Windows.Forms.Label();
            bankWebsiteLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankWebsiteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
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
            // bankIdLabel
            // 
            bankIdLabel.AutoSize = true;
            bankIdLabel.Location = new System.Drawing.Point(16, 32);
            bankIdLabel.Name = "bankIdLabel";
            bankIdLabel.Size = new System.Drawing.Size(47, 13);
            bankIdLabel.TabIndex = 1;
            bankIdLabel.Text = "Bank Id:";
            // 
            // bankIdTextEdit
            // 
            this.bankIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "BankId", true));
            this.bankIdTextEdit.Location = new System.Drawing.Point(99, 29);
            this.bankIdTextEdit.Name = "bankIdTextEdit";
            this.bankIdTextEdit.Properties.ReadOnly = true;
            this.bankIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.bankIdTextEdit.TabIndex = 2;
            // 
            // bankNameLabel
            // 
            bankNameLabel.AutoSize = true;
            bankNameLabel.Location = new System.Drawing.Point(16, 58);
            bankNameLabel.Name = "bankNameLabel";
            bankNameLabel.Size = new System.Drawing.Size(66, 13);
            bankNameLabel.TabIndex = 3;
            bankNameLabel.Text = "Bank Name:";
            // 
            // bankNameTextEdit
            // 
            this.bankNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "BankName", true));
            this.bankNameTextEdit.Location = new System.Drawing.Point(99, 55);
            this.bankNameTextEdit.Name = "bankNameTextEdit";
            this.bankNameTextEdit.Size = new System.Drawing.Size(359, 20);
            this.bankNameTextEdit.TabIndex = 4;
            // 
            // bankWebsiteLabel
            // 
            bankWebsiteLabel.AutoSize = true;
            bankWebsiteLabel.Location = new System.Drawing.Point(16, 84);
            bankWebsiteLabel.Name = "bankWebsiteLabel";
            bankWebsiteLabel.Size = new System.Drawing.Size(77, 13);
            bankWebsiteLabel.TabIndex = 5;
            bankWebsiteLabel.Text = "Bank Website:";
            // 
            // bankWebsiteTextEdit
            // 
            this.bankWebsiteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "BankWebsite", true));
            this.bankWebsiteTextEdit.Location = new System.Drawing.Point(99, 81);
            this.bankWebsiteTextEdit.Name = "bankWebsiteTextEdit";
            this.bankWebsiteTextEdit.Size = new System.Drawing.Size(359, 20);
            this.bankWebsiteTextEdit.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(16, 110);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextEdit
            // 
            this.descriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "Description", true));
            this.descriptionTextEdit.Location = new System.Drawing.Point(99, 107);
            this.descriptionTextEdit.Name = "descriptionTextEdit";
            this.descriptionTextEdit.Size = new System.Drawing.Size(359, 20);
            this.descriptionTextEdit.TabIndex = 8;
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(310, 32);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 9;
            isActiveLabel.Text = "Is Active:";
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankBindingSource, "IsActive", true));
            this.isActiveCheckEdit.Location = new System.Drawing.Point(393, 29);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "Active";
            this.isActiveCheckEdit.Size = new System.Drawing.Size(65, 19);
            this.isActiveCheckEdit.TabIndex = 10;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.bankNameTextEdit);
            this.groupControl1.Controls.Add(bankIdLabel);
            this.groupControl1.Controls.Add(this.isActiveCheckEdit);
            this.groupControl1.Controls.Add(this.bankIdTextEdit);
            this.groupControl1.Controls.Add(isActiveLabel);
            this.groupControl1.Controls.Add(bankNameLabel);
            this.groupControl1.Controls.Add(this.descriptionTextEdit);
            this.groupControl1.Controls.Add(descriptionLabel);
            this.groupControl1.Controls.Add(bankWebsiteLabel);
            this.groupControl1.Controls.Add(this.bankWebsiteTextEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(689, 144);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Thông tin ngân hàng";
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 144);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(689, 373);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Thông tin các chi nhánh giao dịch (dự kiến)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(602, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 48);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmBankInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 517);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmBankInfo";
            this.Text = "frmBankInfo";
            this.Load += new System.EventHandler(this.FrmBankInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankWebsiteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private DBFinancialTableAdapters.BankTableAdapter bankTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit bankIdTextEdit;
        private DevExpress.XtraEditors.TextEdit bankNameTextEdit;
        private DevExpress.XtraEditors.TextEdit bankWebsiteTextEdit;
        private DevExpress.XtraEditors.TextEdit descriptionTextEdit;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}