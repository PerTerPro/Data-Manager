namespace QT.Moduls.Notifycation
{
    partial class FrmNotifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotifications));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNoVisible = new System.Windows.Forms.Button();
            this.btnStartRun = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnManagePush = new System.Windows.Forms.Button();
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
            this.gridControl1.Size = new System.Drawing.Size(699, 424);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMessage,
            this.colProcessed,
            this.colUserName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 41;
            // 
            // colMessage
            // 
            this.colMessage.Caption = "Message";
            this.colMessage.FieldName = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 2;
            this.colMessage.Width = 497;
            // 
            // colProcessed
            // 
            this.colProcessed.Caption = "Processed";
            this.colProcessed.FieldName = "Processed";
            this.colProcessed.Name = "colProcessed";
            this.colProcessed.Visible = true;
            this.colProcessed.VisibleIndex = 1;
            this.colProcessed.Width = 46;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "UserName";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 3;
            this.colUserName.Width = 96;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnManagePush);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnNoVisible);
            this.panel1.Controls.Add(this.btnStartRun);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 30);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "PushMss";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPushMss_Click);
            // 
            // btnNoVisible
            // 
            this.btnNoVisible.Location = new System.Drawing.Point(621, 3);
            this.btnNoVisible.Name = "btnNoVisible";
            this.btnNoVisible.Size = new System.Drawing.Size(75, 23);
            this.btnNoVisible.TabIndex = 3;
            this.btnNoVisible.Text = "ẨN FORM";
            this.btnNoVisible.UseVisualStyleBackColor = true;
            this.btnNoVisible.Click += new System.EventHandler(this.btnNoVisible_Click);
            // 
            // btnStartRun
            // 
            this.btnStartRun.Location = new System.Drawing.Point(165, 4);
            this.btnStartRun.Name = "btnStartRun";
            this.btnStartRun.Size = new System.Drawing.Size(75, 23);
            this.btnStartRun.TabIndex = 2;
            this.btnStartRun.Text = "StartRun";
            this.btnStartRun.UseVisualStyleBackColor = true;
            this.btnStartRun.Click += new System.EventHandler(this.btnStartRun_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 424);
            this.panel2.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnManagePush
            // 
            this.btnManagePush.Location = new System.Drawing.Point(418, 5);
            this.btnManagePush.Name = "btnManagePush";
            this.btnManagePush.Size = new System.Drawing.Size(81, 22);
            this.btnManagePush.TabIndex = 5;
            this.btnManagePush.Text = "ManagePush";
            this.btnManagePush.UseVisualStyleBackColor = true;
            // 
            // FrmNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmNotifications";
            this.Text = "Notification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManagerNotifycation_FormClosing);
            this.Load += new System.EventHandler(this.FrmManagerNotifycation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessed;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private System.Windows.Forms.Button btnStartRun;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Users.DBPhanSPTableAdapters.ProductJobUserTableAdapter productJobUserTableAdapter1;
        private System.Windows.Forms.Button btnNoVisible;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnManagePush;
    }
}