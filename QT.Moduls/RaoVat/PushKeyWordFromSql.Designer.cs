namespace QT.Moduls.RaoVat
{
    partial class FrmPushKeyWordFroSql
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
            this.label1 = new System.Windows.Forms.Label();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.btnTransferKeyWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TuKhoa";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(93, 12);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(100, 20);
            this.spinEdit1.TabIndex = 2;
            // 
            // btnTransferKeyWord
            // 
            this.btnTransferKeyWord.Location = new System.Drawing.Point(400, 12);
            this.btnTransferKeyWord.Name = "btnTransferKeyWord";
            this.btnTransferKeyWord.Size = new System.Drawing.Size(124, 23);
            this.btnTransferKeyWord.TabIndex = 3;
            this.btnTransferKeyWord.Text = "Chuyen Tu Khoa";
            this.btnTransferKeyWord.UseVisualStyleBackColor = true;
            this.btnTransferKeyWord.Click += new System.EventHandler(this.btnTransferKeyWord_Click);
            // 
            // FrmPushKeyWordFroSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 345);
            this.Controls.Add(this.btnTransferKeyWord);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmPushKeyWordFroSql";
            this.Text = "PushKeyWordFromSql";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PushKeyWordFromSql_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private System.Windows.Forms.Button btnTransferKeyWord;
    }
}