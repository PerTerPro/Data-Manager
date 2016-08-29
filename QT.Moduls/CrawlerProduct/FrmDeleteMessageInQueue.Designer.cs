namespace QT.Moduls.CrawlerProduct
{
    partial class FrmDeleteMessageInQueue
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
            this.cboQueue = new System.Windows.Forms.ComboBox();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cboQueue
            // 
            this.cboQueue.FormattingEnabled = true;
            this.cboQueue.Items.AddRange(new object[] {
            "CacheCrawlerProduct.Refresh.CheckDuplicate",
            "CacheCrawlerProduct.Refresh.ProductInfo"});
            this.cboQueue.Location = new System.Drawing.Point(12, 12);
            this.cboQueue.Name = "cboQueue";
            this.cboQueue.Size = new System.Drawing.Size(336, 21);
            this.cboQueue.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(354, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete Mess";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmDeleteMessageInQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 45);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cboQueue);
            this.Name = "FrmDeleteMessageInQueue";
            this.Text = "FrmDeleteMessageInQueue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboQueue;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}