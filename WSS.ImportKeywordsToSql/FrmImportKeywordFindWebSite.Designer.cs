namespace WSS.ImportKeywordsToSql
{
    partial class FrmImportKeywordFindWebSite
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.grcNewKeyword = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblDone = new System.Windows.Forms.Label();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNewKeyword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel3);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(914, 327);
            this.panelControl1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grcNewKeyword);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(471, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 323);
            this.panel3.TabIndex = 5;
            // 
            // grcNewKeyword
            // 
            this.grcNewKeyword.Cursor = System.Windows.Forms.Cursors.Default;
            this.grcNewKeyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNewKeyword.Location = new System.Drawing.Point(0, 0);
            this.grcNewKeyword.MainView = this.gridView2;
            this.grcNewKeyword.Name = "grcNewKeyword";
            this.grcNewKeyword.Size = new System.Drawing.Size(441, 323);
            this.grcNewKeyword.TabIndex = 2;
            this.grcNewKeyword.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grcNewKeyword;
            this.gridView2.Name = "gridView2";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(422, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 323);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 323);
            this.panel2.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(420, 323);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lblDone);
            this.panelControl2.Controls.Add(this.btnImport);
            this.panelControl2.Controls.Add(this.btnLoad);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 327);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(914, 37);
            this.panelControl2.TabIndex = 1;
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(416, 9);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(0, 13);
            this.lblDone.TabIndex = 3;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(84, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import To SQL";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(471, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load File Excel";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmImportKeywordFindWebSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 364);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmImportKeywordFindWebSite";
            this.Text = "ImportKeywordFindWebSite";
            this.Load += new System.EventHandler(this.FrmImportKeywordFindWebSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcNewKeyword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label lblDone;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl grcNewKeyword;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

