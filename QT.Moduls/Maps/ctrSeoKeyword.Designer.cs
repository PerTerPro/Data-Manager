namespace QT.Moduls.Maps
{
    partial class ctrSeoKeyword
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label sapoLabel;
            System.Windows.Forms.Label sEOUpdateLabel;
            System.Windows.Forms.Label keyNameLabel;
            System.Windows.Forms.Label keyLienQuanLabel;
            System.Windows.Forms.Label keyHashLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrSeoKeyword));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.keywordsSeoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kW = new QT.Moduls.Data.KW();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtClick = new System.Windows.Forms.ToolStripTextBox();
            this.btLoad = new System.Windows.Forms.ToolStripButton();
            this.btXemNoiDung = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.gridKe = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKeyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyFreq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyClick = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSapo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEOUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyLienQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyCat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanonical = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.keywordsSeoTableAdapter = new QT.Moduls.Data.KWTableAdapters.KeywordsSeoTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Data.KWTableAdapters.TableAdapterManager();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.sapoTextBox = new System.Windows.Forms.TextBox();
            this.sEOUpdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.keyNameTextBox = new System.Windows.Forms.TextBox();
            this.keyLienQuanTextBox = new System.Windows.Forms.TextBox();
            this.latitle = new System.Windows.Forms.Label();
            this.lasapo = new System.Windows.Forms.Label();
            this.lakey = new System.Windows.Forms.Label();
            this.keyHashTextBox = new System.Windows.Forms.TextBox();
            titleLabel = new System.Windows.Forms.Label();
            sapoLabel = new System.Windows.Forms.Label();
            sEOUpdateLabel = new System.Windows.Forms.Label();
            keyNameLabel = new System.Windows.Forms.Label();
            keyLienQuanLabel = new System.Windows.Forms.Label();
            keyHashLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsSeoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(6, 31);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 16;
            titleLabel.Text = "Title:";
            // 
            // sapoLabel
            // 
            sapoLabel.AutoSize = true;
            sapoLabel.Location = new System.Drawing.Point(1, 57);
            sapoLabel.Name = "sapoLabel";
            sapoLabel.Size = new System.Drawing.Size(35, 13);
            sapoLabel.TabIndex = 17;
            sapoLabel.Text = "Sapo:";
            // 
            // sEOUpdateLabel
            // 
            sEOUpdateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sEOUpdateLabel.AutoSize = true;
            sEOUpdateLabel.Location = new System.Drawing.Point(648, 32);
            sEOUpdateLabel.Name = "sEOUpdateLabel";
            sEOUpdateLabel.Size = new System.Drawing.Size(67, 13);
            sEOUpdateLabel.TabIndex = 18;
            sEOUpdateLabel.Text = "SEOUpdate:";
            // 
            // keyNameLabel
            // 
            keyNameLabel.AutoSize = true;
            keyNameLabel.Location = new System.Drawing.Point(32, 152);
            keyNameLabel.Name = "keyNameLabel";
            keyNameLabel.Size = new System.Drawing.Size(59, 13);
            keyNameLabel.TabIndex = 19;
            keyNameLabel.Text = "Key Name:";
            // 
            // keyLienQuanLabel
            // 
            keyLienQuanLabel.Location = new System.Drawing.Point(6, 100);
            keyLienQuanLabel.Name = "keyLienQuanLabel";
            keyLienQuanLabel.Size = new System.Drawing.Size(115, 40);
            keyLienQuanLabel.TabIndex = 20;
            keyLienQuanLabel.Text = "Key Lien Quan cách nhau bằng dấu phẩy";
            // 
            // keyHashLabel
            // 
            keyHashLabel.AutoSize = true;
            keyHashLabel.Location = new System.Drawing.Point(203, 152);
            keyHashLabel.Name = "keyHashLabel";
            keyHashLabel.Size = new System.Drawing.Size(56, 13);
            keyHashLabel.TabIndex = 22;
            keyHashLabel.Text = "Key Hash:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.keywordsSeoBindingSource;
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
            this.toolStripLabel1,
            this.txtClick,
            this.btLoad,
            this.btXemNoiDung,
            this.btSave});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(819, 25);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // keywordsSeoBindingSource
            // 
            this.keywordsSeoBindingSource.DataMember = "KeywordsSeo";
            this.keywordsSeoBindingSource.DataSource = this.kW;
            // 
            // kW
            // 
            this.kW.DataSetName = "KW";
            this.kW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "Số Click";
            // 
            // txtClick
            // 
            this.txtClick.Name = "txtClick";
            this.txtClick.Size = new System.Drawing.Size(40, 25);
            this.txtClick.Text = "20";
            // 
            // btLoad
            // 
            this.btLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btLoad.Image = ((System.Drawing.Image)(resources.GetObject("btLoad.Image")));
            this.btLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(37, 22);
            this.btLoad.Text = "Load";
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btXemNoiDung
            // 
            this.btXemNoiDung.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btXemNoiDung.Image = ((System.Drawing.Image)(resources.GetObject("btXemNoiDung.Image")));
            this.btXemNoiDung.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btXemNoiDung.Name = "btXemNoiDung";
            this.btXemNoiDung.Size = new System.Drawing.Size(111, 22);
            this.btXemNoiDung.Text = "Xem nội dung web";
            this.btXemNoiDung.Click += new System.EventHandler(this.btXemNoiDung_Click);
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(23, 22);
            this.btSave.Text = "Lưu dữ liệu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // gridKe
            // 
            this.gridKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridKe.DataSource = this.keywordsSeoBindingSource;
            this.gridKe.Location = new System.Drawing.Point(1, 149);
            this.gridKe.MainView = this.gridView2;
            this.gridKe.Name = "gridKe";
            this.gridKe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridKe.Size = new System.Drawing.Size(818, 399);
            this.gridKe.TabIndex = 15;
            this.gridKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridKe.DoubleClick += new System.EventHandler(this.gridKe_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKeyName,
            this.colKeyFreq,
            this.colKeyClick,
            this.colTitle,
            this.colSapo,
            this.colSEOUpdate,
            this.colKeyLienQuan,
            this.colKeyCat,
            this.colCanonical,
            this.gridColumn2});
            this.gridView2.GridControl = this.gridKe;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colKeyName
            // 
            this.colKeyName.FieldName = "KeyName";
            this.colKeyName.Name = "colKeyName";
            this.colKeyName.OptionsColumn.AllowEdit = false;
            this.colKeyName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colKeyName.Visible = true;
            this.colKeyName.VisibleIndex = 0;
            this.colKeyName.Width = 101;
            // 
            // colKeyFreq
            // 
            this.colKeyFreq.Caption = "số kq tìm thấy";
            this.colKeyFreq.FieldName = "KeyFreq";
            this.colKeyFreq.Name = "colKeyFreq";
            this.colKeyFreq.OptionsColumn.AllowEdit = false;
            this.colKeyFreq.OptionsColumn.FixedWidth = true;
            this.colKeyFreq.Visible = true;
            this.colKeyFreq.VisibleIndex = 9;
            // 
            // colKeyClick
            // 
            this.colKeyClick.Caption = "view/month";
            this.colKeyClick.FieldName = "KeyClick";
            this.colKeyClick.Name = "colKeyClick";
            this.colKeyClick.OptionsColumn.AllowEdit = false;
            this.colKeyClick.OptionsColumn.FixedWidth = true;
            this.colKeyClick.Visible = true;
            this.colKeyClick.VisibleIndex = 3;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 5;
            this.colTitle.Width = 86;
            // 
            // colSapo
            // 
            this.colSapo.FieldName = "Sapo";
            this.colSapo.Name = "colSapo";
            this.colSapo.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSapo.Visible = true;
            this.colSapo.VisibleIndex = 6;
            this.colSapo.Width = 86;
            // 
            // colSEOUpdate
            // 
            this.colSEOUpdate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colSEOUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSEOUpdate.FieldName = "SEOUpdate";
            this.colSEOUpdate.Name = "colSEOUpdate";
            this.colSEOUpdate.OptionsColumn.FixedWidth = true;
            this.colSEOUpdate.Visible = true;
            this.colSEOUpdate.VisibleIndex = 8;
            // 
            // colKeyLienQuan
            // 
            this.colKeyLienQuan.FieldName = "KeyLienQuan";
            this.colKeyLienQuan.Name = "colKeyLienQuan";
            this.colKeyLienQuan.Visible = true;
            this.colKeyLienQuan.VisibleIndex = 7;
            this.colKeyLienQuan.Width = 104;
            // 
            // colKeyCat
            // 
            this.colKeyCat.Caption = "Cat";
            this.colKeyCat.FieldName = "KeyCat";
            this.colKeyCat.Name = "colKeyCat";
            this.colKeyCat.OptionsColumn.FixedWidth = true;
            this.colKeyCat.Visible = true;
            this.colKeyCat.VisibleIndex = 4;
            this.colKeyCat.Width = 40;
            // 
            // colCanonical
            // 
            this.colCanonical.Caption = "Canonical";
            this.colCanonical.FieldName = "Canonical";
            this.colCanonical.Name = "colCanonical";
            this.colCanonical.Visible = true;
            this.colCanonical.VisibleIndex = 1;
            this.colCanonical.Width = 104;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "NoFollow";
            this.gridColumn2.FieldName = "NoFollow";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 53;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // keywordsSeoTableAdapter
            // 
            this.keywordsSeoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Keywords_SeoTableAdapter = null;
            this.tableAdapterManager.KeywordsExportTableAdapter = null;
            this.tableAdapterManager.KeywordsSeoTableAdapter = this.keywordsSeoTableAdapter;
            this.tableAdapterManager.KeywordsTableAdapter = null;
            this.tableAdapterManager.KeywordsTempTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Data.KWTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsSeoBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(42, 28);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(560, 20);
            this.titleTextBox.TabIndex = 17;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // sapoTextBox
            // 
            this.sapoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sapoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsSeoBindingSource, "Sapo", true));
            this.sapoTextBox.Location = new System.Drawing.Point(42, 54);
            this.sapoTextBox.Multiline = true;
            this.sapoTextBox.Name = "sapoTextBox";
            this.sapoTextBox.ReadOnly = true;
            this.sapoTextBox.Size = new System.Drawing.Size(715, 43);
            this.sapoTextBox.TabIndex = 18;
            this.sapoTextBox.TextChanged += new System.EventHandler(this.sapoTextBox_TextChanged);
            // 
            // sEOUpdateDateTimePicker
            // 
            this.sEOUpdateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sEOUpdateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.sEOUpdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keywordsSeoBindingSource, "SEOUpdate", true));
            this.sEOUpdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sEOUpdateDateTimePicker.Location = new System.Drawing.Point(721, 28);
            this.sEOUpdateDateTimePicker.Name = "sEOUpdateDateTimePicker";
            this.sEOUpdateDateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.sEOUpdateDateTimePicker.TabIndex = 19;
            // 
            // keyNameTextBox
            // 
            this.keyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsSeoBindingSource, "KeyName", true));
            this.keyNameTextBox.Location = new System.Drawing.Point(97, 149);
            this.keyNameTextBox.Name = "keyNameTextBox";
            this.keyNameTextBox.ReadOnly = true;
            this.keyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyNameTextBox.TabIndex = 20;
            // 
            // keyLienQuanTextBox
            // 
            this.keyLienQuanTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyLienQuanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsSeoBindingSource, "KeyLienQuan", true));
            this.keyLienQuanTextBox.Location = new System.Drawing.Point(127, 100);
            this.keyLienQuanTextBox.Multiline = true;
            this.keyLienQuanTextBox.Name = "keyLienQuanTextBox";
            this.keyLienQuanTextBox.ReadOnly = true;
            this.keyLienQuanTextBox.Size = new System.Drawing.Size(630, 40);
            this.keyLienQuanTextBox.TabIndex = 21;
            this.keyLienQuanTextBox.TextChanged += new System.EventHandler(this.keyLienQuanTextBox_TextChanged);
            // 
            // latitle
            // 
            this.latitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.latitle.AutoSize = true;
            this.latitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitle.Location = new System.Drawing.Point(609, 31);
            this.latitle.Name = "latitle";
            this.latitle.Size = new System.Drawing.Size(26, 17);
            this.latitle.TabIndex = 22;
            this.latitle.Text = "10";
            // 
            // lasapo
            // 
            this.lasapo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lasapo.AutoSize = true;
            this.lasapo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasapo.Location = new System.Drawing.Point(763, 57);
            this.lasapo.Name = "lasapo";
            this.lasapo.Size = new System.Drawing.Size(52, 17);
            this.lasapo.TabIndex = 22;
            this.lasapo.Text = "label1";
            // 
            // lakey
            // 
            this.lakey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lakey.AutoSize = true;
            this.lakey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lakey.Location = new System.Drawing.Point(763, 103);
            this.lakey.Name = "lakey";
            this.lakey.Size = new System.Drawing.Size(52, 17);
            this.lakey.TabIndex = 22;
            this.lakey.Text = "label1";
            // 
            // keyHashTextBox
            // 
            this.keyHashTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsSeoBindingSource, "KeyHash", true));
            this.keyHashTextBox.Location = new System.Drawing.Point(265, 149);
            this.keyHashTextBox.Name = "keyHashTextBox";
            this.keyHashTextBox.ReadOnly = true;
            this.keyHashTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyHashTextBox.TabIndex = 23;
            // 
            // ctrSeoKeyword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lakey);
            this.Controls.Add(this.lasapo);
            this.Controls.Add(this.latitle);
            this.Controls.Add(keyLienQuanLabel);
            this.Controls.Add(this.keyLienQuanTextBox);
            this.Controls.Add(sEOUpdateLabel);
            this.Controls.Add(this.sEOUpdateDateTimePicker);
            this.Controls.Add(sapoLabel);
            this.Controls.Add(this.sapoTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.gridKe);
            this.Controls.Add(keyHashLabel);
            this.Controls.Add(this.keyHashTextBox);
            this.Controls.Add(keyNameLabel);
            this.Controls.Add(this.keyNameTextBox);
            this.Name = "ctrSeoKeyword";
            this.Size = new System.Drawing.Size(819, 551);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsSeoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraGrid.GridControl gridKe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private System.Windows.Forms.BindingSource keywordsSeoBindingSource;
        private Data.KW kW;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyName;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyFreq;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyClick;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colSapo;
        private DevExpress.XtraGrid.Columns.GridColumn colSEOUpdate;
        private Data.KWTableAdapters.KeywordsSeoTableAdapter keywordsSeoTableAdapter;
        private System.Windows.Forms.ToolStripButton btLoad;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtClick;
        private Data.KWTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox sapoTextBox;
        private System.Windows.Forms.DateTimePicker sEOUpdateDateTimePicker;
        private System.Windows.Forms.ToolStripButton btXemNoiDung;
        private System.Windows.Forms.TextBox keyNameTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyLienQuan;
        private System.Windows.Forms.TextBox keyLienQuanTextBox;
        private System.Windows.Forms.Label latitle;
        private System.Windows.Forms.Label lasapo;
        private System.Windows.Forms.Label lakey;
        private System.Windows.Forms.TextBox keyHashTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyCat;
        private System.Windows.Forms.ToolStripButton btSave;
        private DevExpress.XtraGrid.Columns.GridColumn colCanonical;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
