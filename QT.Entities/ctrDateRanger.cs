using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QT.Entities
{
    public partial class ctrDateRanger : UserControl
    {
        public ctrDateRanger()
        {
            InitializeComponent();
            this.comboBoxEdit1.SelectedIndex = 0;
        }
        public DateTime FromDate
        {
            set { this.dateEdit1.EditValue = value; }
            get
            {
                return new System.DateTime(dateEdit1.DateTime.Year,
                    dateEdit1.DateTime.Month,
                    dateEdit1.DateTime.Day,
                    0, 0, 1);
            }
        }
        public DateTime ToDate
        {
            set { this.dateEdit2.EditValue = value; }
            get
            {
                return new System.DateTime(dateEdit2.DateTime.Year,
                  dateEdit2.DateTime.Month,
                  dateEdit2.DateTime.Day,
                  23, 59, 59);
            }
        }
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxEdit1.SelectedIndex)
            {
                case 0:
                    this.dateEdit1.EditValue = DateTime.Now;
                    this.dateEdit2.EditValue = DateTime.Now;
                    break;
                case 1:
                    this.dateEdit1.EditValue = DateTime.Now.AddDays(-7);
                    this.dateEdit2.EditValue = DateTime.Now.AddDays(0);
                    break;
                case 2:
                    this.dateEdit1.EditValue = DateTime.Now.AddDays(-30);
                    this.dateEdit2.EditValue = DateTime.Now.AddDays(0);
                    break;
            }
        }
    }
}
