namespace QT.Moduls.CrawlerProduct
{
    partial class FrmValidCrawler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblNotValid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompany = new DevExpress.XtraEditors.TextEdit();
            this.btnValidCount = new DevExpress.XtraEditors.SimpleButton();
            this.btnAllValidCount = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompany.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crawler Valid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crawler Not Valid:";
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(139, 79);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(23, 13);
            this.lblValid.TabIndex = 2;
            this.lblValid.Text = "lbl1";
            // 
            // lblNotValid
            // 
            this.lblNotValid.AutoSize = true;
            this.lblNotValid.Location = new System.Drawing.Point(139, 117);
            this.lblNotValid.Name = "lblNotValid";
            this.lblNotValid.Size = new System.Drawing.Size(23, 13);
            this.lblNotValid.TabIndex = 3;
            this.lblNotValid.Text = "lbl2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Company:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(72, 6);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(193, 20);
            this.txtCompany.TabIndex = 5;
            // 
            // btnValidCount
            // 
            this.btnValidCount.Location = new System.Drawing.Point(15, 32);
            this.btnValidCount.Name = "btnValidCount";
            this.btnValidCount.Size = new System.Drawing.Size(75, 23);
            this.btnValidCount.TabIndex = 6;
            this.btnValidCount.Text = "Valid Count";
            this.btnValidCount.Click += new System.EventHandler(this.btnValidCount_Click);
            // 
            // btnAllValidCount
            // 
            this.btnAllValidCount.Location = new System.Drawing.Point(96, 32);
            this.btnAllValidCount.Name = "btnAllValidCount";
            this.btnAllValidCount.Size = new System.Drawing.Size(75, 23);
            this.btnAllValidCount.TabIndex = 7;
            this.btnAllValidCount.Text = "All Valid Count";
            this.btnAllValidCount.Click += new System.EventHandler(this.btnAllValidCount_Click);
            // 
            // FrmValidCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 191);
            this.Controls.Add(this.btnAllValidCount);
            this.Controls.Add(this.btnValidCount);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNotValid);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmValidCrawler";
            this.Text = "ValidCrawler";
            ((System.ComponentModel.ISupportInitialize)(this.txtCompany.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Label lblNotValid;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtCompany;
        private DevExpress.XtraEditors.SimpleButton btnValidCount;
        private DevExpress.XtraEditors.SimpleButton btnAllValidCount;
    }
}