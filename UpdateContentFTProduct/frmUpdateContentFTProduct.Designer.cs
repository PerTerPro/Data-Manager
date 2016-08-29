namespace UpdateContentFTProduct
{
    partial class frmUpdateContentFTProduct
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
            this.UpdateContentFTButton = new DevExpress.XtraEditors.SimpleButton();
            this.dB = new UpdateContentFTProduct.DB();
            this.listClassificationBindingSource = new System.Windows.Forms.BindingSource();
            this.listClassificationTableAdapter = new UpdateContentFTProduct.DBTableAdapters.ListClassificationTableAdapter();
            this.tableAdapterManager = new UpdateContentFTProduct.DBTableAdapters.TableAdapterManager();
            this.productTableAdapter = new UpdateContentFTProduct.DBTableAdapters.ProductTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateContentFTButton
            // 
            this.UpdateContentFTButton.Location = new System.Drawing.Point(79, 26);
            this.UpdateContentFTButton.Name = "UpdateContentFTButton";
            this.UpdateContentFTButton.Size = new System.Drawing.Size(135, 41);
            this.UpdateContentFTButton.TabIndex = 0;
            this.UpdateContentFTButton.Text = "Update ContentFT";
            this.UpdateContentFTButton.Click += new System.EventHandler(this.UpdateContentFTButton_Click);
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listClassificationBindingSource
            // 
            this.listClassificationBindingSource.DataMember = "ListClassification";
            this.listClassificationBindingSource.DataSource = this.dB;
            // 
            // listClassificationTableAdapter
            // 
            this.listClassificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ListClassificationTableAdapter = this.listClassificationTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = UpdateContentFTProduct.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dB;
            // 
            // frmUpdateContentFTProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 77);
            this.Controls.Add(this.UpdateContentFTButton);
            this.Name = "frmUpdateContentFTProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmUpdateContentFTProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClassificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton UpdateContentFTButton;
        private DB dB;
        private System.Windows.Forms.BindingSource listClassificationBindingSource;
        private DBTableAdapters.ListClassificationTableAdapter listClassificationTableAdapter;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private DBTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}

