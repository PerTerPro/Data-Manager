namespace QT.Moduls.CrawlerProduct
{
    partial class FrmConfigCrawlHotProduct
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
            System.Windows.Forms.Label hotProduct_XpathLabel;
            System.Windows.Forms.Label hotProduct_LinkLabel;
            System.Windows.Forms.Label companyIDLabel;
            System.Windows.Forms.Label hotProduct_UseSeleniumLabel;
            this.configFixSignTextTableAdapter1 = new QT.Entities.DBTableAdapters.ConfigFixSignTextTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hotProduct_UseSeleniumCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.configurationHotProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB = new QT.Moduls.DB();
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.companyIDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.hotProduct_LinkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.hotProduct_XpathTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.configurationHotProductTableAdapter = new QT.Moduls.DBTableAdapters.ConfigurationHotProductTableAdapter();
            this.tableAdapterManager = new QT.Moduls.DBTableAdapters.TableAdapterManager();
            hotProduct_XpathLabel = new System.Windows.Forms.Label();
            hotProduct_LinkLabel = new System.Windows.Forms.Label();
            companyIDLabel = new System.Windows.Forms.Label();
            hotProduct_UseSeleniumLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotProduct_UseSeleniumCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationHotProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotProduct_LinkMemoEdit.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hotProduct_XpathLabel
            // 
            hotProduct_XpathLabel.AutoSize = true;
            hotProduct_XpathLabel.Location = new System.Drawing.Point(36, 9);
            hotProduct_XpathLabel.Name = "hotProduct_XpathLabel";
            hotProduct_XpathLabel.Size = new System.Drawing.Size(98, 13);
            hotProduct_XpathLabel.TabIndex = 2;
            hotProduct_XpathLabel.Text = "Hot Product Xpath:";
            // 
            // hotProduct_LinkLabel
            // 
            hotProduct_LinkLabel.AutoSize = true;
            hotProduct_LinkLabel.Location = new System.Drawing.Point(44, 35);
            hotProduct_LinkLabel.Name = "hotProduct_LinkLabel";
            hotProduct_LinkLabel.Size = new System.Drawing.Size(90, 13);
            hotProduct_LinkLabel.TabIndex = 4;
            hotProduct_LinkLabel.Text = "Hot Product Link:";
            // 
            // companyIDLabel
            // 
            companyIDLabel.AutoSize = true;
            companyIDLabel.Location = new System.Drawing.Point(629, 9);
            companyIDLabel.Name = "companyIDLabel";
            companyIDLabel.Size = new System.Drawing.Size(68, 13);
            companyIDLabel.TabIndex = 5;
            companyIDLabel.Text = "Company ID:";
            // 
            // hotProduct_UseSeleniumLabel
            // 
            hotProduct_UseSeleniumLabel.AutoSize = true;
            hotProduct_UseSeleniumLabel.Location = new System.Drawing.Point(595, 120);
            hotProduct_UseSeleniumLabel.Name = "hotProduct_UseSeleniumLabel";
            hotProduct_UseSeleniumLabel.Size = new System.Drawing.Size(135, 13);
            hotProduct_UseSeleniumLabel.TabIndex = 8;
            hotProduct_UseSeleniumLabel.Text = "Hot Product Use Selenium:";
            // 
            // configFixSignTextTableAdapter1
            // 
            this.configFixSignTextTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(hotProduct_UseSeleniumLabel);
            this.panel1.Controls.Add(this.hotProduct_UseSeleniumCheckEdit);
            this.panel1.Controls.Add(this.btnViewData);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(companyIDLabel);
            this.panel1.Controls.Add(this.companyIDSpinEdit);
            this.panel1.Controls.Add(hotProduct_LinkLabel);
            this.panel1.Controls.Add(hotProduct_XpathLabel);
            this.panel1.Controls.Add(this.hotProduct_LinkMemoEdit);
            this.panel1.Controls.Add(this.hotProduct_XpathTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 162);
            this.panel1.TabIndex = 0;
            // 
            // hotProduct_UseSeleniumCheckEdit
            // 
            this.hotProduct_UseSeleniumCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationHotProductBindingSource, "HotProduct_UseSelenium", true));
            this.hotProduct_UseSeleniumCheckEdit.Location = new System.Drawing.Point(736, 117);
            this.hotProduct_UseSeleniumCheckEdit.Name = "hotProduct_UseSeleniumCheckEdit";
            this.hotProduct_UseSeleniumCheckEdit.Properties.Caption = "";
            this.hotProduct_UseSeleniumCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.hotProduct_UseSeleniumCheckEdit.TabIndex = 9;
            // 
            // configurationHotProductBindingSource
            // 
            this.configurationHotProductBindingSource.DataMember = "ConfigurationHotProduct";
            this.configurationHotProductBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.EnforceConstraints = false;
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(632, 61);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(75, 23);
            this.btnViewData.TabIndex = 8;
            this.btnViewData.Text = "ViewData";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(632, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.configurationHotProductBindingNavigatorSaveItem_Click);
            // 
            // companyIDSpinEdit
            // 
            this.companyIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationHotProductBindingSource, "CompanyID", true));
            this.companyIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.companyIDSpinEdit.Location = new System.Drawing.Point(703, 6);
            this.companyIDSpinEdit.Name = "companyIDSpinEdit";
            this.companyIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.companyIDSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.companyIDSpinEdit.TabIndex = 6;
            // 
            // hotProduct_LinkMemoEdit
            // 
            this.hotProduct_LinkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationHotProductBindingSource, "HotProduct_Link", true));
            this.hotProduct_LinkMemoEdit.Location = new System.Drawing.Point(140, 32);
            this.hotProduct_LinkMemoEdit.Name = "hotProduct_LinkMemoEdit";
            this.hotProduct_LinkMemoEdit.Size = new System.Drawing.Size(401, 110);
            this.hotProduct_LinkMemoEdit.TabIndex = 5;
            // 
            // hotProduct_XpathTextBox
            // 
            this.hotProduct_XpathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationHotProductBindingSource, "HotProduct_Xpath", true));
            this.hotProduct_XpathTextBox.Location = new System.Drawing.Point(140, 6);
            this.hotProduct_XpathTextBox.Name = "hotProduct_XpathTextBox";
            this.hotProduct_XpathTextBox.Size = new System.Drawing.Size(401, 20);
            this.hotProduct_XpathTextBox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.btnRun);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 563);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(140, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(696, 485);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 6);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // configurationHotProductTableAdapter
            // 
            this.configurationHotProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_RattingTableAdapter = null;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.Config_HaravanBizwebTableAdapter = null;
            this.tableAdapterManager.ConfigurationHotProductTableAdapter = this.configurationHotProductTableAdapter;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.MapClassificationTableAdapter = null;
            this.tableAdapterManager.ProductID_PropertyTableAdapter = null;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PropertyGroupTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmConfigCrawlHotProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 725);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConfigCrawlHotProduct";
            this.Text = "Config Hot Product";
            this.Load += new System.EventHandler(this.FrmConfigCrawlHotProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotProduct_UseSeleniumCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationHotProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotProduct_LinkMemoEdit.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Entities.DBTableAdapters.ConfigFixSignTextTableAdapter configFixSignTextTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRun;
        private DB dB;
        private System.Windows.Forms.BindingSource configurationHotProductBindingSource;
        private DBTableAdapters.ConfigurationHotProductTableAdapter configurationHotProductTableAdapter;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.SpinEdit companyIDSpinEdit;
        private DevExpress.XtraEditors.MemoEdit hotProduct_LinkMemoEdit;
        private System.Windows.Forms.TextBox hotProduct_XpathTextBox;
        private System.Windows.Forms.Button btnViewData;
        private DevExpress.XtraEditors.CheckEdit hotProduct_UseSeleniumCheckEdit;
    }
}