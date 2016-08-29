
namespace QT.Moduls.CrawlSale
{
    partial class FrmFindKeywordOfProduct
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
            this.btnStart = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spinIncr = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIncreateMent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.txtUpdate = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinIncr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 27);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnStart);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(603, 69);
            this.panelControl2.TabIndex = 8;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.richTextBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 69);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(603, 222);
            this.panelControl1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(599, 218);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.spinIncr);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtIncreateMent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtField);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.spinEdit2);
            this.panel1.Controls.Add(this.txtUpdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 172);
            this.panel1.TabIndex = 12;
            // 
            // spinIncr
            // 
            this.spinIncr.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinIncr.Location = new System.Drawing.Point(421, 83);
            this.spinIncr.Name = "spinIncr";
            this.spinIncr.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.spinIncr.Properties.Appearance.Options.UseFont = true;
            this.spinIncr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinIncr.Size = new System.Drawing.Size(93, 26);
            this.spinIncr.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "FieldIncrement";
            // 
            // txtIncreateMent
            // 
            this.txtIncreateMent.Location = new System.Drawing.Point(421, 57);
            this.txtIncreateMent.Name = "txtIncreateMent";
            this.txtIncreateMent.Size = new System.Drawing.Size(93, 20);
            this.txtIncreateMent.TabIndex = 8;
            this.txtIncreateMent.Text = "score_gram";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "field";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(60, 150);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(184, 20);
            this.txtField.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Limit";
            // 
            // spinEdit2
            // 
            this.spinEdit2.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(372, 25);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.spinEdit2.Properties.Appearance.Options.UseFont = true;
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit2.Size = new System.Drawing.Size(142, 26);
            this.spinEdit2.TabIndex = 4;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(60, 78);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(273, 66);
            this.txtUpdate.TabIndex = 3;
            this.txtUpdate.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Update";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Query";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(60, 6);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(273, 66);
            this.txtQuery.TabIndex = 0;
            this.txtQuery.Text = "";
            // 
            // FrmFindKeywordOfProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmFindKeywordOfProduct";
            this.Text = "FrmExtractionKeyWord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExtractionKeyWord_FormClosing);
            this.Load += new System.EventHandler(this.FrmExtractionKeyWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinIncr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private System.Windows.Forms.RichTextBox txtUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIncreateMent;
        private DevExpress.XtraEditors.SpinEdit spinIncr;
    }
}