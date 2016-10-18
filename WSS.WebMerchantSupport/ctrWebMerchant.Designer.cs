namespace WSS.WebMerchantSupport
{
    partial class ctrWebMerchant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label webIdLabel;
            System.Windows.Forms.Label webDomainLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.webDomainTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.websiteProfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsWebMerchant = new WSS.WebMerchantSupport.dsWebMerchant();
            this.webIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.websiteProfilesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWebId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.websiteProfilesTableAdapter = new WSS.WebMerchantSupport.dsWebMerchantTableAdapters.WebsiteProfilesTableAdapter();
            this.tableAdapterManager = new WSS.WebMerchantSupport.dsWebMerchantTableAdapters.TableAdapterManager();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeToolStripChangeProduct = new System.Windows.Forms.ToolStripMenuItem();
            webIdLabel = new System.Windows.Forms.Label();
            webDomainLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webDomainTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteProfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWebMerchant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.websiteProfilesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webIdLabel
            // 
            webIdLabel.AutoSize = true;
            webIdLabel.Location = new System.Drawing.Point(7, 30);
            webIdLabel.Name = "webIdLabel";
            webIdLabel.Size = new System.Drawing.Size(45, 13);
            webIdLabel.TabIndex = 0;
            webIdLabel.Text = "Web Id:";
            // 
            // webDomainLabel
            // 
            webDomainLabel.AutoSize = true;
            webDomainLabel.Location = new System.Drawing.Point(187, 30);
            webDomainLabel.Name = "webDomainLabel";
            webDomainLabel.Size = new System.Drawing.Size(72, 13);
            webDomainLabel.TabIndex = 2;
            webDomainLabel.Text = "Web Domain:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(webDomainLabel);
            this.panelControl1.Controls.Add(this.webDomainTextEdit);
            this.panelControl1.Controls.Add(webIdLabel);
            this.panelControl1.Controls.Add(this.webIdTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(384, 77);
            this.panelControl1.TabIndex = 0;
            // 
            // webDomainTextEdit
            // 
            this.webDomainTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.websiteProfilesBindingSource, "WebDomain", true));
            this.webDomainTextEdit.Location = new System.Drawing.Point(265, 27);
            this.webDomainTextEdit.Name = "webDomainTextEdit";
            this.webDomainTextEdit.Size = new System.Drawing.Size(100, 20);
            this.webDomainTextEdit.TabIndex = 3;
            // 
            // websiteProfilesBindingSource
            // 
            this.websiteProfilesBindingSource.DataMember = "WebsiteProfiles";
            this.websiteProfilesBindingSource.DataSource = this.dsWebMerchant;
            // 
            // dsWebMerchant
            // 
            this.dsWebMerchant.DataSetName = "dsWebMerchant";
            this.dsWebMerchant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // webIdTextEdit
            // 
            this.webIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.websiteProfilesBindingSource, "WebId", true));
            this.webIdTextEdit.Location = new System.Drawing.Point(58, 27);
            this.webIdTextEdit.Name = "webIdTextEdit";
            this.webIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.webIdTextEdit.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.websiteProfilesGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 77);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(384, 550);
            this.panelControl2.TabIndex = 1;
            // 
            // websiteProfilesGridControl
            // 
            this.websiteProfilesGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.websiteProfilesGridControl.DataSource = this.websiteProfilesBindingSource;
            this.websiteProfilesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.websiteProfilesGridControl.Location = new System.Drawing.Point(2, 2);
            this.websiteProfilesGridControl.MainView = this.gridView1;
            this.websiteProfilesGridControl.Name = "websiteProfilesGridControl";
            this.websiteProfilesGridControl.Size = new System.Drawing.Size(380, 546);
            this.websiteProfilesGridControl.TabIndex = 0;
            this.websiteProfilesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.websiteProfilesGridControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.websiteProfilesGridControl_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWebId,
            this.colWebDomain});
            this.gridView1.GridControl = this.websiteProfilesGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colWebId
            // 
            this.colWebId.FieldName = "WebId";
            this.colWebId.Name = "colWebId";
            this.colWebId.OptionsColumn.ReadOnly = true;
            this.colWebId.Visible = true;
            this.colWebId.VisibleIndex = 0;
            this.colWebId.Width = 85;
            // 
            // colWebDomain
            // 
            this.colWebDomain.FieldName = "WebDomain";
            this.colWebDomain.Name = "colWebDomain";
            this.colWebDomain.OptionsColumn.ReadOnly = true;
            this.colWebDomain.Visible = true;
            this.colWebDomain.VisibleIndex = 1;
            this.colWebDomain.Width = 291;
            // 
            // websiteProfilesTableAdapter
            // 
            this.websiteProfilesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WSS.WebMerchantSupport.dsWebMerchantTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WebsiteProfilesTableAdapter = this.websiteProfilesTableAdapter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripChangeProduct});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // changeToolStripChangeProduct
            // 
            this.changeToolStripChangeProduct.Name = "changeToolStripChangeProduct";
            this.changeToolStripChangeProduct.Size = new System.Drawing.Size(157, 22);
            this.changeToolStripChangeProduct.Text = "ChangeProduct";
            this.changeToolStripChangeProduct.Click += new System.EventHandler(this.changeToolStripChangeProduct_Click);
            // 
            // ctrWebMerchant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ctrWebMerchant";
            this.Size = new System.Drawing.Size(384, 627);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webDomainTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteProfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWebMerchant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.websiteProfilesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private dsWebMerchant dsWebMerchant;
        private System.Windows.Forms.BindingSource websiteProfilesBindingSource;
        private dsWebMerchantTableAdapters.WebsiteProfilesTableAdapter websiteProfilesTableAdapter;
        private dsWebMerchantTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit webDomainTextEdit;
        private DevExpress.XtraEditors.TextEdit webIdTextEdit;
        private DevExpress.XtraGrid.GridControl websiteProfilesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colWebId;
        private DevExpress.XtraGrid.Columns.GridColumn colWebDomain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripChangeProduct;
    }
}
