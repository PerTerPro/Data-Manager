namespace QT.Moduls.CrawlerProduct
{
    partial class FrmCacheLastCrawlerProduct
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
            this.btnPushCache = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnPushCache
            // 
            this.btnPushCache.Location = new System.Drawing.Point(12, 12);
            this.btnPushCache.Name = "btnPushCache";
            this.btnPushCache.Size = new System.Drawing.Size(105, 25);
            this.btnPushCache.TabIndex = 0;
            this.btnPushCache.Text = "Start Push";
            this.btnPushCache.Click += new System.EventHandler(this.btnPushCache_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(667, 245);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // FrmCacheLastCrawlerProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 301);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPushCache);
            this.Name = "FrmCacheLastCrawlerProduct";
            this.Text = "FrmCacheLastCrawlerProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPushCache;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}