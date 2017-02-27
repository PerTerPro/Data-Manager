using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WSS.DocumentHelp.Startup))]
namespace WSS.DocumentHelp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
