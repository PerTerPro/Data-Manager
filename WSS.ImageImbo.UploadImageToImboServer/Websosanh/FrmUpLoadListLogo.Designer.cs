namespace WSS.ImageImbo.UploadImageToImboServer.Websosanh
{
    partial class FrmUpLoadListLogo
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
            this.lbFail = new System.Windows.Forms.Label();
            this.lbSuccess = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnChooseFile = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.rbSuccess = new System.Windows.Forms.RichTextBox();
            this.rbFail = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dBWss = new WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWss();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWssTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager = new WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWssTableAdapters.TableAdapterManager();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.rbError = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBWss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbFail);
            this.panelControl1.Controls.Add(this.lbSuccess);
            this.panelControl1.Controls.Add(this.lbCount);
            this.panelControl1.Controls.Add(this.btnChooseFile);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1017, 66);
            this.panelControl1.TabIndex = 0;
            // 
            // lbFail
            // 
            this.lbFail.AutoSize = true;
            this.lbFail.ForeColor = System.Drawing.Color.Red;
            this.lbFail.Location = new System.Drawing.Point(363, 30);
            this.lbFail.Name = "lbFail";
            this.lbFail.Size = new System.Drawing.Size(16, 13);
            this.lbFail.TabIndex = 3;
            this.lbFail.Text = "...";
            // 
            // lbSuccess
            // 
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.ForeColor = System.Drawing.Color.Blue;
            this.lbSuccess.Location = new System.Drawing.Point(227, 30);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(16, 13);
            this.lbSuccess.TabIndex = 2;
            this.lbSuccess.Text = "...";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(113, 30);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(16, 13);
            this.lbCount.TabIndex = 1;
            this.lbCount.Text = "...";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(12, 25);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Chọn file";
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 66);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.rbSuccess);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1017, 559);
            this.splitContainerControl1.SplitterPosition = 294;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // rbSuccess
            // 
            this.rbSuccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbSuccess.Location = new System.Drawing.Point(0, 0);
            this.rbSuccess.Name = "rbSuccess";
            this.rbSuccess.Size = new System.Drawing.Size(294, 559);
            this.rbSuccess.TabIndex = 1;
            this.rbSuccess.Text = "";
            // 
            // rbFail
            // 
            this.rbFail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbFail.Location = new System.Drawing.Point(0, 0);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(317, 559);
            this.rbFail.TabIndex = 0;
            this.rbFail.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Chọn ảnh có định dạng png, jpg, jpeg";
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
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.UpdateOrder = WSS.ImageImbo.UploadImageToImboServer.Websosanh.DBWssTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.rbFail);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.rbError);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(718, 559);
            this.splitContainerControl2.SplitterPosition = 317;
            this.splitContainerControl2.TabIndex = 1;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // rbError
            // 
            this.rbError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbError.Location = new System.Drawing.Point(0, 0);
            this.rbError.Name = "rbError";
            this.rbError.Size = new System.Drawing.Size(396, 559);
            this.rbError.TabIndex = 0;
            this.rbError.Text = "";
            // 
            // FrmUpLoadListLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 625);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmUpLoadListLogo";
            this.Text = "FrmUpLoadListLogo";
            this.Load += new System.EventHandler(this.FrmUpLoadListLogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBWss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lbFail;
        private System.Windows.Forms.Label lbSuccess;
        private System.Windows.Forms.Label lbCount;
        private DevExpress.XtraEditors.SimpleButton btnChooseFile;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.RichTextBox rbSuccess;
        private System.Windows.Forms.RichTextBox rbFail;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DBWss dBWss;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBWssTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DBWssTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.RichTextBox rbError;
    }
}