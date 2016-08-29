namespace QT.Moduls.CrawlerReviewFacebook

{
    partial class FrmAnalysicInfoFacebook
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(701, 383);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.richTextBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 120);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(705, 387);
            this.panelControl2.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtRegex);
            this.panelControl1.Controls.Add(this.btnInsert);
            this.panelControl1.Controls.Add(this.txtUrl);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtPass);
            this.panelControl1.Controls.Add(this.txtUser);
            this.panelControl1.Controls.Add(this.textBox1);
            this.panelControl1.Controls.Add(this.btnTest);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(705, 120);
            this.panelControl1.TabIndex = 4;
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(508, 12);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(192, 20);
            this.txtRegex.TabIndex = 9;
            this.txtRegex.Text = "(?:www.)?facebook.com/(?:(?:\\w)*#!/)?(?:pages/)?(?:[?\\w\\-]*/)?(?:profile.php\\?id=" +
    "(\\d.*))?([\\w\\-]*)?";
            this.txtRegex.Visible = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(171, 38);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(153, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Tìm theo url";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(90, 67);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(580, 20);
            this.txtUrl.TabIndex = 7;
            this.txtUrl.Text = "https://www.facebook.com/sieuthididonghungmobile";
            this.txtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(236, 12);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(43, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(152, 20);
            this.txtUser.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-119, -65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(9, 66);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Phân tích dữ liệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnProcessData);
            // 
            // FrmAnalysicInfoFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 507);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmAnalysicInfoFacebook";
            this.Text = "Phân tích Review Facebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAnalysicInfoFacebook_FormClosing);
            this.Load += new System.EventHandler(this.FrmAnalysicInfoFacebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.Button btnInsert;

    }
}

