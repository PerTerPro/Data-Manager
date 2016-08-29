namespace QT.Moduls.CrawlerProduct
{
    partial class FrmPushPriceLogDataRedis
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
            this.btnPushData = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPushPriceLogOld = new DevExpress.XtraEditors.SimpleButton();
            this.btnPushPriceCurrent = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPushData
            // 
            this.btnPushData.Location = new System.Drawing.Point(3, 5);
            this.btnPushData.Name = "btnPushData";
            this.btnPushData.Size = new System.Drawing.Size(119, 26);
            this.btnPushData.TabIndex = 0;
            this.btnPushData.Text = "PushDataToRedis";
            this.btnPushData.Click += new System.EventHandler(this.btnPushData_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(595, 471);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 50);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPushPriceLogOld);
            this.panel1.Controls.Add(this.btnPushPriceCurrent);
            this.panel1.Controls.Add(this.btnPushData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 35);
            this.panel1.TabIndex = 2;
            // 
            // btnPushPriceLogOld
            // 
            this.btnPushPriceLogOld.Location = new System.Drawing.Point(138, 5);
            this.btnPushPriceLogOld.Name = "btnPushPriceLogOld";
            this.btnPushPriceLogOld.Size = new System.Drawing.Size(171, 26);
            this.btnPushPriceLogOld.TabIndex = 2;
            this.btnPushPriceLogOld.Text = "PushDataToRedisLogData";
            this.btnPushPriceLogOld.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnPushPriceCurrent
            // 
            this.btnPushPriceCurrent.Location = new System.Drawing.Point(315, 6);
            this.btnPushPriceCurrent.Name = "btnPushPriceCurrent";
            this.btnPushPriceCurrent.Size = new System.Drawing.Size(102, 26);
            this.btnPushPriceCurrent.TabIndex = 1;
            this.btnPushPriceCurrent.Text = "PushPriceCurrent";
            this.btnPushPriceCurrent.Click += new System.EventHandler(this.btnPushPriceCurrent_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.richTextBox2);
            this.panelControl1.Controls.Add(this.richTextBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 35);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(782, 300);
            this.panelControl1.TabIndex = 3;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(2, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(778, 296);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // FrmPushPriceLogDataRedis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 335);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPushPriceLogDataRedis";
            this.Text = "FrmPushPriceLogDataRedis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPushPriceLogDataRedis_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPushData;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private DevExpress.XtraEditors.SimpleButton btnPushPriceCurrent;
        private DevExpress.XtraEditors.SimpleButton btnPushPriceLogOld;
    }
}