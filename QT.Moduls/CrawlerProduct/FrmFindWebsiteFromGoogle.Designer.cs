namespace QT.Moduls.CrawlerProduct
{
    partial class FrmFindWebsiteFromGoogle
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
            this.btnClean = new DevExpress.XtraEditors.SimpleButton();
            this.txtPageGoogle = new DevExpress.XtraEditors.TextEdit();
            this.txtTimeDelay = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.txtKeywordSearch = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.richTextBoxWebsiteNew = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageGoogle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeywordSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClean);
            this.panelControl1.Controls.Add(this.txtPageGoogle);
            this.panelControl1.Controls.Add(this.txtTimeDelay);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnFind);
            this.panelControl1.Controls.Add(this.txtKeywordSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(546, 76);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(343, 3);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Clean";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtPageGoogle
            // 
            this.txtPageGoogle.EditValue = "5";
            this.txtPageGoogle.Location = new System.Drawing.Point(222, 35);
            this.txtPageGoogle.Name = "txtPageGoogle";
            this.txtPageGoogle.Size = new System.Drawing.Size(85, 20);
            this.txtPageGoogle.TabIndex = 7;
            // 
            // txtTimeDelay
            // 
            this.txtTimeDelay.EditValue = "10000";
            this.txtTimeDelay.Location = new System.Drawing.Point(59, 35);
            this.txtTimeDelay.Name = "txtTimeDelay";
            this.txtTimeDelay.Size = new System.Drawing.Size(85, 20);
            this.txtTimeDelay.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PageGoogle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TimeDelay";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(262, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtKeywordSearch
            // 
            this.txtKeywordSearch.EditValue = "Keyword search ...";
            this.txtKeywordSearch.Location = new System.Drawing.Point(5, 5);
            this.txtKeywordSearch.Name = "txtKeywordSearch";
            this.txtKeywordSearch.Size = new System.Drawing.Size(251, 20);
            this.txtKeywordSearch.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.richTextBoxWebsiteNew);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 76);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(546, 414);
            this.panelControl2.TabIndex = 1;
            // 
            // richTextBoxWebsiteNew
            // 
            this.richTextBoxWebsiteNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxWebsiteNew.Location = new System.Drawing.Point(2, 2);
            this.richTextBoxWebsiteNew.Name = "richTextBoxWebsiteNew";
            this.richTextBoxWebsiteNew.Size = new System.Drawing.Size(542, 410);
            this.richTextBoxWebsiteNew.TabIndex = 0;
            this.richTextBoxWebsiteNew.Text = "";
            // 
            // FrmFindWebsiteFromGoogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 490);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmFindWebsiteFromGoogle";
            this.Text = "FrmFindWebsiteFromGoogle";
            this.Load += new System.EventHandler(this.FrmFindWebsiteFromGoogle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageGoogle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeywordSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraEditors.TextEdit txtKeywordSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxWebsiteNew;
        private DevExpress.XtraEditors.TextEdit txtPageGoogle;
        private DevExpress.XtraEditors.TextEdit txtTimeDelay;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnClean;
    }
}