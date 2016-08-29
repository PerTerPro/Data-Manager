namespace QT.Moduls.CrawlProd
{
    partial class FrmTrackCrawlerData
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRun = new System.Windows.Forms.Button();
            this.tab_OtherMss = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtOtherMss = new System.Windows.Forms.RichTextBox();
            this.tab_eventProcessLink = new DevExpress.XtraTab.XtraTabPage();
            this.txteventProcessLink = new System.Windows.Forms.RichTextBox();
            this.tab_eventWhenGetProductLink = new DevExpress.XtraTab.XtraTabPage();
            this.txteventWhenGetProductLink = new System.Windows.Forms.RichTextBox();
            this.tab_eventWhenAddQueue = new DevExpress.XtraTab.XtraTabPage();
            this.txteventWhenAddQueue = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_OtherMss)).BeginInit();
            this.tab_OtherMss.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.tab_eventProcessLink.SuspendLayout();
            this.tab_eventWhenGetProductLink.SuspendLayout();
            this.tab_eventWhenAddQueue.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRun);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(900, 32);
            this.panelControl1.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(5, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tab_OtherMss
            // 
            this.tab_OtherMss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_OtherMss.Location = new System.Drawing.Point(0, 32);
            this.tab_OtherMss.Name = "tab_OtherMss";
            this.tab_OtherMss.SelectedTabPage = this.xtraTabPage1;
            this.tab_OtherMss.Size = new System.Drawing.Size(900, 517);
            this.tab_OtherMss.TabIndex = 4;
            this.tab_OtherMss.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tab_eventProcessLink,
            this.tab_eventWhenGetProductLink,
            this.tab_eventWhenAddQueue,
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtOtherMss);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(892, 488);
            this.xtraTabPage1.Text = "OtherMss";
            // 
            // txtOtherMss
            // 
            this.txtOtherMss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOtherMss.Location = new System.Drawing.Point(0, 0);
            this.txtOtherMss.Name = "txtOtherMss";
            this.txtOtherMss.Size = new System.Drawing.Size(892, 488);
            this.txtOtherMss.TabIndex = 3;
            this.txtOtherMss.Text = "";
            // 
            // tab_eventProcessLink
            // 
            this.tab_eventProcessLink.Controls.Add(this.txteventProcessLink);
            this.tab_eventProcessLink.Name = "tab_eventProcessLink";
            this.tab_eventProcessLink.Size = new System.Drawing.Size(892, 488);
            this.tab_eventProcessLink.Text = "eventProcessLink";
            // 
            // txteventProcessLink
            // 
            this.txteventProcessLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txteventProcessLink.Location = new System.Drawing.Point(0, 0);
            this.txteventProcessLink.Name = "txteventProcessLink";
            this.txteventProcessLink.Size = new System.Drawing.Size(892, 488);
            this.txteventProcessLink.TabIndex = 0;
            this.txteventProcessLink.Text = "";
            // 
            // tab_eventWhenGetProductLink
            // 
            this.tab_eventWhenGetProductLink.Controls.Add(this.txteventWhenGetProductLink);
            this.tab_eventWhenGetProductLink.Name = "tab_eventWhenGetProductLink";
            this.tab_eventWhenGetProductLink.Size = new System.Drawing.Size(892, 488);
            this.tab_eventWhenGetProductLink.Text = "eventWhenGetProductLink";
            // 
            // txteventWhenGetProductLink
            // 
            this.txteventWhenGetProductLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txteventWhenGetProductLink.Location = new System.Drawing.Point(0, 0);
            this.txteventWhenGetProductLink.Name = "txteventWhenGetProductLink";
            this.txteventWhenGetProductLink.Size = new System.Drawing.Size(892, 488);
            this.txteventWhenGetProductLink.TabIndex = 1;
            this.txteventWhenGetProductLink.Text = "";
            // 
            // tab_eventWhenAddQueue
            // 
            this.tab_eventWhenAddQueue.Controls.Add(this.txteventWhenAddQueue);
            this.tab_eventWhenAddQueue.Name = "tab_eventWhenAddQueue";
            this.tab_eventWhenAddQueue.Size = new System.Drawing.Size(892, 488);
            this.tab_eventWhenAddQueue.Text = "eventWhenAddQueue";
            // 
            // txteventWhenAddQueue
            // 
            this.txteventWhenAddQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txteventWhenAddQueue.Location = new System.Drawing.Point(0, 0);
            this.txteventWhenAddQueue.Name = "txteventWhenAddQueue";
            this.txteventWhenAddQueue.Size = new System.Drawing.Size(892, 488);
            this.txteventWhenAddQueue.TabIndex = 2;
            this.txteventWhenAddQueue.Text = "";
            // 
            // FrmTrackCrawlerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 549);
            this.Controls.Add(this.tab_OtherMss);
            this.Controls.Add(this.panelControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmTrackCrawlerData";
            this.Text = "FrmViewLog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmViewLog_FormClosing);
            this.Load += new System.EventHandler(this.FrmViewLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab_OtherMss)).EndInit();
            this.tab_OtherMss.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.tab_eventProcessLink.ResumeLayout(false);
            this.tab_eventWhenGetProductLink.ResumeLayout(false);
            this.tab_eventWhenAddQueue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnRun;
        private DevExpress.XtraTab.XtraTabControl tab_OtherMss;
        private DevExpress.XtraTab.XtraTabPage tab_eventProcessLink;
        private DevExpress.XtraTab.XtraTabPage tab_eventWhenGetProductLink;
        private System.Windows.Forms.RichTextBox txteventProcessLink;
        private System.Windows.Forms.RichTextBox txteventWhenGetProductLink;
        private DevExpress.XtraTab.XtraTabPage tab_eventWhenAddQueue;
        private System.Windows.Forms.RichTextBox txteventWhenAddQueue;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.RichTextBox txtOtherMss;
    }
}