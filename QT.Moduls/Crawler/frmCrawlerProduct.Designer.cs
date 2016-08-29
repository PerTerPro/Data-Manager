//namespace QT.Moduls.Crawler
//{
//    partial class frmCrawlerProduct
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            System.Windows.Forms.Label timeDelayLabel;
//            System.Windows.Forms.Label hoursReCrawlerLabel;
//            System.Windows.Forms.Label itemReCrawlerLabel;
//            System.Windows.Forms.Label dayReFullCrawlerLabel;
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrawlerProduct));
//            this.txtUrlCurrent = new System.Windows.Forms.TextBox();
//            this.lblQueue = new System.Windows.Forms.Label();
//            this.lblTime = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label3 = new System.Windows.Forms.Label();
//            this.label4 = new System.Windows.Forms.Label();
//            this.lblVisited = new System.Windows.Forms.Label();
//            this.lblIgnored = new System.Windows.Forms.Label();
//            this.label8 = new System.Windows.Forms.Label();
//            this.lblProduct = new System.Windows.Forms.Label();
//            this.txtResult = new System.Windows.Forms.TextBox();
//            this.timeDelayTextBox = new System.Windows.Forms.TextBox();
//            this.configurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.dB = new QT.Moduls.DB();
//            this.hoursReCrawlerTextBox = new System.Windows.Forms.TextBox();
//            this.itemReCrawlerTextBox = new System.Windows.Forms.TextBox();
//            this.dayReFullCrawlerTextBox = new System.Windows.Forms.TextBox();
//            this.useClearHtmlCheckBox = new System.Windows.Forms.CheckBox();
//            this.timerRecrawler = new System.Windows.Forms.Timer(this.components);
//            this.timerFullCrawler = new System.Windows.Forms.Timer(this.components);
//            this.chkLog = new System.Windows.Forms.CheckBox();
//            this.laStatus = new System.Windows.Forms.Label();
//            this.laStickNormal = new System.Windows.Forms.Label();
//            this.laStickFull = new System.Windows.Forms.Label();
//            this.label6 = new System.Windows.Forms.Label();
//            this.label7 = new System.Windows.Forms.Label();
//            this.timerQueue = new System.Windows.Forms.Timer(this.components);
//            this.configurationTableAdapter = new QT.Moduls.DBTableAdapters.ConfigurationTableAdapter();
//            this.tableAdapterManager = new QT.Moduls.DBTableAdapters.TableAdapterManager();
//            this.timerReCrawlerHistory = new System.Windows.Forms.Timer(this.components);
//            this.chkAutoDelete = new System.Windows.Forms.CheckBox();
//            this.ctrLogMananger1 = new QT.Moduls.Company.ctrLogMananger();
//            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
//            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
//            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
//            timeDelayLabel = new System.Windows.Forms.Label();
//            hoursReCrawlerLabel = new System.Windows.Forms.Label();
//            itemReCrawlerLabel = new System.Windows.Forms.Label();
//            dayReFullCrawlerLabel = new System.Windows.Forms.Label();
//            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
//            this.xtraTabControl1.SuspendLayout();
//            this.xtraTabPage1.SuspendLayout();
//            this.xtraTabPage2.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // timeDelayLabel
//            // 
//            timeDelayLabel.AutoSize = true;
//            timeDelayLabel.Location = new System.Drawing.Point(3, 27);
//            timeDelayLabel.Name = "timeDelayLabel";
//            timeDelayLabel.Size = new System.Drawing.Size(63, 13);
//            timeDelayLabel.TabIndex = 54;
//            timeDelayLabel.Text = "Time Delay:";
//            // 
//            // hoursReCrawlerLabel
//            // 
//            hoursReCrawlerLabel.AutoSize = true;
//            hoursReCrawlerLabel.Location = new System.Drawing.Point(3, 71);
//            hoursReCrawlerLabel.Name = "hoursReCrawlerLabel";
//            hoursReCrawlerLabel.Size = new System.Drawing.Size(97, 13);
//            hoursReCrawlerLabel.TabIndex = 55;
//            hoursReCrawlerLabel.Text = "Minute Re Crawler:";
//            // 
//            // itemReCrawlerLabel
//            // 
//            itemReCrawlerLabel.AutoSize = true;
//            itemReCrawlerLabel.Location = new System.Drawing.Point(15, 49);
//            itemReCrawlerLabel.Name = "itemReCrawlerLabel";
//            itemReCrawlerLabel.Size = new System.Drawing.Size(85, 13);
//            itemReCrawlerLabel.TabIndex = 56;
//            itemReCrawlerLabel.Text = "Item Re Crawler:";
//            // 
//            // dayReFullCrawlerLabel
//            // 
//            dayReFullCrawlerLabel.AutoSize = true;
//            dayReFullCrawlerLabel.Location = new System.Drawing.Point(163, 71);
//            dayReFullCrawlerLabel.Name = "dayReFullCrawlerLabel";
//            dayReFullCrawlerLabel.Size = new System.Drawing.Size(103, 13);
//            dayReFullCrawlerLabel.TabIndex = 57;
//            dayReFullCrawlerLabel.Text = "Day Re Full Crawler:";
//            // 
//            // txtUrlCurrent
//            // 
//            this.txtUrlCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.txtUrlCurrent.Location = new System.Drawing.Point(3, 111);
//            this.txtUrlCurrent.Name = "txtUrlCurrent";
//            this.txtUrlCurrent.Size = new System.Drawing.Size(730, 20);
//            this.txtUrlCurrent.TabIndex = 53;
//            // 
//            // lblQueue
//            // 
//            this.lblQueue.BackColor = System.Drawing.Color.PeachPuff;
//            this.lblQueue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblQueue.Location = new System.Drawing.Point(16, 1);
//            this.lblQueue.Name = "lblQueue";
//            this.lblQueue.Size = new System.Drawing.Size(64, 19);
//            this.lblQueue.TabIndex = 48;
//            this.lblQueue.Text = "0";
//            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblTime
//            // 
//            this.lblTime.BackColor = System.Drawing.Color.PeachPuff;
//            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblTime.Location = new System.Drawing.Point(174, 0);
//            this.lblTime.Name = "lblTime";
//            this.lblTime.Size = new System.Drawing.Size(62, 22);
//            this.lblTime.TabIndex = 50;
//            this.lblTime.Text = "0";
//            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(93, 7);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(14, 13);
//            this.label2.TabIndex = 44;
//            this.label2.Text = "V";
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Location = new System.Drawing.Point(3, 7);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(15, 13);
//            this.label3.TabIndex = 45;
//            this.label3.Text = "Q";
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Location = new System.Drawing.Point(90, 7);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(14, 13);
//            this.label4.TabIndex = 46;
//            this.label4.Text = "P";
//            // 
//            // lblVisited
//            // 
//            this.lblVisited.BackColor = System.Drawing.Color.PeachPuff;
//            this.lblVisited.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.lblVisited.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblVisited.Location = new System.Drawing.Point(107, 1);
//            this.lblVisited.Name = "lblVisited";
//            this.lblVisited.Size = new System.Drawing.Size(61, 19);
//            this.lblVisited.TabIndex = 47;
//            this.lblVisited.Text = "0";
//            this.lblVisited.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // lblIgnored
//            // 
//            this.lblIgnored.BackColor = System.Drawing.Color.PeachPuff;
//            this.lblIgnored.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.lblIgnored.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblIgnored.Location = new System.Drawing.Point(178, 1);
//            this.lblIgnored.Name = "lblIgnored";
//            this.lblIgnored.Size = new System.Drawing.Size(33, 19);
//            this.lblIgnored.TabIndex = 52;
//            this.lblIgnored.Text = "0";
//            this.lblIgnored.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // label8
//            // 
//            this.label8.AutoSize = true;
//            this.label8.Location = new System.Drawing.Point(168, 7);
//            this.label8.Name = "label8";
//            this.label8.Size = new System.Drawing.Size(10, 13);
//            this.label8.TabIndex = 51;
//            this.label8.Text = "I";
//            // 
//            // lblProduct
//            // 
//            this.lblProduct.BackColor = System.Drawing.Color.PeachPuff;
//            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblProduct.ForeColor = System.Drawing.Color.Black;
//            this.lblProduct.Location = new System.Drawing.Point(104, 1);
//            this.lblProduct.Name = "lblProduct";
//            this.lblProduct.Size = new System.Drawing.Size(62, 19);
//            this.lblProduct.TabIndex = 49;
//            this.lblProduct.Text = "0";
//            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // txtResult
//            // 
//            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtResult.Location = new System.Drawing.Point(3, 137);
//            this.txtResult.Multiline = true;
//            this.txtResult.Name = "txtResult";
//            this.txtResult.ReadOnly = true;
//            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.txtResult.Size = new System.Drawing.Size(730, 137);
//            this.txtResult.TabIndex = 5;
//            this.txtResult.WordWrap = false;
//            // 
//            // timeDelayTextBox
//            // 
//            this.timeDelayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "TimeDelay", true));
//            this.timeDelayTextBox.Location = new System.Drawing.Point(72, 23);
//            this.timeDelayTextBox.Name = "timeDelayTextBox";
//            this.timeDelayTextBox.Size = new System.Drawing.Size(50, 20);
//            this.timeDelayTextBox.TabIndex = 1;
//            this.timeDelayTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timeDelayTextBox_KeyDown);
//            // 
//            // configurationBindingSource
//            // 
//            this.configurationBindingSource.DataMember = "Configuration";
//            this.configurationBindingSource.DataSource = this.dB;
//            // 
//            // dB
//            // 
//            this.dB.DataSetName = "DB";
//            this.dB.EnforceConstraints = false;
//            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
//            // 
//            // hoursReCrawlerTextBox
//            // 
//            this.hoursReCrawlerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "HoursReCrawler", true));
//            this.hoursReCrawlerTextBox.Location = new System.Drawing.Point(106, 68);
//            this.hoursReCrawlerTextBox.Name = "hoursReCrawlerTextBox";
//            this.hoursReCrawlerTextBox.Size = new System.Drawing.Size(50, 20);
//            this.hoursReCrawlerTextBox.TabIndex = 2;
//            this.hoursReCrawlerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hoursReCrawlerTextBox_KeyDown);
//            // 
//            // itemReCrawlerTextBox
//            // 
//            this.itemReCrawlerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "ItemReCrawler", true));
//            this.itemReCrawlerTextBox.Location = new System.Drawing.Point(106, 46);
//            this.itemReCrawlerTextBox.Name = "itemReCrawlerTextBox";
//            this.itemReCrawlerTextBox.Size = new System.Drawing.Size(50, 20);
//            this.itemReCrawlerTextBox.TabIndex = 0;
//            this.itemReCrawlerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemReCrawlerTextBox_KeyDown);
//            // 
//            // dayReFullCrawlerTextBox
//            // 
//            this.dayReFullCrawlerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "DayReFullCrawler", true));
//            this.dayReFullCrawlerTextBox.Location = new System.Drawing.Point(272, 68);
//            this.dayReFullCrawlerTextBox.Name = "dayReFullCrawlerTextBox";
//            this.dayReFullCrawlerTextBox.Size = new System.Drawing.Size(50, 20);
//            this.dayReFullCrawlerTextBox.TabIndex = 3;
//            this.dayReFullCrawlerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dayReFullCrawlerTextBox_KeyDown);
//            // 
//            // useClearHtmlCheckBox
//            // 
//            this.useClearHtmlCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.configurationBindingSource, "UseClearHtml", true));
//            this.useClearHtmlCheckBox.Location = new System.Drawing.Point(236, 45);
//            this.useClearHtmlCheckBox.Name = "useClearHtmlCheckBox";
//            this.useClearHtmlCheckBox.Size = new System.Drawing.Size(86, 17);
//            this.useClearHtmlCheckBox.TabIndex = 4;
//            this.useClearHtmlCheckBox.Text = "ClearHTML";
//            this.useClearHtmlCheckBox.UseVisualStyleBackColor = true;
//            // 
//            // timerRecrawler
//            // 
//            this.timerRecrawler.Interval = 1000;
//            this.timerRecrawler.Tick += new System.EventHandler(this.timerRecrawler_Tick);
//            // 
//            // timerFullCrawler
//            // 
//            this.timerFullCrawler.Interval = 86400000;
//            this.timerFullCrawler.Tick += new System.EventHandler(this.timerFullCrawler_Tick);
//            // 
//            // chkLog
//            // 
//            this.chkLog.AutoSize = true;
//            this.chkLog.Location = new System.Drawing.Point(163, 45);
//            this.chkLog.Name = "chkLog";
//            this.chkLog.Size = new System.Drawing.Size(67, 17);
//            this.chkLog.TabIndex = 59;
//            this.chkLog.Text = "ViewLog";
//            this.chkLog.UseVisualStyleBackColor = true;
//            this.chkLog.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
//            // 
//            // laStatus
//            // 
//            this.laStatus.AutoSize = true;
//            this.laStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.laStatus.ForeColor = System.Drawing.Color.Maroon;
//            this.laStatus.Location = new System.Drawing.Point(6, 91);
//            this.laStatus.Name = "laStatus";
//            this.laStatus.Size = new System.Drawing.Size(41, 17);
//            this.laStatus.TabIndex = 60;
//            this.laStatus.Text = "Stop";
//            // 
//            // laStickNormal
//            // 
//            this.laStickNormal.BackColor = System.Drawing.Color.PeachPuff;
//            this.laStickNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.laStickNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.laStickNormal.Location = new System.Drawing.Point(140, 24);
//            this.laStickNormal.Name = "laStickNormal";
//            this.laStickNormal.Size = new System.Drawing.Size(37, 19);
//            this.laStickNormal.TabIndex = 52;
//            this.laStickNormal.Text = "0";
//            this.laStickNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // laStickFull
//            // 
//            this.laStickFull.BackColor = System.Drawing.Color.PeachPuff;
//            this.laStickFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.laStickFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.laStickFull.Location = new System.Drawing.Point(194, 24);
//            this.laStickFull.Name = "laStickFull";
//            this.laStickFull.Size = new System.Drawing.Size(37, 19);
//            this.laStickFull.TabIndex = 52;
//            this.laStickFull.Text = "0";
//            this.laStickFull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // label6
//            // 
//            this.label6.AutoSize = true;
//            this.label6.Location = new System.Drawing.Point(124, 27);
//            this.label6.Name = "label6";
//            this.label6.Size = new System.Drawing.Size(15, 13);
//            this.label6.TabIndex = 51;
//            this.label6.Text = "N";
//            // 
//            // label7
//            // 
//            this.label7.AutoSize = true;
//            this.label7.Location = new System.Drawing.Point(178, 27);
//            this.label7.Name = "label7";
//            this.label7.Size = new System.Drawing.Size(13, 13);
//            this.label7.TabIndex = 51;
//            this.label7.Text = "F";
//            // 
//            // timerQueue
//            // 
//            this.timerQueue.Interval = 1000;
//            this.timerQueue.Tick += new System.EventHandler(this.timerQueue_Tick);
//            // 
//            // configurationTableAdapter
//            // 
//            this.configurationTableAdapter.ClearBeforeFill = true;
//            // 
//            // tableAdapterManager
//            // 
//            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
//            this.tableAdapterManager.ClassificationTableAdapter = null;
//            this.tableAdapterManager.Company_StatusTableAdapter = null;
//            this.tableAdapterManager.CompanyTableAdapter = null;
//            this.tableAdapterManager.ConfigurationTableAdapter = null;
//            this.tableAdapterManager.Connection = null;
//            this.tableAdapterManager.ListClassificationTableAdapter = null;
//            this.tableAdapterManager.MapClassificationTableAdapter = null;
//            this.tableAdapterManager.ProductID_PropertyTableAdapter = null;
//            this.tableAdapterManager.ProductIDTableAdapter = null;
//            this.tableAdapterManager.ProductTableAdapter = null;
//            this.tableAdapterManager.PropertyGroupTableAdapter = null;
//            this.tableAdapterManager.PropertyTableAdapter = null;
//            this.tableAdapterManager.PropertyValueTableAdapter = null;
//            this.tableAdapterManager.UpdateOrder = QT.Moduls.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
//            // 
//            // timerReCrawlerHistory
//            // 
//            this.timerReCrawlerHistory.Interval = 1000;
//            this.timerReCrawlerHistory.Tick += new System.EventHandler(this.timerReCrawlerHistory_Tick);
//            // 
//            // chkAutoDelete
//            // 
//            this.chkAutoDelete.AutoSize = true;
//            this.chkAutoDelete.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configurationBindingSource, "AutoDelete", true));
//            this.chkAutoDelete.Location = new System.Drawing.Point(219, 3);
//            this.chkAutoDelete.Name = "chkAutoDelete";
//            this.chkAutoDelete.Size = new System.Drawing.Size(68, 17);
//            this.chkAutoDelete.TabIndex = 59;
//            this.chkAutoDelete.Text = "AlowXóa";
//            this.chkAutoDelete.UseVisualStyleBackColor = true;
//            this.chkAutoDelete.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
//            // 
//            // ctrLogMananger1
//            // 
//            this.ctrLogMananger1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.ctrLogMananger1.Location = new System.Drawing.Point(0, 0);
//            this.ctrLogMananger1.Name = "ctrLogMananger1";
//            this.ctrLogMananger1.Size = new System.Drawing.Size(742, 280);
//            this.ctrLogMananger1.TabIndex = 61;
//            // 
//            // xtraTabControl1
//            // 
//            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
//            this.xtraTabControl1.Name = "xtraTabControl1";
//            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
//            this.xtraTabControl1.Size = new System.Drawing.Size(750, 309);
//            this.xtraTabControl1.TabIndex = 62;
//            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
//            this.xtraTabPage1,
//            this.xtraTabPage2});
//            // 
//            // xtraTabPage1
//            // 
//            this.xtraTabPage1.Controls.Add(this.laStatus);
//            this.xtraTabPage1.Controls.Add(this.txtResult);
//            this.xtraTabPage1.Controls.Add(this.chkAutoDelete);
//            this.xtraTabPage1.Controls.Add(this.label8);
//            this.xtraTabPage1.Controls.Add(this.chkLog);
//            this.xtraTabPage1.Controls.Add(this.label6);
//            this.xtraTabPage1.Controls.Add(this.lblQueue);
//            this.xtraTabPage1.Controls.Add(this.label7);
//            this.xtraTabPage1.Controls.Add(this.label4);
//            this.xtraTabPage1.Controls.Add(this.laStickFull);
//            this.xtraTabPage1.Controls.Add(this.label3);
//            this.xtraTabPage1.Controls.Add(this.laStickNormal);
//            this.xtraTabPage1.Controls.Add(this.lblIgnored);
//            this.xtraTabPage1.Controls.Add(this.txtUrlCurrent);
//            this.xtraTabPage1.Controls.Add(this.lblProduct);
//            this.xtraTabPage1.Controls.Add(this.timeDelayTextBox);
//            this.xtraTabPage1.Controls.Add(this.useClearHtmlCheckBox);
//            this.xtraTabPage1.Controls.Add(timeDelayLabel);
//            this.xtraTabPage1.Controls.Add(dayReFullCrawlerLabel);
//            this.xtraTabPage1.Controls.Add(this.hoursReCrawlerTextBox);
//            this.xtraTabPage1.Controls.Add(this.dayReFullCrawlerTextBox);
//            this.xtraTabPage1.Controls.Add(hoursReCrawlerLabel);
//            this.xtraTabPage1.Controls.Add(itemReCrawlerLabel);
//            this.xtraTabPage1.Controls.Add(this.itemReCrawlerTextBox);
//            this.xtraTabPage1.Name = "xtraTabPage1";
//            this.xtraTabPage1.Size = new System.Drawing.Size(742, 280);
//            this.xtraTabPage1.Text = "Crawler";
//            // 
//            // xtraTabPage2
//            // 
//            this.xtraTabPage2.Controls.Add(this.ctrLogMananger1);
//            this.xtraTabPage2.Name = "xtraTabPage2";
//            this.xtraTabPage2.Size = new System.Drawing.Size(742, 280);
//            this.xtraTabPage2.Text = "Log";
//            // 
//            // frmCrawlerProduct
//            // 
//            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.ClientSize = new System.Drawing.Size(750, 309);
//            this.Controls.Add(this.lblTime);
//            this.Controls.Add(this.lblVisited);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.xtraTabControl1);
//            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
//            this.Name = "frmCrawlerProduct";
//            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCrawlerProduct_FormClosing);
//            this.Load += new System.EventHandler(this.frmCrawlerProduct_Load);
//            this.Shown += new System.EventHandler(this.frmCrawlerProduct_Shown);
//            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
//            this.xtraTabControl1.ResumeLayout(false);
//            this.xtraTabPage1.ResumeLayout(false);
//            this.xtraTabPage1.PerformLayout();
//            this.xtraTabPage2.ResumeLayout(false);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.TextBox txtUrlCurrent;
//        private System.Windows.Forms.Label lblQueue;
//        private System.Windows.Forms.Label lblTime;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label label4;
//        private System.Windows.Forms.Label lblVisited;
//        private System.Windows.Forms.Label lblIgnored;
//        private System.Windows.Forms.Label label8;
//        private System.Windows.Forms.Label lblProduct;
//        private System.Windows.Forms.TextBox txtResult;
//        private DB dB;
//        private System.Windows.Forms.BindingSource configurationBindingSource;
//        private DBTableAdapters.ConfigurationTableAdapter configurationTableAdapter;
//        private DBTableAdapters.TableAdapterManager tableAdapterManager;
//        private System.Windows.Forms.TextBox timeDelayTextBox;
//        private System.Windows.Forms.TextBox hoursReCrawlerTextBox;
//        private System.Windows.Forms.TextBox itemReCrawlerTextBox;
//        private System.Windows.Forms.TextBox dayReFullCrawlerTextBox;
//        private System.Windows.Forms.CheckBox useClearHtmlCheckBox;
//        private System.Windows.Forms.Timer timerRecrawler;
//        private System.Windows.Forms.Timer timerFullCrawler;
//        private System.Windows.Forms.CheckBox chkLog;
//        private System.Windows.Forms.Label laStatus;
//        private System.Windows.Forms.Label laStickNormal;
//        private System.Windows.Forms.Label laStickFull;
//        private System.Windows.Forms.Label label6;
//        private System.Windows.Forms.Label label7;
//        private System.Windows.Forms.Timer timerQueue;
//        private System.Windows.Forms.Timer timerReCrawlerHistory;
//        private System.Windows.Forms.CheckBox chkAutoDelete;
//        private Company.ctrLogMananger ctrLogMananger1;
//        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
//        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
//        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
//    }
//}
