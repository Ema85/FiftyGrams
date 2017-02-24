using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoulouWebApp.Startup))]
namespace GoulouWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
