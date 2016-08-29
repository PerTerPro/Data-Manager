namespace WSS.Service.Crawler.Consumer.FindNew
{
    partial class FrmCrawlerData
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
            this.lblQueueCount = new System.Windows.Forms.Label();
            this.ckCheckOtherRunning = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPush = new System.Windows.Forms.Button();
            this.txtCompanyDomain = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblQueueCount);
            this.panel1.Controls.Add(this.ckCheckOtherRunning);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.spinEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 30);
            this.panel1.TabIndex = 1;
            // 
            // lblQueueCount
            // 
            this.lblQueueCount.AutoSize = true;
            this.lblQueueCount.Location = new System.Drawing.Point(356, 7);
            this.lblQueueCount.Name = "lblQueueCount";
            this.lblQueueCount.Size = new System.Drawing.Size(18, 13);
            this.lblQueueCount.TabIndex = 7;
            this.lblQueueCount.Text = "Q:";
            // 
            // ckCheckOtherRunning
            // 
            this.ckCheckOtherRunning.AutoSize = true;
            this.ckCheckOtherRunning.Location = new System.Drawing.Point(186, 7);
            this.ckCheckOtherRunning.Name = "ckCheckOtherRunning";
            this.ckCheckOtherRunning.Size = new System.Drawing.Size(123, 17);
            this.ckCheckOtherRunning.TabIndex = 6;
            this.ckCheckOtherRunning.Text = "CheckOtherRunning";
            this.ckCheckOtherRunning.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(104, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(12, 7);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(86, 20);
            this.spinEdit1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPush);
            this.panel2.Controls.Add(this.txtCompanyDomain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 94);
            this.panel2.TabIndex = 3;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(588, 3);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 2;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // txtCompanyDomain
            // 
            this.txtCompanyDomain.Location = new System.Drawing.Point(3, 4);
            this.txtCompanyDomain.Name = "txtCompanyDomain";
            this.txtCompanyDomain.Size = new System.Drawing.Size(579, 87);
            this.txtCompanyDomain.TabIndex = 1;
            this.txtCompanyDomain.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1266, 589);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // FrmCrawlerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 713);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCrawlerData";
            this.Text = "FrmRunData";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCrawlerData_FormClosed);
            this.Load += new System.EventHandler(this.FrmRun_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.CheckBox ckCheckOtherRunning;
        private System.Windows.Forms.Label lblQueueCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.RichTextBox txtCompanyDomain;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}