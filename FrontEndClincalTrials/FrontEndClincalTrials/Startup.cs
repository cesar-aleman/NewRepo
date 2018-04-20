using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrontEndClincalTrials.Startup))]
namespace FrontEndClincalTrials
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
