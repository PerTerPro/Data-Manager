namespace QT.Moduls.Maps
{
    partial class frmChonChuyenMucGoc
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
            this.btSelect = new DevExpress.XtraEditors.SimpleButton();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.ctrTree1 = new QT.Moduls.Maps.ctrTree();
            this.SuspendLayout();
            // 
            // btSelect
            // 
            this.btSelect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSelect.Location = new System.Drawing.Point(265, 488);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(94, 33);
            this.btSelect.TabIndex = 1;
            this.btSelect.Text = "Chọn";
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btClose.Location = new System.Drawing.Point(365, 488);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(94, 33);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ctrTree1
            // 
            this.ctrTree1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrTree1.Location = new System.Drawing.Point(1, -21);
            this.ctrTree1.Name = "ctrTree1";
            this.ctrTree1.Size = new System.Drawing.Size(731, 503);
            this.ctrTree1.TabIndex = 0;
            // 
            // frmChonChuyenMucGoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 523);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.ctrTree1);
            this.Name = "frmChonChuyenMucGoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChonChuyenMucGoc";
            this.Load += new System.EventHandler(this.frmChonChuyenMucGoc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrTree ctrTree1;
        private DevExpress.XtraEditors.SimpleButton btSelect;
        private DevExpress.XtraEditors.SimpleButton btClose;
    }
}