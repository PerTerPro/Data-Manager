using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using WSS.Core.Crawler;
using WSS.Core.Crawler.CrlProduct;

namespace WSS.Service.CR.PushCompanyCrawler
{
    public partial class Service1 : ServiceBase
    {
        private bool _bRunning = true;
        private readonly ILog log = LogManager.GetLogger(typeof (Service1));

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                log.Info("Start push");
                while (_bRunning)
                {
                    log.Info("Start push company");
                    ControlCmpCrlw.PushCmp();
                    log.Debug("Wait 10' to next");
                    Thread.Sleep(60000 * 5);
                }
                log.Info("Stop push");
            });
        }

        protected override void OnStop()
        {
            _bRunning = false;
        }
    }
}
