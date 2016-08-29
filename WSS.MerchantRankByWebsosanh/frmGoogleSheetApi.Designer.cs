namespace WSS.MerchantRankByWebsosanh
{
    partial class frmGoogleSheetApi
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
            this.rbMessage = new System.Windows.Forms.RichTextBox();
            this.txtRange = new DevExpress.XtraEditors.TextEdit();
            this.txtSpreadsheetId = new DevExpress.XtraEditors.TextEdit();
            this.btnGetGoogleSheet = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnUpdateSQL = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpreadsheetId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnUpdateSQL);
            this.panelControl1.Controls.Add(this.rbMessage);
            this.panelControl1.Controls.Add(this.txtRange);
            this.panelControl1.Controls.Add(this.txtSpreadsheetId);
            this.panelControl1.Controls.Add(this.btnGetGoogleSheet);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1280, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // rbMessage
            // 
            this.rbMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbMessage.Location = new System.Drawing.Point(886, 2);
            this.rbMessage.Name = "rbMessage";
            this.rbMessage.Size = new System.Drawing.Size(392, 96);
            this.rbMessage.TabIndex = 3;
            this.rbMessage.Text = "";
            // 
            // txtRange
            // 
            this.txtRange.EditValue = "Rank_Final";
            this.txtRange.Location = new System.Drawing.Point(12, 38);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(603, 20);
            this.txtRange.TabIndex = 2;
            // 
            // txtSpreadsheetId
            // 
            this.txtSpreadsheetId.EditValue = "1lQEUNj7tvuLxX1ZM27Xq7iDzmwp0KBk9LpyCLa9BBns";
            this.txtSpreadsheetId.Location = new System.Drawing.Point(12, 12);
            this.txtSpreadsheetId.Name = "txtSpreadsheetId";
            this.txtSpreadsheetId.Size = new System.Drawing.Size(603, 20);
            this.txtSpreadsheetId.TabIndex = 1;
            // 
            // btnGetGoogleSheet
            // 
            this.btnGetGoogleSheet.Location = new System.Drawing.Point(632, 12);
            this.btnGetGoogleSheet.Name = "btnGetGoogleSheet";
            this.btnGetGoogleSheet.Size = new System.Drawing.Size(101, 43);
            this.btnGetGoogleSheet.TabIndex = 0;
            this.btnGetGoogleSheet.Text = "Get GoogleSheet";
            this.btnGetGoogleSheet.Click += new System.EventHandler(this.btnGetGoogleSheet_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1280, 497);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1276, 493);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnUpdateSQL
            // 
            this.btnUpdateSQL.Location = new System.Drawing.Point(766, 12);
            this.btnUpdateSQL.Name = "btnUpdateSQL";
            this.btnUpdateSQL.Size = new System.Drawing.Size(101, 43);
            this.btnUpdateSQL.TabIndex = 4;
            this.btnUpdateSQL.Text = "Update SQL";
            this.btnUpdateSQL.Click += new System.EventHandler(this.btnUpdateSQL_Click);
            // 
            // frmTestApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 597);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTestApi";
            this.Text = "frmTestApo";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpreadsheetId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtSpreadsheetId;
        private DevExpress.XtraEditors.SimpleButton btnGetGoogleSheet;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtRange;
        private System.Windows.Forms.RichTextBox rbMessage;
        private DevExpress.XtraEditors.SimpleButton btnUpdateSQL;
    }
}