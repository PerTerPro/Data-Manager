using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WSS.Service.ReportProductAdsScoreError
{
    public partial class ServiceReportProductAdsScoreError : ServiceBase
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ServiceReportProductAdsScoreError));
        WorkerCheckError wk = new WorkerCheckError();
        public ServiceReportProductAdsScoreError()
        {
            InitializeComponent();
            OnStart(new string[] { });
        }

        protected override void OnStart(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                wk.StartConsume();
            });
        }

        protected override void OnStop()
        {
            wk.Stop();
        }
    }
}
