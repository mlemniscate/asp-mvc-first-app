using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcFirstApp.Startup))]
namespace MvcFirstApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
