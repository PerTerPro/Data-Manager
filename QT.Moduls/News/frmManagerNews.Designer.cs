namespace QT.Moduls.News
{
    partial class frmManagerNews
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label sapoLabel;
            System.Windows.Forms.Label cRC64Label;
            System.Windows.Forms.Label uRLLabel;
            System.Windows.Forms.Label publishedDateLabel;
            System.Windows.Forms.Label avatarLabel;
            System.Windows.Forms.Label relatedNewsLabel;
            System.Windows.Forms.Label iDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerNews));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.insertReviewCheckBox = new System.Windows.Forms.CheckBox();
            this.newsItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBNew = new QT.Moduls.News.DBNew();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btCheckAll = new System.Windows.Forms.ToolStripButton();
            this.btInsertAll = new System.Windows.Forms.ToolStripButton();
            this.btNotReview = new System.Windows.Forms.ToolStripButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsertReview = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.relatedNewsTextBox = new System.Windows.Forms.TextBox();
            this.avatarTextBox = new System.Windows.Forms.TextBox();
            this.publishedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uRLTextBox = new System.Windows.Forms.TextBox();
            this.cRC64TextBox = new System.Windows.Forms.TextBox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.keywordMapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btSaveKeyword = new System.Windows.Forms.ToolStripButton();
            this.btLoadKeyword = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.btLoadAnanytic = new DevExpress.XtraEditors.SimpleButton();
            this.btLoad = new DevExpress.XtraEditors.SimpleButton();
            this.sapoLabel1 = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.contentsTextBox = new System.Windows.Forms.TextBox();
            this.newsItemTableAdapter = new QT.Moduls.News.DBNewTableAdapters.NewsItemTableAdapter();
            this.tableAdapterManager = new QT.Moduls.News.DBNewTableAdapters.TableAdapterManager();
            this.keywordMapTableAdapter = new QT.Moduls.News.DBNewTableAdapters.KeywordMapTableAdapter();
            titleLabel = new System.Windows.Forms.Label();
            sapoLabel = new System.Windows.Forms.Label();
            cRC64Label = new System.Windows.Forms.Label();
            uRLLabel = new System.Windows.Forms.Label();
            publishedDateLabel = new System.Windows.Forms.Label();
            avatarLabel = new System.Windows.Forms.Label();
            relatedNewsLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keywordMapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(2, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // sapoLabel
            // 
            sapoLabel.AutoSize = true;
            sapoLabel.Location = new System.Drawing.Point(-3, 52);
            sapoLabel.Name = "sapoLabel";
            sapoLabel.Size = new System.Drawing.Size(35, 13);
            sapoLabel.TabIndex = 5;
            sapoLabel.Text = "Sapo:";
            // 
            // cRC64Label
            // 
            cRC64Label.AutoSize = true;
            cRC64Label.Location = new System.Drawing.Point(11, 6);
            cRC64Label.Name = "cRC64Label";
            cRC64Label.Size = new System.Drawing.Size(44, 13);
            cRC64Label.TabIndex = 2;
            cRC64Label.Text = "CRC64:";
            // 
            // uRLLabel
            // 
            uRLLabel.AutoSize = true;
            uRLLabel.Location = new System.Drawing.Point(23, 32);
            uRLLabel.Name = "uRLLabel";
            uRLLabel.Size = new System.Drawing.Size(32, 13);
            uRLLabel.TabIndex = 4;
            uRLLabel.Text = "URL:";
            // 
            // publishedDateLabel
            // 
            publishedDateLabel.AutoSize = true;
            publishedDateLabel.Location = new System.Drawing.Point(39, 59);
            publishedDateLabel.Name = "publishedDateLabel";
            publishedDateLabel.Size = new System.Drawing.Size(82, 13);
            publishedDateLabel.TabIndex = 6;
            publishedDateLabel.Text = "Published Date:";
            // 
            // avatarLabel
            // 
            avatarLabel.AutoSize = true;
            avatarLabel.Location = new System.Drawing.Point(80, 84);
            avatarLabel.Name = "avatarLabel";
            avatarLabel.Size = new System.Drawing.Size(41, 13);
            avatarLabel.TabIndex = 8;
            avatarLabel.Text = "Avatar:";
            // 
            // relatedNewsLabel
            // 
            relatedNewsLabel.AutoSize = true;
            relatedNewsLabel.Location = new System.Drawing.Point(44, 110);
            relatedNewsLabel.Name = "relatedNewsLabel";
            relatedNewsLabel.Size = new System.Drawing.Size(77, 13);
            relatedNewsLabel.TabIndex = 10;
            relatedNewsLabel.Text = "Related News:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(162, 6);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 12;
            iDLabel.Text = "ID:";
            // 
            // splitContainerControl1
            // 
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
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel1;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainerControl1.Panel1.Controls.Add(this.insertReviewCheckBox);
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtTo);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtfrom);
            this.splitContainerControl1.Panel1.Controls.Add(this.btLoadAnanytic);
            this.splitContainerControl1.Panel1.Controls.Add(this.btLoad);
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
            this.splitContainerControl1.Panel2.Controls.Add(sapoLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.sapoLabel1);
            this.splitContainerControl1.Panel2.Controls.Add(titleLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.titleLabel1);
            this.splitContainerControl1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainerControl1.Panel2.Controls.Add(this.contentsTextBox);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;
            this.splitContainerControl1.Size = new System.Drawing.Size(871, 453);
            this.splitContainerControl1.SplitterPosition = 454;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // insertReviewCheckBox
            // 
            this.insertReviewCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.newsItemBindingSource, "InsertReview", true));
            this.insertReviewCheckBox.Location = new System.Drawing.Point(372, 12);
            this.insertReviewCheckBox.Name = "insertReviewCheckBox";
            this.insertReviewCheckBox.Size = new System.Drawing.Size(104, 24);
            this.insertReviewCheckBox.TabIndex = 8;
            this.insertReviewCheckBox.Text = "checkBox1";
            this.insertReviewCheckBox.UseVisualStyleBackColor = true;
            this.insertReviewCheckBox.CheckedChanged += new System.EventHandler(this.insertReviewCheckBox_CheckedChanged);
            // 
            // newsItemBindingSource
            // 
            this.newsItemBindingSource.DataMember = "NewsItem";
            this.newsItemBindingSource.DataSource = this.dBNew;
            // 
            // dBNew
            // 
            this.dBNew.DataSetName = "DBNew";
            this.dBNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabControl1.AppearancePage.Header.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabControl1.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabControl1.AppearancePage.Header.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabControl1.AppearancePage.Header.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabControl1.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabControl1.AppearancePage.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabControl1.AppearancePage.HeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabControl1.AppearancePage.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabControl1.AppearancePage.HeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabControl1.AppearancePage.HeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabControl1.AppearancePage.HeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabControl1.AppearancePage.HeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabControl1.AppearancePage.HeaderDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabControl1.AppearancePage.HeaderDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabControl1.AppearancePage.HeaderDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabControl1.AppearancePage.HeaderDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabControl1.AppearancePage.HeaderDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabControl1.AppearancePage.HeaderDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabControl1.AppearancePage.HeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabControl1.AppearancePage.HeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabControl1.AppearancePage.HeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabControl1.AppearancePage.HeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabControl1.AppearancePage.HeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabControl1.AppearancePage.HeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabControl1.AppearancePage.PageClient.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabControl1.AppearancePage.PageClient.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabControl1.AppearancePage.PageClient.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabControl1.AppearancePage.PageClient.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabControl1.AppearancePage.PageClient.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabControl1.AppearancePage.PageClient.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.xtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.Default;
            this.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.Default;
            this.xtraTabControl1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Default;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Default;
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 29);
            this.xtraTabControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.xtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Near;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabControl1.ShowToolTips = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabControl1.Size = new System.Drawing.Size(450, 424);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabPage1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabPage1.Appearance.Header.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabPage1.Appearance.Header.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabPage1.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabPage1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabPage1.Appearance.HeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabPage1.Appearance.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabPage1.Appearance.HeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabPage1.Appearance.HeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabPage1.Appearance.HeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabPage1.Appearance.HeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabPage1.Appearance.HeaderDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabPage1.Appearance.HeaderDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabPage1.Appearance.HeaderDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabPage1.Appearance.HeaderDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabPage1.Appearance.HeaderDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabPage1.Appearance.HeaderDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabPage1.Appearance.HeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabPage1.Appearance.HeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabPage1.Appearance.HeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabPage1.Appearance.HeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabPage1.Appearance.HeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabPage1.Appearance.HeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabPage1.Appearance.PageClient.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabPage1.Appearance.PageClient.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabPage1.Appearance.PageClient.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabPage1.Appearance.PageClient.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabPage1.Appearance.PageClient.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabPage1.Appearance.PageClient.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xtraTabPage1.Controls.Add(this.bindingNavigator1);
            this.xtraTabPage1.Controls.Add(this.gridControl2);
            this.xtraTabPage1.Controls.Add(iDLabel);
            this.xtraTabPage1.Controls.Add(this.iDTextBox);
            this.xtraTabPage1.Controls.Add(relatedNewsLabel);
            this.xtraTabPage1.Controls.Add(this.relatedNewsTextBox);
            this.xtraTabPage1.Controls.Add(avatarLabel);
            this.xtraTabPage1.Controls.Add(this.avatarTextBox);
            this.xtraTabPage1.Controls.Add(publishedDateLabel);
            this.xtraTabPage1.Controls.Add(this.publishedDateDateTimePicker);
            this.xtraTabPage1.Controls.Add(uRLLabel);
            this.xtraTabPage1.Controls.Add(this.uRLTextBox);
            this.xtraTabPage1.Controls.Add(cRC64Label);
            this.xtraTabPage1.Controls.Add(this.cRC64TextBox);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabPage1.Size = new System.Drawing.Size(442, 395);
            this.xtraTabPage1.Text = "List News";
            this.xtraTabPage1.TooltipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.newsItemBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.btCheckAll,
            this.btInsertAll,
            this.btNotReview});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 370);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(442, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.btCheckAll.Size = new System.Drawing.Size(51, 22);
            this.btCheckAll.Text = "CheckAll";
            this.btCheckAll.Click += new System.EventHandler(this.btCheckAll_Click);
            // 
            // btInsertAll
            // 
            this.btInsertAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btInsertAll.Image = ((System.Drawing.Image)(resources.GetObject("btInsertAll.Image")));
            this.btInsertAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btInsertAll.Name = "btInsertAll";
            this.btInsertAll.Size = new System.Drawing.Size(51, 22);
            this.btInsertAll.Text = "InsertAll";
            this.btInsertAll.Click += new System.EventHandler(this.btInsertAll_Click);
            // 
            // btNotReview
            // 
            this.btNotReview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btNotReview.Image = ((System.Drawing.Image)(resources.GetObject("btNotReview.Image")));
            this.btNotReview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNotReview.Name = "btNotReview";
            this.btNotReview.Size = new System.Drawing.Size(63, 22);
            this.btNotReview.Text = "NotReview";
            this.btNotReview.Click += new System.EventHandler(this.btNotReview_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.newsItemBindingSource;
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
            this.gridControl2.Location = new System.Drawing.Point(0, 3);
            this.gridControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(440, 351);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            this.gridColumn1,
            this.colInsertReview});
            this.gridView2.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus;
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
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default;
            this.gridView2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell;
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn1.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gridColumn1.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gridColumn1.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gridColumn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gridColumn1.FieldName = "Title";
            this.gridColumn1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.gridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.gridColumn1.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.gridColumn1.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.gridColumn1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.gridColumn1.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn1.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.gridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.gridColumn1.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colInsertReview
            // 
            this.colInsertReview.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colInsertReview.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colInsertReview.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colInsertReview.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colInsertReview.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colInsertReview.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colInsertReview.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colInsertReview.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colInsertReview.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colInsertReview.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colInsertReview.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colInsertReview.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colInsertReview.FieldName = "InsertReview";
            this.colInsertReview.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colInsertReview.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colInsertReview.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colInsertReview.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colInsertReview.Name = "colInsertReview";
            this.colInsertReview.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colInsertReview.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colInsertReview.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colInsertReview.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colInsertReview.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colInsertReview.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colInsertReview.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colInsertReview.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colInsertReview.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colInsertReview.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colInsertReview.Visible = true;
            this.colInsertReview.VisibleIndex = 1;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsItemBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(189, 3);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 13;
            // 
            // relatedNewsTextBox
            // 
            this.relatedNewsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsItemBindingSource, "RelatedNews", true));
            this.relatedNewsTextBox.Location = new System.Drawing.Point(127, 107);
            this.relatedNewsTextBox.Name = "relatedNewsTextBox";
            this.relatedNewsTextBox.ReadOnly = true;
            this.relatedNewsTextBox.Size = new System.Drawing.Size(100, 20);
            this.relatedNewsTextBox.TabIndex = 11;
            // 
            // avatarTextBox
            // 
            this.avatarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsItemBindingSource, "Avatar", true));
            this.avatarTextBox.Location = new System.Drawing.Point(127, 81);
            this.avatarTextBox.Name = "avatarTextBox";
            this.avatarTextBox.ReadOnly = true;
            this.avatarTextBox.Size = new System.Drawing.Size(100, 20);
            this.avatarTextBox.TabIndex = 9;
            // 
            // publishedDateDateTimePicker
            // 
            this.publishedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.newsItemBindingSource, "PublishedDate", true));
            this.publishedDateDateTimePicker.Enabled = false;
            this.publishedDateDateTimePicker.Location = new System.Drawing.Point(127, 55);
            this.publishedDateDateTimePicker.Name = "publishedDateDateTimePicker";
            this.publishedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.publishedDateDateTimePicker.TabIndex = 7;
            // 
            // uRLTextBox
            // 
            this.uRLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsItemBindingSource, "URL", true));
            this.uRLTextBox.Location = new System.Drawing.Point(61, 29);
            this.uRLTextBox.Name = "uRLTextBox";
            this.uRLTextBox.ReadOnly = true;
            this.uRLTextBox.Size = new System.Drawing.Size(100, 20);
            this.uRLTextBox.TabIndex = 5;
            // 
            // cRC64TextBox
            // 
            this.cRC64TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsItemBindingSource, "CRC64", true));
            this.cRC64TextBox.Location = new System.Drawing.Point(61, 3);
            this.cRC64TextBox.Name = "cRC64TextBox";
            this.cRC64TextBox.ReadOnly = true;
            this.cRC64TextBox.Size = new System.Drawing.Size(100, 20);
            this.cRC64TextBox.TabIndex = 3;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabPage2.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabPage2.Appearance.Header.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabPage2.Appearance.Header.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabPage2.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabPage2.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabPage2.Appearance.HeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabPage2.Appearance.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabPage2.Appearance.HeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabPage2.Appearance.HeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabPage2.Appearance.HeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabPage2.Appearance.HeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabPage2.Appearance.HeaderDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabPage2.Appearance.HeaderDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabPage2.Appearance.HeaderDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabPage2.Appearance.HeaderDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabPage2.Appearance.HeaderDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabPage2.Appearance.HeaderDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabPage2.Appearance.HeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabPage2.Appearance.HeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabPage2.Appearance.HeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabPage2.Appearance.HeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabPage2.Appearance.HeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabPage2.Appearance.HeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabPage2.Appearance.PageClient.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.xtraTabPage2.Appearance.PageClient.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.xtraTabPage2.Appearance.PageClient.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.xtraTabPage2.Appearance.PageClient.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.xtraTabPage2.Appearance.PageClient.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.xtraTabPage2.Appearance.PageClient.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.xtraTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xtraTabPage2.Controls.Add(this.bindingNavigator2);
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.ShowCloseButton = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabPage2.Size = new System.Drawing.Size(443, 395);
            this.xtraTabPage2.Text = "List Keyword";
            this.xtraTabPage2.TooltipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton2;
            this.bindingNavigator2.BindingSource = this.keywordMapBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = this.toolStripButton3;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripButton3,
            this.btSaveKeyword,
            this.btLoadKeyword});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 370);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton4;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton7;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton6;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton5;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(443, 25);
            this.bindingNavigator2.TabIndex = 3;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Add new";
            // 
            // keywordMapBindingSource
            // 
            this.keywordMapBindingSource.DataMember = "KeywordMap";
            this.keywordMapBindingSource.DataSource = this.dBNew;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Delete";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move first";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move next";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btSaveKeyword
            // 
            this.btSaveKeyword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btSaveKeyword.Image = ((System.Drawing.Image)(resources.GetObject("btSaveKeyword.Image")));
            this.btSaveKeyword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSaveKeyword.Name = "btSaveKeyword";
            this.btSaveKeyword.Size = new System.Drawing.Size(35, 22);
            this.btSaveKeyword.Text = "Save";
            this.btSaveKeyword.Click += new System.EventHandler(this.btSaveKeyword_Click);
            // 
            // btLoadKeyword
            // 
            this.btLoadKeyword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btLoadKeyword.Image = ((System.Drawing.Image)(resources.GetObject("btLoadKeyword.Image")));
            this.btLoadKeyword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLoadKeyword.Name = "btLoadKeyword";
            this.btLoadKeyword.Size = new System.Drawing.Size(34, 22);
            this.btLoadKeyword.Text = "Load";
            this.btLoadKeyword.Click += new System.EventHandler(this.btLoadKeyword_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.keywordMapBindingSource;
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
            this.gridControl1.Size = new System.Drawing.Size(443, 367);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colKeyword,
            this.colCRC});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus;
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
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default;
            this.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell;
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
            // 
            // colKeyword
            // 
            this.colKeyword.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colKeyword.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colKeyword.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colKeyword.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colKeyword.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colKeyword.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colKeyword.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colKeyword.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colKeyword.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colKeyword.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colKeyword.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colKeyword.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colKeyword.FieldName = "Keyword";
            this.colKeyword.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colKeyword.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colKeyword.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colKeyword.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colKeyword.Name = "colKeyword";
            this.colKeyword.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colKeyword.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colKeyword.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colKeyword.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colKeyword.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colKeyword.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colKeyword.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colKeyword.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colKeyword.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colKeyword.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colKeyword.Visible = true;
            this.colKeyword.VisibleIndex = 0;
            // 
            // colCRC
            // 
            this.colCRC.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colCRC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colCRC.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colCRC.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colCRC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colCRC.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colCRC.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colCRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colCRC.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colCRC.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colCRC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colCRC.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colCRC.FieldName = "CRC";
            this.colCRC.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colCRC.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colCRC.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colCRC.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colCRC.Name = "colCRC";
            this.colCRC.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colCRC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colCRC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colCRC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colCRC.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colCRC.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colCRC.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colCRC.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colCRC.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colCRC.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(108, 3);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(96, 20);
            this.dtTo.TabIndex = 6;
            // 
            // dtfrom
            // 
            this.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfrom.Location = new System.Drawing.Point(3, 3);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(99, 20);
            this.dtfrom.TabIndex = 6;
            // 
            // btLoadAnanytic
            // 
            this.btLoadAnanytic.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btLoadAnanytic.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btLoadAnanytic.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btLoadAnanytic.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btLoadAnanytic.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btLoadAnanytic.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btLoadAnanytic.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btLoadAnanytic.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btLoadAnanytic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btLoadAnanytic.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btLoadAnanytic.Location = new System.Drawing.Point(291, 3);
            this.btLoadAnanytic.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btLoadAnanytic.Name = "btLoadAnanytic";
            this.btLoadAnanytic.Size = new System.Drawing.Size(75, 23);
            this.btLoadAnanytic.TabIndex = 2;
            this.btLoadAnanytic.Text = "LoadAnanytic";
            this.btLoadAnanytic.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btLoadAnanytic.Click += new System.EventHandler(this.btLoadAnanytic_Click);
            // 
            // btLoad
            // 
            this.btLoad.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btLoad.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btLoad.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btLoad.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btLoad.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btLoad.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btLoad.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btLoad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btLoad.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btLoad.Location = new System.Drawing.Point(210, 3);
            this.btLoad.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 2;
            this.btLoad.Text = "LoadAll";
            this.btLoad.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // sapoLabel1
            // 
            this.sapoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sapoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsItemBindingSource, "Sapo", true));
            this.sapoLabel1.Location = new System.Drawing.Point(38, 52);
            this.sapoLabel1.Name = "sapoLabel1";
            this.sapoLabel1.Size = new System.Drawing.Size(364, 63);
            this.sapoLabel1.TabIndex = 6;
            this.sapoLabel1.Text = "label1";
            // 
            // titleLabel1
            // 
            this.titleLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsItemBindingSource, "Title", true));
            this.titleLabel1.Location = new System.Drawing.Point(38, 9);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(364, 34);
            this.titleLabel1.TabIndex = 4;
            this.titleLabel1.Text = "label1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(6, 118);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(396, 332);
            this.webBrowser1.TabIndex = 2;
            // 
            // contentsTextBox
            // 
            this.contentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newsItemBindingSource, "Contents", true));
            this.contentsTextBox.Location = new System.Drawing.Point(126, 204);
            this.contentsTextBox.Multiline = true;
            this.contentsTextBox.Name = "contentsTextBox";
            this.contentsTextBox.ReadOnly = true;
            this.contentsTextBox.Size = new System.Drawing.Size(124, 20);
            this.contentsTextBox.TabIndex = 1;
            this.contentsTextBox.TextChanged += new System.EventHandler(this.contentsTextBox_TextChanged);
            // 
            // newsItemTableAdapter
            // 
            this.newsItemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KeywordMapTableAdapter = null;
            this.tableAdapterManager.NewsItemTableAdapter = this.newsItemTableAdapter;
            this.tableAdapterManager.NewsPublishedTableAdapter = null;
            this.tableAdapterManager.NewsReviewTableAdapter = null;
            this.tableAdapterManager.NewsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.News.DBNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // keywordMapTableAdapter
            // 
            this.keywordMapTableAdapter.ClearBeforeFill = true;
            // 
            // frmManagerNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(871, 453);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmManagerNews";
            this.Load += new System.EventHandler(this.frmManagerNews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newsItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keywordMapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DBNew dBNew;
        private System.Windows.Forms.BindingSource newsItemBindingSource;
        private DBNewTableAdapters.NewsItemTableAdapter newsItemTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btLoad;
        private System.Windows.Forms.TextBox contentsTextBox;
        private DBNewTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtfrom;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource keywordMapBindingSource;
        private DBNewTableAdapters.KeywordMapTableAdapter keywordMapTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyword;
        private DevExpress.XtraGrid.Columns.GridColumn colCRC;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btInsertAll;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btSaveKeyword;
        private System.Windows.Forms.ToolStripButton btLoadKeyword;
        private DevExpress.XtraEditors.SimpleButton btLoadAnanytic;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label sapoLabel1;
        private System.Windows.Forms.Label titleLabel1;
        private DevExpress.XtraGrid.Columns.GridColumn colInsertReview;
        private System.Windows.Forms.ToolStripButton btNotReview;
        private System.Windows.Forms.CheckBox insertReviewCheckBox;
        private System.Windows.Forms.ToolStripButton btCheckAll;
        private System.Windows.Forms.TextBox relatedNewsTextBox;
        private System.Windows.Forms.TextBox avatarTextBox;
        private System.Windows.Forms.DateTimePicker publishedDateDateTimePicker;
        private System.Windows.Forms.TextBox uRLTextBox;
        private System.Windows.Forms.TextBox cRC64TextBox;
        private System.Windows.Forms.TextBox iDTextBox;
    }
}
