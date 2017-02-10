using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPrac.Startup))]
namespace MVCPrac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
