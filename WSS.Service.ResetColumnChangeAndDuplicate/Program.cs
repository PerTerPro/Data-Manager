using System.ServiceProcess;

namespace WSS.Service.ResetCacheAllProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            var servicesToRun = new ServiceBase[] 
            { 
                new ServiceResetColumnChangeAndDuplicate() 
            };
            ServiceBase.Run(servicesToRun);
        }
    }
}
