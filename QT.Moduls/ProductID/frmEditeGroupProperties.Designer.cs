namespace QT.Moduls.ProductID
{
    partial class frmEditeGroupProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditeGroupProperties));
            this.dBProperties = new QT.Moduls.ProductID.DBProperties();
            this.propertiesGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertiesGroupTableAdapter = new QT.Moduls.ProductID.DBPropertiesTableAdapters.PropertiesGroupTableAdapter();
            this.tableAdapterManager = new QT.Moduls.ProductID.DBPropertiesTableAdapters.TableAdapterManager();
            this.propertiesGroupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesGroupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameShow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGroupBindingNavigator)).BeginInit();
            this.propertiesGroupBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dBProperties
            // 
            this.dBProperties.DataSetName = "DBProperties";
            this.dBProperties.EnforceConstraints = false;
            this.dBProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertiesGroupBindingSource
            // 
            this.propertiesGroupBindingSource.DataMember = "PropertiesGroup";
            this.propertiesGroupBindingSource.DataSource = this.dBProperties;
            // 
            // propertiesGroupTableAdapter
            // 
            this.propertiesGroupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ListClassification_PropertiesTableAdapter = null;
            this.tableAdapterManager.Product_PropertiesTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PropertiesGroupTableAdapter = this.propertiesGroupTableAdapter;
            this.tableAdapterManager.PropertiesTableAdapter = null;
            this.tableAdapterManager.PropertiesValueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.ProductID.DBPropertiesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // propertiesGroupBindingNavigator
            // 
            this.propertiesGroupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.propertiesGroupBindingNavigator.BindingSource = this.propertiesGroupBindingSource;
            this.propertiesGroupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.propertiesGroupBindingNavigator.DeleteItem = null;
            this.propertiesGroupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.propertiesGroupBindingNavigatorSaveItem});
            this.propertiesGroupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.propertiesGroupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.propertiesGroupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.propertiesGroupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.propertiesGroupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.propertiesGroupBindingNavigator.Name = "propertiesGroupBindingNavigator";
            this.propertiesGroupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propertiesGroupBindingNavigator.Size = new System.Drawing.Size(928, 25);
            this.propertiesGroupBindingNavigator.TabIndex = 0;
            this.propertiesGroupBindingNavigator.Text = "bindingNavigator1";
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
            // propertiesGroupBindingNavigatorSaveItem
            // 
            this.propertiesGroupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.propertiesGroupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("propertiesGroupBindingNavigatorSaveItem.Image")));
            this.propertiesGroupBindingNavigatorSaveItem.Name = "propertiesGroupBindingNavigatorSaveItem";
            this.propertiesGroupBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.propertiesGroupBindingNavigatorSaveItem.Text = "Save Data";
            this.propertiesGroupBindingNavigatorSaveItem.Click += new System.EventHandler(this.propertiesGroupBindingNavigatorSaveItem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.Default;
            this.gridControl1.DataSource = this.propertiesGroupBindingSource;
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
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(928, 387);
            this.gridControl1.TabIndex = 2;
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
            this.colCategoryID,
            this.colSTT,
            this.colID,
            this.colName,
            this.colNumberColumn,
            this.colNameShow,
            this.colGType});
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
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedCell;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colCategoryID
            // 
            this.colCategoryID.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colCategoryID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colCategoryID.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colCategoryID.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colCategoryID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colCategoryID.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colCategoryID.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colCategoryID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colCategoryID.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colCategoryID.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colCategoryID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colCategoryID.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colCategoryID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colCategoryID.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colCategoryID.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colCategoryID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colCategoryID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colCategoryID.OptionsColumn.FixedWidth = true;
            this.colCategoryID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colCategoryID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colCategoryID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colCategoryID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colCategoryID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colCategoryID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colCategoryID.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 1;
            this.colCategoryID.Width = 81;
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
            this.colSTT.OptionsColumn.FixedWidth = true;
            this.colSTT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colSTT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colSTT.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colSTT.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colSTT.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colSTT.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colSTT.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 2;
            this.colSTT.Width = 39;
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
            this.colID.OptionsColumn.FixedWidth = true;
            this.colID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colID.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colID.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colID.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 58;
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
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colName.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colName.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colName.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colName.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colName.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            this.colName.Width = 394;
            // 
            // colNameShow
            // 
            this.colNameShow.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNameShow.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNameShow.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNameShow.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNameShow.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNameShow.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNameShow.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNameShow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNameShow.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNameShow.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNameShow.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNameShow.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNameShow.FieldName = "NameShow";
            this.colNameShow.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colNameShow.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colNameShow.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colNameShow.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colNameShow.Name = "colNameShow";
            this.colNameShow.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colNameShow.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colNameShow.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colNameShow.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colNameShow.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colNameShow.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colNameShow.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colNameShow.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colNameShow.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colNameShow.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colNameShow.Visible = true;
            this.colNameShow.VisibleIndex = 4;
            this.colNameShow.Width = 279;
            // 
            // colGType
            // 
            this.colGType.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colGType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colGType.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colGType.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colGType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colGType.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colGType.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colGType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colGType.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colGType.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colGType.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colGType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colGType.FieldName = "GType";
            this.colGType.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colGType.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colGType.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colGType.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colGType.Name = "colGType";
            this.colGType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colGType.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colGType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colGType.OptionsColumn.FixedWidth = true;
            this.colGType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colGType.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colGType.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colGType.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colGType.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colGType.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colGType.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colGType.Visible = true;
            this.colGType.VisibleIndex = 6;
            this.colGType.Width = 56;
            // 
            // colNumberColumn
            // 
            this.colNumberColumn.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNumberColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNumberColumn.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNumberColumn.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNumberColumn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNumberColumn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNumberColumn.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.colNumberColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.colNumberColumn.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.colNumberColumn.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.colNumberColumn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.colNumberColumn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.colNumberColumn.FieldName = "NumberColumn";
            this.colNumberColumn.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value;
            this.colNumberColumn.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            this.colNumberColumn.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Default;
            this.colNumberColumn.ImageAlignment = System.Drawing.StringAlignment.Near;
            this.colNumberColumn.Name = "colNumberColumn";
            this.colNumberColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.Default;
            this.colNumberColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.Default;
            this.colNumberColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.Default;
            this.colNumberColumn.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Default;
            this.colNumberColumn.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;
            this.colNumberColumn.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.Default;
            this.colNumberColumn.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.Default;
            this.colNumberColumn.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            this.colNumberColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.Default;
            this.colNumberColumn.UnboundType = DevExpress.Data.UnboundColumnType.Bound;
            this.colNumberColumn.Visible = true;
            this.colNumberColumn.VisibleIndex = 5;
            // 
            // frmEditeGroupProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(928, 412);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.propertiesGroupBindingNavigator);
            this.Name = "frmEditeGroupProperties";
            this.Load += new System.EventHandler(this.frmEditeGroupProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGroupBindingNavigator)).EndInit();
            this.propertiesGroupBindingNavigator.ResumeLayout(false);
            this.propertiesGroupBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBProperties dBProperties;
        private System.Windows.Forms.BindingSource propertiesGroupBindingSource;
        private DBPropertiesTableAdapters.PropertiesGroupTableAdapter propertiesGroupTableAdapter;
        private DBPropertiesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator propertiesGroupBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton propertiesGroupBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNameShow;
        private DevExpress.XtraGrid.Columns.GridColumn colGType;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberColumn;
    }
}
