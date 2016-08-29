namespace QT.Moduls.Maps
{
    partial class ctrTreeCompany
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrTreeCompany));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btBuildTree = new DevExpress.XtraEditors.SimpleButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dB = new QT.Moduls.DB();
            this.treeClassificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIDFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.classificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classificationTableAdapter = new QT.Moduls.DBTableAdapters.ClassificationTableAdapter();
            this.tableAdapterManager = new QT.Moduls.DBTableAdapters.TableAdapterManager();
            this.lamess = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddNote = new DevExpress.XtraEditors.SimpleButton();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.btAddRoot = new DevExpress.XtraEditors.SimpleButton();
            this.btAddNoteCate = new DevExpress.XtraEditors.SimpleButton();
            this.btAddRootCat = new DevExpress.XtraEditors.SimpleButton();
            this.iDClassificationLabel1 = new System.Windows.Forms.Label();
            this.txtLevel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkDaMap = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDaMap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btBuildTree
            // 
            this.btBuildTree.ImageList = this.imageList1;
            this.btBuildTree.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btBuildTree.Location = new System.Drawing.Point(186, 23);
            this.btBuildTree.Name = "btBuildTree";
            this.btBuildTree.Size = new System.Drawing.Size(37, 23);
            this.btBuildTree.TabIndex = 1;
            this.btBuildTree.Text = "Load";
            this.btBuildTree.Click += new System.EventHandler(this.btBuildTree_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Refresh.png");
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.EnforceConstraints = false;
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treeClassificationBindingSource
            // 
            this.treeClassificationBindingSource.DataMember = "TreeClassification";
            this.treeClassificationBindingSource.DataSource = this.dB;
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colFullName,
            this.colIDFullName});
            this.treeList1.DataSource = this.treeClassificationBindingSource;
            this.treeList1.Location = new System.Drawing.Point(3, 81);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(424, 461);
            this.treeList1.TabIndex = 2;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 123;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.colFullName.Width = 123;
            // 
            // colIDFullName
            // 
            this.colIDFullName.FieldName = "IDFullName";
            this.colIDFullName.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIDFullName.Name = "colIDFullName";
            this.colIDFullName.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.colIDFullName.Width = 123;
            // 
            // classificationBindingSource
            // 
            this.classificationBindingSource.DataMember = "Classification";
            this.classificationBindingSource.DataSource = this.dB;
            // 
            // classificationTableAdapter
            // 
            this.classificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = this.classificationTableAdapter;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.MapClassificationTableAdapter = null;
            this.tableAdapterManager.ProductID_PropertyTableAdapter = null;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PropertyGroupTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lamess
            // 
            this.lamess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lamess.Location = new System.Drawing.Point(205, 3);
            this.lamess.Name = "lamess";
            this.lamess.Size = new System.Drawing.Size(222, 20);
            this.lamess.TabIndex = 10;
            this.lamess.Text = "-";
            this.lamess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chuyên mục các công ty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btAddNote
            // 
            this.btAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddNote.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btAddNote.Location = new System.Drawing.Point(361, 23);
            this.btAddNote.Name = "btAddNote";
            this.btAddNote.Size = new System.Drawing.Size(66, 23);
            this.btAddNote.TabIndex = 1;
            this.btAddNote.Text = "Add Node";
            this.btAddNote.Click += new System.EventHandler(this.btAddNote_Click);
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treeClassificationBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(229, 23);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(54, 23);
            this.nameLabel1.TabIndex = 12;
            this.nameLabel1.Text = "label2";
            this.nameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btAddRoot
            // 
            this.btAddRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddRoot.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btAddRoot.Location = new System.Drawing.Point(289, 23);
            this.btAddRoot.Name = "btAddRoot";
            this.btAddRoot.Size = new System.Drawing.Size(66, 23);
            this.btAddRoot.TabIndex = 1;
            this.btAddRoot.Text = "Add Root";
            this.btAddRoot.Click += new System.EventHandler(this.btAddRoot_Click);
            // 
            // btAddNoteCate
            // 
            this.btAddNoteCate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddNoteCate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btAddNoteCate.Location = new System.Drawing.Point(308, 52);
            this.btAddNoteCate.Name = "btAddNoteCate";
            this.btAddNoteCate.Size = new System.Drawing.Size(119, 23);
            this.btAddNoteCate.TabIndex = 1;
            this.btAddNoteCate.Text = "Add Node Category";
            this.btAddNoteCate.Click += new System.EventHandler(this.btAddNoteCate_Click);
            // 
            // btAddRootCat
            // 
            this.btAddRootCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddRootCat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btAddRootCat.Location = new System.Drawing.Point(155, 52);
            this.btAddRootCat.Name = "btAddRootCat";
            this.btAddRootCat.Size = new System.Drawing.Size(147, 23);
            this.btAddRootCat.TabIndex = 1;
            this.btAddRootCat.Text = "Add Root-->Child Category";
            this.btAddRootCat.Click += new System.EventHandler(this.btAddRootCat_Click);
            // 
            // iDClassificationLabel1
            // 
            this.iDClassificationLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iDClassificationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treeClassificationBindingSource, "IDClassification", true));
            this.iDClassificationLabel1.Location = new System.Drawing.Point(3, 60);
            this.iDClassificationLabel1.Name = "iDClassificationLabel1";
            this.iDClassificationLabel1.Size = new System.Drawing.Size(146, 15);
            this.iDClassificationLabel1.TabIndex = 13;
            this.iDClassificationLabel1.Text = "label2";
            this.iDClassificationLabel1.TextChanged += new System.EventHandler(this.iDClassificationLabel1_TextChanged);
            // 
            // txtLevel
            // 
            this.txtLevel.EditValue = "6";
            this.txtLevel.Location = new System.Drawing.Point(151, 26);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(29, 20);
            this.txtLevel.TabIndex = 23;
            this.txtLevel.EditValueChanged += new System.EventHandler(this.txtLevel_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(112, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Số cấp";
            // 
            // chkDaMap
            // 
            this.chkDaMap.Location = new System.Drawing.Point(135, 2);
            this.chkDaMap.Name = "chkDaMap";
            this.chkDaMap.Properties.Caption = "Đã map";
            this.chkDaMap.Size = new System.Drawing.Size(64, 19);
            this.chkDaMap.TabIndex = 24;
            // 
            // ctrTreeCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lamess);
            this.Controls.Add(this.chkDaMap);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.iDClassificationLabel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddRootCat);
            this.Controls.Add(this.btAddNoteCate);
            this.Controls.Add(this.btAddRoot);
            this.Controls.Add(this.btAddNote);
            this.Controls.Add(this.btBuildTree);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.treeList1);
            this.Name = "ctrTreeCompany";
            this.Size = new System.Drawing.Size(430, 545);
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDaMap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btBuildTree;
        private DB dB;
        private System.Windows.Forms.BindingSource treeClassificationBindingSource;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.Windows.Forms.BindingSource classificationBindingSource;
        private DBTableAdapters.ClassificationTableAdapter classificationTableAdapter;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lamess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton btAddNote;
        private System.Windows.Forms.Label nameLabel1;
        private DevExpress.XtraEditors.SimpleButton btAddRoot;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFullName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIDFullName;
        private DevExpress.XtraEditors.SimpleButton btAddNoteCate;
        private DevExpress.XtraEditors.SimpleButton btAddRootCat;
        private System.Windows.Forms.Label iDClassificationLabel1;
        private DevExpress.XtraEditors.TextEdit txtLevel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkDaMap;
    }
}
