namespace QT.Moduls.Crawler
{
    partial class FrmQuestionAuto
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRunNow = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ thông tự khởi động crawler nếu bạn không dừng lại?";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(65, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRunNow
            // 
            this.btnRunNow.Location = new System.Drawing.Point(146, 66);
            this.btnRunNow.Name = "btnRunNow";
            this.btnRunNow.Size = new System.Drawing.Size(75, 23);
            this.btnRunNow.TabIndex = 3;
            this.btnRunNow.Text = "Run Now";
            this.btnRunNow.UseVisualStyleBackColor = true;
            this.btnRunNow.Click += new System.EventHandler(this.btnRunNow_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(262, 24);
            this.progressBar1.TabIndex = 4;
            // 
            // FrmQuestionAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 93);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnRunNow);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuestionAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuestionAuto";
            this.Load += new System.EventHandler(this.FrmQuestionAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRunNow;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}