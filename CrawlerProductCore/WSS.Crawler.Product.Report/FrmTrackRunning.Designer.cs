namespace WSS.Crawler.Product.Report
{
    partial class FrmTrackRunning
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSession = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThread = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeReport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMachineCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.ckStop = new System.Windows.Forms.CheckBox();
            this.btnResetOld = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1276, 703);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyId,
            this.colSession,
            this.colIp,
            this.colThread,
            this.colType,
            this.colStartAt,
            this.colTimeReport,
            this.colMachineCode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // colCompanyId
            // 
            this.colCompanyId.Caption = "CompanyId";
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.Visible = true;
            this.colCompanyId.VisibleIndex = 1;
            this.colCompanyId.Width = 105;
            // 
            // colSession
            // 
            this.colSession.Caption = "Session";
            this.colSession.FieldName = "Session";
            this.colSession.Name = "colSession";
            this.colSession.Visible = true;
            this.colSession.VisibleIndex = 2;
            this.colSession.Width = 85;
            // 
            // colIp
            // 
            this.colIp.Caption = "Ip";
            this.colIp.FieldName = "Ip";
            this.colIp.Name = "colIp";
            this.colIp.Visible = true;
            this.colIp.VisibleIndex = 3;
            this.colIp.Width = 149;
            // 
            // colThread
            // 
            this.colThread.Caption = "Thread";
            this.colThread.FieldName = "Thread";
            this.colThread.Name = "colThread";
            this.colThread.Visible = true;
            this.colThread.VisibleIndex = 4;
            this.colThread.Width = 481;
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 5;
            this.colType.Width = 274;
            // 
            // colStartAt
            // 
            this.colStartAt.Caption = "StartAt";
            this.colStartAt.DisplayFormat.FormatString = "yy-MM-dd HH:mm";
            this.colStartAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartAt.FieldName = "StartAt";
            this.colStartAt.Name = "colStartAt";
            this.colStartAt.Visible = true;
            this.colStartAt.VisibleIndex = 6;
            this.colStartAt.Width = 90;
            // 
            // colTimeReport
            // 
            this.colTimeReport.Caption = "TimeReport";
            this.colTimeReport.DisplayFormat.FormatString = "yy-MM-dd HH:mm";
            this.colTimeReport.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTimeReport.FieldName = "TimeReport";
            this.colTimeReport.Name = "colTimeReport";
            this.colTimeReport.Visible = true;
            this.colTimeReport.VisibleIndex = 0;
            this.colTimeReport.Width = 90;
            // 
            // colMachineCode
            // 
            this.colMachineCode.Caption = "MachineCode";
            this.colMachineCode.FieldName = "MachineCode";
            this.colMachineCode.Name = "colMachineCode";
            this.colMachineCode.Visible = true;
            this.colMachineCode.VisibleIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.ckStop);
            this.panel1.Controls.Add(this.btnResetOld);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 38);
            this.panel1.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(171, 7);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(300, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // ckStop
            // 
            this.ckStop.AutoSize = true;
            this.ckStop.Location = new System.Drawing.Point(93, 9);
            this.ckStop.Name = "ckStop";
            this.ckStop.Size = new System.Drawing.Size(72, 17);
            this.ckStop.TabIndex = 1;
            this.ckStop.Text = "StopLoad";
            this.ckStop.UseVisualStyleBackColor = true;
            this.ckStop.CheckedChanged += new System.EventHandler(this.ckStop_CheckedChanged);
            // 
            // btnResetOld
            // 
            this.btnResetOld.Location = new System.Drawing.Point(10, 7);
            this.btnResetOld.Name = "btnResetOld";
            this.btnResetOld.Size = new System.Drawing.Size(75, 23);
            this.btnResetOld.TabIndex = 0;
            this.btnResetOld.Text = "DelOld";
            this.btnResetOld.UseVisualStyleBackColor = true;
            this.btnResetOld.Click += new System.EventHandler(this.btnResetOld_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 703);
            this.panel2.TabIndex = 2;
            // 
            // FrmTrackRunning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTrackRunning";
            this.Text = "FrmTrackRunning";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTrackRunning_FormClosing);
            this.Load += new System.EventHandler(this.FrmTrackRunning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colSession;
        private DevExpress.XtraGrid.Columns.GridColumn colIp;
        private DevExpress.XtraGrid.Columns.GridColumn colThread;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colStartAt;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetOld;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colMachineCode;
        private System.Windows.Forms.CheckBox ckStop;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}