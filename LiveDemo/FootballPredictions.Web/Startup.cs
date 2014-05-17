using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballPredictions.Web.Startup))]
namespace FootballPredictions.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
