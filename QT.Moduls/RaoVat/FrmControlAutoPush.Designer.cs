namespace QT.Moduls.CrawlSale
{
    partial class FrmControlAutoPush
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
            this.components = new System.ComponentModel.Container();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.queueNameTextBox = new System.Windows.Forms.TextBox();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.ckRedisLastUpdate = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.logPushTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckRedisLastUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.spinEdit1);
            this.panelControl2.Controls.Add(this.btnStop);
            this.panelControl2.Controls.Add(this.btnStart);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.ckRedisLastUpdate);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(610, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(136, 413);
            this.panelControl2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "s";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.textBox1);
            this.panelControl4.Controls.Add(this.simpleButton1);
            this.panelControl4.Controls.Add(this.label2);
            this.panelControl4.Controls.Add(this.queueNameTextBox);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(2, 156);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(132, 158);
            this.panelControl4.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(9, 48);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(120, 29);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Run Imediate";
            this.simpleButton1.Click += new System.EventHandler(this.btnPushTask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "QueueRun";
            // 
            // queueNameTextBox
            // 
            this.queueNameTextBox.Location = new System.Drawing.Point(9, 22);
            this.queueNameTextBox.Name = "queueNameTextBox";
            this.queueNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.queueNameTextBox.TabIndex = 0;
            this.queueNameTextBox.Tag = "crawler_sale_wait";
            this.queueNameTextBox.Text = "crawler_sale_wait";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(11, 133);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(74, 20);
            this.spinEdit1.TabIndex = 5;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 71);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(74, 28);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(74, 28);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "StartAuto";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // panelControl3
            // 
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 314);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(132, 97);
            this.panelControl3.TabIndex = 9;
            // 
            // ckRedisLastUpdate
            // 
            this.ckRedisLastUpdate.Location = new System.Drawing.Point(11, 12);
            this.ckRedisLastUpdate.Name = "ckRedisLastUpdate";
            this.ckRedisLastUpdate.Properties.Caption = "Duyệt lần cuối Redis";
            this.ckRedisLastUpdate.Size = new System.Drawing.Size(120, 19);
            this.ckRedisLastUpdate.TabIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.logPushTextBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(610, 413);
            this.panelControl1.TabIndex = 7;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(606, 202);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // logPushTextBox
            // 
            this.logPushTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logPushTextBox.Location = new System.Drawing.Point(2, 204);
            this.logPushTextBox.Name = "logPushTextBox";
            this.logPushTextBox.Size = new System.Drawing.Size(606, 207);
            this.logPushTextBox.TabIndex = 4;
            this.logPushTextBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "0";
            // 
            // FrmControlAutoPush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 413);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmControlAutoPush";
            this.Text = "FrmPushCrawl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmControlAutoPush_FormClosing);
            this.Load += new System.EventHandler(this.FrmControlAutoPush_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckRedisLastUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RichTextBox logPushTextBox;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckEdit ckRedisLastUpdate;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox queueNameTextBox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}