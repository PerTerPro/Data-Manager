namespace QT.Entities
{
    partial class ctrPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btNext = new DevExpress.XtraEditors.SimpleButton();
            this.btEnd = new DevExpress.XtraEditors.SimpleButton();
            this.txtCurrentPage = new DevExpress.XtraEditors.TextEdit();
            this.cboSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbTotalItem = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPage = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btFirst
            // 
            this.btFirst.Location = new System.Drawing.Point(62, 3);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(30, 23);
            this.btFirst.TabIndex = 0;
            this.btFirst.Text = "<<-";
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // btPrevious
            // 
            this.btPrevious.Location = new System.Drawing.Point(92, 3);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(30, 23);
            this.btPrevious.TabIndex = 0;
            this.btPrevious.Text = "<";
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(238, 3);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(30, 23);
            this.btNext.TabIndex = 0;
            this.btNext.Text = ">";
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(268, 3);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(30, 23);
            this.btEnd.TabIndex = 0;
            this.btEnd.Text = ">>";
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Location = new System.Drawing.Point(128, 5);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtCurrentPage.Properties.Appearance.Options.UseForeColor = true;
            this.txtCurrentPage.Size = new System.Drawing.Size(43, 20);
            this.txtCurrentPage.TabIndex = 1;
            this.txtCurrentPage.EditValueChanged += new System.EventHandler(this.txtCurrentPage_EditValueChanged);
            // 
            // cboSize
            // 
            this.cboSize.EditValue = "50";
            this.cboSize.Location = new System.Drawing.Point(5, 6);
            this.cboSize.Name = "cboSize";
            this.cboSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSize.Properties.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "1000"});
            this.cboSize.Size = new System.Drawing.Size(51, 20);
            this.cboSize.TabIndex = 2;
            // 
            // lbTotalItem
            // 
            this.lbTotalItem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalItem.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbTotalItem.Location = new System.Drawing.Point(304, 9);
            this.lbTotalItem.Name = "lbTotalItem";
            this.lbTotalItem.Size = new System.Drawing.Size(0, 13);
            this.lbTotalItem.TabIndex = 3;
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(189, 5);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtTotalPage.Properties.Appearance.Options.UseForeColor = true;
            this.txtTotalPage.Size = new System.Drawing.Size(43, 20);
            this.txtTotalPage.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(177, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(4, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "/";
            // 
            // ctrPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.lbTotalItem);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.txtCurrentPage);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.btFirst);
            this.Name = "ctrPage";
            this.Size = new System.Drawing.Size(386, 30);
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btFirst;
        private DevExpress.XtraEditors.SimpleButton btPrevious;
        private DevExpress.XtraEditors.SimpleButton btNext;
        private DevExpress.XtraEditors.SimpleButton btEnd;
        private DevExpress.XtraEditors.TextEdit txtCurrentPage;
        private DevExpress.XtraEditors.ComboBoxEdit cboSize;
        private DevExpress.XtraEditors.LabelControl lbTotalItem;
        private DevExpress.XtraEditors.TextEdit txtTotalPage;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
