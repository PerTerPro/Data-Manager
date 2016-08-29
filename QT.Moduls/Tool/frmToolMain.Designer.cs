namespace QT.Moduls.Tool
{
    partial class frmToolMain
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
            System.Windows.Forms.Label checkDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToolMain));
            this.btUpdateCompany = new DevExpress.XtraEditors.SimpleButton();
            this.laMess1 = new System.Windows.Forms.Label();
            this.btUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdateComID = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdateClassification = new DevExpress.XtraEditors.SimpleButton();
            this.btDownloadLogo = new DevExpress.XtraEditors.SimpleButton();
            this.btDownloadImage = new DevExpress.XtraEditors.SimpleButton();
            this.btDownloadImg = new DevExpress.XtraEditors.SimpleButton();
            this.btDownloadImageChuaTai = new DevExpress.XtraEditors.SimpleButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTool = new QT.Moduls.Tool.DBTool();
            this.companyTableAdapter = new QT.Moduls.Tool.DBToolTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Tool.DBToolTableAdapters.TableAdapterManager();
            this.view_TongSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_TongSanPhamTableAdapter = new QT.Moduls.Tool.DBToolTableAdapters.View_TongSanPhamTableAdapter();
            this.view_TongSanPhamValidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_TongSanPhamValidTableAdapter = new QT.Moduls.Tool.DBToolTableAdapters.View_TongSanPhamValidTableAdapter();
            this.productIDHashNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDHashNameTableAdapter = new QT.Moduls.Tool.DBToolTableAdapters.ProductIDHashNameTableAdapter();
            this.view_QueueCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_QueueCountTableAdapter = new QT.Moduls.Tool.DBToolTableAdapters.View_QueueCountTableAdapter();
            this.view_VisitedCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_VisitedCountTableAdapter = new QT.Moduls.Tool.DBToolTableAdapters.View_VisitedCountTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheckD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkImageAdmin = new System.Windows.Forms.CheckBox();
            this.checkDCheckBox = new System.Windows.Forms.CheckBox();
            this.chkRedownload = new DevExpress.XtraEditors.CheckEdit();
            this.cboManager = new System.Windows.Forms.ComboBox();
            this.managerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboCommand = new DevExpress.XtraEditors.ComboBoxEdit();
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
            this.btCheckAll = new System.Windows.Forms.ToolStripButton();
            this.ctrLogMananger1 = new QT.Moduls.Company.ctrLogMananger();
            this.managerTypeTableAdapter = new QT.Moduls.Tool.DBToolTableAdapters.ManagerTypeTableAdapter();
            this.btUpdateSizeImage = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdateCountSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btDeleteTrungten = new DevExpress.XtraEditors.SimpleButton();
            this.btUpDateViewCompany = new DevExpress.XtraEditors.SimpleButton();
            checkDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TongSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TongSanPhamValidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIDHashNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_QueueCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_VisitedCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkRedownload.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCommand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkDLabel
            // 
            checkDLabel.AutoSize = true;
            checkDLabel.Location = new System.Drawing.Point(10, 107);
            checkDLabel.Name = "checkDLabel";
            checkDLabel.Size = new System.Drawing.Size(52, 13);
            checkDLabel.TabIndex = 20;
            checkDLabel.Text = "Check D:";
            // 
            // btUpdateCompany
            // 
            this.btUpdateCompany.Location = new System.Drawing.Point(4, 30);
            this.btUpdateCompany.Name = "btUpdateCompany";
            this.btUpdateCompany.Size = new System.Drawing.Size(131, 23);
            this.btUpdateCompany.TabIndex = 0;
            this.btUpdateCompany.Text = "Update Count Product";
            this.btUpdateCompany.Click += new System.EventHandler(this.btUpdateCompany_Click);
            // 
            // laMess1
            // 
            this.laMess1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laMess1.Location = new System.Drawing.Point(4, 2);
            this.laMess1.Name = "laMess1";
            this.laMess1.Size = new System.Drawing.Size(946, 51);
            this.laMess1.TabIndex = 1;
            this.laMess1.Text = "messger";
            // 
            // btUpdate
            // 
            this.btUpdate.Enabled = false;
            this.btUpdate.Location = new System.Drawing.Point(469, 394);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(155, 23);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Update HashNameCRC64";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btUpdateComID
            // 
            this.btUpdateComID.Enabled = false;
            this.btUpdateComID.Location = new System.Drawing.Point(469, 423);
            this.btUpdateComID.Name = "btUpdateComID";
            this.btUpdateComID.Size = new System.Drawing.Size(155, 23);
            this.btUpdateComID.TabIndex = 0;
            this.btUpdateComID.Text = "Update Company IDCRC64";
            this.btUpdateComID.Click += new System.EventHandler(this.btUpdateComID_Click);
            // 
            // btUpdateClassification
            // 
            this.btUpdateClassification.Enabled = false;
            this.btUpdateClassification.Location = new System.Drawing.Point(630, 394);
            this.btUpdateClassification.Name = "btUpdateClassification";
            this.btUpdateClassification.Size = new System.Drawing.Size(155, 23);
            this.btUpdateClassification.TabIndex = 0;
            this.btUpdateClassification.Text = "Update ClassificationIDCRC64";
            this.btUpdateClassification.Click += new System.EventHandler(this.btUpdateClassification_Click);
            // 
            // btDownloadLogo
            // 
            this.btDownloadLogo.Enabled = false;
            this.btDownloadLogo.Location = new System.Drawing.Point(469, 365);
            this.btDownloadLogo.Name = "btDownloadLogo";
            this.btDownloadLogo.Size = new System.Drawing.Size(155, 23);
            this.btDownloadLogo.TabIndex = 0;
            this.btDownloadLogo.Text = "Download Logo";
            this.btDownloadLogo.Click += new System.EventHandler(this.btDownloadLogo_Click);
            // 
            // btDownloadImage
            // 
            this.btDownloadImage.Location = new System.Drawing.Point(313, 50);
            this.btDownloadImage.Name = "btDownloadImage";
            this.btDownloadImage.Size = new System.Drawing.Size(99, 52);
            this.btDownloadImage.TabIndex = 0;
            this.btDownloadImage.Text = "Download Image ";
            this.btDownloadImage.Click += new System.EventHandler(this.btDownloadImage_Click);
            // 
            // btDownloadImg
            // 
            this.btDownloadImg.Enabled = false;
            this.btDownloadImg.Location = new System.Drawing.Point(469, 304);
            this.btDownloadImg.Name = "btDownloadImg";
            this.btDownloadImg.Size = new System.Drawing.Size(155, 23);
            this.btDownloadImg.TabIndex = 0;
            this.btDownloadImg.Text = "Dowload ImageCropAll";
            this.btDownloadImg.Click += new System.EventHandler(this.btDownloadImg_Click);
            // 
            // btDownloadImageChuaTai
            // 
            this.btDownloadImageChuaTai.Enabled = false;
            this.btDownloadImageChuaTai.Location = new System.Drawing.Point(469, 333);
            this.btDownloadImageChuaTai.Name = "btDownloadImageChuaTai";
            this.btDownloadImageChuaTai.Size = new System.Drawing.Size(155, 23);
            this.btDownloadImageChuaTai.TabIndex = 0;
            this.btDownloadImageChuaTai.Text = "Dowload ImageCrop chưa tải";
            this.btDownloadImageChuaTai.Click += new System.EventHandler(this.btDownloadImageChuaTai_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(297, 25);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(123, 20);
            this.iDTextBox.TabIndex = 14;
            this.iDTextBox.TextChanged += new System.EventHandler(this.iDTextBox_TextChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.dBTool;
            // 
            // dBTool
            // 
            this.dBTool.DataSetName = "DBTool";
            this.dBTool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager.KeywordCategoriesTableAdapter = null;
            this.tableAdapterManager.Product_ImageTableAdapter = null;
            this.tableAdapterManager.ProductClassificationTableAdapter = null;
            this.tableAdapterManager.ProductIDHashNameTableAdapter = null;
            this.tableAdapterManager.ProductImagePathTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Tool.DBToolTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_TongSanPhamBindingSource
            // 
            this.view_TongSanPhamBindingSource.DataMember = "View_TongSanPham";
            this.view_TongSanPhamBindingSource.DataSource = this.dBTool;
            // 
            // view_TongSanPhamTableAdapter
            // 
            this.view_TongSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // view_TongSanPhamValidBindingSource
            // 
            this.view_TongSanPhamValidBindingSource.DataMember = "View_TongSanPhamValid";
            this.view_TongSanPhamValidBindingSource.DataSource = this.dBTool;
            // 
            // view_TongSanPhamValidTableAdapter
            // 
            this.view_TongSanPhamValidTableAdapter.ClearBeforeFill = true;
            // 
            // productIDHashNameBindingSource
            // 
            this.productIDHashNameBindingSource.DataSource = this.dBTool;
            this.productIDHashNameBindingSource.Position = 0;
            // 
            // productIDHashNameTableAdapter
            // 
            this.productIDHashNameTableAdapter.ClearBeforeFill = true;
            // 
            // view_QueueCountBindingSource
            // 
            this.view_QueueCountBindingSource.DataSource = this.dBTool;
            this.view_QueueCountBindingSource.Position = 0;
            // 
            // view_QueueCountTableAdapter
            // 
            this.view_QueueCountTableAdapter.ClearBeforeFill = true;
            // 
            // view_VisitedCountBindingSource
            // 
            this.view_VisitedCountBindingSource.DataMember = "View_VisitedCount";
            this.view_VisitedCountBindingSource.DataSource = this.dBTool;
            // 
            // view_VisitedCountTableAdapter
            // 
            this.view_VisitedCountTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.companyBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(4, 171);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(425, 243);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheckD,
            this.colDomain,
            this.colTotalValid,
            this.colTotalProduct});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCheckD
            // 
            this.colCheckD.FieldName = "CheckD";
            this.colCheckD.Name = "colCheckD";
            this.colCheckD.OptionsColumn.FixedWidth = true;
            this.colCheckD.Visible = true;
            this.colCheckD.VisibleIndex = 0;
            this.colCheckD.Width = 60;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 1;
            this.colDomain.Width = 166;
            // 
            // colTotalValid
            // 
            this.colTotalValid.FieldName = "TotalValid";
            this.colTotalValid.Name = "colTotalValid";
            this.colTotalValid.Visible = true;
            this.colTotalValid.VisibleIndex = 2;
            this.colTotalValid.Width = 73;
            // 
            // colTotalProduct
            // 
            this.colTotalProduct.FieldName = "TotalProduct";
            this.colTotalProduct.Name = "colTotalProduct";
            this.colTotalProduct.Visible = true;
            this.colTotalProduct.VisibleIndex = 3;
            this.colTotalProduct.Width = 88;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(checkDLabel);
            this.groupControl1.Controls.Add(this.chkImageAdmin);
            this.groupControl1.Controls.Add(this.checkDCheckBox);
            this.groupControl1.Controls.Add(this.chkRedownload);
            this.groupControl1.Controls.Add(this.cboManager);
            this.groupControl1.Controls.Add(this.iDTextBox);
            this.groupControl1.Controls.Add(this.cboCommand);
            this.groupControl1.Controls.Add(this.bindingNavigator1);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.btDownloadImage);
            this.groupControl1.Location = new System.Drawing.Point(4, 52);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(434, 419);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Tải ảnh theo công ty";
            // 
            // chkImageAdmin
            // 
            this.chkImageAdmin.Location = new System.Drawing.Point(5, 78);
            this.chkImageAdmin.Name = "chkImageAdmin";
            this.chkImageAdmin.Size = new System.Drawing.Size(302, 24);
            this.chkImageAdmin.TabIndex = 21;
            this.chkImageAdmin.Text = "Chỉ download image nhập vào";
            this.chkImageAdmin.UseVisualStyleBackColor = true;
            // 
            // checkDCheckBox
            // 
            this.checkDCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.companyBindingSource, "CheckD", true));
            this.checkDCheckBox.Location = new System.Drawing.Point(68, 102);
            this.checkDCheckBox.Name = "checkDCheckBox";
            this.checkDCheckBox.Size = new System.Drawing.Size(104, 24);
            this.checkDCheckBox.TabIndex = 21;
            this.checkDCheckBox.Text = "checkBox1";
            this.checkDCheckBox.UseVisualStyleBackColor = true;
            // 
            // chkRedownload
            // 
            this.chkRedownload.Location = new System.Drawing.Point(295, 2);
            this.chkRedownload.Name = "chkRedownload";
            this.chkRedownload.Properties.Caption = "Ghi đè lại ảnh";
            this.chkRedownload.Size = new System.Drawing.Size(75, 18);
            this.chkRedownload.TabIndex = 20;
            // 
            // cboManager
            // 
            this.cboManager.DataSource = this.managerTypeBindingSource;
            this.cboManager.DisplayMember = "Name";
            this.cboManager.FormattingEnabled = true;
            this.cboManager.Location = new System.Drawing.Point(4, 51);
            this.cboManager.Name = "cboManager";
            this.cboManager.Size = new System.Drawing.Size(121, 21);
            this.cboManager.TabIndex = 19;
            this.cboManager.ValueMember = "ID";
            this.cboManager.SelectedIndexChanged += new System.EventHandler(this.cboManager_SelectedIndexChanged);
            // 
            // managerTypeBindingSource
            // 
            this.managerTypeBindingSource.DataMember = "ManagerType";
            this.managerTypeBindingSource.DataSource = this.dBTool;
            // 
            // cboCommand
            // 
            this.cboCommand.EditValue = "Current Not Valid";
            this.cboCommand.Location = new System.Drawing.Point(131, 51);
            this.cboCommand.Name = "cboCommand";
            this.cboCommand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCommand.Properties.Items.AddRange(new object[] {
            "Current Not Valid",
            "Current All",
            "All Check Not Valid",
            "All Check",
            "ConfigAnanytic",
            "ReDownloadNotValid"});
            this.cboCommand.Size = new System.Drawing.Size(176, 20);
            this.cboCommand.TabIndex = 18;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.companyBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
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
            this.btCheckAll});
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 22);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(430, 25);
            this.bindingNavigator1.TabIndex = 17;
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
            // btCheckAll
            // 
            this.btCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("btCheckAll.Image")));
            this.btCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCheckAll.Name = "btCheckAll";
            this.btCheckAll.Size = new System.Drawing.Size(58, 22);
            this.btCheckAll.Text = "CheckAll";
            this.btCheckAll.Click += new System.EventHandler(this.btCheckAll_Click);
            // 
            // ctrLogMananger1
            // 
            this.ctrLogMananger1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrLogMananger1.Location = new System.Drawing.Point(435, 52);
            this.ctrLogMananger1.Name = "ctrLogMananger1";
            this.ctrLogMananger1.Size = new System.Drawing.Size(515, 419);
            this.ctrLogMananger1.TabIndex = 17;
            // 
            // managerTypeTableAdapter
            // 
            this.managerTypeTableAdapter.ClearBeforeFill = true;
            // 
            // btUpdateSizeImage
            // 
            this.btUpdateSizeImage.Location = new System.Drawing.Point(141, 30);
            this.btUpdateSizeImage.Name = "btUpdateSizeImage";
            this.btUpdateSizeImage.Size = new System.Drawing.Size(131, 23);
            this.btUpdateSizeImage.TabIndex = 0;
            this.btUpdateSizeImage.Text = "Update search product";
            this.btUpdateSizeImage.Click += new System.EventHandler(this.btUpdateSizeImage_Click);
            // 
            // btUpdateCountSearch
            // 
            this.btUpdateCountSearch.Location = new System.Drawing.Point(278, 30);
            this.btUpdateCountSearch.Name = "btUpdateCountSearch";
            this.btUpdateCountSearch.Size = new System.Drawing.Size(131, 23);
            this.btUpdateCountSearch.TabIndex = 0;
            this.btUpdateCountSearch.Text = "Update Count Search";
            this.btUpdateCountSearch.Click += new System.EventHandler(this.btUpdateCountSearch_Click);
            // 
            // btDeleteTrungten
            // 
            this.btDeleteTrungten.Location = new System.Drawing.Point(415, 30);
            this.btDeleteTrungten.Name = "btDeleteTrungten";
            this.btDeleteTrungten.Size = new System.Drawing.Size(209, 23);
            this.btDeleteTrungten.TabIndex = 0;
            this.btDeleteTrungten.Text = "Delete sản phẩm trùng tên";
            this.btDeleteTrungten.Click += new System.EventHandler(this.btDeleteTrungten_Click);
            // 
            // btUpDateViewCompany
            // 
            this.btUpDateViewCompany.Location = new System.Drawing.Point(630, 30);
            this.btUpDateViewCompany.Name = "btUpDateViewCompany";
            this.btUpDateViewCompany.Size = new System.Drawing.Size(131, 23);
            this.btUpDateViewCompany.TabIndex = 0;
            this.btUpDateViewCompany.Text = "Update ViewCompany";
            this.btUpDateViewCompany.Click += new System.EventHandler(this.btUpDateViewCompany_Click);
            // 
            // frmToolMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(954, 474);
            this.Controls.Add(this.btDeleteTrungten);
            this.Controls.Add(this.btUpdateCountSearch);
            this.Controls.Add(this.btUpdateSizeImage);
            this.Controls.Add(this.btUpDateViewCompany);
            this.Controls.Add(this.btUpdateCompany);
            this.Controls.Add(this.ctrLogMananger1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.laMess1);
            this.Controls.Add(this.btUpdateComID);
            this.Controls.Add(this.btUpdateClassification);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDownloadImageChuaTai);
            this.Controls.Add(this.btDownloadImg);
            this.Controls.Add(this.btDownloadLogo);
            this.Name = "frmToolMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmToolMain_FormClosing);
            this.Load += new System.EventHandler(this.frmToolMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TongSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TongSanPhamValidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIDHashNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_QueueCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_VisitedCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkRedownload.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCommand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btUpdateCompany;
        private DBTool dBTool;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DBToolTableAdapters.CompanyTableAdapter companyTableAdapter;
        private DBToolTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource view_TongSanPhamBindingSource;
        private DBToolTableAdapters.View_TongSanPhamTableAdapter view_TongSanPhamTableAdapter;
        private System.Windows.Forms.BindingSource view_TongSanPhamValidBindingSource;
        private DBToolTableAdapters.View_TongSanPhamValidTableAdapter view_TongSanPhamValidTableAdapter;
        private System.Windows.Forms.Label laMess1;
        private DevExpress.XtraEditors.SimpleButton btUpdate;
        private System.Windows.Forms.BindingSource productIDHashNameBindingSource;
        private DBToolTableAdapters.ProductIDHashNameTableAdapter productIDHashNameTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btUpdateComID;
        private DevExpress.XtraEditors.SimpleButton btUpdateClassification;
        private System.Windows.Forms.BindingSource view_QueueCountBindingSource;
        private DBToolTableAdapters.View_QueueCountTableAdapter view_QueueCountTableAdapter;
        private System.Windows.Forms.BindingSource view_VisitedCountBindingSource;
        private DBToolTableAdapters.View_VisitedCountTableAdapter view_VisitedCountTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btDownloadLogo;
        private DevExpress.XtraEditors.SimpleButton btDownloadImage;
        private DevExpress.XtraEditors.SimpleButton btDownloadImg;
        private DevExpress.XtraEditors.SimpleButton btDownloadImageChuaTai;
        private System.Windows.Forms.TextBox iDTextBox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValid;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduct;
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
        private Company.ctrLogMananger ctrLogMananger1;
        private DevExpress.XtraEditors.ComboBoxEdit cboCommand;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckD;
        private System.Windows.Forms.ToolStripButton btCheckAll;
        private System.Windows.Forms.ComboBox cboManager;
        private System.Windows.Forms.BindingSource managerTypeBindingSource;
        private DBToolTableAdapters.ManagerTypeTableAdapter managerTypeTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btUpdateSizeImage;
        private DevExpress.XtraEditors.CheckEdit chkRedownload;
        private System.Windows.Forms.CheckBox checkDCheckBox;
        private DevExpress.XtraEditors.SimpleButton btUpdateCountSearch;
        private DevExpress.XtraEditors.SimpleButton btDeleteTrungten;
        private DevExpress.XtraEditors.SimpleButton btUpDateViewCompany;
        private System.Windows.Forms.CheckBox chkImageAdmin;
    }
}
