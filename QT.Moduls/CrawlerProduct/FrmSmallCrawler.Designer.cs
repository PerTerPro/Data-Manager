namespace QT.Moduls.CrawlerProduct
{
    partial class FrmSmallCrawler
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
            this.txtPath = new DevExpress.XtraEditors.TextEdit();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAnalysic = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(382, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(410, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAnalysic
            // 
            this.btnAnalysic.Location = new System.Drawing.Point(492, 10);
            this.btnAnalysic.Name = "btnAnalysic";
            this.btnAnalysic.Size = new System.Drawing.Size(75, 23);
            this.btnAnalysic.TabIndex = 2;
            this.btnAnalysic.Text = "Analysic";
            this.btnAnalysic.Click += new System.EventHandler(this.btnAnalysic_Click);
            // 
            // FrmSmallCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 104);
            this.Controls.Add(this.btnAnalysic);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtPath);
            this.Name = "FrmSmallCrawler";
            this.Text = "FrmSmallCrawler";
            ((System.ComponentModel.ISupportInitialize)(this.txtPath.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtPath;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnAnalysic;
    }
}