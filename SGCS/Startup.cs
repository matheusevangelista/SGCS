using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SGCS.Startup))]
namespace SGCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
