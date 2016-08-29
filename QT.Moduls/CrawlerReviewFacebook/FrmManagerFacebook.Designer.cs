//using AnalysicInfoFacbook;
namespace QT.Moduls.CrawlerReviewFacebook
{
    partial class FrmManagerFacebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagerFacebook));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label lastAnalysicLabel;
            System.Windows.Forms.Label numberCommentLabel;
            System.Windows.Forms.Label domainLabel;
            System.Windows.Forms.Label facebookLabel;
            System.Windows.Forms.Label errorWhenAnalysicLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dBAnalysInfo1 = new QT.Moduls.CrawlerReviewFacebook.DBAnalysInfo();
            this.analysicInfoFacbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analysicInfoFacbookTableAdapter = new QT.Moduls.CrawlerReviewFacebook.DBAnalysInfoTableAdapters.AnalysicInfoFacbookTableAdapter();
            this.tableAdapterManager = new QT.Moduls.CrawlerReviewFacebook.DBAnalysInfoTableAdapters.TableAdapterManager();
            this.analysicInfoFacbookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.analysicInfoFacbookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.analysicInfoFacbookGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastAnalysic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFacebook = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colErrorWhenAnalysic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.lastAnalysicDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.numberCommentSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.domainTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.facebookTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.errorWhenAnalysicTextEdit = new DevExpress.XtraEditors.TextEdit();
            idLabel = new System.Windows.Forms.Label();
            lastAnalysicLabel = new System.Windows.Forms.Label();
            numberCommentLabel = new System.Windows.Forms.Label();
            domainLabel = new System.Windows.Forms.Label();
            facebookLabel = new System.Windows.Forms.Label();
            errorWhenAnalysicLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBAnalysInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysicInfoFacbookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysicInfoFacbookBindingNavigator)).BeginInit();
            this.analysicInfoFacbookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analysicInfoFacbookGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastAnalysicDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastAnalysicDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberCommentSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWhenAnalysicTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 497);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(idLabel);
            this.panel2.Controls.Add(this.idSpinEdit);
            this.panel2.Controls.Add(lastAnalysicLabel);
            this.panel2.Controls.Add(this.lastAnalysicDateEdit);
            this.panel2.Controls.Add(numberCommentLabel);
            this.panel2.Controls.Add(this.numberCommentSpinEdit);
            this.panel2.Controls.Add(domainLabel);
            this.panel2.Controls.Add(this.domainTextEdit);
            this.panel2.Controls.Add(facebookLabel);
            this.panel2.Controls.Add(this.facebookTextEdit);
            this.panel2.Controls.Add(errorWhenAnalysicLabel);
            this.panel2.Controls.Add(this.errorWhenAnalysicTextEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.analysicInfoFacbookGridControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 397);
            this.panel3.TabIndex = 1;
            // 
            // dBAnalysInfo1
            // 
            this.dBAnalysInfo1.DataSetName = "DBAnalysInfo";
            this.dBAnalysInfo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // analysicInfoFacbookBindingSource
            // 
            this.analysicInfoFacbookBindingSource.DataMember = "AnalysicInfoFacbook";
            this.analysicInfoFacbookBindingSource.DataSource = this.dBAnalysInfo1;
            // 
            // analysicInfoFacbookTableAdapter
            // 
            this.analysicInfoFacbookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnalysicInfoFacbookTableAdapter = this.analysicInfoFacbookTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.CrawlerReviewFacebook.DBAnalysInfoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // analysicInfoFacbookBindingNavigator
            // 
            this.analysicInfoFacbookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.analysicInfoFacbookBindingNavigator.BindingSource = this.analysicInfoFacbookBindingSource;
            this.analysicInfoFacbookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.analysicInfoFacbookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.analysicInfoFacbookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.analysicInfoFacbookBindingNavigatorSaveItem});
            this.analysicInfoFacbookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.analysicInfoFacbookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.analysicInfoFacbookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.analysicInfoFacbookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.analysicInfoFacbookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.analysicInfoFacbookBindingNavigator.Name = "analysicInfoFacbookBindingNavigator";
            this.analysicInfoFacbookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.analysicInfoFacbookBindingNavigator.Size = new System.Drawing.Size(914, 25);
            this.analysicInfoFacbookBindingNavigator.TabIndex = 1;
            this.analysicInfoFacbookBindingNavigator.Text = "bindingNavigator1";
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
            // analysicInfoFacbookBindingNavigatorSaveItem
            // 
            this.analysicInfoFacbookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.analysicInfoFacbookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("analysicInfoFacbookBindingNavigatorSaveItem.Image")));
            this.analysicInfoFacbookBindingNavigatorSaveItem.Name = "analysicInfoFacbookBindingNavigatorSaveItem";
            this.analysicInfoFacbookBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.analysicInfoFacbookBindingNavigatorSaveItem.Text = "Save Data";
            this.analysicInfoFacbookBindingNavigatorSaveItem.Click += new System.EventHandler(this.analysicInfoFacbookBindingNavigatorSaveItem_Click);
            // 
            // analysicInfoFacbookGridControl
            // 
            this.analysicInfoFacbookGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.analysicInfoFacbookGridControl.DataSource = this.analysicInfoFacbookBindingSource;
            this.analysicInfoFacbookGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analysicInfoFacbookGridControl.Location = new System.Drawing.Point(0, 0);
            this.analysicInfoFacbookGridControl.MainView = this.gridView1;
            this.analysicInfoFacbookGridControl.Name = "analysicInfoFacbookGridControl";
            this.analysicInfoFacbookGridControl.Size = new System.Drawing.Size(914, 397);
            this.analysicInfoFacbookGridControl.TabIndex = 0;
            this.analysicInfoFacbookGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colLastAnalysic,
            this.colNumberComment,
            this.colDomain,
            this.colFacebook,
            this.colErrorWhenAnalysic});
            this.gridView1.GridControl = this.analysicInfoFacbookGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colLastAnalysic
            // 
            this.colLastAnalysic.FieldName = "LastAnalysic";
            this.colLastAnalysic.Name = "colLastAnalysic";
            this.colLastAnalysic.Visible = true;
            this.colLastAnalysic.VisibleIndex = 1;
            // 
            // colNumberComment
            // 
            this.colNumberComment.FieldName = "NumberComment";
            this.colNumberComment.Name = "colNumberComment";
            this.colNumberComment.Visible = true;
            this.colNumberComment.VisibleIndex = 2;
            // 
            // colDomain
            // 
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 3;
            // 
            // colFacebook
            // 
            this.colFacebook.FieldName = "Facebook";
            this.colFacebook.Name = "colFacebook";
            this.colFacebook.Visible = true;
            this.colFacebook.VisibleIndex = 4;
            // 
            // colErrorWhenAnalysic
            // 
            this.colErrorWhenAnalysic.FieldName = "ErrorWhenAnalysic";
            this.colErrorWhenAnalysic.Name = "colErrorWhenAnalysic";
            this.colErrorWhenAnalysic.Visible = true;
            this.colErrorWhenAnalysic.VisibleIndex = 5;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(20, 40);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idSpinEdit
            // 
            this.idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.analysicInfoFacbookBindingSource, "Id", true));
            this.idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idSpinEdit.Location = new System.Drawing.Point(132, 37);
            this.idSpinEdit.Name = "idSpinEdit";
            this.idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.idSpinEdit.TabIndex = 1;
            // 
            // lastAnalysicLabel
            // 
            lastAnalysicLabel.AutoSize = true;
            lastAnalysicLabel.Location = new System.Drawing.Point(20, 66);
            lastAnalysicLabel.Name = "lastAnalysicLabel";
            lastAnalysicLabel.Size = new System.Drawing.Size(72, 13);
            lastAnalysicLabel.TabIndex = 2;
            lastAnalysicLabel.Text = "Last Analysic:";
            // 
            // lastAnalysicDateEdit
            // 
            this.lastAnalysicDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.analysicInfoFacbookBindingSource, "LastAnalysic", true));
            this.lastAnalysicDateEdit.EditValue = null;
            this.lastAnalysicDateEdit.Location = new System.Drawing.Point(132, 63);
            this.lastAnalysicDateEdit.Name = "lastAnalysicDateEdit";
            this.lastAnalysicDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lastAnalysicDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lastAnalysicDateEdit.Size = new System.Drawing.Size(100, 20);
            this.lastAnalysicDateEdit.TabIndex = 3;
            // 
            // numberCommentLabel
            // 
            numberCommentLabel.AutoSize = true;
            numberCommentLabel.Location = new System.Drawing.Point(291, 40);
            numberCommentLabel.Name = "numberCommentLabel";
            numberCommentLabel.Size = new System.Drawing.Size(94, 13);
            numberCommentLabel.TabIndex = 4;
            numberCommentLabel.Text = "Number Comment:";
            // 
            // numberCommentSpinEdit
            // 
            this.numberCommentSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.analysicInfoFacbookBindingSource, "NumberComment", true));
            this.numberCommentSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numberCommentSpinEdit.Location = new System.Drawing.Point(403, 37);
            this.numberCommentSpinEdit.Name = "numberCommentSpinEdit";
            this.numberCommentSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numberCommentSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.numberCommentSpinEdit.TabIndex = 5;
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.Location = new System.Drawing.Point(291, 66);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(46, 13);
            domainLabel.TabIndex = 6;
            domainLabel.Text = "Domain:";
            // 
            // domainTextEdit
            // 
            this.domainTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.analysicInfoFacbookBindingSource, "Domain", true));
            this.domainTextEdit.Location = new System.Drawing.Point(403, 63);
            this.domainTextEdit.Name = "domainTextEdit";
            this.domainTextEdit.Size = new System.Drawing.Size(100, 20);
            this.domainTextEdit.TabIndex = 7;
            // 
            // facebookLabel
            // 
            facebookLabel.AutoSize = true;
            facebookLabel.Location = new System.Drawing.Point(556, 40);
            facebookLabel.Name = "facebookLabel";
            facebookLabel.Size = new System.Drawing.Size(58, 13);
            facebookLabel.TabIndex = 8;
            facebookLabel.Text = "Facebook:";
            // 
            // facebookTextEdit
            // 
            this.facebookTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.analysicInfoFacbookBindingSource, "Facebook", true));
            this.facebookTextEdit.Location = new System.Drawing.Point(668, 37);
            this.facebookTextEdit.Name = "facebookTextEdit";
            this.facebookTextEdit.Size = new System.Drawing.Size(100, 20);
            this.facebookTextEdit.TabIndex = 9;
            // 
            // errorWhenAnalysicLabel
            // 
            errorWhenAnalysicLabel.AutoSize = true;
            errorWhenAnalysicLabel.Location = new System.Drawing.Point(556, 66);
            errorWhenAnalysicLabel.Name = "errorWhenAnalysicLabel";
            errorWhenAnalysicLabel.Size = new System.Drawing.Size(106, 13);
            errorWhenAnalysicLabel.TabIndex = 10;
            errorWhenAnalysicLabel.Text = "Error When Analysic:";
            // 
            // errorWhenAnalysicTextEdit
            // 
            this.errorWhenAnalysicTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.analysicInfoFacbookBindingSource, "ErrorWhenAnalysic", true));
            this.errorWhenAnalysicTextEdit.Location = new System.Drawing.Point(668, 63);
            this.errorWhenAnalysicTextEdit.Name = "errorWhenAnalysicTextEdit";
            this.errorWhenAnalysicTextEdit.Size = new System.Drawing.Size(100, 20);
            this.errorWhenAnalysicTextEdit.TabIndex = 11;
            // 
            // FrmManagerFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 497);
            this.Controls.Add(this.analysicInfoFacbookBindingNavigator);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmManagerFacebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBAnalysInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysicInfoFacbookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analysicInfoFacbookBindingNavigator)).EndInit();
            this.analysicInfoFacbookBindingNavigator.ResumeLayout(false);
            this.analysicInfoFacbookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analysicInfoFacbookGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastAnalysicDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastAnalysicDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberCommentSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWhenAnalysicTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBAnalysInfo dBAnalysInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DBAnalysInfo dBAnalysInfo1;
        private System.Windows.Forms.BindingSource analysicInfoFacbookBindingSource;
        private DBAnalysInfoTableAdapters.AnalysicInfoFacbookTableAdapter analysicInfoFacbookTableAdapter;
        private DBAnalysInfoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator analysicInfoFacbookBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton analysicInfoFacbookBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl analysicInfoFacbookGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colLastAnalysic;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberComment;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private DevExpress.XtraGrid.Columns.GridColumn colFacebook;
        private DevExpress.XtraGrid.Columns.GridColumn colErrorWhenAnalysic;
        private DevExpress.XtraEditors.SpinEdit idSpinEdit;
        private DevExpress.XtraEditors.DateEdit lastAnalysicDateEdit;
        private DevExpress.XtraEditors.SpinEdit numberCommentSpinEdit;
        private DevExpress.XtraEditors.TextEdit domainTextEdit;
        private DevExpress.XtraEditors.TextEdit facebookTextEdit;
        private DevExpress.XtraEditors.TextEdit errorWhenAnalysicTextEdit;
        //private AnalysicInfoFacbook.DBAnalysInfoTableAdapters.AnalysicInfoFacbookTableAdapter analysicInfoFacbookTableAdapter;
        //private AnalysicInfoFacbook.DBAnalysInfoTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

