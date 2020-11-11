using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RescuRect.Startup))]
namespace RescuRect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
