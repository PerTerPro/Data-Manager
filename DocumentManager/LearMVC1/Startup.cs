using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearMVC1.Startup))]
namespace LearMVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
