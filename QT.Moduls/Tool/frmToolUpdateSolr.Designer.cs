namespace QT.Moduls.Tool
{
    partial class frmToolUpdateSolr
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
            this.btUpdateSolr = new DevExpress.XtraEditors.SimpleButton();
            this.laMess1 = new System.Windows.Forms.Label();
            this.btUpdateViewCount = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimeDelay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkEdite = new DevExpress.XtraEditors.CheckEdit();
            this.memoCode = new DevExpress.XtraEditors.MemoEdit();
            this.btUpdateSolrID = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxSolrNodes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdWeek = new System.Windows.Forms.RadioButton();
            this.rdMonth = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEdite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCode.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btUpdateSolr
            // 
            this.btUpdateSolr.Location = new System.Drawing.Point(12, 182);
            this.btUpdateSolr.Name = "btUpdateSolr";
            this.btUpdateSolr.Size = new System.Drawing.Size(131, 23);
            this.btUpdateSolr.TabIndex = 2;
            this.btUpdateSolr.Text = "Update Solr";
            this.btUpdateSolr.Click += new System.EventHandler(this.btUpdateSolr_Click);
            // 
            // laMess1
            // 
            this.laMess1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laMess1.Location = new System.Drawing.Point(1, 9);
            this.laMess1.Name = "laMess1";
            this.laMess1.Size = new System.Drawing.Size(675, 87);
            this.laMess1.TabIndex = 3;
            this.laMess1.Text = "messger";
            // 
            // btUpdateViewCount
            // 
            this.btUpdateViewCount.Location = new System.Drawing.Point(91, 13);
            this.btUpdateViewCount.Name = "btUpdateViewCount";
            this.btUpdateViewCount.Size = new System.Drawing.Size(131, 46);
            this.btUpdateViewCount.TabIndex = 2;
            this.btUpdateViewCount.Text = "Update ViewCount";
            this.btUpdateViewCount.Click += new System.EventHandler(this.btUpdateViewCount_Click);
            // 
            // txtTimeDelay
            // 
            this.txtTimeDelay.EditValue = "100";
            this.txtTimeDelay.Location = new System.Drawing.Point(66, 156);
            this.txtTimeDelay.Name = "txtTimeDelay";
            this.txtTimeDelay.Size = new System.Drawing.Size(100, 20);
            this.txtTimeDelay.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 159);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "timeDelay";
            // 
            // chkEdite
            // 
            this.chkEdite.Location = new System.Drawing.Point(4, 65);
            this.chkEdite.Name = "chkEdite";
            this.chkEdite.Properties.Caption = "ZenCode";
            this.chkEdite.Size = new System.Drawing.Size(75, 18);
            this.chkEdite.TabIndex = 6;
            // 
            // memoCode
            // 
            this.memoCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoCode.Location = new System.Drawing.Point(302, 7);
            this.memoCode.Name = "memoCode";
            this.memoCode.Size = new System.Drawing.Size(380, 364);
            this.memoCode.TabIndex = 7;
            // 
            // btUpdateSolrID
            // 
            this.btUpdateSolrID.Location = new System.Drawing.Point(13, 211);
            this.btUpdateSolrID.Name = "btUpdateSolrID";
            this.btUpdateSolrID.Size = new System.Drawing.Size(131, 23);
            this.btUpdateSolrID.TabIndex = 2;
            this.btUpdateSolrID.Text = "Update Solr ProductID";
            this.btUpdateSolrID.Click += new System.EventHandler(this.btUpdateSolrID_Click);
            // 
            // comboBoxSolrNodes
            // 
            this.comboBoxSolrNodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSolrNodes.DropDownWidth = 255;
            this.comboBoxSolrNodes.FormattingEnabled = true;
            this.comboBoxSolrNodes.Location = new System.Drawing.Point(4, 75);
            this.comboBoxSolrNodes.Name = "comboBoxSolrNodes";
            this.comboBoxSolrNodes.Size = new System.Drawing.Size(242, 21);
            this.comboBoxSolrNodes.TabIndex = 34;
            this.comboBoxSolrNodes.SelectedIndexChanged += new System.EventHandler(this.comboBoxSolrNodes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdWeek);
            this.groupBox1.Controls.Add(this.rdMonth);
            this.groupBox1.Controls.Add(this.btUpdateViewCount);
            this.groupBox1.Controls.Add(this.chkEdite);
            this.groupBox1.Location = new System.Drawing.Point(4, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 100);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdWeek
            // 
            this.rdWeek.AutoSize = true;
            this.rdWeek.Location = new System.Drawing.Point(6, 42);
            this.rdWeek.Name = "rdWeek";
            this.rdWeek.Size = new System.Drawing.Size(73, 17);
            this.rdWeek.TabIndex = 1;
            this.rdWeek.Text = "ViewTuan";
            this.rdWeek.UseVisualStyleBackColor = true;
            // 
            // rdMonth
            // 
            this.rdMonth.AutoSize = true;
            this.rdMonth.Checked = true;
            this.rdMonth.Location = new System.Drawing.Point(6, 19);
            this.rdMonth.Name = "rdMonth";
            this.rdMonth.Size = new System.Drawing.Size(79, 17);
            this.rdMonth.TabIndex = 0;
            this.rdMonth.TabStop = true;
            this.rdMonth.Text = "ViewThang";
            this.rdMonth.UseVisualStyleBackColor = true;
            // 
            // frmToolUpdateSolr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(681, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSolrNodes);
            this.Controls.Add(this.memoCode);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTimeDelay);
            this.Controls.Add(this.btUpdateSolrID);
            this.Controls.Add(this.btUpdateSolr);
            this.Controls.Add(this.laMess1);
            this.Name = "frmToolUpdateSolr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmToolUpdateSolr_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEdite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCode.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btUpdateSolr;
        private System.Windows.Forms.Label laMess1;
        private DevExpress.XtraEditors.SimpleButton btUpdateViewCount;
        private DevExpress.XtraEditors.TextEdit txtTimeDelay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkEdite;
        private DevExpress.XtraEditors.MemoEdit memoCode;
        private DevExpress.XtraEditors.SimpleButton btUpdateSolrID;
        private System.Windows.Forms.ComboBox comboBoxSolrNodes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdWeek;
        private System.Windows.Forms.RadioButton rdMonth;
    }
}
