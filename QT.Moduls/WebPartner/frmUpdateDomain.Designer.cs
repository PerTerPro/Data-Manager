namespace QT.Moduls.WebPartner
{
    partial class frmUpdateDomain
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
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label domainLabel;
            System.Windows.Forms.Label statusLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.websiteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.domainTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.iDSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.statusSpinEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBWebPartner = new QT.Moduls.WebPartner.DBWebPartner();
            this.companyTableAdapter = new QT.Moduls.WebPartner.DBWebPartnerTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager = new QT.Moduls.WebPartner.DBWebPartnerTableAdapters.TableAdapterManager();
            this.companyStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.company_StatusTableAdapter = new QT.Moduls.WebPartner.DBWebPartnerTableAdapters.Company_StatusTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBWebPartner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(413, 365);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(statusLabel);
            this.groupControl1.Controls.Add(domainLabel);
            this.groupControl1.Controls.Add(this.domainTextEdit);
            this.groupControl1.Controls.Add(websiteLabel);
            this.groupControl1.Controls.Add(this.websiteTextEdit);
            this.groupControl1.Controls.Add(iDLabel);
            this.groupControl1.Controls.Add(this.iDSpinEdit);
            this.groupControl1.Controls.Add(this.statusSpinEdit);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(409, 361);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Domai cũ";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(413, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(496, 365);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(492, 361);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Dữ liệu công ty mới";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 42);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(12, 96);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(49, 13);
            websiteLabel.TabIndex = 4;
            websiteLabel.Text = "Website:";
            // 
            // websiteTextEdit
            // 
            this.websiteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Website", true));
            this.websiteTextEdit.Location = new System.Drawing.Point(66, 93);
            this.websiteTextEdit.Name = "websiteTextEdit";
            this.websiteTextEdit.Size = new System.Drawing.Size(200, 20);
            this.websiteTextEdit.TabIndex = 5;
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(12, 151);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 6;
            domainLabel.Text = "Domain:";
            // 
            // domainTextEdit
            // 
            this.domainTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Domain", true));
            this.domainTextEdit.Location = new System.Drawing.Point(66, 148);
            this.domainTextEdit.Name = "domainTextEdit";
            this.domainTextEdit.Size = new System.Drawing.Size(200, 20);
            this.domainTextEdit.TabIndex = 7;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(12, 204);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "Status:";
            // 
            // iDSpinEdit
            // 
            this.iDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "ID", true));
            this.iDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iDSpinEdit.Location = new System.Drawing.Point(66, 39);
            this.iDSpinEdit.Name = "iDSpinEdit";
            this.iDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.iDSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.iDSpinEdit.Size = new System.Drawing.Size(200, 20);
            this.iDSpinEdit.TabIndex = 1;
            // 
            // statusSpinEdit
            // 
            this.statusSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Status", true));
            this.statusSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.statusSpinEdit.Location = new System.Drawing.Point(66, 201);
            this.statusSpinEdit.Name = "statusSpinEdit";
            this.statusSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusSpinEdit.Properties.DataSource = this.companyStatusBindingSource;
            this.statusSpinEdit.Properties.DisplayMember = "Description";
            this.statusSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.statusSpinEdit.Properties.NullText = "";
            this.statusSpinEdit.Properties.ValueMember = "ID";
            this.statusSpinEdit.Size = new System.Drawing.Size(200, 20);
            this.statusSpinEdit.TabIndex = 9;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBWebPartner;
            // 
            // dBWebPartner
            // 
            this.dBWebPartner.DataSetName = "DBWebPartner";
            this.dBWebPartner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Company_HaravanTableAdapter = null;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.Product_MappingHaravanTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.WebPartner.DBWebPartnerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companyStatusBindingSource
            // 
            this.companyStatusBindingSource.DataMember = "Company_Status";
            this.companyStatusBindingSource.DataSource = this.dBWebPartner;
            // 
            // company_StatusTableAdapter
            // 
            this.company_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // frmUpdateDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 365);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmUpdateDomain";
            this.Text = "frmUpdateDomain";
            this.Load += new System.EventHandler(this.frmUpdateDomain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBWebPartner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DBWebPartner dBWebPartner;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBWebPartnerTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DBWebPartnerTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit domainTextEdit;
        private DevExpress.XtraEditors.TextEdit websiteTextEdit;
        private DevExpress.XtraEditors.TextEdit iDSpinEdit;
        private DevExpress.XtraEditors.LookUpEdit statusSpinEdit;
        private System.Windows.Forms.BindingSource companyStatusBindingSource;
        private DBWebPartnerTableAdapters.Company_StatusTableAdapter company_StatusTableAdapter;
    }
}