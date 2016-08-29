namespace QT.Moduls.News
{
    partial class frmGetContent
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
            this.btGetByMonth = new DevExpress.XtraEditors.SimpleButton();
            this.btInsert = new DevExpress.XtraEditors.SimpleButton();
            this.laMess1 = new System.Windows.Forms.Label();
            this.dateTimeSelect = new System.Windows.Forms.DateTimePicker();
            this.btGetByDay = new DevExpress.XtraEditors.SimpleButton();
            this.dBNew = new QT.Moduls.News.DBNew();
            this.tableAdapterManager = new QT.Moduls.News.DBNewTableAdapters.TableAdapterManager();
            this.newsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newsTableAdapter = new QT.Moduls.News.DBNewTableAdapters.NewsTableAdapter();
            this.newsPublishedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newsPublishedTableAdapter = new QT.Moduls.News.DBNewTableAdapters.NewsPublishedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dBNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsPublishedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btGetByMonth
            // 
            this.btGetByMonth.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btGetByMonth.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btGetByMonth.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btGetByMonth.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btGetByMonth.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btGetByMonth.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btGetByMonth.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btGetByMonth.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btGetByMonth.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btGetByMonth.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btGetByMonth.Location = new System.Drawing.Point(12, 27);
            this.btGetByMonth.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btGetByMonth.Name = "btGetByMonth";
            this.btGetByMonth.Size = new System.Drawing.Size(75, 23);
            this.btGetByMonth.TabIndex = 1;
            this.btGetByMonth.Text = "GetByMonth";
            this.btGetByMonth.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btGetByMonth.Click += new System.EventHandler(this.btGetByMonth_Click);
            // 
            // btInsert
            // 
            this.btInsert.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btInsert.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btInsert.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btInsert.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btInsert.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btInsert.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btInsert.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btInsert.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btInsert.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btInsert.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btInsert.Location = new System.Drawing.Point(371, 27);
            this.btInsert.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(75, 23);
            this.btInsert.TabIndex = 1;
            this.btInsert.Text = "InsertNews";
            this.btInsert.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // laMess1
            // 
            this.laMess1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laMess1.Location = new System.Drawing.Point(9, 62);
            this.laMess1.Name = "laMess1";
            this.laMess1.Size = new System.Drawing.Size(549, 90);
            this.laMess1.TabIndex = 3;
            this.laMess1.Text = "messger";
            // 
            // dateTimeSelect
            // 
            this.dateTimeSelect.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSelect.Location = new System.Drawing.Point(12, 1);
            this.dateTimeSelect.Name = "dateTimeSelect";
            this.dateTimeSelect.Size = new System.Drawing.Size(140, 20);
            this.dateTimeSelect.TabIndex = 5;
            // 
            // btGetByDay
            // 
            this.btGetByDay.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btGetByDay.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btGetByDay.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btGetByDay.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btGetByDay.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btGetByDay.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btGetByDay.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btGetByDay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btGetByDay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btGetByDay.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btGetByDay.Location = new System.Drawing.Point(93, 27);
            this.btGetByDay.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btGetByDay.Name = "btGetByDay";
            this.btGetByDay.Size = new System.Drawing.Size(75, 23);
            this.btGetByDay.TabIndex = 1;
            this.btGetByDay.Text = "GetByDay";
            this.btGetByDay.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btGetByDay.Click += new System.EventHandler(this.btGetByDay_Click);
            // 
            // dBNew
            // 
            this.dBNew.DataSetName = "DBNew";
            this.dBNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.KeywordMapTableAdapter = null;
            this.tableAdapterManager.NewsItemTableAdapter = null;
            this.tableAdapterManager.NewsPublishedTableAdapter = null;
            this.tableAdapterManager.NewsReviewTableAdapter = null;
            this.tableAdapterManager.NewsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.News.DBNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // newsBindingSource
            // 
            this.newsBindingSource.DataSource = this.dBNew;
            this.newsBindingSource.Position = 0;
            // 
            // newsTableAdapter
            // 
            this.newsTableAdapter.ClearBeforeFill = true;
            // 
            // newsPublishedBindingSource
            // 
            this.newsPublishedBindingSource.DataMember = "NewsPublished";
            this.newsPublishedBindingSource.DataSource = this.dBNew;
            // 
            // newsPublishedTableAdapter
            // 
            this.newsPublishedTableAdapter.ClearBeforeFill = true;
            // 
            // frmGetContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(681, 435);
            this.Controls.Add(this.dateTimeSelect);
            this.Controls.Add(this.laMess1);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btGetByDay);
            this.Controls.Add(this.btGetByMonth);
            this.Name = "frmGetContent";
            this.Load += new System.EventHandler(this.frmGetContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsPublishedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btGetByMonth;
        private DevExpress.XtraEditors.SimpleButton btInsert;
        private DBNew dBNew;
        private DBNewTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource newsBindingSource;
        private DBNewTableAdapters.NewsTableAdapter newsTableAdapter;
        private System.Windows.Forms.BindingSource newsPublishedBindingSource;
        private DBNewTableAdapters.NewsPublishedTableAdapter newsPublishedTableAdapter;
        private System.Windows.Forms.Label laMess1;
        private System.Windows.Forms.DateTimePicker dateTimeSelect;
        private DevExpress.XtraEditors.SimpleButton btGetByDay;
    }
}
