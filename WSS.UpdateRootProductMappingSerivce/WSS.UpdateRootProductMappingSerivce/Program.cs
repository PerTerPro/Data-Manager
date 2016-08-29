using System.ServiceProcess;

namespace WSS.UpdateRootProductMappingService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new UpdateRootProductMappingService() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
