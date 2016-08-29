namespace QT.Moduls.Company
{
    partial class frmChonRegion
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
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.comboBoxProvin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btChon = new DevExpress.XtraEditors.SimpleButton();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.dBCom = new QT.Moduls.Company.DBCom();
            this.companyAddressTableAdapter = new QT.Moduls.Company.DBComTableAdapters.CompanyAddressTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Location = new System.Drawing.Point(109, 50);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(164, 21);
            this.comboBoxDistrict.TabIndex = 1;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistricts_SelectedIndexChanged);
            // 
            // comboBoxProvin
            // 
            this.comboBoxProvin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxProvin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProvin.FormattingEnabled = true;
            this.comboBoxProvin.Location = new System.Drawing.Point(109, 12);
            this.comboBoxProvin.Name = "comboBoxProvin";
            this.comboBoxProvin.Size = new System.Drawing.Size(164, 21);
            this.comboBoxProvin.TabIndex = 0;
            this.comboBoxProvin.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvin_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quận Huyện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tỉnh Thành";
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(75, 90);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(75, 23);
            this.btChon.TabIndex = 2;
            this.btChon.Text = "Chọn";
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(156, 90);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Đóng";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // dBCom
            // 
            this.dBCom.DataSetName = "DBCom";
            this.dBCom.EnforceConstraints = false;
            this.dBCom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyAddressTableAdapter
            // 
            this.companyAddressTableAdapter.ClearBeforeFill = true;
            // 
            // frmChonRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 138);
            this.Controls.Add(this.comboBoxDistrict);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.comboBoxProvin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btChon);
            this.Controls.Add(this.label1);
            this.Name = "frmChonRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChonRegion";
            this.Load += new System.EventHandler(this.frmChonRegion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.ComboBox comboBoxProvin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btChon;
        private DevExpress.XtraEditors.SimpleButton btClose;
        private DBCom dBCom;
        private DBComTableAdapters.CompanyAddressTableAdapter companyAddressTableAdapter;
    }
}