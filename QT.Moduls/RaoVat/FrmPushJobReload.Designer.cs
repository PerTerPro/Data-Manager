namespace QT.Moduls.CrawlSale
{
    partial class FrmPushJobReload
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtQueueName = new System.Windows.Forms.TextBox();
            this.report = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(157, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtQueueName
            // 
            this.txtQueueName.Location = new System.Drawing.Point(175, 15);
            this.txtQueueName.Name = "txtQueueName";
            this.txtQueueName.Size = new System.Drawing.Size(157, 20);
            this.txtQueueName.TabIndex = 3;
            this.txtQueueName.Text = "crawler_sale_reload_wait";
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 41);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(633, 326);
            this.report.TabIndex = 4;
            this.report.Text = "";
            // 
            // FrmPushJobReload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 379);
            this.Controls.Add(this.report);
            this.Controls.Add(this.txtQueueName);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmPushJobReload";
            this.Text = "Đẩy việc RabbitMQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPushJobReload_FormClosing);
            this.Load += new System.EventHandler(this.FrmPushJobReload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtQueueName;
        private System.Windows.Forms.RichTextBox report;
    }
}