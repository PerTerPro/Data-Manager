namespace QT.Moduls.Maps
{
    partial class ctrListMapCategory
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
            System.Windows.Forms.Label iDClassificationLabel;
            System.Windows.Forms.Label iDCategoryLabel;
            System.Windows.Forms.Label targetIDLabel;
            System.Windows.Forms.Label nameLabel;
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.mapClassificationBindingSource = new System.Windows.Forms.BindingSource();
            this.dB = new QT.Moduls.DB();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDClassification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mapClassificationTableAdapter = new QT.Moduls.DBTableAdapters.MapClassificationTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btBuildTree = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lamess = new System.Windows.Forms.Label();
            this.tableAdapterManager = new QT.Moduls.DBTableAdapters.TableAdapterManager();
            this.iDClassificationLabel1 = new System.Windows.Forms.Label();
            this.iDCategoryLabel1 = new System.Windows.Forms.Label();
            this.targetIDLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.btRemove = new DevExpress.XtraEditors.SimpleButton();
            iDClassificationLabel = new System.Windows.Forms.Label();
            iDCategoryLabel = new System.Windows.Forms.Label();
            targetIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDClassificationLabel
            // 
            iDClassificationLabel.AutoSize = true;
            iDClassificationLabel.Location = new System.Drawing.Point(69, 110);
            iDClassificationLabel.Name = "iDClassificationLabel";
            iDClassificationLabel.Size = new System.Drawing.Size(82, 13);
            iDClassificationLabel.TabIndex = 20;
            iDClassificationLabel.Text = "IDClassification:";
            // 
            // iDCategoryLabel
            // 
            iDCategoryLabel.AutoSize = true;
            iDCategoryLabel.Location = new System.Drawing.Point(88, 133);
            iDCategoryLabel.Name = "iDCategoryLabel";
            iDCategoryLabel.Size = new System.Drawing.Size(63, 13);
            iDCategoryLabel.TabIndex = 21;
            iDCategoryLabel.Text = "IDCategory:";
            // 
            // targetIDLabel
            // 
            targetIDLabel.AutoSize = true;
            targetIDLabel.Location = new System.Drawing.Point(96, 156);
            targetIDLabel.Name = "targetIDLabel";
            targetIDLabel.Size = new System.Drawing.Size(55, 13);
            targetIDLabel.TabIndex = 22;
            targetIDLabel.Text = "Target ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(113, 179);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.mapClassificationBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(496, 438);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // mapClassificationBindingSource
            // 
            this.mapClassificationBindingSource.DataMember = "MapClassification";
            this.mapClassificationBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.EnforceConstraints = false;
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colIDCategory,
            this.colTargetID,
            this.colIDClassification});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 283;
            // 
            // colIDCategory
            // 
            this.colIDCategory.FieldName = "IDCategory";
            this.colIDCategory.Name = "colIDCategory";
            this.colIDCategory.Visible = true;
            this.colIDCategory.VisibleIndex = 1;
            this.colIDCategory.Width = 77;
            // 
            // colTargetID
            // 
            this.colTargetID.FieldName = "TargetID";
            this.colTargetID.Name = "colTargetID";
            this.colTargetID.Visible = true;
            this.colTargetID.VisibleIndex = 2;
            this.colTargetID.Width = 74;
            // 
            // colIDClassification
            // 
            this.colIDClassification.FieldName = "IDClassification";
            this.colIDClassification.Name = "colIDClassification";
            this.colIDClassification.Visible = true;
            this.colIDClassification.VisibleIndex = 3;
            this.colIDClassification.Width = 45;
            // 
            // mapClassificationTableAdapter
            // 
            this.mapClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btBuildTree
            // 
            this.btBuildTree.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btBuildTree.Location = new System.Drawing.Point(115, 24);
            this.btBuildTree.Name = "btBuildTree";
            this.btBuildTree.Size = new System.Drawing.Size(37, 23);
            this.btBuildTree.TabIndex = 3;
            this.btBuildTree.Text = "Load";
            this.btBuildTree.Click += new System.EventHandler(this.btBuildTree_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chuyên mục maping";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lamess
            // 
            this.lamess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lamess.Location = new System.Drawing.Point(144, 1);
            this.lamess.Name = "lamess";
            this.lamess.Size = new System.Drawing.Size(230, 20);
            this.lamess.TabIndex = 20;
            this.lamess.Text = "-";
            this.lamess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_StatusTableAdapter = null;

            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.MapClassificationTableAdapter = this.mapClassificationTableAdapter;
            this.tableAdapterManager.ProductID_PropertyTableAdapter = null;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PropertyGroupTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDClassificationLabel1
            // 
            this.iDClassificationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mapClassificationBindingSource, "IDClassification", true));
            this.iDClassificationLabel1.Location = new System.Drawing.Point(157, 110);
            this.iDClassificationLabel1.Name = "iDClassificationLabel1";
            this.iDClassificationLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDClassificationLabel1.TabIndex = 21;
            this.iDClassificationLabel1.Text = "label2";
            // 
            // iDCategoryLabel1
            // 
            this.iDCategoryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mapClassificationBindingSource, "IDCategory", true));
            this.iDCategoryLabel1.Location = new System.Drawing.Point(157, 133);
            this.iDCategoryLabel1.Name = "iDCategoryLabel1";
            this.iDCategoryLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDCategoryLabel1.TabIndex = 22;
            this.iDCategoryLabel1.Text = "label2";
            // 
            // targetIDLabel1
            // 
            this.targetIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mapClassificationBindingSource, "TargetID", true));
            this.targetIDLabel1.Location = new System.Drawing.Point(157, 156);
            this.targetIDLabel1.Name = "targetIDLabel1";
            this.targetIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.targetIDLabel1.TabIndex = 23;
            this.targetIDLabel1.Text = "label2";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mapClassificationBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(157, 179);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 24;
            this.nameLabel1.Text = "label2";
            // 
            // btSave
            // 
            this.btSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btSave.Location = new System.Drawing.Point(380, 24);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(116, 23);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btRemove
            // 
            this.btRemove.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btRemove.Location = new System.Drawing.Point(314, 24);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(60, 23);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Remove";
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // ctrListMapCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(targetIDLabel);
            this.Controls.Add(this.targetIDLabel1);
            this.Controls.Add(iDCategoryLabel);
            this.Controls.Add(this.iDCategoryLabel1);
            this.Controls.Add(iDClassificationLabel);
            this.Controls.Add(this.iDClassificationLabel1);
            this.Controls.Add(this.lamess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btBuildTree);
            this.Name = "ctrListMapCategory";
            this.Size = new System.Drawing.Size(502, 494);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource mapClassificationBindingSource;
        private DB dB;
        private DBTableAdapters.MapClassificationTableAdapter mapClassificationTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btBuildTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lamess;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label iDClassificationLabel1;
        private System.Windows.Forms.Label iDCategoryLabel1;
        private System.Windows.Forms.Label targetIDLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraGrid.Columns.GridColumn colIDClassification;
        private DevExpress.XtraEditors.SimpleButton btRemove;
    }
}
