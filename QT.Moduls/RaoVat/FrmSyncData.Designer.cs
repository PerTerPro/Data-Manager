namespace QT.Moduls.CrawlSale
{
    partial class FrmSyncData
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSoftCommit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSoftCommit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.spinEdit1);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 34);
            this.panel2.TabIndex = 2;
            // 
            // btnSoftCommit
            // 
            this.btnSoftCommit.Location = new System.Drawing.Point(356, 4);
            this.btnSoftCommit.Name = "btnSoftCommit";
            this.btnSoftCommit.Size = new System.Drawing.Size(128, 22);
            this.btnSoftCommit.TabIndex = 3;
            this.btnSoftCommit.Text = "SoftCommit";
            this.btnSoftCommit.UseVisualStyleBackColor = true;
            this.btnSoftCommit.Click += new System.EventHandler(this.btnSoftCommit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NumberItem";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(224, 1);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(100, 30);
            this.spinEdit1.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 22);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 471);
            this.panel1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(840, 471);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // FrmSyncData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmSyncData";
            this.Text = "Đồng bộ Product: MongoDb=>Solr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSyncData_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSoftCommit;
    }
}