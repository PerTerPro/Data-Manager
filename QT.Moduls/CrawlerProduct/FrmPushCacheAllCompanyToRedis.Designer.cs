namespace QT.Moduls.CrawlerProduct
{
    partial class FrmPushCacheAllCompanyToRedis
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.dBCom = new QT.Moduls.Company.DBCom();
            this.companyBindingSource = new System.Windows.Forms.BindingSource();
            this.companyTableAdapter = new QT.Moduls.Company.DBComTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Company.DBComTableAdapters.TableAdapterManager();
            this.productTableAdapter = new QT.Moduls.Company.DBComTableAdapters.ProductTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource();
            this.txtCompanyID = new DevExpress.XtraEditors.TextEdit();
            this.btnPushCheckDumplicate = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelFailRegexPath = new DevExpress.XtraEditors.SimpleButton();
            this.btnVisibleAllDumplicate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(522, 218);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(398, 265);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 17);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dBCom
            // 
            this.dBCom.DataSetName = "DBCom";
            this.dBCom.EnforceConstraints = false;
            this.dBCom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBCom;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_AddressTableAdapter = null;
            this.tableAdapterManager.Company_ImageTableAdapter = null;
            this.tableAdapterManager.Company1TableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.DatafeedConfigTableAdapter = null;
            this.tableAdapterManager.HistoryDatafeedTableAdapter = null;
            this.tableAdapterManager.Job_WebsiteConfigLogTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.ManagerCompanyLogTableAdapter = null;
            this.tableAdapterManager.ManagerCompanyLogTypeTableAdapter = null;
            this.tableAdapterManager.ManagerCrawlerTableAdapter = null;
            this.tableAdapterManager.ManagerTypeRCompanyTableAdapter = null;
            this.tableAdapterManager.ManagerTypeTableAdapter = null;
            this.tableAdapterManager.ProductQuangCaoTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Company.DBComTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBCom;
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(25, 262);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(188, 20);
            this.txtCompanyID.TabIndex = 3;
            // 
            // btnPushCheckDumplicate
            // 
            this.btnPushCheckDumplicate.Location = new System.Drawing.Point(398, 288);
            this.btnPushCheckDumplicate.Name = "btnPushCheckDumplicate";
            this.btnPushCheckDumplicate.Size = new System.Drawing.Size(149, 20);
            this.btnPushCheckDumplicate.TabIndex = 6;
            this.btnPushCheckDumplicate.Text = "PushCheckDumplicateData";
            this.btnPushCheckDumplicate.Click += new System.EventHandler(this.btnPushCheckDumplicate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DomainCompany";
            // 
            // btnDelFailRegexPath
            // 
            this.btnDelFailRegexPath.Location = new System.Drawing.Point(244, 259);
            this.btnDelFailRegexPath.Name = "btnDelFailRegexPath";
            this.btnDelFailRegexPath.Size = new System.Drawing.Size(149, 23);
            this.btnDelFailRegexPath.TabIndex = 8;
            this.btnDelFailRegexPath.Text = "Del Fail Regex Url";
            this.btnDelFailRegexPath.Click += new System.EventHandler(this.btnDelFailRegexPath_Click);
            // 
            // btnVisibleAllDumplicate
            // 
            this.btnVisibleAllDumplicate.Location = new System.Drawing.Point(244, 288);
            this.btnVisibleAllDumplicate.Name = "btnVisibleAllDumplicate";
            this.btnVisibleAllDumplicate.Size = new System.Drawing.Size(149, 23);
            this.btnVisibleAllDumplicate.TabIndex = 9;
            this.btnVisibleAllDumplicate.Text = "NoValid DupicateData";
            this.btnVisibleAllDumplicate.Click += new System.EventHandler(this.btnVisibleAllDumplicate_Click);
            // 
            // FrmPushCacheAllCompanyToRedis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 372);
            this.Controls.Add(this.btnVisibleAllDumplicate);
            this.Controls.Add(this.btnDelFailRegexPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPushCheckDumplicate);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmPushCacheAllCompanyToRedis";
            this.Text = "FrmPushCacheAllCompanyToRedis";
            this.Load += new System.EventHandler(this.FrmPushCacheAllCompanyToRedis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Company.DBCom dBCom;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private Company.DBComTableAdapters.CompanyTableAdapter companyTableAdapter;
        private Company.DBComTableAdapters.TableAdapterManager tableAdapterManager;
        private Company.DBComTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.TextEdit txtCompanyID;
        private DevExpress.XtraEditors.SimpleButton btnPushCheckDumplicate;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnDelFailRegexPath;
        private DevExpress.XtraEditors.SimpleButton btnVisibleAllDumplicate;
    }
}