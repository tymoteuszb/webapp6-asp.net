using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_lab6.Startup))]
namespace WebApp_lab6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
