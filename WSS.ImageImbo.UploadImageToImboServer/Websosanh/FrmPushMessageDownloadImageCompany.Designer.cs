namespace WSS.ImageImbo.UploadImageToImboServer.Websosanh
{
    partial class FrmPushMessageDownloadImageCompany
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
            this.rbListIdCompany = new System.Windows.Forms.RichTextBox();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPushMessage = new DevExpress.XtraEditors.SimpleButton();
            this.rbMessage = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbListIdCompany
            // 
            this.rbListIdCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbListIdCompany.Location = new System.Drawing.Point(0, 0);
            this.rbListIdCompany.Name = "rbListIdCompany";
            this.rbListIdCompany.Size = new System.Drawing.Size(267, 644);
            this.rbListIdCompany.TabIndex = 0;
            this.rbListIdCompany.Text = "";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.rbListIdCompany);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.rbMessage);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1033, 644);
            this.splitContainerControl1.SplitterPosition = 267;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPushMessage);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(103, 644);
            this.panelControl1.TabIndex = 0;
            // 
            // btnPushMessage
            // 
            this.btnPushMessage.Location = new System.Drawing.Point(12, 27);
            this.btnPushMessage.Name = "btnPushMessage";
            this.btnPushMessage.Size = new System.Drawing.Size(75, 23);
            this.btnPushMessage.TabIndex = 0;
            this.btnPushMessage.Text = "PushMessage";
            this.btnPushMessage.Click += new System.EventHandler(this.btnPushMessage_Click);
            // 
            // rbMessage
            // 
            this.rbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbMessage.Location = new System.Drawing.Point(103, 0);
            this.rbMessage.Name = "rbMessage";
            this.rbMessage.Size = new System.Drawing.Size(658, 644);
            this.rbMessage.TabIndex = 1;
            this.rbMessage.Text = "";
            // 
            // FrmPushMessageDownloadImageCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 644);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmPushMessageDownloadImageCompany";
            this.Text = "FrmPushMessageDownloadImageCompany";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rbListIdCompany;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.RichTextBox rbMessage;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPushMessage;
    }
}