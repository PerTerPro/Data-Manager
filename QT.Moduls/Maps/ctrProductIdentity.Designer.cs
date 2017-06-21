namespace QT.Moduls.Maps
{
    partial class CtrProductIdentity
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
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label companyLabel1;
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrProductIdentity));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView1 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView2 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.richTextBoxConfusedProductList = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBoxAdditionProductIDs = new System.Windows.Forms.RichTextBox();
            this.buttonSaveTemporary = new System.Windows.Forms.Button();
            this.spinEditMaxPriceFound = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditMinPriceFound = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditMaxPrice = new DevExpress.XtraEditors.SpinEdit();
            this.spintEditMinPrice = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNumFound = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBoxCompanyBlackList = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxProductBlackList = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxExcludeKeywords = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxKeywords = new System.Windows.Forms.RichTextBox();
            this.dBMap = new QT.Moduls.Maps.DBMap();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMarkConfused = new System.Windows.Forms.ToolStripButton();
            this.btLoaiSanPham = new System.Windows.Forms.ToolStripButton();
            this.btLoaiCongTy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddProductID = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmLoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoaiCongTy = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewListProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnRootID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlListProduct = new DevExpress.XtraGrid.GridControl();
            this.productInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSelectedProductID = new DevExpress.XtraEditors.SpinEdit();
            this.textBoxSelectedProductCompany = new DevExpress.XtraEditors.SpinEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.buttonUpdateToWeb = new System.Windows.Forms.Button();
            iDLabel1 = new System.Windows.Forms.Label();
            companyLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxPriceFound.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMinPriceFound.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spintEditMinPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSelectedProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSelectedProductCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel1
            // 
            iDLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(31, 614);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 14;
            iDLabel1.Text = "ID:";
            // 
            // companyLabel1
            // 
            companyLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            companyLabel1.AutoSize = true;
            companyLabel1.Location = new System.Drawing.Point(196, 614);
            companyLabel1.Name = "companyLabel1";
            companyLabel1.Size = new System.Drawing.Size(54, 13);
            companyLabel1.TabIndex = 26;
            companyLabel1.Text = "Company:";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(37, 3);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(118, 20);
            this.textBoxProductID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // textBoxLastUpdate
            // 
            this.textBoxLastUpdate.Enabled = false;
            this.textBoxLastUpdate.Location = new System.Drawing.Point(304, 3);
            this.textBoxLastUpdate.Name = "textBoxLastUpdate";
            this.textBoxLastUpdate.Size = new System.Drawing.Size(137, 20);
            this.textBoxLastUpdate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cập nhập lần cuối";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonUpdateToWeb);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.richTextBoxConfusedProductList);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.richTextBoxAdditionProductIDs);
            this.panel1.Controls.Add(this.buttonSaveTemporary);
            this.panel1.Controls.Add(this.spinEditMaxPriceFound);
            this.panel1.Controls.Add(this.spinEditMinPriceFound);
            this.panel1.Controls.Add(this.spinEditMaxPrice);
            this.panel1.Controls.Add(this.spintEditMinPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBoxNote);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBoxNumFound);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnIdentify);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.richTextBoxCompanyBlackList);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.richTextBoxProductBlackList);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.richTextBoxExcludeKeywords);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.richTextBoxKeywords);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxLastUpdate);
            this.panel1.Controls.Add(this.textBoxProductID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 273);
            this.panel1.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(156, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "BlackList";
            // 
            // richTextBoxConfusedProductList
            // 
            this.richTextBoxConfusedProductList.Location = new System.Drawing.Point(16, 139);
            this.richTextBoxConfusedProductList.Name = "richTextBoxConfusedProductList";
            this.richTextBoxConfusedProductList.Size = new System.Drawing.Size(132, 76);
            this.richTextBoxConfusedProductList.TabIndex = 42;
            this.richTextBoxConfusedProductList.Text = "";
            this.richTextBoxConfusedProductList.TextChanged += new System.EventHandler(this.richTextBoxConfusedProductList_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(441, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "ID sp bổ sung";
            // 
            // richTextBoxAdditionProductIDs
            // 
            this.richTextBoxAdditionProductIDs.Location = new System.Drawing.Point(441, 139);
            this.richTextBoxAdditionProductIDs.Name = "richTextBoxAdditionProductIDs";
            this.richTextBoxAdditionProductIDs.Size = new System.Drawing.Size(129, 76);
            this.richTextBoxAdditionProductIDs.TabIndex = 40;
            this.richTextBoxAdditionProductIDs.Text = "";
            this.richTextBoxAdditionProductIDs.TextChanged += new System.EventHandler(this.richTextBoxAdditionProductIDs_TextChanged);
            // 
            // buttonSaveTemporary
            // 
            this.buttonSaveTemporary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveTemporary.Location = new System.Drawing.Point(607, 217);
            this.buttonSaveTemporary.Name = "buttonSaveTemporary";
            this.buttonSaveTemporary.Size = new System.Drawing.Size(88, 27);
            this.buttonSaveTemporary.TabIndex = 38;
            this.buttonSaveTemporary.Text = "Lưu Tạm";
            this.buttonSaveTemporary.UseVisualStyleBackColor = true;
            this.buttonSaveTemporary.Click += new System.EventHandler(this.buttonSaveTemporary_Click);
            // 
            // spinEditMaxPriceFound
            // 
            this.spinEditMaxPriceFound.EditValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spinEditMaxPriceFound.Location = new System.Drawing.Point(376, 250);
            this.spinEditMaxPriceFound.Name = "spinEditMaxPriceFound";
            this.spinEditMaxPriceFound.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.spinEditMaxPriceFound.Properties.DisplayFormat.FormatString = "n00";
            this.spinEditMaxPriceFound.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditMaxPriceFound.Properties.Mask.EditMask = "n00";
            this.spinEditMaxPriceFound.Size = new System.Drawing.Size(109, 20);
            this.spinEditMaxPriceFound.TabIndex = 37;
            // 
            // spinEditMinPriceFound
            // 
            this.spinEditMinPriceFound.EditValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spinEditMinPriceFound.Location = new System.Drawing.Point(376, 228);
            this.spinEditMinPriceFound.Name = "spinEditMinPriceFound";
            this.spinEditMinPriceFound.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.spinEditMinPriceFound.Properties.DisplayFormat.FormatString = "n00";
            this.spinEditMinPriceFound.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditMinPriceFound.Properties.Mask.EditMask = "n00";
            this.spinEditMinPriceFound.Size = new System.Drawing.Size(109, 20);
            this.spinEditMinPriceFound.TabIndex = 36;
            // 
            // spinEditMaxPrice
            // 
            this.spinEditMaxPrice.EditValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spinEditMaxPrice.Location = new System.Drawing.Point(615, 98);
            this.spinEditMaxPrice.Name = "spinEditMaxPrice";
            this.spinEditMaxPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.spinEditMaxPrice.Properties.DisplayFormat.FormatString = "n00";
            this.spinEditMaxPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditMaxPrice.Properties.Mask.EditMask = "n00";
            this.spinEditMaxPrice.Size = new System.Drawing.Size(89, 20);
            this.spinEditMaxPrice.TabIndex = 35;
            this.spinEditMaxPrice.EditValueChanged += new System.EventHandler(this.spinEditMaxPrice_EditValueChanged);
            // 
            // spintEditMinPrice
            // 
            this.spintEditMinPrice.EditValue = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.spintEditMinPrice.Location = new System.Drawing.Point(615, 43);
            this.spintEditMinPrice.Name = "spintEditMinPrice";
            this.spintEditMinPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.spintEditMinPrice.Properties.DisplayFormat.FormatString = "n00";
            this.spintEditMinPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spintEditMinPrice.Properties.Mask.EditMask = "n00";
            this.spintEditMinPrice.Size = new System.Drawing.Size(90, 20);
            this.spintEditMinPrice.TabIndex = 34;
            this.spintEditMinPrice.EditValueChanged += new System.EventHandler(this.spintEditMinPrice_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ghi chú";
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Location = new System.Drawing.Point(576, 139);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(132, 76);
            this.richTextBoxNote.TabIndex = 28;
            this.richTextBoxNote.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(243, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Giá lớn nhất tìm thấy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(242, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Giá nhỏ nhất tìm thấy";
            // 
            // textBoxNumFound
            // 
            this.textBoxNumFound.Location = new System.Drawing.Point(193, 240);
            this.textBoxNumFound.Name = "textBoxNumFound";
            this.textBoxNumFound.Size = new System.Drawing.Size(44, 20);
            this.textBoxNumFound.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(110, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Số sản phẩm";
            // 
            // btnIdentify
            // 
            this.btnIdentify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentify.Location = new System.Drawing.Point(8, 221);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(98, 48);
            this.btnIdentify.TabIndex = 21;
            this.btnIdentify.Text = "Nhận diện (F6)";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(488, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu ( Ctr+S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(294, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "C.ty bị loại";
            // 
            // richTextBoxCompanyBlackList
            // 
            this.richTextBoxCompanyBlackList.Location = new System.Drawing.Point(294, 139);
            this.richTextBoxCompanyBlackList.Name = "richTextBoxCompanyBlackList";
            this.richTextBoxCompanyBlackList.Size = new System.Drawing.Size(134, 76);
            this.richTextBoxCompanyBlackList.TabIndex = 18;
            this.richTextBoxCompanyBlackList.Text = "";
            this.richTextBoxCompanyBlackList.TextChanged += new System.EventHandler(this.richTextBoxCompanyBlackList_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID sp bị nhận nhầm";
            // 
            // richTextBoxProductBlackList
            // 
            this.richTextBoxProductBlackList.Location = new System.Drawing.Point(159, 139);
            this.richTextBoxProductBlackList.Name = "richTextBoxProductBlackList";
            this.richTextBoxProductBlackList.Size = new System.Drawing.Size(129, 76);
            this.richTextBoxProductBlackList.TabIndex = 16;
            this.richTextBoxProductBlackList.Text = "";
            this.richTextBoxProductBlackList.TextChanged += new System.EventHandler(this.richTextBoxProductIDBlackList_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(619, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Giá lớn nhất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giá nhỏ nhất";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Từ không chứa";
            // 
            // richTextBoxExcludeKeywords
            // 
            this.richTextBoxExcludeKeywords.Location = new System.Drawing.Point(376, 27);
            this.richTextBoxExcludeKeywords.Name = "richTextBoxExcludeKeywords";
            this.richTextBoxExcludeKeywords.Size = new System.Drawing.Size(233, 91);
            this.richTextBoxExcludeKeywords.TabIndex = 10;
            this.richTextBoxExcludeKeywords.Text = "";
            this.richTextBoxExcludeKeywords.TextChanged += new System.EventHandler(this.richTextBoxExcludeKeywords_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Từ khóa";
            // 
            // richTextBoxKeywords
            // 
            this.richTextBoxKeywords.Location = new System.Drawing.Point(65, 27);
            this.richTextBoxKeywords.Name = "richTextBoxKeywords";
            this.richTextBoxKeywords.Size = new System.Drawing.Size(305, 91);
            this.richTextBoxKeywords.TabIndex = 8;
            this.richTextBoxKeywords.Text = "";
            this.richTextBoxKeywords.TextChanged += new System.EventHandler(this.richTextBoxKeywords_TextChanged);
            // 
            // dBMap
            // 
            this.dBMap.DataSetName = "DBMap";
            this.dBMap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonMarkConfused,
            this.btLoaiSanPham,
            this.btLoaiCongTy,
            this.toolStripButtonAddProductID});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 637);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(711, 25);
            this.bindingNavigator1.TabIndex = 11;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonMarkConfused
            // 
            this.toolStripButtonMarkConfused.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMarkConfused.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMarkConfused.Image")));
            this.toolStripButtonMarkConfused.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMarkConfused.Name = "toolStripButtonMarkConfused";
            this.toolStripButtonMarkConfused.Size = new System.Drawing.Size(77, 22);
            this.toolStripButtonMarkConfused.Text = "Nhận nhầm ";
            this.toolStripButtonMarkConfused.Click += new System.EventHandler(this.toolStripButtonMarkConfused_Click);
            // 
            // btLoaiSanPham
            // 
            this.btLoaiSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btLoaiSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btLoaiSanPham.Image")));
            this.btLoaiSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLoaiSanPham.Name = "btLoaiSanPham";
            this.btLoaiSanPham.Size = new System.Drawing.Size(88, 22);
            this.btLoaiSanPham.Text = "Loại sản phẩm";
            this.btLoaiSanPham.Click += new System.EventHandler(this.AddIDLoai);
            // 
            // btLoaiCongTy
            // 
            this.btLoaiCongTy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btLoaiCongTy.Image = ((System.Drawing.Image)(resources.GetObject("btLoaiCongTy.Image")));
            this.btLoaiCongTy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLoaiCongTy.Name = "btLoaiCongTy";
            this.btLoaiCongTy.Size = new System.Drawing.Size(76, 22);
            this.btLoaiCongTy.Text = "Loại công ty";
            this.btLoaiCongTy.Click += new System.EventHandler(this.tsmLoaiCongTy_Click);
            // 
            // toolStripButtonAddProductID
            // 
            this.toolStripButtonAddProductID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddProductID.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddProductID.Image")));
            this.toolStripButtonAddProductID.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddProductID.Name = "toolStripButtonAddProductID";
            this.toolStripButtonAddProductID.Size = new System.Drawing.Size(97, 22);
            this.toolStripButtonAddProductID.Text = "Thêm sản phẩm";
            this.toolStripButtonAddProductID.Click += new System.EventHandler(this.toolStripButtonAddProductID_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLoaiSanPham,
            this.tsmLoaiCongTy});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            // 
            // tsmLoaiSanPham
            // 
            this.tsmLoaiSanPham.Name = "tsmLoaiSanPham";
            this.tsmLoaiSanPham.Size = new System.Drawing.Size(151, 22);
            this.tsmLoaiSanPham.Text = "Loại sản phẩm";
            this.tsmLoaiSanPham.Click += new System.EventHandler(this.AddIDLoai);
            // 
            // tsmLoaiCongTy
            // 
            this.tsmLoaiCongTy.Name = "tsmLoaiCongTy";
            this.tsmLoaiCongTy.Size = new System.Drawing.Size(151, 22);
            this.tsmLoaiCongTy.Text = "Loại công ty";
            this.tsmLoaiCongTy.Click += new System.EventHandler(this.tsmLoaiCongTy_Click);
            // 
            // gridViewListProduct
            // 
            this.gridViewListProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnID,
            this.columnRootID,
            this.columnName,
            this.columnPrice,
            this.columnLastUpdate,
            this.columnUrl,
            this.columnCompany});
            this.gridViewListProduct.GridControl = this.gridControlListProduct;
            this.gridViewListProduct.Name = "gridViewListProduct";
            this.gridViewListProduct.OptionsView.ShowAutoFilterRow = true;
            this.gridViewListProduct.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.gridViewListProduct.OptionsView.ShowGroupPanel = false;
            this.gridViewListProduct.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewListProduct_RowStyle);
            // 
            // columnID
            // 
            this.columnID.Caption = "ID";
            this.columnID.FieldName = "ID";
            this.columnID.Name = "columnID";
            this.columnID.OptionsColumn.FixedWidth = true;
            this.columnID.OptionsColumn.ReadOnly = true;
            this.columnID.Visible = true;
            this.columnID.VisibleIndex = 0;
            this.columnID.Width = 70;
            // 
            // columnRootID
            // 
            this.columnRootID.Caption = "RootID";
            this.columnRootID.FieldName = "RootID";
            this.columnRootID.Name = "columnRootID";
            this.columnRootID.Visible = true;
            this.columnRootID.VisibleIndex = 1;
            this.columnRootID.Width = 67;
            // 
            // columnName
            // 
            this.columnName.Caption = "Name";
            this.columnName.FieldName = "Name";
            this.columnName.Name = "columnName";
            this.columnName.OptionsColumn.ReadOnly = true;
            this.columnName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.columnName.Visible = true;
            this.columnName.VisibleIndex = 2;
            this.columnName.Width = 217;
            // 
            // columnPrice
            // 
            this.columnPrice.Caption = "Price";
            this.columnPrice.DisplayFormat.FormatString = "n00";
            this.columnPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.columnPrice.FieldName = "Price";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.OptionsColumn.FixedWidth = true;
            this.columnPrice.Visible = true;
            this.columnPrice.VisibleIndex = 3;
            this.columnPrice.Width = 64;
            // 
            // columnLastUpdate
            // 
            this.columnLastUpdate.DisplayFormat.FormatString = "dd/MM/yyy";
            this.columnLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.columnLastUpdate.FieldName = "LastUpdate";
            this.columnLastUpdate.Name = "columnLastUpdate";
            this.columnLastUpdate.OptionsColumn.FixedWidth = true;
            this.columnLastUpdate.OptionsColumn.ReadOnly = true;
            // 
            // columnUrl
            // 
            this.columnUrl.Caption = "Url";
            this.columnUrl.FieldName = "Url";
            this.columnUrl.Name = "columnUrl";
            this.columnUrl.OptionsColumn.ReadOnly = true;
            this.columnUrl.Visible = true;
            this.columnUrl.VisibleIndex = 4;
            this.columnUrl.Width = 88;
            // 
            // columnCompany
            // 
            this.columnCompany.Caption = "Company";
            this.columnCompany.FieldName = "Company";
            this.columnCompany.Name = "columnCompany";
            this.columnCompany.Visible = true;
            this.columnCompany.VisibleIndex = 5;
            this.columnCompany.Width = 67;
            // 
            // gridControlListProduct
            // 
            this.gridControlListProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlListProduct.DataSource = this.productInfoBindingSource1;
            this.gridControlListProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlListProduct.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlListProduct.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlListProduct.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControlListProduct.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlListProduct.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlListProduct.Location = new System.Drawing.Point(0, 0);
            this.gridControlListProduct.MainView = this.gridViewListProduct;
            this.gridControlListProduct.Name = "gridControlListProduct";
            this.gridControlListProduct.Size = new System.Drawing.Size(703, 335);
            this.gridControlListProduct.TabIndex = 10;
            this.gridControlListProduct.UseEmbeddedNavigator = true;
            this.gridControlListProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewListProduct});
            this.gridControlListProduct.Click += new System.EventHandler(this.gridControlListProduct_Click);
            this.gridControlListProduct.DoubleClick += new System.EventHandler(this.gridControlListProduct_DoubleClick);
            // 
            // productInfoBindingSource1
            // 
            this.productInfoBindingSource1.DataMember = "ProductInfo";
            this.productInfoBindingSource1.DataSource = this.dBMap;
            // 
            // productInfoBindingSource
            // 
            this.productInfoBindingSource.DataMember = "ProductInfo";
            this.productInfoBindingSource.DataSource = this.dBMap;
            // 
            // textBoxSelectedProductID
            // 
            this.textBoxSelectedProductID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectedProductID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productInfoBindingSource1, "ID", true));
            this.textBoxSelectedProductID.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBoxSelectedProductID.Location = new System.Drawing.Point(67, 611);
            this.textBoxSelectedProductID.Name = "textBoxSelectedProductID";
            this.textBoxSelectedProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textBoxSelectedProductID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectedProductID.TabIndex = 15;
            // 
            // textBoxSelectedProductCompany
            // 
            this.textBoxSelectedProductCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectedProductCompany.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productInfoBindingSource1, "Company", true));
            this.textBoxSelectedProductCompany.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBoxSelectedProductCompany.Location = new System.Drawing.Point(270, 611);
            this.textBoxSelectedProductCompany.Name = "textBoxSelectedProductCompany";
            this.textBoxSelectedProductCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textBoxSelectedProductCompany.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectedProductCompany.TabIndex = 27;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 273);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(711, 364);
            this.xtraTabControl1.TabIndex = 28;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControlListProduct);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(703, 335);
            this.xtraTabPage1.Text = "Data in grid";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.chartControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(703, 335);
            this.xtraTabPage2.Text = "Data in chart";
            // 
            // chartControl
            // 
            this.chartControl.AppearanceNameSerializable = "Chameleon";
            xyDiagram1.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.PaletteName = "Blue Green";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "DistributionPrice";
            series1.View = pointSeriesView1;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl.SeriesTemplate.View = pointSeriesView2;
            this.chartControl.Size = new System.Drawing.Size(455, 335);
            this.chartControl.TabIndex = 1;
            chartTitle1.Text = "Prices distribution chart";
            this.chartControl.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chartControl.ObjectHotTracked += new DevExpress.XtraCharts.HotTrackEventHandler(this.chartControl_ObjectHotTracked);
            this.chartControl.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.EventDrawPoint);
            // 
            // buttonUpdateToWeb
            // 
            this.buttonUpdateToWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateToWeb.Location = new System.Drawing.Point(599, 246);
            this.buttonUpdateToWeb.Name = "buttonUpdateToWeb";
            this.buttonUpdateToWeb.Size = new System.Drawing.Size(109, 27);
            this.buttonUpdateToWeb.TabIndex = 44;
            this.buttonUpdateToWeb.Text = "Update lên wss";
            this.buttonUpdateToWeb.UseVisualStyleBackColor = true;
            this.buttonUpdateToWeb.Click += new System.EventHandler(this.buttonUpdateToWeb_Click);
            // 
            // CtrProductIdentity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(iDLabel1);
            this.Controls.Add(this.textBoxSelectedProductID);
            this.Controls.Add(companyLabel1);
            this.Controls.Add(this.textBoxSelectedProductCompany);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.Name = "CtrProductIdentity";
            this.Size = new System.Drawing.Size(711, 662);
            this.Load += new System.EventHandler(this.CtrProductIdentity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxPriceFound.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMinPriceFound.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spintEditMinPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlListProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSelectedProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSelectedProductCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void chartControl_ObjectHotTracked(object sender, DevExpress.XtraCharts.HotTrackEventArgs e)
        {
            if (e.HitInfo.SeriesPoint == null)
            {
                toolTipController1.HideHint();
            }
            else
            {
                //string hint = ((Websosanh.Core.Product.BO.SolrProductItem)e.HitInfo.SeriesPoint.Tag).DetailUrl;
                //if (!string.IsNullOrEmpty(hint))
                //{
                //    toolTipController1.ShowHint(hint);
                //}
            }
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxCompanyBlackList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxProductBlackList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxExcludeKeywords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxKeywords;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNumFound;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btLoaiSanPham;
        private System.Windows.Forms.ToolStripButton btLoaiCongTy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmLoaiSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmLoaiCongTy;
        private DBMap dBMap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewListProduct;
        private DevExpress.XtraGrid.Columns.GridColumn columnID;
        private DevExpress.XtraGrid.Columns.GridColumn columnName;
        private DevExpress.XtraGrid.Columns.GridColumn columnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn columnLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn columnUrl;
        private DevExpress.XtraGrid.GridControl gridControlListProduct;
        private System.Windows.Forms.BindingSource listProductBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn columnCompany;
        private DevExpress.XtraGrid.Columns.GridColumn columnRootID;
        private DevExpress.XtraEditors.SpinEdit spintEditMinPrice;
        private DevExpress.XtraEditors.SpinEdit spinEditMaxPrice;
        private DevExpress.XtraEditors.SpinEdit spinEditMaxPriceFound;
        private DevExpress.XtraEditors.SpinEdit spinEditMinPriceFound;
        private System.Windows.Forms.BindingSource productInfoBindingSource;
        private DevExpress.XtraEditors.SpinEdit textBoxSelectedProductID;
        private DevExpress.XtraEditors.SpinEdit textBoxSelectedProductCompany;
        private System.Windows.Forms.BindingSource productInfoBindingSource1;
        private System.Windows.Forms.Button buttonSaveTemporary;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBoxAdditionProductIDs;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddProductID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richTextBoxConfusedProductList;
        private System.Windows.Forms.ToolStripButton toolStripButtonMarkConfused;
        private System.Windows.Forms.Button buttonUpdateToWeb;
    }
}
