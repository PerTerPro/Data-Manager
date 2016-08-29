namespace QT.Moduls.ProductID
{
    partial class frmEditePropertiesValue
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditePropertiesValue));
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dBProperties = new QT.Moduls.ProductID.DBProperties();
            this.propertiesValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertiesValueTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.PropertiesValueTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPropertiesID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDFilter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHasName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.propertiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.propertiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesValueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingNavigator)).BeginInit();
            this.propertiesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.propertiesValueBindingSource;
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
            this.gridControl2.Location = new System.Drawing.Point(0, 28);
            this.gridControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl2.Size = new System.Drawing.Size(769, 380);
            this.gridControl2.TabIndex = 3;
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
            this.colID,
            this.colValue,
            this.colPropertiesID,
            this.colFilter,
            this.colIDFilter,
            this.colHasName});
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
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default;
            this.gridView2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell;
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.repositoryItemLookUpEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.repositoryItemLookUpEdit1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemLookUpEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemLookUpEdit1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemLookUpEdit1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemLookUpEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemLookUpEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemLookUpEdit1.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemLookUpEdit1.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemLookUpEdit1.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemLookUpEdit1.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemLookUpEdit1.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemLookUpEdit1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemLookUpEdit1.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemLookUpEdit1.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemLookUpEdit1.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemLookUpEdit1.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemLookUpEdit1.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemLookUpEdit1.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemLookUpEdit1.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemLookUpEdit1.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemLookUpEdit1.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemLookUpEdit1.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemLookUpEdit1.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.repositoryItemLookUpEdit1.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemLookUpEdit1.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.repositoryItemLookUpEdit1.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.repositoryItemLookUpEdit1.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.repositoryItemLookUpEdit1.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.None;
            this.repositoryItemLookUpEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            serializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            serializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            serializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            serializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            serializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemLookUpEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 137, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GType", "GType", 41, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.DropDownRows = 20;
            this.repositoryItemLookUpEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemLookUpEdit1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.repositoryItemLookUpEdit1.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.Sorting;
            this.repositoryItemLookUpEdit1.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Default;
            this.repositoryItemLookUpEdit1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupFormMinSize = new System.Drawing.Size(200, 0);
            this.repositoryItemLookUpEdit1.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.Default;
            this.repositoryItemLookUpEdit1.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            this.repositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick;
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // dBProperties
            // 
            this.dBProperties.DataSetName = "DBProperties";
            this.dBProperties.EnforceConstraints = false;
            this.dBProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertiesValueBindingSource
            // 
            this.propertiesValueBindingSource.DataMember = "PropertiesValue";
            this.propertiesValueBindingSource.DataSource = this.dBProperties;
            // 
            // propertiesValueTableAdapter
            // 
            this.propertiesValueTableAdapter.ClearBeforeFill = true;
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
            this.colID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colID.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 103;
            // 
            // colValue
            // 
            this.colValue.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colValue.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colValue.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colValue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colValue.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colValue.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colValue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colValue.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colValue.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colValue.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colValue.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colValue.FieldName = "Value";
            this.colValue.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colValue.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colValue.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colValue.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colValue.Name = "colValue";
            this.colValue.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colValue.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colValue.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colValue.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colValue.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colValue.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colValue.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colValue.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colValue.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colValue.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 1;
            this.colValue.Width = 128;
            // 
            // colPropertiesID
            // 
            this.colPropertiesID.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colPropertiesID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colPropertiesID.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colPropertiesID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colPropertiesID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colPropertiesID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colPropertiesID.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colPropertiesID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colPropertiesID.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colPropertiesID.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colPropertiesID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colPropertiesID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colPropertiesID.FieldName = "PropertiesID";
            this.colPropertiesID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colPropertiesID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colPropertiesID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colPropertiesID.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colPropertiesID.Name = "colPropertiesID";
            this.colPropertiesID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colPropertiesID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colPropertiesID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colPropertiesID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colPropertiesID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colPropertiesID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colPropertiesID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colPropertiesID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colPropertiesID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colPropertiesID.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colPropertiesID.Visible = true;
            this.colPropertiesID.VisibleIndex = 2;
            this.colPropertiesID.Width = 128;
            // 
            // colFilter
            // 
            this.colFilter.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colFilter.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colFilter.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colFilter.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colFilter.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colFilter.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colFilter.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colFilter.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colFilter.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colFilter.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colFilter.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colFilter.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colFilter.FieldName = "Filter";
            this.colFilter.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colFilter.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colFilter.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colFilter.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colFilter.Name = "colFilter";
            this.colFilter.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colFilter.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colFilter.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colFilter.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colFilter.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colFilter.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colFilter.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colFilter.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colFilter.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colFilter.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colFilter.Visible = true;
            this.colFilter.VisibleIndex = 3;
            this.colFilter.Width = 128;
            // 
            // colIDFilter
            // 
            this.colIDFilter.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colIDFilter.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colIDFilter.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colIDFilter.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colIDFilter.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colIDFilter.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colIDFilter.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colIDFilter.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colIDFilter.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colIDFilter.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colIDFilter.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colIDFilter.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colIDFilter.FieldName = "IDFilter";
            this.colIDFilter.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colIDFilter.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colIDFilter.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colIDFilter.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colIDFilter.Name = "colIDFilter";
            this.colIDFilter.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colIDFilter.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colIDFilter.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colIDFilter.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colIDFilter.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colIDFilter.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colIDFilter.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colIDFilter.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colIDFilter.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colIDFilter.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colIDFilter.Visible = true;
            this.colIDFilter.VisibleIndex = 4;
            this.colIDFilter.Width = 128;
            // 
            // colHasName
            // 
            this.colHasName.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colHasName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colHasName.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colHasName.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colHasName.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colHasName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colHasName.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colHasName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colHasName.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colHasName.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colHasName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colHasName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colHasName.FieldName = "HasName";
            this.colHasName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colHasName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colHasName.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colHasName.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colHasName.Name = "colHasName";
            this.colHasName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colHasName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colHasName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colHasName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colHasName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colHasName.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colHasName.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colHasName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colHasName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colHasName.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colHasName.Visible = true;
            this.colHasName.VisibleIndex = 5;
            this.colHasName.Width = 133;
            // 
            // propertiesBindingNavigator
            // 
            this.propertiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.propertiesBindingNavigator.BindingSource = this.propertiesValueBindingSource;
            this.propertiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.propertiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.propertiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.propertiesBindingNavigatorSaveItem});
            this.propertiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.propertiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.propertiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.propertiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.propertiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.propertiesBindingNavigator.Name = "propertiesBindingNavigator";
            this.propertiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propertiesBindingNavigator.Size = new System.Drawing.Size(769, 25);
            this.propertiesBindingNavigator.TabIndex = 4;
            this.propertiesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            // propertiesBindingNavigatorSaveItem
            // 
            this.propertiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.propertiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("propertiesBindingNavigatorSaveItem.Image")));
            this.propertiesBindingNavigatorSaveItem.Name = "propertiesBindingNavigatorSaveItem";
            this.propertiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.propertiesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // frmEditePropertiesValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(769, 410);
            this.Controls.Add(this.propertiesBindingNavigator);
            this.Controls.Add(this.gridControl2);
            this.Name = "frmEditePropertiesValue";
            this.Load += new System.EventHandler(this.frmEditePropertiesValue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesValueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingNavigator)).EndInit();
            this.propertiesBindingNavigator.ResumeLayout(false);
            this.propertiesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DBProperties dBProperties;
        private System.Windows.Forms.BindingSource propertiesValueBindingSource;
        private DBPropertiesTableAdapters.PropertiesValueTableAdapter propertiesValueTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colPropertiesID;
        private DevExpress.XtraGrid.Columns.GridColumn colFilter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFilter;
        private DevExpress.XtraGrid.Columns.GridColumn colHasName;
        private System.Windows.Forms.BindingNavigator propertiesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton propertiesBindingNavigatorSaveItem;
    }
}
