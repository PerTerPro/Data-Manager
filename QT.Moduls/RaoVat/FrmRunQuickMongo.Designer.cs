namespace QT.Moduls.CrawlSale
{
    partial class FrmRunQuickMongo
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
            this.txtFind = new System.Windows.Forms.RichTextBox();
            this.txtUpdate = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(107, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(601, 98);
            this.txtFind.TabIndex = 0;
            this.txtFind.Text = "";
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(107, 116);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(601, 98);
            this.txtUpdate.TabIndex = 1;
            this.txtUpdate.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find Query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Update Query";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(107, 220);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(601, 229);
            this.txtLog.TabIndex = 4;
            this.txtLog.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(714, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(714, 41);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(77, 20);
            this.spinEdit1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FixOverDate",
            "Fix category_ids",
            "FixAddField:wait_quick_reload"});
            this.comboBox1.Location = new System.Drawing.Point(107, 455);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmRunQuickMongo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 487);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtFind);
            this.Name = "FrmRunQuickMongo";
            this.Text = "FrmRunQuickMongo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRunQuickMongo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtFind;
        private System.Windows.Forms.RichTextBox txtUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRun;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}