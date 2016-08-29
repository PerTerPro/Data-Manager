namespace QT.Moduls.Notifycation
{
    partial class FrmPushNotifycation
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnPushMss = new System.Windows.Forms.Button();
            this.txtRountingKey = new System.Windows.Forms.TextBox();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.notification_PushBindingSource = new System.Windows.Forms.BindingSource();
            this.dBNotification = new QT.Moduls.Notifycation.DBNotification();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notification_PushTableAdapter = new QT.Moduls.Notifycation.DBNotificationTableAdapters.Notification_PushTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Notifycation.DBNotificationTableAdapters.TableAdapterManager();
            this.notification_PushGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoutingKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.notification_PushBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notification_PushGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(58, 12);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(343, 20);
            this.txtMessage.TabIndex = 1;
            // 
            // btnPushMss
            // 
            this.btnPushMss.Location = new System.Drawing.Point(318, 88);
            this.btnPushMss.Name = "btnPushMss";
            this.btnPushMss.Size = new System.Drawing.Size(75, 46);
            this.btnPushMss.TabIndex = 2;
            this.btnPushMss.Text = "Push Notify";
            this.btnPushMss.UseVisualStyleBackColor = true;
            this.btnPushMss.Click += new System.EventHandler(this.btnPushMss_Click);
            // 
            // txtRountingKey
            // 
            this.txtRountingKey.Enabled = false;
            this.txtRountingKey.Location = new System.Drawing.Point(12, 88);
            this.txtRountingKey.Name = "txtRountingKey";
            this.txtRountingKey.Size = new System.Drawing.Size(208, 20);
            this.txtRountingKey.TabIndex = 3;
            this.txtRountingKey.Text = "Notification.Code.Manh";
            // 
            // txtExchange
            // 
            this.txtExchange.Enabled = false;
            this.txtExchange.Location = new System.Drawing.Point(12, 114);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Size = new System.Drawing.Size(208, 20);
            this.txtExchange.TabIndex = 4;
            this.txtExchange.Text = "Notification.Code";
            this.txtExchange.TextChanged += new System.EventHandler(this.txtExchange_TextChanged);
            // 
            // notification_PushBindingSource
            // 
            this.notification_PushBindingSource.DataMember = "Notification_Push";
            this.notification_PushBindingSource.DataSource = this.dBNotification;
            // 
            // dBNotification
            // 
            this.dBNotification.DataSetName = "DBNotification";
            this.dBNotification.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MSS";
            // 
            // notification_PushTableAdapter
            // 
            this.notification_PushTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Notification_PushTableAdapter = this.notification_PushTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Notifycation.DBNotificationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notification_PushGridControl
            // 
            this.notification_PushGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.notification_PushGridControl.DataSource = this.notification_PushBindingSource;
            this.notification_PushGridControl.Location = new System.Drawing.Point(40, 219);
            this.notification_PushGridControl.MainView = this.gridView1;
            this.notification_PushGridControl.Name = "notification_PushGridControl";
            this.notification_PushGridControl.Size = new System.Drawing.Size(300, 220);
            this.notification_PushGridControl.TabIndex = 8;
            this.notification_PushGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colExchange,
            this.colRoutingKey});
            this.gridView1.GridControl = this.notification_PushGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notification_PushBindingSource, "Name", true));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(58, 60);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(343, 21);
            this.nameComboBox.TabIndex = 11;
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colExchange
            // 
            this.colExchange.FieldName = "Exchange";
            this.colExchange.Name = "colExchange";
            this.colExchange.Visible = true;
            this.colExchange.VisibleIndex = 2;
            // 
            // colRoutingKey
            // 
            this.colRoutingKey.FieldName = "RoutingKey";
            this.colRoutingKey.Name = "colRoutingKey";
            this.colRoutingKey.Visible = true;
            this.colRoutingKey.VisibleIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "FROM";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(58, 36);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(343, 20);
            this.txtFrom.TabIndex = 13;
            // 
            // FrmPushNotifycation
            // 
            this.AcceptButton = this.btnPushMss;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 140);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.notification_PushGridControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExchange);
            this.Controls.Add(this.txtRountingKey);
            this.Controls.Add(this.btnPushMss);
            this.Controls.Add(this.txtMessage);
            this.Name = "FrmPushNotifycation";
            this.Text = "FrmPushNotifycation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPushNotifycation_FormClosing);
            this.Load += new System.EventHandler(this.FrmPushNotifycation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notification_PushBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notification_PushGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnPushMss;
        private System.Windows.Forms.TextBox txtRountingKey;
        private System.Windows.Forms.TextBox txtExchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DBNotification dBNotification;
        private System.Windows.Forms.BindingSource notification_PushBindingSource;
        private DBNotificationTableAdapters.Notification_PushTableAdapter notification_PushTableAdapter;
        private DBNotificationTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl notification_PushGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox nameComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colExchange;
        private DevExpress.XtraGrid.Columns.GridColumn colRoutingKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrom;
    }
}