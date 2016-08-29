namespace QT.Moduls.CrawlerProduct
{
    partial class FrmReportCrawler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlReport = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.lblDescription);
            this.panelControl1.Controls.Add(this.comboBox1);
            this.panelControl1.Controls.Add(this.txtCompanyID);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(936, 32);
            this.panelControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(839, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 28);
            this.panel1.TabIndex = 4;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(10, 3);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(5, 32);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(34, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Mô tả";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "prc_Report_CurrentCrawlerFindNew",
            "prc_Report_CurrentCrawlerReload",
            "prc_Report_LastEndCrawlerFindNew",
            "prc_Report_LastEndCrawlerReload",
            "prc_Report_HistoryCrawlerProduct",
            "prc_Report_ProductOfCompany",
            "prc_Report_HistoryCrawlerByCompany",
            "prc_Report_ReloadCrawlerNeedFix",
            "prc_Report_CrawlerForKhachVip",
            "prc_Report_Company_Config_Error",
            "prc_Report_MinLastUpdateProductCrawler"});
            this.comboBox1.Location = new System.Drawing.Point(226, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(5, 5);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(215, 20);
            this.txtCompanyID.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlReport);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 32);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(936, 459);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControlReport
            // 
            this.gridControlReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlReport.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridControlReport.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridControlReport.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControlReport.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControlReport.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gridControlReport.Location = new System.Drawing.Point(2, 2);
            this.gridControlReport.MainView = this.gridView1;
            this.gridControlReport.Name = "gridControlReport";
            this.gridControlReport.Size = new System.Drawing.Size(932, 455);
            this.gridControlReport.TabIndex = 0;
            this.gridControlReport.UseEmbeddedNavigator = true;
            this.gridControlReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlReport;
            this.gridView1.IndicatorWidth = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // FrmReportCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 491);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmReportCrawler";
            this.Text = "Report crawler dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtCompanyID;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControlReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
    }
}