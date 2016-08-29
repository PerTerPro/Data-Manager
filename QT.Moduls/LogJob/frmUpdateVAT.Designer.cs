namespace QT.Moduls.LogJob
{
    partial class frmUpdateVAT
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dBLogJob = new QT.Moduls.LogJob.DBLogJob();
            this.companyVATStatusBindingSource = new System.Windows.Forms.BindingSource();
            this.companyVATStatusTableAdapter = new QT.Moduls.LogJob.DBLogJobTableAdapters.CompanyVATStatusTableAdapter();
            this.tableAdapterManager = new QT.Moduls.LogJob.DBLogJobTableAdapters.TableAdapterManager();
            this.companyVATStatusGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.configurationBindingSource = new System.Windows.Forms.BindingSource();
            this.configurationTableAdapter = new QT.Moduls.LogJob.DBLogJobTableAdapters.ConfigurationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBLogJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyVATStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyVATStatusGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1166, 101);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.companyVATStatusGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 101);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1166, 475);
            this.panelControl2.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(147, 48);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(695, 48);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dBLogJob
            // 
            this.dBLogJob.DataSetName = "DBLogJob";
            this.dBLogJob.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyVATStatusBindingSource
            // 
            this.companyVATStatusBindingSource.DataMember = "CompanyVATStatus";
            this.companyVATStatusBindingSource.DataSource = this.dBLogJob;
            // 
            // companyVATStatusTableAdapter
            // 
            this.companyVATStatusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyVATStatusTableAdapter = this.companyVATStatusTableAdapter;
            this.tableAdapterManager.ConfigurationTableAdapter = this.configurationTableAdapter;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.LogJobTableAdapter = null;
            this.tableAdapterManager.tblUserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.LogJob.DBLogJobTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companyVATStatusGridControl
            // 
            this.companyVATStatusGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.companyVATStatusGridControl.DataSource = this.companyVATStatusBindingSource;
            this.companyVATStatusGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyVATStatusGridControl.Location = new System.Drawing.Point(2, 2);
            this.companyVATStatusGridControl.MainView = this.gridView1;
            this.companyVATStatusGridControl.Name = "companyVATStatusGridControl";
            this.companyVATStatusGridControl.Size = new System.Drawing.Size(1162, 471);
            this.companyVATStatusGridControl.TabIndex = 0;
            this.companyVATStatusGridControl.UseEmbeddedNavigator = true;
            this.companyVATStatusGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.companyVATStatusGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // configurationBindingSource
            // 
            this.configurationBindingSource.DataMember = "Configuration";
            this.configurationBindingSource.DataSource = this.dBLogJob;
            // 
            // configurationTableAdapter
            // 
            this.configurationTableAdapter.ClearBeforeFill = true;
            // 
            // frmUpdateVAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 576);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmUpdateVAT";
            this.Text = "frmUpdateVAT";
            this.Load += new System.EventHandler(this.frmUpdateVAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBLogJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyVATStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyVATStatusGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DBLogJob dBLogJob;
        private System.Windows.Forms.BindingSource companyVATStatusBindingSource;
        private DBLogJobTableAdapters.CompanyVATStatusTableAdapter companyVATStatusTableAdapter;
        private DBLogJobTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl companyVATStatusGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DBLogJobTableAdapters.ConfigurationTableAdapter configurationTableAdapter;
        private System.Windows.Forms.BindingSource configurationBindingSource;
    }
}