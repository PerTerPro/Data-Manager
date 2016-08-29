namespace UpdateSolrTools
{
    partial class FrmToolUpdateSolr
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
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRunAsServiceBreakTime = new System.Windows.Forms.TextBox();
            this.txtTimeDelay = new System.Windows.Forms.TextBox();
            this.chkEdite = new System.Windows.Forms.CheckBox();
            this.buttonUpdateProducts = new System.Windows.Forms.Button();
            this.buttonUpdateRootProduct = new System.Windows.Forms.Button();
            this.btnUpdateProductProperties = new System.Windows.Forms.Button();
            this.btUpdateViewCount = new System.Windows.Forms.Button();
            this.buttonCommitSolr = new System.Windows.Forms.Button();
            this.buttonRunAllAsService = new System.Windows.Forms.Button();
            this.buttonRunIndexAsService = new System.Windows.Forms.Button();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.memoCode = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastFullCrawler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdateSolr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataSet = new CompanyDataSet();
            this.dBTool2 = new DBTool2();
            this.companyTableAdapter = new DBTool2TableAdapters.CompanyTableAdapter();
            this.companyTableAdapter1 = new CompanyDataSetTableAdapters.CompanyTableAdapter();
            this.comboBoxSolrNodes = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(453, 578);
            this.richTextBoxInfo.TabIndex = 9;
            this.richTextBoxInfo.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxSolrNodes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRunAsServiceBreakTime);
            this.panel1.Controls.Add(this.txtTimeDelay);
            this.panel1.Controls.Add(this.chkEdite);
            this.panel1.Controls.Add(this.buttonUpdateProducts);
            this.panel1.Controls.Add(this.buttonUpdateRootProduct);
            this.panel1.Controls.Add(this.btnUpdateProductProperties);
            this.panel1.Controls.Add(this.btUpdateViewCount);
            this.panel1.Controls.Add(this.buttonCommitSolr);
            this.panel1.Controls.Add(this.buttonRunAllAsService);
            this.panel1.Controls.Add(this.buttonRunIndexAsService);
            this.panel1.Controls.Add(this.buttonClearLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 572);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sleep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Delay";
            // 
            // txtRunAsServiceBreakTime
            // 
            this.txtRunAsServiceBreakTime.Location = new System.Drawing.Point(48, 350);
            this.txtRunAsServiceBreakTime.Name = "txtRunAsServiceBreakTime";
            this.txtRunAsServiceBreakTime.Size = new System.Drawing.Size(49, 20);
            this.txtRunAsServiceBreakTime.TabIndex = 27;
            this.txtRunAsServiceBreakTime.Text = "120";
            // 
            // txtTimeDelay
            // 
            this.txtTimeDelay.Location = new System.Drawing.Point(49, 8);
            this.txtTimeDelay.Name = "txtTimeDelay";
            this.txtTimeDelay.Size = new System.Drawing.Size(61, 20);
            this.txtTimeDelay.TabIndex = 26;
            this.txtTimeDelay.Text = "10";
            // 
            // chkEdite
            // 
            this.chkEdite.AutoSize = true;
            this.chkEdite.Location = new System.Drawing.Point(69, 149);
            this.chkEdite.Name = "chkEdite";
            this.chkEdite.Size = new System.Drawing.Size(56, 17);
            this.chkEdite.TabIndex = 25;
            this.chkEdite.Text = "check";
            this.chkEdite.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateProducts
            // 
            this.buttonUpdateProducts.Location = new System.Drawing.Point(9, 34);
            this.buttonUpdateProducts.Name = "buttonUpdateProducts";
            this.buttonUpdateProducts.Size = new System.Drawing.Size(143, 23);
            this.buttonUpdateProducts.TabIndex = 24;
            this.buttonUpdateProducts.Text = "Update Products";
            this.buttonUpdateProducts.UseVisualStyleBackColor = true;
            this.buttonUpdateProducts.Click += new System.EventHandler(this.btUpdateSolr_Click);
            // 
            // buttonUpdateRootProduct
            // 
            this.buttonUpdateRootProduct.Location = new System.Drawing.Point(9, 63);
            this.buttonUpdateRootProduct.Name = "buttonUpdateRootProduct";
            this.buttonUpdateRootProduct.Size = new System.Drawing.Size(143, 23);
            this.buttonUpdateRootProduct.TabIndex = 23;
            this.buttonUpdateRootProduct.Text = "Update Root Products";
            this.buttonUpdateRootProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateRootProduct.Click += new System.EventHandler(this.btUpdateSolrID_Click);
            // 
            // btnUpdateProductProperties
            // 
            this.btnUpdateProductProperties.Location = new System.Drawing.Point(9, 92);
            this.btnUpdateProductProperties.Name = "btnUpdateProductProperties";
            this.btnUpdateProductProperties.Size = new System.Drawing.Size(143, 23);
            this.btnUpdateProductProperties.TabIndex = 22;
            this.btnUpdateProductProperties.Text = "Update Product Properties";
            this.btnUpdateProductProperties.UseVisualStyleBackColor = true;
            this.btnUpdateProductProperties.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btUpdateViewCount
            // 
            this.btUpdateViewCount.Location = new System.Drawing.Point(9, 123);
            this.btUpdateViewCount.Name = "btUpdateViewCount";
            this.btUpdateViewCount.Size = new System.Drawing.Size(143, 23);
            this.btUpdateViewCount.TabIndex = 21;
            this.btUpdateViewCount.Text = "Update View Count";
            this.btUpdateViewCount.UseVisualStyleBackColor = true;
            // 
            // buttonCommitSolr
            // 
            this.buttonCommitSolr.Location = new System.Drawing.Point(12, 281);
            this.buttonCommitSolr.Name = "buttonCommitSolr";
            this.buttonCommitSolr.Size = new System.Drawing.Size(138, 23);
            this.buttonCommitSolr.TabIndex = 20;
            this.buttonCommitSolr.Text = "Commit Solr";
            this.buttonCommitSolr.UseVisualStyleBackColor = true;
            this.buttonCommitSolr.Click += new System.EventHandler(this.buttonCommitSolr_Click);
            // 
            // buttonRunAllAsService
            // 
            this.buttonRunAllAsService.Location = new System.Drawing.Point(9, 321);
            this.buttonRunAllAsService.Name = "buttonRunAllAsService";
            this.buttonRunAllAsService.Size = new System.Drawing.Size(138, 23);
            this.buttonRunAllAsService.TabIndex = 19;
            this.buttonRunAllAsService.Text = "Run All As Service";
            this.buttonRunAllAsService.UseVisualStyleBackColor = true;
            this.buttonRunAllAsService.Click += new System.EventHandler(this.buttonRunAllAsService_Click);
            // 
            // buttonRunIndexAsService
            // 
            this.buttonRunIndexAsService.Location = new System.Drawing.Point(11, 378);
            this.buttonRunIndexAsService.Name = "buttonRunIndexAsService";
            this.buttonRunIndexAsService.Size = new System.Drawing.Size(138, 23);
            this.buttonRunIndexAsService.TabIndex = 18;
            this.buttonRunIndexAsService.Text = "Run Index As Service";
            this.buttonRunIndexAsService.UseVisualStyleBackColor = true;
            this.buttonRunIndexAsService.Click += new System.EventHandler(this.buttonRunIndexAsService_Click);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(5, 421);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(150, 59);
            this.buttonClearLog.TabIndex = 17;
            this.buttonClearLog.Text = "Clear Log";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(167, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBoxInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.memoCode);
            this.splitContainer1.Size = new System.Drawing.Size(693, 578);
            this.splitContainer1.SplitterDistance = 453;
            this.splitContainer1.TabIndex = 12;
            // 
            // memoCode
            // 
            this.memoCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoCode.Location = new System.Drawing.Point(0, 0);
            this.memoCode.Name = "memoCode";
            this.memoCode.Size = new System.Drawing.Size(236, 578);
            this.memoCode.TabIndex = 0;
            this.memoCode.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 604);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Update All";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(860, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Per Company";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Website,
            this.TotalProduct,
            this.LastFullCrawler,
            this.LastUpdateSolr});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(551, 442);
            this.dataGridView1.TabIndex = 0;
            // 
            // Website
            // 
            this.Website.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Website.DataPropertyName = "Website";
            this.Website.FillWeight = 25F;
            this.Website.HeaderText = "Website";
            this.Website.Name = "Website";
            this.Website.ReadOnly = true;
            // 
            // TotalProduct
            // 
            this.TotalProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalProduct.DataPropertyName = "TotalProduct";
            this.TotalProduct.FillWeight = 10F;
            this.TotalProduct.HeaderText = "TotalProduct";
            this.TotalProduct.Name = "TotalProduct";
            this.TotalProduct.ReadOnly = true;
            // 
            // LastFullCrawler
            // 
            this.LastFullCrawler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastFullCrawler.DataPropertyName = "LastFullCrawler";
            this.LastFullCrawler.FillWeight = 20F;
            this.LastFullCrawler.HeaderText = "LastFullCrawler";
            this.LastFullCrawler.Name = "LastFullCrawler";
            this.LastFullCrawler.ReadOnly = true;
            // 
            // LastUpdateSolr
            // 
            this.LastUpdateSolr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastUpdateSolr.DataPropertyName = "LastUpdateSolr";
            this.LastUpdateSolr.FillWeight = 20F;
            this.LastUpdateSolr.HeaderText = "LastUpdateSolr";
            this.LastUpdateSolr.Name = "LastUpdateSolr";
            this.LastUpdateSolr.ReadOnly = true;
            // 
            // companyDataSet
            // 
            this.companyDataSet.DataSetName = "CompanyDataSet";
            this.companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBTool2
            // 
            this.dBTool2.DataSetName = "DBTool2";
            this.dBTool2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter1
            // 
            this.companyTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBoxSolrNodes
            // 
            this.comboBoxSolrNodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSolrNodes.DropDownWidth = 255;
            this.comboBoxSolrNodes.FormattingEnabled = true;
            this.comboBoxSolrNodes.Location = new System.Drawing.Point(0, 181);
            this.comboBoxSolrNodes.Name = "comboBoxSolrNodes";
            this.comboBoxSolrNodes.Size = new System.Drawing.Size(155, 21);
            this.comboBoxSolrNodes.TabIndex = 33;
            this.comboBoxSolrNodes.SelectedIndexChanged += new System.EventHandler(this.comboBoxSolrNodes_SelectedIndexChanged);
            // 
            // FrmToolUpdateSolr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(868, 604);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmToolUpdateSolr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmToolUpdateSolr_FormClosing);
            this.Load += new System.EventHandler(this.FrmToolUpdateSolr_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBTool2 dBTool2;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBTool2TableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource2;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        private CompanyDataSet companyDataSet;
        private System.Windows.Forms.BindingSource companyBindingSource3;
        private CompanyDataSetTableAdapters.CompanyTableAdapter companyTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.BindingSource companyBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastFullCrawler;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdateSolr;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Button buttonRunIndexAsService;
        private System.Windows.Forms.Button buttonCommitSolr;
        private System.Windows.Forms.Button buttonRunAllAsService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRunAsServiceBreakTime;
        private System.Windows.Forms.TextBox txtTimeDelay;
        private System.Windows.Forms.CheckBox chkEdite;
        private System.Windows.Forms.Button buttonUpdateProducts;
        private System.Windows.Forms.Button buttonUpdateRootProduct;
        private System.Windows.Forms.Button btnUpdateProductProperties;
        private System.Windows.Forms.Button btUpdateViewCount;
        private System.Windows.Forms.RichTextBox memoCode;
        private System.Windows.Forms.ComboBox comboBoxSolrNodes;

        public System.EventHandler btUpdateViewCount_Click { get; set; }
    }
}
