namespace QT.Moduls.Maps
{
    partial class frmClassificationToTree
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ctrTreeCompany1 = new QT.Moduls.Maps.ctrTreeCompany();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.ctrTree1 = new QT.Moduls.Maps.ctrTree();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.ctrProductInCategory1 = new QT.Moduls.Maps.ctrProductInCategory();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ctrTreeCompany1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(931, 482);
            this.splitContainerControl1.SplitterPosition = 461;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ctrTreeCompany1
            // 
            this.ctrTreeCompany1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrTreeCompany1.Location = new System.Drawing.Point(0, 0);
            this.ctrTreeCompany1.Name = "ctrTreeCompany1";
            this.ctrTreeCompany1.Size = new System.Drawing.Size(461, 482);
            this.ctrTreeCompany1.TabIndex = 0;
            this.ctrTreeCompany1.CreateNode += new QT.Moduls.Maps.ctrTreeCompany.ChangedEventHandler(this.ctrTreeCompany1_CreateNode);
            this.ctrTreeCompany1.IDCateChange += new QT.Moduls.Maps.ctrTreeCompany.IDCategoryChangeHandler(this.ctrTreeCompany1_IDCateChange);
            this.ctrTreeCompany1.LevelMapChange += new QT.Moduls.Maps.ctrTreeCompany.LevelMapChangeHandler(this.ctrTreeCompany1_LevelMapChange);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(462, 482);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.ctrTree1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(454, 453);
            this.xtraTabPage1.Text = "Chuyên mục hệ thống";
            // 
            // ctrTree1
            // 
            this.ctrTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrTree1.Location = new System.Drawing.Point(0, 0);
            this.ctrTree1.Name = "ctrTree1";
            this.ctrTree1.Size = new System.Drawing.Size(454, 453);
            this.ctrTree1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.ctrProductInCategory1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(454, 453);
            this.xtraTabPage2.Text = "Product in category";
            // 
            // ctrProductInCategory1
            // 
            this.ctrProductInCategory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrProductInCategory1.IDCategory = 0;
            this.ctrProductInCategory1.IDClassification = ((long)(0));
            this.ctrProductInCategory1.LevelMap = 0;
            this.ctrProductInCategory1.Location = new System.Drawing.Point(0, 0);
            this.ctrProductInCategory1.Name = "ctrProductInCategory1";
            this.ctrProductInCategory1.NameCategory = null;
            this.ctrProductInCategory1.Size = new System.Drawing.Size(454, 453);
            this.ctrProductInCategory1.TabIndex = 0;
            // 
            // frmClassificationToTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(931, 482);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmClassificationToTree";
            this.Load += new System.EventHandler(this.frmClassificationToTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private ctrTreeCompany ctrTreeCompany1;
        private ctrTree ctrTree1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ctrProductInCategory ctrProductInCategory1;

    }
}
