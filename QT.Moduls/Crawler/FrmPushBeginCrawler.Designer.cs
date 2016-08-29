namespace WSS.CrawlerSale.Manager
{
    partial class FrmPushBeginCrawler
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboTypeCrawl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.queuNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckTest = new DevExpress.XtraEditors.CheckEdit();
            this.dteLastUpdateCrawl = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ckTest.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(85, 114);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(166, 114);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboTypeCrawl
            // 
            this.cboTypeCrawl.FormattingEnabled = true;
            this.cboTypeCrawl.Items.AddRange(new object[] {
            "FullCrawl",
            "ReloadCrawl",
            "CrawlNewData"});
            this.cboTypeCrawl.Location = new System.Drawing.Point(85, 40);
            this.cboTypeCrawl.Name = "cboTypeCrawl";
            this.cboTypeCrawl.Size = new System.Drawing.Size(156, 21);
            this.cboTypeCrawl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Queue";
            // 
            // queuNameTextBox
            // 
            this.queuNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queuNameTextBox.Location = new System.Drawing.Point(85, 65);
            this.queuNameTextBox.Name = "queuNameTextBox";
            this.queuNameTextBox.Size = new System.Drawing.Size(156, 22);
            this.queuNameTextBox.TabIndex = 4;
            this.queuNameTextBox.Text = "crawl_product_job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TypeRun";
            // 
            // ckTest
            // 
            this.ckTest.EditValue = true;
            this.ckTest.Location = new System.Drawing.Point(85, 89);
            this.ckTest.Name = "ckTest";
            this.ckTest.Properties.Caption = "Is test";
            this.ckTest.Size = new System.Drawing.Size(75, 19);
            this.ckTest.TabIndex = 6;
            // 
            // dteLastUpdateCrawl
            // 
            this.dteLastUpdateCrawl.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dteLastUpdateCrawl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteLastUpdateCrawl.Location = new System.Drawing.Point(107, 14);
            this.dteLastUpdateCrawl.Name = "dteLastUpdateCrawl";
            this.dteLastUpdateCrawl.Size = new System.Drawing.Size(134, 20);
            this.dteLastUpdateCrawl.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last job process";
            // 
            // FrmPushBeginCrawler
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 142);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dteLastUpdateCrawl);
            this.Controls.Add(this.ckTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.queuNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTypeCrawl);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmPushBeginCrawler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khởi tạo crawl";
            this.Load += new System.EventHandler(this.FrmPushBeginCrawler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ckTest.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.ComboBox cboTypeCrawl;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox queuNameTextBox;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.CheckEdit ckTest;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dteLastUpdateCrawl;

    }
}