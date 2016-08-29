namespace QT.Moduls.CrawlerProduct
{
    partial class FrmPushIsNewProductToChangeImage
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnFixImageLInk = new System.Windows.Forms.Button();
            this.btnPushIsNewAllCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(468, 220);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(486, 10);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(147, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Start";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(12, 10);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(468, 20);
            this.txtCompany.TabIndex = 2;
            // 
            // btnFixImageLInk
            // 
            this.btnFixImageLInk.Location = new System.Drawing.Point(486, 39);
            this.btnFixImageLInk.Name = "btnFixImageLInk";
            this.btnFixImageLInk.Size = new System.Drawing.Size(147, 23);
            this.btnFixImageLInk.TabIndex = 3;
            this.btnFixImageLInk.Text = "FixImageLink";
            this.btnFixImageLInk.UseVisualStyleBackColor = true;
            this.btnFixImageLInk.Click += new System.EventHandler(this.btnFixImageLInk_Click);
            // 
            // btnPushIsNewAllCompany
            // 
            this.btnPushIsNewAllCompany.Location = new System.Drawing.Point(486, 68);
            this.btnPushIsNewAllCompany.Name = "btnPushIsNewAllCompany";
            this.btnPushIsNewAllCompany.Size = new System.Drawing.Size(147, 23);
            this.btnPushIsNewAllCompany.TabIndex = 4;
            this.btnPushIsNewAllCompany.Text = "DownloadAllImage";
            this.btnPushIsNewAllCompany.UseVisualStyleBackColor = true;
            this.btnPushIsNewAllCompany.Click += new System.EventHandler(this.btnPushIsNewAllCompany_Click);
            // 
            // FrmPushIsNewProductToChangeImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 261);
            this.Controls.Add(this.btnPushIsNewAllCompany);
            this.Controls.Add(this.btnFixImageLInk);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FrmPushIsNewProductToChangeImage";
            this.Text = "Sửa thông tin lỗi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnFixImageLInk;
        private System.Windows.Forms.Button btnPushIsNewAllCompany;
    }
}