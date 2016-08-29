namespace QT.Moduls.Tool
{
    partial class frmWeb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeb));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btBack = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btStop = new System.Windows.Forms.Button();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(1, 34);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(680, 306);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(1, 0);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(38, 28);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "<";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(39, 0);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(38, 28);
            this.btNext.TabIndex = 2;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btLoad
            // 
            this.btLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLoad.ImageIndex = 0;
            this.btLoad.ImageList = this.imageList1;
            this.btLoad.Location = new System.Drawing.Point(642, 2);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(38, 28);
            this.btLoad.TabIndex = 2;
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Refresh.png");
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(79, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(307, 20);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // btStop
            // 
            this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStop.ImageIndex = 0;
            this.btStop.Location = new System.Drawing.Point(604, 2);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(38, 28);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "X";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.progressBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl1.Location = new System.Drawing.Point(392, 6);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.progressBarControl1.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progressBarControl1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.progressBarControl1.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.progressBarControl1.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.progressBarControl1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.progressBarControl1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.progressBarControl1.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progressBarControl1.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.progressBarControl1.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.progressBarControl1.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.progressBarControl1.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.progressBarControl1.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.progressBarControl1.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progressBarControl1.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.progressBarControl1.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.progressBarControl1.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.progressBarControl1.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.progressBarControl1.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.progressBarControl1.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progressBarControl1.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.progressBarControl1.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.progressBarControl1.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.progressBarControl1.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.progressBarControl1.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.progressBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.progressBarControl1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.progressBarControl1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.progressBarControl1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.progressBarControl1.Properties.ProgressKind = DevExpress.XtraEditors.Controls.ProgressKind.Horizontal;
            this.progressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Broken;
            this.progressBarControl1.Size = new System.Drawing.Size(130, 18);
            this.progressBarControl1.TabIndex = 4;
            this.progressBarControl1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // checkEdit1
            // 
            this.checkEdit1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.checkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit1.Location = new System.Drawing.Point(526, 7);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.checkEdit1.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.checkEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkEdit1.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.checkEdit1.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.checkEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.checkEdit1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.checkEdit1.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.checkEdit1.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkEdit1.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.checkEdit1.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.checkEdit1.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.checkEdit1.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.checkEdit1.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.checkEdit1.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkEdit1.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.checkEdit1.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.checkEdit1.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.checkEdit1.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.checkEdit1.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.checkEdit1.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkEdit1.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.checkEdit1.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.checkEdit1.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.checkEdit1.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.checkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.checkEdit1.Properties.Caption = "AutoRefresh";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Standard;
            this.checkEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.checkEdit1.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.checkEdit1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.checkEdit1.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.InactiveChecked;
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 5;
            this.checkEdit1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(681, 339);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.webBrowser1);
            this.Name = "frmWeb";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btStop;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.Timer timer1;
    }
}
