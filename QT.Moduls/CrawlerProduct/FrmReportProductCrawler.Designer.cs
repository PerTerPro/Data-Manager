namespace QT.Moduls.CrawlerProduct
{
    partial class FrmReportProductCrawler
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnFN = new System.Windows.Forms.Button();
            this.btnRL = new System.Windows.Forms.Button();
            this.btnLSUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1025, 208);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLSUpdate);
            this.panelControl1.Controls.Add(this.btnRL);
            this.panelControl1.Controls.Add(this.btnFN);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1166, 34);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 34);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1166, 490);
            this.panelControl2.TabIndex = 3;
            // 
            // btnFN
            // 
            this.btnFN.Location = new System.Drawing.Point(5, 5);
            this.btnFN.Name = "btnFN";
            this.btnFN.Size = new System.Drawing.Size(75, 23);
            this.btnFN.TabIndex = 0;
            this.btnFN.Text = "FN";
            this.btnFN.UseVisualStyleBackColor = true;
            this.btnFN.Click += new System.EventHandler(this.btnFN_Click);
            // 
            // btnRL
            // 
            this.btnRL.Location = new System.Drawing.Point(86, 5);
            this.btnRL.Name = "btnRL";
            this.btnRL.Size = new System.Drawing.Size(75, 23);
            this.btnRL.TabIndex = 1;
            this.btnRL.Text = "RL";
            this.btnRL.UseVisualStyleBackColor = true;
            // 
            // btnLSUpdate
            // 
            this.btnLSUpdate.Location = new System.Drawing.Point(167, 6);
            this.btnLSUpdate.Name = "btnLSUpdate";
            this.btnLSUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnLSUpdate.TabIndex = 2;
            this.btnLSUpdate.Text = "LSUpdate";
            this.btnLSUpdate.UseVisualStyleBackColor = true;
            // 
            // FrmReportProductCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 524);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmReportProductCrawler";
            this.Text = "FrmReportProductCrawler";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnLSUpdate;
        private System.Windows.Forms.Button btnRL;
        private System.Windows.Forms.Button btnFN;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}