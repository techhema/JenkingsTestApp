using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkingsTestApp.Startup))]
namespace JenkingsTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
