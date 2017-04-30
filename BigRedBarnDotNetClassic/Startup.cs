using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigRedBarnDotNetClassic.Startup))]
namespace BigRedBarnDotNetClassic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
