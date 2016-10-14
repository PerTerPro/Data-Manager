namespace WSS.Financial.BankLending
{
    partial class FrmBankLendingManager
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label bankIdLabel;
            System.Windows.Forms.Label interestRatesLabel;
            System.Windows.Forms.Label minimumLabel;
            System.Windows.Forms.Label maximumLabel;
            System.Windows.Forms.Label timeLimitLabel;
            System.Windows.Forms.Label minPersonalIncomeLabel;
            System.Windows.Forms.Label paymentMethodIdLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankLendingManager));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bankLendingBindingSource = new System.Windows.Forms.BindingSource();
            this.dBFinancial = new WSS.Financial.DBFinancial();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bankIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.bankBindingSource = new System.Windows.Forms.BindingSource();
            this.interestRatesTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.timeLimitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.paymentMethodIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.paymentMethodBindingSource = new System.Windows.Forms.BindingSource();
            this.bankLendingTableAdapter = new WSS.Financial.DBFinancialTableAdapters.BankLendingTableAdapter();
            this.tableAdapterManager = new WSS.Financial.DBFinancialTableAdapters.TableAdapterManager();
            this.bankTableAdapter = new WSS.Financial.DBFinancialTableAdapters.BankTableAdapter();
            this.paymentMethodTableAdapter = new WSS.Financial.DBFinancialTableAdapters.PaymentMethodTableAdapter();
            this.bankLendingBindingNavigator = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bankLendingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bankLendingGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditBank = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colInterestRates = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinimum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaximum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinPersonalIncome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMethodId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEditPaymentMethod = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.spinEditMinPriceFound = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            bankIdLabel = new System.Windows.Forms.Label();
            interestRatesLabel = new System.Windows.Forms.Label();
            minimumLabel = new System.Windows.Forms.Label();
            maximumLabel = new System.Windows.Forms.Label();
            timeLimitLabel = new System.Windows.Forms.Label();
            minPersonalIncomeLabel = new System.Windows.Forms.Label();
            paymentMethodIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankLendingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRatesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankLendingBindingNavigator)).BeginInit();
            this.bankLendingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankLendingGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPaymentMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMinPriceFound.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(50, 24);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(311, 24);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(106, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Tên gói vay tín dụng";
            // 
            // bankIdLabel
            // 
            bankIdLabel.AutoSize = true;
            bankIdLabel.Location = new System.Drawing.Point(50, 60);
            bankIdLabel.Name = "bankIdLabel";
            bankIdLabel.Size = new System.Drawing.Size(86, 13);
            bankIdLabel.TabIndex = 4;
            bankIdLabel.Text = "Chọn ngân hàng";
            // 
            // interestRatesLabel
            // 
            interestRatesLabel.AutoSize = true;
            interestRatesLabel.Location = new System.Drawing.Point(428, 60);
            interestRatesLabel.Name = "interestRatesLabel";
            interestRatesLabel.Size = new System.Drawing.Size(44, 13);
            interestRatesLabel.TabIndex = 6;
            interestRatesLabel.Text = "Lãi suất";
            // 
            // minimumLabel
            // 
            minimumLabel.AutoSize = true;
            minimumLabel.Location = new System.Drawing.Point(5, 31);
            minimumLabel.Name = "minimumLabel";
            minimumLabel.Size = new System.Drawing.Size(24, 13);
            minimumLabel.TabIndex = 8;
            minimumLabel.Text = "Min";
            // 
            // maximumLabel
            // 
            maximumLabel.AutoSize = true;
            maximumLabel.Location = new System.Drawing.Point(257, 31);
            maximumLabel.Name = "maximumLabel";
            maximumLabel.Size = new System.Drawing.Size(27, 13);
            maximumLabel.TabIndex = 10;
            maximumLabel.Text = "Max";
            // 
            // timeLimitLabel
            // 
            timeLimitLabel.AutoSize = true;
            timeLimitLabel.Location = new System.Drawing.Point(660, 60);
            timeLimitLabel.Name = "timeLimitLabel";
            timeLimitLabel.Size = new System.Drawing.Size(69, 13);
            timeLimitLabel.TabIndex = 12;
            timeLimitLabel.Text = "Thời hạn vay";
            // 
            // minPersonalIncomeLabel
            // 
            minPersonalIncomeLabel.AutoSize = true;
            minPersonalIncomeLabel.Location = new System.Drawing.Point(564, 105);
            minPersonalIncomeLabel.Name = "minPersonalIncomeLabel";
            minPersonalIncomeLabel.Size = new System.Drawing.Size(93, 13);
            minPersonalIncomeLabel.TabIndex = 14;
            minPersonalIncomeLabel.Text = "Thu nhập tối thiểu";
            // 
            // paymentMethodIdLabel
            // 
            paymentMethodIdLabel.AutoSize = true;
            paymentMethodIdLabel.Location = new System.Drawing.Point(910, 105);
            paymentMethodIdLabel.Name = "paymentMethodIdLabel";
            paymentMethodIdLabel.Size = new System.Drawing.Size(121, 13);
            paymentMethodIdLabel.TabIndex = 16;
            paymentMethodIdLabel.Text = "Hình thức trả khoản vay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(584, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 18;
            label1.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(890, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 20);
            label3.TabIndex = 21;
            label3.Text = "tháng";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.spinEdit2);
            this.panelControl1.Controls.Add(label3);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(label1);
            this.panelControl1.Controls.Add(idLabel);
            this.panelControl1.Controls.Add(this.idTextEdit);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.nameTextEdit);
            this.panelControl1.Controls.Add(bankIdLabel);
            this.panelControl1.Controls.Add(this.bankIdLookUpEdit);
            this.panelControl1.Controls.Add(interestRatesLabel);
            this.panelControl1.Controls.Add(this.interestRatesTextEdit);
            this.panelControl1.Controls.Add(timeLimitLabel);
            this.panelControl1.Controls.Add(this.timeLimitTextEdit);
            this.panelControl1.Controls.Add(minPersonalIncomeLabel);
            this.panelControl1.Controls.Add(paymentMethodIdLabel);
            this.panelControl1.Controls.Add(this.paymentMethodIdLookUpEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1585, 167);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.spinEdit1);
            this.groupControl1.Controls.Add(this.spinEditMinPriceFound);
            this.groupControl1.Controls.Add(minimumLabel);
            this.groupControl1.Controls.Add(maximumLabel);
            this.groupControl1.Location = new System.Drawing.Point(53, 89);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(505, 68);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Số tiền có thể vay";
            // 
            // bankLendingBindingSource
            // 
            this.bankLendingBindingSource.DataMember = "BankLending";
            this.bankLendingBindingSource.DataSource = this.dBFinancial;
            // 
            // dBFinancial
            // 
            this.dBFinancial.DataSetName = "DBFinancial";
            this.dBFinancial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankLendingBindingSource, "Id", true));
            this.idTextEdit.Location = new System.Drawing.Point(165, 21);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Properties.ReadOnly = true;
            this.idTextEdit.Size = new System.Drawing.Size(100, 20);
            this.idTextEdit.TabIndex = 1;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankLendingBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(426, 21);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(821, 20);
            this.nameTextEdit.TabIndex = 3;
            // 
            // bankIdLookUpEdit
            // 
            this.bankIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankLendingBindingSource, "BankId", true));
            this.bankIdLookUpEdit.Location = new System.Drawing.Point(165, 57);
            this.bankIdLookUpEdit.Name = "bankIdLookUpEdit";
            this.bankIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bankIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankName", "Ngân hàng")});
            this.bankIdLookUpEdit.Properties.DataSource = this.bankBindingSource;
            this.bankIdLookUpEdit.Properties.DisplayMember = "BankName";
            this.bankIdLookUpEdit.Properties.ValueMember = "BankId";
            this.bankIdLookUpEdit.Size = new System.Drawing.Size(220, 20);
            this.bankIdLookUpEdit.TabIndex = 5;
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataMember = "Bank";
            this.bankBindingSource.DataSource = this.dBFinancial;
            // 
            // interestRatesTextEdit
            // 
            this.interestRatesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankLendingBindingSource, "InterestRates", true));
            this.interestRatesTextEdit.EditValue = "0";
            this.interestRatesTextEdit.Location = new System.Drawing.Point(478, 57);
            this.interestRatesTextEdit.Name = "interestRatesTextEdit";
            this.interestRatesTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRatesTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.interestRatesTextEdit.Properties.Appearance.Options.UseFont = true;
            this.interestRatesTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.interestRatesTextEdit.Properties.Mask.EditMask = "n00";
            this.interestRatesTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.interestRatesTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.interestRatesTextEdit.Size = new System.Drawing.Size(100, 22);
            this.interestRatesTextEdit.TabIndex = 7;
            // 
            // timeLimitTextEdit
            // 
            this.timeLimitTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankLendingBindingSource, "TimeLimit", true));
            this.timeLimitTextEdit.EditValue = "0";
            this.timeLimitTextEdit.Location = new System.Drawing.Point(775, 57);
            this.timeLimitTextEdit.Name = "timeLimitTextEdit";
            this.timeLimitTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLimitTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.timeLimitTextEdit.Properties.Appearance.Options.UseFont = true;
            this.timeLimitTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.timeLimitTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timeLimitTextEdit.Size = new System.Drawing.Size(100, 22);
            this.timeLimitTextEdit.TabIndex = 13;
            // 
            // paymentMethodIdLookUpEdit
            // 
            this.paymentMethodIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankLendingBindingSource, "PaymentMethodId", true));
            this.paymentMethodIdLookUpEdit.Location = new System.Drawing.Point(1058, 102);
            this.paymentMethodIdLookUpEdit.Name = "paymentMethodIdLookUpEdit";
            this.paymentMethodIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paymentMethodIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentMethodName", "Hình thức trả khoản vay")});
            this.paymentMethodIdLookUpEdit.Properties.DataSource = this.paymentMethodBindingSource;
            this.paymentMethodIdLookUpEdit.Properties.DisplayMember = "PaymentMethodName";
            this.paymentMethodIdLookUpEdit.Properties.ValueMember = "PaymentMethodId";
            this.paymentMethodIdLookUpEdit.Size = new System.Drawing.Size(189, 20);
            this.paymentMethodIdLookUpEdit.TabIndex = 17;
            // 
            // paymentMethodBindingSource
            // 
            this.paymentMethodBindingSource.DataMember = "PaymentMethod";
            this.paymentMethodBindingSource.DataSource = this.dBFinancial;
            // 
            // bankLendingTableAdapter
            // 
            this.bankLendingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankLendingTableAdapter = this.bankLendingTableAdapter;
            this.tableAdapterManager.BankTableAdapter = this.bankTableAdapter;
            this.tableAdapterManager.PaymentMethodTableAdapter = this.paymentMethodTableAdapter;
            this.tableAdapterManager.UpdateOrder = WSS.Financial.DBFinancialTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bankTableAdapter
            // 
            this.bankTableAdapter.ClearBeforeFill = true;
            // 
            // paymentMethodTableAdapter
            // 
            this.paymentMethodTableAdapter.ClearBeforeFill = true;
            // 
            // bankLendingBindingNavigator
            // 
            this.bankLendingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bankLendingBindingNavigator.BindingSource = this.bankLendingBindingSource;
            this.bankLendingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bankLendingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bankLendingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bankLendingBindingNavigatorSaveItem});
            this.bankLendingBindingNavigator.Location = new System.Drawing.Point(0, 167);
            this.bankLendingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bankLendingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bankLendingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bankLendingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bankLendingBindingNavigator.Name = "bankLendingBindingNavigator";
            this.bankLendingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bankLendingBindingNavigator.Size = new System.Drawing.Size(1585, 25);
            this.bankLendingBindingNavigator.TabIndex = 1;
            this.bankLendingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bankLendingBindingNavigatorSaveItem
            // 
            this.bankLendingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bankLendingBindingNavigatorSaveItem.Image")));
            this.bankLendingBindingNavigatorSaveItem.Name = "bankLendingBindingNavigatorSaveItem";
            this.bankLendingBindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 22);
            this.bankLendingBindingNavigatorSaveItem.Text = "Save";
            this.bankLendingBindingNavigatorSaveItem.Click += new System.EventHandler(this.bankLendingBindingNavigatorSaveItem_Click);
            // 
            // bankLendingGridControl
            // 
            this.bankLendingGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.bankLendingGridControl.DataSource = this.bankLendingBindingSource;
            this.bankLendingGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankLendingGridControl.Location = new System.Drawing.Point(0, 192);
            this.bankLendingGridControl.MainView = this.gridView1;
            this.bankLendingGridControl.Name = "bankLendingGridControl";
            this.bankLendingGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEditBank,
            this.repositoryItemLookUpEditPaymentMethod});
            this.bankLendingGridControl.Size = new System.Drawing.Size(1585, 572);
            this.bankLendingGridControl.TabIndex = 2;
            this.bankLendingGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colBankId,
            this.colInterestRates,
            this.colMinimum,
            this.colMaximum,
            this.colTimeLimit,
            this.colMinPersonalIncome,
            this.colPaymentMethodId});
            this.gridView1.GridControl = this.bankLendingGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 72;
            // 
            // colName
            // 
            this.colName.Caption = "Tên gói vay tín dụng";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 701;
            // 
            // colBankId
            // 
            this.colBankId.Caption = "Ngân hàng";
            this.colBankId.ColumnEdit = this.repositoryItemLookUpEditBank;
            this.colBankId.FieldName = "BankId";
            this.colBankId.Name = "colBankId";
            this.colBankId.Visible = true;
            this.colBankId.VisibleIndex = 1;
            this.colBankId.Width = 112;
            // 
            // repositoryItemLookUpEditBank
            // 
            this.repositoryItemLookUpEditBank.AutoHeight = false;
            this.repositoryItemLookUpEditBank.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditBank.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankName", "Ngân hàng")});
            this.repositoryItemLookUpEditBank.DataSource = this.bankBindingSource;
            this.repositoryItemLookUpEditBank.DisplayMember = "BankName";
            this.repositoryItemLookUpEditBank.Name = "repositoryItemLookUpEditBank";
            this.repositoryItemLookUpEditBank.ValueMember = "BankId";
            // 
            // colInterestRates
            // 
            this.colInterestRates.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colInterestRates.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colInterestRates.AppearanceCell.Options.UseFont = true;
            this.colInterestRates.AppearanceCell.Options.UseForeColor = true;
            this.colInterestRates.Caption = "Lãi suất(%)";
            this.colInterestRates.FieldName = "InterestRates";
            this.colInterestRates.Name = "colInterestRates";
            this.colInterestRates.Visible = true;
            this.colInterestRates.VisibleIndex = 3;
            this.colInterestRates.Width = 68;
            // 
            // colMinimum
            // 
            this.colMinimum.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMinimum.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colMinimum.AppearanceCell.Options.UseFont = true;
            this.colMinimum.AppearanceCell.Options.UseForeColor = true;
            this.colMinimum.Caption = "Khoảng vay (nhỏ nhất)";
            this.colMinimum.DisplayFormat.FormatString = "n00";
            this.colMinimum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMinimum.FieldName = "Minimum";
            this.colMinimum.Name = "colMinimum";
            this.colMinimum.Visible = true;
            this.colMinimum.VisibleIndex = 4;
            this.colMinimum.Width = 122;
            // 
            // colMaximum
            // 
            this.colMaximum.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaximum.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colMaximum.AppearanceCell.Options.UseFont = true;
            this.colMaximum.AppearanceCell.Options.UseForeColor = true;
            this.colMaximum.Caption = "Khoảng vay (lớn nhất)";
            this.colMaximum.DisplayFormat.FormatString = "n00";
            this.colMaximum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMaximum.FieldName = "Maximum";
            this.colMaximum.Name = "colMaximum";
            this.colMaximum.Visible = true;
            this.colMaximum.VisibleIndex = 5;
            this.colMaximum.Width = 118;
            // 
            // colTimeLimit
            // 
            this.colTimeLimit.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTimeLimit.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colTimeLimit.AppearanceCell.Options.UseFont = true;
            this.colTimeLimit.AppearanceCell.Options.UseForeColor = true;
            this.colTimeLimit.Caption = "Thời hạn vay (tháng)";
            this.colTimeLimit.FieldName = "TimeLimit";
            this.colTimeLimit.Name = "colTimeLimit";
            this.colTimeLimit.Visible = true;
            this.colTimeLimit.VisibleIndex = 6;
            this.colTimeLimit.Width = 109;
            // 
            // colMinPersonalIncome
            // 
            this.colMinPersonalIncome.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMinPersonalIncome.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colMinPersonalIncome.AppearanceCell.Options.UseFont = true;
            this.colMinPersonalIncome.AppearanceCell.Options.UseForeColor = true;
            this.colMinPersonalIncome.Caption = "Thu nhập tối thiểu";
            this.colMinPersonalIncome.DisplayFormat.FormatString = "n00";
            this.colMinPersonalIncome.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMinPersonalIncome.FieldName = "MinPersonalIncome";
            this.colMinPersonalIncome.Name = "colMinPersonalIncome";
            this.colMinPersonalIncome.Visible = true;
            this.colMinPersonalIncome.VisibleIndex = 7;
            this.colMinPersonalIncome.Width = 96;
            // 
            // colPaymentMethodId
            // 
            this.colPaymentMethodId.Caption = "Phương thức thanh toán";
            this.colPaymentMethodId.ColumnEdit = this.repositoryItemLookUpEditPaymentMethod;
            this.colPaymentMethodId.FieldName = "PaymentMethodId";
            this.colPaymentMethodId.Name = "colPaymentMethodId";
            this.colPaymentMethodId.Visible = true;
            this.colPaymentMethodId.VisibleIndex = 8;
            this.colPaymentMethodId.Width = 169;
            // 
            // repositoryItemLookUpEditPaymentMethod
            // 
            this.repositoryItemLookUpEditPaymentMethod.AutoHeight = false;
            this.repositoryItemLookUpEditPaymentMethod.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEditPaymentMethod.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentMethodName", "Phương thức")});
            this.repositoryItemLookUpEditPaymentMethod.DataSource = this.paymentMethodBindingSource;
            this.repositoryItemLookUpEditPaymentMethod.DisplayMember = "PaymentMethodName";
            this.repositoryItemLookUpEditPaymentMethod.Name = "repositoryItemLookUpEditPaymentMethod";
            this.repositoryItemLookUpEditPaymentMethod.ValueMember = "PaymentMethodId";
            // 
            // spinEditMinPriceFound
            // 
            this.spinEditMinPriceFound.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankLendingBindingSource, "Minimum", true));
            this.spinEditMinPriceFound.EditValue = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.spinEditMinPriceFound.Location = new System.Drawing.Point(47, 28);
            this.spinEditMinPriceFound.Name = "spinEditMinPriceFound";
            this.spinEditMinPriceFound.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEditMinPriceFound.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.spinEditMinPriceFound.Properties.Appearance.Options.UseFont = true;
            this.spinEditMinPriceFound.Properties.Appearance.Options.UseForeColor = true;
            this.spinEditMinPriceFound.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.spinEditMinPriceFound.Properties.DisplayFormat.FormatString = "n00";
            this.spinEditMinPriceFound.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditMinPriceFound.Properties.Mask.EditMask = "n00";
            this.spinEditMinPriceFound.Size = new System.Drawing.Size(165, 22);
            this.spinEditMinPriceFound.TabIndex = 37;
            // 
            // spinEdit1
            // 
            this.spinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankLendingBindingSource, "Maximum", true));
            this.spinEdit1.EditValue = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(310, 28);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.spinEdit1.Properties.DisplayFormat.FormatString = "n00";
            this.spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit1.Properties.Mask.EditMask = "n00";
            this.spinEdit1.Size = new System.Drawing.Size(177, 22);
            this.spinEdit1.TabIndex = 38;
            // 
            // spinEdit2
            // 
            this.spinEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bankLendingBindingSource, "MinPersonalIncome", true));
            this.spinEdit2.EditValue = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(685, 101);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.spinEdit2.Properties.Appearance.Options.UseFont = true;
            this.spinEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.spinEdit2.Properties.DisplayFormat.FormatString = "n00";
            this.spinEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEdit2.Properties.Mask.EditMask = "n00";
            this.spinEdit2.Size = new System.Drawing.Size(165, 22);
            this.spinEdit2.TabIndex = 38;
            // 
            // FrmBankLendingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 764);
            this.Controls.Add(this.bankLendingGridControl);
            this.Controls.Add(this.bankLendingBindingNavigator);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmBankLendingManager";
            this.Text = "FrmBankBlendingManager";
            this.Load += new System.EventHandler(this.FrmBankBlendingManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankLendingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRatesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankLendingBindingNavigator)).EndInit();
            this.bankLendingBindingNavigator.ResumeLayout(false);
            this.bankLendingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankLendingGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEditPaymentMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMinPriceFound.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DBFinancial dBFinancial;
        private System.Windows.Forms.BindingSource bankLendingBindingSource;
        private DBFinancialTableAdapters.BankLendingTableAdapter bankLendingTableAdapter;
        private DBFinancialTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bankLendingBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bankLendingBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit bankIdLookUpEdit;
        private DevExpress.XtraEditors.TextEdit interestRatesTextEdit;
        private DevExpress.XtraEditors.TextEdit timeLimitTextEdit;
        private DevExpress.XtraEditors.LookUpEdit paymentMethodIdLookUpEdit;
        private DevExpress.XtraGrid.GridControl bankLendingGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankId;
        private DevExpress.XtraGrid.Columns.GridColumn colInterestRates;
        private DevExpress.XtraGrid.Columns.GridColumn colMinimum;
        private DevExpress.XtraGrid.Columns.GridColumn colMaximum;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colMinPersonalIncome;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethodId;
        private DBFinancialTableAdapters.PaymentMethodTableAdapter paymentMethodTableAdapter;
        private System.Windows.Forms.BindingSource paymentMethodBindingSource;
        private DBFinancialTableAdapters.BankTableAdapter bankTableAdapter;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditBank;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEditPaymentMethod;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.SpinEdit spinEditMinPriceFound;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;

    }
}