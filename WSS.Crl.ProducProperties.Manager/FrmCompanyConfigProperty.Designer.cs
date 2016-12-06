namespace WSS.Crl.ProducProperties.Manager
{
    partial class FrmCompanyConfigProperty
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label domainLabel;
            System.Windows.Forms.Label linkTestLabel;
            System.Windows.Forms.Label typeLayoutLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.iDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.linkTestTextBox = new System.Windows.Forms.TextBox();
            this.configurationBindingSource = new System.Windows.Forms.BindingSource();
            this.productQT = new WSS.Crl.ProducProperties.Manager.ProductQT();
            this.companyBindingSource = new System.Windows.Forms.BindingSource();
            this.companyTableAdapter = new WSS.Crl.ProducProperties.Manager.ProductQTTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager = new WSS.Crl.ProducProperties.Manager.ProductQTTableAdapters.TableAdapterManager();
            this.configurationTableAdapter = new WSS.Crl.ProducProperties.Manager.ProductQTTableAdapters.ConfigurationTableAdapter();
            this.configuration_PropertyBindingSource = new System.Windows.Forms.BindingSource();
            this.configuration_PropertyTableAdapter = new WSS.Crl.ProducProperties.Manager.ProductQTTableAdapters.Configuration_PropertyTableAdapter();
            this.typeLayoutComboBox = new System.Windows.Forms.ComboBox();
            iDLabel = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            linkTestLabel = new System.Windows.Forms.Label();
            typeLayoutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuration_PropertyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(linkTestLabel);
            this.panelControl1.Controls.Add(this.linkTestTextBox);
            this.panelControl1.Controls.Add(domainLabel);
            this.panelControl1.Controls.Add(this.domainTextBox);
            this.panelControl1.Controls.Add(iDLabel);
            this.panelControl1.Controls.Add(this.iDSpinEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1134, 69);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 69);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1134, 42);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 710);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1134, 100);
            this.panelControl3.TabIndex = 2;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.panel1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl5.Location = new System.Drawing.Point(817, 111);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(317, 599);
            this.panelControl5.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 31);
            this.panel1.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(4, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "&Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(92, 15);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // iDSpinEdit
            // 
            this.iDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "ID", true));
            this.iDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iDSpinEdit.Location = new System.Drawing.Point(119, 12);
            this.iDSpinEdit.Name = "iDSpinEdit";
            this.iDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iDSpinEdit.Size = new System.Drawing.Size(212, 20);
            this.iDSpinEdit.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(typeLayoutLabel);
            this.panelControl4.Controls.Add(this.typeLayoutComboBox);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(0, 111);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(817, 599);
            this.panelControl4.TabIndex = 5;
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(67, 41);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 2;
            domainLabel.Text = "Domain:";
            // 
            // domainTextBox
            // 
            this.domainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Domain", true));
            this.domainTextBox.Location = new System.Drawing.Point(119, 38);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(212, 20);
            this.domainTextBox.TabIndex = 3;
            // 
            // linkTestLabel
            // 
            linkTestLabel.AutoSize = true;
            linkTestLabel.Location = new System.Drawing.Point(361, 14);
            linkTestLabel.Name = "linkTestLabel";
            linkTestLabel.Size = new System.Drawing.Size(54, 13);
            linkTestLabel.TabIndex = 4;
            linkTestLabel.Text = "Link Test:";
            // 
            // linkTestTextBox
            // 
            this.linkTestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "LinkTest", true));
            this.linkTestTextBox.Location = new System.Drawing.Point(421, 11);
            this.linkTestTextBox.Name = "linkTestTextBox";
            this.linkTestTextBox.Size = new System.Drawing.Size(438, 20);
            this.linkTestTextBox.TabIndex = 5;
            // 
            // configurationBindingSource
            // 
            this.configurationBindingSource.DataMember = "Configuration";
            this.configurationBindingSource.DataSource = this.productQT;
            // 
            // productQT
            // 
            this.productQT.DataSetName = "ProductQT";
            this.productQT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.productQT;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.Configuration_PropertyTableAdapter = null;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.Crl.ProducProperties.Manager.ProductQTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // configurationTableAdapter
            // 
            this.configurationTableAdapter.ClearBeforeFill = true;
            // 
            // configuration_PropertyBindingSource
            // 
            this.configuration_PropertyBindingSource.DataMember = "Configuration_Property";
            this.configuration_PropertyBindingSource.DataSource = this.productQT;
            // 
            // configuration_PropertyTableAdapter
            // 
            this.configuration_PropertyTableAdapter.ClearBeforeFill = true;
            // 
            // typeLayoutLabel
            // 
            typeLayoutLabel.AutoSize = true;
            typeLayoutLabel.Location = new System.Drawing.Point(44, 15);
            typeLayoutLabel.Name = "typeLayoutLabel";
            typeLayoutLabel.Size = new System.Drawing.Size(69, 13);
            typeLayoutLabel.TabIndex = 0;
            typeLayoutLabel.Text = "Type Layout:";
            // 
            // typeLayoutComboBox
            // 
            this.typeLayoutComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configuration_PropertyBindingSource, "TypeLayout", true));
            this.typeLayoutComboBox.FormattingEnabled = true;
            this.typeLayoutComboBox.Items.AddRange(new object[] {
            "TableNormal",
            "TableHeader"});
            this.typeLayoutComboBox.Location = new System.Drawing.Point(119, 12);
            this.typeLayoutComboBox.Name = "typeLayoutComboBox";
            this.typeLayoutComboBox.Size = new System.Drawing.Size(212, 21);
            this.typeLayoutComboBox.TabIndex = 1;
            // 
            // FrmCompanyConfigProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1134, 810);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCompanyConfigProperty";
            this.Text = "FrmCompanyConfigProperty";
            this.Load += new System.EventHandler(this.FrmCompanyConfigProperty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuration_PropertyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTest;
        private ProductQT productQT;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private ProductQTTableAdapters.CompanyTableAdapter companyTableAdapter;
        private ProductQTTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox domainTextBox;
        private DevExpress.XtraEditors.SpinEdit iDSpinEdit;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.BindingSource configurationBindingSource;
        private ProductQTTableAdapters.ConfigurationTableAdapter configurationTableAdapter;
        private System.Windows.Forms.TextBox linkTestTextBox;
        private System.Windows.Forms.BindingSource configuration_PropertyBindingSource;
        private ProductQTTableAdapters.Configuration_PropertyTableAdapter configuration_PropertyTableAdapter;
        private System.Windows.Forms.ComboBox typeLayoutComboBox;
    }
}