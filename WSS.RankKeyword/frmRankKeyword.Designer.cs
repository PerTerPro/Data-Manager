namespace WSS.RankKeyword
{
    partial class frmRankKeyword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRankKeyword));
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.txtKeyword = new DevExpress.XtraEditors.TextEdit();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbCheckRestartProgram = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.rbInfo = new System.Windows.Forms.RichTextBox();
            this.rblink = new System.Windows.Forms.RichTextBox();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnGetlistUrl = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtKeywordCheck = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbRank = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtLinks = new DevExpress.XtraEditors.TextEdit();
            this.txtDomainCheck = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnCheckRank = new DevExpress.XtraEditors.SimpleButton();
            this.txtDirectory = new DevExpress.XtraEditors.MemoEdit();
            this.rbError = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeywordCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLinks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomainCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 54);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(156, 54);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(12, 28);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(219, 20);
            this.txtKeyword.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "WSS.Lee";
            this.notifyIcon1.BalloonTipTitle = "Check Rank Keyword";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WSS.Lee*";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Đang xử lý từ khóa thứ: ";
            // 
            // lbCheckRestartProgram
            // 
            this.lbCheckRestartProgram.Location = new System.Drawing.Point(138, 9);
            this.lbCheckRestartProgram.Name = "lbCheckRestartProgram";
            this.lbCheckRestartProgram.Size = new System.Drawing.Size(12, 13);
            this.lbCheckRestartProgram.TabIndex = 4;
            this.lbCheckRestartProgram.Text = "...";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.rbError);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lbCheckRestartProgram);
            this.panelControl1.Controls.Add(this.btnStart);
            this.panelControl1.Controls.Add(this.btnStop);
            this.panelControl1.Controls.Add(this.txtKeyword);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1309, 87);
            this.panelControl1.TabIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 87);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1309, 547);
            this.panelControl2.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl5);
            this.groupControl1.Controls.Add(this.panelControl4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(244, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1063, 543);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Get list Links";
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.splitContainerControl1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(2, 66);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1059, 475);
            this.panelControl5.TabIndex = 1;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.rbInfo);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.rblink);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1055, 471);
            this.splitContainerControl1.SplitterPosition = 320;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // rbInfo
            // 
            this.rbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbInfo.Location = new System.Drawing.Point(0, 0);
            this.rbInfo.Name = "rbInfo";
            this.rbInfo.Size = new System.Drawing.Size(320, 471);
            this.rbInfo.TabIndex = 0;
            this.rbInfo.Text = "";
            // 
            // rblink
            // 
            this.rblink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rblink.Location = new System.Drawing.Point(0, 0);
            this.rblink.Name = "rblink";
            this.rblink.Size = new System.Drawing.Size(730, 471);
            this.rblink.TabIndex = 1;
            this.rblink.Text = "";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnGetlistUrl);
            this.panelControl4.Controls.Add(this.txtDirectory);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 21);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1059, 45);
            this.panelControl4.TabIndex = 0;
            // 
            // btnGetlistUrl
            // 
            this.btnGetlistUrl.Location = new System.Drawing.Point(363, 11);
            this.btnGetlistUrl.Name = "btnGetlistUrl";
            this.btnGetlistUrl.Size = new System.Drawing.Size(75, 23);
            this.btnGetlistUrl.TabIndex = 0;
            this.btnGetlistUrl.Text = "Get Url";
            this.btnGetlistUrl.Click += new System.EventHandler(this.btnGetlistUrl_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txtKeywordCheck);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.lbRank);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.txtLinks);
            this.panelControl3.Controls.Add(this.txtDomainCheck);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.btnCheckRank);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(242, 543);
            this.panelControl3.TabIndex = 9;
            // 
            // txtKeywordCheck
            // 
            this.txtKeywordCheck.Location = new System.Drawing.Point(92, 5);
            this.txtKeywordCheck.Name = "txtKeywordCheck";
            this.txtKeywordCheck.Size = new System.Drawing.Size(137, 20);
            this.txtKeywordCheck.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Từ khóa";
            // 
            // lbRank
            // 
            this.lbRank.Location = new System.Drawing.Point(92, 111);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(12, 13);
            this.lbRank.TabIndex = 7;
            this.lbRank.Text = "...";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Domain";
            // 
            // txtLinks
            // 
            this.txtLinks.Location = new System.Drawing.Point(11, 139);
            this.txtLinks.Name = "txtLinks";
            this.txtLinks.Size = new System.Drawing.Size(218, 20);
            this.txtLinks.TabIndex = 6;
            // 
            // txtDomainCheck
            // 
            this.txtDomainCheck.Location = new System.Drawing.Point(92, 34);
            this.txtDomainCheck.Name = "txtDomainCheck";
            this.txtDomainCheck.Size = new System.Drawing.Size(137, 20);
            this.txtDomainCheck.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Rank : ";
            // 
            // btnCheckRank
            // 
            this.btnCheckRank.Location = new System.Drawing.Point(11, 68);
            this.btnCheckRank.Name = "btnCheckRank";
            this.btnCheckRank.Size = new System.Drawing.Size(75, 23);
            this.btnCheckRank.TabIndex = 4;
            this.btnCheckRank.Text = "CheckRank";
            this.btnCheckRank.Click += new System.EventHandler(this.btnCheckRank_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(16, 13);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(329, 20);
            this.txtDirectory.TabIndex = 1;
            // 
            // rbError
            // 
            this.rbError.Location = new System.Drawing.Point(842, 5);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(398, 72);
            this.rbError.TabIndex = 5;
            this.rbError.Text = "";
            // 
            // frmRankKeyword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 634);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmRankKeyword";
            this.Resize += new System.EventHandler(this.frmRankKeyword_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeywordCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLinks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomainCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.TextEdit txtKeyword;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbCheckRestartProgram;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lbRank;
        private DevExpress.XtraEditors.TextEdit txtLinks;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnCheckRank;
        private DevExpress.XtraEditors.TextEdit txtDomainCheck;
        private DevExpress.XtraEditors.TextEdit txtKeywordCheck;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.RichTextBox rbInfo;
        private System.Windows.Forms.RichTextBox rblink;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnGetlistUrl;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.MemoEdit txtDirectory;
        private System.Windows.Forms.RichTextBox rbError;
    }
}

