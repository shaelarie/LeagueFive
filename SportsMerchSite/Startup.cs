using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsMerchSite.Startup))]
namespace SportsMerchSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
