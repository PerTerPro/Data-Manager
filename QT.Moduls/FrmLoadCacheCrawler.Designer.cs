namespace QT.Moduls
{
    partial class FrmLoadCacheCrawler
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
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtQuery = new System.Windows.Forms.RichTextBox();
            this.tableAdapterManager1 = new QT.Users.DBCustomerTableAdapters.TableAdapterManager();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 270);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 29);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 270);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 29);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(236, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(390, 252);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(1, 12);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(229, 252);
            this.txtQuery.TabIndex = 3;
            this.txtQuery.Text = "  select top 1 id, name, DetailUrl\n  from product\n";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QT.Users.DBCustomerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserPersonTableAdapter = null;
            this.tableAdapterManager1.UserPersonTypeTableAdapter = null;
            this.tableAdapterManager1.WebUserTableAdapter = null;
            // 
            // FrmLoadCacheCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 302);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmLoadCacheCrawler";
            this.Text = "FrmLoadCacheCrawler";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Users.DBCustomerTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.RichTextBox txtQuery;
    }
}