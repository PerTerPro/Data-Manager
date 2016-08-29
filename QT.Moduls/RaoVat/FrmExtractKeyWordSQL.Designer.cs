namespace QT.Moduls.CrawlSale
{
    partial class FrmExtractKeyWordSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExtractKeyWordSQL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberWord = new System.Windows.Forms.TextBox();
            this.btnAnalysic = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadAnalysictData = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControlGoodKey = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.crc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.is_selected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCheckAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnSaveKeyWord = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridControlKey = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckRegexKeyword = new DevExpress.XtraEditors.CheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGoodKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckRegexKeyword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckRegexKeyword);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNumberWord);
            this.panel1.Controls.Add(this.btnAnalysic);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnLoadAnalysictData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 100);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(495, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(413, 51);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "{$or:[{\'is_extract_keyword\':{$exists:false}},{\'is_extract_keyword\':false}]}";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(924, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tải lại RegexKeyword";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NumberWord";
            // 
            // txtNumberWord
            // 
            this.txtNumberWord.Location = new System.Drawing.Point(571, 17);
            this.txtNumberWord.Name = "txtNumberWord";
            this.txtNumberWord.Size = new System.Drawing.Size(140, 20);
            this.txtNumberWord.TabIndex = 2;
            this.txtNumberWord.Text = "2,1";
            // 
            // btnAnalysic
            // 
            this.btnAnalysic.Location = new System.Drawing.Point(12, 41);
            this.btnAnalysic.Name = "btnAnalysic";
            this.btnAnalysic.Size = new System.Drawing.Size(125, 23);
            this.btnAnalysic.TabIndex = 1;
            this.btnAnalysic.Text = "Phân tích dữ liệu";
            this.btnAnalysic.UseVisualStyleBackColor = true;
            this.btnAnalysic.Click += new System.EventHandler(this.btnAnalysic_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(317, 82);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnLoadAnalysictData
            // 
            this.btnLoadAnalysictData.Location = new System.Drawing.Point(12, 12);
            this.btnLoadAnalysictData.Name = "btnLoadAnalysictData";
            this.btnLoadAnalysictData.Size = new System.Drawing.Size(125, 23);
            this.btnLoadAnalysictData.TabIndex = 0;
            this.btnLoadAnalysictData.Text = "Tải dữ liệu phân tích";
            this.btnLoadAnalysictData.UseVisualStyleBackColor = true;
            this.btnLoadAnalysictData.Click += new System.EventHandler(this.btnLoadAnalysictData_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 432);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1119, 72);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 332);
            this.panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControlGoodKey);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(502, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 332);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Từ khóa tốt";
            // 
            // gridControlGoodKey
            // 
            this.gridControlGoodKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlGoodKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGoodKey.Location = new System.Drawing.Point(3, 41);
            this.gridControlGoodKey.MainView = this.gridView1;
            this.gridControlGoodKey.Name = "gridControlGoodKey";
            this.gridControlGoodKey.Size = new System.Drawing.Size(302, 288);
            this.gridControlGoodKey.TabIndex = 3;
            this.gridControlGoodKey.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.crc,
            this.name,
            this.is_selected});
            this.gridView1.GridControl = this.gridControlGoodKey;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // crc
            // 
            this.crc.Caption = "crc";
            this.crc.FieldName = "crcKeyWord";
            this.crc.Name = "crc";
            this.crc.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.crc.Visible = true;
            this.crc.VisibleIndex = 0;
            // 
            // name
            // 
            this.name.Caption = "name";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.OptionsColumn.AllowEdit = false;
            this.name.Visible = true;
            this.name.VisibleIndex = 1;
            // 
            // is_selected
            // 
            this.is_selected.Caption = "is_selected";
            this.is_selected.FieldName = "is_selected";
            this.is_selected.Name = "is_selected";
            this.is_selected.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.is_selected.Visible = true;
            this.is_selected.VisibleIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCheckAll,
            this.toolStripButton3,
            this.btnSaveKeyWord});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(302, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAll.Image")));
            this.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(77, 22);
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton3.Text = "=> To Black List";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnSaveKeyWord
            // 
            this.btnSaveKeyWord.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveKeyWord.Image")));
            this.btnSaveKeyWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveKeyWord.Name = "btnSaveKeyWord";
            this.btnSaveKeyWord.Size = new System.Drawing.Size(102, 22);
            this.btnSaveKeyWord.Text = "Save KeyWord";
            this.btnSaveKeyWord.Click += new System.EventHandler(this.btnSaveKeyWord_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridControlKey);
            this.groupBox3.Controls.Add(this.toolStrip2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(810, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 332);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Black Link";
            // 
            // gridControlKey
            // 
            this.gridControlKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKey.Location = new System.Drawing.Point(3, 41);
            this.gridControlKey.MainView = this.gridView3;
            this.gridControlKey.Name = "gridControlKey";
            this.gridControlKey.Size = new System.Drawing.Size(303, 288);
            this.gridControlKey.TabIndex = 5;
            this.gridControlKey.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView3.GridControl = this.gridControlKey;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.MultiSelect = true;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "crc";
            this.gridColumn1.FieldName = "crcKeyWord";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "name";
            this.gridColumn2.FieldName = "name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "is_selected";
            this.gridColumn3.FieldName = "is_selected";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(303, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton1.Text = "Check All";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(111, 22);
            this.toolStripButton2.Text = "=> ToGoodLink";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(102, 22);
            this.toolStripButton4.Text = "Save KeyWord";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu phân tích";
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(3, 16);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(496, 313);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colUpdatedAt,
            this.Id});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colName
            // 
            this.colName.Caption = "name";
            this.colName.FieldName = "name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colUpdatedAt
            // 
            this.colUpdatedAt.Caption = "Updated At";
            this.colUpdatedAt.FieldName = "updated_at";
            this.colUpdatedAt.Name = "colUpdatedAt";
            this.colUpdatedAt.Visible = true;
            this.colUpdatedAt.VisibleIndex = 1;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "_id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 2;
            // 
            // ckRegexKeyword
            // 
            this.ckRegexKeyword.EditValue = true;
            this.ckRegexKeyword.Location = new System.Drawing.Point(717, 18);
            this.ckRegexKeyword.Name = "ckRegexKeyword";
            this.ckRegexKeyword.Properties.Caption = "UseRegex";
            this.ckRegexKeyword.Size = new System.Drawing.Size(75, 19);
            this.ckRegexKeyword.TabIndex = 6;
            // 
            // FrmExtractKeyWordSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmExtractKeyWordSQL";
            this.Text = "FrmExtractKeyWordSQL";
            this.Load += new System.EventHandler(this.FrmExtractKeyWordSQL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGoodKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckRegexKeyword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadAnalysictData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAnalysic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.GridControl gridControlGoodKey;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn crc;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn is_selected;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCheckAll;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btnSaveKeyWord;
        private DevExpress.XtraGrid.GridControl gridControlKey;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.CheckEdit ckRegexKeyword;
    }
}