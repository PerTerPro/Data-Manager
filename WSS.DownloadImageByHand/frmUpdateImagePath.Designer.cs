namespace WSS.DownloadImageByHand
{
    partial class frmUpdateImagePath
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.rbsuccess = new System.Windows.Forms.RichTextBox();
            this.rbfail = new System.Windows.Forms.RichTextBox();
            this.txtCompanyId = new DevExpress.XtraEditors.TextEdit();
            this.btnRun = new DevExpress.XtraEditors.SimpleButton();
            this.lbsuccess = new DevExpress.XtraEditors.LabelControl();
            this.lbfail = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Controls.Add(this.lbfail);
            this.panelControl1.Controls.Add(this.lbsuccess);
            this.panelControl1.Controls.Add(this.btnRun);
            this.panelControl1.Controls.Add(this.txtCompanyId);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1155, 52);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 52);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.rbsuccess);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.rbfail);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1155, 525);
            this.splitContainerControl1.SplitterPosition = 523;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // rbsuccess
            // 
            this.rbsuccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbsuccess.Location = new System.Drawing.Point(0, 0);
            this.rbsuccess.Name = "rbsuccess";
            this.rbsuccess.Size = new System.Drawing.Size(523, 525);
            this.rbsuccess.TabIndex = 0;
            this.rbsuccess.Text = "";
            // 
            // rbfail
            // 
            this.rbfail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbfail.Location = new System.Drawing.Point(0, 0);
            this.rbfail.Name = "rbfail";
            this.rbfail.Size = new System.Drawing.Size(627, 525);
            this.rbfail.TabIndex = 1;
            this.rbfail.Text = "";
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.Location = new System.Drawing.Point(12, 12);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.Size = new System.Drawing.Size(280, 20);
            this.txtCompanyId.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(489, 7);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(131, 30);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "UpdateImagePath";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lbsuccess
            // 
            this.lbsuccess.Location = new System.Drawing.Point(316, 15);
            this.lbsuccess.Name = "lbsuccess";
            this.lbsuccess.Size = new System.Drawing.Size(37, 13);
            this.lbsuccess.TabIndex = 2;
            this.lbsuccess.Text = "success";
            // 
            // lbfail
            // 
            this.lbfail.Location = new System.Drawing.Point(396, 15);
            this.lbfail.Name = "lbfail";
            this.lbfail.Size = new System.Drawing.Size(14, 13);
            this.lbfail.TabIndex = 3;
            this.lbfail.Text = "fail";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(640, 13);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "reloadall";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 4;
            // 
            // frmUpdateImagePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 577);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmUpdateImagePath";
            this.Text = "frmUpdateImagePath";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbfail;
        private DevExpress.XtraEditors.LabelControl lbsuccess;
        private DevExpress.XtraEditors.SimpleButton btnRun;
        private DevExpress.XtraEditors.TextEdit txtCompanyId;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.RichTextBox rbsuccess;
        private System.Windows.Forms.RichTextBox rbfail;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}