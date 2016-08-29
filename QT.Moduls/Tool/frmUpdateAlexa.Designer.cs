namespace QT.Moduls.Tool
{
    partial class frmUpdateAlexa
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label iDLabel1;
            this.btStart = new DevExpress.XtraEditors.SimpleButton();
            this.laTong = new System.Windows.Forms.Label();
            this.btupdatefulltext = new DevExpress.XtraEditors.SimpleButton();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.companyStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTool = new QT.Moduls.Tool.DBTool();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.company_StatusTableAdapter = new QT.Moduls.Tool.DBToolTableAdapters.Company_StatusTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Tool.DBToolTableAdapters.TableAdapterManager();
            this.managerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTypeTableAdapter = new QT.Moduls.Tool.DBToolTableAdapters.ManagerTypeTableAdapter();
            this.txtManagerID = new System.Windows.Forms.TextBox();
            this.chkNhomQuanLy = new System.Windows.Forms.CheckBox();
            iDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(-2, 13);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "ID:";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(375, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(98, 53);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start Update";
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // laTong
            // 
            this.laTong.Location = new System.Drawing.Point(12, 58);
            this.laTong.Name = "laTong";
            this.laTong.Size = new System.Drawing.Size(657, 220);
            this.laTong.TabIndex = 1;
            this.laTong.Text = "label1";
            // 
            // btupdatefulltext
            // 
            this.btupdatefulltext.Location = new System.Drawing.Point(585, 10);
            this.btupdatefulltext.Name = "btupdatefulltext";
            this.btupdatefulltext.Size = new System.Drawing.Size(84, 28);
            this.btupdatefulltext.TabIndex = 0;
            this.btupdatefulltext.Text = "update fulltext";
            this.btupdatefulltext.Click += new System.EventHandler(this.btupdatefulltext_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DataSource = this.companyStatusBindingSource;
            this.cboStatus.DisplayMember = "Description";
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(72, 9);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 3;
            this.cboStatus.ValueMember = "ID";
            // 
            // companyStatusBindingSource
            // 
            this.companyStatusBindingSource.DataMember = "Company_Status";
            this.companyStatusBindingSource.DataSource = this.dBTool;
            // 
            // dBTool
            // 
            this.dBTool.DataSetName = "DBTool";
            this.dBTool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyStatusBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(25, 10);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(41, 20);
            this.iDTextBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.managerTypeBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "ID";
            // 
            // company_StatusTableAdapter
            // 
            this.company_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_StatusTableAdapter = this.company_StatusTableAdapter;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.ProductClassificationTableAdapter = null;
            this.tableAdapterManager.ProductIDHashNameTableAdapter = null;
            this.tableAdapterManager.ProductImagePathTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Tool.DBToolTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(-2, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 13);
            label1.TabIndex = 5;
            label1.Text = "Nhóm quản lý";
            // 
            // managerTypeBindingSource
            // 
            this.managerTypeBindingSource.DataMember = "ManagerType";
            this.managerTypeBindingSource.DataSource = this.dBTool;
            // 
            // managerTypeTableAdapter
            // 
            this.managerTypeTableAdapter.ClearBeforeFill = true;
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(204, 38);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 8;
            iDLabel1.Text = "ID:";
            // 
            // txtManagerID
            // 
            this.txtManagerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeBindingSource, "ID", true));
            this.txtManagerID.Location = new System.Drawing.Point(231, 35);
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.Size = new System.Drawing.Size(100, 20);
            this.txtManagerID.TabIndex = 9;
            // 
            // chkNhomQuanLy
            // 
            this.chkNhomQuanLy.AutoSize = true;
            this.chkNhomQuanLy.Checked = true;
            this.chkNhomQuanLy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNhomQuanLy.Location = new System.Drawing.Point(218, 10);
            this.chkNhomQuanLy.Name = "chkNhomQuanLy";
            this.chkNhomQuanLy.Size = new System.Drawing.Size(151, 17);
            this.chkNhomQuanLy.TabIndex = 10;
            this.chkNhomQuanLy.Text = "Update theo nhóm quản lý";
            this.chkNhomQuanLy.UseVisualStyleBackColor = true;
            // 
            // frmUpdateAlexa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(689, 339);
            this.Controls.Add(this.chkNhomQuanLy);
            this.Controls.Add(iDLabel1);
            this.Controls.Add(this.txtManagerID);
            this.Controls.Add(label1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.laTong);
            this.Controls.Add(this.btupdatefulltext);
            this.Controls.Add(this.btStart);
            this.Name = "frmUpdateAlexa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateAlexa_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdateAlexa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btStart;
        private System.Windows.Forms.Label laTong;
        private DevExpress.XtraEditors.SimpleButton btupdatefulltext;
        private System.Windows.Forms.ComboBox cboStatus;
        private DBTool dBTool;
        private System.Windows.Forms.BindingSource companyStatusBindingSource;
        private DBToolTableAdapters.Company_StatusTableAdapter company_StatusTableAdapter;
        private DBToolTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource managerTypeBindingSource;
        private DBToolTableAdapters.ManagerTypeTableAdapter managerTypeTableAdapter;
        private System.Windows.Forms.TextBox txtManagerID;
        private System.Windows.Forms.CheckBox chkNhomQuanLy;
    }
}
