namespace QT.Moduls.Crawler
{
    partial class FrmPushJobCrawler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPushJobCrawler));
            this.btnStart = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.txtReportPush = new System.Windows.Forms.RichTextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnGetData = new System.Windows.Forms.Button();
            this.txtQueueName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spinTypeCrawler = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPushCurrent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTypeCrawler.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(2, 9);
            this.btnStart.MinimumSize = new System.Drawing.Size(50, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.txtQuery.Location = new System.Drawing.Point(86, 9);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(533, 255);
            this.txtQuery.TabIndex = 1;
            this.txtQuery.Text = resources.GetString("txtQuery.Text");
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            // 
            // txtReportPush
            // 
            this.txtReportPush.Location = new System.Drawing.Point(84, 272);
            this.txtReportPush.Name = "txtReportPush";
            this.txtReportPush.Size = new System.Drawing.Size(533, 165);
            this.txtReportPush.TabIndex = 2;
            this.txtReportPush.Text = "";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(623, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(515, 426);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(2, 38);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 4;
            this.btnGetData.Text = "Test";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // txtQueueName
            // 
            this.txtQueueName.Location = new System.Drawing.Point(423, 444);
            this.txtQueueName.Name = "txtQueueName";
            this.txtQueueName.Size = new System.Drawing.Size(193, 20);
            this.txtQueueName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "QueueName";
            // 
            // spinTypeCrawler
            // 
            this.spinTypeCrawler.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTypeCrawler.Location = new System.Drawing.Point(155, 443);
            this.spinTypeCrawler.Name = "spinTypeCrawler";
            this.spinTypeCrawler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTypeCrawler.Size = new System.Drawing.Size(70, 20);
            this.spinTypeCrawler.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "TypeCrawler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "(0-Find New, 1-Reload Data)";
            // 
            // btnPushCurrent
            // 
            this.btnPushCurrent.Location = new System.Drawing.Point(623, 444);
            this.btnPushCurrent.Name = "btnPushCurrent";
            this.btnPushCurrent.Size = new System.Drawing.Size(75, 23);
            this.btnPushCurrent.TabIndex = 10;
            this.btnPushCurrent.Text = "PushCurrent";
            this.btnPushCurrent.UseVisualStyleBackColor = true;
            this.btnPushCurrent.Click += new System.EventHandler(this.btnPushCurrent_Click);
            // 
            // FrmPushJobCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 500);
            this.Controls.Add(this.btnPushCurrent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinTypeCrawler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQueueName);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtReportPush);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmPushJobCrawler";
            this.Text = "PushCurrent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPushJobCrawler_FormClosing);
            this.Load += new System.EventHandler(this.FrmPushJobCrawler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTypeCrawler.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox txtQuery;
        private System.Windows.Forms.RichTextBox txtReportPush;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TextBox txtQueueName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit spinTypeCrawler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPushCurrent;
    }
}