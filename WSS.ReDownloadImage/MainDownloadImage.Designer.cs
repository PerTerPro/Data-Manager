namespace WSS.ReDownloadImage
{
    partial class MainDownloadImage
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
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemSingle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemProcessAll = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemUpdateImagePath = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItemUpdateImagePathSingle = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItemSingle,
            this.barButtonItemProcessAll,
            this.barSubItem2,
            this.barButtonItemUpdateImagePath,
            this.barButtonItemUpdateImagePathSingle});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Action";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSingle),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemProcessAll)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItemSingle
            // 
            this.barButtonItemSingle.Caption = "Single";
            this.barButtonItemSingle.Id = 1;
            this.barButtonItemSingle.Name = "barButtonItemSingle";
            this.barButtonItemSingle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemSingle_ItemClick);
            // 
            // barButtonItemProcessAll
            // 
            this.barButtonItemProcessAll.Caption = "Process All";
            this.barButtonItemProcessAll.Id = 2;
            this.barButtonItemProcessAll.Name = "barButtonItemProcessAll";
            this.barButtonItemProcessAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemProcessAll_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Update";
            this.barSubItem2.Id = 3;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemUpdateImagePath),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemUpdateImagePathSingle)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItemUpdateImagePath
            // 
            this.barButtonItemUpdateImagePath.Caption = "Update ImagePath";
            this.barButtonItemUpdateImagePath.Id = 4;
            this.barButtonItemUpdateImagePath.Name = "barButtonItemUpdateImagePath";
            this.barButtonItemUpdateImagePath.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUpdateImagePath_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1266, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 685);
            this.barDockControlBottom.Size = new System.Drawing.Size(1266, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 663);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1266, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 663);
            // 
            // barButtonItemUpdateImagePathSingle
            // 
            this.barButtonItemUpdateImagePathSingle.Caption = "Single";
            this.barButtonItemUpdateImagePathSingle.Id = 5;
            this.barButtonItemUpdateImagePathSingle.Name = "barButtonItemUpdateImagePathSingle";
            this.barButtonItemUpdateImagePathSingle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemUpdateImagePathSingle_ItemClick);
            // 
            // MainDownloadImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 708);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "MainDownloadImage";
            this.Text = "MainDownloadImage";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
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
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSingle;
        private DevExpress.XtraBars.BarButtonItem barButtonItemProcessAll;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUpdateImagePath;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUpdateImagePathSingle;
    }
}