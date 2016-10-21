namespace WSS.Financial
{
    partial class Main
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemBrandManager = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCategoryManager = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPropertyGroup = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPropertyByCategory = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPropertyValue = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ctrBrand1 = new WSS.Financial.Brand.ctrBrand();
            this.barSubItemVayTinDung = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemBankLending = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemBankBlending = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItemVayTinDung,
            this.barButtonItemBankLending,
            this.barSubItem1,
            this.barButtonItemBankBlending,
            this.barSubItem2,
            this.barButtonItemPropertyGroup,
            this.barButtonItemCategoryManager,
            this.barButtonItemPropertyByCategory,
            this.barButtonItemPropertyValue,
            this.barButtonItemBrandManager});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 14;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Tool";
            this.barSubItem2.Id = 4;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemBrandManager),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCategoryManager),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPropertyGroup),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPropertyByCategory),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPropertyValue)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItemBrandManager
            // 
            this.barButtonItemBrandManager.Caption = "Quản lý Brand";
            this.barButtonItemBrandManager.Id = 13;
            this.barButtonItemBrandManager.Name = "barButtonItemBrandManager";
            this.barButtonItemBrandManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemBrandManager_ItemClick);
            // 
            // barButtonItemCategoryManager
            // 
            this.barButtonItemCategoryManager.Caption = "Quản lý Category";
            this.barButtonItemCategoryManager.Id = 10;
            this.barButtonItemCategoryManager.Name = "barButtonItemCategoryManager";
            this.barButtonItemCategoryManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemCategoryManager_ItemClick);
            // 
            // barButtonItemPropertyGroup
            // 
            this.barButtonItemPropertyGroup.Caption = "Nhập thuộc tính chung (PropertyGroup)";
            this.barButtonItemPropertyGroup.Id = 5;
            this.barButtonItemPropertyGroup.Name = "barButtonItemPropertyGroup";
            this.barButtonItemPropertyGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPaymentMethod_ItemClick);
            // 
            // barButtonItemPropertyByCategory
            // 
            this.barButtonItemPropertyByCategory.Caption = "Quản lý các thuộc tính theo category";
            this.barButtonItemPropertyByCategory.Id = 11;
            this.barButtonItemPropertyByCategory.Name = "barButtonItemPropertyByCategory";
            this.barButtonItemPropertyByCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPropertyByCategory_ItemClick);
            // 
            // barButtonItemPropertyValue
            // 
            this.barButtonItemPropertyValue.Caption = "Nhập giá trị thuộc tính (PropertyValue)";
            this.barButtonItemPropertyValue.Id = 12;
            this.barButtonItemPropertyValue.Name = "barButtonItemPropertyValue";
            this.barButtonItemPropertyValue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPropertyValue_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1448, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 697);
            this.barDockControlBottom.Size = new System.Drawing.Size(1448, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 675);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1448, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 675);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("bc46edda-9530-41b6-8d80-35602044dddd");
            this.dockPanel1.Location = new System.Drawing.Point(0, 22);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(435, 200);
            this.dockPanel1.Size = new System.Drawing.Size(435, 675);
            this.dockPanel1.Text = "Danh sách Brand";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.ctrBrand1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(427, 648);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ctrBrand1
            // 
            this.ctrBrand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrBrand1.Location = new System.Drawing.Point(0, 0);
            this.ctrBrand1.Name = "ctrBrand1";
            this.ctrBrand1.Size = new System.Drawing.Size(427, 648);
            this.ctrBrand1.TabIndex = 0;
            this.ctrBrand1.ExcuteCommand += new WSS.Financial.Brand.ctrBrand.ChangedEventHandler(this.ctrBrand1_ExcuteCommand);
            // 
            // barSubItemVayTinDung
            // 
            this.barSubItemVayTinDung.Id = 6;
            this.barSubItemVayTinDung.Name = "barSubItemVayTinDung";
            // 
            // barButtonItemBankLending
            // 
            this.barButtonItemBankLending.Id = 7;
            this.barButtonItemBankLending.Name = "barButtonItemBankLending";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Id = 8;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItemBankBlending
            // 
            this.barButtonItemBankBlending.Id = 9;
            this.barButtonItemBankBlending.Name = "barButtonItemBankBlending";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 720);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống trang tài chính websosanh.vn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItemVayTinDung;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBankLending;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBankBlending;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPropertyGroup;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCategoryManager;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPropertyByCategory;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPropertyValue;
        private Brand.ctrBrand ctrBrand1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemBrandManager;
    }
}

