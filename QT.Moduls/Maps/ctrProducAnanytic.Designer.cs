namespace QT.Moduls.Maps
{
    partial class ctrProducAnanytic
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label tongSanPhamLabel;
            System.Windows.Forms.Label giaNhoNhatLabel;
            System.Windows.Forms.Label giaLonNhatLabel;
            System.Windows.Forms.Label lastUpdateLabel;
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrProducAnanytic));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.productAnanyticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPMan = new QT.Moduls.Maps.DBPMan();
            this.product_KeyComparisonTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.Product_KeyComparisonTableAdapter();
            this.product_KeyComparisonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.productAnanyticTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.ProductAnanyticTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Maps.DBPManTableAdapters.TableAdapterManager();
            this.priceMaximum = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.priceMinium = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNotKeywordLike = new DevExpress.XtraEditors.TextEdit();
            this.txtKeywordLike = new DevExpress.XtraEditors.TextEdit();
            this.detailUrlTextBox = new System.Windows.Forms.TextBox();
            this.btGetCode = new DevExpress.XtraEditors.SimpleButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.txttcode = new DevExpress.XtraEditors.TextEdit();
            this.btCodeAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btGetPriceMin = new DevExpress.XtraEditors.SimpleButton();
            this.btGetPriceMax = new DevExpress.XtraEditors.SimpleButton();
            this.priceProduct = new DevExpress.XtraEditors.SpinEdit();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btAnaytic = new System.Windows.Forms.ToolStripButton();
            this.btUpDate = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btMapCurrentID = new System.Windows.Forms.ToolStripButton();
            this.btRemoveID = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.txtNotLikeKeywordOneCharTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtLikeCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tongSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.lastUpdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.spGiaNhoNhat = new DevExpress.XtraEditors.SpinEdit();
            this.spGiaLonNhat = new DevExpress.XtraEditors.SpinEdit();
            this.getByProductIDCheckBox = new System.Windows.Forms.CheckBox();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductIDMerchant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productIDTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.ProductIDTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            tongSanPhamLabel = new System.Windows.Forms.Label();
            giaNhoNhatLabel = new System.Windows.Forms.Label();
            giaLonNhatLabel = new System.Windows.Forms.Label();
            lastUpdateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAnanyticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_KeyComparisonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMaximum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMinium.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotKeywordLike.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeywordLike.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotLikeKeywordOneCharTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLikeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGiaNhoNhat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGiaLonNhat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(38, 138);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "Name:";
            // 
            // tongSanPhamLabel
            // 
            tongSanPhamLabel.AutoSize = true;
            tongSanPhamLabel.Enabled = false;
            tongSanPhamLabel.Location = new System.Drawing.Point(9, 164);
            tongSanPhamLabel.Name = "tongSanPhamLabel";
            tongSanPhamLabel.Size = new System.Drawing.Size(87, 13);
            tongSanPhamLabel.TabIndex = 30;
            tongSanPhamLabel.Text = "Tong San Pham:";
            // 
            // giaNhoNhatLabel
            // 
            giaNhoNhatLabel.AutoSize = true;
            giaNhoNhatLabel.Enabled = false;
            giaNhoNhatLabel.Location = new System.Drawing.Point(208, 164);
            giaNhoNhatLabel.Name = "giaNhoNhatLabel";
            giaNhoNhatLabel.Size = new System.Drawing.Size(75, 13);
            giaNhoNhatLabel.TabIndex = 31;
            giaNhoNhatLabel.Text = "Gia Nho Nhat:";
            // 
            // giaLonNhatLabel
            // 
            giaLonNhatLabel.AutoSize = true;
            giaLonNhatLabel.Enabled = false;
            giaLonNhatLabel.Location = new System.Drawing.Point(398, 164);
            giaLonNhatLabel.Name = "giaLonNhatLabel";
            giaLonNhatLabel.Size = new System.Drawing.Size(73, 13);
            giaLonNhatLabel.TabIndex = 32;
            giaLonNhatLabel.Text = "Gia Lon Nhat:";
            // 
            // lastUpdateLabel
            // 
            lastUpdateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lastUpdateLabel.AutoSize = true;
            lastUpdateLabel.Location = new System.Drawing.Point(721, 61);
            lastUpdateLabel.Name = "lastUpdateLabel";
            lastUpdateLabel.Size = new System.Drawing.Size(68, 13);
            lastUpdateLabel.TabIndex = 33;
            lastUpdateLabel.Text = "Last Update:";
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colLastUpdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colLastUpdate.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colLastUpdate.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colLastUpdate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colLastUpdate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colLastUpdate.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colLastUpdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colLastUpdate.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colLastUpdate.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colLastUpdate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colLastUpdate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colLastUpdate.DisplayFormat.FormatString = "dd/MM/yyy";
            this.colLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colLastUpdate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colLastUpdate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colLastUpdate.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colLastUpdate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colLastUpdate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colLastUpdate.OptionsColumn.FixedWidth = true;
            this.colLastUpdate.OptionsColumn.ReadOnly = true;
            this.colLastUpdate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colLastUpdate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colLastUpdate.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colLastUpdate.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colLastUpdate.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colLastUpdate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colLastUpdate.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 3;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colPrice.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colPrice.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colPrice.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colPrice.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colPrice.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colPrice.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colPrice.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colPrice.DisplayFormat.FormatString = "n0";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colPrice.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colPrice.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colPrice.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colPrice.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colPrice.OptionsColumn.FixedWidth = true;
            this.colPrice.OptionsColumn.ReadOnly = true;
            this.colPrice.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colPrice.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colPrice.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colPrice.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colPrice.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colPrice.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colPrice.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // colName
            // 
            this.colName.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colName.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colName.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colName.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colName.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colName.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colName.FieldName = "Name";
            this.colName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colName.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colName.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colName.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colName.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colName.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView2.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView2.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView2.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView2.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView2.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colPrice,
            this.colLastUpdate,
            this.colProductID});
            this.gridView2.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded;
            this.gridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.Default;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.Default;
            this.gridView2.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll;
            this.gridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default;
            this.gridView2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.Default;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            this.gridView2.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.Default;
            this.gridView2.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Default;
            this.gridView2.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Default;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colProductID
            // 
            this.colProductID.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colProductID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colProductID.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colProductID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colProductID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colProductID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colProductID.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colProductID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colProductID.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colProductID.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colProductID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colProductID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colProductID.FieldName = "ProductID";
            this.colProductID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colProductID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colProductID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colProductID.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colProductID.Name = "colProductID";
            this.colProductID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductID.OptionsColumn.FixedWidth = true;
            this.colProductID.OptionsColumn.ReadOnly = true;
            this.colProductID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colProductID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colProductID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colProductID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colProductID.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.gridControl2.DataSource = this.productAnanyticBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.gridControl2.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridControl2.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridControl2.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridControl2.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridControl2.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridControl2.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridControl2.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.gridControl2.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.gridControl2.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(898, 333);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // productAnanyticBindingSource
            // 
            this.productAnanyticBindingSource.DataMember = "ProductAnanytic";
            this.productAnanyticBindingSource.DataSource = this.dBPMan;
            // 
            // dBPMan
            // 
            this.dBPMan.DataSetName = "DBPMan";
            this.dBPMan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_KeyComparisonTableAdapter
            // 
            this.product_KeyComparisonTableAdapter.ClearBeforeFill = true;
            // 
            // product_KeyComparisonBindingSource
            // 
            this.product_KeyComparisonBindingSource.DataMember = "Product_KeyComparison";
            this.product_KeyComparisonBindingSource.DataSource = this.dBPMan;
            // 
            // labelControl6
            // 
            this.labelControl6.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.labelControl6.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.labelControl6.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.labelControl6.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.labelControl6.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.labelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Default;
            this.labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None;
            this.labelControl6.LineLocation = DevExpress.XtraEditors.LineLocation.Default;
            this.labelControl6.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Default;
            this.labelControl6.Location = new System.Drawing.Point(1, 6);
            this.labelControl6.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Mã sản phẩm";
            this.labelControl6.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // txtCode
            // 
            this.txtCode.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.product_KeyComparisonBindingSource, "Code", true));
            this.txtCode.Location = new System.Drawing.Point(225, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.txtCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.txtCode.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtCode.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtCode.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtCode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtCode.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtCode.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtCode.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtCode.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtCode.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtCode.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtCode.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtCode.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtCode.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtCode.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtCode.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtCode.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtCode.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtCode.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtCode.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtCode.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtCode.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtCode.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtCode.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCode.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtCode.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.txtCode.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.txtCode.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.txtCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtCode.Size = new System.Drawing.Size(547, 20);
            this.txtCode.TabIndex = 0;
            this.txtCode.ToolTip = "Nhập vào mã duy nhất của sản phẩm";
            this.txtCode.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // productAnanyticTableAdapter
            // 
            this.productAnanyticTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.NewsTableAdapter = null;
            this.tableAdapterManager.Product_KeyComparisonTableAdapter = this.product_KeyComparisonTableAdapter;
            this.tableAdapterManager.Product_PropertiesTableAdapter = null;
            this.tableAdapterManager.ProductAnanyticTableAdapter = this.productAnanyticTableAdapter;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductStatusTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Maps.DBPManTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // priceMaximum
            // 
            this.priceMaximum.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.priceMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceMaximum.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.product_KeyComparisonBindingSource, "PriceMax", true));
            this.priceMaximum.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.priceMaximum.Location = new System.Drawing.Point(813, 29);
            this.priceMaximum.Name = "priceMaximum";
            this.priceMaximum.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.priceMaximum.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.priceMaximum.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceMaximum.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceMaximum.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceMaximum.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceMaximum.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceMaximum.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceMaximum.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceMaximum.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceMaximum.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceMaximum.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceMaximum.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceMaximum.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceMaximum.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceMaximum.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceMaximum.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceMaximum.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceMaximum.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceMaximum.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceMaximum.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceMaximum.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceMaximum.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceMaximum.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceMaximum.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceMaximum.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceMaximum.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            serializableAppearanceObject6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceMaximum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.priceMaximum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.priceMaximum.Properties.DisplayFormat.FormatString = "n0";
            this.priceMaximum.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.priceMaximum.Properties.EditFormat.FormatString = "n0";
            this.priceMaximum.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.priceMaximum.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.priceMaximum.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.priceMaximum.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.priceMaximum.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.priceMaximum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.priceMaximum.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical;
            this.priceMaximum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.priceMaximum.Size = new System.Drawing.Size(86, 20);
            this.priceMaximum.TabIndex = 5;
            this.priceMaximum.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // labelControl4
            // 
            this.labelControl4.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.labelControl4.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.labelControl4.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Default;
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Default;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Default;
            this.labelControl4.Location = new System.Drawing.Point(789, 32);
            this.labelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(18, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "đến";
            this.labelControl4.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // priceMinium
            // 
            this.priceMinium.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.priceMinium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceMinium.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.product_KeyComparisonBindingSource, "PriceMin", true));
            this.priceMinium.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.priceMinium.Location = new System.Drawing.Point(813, 3);
            this.priceMinium.Name = "priceMinium";
            this.priceMinium.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.priceMinium.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.priceMinium.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceMinium.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceMinium.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceMinium.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceMinium.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceMinium.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceMinium.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceMinium.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceMinium.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceMinium.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceMinium.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceMinium.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceMinium.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceMinium.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceMinium.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceMinium.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceMinium.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceMinium.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceMinium.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceMinium.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceMinium.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceMinium.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceMinium.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceMinium.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceMinium.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            serializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceMinium.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.priceMinium.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.priceMinium.Properties.DisplayFormat.FormatString = "n0";
            this.priceMinium.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.priceMinium.Properties.EditFormat.FormatString = "n0";
            this.priceMinium.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.priceMinium.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.priceMinium.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.priceMinium.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.priceMinium.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.priceMinium.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.priceMinium.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical;
            this.priceMinium.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.priceMinium.Size = new System.Drawing.Size(86, 20);
            this.priceMinium.TabIndex = 4;
            this.priceMinium.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // labelControl3
            // 
            this.labelControl3.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.labelControl3.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.labelControl3.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.labelControl3.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Default;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Default;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Default;
            this.labelControl3.Location = new System.Drawing.Point(778, 6);
            this.labelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Giá từ";
            this.labelControl3.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // labelControl5
            // 
            this.labelControl5.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.labelControl5.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.labelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.labelControl5.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.labelControl5.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.labelControl5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Default;
            this.labelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Default;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Default;
            this.labelControl5.Location = new System.Drawing.Point(1, 85);
            this.labelControl5.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Mã không có";
            this.labelControl5.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // txtNotKeywordLike
            // 
            this.txtNotKeywordLike.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNotKeywordLike.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotKeywordLike.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.product_KeyComparisonBindingSource, "NotLikeKeyword", true));
            this.txtNotKeywordLike.Location = new System.Drawing.Point(102, 82);
            this.txtNotKeywordLike.Name = "txtNotKeywordLike";
            this.txtNotKeywordLike.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.txtNotKeywordLike.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNotKeywordLike.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNotKeywordLike.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtNotKeywordLike.Properties.Appearance.Options.UseBackColor = true;
            this.txtNotKeywordLike.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtNotKeywordLike.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtNotKeywordLike.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtNotKeywordLike.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtNotKeywordLike.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtNotKeywordLike.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtNotKeywordLike.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtNotKeywordLike.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtNotKeywordLike.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtNotKeywordLike.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtNotKeywordLike.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtNotKeywordLike.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtNotKeywordLike.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtNotKeywordLike.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtNotKeywordLike.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtNotKeywordLike.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtNotKeywordLike.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtNotKeywordLike.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtNotKeywordLike.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtNotKeywordLike.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtNotKeywordLike.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtNotKeywordLike.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtNotKeywordLike.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtNotKeywordLike.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtNotKeywordLike.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNotKeywordLike.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtNotKeywordLike.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.txtNotKeywordLike.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.txtNotKeywordLike.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.txtNotKeywordLike.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtNotKeywordLike.Size = new System.Drawing.Size(832, 20);
            this.txtNotKeywordLike.TabIndex = 2;
            this.txtNotKeywordLike.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // txtKeywordLike
            // 
            this.txtKeywordLike.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.txtKeywordLike.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeywordLike.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.product_KeyComparisonBindingSource, "LikeKeyword", true));
            this.txtKeywordLike.Location = new System.Drawing.Point(225, 29);
            this.txtKeywordLike.Name = "txtKeywordLike";
            this.txtKeywordLike.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.txtKeywordLike.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.txtKeywordLike.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtKeywordLike.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtKeywordLike.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtKeywordLike.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtKeywordLike.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtKeywordLike.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtKeywordLike.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtKeywordLike.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtKeywordLike.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtKeywordLike.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtKeywordLike.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtKeywordLike.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtKeywordLike.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtKeywordLike.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtKeywordLike.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtKeywordLike.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtKeywordLike.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtKeywordLike.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtKeywordLike.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtKeywordLike.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtKeywordLike.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtKeywordLike.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtKeywordLike.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtKeywordLike.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtKeywordLike.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtKeywordLike.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKeywordLike.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtKeywordLike.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.txtKeywordLike.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.txtKeywordLike.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.txtKeywordLike.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtKeywordLike.Size = new System.Drawing.Size(547, 20);
            this.txtKeywordLike.TabIndex = 1;
            this.txtKeywordLike.ToolTip = "Tối đa 4 nội dung Cách nhau dấu phẩy , Bao gồm cả khoảng trắng";
            this.txtKeywordLike.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // detailUrlTextBox
            // 
            this.detailUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detailUrlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productAnanyticBindingSource, "DetailUrl", true));
            this.detailUrlTextBox.Location = new System.Drawing.Point(668, 135);
            this.detailUrlTextBox.Name = "detailUrlTextBox";
            this.detailUrlTextBox.Size = new System.Drawing.Size(101, 20);
            this.detailUrlTextBox.TabIndex = 20;
            // 
            // btGetCode
            // 
            this.btGetCode.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btGetCode.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btGetCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btGetCode.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btGetCode.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btGetCode.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btGetCode.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btGetCode.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btGetCode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btGetCode.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btGetCode.Location = new System.Drawing.Point(156, 3);
            this.btGetCode.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btGetCode.Name = "btGetCode";
            this.btGetCode.Size = new System.Drawing.Size(32, 22);
            this.btGetCode.TabIndex = 7;
            this.btGetCode.Text = "get";
            this.btGetCode.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btGetCode.Click += new System.EventHandler(this.btGetCode_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productAnanyticBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(82, 135);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(580, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // txttcode
            // 
            this.txttcode.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.txttcode.Location = new System.Drawing.Point(82, 3);
            this.txttcode.Name = "txttcode";
            this.txttcode.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.txttcode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.txttcode.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txttcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txttcode.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txttcode.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txttcode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txttcode.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txttcode.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txttcode.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txttcode.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txttcode.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txttcode.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txttcode.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txttcode.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txttcode.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txttcode.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txttcode.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txttcode.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txttcode.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txttcode.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txttcode.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txttcode.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txttcode.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txttcode.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txttcode.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txttcode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txttcode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txttcode.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txttcode.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.txttcode.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.txttcode.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.txttcode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txttcode.Size = new System.Drawing.Size(73, 20);
            this.txttcode.TabIndex = 22;
            this.txttcode.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // btCodeAdd
            // 
            this.btCodeAdd.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btCodeAdd.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btCodeAdd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btCodeAdd.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btCodeAdd.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btCodeAdd.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btCodeAdd.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btCodeAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btCodeAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btCodeAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btCodeAdd.Location = new System.Drawing.Point(191, 3);
            this.btCodeAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btCodeAdd.Name = "btCodeAdd";
            this.btCodeAdd.Size = new System.Drawing.Size(32, 22);
            this.btCodeAdd.TabIndex = 7;
            this.btCodeAdd.Text = "add";
            this.btCodeAdd.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btCodeAdd.Click += new System.EventHandler(this.btCodeAdd_Click);
            // 
            // btGetPriceMin
            // 
            this.btGetPriceMin.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btGetPriceMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGetPriceMin.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btGetPriceMin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btGetPriceMin.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btGetPriceMin.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btGetPriceMin.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btGetPriceMin.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btGetPriceMin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btGetPriceMin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btGetPriceMin.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btGetPriceMin.Location = new System.Drawing.Point(905, 3);
            this.btGetPriceMin.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btGetPriceMin.Name = "btGetPriceMin";
            this.btGetPriceMin.Size = new System.Drawing.Size(29, 20);
            this.btGetPriceMin.TabIndex = 7;
            this.btGetPriceMin.Text = "get";
            this.btGetPriceMin.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btGetPriceMin.Click += new System.EventHandler(this.btGetPriceMin_Click);
            // 
            // btGetPriceMax
            // 
            this.btGetPriceMax.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btGetPriceMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGetPriceMax.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btGetPriceMax.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btGetPriceMax.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btGetPriceMax.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btGetPriceMax.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btGetPriceMax.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btGetPriceMax.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btGetPriceMax.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btGetPriceMax.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btGetPriceMax.Location = new System.Drawing.Point(905, 29);
            this.btGetPriceMax.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btGetPriceMax.Name = "btGetPriceMax";
            this.btGetPriceMax.Size = new System.Drawing.Size(29, 20);
            this.btGetPriceMax.TabIndex = 8;
            this.btGetPriceMax.Text = "get";
            this.btGetPriceMax.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btGetPriceMax.Click += new System.EventHandler(this.btGetPriceMax_Click);
            // 
            // priceProduct
            // 
            this.priceProduct.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.priceProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceProduct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productAnanyticBindingSource, "Price", true));
            this.priceProduct.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.priceProduct.Location = new System.Drawing.Point(775, 135);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.priceProduct.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.priceProduct.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceProduct.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceProduct.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceProduct.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceProduct.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceProduct.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceProduct.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceProduct.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceProduct.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceProduct.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceProduct.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceProduct.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceProduct.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceProduct.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceProduct.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceProduct.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceProduct.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceProduct.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceProduct.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceProduct.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.priceProduct.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.priceProduct.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.priceProduct.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.priceProduct.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.priceProduct.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            serializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.priceProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.priceProduct.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.priceProduct.Properties.DisplayFormat.FormatString = "n0";
            this.priceProduct.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.priceProduct.Properties.EditFormat.FormatString = "n0";
            this.priceProduct.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.priceProduct.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.priceProduct.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.priceProduct.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.priceProduct.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.priceProduct.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.priceProduct.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical;
            this.priceProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.priceProduct.Size = new System.Drawing.Size(76, 20);
            this.priceProduct.TabIndex = 4;
            this.priceProduct.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.productAnanyticBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAnaytic,
            this.btUpDate,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.btMapCurrentID,
            this.btRemoveID,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 52);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(427, 25);
            this.bindingNavigator1.TabIndex = 23;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // btAnaytic
            // 
            this.btAnaytic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btAnaytic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btAnaytic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAnaytic.Image = ((System.Drawing.Image)(resources.GetObject("btAnaytic.Image")));
            this.btAnaytic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAnaytic.Name = "btAnaytic";
            this.btAnaytic.Size = new System.Drawing.Size(53, 22);
            this.btAnaytic.Text = "Ananytic";
            this.btAnaytic.Click += new System.EventHandler(this.btAnanytic_Click);
            // 
            // btUpDate
            // 
            this.btUpDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btUpDate.Image = ((System.Drawing.Image)(resources.GetObject("btUpDate.Image")));
            this.btUpDate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUpDate.Name = "btUpDate";
            this.btUpDate.Size = new System.Drawing.Size(46, 22);
            this.btUpDate.Text = "Update";
            this.btUpDate.Click += new System.EventHandler(this.btUpDate_Click);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(30, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btMapCurrentID
            // 
            this.btMapCurrentID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btMapCurrentID.Image = ((System.Drawing.Image)(resources.GetObject("btMapCurrentID.Image")));
            this.btMapCurrentID.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMapCurrentID.Name = "btMapCurrentID";
            this.btMapCurrentID.Size = new System.Drawing.Size(45, 22);
            this.btMapCurrentID.Text = "Map ID";
            this.btMapCurrentID.Click += new System.EventHandler(this.btMapCurrentID_Click);
            // 
            // btRemoveID
            // 
            this.btRemoveID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btRemoveID.Image = ((System.Drawing.Image)(resources.GetObject("btRemoveID.Image")));
            this.btRemoveID.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRemoveID.Name = "btRemoveID";
            this.btRemoveID.Size = new System.Drawing.Size(64, 22);
            this.btRemoveID.Text = "Remove ID";
            this.btRemoveID.Click += new System.EventHandler(this.btRemoveID_Click);
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
            // productIDTextBox
            // 
            this.productIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productAnanyticBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(860, 135);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(74, 20);
            this.productIDTextBox.TabIndex = 29;
            // 
            // txtNotLikeKeywordOneCharTextEdit
            // 
            this.txtNotLikeKeywordOneCharTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotLikeKeywordOneCharTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.product_KeyComparisonBindingSource, "NotLikeKeywordOneChar", true));
            this.txtNotLikeKeywordOneCharTextEdit.Location = new System.Drawing.Point(102, 108);
            this.txtNotLikeKeywordOneCharTextEdit.Name = "txtNotLikeKeywordOneCharTextEdit";
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNotLikeKeywordOneCharTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.txtNotLikeKeywordOneCharTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtNotLikeKeywordOneCharTextEdit.Size = new System.Drawing.Size(832, 20);
            this.txtNotLikeKeywordOneCharTextEdit.TabIndex = 3;
            this.txtNotLikeKeywordOneCharTextEdit.ToolTip = "Tối đa 4 nội dung Cách nhau dấu phẩy , Bao gồm cả khoảng trắng";
            this.txtNotLikeKeywordOneCharTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.simpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.simpleButton1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.simpleButton1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.simpleButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.simpleButton1.Location = new System.Drawing.Point(156, 27);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(32, 22);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "get";
            this.simpleButton1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.simpleButton1.Click += new System.EventHandler(this.btGetCode_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.simpleButton2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.simpleButton2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.simpleButton2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.simpleButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.simpleButton2.Location = new System.Drawing.Point(191, 27);
            this.simpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(32, 22);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "add";
            this.simpleButton2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.simpleButton2.Click += new System.EventHandler(this.btCodeAdd_Click);
            // 
            // txtLikeCode
            // 
            this.txtLikeCode.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.txtLikeCode.Location = new System.Drawing.Point(82, 29);
            this.txtLikeCode.Name = "txtLikeCode";
            this.txtLikeCode.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.txtLikeCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.txtLikeCode.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtLikeCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtLikeCode.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtLikeCode.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtLikeCode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtLikeCode.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtLikeCode.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtLikeCode.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtLikeCode.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtLikeCode.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtLikeCode.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtLikeCode.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtLikeCode.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtLikeCode.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtLikeCode.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtLikeCode.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtLikeCode.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtLikeCode.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtLikeCode.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txtLikeCode.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtLikeCode.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txtLikeCode.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txtLikeCode.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txtLikeCode.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txtLikeCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtLikeCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLikeCode.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtLikeCode.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.txtLikeCode.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.txtLikeCode.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.txtLikeCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtLikeCode.Size = new System.Drawing.Size(73, 20);
            this.txtLikeCode.TabIndex = 22;
            this.txtLikeCode.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.labelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.labelControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.labelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Default;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Default;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Default;
            this.labelControl1.Location = new System.Drawing.Point(1, 32);
            this.labelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Mã đặc biệt";
            this.labelControl1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // labelControl2
            // 
            this.labelControl2.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.labelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.labelControl2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.labelControl2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Default;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Default;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Default;
            this.labelControl2.Location = new System.Drawing.Point(1, 111);
            this.labelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Mã ko có đặc biệt";
            this.labelControl2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // tongSanPhamTextBox
            // 
            this.tongSanPhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_KeyComparisonBindingSource, "TongSanPham", true));
            this.tongSanPhamTextBox.Enabled = false;
            this.tongSanPhamTextBox.Location = new System.Drawing.Point(102, 161);
            this.tongSanPhamTextBox.Name = "tongSanPhamTextBox";
            this.tongSanPhamTextBox.Size = new System.Drawing.Size(100, 20);
            this.tongSanPhamTextBox.TabIndex = 31;
            // 
            // lastUpdateDateTimePicker
            // 
            this.lastUpdateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastUpdateDateTimePicker.CustomFormat = "dd/MM/yyyy -hh/mm";
            this.lastUpdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.product_KeyComparisonBindingSource, "LastUpdate", true));
            this.lastUpdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.lastUpdateDateTimePicker.Location = new System.Drawing.Point(795, 57);
            this.lastUpdateDateTimePicker.Name = "lastUpdateDateTimePicker";
            this.lastUpdateDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.lastUpdateDateTimePicker.TabIndex = 34;
            // 
            // spGiaNhoNhat
            // 
            this.spGiaNhoNhat.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.spGiaNhoNhat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.product_KeyComparisonBindingSource, "GiaNhoNhat", true));
            this.spGiaNhoNhat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spGiaNhoNhat.Location = new System.Drawing.Point(289, 161);
            this.spGiaNhoNhat.Name = "spGiaNhoNhat";
            this.spGiaNhoNhat.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.spGiaNhoNhat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.spGiaNhoNhat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.spGiaNhoNhat.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.spGiaNhoNhat.Properties.Appearance.Options.UseBackColor = true;
            this.spGiaNhoNhat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.spGiaNhoNhat.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.spGiaNhoNhat.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.spGiaNhoNhat.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.spGiaNhoNhat.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.spGiaNhoNhat.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.spGiaNhoNhat.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.spGiaNhoNhat.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.spGiaNhoNhat.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.spGiaNhoNhat.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.spGiaNhoNhat.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.spGiaNhoNhat.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.spGiaNhoNhat.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.spGiaNhoNhat.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.spGiaNhoNhat.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.spGiaNhoNhat.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.spGiaNhoNhat.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.spGiaNhoNhat.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.spGiaNhoNhat.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.spGiaNhoNhat.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.spGiaNhoNhat.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.spGiaNhoNhat.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.spGiaNhoNhat.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.spGiaNhoNhat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            serializableAppearanceObject3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.spGiaNhoNhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.spGiaNhoNhat.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.spGiaNhoNhat.Properties.DisplayFormat.FormatString = "n0";
            this.spGiaNhoNhat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spGiaNhoNhat.Properties.EditFormat.FormatString = "n0";
            this.spGiaNhoNhat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spGiaNhoNhat.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.spGiaNhoNhat.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.spGiaNhoNhat.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.spGiaNhoNhat.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.spGiaNhoNhat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spGiaNhoNhat.Properties.ReadOnly = true;
            this.spGiaNhoNhat.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical;
            this.spGiaNhoNhat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.spGiaNhoNhat.Size = new System.Drawing.Size(100, 20);
            this.spGiaNhoNhat.TabIndex = 35;
            this.spGiaNhoNhat.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // spGiaLonNhat
            // 
            this.spGiaLonNhat.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.spGiaLonNhat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.product_KeyComparisonBindingSource, "GiaLonNhat", true));
            this.spGiaLonNhat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spGiaLonNhat.Location = new System.Drawing.Point(477, 161);
            this.spGiaLonNhat.Name = "spGiaLonNhat";
            this.spGiaLonNhat.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.spGiaLonNhat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.spGiaLonNhat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.spGiaLonNhat.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.spGiaLonNhat.Properties.Appearance.Options.UseBackColor = true;
            this.spGiaLonNhat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.spGiaLonNhat.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.spGiaLonNhat.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.spGiaLonNhat.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.spGiaLonNhat.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.spGiaLonNhat.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.spGiaLonNhat.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.spGiaLonNhat.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.spGiaLonNhat.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.spGiaLonNhat.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.spGiaLonNhat.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.spGiaLonNhat.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.spGiaLonNhat.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.spGiaLonNhat.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.spGiaLonNhat.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.spGiaLonNhat.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.spGiaLonNhat.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.spGiaLonNhat.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.spGiaLonNhat.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.spGiaLonNhat.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.spGiaLonNhat.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.spGiaLonNhat.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.spGiaLonNhat.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.spGiaLonNhat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            serializableAppearanceObject4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.spGiaLonNhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.spGiaLonNhat.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.spGiaLonNhat.Properties.DisplayFormat.FormatString = "n0";
            this.spGiaLonNhat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spGiaLonNhat.Properties.EditFormat.FormatString = "n0";
            this.spGiaLonNhat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spGiaLonNhat.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.spGiaLonNhat.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.spGiaLonNhat.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.spGiaLonNhat.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.spGiaLonNhat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.spGiaLonNhat.Properties.ReadOnly = true;
            this.spGiaLonNhat.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical;
            this.spGiaLonNhat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.spGiaLonNhat.Size = new System.Drawing.Size(100, 20);
            this.spGiaLonNhat.TabIndex = 35;
            this.spGiaLonNhat.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // getByProductIDCheckBox
            // 
            this.getByProductIDCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.product_KeyComparisonBindingSource, "GetByProductID", true));
            this.getByProductIDCheckBox.Location = new System.Drawing.Point(442, 52);
            this.getByProductIDCheckBox.Name = "getByProductIDCheckBox";
            this.getByProductIDCheckBox.Size = new System.Drawing.Size(135, 24);
            this.getByProductIDCheckBox.TabIndex = 36;
            this.getByProductIDCheckBox.Text = "Lấy dữ liệu theo ID";
            this.getByProductIDCheckBox.UseVisualStyleBackColor = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl1.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl1.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.Default;
            this.splitContainerControl1.CaptionLocation = DevExpress.Utils.Locations.Default;
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.None;
            this.splitContainerControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel1;
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 187);
            this.splitContainerControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl1.Panel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl1.Panel1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl1.Panel1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl1.Panel1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl1.Panel1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl1.Panel1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl1.Panel1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl1.Panel1.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl1.Panel1.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl1.Panel1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl1.Panel1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl1.Panel1.CaptionLocation = DevExpress.Utils.Locations.Default;
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl1.Panel2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl1.Panel2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl1.Panel2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl1.Panel2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl1.Panel2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl1.Panel2.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl1.Panel2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl1.Panel2.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl1.Panel2.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl1.Panel2.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl1.Panel2.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl1.Panel2.CaptionLocation = DevExpress.Utils.Locations.Default;
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;
            this.splitContainerControl1.Size = new System.Drawing.Size(931, 333);
            this.splitContainerControl1.SplitterPosition = 898;
            this.splitContainerControl1.TabIndex = 37;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.gridControl1.DataSource = this.productIDBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.gridControl1.EmbeddedNavigator.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridControl1.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridControl1.EmbeddedNavigator.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridControl1.EmbeddedNavigator.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridControl1.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridControl1.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.gridControl1.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.gridControl1.EmbeddedNavigator.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(25, 333);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // productIDBindingSource
            // 
            this.productIDBindingSource.DataMember = "ProductID";
            this.productIDBindingSource.DataSource = this.dBPMan;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.CustomizationFormHint.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.DetailTip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.DetailTip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.DetailTip.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.Empty.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.Empty.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.FixedLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.FixedLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.FixedLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.FocusedCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.FocusedCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.FocusedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.FocusedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.GroupButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.GroupButton.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.GroupButton.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.GroupPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.GroupPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.GroupPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.HorzLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.HorzLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.HorzLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.RowSeparator.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.RowSeparator.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.RowSeparator.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.SelectedRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.SelectedRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.TopNewRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.TopNewRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.TopNewRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.VertLine.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.VertLine.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.AppearancePrint.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.AppearancePrint.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.AppearancePrint.FilterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.AppearancePrint.FilterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.AppearancePrint.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.AppearancePrint.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.AppearancePrint.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.AppearancePrint.GroupFooter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.AppearancePrint.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.AppearancePrint.GroupRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.AppearancePrint.GroupRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.AppearancePrint.GroupRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.AppearancePrint.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.AppearancePrint.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.AppearancePrint.Lines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.AppearancePrint.Lines.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.AppearancePrint.Lines.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.AppearancePrint.Lines.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.AppearancePrint.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.AppearancePrint.OddRow.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.AppearancePrint.OddRow.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.AppearancePrint.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.AppearancePrint.Preview.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.AppearancePrint.Preview.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.AppearancePrint.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.AppearancePrint.Row.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridView1.AppearancePrint.Row.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridView1.AppearancePrint.Row.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridView1.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridView1.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colProductID1,
            this.colProductIDMerchant,
            this.colCompanyID,
            this.colPrice1,
            this.colSTT,
            this.colViewMonth,
            this.colViewWeek,
            this.colRegion,
            this.colValid,
            this.colName1,
            this.colURL,
            this.colDomain});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.Default;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.Default;
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.CacheAll;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Default;
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.Default;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            this.gridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.Default;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Default;
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Default;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colID
            // 
            this.colID.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colID.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colID.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colID.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colID.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colID.FieldName = "ID";
            this.colID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colID.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colID.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colProductID1
            // 
            this.colProductID1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colProductID1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colProductID1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colProductID1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colProductID1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colProductID1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colProductID1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colProductID1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colProductID1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colProductID1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colProductID1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colProductID1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colProductID1.FieldName = "ProductID";
            this.colProductID1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colProductID1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colProductID1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colProductID1.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colProductID1.Name = "colProductID1";
            this.colProductID1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductID1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductID1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductID1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colProductID1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colProductID1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductID1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductID1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colProductID1.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colProductID1.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colProductID1.Visible = true;
            this.colProductID1.VisibleIndex = 1;
            // 
            // colProductIDMerchant
            // 
            this.colProductIDMerchant.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colProductIDMerchant.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colProductIDMerchant.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colProductIDMerchant.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colProductIDMerchant.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colProductIDMerchant.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colProductIDMerchant.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colProductIDMerchant.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colProductIDMerchant.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colProductIDMerchant.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colProductIDMerchant.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colProductIDMerchant.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colProductIDMerchant.FieldName = "ProductIDMerchant";
            this.colProductIDMerchant.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colProductIDMerchant.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colProductIDMerchant.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colProductIDMerchant.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colProductIDMerchant.Name = "colProductIDMerchant";
            this.colProductIDMerchant.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductIDMerchant.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductIDMerchant.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductIDMerchant.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colProductIDMerchant.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colProductIDMerchant.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductIDMerchant.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colProductIDMerchant.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colProductIDMerchant.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colProductIDMerchant.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colProductIDMerchant.Visible = true;
            this.colProductIDMerchant.VisibleIndex = 2;
            // 
            // colCompanyID
            // 
            this.colCompanyID.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colCompanyID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colCompanyID.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colCompanyID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colCompanyID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colCompanyID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colCompanyID.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colCompanyID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colCompanyID.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colCompanyID.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colCompanyID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colCompanyID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colCompanyID.FieldName = "CompanyID";
            this.colCompanyID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colCompanyID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colCompanyID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colCompanyID.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colCompanyID.Name = "colCompanyID";
            this.colCompanyID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colCompanyID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colCompanyID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colCompanyID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colCompanyID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colCompanyID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colCompanyID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colCompanyID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colCompanyID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colCompanyID.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colCompanyID.Visible = true;
            this.colCompanyID.VisibleIndex = 3;
            // 
            // colPrice1
            // 
            this.colPrice1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colPrice1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colPrice1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colPrice1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colPrice1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colPrice1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colPrice1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colPrice1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colPrice1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colPrice1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colPrice1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colPrice1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colPrice1.FieldName = "Price";
            this.colPrice1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colPrice1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colPrice1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colPrice1.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colPrice1.Name = "colPrice1";
            this.colPrice1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colPrice1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colPrice1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colPrice1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colPrice1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colPrice1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colPrice1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colPrice1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colPrice1.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colPrice1.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colPrice1.Visible = true;
            this.colPrice1.VisibleIndex = 4;
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colSTT.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colSTT.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colSTT.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colSTT.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colSTT.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colSTT.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colSTT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colSTT.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colSTT.FieldName = "STT";
            this.colSTT.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colSTT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colSTT.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colSTT.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colSTT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colSTT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colSTT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colSTT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colSTT.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colSTT.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colSTT.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colSTT.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colSTT.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 5;
            // 
            // colViewMonth
            // 
            this.colViewMonth.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colViewMonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colViewMonth.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colViewMonth.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colViewMonth.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colViewMonth.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colViewMonth.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colViewMonth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colViewMonth.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colViewMonth.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colViewMonth.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colViewMonth.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colViewMonth.FieldName = "ViewMonth";
            this.colViewMonth.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colViewMonth.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colViewMonth.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colViewMonth.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colViewMonth.Name = "colViewMonth";
            this.colViewMonth.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewMonth.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewMonth.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewMonth.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colViewMonth.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colViewMonth.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewMonth.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewMonth.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colViewMonth.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colViewMonth.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colViewMonth.Visible = true;
            this.colViewMonth.VisibleIndex = 6;
            // 
            // colViewWeek
            // 
            this.colViewWeek.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colViewWeek.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colViewWeek.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colViewWeek.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colViewWeek.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colViewWeek.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colViewWeek.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colViewWeek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colViewWeek.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colViewWeek.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colViewWeek.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colViewWeek.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colViewWeek.FieldName = "ViewWeek";
            this.colViewWeek.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colViewWeek.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colViewWeek.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colViewWeek.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colViewWeek.Name = "colViewWeek";
            this.colViewWeek.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewWeek.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewWeek.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewWeek.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colViewWeek.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colViewWeek.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewWeek.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewWeek.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colViewWeek.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colViewWeek.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colViewWeek.Visible = true;
            this.colViewWeek.VisibleIndex = 7;
            // 
            // colRegion
            // 
            this.colRegion.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colRegion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colRegion.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colRegion.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colRegion.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colRegion.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colRegion.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colRegion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colRegion.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colRegion.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colRegion.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colRegion.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colRegion.FieldName = "Region";
            this.colRegion.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colRegion.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colRegion.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colRegion.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colRegion.Name = "colRegion";
            this.colRegion.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colRegion.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colRegion.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colRegion.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colRegion.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colRegion.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colRegion.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colRegion.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colRegion.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colRegion.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colRegion.Visible = true;
            this.colRegion.VisibleIndex = 8;
            // 
            // colValid
            // 
            this.colValid.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colValid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colValid.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colValid.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colValid.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colValid.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colValid.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colValid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colValid.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colValid.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colValid.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colValid.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colValid.FieldName = "Valid";
            this.colValid.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colValid.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colValid.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colValid.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colValid.Name = "colValid";
            this.colValid.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colValid.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colValid.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colValid.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colValid.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colValid.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colValid.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colValid.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colValid.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colValid.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colValid.Visible = true;
            this.colValid.VisibleIndex = 9;
            // 
            // colName1
            // 
            this.colName1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colName1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colName1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colName1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colName1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colName1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colName1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colName1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colName1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colName1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colName1.FieldName = "Name";
            this.colName1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colName1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colName1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colName1.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colName1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colName1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colName1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colName1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colName1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colName1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colName1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colName1.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colName1.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 10;
            // 
            // colURL
            // 
            this.colURL.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colURL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colURL.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colURL.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colURL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colURL.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colURL.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colURL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colURL.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colURL.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colURL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colURL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colURL.FieldName = "URL";
            this.colURL.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colURL.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colURL.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colURL.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colURL.Name = "colURL";
            this.colURL.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colURL.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colURL.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colURL.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colURL.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colURL.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colURL.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colURL.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colURL.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colURL.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colURL.Visible = true;
            this.colURL.VisibleIndex = 11;
            // 
            // colDomain
            // 
            this.colDomain.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colDomain.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colDomain.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colDomain.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colDomain.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colDomain.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colDomain.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colDomain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colDomain.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colDomain.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colDomain.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colDomain.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colDomain.FieldName = "Domain";
            this.colDomain.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colDomain.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colDomain.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colDomain.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colDomain.Name = "colDomain";
            this.colDomain.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colDomain.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colDomain.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colDomain.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colDomain.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colDomain.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colDomain.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colDomain.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colDomain.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colDomain.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 12;
            // 
            // productIDTableAdapter
            // 
            this.productIDTableAdapter.ClearBeforeFill = true;
            // 
            // ctrProducAnanytic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.getByProductIDCheckBox);
            this.Controls.Add(this.spGiaLonNhat);
            this.Controls.Add(this.spGiaNhoNhat);
            this.Controls.Add(lastUpdateLabel);
            this.Controls.Add(this.lastUpdateDateTimePicker);
            this.Controls.Add(this.txtNotLikeKeywordOneCharTextEdit);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.txtLikeCode);
            this.Controls.Add(this.txttcode);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.detailUrlTextBox);
            this.Controls.Add(this.btGetPriceMax);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btGetPriceMin);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btCodeAdd);
            this.Controls.Add(this.btGetCode);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.priceProduct);
            this.Controls.Add(this.priceMaximum);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.priceMinium);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtNotKeywordLike);
            this.Controls.Add(this.txtKeywordLike);
            this.Controls.Add(giaLonNhatLabel);
            this.Controls.Add(giaNhoNhatLabel);
            this.Controls.Add(tongSanPhamLabel);
            this.Controls.Add(this.tongSanPhamTextBox);
            this.Name = "ctrProducAnanytic";
            this.Size = new System.Drawing.Size(937, 520);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productAnanyticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_KeyComparisonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMaximum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMinium.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotKeywordLike.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeywordLike.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotLikeKeywordOneCharTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLikeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGiaNhoNhat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGiaLonNhat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.BindingSource productAnanyticBindingSource;
        private DBPMan dBPMan;
        private DBPManTableAdapters.Product_KeyComparisonTableAdapter product_KeyComparisonTableAdapter;
        private System.Windows.Forms.BindingSource product_KeyComparisonBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DBPManTableAdapters.ProductAnanyticTableAdapter productAnanyticTableAdapter;
        private DBPManTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SpinEdit priceMaximum;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit priceMinium;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtNotKeywordLike;
        private DevExpress.XtraEditors.TextEdit txtKeywordLike;
        private System.Windows.Forms.TextBox detailUrlTextBox;
        private DevExpress.XtraEditors.SimpleButton btGetCode;
        private System.Windows.Forms.TextBox nameTextBox;
        private DevExpress.XtraEditors.TextEdit txttcode;
        private DevExpress.XtraEditors.SimpleButton btCodeAdd;
        private DevExpress.XtraEditors.SimpleButton btGetPriceMin;
        private DevExpress.XtraEditors.SimpleButton btGetPriceMax;
        private DevExpress.XtraEditors.SpinEdit priceProduct;
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
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private System.Windows.Forms.ToolStripButton btAnaytic;
        private System.Windows.Forms.ToolStripButton btUpDate;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.ToolStripButton btRemoveID;
        private System.Windows.Forms.ToolStripButton btMapCurrentID;
        private DevExpress.XtraEditors.TextEdit txtNotLikeKeywordOneCharTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit txtLikeCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox tongSanPhamTextBox;
        private System.Windows.Forms.DateTimePicker lastUpdateDateTimePicker;
        private DevExpress.XtraEditors.SpinEdit spGiaNhoNhat;
        private DevExpress.XtraEditors.SpinEdit spGiaLonNhat;
        private System.Windows.Forms.CheckBox getByProductIDCheckBox;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource productIDBindingSource;
        private DBPManTableAdapters.ProductIDTableAdapter productIDTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductIDMerchant;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colViewMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colViewWeek;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colValid;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colURL;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
    }
}
