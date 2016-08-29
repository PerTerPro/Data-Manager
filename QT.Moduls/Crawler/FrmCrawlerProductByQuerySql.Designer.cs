namespace QT.Moduls.Crawler
{
    partial class FrmCrawlerProductByQuerySql
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spinVisited = new DevExpress.XtraEditors.SpinEdit();
            this.spinQueue = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.spinQueueName = new System.Windows.Forms.TextBox();
            this.spinWaitRestart = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tblAllInfo = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnRun = new DevExpress.XtraEditors.SimpleButton();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinVisited.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQueue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinWaitRestart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnStop);
            this.panelControl1.Controls.Add(this.btnRun);
            this.panelControl1.Controls.Add(this.spinWaitRestart);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.spinQueueName);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.spinQueue);
            this.panelControl1.Controls.Add(this.spinVisited);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(670, 53);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tabControl1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 53);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(670, 290);
            this.panelControl2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visited";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Queue";
            // 
            // spinVisited
            // 
            this.spinVisited.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinVisited.Location = new System.Drawing.Point(46, 5);
            this.spinVisited.Name = "spinVisited";
            this.spinVisited.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinVisited.Size = new System.Drawing.Size(71, 20);
            this.spinVisited.TabIndex = 2;
            // 
            // spinQueue
            // 
            this.spinQueue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinQueue.Location = new System.Drawing.Point(46, 30);
            this.spinQueue.Name = "spinQueue";
            this.spinQueue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinQueue.Size = new System.Drawing.Size(71, 20);
            this.spinQueue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "QueueName";
            // 
            // spinQueueName
            // 
            this.spinQueueName.Location = new System.Drawing.Point(201, 6);
            this.spinQueueName.Name = "spinQueueName";
            this.spinQueueName.Size = new System.Drawing.Size(163, 20);
            this.spinQueueName.TabIndex = 5;
            // 
            // spinWaitRestart
            // 
            this.spinWaitRestart.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinWaitRestart.Location = new System.Drawing.Point(201, 29);
            this.spinWaitRestart.Name = "spinWaitRestart";
            this.spinWaitRestart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinWaitRestart.Size = new System.Drawing.Size(57, 20);
            this.spinWaitRestart.TabIndex = 7;
            this.spinWaitRestart.EditValueChanged += new System.EventHandler(this.spinEdit3_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wait Recrawl";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.textBox2);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(666, 38);
            this.panelControl3.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tblAllInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(2, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 248);
            this.tabControl1.TabIndex = 1;
            // 
            // tblAllInfo
            // 
            this.tblAllInfo.Location = new System.Drawing.Point(4, 22);
            this.tblAllInfo.Name = "tblAllInfo";
            this.tblAllInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tblAllInfo.Size = new System.Drawing.Size(658, 222);
            this.tblAllInfo.TabIndex = 1;
            this.tblAllInfo.Text = "tabPage2";
            this.tblAllInfo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CurrentUrl";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.textBox2.Location = new System.Drawing.Point(64, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(598, 31);
            this.textBox2.TabIndex = 6;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(574, 6);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(42, 33);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(622, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(42, 33);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // FrmCrawlerProductByQuerySql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 343);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCrawlerProductByQuerySql";
            this.Text = "CrawlerProduct:Company....";
            this.Load += new System.EventHandler(this.FrmCrawlerProductByQuerySql_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinVisited.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQueue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinWaitRestart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit spinWaitRestart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox spinQueueName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SpinEdit spinQueue;
        private DevExpress.XtraEditors.SpinEdit spinVisited;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.SimpleButton btnRun;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tblAllInfo;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;

    }
}