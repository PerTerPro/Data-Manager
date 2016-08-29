namespace QT.Moduls.CrawlerProduct
{
    partial class FrmImportProductFromFixedLink
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblAnalysicData = new System.Windows.Forms.Label();
            this.lblImportProductToSQL = new System.Windows.Forms.Label();
            this.btnImportProductToSQL = new DevExpress.XtraEditors.SimpleButton();
            this.bDeleteProduct = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnalysicData = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.lblFile = new DevExpress.XtraEditors.LabelControl();
            this.txtFile = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblAnalysicData);
            this.panelControl1.Controls.Add(this.lblImportProductToSQL);
            this.panelControl1.Controls.Add(this.btnImportProductToSQL);
            this.panelControl1.Controls.Add(this.bDeleteProduct);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnAnalysicData);
            this.panelControl1.Controls.Add(this.btnLoad);
            this.panelControl1.Controls.Add(this.lblFile);
            this.panelControl1.Controls.Add(this.txtFile);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(806, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // lblAnalysicData
            // 
            this.lblAnalysicData.AutoSize = true;
            this.lblAnalysicData.Location = new System.Drawing.Point(554, 32);
            this.lblAnalysicData.Name = "lblAnalysicData";
            this.lblAnalysicData.Size = new System.Drawing.Size(0, 13);
            this.lblAnalysicData.TabIndex = 10;
            // 
            // lblImportProductToSQL
            // 
            this.lblImportProductToSQL.AutoSize = true;
            this.lblImportProductToSQL.Location = new System.Drawing.Point(679, 34);
            this.lblImportProductToSQL.Name = "lblImportProductToSQL";
            this.lblImportProductToSQL.Size = new System.Drawing.Size(0, 13);
            this.lblImportProductToSQL.TabIndex = 9;
            // 
            // btnImportProductToSQL
            // 
            this.btnImportProductToSQL.Location = new System.Drawing.Point(682, 3);
            this.btnImportProductToSQL.Name = "btnImportProductToSQL";
            this.btnImportProductToSQL.Size = new System.Drawing.Size(119, 22);
            this.btnImportProductToSQL.TabIndex = 8;
            this.btnImportProductToSQL.Text = "ImportProductToSQL";
            this.btnImportProductToSQL.Click += new System.EventHandler(this.btnImportProductToSQL_Click);
            // 
            // bDeleteProduct
            // 
            this.bDeleteProduct.AutoSize = true;
            this.bDeleteProduct.Location = new System.Drawing.Point(438, 31);
            this.bDeleteProduct.Name = "bDeleteProduct";
            this.bDeleteProduct.Size = new System.Drawing.Size(97, 17);
            this.bDeleteProduct.TabIndex = 7;
            this.bDeleteProduct.Text = "Delete Product";
            this.bDeleteProduct.UseVisualStyleBackColor = true;
            this.bDeleteProduct.CheckedChanged += new System.EventHandler(this.bDeleteProduct_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số link";
            // 
            // btnAnalysicData
            // 
            this.btnAnalysicData.Location = new System.Drawing.Point(557, 4);
            this.btnAnalysicData.Name = "btnAnalysicData";
            this.btnAnalysicData.Size = new System.Drawing.Size(119, 22);
            this.btnAnalysicData.TabIndex = 5;
            this.btnAnalysicData.Text = "AnalysicData";
            this.btnAnalysicData.Click += new System.EventHandler(this.btnAnalysicData_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(438, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 22);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblFile
            // 
            this.lblFile.Location = new System.Drawing.Point(18, 8);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(20, 13);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "File:";
            // 
            // txtFile
            // 
            this.txtFile.EditValue = "Đường dẫn file exel ...";
            this.txtFile.Location = new System.Drawing.Point(55, 5);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(377, 20);
            this.txtFile.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.richTextBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 50);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(806, 342);
            this.panelControl2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(802, 338);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmImportProductFromFixedLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 392);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmImportProductFromFixedLink";
            this.Text = "FrmImportProductFromFixedLink";
            this.Load += new System.EventHandler(this.FrmImportProductFromFixedLink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAnalysicData;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.LabelControl lblFile;
        private DevExpress.XtraEditors.TextEdit txtFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox bDeleteProduct;
        private DevExpress.XtraEditors.SimpleButton btnImportProductToSQL;
        private System.Windows.Forms.Label lblImportProductToSQL;
        private System.Windows.Forms.Label lblAnalysicData;
        private System.Windows.Forms.Label label1;
    }
}

