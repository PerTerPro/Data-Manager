namespace QT.Moduls.Company
{
    partial class frmProduct
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label classificationIDLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label detailUrlLabel;
            System.Windows.Forms.Label promotionLabel;
            System.Windows.Forms.Label summaryLabel;
            System.Windows.Forms.Label productContentLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label imageUrlsLabel;
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lamess = new System.Windows.Forms.Label();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB = new QT.Moduls.DB();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemRichTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.webImage = new System.Windows.Forms.WebBrowser();
            this.webSumary = new System.Windows.Forms.WebBrowser();
            this.webContent = new System.Windows.Forms.WebBrowser();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.productContentLabel1 = new System.Windows.Forms.Label();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db1 = new QT.Moduls.DB();
            this.summaryLabel1 = new System.Windows.Forms.Label();
            this.promotionLabel1 = new System.Windows.Forms.Label();
            this.detailUrlTextBox = new System.Windows.Forms.TextBox();
            this.classificationIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.imageUrlsLabel1 = new System.Windows.Forms.Label();
            this.productTableAdapter = new QT.Moduls.DBTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new QT.Moduls.DBTableAdapters.TableAdapterManager();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.ctrCheckProduct1 = new QT.Moduls.Company.ctrCheckProduct();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            nameLabel = new System.Windows.Forms.Label();
            classificationIDLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            detailUrlLabel = new System.Windows.Forms.Label();
            promotionLabel = new System.Windows.Forms.Label();
            summaryLabel = new System.Windows.Forms.Label();
            productContentLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            imageUrlsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(47, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // classificationIDLabel
            // 
            classificationIDLabel.AutoSize = true;
            classificationIDLabel.Location = new System.Drawing.Point(3, 41);
            classificationIDLabel.Name = "classificationIDLabel";
            classificationIDLabel.Size = new System.Drawing.Size(85, 13);
            classificationIDLabel.TabIndex = 2;
            classificationIDLabel.Text = "Classification ID:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(54, 67);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price:";
            // 
            // detailUrlLabel
            // 
            detailUrlLabel.AutoSize = true;
            detailUrlLabel.Location = new System.Drawing.Point(205, 70);
            detailUrlLabel.Name = "detailUrlLabel";
            detailUrlLabel.Size = new System.Drawing.Size(53, 13);
            detailUrlLabel.TabIndex = 6;
            detailUrlLabel.Text = "Detail Url:";
            // 
            // promotionLabel
            // 
            promotionLabel.AutoSize = true;
            promotionLabel.Location = new System.Drawing.Point(28, 213);
            promotionLabel.Name = "promotionLabel";
            promotionLabel.Size = new System.Drawing.Size(57, 13);
            promotionLabel.TabIndex = 8;
            promotionLabel.Text = "Promotion:";
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Location = new System.Drawing.Point(32, 236);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new System.Drawing.Size(53, 13);
            summaryLabel.TabIndex = 10;
            summaryLabel.Text = "Summary:";
            // 
            // productContentLabel
            // 
            productContentLabel.AutoSize = true;
            productContentLabel.Location = new System.Drawing.Point(1, 259);
            productContentLabel.Name = "productContentLabel";
            productContentLabel.Size = new System.Drawing.Size(87, 13);
            productContentLabel.TabIndex = 12;
            productContentLabel.Text = "Product Content:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(67, 89);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 14;
            iDLabel.Text = "ID:";
            // 
            // imageUrlsLabel
            // 
            imageUrlsLabel.AutoSize = true;
            imageUrlsLabel.Location = new System.Drawing.Point(139, 172);
            imageUrlsLabel.Name = "imageUrlsLabel";
            imageUrlsLabel.Size = new System.Drawing.Size(60, 13);
            imageUrlsLabel.TabIndex = 18;
            imageUrlsLabel.Text = "Image Urls:";
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
            this.splitContainerControl1.Panel1.Controls.Add(this.lamess);
            this.splitContainerControl1.Panel1.Controls.Add(this.dataNavigator1);
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
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
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Controls.Add(iDLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.iDLabel1);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit1);
            this.splitContainerControl1.Panel2.Controls.Add(productContentLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.productContentLabel1);
            this.splitContainerControl1.Panel2.Controls.Add(summaryLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.summaryLabel1);
            this.splitContainerControl1.Panel2.Controls.Add(promotionLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.promotionLabel1);
            this.splitContainerControl1.Panel2.Controls.Add(detailUrlLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.detailUrlTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(priceLabel);
            this.splitContainerControl1.Panel2.Controls.Add(classificationIDLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.classificationIDTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(nameLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.nameTextBox);
            this.splitContainerControl1.Panel2.Controls.Add(imageUrlsLabel);
            this.splitContainerControl1.Panel2.Controls.Add(this.imageUrlsLabel1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;
            this.splitContainerControl1.Size = new System.Drawing.Size(848, 483);
            this.splitContainerControl1.SplitterPosition = 361;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lamess
            // 
            this.lamess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lamess.Location = new System.Drawing.Point(3, 6);
            this.lamess.Name = "lamess";
            this.lamess.Size = new System.Drawing.Size(220, 20);
            this.lamess.TabIndex = 18;
            this.lamess.Text = "-";
            this.lamess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lamess.Visible = false;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.dataNavigator1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dataNavigator1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.dataNavigator1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.dataNavigator1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.dataNavigator1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.dataNavigator1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.dataNavigator1.DataSource = this.productBindingSource;
            this.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataNavigator1.Location = new System.Drawing.Point(0, 0);
            this.dataNavigator1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(361, 30);
            this.dataNavigator1.TabIndex = 2;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.dataNavigator1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dB;
            this.productBindingSource.CurrentChanged += new System.EventHandler(this.productBindingSource_CurrentChanged);
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.EnforceConstraints = false;
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.productBindingSource;
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
            this.gridControl1.Location = new System.Drawing.Point(0, 36);
            this.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRichTextEdit1,
            this.repositoryItemRichTextEdit2});
            this.gridControl1.Size = new System.Drawing.Size(361, 447);
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
            this.colName});
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
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 20;
            this.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
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
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colName.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colName.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colName.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.repositoryItemRichTextEdit1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemRichTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRichTextEdit1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemRichTextEdit1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemRichTextEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemRichTextEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemRichTextEdit1.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemRichTextEdit1.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRichTextEdit1.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemRichTextEdit1.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemRichTextEdit1.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemRichTextEdit1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemRichTextEdit1.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemRichTextEdit1.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRichTextEdit1.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemRichTextEdit1.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemRichTextEdit1.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemRichTextEdit1.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemRichTextEdit1.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemRichTextEdit1.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRichTextEdit1.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemRichTextEdit1.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemRichTextEdit1.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemRichTextEdit1.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemRichTextEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.repositoryItemRichTextEdit1.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.repositoryItemRichTextEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemRichTextEdit1.EncodingWebName = "utf-8";
            this.repositoryItemRichTextEdit1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.repositoryItemRichTextEdit1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.OptionsBehavior.Copy = DevExpress.XtraRichEdit.DocumentCapability.Default;
            this.repositoryItemRichTextEdit1.OptionsBehavior.Cut = DevExpress.XtraRichEdit.DocumentCapability.Default;
            this.repositoryItemRichTextEdit1.OptionsBehavior.Drag = DevExpress.XtraRichEdit.DocumentCapability.Default;
            this.repositoryItemRichTextEdit1.OptionsBehavior.Drop = DevExpress.XtraRichEdit.DocumentCapability.Default;
            this.repositoryItemRichTextEdit1.OptionsBehavior.FontSource = DevExpress.XtraRichEdit.RichEditBaseValueSource.Auto;
            this.repositoryItemRichTextEdit1.OptionsBehavior.ForeColorSource = DevExpress.XtraRichEdit.RichEditBaseValueSource.Auto;
            this.repositoryItemRichTextEdit1.OptionsBehavior.Paste = DevExpress.XtraRichEdit.DocumentCapability.Default;
            this.repositoryItemRichTextEdit1.OptionsBehavior.ShowPopupMenu = DevExpress.XtraRichEdit.DocumentCapability.Default;
            // 
            // repositoryItemRichTextEdit2
            // 
            this.repositoryItemRichTextEdit2.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.repositoryItemRichTextEdit2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemRichTextEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRichTextEdit2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemRichTextEdit2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemRichTextEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemRichTextEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemRichTextEdit2.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemRichTextEdit2.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRichTextEdit2.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemRichTextEdit2.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemRichTextEdit2.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemRichTextEdit2.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemRichTextEdit2.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemRichTextEdit2.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRichTextEdit2.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemRichTextEdit2.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemRichTextEdit2.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemRichTextEdit2.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemRichTextEdit2.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemRichTextEdit2.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemRichTextEdit2.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemRichTextEdit2.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemRichTextEdit2.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemRichTextEdit2.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemRichTextEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.repositoryItemRichTextEdit2.DocumentFormat = DevExpress.XtraRichEdit.DocumentFormat.Html;
            this.repositoryItemRichTextEdit2.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemRichTextEdit2.EncodingWebName = "utf-8";
            this.repositoryItemRichTextEdit2.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.repositoryItemRichTextEdit2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.repositoryItemRichTextEdit2.Name = "repositoryItemRichTextEdit2";
            this.repositoryItemRichTextEdit2.OptionsBehavior.Copy = DevExpress.XtraRichEdit.DocumentCapability.Default;
            this.repositoryItemRichTextEdit2.OptionsBehavior.Cut = DevExpress.XtraRichEdit.DocumentCapability.Default;
            this.repositoryItemRichTextEdit2.OptionsBehavior.Drag = DevExpress.XtraRichEdit.DocumentCapability.Default;
            this.repositoryItemRichTextEdit2.OptionsBehavior.Drop = DevExpress.XtraRichEdit.DocumentCapability.Default;
            this.repositoryItemRichTextEdit2.OptionsBehavior.FontSource = DevExpress.XtraRichEdit.RichEditBaseValueSource.Auto;
            this.repositoryItemRichTextEdit2.OptionsBehavior.ForeColorSource = DevExpress.XtraRichEdit.RichEditBaseValueSource.Auto;
            this.repositoryItemRichTextEdit2.OptionsBehavior.Paste = DevExpress.XtraRichEdit.DocumentCapability.Default;
            this.repositoryItemRichTextEdit2.OptionsBehavior.ShowPopupMenu = DevExpress.XtraRichEdit.DocumentCapability.Default;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl2.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl2.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl2.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl2.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl2.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl2.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.Default;
            this.splitContainerControl2.CaptionLocation = DevExpress.Utils.Locations.Default;
            this.splitContainerControl2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.None;
            this.splitContainerControl2.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel1;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(2, 114);
            this.splitContainerControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl2.Panel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl2.Panel1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl2.Panel1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl2.Panel1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl2.Panel1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl2.Panel1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl2.Panel1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl2.Panel1.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl2.Panel1.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl2.Panel1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl2.Panel1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl2.Panel1.CaptionLocation = DevExpress.Utils.Locations.Default;
            this.splitContainerControl2.Panel1.Controls.Add(this.webImage);
            this.splitContainerControl2.Panel1.Controls.Add(this.webSumary);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl2.Panel2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl2.Panel2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl2.Panel2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl2.Panel2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl2.Panel2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl2.Panel2.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.splitContainerControl2.Panel2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.splitContainerControl2.Panel2.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.splitContainerControl2.Panel2.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.splitContainerControl2.Panel2.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.splitContainerControl2.Panel2.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.splitContainerControl2.Panel2.CaptionLocation = DevExpress.Utils.Locations.Default;
            this.splitContainerControl2.Panel2.Controls.Add(this.webContent);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;
            this.splitContainerControl2.Size = new System.Drawing.Size(476, 369);
            this.splitContainerControl2.SplitterPosition = 146;
            this.splitContainerControl2.TabIndex = 18;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // webImage
            // 
            this.webImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.webImage.Location = new System.Drawing.Point(4, 4);
            this.webImage.MinimumSize = new System.Drawing.Size(20, 20);
            this.webImage.Name = "webImage";
            this.webImage.Size = new System.Drawing.Size(196, 141);
            this.webImage.TabIndex = 17;
            // 
            // webSumary
            // 
            this.webSumary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webSumary.Location = new System.Drawing.Point(206, 3);
            this.webSumary.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSumary.Name = "webSumary";
            this.webSumary.Size = new System.Drawing.Size(311, 141);
            this.webSumary.TabIndex = 17;
            // 
            // webContent
            // 
            this.webContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webContent.Location = new System.Drawing.Point(0, 0);
            this.webContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.webContent.Name = "webContent";
            this.webContent.Size = new System.Drawing.Size(476, 217);
            this.webContent.TabIndex = 16;
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(94, 88);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 15;
            this.iDLabel1.Text = "label1";
            // 
            // textEdit1
            // 
            this.textEdit1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Price", true));
            this.textEdit1.Location = new System.Drawing.Point(94, 63);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.textEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.textEdit1.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.textEdit1.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.textEdit1.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.textEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.textEdit1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.textEdit1.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.textEdit1.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.textEdit1.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.textEdit1.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.textEdit1.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.textEdit1.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.textEdit1.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.textEdit1.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.textEdit1.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.textEdit1.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.textEdit1.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.textEdit1.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.textEdit1.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.textEdit1.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.textEdit1.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.textEdit1.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.textEdit1.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.textEdit1.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.textEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textEdit1.Properties.DisplayFormat.FormatString = "n0";
            this.textEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit1.Properties.EditFormat.FormatString = "n0";
            this.textEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.textEdit1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.textEdit1.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 14;
            this.textEdit1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // productContentLabel1
            // 
            this.productContentLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource1, "ProductContent", true));
            this.productContentLabel1.Location = new System.Drawing.Point(94, 259);
            this.productContentLabel1.Name = "productContentLabel1";
            this.productContentLabel1.Size = new System.Drawing.Size(100, 23);
            this.productContentLabel1.TabIndex = 13;
            this.productContentLabel1.Text = "label1";
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.db1;
            // 
            // db1
            // 
            this.db1.DataSetName = "DB";
            this.db1.EnforceConstraints = false;
            this.db1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // summaryLabel1
            // 
            this.summaryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource1, "Summary", true));
            this.summaryLabel1.Location = new System.Drawing.Point(91, 236);
            this.summaryLabel1.Name = "summaryLabel1";
            this.summaryLabel1.Size = new System.Drawing.Size(100, 23);
            this.summaryLabel1.TabIndex = 11;
            this.summaryLabel1.Text = "label1";
            // 
            // promotionLabel1
            // 
            this.promotionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource1, "Promotion", true));
            this.promotionLabel1.Location = new System.Drawing.Point(91, 213);
            this.promotionLabel1.Name = "promotionLabel1";
            this.promotionLabel1.Size = new System.Drawing.Size(100, 23);
            this.promotionLabel1.TabIndex = 9;
            this.promotionLabel1.Text = "label1";
            // 
            // detailUrlTextBox
            // 
            this.detailUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.detailUrlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource1, "DetailUrl", true));
            this.detailUrlTextBox.Location = new System.Drawing.Point(264, 67);
            this.detailUrlTextBox.Name = "detailUrlTextBox";
            this.detailUrlTextBox.Size = new System.Drawing.Size(291, 20);
            this.detailUrlTextBox.TabIndex = 7;
            // 
            // classificationIDTextBox
            // 
            this.classificationIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.classificationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ClassificationID", true));
            this.classificationIDTextBox.Location = new System.Drawing.Point(94, 38);
            this.classificationIDTextBox.Name = "classificationIDTextBox";
            this.classificationIDTextBox.Size = new System.Drawing.Size(364, 20);
            this.classificationIDTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(94, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(364, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // imageUrlsLabel1
            // 
            this.imageUrlsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource1, "ImageUrls", true));
            this.imageUrlsLabel1.Location = new System.Drawing.Point(205, 172);
            this.imageUrlsLabel1.Name = "imageUrlsLabel1";
            this.imageUrlsLabel1.Size = new System.Drawing.Size(100, 23);
            this.imageUrlsLabel1.TabIndex = 19;
            this.imageUrlsLabel1.Text = "label1";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.MapClassificationTableAdapter = null;
            this.tableAdapterManager.ProductID_PropertyTableAdapter = null;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.PropertyGroupTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // xtraTabControl1
            // 
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
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.Default;
            this.xtraTabControl1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Default;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Default;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.xtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Near;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabControl1.ShowToolTips = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabControl1.Size = new System.Drawing.Size(855, 512);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
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
            this.xtraTabPage2.Controls.Add(this.ctrCheckProduct1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.ShowCloseButton = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabPage2.Size = new System.Drawing.Size(848, 483);
            this.xtraTabPage2.Text = "Check product";
            this.xtraTabPage2.TooltipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // ctrCheckProduct1
            // 
            this.ctrCheckProduct1.CompanyID = ((long)(0));
            this.ctrCheckProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrCheckProduct1.Location = new System.Drawing.Point(0, 0);
            this.ctrCheckProduct1.Name = "ctrCheckProduct1";
            this.ctrCheckProduct1.Size = new System.Drawing.Size(848, 483);
            this.ctrCheckProduct1.TabIndex = 0;
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
            this.xtraTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xtraTabPage1.Controls.Add(this.splitContainerControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.Default;
            this.xtraTabPage1.Size = new System.Drawing.Size(848, 483);
            this.xtraTabPage1.Text = "ViewAll";
            this.xtraTabPage1.TooltipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(855, 512);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit2;
        private DB dB;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DBTableAdapters.ProductTableAdapter productTableAdapter;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private System.Windows.Forms.Label lamess;
        private DB db1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label productContentLabel1;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.Label summaryLabel1;
        private System.Windows.Forms.Label promotionLabel1;
        private System.Windows.Forms.TextBox detailUrlTextBox;
        private System.Windows.Forms.TextBox classificationIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.WebBrowser webSumary;
        private System.Windows.Forms.WebBrowser webContent;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.WebBrowser webImage;
        private System.Windows.Forms.Label imageUrlsLabel1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ctrCheckProduct ctrCheckProduct1;
    }
}
