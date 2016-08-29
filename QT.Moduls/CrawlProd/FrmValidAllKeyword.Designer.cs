namespace QT.Moduls.CrawlProd
{
    partial class FrmValidAllKeyword
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
            this.btnStartRun = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ckStutus = new DevExpress.XtraEditors.CheckEdit();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckStutus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartRun
            // 
            this.btnStartRun.Location = new System.Drawing.Point(5, 6);
            this.btnStartRun.Name = "btnStartRun";
            this.btnStartRun.Size = new System.Drawing.Size(95, 23);
            this.btnStartRun.TabIndex = 0;
            this.btnStartRun.Text = "Start";
            this.btnStartRun.UseVisualStyleBackColor = true;
            this.btnStartRun.Click += new System.EventHandler(this.btnStartRun_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ckStutus);
            this.panelControl1.Controls.Add(this.dateTimePicker1);
            this.panelControl1.Controls.Add(this.btnStartRun);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(676, 39);
            this.panelControl1.TabIndex = 2;
            // 
            // ckStutus
            // 
            this.ckStutus.EditValue = true;
            this.ckStutus.Location = new System.Drawing.Point(283, 10);
            this.ckStutus.Name = "ckStutus";
            this.ckStutus.Properties.Caption = "check status = 1";
            this.ckStutus.Size = new System.Drawing.Size(118, 19);
            this.ckStutus.TabIndex = 2;
            this.ckStutus.CheckedChanged += new System.EventHandler(this.ckStutus_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2015, 11, 5, 13, 31, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(676, 357);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // FrmValidAllKeyword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 396);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmValidAllKeyword";
            this.Text = "FrmValidAllKeyword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmValidAllKeyword_FormClosing);
            this.Load += new System.EventHandler(this.FrmValidAllKeyword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckStutus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartRun;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.CheckEdit ckStutus;
    }
}