namespace QT.Moduls.Maps
{
    partial class ctrTree
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label parentIDLabel;
            this.tlClassification = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNameUrl = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLevels = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colValid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsFocus = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSTTFocus = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPicture = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colListIDSearch = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource();
            this.dB = new QT.Moduls.DB();
            this.listClassificationTableAdapter = new QT.Moduls.DBTableAdapters.ListClassificationTableAdapter();
            this.btAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.btAddChild = new DevExpress.XtraEditors.SimpleButton();
            this.tableAdapterManager = new QT.Moduls.DBTableAdapters.TableAdapterManager();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.parentIDLabel1 = new System.Windows.Forms.Label();
            this.btMapIDSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btExpan = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ListIDSearchLabelControl = new DevExpress.XtraEditors.LabelControl();
            nameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            parentIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tlClassification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(295, 52);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Name:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(7, 52);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 13;
            iDLabel.Text = "ID:";
            // 
            // parentIDLabel
            // 
            parentIDLabel.AutoSize = true;
            parentIDLabel.Location = new System.Drawing.Point(118, 52);
            parentIDLabel.Name = "parentIDLabel";
            parentIDLabel.Size = new System.Drawing.Size(55, 13);
            parentIDLabel.TabIndex = 15;
            parentIDLabel.Text = "Parent ID:";
            // 
            // tlClassification
            // 
            this.tlClassification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlClassification.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colNameUrl,
            this.colLevels,
            this.colDescription,
            this.colValid,
            this.colIsFocus,
            this.colSTTFocus,
            this.colPicture,
            this.colListIDSearch});
            this.tlClassification.DataSource = this.listClassificationBindingSource;
            this.tlClassification.Location = new System.Drawing.Point(3, 68);
            this.tlClassification.Name = "tlClassification";
            this.tlClassification.OptionsBehavior.AutoChangeParent = false;
            this.tlClassification.OptionsBehavior.CanCloneNodesOnDrop = true;
            this.tlClassification.OptionsBehavior.CloseEditorOnLostFocus = false;
            this.tlClassification.OptionsBehavior.DragNodes = true;
            this.tlClassification.Size = new System.Drawing.Size(719, 443);
            this.tlClassification.TabIndex = 0;
            this.tlClassification.AfterDragNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tlClassification_AfterDragNode);
            this.tlClassification.DragDrop += new System.Windows.Forms.DragEventHandler(this.tlClassification_DragDrop);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 272;
            // 
            // colNameUrl
            // 
            this.colNameUrl.FieldName = "NameUrl";
            this.colNameUrl.Name = "colNameUrl";
            this.colNameUrl.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.colNameUrl.Visible = true;
            this.colNameUrl.VisibleIndex = 4;
            this.colNameUrl.Width = 67;
            // 
            // colLevels
            // 
            this.colLevels.FieldName = "Levels";
            this.colLevels.Name = "colLevels";
            this.colLevels.OptionsColumn.FixedWidth = true;
            this.colLevels.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.colLevels.Visible = true;
            this.colLevels.VisibleIndex = 5;
            this.colLevels.Width = 68;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 90;
            // 
            // colValid
            // 
            this.colValid.FieldName = "Valid";
            this.colValid.Name = "colValid";
            this.colValid.OptionsColumn.FixedWidth = true;
            this.colValid.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.colValid.Visible = true;
            this.colValid.VisibleIndex = 2;
            this.colValid.Width = 68;
            // 
            // colIsFocus
            // 
            this.colIsFocus.Caption = "Tiêu điểm";
            this.colIsFocus.FieldName = "IsFocus";
            this.colIsFocus.Name = "colIsFocus";
            this.colIsFocus.OptionsColumn.FixedWidth = true;
            this.colIsFocus.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.colIsFocus.Visible = true;
            this.colIsFocus.VisibleIndex = 6;
            this.colIsFocus.Width = 60;
            // 
            // colSTTFocus
            // 
            this.colSTTFocus.Caption = "STT Tiêu điểm";
            this.colSTTFocus.FieldName = "STTFocus";
            this.colSTTFocus.Name = "colSTTFocus";
            this.colSTTFocus.OptionsColumn.FixedWidth = true;
            this.colSTTFocus.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.colSTTFocus.Visible = true;
            this.colSTTFocus.VisibleIndex = 7;
            this.colSTTFocus.Width = 73;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Object;
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 1;
            // 
            // colListIDSearch
            // 
            this.colListIDSearch.Caption = "ListIDSearch";
            this.colListIDSearch.Name = "colListIDSearch";
            this.colListIDSearch.Visible = true;
            this.colListIDSearch.VisibleIndex = 8;
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.EnforceConstraints = false;
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(180, 26);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "New Root";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(426, 26);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Delete";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(99, 26);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(342, 26);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btAddChild
            // 
            this.btAddChild.Location = new System.Drawing.Point(261, 26);
            this.btAddChild.Name = "btAddChild";
            this.btAddChild.Size = new System.Drawing.Size(75, 23);
            this.btAddChild.TabIndex = 1;
            this.btAddChild.Text = "New Child";
            this.btAddChild.Click += new System.EventHandler(this.btAddChild_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.ConfigurationTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = this.listClassificationTableAdapter;
            this.tableAdapterManager.MapClassificationTableAdapter = null;
            this.tableAdapterManager.ProductID_PropertyTableAdapter = null;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PropertyGroupTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(339, 52);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(35, 13);
            this.nameLabel1.TabIndex = 13;
            this.nameLabel1.Text = "label2";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "CHUYÊN MỤC HỆ THỐNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iDLabel1
            // 
            this.iDLabel1.AutoSize = true;
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(34, 52);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(35, 13);
            this.iDLabel1.TabIndex = 14;
            this.iDLabel1.Text = "label2";
            // 
            // parentIDLabel1
            // 
            this.parentIDLabel1.AutoSize = true;
            this.parentIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "ParentID", true));
            this.parentIDLabel1.Location = new System.Drawing.Point(179, 52);
            this.parentIDLabel1.Name = "parentIDLabel1";
            this.parentIDLabel1.Size = new System.Drawing.Size(35, 13);
            this.parentIDLabel1.TabIndex = 16;
            this.parentIDLabel1.Text = "label2";
            // 
            // btMapIDSearch
            // 
            this.btMapIDSearch.Location = new System.Drawing.Point(521, 26);
            this.btMapIDSearch.Name = "btMapIDSearch";
            this.btMapIDSearch.Size = new System.Drawing.Size(98, 23);
            this.btMapIDSearch.TabIndex = 2;
            this.btMapIDSearch.Text = "Map IDSearch";
            this.btMapIDSearch.Click += new System.EventHandler(this.btMapIDSearch_Click);
            // 
            // btExpan
            // 
            this.btExpan.Location = new System.Drawing.Point(18, 26);
            this.btExpan.Name = "btExpan";
            this.btExpan.Size = new System.Drawing.Size(75, 23);
            this.btExpan.TabIndex = 3;
            this.btExpan.Text = "Expan";
            this.btExpan.Click += new System.EventHandler(this.btExpan_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(412, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "ListIDSearch";
            // 
            // ListIDSearchLabelControl
            // 
            this.ListIDSearchLabelControl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listClassificationBindingSource, "ListIDSearch", true));
            this.ListIDSearchLabelControl.Location = new System.Drawing.Point(478, 52);
            this.ListIDSearchLabelControl.Name = "ListIDSearchLabelControl";
            this.ListIDSearchLabelControl.Size = new System.Drawing.Size(12, 13);
            this.ListIDSearchLabelControl.TabIndex = 18;
            this.ListIDSearchLabelControl.Text = "...";
            // 
            // ctrTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListIDSearchLabelControl);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(parentIDLabel);
            this.Controls.Add(this.parentIDLabel1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDLabel1);
            this.Controls.Add(this.tlClassification);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btExpan);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btMapIDSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddChild);
            this.Controls.Add(this.btAdd);
            this.Name = "ctrTree";
            this.Size = new System.Drawing.Size(725, 514);
            ((System.ComponentModel.ISupportInitialize)(this.tlClassification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlClassification;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLevels;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DB dB;
        private DBTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btAdd;
        private DevExpress.XtraEditors.SimpleButton btDelete;
        private DevExpress.XtraEditors.SimpleButton btRefresh;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.SimpleButton btAddChild;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.Label parentIDLabel1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colValid;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNameUrl;
        private DevExpress.XtraEditors.SimpleButton btMapIDSearch;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsFocus;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSTTFocus;
        private DevExpress.XtraEditors.SimpleButton btExpan;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPicture;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colListIDSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl ListIDSearchLabelControl;
    }
}
