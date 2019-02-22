using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BursUI.Startup))]
namespace BursUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
