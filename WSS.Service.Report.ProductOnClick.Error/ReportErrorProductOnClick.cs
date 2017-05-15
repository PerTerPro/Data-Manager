using QT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WSS.Service.Report.ProductOnClick.Error.Worker;

namespace WSS.Service.Report.ProductOnClick.Error
{
    public partial class ReportErrorProductOnClick : ServiceBase
    {
        int WorkerCount = Common.Obj2Int(ConfigurationManager.AppSettings["WorkerCount"]); 
        public ReportErrorProductOnClick()
        {
            InitializeComponent();
            //OnStart(new string[] { });
        }

        protected override void OnStart(string[] args)
        {
            CommonConnection.ConnectionStringSQL = ConfigurationManager.AppSettings["ConnectionString"];
            for (int i = 0; i < WorkerCount; i++)
            {
                var workerTask = new Task(() =>
                {
                    WorkerReportErrorProductOnClick wk = new WorkerReportErrorProductOnClick();
                    wk.StartConsume();
                });
                workerTask.Start();
                //Log.InfoFormat("Worker {0} started", i);
            }
        }

        protected override void OnStop()
        {

        }
    }
}
