namespace WSS.MerchantRankByWebsosanh
{
    partial class frmMerchantRankByWebsosanh
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dBScore = new WSS.MerchantRankByWebsosanh.DBScore();
            this.merchantScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.merchantScoreTableAdapter = new WSS.MerchantRankByWebsosanh.DBScoreTableAdapters.MerchantScoreTableAdapter();
            this.colMerchantId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreNumberProduct1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreStore1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreTraffic1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreAdvertisementPR1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreScandal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreAddressStore2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScorePhoneNumberAvaiable2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreCustomerServices2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreProductInformation3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreWebsosanhRate3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreGoogleRate3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreRateWebsite3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreStatusProduct4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreSignContract5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreResignContract5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScorePotential5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScoreSales5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPart1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPart2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPart3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPart5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantScoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1679, 82);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 82);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1679, 672);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.merchantScoreBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1675, 668);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMerchantId,
            this.colScoreNumberProduct1,
            this.colScoreStore1,
            this.colScoreTraffic1,
            this.colScoreAdvertisementPR1,
            this.colScoreScandal1,
            this.colScoreAddressStore2,
            this.colScorePhoneNumberAvaiable2,
            this.colScoreCustomerServices2,
            this.colScoreProductInformation3,
            this.colScoreWebsosanhRate3,
            this.colScoreGoogleRate3,
            this.colScoreRateWebsite3,
            this.colScoreStatusProduct4,
            this.colScoreSignContract5,
            this.colScoreResignContract5,
            this.colScorePotential5,
            this.colScoreSales5,
            this.colWebsite,
            this.colTotalPart1,
            this.colTotalPart2,
            this.colTotalPart3,
            this.colTotalPart5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // dBScore
            // 
            this.dBScore.DataSetName = "DBScore";
            this.dBScore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // merchantScoreBindingSource
            // 
            this.merchantScoreBindingSource.DataMember = "MerchantScore";
            this.merchantScoreBindingSource.DataSource = this.dBScore;
            // 
            // merchantScoreTableAdapter
            // 
            this.merchantScoreTableAdapter.ClearBeforeFill = true;
            // 
            // colMerchantId
            // 
            this.colMerchantId.FieldName = "MerchantId";
            this.colMerchantId.Name = "colMerchantId";
            this.colMerchantId.Visible = true;
            this.colMerchantId.VisibleIndex = 0;
            this.colMerchantId.Width = 72;
            // 
            // colScoreNumberProduct1
            // 
            this.colScoreNumberProduct1.Caption = "Số lượng SP";
            this.colScoreNumberProduct1.FieldName = "ScoreNumberProduct1";
            this.colScoreNumberProduct1.Name = "colScoreNumberProduct1";
            this.colScoreNumberProduct1.Visible = true;
            this.colScoreNumberProduct1.VisibleIndex = 2;
            this.colScoreNumberProduct1.Width = 78;
            // 
            // colScoreStore1
            // 
            this.colScoreStore1.Caption = "Cửa hàng";
            this.colScoreStore1.FieldName = "ScoreStore1";
            this.colScoreStore1.Name = "colScoreStore1";
            this.colScoreStore1.Visible = true;
            this.colScoreStore1.VisibleIndex = 3;
            this.colScoreStore1.Width = 60;
            // 
            // colScoreTraffic1
            // 
            this.colScoreTraffic1.Caption = "Traffic";
            this.colScoreTraffic1.FieldName = "ScoreTraffic1";
            this.colScoreTraffic1.Name = "colScoreTraffic1";
            this.colScoreTraffic1.Visible = true;
            this.colScoreTraffic1.VisibleIndex = 4;
            this.colScoreTraffic1.Width = 41;
            // 
            // colScoreAdvertisementPR1
            // 
            this.colScoreAdvertisementPR1.Caption = "QuảngcáoPR";
            this.colScoreAdvertisementPR1.FieldName = "ScoreAdvertisementPR1";
            this.colScoreAdvertisementPR1.Name = "colScoreAdvertisementPR1";
            this.colScoreAdvertisementPR1.Visible = true;
            this.colScoreAdvertisementPR1.VisibleIndex = 5;
            this.colScoreAdvertisementPR1.Width = 78;
            // 
            // colScoreScandal1
            // 
            this.colScoreScandal1.Caption = "Scandal";
            this.colScoreScandal1.FieldName = "ScoreScandal1";
            this.colScoreScandal1.Name = "colScoreScandal1";
            this.colScoreScandal1.Visible = true;
            this.colScoreScandal1.VisibleIndex = 6;
            this.colScoreScandal1.Width = 51;
            // 
            // colScoreAddressStore2
            // 
            this.colScoreAddressStore2.Caption = "Địa chỉ rõ ràng";
            this.colScoreAddressStore2.FieldName = "ScoreAddressStore2";
            this.colScoreAddressStore2.Name = "colScoreAddressStore2";
            this.colScoreAddressStore2.Visible = true;
            this.colScoreAddressStore2.VisibleIndex = 8;
            this.colScoreAddressStore2.Width = 83;
            // 
            // colScorePhoneNumberAvaiable2
            // 
            this.colScorePhoneNumberAvaiable2.Caption = "Điện thoại hoạt động";
            this.colScorePhoneNumberAvaiable2.FieldName = "ScorePhoneNumberAvaiable2";
            this.colScorePhoneNumberAvaiable2.Name = "colScorePhoneNumberAvaiable2";
            this.colScorePhoneNumberAvaiable2.Visible = true;
            this.colScorePhoneNumberAvaiable2.VisibleIndex = 9;
            this.colScorePhoneNumberAvaiable2.Width = 114;
            // 
            // colScoreCustomerServices2
            // 
            this.colScoreCustomerServices2.Caption = "Tư vấn KH";
            this.colScoreCustomerServices2.FieldName = "ScoreCustomerServices2";
            this.colScoreCustomerServices2.Name = "colScoreCustomerServices2";
            this.colScoreCustomerServices2.Visible = true;
            this.colScoreCustomerServices2.VisibleIndex = 10;
            this.colScoreCustomerServices2.Width = 62;
            // 
            // colScoreProductInformation3
            // 
            this.colScoreProductInformation3.Caption = "Thông tin SP";
            this.colScoreProductInformation3.FieldName = "ScoreProductInformation3";
            this.colScoreProductInformation3.Name = "colScoreProductInformation3";
            this.colScoreProductInformation3.Visible = true;
            this.colScoreProductInformation3.VisibleIndex = 12;
            this.colScoreProductInformation3.Width = 69;
            // 
            // colScoreWebsosanhRate3
            // 
            this.colScoreWebsosanhRate3.Caption = "WSS đánh giá";
            this.colScoreWebsosanhRate3.FieldName = "ScoreWebsosanhRate3";
            this.colScoreWebsosanhRate3.Name = "colScoreWebsosanhRate3";
            this.colScoreWebsosanhRate3.Visible = true;
            this.colScoreWebsosanhRate3.VisibleIndex = 13;
            this.colScoreWebsosanhRate3.Width = 78;
            // 
            // colScoreGoogleRate3
            // 
            this.colScoreGoogleRate3.Caption = "Google đánh giá";
            this.colScoreGoogleRate3.FieldName = "ScoreGoogleRate3";
            this.colScoreGoogleRate3.Name = "colScoreGoogleRate3";
            this.colScoreGoogleRate3.Visible = true;
            this.colScoreGoogleRate3.VisibleIndex = 14;
            this.colScoreGoogleRate3.Width = 90;
            // 
            // colScoreRateWebsite3
            // 
            this.colScoreRateWebsite3.Caption = "Đánh giá Web";
            this.colScoreRateWebsite3.FieldName = "ScoreRateWebsite3";
            this.colScoreRateWebsite3.Name = "colScoreRateWebsite3";
            this.colScoreRateWebsite3.Visible = true;
            this.colScoreRateWebsite3.VisibleIndex = 15;
            this.colScoreRateWebsite3.Width = 85;
            // 
            // colScoreStatusProduct4
            // 
            this.colScoreStatusProduct4.Caption = "Điểm tình trạng SP (P4)";
            this.colScoreStatusProduct4.FieldName = "ScoreStatusProduct4";
            this.colScoreStatusProduct4.Name = "colScoreStatusProduct4";
            this.colScoreStatusProduct4.Visible = true;
            this.colScoreStatusProduct4.VisibleIndex = 17;
            this.colScoreStatusProduct4.Width = 120;
            // 
            // colScoreSignContract5
            // 
            this.colScoreSignContract5.Caption = "Kí HD";
            this.colScoreSignContract5.FieldName = "ScoreSignContract5";
            this.colScoreSignContract5.Name = "colScoreSignContract5";
            this.colScoreSignContract5.Visible = true;
            this.colScoreSignContract5.VisibleIndex = 18;
            this.colScoreSignContract5.Width = 39;
            // 
            // colScoreResignContract5
            // 
            this.colScoreResignContract5.Caption = "Tái kí HĐ";
            this.colScoreResignContract5.FieldName = "ScoreResignContract5";
            this.colScoreResignContract5.Name = "colScoreResignContract5";
            this.colScoreResignContract5.Visible = true;
            this.colScoreResignContract5.VisibleIndex = 19;
            this.colScoreResignContract5.Width = 52;
            // 
            // colScorePotential5
            // 
            this.colScorePotential5.Caption = "Tiềm năng";
            this.colScorePotential5.FieldName = "ScorePotential5";
            this.colScorePotential5.Name = "colScorePotential5";
            this.colScorePotential5.Visible = true;
            this.colScorePotential5.VisibleIndex = 20;
            this.colScorePotential5.Width = 61;
            // 
            // colScoreSales5
            // 
            this.colScoreSales5.Caption = "Doanh số";
            this.colScoreSales5.FieldName = "ScoreSales5";
            this.colScoreSales5.Name = "colScoreSales5";
            this.colScoreSales5.Visible = true;
            this.colScoreSales5.VisibleIndex = 21;
            this.colScoreSales5.Width = 55;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.OptionsColumn.ReadOnly = true;
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 1;
            this.colWebsite.Width = 72;
            // 
            // colTotalPart1
            // 
            this.colTotalPart1.Caption = "Tổng phần 1";
            this.colTotalPart1.FieldName = "TotalPart1";
            this.colTotalPart1.Name = "colTotalPart1";
            this.colTotalPart1.Visible = true;
            this.colTotalPart1.VisibleIndex = 7;
            this.colTotalPart1.Width = 78;
            // 
            // colTotalPart2
            // 
            this.colTotalPart2.Caption = "Tổng phần 2";
            this.colTotalPart2.FieldName = "TotalPart2";
            this.colTotalPart2.Name = "colTotalPart2";
            this.colTotalPart2.Visible = true;
            this.colTotalPart2.VisibleIndex = 11;
            this.colTotalPart2.Width = 68;
            // 
            // colTotalPart3
            // 
            this.colTotalPart3.Caption = "Tổng phần 3";
            this.colTotalPart3.FieldName = "TotalPart3";
            this.colTotalPart3.Name = "colTotalPart3";
            this.colTotalPart3.Visible = true;
            this.colTotalPart3.VisibleIndex = 16;
            this.colTotalPart3.Width = 74;
            // 
            // colTotalPart5
            // 
            this.colTotalPart5.Caption = "Tổng phần 5";
            this.colTotalPart5.FieldName = "TotalPart5";
            this.colTotalPart5.Name = "colTotalPart5";
            this.colTotalPart5.Visible = true;
            this.colTotalPart5.VisibleIndex = 22;
            this.colTotalPart5.Width = 77;
            // 
            // frmMerchantRankByWebsosanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 754);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmMerchantRankByWebsosanh";
            this.Load += new System.EventHandler(this.frmMerchantRankByWebsosanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantScoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DBScore dBScore;
        private System.Windows.Forms.BindingSource merchantScoreBindingSource;
        private DBScoreTableAdapters.MerchantScoreTableAdapter merchantScoreTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMerchantId;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreNumberProduct1;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreStore1;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreTraffic1;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreAdvertisementPR1;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreScandal1;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreAddressStore2;
        private DevExpress.XtraGrid.Columns.GridColumn colScorePhoneNumberAvaiable2;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreCustomerServices2;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreProductInformation3;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreWebsosanhRate3;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreGoogleRate3;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreRateWebsite3;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreStatusProduct4;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreSignContract5;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreResignContract5;
        private DevExpress.XtraGrid.Columns.GridColumn colScorePotential5;
        private DevExpress.XtraGrid.Columns.GridColumn colScoreSales5;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPart1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPart2;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPart3;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPart5;
    }
}

