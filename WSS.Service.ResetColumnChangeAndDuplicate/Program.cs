﻿using QT.Entities.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.Service.ResetColumnChangeAndDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new ServiceResetColumnChangeAndDuplicate() 
            };
            ServiceBase.Run(ServicesToRun);
        }


    }
}
