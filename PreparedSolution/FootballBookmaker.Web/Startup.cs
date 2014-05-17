using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballBookmaker.Web.Startup))]
namespace FootballBookmaker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
