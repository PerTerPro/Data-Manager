namespace QT.Moduls.News
{
    partial class frmNewsReport
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.newsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBNew = new QT.Moduls.News.DBNew();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNews_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCat_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNews_Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNews_Source = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNews_Author = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNews_Approver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNews_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNews_PublishDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinkGoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWordCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btExport = new DevExpress.XtraEditors.SimpleButton();
            this.btViewAll = new DevExpress.XtraEditors.SimpleButton();
            this.ctrDateRanger1 = new QT.Entities.ctrDateRanger();
            this.newsReportTableAdapter = new QT.Moduls.News.DBNewTableAdapters.NewsReportTableAdapter();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.newsReportBindingSource;
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
            this.gridControl1.Location = new System.Drawing.Point(3, 34);
            this.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(887, 422);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // newsReportBindingSource
            // 
            this.newsReportBindingSource.DataMember = "NewsReport";
            this.newsReportBindingSource.DataSource = this.dBNew;
            // 
            // dBNew
            // 
            this.dBNew.DataSetName = "DBNew";
            this.dBNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colNews_ID,
            this.colCat_ID,
            this.colNews_Title,
            this.colNews_Source,
            this.colNews_Author,
            this.colNews_Approver,
            this.colNews_Status,
            this.colNews_PublishDate,
            this.colLinkGoc,
            this.colDomain,
            this.colWordCount,
            this.colViewCount});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleIfExpanded;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "IDStatus", null, "")});
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
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default;
            this.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNews_Author, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNews_PublishDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colNews_ID
            // 
            this.colNews_ID.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_ID.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_ID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_ID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_ID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_ID.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_ID.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_ID.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_ID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_ID.FieldName = "News_ID";
            this.colNews_ID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colNews_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colNews_ID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colNews_ID.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colNews_ID.Name = "colNews_ID";
            this.colNews_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colNews_ID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colNews_ID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_ID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_ID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colNews_ID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colNews_ID.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            // 
            // colCat_ID
            // 
            this.colCat_ID.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colCat_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colCat_ID.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colCat_ID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colCat_ID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colCat_ID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colCat_ID.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colCat_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colCat_ID.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colCat_ID.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colCat_ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colCat_ID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colCat_ID.FieldName = "Cat_ID";
            this.colCat_ID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colCat_ID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colCat_ID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colCat_ID.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colCat_ID.Name = "colCat_ID";
            this.colCat_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colCat_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colCat_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colCat_ID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colCat_ID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colCat_ID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colCat_ID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colCat_ID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colCat_ID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colCat_ID.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            // 
            // colNews_Title
            // 
            this.colNews_Title.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_Title.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_Title.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_Title.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_Title.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_Title.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_Title.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_Title.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_Title.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_Title.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_Title.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_Title.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_Title.FieldName = "News_Title";
            this.colNews_Title.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colNews_Title.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colNews_Title.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colNews_Title.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colNews_Title.Name = "colNews_Title";
            this.colNews_Title.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Title.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Title.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Title.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colNews_Title.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colNews_Title.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Title.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Title.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colNews_Title.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colNews_Title.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colNews_Title.Visible = true;
            this.colNews_Title.VisibleIndex = 0;
            // 
            // colNews_Source
            // 
            this.colNews_Source.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_Source.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_Source.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_Source.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_Source.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_Source.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_Source.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_Source.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_Source.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_Source.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_Source.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_Source.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_Source.FieldName = "News_Source";
            this.colNews_Source.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colNews_Source.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colNews_Source.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colNews_Source.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colNews_Source.Name = "colNews_Source";
            this.colNews_Source.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Source.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Source.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Source.OptionsColumn.FixedWidth = true;
            this.colNews_Source.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colNews_Source.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colNews_Source.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Source.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Source.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colNews_Source.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colNews_Source.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colNews_Source.Visible = true;
            this.colNews_Source.VisibleIndex = 1;
            // 
            // colNews_Author
            // 
            this.colNews_Author.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_Author.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_Author.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_Author.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_Author.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_Author.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_Author.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_Author.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_Author.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_Author.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_Author.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_Author.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_Author.FieldName = "News_Author";
            this.colNews_Author.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colNews_Author.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colNews_Author.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colNews_Author.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colNews_Author.Name = "colNews_Author";
            this.colNews_Author.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Author.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Author.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Author.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colNews_Author.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colNews_Author.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Author.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Author.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colNews_Author.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colNews_Author.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colNews_Author.Visible = true;
            this.colNews_Author.VisibleIndex = 4;
            // 
            // colNews_Approver
            // 
            this.colNews_Approver.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_Approver.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_Approver.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_Approver.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_Approver.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_Approver.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_Approver.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_Approver.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_Approver.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_Approver.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_Approver.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_Approver.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_Approver.FieldName = "News_Approver";
            this.colNews_Approver.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colNews_Approver.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colNews_Approver.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colNews_Approver.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colNews_Approver.Name = "colNews_Approver";
            this.colNews_Approver.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Approver.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Approver.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Approver.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colNews_Approver.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colNews_Approver.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Approver.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Approver.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colNews_Approver.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colNews_Approver.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            // 
            // colNews_Status
            // 
            this.colNews_Status.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_Status.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_Status.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_Status.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_Status.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_Status.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_Status.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_Status.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_Status.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_Status.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_Status.FieldName = "News_Status";
            this.colNews_Status.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colNews_Status.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colNews_Status.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colNews_Status.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colNews_Status.Name = "colNews_Status";
            this.colNews_Status.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Status.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Status.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Status.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colNews_Status.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colNews_Status.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Status.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_Status.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colNews_Status.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colNews_Status.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            // 
            // colNews_PublishDate
            // 
            this.colNews_PublishDate.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_PublishDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_PublishDate.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_PublishDate.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_PublishDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_PublishDate.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_PublishDate.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNews_PublishDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNews_PublishDate.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNews_PublishDate.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNews_PublishDate.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNews_PublishDate.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNews_PublishDate.FieldName = "News_PublishDate";
            this.colNews_PublishDate.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colNews_PublishDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colNews_PublishDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colNews_PublishDate.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colNews_PublishDate.Name = "colNews_PublishDate";
            this.colNews_PublishDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_PublishDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_PublishDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_PublishDate.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colNews_PublishDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colNews_PublishDate.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_PublishDate.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colNews_PublishDate.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colNews_PublishDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colNews_PublishDate.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colNews_PublishDate.Visible = true;
            this.colNews_PublishDate.VisibleIndex = 5;
            // 
            // colLinkGoc
            // 
            this.colLinkGoc.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colLinkGoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colLinkGoc.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colLinkGoc.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colLinkGoc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colLinkGoc.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colLinkGoc.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colLinkGoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colLinkGoc.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colLinkGoc.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colLinkGoc.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colLinkGoc.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colLinkGoc.FieldName = "LinkGoc";
            this.colLinkGoc.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colLinkGoc.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colLinkGoc.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colLinkGoc.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colLinkGoc.Name = "colLinkGoc";
            this.colLinkGoc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colLinkGoc.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colLinkGoc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colLinkGoc.OptionsColumn.FixedWidth = true;
            this.colLinkGoc.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colLinkGoc.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colLinkGoc.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colLinkGoc.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colLinkGoc.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colLinkGoc.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colLinkGoc.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colLinkGoc.Visible = true;
            this.colLinkGoc.VisibleIndex = 2;
            this.colLinkGoc.Width = 100;
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
            this.colDomain.OptionsColumn.FixedWidth = true;
            this.colDomain.OptionsColumn.ReadOnly = true;
            this.colDomain.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colDomain.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colDomain.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colDomain.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colDomain.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colDomain.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colDomain.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 3;
            // 
            // colWordCount
            // 
            this.colWordCount.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colWordCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colWordCount.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colWordCount.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colWordCount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colWordCount.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colWordCount.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colWordCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colWordCount.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colWordCount.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colWordCount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colWordCount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colWordCount.FieldName = "WordCount";
            this.colWordCount.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colWordCount.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colWordCount.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colWordCount.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colWordCount.Name = "colWordCount";
            this.colWordCount.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colWordCount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colWordCount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colWordCount.OptionsColumn.FixedWidth = true;
            this.colWordCount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colWordCount.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colWordCount.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colWordCount.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colWordCount.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colWordCount.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colWordCount.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colWordCount.Visible = true;
            this.colWordCount.VisibleIndex = 4;
            // 
            // colViewCount
            // 
            this.colViewCount.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colViewCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colViewCount.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colViewCount.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colViewCount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colViewCount.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colViewCount.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colViewCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colViewCount.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colViewCount.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colViewCount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colViewCount.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colViewCount.FieldName = "ViewCount";
            this.colViewCount.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colViewCount.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colViewCount.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colViewCount.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colViewCount.Name = "colViewCount";
            this.colViewCount.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewCount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewCount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewCount.OptionsColumn.FixedWidth = true;
            this.colViewCount.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colViewCount.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colViewCount.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewCount.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colViewCount.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colViewCount.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colViewCount.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colViewCount.Visible = true;
            this.colViewCount.VisibleIndex = 5;
            // 
            // btExport
            // 
            this.btExport.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btExport.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btExport.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btExport.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btExport.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btExport.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btExport.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btExport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btExport.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btExport.Location = new System.Drawing.Point(569, 5);
            this.btExport.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(102, 23);
            this.btExport.TabIndex = 14;
            this.btExport.Text = "Export";
            this.btExport.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btViewAll
            // 
            this.btViewAll.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btViewAll.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btViewAll.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btViewAll.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btViewAll.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btViewAll.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btViewAll.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btViewAll.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btViewAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btViewAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btViewAll.Location = new System.Drawing.Point(461, 5);
            this.btViewAll.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btViewAll.Name = "btViewAll";
            this.btViewAll.Size = new System.Drawing.Size(102, 23);
            this.btViewAll.TabIndex = 12;
            this.btViewAll.Text = "Xem toàn bộ";
            this.btViewAll.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btViewAll.Click += new System.EventHandler(this.btViewAll_Click);
            // 
            // ctrDateRanger1
            // 
            this.ctrDateRanger1.FromDate = new System.DateTime(2014, 7, 20, 0, 0, 1, 0);
            this.ctrDateRanger1.Location = new System.Drawing.Point(9, 1);
            this.ctrDateRanger1.Name = "ctrDateRanger1";
            this.ctrDateRanger1.Size = new System.Drawing.Size(442, 27);
            this.ctrDateRanger1.TabIndex = 11;
            this.ctrDateRanger1.ToDate = new System.DateTime(2014, 7, 20, 23, 59, 59, 0);
            // 
            // newsReportTableAdapter
            // 
            this.newsReportTableAdapter.ClearBeforeFill = true;
            // 
            // frmNewsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(892, 458);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btViewAll);
            this.Controls.Add(this.ctrDateRanger1);
            this.Name = "frmNewsReport";
            this.Load += new System.EventHandler(this.frmNewsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btExport;
        private DevExpress.XtraEditors.SimpleButton btViewAll;
        private Entities.ctrDateRanger ctrDateRanger1;
        private DBNew dBNew;
        private System.Windows.Forms.BindingSource newsReportBindingSource;
        private DBNewTableAdapters.NewsReportTableAdapter newsReportTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colNews_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCat_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colNews_Title;
        private DevExpress.XtraGrid.Columns.GridColumn colNews_Source;
        private DevExpress.XtraGrid.Columns.GridColumn colNews_Author;
        private DevExpress.XtraGrid.Columns.GridColumn colNews_Approver;
        private DevExpress.XtraGrid.Columns.GridColumn colNews_Status;
        private DevExpress.XtraGrid.Columns.GridColumn colNews_PublishDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLinkGoc;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colWordCount;
        private DevExpress.XtraGrid.Columns.GridColumn colViewCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}
