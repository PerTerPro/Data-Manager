namespace QT.Moduls.Crawler
{
    partial class FrmViewLog
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
            this.xtraTabContorl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContorl)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(900, 32);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Visible = false;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // xtraTabContorl
            // 
            this.xtraTabContorl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabContorl.Location = new System.Drawing.Point(0, 32);
            this.xtraTabContorl.Name = "xtraTabContorl";
            this.xtraTabContorl.Size = new System.Drawing.Size(900, 517);
            this.xtraTabContorl.TabIndex = 4;
            // 
            // FrmViewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 549);
            this.Controls.Add(this.xtraTabContorl);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmViewLog";
            this.Text = "FrmViewLog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmViewLog_FormClosing);
            this.Load += new System.EventHandler(this.FrmViewLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabContorl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabContorl;
    }
}