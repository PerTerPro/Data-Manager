namespace QT.Moduls.Maps
{
    partial class frmManagerProduct
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label validLabel;
            System.Windows.Forms.Label detailUrlLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label summaryLabel;
            System.Windows.Forms.Label lastPriceChangeLabel;
            System.Windows.Forms.Label lastUpdateLabel;
            System.Windows.Forms.Label iDLabel2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label addPositionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerProduct));
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPMan = new QT.Moduls.Maps.DBPMan();
            this.detailUrlTextBox1 = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.productContentTextBox = new System.Windows.Forms.TextBox();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ctrListSPGoc1 = new QT.Moduls.Maps.ctrListSPGoc();
            this.iDCategoryTextBox = new System.Windows.Forms.TextBox();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnMappingRootId = new DevExpress.XtraEditors.SimpleButton();
            this.addPositionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imageUrlsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UploadImageButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lastUpdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastPriceChangeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.btOpenWeb = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.productStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.ctrProductIdentity1 = new QT.Moduls.Maps.CtrProductIdentity();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.webContent = new System.Windows.Forms.WebBrowser();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.btBuildContent = new DevExpress.XtraEditors.SimpleButton();
            this.webBuildContent = new System.Windows.Forms.WebBrowser();
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.chkSelectFulltext = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.iDListClassificationTextBox = new System.Windows.Forms.TextBox();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.laMess1 = new System.Windows.Forms.Label();
            this.btUpdateTopGiamGiaTuan = new DevExpress.XtraEditors.SimpleButton();
            this.btUpadateTongView = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdateTinLienQuan = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdateGiaSPGocSauPhanTich = new DevExpress.XtraEditors.SimpleButton();
            this.btSiteMap = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdateFulltext_catid = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdateGiaSPGoc = new DevExpress.XtraEditors.SimpleButton();
            this.DownloadImageTab = new DevExpress.XtraTab.XtraTabPage();
            this.grdProductImage = new DevExpress.XtraGrid.GridControl();
            this.gvProductImage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetProductImage = new DevExpress.XtraEditors.SimpleButton();
            this.UploadAllImageProductButton = new DevExpress.XtraEditors.SimpleButton();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.validCheckBox = new System.Windows.Forms.CheckBox();
            this.productKeyComparisonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listClassificationTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.ListClassificationTableAdapter();
            this.productTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Maps.DBPManTableAdapters.TableAdapterManager();
            this.product_KeyComparisonTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.Product_KeyComparisonTableAdapter();
            this.productStatusTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.ProductStatusTableAdapter();
            this.dBMap = new QT.Moduls.Maps.DBMap();
            this.productValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productValueTableAdapter = new QT.Moduls.Maps.DBMapTableAdapters.ProductValueTableAdapter();
            this.tableAdapterManager1 = new QT.Moduls.Maps.DBMapTableAdapters.TableAdapterManager();
            this.productPerClassTableAdapter1 = new QT.Moduls.Tool.DBToolTableAdapters.ProductPerClassTableAdapter();
            iDLabel = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            validLabel = new System.Windows.Forms.Label();
            detailUrlLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            summaryLabel = new System.Windows.Forms.Label();
            lastPriceChangeLabel = new System.Windows.Forms.Label();
            lastUpdateLabel = new System.Windows.Forms.Label();
            iDLabel2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            addPositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPositionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrlsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage6.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            this.xtraTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.DownloadImageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productKeyComparisonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productValueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(214, 392);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // iDLabel1
            // 
            iDLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(201, 163);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 0;
            iDLabel1.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(11, 46);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // validLabel
            // 
            validLabel.AutoSize = true;
            validLabel.Location = new System.Drawing.Point(171, 94);
            validLabel.Name = "validLabel";
            validLabel.Size = new System.Drawing.Size(36, 13);
            validLabel.TabIndex = 14;
            validLabel.Text = "Public";
            // 
            // detailUrlLabel1
            // 
            detailUrlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            detailUrlLabel1.AutoSize = true;
            detailUrlLabel1.Location = new System.Drawing.Point(307, 159);
            detailUrlLabel1.Name = "detailUrlLabel1";
            detailUrlLabel1.Size = new System.Drawing.Size(48, 13);
            detailUrlLabel1.TabIndex = 18;
            detailUrlLabel1.Text = "Link gốc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 13);
            label1.TabIndex = 18;
            label1.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(47, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 0;
            label2.Text = "Thấp nhất";
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Location = new System.Drawing.Point(11, 9);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new System.Drawing.Size(47, 13);
            summaryLabel.TabIndex = 22;
            summaryLabel.Text = "Tên gốc";
            // 
            // lastPriceChangeLabel
            // 
            lastPriceChangeLabel.AutoSize = true;
            lastPriceChangeLabel.Location = new System.Drawing.Point(6, 83);
            lastPriceChangeLabel.Name = "lastPriceChangeLabel";
            lastPriceChangeLabel.Size = new System.Drawing.Size(97, 13);
            lastPriceChangeLabel.TabIndex = 22;
            lastPriceChangeLabel.Text = "Last Price Change:";
            // 
            // lastUpdateLabel
            // 
            lastUpdateLabel.AutoSize = true;
            lastUpdateLabel.Location = new System.Drawing.Point(35, 57);
            lastUpdateLabel.Name = "lastUpdateLabel";
            lastUpdateLabel.Size = new System.Drawing.Size(68, 13);
            lastUpdateLabel.TabIndex = 23;
            lastUpdateLabel.Text = "Last Update:";
            // 
            // iDLabel2
            // 
            iDLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel2.AutoSize = true;
            iDLabel2.Location = new System.Drawing.Point(246, 59);
            iDLabel2.Name = "iDLabel2";
            iDLabel2.Size = new System.Drawing.Size(21, 13);
            iDLabel2.TabIndex = 5;
            iDLabel2.Text = "ID:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(398, 62);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 5;
            label3.Text = "Delay";
            // 
            // addPositionLabel
            // 
            addPositionLabel.AutoSize = true;
            addPositionLabel.Location = new System.Drawing.Point(238, 94);
            addPositionLabel.Name = "addPositionLabel";
            addPositionLabel.Size = new System.Drawing.Size(69, 13);
            addPositionLabel.TabIndex = 27;
            addPositionLabel.Text = "Add Position:";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dBPMan;
            // 
            // dBPMan
            // 
            this.dBPMan.DataSetName = "DBPMan";
            this.dBPMan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailUrlTextBox1
            // 
            this.detailUrlTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detailUrlTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "DetailUrl", true));
            this.detailUrlTextBox1.Location = new System.Drawing.Point(361, 156);
            this.detailUrlTextBox1.Name = "detailUrlTextBox1";
            this.detailUrlTextBox1.ReadOnly = true;
            this.detailUrlTextBox1.Size = new System.Drawing.Size(113, 20);
            this.detailUrlTextBox1.TabIndex = 19;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(226, 160);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(47, 20);
            this.iDTextBox.TabIndex = 1;
            this.iDTextBox.TextChanged += new System.EventHandler(this.iDTextBox_TextChanged);
            // 
            // productContentTextBox
            // 
            this.productContentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductContent", true));
            this.productContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productContentTextBox.Location = new System.Drawing.Point(0, 0);
            this.productContentTextBox.Multiline = true;
            this.productContentTextBox.Name = "productContentTextBox";
            this.productContentTextBox.Size = new System.Drawing.Size(996, 467);
            this.productContentTextBox.TabIndex = 1;
            this.productContentTextBox.TextChanged += new System.EventHandler(this.productContentTextBox_TextChanged);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ctrListSPGoc1);
            this.splitContainerControl1.Panel1.Controls.Add(iDLabel);
            this.splitContainerControl1.Panel1.Controls.Add(this.iDCategoryTextBox);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnMappingRootId);
            this.splitContainerControl1.Panel2.Controls.Add(addPositionLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.addPositionTextEdit);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.imageUrlsTextEdit);
            this.splitContainerControl1.Panel2.Controls.Add(this.UploadImageButton);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.cboStatus);
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl2);
            this.splitContainerControl1.Panel2.Controls.Add(detailUrlLabel1);
            this.splitContainerControl1.Panel2.Controls.Add(this.detailUrlTextBox1);
            this.splitContainerControl1.Panel2.Controls.Add(this.iDTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(summaryLabel);
            this.splitContainerControl1.Panel2.Controls.Add(iDLabel1);
            this.splitContainerControl1.Panel2.Controls.Add(this.summaryTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(label1);
            this.splitContainerControl1.Panel2.Controls.Add(this.nameTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(nameLabel);
            this.splitContainerControl1.Panel2.Controls.Add(validLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.validCheckBox);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1470, 634);
            this.splitContainerControl1.SplitterPosition = 446;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ctrListSPGoc1
            // 
            this.ctrListSPGoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrListSPGoc1.Location = new System.Drawing.Point(1, 1);
            this.ctrListSPGoc1.Name = "ctrListSPGoc1";
            this.ctrListSPGoc1.Size = new System.Drawing.Size(446, 633);
            this.ctrListSPGoc1.TabIndex = 5;
            this.ctrListSPGoc1.ProductIDChange += new QT.Moduls.Maps.ctrListSPGoc.ProductIDChangedEventHandler(this.ctrListSPGoc1_ProductIDChange);
            // 
            // iDCategoryTextBox
            // 
            this.iDCategoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iDCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "ID", true));
            this.iDCategoryTextBox.Enabled = false;
            this.iDCategoryTextBox.Location = new System.Drawing.Point(241, 389);
            this.iDCategoryTextBox.Name = "iDCategoryTextBox";
            this.iDCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDCategoryTextBox.TabIndex = 3;
            this.iDCategoryTextBox.TabStop = false;
            this.iDCategoryTextBox.TextChanged += new System.EventHandler(this.iDCategoryTextBox_TextChanged);
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dBPMan;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(460, 115);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(228, 13);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "(Thiết lập ID SP gốc này trỏ về ID SP gốc chính)";
            // 
            // btnMappingRootId
            // 
            this.btnMappingRootId.Location = new System.Drawing.Point(361, 112);
            this.btnMappingRootId.Name = "btnMappingRootId";
            this.btnMappingRootId.Size = new System.Drawing.Size(93, 20);
            this.btnMappingRootId.TabIndex = 29;
            this.btnMappingRootId.Text = "Thiếp lập Link 301";
            this.btnMappingRootId.Click += new System.EventHandler(this.btnMappingRootId_Click);
            // 
            // addPositionTextEdit
            // 
            this.addPositionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "AddPosition", true));
            this.addPositionTextEdit.Location = new System.Drawing.Point(306, 91);
            this.addPositionTextEdit.Name = "addPositionTextEdit";
            this.addPositionTextEdit.Size = new System.Drawing.Size(39, 20);
            this.addPositionTextEdit.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 115);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "ImageUrls";
            // 
            // imageUrlsTextEdit
            // 
            this.imageUrlsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ImageUrls", true));
            this.imageUrlsTextEdit.Location = new System.Drawing.Point(69, 112);
            this.imageUrlsTextEdit.Name = "imageUrlsTextEdit";
            this.imageUrlsTextEdit.Size = new System.Drawing.Size(185, 20);
            this.imageUrlsTextEdit.TabIndex = 26;
            // 
            // UploadImageButton
            // 
            this.UploadImageButton.Location = new System.Drawing.Point(262, 112);
            this.UploadImageButton.Name = "UploadImageButton";
            this.UploadImageButton.Size = new System.Drawing.Size(75, 20);
            this.UploadImageButton.TabIndex = 5;
            this.UploadImageButton.Text = "UploadImage";
            this.UploadImageButton.Click += new System.EventHandler(this.UploadImageButton_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(lastUpdateLabel);
            this.groupControl1.Controls.Add(this.lastUpdateDateTimePicker);
            this.groupControl1.Controls.Add(lastPriceChangeLabel);
            this.groupControl1.Controls.Add(this.lastPriceChangeDateTimePicker);
            this.groupControl1.Controls.Add(this.spinEdit1);
            this.groupControl1.Controls.Add(label2);
            this.groupControl1.Controls.Add(this.btOpenWeb);
            this.groupControl1.Location = new System.Drawing.Point(752, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(217, 108);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "So sánh với vật giá";
            // 
            // lastUpdateDateTimePicker
            // 
            this.lastUpdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "LastUpdate", true));
            this.lastUpdateDateTimePicker.Enabled = false;
            this.lastUpdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastUpdateDateTimePicker.Location = new System.Drawing.Point(109, 51);
            this.lastUpdateDateTimePicker.Name = "lastUpdateDateTimePicker";
            this.lastUpdateDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.lastUpdateDateTimePicker.TabIndex = 24;
            // 
            // lastPriceChangeDateTimePicker
            // 
            this.lastPriceChangeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "LastPriceChange", true));
            this.lastPriceChangeDateTimePicker.Enabled = false;
            this.lastPriceChangeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastPriceChangeDateTimePicker.Location = new System.Drawing.Point(109, 77);
            this.lastPriceChangeDateTimePicker.Name = "lastPriceChangeDateTimePicker";
            this.lastPriceChangeDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.lastPriceChangeDateTimePicker.TabIndex = 23;
            // 
            // spinEdit1
            // 
            this.spinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "PriceChange", true));
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(109, 25);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.spinEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.DisplayFormat.FormatString = "n0";
            this.spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit1.Properties.EditFormat.FormatString = "n0";
            this.spinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit1.Size = new System.Drawing.Size(100, 20);
            this.spinEdit1.TabIndex = 22;
            // 
            // btOpenWeb
            // 
            this.btOpenWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpenWeb.Location = new System.Drawing.Point(142, 0);
            this.btOpenWeb.Name = "btOpenWeb";
            this.btOpenWeb.Size = new System.Drawing.Size(75, 23);
            this.btOpenWeb.TabIndex = 20;
            this.btOpenWeb.Text = "OpenVatGia";
            this.btOpenWeb.UseVisualStyleBackColor = true;
            this.btOpenWeb.Click += new System.EventHandler(this.btOpenWeb_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "Status", true));
            this.cboStatus.DataSource = this.productStatusBindingSource;
            this.cboStatus.DisplayMember = "Name";
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(69, 90);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(98, 21);
            this.cboStatus.TabIndex = 24;
            this.cboStatus.ValueMember = "ID";
            // 
            // productStatusBindingSource
            // 
            this.productStatusBindingSource.DataMember = "ProductStatus";
            this.productStatusBindingSource.DataSource = this.dBPMan;
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl2.Location = new System.Drawing.Point(2, 139);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage6;
            this.xtraTabControl2.Size = new System.Drawing.Size(1002, 495);
            this.xtraTabControl2.TabIndex = 17;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage6,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5,
            this.xtraTabPage7,
            this.DownloadImageTab});
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.ctrProductIdentity1);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(996, 467);
            this.xtraTabPage6.Text = "Product Ananytic";
            // 
            // ctrProductIdentity1
            // 
            this.ctrProductIdentity1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrProductIdentity1.Location = new System.Drawing.Point(0, 0);
            this.ctrProductIdentity1.Name = "ctrProductIdentity1";
            this.ctrProductIdentity1.Size = new System.Drawing.Size(996, 467);
            this.ctrProductIdentity1.TabIndex = 0;
            this.ctrProductIdentity1.UpdateProductIdentityClick += new QT.Moduls.Maps.CtrProductIdentity.UpdateEventHandler(this.ctrProductIdentity1_UpdateProductIdentityClick);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.productContentTextBox);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(996, 467);
            this.xtraTabPage3.Text = "Html";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.webContent);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(996, 467);
            this.xtraTabPage4.Text = "View";
            // 
            // webContent
            // 
            this.webContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webContent.Location = new System.Drawing.Point(0, 0);
            this.webContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.webContent.Name = "webContent";
            this.webContent.Size = new System.Drawing.Size(996, 467);
            this.webContent.TabIndex = 16;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.btBuildContent);
            this.xtraTabPage5.Controls.Add(this.webBuildContent);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(996, 467);
            this.xtraTabPage5.Text = "Build content";
            // 
            // btBuildContent
            // 
            this.btBuildContent.Location = new System.Drawing.Point(2, 2);
            this.btBuildContent.Name = "btBuildContent";
            this.btBuildContent.Size = new System.Drawing.Size(196, 23);
            this.btBuildContent.TabIndex = 18;
            this.btBuildContent.Text = "Build content";
            this.btBuildContent.Click += new System.EventHandler(this.btBuildContent_Click);
            // 
            // webBuildContent
            // 
            this.webBuildContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBuildContent.Location = new System.Drawing.Point(0, 28);
            this.webBuildContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBuildContent.Name = "webBuildContent";
            this.webBuildContent.Size = new System.Drawing.Size(772, 654);
            this.webBuildContent.TabIndex = 17;
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.AutoScroll = true;
            this.xtraTabPage7.Controls.Add(this.txtDelay);
            this.xtraTabPage7.Controls.Add(this.chkSelectFulltext);
            this.xtraTabPage7.Controls.Add(this.chkAll);
            this.xtraTabPage7.Controls.Add(label3);
            this.xtraTabPage7.Controls.Add(iDLabel2);
            this.xtraTabPage7.Controls.Add(this.iDListClassificationTextBox);
            this.xtraTabPage7.Controls.Add(this.treeList1);
            this.xtraTabPage7.Controls.Add(this.laMess1);
            this.xtraTabPage7.Controls.Add(this.btUpdateTopGiamGiaTuan);
            this.xtraTabPage7.Controls.Add(this.btUpadateTongView);
            this.xtraTabPage7.Controls.Add(this.btUpdateTinLienQuan);
            this.xtraTabPage7.Controls.Add(this.btUpdateGiaSPGocSauPhanTich);
            this.xtraTabPage7.Controls.Add(this.btSiteMap);
            this.xtraTabPage7.Controls.Add(this.btUpdateFulltext_catid);
            this.xtraTabPage7.Controls.Add(this.btUpdateGiaSPGoc);
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.Size = new System.Drawing.Size(996, 467);
            this.xtraTabPage7.Text = "Tool";
            // 
            // txtDelay
            // 
            this.txtDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDelay.Location = new System.Drawing.Point(438, 59);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(100, 20);
            this.txtDelay.TabIndex = 8;
            this.txtDelay.Text = "200";
            // 
            // chkSelectFulltext
            // 
            this.chkSelectFulltext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSelectFulltext.AutoSize = true;
            this.chkSelectFulltext.Location = new System.Drawing.Point(355, 82);
            this.chkSelectFulltext.Name = "chkSelectFulltext";
            this.chkSelectFulltext.Size = new System.Drawing.Size(93, 17);
            this.chkSelectFulltext.TabIndex = 7;
            this.chkSelectFulltext.Text = "SelectFullText";
            this.chkSelectFulltext.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(273, 82);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(68, 17);
            this.chkAll.TabIndex = 7;
            this.chkAll.Text = "CheckAll";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // iDListClassificationTextBox
            // 
            this.iDListClassificationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iDListClassificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "ID", true));
            this.iDListClassificationTextBox.Location = new System.Drawing.Point(273, 56);
            this.iDListClassificationTextBox.Name = "iDListClassificationTextBox";
            this.iDListClassificationTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDListClassificationTextBox.TabIndex = 6;
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName});
            this.treeList1.DataSource = this.listClassificationBindingSource;
            this.treeList1.Location = new System.Drawing.Point(3, 56);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(231, 482);
            this.treeList1.TabIndex = 5;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 61;
            // 
            // laMess1
            // 
            this.laMess1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laMess1.Location = new System.Drawing.Point(3, 0);
            this.laMess1.Name = "laMess1";
            this.laMess1.Size = new System.Drawing.Size(569, 53);
            this.laMess1.TabIndex = 2;
            this.laMess1.Text = "messger";
            // 
            // btUpdateTopGiamGiaTuan
            // 
            this.btUpdateTopGiamGiaTuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpdateTopGiamGiaTuan.Location = new System.Drawing.Point(249, 315);
            this.btUpdateTopGiamGiaTuan.Name = "btUpdateTopGiamGiaTuan";
            this.btUpdateTopGiamGiaTuan.Size = new System.Drawing.Size(259, 23);
            this.btUpdateTopGiamGiaTuan.TabIndex = 1;
            this.btUpdateTopGiamGiaTuan.Text = "Update lại Top giảm giá tuần";
            this.btUpdateTopGiamGiaTuan.Click += new System.EventHandler(this.btUpdateTopGiamGiaTuan_Click);
            // 
            // btUpadateTongView
            // 
            this.btUpadateTongView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpadateTongView.Location = new System.Drawing.Point(249, 287);
            this.btUpadateTongView.Name = "btUpadateTongView";
            this.btUpadateTongView.Size = new System.Drawing.Size(259, 23);
            this.btUpadateTongView.TabIndex = 1;
            this.btUpadateTongView.Text = "Update lại tổng View trong tháng";
            this.btUpadateTongView.Click += new System.EventHandler(this.btUpadateTongView_Click);
            // 
            // btUpdateTinLienQuan
            // 
            this.btUpdateTinLienQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpdateTinLienQuan.Location = new System.Drawing.Point(249, 258);
            this.btUpdateTinLienQuan.Name = "btUpdateTinLienQuan";
            this.btUpdateTinLienQuan.Size = new System.Drawing.Size(259, 23);
            this.btUpdateTinLienQuan.TabIndex = 1;
            this.btUpdateTinLienQuan.Text = "Update lại tin liên quan sau phân tích";
            this.btUpdateTinLienQuan.Click += new System.EventHandler(this.btUpdateTinLienQuan_Click);
            // 
            // btUpdateGiaSPGocSauPhanTich
            // 
            this.btUpdateGiaSPGocSauPhanTich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpdateGiaSPGocSauPhanTich.Location = new System.Drawing.Point(249, 152);
            this.btUpdateGiaSPGocSauPhanTich.Name = "btUpdateGiaSPGocSauPhanTich";
            this.btUpdateGiaSPGocSauPhanTich.Size = new System.Drawing.Size(259, 23);
            this.btUpdateGiaSPGocSauPhanTich.TabIndex = 1;
            this.btUpdateGiaSPGocSauPhanTich.Text = "Update lại tổng, giá sản phẩm gốc sau phân tích";
            this.btUpdateGiaSPGocSauPhanTich.Click += new System.EventHandler(this.btUpdateGiaSPGocSauPhanTich_Click);
            // 
            // btSiteMap
            // 
            this.btSiteMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSiteMap.Location = new System.Drawing.Point(249, 210);
            this.btSiteMap.Name = "btSiteMap";
            this.btSiteMap.Size = new System.Drawing.Size(258, 23);
            this.btSiteMap.TabIndex = 0;
            this.btSiteMap.Text = "Zen Sitemap";
            this.btSiteMap.Click += new System.EventHandler(this.btSiteMap_Click);
            // 
            // btUpdateFulltext_catid
            // 
            this.btUpdateFulltext_catid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpdateFulltext_catid.Location = new System.Drawing.Point(249, 181);
            this.btUpdateFulltext_catid.Name = "btUpdateFulltext_catid";
            this.btUpdateFulltext_catid.Size = new System.Drawing.Size(258, 23);
            this.btUpdateFulltext_catid.TabIndex = 0;
            this.btUpdateFulltext_catid.Text = "Update lại Fulltext search các sản phẩm + catid";
            this.btUpdateFulltext_catid.Visible = false;
            this.btUpdateFulltext_catid.Click += new System.EventHandler(this.btUpdateFulltext_catid_Click);
            // 
            // btUpdateGiaSPGoc
            // 
            this.btUpdateGiaSPGoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpdateGiaSPGoc.Location = new System.Drawing.Point(249, 105);
            this.btUpdateGiaSPGoc.Name = "btUpdateGiaSPGoc";
            this.btUpdateGiaSPGoc.Size = new System.Drawing.Size(258, 23);
            this.btUpdateGiaSPGoc.TabIndex = 0;
            this.btUpdateGiaSPGoc.Text = "Update lại giá link sản phẩm gốc từ vật giá";
            this.btUpdateGiaSPGoc.Click += new System.EventHandler(this.btUpdateGiaSPGoc_Click);
            // 
            // DownloadImageTab
            // 
            this.DownloadImageTab.Controls.Add(this.grdProductImage);
            this.DownloadImageTab.Controls.Add(this.panelControl1);
            this.DownloadImageTab.Name = "DownloadImageTab";
            this.DownloadImageTab.Size = new System.Drawing.Size(996, 467);
            this.DownloadImageTab.Text = "Download Image";
            // 
            // grdProductImage
            // 
            this.grdProductImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProductImage.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdProductImage.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdProductImage.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdProductImage.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdProductImage.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdProductImage.Location = new System.Drawing.Point(0, 56);
            this.grdProductImage.MainView = this.gvProductImage;
            this.grdProductImage.Name = "grdProductImage";
            this.grdProductImage.Size = new System.Drawing.Size(996, 411);
            this.grdProductImage.TabIndex = 1;
            this.grdProductImage.UseEmbeddedNavigator = true;
            this.grdProductImage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductImage});
            // 
            // gvProductImage
            // 
            this.gvProductImage.GridControl = this.grdProductImage;
            this.gvProductImage.Name = "gvProductImage";
            this.gvProductImage.OptionsView.ShowAutoFilterRow = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExportExcel);
            this.panelControl1.Controls.Add(this.btnGetProductImage);
            this.panelControl1.Controls.Add(this.UploadAllImageProductButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(996, 56);
            this.panelControl1.TabIndex = 0;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(181, 5);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(66, 38);
            this.btnExportExcel.TabIndex = 11;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnGetProductImage
            // 
            this.btnGetProductImage.Location = new System.Drawing.Point(8, 5);
            this.btnGetProductImage.Name = "btnGetProductImage";
            this.btnGetProductImage.Size = new System.Drawing.Size(161, 38);
            this.btnGetProductImage.TabIndex = 10;
            this.btnGetProductImage.Text = "Get Product Check Image";
            this.btnGetProductImage.Click += new System.EventHandler(this.btnGetProductImage_Click);
            // 
            // UploadAllImageProductButton
            // 
            this.UploadAllImageProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadAllImageProductButton.Image = ((System.Drawing.Image)(resources.GetObject("UploadAllImageProductButton.Image")));
            this.UploadAllImageProductButton.Location = new System.Drawing.Point(812, 5);
            this.UploadAllImageProductButton.Name = "UploadAllImageProductButton";
            this.UploadAllImageProductButton.Size = new System.Drawing.Size(179, 38);
            this.UploadAllImageProductButton.TabIndex = 9;
            this.UploadAllImageProductButton.Text = "Upload All Image SP Gốc";
            this.UploadAllImageProductButton.ToolTip = "Upload toàn bộ sản phẩm gốc có trạng thái Config nhưng chưa Public";
            this.UploadAllImageProductButton.Click += new System.EventHandler(this.UploadAllImageProductButton_Click);
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Summary", true));
            this.summaryTextBox.Location = new System.Drawing.Point(69, 7);
            this.summaryTextBox.Multiline = true;
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.ReadOnly = true;
            this.summaryTextBox.Size = new System.Drawing.Size(676, 38);
            this.summaryTextBox.TabIndex = 23;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(69, 46);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(676, 42);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // validCheckBox
            // 
            this.validCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "Valid", true));
            this.validCheckBox.Location = new System.Drawing.Point(213, 89);
            this.validCheckBox.Name = "validCheckBox";
            this.validCheckBox.Size = new System.Drawing.Size(19, 24);
            this.validCheckBox.TabIndex = 15;
            this.validCheckBox.UseVisualStyleBackColor = true;
            // 
            // productKeyComparisonBindingSource
            // 
            this.productKeyComparisonBindingSource.DataMember = "Product_KeyComparison";
            this.productKeyComparisonBindingSource.DataSource = this.dBPMan;
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ListClassificationTableAdapter = this.listClassificationTableAdapter;
            this.tableAdapterManager.NewsTableAdapter = null;
            this.tableAdapterManager.Product_KeyComparisonTableAdapter = null;
            this.tableAdapterManager.Product_PropertiesTableAdapter = null;
            this.tableAdapterManager.ProductAnanyticTableAdapter = null;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductStatusTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RouterRootProductTableAdapter = null;
            this.tableAdapterManager.Tag_CategoryTableAdapter = null;
            this.tableAdapterManager.Tag_ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Maps.DBPManTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // product_KeyComparisonTableAdapter
            // 
            this.product_KeyComparisonTableAdapter.ClearBeforeFill = true;
            // 
            // productStatusTableAdapter
            // 
            this.productStatusTableAdapter.ClearBeforeFill = true;
            // 
            // dBMap
            // 
            this.dBMap.DataSetName = "DBMap";
            this.dBMap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productValueBindingSource
            // 
            this.productValueBindingSource.DataMember = "ProductValue";
            this.productValueBindingSource.DataSource = this.dBMap;
            // 
            // productValueTableAdapter
            // 
            this.productValueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClassificationTableAdapter = null;
            this.tableAdapterManager1.Company_AddressTableAdapter = null;
            this.tableAdapterManager1.CompanyTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.ListClassificationTableAdapter = null;
            this.tableAdapterManager1.Product_ImageTableAdapter = null;
            this.tableAdapterManager1.ProductIDTableAdapter = null;
            this.tableAdapterManager1.ProductTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QT.Moduls.Maps.DBMapTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productPerClassTableAdapter1
            // 
            this.productPerClassTableAdapter1.ClearBeforeFill = true;
            // 
            // frmManagerProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1470, 634);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmManagerProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManagerProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmManagerProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPositionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUrlsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage6.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage7.ResumeLayout(false);
            this.xtraTabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.DownloadImageTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productKeyComparisonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productValueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DBPMan dBPMan;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DBPManTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBPManTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.TextBox iDCategoryTextBox;
        private DBPManTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox validCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox productContentTextBox;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private System.Windows.Forms.WebBrowser webContent;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private System.Windows.Forms.BindingSource productKeyComparisonBindingSource;
        private DBPManTableAdapters.Product_KeyComparisonTableAdapter product_KeyComparisonTableAdapter;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private System.Windows.Forms.TextBox detailUrlTextBox1;
        private System.Windows.Forms.Button btOpenWeb;
        private System.Windows.Forms.BindingSource productStatusBindingSource;
        private DBPManTableAdapters.ProductStatusTableAdapter productStatusTableAdapter;
        private System.Windows.Forms.WebBrowser webBuildContent;
        private DBMap dBMap;
        private System.Windows.Forms.BindingSource productValueBindingSource;
        private DBMapTableAdapters.ProductValueTableAdapter productValueTableAdapter;
        private DBMapTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private DevExpress.XtraEditors.SimpleButton btUpdateGiaSPGoc;
        private System.Windows.Forms.Label laMess1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private ctrListSPGoc ctrListSPGoc1;
        private System.Windows.Forms.TextBox summaryTextBox;
        private DevExpress.XtraEditors.SimpleButton btBuildContent;
        private System.Windows.Forms.ComboBox cboStatus;
        private DevExpress.XtraEditors.SimpleButton btUpdateGiaSPGocSauPhanTich;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker lastUpdateDateTimePicker;
        private System.Windows.Forms.DateTimePicker lastPriceChangeDateTimePicker;
        private DevExpress.XtraEditors.SimpleButton btUpdateFulltext_catid;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private System.Windows.Forms.TextBox iDListClassificationTextBox;
        private System.Windows.Forms.CheckBox chkAll;
        private DevExpress.XtraEditors.SimpleButton btSiteMap;
        private DevExpress.XtraEditors.SimpleButton btUpadateTongView;
        private DevExpress.XtraEditors.SimpleButton btUpdateTinLienQuan;
        private DevExpress.XtraEditors.SimpleButton btUpdateTopGiamGiaTuan;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.CheckBox chkSelectFulltext;
        private Tool.DBToolTableAdapters.ProductPerClassTableAdapter productPerClassTableAdapter1;
        private CtrProductIdentity ctrProductIdentity1;
        private DevExpress.XtraEditors.SimpleButton UploadImageButton;
        private DevExpress.XtraEditors.SimpleButton UploadAllImageProductButton;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit imageUrlsTextEdit;
        private DevExpress.XtraTab.XtraTabPage DownloadImageTab;
        private DevExpress.XtraGrid.GridControl grdProductImage;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductImage;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGetProductImage;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraEditors.TextEdit addPositionTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnMappingRootId;
    }
}
