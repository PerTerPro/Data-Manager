namespace QT.Moduls.Company
{
    partial class FrmEditCompanyRegion
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
            this.dataGridViewCompanyAddress = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanHuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.googleMapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyAddressBindingSource = new System.Windows.Forms.BindingSource();
            this.dBCom = new QT.Moduls.Company.DBCom();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.comboBoxProvin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyAddressTableAdapter = new QT.Moduls.Company.DBComTableAdapters.CompanyAddressTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdateAll = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanyAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCompanyAddress
            // 
            this.dataGridViewCompanyAddress.AllowUserToAddRows = false;
            this.dataGridViewCompanyAddress.AllowUserToDeleteRows = false;
            this.dataGridViewCompanyAddress.AllowUserToOrderColumns = true;
            this.dataGridViewCompanyAddress.AllowUserToResizeRows = false;
            this.dataGridViewCompanyAddress.AutoGenerateColumns = false;
            this.dataGridViewCompanyAddress.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewCompanyAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompanyAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.Domain,
            this.dataGridViewTextBoxColumn1,
            this.quanHuyenDataGridViewTextBoxColumn,
            this.thanhPhoDataGridViewTextBoxColumn,
            this.regionIDDataGridViewTextBoxColumn,
            this.googleMapDataGridViewTextBoxColumn,
            this.sTTDataGridViewTextBoxColumn});
            this.dataGridViewCompanyAddress.DataSource = this.companyAddressBindingSource;
            this.dataGridViewCompanyAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCompanyAddress.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCompanyAddress.MultiSelect = false;
            this.dataGridViewCompanyAddress.Name = "dataGridViewCompanyAddress";
            this.dataGridViewCompanyAddress.ReadOnly = true;
            this.dataGridViewCompanyAddress.RowHeadersVisible = false;
            this.dataGridViewCompanyAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewCompanyAddress.Size = new System.Drawing.Size(534, 229);
            this.dataGridViewCompanyAddress.TabIndex = 0;
            this.dataGridViewCompanyAddress.SelectionChanged += new System.EventHandler(this.dataGridViewCompanyAddress_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.FillWeight = 5F;
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Domain
            // 
            this.Domain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Domain.DataPropertyName = "Domain";
            this.Domain.FillWeight = 20F;
            this.Domain.HeaderText = "Domain";
            this.Domain.Name = "Domain";
            this.Domain.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.FillWeight = 15F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quanHuyenDataGridViewTextBoxColumn
            // 
            this.quanHuyenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quanHuyenDataGridViewTextBoxColumn.DataPropertyName = "QuanHuyen";
            this.quanHuyenDataGridViewTextBoxColumn.FillWeight = 15F;
            this.quanHuyenDataGridViewTextBoxColumn.HeaderText = "QuanHuyen";
            this.quanHuyenDataGridViewTextBoxColumn.Name = "quanHuyenDataGridViewTextBoxColumn";
            this.quanHuyenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thanhPhoDataGridViewTextBoxColumn
            // 
            this.thanhPhoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhPhoDataGridViewTextBoxColumn.DataPropertyName = "ThanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.FillWeight = 15F;
            this.thanhPhoDataGridViewTextBoxColumn.HeaderText = "ThanhPho";
            this.thanhPhoDataGridViewTextBoxColumn.Name = "thanhPhoDataGridViewTextBoxColumn";
            this.thanhPhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionIDDataGridViewTextBoxColumn
            // 
            this.regionIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.regionIDDataGridViewTextBoxColumn.DataPropertyName = "RegionID";
            this.regionIDDataGridViewTextBoxColumn.FillWeight = 10F;
            this.regionIDDataGridViewTextBoxColumn.HeaderText = "RegionID";
            this.regionIDDataGridViewTextBoxColumn.Name = "regionIDDataGridViewTextBoxColumn";
            this.regionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // googleMapDataGridViewTextBoxColumn
            // 
            this.googleMapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.googleMapDataGridViewTextBoxColumn.DataPropertyName = "GoogleMap";
            this.googleMapDataGridViewTextBoxColumn.FillWeight = 15F;
            this.googleMapDataGridViewTextBoxColumn.HeaderText = "GoogleMap";
            this.googleMapDataGridViewTextBoxColumn.Name = "googleMapDataGridViewTextBoxColumn";
            this.googleMapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.FillWeight = 5F;
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyAddressBindingSource
            // 
            this.companyAddressBindingSource.DataMember = "CompanyAddress";
            this.companyAddressBindingSource.DataSource = this.dBCom;
            // 
            // dBCom
            // 
            this.dBCom.DataSetName = "DBCom";
            this.dBCom.EnforceConstraints = false;
            this.dBCom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxDistrict);
            this.groupBox1.Controls.Add(this.comboBoxProvin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn đơn vị hành chính";
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(135, 68);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDistrict.TabIndex = 3;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistricts_SelectedIndexChanged);
            // 
            // comboBoxProvin
            // 
            this.comboBoxProvin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxProvin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProvin.FormattingEnabled = true;
            this.comboBoxProvin.Location = new System.Drawing.Point(135, 30);
            this.comboBoxProvin.Name = "comboBoxProvin";
            this.comboBoxProvin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProvin.TabIndex = 2;
            this.comboBoxProvin.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quận Huyện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tỉnh Thành";
            // 
            // companyAddressTableAdapter
            // 
            this.companyAddressTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 5F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.FillWeight = 20F;
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Domain";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // buttonUpdateAll
            // 
            this.buttonUpdateAll.Location = new System.Drawing.Point(135, 165);
            this.buttonUpdateAll.Name = "buttonUpdateAll";
            this.buttonUpdateAll.Size = new System.Drawing.Size(114, 31);
            this.buttonUpdateAll.TabIndex = 2;
            this.buttonUpdateAll.Text = "Update All";
            this.buttonUpdateAll.UseVisualStyleBackColor = true;
            this.buttonUpdateAll.Click += new System.EventHandler(this.buttonUpdateAll_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewCompanyAddress);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonUpdateAll);
            this.splitContainer1.Size = new System.Drawing.Size(902, 229);
            this.splitContainer1.SplitterDistance = 534;
            this.splitContainer1.TabIndex = 3;
            // 
            // FrmEditCompanyRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 229);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmEditCompanyRegion";
            this.Text = "frmEditCompanyRegion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanyAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompanyAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.ComboBox comboBoxProvin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DBCom dBCom;
        private DBComTableAdapters.CompanyAddressTableAdapter companyAddressTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource companyAddressBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domain;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanHuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn googleMapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdateAll;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}