namespace QT.Moduls.RaoVat
{
    partial class FrmPushReloadProduct
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
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.txtReport = new System.Windows.Forms.RichTextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.btnPushImediate = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtQuery);
            this.panelControl1.Controls.Add(this.txtReport);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(585, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // txtQuery
            // 
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuery.Location = new System.Drawing.Point(2, 2);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(363, 96);
            this.txtQuery.TabIndex = 2;
            this.txtQuery.Text = "{}";
            // 
            // txtReport
            // 
            this.txtReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtReport.Location = new System.Drawing.Point(365, 2);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(218, 96);
            this.txtReport.TabIndex = 1;
            this.txtReport.Text = "";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.spinEdit1);
            this.panelControl2.Controls.Add(this.btnPushImediate);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(585, 100);
            this.panelControl2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Limit";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(39, 4);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(125, 20);
            this.spinEdit1.TabIndex = 1;
            // 
            // btnPushImediate
            // 
            this.btnPushImediate.Location = new System.Drawing.Point(170, 2);
            this.btnPushImediate.Name = "btnPushImediate";
            this.btnPushImediate.Size = new System.Drawing.Size(87, 23);
            this.btnPushImediate.TabIndex = 0;
            this.btnPushImediate.Text = "Push Imediate";
            this.btnPushImediate.Click += new System.EventHandler(this.btnPushImediate_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 200);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(585, 100);
            this.panelControl3.TabIndex = 2;
            // 
            // FrmPushReloadProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 303);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmPushReloadProduct";
            this.Text = "FrmPushReloadProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPushReloadProduct_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RichTextBox txtQuery;
        private System.Windows.Forms.RichTextBox txtReport;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.SimpleButton btnPushImediate;
        private DevExpress.XtraEditors.PanelControl panelControl3;

    }
}