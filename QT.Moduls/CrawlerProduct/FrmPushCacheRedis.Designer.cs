namespace QT.Moduls.CrawlerProduct
{
    partial class FrmPushCacheRedis
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
            this.btnPushCacheProduct = new System.Windows.Forms.Button();
            this.btnPushClassification = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblPageIDProduct = new System.Windows.Forms.Label();
            this.btnPauseProduct = new System.Windows.Forms.CheckBox();
            this.ckPauseClassification = new System.Windows.Forms.CheckBox();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblCompanyClasification = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPushProductByHash = new System.Windows.Forms.Button();
            this.lblPageHash = new System.Windows.Forms.Label();
            this.btnDelProductError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPushCacheProduct
            // 
            this.btnPushCacheProduct.Location = new System.Drawing.Point(12, 12);
            this.btnPushCacheProduct.Name = "btnPushCacheProduct";
            this.btnPushCacheProduct.Size = new System.Drawing.Size(110, 30);
            this.btnPushCacheProduct.TabIndex = 0;
            this.btnPushCacheProduct.Text = "Product";
            this.btnPushCacheProduct.UseVisualStyleBackColor = true;
            this.btnPushCacheProduct.Click += new System.EventHandler(this.btnPushCacheProduct_Click);
            // 
            // btnPushClassification
            // 
            this.btnPushClassification.Location = new System.Drawing.Point(12, 119);
            this.btnPushClassification.Name = "btnPushClassification";
            this.btnPushClassification.Size = new System.Drawing.Size(110, 31);
            this.btnPushClassification.TabIndex = 1;
            this.btnPushClassification.Text = "Classification";
            this.btnPushClassification.UseVisualStyleBackColor = true;
            this.btnPushClassification.Click += new System.EventHandler(this.btnPushClassification_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(128, 21);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(35, 13);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "label1";
            // 
            // lblPageIDProduct
            // 
            this.lblPageIDProduct.AutoSize = true;
            this.lblPageIDProduct.Location = new System.Drawing.Point(128, 48);
            this.lblPageIDProduct.Name = "lblPageIDProduct";
            this.lblPageIDProduct.Size = new System.Drawing.Size(35, 13);
            this.lblPageIDProduct.TabIndex = 3;
            this.lblPageIDProduct.Text = "label1";
            // 
            // btnPauseProduct
            // 
            this.btnPauseProduct.AutoSize = true;
            this.btnPauseProduct.Location = new System.Drawing.Point(131, 76);
            this.btnPauseProduct.Name = "btnPauseProduct";
            this.btnPauseProduct.Size = new System.Drawing.Size(56, 17);
            this.btnPauseProduct.TabIndex = 4;
            this.btnPauseProduct.Text = "Pause";
            this.btnPauseProduct.UseVisualStyleBackColor = true;
            // 
            // ckPauseClassification
            // 
            this.ckPauseClassification.AutoSize = true;
            this.ckPauseClassification.Location = new System.Drawing.Point(131, 183);
            this.ckPauseClassification.Name = "ckPauseClassification";
            this.ckPauseClassification.Size = new System.Drawing.Size(56, 17);
            this.ckPauseClassification.TabIndex = 7;
            this.ckPauseClassification.Text = "Pause";
            this.ckPauseClassification.UseVisualStyleBackColor = true;
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Location = new System.Drawing.Point(128, 155);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(35, 13);
            this.lblClassification.TabIndex = 6;
            this.lblClassification.Text = "label1";
            // 
            // lblCompanyClasification
            // 
            this.lblCompanyClasification.AutoSize = true;
            this.lblCompanyClasification.Location = new System.Drawing.Point(128, 128);
            this.lblCompanyClasification.Name = "lblCompanyClasification";
            this.lblCompanyClasification.Size = new System.Drawing.Size(35, 13);
            this.lblCompanyClasification.TabIndex = 5;
            this.lblCompanyClasification.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // btnPushProductByHash
            // 
            this.btnPushProductByHash.Location = new System.Drawing.Point(243, 11);
            this.btnPushProductByHash.Name = "btnPushProductByHash";
            this.btnPushProductByHash.Size = new System.Drawing.Size(110, 31);
            this.btnPushProductByHash.TabIndex = 8;
            this.btnPushProductByHash.Text = "ProductHash";
            this.btnPushProductByHash.UseVisualStyleBackColor = true;
            this.btnPushProductByHash.Click += new System.EventHandler(this.btnPushProductByHash_Click);
            // 
            // lblPageHash
            // 
            this.lblPageHash.AutoSize = true;
            this.lblPageHash.Location = new System.Drawing.Point(359, 45);
            this.lblPageHash.Name = "lblPageHash";
            this.lblPageHash.Size = new System.Drawing.Size(35, 13);
            this.lblPageHash.TabIndex = 10;
            this.lblPageHash.Text = "label2";
            // 
            // btnDelProductError
            // 
            this.btnDelProductError.Location = new System.Drawing.Point(243, 110);
            this.btnDelProductError.Name = "btnDelProductError";
            this.btnDelProductError.Size = new System.Drawing.Size(110, 31);
            this.btnDelProductError.TabIndex = 11;
            this.btnDelProductError.Text = "Xóa Product lỗi";
            this.btnDelProductError.UseVisualStyleBackColor = true;
            this.btnDelProductError.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPushCacheRedis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 207);
            this.Controls.Add(this.btnDelProductError);
            this.Controls.Add(this.lblPageHash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPushProductByHash);
            this.Controls.Add(this.ckPauseClassification);
            this.Controls.Add(this.lblClassification);
            this.Controls.Add(this.lblCompanyClasification);
            this.Controls.Add(this.btnPauseProduct);
            this.Controls.Add(this.lblPageIDProduct);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.btnPushClassification);
            this.Controls.Add(this.btnPushCacheProduct);
            this.Name = "FrmPushCacheRedis";
            this.Text = "FrmPushCacheRedis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPushCacheRedis_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPushCacheProduct;
        private System.Windows.Forms.Button btnPushClassification;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblPageIDProduct;
        private System.Windows.Forms.CheckBox btnPauseProduct;
        private System.Windows.Forms.CheckBox ckPauseClassification;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.Label lblCompanyClasification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPushProductByHash;
        private System.Windows.Forms.Label lblPageHash;
        private System.Windows.Forms.Button btnDelProductError;
    }
}