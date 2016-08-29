namespace QT.Moduls.Company
{
    partial class frmChonNhomQuanLy
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            this.dBCom = new QT.Moduls.Company.DBCom();
            this.managerTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.managerTypeTableAdapter = new QT.Moduls.Company.DBComTableAdapters.ManagerTypeTableAdapter();
            this.gridListCurrent = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btOK = new DevExpress.XtraEditors.SimpleButton();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tableAdapterManager = new QT.Moduls.Company.DBComTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Enabled = false;
            iDLabel.Location = new System.Drawing.Point(116, 263);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 499);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // dBCom
            // 
            this.dBCom.DataSetName = "DBCom";
            this.dBCom.EnforceConstraints = false;
            this.dBCom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerTypeBindingSource
            // 
            this.managerTypeBindingSource.DataMember = "ManagerType";
            this.managerTypeBindingSource.DataSource = this.dBCom;
            // 
            // managerTypeTableAdapter
            // 
            this.managerTypeTableAdapter.ClearBeforeFill = true;
            // 
            // gridListCurrent
            // 
            this.gridListCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListCurrent.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridListCurrent.DataSource = this.managerTypeBindingSource;
            this.gridListCurrent.Location = new System.Drawing.Point(3, 12);
            this.gridListCurrent.MainView = this.gridView2;
            this.gridListCurrent.Name = "gridListCurrent";
            this.gridListCurrent.Size = new System.Drawing.Size(471, 481);
            this.gridListCurrent.TabIndex = 1;
            this.gridListCurrent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colName,
            this.colDes});
            this.gridView2.GridControl = this.gridListCurrent;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.FixedWidth = true;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 56;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 341;
            // 
            // colDes
            // 
            this.colDes.FieldName = "Des";
            this.colDes.Name = "colDes";
            this.colDes.Visible = true;
            this.colDes.VisibleIndex = 2;
            this.colDes.Width = 241;
            // 
            // btOK
            // 
            this.btOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btOK.Location = new System.Drawing.Point(159, 499);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCancel.Location = new System.Drawing.Point(241, 499);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_AddressTableAdapter = null;
            this.tableAdapterManager.Company_ImageTableAdapter = null;
            this.tableAdapterManager.Company1TableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.DatafeedConfigTableAdapter = null;
            this.tableAdapterManager.HistoryDatafeedTableAdapter = null;
            this.tableAdapterManager.Job_WebsiteConfigLogTableAdapter = null;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.ManagerCompanyLogTableAdapter = null;
            this.tableAdapterManager.ManagerCompanyLogTypeTableAdapter = null;
            this.tableAdapterManager.ManagerCrawlerTableAdapter = null;
            this.tableAdapterManager.ManagerTypeRCompanyTableAdapter = null;
            this.tableAdapterManager.ManagerTypeTableAdapter = this.managerTypeTableAdapter;
            this.tableAdapterManager.ProductQuangCaoTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Company.DBComTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Location = new System.Drawing.Point(143, 260);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 4;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(53, 499);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 6;
            this.nameLabel1.Text = "label1";
            // 
            // frmChonNhomQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 528);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.gridListCurrent);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Name = "frmChonNhomQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn nhóm quản lý";
            this.Load += new System.EventHandler(this.frmChonNhomQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBCom dBCom;
        private System.Windows.Forms.BindingSource managerTypeBindingSource;
        private DBComTableAdapters.ManagerTypeTableAdapter managerTypeTableAdapter;
        private DevExpress.XtraGrid.GridControl gridListCurrent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDes;
        private DevExpress.XtraEditors.SimpleButton btOK;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DBComTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Label nameLabel1;
    }
}