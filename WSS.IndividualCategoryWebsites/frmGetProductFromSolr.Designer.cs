namespace WSS.IndividualCategoryWebsites
{
    partial class frmGetProductFromSolr
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
            this.btnGetListProductFromSolr = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumberFound = new DevExpress.XtraEditors.TextEdit();
            this.txtLimitResult = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rbKeywords = new System.Windows.Forms.RichTextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberFound.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimitResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGetListProductFromSolr);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtNumberFound);
            this.panelControl1.Controls.Add(this.txtLimitResult);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.rbKeywords);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(206, 672);
            this.panelControl1.TabIndex = 0;
            // 
            // btnGetListProductFromSolr
            // 
            this.btnGetListProductFromSolr.Location = new System.Drawing.Point(12, 447);
            this.btnGetListProductFromSolr.Name = "btnGetListProductFromSolr";
            this.btnGetListProductFromSolr.Size = new System.Drawing.Size(182, 59);
            this.btnGetListProductFromSolr.TabIndex = 2;
            this.btnGetListProductFromSolr.Text = "Get List Product";
            this.btnGetListProductFromSolr.Click += new System.EventHandler(this.btnGetListProductFromSolr_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(12, 397);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Number Found";
            // 
            // txtNumberFound
            // 
            this.txtNumberFound.EditValue = "";
            this.txtNumberFound.Enabled = false;
            this.txtNumberFound.Location = new System.Drawing.Point(94, 394);
            this.txtNumberFound.Name = "txtNumberFound";
            this.txtNumberFound.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtNumberFound.Properties.Appearance.Options.UseForeColor = true;
            this.txtNumberFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumberFound.Size = new System.Drawing.Size(100, 20);
            this.txtNumberFound.TabIndex = 2;
            // 
            // txtLimitResult
            // 
            this.txtLimitResult.EditValue = "10000";
            this.txtLimitResult.Location = new System.Drawing.Point(94, 351);
            this.txtLimitResult.Name = "txtLimitResult";
            this.txtLimitResult.Size = new System.Drawing.Size(100, 20);
            this.txtLimitResult.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 354);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Limit Result";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Từ khóa";
            // 
            // rbKeywords
            // 
            this.rbKeywords.Location = new System.Drawing.Point(12, 30);
            this.rbKeywords.Name = "rbKeywords";
            this.rbKeywords.Size = new System.Drawing.Size(182, 311);
            this.rbKeywords.TabIndex = 2;
            this.rbKeywords.Text = "";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(206, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1051, 672);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // frmGetProductFromSolr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 672);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmGetProductFromSolr";
            this.Text = "frmGetProductFromSolr";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberFound.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimitResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGetListProductFromSolr;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNumberFound;
        private DevExpress.XtraEditors.TextEdit txtLimitResult;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox rbKeywords;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}