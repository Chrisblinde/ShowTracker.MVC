using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShowTrackerMVC.Startup))]
namespace ShowTrackerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
