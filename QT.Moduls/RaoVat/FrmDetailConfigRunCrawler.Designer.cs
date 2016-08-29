namespace QT.Moduls.RaoVat
{
    partial class FrmDetailConfigRunCrawler
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label config_idLabel;
            System.Windows.Forms.Label rootlinkLabel;
            System.Windows.Forms.Label number_threadLabel;
            System.Windows.Forms.Label second_sleep_recrawlerLabel;
            System.Windows.Forms.Label type_crawlerLabel;
            System.Windows.Forms.Label is_find_newLabel;
            System.Windows.Forms.Label is_reload_itemLabel;
            this.idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.config_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.rootlinkTextBox = new System.Windows.Forms.TextBox();
            this.number_threadSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.second_sleep_recrawlerSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.type_crawlerSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.is_find_newCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.is_reload_itemCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.config_run_crawlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crawlerSaleNew = new QT.Moduls.RaoVat.CrawlerSaleNew();
            this.config_run_crawlerTableAdapter = new QT.Moduls.RaoVat.CrawlerSaleNewTableAdapters.config_run_crawlerTableAdapter();
            this.tableAdapterManager = new QT.Moduls.RaoVat.CrawlerSaleNewTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            config_idLabel = new System.Windows.Forms.Label();
            rootlinkLabel = new System.Windows.Forms.Label();
            number_threadLabel = new System.Windows.Forms.Label();
            second_sleep_recrawlerLabel = new System.Windows.Forms.Label();
            type_crawlerLabel = new System.Windows.Forms.Label();
            is_find_newLabel = new System.Windows.Forms.Label();
            is_reload_itemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_threadSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_sleep_recrawlerSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_crawlerSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_find_newCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_reload_itemCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_run_crawlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerSaleNew)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(26, 35);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // config_idLabel
            // 
            config_idLabel.AutoSize = true;
            config_idLabel.Location = new System.Drawing.Point(26, 61);
            config_idLabel.Name = "config_idLabel";
            config_idLabel.Size = new System.Drawing.Size(50, 13);
            config_idLabel.TabIndex = 3;
            config_idLabel.Text = "config id:";
            // 
            // rootlinkLabel
            // 
            rootlinkLabel.AutoSize = true;
            rootlinkLabel.Location = new System.Drawing.Point(26, 153);
            rootlinkLabel.Name = "rootlinkLabel";
            rootlinkLabel.Size = new System.Drawing.Size(44, 13);
            rootlinkLabel.TabIndex = 5;
            rootlinkLabel.Text = "rootlink:";
            // 
            // number_threadLabel
            // 
            number_threadLabel.AutoSize = true;
            number_threadLabel.Location = new System.Drawing.Point(26, 87);
            number_threadLabel.Name = "number_threadLabel";
            number_threadLabel.Size = new System.Drawing.Size(78, 13);
            number_threadLabel.TabIndex = 7;
            number_threadLabel.Text = "number thread:";
            // 
            // second_sleep_recrawlerLabel
            // 
            second_sleep_recrawlerLabel.AutoSize = true;
            second_sleep_recrawlerLabel.Location = new System.Drawing.Point(342, 31);
            second_sleep_recrawlerLabel.Name = "second_sleep_recrawlerLabel";
            second_sleep_recrawlerLabel.Size = new System.Drawing.Size(119, 13);
            second_sleep_recrawlerLabel.TabIndex = 9;
            second_sleep_recrawlerLabel.Text = "second sleep recrawler:";
            // 
            // type_crawlerLabel
            // 
            type_crawlerLabel.AutoSize = true;
            type_crawlerLabel.Location = new System.Drawing.Point(342, 57);
            type_crawlerLabel.Name = "type_crawlerLabel";
            type_crawlerLabel.Size = new System.Drawing.Size(67, 13);
            type_crawlerLabel.TabIndex = 11;
            type_crawlerLabel.Text = "type crawler:";
            // 
            // is_find_newLabel
            // 
            is_find_newLabel.AutoSize = true;
            is_find_newLabel.Location = new System.Drawing.Point(342, 83);
            is_find_newLabel.Name = "is_find_newLabel";
            is_find_newLabel.Size = new System.Drawing.Size(60, 13);
            is_find_newLabel.TabIndex = 13;
            is_find_newLabel.Text = "is find new:";
            // 
            // is_reload_itemLabel
            // 
            is_reload_itemLabel.AutoSize = true;
            is_reload_itemLabel.Location = new System.Drawing.Point(342, 108);
            is_reload_itemLabel.Name = "is_reload_itemLabel";
            is_reload_itemLabel.Size = new System.Drawing.Size(71, 13);
            is_reload_itemLabel.TabIndex = 15;
            is_reload_itemLabel.Text = "is reload item:";
            // 
            // idSpinEdit
            // 
            this.idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "id", true));
            this.idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idSpinEdit.Location = new System.Drawing.Point(151, 32);
            this.idSpinEdit.Name = "idSpinEdit";
            this.idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.idSpinEdit.TabIndex = 2;
            // 
            // config_idSpinEdit
            // 
            this.config_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "config_id", true));
            this.config_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.config_idSpinEdit.Location = new System.Drawing.Point(151, 58);
            this.config_idSpinEdit.Name = "config_idSpinEdit";
            this.config_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.config_idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.config_idSpinEdit.TabIndex = 4;
            // 
            // rootlinkTextBox
            // 
            this.rootlinkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.config_run_crawlerBindingSource, "rootlink", true));
            this.rootlinkTextBox.Location = new System.Drawing.Point(76, 150);
            this.rootlinkTextBox.Multiline = true;
            this.rootlinkTextBox.Name = "rootlinkTextBox";
            this.rootlinkTextBox.Size = new System.Drawing.Size(491, 241);
            this.rootlinkTextBox.TabIndex = 6;
            // 
            // number_threadSpinEdit
            // 
            this.number_threadSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "number_thread", true));
            this.number_threadSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.number_threadSpinEdit.Location = new System.Drawing.Point(151, 84);
            this.number_threadSpinEdit.Name = "number_threadSpinEdit";
            this.number_threadSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.number_threadSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.number_threadSpinEdit.TabIndex = 8;
            // 
            // second_sleep_recrawlerSpinEdit
            // 
            this.second_sleep_recrawlerSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "second_sleep_recrawler", true));
            this.second_sleep_recrawlerSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.second_sleep_recrawlerSpinEdit.Location = new System.Drawing.Point(467, 28);
            this.second_sleep_recrawlerSpinEdit.Name = "second_sleep_recrawlerSpinEdit";
            this.second_sleep_recrawlerSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.second_sleep_recrawlerSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.second_sleep_recrawlerSpinEdit.TabIndex = 10;
            // 
            // type_crawlerSpinEdit
            // 
            this.type_crawlerSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "type_crawler", true));
            this.type_crawlerSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.type_crawlerSpinEdit.Location = new System.Drawing.Point(467, 54);
            this.type_crawlerSpinEdit.Name = "type_crawlerSpinEdit";
            this.type_crawlerSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type_crawlerSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.type_crawlerSpinEdit.TabIndex = 12;
            // 
            // is_find_newCheckEdit
            // 
            this.is_find_newCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "is_find_new", true));
            this.is_find_newCheckEdit.Location = new System.Drawing.Point(467, 80);
            this.is_find_newCheckEdit.Name = "is_find_newCheckEdit";
            this.is_find_newCheckEdit.Properties.Caption = "checkEdit1";
            this.is_find_newCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.is_find_newCheckEdit.TabIndex = 14;
            // 
            // is_reload_itemCheckEdit
            // 
            this.is_reload_itemCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.config_run_crawlerBindingSource, "is_reload_item", true));
            this.is_reload_itemCheckEdit.Location = new System.Drawing.Point(467, 105);
            this.is_reload_itemCheckEdit.Name = "is_reload_itemCheckEdit";
            this.is_reload_itemCheckEdit.Properties.Caption = "checkEdit1";
            this.is_reload_itemCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.is_reload_itemCheckEdit.TabIndex = 16;
            // 
            // config_run_crawlerBindingSource
            // 
            this.config_run_crawlerBindingSource.DataMember = "config_run_crawler";
            this.config_run_crawlerBindingSource.DataSource = this.crawlerSaleNew;
            // 
            // crawlerSaleNew
            // 
            this.crawlerSaleNew.DataSetName = "CrawlerSaleNew";
            this.crawlerSaleNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // config_run_crawlerTableAdapter
            // 
            this.config_run_crawlerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.config_run_crawlerTableAdapter = this.config_run_crawlerTableAdapter;
            this.tableAdapterManager.RegexFindKeyWordTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.RaoVat.CrawlerSaleNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WebSiteTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDetailConfigRunCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idSpinEdit);
            this.Controls.Add(config_idLabel);
            this.Controls.Add(this.config_idSpinEdit);
            this.Controls.Add(rootlinkLabel);
            this.Controls.Add(this.rootlinkTextBox);
            this.Controls.Add(number_threadLabel);
            this.Controls.Add(this.number_threadSpinEdit);
            this.Controls.Add(second_sleep_recrawlerLabel);
            this.Controls.Add(this.second_sleep_recrawlerSpinEdit);
            this.Controls.Add(type_crawlerLabel);
            this.Controls.Add(this.type_crawlerSpinEdit);
            this.Controls.Add(is_find_newLabel);
            this.Controls.Add(this.is_find_newCheckEdit);
            this.Controls.Add(is_reload_itemLabel);
            this.Controls.Add(this.is_reload_itemCheckEdit);
            this.Name = "FrmDetailConfigRunCrawler";
            this.Text = "FrmDetailConfigRunCrawler";
            this.Load += new System.EventHandler(this.FrmDetailConfigRunCrawler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_threadSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_sleep_recrawlerSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_crawlerSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_find_newCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.is_reload_itemCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_run_crawlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerSaleNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrawlerSaleNew crawlerSaleNew;
        private System.Windows.Forms.BindingSource config_run_crawlerBindingSource;
        private CrawlerSaleNewTableAdapters.config_run_crawlerTableAdapter config_run_crawlerTableAdapter;
        private CrawlerSaleNewTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SpinEdit idSpinEdit;
        private DevExpress.XtraEditors.SpinEdit config_idSpinEdit;
        private System.Windows.Forms.TextBox rootlinkTextBox;
        private DevExpress.XtraEditors.SpinEdit number_threadSpinEdit;
        private DevExpress.XtraEditors.SpinEdit second_sleep_recrawlerSpinEdit;
        private DevExpress.XtraEditors.SpinEdit type_crawlerSpinEdit;
        private DevExpress.XtraEditors.CheckEdit is_find_newCheckEdit;
        private DevExpress.XtraEditors.CheckEdit is_reload_itemCheckEdit;
        private System.Windows.Forms.Button button1;
    }
}