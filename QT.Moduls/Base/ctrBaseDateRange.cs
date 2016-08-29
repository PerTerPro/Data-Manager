using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QT.Moduls.Base
{
    public partial class ctrBaseDateRange : UserControl
    {
        public ctrBaseDateRange()
        {
            InitializeComponent();
            cboDateRange.SelectedIndex = 1;
            cboDateRange.SelectedIndex = 0;
        }

        //Hôm nay
        //Hôm qua
        //7 ngày gần nhất
        //30 ngày gần nhất
        //Trong tháng này
        //Tháng trước
        //Từ đầu năm

        private void cboDateRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            switch (cboDateRange.SelectedIndex)
            {
                case 0:
                    dateFrom.EditValue = new DateTime(now.Year, now.Month, now.Day, 0, 0, 1);
                    dateTo.EditValue = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);
                    break;
                case 1:
                    DateTime yesterday = DateTime.Now.AddDays(-1);
                    dateFrom.EditValue = new DateTime(yesterday.Year, yesterday.Month, yesterday.Day, 0, 0, 1);
                    dateTo.EditValue = new DateTime(yesterday.Year, yesterday.Month, yesterday.Day, 23, 59, 59);
                    break;
                case 2:
                    DateTime bayday = DateTime.Now.AddDays(-7);
                    dateFrom.EditValue = new DateTime(bayday.Year, bayday.Month, bayday.Day, 0, 0, 1);
                    dateTo.EditValue = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);
                    break;
                case 3:
                    DateTime bamuoiday = DateTime.Now.AddDays(-30);
                    dateFrom.EditValue = new DateTime(bamuoiday.Year, bamuoiday.Month, bamuoiday.Day, 0, 0, 1);
                    dateTo.EditValue = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);
                    break;
                case 4:
                    //trong tháng
                    dateFrom.EditValue = new DateTime(now.Year, now.Month, 1, 0, 0, 1);
                    dateTo.EditValue = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);
                    break;
                case 5:
                    //trong tháng trước
                    DateTime thangtruoc = now.AddMonths(-1);
                    DateTime dauthang = new DateTime(now.Year, now.Month, 1, 0, 0, 1);
                    DateTime cuoithangtruoc = dauthang.AddDays(-1);
                    dateFrom.EditValue = new DateTime(thangtruoc.Year, thangtruoc.Month, 1, 0, 0, 1);
                    dateTo.EditValue = new DateTime(cuoithangtruoc.Year, cuoithangtruoc.Month, cuoithangtruoc.Day, 23, 59, 59);
                    break;
            }
        }

        public DateTime FromDate {
            set
            {
                dateFrom.EditValue = value;
            }
            get {
                DateTime dtfrom = dateFrom.DateTime;
                return new DateTime(dtfrom.Year, dtfrom.Month, dtfrom.Day, 0, 0, 0);
            }
            
        }
        public DateTime ToDate
        {
            set
            {
                dateTo.EditValue = value;
            }
            get
            {
                DateTime dtfrom = dateTo.DateTime;
                return new DateTime(dtfrom.Year, dtfrom.Month, dtfrom.Day, 23, 59, 59);
            }

        }
    }
}
