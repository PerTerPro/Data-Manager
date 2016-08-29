namespace QT.Moduls.CrawlerProduct
{
    partial class FrmKeywordManager
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
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.txtKeywordID = new DevExpress.XtraEditors.TextEdit();
            this.txtKeyword = new DevExpress.XtraEditors.TextEdit();
            this.txtPathEx = new DevExpress.XtraEditors.TextEdit();
            this.lblNotice = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gridControlKeyword = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsiteNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUseToFindWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.openFileDialogExel = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeywordID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPathEx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKeyword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnReload);
            this.panelControl1.Controls.Add(this.txtKeywordID);
            this.panelControl1.Controls.Add(this.txtKeyword);
            this.panelControl1.Controls.Add(this.txtPathEx);
            this.panelControl1.Controls.Add(this.lblNotice);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnLoad);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(614, 65);
            this.panelControl1.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(517, 36);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(83, 23);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Load Keyword";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtKeywordID
            // 
            this.txtKeywordID.Location = new System.Drawing.Point(67, 79);
            this.txtKeywordID.Name = "txtKeywordID";
            this.txtKeywordID.Size = new System.Drawing.Size(266, 20);
            this.txtKeywordID.TabIndex = 12;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(67, 38);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(266, 20);
            this.txtKeyword.TabIndex = 11;
            this.txtKeyword.EditValueChanged += new System.EventHandler(this.txtKeyword_EditValueChanged);
            // 
            // txtPathEx
            // 
            this.txtPathEx.Location = new System.Drawing.Point(67, 12);
            this.txtPathEx.Name = "txtPathEx";
            this.txtPathEx.Size = new System.Drawing.Size(266, 20);
            this.txtPathEx.TabIndex = 10;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Location = new System.Drawing.Point(428, 15);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(0, 13);
            this.lblNotice.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(428, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(339, 36);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Keyword";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(339, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(83, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load Ex";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "KeyID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Keyword:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Exel:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.gridControlKeyword);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 65);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(614, 580);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.richTextBox1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 311);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(610, 267);
            this.panelControl3.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(606, 263);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // gridControlKeyword
            // 
            this.gridControlKeyword.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlKeyword.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlKeyword.Location = new System.Drawing.Point(2, 2);
            this.gridControlKeyword.MainView = this.gridView1;
            this.gridControlKeyword.Name = "gridControlKeyword";
            this.gridControlKeyword.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControlKeyword.Size = new System.Drawing.Size(610, 309);
            this.gridControlKeyword.TabIndex = 0;
            this.gridControlKeyword.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlKeyword.Click += new System.EventHandler(this.gridControlKeyword_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colKeyword,
            this.colWebsiteNumber,
            this.colInsertDate,
            this.colLastUseToFindWebsite});
            this.gridView1.GridControl = this.gridControlKeyword;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colKeyword
            // 
            this.colKeyword.Caption = "Keyword";
            this.colKeyword.FieldName = "Keyword";
            this.colKeyword.Name = "colKeyword";
            this.colKeyword.Visible = true;
            this.colKeyword.VisibleIndex = 1;
            // 
            // colWebsiteNumber
            // 
            this.colWebsiteNumber.Caption = "WebsiteNumber";
            this.colWebsiteNumber.FieldName = "WebsiteNumber";
            this.colWebsiteNumber.Name = "colWebsiteNumber";
            this.colWebsiteNumber.Visible = true;
            this.colWebsiteNumber.VisibleIndex = 2;
            // 
            // colInsertDate
            // 
            this.colInsertDate.Caption = "InsertDate";
            this.colInsertDate.DisplayFormat.FormatString = "d";
            this.colInsertDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colInsertDate.FieldName = "InsertDate";
            this.colInsertDate.Name = "colInsertDate";
            this.colInsertDate.Visible = true;
            this.colInsertDate.VisibleIndex = 3;
            // 
            // colLastUseToFindWebsite
            // 
            this.colLastUseToFindWebsite.Caption = "LastUseToFindWebsite";
            this.colLastUseToFindWebsite.DisplayFormat.FormatString = "d";
            this.colLastUseToFindWebsite.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUseToFindWebsite.FieldName = "LastUseToFindWebsite";
            this.colLastUseToFindWebsite.Name = "colLastUseToFindWebsite";
            this.colLastUseToFindWebsite.Visible = true;
            this.colLastUseToFindWebsite.VisibleIndex = 4;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n0";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // openFileDialogExel
            // 
            this.openFileDialogExel.FileName = "openFileDialog1";
            // 
            // FrmKeywordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 645);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmKeywordManager";
            this.Text = "FrmKeywordManager";
            this.Load += new System.EventHandler(this.FrmKeywordManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeywordID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPathEx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKeyword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControlKeyword;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyword;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsiteNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUseToFindWebsite;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialogExel;
        private System.Windows.Forms.Label lblNotice;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.TextEdit txtKeywordID;
        private DevExpress.XtraEditors.TextEdit txtKeyword;
        private DevExpress.XtraEditors.TextEdit txtPathEx;
        private DevExpress.XtraEditors.SimpleButton btnReload;
    }
}