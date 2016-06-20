using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(ResourceServer.Startup))]

namespace ResourceServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //HandlerConfig.RegisterHandlers(GlobalConfiguration.Configuration.MessageHandlers);
        }
    }
}
