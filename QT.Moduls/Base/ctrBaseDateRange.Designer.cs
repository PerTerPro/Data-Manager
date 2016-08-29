namespace QT.Moduls.Base
{
    partial class ctrBaseDateRange
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.dtTo = new DevExpress.XtraEditors.LabelControl();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboDateRange = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDateRange.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTo
            // 
            this.dateTo.EditValue = null;
            this.dateTo.Location = new System.Drawing.Point(442, 5);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateTo.Size = new System.Drawing.Size(100, 20);
            this.dateTo.TabIndex = 5;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(418, 9);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(18, 13);
            this.dtTo.TabIndex = 4;
            this.dtTo.Text = "đến";
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = null;
            this.dateFrom.Location = new System.Drawing.Point(304, 5);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateFrom.Size = new System.Drawing.Size(100, 20);
            this.dateFrom.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(236, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Thời gian từ";
            // 
            // cboDateRange
            // 
            this.cboDateRange.Location = new System.Drawing.Point(96, 5);
            this.cboDateRange.Name = "cboDateRange";
            this.cboDateRange.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDateRange.Properties.Items.AddRange(new object[] {
            "Hôm nay",
            "Hôm qua",
            "7 ngày gần nhất",
            "30 ngày gần nhất",
            "Trong tháng này",
            "Tháng trước",
            "Từ đầu năm"});
            this.cboDateRange.Size = new System.Drawing.Size(134, 20);
            this.cboDateRange.TabIndex = 7;
            this.cboDateRange.SelectedIndexChanged += new System.EventHandler(this.cboDateRange_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Khoảng thời gian";
            // 
            // ctrBaseDateRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboDateRange);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Name = "ctrBaseDateRange";
            this.Size = new System.Drawing.Size(553, 31);
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDateRange.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateTo;
        private DevExpress.XtraEditors.LabelControl dtTo;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboDateRange;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
