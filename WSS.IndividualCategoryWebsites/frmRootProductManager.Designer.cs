namespace WSS.IndividualCategoryWebsites
{
    partial class frmRootProductManager
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
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label websiteIdLabel;
            System.Windows.Forms.Label minPriceLabel;
            System.Windows.Forms.Label numMerchantLabel;
            System.Windows.Forms.Label localPathLabel;
            System.Windows.Forms.Label productIdListLabel;
            System.Windows.Forms.Label imageLabel;
            this.dBIndi = new WSS.IndividualCategoryWebsites.DBIndi();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.idTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.rootProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.websiteIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.minPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.numMerchantTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.localPathTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.productIdListTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.imageTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tableAdapterManager = new WSS.IndividualCategoryWebsites.DBIndiTableAdapters.TableAdapterManager();
            this.rootProductsTableAdapter = new WSS.IndividualCategoryWebsites.DBIndiTableAdapters.RootProductsTableAdapter();
            this.rootProductsGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewRootProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.websitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.websitesTableAdapter = new WSS.IndividualCategoryWebsites.DBIndiTableAdapters.WebsitesTableAdapter();
            idLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            websiteIdLabel = new System.Windows.Forms.Label();
            minPriceLabel = new System.Windows.Forms.Label();
            numMerchantLabel = new System.Windows.Forms.Label();
            localPathLabel = new System.Windows.Forms.Label();
            productIdListLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBIndi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMerchantTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localPathTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIdListTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootProductsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRootProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websitesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(23, 25);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 0;
            idLabel1.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(312, 25);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // websiteIdLabel
            // 
            websiteIdLabel.AutoSize = true;
            websiteIdLabel.Location = new System.Drawing.Point(23, 61);
            websiteIdLabel.Name = "websiteIdLabel";
            websiteIdLabel.Size = new System.Drawing.Size(61, 13);
            websiteIdLabel.TabIndex = 4;
            websiteIdLabel.Text = "Website Id:";
            // 
            // minPriceLabel
            // 
            minPriceLabel.AutoSize = true;
            minPriceLabel.Location = new System.Drawing.Point(312, 61);
            minPriceLabel.Name = "minPriceLabel";
            minPriceLabel.Size = new System.Drawing.Size(54, 13);
            minPriceLabel.TabIndex = 6;
            minPriceLabel.Text = "Min Price:";
            // 
            // numMerchantLabel
            // 
            numMerchantLabel.AutoSize = true;
            numMerchantLabel.Location = new System.Drawing.Point(523, 61);
            numMerchantLabel.Name = "numMerchantLabel";
            numMerchantLabel.Size = new System.Drawing.Size(80, 13);
            numMerchantLabel.TabIndex = 8;
            numMerchantLabel.Text = "Num Merchant:";
            // 
            // localPathLabel
            // 
            localPathLabel.AutoSize = true;
            localPathLabel.Location = new System.Drawing.Point(23, 100);
            localPathLabel.Name = "localPathLabel";
            localPathLabel.Size = new System.Drawing.Size(61, 13);
            localPathLabel.TabIndex = 10;
            localPathLabel.Text = "Local Path:";
            // 
            // productIdListLabel
            // 
            productIdListLabel.AutoSize = true;
            productIdListLabel.Location = new System.Drawing.Point(312, 100);
            productIdListLabel.Name = "productIdListLabel";
            productIdListLabel.Size = new System.Drawing.Size(78, 13);
            productIdListLabel.TabIndex = 12;
            productIdListLabel.Text = "Product Id List:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(312, 136);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(39, 13);
            imageLabel.TabIndex = 14;
            imageLabel.Text = "Image:";
            // 
            // dBIndi
            // 
            this.dBIndi.DataSetName = "DBIndi";
            this.dBIndi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnDeleteAll);
            this.panelControl2.Controls.Add(idLabel1);
            this.panelControl2.Controls.Add(this.idTextEdit1);
            this.panelControl2.Controls.Add(nameLabel);
            this.panelControl2.Controls.Add(this.nameTextEdit);
            this.panelControl2.Controls.Add(websiteIdLabel);
            this.panelControl2.Controls.Add(this.websiteIdTextEdit);
            this.panelControl2.Controls.Add(minPriceLabel);
            this.panelControl2.Controls.Add(this.minPriceTextEdit);
            this.panelControl2.Controls.Add(numMerchantLabel);
            this.panelControl2.Controls.Add(this.numMerchantTextEdit);
            this.panelControl2.Controls.Add(localPathLabel);
            this.panelControl2.Controls.Add(this.localPathTextEdit);
            this.panelControl2.Controls.Add(productIdListLabel);
            this.panelControl2.Controls.Add(this.productIdListTextEdit);
            this.panelControl2.Controls.Add(imageLabel);
            this.panelControl2.Controls.Add(this.imageTextEdit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1281, 168);
            this.panelControl2.TabIndex = 1;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(1076, 31);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(145, 74);
            this.btnDeleteAll.TabIndex = 16;
            this.btnDeleteAll.Text = "Xóa tất cả dữ liệu";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // idTextEdit1
            // 
            this.idTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rootProductsBindingSource, "Id", true));
            this.idTextEdit1.Location = new System.Drawing.Point(109, 22);
            this.idTextEdit1.Name = "idTextEdit1";
            this.idTextEdit1.Size = new System.Drawing.Size(100, 20);
            this.idTextEdit1.TabIndex = 1;
            // 
            // rootProductsBindingSource
            // 
            this.rootProductsBindingSource.DataMember = "RootProducts";
            this.rootProductsBindingSource.DataSource = this.dBIndi;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rootProductsBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(398, 22);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(311, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // websiteIdTextEdit
            // 
            this.websiteIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rootProductsBindingSource, "WebsiteId", true));
            this.websiteIdTextEdit.Location = new System.Drawing.Point(109, 58);
            this.websiteIdTextEdit.Name = "websiteIdTextEdit";
            this.websiteIdTextEdit.Size = new System.Drawing.Size(100, 20);
            this.websiteIdTextEdit.TabIndex = 5;
            // 
            // minPriceTextEdit
            // 
            this.minPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rootProductsBindingSource, "MinPrice", true));
            this.minPriceTextEdit.Location = new System.Drawing.Point(398, 58);
            this.minPriceTextEdit.Name = "minPriceTextEdit";
            this.minPriceTextEdit.Size = new System.Drawing.Size(100, 20);
            this.minPriceTextEdit.TabIndex = 7;
            // 
            // numMerchantTextEdit
            // 
            this.numMerchantTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rootProductsBindingSource, "NumMerchant", true));
            this.numMerchantTextEdit.Location = new System.Drawing.Point(609, 58);
            this.numMerchantTextEdit.Name = "numMerchantTextEdit";
            this.numMerchantTextEdit.Size = new System.Drawing.Size(100, 20);
            this.numMerchantTextEdit.TabIndex = 9;
            // 
            // localPathTextEdit
            // 
            this.localPathTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rootProductsBindingSource, "LocalPath", true));
            this.localPathTextEdit.Location = new System.Drawing.Point(109, 97);
            this.localPathTextEdit.Name = "localPathTextEdit";
            this.localPathTextEdit.Size = new System.Drawing.Size(100, 20);
            this.localPathTextEdit.TabIndex = 11;
            // 
            // productIdListTextEdit
            // 
            this.productIdListTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rootProductsBindingSource, "ProductIdList", true));
            this.productIdListTextEdit.Location = new System.Drawing.Point(398, 97);
            this.productIdListTextEdit.Name = "productIdListTextEdit";
            this.productIdListTextEdit.Size = new System.Drawing.Size(311, 20);
            this.productIdListTextEdit.TabIndex = 13;
            // 
            // imageTextEdit
            // 
            this.imageTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rootProductsBindingSource, "Image", true));
            this.imageTextEdit.Location = new System.Drawing.Point(398, 133);
            this.imageTextEdit.Name = "imageTextEdit";
            this.imageTextEdit.Size = new System.Drawing.Size(311, 20);
            this.imageTextEdit.TabIndex = 15;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.RootProductsTableAdapter = null;
            this.tableAdapterManager.TagsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.IndividualCategoryWebsites.DBIndiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WebsitesTableAdapter = null;
            // 
            // rootProductsTableAdapter
            // 
            this.rootProductsTableAdapter.ClearBeforeFill = true;
            // 
            // rootProductsGridControl
            // 
            this.rootProductsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.rootProductsGridControl.DataSource = this.rootProductsBindingSource;
            this.rootProductsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootProductsGridControl.Location = new System.Drawing.Point(0, 168);
            this.rootProductsGridControl.MainView = this.gridViewRootProduct;
            this.rootProductsGridControl.Name = "rootProductsGridControl";
            this.rootProductsGridControl.Size = new System.Drawing.Size(1281, 544);
            this.rootProductsGridControl.TabIndex = 2;
            this.rootProductsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRootProduct});
            // 
            // gridViewRootProduct
            // 
            this.gridViewRootProduct.GridControl = this.rootProductsGridControl;
            this.gridViewRootProduct.Name = "gridViewRootProduct";
            // 
            // websitesBindingSource
            // 
            this.websitesBindingSource.DataMember = "Websites";
            this.websitesBindingSource.DataSource = this.dBIndi;
            // 
            // websitesTableAdapter
            // 
            this.websitesTableAdapter.ClearBeforeFill = true;
            // 
            // frmRootProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1281, 712);
            this.Controls.Add(this.rootProductsGridControl);
            this.Controls.Add(this.panelControl2);
            this.Name = "frmRootProductManager";
            this.Text = "Quản lý sản phẩm gốc";
            this.Load += new System.EventHandler(this.frmRootProductManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBIndi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websiteIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMerchantTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localPathTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIdListTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootProductsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRootProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websitesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DBIndi dBIndi;
        private DBIndiTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource rootProductsBindingSource;
        private DBIndiTableAdapters.RootProductsTableAdapter rootProductsTableAdapter;
        private DevExpress.XtraGrid.GridControl rootProductsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRootProduct;
        private DevExpress.XtraEditors.TextEdit idTextEdit1;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit websiteIdTextEdit;
        private DevExpress.XtraEditors.TextEdit minPriceTextEdit;
        private DevExpress.XtraEditors.TextEdit numMerchantTextEdit;
        private DevExpress.XtraEditors.TextEdit localPathTextEdit;
        private DevExpress.XtraEditors.TextEdit productIdListTextEdit;
        private DevExpress.XtraEditors.TextEdit imageTextEdit;
        private System.Windows.Forms.BindingSource websitesBindingSource;
        private DBIndiTableAdapters.WebsitesTableAdapter websitesTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
    }
}