namespace QT.Moduls.Statistics
{
    partial class FrmStatisticsPrice
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
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rtxtCompete = new System.Windows.Forms.RichTextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlProductStatistics = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnView);
            this.panelControl1.Controls.Add(this.lookUpEditCategory);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.rtxtCompete);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1261, 116);
            this.panelControl1.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(457, 37);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 64);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lookUpEditCategory
            // 
            this.lookUpEditCategory.Location = new System.Drawing.Point(457, 5);
            this.lookUpEditCategory.Name = "lookUpEditCategory";
            this.lookUpEditCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCategory.Size = new System.Drawing.Size(214, 20);
            this.lookUpEditCategory.TabIndex = 2;
            this.lookUpEditCategory.EditValueChanged += new System.EventHandler(this.lookUpEditCategory_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Công ty cạnh tranh:";
            // 
            // rtxtCompete
            // 
            this.rtxtCompete.Location = new System.Drawing.Point(107, 5);
            this.rtxtCompete.Name = "rtxtCompete";
            this.rtxtCompete.Size = new System.Drawing.Size(344, 96);
            this.rtxtCompete.TabIndex = 0;
            this.rtxtCompete.Text = "";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnExport);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 646);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1261, 37);
            this.panelControl2.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1174, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControlProductStatistics);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 116);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1261, 530);
            this.panelControl3.TabIndex = 2;
            // 
            // gridControlProductStatistics
            // 
            this.gridControlProductStatistics.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProductStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductStatistics.Location = new System.Drawing.Point(2, 2);
            this.gridControlProductStatistics.MainView = this.gridView1;
            this.gridControlProductStatistics.Name = "gridControlProductStatistics";
            this.gridControlProductStatistics.Size = new System.Drawing.Size(1257, 526);
            this.gridControlProductStatistics.TabIndex = 0;
            this.gridControlProductStatistics.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlProductStatistics;
            this.gridView1.Name = "gridView1";
            this.gridView1.PreviewLineCount = 10;
            this.gridView1.RowHeight = 30;
            // 
            // FrmStatisticsPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 683);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmStatisticsPrice";
            this.Text = "FrmStatisticsPrice";
            this.Load += new System.EventHandler(this.FrmStatisticsPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.RichTextBox rtxtCompete;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCategory;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraGrid.GridControl gridControlProductStatistics;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnExport;

    }
}