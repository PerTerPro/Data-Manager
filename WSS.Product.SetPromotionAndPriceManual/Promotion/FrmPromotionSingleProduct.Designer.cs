namespace WSS.Product.SetPromotionAndPriceManual.Promotion
{
    partial class FrmPromotionSingleProduct
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label promotionInfoLabel;
            System.Windows.Forms.Label detailUrlLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label domainLabel;
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.productGridControl = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource();
            this.dBProduct = new WSS.Product.SetPromotionAndPriceManual.DBProduct();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPromotionInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtIdProductByLink = new DevExpress.XtraEditors.TextEdit();
            this.txtDetailUrl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnCheckProductLinkDetail = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdCompany = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNameProduct = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCheckProductName = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtIdProductBySku = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSku = new DevExpress.XtraEditors.TextEdit();
            this.btnCheckProductSku = new DevExpress.XtraEditors.SimpleButton();
            this.domainTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.rbPromotionInfo = new System.Windows.Forms.RichTextBox();
            this.iDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.detailUrlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.companyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.productTableAdapter = new WSS.Product.SetPromotionAndPriceManual.DBProductTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new WSS.Product.SetPromotionAndPriceManual.DBProductTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            promotionInfoLabel = new System.Windows.Forms.Label();
            detailUrlLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProductByLink.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProductBySku.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSku.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailUrlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(9, 29);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // promotionInfoLabel
            // 
            promotionInfoLabel.AutoSize = true;
            promotionInfoLabel.Location = new System.Drawing.Point(9, 124);
            promotionInfoLabel.Name = "promotionInfoLabel";
            promotionInfoLabel.Size = new System.Drawing.Size(78, 13);
            promotionInfoLabel.TabIndex = 6;
            promotionInfoLabel.Text = "Promotion Info:";
            // 
            // detailUrlLabel
            // 
            detailUrlLabel.AutoSize = true;
            detailUrlLabel.Location = new System.Drawing.Point(9, 90);
            detailUrlLabel.Name = "detailUrlLabel";
            detailUrlLabel.Size = new System.Drawing.Size(53, 13);
            detailUrlLabel.TabIndex = 8;
            detailUrlLabel.Text = "Detail Url:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(199, 29);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 10;
            companyLabel.Text = "Company:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 306);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 13);
            label1.TabIndex = 14;
            label1.Text = "Price:";
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(375, 29);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 15;
            domainLabel.Text = "Domain:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.productGridControl);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(domainLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.domainTextEdit);
            this.splitContainerControl1.Panel2.Controls.Add(label1);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit1);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel2.Controls.Add(this.rbPromotionInfo);
            this.splitContainerControl1.Panel2.Controls.Add(iDLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.iDTextEdit);
            this.splitContainerControl1.Panel2.Controls.Add(nameLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.nameTextEdit);
            this.splitContainerControl1.Panel2.Controls.Add(promotionInfoLabel);
            this.splitContainerControl1.Panel2.Controls.Add(detailUrlLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.detailUrlTextEdit);
            this.splitContainerControl1.Panel2.Controls.Add(companyLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.companyTextEdit);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1103, 637);
            this.splitContainerControl1.SplitterPosition = 536;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // productGridControl
            // 
            this.productGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.productGridControl.DataSource = this.productBindingSource;
            this.productGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridControl.Location = new System.Drawing.Point(0, 300);
            this.productGridControl.MainView = this.gvProduct;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.Size = new System.Drawing.Size(536, 337);
            this.productGridControl.TabIndex = 1;
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBProduct;
            // 
            // dBProduct
            // 
            this.dBProduct.DataSetName = "DBProduct";
            this.dBProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvProduct
            // 
            this.gvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colPrice,
            this.colPromotionInfo,
            this.colDetailUrl,
            this.colCompany});
            this.gvProduct.GridControl = this.productGridControl;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsBehavior.Editable = false;
            this.gvProduct.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 83;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 192;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // colPromotionInfo
            // 
            this.colPromotionInfo.FieldName = "PromotionInfo";
            this.colPromotionInfo.Name = "colPromotionInfo";
            // 
            // colDetailUrl
            // 
            this.colDetailUrl.FieldName = "DetailUrl";
            this.colDetailUrl.Name = "colDetailUrl";
            this.colDetailUrl.Visible = true;
            this.colDetailUrl.VisibleIndex = 2;
            this.colDetailUrl.Width = 243;
            // 
            // colCompany
            // 
            this.colCompany.FieldName = "Company";
            this.colCompany.Name = "colCompany";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(536, 300);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtIdProductByLink);
            this.groupControl3.Controls.Add(this.txtDetailUrl);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.btnCheckProductLinkDetail);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 200);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(532, 98);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Tìm theo Link hoặc ID sản phẩm";
            // 
            // txtIdProductByLink
            // 
            this.txtIdProductByLink.Location = new System.Drawing.Point(75, 68);
            this.txtIdProductByLink.Name = "txtIdProductByLink";
            this.txtIdProductByLink.Size = new System.Drawing.Size(360, 20);
            this.txtIdProductByLink.TabIndex = 10;
            // 
            // txtDetailUrl
            // 
            this.txtDetailUrl.Location = new System.Drawing.Point(75, 33);
            this.txtDetailUrl.Name = "txtDetailUrl";
            this.txtDetailUrl.Size = new System.Drawing.Size(360, 20);
            this.txtDetailUrl.TabIndex = 7;
            this.txtDetailUrl.EditValueChanged += new System.EventHandler(this.txtDetailUrl_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "IDProduct";
            // 
            // btnCheckProductLinkDetail
            // 
            this.btnCheckProductLinkDetail.Location = new System.Drawing.Point(441, 31);
            this.btnCheckProductLinkDetail.Name = "btnCheckProductLinkDetail";
            this.btnCheckProductLinkDetail.Size = new System.Drawing.Size(75, 23);
            this.btnCheckProductLinkDetail.TabIndex = 8;
            this.btnCheckProductLinkDetail.Text = "CheckProduct";
            this.btnCheckProductLinkDetail.Click += new System.EventHandler(this.btnCheckProductLinkDetail_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Link SP";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtIdCompany);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtNameProduct);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.btnCheckProductName);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 83);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(532, 117);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Tìm theo tên sản phẩm";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Location = new System.Drawing.Point(10, 24);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(439, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "* Tip: Nên search : Ví dụ sản phẩm: Quạt phun sương Sunhouse SHD7800 thì điền SHD" +
    "7800";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(441, 85);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(18, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "***";
            // 
            // txtIdCompany
            // 
            this.txtIdCompany.Location = new System.Drawing.Point(75, 82);
            this.txtIdCompany.Name = "txtIdCompany";
            this.txtIdCompany.Size = new System.Drawing.Size(360, 20);
            this.txtIdCompany.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "ID Công ty";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(75, 47);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(360, 20);
            this.txtNameProduct.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tên SP";
            // 
            // btnCheckProductName
            // 
            this.btnCheckProductName.Location = new System.Drawing.Point(441, 45);
            this.btnCheckProductName.Name = "btnCheckProductName";
            this.btnCheckProductName.Size = new System.Drawing.Size(75, 23);
            this.btnCheckProductName.TabIndex = 3;
            this.btnCheckProductName.Text = "CheckProduct";
            this.btnCheckProductName.Click += new System.EventHandler(this.btnCheckProductName_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtIdProductBySku);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtSku);
            this.groupControl1.Controls.Add(this.btnCheckProductSku);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(532, 81);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Tìm theo SKU - tạm thời chưa sử dụng";
            // 
            // txtIdProductBySku
            // 
            this.txtIdProductBySku.Location = new System.Drawing.Point(75, 50);
            this.txtIdProductBySku.Name = "txtIdProductBySku";
            this.txtIdProductBySku.Properties.ReadOnly = true;
            this.txtIdProductBySku.Size = new System.Drawing.Size(360, 20);
            this.txtIdProductBySku.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "IDProduct";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 27);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(19, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "SKU";
            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(75, 24);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(360, 20);
            this.txtSku.TabIndex = 0;
            // 
            // btnCheckProductSku
            // 
            this.btnCheckProductSku.Location = new System.Drawing.Point(441, 22);
            this.btnCheckProductSku.Name = "btnCheckProductSku";
            this.btnCheckProductSku.Size = new System.Drawing.Size(75, 23);
            this.btnCheckProductSku.TabIndex = 2;
            this.btnCheckProductSku.Text = "CheckProduct";
            this.btnCheckProductSku.Click += new System.EventHandler(this.btnCheckProductSku_Click);
            // 
            // domainTextEdit
            // 
            this.domainTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Domain", true));
            this.domainTextEdit.Location = new System.Drawing.Point(427, 26);
            this.domainTextEdit.Name = "domainTextEdit";
            this.domainTextEdit.Properties.ReadOnly = true;
            this.domainTextEdit.Size = new System.Drawing.Size(100, 20);
            this.domainTextEdit.TabIndex = 16;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Price", true));
            this.textEdit1.Location = new System.Drawing.Point(93, 299);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(160, 20);
            this.textEdit1.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu dữ liệu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbPromotionInfo
            // 
            this.rbPromotionInfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "PromotionInfo", true));
            this.rbPromotionInfo.Location = new System.Drawing.Point(93, 121);
            this.rbPromotionInfo.Name = "rbPromotionInfo";
            this.rbPromotionInfo.Size = new System.Drawing.Size(434, 172);
            this.rbPromotionInfo.TabIndex = 12;
            this.rbPromotionInfo.Text = "";
            // 
            // iDTextEdit
            // 
            this.iDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "ID", true));
            this.iDTextEdit.Location = new System.Drawing.Point(92, 26);
            this.iDTextEdit.Name = "iDTextEdit";
            this.iDTextEdit.Properties.ReadOnly = true;
            this.iDTextEdit.Size = new System.Drawing.Size(100, 20);
            this.iDTextEdit.TabIndex = 1;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(92, 57);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.ReadOnly = true;
            this.nameTextEdit.Size = new System.Drawing.Size(435, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // detailUrlTextEdit
            // 
            this.detailUrlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "DetailUrl", true));
            this.detailUrlTextEdit.Location = new System.Drawing.Point(92, 87);
            this.detailUrlTextEdit.Name = "detailUrlTextEdit";
            this.detailUrlTextEdit.Properties.ReadOnly = true;
            this.detailUrlTextEdit.Size = new System.Drawing.Size(435, 20);
            this.detailUrlTextEdit.TabIndex = 9;
            // 
            // companyTextEdit
            // 
            this.companyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Company", true));
            this.companyTextEdit.Location = new System.Drawing.Point(261, 26);
            this.companyTextEdit.Name = "companyTextEdit";
            this.companyTextEdit.Properties.ReadOnly = true;
            this.companyTextEdit.Size = new System.Drawing.Size(100, 20);
            this.companyTextEdit.TabIndex = 11;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WSS.Product.SetPromotionAndPriceManual.DBProductTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmPromotionSingleProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 637);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmPromotionSingleProduct";
            this.Text = "FrmPromotionSingleProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPromotionSingleProduct_FormClosing);
            this.Load += new System.EventHandler(this.FrmPromotionSingleProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProductByLink.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdProductBySku.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSku.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailUrlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBProduct dBProduct;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBProductTableAdapters.ProductTableAdapter productTableAdapter;
        private DBProductTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl productGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
        private DevExpress.XtraEditors.TextEdit txtSku;
        private DevExpress.XtraEditors.SimpleButton btnCheckProductSku;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtIdCompany;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNameProduct;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCheckProductName;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtIdProductByLink;
        private DevExpress.XtraEditors.TextEdit txtDetailUrl;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCheckProductLinkDetail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPromotionInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.RichTextBox rbPromotionInfo;
        private DevExpress.XtraEditors.TextEdit iDTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit detailUrlTextEdit;
        private DevExpress.XtraEditors.TextEdit txtIdProductBySku;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit domainTextEdit;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit companyTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}