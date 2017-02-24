namespace WSS.ImageImbo.UploadImageToImboServer.Websosanh
{
    partial class FrmDownloadImageWithCompany
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label domainLabel;
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.companyGridControl = new DevExpress.XtraGrid.GridControl();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBWss = new WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWss();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogoImageId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtDomain = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rbSuccess = new System.Windows.Forms.RichTextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.rbListIdFails = new System.Windows.Forms.RichTextBox();
            this.rbFail = new System.Windows.Forms.RichTextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnDownloadImageRootProduct = new DevExpress.XtraEditors.SimpleButton();
            this.domainTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.iDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            this.txtImageUrlsTest = new DevExpress.XtraEditors.TextEdit();
            this.lbFails = new DevExpress.XtraEditors.LabelControl();
            this.lbSuccess = new DevExpress.XtraEditors.LabelControl();
            this.lbCount = new DevExpress.XtraEditors.LabelControl();
            this.checkEditReloadAll = new DevExpress.XtraEditors.CheckEdit();
            this.btnDownload = new DevExpress.XtraEditors.SimpleButton();
            this.tableAdapterManager = new WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWssTableAdapters.TableAdapterManager();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWssTableAdapters.ProductTableAdapter();
            this.companyTableAdapter = new WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWssTableAdapters.CompanyTableAdapter();
            this.splitContainerControl4 = new DevExpress.XtraEditors.SplitContainerControl();
            iDLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBWss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageUrlsTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditReloadAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).BeginInit();
            this.splitContainerControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(5, 27);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(5, 27);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 12;
            iDLabel1.Text = "ID:";
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(197, 27);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 13;
            domainLabel.Text = "Domain:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.companyGridControl);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1202, 603);
            this.splitContainerControl1.SplitterPosition = 345;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // companyGridControl
            // 
            this.companyGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.companyGridControl.DataSource = this.companyBindingSource;
            this.companyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyGridControl.Location = new System.Drawing.Point(0, 62);
            this.companyGridControl.MainView = this.gridView1;
            this.companyGridControl.Name = "companyGridControl";
            this.companyGridControl.Size = new System.Drawing.Size(345, 541);
            this.companyGridControl.TabIndex = 1;
            this.companyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBWss;
            // 
            // dBWss
            // 
            this.dBWss.DataSetName = "DBWss";
            this.dBWss.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colLogoImageId,
            this.colDomain});
            this.gridView1.GridControl = this.companyGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colLogoImageId
            // 
            this.colLogoImageId.FieldName = "LogoImageId";
            this.colLogoImageId.Name = "colLogoImageId";
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtDomain);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(345, 62);
            this.panelControl1.TabIndex = 0;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(12, 25);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(204, 20);
            this.txtDomain.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 62);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(852, 541);
            this.splitContainerControl2.SplitterPosition = 306;
            this.splitContainerControl2.TabIndex = 7;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rbSuccess);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(306, 541);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Download thành công";
            // 
            // rbSuccess
            // 
            this.rbSuccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSuccess.Location = new System.Drawing.Point(2, 21);
            this.rbSuccess.Name = "rbSuccess";
            this.rbSuccess.Size = new System.Drawing.Size(302, 518);
            this.rbSuccess.TabIndex = 0;
            this.rbSuccess.Text = "";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.splitContainerControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(541, 541);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Download Lỗi";
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(2, 21);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.rbListIdFails);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.rbFail);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(537, 518);
            this.splitContainerControl3.SplitterPosition = 167;
            this.splitContainerControl3.TabIndex = 2;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // rbListIdFails
            // 
            this.rbListIdFails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbListIdFails.Location = new System.Drawing.Point(0, 0);
            this.rbListIdFails.Name = "rbListIdFails";
            this.rbListIdFails.Size = new System.Drawing.Size(167, 518);
            this.rbListIdFails.TabIndex = 0;
            this.rbListIdFails.Text = "";
            // 
            // rbFail
            // 
            this.rbFail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbFail.Location = new System.Drawing.Point(0, 0);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(365, 518);
            this.rbFail.TabIndex = 1;
            this.rbFail.Text = "";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.splitContainerControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(852, 62);
            this.panelControl2.TabIndex = 6;
            // 
            // btnDownloadImageRootProduct
            // 
            this.btnDownloadImageRootProduct.Location = new System.Drawing.Point(679, 21);
            this.btnDownloadImageRootProduct.Name = "btnDownloadImageRootProduct";
            this.btnDownloadImageRootProduct.Size = new System.Drawing.Size(101, 23);
            this.btnDownloadImageRootProduct.TabIndex = 15;
            this.btnDownloadImageRootProduct.Text = "Download SP gốc";
            this.btnDownloadImageRootProduct.Click += new System.EventHandler(this.btnDownloadImageRootProduct_Click);
            // 
            // domainTextEdit
            // 
            this.domainTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Domain", true));
            this.domainTextEdit.Location = new System.Drawing.Point(249, 24);
            this.domainTextEdit.Name = "domainTextEdit";
            this.domainTextEdit.Size = new System.Drawing.Size(167, 20);
            this.domainTextEdit.TabIndex = 14;
            // 
            // iDTextEdit
            // 
            this.iDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "ID", true));
            this.iDTextEdit.Location = new System.Drawing.Point(32, 24);
            this.iDTextEdit.Name = "iDTextEdit";
            this.iDTextEdit.Size = new System.Drawing.Size(154, 20);
            this.iDTextEdit.TabIndex = 13;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(285, 27);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(90, 23);
            this.btnTest.TabIndex = 12;
            this.btnTest.Text = "Download Test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtImageUrlsTest
            // 
            this.txtImageUrlsTest.Location = new System.Drawing.Point(8, 30);
            this.txtImageUrlsTest.Name = "txtImageUrlsTest";
            this.txtImageUrlsTest.Size = new System.Drawing.Size(231, 20);
            this.txtImageUrlsTest.TabIndex = 11;
            // 
            // lbFails
            // 
            this.lbFails.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbFails.Location = new System.Drawing.Point(647, 26);
            this.lbFails.Name = "lbFails";
            this.lbFails.Size = new System.Drawing.Size(12, 13);
            this.lbFails.TabIndex = 10;
            this.lbFails.Text = "...";
            // 
            // lbSuccess
            // 
            this.lbSuccess.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbSuccess.Location = new System.Drawing.Point(610, 26);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(12, 13);
            this.lbSuccess.TabIndex = 9;
            this.lbSuccess.Text = "...";
            // 
            // lbCount
            // 
            this.lbCount.Location = new System.Drawing.Point(593, 27);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 13);
            this.lbCount.TabIndex = 8;
            // 
            // checkEditReloadAll
            // 
            this.checkEditReloadAll.Location = new System.Drawing.Point(422, 24);
            this.checkEditReloadAll.Name = "checkEditReloadAll";
            this.checkEditReloadAll.Properties.Caption = "Reload All";
            this.checkEditReloadAll.Size = new System.Drawing.Size(75, 19);
            this.checkEditReloadAll.TabIndex = 7;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(503, 22);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWssTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            this.openFileDialog1.Title = "Chọn ảnh có định dạng png, jpg, jpeg";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBWss;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainerControl4
            // 
            this.splitContainerControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl4.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl4.Name = "splitContainerControl4";
            this.splitContainerControl4.Panel1.Controls.Add(this.domainTextEdit);
            this.splitContainerControl4.Panel1.Controls.Add(this.btnDownloadImageRootProduct);
            this.splitContainerControl4.Panel1.Controls.Add(this.lbFails);
            this.splitContainerControl4.Panel1.Controls.Add(iDLabel);
            this.splitContainerControl4.Panel1.Controls.Add(this.lbSuccess);
            this.splitContainerControl4.Panel1.Controls.Add(domainLabel);
            this.splitContainerControl4.Panel1.Controls.Add(this.btnDownload);
            this.splitContainerControl4.Panel1.Controls.Add(this.checkEditReloadAll);
            this.splitContainerControl4.Panel1.Controls.Add(iDLabel1);
            this.splitContainerControl4.Panel1.Controls.Add(this.lbCount);
            this.splitContainerControl4.Panel1.Controls.Add(this.iDTextEdit);
            this.splitContainerControl4.Panel1.Text = "Panel1";
            this.splitContainerControl4.Panel2.Controls.Add(this.txtImageUrlsTest);
            this.splitContainerControl4.Panel2.Controls.Add(this.btnTest);
            this.splitContainerControl4.Panel2.Text = "Panel2";
            this.splitContainerControl4.Size = new System.Drawing.Size(848, 58);
            this.splitContainerControl4.SplitterPosition = 792;
            this.splitContainerControl4.TabIndex = 16;
            this.splitContainerControl4.Text = "splitContainerControl4";
            // 
            // FrmDownloadImageWithCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 603);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmDownloadImageWithCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDownloadImageWithCompany_FormClosing);
            this.Load += new System.EventHandler(this.FrmUploadLogoWebsosanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBWss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageUrlsTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditReloadAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).EndInit();
            this.splitContainerControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtDomain;
        private DBWss dBWss;
        private DBWssTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rbSuccess;
        private System.Windows.Forms.RichTextBox rbFail;
        private DevExpress.XtraEditors.SimpleButton btnDownload;
        private DevExpress.XtraEditors.CheckEdit checkEditReloadAll;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBWssTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBWssTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DevExpress.XtraGrid.GridControl companyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colLogoImageId;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private System.Windows.Forms.RichTextBox rbListIdFails;
        private DevExpress.XtraEditors.LabelControl lbFails;
        private DevExpress.XtraEditors.LabelControl lbSuccess;
        private DevExpress.XtraEditors.LabelControl lbCount;
        private DevExpress.XtraEditors.TextEdit domainTextEdit;
        private DevExpress.XtraEditors.TextEdit iDTextEdit;
        private DevExpress.XtraEditors.SimpleButton btnTest;
        private DevExpress.XtraEditors.TextEdit txtImageUrlsTest;
        private DevExpress.XtraEditors.SimpleButton btnDownloadImageRootProduct;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl4;
    }
}