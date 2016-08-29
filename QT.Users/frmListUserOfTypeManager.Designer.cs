namespace QT.Users
{
    partial class frmListUserOfTypeManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB = new QT.Users.DB();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btQuit = new DevExpress.XtraEditors.SimpleButton();
            this.btLogin = new DevExpress.XtraEditors.SimpleButton();
            this.tblUserTableAdapter = new QT.Users.DBTableAdapters.tblUserTableAdapter();
            this.tableAdapterManager = new QT.Users.DBTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(8, 181);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 5;
            iDLabel.Text = "ID:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.tblUserBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(1, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(482, 171);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colEmail,
            this.colMobile});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 0;
            // 
            // colMobile
            // 
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 2;
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(245, 178);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(75, 23);
            this.btQuit.TabIndex = 5;
            this.btQuit.Text = "Quit";
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(164, 178);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Chọn";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManagerTypeRUserTableAdapter = null;
            this.tableAdapterManager.ManagerTypeTableAdapter = null;
            this.tableAdapterManager.tblUserTableAdapter = this.tblUserTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Users.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_CategoryTableAdapter = null;
            this.tableAdapterManager.User_PermisionTableAdapter = null;
            this.tableAdapterManager.UserJobTableAdapter = null;
            this.tableAdapterManager.UserJobTypeTableAdapter = null;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(35, 178);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 6;
            // 
            // frmListUserOfTypeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 206);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmListUserOfTypeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListUserOfTypeManager";
            this.Load += new System.EventHandler(this.frmListUserOfTypeManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraEditors.SimpleButton btQuit;
        private DevExpress.XtraEditors.SimpleButton btLogin;
        private DB dB;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private DBTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
    }
}