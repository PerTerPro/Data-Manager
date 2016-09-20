using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using Websosanh.Core.Drivers.RabbitMQ;

namespace WSS.Crawler.Product.Report
{
    public partial class FrmTrackRunning : Form
    {
        private BindingList<ReportSessionRunning> lstSessionRunnings = new BindingList<ReportSessionRunning>();
        private  CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private bool _stopRun;

        public FrmTrackRunning()
        {
            InitializeComponent();
            this.gridControl1.DataSource = lstSessionRunnings;
            this.gridView1.CustomDrawGroupRow += new RowObjectCustomDrawEventHandler(EventGroup);
        }


        private void EventGroup(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if (info.Column.Caption == string.Empty)
                caption = info.Column.ToString();
            info.GroupText = string.Format("{0} : {1} (count= {2})", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
        }

        private void FrmTrackRunning_Load(object sender, EventArgs e)
        {
            var token = _cancellationTokenSource.Token;
            Task.Factory.StartNew(() =>
            {
                try
                {
                    while (true)
                    {
                        if (!_stopRun)
                        {
                            token.ThrowIfCancellationRequested();
                            var rabbitMq = RabbitMQManager.GetRabbitMQServer(ConfigRun.KeyRabbitMqCrawler);
                            var channel = rabbitMq.CreateChannel();
                            var job = channel.BasicGet("SeesionRunning.TrackRunning", true);
                            if (job == null)
                            {
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                ReportSessionRunning jobData = ReportSessionRunning.GetFromJson(job.Body);
                                this.Invoke(new Action(() =>
                                {
                                    lstSessionRunnings.Add(jobData);
                                }));
                            }
                        }
                        else
                        {
                            Thread.Sleep(5000);
                        }
                    }
                }
                catch (OperationCanceledException ex)
                {
                    return;
                }
                catch (Exception ex1)
                {
                    
                }
            }, token);
        }

        private void btnResetOld_Click(object sender, EventArgs e)
        {
            var d1 = (from d in lstSessionRunnings
                where Math.Abs((d.TimeReport - DateTime.Now).TotalMinutes) > 5
                select d).ToList();
            if (d1.Count > 0)
                foreach (var vari in d1)
                {
                    this.Invoke(new Action(() =>
                    {
                        lstSessionRunnings.Remove(vari);
                    }));
                }
        }

        private void FrmTrackRunning_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        private void ckStop_CheckedChanged(object sender, EventArgs e)
        {
            this._stopRun = ckStop.Checked;
        }
    }
}
