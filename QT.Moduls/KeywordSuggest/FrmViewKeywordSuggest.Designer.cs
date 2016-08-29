namespace QT.Moduls.KeywordSuggest
{
    partial class FrmViewKeywordSuggest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewKeywordSuggest));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImportKeyword = new System.Windows.Forms.ToolStripButton();
            this.btnNumberMss = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteKeywordFinded = new System.Windows.Forms.ToolStripButton();
            this.btnViewChar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportKeyword,
            this.btnNumberMss,
            this.btnRefresh,
            this.btnDeleteKeywordFinded,
            this.btnViewChar,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1265, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnImportKeyword
            // 
            this.btnImportKeyword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportKeyword.Name = "btnImportKeyword";
            this.btnImportKeyword.Size = new System.Drawing.Size(93, 22);
            this.btnImportKeyword.Text = "ImportKeyword";
            this.btnImportKeyword.Click += new System.EventHandler(this.btnImportKeyword_Click);
            // 
            // btnNumberMss
            // 
            this.btnNumberMss.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNumberMss.Name = "btnNumberMss";
            this.btnNumberMss.Size = new System.Drawing.Size(76, 22);
            this.btnNumberMss.Text = "NumberMss";
            this.btnNumberMss.Click += new System.EventHandler(this.btnNumberMss_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteKeywordFinded
            // 
            this.btnDeleteKeywordFinded.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteKeywordFinded.Name = "btnDeleteKeywordFinded";
            this.btnDeleteKeywordFinded.Size = new System.Drawing.Size(132, 22);
            this.btnDeleteKeywordFinded.Text = "Delete Keyword Finded";
            this.btnDeleteKeywordFinded.Click += new System.EventHandler(this.btnDeleteKeywordFinded_Click);
            // 
            // btnViewChar
            // 
            this.btnViewChar.Image = ((System.Drawing.Image)(resources.GetObject("btnViewChar.Image")));
            this.btnViewChar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewChar.Name = "btnViewChar";
            this.btnViewChar.Size = new System.Drawing.Size(81, 22);
            this.btnViewChar.Text = "ViewChart";
            this.btnViewChar.Click += new System.EventHandler(this.btnViewChar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.MediumAquamarine;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(137, 22);
            this.toolStripButton1.Text = "View History Volume";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1265, 708);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // FrmViewKeywordSuggest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 733);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmViewKeywordSuggest";
            this.Text = "FrmViewKeywordSuggest";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripButton btnImportKeyword;
        private System.Windows.Forms.ToolStripButton btnNumberMss;
        private System.Windows.Forms.ToolStripButton btnDeleteKeywordFinded;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyword;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdateVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colKeywordSource;
        private System.Windows.Forms.ToolStripButton btnViewChar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}