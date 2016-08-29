namespace QT.Users
{
    partial class frmResetPass
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
            this.txtPassNews = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassNewsRe = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.laPassOld = new System.Windows.Forms.Label();
            this.txtPassOld = new System.Windows.Forms.TextBox();
            this.laUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassNews
            // 
            this.txtPassNews.Location = new System.Drawing.Point(116, 31);
            this.txtPassNews.Name = "txtPassNews";
            this.txtPassNews.PasswordChar = '*';
            this.txtPassNews.Size = new System.Drawing.Size(168, 20);
            this.txtPassNews.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mật khẩu mới";
            // 
            // txtPassNewsRe
            // 
            this.txtPassNewsRe.Location = new System.Drawing.Point(116, 57);
            this.txtPassNewsRe.Name = "txtPassNewsRe";
            this.txtPassNewsRe.PasswordChar = '*';
            this.txtPassNewsRe.Size = new System.Drawing.Size(168, 20);
            this.txtPassNewsRe.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(76, 104);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(159, 104);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // laPassOld
            // 
            this.laPassOld.AutoSize = true;
            this.laPassOld.Location = new System.Drawing.Point(43, 8);
            this.laPassOld.Name = "laPassOld";
            this.laPassOld.Size = new System.Drawing.Size(67, 13);
            this.laPassOld.TabIndex = 10;
            this.laPassOld.Text = "Mật khẩu cũ";
            this.laPassOld.Visible = false;
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(116, 5);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.PasswordChar = '*';
            this.txtPassOld.Size = new System.Drawing.Size(168, 20);
            this.txtPassOld.TabIndex = 0;
            this.txtPassOld.Visible = false;
            // 
            // laUser
            // 
            this.laUser.AutoSize = true;
            this.laUser.Location = new System.Drawing.Point(16, 86);
            this.laUser.Name = "laUser";
            this.laUser.Size = new System.Drawing.Size(29, 13);
            this.laUser.TabIndex = 10;
            this.laUser.Text = "User";
            this.laUser.Visible = false;
            // 
            // frmResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 132);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtPassOld);
            this.Controls.Add(this.txtPassNews);
            this.Controls.Add(this.laUser);
            this.Controls.Add(this.laPassOld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassNewsRe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResetPass";
            this.Load += new System.EventHandler(this.frmResetPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassNews;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassNewsRe;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label laPassOld;
        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.Label laUser;
    }
}