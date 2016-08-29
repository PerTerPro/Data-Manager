namespace QT.Moduls.Tool
{
    partial class frmCheckXPath
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
            this.btCheckXPath = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtURL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtXPath = new DevExpress.XtraEditors.TextEdit();
            this.btReload = new DevExpress.XtraEditors.SimpleButton();
            this.txtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btCheckXPath
            // 
            this.btCheckXPath.Location = new System.Drawing.Point(90, 64);
            this.btCheckXPath.Name = "btCheckXPath";
            this.btCheckXPath.Size = new System.Drawing.Size(75, 23);
            this.btCheckXPath.TabIndex = 0;
            this.btCheckXPath.Text = "Check Xpath";
            this.btCheckXPath.Click += new System.EventHandler(this.btCheckXPath_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "url";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(54, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(615, 20);
            this.txtURL.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "XPath";
            // 
            // txtXPath
            // 
            this.txtXPath.Location = new System.Drawing.Point(54, 38);
            this.txtXPath.Name = "txtXPath";
            this.txtXPath.Size = new System.Drawing.Size(615, 20);
            this.txtXPath.TabIndex = 2;
            // 
            // btReload
            // 
            this.btReload.Location = new System.Drawing.Point(9, 64);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(75, 23);
            this.btReload.TabIndex = 0;
            this.btReload.Text = "Reload";
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(54, 93);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(615, 234);
            this.txtResult.TabIndex = 3;
            // 
            // frmCheckXPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(681, 339);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtXPath);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.btCheckXPath);
            this.Name = "frmCheckXPath";
            ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXPath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btCheckXPath;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtURL;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtXPath;
        private DevExpress.XtraEditors.SimpleButton btReload;
        private System.Windows.Forms.TextBox txtResult;
    }
}
