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
using log4net;
using Ninject;
using Ninject.Modules;
using Websosanh.Core.Drivers.RabbitMQ;
using Wss.Lib.RabbitMq;
using WSS.Service.Report.ProductOnClick.Error.Model;

namespace WSS.Service.Report.ProductOnClick.Error
{
    public partial class ReportErrorProductOnClick : ServiceBase
    {
        private readonly int _workerCount = 0;
        private readonly ILog _log = LogManager.GetLogger(typeof(ReportErrorProductOnClick));
        private readonly ISettingRepository _settingRepository;
        private readonly IKernel _kerner;
        private List<ConsumerBasic<MsProduct>> lstConsumerBasics=new List<ConsumerBasic<MsProduct>>();

        public ReportErrorProductOnClick()
        {
            InitializeComponent();
            _kerner = new StandardKernel(new MappingNinject());
            _settingRepository = _kerner.Get<ISettingRepository>();
            _workerCount = _settingRepository.WorkerCount;
        }

        protected override void OnStart(string[] args)
        {
            for (int i = 0; i < _workerCount; i++)
            {
                var workerTask = new Task(() =>
                {
                    IHandlerClick handler = _kerner.Get<IHandlerClick>();
                    ConsumerBasic<MsProduct> consumer = new ConsumerBasic<MsProduct>(RabbitMQManager.GetRabbitMQServer("rabbitMQ177_OnClick"), _settingRepository.QueueProductClick);
                    consumer._eventProcessJob += (job) =>
                    {
                        handler.Process(job);
                    };
                    lstConsumerBasics.Add(consumer);
                    consumer.StartConsume();
                });
                workerTask.Start();
                _log.InfoFormat("Worker {0} started", i);
            }
        }

        protected override void OnStop()
        {
            foreach (var variable in lstConsumerBasics)
            {
                try
                {
                    variable.Stop();
                }
                catch (Exception ex01)
                {
                    _log.Error(ex01);
                }
            }
        }
    }
}
