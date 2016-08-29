namespace QT.Moduls.RaoVat
{
    partial class FrmConfigRunCrawler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigRunCrawler));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label config_idLabel;
            System.Windows.Forms.Label rootlinkLabel;
            System.Windows.Forms.Label number_threadLabel;
            System.Windows.Forms.Label second_sleep_recrawlerLabel;
            System.Windows.Forms.Label type_crawlerLabel;
            System.Windows.Forms.Label is_find_newLabel;
            System.Windows.Forms.Label is_reload_itemLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crawlerSaleNew = new QT.Moduls.RaoVat.CrawlerSaleNew();
            this.config_run_crawlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.config_run_crawlerTableAdapter = new QT.Moduls.RaoVat.CrawlerSaleNewTableAdapters.config_run_crawlerTableAdapter();
            this.tableAdapterManager = new QT.Moduls.RaoVat.CrawlerSaleNewTableAdapters.TableAdapterManager();
            this.config_run_crawlerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.config_run_crawlerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.config_run_crawlerGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconfig_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrootlink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumber_thread = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsecond_sleep_recrawler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype_crawler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colis_find_new = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colis_reload_item = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.config_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.rootlinkTextBox = new System.Windows.Forms.TextBox();
            this.number_threadSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.second_sleep_recrawlerSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.type_crawlerSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.is_find_newCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.is_reload_itemCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            idLabel = new System.Windows.Forms.Label();
            config_idLabel = new System.Windows.Forms.Label();
            rootlinkLabel = new System.Windows.Forms.Label();
            number_threadLabel = new System.Windows.Forms.Label();
            second_sleep_recrawlerLabel = new System.Windows.Forms.Label();
            type_crawlerLabel = new System.Windows.Forms.Label();
            is_find_newLabel = new System.Windows.Forms.Label();
            is_reload_itemLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerSaleNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_run_crawlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_run_crawlerBindingNavigator)).BeginInit();
            this.config_run_crawlerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_run_crawlerGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_threadSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_sleep_recrawlerSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_crawlerSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_find_newCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_reload_itemCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.config_run_crawlerGridControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 486);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(idLabel);
            this.panel2.Controls.Add(this.idSpinEdit);
            this.panel2.Controls.Add(config_idLabel);
            this.panel2.Controls.Add(this.config_idSpinEdit);
            this.panel2.Controls.Add(rootlinkLabel);
            this.panel2.Controls.Add(this.rootlinkTextBox);
            this.panel2.Controls.Add(number_threadLabel);
            this.panel2.Controls.Add(this.number_threadSpinEdit);
            this.panel2.Controls.Add(second_sleep_recrawlerLabel);
            this.panel2.Controls.Add(this.second_sleep_recrawlerSpinEdit);
            this.panel2.Controls.Add(type_crawlerLabel);
            this.panel2.Controls.Add(this.type_crawlerSpinEdit);
            this.panel2.Controls.Add(is_find_newLabel);
            this.panel2.Controls.Add(this.is_find_newCheckEdit);
            this.panel2.Controls.Add(is_reload_itemLabel);
            this.panel2.Controls.Add(this.is_reload_itemCheckEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(607, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 486);
            this.panel2.TabIndex = 1;
            // 
            // crawlerSaleNew
            // 
            this.crawlerSaleNew.DataSetName = "CrawlerSaleNew";
            this.crawlerSaleNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // config_run_crawlerBindingSource
            // 
            this.config_run_crawlerBindingSource.DataMember = "config_run_crawler";
            this.config_run_crawlerBindingSource.DataSource = this.crawlerSaleNew;
            // 
            // config_run_crawlerTableAdapter
            // 
            this.config_run_crawlerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.config_run_crawlerTableAdapter = this.config_run_crawlerTableAdapter;
            this.tableAdapterManager.RegexFindKeyWordTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.RaoVat.CrawlerSaleNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WebSiteTableAdapter = null;
            // 
            // config_run_crawlerBindingNavigator
            // 
            this.config_run_crawlerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.config_run_crawlerBindingNavigator.BindingSource = this.config_run_crawlerBindingSource;
            this.config_run_crawlerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.config_run_crawlerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.config_run_crawlerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.config_run_crawlerBindingNavigatorSaveItem});
            this.config_run_crawlerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.config_run_crawlerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.config_run_crawlerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.config_run_crawlerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.config_run_crawlerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.config_run_crawlerBindingNavigator.Name = "config_run_crawlerBindingNavigator";
            this.config_run_crawlerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.config_run_crawlerBindingNavigator.Size = new System.Drawing.Size(607, 25);
            this.config_run_crawlerBindingNavigator.TabIndex = 2;
            this.config_run_crawlerBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // config_run_crawlerBindingNavigatorSaveItem
            // 
            this.config_run_crawlerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.config_run_crawlerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("config_run_crawlerBindingNavigatorSaveItem.Image")));
            this.config_run_crawlerBindingNavigatorSaveItem.Name = "config_run_crawlerBindingNavigatorSaveItem";
            this.config_run_crawlerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.config_run_crawlerBindingNavigatorSaveItem.Text = "Save Data";
            this.config_run_crawlerBindingNavigatorSaveItem.Click += new System.EventHandler(this.config_run_crawlerBindingNavigatorSaveItem_Click_1);
            // 
            // config_run_crawlerGridControl
            // 
            this.config_run_crawlerGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.config_run_crawlerGridControl.DataSource = this.config_run_crawlerBindingSource;
            this.config_run_crawlerGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.config_run_crawlerGridControl.Location = new System.Drawing.Point(0, 0);
            this.config_run_crawlerGridControl.MainView = this.gridView1;
            this.config_run_crawlerGridControl.Name = "config_run_crawlerGridControl";
            this.config_run_crawlerGridControl.Size = new System.Drawing.Size(607, 486);
            this.config_run_crawlerGridControl.TabIndex = 0;
            this.config_run_crawlerGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colconfig_id,
            this.colrootlink,
            this.colnumber_thread,
            this.colsecond_sleep_recrawler,
            this.coltype_crawler,
            this.colis_find_new,
            this.colis_reload_item});
            this.gridView1.GridControl = this.config_run_crawlerGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.config_run_crawlerBindingNavigator);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 30);
            this.panel3.TabIndex = 1;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colconfig_id
            // 
            this.colconfig_id.FieldName = "config_id";
            this.colconfig_id.Name = "colconfig_id";
            this.colconfig_id.Visible = true;
            this.colconfig_id.VisibleIndex = 1;
            // 
            // colrootlink
            // 
            this.colrootlink.FieldName = "rootlink";
            this.colrootlink.Name = "colrootlink";
            this.colrootlink.Visible = true;
            this.colrootlink.VisibleIndex = 2;
            // 
            // colnumber_thread
            // 
            this.colnumber_thread.FieldName = "number_thread";
            this.colnumber_thread.Name = "colnumber_thread";
            this.colnumber_thread.Visible = true;
            this.colnumber_thread.VisibleIndex = 3;
            // 
            // colsecond_sleep_recrawler
            // 
            this.colsecond_sleep_recrawler.FieldName = "second_sleep_recrawler";
            this.colsecond_sleep_recrawler.Name = "colsecond_sleep_recrawler";
            this.colsecond_sleep_recrawler.Visible = true;
            this.colsecond_sleep_recrawler.VisibleIndex = 4;
            // 
            // coltype_crawler
            // 
            this.coltype_crawler.FieldName = "type_crawler";
            this.coltype_crawler.Name = "coltype_crawler";
            this.coltype_crawler.Visible = true;
            this.coltype_crawler.VisibleIndex = 5;
            // 
            // colis_find_new
            // 
            this.colis_find_new.FieldName = "is_find_new";
            this.colis_find_new.Name = "colis_find_new";
            this.colis_find_new.Visible = true;
            this.colis_find_new.VisibleIndex = 6;
            // 
            // colis_reload_item
            // 
            this.colis_reload_item.FieldName = "is_reload_item";
            this.colis_reload_item.Name = "colis_reload_item";
            this.colis_reload_item.Visible = true;
            this.colis_reload_item.VisibleIndex = 7;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(14, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "id:";
            // 
            // idSpinEdit
            // 
            this.idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "id", true));
            this.idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idSpinEdit.Location = new System.Drawing.Point(139, 12);
            this.idSpinEdit.Name = "idSpinEdit";
            this.idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.idSpinEdit.TabIndex = 1;
            // 
            // config_idLabel
            // 
            config_idLabel.AutoSize = true;
            config_idLabel.Location = new System.Drawing.Point(14, 41);
            config_idLabel.Name = "config_idLabel";
            config_idLabel.Size = new System.Drawing.Size(50, 13);
            config_idLabel.TabIndex = 2;
            config_idLabel.Text = "config id:";
            // 
            // config_idSpinEdit
            // 
            this.config_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "config_id", true));
            this.config_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.config_idSpinEdit.Location = new System.Drawing.Point(139, 38);
            this.config_idSpinEdit.Name = "config_idSpinEdit";
            this.config_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.config_idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.config_idSpinEdit.TabIndex = 3;
            // 
            // rootlinkLabel
            // 
            rootlinkLabel.AutoSize = true;
            rootlinkLabel.Location = new System.Drawing.Point(14, 127);
            rootlinkLabel.Name = "rootlinkLabel";
            rootlinkLabel.Size = new System.Drawing.Size(44, 13);
            rootlinkLabel.TabIndex = 4;
            rootlinkLabel.Text = "rootlink:";
            // 
            // rootlinkTextBox
            // 
            this.rootlinkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_run_crawlerBindingSource, "rootlink", true));
            this.rootlinkTextBox.Location = new System.Drawing.Point(139, 124);
            this.rootlinkTextBox.Multiline = true;
            this.rootlinkTextBox.Name = "rootlinkTextBox";
            this.rootlinkTextBox.Size = new System.Drawing.Size(406, 280);
            this.rootlinkTextBox.TabIndex = 5;
            // 
            // number_threadLabel
            // 
            number_threadLabel.AutoSize = true;
            number_threadLabel.Location = new System.Drawing.Point(320, 15);
            number_threadLabel.Name = "number_threadLabel";
            number_threadLabel.Size = new System.Drawing.Size(78, 13);
            number_threadLabel.TabIndex = 6;
            number_threadLabel.Text = "number thread:";
            // 
            // number_threadSpinEdit
            // 
            this.number_threadSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "number_thread", true));
            this.number_threadSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.number_threadSpinEdit.Location = new System.Drawing.Point(445, 12);
            this.number_threadSpinEdit.Name = "number_threadSpinEdit";
            this.number_threadSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.number_threadSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.number_threadSpinEdit.TabIndex = 7;
            // 
            // second_sleep_recrawlerLabel
            // 
            second_sleep_recrawlerLabel.AutoSize = true;
            second_sleep_recrawlerLabel.Location = new System.Drawing.Point(320, 41);
            second_sleep_recrawlerLabel.Name = "second_sleep_recrawlerLabel";
            second_sleep_recrawlerLabel.Size = new System.Drawing.Size(119, 13);
            second_sleep_recrawlerLabel.TabIndex = 8;
            second_sleep_recrawlerLabel.Text = "second sleep recrawler:";
            // 
            // second_sleep_recrawlerSpinEdit
            // 
            this.second_sleep_recrawlerSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "second_sleep_recrawler", true));
            this.second_sleep_recrawlerSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.second_sleep_recrawlerSpinEdit.Location = new System.Drawing.Point(445, 38);
            this.second_sleep_recrawlerSpinEdit.Name = "second_sleep_recrawlerSpinEdit";
            this.second_sleep_recrawlerSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.second_sleep_recrawlerSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.second_sleep_recrawlerSpinEdit.TabIndex = 9;
            // 
            // type_crawlerLabel
            // 
            type_crawlerLabel.AutoSize = true;
            type_crawlerLabel.Location = new System.Drawing.Point(320, 67);
            type_crawlerLabel.Name = "type_crawlerLabel";
            type_crawlerLabel.Size = new System.Drawing.Size(67, 13);
            type_crawlerLabel.TabIndex = 10;
            type_crawlerLabel.Text = "type crawler:";
            // 
            // type_crawlerSpinEdit
            // 
            this.type_crawlerSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "type_crawler", true));
            this.type_crawlerSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.type_crawlerSpinEdit.Location = new System.Drawing.Point(445, 64);
            this.type_crawlerSpinEdit.Name = "type_crawlerSpinEdit";
            this.type_crawlerSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type_crawlerSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.type_crawlerSpinEdit.TabIndex = 11;
            // 
            // is_find_newLabel
            // 
            is_find_newLabel.AutoSize = true;
            is_find_newLabel.Location = new System.Drawing.Point(14, 77);
            is_find_newLabel.Name = "is_find_newLabel";
            is_find_newLabel.Size = new System.Drawing.Size(60, 13);
            is_find_newLabel.TabIndex = 12;
            is_find_newLabel.Text = "is find new:";
            // 
            // is_find_newCheckEdit
            // 
            this.is_find_newCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "is_find_new", true));
            this.is_find_newCheckEdit.Location = new System.Drawing.Point(139, 74);
            this.is_find_newCheckEdit.Name = "is_find_newCheckEdit";
            this.is_find_newCheckEdit.Properties.Caption = "checkEdit1";
            this.is_find_newCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.is_find_newCheckEdit.TabIndex = 13;
            // 
            // is_reload_itemLabel
            // 
            is_reload_itemLabel.AutoSize = true;
            is_reload_itemLabel.Location = new System.Drawing.Point(14, 102);
            is_reload_itemLabel.Name = "is_reload_itemLabel";
            is_reload_itemLabel.Size = new System.Drawing.Size(71, 13);
            is_reload_itemLabel.TabIndex = 14;
            is_reload_itemLabel.Text = "is reload item:";
            // 
            // is_reload_itemCheckEdit
            // 
            this.is_reload_itemCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "is_reload_item", true));
            this.is_reload_itemCheckEdit.Location = new System.Drawing.Point(139, 99);
            this.is_reload_itemCheckEdit.Name = "is_reload_itemCheckEdit";
            this.is_reload_itemCheckEdit.Properties.Caption = "checkEdit1";
            this.is_reload_itemCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.is_reload_itemCheckEdit.TabIndex = 15;
            // 
            // FrmConfigRunCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConfigRunCrawler";
            this.Text = "FrmConfigRunCrawler";
            this.Load += new System.EventHandler(this.FrmConfigRunCrawler_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerSaleNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_run_crawlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_run_crawlerBindingNavigator)).EndInit();
            this.config_run_crawlerBindingNavigator.ResumeLayout(false);
            this.config_run_crawlerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config_run_crawlerGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_threadSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_sleep_recrawlerSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_crawlerSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_find_newCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_reload_itemCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CrawlerSaleNew crawlerSaleNew;
        private System.Windows.Forms.BindingSource config_run_crawlerBindingSource;
        private CrawlerSaleNewTableAdapters.config_run_crawlerTableAdapter config_run_crawlerTableAdapter;
        private CrawlerSaleNewTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator config_run_crawlerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton config_run_crawlerBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl config_run_crawlerGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colconfig_id;
        private DevExpress.XtraGrid.Columns.GridColumn colrootlink;
        private DevExpress.XtraGrid.Columns.GridColumn colnumber_thread;
        private DevExpress.XtraGrid.Columns.GridColumn colsecond_sleep_recrawler;
        private DevExpress.XtraGrid.Columns.GridColumn coltype_crawler;
        private DevExpress.XtraGrid.Columns.GridColumn colis_find_new;
        private DevExpress.XtraGrid.Columns.GridColumn colis_reload_item;
        private DevExpress.XtraEditors.SpinEdit idSpinEdit;
        private DevExpress.XtraEditors.SpinEdit config_idSpinEdit;
        private System.Windows.Forms.TextBox rootlinkTextBox;
        private DevExpress.XtraEditors.SpinEdit number_threadSpinEdit;
        private DevExpress.XtraEditors.SpinEdit second_sleep_recrawlerSpinEdit;
        private DevExpress.XtraEditors.SpinEdit type_crawlerSpinEdit;
        private DevExpress.XtraEditors.CheckEdit is_find_newCheckEdit;
        private DevExpress.XtraEditors.CheckEdit is_reload_itemCheckEdit;

    }
}