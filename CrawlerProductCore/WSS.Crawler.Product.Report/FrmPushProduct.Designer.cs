namespace WSS.Crawler.Product.Report
{
    partial class FrmPushProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPushProduct));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPushDownloadImage = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPushDownloadImage});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(916, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "PushDownloadImage";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(916, 705);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnPushDownloadImage
            // 
            this.btnPushDownloadImage.Image = ((System.Drawing.Image)(resources.GetObject("btnPushDownloadImage.Image")));
            this.btnPushDownloadImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPushDownloadImage.Name = "btnPushDownloadImage";
            this.btnPushDownloadImage.Size = new System.Drawing.Size(140, 22);
            this.btnPushDownloadImage.Text = "PushDownloadImage";
            this.btnPushDownloadImage.Click += new System.EventHandler(this.btnPushDownloadImage_Click);
            // 
            // FrmPushProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 730);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "FrmPushProduct";
            this.Text = "FrmPushProduct";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnPushDownloadImage;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}