using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdoNetIntegration.Startup))]
namespace AdoNetIntegration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
