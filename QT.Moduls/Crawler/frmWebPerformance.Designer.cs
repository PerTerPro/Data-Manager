namespace QT.Moduls.Crawler
{
    partial class frmWebPerformance
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
            this.btStart = new DevExpress.XtraEditors.SimpleButton();
            this.txtURL = new DevExpress.XtraEditors.TextEdit();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblVisited = new System.Windows.Forms.Label();
            this.laStickFull = new System.Windows.Forms.Label();
            this.laStickNormal = new System.Windows.Forms.Label();
            this.lblIgnored = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUrlCurrent = new System.Windows.Forms.TextBox();
            this.btStop = new DevExpress.XtraEditors.SimpleButton();
            this.chkFind = new System.Windows.Forms.CheckBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNapCache = new System.Windows.Forms.CheckBox();
            this.chkCacheSearch = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(279, 35);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // txtURL
            // 
            this.txtURL.EditValue = "http://websosanh.vn/home.htm";
            this.txtURL.Location = new System.Drawing.Point(9, 37);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(264, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.EditValueChanged += new System.EventHandler(this.txtURL_EditValueChanged);
            // 
            // lblQueue
            // 
            this.lblQueue.BackColor = System.Drawing.Color.PeachPuff;
            this.lblQueue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.Location = new System.Drawing.Point(146, 71);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(44, 19);
            this.lblQueue.TabIndex = 57;
            this.lblQueue.Text = "0";
            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVisited
            // 
            this.lblVisited.BackColor = System.Drawing.Color.PeachPuff;
            this.lblVisited.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVisited.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisited.Location = new System.Drawing.Point(85, 71);
            this.lblVisited.Name = "lblVisited";
            this.lblVisited.Size = new System.Drawing.Size(46, 19);
            this.lblVisited.TabIndex = 56;
            this.lblVisited.Text = "0";
            this.lblVisited.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laStickFull
            // 
            this.laStickFull.BackColor = System.Drawing.Color.PeachPuff;
            this.laStickFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laStickFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laStickFull.Location = new System.Drawing.Point(394, 72);
            this.laStickFull.Name = "laStickFull";
            this.laStickFull.Size = new System.Drawing.Size(37, 19);
            this.laStickFull.TabIndex = 65;
            this.laStickFull.Text = "0";
            this.laStickFull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laStickNormal
            // 
            this.laStickNormal.BackColor = System.Drawing.Color.PeachPuff;
            this.laStickNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laStickNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laStickNormal.Location = new System.Drawing.Point(344, 72);
            this.laStickNormal.Name = "laStickNormal";
            this.laStickNormal.Size = new System.Drawing.Size(37, 19);
            this.laStickNormal.TabIndex = 64;
            this.laStickNormal.Text = "0";
            this.laStickNormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIgnored
            // 
            this.lblIgnored.BackColor = System.Drawing.Color.PeachPuff;
            this.lblIgnored.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIgnored.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgnored.Location = new System.Drawing.Point(290, 71);
            this.lblIgnored.Name = "lblIgnored";
            this.lblIgnored.Size = new System.Drawing.Size(37, 19);
            this.lblIgnored.TabIndex = 63;
            this.lblIgnored.Text = "0";
            this.lblIgnored.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.PeachPuff;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(230, 71);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(50, 19);
            this.lblProduct.TabIndex = 58;
            this.lblProduct.Text = "0";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(9, 69);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(62, 22);
            this.lblTime.TabIndex = 59;
            this.lblTime.Text = "0";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Web";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "F";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "N";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "I";
            // 
            // txtUrlCurrent
            // 
            this.txtUrlCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlCurrent.Location = new System.Drawing.Point(9, 103);
            this.txtUrlCurrent.Name = "txtUrlCurrent";
            this.txtUrlCurrent.Size = new System.Drawing.Size(471, 20);
            this.txtUrlCurrent.TabIndex = 66;
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(360, 35);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 0;
            this.btStop.Text = "Stop";
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // chkFind
            // 
            this.chkFind.AutoSize = true;
            this.chkFind.Location = new System.Drawing.Point(12, 12);
            this.chkFind.Name = "chkFind";
            this.chkFind.Size = new System.Drawing.Size(85, 17);
            this.chkFind.TabIndex = 67;
            this.chkFind.Text = "Tìm web mới";
            this.chkFind.UseVisualStyleBackColor = true;
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(169, 10);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(50, 20);
            this.txtDelay.TabIndex = 66;
            this.txtDelay.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Time Delay";
            // 
            // chkNapCache
            // 
            this.chkNapCache.AutoSize = true;
            this.chkNapCache.Checked = true;
            this.chkNapCache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNapCache.Location = new System.Drawing.Point(248, 12);
            this.chkNapCache.Name = "chkNapCache";
            this.chkNapCache.Size = new System.Drawing.Size(121, 17);
            this.chkNapCache.TabIndex = 67;
            this.chkNapCache.Text = "Nạp cache So sanh";
            this.chkNapCache.UseVisualStyleBackColor = true;
            // 
            // chkCacheSearch
            // 
            this.chkCacheSearch.AutoSize = true;
            this.chkCacheSearch.Location = new System.Drawing.Point(375, 11);
            this.chkCacheSearch.Name = "chkCacheSearch";
            this.chkCacheSearch.Size = new System.Drawing.Size(114, 17);
            this.chkCacheSearch.TabIndex = 67;
            this.chkCacheSearch.Text = "Nạp cache search";
            this.chkCacheSearch.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmWebPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(499, 136);
            this.Controls.Add(this.chkCacheSearch);
            this.Controls.Add(this.chkNapCache);
            this.Controls.Add(this.chkFind);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.txtUrlCurrent);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.lblVisited);
            this.Controls.Add(this.laStickFull);
            this.Controls.Add(this.laStickNormal);
            this.Controls.Add(this.lblIgnored);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Name = "frmWebPerformance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWebPerformance_FormClosing);
            this.Load += new System.EventHandler(this.frmWebPerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btStart;
        private DevExpress.XtraEditors.TextEdit txtURL;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblVisited;
        private System.Windows.Forms.Label laStickFull;
        private System.Windows.Forms.Label laStickNormal;
        private System.Windows.Forms.Label lblIgnored;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrlCurrent;
        private DevExpress.XtraEditors.SimpleButton btStop;
        private System.Windows.Forms.CheckBox chkFind;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNapCache;
        private System.Windows.Forms.CheckBox chkCacheSearch;
        private System.Windows.Forms.Timer timer1;
    }
}
