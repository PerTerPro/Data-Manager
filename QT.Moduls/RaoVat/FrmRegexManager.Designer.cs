namespace QT.Moduls.RaoVat
{
    partial class FrmRegexManager
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
            System.Windows.Forms.Label regexLabel;
            System.Windows.Forms.Label nameLabel;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegexManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.regexCityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBRegex = new QT.Moduls.RaoVat.DBRegex();
            this.regexTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.regexCityGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.regexCityTableAdapter = new QT.Moduls.RaoVat.DBRegexTableAdapters.RegexCityTableAdapter();
            this.tableAdapterManager = new QT.Moduls.RaoVat.DBRegexTableAdapters.TableAdapterManager();
            this.regexCityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.regexCityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            regexLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexCityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBRegex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regexCityGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexCityBindingNavigator)).BeginInit();
            this.regexCityBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(18, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // regexLabel
            // 
            regexLabel.AutoSize = true;
            regexLabel.Location = new System.Drawing.Point(212, 15);
            regexLabel.Name = "regexLabel";
            regexLabel.Size = new System.Drawing.Size(41, 13);
            regexLabel.TabIndex = 2;
            regexLabel.Text = "Regex:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(395, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idSpinEdit);
            this.panel1.Controls.Add(regexLabel);
            this.panel1.Controls.Add(this.regexTextEdit);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 46);
            this.panel1.TabIndex = 0;
            // 
            // idSpinEdit
            // 
            this.idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.regexCityBindingSource, "Id", true));
            this.idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idSpinEdit.Enabled = false;
            this.idSpinEdit.Location = new System.Drawing.Point(65, 12);
            this.idSpinEdit.Name = "idSpinEdit";
            this.idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.idSpinEdit.TabIndex = 1;
            // 
            // regexCityBindingSource
            // 
            this.regexCityBindingSource.DataMember = "RegexCity";
            this.regexCityBindingSource.DataSource = this.dBRegex;
            // 
            // dBRegex
            // 
            this.dBRegex.DataSetName = "DBRegex";
            this.dBRegex.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regexTextEdit
            // 
            this.regexTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.regexCityBindingSource, "Regex", true));
            this.regexTextEdit.Location = new System.Drawing.Point(259, 12);
            this.regexTextEdit.Name = "regexTextEdit";
            this.regexTextEdit.Size = new System.Drawing.Size(100, 20);
            this.regexTextEdit.TabIndex = 3;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.regexCityBindingSource, "Name", true));
            this.nameTextEdit.Enabled = false;
            this.nameTextEdit.Location = new System.Drawing.Point(442, 12);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.nameTextEdit.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.regexCityGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 445);
            this.panel2.TabIndex = 1;
            // 
            // regexCityGridControl
            // 
            this.regexCityGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.regexCityGridControl.DataSource = this.regexCityBindingSource;
            this.regexCityGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.regexCityGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.regexCityGridControl.Location = new System.Drawing.Point(0, 0);
            this.regexCityGridControl.MainView = this.gridView1;
            this.regexCityGridControl.Name = "regexCityGridControl";
            this.regexCityGridControl.Size = new System.Drawing.Size(1035, 445);
            this.regexCityGridControl.TabIndex = 0;
            this.regexCityGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colRegex,
            this.colName});
            this.gridView1.GridControl = this.regexCityGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colRegex
            // 
            this.colRegex.FieldName = "Regex";
            this.colRegex.Name = "colRegex";
            this.colRegex.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRegex.Visible = true;
            this.colRegex.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // regexCityTableAdapter
            // 
            this.regexCityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RegexCityTableAdapter = this.regexCityTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.RaoVat.DBRegexTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // regexCityBindingNavigator
            // 
            this.regexCityBindingNavigator.AddNewItem = null;
            this.regexCityBindingNavigator.BindingSource = this.regexCityBindingSource;
            this.regexCityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.regexCityBindingNavigator.DeleteItem = null;
            this.regexCityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.regexCityBindingNavigatorSaveItem});
            this.regexCityBindingNavigator.Location = new System.Drawing.Point(0, 46);
            this.regexCityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.regexCityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.regexCityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.regexCityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.regexCityBindingNavigator.Name = "regexCityBindingNavigator";
            this.regexCityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.regexCityBindingNavigator.Size = new System.Drawing.Size(1035, 25);
            this.regexCityBindingNavigator.TabIndex = 2;
            this.regexCityBindingNavigator.Text = "bindingNavigator1";
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
            // regexCityBindingNavigatorSaveItem
            // 
            this.regexCityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.regexCityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("regexCityBindingNavigatorSaveItem.Image")));
            this.regexCityBindingNavigatorSaveItem.Name = "regexCityBindingNavigatorSaveItem";
            this.regexCityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.regexCityBindingNavigatorSaveItem.Text = "Save Data";
            this.regexCityBindingNavigatorSaveItem.Click += new System.EventHandler(this.regexCityBindingNavigatorSaveItem_Click);
            // 
            // FrmRegexManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 491);
            this.Controls.Add(this.regexCityBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRegexManager";
            this.Text = "FrmRegexManager";
            this.Load += new System.EventHandler(this.FrmRegexManager_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRegexManager_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexCityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBRegex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.regexCityGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexCityBindingNavigator)).EndInit();
            this.regexCityBindingNavigator.ResumeLayout(false);
            this.regexCityBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DBRegex dBRegex;
        private System.Windows.Forms.BindingSource regexCityBindingSource;
        private DBRegexTableAdapters.RegexCityTableAdapter regexCityTableAdapter;
        private DBRegexTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator regexCityBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton regexCityBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SpinEdit idSpinEdit;
        private DevExpress.XtraEditors.TextEdit regexTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraGrid.GridControl regexCityGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colRegex;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
    }
}