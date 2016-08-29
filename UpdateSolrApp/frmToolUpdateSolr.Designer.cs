namespace UpdateSolrApp
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
            this.components = new System.ComponentModel.Container();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.panelMainControl = new System.Windows.Forms.Panel();
            this.buttonScheduleUpdate = new System.Windows.Forms.Button();
            this.buttonOptimizeSolr = new System.Windows.Forms.Button();
            this.comboBoxSolrNodes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeDelay = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.buttonUpdateProducts = new System.Windows.Forms.Button();
            this.buttonUpdateRootProduct = new System.Windows.Forms.Button();
            this.buttonCommitSolr = new System.Windows.Forms.Button();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.memoCode = new System.Windows.Forms.RichTextBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewRunningCompany = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdelay = new System.Windows.Forms.TextBox();
            this.cbDelay = new System.Windows.Forms.CheckBox();
            this.txtCompanyName = new System.Windows.Forms.ComboBox();
            this.richTxtView = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewListCompany = new System.Windows.Forms.DataGridView();
            this.tabPageCreateSynonymsFiles = new System.Windows.Forms.TabPage();
            this.buttonCreateSynonymFiles = new System.Windows.Forms.Button();
            this.buttonSelectOutputDir = new System.Windows.Forms.Button();
            this.labelOutputFileDir = new System.Windows.Forms.Label();
            this.textBoxOutputFilesDir = new System.Windows.Forms.TextBox();
            this.buttonOpenExcelFile = new System.Windows.Forms.Button();
            this.labelExcelFileDir = new System.Windows.Forms.Label();
            this.txtExcelFileDir = new System.Windows.Forms.TextBox();
            this.tabPageKeywordSuggest = new System.Windows.Forms.TabPage();
            this.buttonReIndexKeyword = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textEditProductID = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonUpdateProduct = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStripListCompany = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripRunningCompany = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.synonymsFilesOutputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.companyDataSet = new UpdateSolrApp.CompanyDataSet();
            this.panelMainControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunningCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCompany)).BeginInit();
            this.tabPageCreateSynonymsFiles.SuspendLayout();
            this.tabPageKeywordSuggest.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProductID.Properties)).BeginInit();
            this.contextMenuStripListCompany.SuspendLayout();
            this.contextMenuStripRunningCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).BeginInit();
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
            // panelMainControl
            // 
            this.panelMainControl.Controls.Add(this.buttonScheduleUpdate);
            this.panelMainControl.Controls.Add(this.buttonOptimizeSolr);
            this.panelMainControl.Controls.Add(this.comboBoxSolrNodes);
            this.panelMainControl.Controls.Add(this.label2);
            this.panelMainControl.Controls.Add(this.label1);
            this.panelMainControl.Controls.Add(this.txtTimeDelay);
            this.panelMainControl.Controls.Add(this.btnStop);
            this.panelMainControl.Controls.Add(this.btnUpdateAll);
            this.panelMainControl.Controls.Add(this.buttonUpdateProducts);
            this.panelMainControl.Controls.Add(this.buttonUpdateRootProduct);
            this.panelMainControl.Controls.Add(this.buttonCommitSolr);
            this.panelMainControl.Controls.Add(this.buttonClearLog);
            this.panelMainControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainControl.Location = new System.Drawing.Point(3, 3);
            this.panelMainControl.Name = "panelMainControl";
            this.panelMainControl.Size = new System.Drawing.Size(158, 572);
            this.panelMainControl.TabIndex = 11;
            // 
            // buttonScheduleUpdate
            // 
            this.buttonScheduleUpdate.Location = new System.Drawing.Point(6, 233);
            this.buttonScheduleUpdate.Name = "buttonScheduleUpdate";
            this.buttonScheduleUpdate.Size = new System.Drawing.Size(143, 23);
            this.buttonScheduleUpdate.TabIndex = 35;
            this.buttonScheduleUpdate.Text = "Schedule Update";
            this.buttonScheduleUpdate.UseVisualStyleBackColor = true;
            this.buttonScheduleUpdate.Click += new System.EventHandler(this.buttonScheduleUpdate_Click);
            // 
            // buttonOptimizeSolr
            // 
            this.buttonOptimizeSolr.Location = new System.Drawing.Point(11, 291);
            this.buttonOptimizeSolr.Name = "buttonOptimizeSolr";
            this.buttonOptimizeSolr.Size = new System.Drawing.Size(138, 23);
            this.buttonOptimizeSolr.TabIndex = 34;
            this.buttonOptimizeSolr.Text = "Optimize Solr";
            this.buttonOptimizeSolr.UseVisualStyleBackColor = true;
            this.buttonOptimizeSolr.Click += new System.EventHandler(this.buttonOptimizeSolr_Click);
            // 
            // comboBoxSolrNodes
            // 
            this.comboBoxSolrNodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSolrNodes.DropDownWidth = 255;
            this.comboBoxSolrNodes.FormattingEnabled = true;
            this.comboBoxSolrNodes.Location = new System.Drawing.Point(0, 208);
            this.comboBoxSolrNodes.Name = "comboBoxSolrNodes";
            this.comboBoxSolrNodes.Size = new System.Drawing.Size(155, 21);
            this.comboBoxSolrNodes.TabIndex = 33;
            this.comboBoxSolrNodes.SelectedIndexChanged += new System.EventHandler(this.comboBoxSolrNodes_SelectedIndexChanged);
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
            // txtTimeDelay
            // 
            this.txtTimeDelay.Location = new System.Drawing.Point(49, 8);
            this.txtTimeDelay.Name = "txtTimeDelay";
            this.txtTimeDelay.Size = new System.Drawing.Size(61, 20);
            this.txtTimeDelay.TabIndex = 26;
            this.txtTimeDelay.Text = "10";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(103, 33);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(49, 23);
            this.btnStop.TabIndex = 24;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Location = new System.Drawing.Point(9, 33);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(88, 23);
            this.btnUpdateAll.TabIndex = 24;
            this.btnUpdateAll.Text = "Update All";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // buttonUpdateProducts
            // 
            this.buttonUpdateProducts.Location = new System.Drawing.Point(9, 61);
            this.buttonUpdateProducts.Name = "buttonUpdateProducts";
            this.buttonUpdateProducts.Size = new System.Drawing.Size(143, 23);
            this.buttonUpdateProducts.TabIndex = 24;
            this.buttonUpdateProducts.Text = "Update Products";
            this.buttonUpdateProducts.UseVisualStyleBackColor = true;
            this.buttonUpdateProducts.Click += new System.EventHandler(this.btUpdateSolr_Click);
            // 
            // buttonUpdateRootProduct
            // 
            this.buttonUpdateRootProduct.Location = new System.Drawing.Point(9, 90);
            this.buttonUpdateRootProduct.Name = "buttonUpdateRootProduct";
            this.buttonUpdateRootProduct.Size = new System.Drawing.Size(143, 23);
            this.buttonUpdateRootProduct.TabIndex = 23;
            this.buttonUpdateRootProduct.Text = "Update Root Products";
            this.buttonUpdateRootProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateRootProduct.Click += new System.EventHandler(this.btUpdateSolrID_Click);
            // 
            // buttonCommitSolr
            // 
            this.buttonCommitSolr.Location = new System.Drawing.Point(9, 262);
            this.buttonCommitSolr.Name = "buttonCommitSolr";
            this.buttonCommitSolr.Size = new System.Drawing.Size(138, 23);
            this.buttonCommitSolr.TabIndex = 20;
            this.buttonCommitSolr.Text = "Commit Solr";
            this.buttonCommitSolr.UseVisualStyleBackColor = true;
            this.buttonCommitSolr.Click += new System.EventHandler(this.buttonCommitSolr_Click);
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
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPageCreateSynonymsFiles);
            this.tabMain.Controls.Add(this.tabPageKeywordSuggest);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(868, 604);
            this.tabMain.TabIndex = 13;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelMainControl);
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
            this.tabPage2.Controls.Add(this.dataGridViewRunningCompany);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtdelay);
            this.tabPage2.Controls.Add(this.cbDelay);
            this.tabPage2.Controls.Add(this.txtCompanyName);
            this.tabPage2.Controls.Add(this.richTxtView);
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.dataGridViewListCompany);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(860, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Per Company";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRunningCompany
            // 
            this.dataGridViewRunningCompany.AllowUserToAddRows = false;
            this.dataGridViewRunningCompany.AllowUserToDeleteRows = false;
            this.dataGridViewRunningCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRunningCompany.Location = new System.Drawing.Point(570, 360);
            this.dataGridViewRunningCompany.Name = "dataGridViewRunningCompany";
            this.dataGridViewRunningCompany.ReadOnly = true;
            this.dataGridViewRunningCompany.RowHeadersVisible = false;
            this.dataGridViewRunningCompany.Size = new System.Drawing.Size(251, 152);
            this.dataGridViewRunningCompany.TabIndex = 9;
            this.dataGridViewRunningCompany.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(779, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "minute";
            // 
            // txtdelay
            // 
            this.txtdelay.Location = new System.Drawing.Point(721, 125);
            this.txtdelay.Name = "txtdelay";
            this.txtdelay.Size = new System.Drawing.Size(54, 20);
            this.txtdelay.TabIndex = 7;
            this.txtdelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdelay_KeyPress);
            // 
            // cbDelay
            // 
            this.cbDelay.AutoSize = true;
            this.cbDelay.Location = new System.Drawing.Point(665, 128);
            this.cbDelay.Name = "cbDelay";
            this.cbDelay.Size = new System.Drawing.Size(53, 17);
            this.cbDelay.TabIndex = 6;
            this.cbDelay.Text = "Delay";
            this.cbDelay.UseVisualStyleBackColor = true;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCompanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCompanyName.FormattingEnabled = true;
            this.txtCompanyName.Location = new System.Drawing.Point(665, 48);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(155, 21);
            this.txtCompanyName.TabIndex = 5;
            this.txtCompanyName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCompanyName_KeyUp);
            // 
            // richTxtView
            // 
            this.richTxtView.Location = new System.Drawing.Point(570, 159);
            this.richTxtView.Name = "richTxtView";
            this.richTxtView.Size = new System.Drawing.Size(251, 195);
            this.richTxtView.TabIndex = 4;
            this.richTxtView.Text = "";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(665, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 20);
            this.txtID.TabIndex = 3;
            this.txtID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Website";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(746, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(665, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewListCompany
            // 
            this.dataGridViewListCompany.AllowUserToAddRows = false;
            this.dataGridViewListCompany.AllowUserToDeleteRows = false;
            this.dataGridViewListCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCompany.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewListCompany.Name = "dataGridViewListCompany";
            this.dataGridViewListCompany.ReadOnly = true;
            this.dataGridViewListCompany.RowHeadersVisible = false;
            this.dataGridViewListCompany.Size = new System.Drawing.Size(551, 509);
            this.dataGridViewListCompany.TabIndex = 0;
            this.dataGridViewListCompany.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // tabPageCreateSynonymsFiles
            // 
            this.tabPageCreateSynonymsFiles.Controls.Add(this.buttonCreateSynonymFiles);
            this.tabPageCreateSynonymsFiles.Controls.Add(this.buttonSelectOutputDir);
            this.tabPageCreateSynonymsFiles.Controls.Add(this.labelOutputFileDir);
            this.tabPageCreateSynonymsFiles.Controls.Add(this.textBoxOutputFilesDir);
            this.tabPageCreateSynonymsFiles.Controls.Add(this.buttonOpenExcelFile);
            this.tabPageCreateSynonymsFiles.Controls.Add(this.labelExcelFileDir);
            this.tabPageCreateSynonymsFiles.Controls.Add(this.txtExcelFileDir);
            this.tabPageCreateSynonymsFiles.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateSynonymsFiles.Name = "tabPageCreateSynonymsFiles";
            this.tabPageCreateSynonymsFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateSynonymsFiles.Size = new System.Drawing.Size(860, 578);
            this.tabPageCreateSynonymsFiles.TabIndex = 2;
            this.tabPageCreateSynonymsFiles.Text = "Create Synonyms Files";
            this.tabPageCreateSynonymsFiles.UseVisualStyleBackColor = true;
            // 
            // buttonCreateSynonymFiles
            // 
            this.buttonCreateSynonymFiles.Location = new System.Drawing.Point(341, 186);
            this.buttonCreateSynonymFiles.Name = "buttonCreateSynonymFiles";
            this.buttonCreateSynonymFiles.Size = new System.Drawing.Size(87, 46);
            this.buttonCreateSynonymFiles.TabIndex = 10;
            this.buttonCreateSynonymFiles.Text = "Create";
            this.buttonCreateSynonymFiles.UseVisualStyleBackColor = true;
            this.buttonCreateSynonymFiles.Click += new System.EventHandler(this.buttonCreateSynonymFiles_Click);
            // 
            // buttonSelectOutputDir
            // 
            this.buttonSelectOutputDir.Location = new System.Drawing.Point(526, 142);
            this.buttonSelectOutputDir.Name = "buttonSelectOutputDir";
            this.buttonSelectOutputDir.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectOutputDir.TabIndex = 9;
            this.buttonSelectOutputDir.Text = "Open";
            this.buttonSelectOutputDir.UseVisualStyleBackColor = true;
            this.buttonSelectOutputDir.Click += new System.EventHandler(this.buttonSelectOutputDir_Click);
            // 
            // labelOutputFileDir
            // 
            this.labelOutputFileDir.AutoSize = true;
            this.labelOutputFileDir.Location = new System.Drawing.Point(156, 148);
            this.labelOutputFileDir.Name = "labelOutputFileDir";
            this.labelOutputFileDir.Size = new System.Drawing.Size(39, 13);
            this.labelOutputFileDir.TabIndex = 8;
            this.labelOutputFileDir.Text = "Output";
            // 
            // textBoxOutputFilesDir
            // 
            this.textBoxOutputFilesDir.Location = new System.Drawing.Point(255, 145);
            this.textBoxOutputFilesDir.Name = "textBoxOutputFilesDir";
            this.textBoxOutputFilesDir.Size = new System.Drawing.Size(265, 20);
            this.textBoxOutputFilesDir.TabIndex = 7;
            // 
            // buttonOpenExcelFile
            // 
            this.buttonOpenExcelFile.Location = new System.Drawing.Point(526, 81);
            this.buttonOpenExcelFile.Name = "buttonOpenExcelFile";
            this.buttonOpenExcelFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenExcelFile.TabIndex = 6;
            this.buttonOpenExcelFile.Text = "Open";
            this.buttonOpenExcelFile.UseVisualStyleBackColor = true;
            this.buttonOpenExcelFile.Click += new System.EventHandler(this.buttonOpenExcelFile_Click);
            // 
            // labelExcelFileDir
            // 
            this.labelExcelFileDir.AutoSize = true;
            this.labelExcelFileDir.Location = new System.Drawing.Point(156, 87);
            this.labelExcelFileDir.Name = "labelExcelFileDir";
            this.labelExcelFileDir.Size = new System.Drawing.Size(52, 13);
            this.labelExcelFileDir.TabIndex = 5;
            this.labelExcelFileDir.Text = "Excel File";
            // 
            // txtExcelFileDir
            // 
            this.txtExcelFileDir.Location = new System.Drawing.Point(255, 84);
            this.txtExcelFileDir.Name = "txtExcelFileDir";
            this.txtExcelFileDir.Size = new System.Drawing.Size(265, 20);
            this.txtExcelFileDir.TabIndex = 4;
            // 
            // tabPageKeywordSuggest
            // 
            this.tabPageKeywordSuggest.Controls.Add(this.buttonReIndexKeyword);
            this.tabPageKeywordSuggest.Location = new System.Drawing.Point(4, 22);
            this.tabPageKeywordSuggest.Name = "tabPageKeywordSuggest";
            this.tabPageKeywordSuggest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeywordSuggest.Size = new System.Drawing.Size(860, 578);
            this.tabPageKeywordSuggest.TabIndex = 3;
            this.tabPageKeywordSuggest.Text = "Keyword Suggest";
            this.tabPageKeywordSuggest.UseVisualStyleBackColor = true;
            // 
            // buttonReIndexKeyword
            // 
            this.buttonReIndexKeyword.Location = new System.Drawing.Point(311, 166);
            this.buttonReIndexKeyword.Name = "buttonReIndexKeyword";
            this.buttonReIndexKeyword.Size = new System.Drawing.Size(87, 46);
            this.buttonReIndexKeyword.TabIndex = 11;
            this.buttonReIndexKeyword.Text = "ReIndex Keywords";
            this.buttonReIndexKeyword.UseVisualStyleBackColor = true;
            this.buttonReIndexKeyword.Click += new System.EventHandler(this.buttonReIndexKeyword_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textEditProductID);
            this.tabPage3.Controls.Add(this.simpleButtonUpdateProduct);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(860, 578);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Test";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textEditProductID
            // 
            this.textEditProductID.Location = new System.Drawing.Point(151, 43);
            this.textEditProductID.Name = "textEditProductID";
            this.textEditProductID.Size = new System.Drawing.Size(149, 20);
            this.textEditProductID.TabIndex = 1;
            // 
            // simpleButtonUpdateProduct
            // 
            this.simpleButtonUpdateProduct.Location = new System.Drawing.Point(19, 40);
            this.simpleButtonUpdateProduct.Name = "simpleButtonUpdateProduct";
            this.simpleButtonUpdateProduct.Size = new System.Drawing.Size(102, 23);
            this.simpleButtonUpdateProduct.TabIndex = 0;
            this.simpleButtonUpdateProduct.Text = "Update Product";
            this.simpleButtonUpdateProduct.Click += new System.EventHandler(this.simpleButtonUpdateProduct_Click);
            // 
            // contextMenuStripListCompany
            // 
            this.contextMenuStripListCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.scheduleToolStripMenuItem});
            this.contextMenuStripListCompany.Name = "contextMenuStrip1";
            this.contextMenuStripListCompany.Size = new System.Drawing.Size(123, 48);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // contextMenuStripRunningCompany
            // 
            this.contextMenuStripRunningCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStripRunningCompany.Name = "contextMenuStrip2";
            this.contextMenuStripRunningCompany.Size = new System.Drawing.Size(99, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.deleteToolStripMenuItem.Text = "Stop";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // openExcelFileDialog
            // 
            this.openExcelFileDialog.FileName = "keyword*.*";
            this.openExcelFileDialog.Filter = "Excel files|*.xls";
            // 
            // companyDataSet
            // 
            this.companyDataSet.DataSetName = "CompanyDataSet";
            this.companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmToolUpdateSolr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(868, 604);
            this.Controls.Add(this.tabMain);
            this.Name = "FrmToolUpdateSolr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmToolUpdateSolr_FormClosing);
            this.Load += new System.EventHandler(this.FrmToolUpdateSolr_Load);
            this.panelMainControl.ResumeLayout(false);
            this.panelMainControl.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunningCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCompany)).EndInit();
            this.tabPageCreateSynonymsFiles.ResumeLayout(false);
            this.tabPageCreateSynonymsFiles.PerformLayout();
            this.tabPageKeywordSuggest.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditProductID.Properties)).EndInit();
            this.contextMenuStripListCompany.ResumeLayout(false);
            this.contextMenuStripRunningCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Panel panelMainControl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewListCompany;
        //private ProductDataset dBTool2;
        private System.Windows.Forms.BindingSource companyBindingSource;
        //private DBTool2TableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource2;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        private CompanyDataSet companyDataSet;
        private System.Windows.Forms.BindingSource companyBindingSource3;
        //private CompanyDataSetTableAdapters.CompanyTableAdapter companyTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.BindingSource companyBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Button buttonCommitSolr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeDelay;
        private System.Windows.Forms.Button buttonUpdateProducts;
        private System.Windows.Forms.Button buttonUpdateRootProduct;
        private System.Windows.Forms.RichTextBox memoCode;
        private System.Windows.Forms.ComboBox comboBoxSolrNodes;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListCompany;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTxtView;
        private System.Windows.Forms.ComboBox txtCompanyName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdelay;
        private System.Windows.Forms.CheckBox cbDelay;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewRunningCompany;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRunningCompany;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageCreateSynonymsFiles;
        private System.Windows.Forms.Button buttonOpenExcelFile;
        private System.Windows.Forms.Label labelExcelFileDir;
        private System.Windows.Forms.TextBox txtExcelFileDir;
        private System.Windows.Forms.OpenFileDialog openExcelFileDialog;
        private System.Windows.Forms.Button buttonSelectOutputDir;
        private System.Windows.Forms.Label labelOutputFileDir;
        private System.Windows.Forms.TextBox textBoxOutputFilesDir;
        private System.Windows.Forms.FolderBrowserDialog synonymsFilesOutputFolderBrowserDialog;
        private System.Windows.Forms.Button buttonCreateSynonymFiles;
        private System.Windows.Forms.TabPage tabPageKeywordSuggest;
        private System.Windows.Forms.Button buttonReIndexKeyword;
        private System.Windows.Forms.Button buttonOptimizeSolr;
        private System.Windows.Forms.Button buttonScheduleUpdate;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraEditors.TextEdit textEditProductID;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdateProduct;

        public System.EventHandler btUpdateViewCount_Click { get; set; }
    }
}
