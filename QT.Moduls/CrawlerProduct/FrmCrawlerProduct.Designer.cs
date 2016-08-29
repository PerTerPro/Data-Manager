using QT.Moduls.Company;
namespace QT.Moduls.CrawlerProduct
{
    partial class FrmCrawlerProduct
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
            this.timeDelayLabel = new System.Windows.Forms.Label();
            this.hoursReCrawlerLabel = new System.Windows.Forms.Label();
            this.itemReCrawlerLabel = new System.Windows.Forms.Label();
            this.dayReFullCrawlerLabel = new System.Windows.Forms.Label();
            this.txtUrlCurrent = new System.Windows.Forms.TextBox();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVisited = new System.Windows.Forms.Label();
            this.lblIgnored = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.timeDelayTextBox = new System.Windows.Forms.TextBox();
            this.dB = new QT.Moduls.DB();
            this.hoursReCrawlerTextBox = new System.Windows.Forms.TextBox();
            this.itemReCrawlerTextBox = new System.Windows.Forms.TextBox();
            this.dayReFullCrawlerTextBox = new System.Windows.Forms.TextBox();
            this.useClearHtmlCheckBox = new System.Windows.Forms.CheckBox();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.laStatus = new System.Windows.Forms.Label();
            this.laStickNormal = new System.Windows.Forms.Label();
            this.laStickFull = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new QT.Moduls.DBTableAdapters.TableAdapterManager();
            this.chkAutoDelete = new System.Windows.Forms.CheckBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label9 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtTotalProduct = new System.Windows.Forms.TextBox();
            this.ckCheckDumplicate = new System.Windows.Forms.CheckBox();
            this.ckChangeAll = new System.Windows.Forms.CheckBox();
            this.ckPause = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.ctrLogMananger1 = new QT.Moduls.Company.ctrLogMananger();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeDelayLabel
            // 
            this.timeDelayLabel.AutoSize = true;
            this.timeDelayLabel.Location = new System.Drawing.Point(-2, 30);
            this.timeDelayLabel.Name = "timeDelayLabel";
            this.timeDelayLabel.Size = new System.Drawing.Size(28, 13);
            this.timeDelayLabel.TabIndex = 54;
            this.timeDelayLabel.Text = "T Dl:";
            // 
            // hoursReCrawlerLabel
            // 
            this.hoursReCrawlerLabel.AutoSize = true;
            this.hoursReCrawlerLabel.Location = new System.Drawing.Point(-3, 72);
            this.hoursReCrawlerLabel.Name = "hoursReCrawlerLabel";
            this.hoursReCrawlerLabel.Size = new System.Drawing.Size(33, 13);
            this.hoursReCrawlerLabel.TabIndex = 55;
            this.hoursReCrawlerLabel.Text = "MRC:";
            // 
            // itemReCrawlerLabel
            // 
            this.itemReCrawlerLabel.AutoSize = true;
            this.itemReCrawlerLabel.Location = new System.Drawing.Point(-2, 52);
            this.itemReCrawlerLabel.Name = "itemReCrawlerLabel";
            this.itemReCrawlerLabel.Size = new System.Drawing.Size(24, 13);
            this.itemReCrawlerLabel.TabIndex = 56;
            this.itemReCrawlerLabel.Text = "RC:";
            // 
            // dayReFullCrawlerLabel
            // 
            this.dayReFullCrawlerLabel.AutoSize = true;
            this.dayReFullCrawlerLabel.Location = new System.Drawing.Point(81, 71);
            this.dayReFullCrawlerLabel.Name = "dayReFullCrawlerLabel";
            this.dayReFullCrawlerLabel.Size = new System.Drawing.Size(48, 13);
            this.dayReFullCrawlerLabel.TabIndex = 57;
            this.dayReFullCrawlerLabel.Text = "DRFullC:";
            // 
            // txtUrlCurrent
            // 
            this.txtUrlCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrlCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.txtUrlCurrent.Location = new System.Drawing.Point(2, 2);
            this.txtUrlCurrent.Name = "txtUrlCurrent";
            this.txtUrlCurrent.Size = new System.Drawing.Size(595, 17);
            this.txtUrlCurrent.TabIndex = 53;
            // 
            // lblQueue
            // 
            this.lblQueue.BackColor = System.Drawing.Color.PeachPuff;
            this.lblQueue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.999999F);
            this.lblQueue.Location = new System.Drawing.Point(16, 4);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(57, 19);
            this.lblQueue.TabIndex = 48;
            this.lblQueue.Text = "0";
            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(174, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 22);
            this.lblTime.TabIndex = 50;
            this.lblTime.Text = "0";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "P";
            // 
            // lblVisited
            // 
            this.lblVisited.BackColor = System.Drawing.Color.PeachPuff;
            this.lblVisited.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVisited.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisited.Location = new System.Drawing.Point(107, 1);
            this.lblVisited.Name = "lblVisited";
            this.lblVisited.Size = new System.Drawing.Size(61, 19);
            this.lblVisited.TabIndex = 47;
            this.lblVisited.Text = "0";
            this.lblVisited.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIgnored
            // 
            this.lblIgnored.BackColor = System.Drawing.Color.PeachPuff;
            this.lblIgnored.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIgnored.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgnored.Location = new System.Drawing.Point(155, 4);
            this.lblIgnored.Name = "lblIgnored";
            this.lblIgnored.Size = new System.Drawing.Size(42, 19);
            this.lblIgnored.TabIndex = 52;
            this.lblIgnored.Text = "0";
            this.lblIgnored.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "I";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.PeachPuff;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(84, 4);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(53, 19);
            this.lblProduct.TabIndex = 49;
            this.lblProduct.Text = "0";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeDelayTextBox
            // 
            this.timeDelayTextBox.Location = new System.Drawing.Point(30, 28);
            this.timeDelayTextBox.Name = "timeDelayTextBox";
            this.timeDelayTextBox.Size = new System.Drawing.Size(43, 18);
            this.timeDelayTextBox.TabIndex = 1;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.EnforceConstraints = false;
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoursReCrawlerTextBox
            // 
            this.hoursReCrawlerTextBox.Location = new System.Drawing.Point(30, 69);
            this.hoursReCrawlerTextBox.Name = "hoursReCrawlerTextBox";
            this.hoursReCrawlerTextBox.Size = new System.Drawing.Size(43, 18);
            this.hoursReCrawlerTextBox.TabIndex = 2;
            // 
            // itemReCrawlerTextBox
            // 
            this.itemReCrawlerTextBox.Location = new System.Drawing.Point(30, 49);
            this.itemReCrawlerTextBox.Name = "itemReCrawlerTextBox";
            this.itemReCrawlerTextBox.Size = new System.Drawing.Size(42, 18);
            this.itemReCrawlerTextBox.TabIndex = 0;
            // 
            // dayReFullCrawlerTextBox
            // 
            this.dayReFullCrawlerTextBox.Location = new System.Drawing.Point(128, 68);
            this.dayReFullCrawlerTextBox.Name = "dayReFullCrawlerTextBox";
            this.dayReFullCrawlerTextBox.Size = new System.Drawing.Size(34, 18);
            this.dayReFullCrawlerTextBox.TabIndex = 3;
            // 
            // useClearHtmlCheckBox
            // 
            this.useClearHtmlCheckBox.Location = new System.Drawing.Point(199, 42);
            this.useClearHtmlCheckBox.Name = "useClearHtmlCheckBox";
            this.useClearHtmlCheckBox.Size = new System.Drawing.Size(71, 23);
            this.useClearHtmlCheckBox.TabIndex = 4;
            this.useClearHtmlCheckBox.Text = "ClearHTML";
            this.useClearHtmlCheckBox.UseVisualStyleBackColor = true;
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(200, 22);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(67, 17);
            this.chkLog.TabIndex = 59;
            this.chkLog.Text = "ViewLog";
            this.chkLog.UseVisualStyleBackColor = true;
            this.chkLog.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
            // 
            // laStatus
            // 
            this.laStatus.AutoSize = true;
            this.laStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laStatus.ForeColor = System.Drawing.Color.Maroon;
            this.laStatus.Location = new System.Drawing.Point(2, 88);
            this.laStatus.Name = "laStatus";
            this.laStatus.Size = new System.Drawing.Size(41, 17);
            this.laStatus.TabIndex = 60;
            this.laStatus.Text = "Stop";
            // 
            // laStickNormal
            // 
            this.laStickNormal.BackColor = System.Drawing.Color.PeachPuff;
            this.laStickNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laStickNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laStickNormal.Location = new System.Drawing.Point(92, 26);
            this.laStickNormal.Name = "laStickNormal";
            this.laStickNormal.Size = new System.Drawing.Size(45, 19);
            this.laStickNormal.TabIndex = 52;
            this.laStickNormal.Text = "0";
            this.laStickNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laStickFull
            // 
            this.laStickFull.BackColor = System.Drawing.Color.PeachPuff;
            this.laStickFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laStickFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laStickFull.Location = new System.Drawing.Point(155, 26);
            this.laStickFull.Name = "laStickFull";
            this.laStickFull.Size = new System.Drawing.Size(42, 19);
            this.laStickFull.TabIndex = 52;
            this.laStickFull.Text = "0";
            this.laStickFull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "W";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "F";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_RattingTableAdapter = null;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // chkAutoDelete
            // 
            this.chkAutoDelete.AutoSize = true;
            this.chkAutoDelete.Location = new System.Drawing.Point(275, 42);
            this.chkAutoDelete.Name = "chkAutoDelete";
            this.chkAutoDelete.Size = new System.Drawing.Size(68, 17);
            this.chkAutoDelete.TabIndex = 59;
            this.chkAutoDelete.Text = "AlowXóa";
            this.chkAutoDelete.UseVisualStyleBackColor = true;
            this.chkAutoDelete.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(607, 393);
            this.xtraTabControl1.TabIndex = 62;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtResult);
            this.xtraTabPage1.Controls.Add(this.panelControl3);
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.Controls.Add(this.laStatus);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(599, 364);
            this.xtraTabPage1.Text = "Crawler";
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(0, 117);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(599, 247);
            this.txtResult.TabIndex = 65;
            this.txtResult.WordWrap = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txtUrlCurrent);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 93);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(599, 24);
            this.panelControl3.TabIndex = 64;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label9);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(599, 93);
            this.panelControl1.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "label9";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtTotalProduct);
            this.panelControl2.Controls.Add(this.ckCheckDumplicate);
            this.panelControl2.Controls.Add(this.ckChangeAll);
            this.panelControl2.Controls.Add(this.ckPause);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.lblQueue);
            this.panelControl2.Controls.Add(this.txtCompanyID);
            this.panelControl2.Controls.Add(this.itemReCrawlerTextBox);
            this.panelControl2.Controls.Add(this.itemReCrawlerLabel);
            this.panelControl2.Controls.Add(this.hoursReCrawlerLabel);
            this.panelControl2.Controls.Add(this.chkAutoDelete);
            this.panelControl2.Controls.Add(this.dayReFullCrawlerTextBox);
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Controls.Add(this.hoursReCrawlerTextBox);
            this.panelControl2.Controls.Add(this.chkLog);
            this.panelControl2.Controls.Add(this.dayReFullCrawlerLabel);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.timeDelayLabel);
            this.panelControl2.Controls.Add(this.useClearHtmlCheckBox);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Controls.Add(this.timeDelayTextBox);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.lblProduct);
            this.panelControl2.Controls.Add(this.laStickFull);
            this.panelControl2.Controls.Add(this.lblIgnored);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.laStickNormal);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(362, 89);
            this.panelControl2.TabIndex = 0;
            // 
            // txtTotalProduct
            // 
            this.txtTotalProduct.Location = new System.Drawing.Point(200, 3);
            this.txtTotalProduct.Name = "txtTotalProduct";
            this.txtTotalProduct.Size = new System.Drawing.Size(67, 18);
            this.txtTotalProduct.TabIndex = 3;
            // 
            // ckCheckDumplicate
            // 
            this.ckCheckDumplicate.AutoSize = true;
            this.ckCheckDumplicate.Location = new System.Drawing.Point(275, 63);
            this.ckCheckDumplicate.Name = "ckCheckDumplicate";
            this.ckCheckDumplicate.Size = new System.Drawing.Size(83, 17);
            this.ckCheckDumplicate.TabIndex = 60;
            this.ckCheckDumplicate.Text = "CheckDump";
            this.ckCheckDumplicate.UseVisualStyleBackColor = true;
            this.ckCheckDumplicate.CheckedChanged += new System.EventHandler(this.ckCheckDumplicate_CheckedChanged);
            // 
            // ckChangeAll
            // 
            this.ckChangeAll.AutoSize = true;
            this.ckChangeAll.Location = new System.Drawing.Point(275, 3);
            this.ckChangeAll.Name = "ckChangeAll";
            this.ckChangeAll.Size = new System.Drawing.Size(74, 17);
            this.ckChangeAll.TabIndex = 64;
            this.ckChangeAll.Text = "ChangeAll";
            this.ckChangeAll.UseVisualStyleBackColor = true;
            this.ckChangeAll.CheckedChanged += new System.EventHandler(this.ckChangeAll_CheckedChanged);
            // 
            // ckPause
            // 
            this.ckPause.AutoSize = true;
            this.ckPause.Location = new System.Drawing.Point(275, 22);
            this.ckPause.Name = "ckPause";
            this.ckPause.Size = new System.Drawing.Size(56, 17);
            this.ckPause.TabIndex = 63;
            this.ckPause.Text = "Pause";
            this.ckPause.UseVisualStyleBackColor = true;
            this.ckPause.CheckedChanged += new System.EventHandler(this.ckPause_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "BR";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtCompanyID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCompanyID.Location = new System.Drawing.Point(77, 49);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(85, 18);
            this.txtCompanyID.TabIndex = 62;
            this.txtCompanyID.Text = "1111111111";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.ctrLogMananger1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(599, 364);
            this.xtraTabPage2.Text = "Log";
            // 
            // ctrLogMananger1
            // 
            this.ctrLogMananger1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrLogMananger1.Location = new System.Drawing.Point(0, 0);
            this.ctrLogMananger1.Name = "ctrLogMananger1";
            this.ctrLogMananger1.Size = new System.Drawing.Size(599, 364);
            this.ctrLogMananger1.TabIndex = 61;
            // 
            // FrmCrawlerProduct
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ClientSize = new System.Drawing.Size(607, 393);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblVisited);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xtraTabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.Name = "FrmCrawlerProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCrawlerProduct_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCrawlerProductRedis_FormClosed);
            this.Load += new System.EventHandler(this.frmCrawlerProduct_Load);
            this.Shown += new System.EventHandler(this.frmCrawlerProduct_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrlCurrent;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVisited;
        private System.Windows.Forms.Label lblIgnored;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProduct;
        private DB dB;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox timeDelayTextBox;
        private System.Windows.Forms.TextBox hoursReCrawlerTextBox;
        private System.Windows.Forms.TextBox itemReCrawlerTextBox;
        private System.Windows.Forms.TextBox dayReFullCrawlerTextBox;
        private System.Windows.Forms.CheckBox useClearHtmlCheckBox;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.Label laStatus;
        private System.Windows.Forms.Label laStickNormal;
        private System.Windows.Forms.Label laStickFull;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAutoDelete;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Label timeDelayLabel;
        private System.Windows.Forms.Label hoursReCrawlerLabel;
        private System.Windows.Forms.Label itemReCrawlerLabel;
        private System.Windows.Forms.Label dayReFullCrawlerLabel;
        private ctrLogMananger ctrLogMananger1;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.TextBox txtResult;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckPause;
        private System.Windows.Forms.CheckBox ckChangeAll;
        private System.Windows.Forms.CheckBox ckCheckDumplicate;
        private System.Windows.Forms.TextBox txtTotalProduct;
        private System.Windows.Forms.Label label9;
    }
}