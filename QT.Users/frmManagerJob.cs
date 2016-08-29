using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QT.Users
{
    public partial class frmManagerJob : QT.Entities.frmBase
    {
        public frmManagerJob()
        {
            InitializeComponent();
        }

        private void frmManagerJob_Load(object sender, EventArgs e)
        {
            this.userJobTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
            this.dateEdit1.EditValue = DateTime.Now;
            RefreshData();
        }
        public override bool RefreshData()
        {
            DateTime dtime = QT.Entities.Common.ObjectToDataTime(dateEdit1.EditValue);
            this.userJobTableAdapter.FillBy_Date(this.dB.UserJob, dtime.Month, dtime.Year);
            return true;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btPrinter_Click(object sender, EventArgs e)
        {
            DateTime dtime = QT.Entities.Common.ObjectToDataTime(dateEdit1.EditValue);
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "*.xls|*.xlsx";
            f.FileName = string.Format("report_{0}", dtime.ToString("MM_yyyy") + ".xls");
            if (f.ShowDialog() == DialogResult.OK)
            {
                string filename = "";
                filename = f.FileName;
                //this.gridView1.ExportToXlsx(filename);
                this.gridView1.ExportToExcelOld(filename);
            }


            //String file = "C:\\" + dtime.ToString("MM_yyyy") + ".xls";
            
        }
    }
}
