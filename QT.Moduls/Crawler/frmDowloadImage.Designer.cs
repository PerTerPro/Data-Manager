namespace QT.Moduls.Crawler
{
    partial class frmDowloadImage
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
            this.laMess1 = new System.Windows.Forms.Label();
            this.chkRedownload = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRedownload.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // laMess1
            // 
            this.laMess1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laMess1.Location = new System.Drawing.Point(9, 45);
            this.laMess1.Name = "laMess1";
            this.laMess1.Size = new System.Drawing.Size(701, 294);
            this.laMess1.TabIndex = 2;
            this.laMess1.Text = "messger";
            // 
            // chkRedownload
            // 
            this.chkRedownload.Location = new System.Drawing.Point(12, 12);
            this.chkRedownload.Name = "chkRedownload";
            this.chkRedownload.Properties.Caption = "Ghi đè lại ảnh";
            this.chkRedownload.Size = new System.Drawing.Size(106, 19);
            this.chkRedownload.TabIndex = 21;
            this.chkRedownload.CheckedChanged += new System.EventHandler(this.chkRedownload_CheckedChanged);
            // 
            // frmDowloadImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(714, 351);
            this.Controls.Add(this.chkRedownload);
            this.Controls.Add(this.laMess1);
            this.Name = "frmDowloadImage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDowloadImage_FormClosing);
            this.Load += new System.EventHandler(this.frmDowloadImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkRedownload.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label laMess1;
        private DevExpress.XtraEditors.CheckEdit chkRedownload;
    }
}
