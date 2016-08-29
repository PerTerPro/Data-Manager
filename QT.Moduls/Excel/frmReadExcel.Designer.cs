namespace QT.Moduls.Excel
{
    partial class frmReadExcel
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAction = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.gridControlDataExcel = new DevExpress.XtraGrid.GridControl();
            this.gridViewDataExcel = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonAction);
            this.panelControl1.Controls.Add(this.simpleButtonOpenFile);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1079, 44);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlDataExcel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 44);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1079, 535);
            this.panelControl2.TabIndex = 1;
            // 
            // simpleButtonOpenFile
            // 
            this.simpleButtonOpenFile.Location = new System.Drawing.Point(12, 12);
            this.simpleButtonOpenFile.Name = "simpleButtonOpenFile";
            this.simpleButtonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonOpenFile.TabIndex = 0;
            this.simpleButtonOpenFile.Text = "Open File";
            this.simpleButtonOpenFile.Click += new System.EventHandler(this.simpleButtonOpenFile_Click);
            // 
            // simpleButtonAction
            // 
            this.simpleButtonAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonAction.Location = new System.Drawing.Point(980, 12);
            this.simpleButtonAction.Name = "simpleButtonAction";
            this.simpleButtonAction.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonAction.TabIndex = 1;
            this.simpleButtonAction.Text = "Action";
            this.simpleButtonAction.Click += new System.EventHandler(this.simpleButtonAction_Click);
            // 
            // gridControlDataExcel
            // 
            this.gridControlDataExcel.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlDataExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDataExcel.Location = new System.Drawing.Point(2, 2);
            this.gridControlDataExcel.MainView = this.gridViewDataExcel;
            this.gridControlDataExcel.Name = "gridControlDataExcel";
            this.gridControlDataExcel.Size = new System.Drawing.Size(1075, 531);
            this.gridControlDataExcel.TabIndex = 0;
            this.gridControlDataExcel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDataExcel});
            // 
            // gridViewDataExcel
            // 
            this.gridViewDataExcel.GridControl = this.gridControlDataExcel;
            this.gridViewDataExcel.Name = "gridViewDataExcel";
            // 
            // frmReadExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 579);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmReadExcel";
            this.Text = "frmReadExcel";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAction;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOpenFile;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private DevExpress.XtraGrid.GridControl gridControlDataExcel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDataExcel;
    }
}