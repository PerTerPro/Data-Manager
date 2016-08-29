namespace CustomTest
{
    partial class Form1
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
            this.buttonSendUpdateRootIDJob = new System.Windows.Forms.Button();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSendUpdateRootIDJob
            // 
            this.buttonSendUpdateRootIDJob.Location = new System.Drawing.Point(36, 79);
            this.buttonSendUpdateRootIDJob.Name = "buttonSendUpdateRootIDJob";
            this.buttonSendUpdateRootIDJob.Size = new System.Drawing.Size(75, 23);
            this.buttonSendUpdateRootIDJob.TabIndex = 0;
            this.buttonSendUpdateRootIDJob.Text = "Send Job";
            this.buttonSendUpdateRootIDJob.UseVisualStyleBackColor = true;
            this.buttonSendUpdateRootIDJob.Click += new System.EventHandler(this.buttonSendUpdateRootIDJob_Click);
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(25, 41);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductID.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 261);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.buttonSendUpdateRootIDJob);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSendUpdateRootIDJob;
        private System.Windows.Forms.TextBox textBoxProductID;
    }
}

