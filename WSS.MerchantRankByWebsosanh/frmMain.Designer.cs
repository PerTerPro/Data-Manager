namespace WSS.MerchantRankByWebsosanh
{
    partial class frmMain
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowGoogleSheet = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewMerchantScore = new DevExpress.XtraEditors.SimpleButton();
            this.lbMessage = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDomain = new DevExpress.XtraEditors.TextEdit();
            this.iDSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBScore = new WSS.MerchantRankByWebsosanh.DBScore();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.companyTableAdapter = new WSS.MerchantRankByWebsosanh.DBScoreTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager = new WSS.MerchantRankByWebsosanh.DBScoreTableAdapters.TableAdapterManager();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(459, 21);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 4;
            iDLabel.Text = "ID:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnShowGoogleSheet);
            this.panelControl1.Controls.Add(this.btnViewMerchantScore);
            this.panelControl1.Controls.Add(iDLabel);
            this.panelControl1.Controls.Add(this.lbMessage);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtDomain);
            this.panelControl1.Controls.Add(this.iDSpinEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1050, 81);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(761, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnShowGoogleSheet
            // 
            this.btnShowGoogleSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowGoogleSheet.Location = new System.Drawing.Point(963, 16);
            this.btnShowGoogleSheet.Name = "btnShowGoogleSheet";
            this.btnShowGoogleSheet.Size = new System.Drawing.Size(75, 23);
            this.btnShowGoogleSheet.TabIndex = 7;
            this.btnShowGoogleSheet.Text = "GoogleSheet";
            this.btnShowGoogleSheet.ToolTip = "Lấy danh sách đánh giá trên GoogleSheet";
            this.btnShowGoogleSheet.Click += new System.EventHandler(this.btnShowGoogleSheet_Click);
            // 
            // btnViewMerchantScore
            // 
            this.btnViewMerchantScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewMerchantScore.Location = new System.Drawing.Point(871, 16);
            this.btnViewMerchantScore.Name = "btnViewMerchantScore";
            this.btnViewMerchantScore.Size = new System.Drawing.Size(75, 23);
            this.btnViewMerchantScore.TabIndex = 6;
            this.btnViewMerchantScore.Text = "Xem đánh giá";
            this.btnViewMerchantScore.Click += new System.EventHandler(this.btnViewMerchantScore_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.Location = new System.Drawing.Point(82, 54);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(12, 13);
            this.lbMessage.TabIndex = 3;
            this.lbMessage.Text = "...";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(329, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Domain";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(82, 18);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(241, 20);
            this.txtDomain.TabIndex = 0;
            // 
            // iDSpinEdit
            // 
            this.iDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "ID", true));
            this.iDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iDSpinEdit.Location = new System.Drawing.Point(486, 18);
            this.iDSpinEdit.Name = "iDSpinEdit";
            this.iDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.iDSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.iDSpinEdit.Size = new System.Drawing.Size(135, 20);
            this.iDSpinEdit.TabIndex = 5;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBScore;
            // 
            // dBScore
            // 
            this.dBScore.DataSetName = "DBScore";
            this.dBScore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.companyBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 81);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1050, 522);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDomain,
            this.colWebsite,
            this.colStatus,
            this.colTotalProduct,
            this.colTotalValid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 160;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 1;
            this.colDomain.Width = 171;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 2;
            this.colWebsite.Width = 198;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 85;
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 4;
            this.colTotalProduct.Width = 89;
            // 
            // colTotalValid
            // 
            this.colTotalValid.FieldName = "TotalValid";
            this.colTotalValid.Name = "colTotalValid";
            this.colTotalValid.Visible = true;
            this.colTotalValid.VisibleIndex = 5;
            this.colTotalValid.Width = 91;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.MerchantScoreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.MerchantRankByWebsosanh.DBScoreTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 26);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.thêmToolStripMenuItem.Text = "Xem đánh giá";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(655, 44);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 603);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lbMessage;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDomain;
        private DBScore dBScore;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBScoreTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValid;
        private DevExpress.XtraEditors.TextEdit iDSpinEdit;
        private DBScoreTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton btnViewMerchantScore;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btnShowGoogleSheet;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}