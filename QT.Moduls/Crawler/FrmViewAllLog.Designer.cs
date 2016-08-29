namespace QT.Moduls.Crawler
{
    partial class FrmViewLogAllCompany
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtQueueLog = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.textBox1);
            this.panelControl1.Controls.Add(this.btnRun);
            this.panelControl1.Controls.Add(this.txtQueueLog);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(684, 36);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "companyFix";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(371, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 26);
            this.textBox1.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(245, 8);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(51, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtQueueLog
            // 
            this.txtQueueLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtQueueLog.Location = new System.Drawing.Point(5, 5);
            this.txtQueueLog.Name = "txtQueueLog";
            this.txtQueueLog.Size = new System.Drawing.Size(234, 26);
            this.txtQueueLog.TabIndex = 0;
            this.txtQueueLog.Text = "crawler_product_log";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmViewLogAllCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 458);
            this.Controls.Add(this.panelControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmViewLogAllCompany";
            this.Text = "FrmViewLogAllCompany";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmViewLogAllCompany_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtQueueLog;
        private System.Windows.Forms.Button button1;
    }
}