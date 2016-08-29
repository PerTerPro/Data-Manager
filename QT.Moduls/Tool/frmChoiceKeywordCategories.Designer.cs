namespace QT.Moduls.Tool
{
    partial class frmChoiceKeywordCategories
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
            this.dataGridViewNotChoisedKeyword = new System.Windows.Forms.DataGridView();
            this.hashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTool = new QT.Moduls.Tool.DBTool();
            this.keywordCategoriesTableAdapter = new QT.Moduls.Tool.DBToolTableAdapters.KeywordCategoriesTableAdapter();
            this.fillNotProcessedKeyWordByUserIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.userIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillNotProcessedKeyWordByUserIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.comboBoxCategory1 = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory2 = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory3 = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory4 = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory5 = new System.Windows.Forms.ComboBox();
            this.lblCategory1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewChoisedKeyword = new System.Windows.Forms.DataGridView();
            this.KeywordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category3Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category4Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category5Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddKeyword = new System.Windows.Forms.Button();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.contextMenuStripDeleteRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCoppy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.coppyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotChoisedKeyword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool)).BeginInit();
            this.fillNotProcessedKeyWordByUserIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoisedKeyword)).BeginInit();
            this.contextMenuStripDeleteRow.SuspendLayout();
            this.contextMenuStripCoppy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNotChoisedKeyword
            // 
            this.dataGridViewNotChoisedKeyword.AllowUserToAddRows = false;
            this.dataGridViewNotChoisedKeyword.AutoGenerateColumns = false;
            this.dataGridViewNotChoisedKeyword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotChoisedKeyword.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hashDataGridViewTextBoxColumn,
            this.keywordDataGridViewTextBoxColumn,
            this.category1DataGridViewTextBoxColumn,
            this.category2DataGridViewTextBoxColumn,
            this.category3DataGridViewTextBoxColumn,
            this.category4DataGridViewTextBoxColumn,
            this.category5DataGridViewTextBoxColumn});
            this.dataGridViewNotChoisedKeyword.DataSource = this.keywordCategoriesBindingSource;
            this.dataGridViewNotChoisedKeyword.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewNotChoisedKeyword.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewNotChoisedKeyword.Name = "dataGridViewNotChoisedKeyword";
            this.dataGridViewNotChoisedKeyword.RowHeadersVisible = false;
            this.dataGridViewNotChoisedKeyword.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNotChoisedKeyword.Size = new System.Drawing.Size(309, 380);
            this.dataGridViewNotChoisedKeyword.TabIndex = 0;
            this.dataGridViewNotChoisedKeyword.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewNotChoisedKeyword_CellMouseDown);
            this.dataGridViewNotChoisedKeyword.SelectionChanged += new System.EventHandler(this.dataGridViewNotChoisedKeyword_SelectionChanged);
            // 
            // hashDataGridViewTextBoxColumn
            // 
            this.hashDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hashDataGridViewTextBoxColumn.DataPropertyName = "Hash";
            this.hashDataGridViewTextBoxColumn.FillWeight = 30F;
            this.hashDataGridViewTextBoxColumn.HeaderText = "Hash";
            this.hashDataGridViewTextBoxColumn.Name = "hashDataGridViewTextBoxColumn";
            // 
            // keywordDataGridViewTextBoxColumn
            // 
            this.keywordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keywordDataGridViewTextBoxColumn.DataPropertyName = "Keyword";
            this.keywordDataGridViewTextBoxColumn.FillWeight = 70F;
            this.keywordDataGridViewTextBoxColumn.HeaderText = "Keyword";
            this.keywordDataGridViewTextBoxColumn.Name = "keywordDataGridViewTextBoxColumn";
            // 
            // category1DataGridViewTextBoxColumn
            // 
            this.category1DataGridViewTextBoxColumn.DataPropertyName = "Category1";
            this.category1DataGridViewTextBoxColumn.HeaderText = "Category1";
            this.category1DataGridViewTextBoxColumn.Name = "category1DataGridViewTextBoxColumn";
            this.category1DataGridViewTextBoxColumn.Visible = false;
            // 
            // category2DataGridViewTextBoxColumn
            // 
            this.category2DataGridViewTextBoxColumn.DataPropertyName = "Category2";
            this.category2DataGridViewTextBoxColumn.HeaderText = "Category2";
            this.category2DataGridViewTextBoxColumn.Name = "category2DataGridViewTextBoxColumn";
            this.category2DataGridViewTextBoxColumn.Visible = false;
            // 
            // category3DataGridViewTextBoxColumn
            // 
            this.category3DataGridViewTextBoxColumn.DataPropertyName = "Category3";
            this.category3DataGridViewTextBoxColumn.HeaderText = "Category3";
            this.category3DataGridViewTextBoxColumn.Name = "category3DataGridViewTextBoxColumn";
            this.category3DataGridViewTextBoxColumn.Visible = false;
            // 
            // category4DataGridViewTextBoxColumn
            // 
            this.category4DataGridViewTextBoxColumn.DataPropertyName = "Category4";
            this.category4DataGridViewTextBoxColumn.HeaderText = "Category4";
            this.category4DataGridViewTextBoxColumn.Name = "category4DataGridViewTextBoxColumn";
            this.category4DataGridViewTextBoxColumn.Visible = false;
            // 
            // category5DataGridViewTextBoxColumn
            // 
            this.category5DataGridViewTextBoxColumn.DataPropertyName = "Category5";
            this.category5DataGridViewTextBoxColumn.HeaderText = "Category5";
            this.category5DataGridViewTextBoxColumn.Name = "category5DataGridViewTextBoxColumn";
            this.category5DataGridViewTextBoxColumn.Visible = false;
            // 
            // keywordCategoriesBindingSource
            // 
            this.keywordCategoriesBindingSource.DataMember = "KeywordCategories";
            this.keywordCategoriesBindingSource.DataSource = this.dBTool;
            // 
            // dBTool
            // 
            this.dBTool.DataSetName = "DBTool";
            this.dBTool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // keywordCategoriesTableAdapter
            // 
            this.keywordCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // fillNotProcessedKeyWordByUserIDToolStrip
            // 
            this.fillNotProcessedKeyWordByUserIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIDToolStripLabel,
            this.userIDToolStripTextBox,
            this.fillNotProcessedKeyWordByUserIDToolStripButton});
            this.fillNotProcessedKeyWordByUserIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillNotProcessedKeyWordByUserIDToolStrip.Name = "fillNotProcessedKeyWordByUserIDToolStrip";
            this.fillNotProcessedKeyWordByUserIDToolStrip.Size = new System.Drawing.Size(798, 25);
            this.fillNotProcessedKeyWordByUserIDToolStrip.TabIndex = 1;
            this.fillNotProcessedKeyWordByUserIDToolStrip.Text = "fillNotProcessedKeyWordByUserIDToolStrip";
            // 
            // userIDToolStripLabel
            // 
            this.userIDToolStripLabel.Name = "userIDToolStripLabel";
            this.userIDToolStripLabel.Size = new System.Drawing.Size(43, 22);
            this.userIDToolStripLabel.Text = "userID:";
            // 
            // userIDToolStripTextBox
            // 
            this.userIDToolStripTextBox.Name = "userIDToolStripTextBox";
            this.userIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillNotProcessedKeyWordByUserIDToolStripButton
            // 
            this.fillNotProcessedKeyWordByUserIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillNotProcessedKeyWordByUserIDToolStripButton.Name = "fillNotProcessedKeyWordByUserIDToolStripButton";
            this.fillNotProcessedKeyWordByUserIDToolStripButton.Size = new System.Drawing.Size(178, 22);
            this.fillNotProcessedKeyWordByUserIDToolStripButton.Text = "FillNotProcessedKeyWordByUserID";
            this.fillNotProcessedKeyWordByUserIDToolStripButton.Click += new System.EventHandler(this.fillNotProcessedKeyWordByUserIDToolStripButton_Click);
            // 
            // comboBoxCategory1
            // 
            this.comboBoxCategory1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCategory1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCategory1.Enabled = false;
            this.comboBoxCategory1.FormattingEnabled = true;
            this.comboBoxCategory1.Location = new System.Drawing.Point(417, 33);
            this.comboBoxCategory1.Name = "comboBoxCategory1";
            this.comboBoxCategory1.Size = new System.Drawing.Size(349, 21);
            this.comboBoxCategory1.TabIndex = 2;
            this.comboBoxCategory1.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory1_SelectedIndexChanged);
            // 
            // comboBoxCategory2
            // 
            this.comboBoxCategory2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCategory2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCategory2.Enabled = false;
            this.comboBoxCategory2.FormattingEnabled = true;
            this.comboBoxCategory2.Location = new System.Drawing.Point(417, 60);
            this.comboBoxCategory2.Name = "comboBoxCategory2";
            this.comboBoxCategory2.Size = new System.Drawing.Size(349, 21);
            this.comboBoxCategory2.TabIndex = 3;
            this.comboBoxCategory2.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory2_SelectedIndexChanged);
            // 
            // comboBoxCategory3
            // 
            this.comboBoxCategory3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCategory3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCategory3.Enabled = false;
            this.comboBoxCategory3.FormattingEnabled = true;
            this.comboBoxCategory3.Location = new System.Drawing.Point(417, 87);
            this.comboBoxCategory3.Name = "comboBoxCategory3";
            this.comboBoxCategory3.Size = new System.Drawing.Size(349, 21);
            this.comboBoxCategory3.TabIndex = 4;
            this.comboBoxCategory3.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory3_SelectedIndexChanged);
            // 
            // comboBoxCategory4
            // 
            this.comboBoxCategory4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCategory4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCategory4.Enabled = false;
            this.comboBoxCategory4.FormattingEnabled = true;
            this.comboBoxCategory4.Location = new System.Drawing.Point(417, 114);
            this.comboBoxCategory4.Name = "comboBoxCategory4";
            this.comboBoxCategory4.Size = new System.Drawing.Size(349, 21);
            this.comboBoxCategory4.TabIndex = 5;
            this.comboBoxCategory4.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory4_SelectedIndexChanged);
            // 
            // comboBoxCategory5
            // 
            this.comboBoxCategory5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCategory5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCategory5.Enabled = false;
            this.comboBoxCategory5.FormattingEnabled = true;
            this.comboBoxCategory5.Location = new System.Drawing.Point(417, 141);
            this.comboBoxCategory5.Name = "comboBoxCategory5";
            this.comboBoxCategory5.Size = new System.Drawing.Size(349, 21);
            this.comboBoxCategory5.TabIndex = 6;
            // 
            // lblCategory1
            // 
            this.lblCategory1.AutoSize = true;
            this.lblCategory1.Location = new System.Drawing.Point(324, 33);
            this.lblCategory1.Name = "lblCategory1";
            this.lblCategory1.Size = new System.Drawing.Size(55, 13);
            this.lblCategory1.TabIndex = 7;
            this.lblCategory1.Text = "Category1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Category3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Category5";
            // 
            // dataGridViewChoisedKeyword
            // 
            this.dataGridViewChoisedKeyword.AllowUserToAddRows = false;
            this.dataGridViewChoisedKeyword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChoisedKeyword.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeywordColumn,
            this.Category1Column,
            this.Category2Column,
            this.Category3Column,
            this.Category4Column,
            this.Category5Column});
            this.dataGridViewChoisedKeyword.Location = new System.Drawing.Point(327, 202);
            this.dataGridViewChoisedKeyword.Name = "dataGridViewChoisedKeyword";
            this.dataGridViewChoisedKeyword.RowHeadersVisible = false;
            this.dataGridViewChoisedKeyword.Size = new System.Drawing.Size(466, 206);
            this.dataGridViewChoisedKeyword.TabIndex = 12;
            this.dataGridViewChoisedKeyword.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewChoisedKeyword_CellMouseUp);
            // 
            // KeywordColumn
            // 
            this.KeywordColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KeywordColumn.FillWeight = 25F;
            this.KeywordColumn.HeaderText = "Keyword";
            this.KeywordColumn.Name = "KeywordColumn";
            // 
            // Category1Column
            // 
            this.Category1Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category1Column.FillWeight = 25F;
            this.Category1Column.HeaderText = "Category1";
            this.Category1Column.Name = "Category1Column";
            // 
            // Category2Column
            // 
            this.Category2Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category2Column.FillWeight = 20F;
            this.Category2Column.HeaderText = "Category2";
            this.Category2Column.Name = "Category2Column";
            // 
            // Category3Column
            // 
            this.Category3Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category3Column.FillWeight = 15F;
            this.Category3Column.HeaderText = "Category3";
            this.Category3Column.Name = "Category3Column";
            // 
            // Category4Column
            // 
            this.Category4Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category4Column.FillWeight = 10F;
            this.Category4Column.HeaderText = "Category4";
            this.Category4Column.Name = "Category4Column";
            // 
            // Category5Column
            // 
            this.Category5Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category5Column.FillWeight = 5F;
            this.Category5Column.HeaderText = "Category5";
            this.Category5Column.Name = "Category5Column";
            // 
            // buttonAddKeyword
            // 
            this.buttonAddKeyword.Enabled = false;
            this.buttonAddKeyword.Location = new System.Drawing.Point(327, 173);
            this.buttonAddKeyword.Name = "buttonAddKeyword";
            this.buttonAddKeyword.Size = new System.Drawing.Size(116, 23);
            this.buttonAddKeyword.TabIndex = 13;
            this.buttonAddKeyword.Text = "Add";
            this.buttonAddKeyword.UseVisualStyleBackColor = true;
            this.buttonAddKeyword.Click += new System.EventHandler(this.buttonAddKeyword_Click);
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Location = new System.Drawing.Point(647, 173);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(107, 23);
            this.buttonSaveAll.TabIndex = 14;
            this.buttonSaveAll.Text = "Save All";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // contextMenuStripDeleteRow
            // 
            this.contextMenuStripDeleteRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStripDeleteRow.Name = "contextMenuStrip1";
            this.contextMenuStripDeleteRow.Size = new System.Drawing.Size(130, 26);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // contextMenuStripCoppy
            // 
            this.contextMenuStripCoppy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coppyToolStripMenuItem,
            this.deleteRowToolStripMenuItem1});
            this.contextMenuStripCoppy.Name = "contextMenuStripCoppy";
            this.contextMenuStripCoppy.Size = new System.Drawing.Size(153, 70);
            // 
            // coppyToolStripMenuItem
            // 
            this.coppyToolStripMenuItem.Name = "coppyToolStripMenuItem";
            this.coppyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coppyToolStripMenuItem.Text = "Copy";
            this.coppyToolStripMenuItem.Click += new System.EventHandler(this.coppyToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem1
            // 
            this.deleteRowToolStripMenuItem1.Name = "deleteRowToolStripMenuItem1";
            this.deleteRowToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteRowToolStripMenuItem1.Text = "Delete Row";
            this.deleteRowToolStripMenuItem1.Click += new System.EventHandler(this.deleteRowToolStripMenuItem1_Click);
            // 
            // frmChoiceKeywordCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 420);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.buttonAddKeyword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewChoisedKeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCategory1);
            this.Controls.Add(this.comboBoxCategory5);
            this.Controls.Add(this.comboBoxCategory4);
            this.Controls.Add(this.comboBoxCategory3);
            this.Controls.Add(this.comboBoxCategory2);
            this.Controls.Add(this.comboBoxCategory1);
            this.Controls.Add(this.fillNotProcessedKeyWordByUserIDToolStrip);
            this.Controls.Add(this.dataGridViewNotChoisedKeyword);
            this.KeyPreview = true;
            this.Name = "frmChoiceKeywordCategories";
            this.Text = "frmChoiceKeywordCategories";
            this.Load += new System.EventHandler(this.frmChoiceKeywordCategories_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChoiceKeywordCategories_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotChoisedKeyword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool)).EndInit();
            this.fillNotProcessedKeyWordByUserIDToolStrip.ResumeLayout(false);
            this.fillNotProcessedKeyWordByUserIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoisedKeyword)).EndInit();
            this.contextMenuStripDeleteRow.ResumeLayout(false);
            this.contextMenuStripCoppy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNotChoisedKeyword;
        private DBTool dBTool;
        private System.Windows.Forms.BindingSource keywordCategoriesBindingSource;
        private DBToolTableAdapters.KeywordCategoriesTableAdapter keywordCategoriesTableAdapter;
        private System.Windows.Forms.ToolStrip fillNotProcessedKeyWordByUserIDToolStrip;
        private System.Windows.Forms.ToolStripLabel userIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox userIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillNotProcessedKeyWordByUserIDToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn category1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn category2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn category3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn category4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn category5DataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxCategory1;
        private System.Windows.Forms.ComboBox comboBoxCategory2;
        private System.Windows.Forms.ComboBox comboBoxCategory3;
        private System.Windows.Forms.ComboBox comboBoxCategory4;
        private System.Windows.Forms.ComboBox comboBoxCategory5;
        private System.Windows.Forms.Label lblCategory1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewChoisedKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeywordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category4Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category5Column;
        private System.Windows.Forms.Button buttonAddKeyword;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDeleteRow;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCoppy;
        private System.Windows.Forms.ToolStripMenuItem coppyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem1;
    }
}