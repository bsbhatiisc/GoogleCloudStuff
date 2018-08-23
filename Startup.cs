using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryAppGCP.Startup))]
namespace LibraryAppGCP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
