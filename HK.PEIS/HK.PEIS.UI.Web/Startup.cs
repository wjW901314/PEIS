using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HK.PEIS.UI.Web.Startup))]
namespace HK.PEIS.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
