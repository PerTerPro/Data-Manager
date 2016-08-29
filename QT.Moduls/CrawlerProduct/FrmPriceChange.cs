using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT.Moduls.CrawlerProduct
{
    public partial class FrmPriceChange : Form
    {
        public FrmPriceChange()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RefreshData();
            }
        }

        private void RefreshData()
        {

            this.chartControl1.Series.Clear();
            this.chartControl1.RefreshData();
            List<KeyValuePair<DateTime, long>> LogPrice = RedisPriceLogAdapter.GetMerchantProductPriceLog(Convert.ToInt64(textBox1.Text));
            DevExpress.XtraCharts.Series seriesPrice = new DevExpress.XtraCharts.Series("LogPrice", DevExpress.XtraCharts.ViewType.Line);
            foreach (KeyValuePair<DateTime, long> item in LogPrice)
            {
                seriesPrice.Points.Add(new DevExpress.XtraCharts.SeriesPoint(item.Key, item.Value));
            }
            this.chartControl1.Series.Add(seriesPrice);
            this.chartControl1.RefreshData();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
