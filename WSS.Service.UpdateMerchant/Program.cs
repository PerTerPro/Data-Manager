using System.ServiceProcess;

namespace WSS.Service.UpdateMerchant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var servicesToRun = new ServiceBase[] 
            { 
                new UpdateMerchantService() 
            };
            ServiceBase.Run(servicesToRun);
        }
    }
}
