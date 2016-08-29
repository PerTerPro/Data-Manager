namespace QT.Moduls.User
{
    partial class FrmUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserManager));
            System.Windows.Forms.Label userLabel;
            System.Windows.Forms.Label formLabel;
            System.Windows.Forms.Label functionsLabel;
            System.Windows.Forms.Label allowLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dBUser = new QT.Moduls.User.DBUser();
            this.permissionUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissionUserTableAdapter = new QT.Moduls.User.DBUserTableAdapters.PermissionUserTableAdapter();
            this.tableAdapterManager = new QT.Moduls.User.DBUserTableAdapters.TableAdapterManager();
            this.permissionUserBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.permissionUserBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.permissionUserGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coluser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colform = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfunctions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colallow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.formTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.functionsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.allowCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            userLabel = new System.Windows.Forms.Label();
            formLabel = new System.Windows.Forms.Label();
            functionsLabel = new System.Windows.Forms.Label();
            allowLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionUserBindingNavigator)).BeginInit();
            this.permissionUserBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionUserGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(userLabel);
            this.panel1.Controls.Add(this.userTextEdit);
            this.panel1.Controls.Add(formLabel);
            this.panel1.Controls.Add(this.formTextEdit);
            this.panel1.Controls.Add(functionsLabel);
            this.panel1.Controls.Add(this.functionsTextEdit);
            this.panel1.Controls.Add(allowLabel);
            this.panel1.Controls.Add(this.allowCheckEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 44);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.permissionUserGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 342);
            this.panel2.TabIndex = 1;
            // 
            // dBUser
            // 
            this.dBUser.DataSetName = "DBUser";
            this.dBUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // permissionUserBindingSource
            // 
            this.permissionUserBindingSource.DataMember = "PermissionUser";
            this.permissionUserBindingSource.DataSource = this.dBUser;
            // 
            // permissionUserTableAdapter
            // 
            this.permissionUserTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PermissionUserTableAdapter = this.permissionUserTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.User.DBUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // permissionUserBindingNavigator
            // 
            this.permissionUserBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.permissionUserBindingNavigator.BindingSource = this.permissionUserBindingSource;
            this.permissionUserBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.permissionUserBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.permissionUserBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.permissionUserBindingNavigatorSaveItem});
            this.permissionUserBindingNavigator.Location = new System.Drawing.Point(0, 44);
            this.permissionUserBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.permissionUserBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.permissionUserBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.permissionUserBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.permissionUserBindingNavigator.Name = "permissionUserBindingNavigator";
            this.permissionUserBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.permissionUserBindingNavigator.Size = new System.Drawing.Size(824, 25);
            this.permissionUserBindingNavigator.TabIndex = 2;
            this.permissionUserBindingNavigator.Text = "bindingNavigator1";
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
            // permissionUserBindingNavigatorSaveItem
            // 
            this.permissionUserBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.permissionUserBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("permissionUserBindingNavigatorSaveItem.Image")));
            this.permissionUserBindingNavigatorSaveItem.Name = "permissionUserBindingNavigatorSaveItem";
            this.permissionUserBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.permissionUserBindingNavigatorSaveItem.Text = "Save Data";
            this.permissionUserBindingNavigatorSaveItem.Click += new System.EventHandler(this.permissionUserBindingNavigatorSaveItem_Click);
            // 
            // permissionUserGridControl
            // 
            this.permissionUserGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.permissionUserGridControl.DataSource = this.permissionUserBindingSource;
            this.permissionUserGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.permissionUserGridControl.Location = new System.Drawing.Point(0, 0);
            this.permissionUserGridControl.MainView = this.gridView1;
            this.permissionUserGridControl.Name = "permissionUserGridControl";
            this.permissionUserGridControl.Size = new System.Drawing.Size(824, 342);
            this.permissionUserGridControl.TabIndex = 0;
            this.permissionUserGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluser,
            this.colform,
            this.colfunctions,
            this.colallow});
            this.gridView1.GridControl = this.permissionUserGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // coluser
            // 
            this.coluser.FieldName = "user";
            this.coluser.Name = "coluser";
            this.coluser.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.coluser.Visible = true;
            this.coluser.VisibleIndex = 0;
            // 
            // colform
            // 
            this.colform.FieldName = "form";
            this.colform.Name = "colform";
            this.colform.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colform.Visible = true;
            this.colform.VisibleIndex = 1;
            // 
            // colfunctions
            // 
            this.colfunctions.FieldName = "functions";
            this.colfunctions.Name = "colfunctions";
            this.colfunctions.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colfunctions.Visible = true;
            this.colfunctions.VisibleIndex = 2;
            // 
            // colallow
            // 
            this.colallow.FieldName = "allow";
            this.colallow.Name = "colallow";
            this.colallow.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colallow.Visible = true;
            this.colallow.VisibleIndex = 3;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new System.Drawing.Point(24, 15);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(30, 13);
            userLabel.TabIndex = 0;
            userLabel.Text = "user:";
            // 
            // userTextEdit
            // 
            this.userTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.permissionUserBindingSource, "user", true));
            this.userTextEdit.Location = new System.Drawing.Point(83, 12);
            this.userTextEdit.Name = "userTextEdit";
            this.userTextEdit.Size = new System.Drawing.Size(100, 20);
            this.userTextEdit.TabIndex = 1;
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.Location = new System.Drawing.Point(220, 15);
            formLabel.Name = "formLabel";
            formLabel.Size = new System.Drawing.Size(30, 13);
            formLabel.TabIndex = 2;
            formLabel.Text = "form:";
            // 
            // formTextEdit
            // 
            this.formTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.permissionUserBindingSource, "form", true));
            this.formTextEdit.Location = new System.Drawing.Point(279, 12);
            this.formTextEdit.Name = "formTextEdit";
            this.formTextEdit.Size = new System.Drawing.Size(100, 20);
            this.formTextEdit.TabIndex = 3;
            // 
            // functionsLabel
            // 
            functionsLabel.AutoSize = true;
            functionsLabel.Location = new System.Drawing.Point(421, 15);
            functionsLabel.Name = "functionsLabel";
            functionsLabel.Size = new System.Drawing.Size(53, 13);
            functionsLabel.TabIndex = 4;
            functionsLabel.Text = "functions:";
            // 
            // functionsTextEdit
            // 
            this.functionsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.permissionUserBindingSource, "functions", true));
            this.functionsTextEdit.Location = new System.Drawing.Point(480, 12);
            this.functionsTextEdit.Name = "functionsTextEdit";
            this.functionsTextEdit.Size = new System.Drawing.Size(100, 20);
            this.functionsTextEdit.TabIndex = 5;
            // 
            // allowLabel
            // 
            allowLabel.AutoSize = true;
            allowLabel.Location = new System.Drawing.Point(623, 15);
            allowLabel.Name = "allowLabel";
            allowLabel.Size = new System.Drawing.Size(34, 13);
            allowLabel.TabIndex = 6;
            allowLabel.Text = "allow:";
            // 
            // allowCheckEdit
            // 
            this.allowCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.permissionUserBindingSource, "allow", true));
            this.allowCheckEdit.Location = new System.Drawing.Point(682, 12);
            this.allowCheckEdit.Name = "allowCheckEdit";
            this.allowCheckEdit.Properties.Caption = "";
            this.allowCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.allowCheckEdit.TabIndex = 7;
            // 
            // FrmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 386);
            this.Controls.Add(this.permissionUserBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUserManager";
            this.Text = "FrmUserManager";
            this.Load += new System.EventHandler(this.FrmUserManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionUserBindingNavigator)).EndInit();
            this.permissionUserBindingNavigator.ResumeLayout(false);
            this.permissionUserBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionUserGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DBUser dBUser;
        private System.Windows.Forms.BindingSource permissionUserBindingSource;
        private DBUserTableAdapters.PermissionUserTableAdapter permissionUserTableAdapter;
        private DBUserTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator permissionUserBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton permissionUserBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.TextEdit userTextEdit;
        private DevExpress.XtraEditors.TextEdit formTextEdit;
        private DevExpress.XtraEditors.TextEdit functionsTextEdit;
        private DevExpress.XtraEditors.CheckEdit allowCheckEdit;
        private DevExpress.XtraGrid.GridControl permissionUserGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coluser;
        private DevExpress.XtraGrid.Columns.GridColumn colform;
        private DevExpress.XtraGrid.Columns.GridColumn colfunctions;
        private DevExpress.XtraGrid.Columns.GridColumn colallow;
    }
}