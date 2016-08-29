namespace QT.Moduls.CrawlSale
{
    partial class FrmReloadData
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
            this.btnPause = new System.Windows.Forms.Button();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtOptionFind = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFieldUpdate = new System.Windows.Forms.RichTextBox();
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtQueryUpdate = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(269, 5);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(97, 26);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Stop";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(59, 5);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(97, 26);
            this.spinEdit1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interval";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(166, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 26);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Run";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtOptionFind);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.lblDescription);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.txtFieldUpdate);
            this.panelControl2.Controls.Add(this.txtQuery);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.spinEdit1);
            this.panelControl2.Controls.Add(this.btnPause);
            this.panelControl2.Controls.Add(this.btnStart);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(871, 302);
            this.panelControl2.TabIndex = 7;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // txtOptionFind
            // 
            this.txtOptionFind.Location = new System.Drawing.Point(104, 99);
            this.txtOptionFind.Name = "txtOptionFind";
            this.txtOptionFind.Size = new System.Drawing.Size(492, 56);
            this.txtOptionFind.TabIndex = 11;
            this.txtOptionFind.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "OptionFind";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(101, 197);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(492, 63);
            this.lblDescription.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "UpdateToField";
            // 
            // txtFieldUpdate
            // 
            this.txtFieldUpdate.Location = new System.Drawing.Point(59, 71);
            this.txtFieldUpdate.Name = "txtFieldUpdate";
            this.txtFieldUpdate.Size = new System.Drawing.Size(10, 34);
            this.txtFieldUpdate.TabIndex = 7;
            this.txtFieldUpdate.Text = "";
            this.txtFieldUpdate.Visible = false;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(104, 37);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(492, 56);
            this.txtQuery.TabIndex = 6;
            this.txtQuery.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Query Reload";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtQueryUpdate);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 302);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(871, 249);
            this.panelControl1.TabIndex = 8;
            // 
            // txtQueryUpdate
            // 
            this.txtQueryUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQueryUpdate.Location = new System.Drawing.Point(2, 2);
            this.txtQueryUpdate.Name = "txtQueryUpdate";
            this.txtQueryUpdate.Size = new System.Drawing.Size(867, 245);
            this.txtQueryUpdate.TabIndex = 5;
            this.txtQueryUpdate.Text = "";
            // 
            // FrmReloadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 551);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmReloadData";
            this.Text = "Tách luồng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReloadData_FormClosing);
            this.Load += new System.EventHandler(this.FrmReloadData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RichTextBox txtQueryUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox txtFieldUpdate;
        public System.Windows.Forms.RichTextBox txtQuery;
        public System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.RichTextBox txtOptionFind;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.SpinEdit spinEdit1;
    }
}