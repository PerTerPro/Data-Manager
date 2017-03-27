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
using WSS.LibExtra;
using WSS.Service.LogDeleteProductAdsScore.Worker;

namespace WSS.Service.LogDeleteProductAdsScore
{
    public partial class ServiceLogDeleteProductAdsScore : ServiceBase
    {
        private int _workerCount;
        public ServiceLogDeleteProductAdsScore()
        {

            InitializeComponent();
            //OnStart(new string[] { });
        }

        protected override void OnStart(string[] args)
        {
            _workerCount = CommonConvert.Obj2Int(ConfigurationManager.AppSettings["WorkerCount"]);
            for (var i = 0; i < _workerCount; i++)
            {
                var workerTask = new Task(() =>
                {
                    WorkerLog wk = new WorkerLog();
                    wk.StartConsume();
                    Console.ReadLine();
                });
                workerTask.Start();
                
            }
            
        }

        protected override void OnStop()
        {
        }
    }
}
