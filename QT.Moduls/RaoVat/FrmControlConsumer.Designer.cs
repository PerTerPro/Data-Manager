//namespace WSS.CrawlerSale.Manager
//{
//    partial class FrmControlConsumer
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

//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.btnShowLog = new System.Windows.Forms.Button();
//            this.label2 = new System.Windows.Forms.Label();
//            this.txtQueueLog = new System.Windows.Forms.TextBox();
//            this.button1 = new System.Windows.Forms.Button();
//            this.label1 = new System.Windows.Forms.Label();
//            this.queueNameTextBox = new System.Windows.Forms.TextBox();
//            this.button3 = new System.Windows.Forms.Button();
//            this.txtThreads = new DevExpress.XtraEditors.SpinEdit();
//            this.label12 = new System.Windows.Forms.Label();
//            this.ckTest = new System.Windows.Forms.CheckBox();
//            this.button4 = new System.Windows.Forms.Button();
//            this.btnLoadKeyWord = new System.Windows.Forms.Button();
//            this.btnRemoveSolr = new System.Windows.Forms.Button();
//            this.btnLoadStandardProduct = new System.Windows.Forms.Button();
//            this.btnStart = new System.Windows.Forms.Button();
//            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
//            this.webUserTableAdapter1 = new QT.Users.DBCustomerTableAdapters.WebUserTableAdapter();
//            this.xtraTabPage9 = new DevExpress.XtraTab.XtraTabPage();
//            this.txtProcessLink = new System.Windows.Forms.RichTextBox();
//            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
//            this.panel1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.txtThreads.Properties)).BeginInit();
//            this.xtraTabPage9.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
//            this.xtraTabControl1.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // panel1
//            // 
//            this.panel1.Controls.Add(this.btnShowLog);
//            this.panel1.Controls.Add(this.label2);
//            this.panel1.Controls.Add(this.txtQueueLog);
//            this.panel1.Controls.Add(this.button1);
//            this.panel1.Controls.Add(this.label1);
//            this.panel1.Controls.Add(this.queueNameTextBox);
//            this.panel1.Controls.Add(this.button3);
//            this.panel1.Controls.Add(this.txtThreads);
//            this.panel1.Controls.Add(this.label12);
//            this.panel1.Controls.Add(this.ckTest);
//            this.panel1.Controls.Add(this.button4);
//            this.panel1.Controls.Add(this.btnLoadKeyWord);
//            this.panel1.Controls.Add(this.btnRemoveSolr);
//            this.panel1.Controls.Add(this.btnLoadStandardProduct);
//            this.panel1.Controls.Add(this.btnStart);
//            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panel1.Location = new System.Drawing.Point(0, 0);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(1205, 69);
//            this.panel1.TabIndex = 0;
//            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
//            // 
//            // btnShowLog
//            // 
//            this.btnShowLog.Location = new System.Drawing.Point(491, 8);
//            this.btnShowLog.Name = "btnShowLog";
//            this.btnShowLog.Size = new System.Drawing.Size(70, 27);
//            this.btnShowLog.TabIndex = 71;
//            this.btnShowLog.Text = "Show&Log";
//            this.btnShowLog.UseVisualStyleBackColor = true;
//            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(136, 46);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(57, 13);
//            this.label2.TabIndex = 70;
//            this.label2.Text = "QueueLog";
//            // 
//            // txtQueueLog
//            // 
//            this.txtQueueLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txtQueueLog.ForeColor = System.Drawing.Color.Teal;
//            this.txtQueueLog.Location = new System.Drawing.Point(203, 38);
//            this.txtQueueLog.Name = "txtQueueLog";
//            this.txtQueueLog.Size = new System.Drawing.Size(282, 26);
//            this.txtQueueLog.TabIndex = 69;
//            this.txtQueueLog.Text = "crawler_sale_wait_log";
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(756, 41);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(23, 20);
//            this.button1.TabIndex = 68;
//            this.button1.Text = "Start";
//            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Visible = false;
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(136, 14);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(61, 13);
//            this.label1.TabIndex = 67;
//            this.label1.Text = "QueuName";
//            // 
//            // queueNameTextBox
//            // 
//            this.queueNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.queueNameTextBox.ForeColor = System.Drawing.Color.Teal;
//            this.queueNameTextBox.Location = new System.Drawing.Point(203, 7);
//            this.queueNameTextBox.Name = "queueNameTextBox";
//            this.queueNameTextBox.Size = new System.Drawing.Size(282, 26);
//            this.queueNameTextBox.TabIndex = 66;
//            this.queueNameTextBox.Text = "crawler_sale_wait";
//            this.queueNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.queueNameTextBox_KeyDown);
//            // 
//            // button3
//            // 
//            this.button3.Location = new System.Drawing.Point(1003, 38);
//            this.button3.Name = "button3";
//            this.button3.Size = new System.Drawing.Size(119, 23);
//            this.button3.TabIndex = 65;
//            this.button3.Text = "Stop sản phẩm gốc";
//            this.button3.UseVisualStyleBackColor = true;
//            this.button3.Visible = false;
//            this.button3.Click += new System.EventHandler(this.button3_Click);
//            // 
//            // txtThreads
//            // 
//            this.txtThreads.EditValue = new decimal(new int[] {
//            4,
//            0,
//            0,
//            0});
//            this.txtThreads.Location = new System.Drawing.Point(64, 42);
//            this.txtThreads.Name = "txtThreads";
//            this.txtThreads.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
//            this.txtThreads.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
//            this.txtThreads.Properties.Appearance.Options.UseFont = true;
//            this.txtThreads.Properties.Appearance.Options.UseForeColor = true;
//            this.txtThreads.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
//            this.txtThreads.Size = new System.Drawing.Size(58, 24);
//            this.txtThreads.TabIndex = 62;
//            // 
//            // label12
//            // 
//            this.label12.AutoSize = true;
//            this.label12.Location = new System.Drawing.Point(12, 47);
//            this.label12.Name = "label12";
//            this.label12.Size = new System.Drawing.Size(46, 13);
//            this.label12.TabIndex = 61;
//            this.label12.Text = "&Threads";
//            // 
//            // ckTest
//            // 
//            this.ckTest.AutoSize = true;
//            this.ckTest.Location = new System.Drawing.Point(820, 37);
//            this.ckTest.Name = "ckTest";
//            this.ckTest.Size = new System.Drawing.Size(124, 17);
//            this.ckTest.TabIndex = 60;
//            this.ckTest.Text = "TestCrawl (NotSave)";
//            this.ckTest.UseVisualStyleBackColor = true;
//            // 
//            // button4
//            // 
//            this.button4.Location = new System.Drawing.Point(607, 38);
//            this.button4.Name = "button4";
//            this.button4.Size = new System.Drawing.Size(143, 27);
//            this.button4.TabIndex = 39;
//            this.button4.Text = "Duyệt keyword Categories";
//            this.button4.UseVisualStyleBackColor = true;
//            this.button4.Click += new System.EventHandler(this.button4_Click_2);
//            // 
//            // btnLoadKeyWord
//            // 
//            this.btnLoadKeyWord.Location = new System.Drawing.Point(607, 8);
//            this.btnLoadKeyWord.Name = "btnLoadKeyWord";
//            this.btnLoadKeyWord.Size = new System.Drawing.Size(143, 27);
//            this.btnLoadKeyWord.TabIndex = 38;
//            this.btnLoadKeyWord.Text = "Duyệt keyword Product";
//            this.btnLoadKeyWord.UseVisualStyleBackColor = true;
//            this.btnLoadKeyWord.Click += new System.EventHandler(this.btnLoadKeyWord_Click);
//            // 
//            // btnRemoveSolr
//            // 
//            this.btnRemoveSolr.Location = new System.Drawing.Point(820, 8);
//            this.btnRemoveSolr.Name = "btnRemoveSolr";
//            this.btnRemoveSolr.Size = new System.Drawing.Size(132, 23);
//            this.btnRemoveSolr.TabIndex = 34;
//            this.btnRemoveSolr.Text = "Xóa Solr";
//            this.btnRemoveSolr.UseVisualStyleBackColor = false;
//            this.btnRemoveSolr.Visible = false;
//            // 
//            // btnLoadStandardProduct
//            // 
//            this.btnLoadStandardProduct.Location = new System.Drawing.Point(1003, 10);
//            this.btnLoadStandardProduct.Name = "btnLoadStandardProduct";
//            this.btnLoadStandardProduct.Size = new System.Drawing.Size(119, 23);
//            this.btnLoadStandardProduct.TabIndex = 8;
//            this.btnLoadStandardProduct.Text = "Duyệt sản phẩm gốc";
//            this.btnLoadStandardProduct.UseVisualStyleBackColor = true;
//            this.btnLoadStandardProduct.Visible = false;
//            this.btnLoadStandardProduct.Click += new System.EventHandler(this.btnLoadCategory_Click);
//            // 
//            // btnStart
//            // 
//            this.btnStart.Location = new System.Drawing.Point(15, 7);
//            this.btnStart.Name = "btnStart";
//            this.btnStart.Size = new System.Drawing.Size(107, 28);
//            this.btnStart.TabIndex = 46;
//            this.btnStart.Text = "Start";
//            this.btnStart.UseVisualStyleBackColor = true;
//            this.btnStart.Click += new System.EventHandler(this.btnStartConsumer_Click);
//            // 
//            // contextMenuStrip1
//            // 
//            this.contextMenuStrip1.Name = "contextMenuStrip1";
//            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
//            // 
//            // webUserTableAdapter1
//            // 
//            this.webUserTableAdapter1.ClearBeforeFill = true;
//            // 
//            // xtraTabPage9
//            // 
//            this.xtraTabPage9.Controls.Add(this.txtProcessLink);
//            this.xtraTabPage9.Name = "xtraTabPage9";
//            this.xtraTabPage9.Size = new System.Drawing.Size(1197, 577);
//            this.xtraTabPage9.Text = "crawl_TrackConsumer";
//            // 
//            // txtProcessLink
//            // 
//            this.txtProcessLink.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.txtProcessLink.Location = new System.Drawing.Point(0, 0);
//            this.txtProcessLink.MaxLength = 100000;
//            this.txtProcessLink.Name = "txtProcessLink";
//            this.txtProcessLink.Size = new System.Drawing.Size(1197, 577);
//            this.txtProcessLink.TabIndex = 0;
//            this.txtProcessLink.Text = "";
//            // 
//            // xtraTabControl1
//            // 
//            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.xtraTabControl1.Location = new System.Drawing.Point(0, 69);
//            this.xtraTabControl1.Name = "xtraTabControl1";
//            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage9;
//            this.xtraTabControl1.Size = new System.Drawing.Size(1205, 606);
//            this.xtraTabControl1.TabIndex = 1;
//            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
//            this.xtraTabPage9});
//            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
//            // 
//            // FrmControlConsumer
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1205, 675);
//            this.Controls.Add(this.xtraTabControl1);
//            this.Controls.Add(this.panel1);
//            this.KeyPreview = true;
//            this.Name = "FrmControlConsumer";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "ManagerCrawl";
//            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmControlConsumer_FormClosing);
//            this.Load += new System.EventHandler(this.FrmConfigXPath_Load);
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.txtThreads.Properties)).EndInit();
//            this.xtraTabPage9.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
//            this.xtraTabControl1.ResumeLayout(false);
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
//        private System.Windows.Forms.Button btnLoadStandardProduct;
//        private System.Windows.Forms.Button btnRemoveSolr;
//        private System.Windows.Forms.Button btnLoadKeyWord;
//        private System.Windows.Forms.Button button4;
//        private System.Windows.Forms.Button btnStart;
//        private QT.Users.DBCustomerTableAdapters.WebUserTableAdapter webUserTableAdapter1;
//        private System.Windows.Forms.CheckBox ckTest;
//        private DevExpress.XtraEditors.SpinEdit txtThreads;
//        private System.Windows.Forms.Label label12;
//        private System.Windows.Forms.Button button3;
//        private DevExpress.XtraTab.XtraTabPage xtraTabPage9;
//        private System.Windows.Forms.RichTextBox txtProcessLink;
//        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.TextBox queueNameTextBox;
//        private System.Windows.Forms.Button button1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.TextBox txtQueueLog;
//        private System.Windows.Forms.Button btnShowLog;
//    }
//}