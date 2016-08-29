namespace QT.Moduls.Maps
{
    partial class frmSeoKeyWord
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label sapoLabel;
            System.Windows.Forms.Label keyLienQuanLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label keyNameLabel;
            System.Windows.Forms.Label sEOUpdateLabel;
            System.Windows.Forms.Label keyFreqLabel;
            System.Windows.Forms.Label keyClickLabel;
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.sapoTextBox = new System.Windows.Forms.TextBox();
            this.keyLienQuanTextBox = new System.Windows.Forms.TextBox();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.btView = new DevExpress.XtraEditors.SimpleButton();
            this.btClose = new DevExpress.XtraEditors.SimpleButton();
            this.keyNameLabel1 = new System.Windows.Forms.Label();
            this.lakey = new System.Windows.Forms.Label();
            this.lasapo = new System.Windows.Forms.Label();
            this.latitle = new System.Windows.Forms.Label();
            this.sEOUpdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btSaveClose = new DevExpress.XtraEditors.SimpleButton();
            this.keyFreqTextBox = new System.Windows.Forms.TextBox();
            this.keyClickTextBox = new System.Windows.Forms.TextBox();
            this.keywordsSeoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kW = new QT.Moduls.Data.KW();
            this.keywordsSeoTableAdapter = new QT.Moduls.Data.KWTableAdapters.KeywordsSeoTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Data.KWTableAdapters.TableAdapterManager();
            this.keywords_SeoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keywords_SeoTableAdapter = new QT.Moduls.Data.KWTableAdapters.Keywords_SeoTableAdapter();
            titleLabel = new System.Windows.Forms.Label();
            sapoLabel = new System.Windows.Forms.Label();
            keyLienQuanLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            keyNameLabel = new System.Windows.Forms.Label();
            sEOUpdateLabel = new System.Windows.Forms.Label();
            keyFreqLabel = new System.Windows.Forms.Label();
            keyClickLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsSeoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywords_SeoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(54, 37);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Title:";
            // 
            // sapoLabel
            // 
            sapoLabel.AutoSize = true;
            sapoLabel.Location = new System.Drawing.Point(49, 87);
            sapoLabel.Name = "sapoLabel";
            sapoLabel.Size = new System.Drawing.Size(35, 13);
            sapoLabel.TabIndex = 3;
            sapoLabel.Text = "Sapo:";
            // 
            // keyLienQuanLabel
            // 
            keyLienQuanLabel.AutoSize = true;
            keyLienQuanLabel.Location = new System.Drawing.Point(4, 180);
            keyLienQuanLabel.Name = "keyLienQuanLabel";
            keyLienQuanLabel.Size = new System.Drawing.Size(80, 13);
            keyLienQuanLabel.TabIndex = 5;
            keyLienQuanLabel.Text = "Key Lien Quan:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(87, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 13);
            label1.TabIndex = 1;
            label1.Text = "Không nhập quá 75 ký tự";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(87, 149);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 13);
            label2.TabIndex = 1;
            label2.Text = "Không nhập quá 160 ký tự";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(87, 247);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(285, 13);
            label3.TabIndex = 1;
            label3.Text = "Từ 3 cụm từ khóa trở lên Mỗi cụm từ cách nhau dấu phẩy, ";
            // 
            // keyNameLabel
            // 
            keyNameLabel.AutoSize = true;
            keyNameLabel.Location = new System.Drawing.Point(22, 8);
            keyNameLabel.Name = "keyNameLabel";
            keyNameLabel.Size = new System.Drawing.Size(59, 13);
            keyNameLabel.TabIndex = 12;
            keyNameLabel.Text = "Key Name:";
            // 
            // sEOUpdateLabel
            // 
            sEOUpdateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sEOUpdateLabel.AutoSize = true;
            sEOUpdateLabel.Location = new System.Drawing.Point(427, 11);
            sEOUpdateLabel.Name = "sEOUpdateLabel";
            sEOUpdateLabel.Size = new System.Drawing.Size(67, 13);
            sEOUpdateLabel.TabIndex = 25;
            sEOUpdateLabel.Text = "SEOUpdate:";
            // 
            // keyFreqLabel
            // 
            keyFreqLabel.AutoSize = true;
            keyFreqLabel.Location = new System.Drawing.Point(4, 271);
            keyFreqLabel.Name = "keyFreqLabel";
            keyFreqLabel.Size = new System.Drawing.Size(170, 13);
            keyFreqLabel.TabIndex = 26;
            keyFreqLabel.Text = "Số kết quả tìm thấy trong hệ thống";
            // 
            // keyClickLabel
            // 
            keyClickLabel.AutoSize = true;
            keyClickLabel.Location = new System.Drawing.Point(290, 271);
            keyClickLabel.Name = "keyClickLabel";
            keyClickLabel.Size = new System.Drawing.Size(123, 13);
            keyClickLabel.TabIndex = 27;
            keyClickLabel.Text = "Google click trong tháng";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsSeoBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(90, 34);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(548, 20);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // sapoTextBox
            // 
            this.sapoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sapoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsSeoBindingSource, "Sapo", true));
            this.sapoTextBox.Location = new System.Drawing.Point(90, 84);
            this.sapoTextBox.Multiline = true;
            this.sapoTextBox.Name = "sapoTextBox";
            this.sapoTextBox.Size = new System.Drawing.Size(548, 62);
            this.sapoTextBox.TabIndex = 4;
            this.sapoTextBox.TextChanged += new System.EventHandler(this.sapoTextBox_TextChanged);
            // 
            // keyLienQuanTextBox
            // 
            this.keyLienQuanTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyLienQuanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsSeoBindingSource, "KeyLienQuan", true));
            this.keyLienQuanTextBox.Location = new System.Drawing.Point(90, 177);
            this.keyLienQuanTextBox.Multiline = true;
            this.keyLienQuanTextBox.Name = "keyLienQuanTextBox";
            this.keyLienQuanTextBox.Size = new System.Drawing.Size(548, 67);
            this.keyLienQuanTextBox.TabIndex = 6;
            this.keyLienQuanTextBox.TextChanged += new System.EventHandler(this.keyLienQuanTextBox_TextChanged);
            // 
            // btSave
            // 
            this.btSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSave.Location = new System.Drawing.Point(166, 295);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "&Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btView
            // 
            this.btView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btView.Location = new System.Drawing.Point(328, 295);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(75, 23);
            this.btView.TabIndex = 7;
            this.btView.Text = "&View web";
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btClose.Location = new System.Drawing.Point(409, 294);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "&Close";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // keyNameLabel1
            // 
            this.keyNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsSeoBindingSource, "KeyName", true));
            this.keyNameLabel1.Location = new System.Drawing.Point(87, 8);
            this.keyNameLabel1.Name = "keyNameLabel1";
            this.keyNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.keyNameLabel1.TabIndex = 13;
            this.keyNameLabel1.Text = "label4";
            // 
            // lakey
            // 
            this.lakey.AutoSize = true;
            this.lakey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lakey.Location = new System.Drawing.Point(25, 209);
            this.lakey.Name = "lakey";
            this.lakey.Size = new System.Drawing.Size(17, 17);
            this.lakey.TabIndex = 25;
            this.lakey.Text = "0";
            // 
            // lasapo
            // 
            this.lasapo.AutoSize = true;
            this.lasapo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasapo.Location = new System.Drawing.Point(25, 103);
            this.lasapo.Name = "lasapo";
            this.lasapo.Size = new System.Drawing.Size(17, 17);
            this.lasapo.TabIndex = 24;
            this.lasapo.Text = "0";
            // 
            // latitle
            // 
            this.latitle.AutoSize = true;
            this.latitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitle.Location = new System.Drawing.Point(25, 37);
            this.latitle.Name = "latitle";
            this.latitle.Size = new System.Drawing.Size(17, 17);
            this.latitle.TabIndex = 23;
            this.latitle.Text = "0";
            // 
            // sEOUpdateDateTimePicker
            // 
            this.sEOUpdateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sEOUpdateDateTimePicker.CustomFormat = "hh:mm-dd/MM/yyyy";
            this.sEOUpdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keywordsSeoBindingSource, "SEOUpdate", true));
            this.sEOUpdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sEOUpdateDateTimePicker.Location = new System.Drawing.Point(500, 8);
            this.sEOUpdateDateTimePicker.Name = "sEOUpdateDateTimePicker";
            this.sEOUpdateDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.sEOUpdateDateTimePicker.TabIndex = 26;
            // 
            // btSaveClose
            // 
            this.btSaveClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSaveClose.Location = new System.Drawing.Point(247, 295);
            this.btSaveClose.Name = "btSaveClose";
            this.btSaveClose.Size = new System.Drawing.Size(75, 23);
            this.btSaveClose.TabIndex = 7;
            this.btSaveClose.Text = "Sa&ve - Close";
            this.btSaveClose.Click += new System.EventHandler(this.btSaveClose_Click);
            // 
            // keyFreqTextBox
            // 
            this.keyFreqTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsSeoBindingSource, "KeyFreq", true));
            this.keyFreqTextBox.Location = new System.Drawing.Point(180, 268);
            this.keyFreqTextBox.Name = "keyFreqTextBox";
            this.keyFreqTextBox.ReadOnly = true;
            this.keyFreqTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyFreqTextBox.TabIndex = 27;
            // 
            // keyClickTextBox
            // 
            this.keyClickTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.keywordsSeoBindingSource, "KeyClick", true));
            this.keyClickTextBox.Location = new System.Drawing.Point(419, 268);
            this.keyClickTextBox.Name = "keyClickTextBox";
            this.keyClickTextBox.ReadOnly = true;
            this.keyClickTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyClickTextBox.TabIndex = 28;
            // 
            // keywordsSeoBindingSource
            // 
            this.keywordsSeoBindingSource.DataMember = "KeywordsSeo";
            this.keywordsSeoBindingSource.DataSource = this.kW;
            // 
            // kW
            // 
            this.kW.DataSetName = "KW";
            this.kW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // keywordsSeoTableAdapter
            // 
            this.keywordsSeoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Keywords_SeoTableAdapter = null;
            this.tableAdapterManager.KeywordsSeoTableAdapter = this.keywordsSeoTableAdapter;
            this.tableAdapterManager.KeywordsTableAdapter = null;
            this.tableAdapterManager.KeywordsTempTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Data.KWTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // keywords_SeoBindingSource
            // 
            this.keywords_SeoBindingSource.DataMember = "Keywords_Seo";
            this.keywords_SeoBindingSource.DataSource = this.kW;
            // 
            // keywords_SeoTableAdapter
            // 
            this.keywords_SeoTableAdapter.ClearBeforeFill = true;
            // 
            // frmSeoKeyWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 325);
            this.Controls.Add(keyClickLabel);
            this.Controls.Add(this.keyClickTextBox);
            this.Controls.Add(keyFreqLabel);
            this.Controls.Add(this.keyFreqTextBox);
            this.Controls.Add(sEOUpdateLabel);
            this.Controls.Add(this.sEOUpdateDateTimePicker);
            this.Controls.Add(this.lakey);
            this.Controls.Add(this.lasapo);
            this.Controls.Add(this.latitle);
            this.Controls.Add(keyNameLabel);
            this.Controls.Add(this.keyNameLabel1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btSaveClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(keyLienQuanLabel);
            this.Controls.Add(this.keyLienQuanTextBox);
            this.Controls.Add(sapoLabel);
            this.Controls.Add(this.sapoTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Name = "frmSeoKeyWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeoKeyWord";
            this.Load += new System.EventHandler(this.frmSeoKeyWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keywordsSeoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywords_SeoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.KW kW;
        private System.Windows.Forms.BindingSource keywordsSeoBindingSource;
        private Data.KWTableAdapters.KeywordsSeoTableAdapter keywordsSeoTableAdapter;
        private Data.KWTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox sapoTextBox;
        private System.Windows.Forms.TextBox keyLienQuanTextBox;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.SimpleButton btView;
        private DevExpress.XtraEditors.SimpleButton btClose;
        private System.Windows.Forms.Label keyNameLabel1;
        private System.Windows.Forms.Label lakey;
        private System.Windows.Forms.Label lasapo;
        private System.Windows.Forms.Label latitle;
        private System.Windows.Forms.DateTimePicker sEOUpdateDateTimePicker;
        private DevExpress.XtraEditors.SimpleButton btSaveClose;
        private System.Windows.Forms.BindingSource keywords_SeoBindingSource;
        private Data.KWTableAdapters.Keywords_SeoTableAdapter keywords_SeoTableAdapter;
        private System.Windows.Forms.TextBox keyFreqTextBox;
        private System.Windows.Forms.TextBox keyClickTextBox;
    }
}