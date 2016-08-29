namespace QT.Moduls.Tool
{
    partial class frmXoaSPLogTrung
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
            this.laTong = new System.Windows.Forms.Label();
            this.btStart = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.managerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTool3 = new QT.Moduls.Tool.DBTool3();
            this.managerTypeTableAdapter = new QT.Moduls.Tool.DBTool3TableAdapters.ManagerTypeTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Tool.DBTool3TableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.btUpdateImageBTThu = new DevExpress.XtraEditors.SimpleButton();
            this.btUpdateImageToProduct = new DevExpress.XtraEditors.SimpleButton();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool3)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(147, 12);
            iDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 4;
            iDLabel.Text = "ID:";
            // 
            // laTong
            // 
            this.laTong.Location = new System.Drawing.Point(12, 60);
            this.laTong.Name = "laTong";
            this.laTong.Size = new System.Drawing.Size(657, 220);
            this.laTong.TabIndex = 3;
            this.laTong.Text = "label1";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(223, 10);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(84, 28);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start Delete";
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.managerTypeBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "ID";
            // 
            // managerTypeBindingSource
            // 
            this.managerTypeBindingSource.DataMember = "ManagerType";
            this.managerTypeBindingSource.DataSource = this.dBTool3;
            // 
            // dBTool3
            // 
            this.dBTool3.DataSetName = "DBTool3";
            this.dBTool3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerTypeTableAdapter
            // 
            this.managerTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Product_LogsAddProductTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.TempTradeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Tool.DBTool3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerTypeBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(170, 10);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(38, 20);
            this.iDTextBox.TabIndex = 5;
            // 
            // btUpdateImageBTThu
            // 
            this.btUpdateImageBTThu.Location = new System.Drawing.Point(444, 324);
            this.btUpdateImageBTThu.Name = "btUpdateImageBTThu";
            this.btUpdateImageBTThu.Size = new System.Drawing.Size(162, 28);
            this.btUpdateImageBTThu.TabIndex = 2;
            this.btUpdateImageBTThu.Text = "Upadete Image BanhTrungThu";
            this.btUpdateImageBTThu.Click += new System.EventHandler(this.btUpdateImageBTThu_Click);
            // 
            // btUpdateImageToProduct
            // 
            this.btUpdateImageToProduct.Location = new System.Drawing.Point(481, 10);
            this.btUpdateImageToProduct.Name = "btUpdateImageToProduct";
            this.btUpdateImageToProduct.Size = new System.Drawing.Size(162, 28);
            this.btUpdateImageToProduct.TabIndex = 2;
            this.btUpdateImageToProduct.Text = "Upadete Image To Product";
            this.btUpdateImageToProduct.Click += new System.EventHandler(this.btUpdateImageToProduct_Click);
            // 
            // frmXoaSPLogTrung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(883, 412);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.laTong);
            this.Controls.Add(this.btUpdateImageToProduct);
            this.Controls.Add(this.btUpdateImageBTThu);
            this.Controls.Add(this.btStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXoaSPLogTrung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXoaSPLogTrung_FormClosing);
            this.Load += new System.EventHandler(this.frmXoaSPLogTrung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTong;
        private DevExpress.XtraEditors.SimpleButton btStart;
        private System.Windows.Forms.ComboBox comboBox1;
        private DBTool3 dBTool3;
        private System.Windows.Forms.BindingSource managerTypeBindingSource;
        private DBTool3TableAdapters.ManagerTypeTableAdapter managerTypeTableAdapter;
        private DBTool3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private DevExpress.XtraEditors.SimpleButton btUpdateImageBTThu;
        private DevExpress.XtraEditors.SimpleButton btUpdateImageToProduct;
    }
}
