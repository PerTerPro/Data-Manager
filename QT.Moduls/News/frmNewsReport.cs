using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.News
{
    public partial class frmNewsReport : QT.Entities.frmBase
    {
        public frmNewsReport()
        {
            InitializeComponent();
        }

        private void frmNewsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBNew.NewsReport' table. You can move, or remove it, as needed.
            this.newsReportTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionStringNews;
        }

        private void btViewAll_Click(object sender, EventArgs e)
        {
            this.newsReportTableAdapter.FillBy_DateRange(this.dBNew.NewsReport, this.ctrDateRanger1.FromDate, this.ctrDateRanger1.ToDate);

        }

        private void btExport_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.DefaultExt = "xls";
            this.saveFileDialog1.FileName = string.Format("logNhuanBut_date_{0}-{1}.xls", ctrDateRanger1.FromDate.ToString("dd_MM_yyyy"), ctrDateRanger1.ToDate.ToString("dd_MM_yyyy"));
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                QT.Entities.Wait.Show("Đang export");
                this.gridView1.ExportToXls(saveFileDialog1.FileName);
                QT.Entities.Wait.Close();
            }
        }
    }
}
