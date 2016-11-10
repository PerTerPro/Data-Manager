namespace WSS.IndividualCategoryWebsites
{
    partial class frmGetProductFromSolr
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label keywordLabel;
            System.Windows.Forms.Label keywordBlockLabel;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label categoryIdSelectedLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label minPriceLabel;
            System.Windows.Forms.Label maxPriceLabel;
            System.Windows.Forms.Label listIdBlockLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetProductFromSolr));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.logKeywordsWebsiteGridControl = new DevExpress.XtraGrid.GridControl();
            this.logKeywordsWebsiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBIndi = new WSS.IndividualCategoryWebsites.DBIndi();
            this.gvlogKeywordsWebsite = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeyword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeywordBlock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsiteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryIdSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colListIdBlock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxPrice = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnSaveLogKeywords = new System.Windows.Forms.ToolStripButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.spinEditMaxpriceSql = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditMinpriceSql = new DevExpress.XtraEditors.SpinEdit();
            this.richTextBoxListIdBlock = new System.Windows.Forms.RichTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBoxKeywordBlock = new System.Windows.Forms.RichTextBox();
            this.idKeywordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.keywordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isActiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.categoryIdSelectedTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnLoadListKeywordsWebsite = new DevExpress.XtraEditors.SimpleButton();
            this.txtWebsiteId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDomain = new DevExpress.XtraEditors.TextEdit();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grdCategory = new DevExpress.XtraGrid.GridControl();
            this.gvCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnSaveFilter = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditMaxPrice = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditMinPrice = new DevExpress.XtraEditors.SpinEdit();
            this.rbListIdBlock = new System.Windows.Forms.RichTextBox();
            this.rbKeywordBlock = new System.Windows.Forms.RichTextBox();
            this.txtKeyword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumberFound = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnGetListProductFromSolr = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grdProduct = new DevExpress.XtraGrid.GridControl();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.btnViewListProduct = new DevExpress.XtraEditors.SimpleButton();
            this.txtCountProductSelected = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCategoryName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnPushAllProductToServiceRootProduct = new DevExpress.XtraEditors.SimpleButton();
            this.txtCategoryId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStripCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewDetailProductWithCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewAllProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectListProductToServiceRootProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectProductToRootProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logKeywordsWebsiteTableAdapter = new WSS.IndividualCategoryWebsites.DBIndiTableAdapters.LogKeywordsWebsiteTableAdapter();
            this.tableAdapterManager = new WSS.IndividualCategoryWebsites.DBIndiTableAdapters.TableAdapterManager();
            this.contextMenuStripLogKeywords = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.previewDataWithLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            idLabel = new System.Windows.Forms.Label();
            keywordLabel = new System.Windows.Forms.Label();
            keywordBlockLabel = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            categoryIdSelectedLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            minPriceLabel = new System.Windows.Forms.Label();
            maxPriceLabel = new System.Windows.Forms.Label();
            listIdBlockLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logKeywordsWebsiteGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logKeywordsWebsiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIndi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlogKeywordsWebsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxpriceSql.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMinpriceSql.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idKeywordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdSelectedTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsiteId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMinPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberFound.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountProductSelected.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryId.Properties)).BeginInit();
            this.contextMenuStripCategory.SuspendLayout();
            this.contextMenuStripProduct.SuspendLayout();
            this.contextMenuStripLogKeywords.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(3, 37);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // keywordLabel
            // 
            keywordLabel.AutoSize = true;
            keywordLabel.Location = new System.Drawing.Point(3, 63);
            keywordLabel.Name = "keywordLabel";
            keywordLabel.Size = new System.Drawing.Size(51, 13);
            keywordLabel.TabIndex = 9;
            keywordLabel.Text = "Keyword:";
            // 
            // keywordBlockLabel
            // 
            keywordBlockLabel.AutoSize = true;
            keywordBlockLabel.Location = new System.Drawing.Point(3, 89);
            keywordBlockLabel.Name = "keywordBlockLabel";
            keywordBlockLabel.Size = new System.Drawing.Size(81, 13);
            keywordBlockLabel.TabIndex = 11;
            keywordBlockLabel.Text = "Keyword Block:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(3, 308);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(51, 13);
            isActiveLabel.TabIndex = 15;
            isActiveLabel.Text = "Is Active:";
            // 
            // categoryIdSelectedLabel
            // 
            categoryIdSelectedLabel.AutoSize = true;
            categoryIdSelectedLabel.Location = new System.Drawing.Point(3, 333);
            categoryIdSelectedLabel.Name = "categoryIdSelectedLabel";
            categoryIdSelectedLabel.Size = new System.Drawing.Size(109, 13);
            categoryIdSelectedLabel.TabIndex = 17;
            categoryIdSelectedLabel.Text = "Category Id Selected:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 13);
            label1.TabIndex = 13;
            label1.Text = "Từ khóa bị chặn";
            // 
            // minPriceLabel
            // 
            minPriceLabel.AutoSize = true;
            minPriceLabel.Location = new System.Drawing.Point(3, 369);
            minPriceLabel.Name = "minPriceLabel";
            minPriceLabel.Size = new System.Drawing.Size(54, 13);
            minPriceLabel.TabIndex = 19;
            minPriceLabel.Text = "Min Price:";
            // 
            // maxPriceLabel
            // 
            maxPriceLabel.AutoSize = true;
            maxPriceLabel.Location = new System.Drawing.Point(240, 369);
            maxPriceLabel.Name = "maxPriceLabel";
            maxPriceLabel.Size = new System.Drawing.Size(57, 13);
            maxPriceLabel.TabIndex = 20;
            maxPriceLabel.Text = "Max Price:";
            // 
            // listIdBlockLabel
            // 
            listIdBlockLabel.AutoSize = true;
            listIdBlockLabel.Location = new System.Drawing.Point(3, 198);
            listIdBlockLabel.Name = "listIdBlockLabel";
            listIdBlockLabel.Size = new System.Drawing.Size(68, 13);
            listIdBlockLabel.TabIndex = 21;
            listIdBlockLabel.Text = "List Id Block:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(5, 160);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 13);
            label2.TabIndex = 15;
            label2.Text = "List Id bị chặn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(5, 286);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 13);
            label3.TabIndex = 21;
            label3.Text = "Min Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(5, 308);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 13);
            label4.TabIndex = 23;
            label4.Text = "Max Price:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.logKeywordsWebsiteGridControl);
            this.splitContainerControl1.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1216, 672);
            this.splitContainerControl1.SplitterPosition = 431;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // logKeywordsWebsiteGridControl
            // 
            this.logKeywordsWebsiteGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.logKeywordsWebsiteGridControl.DataSource = this.logKeywordsWebsiteBindingSource;
            this.logKeywordsWebsiteGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logKeywordsWebsiteGridControl.Location = new System.Drawing.Point(0, 396);
            this.logKeywordsWebsiteGridControl.MainView = this.gvlogKeywordsWebsite;
            this.logKeywordsWebsiteGridControl.Name = "logKeywordsWebsiteGridControl";
            this.logKeywordsWebsiteGridControl.Size = new System.Drawing.Size(431, 251);
            this.logKeywordsWebsiteGridControl.TabIndex = 1;
            this.logKeywordsWebsiteGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlogKeywordsWebsite});
            // 
            // logKeywordsWebsiteBindingSource
            // 
            this.logKeywordsWebsiteBindingSource.DataMember = "LogKeywordsWebsite";
            this.logKeywordsWebsiteBindingSource.DataSource = this.dBIndi;
            // 
            // dBIndi
            // 
            this.dBIndi.DataSetName = "DBIndi";
            this.dBIndi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvlogKeywordsWebsite
            // 
            this.gvlogKeywordsWebsite.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colKeyword,
            this.colKeywordBlock,
            this.colWebsiteId,
            this.colIsActive,
            this.colCategoryIdSelected,
            this.colListIdBlock,
            this.colMinPrice,
            this.colMaxPrice});
            this.gvlogKeywordsWebsite.GridControl = this.logKeywordsWebsiteGridControl;
            this.gvlogKeywordsWebsite.Name = "gvlogKeywordsWebsite";
            this.gvlogKeywordsWebsite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvlogKeywordsWebsite_MouseDown);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colKeyword
            // 
            this.colKeyword.FieldName = "Keyword";
            this.colKeyword.Name = "colKeyword";
            this.colKeyword.Visible = true;
            this.colKeyword.VisibleIndex = 1;
            // 
            // colKeywordBlock
            // 
            this.colKeywordBlock.FieldName = "KeywordBlock";
            this.colKeywordBlock.Name = "colKeywordBlock";
            this.colKeywordBlock.Visible = true;
            this.colKeywordBlock.VisibleIndex = 2;
            // 
            // colWebsiteId
            // 
            this.colWebsiteId.FieldName = "WebsiteId";
            this.colWebsiteId.Name = "colWebsiteId";
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 7;
            // 
            // colCategoryIdSelected
            // 
            this.colCategoryIdSelected.FieldName = "CategoryIdSelected";
            this.colCategoryIdSelected.Name = "colCategoryIdSelected";
            this.colCategoryIdSelected.Visible = true;
            this.colCategoryIdSelected.VisibleIndex = 3;
            // 
            // colListIdBlock
            // 
            this.colListIdBlock.FieldName = "ListIdBlock";
            this.colListIdBlock.Name = "colListIdBlock";
            this.colListIdBlock.Visible = true;
            this.colListIdBlock.VisibleIndex = 4;
            // 
            // colMinPrice
            // 
            this.colMinPrice.FieldName = "MinPrice";
            this.colMinPrice.Name = "colMinPrice";
            this.colMinPrice.Visible = true;
            this.colMinPrice.VisibleIndex = 5;
            // 
            // colMaxPrice
            // 
            this.colMaxPrice.FieldName = "MaxPrice";
            this.colMaxPrice.Name = "colMaxPrice";
            this.colMaxPrice.Visible = true;
            this.colMaxPrice.VisibleIndex = 6;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.logKeywordsWebsiteBindingSource;
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
            this.btnSaveLogKeywords});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 647);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(431, 25);
            this.bindingNavigator1.TabIndex = 1;
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
            // btnSaveLogKeywords
            // 
            this.btnSaveLogKeywords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaveLogKeywords.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveLogKeywords.Image")));
            this.btnSaveLogKeywords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveLogKeywords.Name = "btnSaveLogKeywords";
            this.btnSaveLogKeywords.Size = new System.Drawing.Size(35, 22);
            this.btnSaveLogKeywords.Text = "Save";
            this.btnSaveLogKeywords.Click += new System.EventHandler(this.btnSaveLogKeywords_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.spinEditMaxpriceSql);
            this.panelControl3.Controls.Add(this.spinEditMinpriceSql);
            this.panelControl3.Controls.Add(this.richTextBoxListIdBlock);
            this.panelControl3.Controls.Add(listIdBlockLabel);
            this.panelControl3.Controls.Add(maxPriceLabel);
            this.panelControl3.Controls.Add(minPriceLabel);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Controls.Add(this.richTextBoxKeywordBlock);
            this.panelControl3.Controls.Add(idLabel);
            this.panelControl3.Controls.Add(this.idKeywordTextEdit);
            this.panelControl3.Controls.Add(keywordLabel);
            this.panelControl3.Controls.Add(this.keywordTextEdit);
            this.panelControl3.Controls.Add(keywordBlockLabel);
            this.panelControl3.Controls.Add(isActiveLabel);
            this.panelControl3.Controls.Add(this.isActiveCheckEdit);
            this.panelControl3.Controls.Add(categoryIdSelectedLabel);
            this.panelControl3.Controls.Add(this.categoryIdSelectedTextEdit);
            this.panelControl3.Controls.Add(this.btnLoadListKeywordsWebsite);
            this.panelControl3.Controls.Add(this.txtWebsiteId);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.txtDomain);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(431, 396);
            this.panelControl3.TabIndex = 0;
            // 
            // spinEditMaxpriceSql
            // 
            this.spinEditMaxpriceSql.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.logKeywordsWebsiteBindingSource, "MaxPrice", true));
            this.spinEditMaxpriceSql.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditMaxpriceSql.Location = new System.Drawing.Point(303, 366);
            this.spinEditMaxpriceSql.Name = "spinEditMaxpriceSql";
            this.spinEditMaxpriceSql.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.spinEditMaxpriceSql.Properties.DisplayFormat.FormatString = "n00";
            this.spinEditMaxpriceSql.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditMaxpriceSql.Properties.Mask.EditMask = "n00";
            this.spinEditMaxpriceSql.Size = new System.Drawing.Size(109, 20);
            this.spinEditMaxpriceSql.TabIndex = 39;
            // 
            // spinEditMinpriceSql
            // 
            this.spinEditMinpriceSql.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.logKeywordsWebsiteBindingSource, "MinPrice", true));
            this.spinEditMinpriceSql.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditMinpriceSql.Location = new System.Drawing.Point(118, 366);
            this.spinEditMinpriceSql.Name = "spinEditMinpriceSql";
            this.spinEditMinpriceSql.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.spinEditMinpriceSql.Properties.DisplayFormat.FormatString = "n00";
            this.spinEditMinpriceSql.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditMinpriceSql.Properties.Mask.EditMask = "n00";
            this.spinEditMinpriceSql.Size = new System.Drawing.Size(109, 20);
            this.spinEditMinpriceSql.TabIndex = 38;
            // 
            // richTextBoxListIdBlock
            // 
            this.richTextBoxListIdBlock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logKeywordsWebsiteBindingSource, "ListIdBlock", true));
            this.richTextBoxListIdBlock.Location = new System.Drawing.Point(118, 195);
            this.richTextBoxListIdBlock.Name = "richTextBoxListIdBlock";
            this.richTextBoxListIdBlock.Size = new System.Drawing.Size(232, 101);
            this.richTextBoxListIdBlock.TabIndex = 23;
            this.richTextBoxListIdBlock.Text = "";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(118, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Domain";
            // 
            // richTextBoxKeywordBlock
            // 
            this.richTextBoxKeywordBlock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logKeywordsWebsiteBindingSource, "KeywordBlock", true));
            this.richTextBoxKeywordBlock.Location = new System.Drawing.Point(118, 87);
            this.richTextBoxKeywordBlock.Name = "richTextBoxKeywordBlock";
            this.richTextBoxKeywordBlock.Size = new System.Drawing.Size(232, 101);
            this.richTextBoxKeywordBlock.TabIndex = 6;
            this.richTextBoxKeywordBlock.Text = "";
            // 
            // idKeywordTextEdit
            // 
            this.idKeywordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.logKeywordsWebsiteBindingSource, "Id", true));
            this.idKeywordTextEdit.Location = new System.Drawing.Point(118, 34);
            this.idKeywordTextEdit.Name = "idKeywordTextEdit";
            this.idKeywordTextEdit.Properties.ReadOnly = true;
            this.idKeywordTextEdit.Size = new System.Drawing.Size(232, 20);
            this.idKeywordTextEdit.TabIndex = 8;
            // 
            // keywordTextEdit
            // 
            this.keywordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.logKeywordsWebsiteBindingSource, "Keyword", true));
            this.keywordTextEdit.Location = new System.Drawing.Point(118, 60);
            this.keywordTextEdit.Name = "keywordTextEdit";
            this.keywordTextEdit.Size = new System.Drawing.Size(232, 20);
            this.keywordTextEdit.TabIndex = 10;
            this.keywordTextEdit.EditValueChanged += new System.EventHandler(this.keywordTextEdit_EditValueChanged);
            // 
            // isActiveCheckEdit
            // 
            this.isActiveCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.logKeywordsWebsiteBindingSource, "IsActive", true));
            this.isActiveCheckEdit.Location = new System.Drawing.Point(118, 305);
            this.isActiveCheckEdit.Name = "isActiveCheckEdit";
            this.isActiveCheckEdit.Properties.Caption = "Active";
            this.isActiveCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.isActiveCheckEdit.TabIndex = 16;
            // 
            // categoryIdSelectedTextEdit
            // 
            this.categoryIdSelectedTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.logKeywordsWebsiteBindingSource, "CategoryIdSelected", true));
            this.categoryIdSelectedTextEdit.Location = new System.Drawing.Point(118, 330);
            this.categoryIdSelectedTextEdit.Name = "categoryIdSelectedTextEdit";
            this.categoryIdSelectedTextEdit.Size = new System.Drawing.Size(100, 20);
            this.categoryIdSelectedTextEdit.TabIndex = 18;
            // 
            // btnLoadListKeywordsWebsite
            // 
            this.btnLoadListKeywordsWebsite.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadListKeywordsWebsite.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnLoadListKeywordsWebsite.Appearance.Options.UseFont = true;
            this.btnLoadListKeywordsWebsite.Appearance.Options.UseForeColor = true;
            this.btnLoadListKeywordsWebsite.Location = new System.Drawing.Point(365, 2);
            this.btnLoadListKeywordsWebsite.Name = "btnLoadListKeywordsWebsite";
            this.btnLoadListKeywordsWebsite.Size = new System.Drawing.Size(61, 48);
            this.btnLoadListKeywordsWebsite.TabIndex = 6;
            this.btnLoadListKeywordsWebsite.Text = "Load List \r\nKeyword";
            this.btnLoadListKeywordsWebsite.Click += new System.EventHandler(this.btnLoadListKeywordsWebsite_Click);
            // 
            // txtWebsiteId
            // 
            this.txtWebsiteId.EditValue = "";
            this.txtWebsiteId.Location = new System.Drawing.Point(58, 2);
            this.txtWebsiteId.Name = "txtWebsiteId";
            this.txtWebsiteId.Properties.ReadOnly = true;
            this.txtWebsiteId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWebsiteId.Size = new System.Drawing.Size(54, 20);
            this.txtWebsiteId.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(3, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "WebsiteId";
            // 
            // txtDomain
            // 
            this.txtDomain.EditValue = "";
            this.txtDomain.Location = new System.Drawing.Point(168, 2);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Properties.ReadOnly = true;
            this.txtDomain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDomain.Size = new System.Drawing.Size(182, 20);
            this.txtDomain.TabIndex = 7;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.grdCategory);
            this.splitContainerControl2.Panel1.Controls.Add(this.panelControl4);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl2.Panel2.Controls.Add(this.panelControl5);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(777, 672);
            this.splitContainerControl2.SplitterPosition = 256;
            this.splitContainerControl2.TabIndex = 1;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // grdCategory
            // 
            this.grdCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCategory.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdCategory.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdCategory.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdCategory.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdCategory.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdCategory.Location = new System.Drawing.Point(0, 396);
            this.grdCategory.MainView = this.gvCategory;
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.Size = new System.Drawing.Size(256, 276);
            this.grdCategory.TabIndex = 3;
            this.grdCategory.UseEmbeddedNavigator = true;
            this.grdCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategory});
            // 
            // gvCategory
            // 
            this.gvCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvCategory.GridControl = this.grdCategory;
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.OptionsBehavior.Editable = false;
            this.gvCategory.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCategory_RowClick);
            this.gvCategory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvCategory_MouseDown);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "CategoryId";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 39;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cate";
            this.gridColumn2.FieldName = "CategoryName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 127;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Count";
            this.gridColumn3.FieldName = "CountProductInCat";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 78;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnSaveFilter);
            this.panelControl4.Controls.Add(this.spinEditMaxPrice);
            this.panelControl4.Controls.Add(this.spinEditMinPrice);
            this.panelControl4.Controls.Add(label4);
            this.panelControl4.Controls.Add(label3);
            this.panelControl4.Controls.Add(this.rbListIdBlock);
            this.panelControl4.Controls.Add(label2);
            this.panelControl4.Controls.Add(this.rbKeywordBlock);
            this.panelControl4.Controls.Add(label1);
            this.panelControl4.Controls.Add(this.txtKeyword);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.txtNumberFound);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Controls.Add(this.btnGetListProductFromSolr);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(256, 396);
            this.panelControl4.TabIndex = 0;
            // 
            // btnSaveFilter
            // 
            this.btnSaveFilter.Location = new System.Drawing.Point(157, 333);
            this.btnSaveFilter.Name = "btnSaveFilter";
            this.btnSaveFilter.Size = new System.Drawing.Size(93, 30);
            this.btnSaveFilter.TabIndex = 39;
            this.btnSaveFilter.Text = "Lưu Filter";
            this.btnSaveFilter.Click += new System.EventHandler(this.btnSaveFilter_Click);
            // 
            // spinEditMaxPrice
            // 
            this.spinEditMaxPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditMaxPrice.Location = new System.Drawing.Point(140, 305);
            this.spinEditMaxPrice.Name = "spinEditMaxPrice";
            this.spinEditMaxPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.spinEditMaxPrice.Properties.DisplayFormat.FormatString = "n00";
            this.spinEditMaxPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditMaxPrice.Properties.Mask.EditMask = "n00";
            this.spinEditMaxPrice.Size = new System.Drawing.Size(109, 20);
            this.spinEditMaxPrice.TabIndex = 38;
            // 
            // spinEditMinPrice
            // 
            this.spinEditMinPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditMinPrice.Location = new System.Drawing.Point(140, 283);
            this.spinEditMinPrice.Name = "spinEditMinPrice";
            this.spinEditMinPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.spinEditMinPrice.Properties.DisplayFormat.FormatString = "n00";
            this.spinEditMinPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditMinPrice.Properties.Mask.EditMask = "n00";
            this.spinEditMinPrice.Size = new System.Drawing.Size(109, 20);
            this.spinEditMinPrice.TabIndex = 37;
            // 
            // rbListIdBlock
            // 
            this.rbListIdBlock.Location = new System.Drawing.Point(67, 176);
            this.rbListIdBlock.Name = "rbListIdBlock";
            this.rbListIdBlock.Size = new System.Drawing.Size(182, 101);
            this.rbListIdBlock.TabIndex = 14;
            this.rbListIdBlock.Text = "";
            // 
            // rbKeywordBlock
            // 
            this.rbKeywordBlock.Location = new System.Drawing.Point(68, 53);
            this.rbKeywordBlock.Name = "rbKeywordBlock";
            this.rbKeywordBlock.Size = new System.Drawing.Size(182, 101);
            this.rbKeywordBlock.TabIndex = 12;
            this.rbKeywordBlock.Text = "";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(68, 12);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(182, 20);
            this.txtKeyword.TabIndex = 6;
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Từ khóa";
            // 
            // txtNumberFound
            // 
            this.txtNumberFound.EditValue = "";
            this.txtNumberFound.Enabled = false;
            this.txtNumberFound.Location = new System.Drawing.Point(156, 371);
            this.txtNumberFound.Name = "txtNumberFound";
            this.txtNumberFound.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtNumberFound.Properties.Appearance.Options.UseForeColor = true;
            this.txtNumberFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumberFound.Size = new System.Drawing.Size(93, 20);
            this.txtNumberFound.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(68, 374);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Number Found";
            // 
            // btnGetListProductFromSolr
            // 
            this.btnGetListProductFromSolr.Location = new System.Drawing.Point(8, 333);
            this.btnGetListProductFromSolr.Name = "btnGetListProductFromSolr";
            this.btnGetListProductFromSolr.Size = new System.Drawing.Size(109, 30);
            this.btnGetListProductFromSolr.TabIndex = 2;
            this.btnGetListProductFromSolr.Text = "Search";
            this.btnGetListProductFromSolr.Click += new System.EventHandler(this.btnGetListProductFromSolr_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.grdProduct);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 76);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(513, 596);
            this.panelControl1.TabIndex = 3;
            // 
            // grdProduct
            // 
            this.grdProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdProduct.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdProduct.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdProduct.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdProduct.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdProduct.Location = new System.Drawing.Point(0, 0);
            this.grdProduct.MainView = this.gvProduct;
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.Size = new System.Drawing.Size(513, 596);
            this.grdProduct.TabIndex = 2;
            this.grdProduct.UseEmbeddedNavigator = true;
            this.grdProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            // 
            // gvProduct
            // 
            this.gvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gvProduct.GridControl = this.grdProduct;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvProduct.OptionsSelection.MultiSelect = true;
            this.gvProduct.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvProduct.OptionsView.ShowAutoFilterRow = true;
            this.gvProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvProduct_MouseDown);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Id";
            this.gridColumn4.FieldName = "Id";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 61;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Name";
            this.gridColumn5.FieldName = "Name";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 160;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Price";
            this.gridColumn6.DisplayFormat.FormatString = "N00";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "Price";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 59;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "MerchantScore";
            this.gridColumn7.FieldName = "MerchantScore";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 85;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "WebsiteId";
            this.gridColumn8.FieldName = "WebsiteId";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 61;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "CategoryId";
            this.gridColumn9.FieldName = "CategoryId";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.btnViewListProduct);
            this.panelControl5.Controls.Add(this.txtCountProductSelected);
            this.panelControl5.Controls.Add(this.labelControl6);
            this.panelControl5.Controls.Add(this.txtCategoryName);
            this.panelControl5.Controls.Add(this.labelControl7);
            this.panelControl5.Controls.Add(this.btnPushAllProductToServiceRootProduct);
            this.panelControl5.Controls.Add(this.txtCategoryId);
            this.panelControl5.Controls.Add(this.labelControl2);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(0, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(513, 76);
            this.panelControl5.TabIndex = 0;
            // 
            // btnViewListProduct
            // 
            this.btnViewListProduct.Location = new System.Drawing.Point(222, 10);
            this.btnViewListProduct.Name = "btnViewListProduct";
            this.btnViewListProduct.Size = new System.Drawing.Size(132, 23);
            this.btnViewListProduct.TabIndex = 8;
            this.btnViewListProduct.Text = "Load list product đã chọn";
            this.btnViewListProduct.Click += new System.EventHandler(this.btnViewListProduct_Click);
            // 
            // txtCountProductSelected
            // 
            this.txtCountProductSelected.Location = new System.Drawing.Point(116, 12);
            this.txtCountProductSelected.Name = "txtCountProductSelected";
            this.txtCountProductSelected.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountProductSelected.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtCountProductSelected.Properties.Appearance.Options.UseFont = true;
            this.txtCountProductSelected.Properties.Appearance.Options.UseForeColor = true;
            this.txtCountProductSelected.Properties.ReadOnly = true;
            this.txtCountProductSelected.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCountProductSelected.Size = new System.Drawing.Size(100, 20);
            this.txtCountProductSelected.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(93, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Số Product đã chọn";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.EditValue = "";
            this.txtCategoryName.Location = new System.Drawing.Point(216, 50);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCategoryName.Size = new System.Drawing.Size(138, 20);
            this.txtCategoryName.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(128, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 13);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "CategoryName";
            // 
            // btnPushAllProductToServiceRootProduct
            // 
            this.btnPushAllProductToServiceRootProduct.Location = new System.Drawing.Point(379, 5);
            this.btnPushAllProductToServiceRootProduct.Name = "btnPushAllProductToServiceRootProduct";
            this.btnPushAllProductToServiceRootProduct.Size = new System.Drawing.Size(128, 65);
            this.btnPushAllProductToServiceRootProduct.TabIndex = 5;
            this.btnPushAllProductToServiceRootProduct.Text = "Push Message \r\nsản phẩm đã chọn";
            this.btnPushAllProductToServiceRootProduct.Click += new System.EventHandler(this.btnPushAllProductToServiceRootProduct_Click);
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.EditValue = "";
            this.txtCategoryId.Location = new System.Drawing.Point(67, 50);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCategoryId.Size = new System.Drawing.Size(51, 20);
            this.txtCategoryId.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "CategoryId";
            // 
            // contextMenuStripCategory
            // 
            this.contextMenuStripCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewDetailProductWithCategoryToolStripMenuItem,
            this.ViewAllProductToolStripMenuItem});
            this.contextMenuStripCategory.Name = "contextMenuStrip1";
            this.contextMenuStripCategory.Size = new System.Drawing.Size(283, 48);
            // 
            // ViewDetailProductWithCategoryToolStripMenuItem
            // 
            this.ViewDetailProductWithCategoryToolStripMenuItem.Name = "ViewDetailProductWithCategoryToolStripMenuItem";
            this.ViewDetailProductWithCategoryToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.ViewDetailProductWithCategoryToolStripMenuItem.Text = "Xem chi tiết sản phẩm với category này";
            this.ViewDetailProductWithCategoryToolStripMenuItem.Click += new System.EventHandler(this.ViewDetailProductWithCategoryToolStripMenuItem_Click);
            // 
            // ViewAllProductToolStripMenuItem
            // 
            this.ViewAllProductToolStripMenuItem.Name = "ViewAllProductToolStripMenuItem";
            this.ViewAllProductToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.ViewAllProductToolStripMenuItem.Text = "Xem tất cả sản phẩm";
            this.ViewAllProductToolStripMenuItem.Click += new System.EventHandler(this.ViewAllProductToolStripMenuItem_Click);
            // 
            // contextMenuStripProduct
            // 
            this.contextMenuStripProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectListProductToServiceRootProductToolStripMenuItem,
            this.selectProductToRootProductToolStripMenuItem});
            this.contextMenuStripProduct.Name = "contextMenuStrip2";
            this.contextMenuStripProduct.Size = new System.Drawing.Size(271, 48);
            // 
            // selectListProductToServiceRootProductToolStripMenuItem
            // 
            this.selectListProductToServiceRootProductToolStripMenuItem.Name = "selectListProductToServiceRootProductToolStripMenuItem";
            this.selectListProductToServiceRootProductToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.selectListProductToServiceRootProductToolStripMenuItem.Text = "Chọn list Product";
            this.selectListProductToServiceRootProductToolStripMenuItem.Click += new System.EventHandler(this.selectListProductToServiceRootProductToolStripMenuItem_Click);
            // 
            // selectProductToRootProductToolStripMenuItem
            // 
            this.selectProductToRootProductToolStripMenuItem.Name = "selectProductToRootProductToolStripMenuItem";
            this.selectProductToRootProductToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.selectProductToRootProductToolStripMenuItem.Text = "Chọn sản phẩm thành sản phẩm gốc";
            this.selectProductToRootProductToolStripMenuItem.Click += new System.EventHandler(this.selectProductToRootProductToolStripMenuItem_Click);
            // 
            // logKeywordsWebsiteTableAdapter
            // 
            this.logKeywordsWebsiteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.LogKeywordsWebsiteTableAdapter = this.logKeywordsWebsiteTableAdapter;
            this.tableAdapterManager.RootProductsTableAdapter = null;
            this.tableAdapterManager.TagsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WSS.IndividualCategoryWebsites.DBIndiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WebsitesTableAdapter = null;
            // 
            // contextMenuStripLogKeywords
            // 
            this.contextMenuStripLogKeywords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewDataWithLogToolStripMenuItem});
            this.contextMenuStripLogKeywords.Name = "contextMenuStripLogKeywords";
            this.contextMenuStripLogKeywords.Size = new System.Drawing.Size(194, 26);
            // 
            // previewDataWithLogToolStripMenuItem
            // 
            this.previewDataWithLogToolStripMenuItem.Name = "previewDataWithLogToolStripMenuItem";
            this.previewDataWithLogToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.previewDataWithLogToolStripMenuItem.Text = "Preview Data With Log";
            this.previewDataWithLogToolStripMenuItem.Click += new System.EventHandler(this.previewDataWithLogToolStripMenuItem_Click);
            // 
            // frmGetProductFromSolr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 672);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmGetProductFromSolr";
            this.Text = "frmGetProductFromSolr";
            this.Load += new System.EventHandler(this.frmGetProductFromSolr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logKeywordsWebsiteGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logKeywordsWebsiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBIndi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlogKeywordsWebsite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxpriceSql.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMinpriceSql.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idKeywordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActiveCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdSelectedTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebsiteId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMaxPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMinPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberFound.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountProductSelected.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryId.Properties)).EndInit();
            this.contextMenuStripCategory.ResumeLayout(false);
            this.contextMenuStripProduct.ResumeLayout(false);
            this.contextMenuStripLogKeywords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGetListProductFromSolr;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNumberFound;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPushAllProductToServiceRootProduct;
        private DevExpress.XtraGrid.GridControl grdProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
        private DevExpress.XtraEditors.TextEdit txtDomain;
        private DevExpress.XtraEditors.TextEdit txtWebsiteId;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl grdCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategory;
        private DevExpress.XtraEditors.TextEdit txtKeyword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCategory;
        private System.Windows.Forms.ToolStripMenuItem ViewDetailProductWithCategoryToolStripMenuItem;
        private DevExpress.XtraEditors.TextEdit txtCategoryName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCategoryId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProduct;
        private System.Windows.Forms.ToolStripMenuItem selectListProductToServiceRootProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewAllProductToolStripMenuItem;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DBIndi dBIndi;
        private System.Windows.Forms.BindingSource logKeywordsWebsiteBindingSource;
        private DBIndiTableAdapters.LogKeywordsWebsiteTableAdapter logKeywordsWebsiteTableAdapter;
        private DBIndiTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl logKeywordsWebsiteGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlogKeywordsWebsite;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton btnLoadListKeywordsWebsite;
        private System.Windows.Forms.RichTextBox richTextBoxKeywordBlock;
        private DevExpress.XtraEditors.TextEdit idKeywordTextEdit;
        private DevExpress.XtraEditors.TextEdit keywordTextEdit;
        private DevExpress.XtraEditors.CheckEdit isActiveCheckEdit;
        private DevExpress.XtraEditors.TextEdit categoryIdSelectedTextEdit;
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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.RichTextBox rbKeywordBlock;
        private DevExpress.XtraEditors.TextEdit txtCountProductSelected;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnViewListProduct;
        private System.Windows.Forms.ToolStripButton btnSaveLogKeywords;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colKeyword;
        private DevExpress.XtraGrid.Columns.GridColumn colKeywordBlock;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsiteId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryIdSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colListIdBlock;
        private DevExpress.XtraGrid.Columns.GridColumn colMinPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxPrice;
        private System.Windows.Forms.RichTextBox richTextBoxListIdBlock;
        private System.Windows.Forms.RichTextBox rbListIdBlock;
        private DevExpress.XtraEditors.SpinEdit spinEditMinPrice;
        private DevExpress.XtraEditors.SpinEdit spinEditMaxpriceSql;
        private DevExpress.XtraEditors.SpinEdit spinEditMinpriceSql;
        private DevExpress.XtraEditors.SpinEdit spinEditMaxPrice;
        private DevExpress.XtraEditors.SimpleButton btnSaveFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLogKeywords;
        private System.Windows.Forms.ToolStripMenuItem previewDataWithLogToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.ToolStripMenuItem selectProductToRootProductToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}