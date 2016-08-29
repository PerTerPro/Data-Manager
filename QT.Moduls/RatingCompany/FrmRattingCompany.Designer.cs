namespace QT.Moduls.RatingCompany
{
    partial class FrmRattingCompany
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDomain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReputation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Reputation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colBigStore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_BigStore = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colScandal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Scandal = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGenuine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Geneuine = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuanlity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Quantity = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAttitude = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Attitude = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDelivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Delivery = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGuarantee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Guarantee = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSwap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Swap = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Price = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OldCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_OldCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox_BigStore = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemLookUpEdit_OldCustomer1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Reputation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_BigStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Scandal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Geneuine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Attitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Delivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Guarantee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Swap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_OldCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_BigStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_OldCustomer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDomain);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 39);
            this.panel1.TabIndex = 1;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(12, 10);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(202, 20);
            this.txtDomain.TabIndex = 2;
            this.txtDomain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDomain_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(236, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refesh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(0, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox_BigStore,
            this.repositoryItemLookUpEdit_BigStore,
            this.repositoryItemLookUpEdit_Reputation,
            this.repositoryItemLookUpEdit_Scandal,
            this.repositoryItemLookUpEdit_Geneuine,
            this.repositoryItemLookUpEdit_Quantity,
            this.repositoryItemLookUpEdit_Attitude,
            this.repositoryItemLookUpEdit_Delivery,
            this.repositoryItemLookUpEdit_Guarantee,
            this.repositoryItemLookUpEdit_Swap,
            this.repositoryItemLookUpEdit_Price,
            this.repositoryItemLookUpEdit_OldCustomer1,
            this.repositoryItemLookUpEdit_OldCustomer});
            this.gridControl1.Size = new System.Drawing.Size(1482, 762);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDomain,
            this.colCompanyID,
            this.colReputation,
            this.colBigStore,
            this.colScandal,
            this.colGenuine,
            this.colQuanlity,
            this.colAttitude,
            this.colDelivery,
            this.colGuarantee,
            this.colSwap,
            this.colPrice,
            this.UserName,
            this.OldCustomer});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colDomain
            // 
            this.colDomain.Caption = "Domain";
            this.colDomain.FieldName = "Domain";
            this.colDomain.Name = "colDomain";
            this.colDomain.Visible = true;
            this.colDomain.VisibleIndex = 0;
            // 
            // colCompanyID
            // 
            this.colCompanyID.Caption = "Mã CT";
            this.colCompanyID.FieldName = "CompanyID";
            this.colCompanyID.Name = "colCompanyID";
            this.colCompanyID.Visible = true;
            this.colCompanyID.VisibleIndex = 1;
            // 
            // colReputation
            // 
            this.colReputation.Caption = "Uy tín";
            this.colReputation.ColumnEdit = this.repositoryItemLookUpEdit_Reputation;
            this.colReputation.FieldName = "Reputation";
            this.colReputation.Name = "colReputation";
            // 
            // repositoryItemLookUpEdit_Reputation
            // 
            this.repositoryItemLookUpEdit_Reputation.AutoHeight = false;
            this.repositoryItemLookUpEdit_Reputation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Reputation.Name = "repositoryItemLookUpEdit_Reputation";
            // 
            // colBigStore
            // 
            this.colBigStore.Caption = "Cửa hàng lớn";
            this.colBigStore.ColumnEdit = this.repositoryItemLookUpEdit_BigStore;
            this.colBigStore.FieldName = "BigStore";
            this.colBigStore.Name = "colBigStore";
            this.colBigStore.Visible = true;
            this.colBigStore.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit_BigStore
            // 
            this.repositoryItemLookUpEdit_BigStore.AutoHeight = false;
            this.repositoryItemLookUpEdit_BigStore.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_BigStore.Name = "repositoryItemLookUpEdit_BigStore";
            // 
            // colScandal
            // 
            this.colScandal.Caption = "Dính phốt";
            this.colScandal.ColumnEdit = this.repositoryItemLookUpEdit_Scandal;
            this.colScandal.FieldName = "Scandal";
            this.colScandal.Name = "colScandal";
            this.colScandal.Visible = true;
            this.colScandal.VisibleIndex = 3;
            // 
            // repositoryItemLookUpEdit_Scandal
            // 
            this.repositoryItemLookUpEdit_Scandal.AutoHeight = false;
            this.repositoryItemLookUpEdit_Scandal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Scandal.Name = "repositoryItemLookUpEdit_Scandal";
            // 
            // colGenuine
            // 
            this.colGenuine.Caption = "Chính hãng";
            this.colGenuine.ColumnEdit = this.repositoryItemLookUpEdit_Geneuine;
            this.colGenuine.FieldName = "Genuine";
            this.colGenuine.Name = "colGenuine";
            this.colGenuine.Visible = true;
            this.colGenuine.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEdit_Geneuine
            // 
            this.repositoryItemLookUpEdit_Geneuine.AutoHeight = false;
            this.repositoryItemLookUpEdit_Geneuine.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Geneuine.Name = "repositoryItemLookUpEdit_Geneuine";
            // 
            // colQuanlity
            // 
            this.colQuanlity.Caption = "Chất lượng";
            this.colQuanlity.ColumnEdit = this.repositoryItemLookUpEdit_Quantity;
            this.colQuanlity.FieldName = "Quanlity";
            this.colQuanlity.Name = "colQuanlity";
            this.colQuanlity.Visible = true;
            this.colQuanlity.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEdit_Quantity
            // 
            this.repositoryItemLookUpEdit_Quantity.AutoHeight = false;
            this.repositoryItemLookUpEdit_Quantity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Quantity.Name = "repositoryItemLookUpEdit_Quantity";
            // 
            // colAttitude
            // 
            this.colAttitude.Caption = "Thái độ PV";
            this.colAttitude.ColumnEdit = this.repositoryItemLookUpEdit_Attitude;
            this.colAttitude.FieldName = "Attitude";
            this.colAttitude.Name = "colAttitude";
            this.colAttitude.Visible = true;
            this.colAttitude.VisibleIndex = 6;
            // 
            // repositoryItemLookUpEdit_Attitude
            // 
            this.repositoryItemLookUpEdit_Attitude.AutoHeight = false;
            this.repositoryItemLookUpEdit_Attitude.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Attitude.Name = "repositoryItemLookUpEdit_Attitude";
            // 
            // colDelivery
            // 
            this.colDelivery.Caption = "Giao hàng nhanh";
            this.colDelivery.ColumnEdit = this.repositoryItemLookUpEdit_Delivery;
            this.colDelivery.FieldName = "Delivery";
            this.colDelivery.Name = "colDelivery";
            this.colDelivery.Visible = true;
            this.colDelivery.VisibleIndex = 7;
            // 
            // repositoryItemLookUpEdit_Delivery
            // 
            this.repositoryItemLookUpEdit_Delivery.AutoHeight = false;
            this.repositoryItemLookUpEdit_Delivery.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Delivery.Name = "repositoryItemLookUpEdit_Delivery";
            // 
            // colGuarantee
            // 
            this.colGuarantee.Caption = "Bảo hành";
            this.colGuarantee.ColumnEdit = this.repositoryItemLookUpEdit_Guarantee;
            this.colGuarantee.FieldName = "Guarantee";
            this.colGuarantee.Name = "colGuarantee";
            this.colGuarantee.Visible = true;
            this.colGuarantee.VisibleIndex = 8;
            // 
            // repositoryItemLookUpEdit_Guarantee
            // 
            this.repositoryItemLookUpEdit_Guarantee.AutoHeight = false;
            this.repositoryItemLookUpEdit_Guarantee.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Guarantee.Name = "repositoryItemLookUpEdit_Guarantee";
            // 
            // colSwap
            // 
            this.colSwap.Caption = "Đổi hàng";
            this.colSwap.ColumnEdit = this.repositoryItemLookUpEdit_Swap;
            this.colSwap.FieldName = "Swap";
            this.colSwap.Name = "colSwap";
            this.colSwap.Visible = true;
            this.colSwap.VisibleIndex = 9;
            // 
            // repositoryItemLookUpEdit_Swap
            // 
            this.repositoryItemLookUpEdit_Swap.AutoHeight = false;
            this.repositoryItemLookUpEdit_Swap.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Swap.Name = "repositoryItemLookUpEdit_Swap";
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Giá SP";
            this.colPrice.ColumnEdit = this.repositoryItemLookUpEdit_Price;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 10;
            // 
            // repositoryItemLookUpEdit_Price
            // 
            this.repositoryItemLookUpEdit_Price.AutoHeight = false;
            this.repositoryItemLookUpEdit_Price.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Price.Name = "repositoryItemLookUpEdit_Price";
            // 
            // UserName
            // 
            this.UserName.Caption = "UserName";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            // 
            // OldCustomer
            // 
            this.OldCustomer.Caption = "Ưu đãi khách cũ";
            this.OldCustomer.ColumnEdit = this.repositoryItemLookUpEdit_OldCustomer;
            this.OldCustomer.FieldName = "OldCustomer";
            this.OldCustomer.Name = "OldCustomer";
            this.OldCustomer.Visible = true;
            this.OldCustomer.VisibleIndex = 11;
            // 
            // repositoryItemLookUpEdit_OldCustomer
            // 
            this.repositoryItemLookUpEdit_OldCustomer.AutoHeight = false;
            this.repositoryItemLookUpEdit_OldCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_OldCustomer.Name = "repositoryItemLookUpEdit_OldCustomer";
            // 
            // repositoryItemComboBox_BigStore
            // 
            this.repositoryItemComboBox_BigStore.AutoHeight = false;
            this.repositoryItemComboBox_BigStore.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox_BigStore.Name = "repositoryItemComboBox_BigStore";
            // 
            // repositoryItemLookUpEdit_OldCustomer1
            // 
            this.repositoryItemLookUpEdit_OldCustomer1.AutoHeight = false;
            this.repositoryItemLookUpEdit_OldCustomer1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_OldCustomer1.Name = "repositoryItemLookUpEdit_OldCustomer1";
            this.repositoryItemLookUpEdit_OldCustomer1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // FrmRattingCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 801);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRattingCompany";
            this.Text = "Đánh giá công ty";
            this.Load += new System.EventHandler(this.FrmRattingCompany_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRattingCompany_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Reputation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_BigStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Scandal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Geneuine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Attitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Delivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Guarantee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Swap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_OldCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_BigStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_OldCustomer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn colReputation;
        private DevExpress.XtraGrid.Columns.GridColumn colBigStore;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox_BigStore;
        private DevExpress.XtraGrid.Columns.GridColumn colScandal;
        private DevExpress.XtraGrid.Columns.GridColumn colGenuine;
        private DevExpress.XtraGrid.Columns.GridColumn colQuanlity;
        private DevExpress.XtraGrid.Columns.GridColumn colAttitude;
        private DevExpress.XtraGrid.Columns.GridColumn colDelivery;
        private DevExpress.XtraGrid.Columns.GridColumn colGuarantee;
        private DevExpress.XtraGrid.Columns.GridColumn colSwap;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_BigStore;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Reputation;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Scandal;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Geneuine;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Quantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Attitude;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Delivery;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Guarantee;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Swap;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colDomain;
        private System.Windows.Forms.TextBox txtDomain;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn OldCustomer;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemLookUpEdit_OldCustomer1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_OldCustomer;
    }
}