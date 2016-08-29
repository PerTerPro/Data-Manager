namespace QT.Moduls.RaoVat
{
    partial class FrmRunnerCrawler
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.spinId = new DevExpress.XtraEditors.SpinEdit();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboWebSite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.spimMaxTime = new DevExpress.XtraEditors.SpinEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.spinMaxItem = new DevExpress.XtraEditors.SpinEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.spinMaxDeep = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.ckReloadData = new System.Windows.Forms.CheckBox();
            this.ckFindNewItem = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.spinRecrawler = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.spinNumberThread = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRootLink = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.btnRunCrawler = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spimMaxTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxDeep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRecrawler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumberThread.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(361, 448);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(357, 444);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.name,
            this.colBaseLink});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            this.id.Width = 45;
            // 
            // name
            // 
            this.name.Caption = "name";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 1;
            this.name.Width = 150;
            // 
            // colBaseLink
            // 
            this.colBaseLink.Caption = "base_link";
            this.colBaseLink.FieldName = "base_link";
            this.colBaseLink.Name = "colBaseLink";
            this.colBaseLink.Visible = true;
            this.colBaseLink.VisibleIndex = 2;
            this.colBaseLink.Width = 143;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Controls.Add(this.btnReload);
            this.panelControl2.Controls.Add(this.spinId);
            this.panelControl2.Controls.Add(this.txtName);
            this.panelControl2.Controls.Add(this.label12);
            this.panelControl2.Controls.Add(this.cboWebSite);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(361, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(703, 36);
            this.panelControl2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(631, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(568, 6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(57, 23);
            this.btnReload.TabIndex = 25;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // spinId
            // 
            this.spinId.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinId.Location = new System.Drawing.Point(459, 7);
            this.spinId.Name = "spinId";
            this.spinId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinId.Size = new System.Drawing.Size(102, 20);
            this.spinId.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(256, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 20);
            this.txtName.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Name";
            // 
            // cboWebSite
            // 
            this.cboWebSite.FormattingEnabled = true;
            this.cboWebSite.Location = new System.Drawing.Point(67, 9);
            this.cboWebSite.Name = "cboWebSite";
            this.cboWebSite.Size = new System.Drawing.Size(139, 21);
            this.cboWebSite.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WebSite";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.spimMaxTime);
            this.panelControl3.Controls.Add(this.label13);
            this.panelControl3.Controls.Add(this.btnRefresh);
            this.panelControl3.Controls.Add(this.btnSave);
            this.panelControl3.Controls.Add(this.label11);
            this.panelControl3.Controls.Add(this.label10);
            this.panelControl3.Controls.Add(this.txtDescription);
            this.panelControl3.Controls.Add(this.spinMaxItem);
            this.panelControl3.Controls.Add(this.label7);
            this.panelControl3.Controls.Add(this.spinMaxDeep);
            this.panelControl3.Controls.Add(this.label8);
            this.panelControl3.Controls.Add(this.ckReloadData);
            this.panelControl3.Controls.Add(this.ckFindNewItem);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Controls.Add(this.spinRecrawler);
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Controls.Add(this.spinNumberThread);
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.txtRootLink);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(361, 36);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(703, 412);
            this.panelControl3.TabIndex = 2;
            // 
            // spimMaxTime
            // 
            this.spimMaxTime.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spimMaxTime.Location = new System.Drawing.Point(322, 373);
            this.spimMaxTime.Name = "spimMaxTime";
            this.spimMaxTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spimMaxTime.Size = new System.Drawing.Size(100, 20);
            this.spimMaxTime.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Max time (\')";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(85, 382);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 22);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "Refresh";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(4, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 22);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(487, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 21;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(490, 329);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 64);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.Text = "";
            // 
            // spinMaxItem
            // 
            this.spinMaxItem.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMaxItem.Location = new System.Drawing.Point(322, 325);
            this.spinMaxItem.Name = "spinMaxItem";
            this.spinMaxItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinMaxItem.Size = new System.Drawing.Size(100, 20);
            this.spinMaxItem.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Max Items";
            // 
            // spinMaxDeep
            // 
            this.spinMaxDeep.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMaxDeep.Location = new System.Drawing.Point(322, 299);
            this.spinMaxDeep.Name = "spinMaxDeep";
            this.spinMaxDeep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinMaxDeep.Size = new System.Drawing.Size(100, 20);
            this.spinMaxDeep.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Max Deep";
            // 
            // ckReloadData
            // 
            this.ckReloadData.AutoSize = true;
            this.ckReloadData.Location = new System.Drawing.Point(193, 355);
            this.ckReloadData.Name = "ckReloadData";
            this.ckReloadData.Size = new System.Drawing.Size(78, 17);
            this.ckReloadData.TabIndex = 11;
            this.ckReloadData.Text = "reloadData";
            this.ckReloadData.UseVisualStyleBackColor = true;
            // 
            // ckFindNewItem
            // 
            this.ckFindNewItem.AutoSize = true;
            this.ckFindNewItem.Location = new System.Drawing.Point(102, 355);
            this.ckFindNewItem.Name = "ckFindNewItem";
            this.ckFindNewItem.Size = new System.Drawing.Size(85, 17);
            this.ckFindNewItem.TabIndex = 10;
            this.ckFindNewItem.Text = "findNewItem";
            this.ckFindNewItem.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "s";
            // 
            // spinRecrawler
            // 
            this.spinRecrawler.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinRecrawler.Location = new System.Drawing.Point(102, 329);
            this.spinRecrawler.Name = "spinRecrawler";
            this.spinRecrawler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinRecrawler.Size = new System.Drawing.Size(100, 20);
            this.spinRecrawler.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Wait recrawler";
            // 
            // spinNumberThread
            // 
            this.spinNumberThread.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinNumberThread.Location = new System.Drawing.Point(102, 303);
            this.spinNumberThread.Name = "spinNumberThread";
            this.spinNumberThread.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNumberThread.Size = new System.Drawing.Size(100, 20);
            this.spinNumberThread.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number Threads";
            // 
            // txtRootLink
            // 
            this.txtRootLink.Location = new System.Drawing.Point(9, 23);
            this.txtRootLink.Name = "txtRootLink";
            this.txtRootLink.Size = new System.Drawing.Size(679, 274);
            this.txtRootLink.TabIndex = 3;
            this.txtRootLink.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Root Link";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRunCrawler});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 26);
            // 
            // btnRunCrawler
            // 
            this.btnRunCrawler.Name = "btnRunCrawler";
            this.btnRunCrawler.Size = new System.Drawing.Size(135, 22);
            this.btnRunCrawler.Text = "RunCrawler";
            this.btnRunCrawler.Click += new System.EventHandler(this.btnRunCrawler_Click);
            // 
            // FrmRunnerCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 448);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmRunnerCrawler";
            this.Text = "Cấu hình chạy crawler";
            this.Load += new System.EventHandler(this.FrmRunnerCrawler_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRunnerCrawler_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spimMaxTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMaxDeep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRecrawler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumberThread.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboWebSite;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtDescription;
        private DevExpress.XtraEditors.SpinEdit spinMaxItem;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SpinEdit spinMaxDeep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckReloadData;
        private System.Windows.Forms.CheckBox ckFindNewItem;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SpinEdit spinRecrawler;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit spinNumberThread;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtRootLink;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SpinEdit spinId;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SpinEdit spimMaxTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnRunCrawler;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseLink;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
    }
}