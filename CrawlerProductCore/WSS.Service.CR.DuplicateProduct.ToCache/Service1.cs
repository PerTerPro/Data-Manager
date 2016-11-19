﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using log4net;
using WSS.Core.Crawler;

namespace WSS.Service.CR.DuplicateProduct.ToCache
{
    public partial class Service1 : ServiceBase
    {
        private ILog _log = LogManager.GetLogger(typeof(Service1));
        private ConsumerDuplicateToCache _consumer;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                _consumer = new ConsumerDuplicateToCache();
                _consumer.StartConsume();
            });
        }

        protected override void OnStop()
        {
            try
            {
                _consumer.Stop();
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }
    }
}