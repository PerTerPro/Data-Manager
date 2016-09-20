namespace WSS.Crawler.Product.Report
{
    partial class FrmCacheCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCacheCompany));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDuyetCache = new System.Windows.Forms.ToolStripButton();
            this.btnDuyetTuSQL = new System.Windows.Forms.ToolStripButton();
            this.btnViewCacheCompany = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDuyetCache,
            this.btnDuyetTuSQL,
            this.btnViewCacheCompany});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1053, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDuyetCache
            // 
            this.btnDuyetCache.Image = ((System.Drawing.Image)(resources.GetObject("btnDuyetCache.Image")));
            this.btnDuyetCache.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuyetCache.Name = "btnDuyetCache";
            this.btnDuyetCache.Size = new System.Drawing.Size(150, 22);
            this.btnDuyetCache.Text = "DeleteNotAllowCrawler";
            this.btnDuyetCache.Click += new System.EventHandler(this.btnDuyetCache_Click);
            // 
            // btnDuyetTuSQL
            // 
            this.btnDuyetTuSQL.Image = ((System.Drawing.Image)(resources.GetObject("btnDuyetTuSQL.Image")));
            this.btnDuyetTuSQL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuyetTuSQL.Name = "btnDuyetTuSQL";
            this.btnDuyetTuSQL.Size = new System.Drawing.Size(165, 22);
            this.btnDuyetTuSQL.Text = "Add lost company crawler";
            this.btnDuyetTuSQL.Click += new System.EventHandler(this.btnDuyetTuSQL_Click);
            // 
            // btnViewCacheCompany
            // 
            this.btnViewCacheCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCacheCompany.Image")));
            this.btnViewCacheCompany.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewCacheCompany.Name = "btnViewCacheCompany";
            this.btnViewCacheCompany.Size = new System.Drawing.Size(137, 22);
            this.btnViewCacheCompany.Text = "ViewCacheCompany";
            this.btnViewCacheCompany.Click += new System.EventHandler(this.btnViewCacheCompany_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1053, 551);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // FrmCacheCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 576);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmCacheCompany";
            this.Text = "Manage Cache Company Crawler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCacheCompany_FormClosing);
            this.Load += new System.EventHandler(this.FrmCacheCompany_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDuyetCache;
        private System.Windows.Forms.ToolStripButton btnDuyetTuSQL;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton btnViewCacheCompany;
    }
}