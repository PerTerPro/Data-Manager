namespace QT.Moduls.CrawlerProduct
{
    partial class FrmCleanDuplicateProduct
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
            this.btnSetDuplicateErrors = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblDone = new System.Windows.Forms.Label();
            this.btnCleanAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnCleanOne = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomain = new DevExpress.XtraEditors.TextEdit();
            this.lblTongSanPham = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblSpThucTe = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSetDuplicateErrors);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.lblDone);
            this.panelControl1.Controls.Add(this.btnCleanAll);
            this.panelControl1.Controls.Add(this.btnCleanOne);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtDomain);
            this.panelControl1.Controls.Add(this.lblTongSanPham);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lblSpThucTe);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(445, 99);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSetDuplicateErrors
            // 
            this.btnSetDuplicateErrors.Location = new System.Drawing.Point(213, 60);
            this.btnSetDuplicateErrors.Name = "btnSetDuplicateErrors";
            this.btnSetDuplicateErrors.Size = new System.Drawing.Size(106, 23);
            this.btnSetDuplicateErrors.TabIndex = 8;
            this.btnSetDuplicateErrors.Text = "SetDuplicateErrors";
            this.btnSetDuplicateErrors.Click += new System.EventHandler(this.btnSetDuplicateErrors_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(213, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "SetDuplicateField";
            this.simpleButton1.Click += new System.EventHandler(this.btnSetDataDumplicate);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(141, 75);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(16, 13);
            this.lblDone.TabIndex = 2;
            this.lblDone.Text = "...";
            // 
            // btnCleanAll
            // 
            this.btnCleanAll.Location = new System.Drawing.Point(325, 31);
            this.btnCleanAll.Name = "btnCleanAll";
            this.btnCleanAll.Size = new System.Drawing.Size(75, 23);
            this.btnCleanAll.TabIndex = 6;
            this.btnCleanAll.Text = "Clean all";
            this.btnCleanAll.Click += new System.EventHandler(this.btnCleanAll_Click);
            // 
            // btnCleanOne
            // 
            this.btnCleanOne.Location = new System.Drawing.Point(65, 31);
            this.btnCleanOne.Name = "btnCleanOne";
            this.btnCleanOne.Size = new System.Drawing.Size(75, 23);
            this.btnCleanOne.TabIndex = 5;
            this.btnCleanOne.Text = "Clean one";
            this.btnCleanOne.Click += new System.EventHandler(this.btnCleanOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Domain:";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(65, 5);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(335, 20);
            this.txtDomain.TabIndex = 3;
            // 
            // lblTongSanPham
            // 
            this.lblTongSanPham.Location = new System.Drawing.Point(65, 75);
            this.lblTongSanPham.Name = "lblTongSanPham";
            this.lblTongSanPham.Size = new System.Drawing.Size(24, 13);
            this.lblTongSanPham.TabIndex = 2;
            this.lblTongSanPham.Text = "Tổng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(55, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "/";
            // 
            // lblSpThucTe
            // 
            this.lblSpThucTe.Location = new System.Drawing.Point(12, 75);
            this.lblSpThucTe.Name = "lblSpThucTe";
            this.lblSpThucTe.Size = new System.Drawing.Size(37, 13);
            this.lblSpThucTe.TabIndex = 0;
            this.lblSpThucTe.Text = "Thực tế";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.richTextBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 99);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(445, 268);
            this.panelControl2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(441, 264);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // FrmCleanDuplicateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 367);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmCleanDuplicateProduct";
            this.Text = "FrmCleanDuplicateProduct";
            this.Load += new System.EventHandler(this.FrmCleanDuplicateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblTongSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblSpThucTe;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.SimpleButton btnCleanAll;
        private DevExpress.XtraEditors.SimpleButton btnCleanOne;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtDomain;
        private System.Windows.Forms.Label lblDone;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnSetDuplicateErrors;
    }
}