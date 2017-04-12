namespace QT.Moduls.Maps
{
    partial class frmAddRouterRootID
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
            System.Windows.Forms.Label rootIDLabel;
            System.Windows.Forms.Label mappingRootIDLabel;
            this.rootIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.routerRootProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBPMan = new QT.Moduls.Maps.DBPMan();
            this.mappingRootIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.routerRootProductTableAdapter = new QT.Moduls.Maps.DBPManTableAdapters.RouterRootProductTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Maps.DBPManTableAdapters.TableAdapterManager();
            rootIDLabel = new System.Windows.Forms.Label();
            mappingRootIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rootIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routerRootProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mappingRootIDTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rootIDLabel
            // 
            rootIDLabel.AutoSize = true;
            rootIDLabel.Location = new System.Drawing.Point(24, 15);
            rootIDLabel.Name = "rootIDLabel";
            rootIDLabel.Size = new System.Drawing.Size(96, 13);
            rootIDLabel.TabIndex = 0;
            rootIDLabel.Text = "ID SP Gốc bị trùng";
            // 
            // mappingRootIDLabel
            // 
            mappingRootIDLabel.AutoSize = true;
            mappingRootIDLabel.Location = new System.Drawing.Point(24, 56);
            mappingRootIDLabel.Name = "mappingRootIDLabel";
            mappingRootIDLabel.Size = new System.Drawing.Size(119, 13);
            mappingRootIDLabel.TabIndex = 2;
            mappingRootIDLabel.Text = "ID SP Gốc đc map đến";
            // 
            // rootIDTextEdit
            // 
            this.rootIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.routerRootProductBindingSource, "RootID", true));
            this.rootIDTextEdit.Location = new System.Drawing.Point(160, 12);
            this.rootIDTextEdit.Name = "rootIDTextEdit";
            this.rootIDTextEdit.Properties.ReadOnly = true;
            this.rootIDTextEdit.Size = new System.Drawing.Size(233, 20);
            this.rootIDTextEdit.TabIndex = 1;
            // 
            // routerRootProductBindingSource
            // 
            this.routerRootProductBindingSource.DataMember = "RouterRootProduct";
            this.routerRootProductBindingSource.DataSource = this.dBPMan;
            // 
            // dBPMan
            // 
            this.dBPMan.DataSetName = "DBPMan";
            this.dBPMan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mappingRootIDTextEdit
            // 
            this.mappingRootIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.routerRootProductBindingSource, "MappingRootID", true));
            this.mappingRootIDTextEdit.Location = new System.Drawing.Point(160, 53);
            this.mappingRootIDTextEdit.Name = "mappingRootIDTextEdit";
            this.mappingRootIDTextEdit.Size = new System.Drawing.Size(233, 20);
            this.mappingRootIDTextEdit.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(139, 106);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(234, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // routerRootProductTableAdapter
            // 
            this.routerRootProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.NewsTableAdapter = null;
            this.tableAdapterManager.Product_KeyComparisonTableAdapter = null;
            this.tableAdapterManager.Product_PropertiesTableAdapter = null;
            this.tableAdapterManager.ProductAnanyticTableAdapter = null;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductStatusTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RouterRootProductTableAdapter = this.routerRootProductTableAdapter;
            this.tableAdapterManager.Tag_CategoryTableAdapter = null;
            this.tableAdapterManager.Tag_ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Maps.DBPManTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmAddRouterRootID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 141);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(rootIDLabel);
            this.Controls.Add(this.rootIDTextEdit);
            this.Controls.Add(mappingRootIDLabel);
            this.Controls.Add(this.mappingRootIDTextEdit);
            this.Name = "frmAddRouterRootID";
            this.Text = "frmAddRouterRootID";
            this.Load += new System.EventHandler(this.frmAddRouterRootID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rootIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routerRootProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mappingRootIDTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBPMan dBPMan;
        private System.Windows.Forms.BindingSource routerRootProductBindingSource;
        private DBPManTableAdapters.RouterRootProductTableAdapter routerRootProductTableAdapter;
        private DBPManTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit rootIDTextEdit;
        private DevExpress.XtraEditors.TextEdit mappingRootIDTextEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}