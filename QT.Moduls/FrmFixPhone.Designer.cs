namespace QT.Moduls
{
    partial class FrmFixPhone
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportExcell = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneInCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneInCompanyAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuccess = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportExcell);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 31);
            this.panel1.TabIndex = 0;
            // 
            // btnExportExcell
            // 
            this.btnExportExcell.Location = new System.Drawing.Point(165, 3);
            this.btnExportExcell.Name = "btnExportExcell";
            this.btnExportExcell.Size = new System.Drawing.Size(75, 23);
            this.btnExportExcell.TabIndex = 2;
            this.btnExportExcell.Text = "ExportExcell";
            this.btnExportExcell.UseVisualStyleBackColor = true;
            this.btnExportExcell.Click += new System.EventHandler(this.btnExportExcell_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(84, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Duyệt lỗi sđt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1241, 712);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colWebsite,
            this.colPhoneInCompany,
            this.colPhoneInCompanyAddress,
            this.colDomain,
            this.colSuccess,
            this.colTotalProduct});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 88;
            // 
            // colWebsite
            // 
            this.colWebsite.Caption = "Website";
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 1;
            this.colWebsite.Width = 138;
            // 
            // colPhoneInCompany
            // 
            this.colPhoneInCompany.Caption = "PhoneInCompany";
            this.colPhoneInCompany.FieldName = "PhoneInCompany";
            this.colPhoneInCompany.Name = "colPhoneInCompany";
            this.colPhoneInCompany.Visible = true;
            this.colPhoneInCompany.VisibleIndex = 3;
            this.colPhoneInCompany.Width = 404;
            // 
            // colPhoneInCompanyAddress
            // 
            this.colPhoneInCompanyAddress.Caption = "PhoneInCompanyAddress";
            this.colPhoneInCompanyAddress.FieldName = "PhoneInCompanyAddress";
            this.colPhoneInCompanyAddress.Name = "colPhoneInCompanyAddress";
            this.colPhoneInCompanyAddress.Visible = true;
            this.colPhoneInCompanyAddress.VisibleIndex = 4;
            this.colPhoneInCompanyAddress.Width = 326;
            // 
            // colDomain
            // 
            this.colDomain.Caption = "Domain";
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 2;
            this.colDomain.Width = 169;
            // 
            // colSuccess
            // 
            this.colSuccess.Caption = "Success";
            this.colSuccess.FieldName = "Success";
            this.colSuccess.Name = "colSuccess";
            this.colSuccess.Visible = true;
            this.colSuccess.VisibleIndex = 6;
            this.colSuccess.Width = 20;
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.Caption = "TotalProduct";
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 5;
            this.colTotalProduct.Width = 77;
            // 
            // FrmFixPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 743);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFixPhone";
            this.Text = "Duyệt số điện thoại lỗi";
            this.Load += new System.EventHandler(this.FrmFixPhone_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneInCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneInCompanyAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn colSuccess;
        private System.Windows.Forms.Button btnExportExcell;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
    }
}