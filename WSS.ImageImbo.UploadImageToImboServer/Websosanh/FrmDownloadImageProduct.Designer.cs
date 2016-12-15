namespace WSS.ImageImbo.UploadImageToImboServer.Websosanh
{
    partial class FrmDownloadImageProduct
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
            System.Windows.Forms.Label imageUrlsLabel;
            System.Windows.Forms.Label imageIdLabel;
            System.Windows.Forms.Label iDLabel;
            this.productTableAdapter = new WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWssTableAdapters.ProductTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableAdapterManager = new WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWssTableAdapters.TableAdapterManager();
            this.companyTableAdapter = new WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWssTableAdapters.CompanyTableAdapter();
            this.dBWss = new WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWss();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.idCheck = new DevExpress.XtraEditors.TextEdit();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imageUrlsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.imageIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.rbMessage = new System.Windows.Forms.RichTextBox();
            this.btnDownloadByLink = new DevExpress.XtraEditors.SimpleButton();
            this.btnChooseFile = new DevExpress.XtraEditors.SimpleButton();
            this.iDTextEdit = new DevExpress.XtraEditors.TextEdit();
            imageUrlsLabel = new System.Windows.Forms.Label();
            imageIdLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBWss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrlsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            this.openFileDialog1.Title = "Chọn ảnh có định dạng png, jpg, jpeg";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWssTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // dBWss
            // 
            this.dBWss.DataSetName = "DBWss";
            this.dBWss.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBWss;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(iDLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.iDTextEdit);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnChooseFile);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnDownloadByLink);
            this.splitContainerControl1.Panel1.Controls.Add(imageUrlsLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.imageUrlsTextEdit);
            this.splitContainerControl1.Panel1.Controls.Add(imageIdLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.imageIdTextEdit);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.rbMessage);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(689, 603);
            this.splitContainerControl1.SplitterPosition = 332;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.idCheck);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(332, 71);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(217, 29);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Check ID";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // idCheck
            // 
            this.idCheck.Location = new System.Drawing.Point(12, 31);
            this.idCheck.Name = "idCheck";
            this.idCheck.Size = new System.Drawing.Size(189, 20);
            this.idCheck.TabIndex = 1;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.dBWss;
            // 
            // imageUrlsLabel
            // 
            imageUrlsLabel.AutoSize = true;
            imageUrlsLabel.Location = new System.Drawing.Point(13, 155);
            imageUrlsLabel.Name = "imageUrlsLabel";
            imageUrlsLabel.Size = new System.Drawing.Size(60, 13);
            imageUrlsLabel.TabIndex = 3;
            imageUrlsLabel.Text = "Image Urls:";
            // 
            // imageUrlsTextEdit
            // 
            this.imageUrlsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource1, "ImageUrls", true));
            this.imageUrlsTextEdit.Location = new System.Drawing.Point(79, 152);
            this.imageUrlsTextEdit.Name = "imageUrlsTextEdit";
            this.imageUrlsTextEdit.Size = new System.Drawing.Size(228, 20);
            this.imageUrlsTextEdit.TabIndex = 4;
            // 
            // imageIdLabel
            // 
            imageIdLabel.AutoSize = true;
            imageIdLabel.Location = new System.Drawing.Point(13, 120);
            imageIdLabel.Name = "imageIdLabel";
            imageIdLabel.Size = new System.Drawing.Size(51, 13);
            imageIdLabel.TabIndex = 5;
            imageIdLabel.Text = "Image Id:";
            // 
            // imageIdTextEdit
            // 
            this.imageIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource1, "ImageId", true));
            this.imageIdTextEdit.Location = new System.Drawing.Point(79, 117);
            this.imageIdTextEdit.Name = "imageIdTextEdit";
            this.imageIdTextEdit.Size = new System.Drawing.Size(228, 20);
            this.imageIdTextEdit.TabIndex = 6;
            // 
            // rbMessage
            // 
            this.rbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbMessage.Location = new System.Drawing.Point(0, 0);
            this.rbMessage.Name = "rbMessage";
            this.rbMessage.Size = new System.Drawing.Size(352, 603);
            this.rbMessage.TabIndex = 0;
            this.rbMessage.Text = "";
            // 
            // btnDownloadByLink
            // 
            this.btnDownloadByLink.Location = new System.Drawing.Point(79, 184);
            this.btnDownloadByLink.Name = "btnDownloadByLink";
            this.btnDownloadByLink.Size = new System.Drawing.Size(122, 23);
            this.btnDownloadByLink.TabIndex = 7;
            this.btnDownloadByLink.Text = "Download By Link";
            this.btnDownloadByLink.Click += new System.EventHandler(this.btnDownloadByLink_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(79, 231);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(122, 29);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Upload = File";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(13, 84);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 7;
            iDLabel.Text = "ID:";
            // 
            // iDTextEdit
            // 
            this.iDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource1, "ID", true));
            this.iDTextEdit.Location = new System.Drawing.Point(79, 81);
            this.iDTextEdit.Name = "iDTextEdit";
            this.iDTextEdit.Size = new System.Drawing.Size(228, 20);
            this.iDTextEdit.TabIndex = 8;
            // 
            // FrmDownloadImageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 603);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmDownloadImageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmUploadLogoWebsosanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBWss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.idCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrlsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DBWssTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DBWssTableAdapters.TableAdapterManager tableAdapterManager;
        private DBWssTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DBWss dBWss;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit imageUrlsTextEdit;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private DevExpress.XtraEditors.TextEdit imageIdTextEdit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit idCheck;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox rbMessage;
        private DevExpress.XtraEditors.SimpleButton btnChooseFile;
        private DevExpress.XtraEditors.SimpleButton btnDownloadByLink;
        private DevExpress.XtraEditors.TextEdit iDTextEdit;
    }
}