namespace QT.Moduls.Tool
{
    partial class FrmAutoAddCampaign
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
            this.lblB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.btnCreateLandingPage = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtPathEx = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPathEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblB);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.lblA);
            this.panelControl1.Controls.Add(this.btnCreateLandingPage);
            this.panelControl1.Controls.Add(this.btnBrowse);
            this.panelControl1.Controls.Add(this.txtPathEx);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1031, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(182, 75);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(16, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 75);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "...";
            // 
            // btnCreateLandingPage
            // 
            this.btnCreateLandingPage.Location = new System.Drawing.Point(12, 38);
            this.btnCreateLandingPage.Name = "btnCreateLandingPage";
            this.btnCreateLandingPage.Size = new System.Drawing.Size(248, 23);
            this.btnCreateLandingPage.TabIndex = 2;
            this.btnCreateLandingPage.Text = "Create LandingPage";
            this.btnCreateLandingPage.Click += new System.EventHandler(this.btnCreateLandingPage_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(185, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPathEx
            // 
            this.txtPathEx.Location = new System.Drawing.Point(12, 12);
            this.txtPathEx.Name = "txtPathEx";
            this.txtPathEx.Size = new System.Drawing.Size(167, 20);
            this.txtPathEx.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.richTextBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1031, 423);
            this.panelControl2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1027, 419);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAutoAddCampaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 523);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmAutoAddCampaign";
            this.Text = "FrmAutoAddCampaign";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPathEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.TextEdit txtPathEx;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnCreateLandingPage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblA;
    }
}