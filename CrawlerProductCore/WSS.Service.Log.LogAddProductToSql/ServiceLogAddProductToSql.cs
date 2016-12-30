using log4net;
using Newtonsoft.Json;
using QT.Entities;
using QT.Entities.CrawlerProduct;
using QT.Entities.Data;
using QT.Moduls.CrawlerProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websosanh.Core.Drivers.RabbitMQ;
using WSS.Core.Crawler;


namespace WSS.Service.Log.LogAddProductToSql
{
    public partial class ServiceLogAddProductToSql : ServiceBase
    {
        private log4net.ILog log = log4net.LogManager.GetLogger(typeof (ServiceLogAddProductToSql));



        public ServiceLogAddProductToSql()
        {

        }

        protected override void OnStart(string[] args)
        {
            log.Info("Start service");
            try
            {
                Task.Factory.StartNew(() =>
                {
                    WorkerLogAddProduct w = new WorkerLogAddProduct();
                    w.StartConsume();
                });
              
            }
            catch (Exception ex)
            {
                log.Error("Start error", ex);
                throw;
            }
        }

        protected override void OnStop()
        {

        }
    }
}
