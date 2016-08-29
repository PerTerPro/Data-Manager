namespace QT.Moduls.CrawlerProduct
{
    partial class FrmReportReloadTimeNewProduct
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.realTimeSource1 = new DevExpress.Data.RealTimeSource();
            this.prcRealTimeTotalNewProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qT_2DataSetRealTime = new QT.Moduls.QT_2DataSetRealTime();
            this.dB = new QT.Moduls.DB();
            this.dBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prc_RealTime_TotalNewProductTableAdapter = new QT.Moduls.QT_2DataSetRealTimeTableAdapters.prc_RealTime_TotalNewProductTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prcRealTimeTotalNewProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qT_2DataSetRealTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1097, 29);
            this.panelControl1.TabIndex = 1;
            // 
            // realTimeSource1
            // 
            this.realTimeSource1.DataSource = this.prcRealTimeTotalNewProductBindingSource;
            this.realTimeSource1.DisplayableProperties = "ID;Domain;TotalProduct;MaxValid;MinHourRecrawl;TotalValid";
            this.realTimeSource1.UseWeakEventHandler = true;
            // 
            // prcRealTimeTotalNewProductBindingSource
            // 
            this.prcRealTimeTotalNewProductBindingSource.DataMember = "prc_RealTime_TotalNewProduct";
            this.prcRealTimeTotalNewProductBindingSource.DataSource = this.qT_2DataSetRealTime;
            // 
            // qT_2DataSetRealTime
            // 
            this.qT_2DataSetRealTime.DataSetName = "QT_2DataSetRealTime";
            this.qT_2DataSetRealTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.EnforceConstraints = false;
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBBindingSource
            // 
            this.dBBindingSource.DataSource = this.dB;
            this.dBBindingSource.Position = 0;
            // 
            // prc_RealTime_TotalNewProductTableAdapter
            // 
            this.prc_RealTime_TotalNewProductTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Location = new System.Drawing.Point(353, 35);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(380, 254);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "ChangeData";
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 21);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(376, 231);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 35);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(337, 254);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "TotalNewProduct";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(333, 231);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // FrmReportReloadTimeNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 495);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmReportReloadTimeNewProduct";
            this.Text = "FrmReportReloadTimeNewProduct";
            this.Load += new System.EventHandler(this.FrmReportReloadTimeNewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prcRealTimeTotalNewProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qT_2DataSetRealTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Data.RealTimeSource realTimeSource1;
        private System.Windows.Forms.BindingSource dBBindingSource;
        private DB dB;
        private QT_2DataSetRealTime qT_2DataSetRealTime;
        private System.Windows.Forms.BindingSource prcRealTimeTotalNewProductBindingSource;
        private QT_2DataSetRealTimeTableAdapters.prc_RealTime_TotalNewProductTableAdapter prc_RealTime_TotalNewProductTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}