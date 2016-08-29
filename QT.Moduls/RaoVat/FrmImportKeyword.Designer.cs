namespace QT.Moduls.RaoVat
{
    partial class FrmImportKeyword
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSaveKeywrod = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtImportKeyword = new System.Windows.Forms.RichTextBox();
            this.spinPriority = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.ckChangeSpecialCharacter = new System.Windows.Forms.CheckBox();
            this.btnDelKeyword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinPriority.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnDelKeyword);
            this.panelControl2.Controls.Add(this.ckChangeSpecialCharacter);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.spinPriority);
            this.panelControl2.Controls.Add(this.btnSaveKeywrod);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 394);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(725, 37);
            this.panelControl2.TabIndex = 1;
            // 
            // btnSaveKeywrod
            // 
            this.btnSaveKeywrod.Location = new System.Drawing.Point(305, 6);
            this.btnSaveKeywrod.Name = "btnSaveKeywrod";
            this.btnSaveKeywrod.Size = new System.Drawing.Size(133, 23);
            this.btnSaveKeywrod.TabIndex = 0;
            this.btnSaveKeywrod.Text = "Save Keyword";
            this.btnSaveKeywrod.UseVisualStyleBackColor = true;
            this.btnSaveKeywrod.Click += new System.EventHandler(this.btnSaveKeywrod_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtImportKeyword);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(725, 394);
            this.panelControl1.TabIndex = 2;
            // 
            // txtImportKeyword
            // 
            this.txtImportKeyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtImportKeyword.Location = new System.Drawing.Point(2, 2);
            this.txtImportKeyword.Name = "txtImportKeyword";
            this.txtImportKeyword.Size = new System.Drawing.Size(721, 390);
            this.txtImportKeyword.TabIndex = 0;
            this.txtImportKeyword.Text = "";
            // 
            // spinPriority
            // 
            this.spinPriority.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinPriority.Location = new System.Drawing.Point(61, 9);
            this.spinPriority.Name = "spinPriority";
            this.spinPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinPriority.Size = new System.Drawing.Size(60, 20);
            this.spinPriority.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Priority";
            // 
            // ckChangeSpecialCharacter
            // 
            this.ckChangeSpecialCharacter.AutoSize = true;
            this.ckChangeSpecialCharacter.Checked = true;
            this.ckChangeSpecialCharacter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckChangeSpecialCharacter.Location = new System.Drawing.Point(569, 12);
            this.ckChangeSpecialCharacter.Name = "ckChangeSpecialCharacter";
            this.ckChangeSpecialCharacter.Size = new System.Drawing.Size(144, 17);
            this.ckChangeSpecialCharacter.TabIndex = 3;
            this.ckChangeSpecialCharacter.Text = "ChangeSpecialCharacter";
            this.ckChangeSpecialCharacter.UseVisualStyleBackColor = true;
            // 
            // btnDelKeyword
            // 
            this.btnDelKeyword.Location = new System.Drawing.Point(444, 6);
            this.btnDelKeyword.Name = "btnDelKeyword";
            this.btnDelKeyword.Size = new System.Drawing.Size(91, 23);
            this.btnDelKeyword.TabIndex = 4;
            this.btnDelKeyword.Text = "DelKeyword";
            this.btnDelKeyword.UseVisualStyleBackColor = true;
            this.btnDelKeyword.Click += new System.EventHandler(this.btnDelKeyword_Click);
            // 
            // FrmImportKeyword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 431);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmImportKeyword";
            this.Text = "FrmImportKeyword";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinPriority.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnSaveKeywrod;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RichTextBox txtImportKeyword;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit spinPriority;
        private System.Windows.Forms.CheckBox ckChangeSpecialCharacter;
        private System.Windows.Forms.Button btnDelKeyword;
    }
}