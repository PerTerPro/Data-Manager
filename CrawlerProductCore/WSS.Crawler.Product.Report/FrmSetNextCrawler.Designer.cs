namespace WSS.Crawler.Product.Report
{
    partial class FrmSetNextCrawler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.dtpTimeRun = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbFN = new System.Windows.Forms.RadioButton();
            this.rbRL = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtpTimeRun);
            this.panel1.Controls.Add(this.btnPush);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 41);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(921, 521);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(13, 13);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 0;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // dtpTimeRun
            // 
            this.dtpTimeRun.CustomFormat = "yyyy-MM-dd HH";
            this.dtpTimeRun.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeRun.Location = new System.Drawing.Point(94, 12);
            this.dtpTimeRun.Name = "dtpTimeRun";
            this.dtpTimeRun.Size = new System.Drawing.Size(153, 20);
            this.dtpTimeRun.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbRL);
            this.panel2.Controls.Add(this.rbFN);
            this.panel2.Location = new System.Drawing.Point(292, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 33);
            this.panel2.TabIndex = 2;
            // 
            // rbFN
            // 
            this.rbFN.AutoSize = true;
            this.rbFN.Location = new System.Drawing.Point(4, 9);
            this.rbFN.Name = "rbFN";
            this.rbFN.Size = new System.Drawing.Size(39, 17);
            this.rbFN.TabIndex = 0;
            this.rbFN.TabStop = true;
            this.rbFN.Text = "FN";
            this.rbFN.UseVisualStyleBackColor = true;
            // 
            // rbRL
            // 
            this.rbRL.AutoSize = true;
            this.rbRL.Location = new System.Drawing.Point(49, 9);
            this.rbRL.Name = "rbRL";
            this.rbRL.Size = new System.Drawing.Size(39, 17);
            this.rbRL.TabIndex = 1;
            this.rbRL.TabStop = true;
            this.rbRL.Text = "RL";
            this.rbRL.UseVisualStyleBackColor = true;
            // 
            // FrmSetNextCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 562);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSetNextCrawler";
            this.Text = "FrmSetNextCrawler";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dtpTimeRun;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbRL;
        private System.Windows.Forms.RadioButton rbFN;
    }
}