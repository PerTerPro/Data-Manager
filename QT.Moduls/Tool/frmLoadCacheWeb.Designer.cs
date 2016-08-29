namespace QT.Moduls.Tool
{
    partial class frmLoadCacheWeb
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btLoadSoSanh = new DevExpress.XtraEditors.SimpleButton();
            this.txtDelay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.uRLCacheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTool3 = new QT.Moduls.Tool.DBTool3();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.laTong = new System.Windows.Forms.Label();
            this.chkWebsosanh = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRLCacheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Load Cat";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(93, 12);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 0;
            this.btSearch.Text = "Load Search";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btLoadSoSanh
            // 
            this.btLoadSoSanh.Location = new System.Drawing.Point(174, 12);
            this.btLoadSoSanh.Name = "btLoadSoSanh";
            this.btLoadSoSanh.Size = new System.Drawing.Size(75, 23);
            this.btLoadSoSanh.TabIndex = 0;
            this.btLoadSoSanh.Text = "Load So sánh";
            this.btLoadSoSanh.Click += new System.EventHandler(this.btLoadSoSanh_Click);
            // 
            // txtDelay
            // 
            this.txtDelay.EditValue = "1000";
            this.txtDelay.Location = new System.Drawing.Point(287, 15);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(59, 20);
            this.txtDelay.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(255, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "delay";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(12, 41);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 0;
            this.simpleButton4.Text = "Start";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(93, 41);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 0;
            this.simpleButton5.Text = "Stop";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.uRLCacheBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 70);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(970, 611);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // uRLCacheBindingSource
            // 
            this.uRLCacheBindingSource.DataMember = "URLCache";
            this.uRLCacheBindingSource.DataSource = this.dBTool3;
            // 
            // dBTool3
            // 
            this.dBTool3.DataSetName = "DBTool3";
            this.dBTool3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKey,
            this.colCount,
            this.colUrl});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colKey
            // 
            this.colKey.FieldName = "Key";
            this.colKey.Name = "colKey";
            this.colKey.OptionsColumn.FixedWidth = true;
            this.colKey.Visible = true;
            this.colKey.VisibleIndex = 0;
            this.colKey.Width = 89;
            // 
            // colCount
            // 
            this.colCount.DisplayFormat.FormatString = "n0";
            this.colCount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.OptionsColumn.FixedWidth = true;
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 1;
            // 
            // colUrl
            // 
            this.colUrl.FieldName = "Url";
            this.colUrl.Name = "colUrl";
            this.colUrl.Visible = true;
            this.colUrl.VisibleIndex = 2;
            this.colUrl.Width = 785;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(174, 41);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 23);
            this.simpleButton6.TabIndex = 0;
            this.simpleButton6.Text = "Nạp";
            // 
            // laTong
            // 
            this.laTong.Location = new System.Drawing.Point(389, 7);
            this.laTong.Name = "laTong";
            this.laTong.Size = new System.Drawing.Size(593, 57);
            this.laTong.TabIndex = 4;
            this.laTong.Text = "label1";
            // 
            // chkWebsosanh
            // 
            this.chkWebsosanh.AutoSize = true;
            this.chkWebsosanh.Location = new System.Drawing.Point(255, 47);
            this.chkWebsosanh.Name = "chkWebsosanh";
            this.chkWebsosanh.Size = new System.Drawing.Size(155, 17);
            this.chkWebsosanh.TabIndex = 5;
            this.chkWebsosanh.Text = "Load cache.websosanh.vn";
            this.chkWebsosanh.UseVisualStyleBackColor = true;
            // 
            // frmLoadCacheWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(994, 693);
            this.Controls.Add(this.chkWebsosanh);
            this.Controls.Add(this.laTong);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.btLoadSoSanh);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmLoadCacheWeb";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoadCacheWeb_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRLCacheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btSearch;
        private DevExpress.XtraEditors.SimpleButton btLoadSoSanh;
        private DevExpress.XtraEditors.TextEdit txtDelay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource uRLCacheBindingSource;
        private DBTool3 dBTool3;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private System.Windows.Forms.Label laTong;
        private System.Windows.Forms.CheckBox chkWebsosanh;
        private DevExpress.XtraGrid.Columns.GridColumn colUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colKey;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
    }
}
