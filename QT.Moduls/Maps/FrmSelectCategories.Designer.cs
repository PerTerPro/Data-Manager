namespace QT.Moduls.Maps
{
    partial class FrmSelectCategories
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnEnd = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.qT_2DataSet1 = new QT.Moduls.QT_2DataSet();
            this.listClassificationTableAdapter1 = new QT.Moduls.QT_2DataSetTableAdapters.ListClassificationTableAdapter();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qT_2DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnOK);
            this.panel4.Controls.Add(this.btnEnd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 324);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 38);
            this.panel4.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(262, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(181, 6);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "Close";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.treeList1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 288);
            this.panel3.TabIndex = 3;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName});
            this.treeList1.DataMember = "ListClassification";
            this.treeList1.DataSource = this.qT_2DataSet1;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(558, 288);
            this.treeList1.TabIndex = 1;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 540;
            // 
            // qT_2DataSet1
            // 
            this.qT_2DataSet1.DataSetName = "QT_2DataSet";
            this.qT_2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listClassificationTableAdapter1
            // 
            this.listClassificationTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmSelectCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 362);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSelectCategories";
            this.Text = "FrmSelectCategories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSelectCategories_FormClosing);
            this.Load += new System.EventHandler(this.FrmSelectCategories_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qT_2DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnEnd;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private QT_2DataSet qT_2DataSet1;
        private QT_2DataSetTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter1;
    }
}